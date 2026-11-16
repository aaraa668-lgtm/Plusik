namespace Plusik {
 partial class TargetDialog {
  private System.ComponentModel.IContainer components = null;
  private System.Windows.Forms.Label promptLabel;
  private System.Windows.Forms.NumericUpDown numberNumericUpDown;
  private System.Windows.Forms.Button okButton, cancelButton;
  protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
  private void InitializeComponent() {
   promptLabel = new System.Windows.Forms.Label(); numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
   okButton = new System.Windows.Forms.Button(); cancelButton = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)numberNumericUpDown).BeginInit(); SuspendLayout();
   promptLabel.AutoSize = true; promptLabel.Location = new System.Drawing.Point(18,20); promptLabel.Text = "Введите целевое число:";
   numberNumericUpDown.Location = new System.Drawing.Point(21,48); numberNumericUpDown.Minimum = 2;
   numberNumericUpDown.Maximum = 1000000; numberNumericUpDown.Value = 15; numberNumericUpDown.Size = new System.Drawing.Size(230,23);
   okButton.Location = new System.Drawing.Point(21,90); okButton.Size = new System.Drawing.Size(105,32); okButton.Text = "ОК";
   okButton.Click += new System.EventHandler(OkButton_Click);
   cancelButton.Location = new System.Drawing.Point(146,90); cancelButton.Size = new System.Drawing.Size(105,32);
   cancelButton.Text = "Отмена"; cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
   cancelButton.Click += new System.EventHandler(CancelButton_Click);
   AcceptButton = okButton; CancelButton = cancelButton; ClientSize = new System.Drawing.Size(275,145);
   Controls.AddRange(new System.Windows.Forms.Control[] {promptLabel,numberNumericUpDown,okButton,cancelButton});
   FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;
   StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; Text = "Новая цель";
   ((System.ComponentModel.ISupportInitialize)numberNumericUpDown).EndInit(); ResumeLayout(false); PerformLayout();
  }
 }
}
