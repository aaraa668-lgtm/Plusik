using System;
using System.Windows.Forms;
namespace Plusik {
 public partial class MainForm : Form {
  private int userNum = 1, targetNum = 15, steps = 0;
  private bool gameFinished = false;
  private readonly Random random = new Random();
  public MainForm() { InitializeComponent(); UpdateScreen(); }
  private void PlusButton_Click(object s, EventArgs e) { ApplyOperation(userNum + 1); }
  private void MultiplyButton_Click(object s, EventArgs e) {
   if (userNum > int.MaxValue / 2) { MessageBox.Show("Слишком большое число."); return; }
   ApplyOperation(userNum * 2);
  }
  private void ApplyOperation(int value) {
   if (gameFinished) return;
   userNum = value; steps++;
   if (userNum == targetNum) {
    gameFinished = true;
    int optimal = GetOptimalSteps(targetNum);
    statusLabel.Text = steps == optimal ? "Победа! Оптимальное число шагов." : "Победа! Можно было за " + optimal + " шаг(а/ов).";
    plusButton.Enabled = multiplyButton.Enabled = false;
    MessageBox.Show(statusLabel.Text, "Игра окончена");
   } else if (userNum > targetNum) {
    gameFinished = true; statusLabel.Text = "Проигрыш: число превысило цель.";
    plusButton.Enabled = multiplyButton.Enabled = false;
    MessageBox.Show("Число превысило цель. Начни заново.", "Игра окончена");
   } else statusLabel.Text = "Продолжай!";
   UpdateScreen();
  }
  private void ResetButton_Click(object s, EventArgs e) { ResetGame(); }
  private void ResetGame() {
   userNum = 1; steps = 0; gameFinished = false;
   plusButton.Enabled = multiplyButton.Enabled = true;
   statusLabel.Text = "Попробуй получить число.";
   UpdateScreen();
  }
  private void RandomButton_Click(object s, EventArgs e) { targetNum = random.Next(2, 101); ResetGame(); }
  private void SetTargetButton_Click(object s, EventArgs e) {
   using (var d = new TargetDialog(targetNum))
    if (d.ShowDialog(this) == DialogResult.OK) { targetNum = d.TargetNumber; ResetGame(); }
  }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private int GetOptimalSteps(int target) {
   if (target < 1) return 0;
   int[] dp = new int[target + 1];
   for (int i = 2; i <= target; i++) {
    dp[i] = dp[i - 1] + 1;
    if (i % 2 == 0) dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
   }
   return dp[target];
  }
  private void UpdateScreen() {
   currentLabel.Text = "Текущее число: " + userNum;
   targetLabel.Text = "Цель: " + targetNum;
   stepsLabel.Text = "Шаги: " + steps;
   optimalLabel.Text = "Минимум шагов: " + GetOptimalSteps(targetNum);
  }
 }
}
