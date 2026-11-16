using System;
using System.Windows.Forms;
namespace Plusik {
 public partial class TargetDialog : Form {
  public int TargetNumber { get; private set; }
  public TargetDialog(int current) { InitializeComponent(); numberNumericUpDown.Value = current; }
  private void OkButton_Click(object s, EventArgs e) { TargetNumber = (int)numberNumericUpDown.Value; DialogResult = DialogResult.OK; Close(); }
  private void CancelButton_Click(object s, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
 }
}
