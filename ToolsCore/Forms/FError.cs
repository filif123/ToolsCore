using ExControls;
using ToolsCore.Tools;

namespace ToolsCore.Forms;

public partial class FError : Form
{
    private FError(string msg)
    {
        InitializeComponent();
        this.ApplyThemeAndFonts();

        pbIcon.Image = new ShellIcon(ShellIconType.Error,ShellIconSize.Large).ToBitmap();
        rtbMessage.Text = msg;
        rtbMessage.Font = new Font("Consolas", 10);
    }

    private void bOK_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    public static void ShowError(string msg)
    {
        var dialog = new FError(msg);
        dialog.ShowDialog();
    }
}