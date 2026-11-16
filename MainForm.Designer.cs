namespace Plusik {
 partial class MainForm {
  private System.ComponentModel.IContainer components = null;
  private System.Windows.Forms.Label titleLabel, currentLabel, targetLabel, stepsLabel, optimalLabel, statusLabel;
  private System.Windows.Forms.Button plusButton, multiplyButton, resetButton, randomButton, setTargetButton;
  protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
  private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.optimalLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.setTargetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(142, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(224, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Плюсик";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.currentLabel.Location = new System.Drawing.Point(59, 76);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(410, 35);
            this.currentLabel.TabIndex = 1;
            this.currentLabel.Text = "Текущее число: 1";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabel
            // 
            this.targetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetLabel.ForeColor = System.Drawing.Color.Black;
            this.targetLabel.Location = new System.Drawing.Point(211, 130);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(102, 52);
            this.targetLabel.TabIndex = 2;
            this.targetLabel.Text = "Цель: 15";
            this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepsLabel
            // 
            this.stepsLabel.Location = new System.Drawing.Point(12, 297);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(79, 27);
            this.stepsLabel.TabIndex = 3;
            this.stepsLabel.Text = "Шаги: 0";
            // 
            // optimalLabel
            // 
            this.optimalLabel.Location = new System.Drawing.Point(-4, 265);
            this.optimalLabel.Name = "optimalLabel";
            this.optimalLabel.Size = new System.Drawing.Size(140, 32);
            this.optimalLabel.TabIndex = 4;
            this.optimalLabel.Text = "Минимум шагов: 0";
            this.optimalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(97, 310);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(356, 51);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Попробуй получить число.";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.resetButton.Location = new System.Drawing.Point(2, 364);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(125, 38);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Начать сначала";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.randomButton.Location = new System.Drawing.Point(133, 364);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(157, 38);
            this.randomButton.TabIndex = 9;
            this.randomButton.Text = "Случайное число";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // setTargetButton
            // 
            this.setTargetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.setTargetButton.Location = new System.Drawing.Point(301, 364);
            this.setTargetButton.Name = "setTargetButton";
            this.setTargetButton.Size = new System.Drawing.Size(130, 38);
            this.setTargetButton.TabIndex = 10;
            this.setTargetButton.Text = "Задать число";
            this.setTargetButton.UseVisualStyleBackColor = false;
            this.setTargetButton.Click += new System.EventHandler(this.SetTargetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Х2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "+1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Plusik.Properties.Resources.ь;
            this.pictureBox1.Image = global::Plusik.Properties.Resources.ь1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.White;
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.plusButton.Image = global::Plusik.Properties.Resources.Plus_Vector_Icon__Plus_Icons__Red_Cross_Clipart__Cross_Icon_PNG_and_Vector_with_Transparent_Background_for_Free_Download2;
            this.plusButton.Location = new System.Drawing.Point(63, 130);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(97, 102);
            this.plusButton.TabIndex = 5;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Fuchsia;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.multiplyButton.Image = global::Plusik.Properties.Resources.загрузка__6_;
            this.multiplyButton.Location = new System.Drawing.Point(357, 130);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(98, 102);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.optimalLabel);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.setTargetButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плюсик";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

  }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
