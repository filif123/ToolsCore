using System.Diagnostics;
using ToolsCore.Tools;

namespace ToolsCore.Forms;

public partial class FAboutApp : Form
{
    public FAboutApp(string appName, string appVersion, string textAbout, Image icon = null)
    {
        InitializeComponent();
        FormUtils.SetFormFont(this);
        this.ApplyTheme();

        lAppName.Text = appName;
        lAppVersion.Text = appVersion;
        lText.Text = textAbout;
        if (icon != null)
            picIcon.Image = icon;
        lAppName.Font = new Font(lAppName.Font, FontStyle.Bold);

        linkWeb.Text = LinkConsts.LINK_INFO_APP;
        linkEmail.Text = LinkConsts.EMAIL;
    }

    private void OnWebLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(LinkConsts.LINK_INFO_APP);

    private void OnEmailLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("mailto:" + LinkConsts.EMAIL);

    private void OnHelpButtonClicked(object sender, CancelEventArgs e) => Process.Start(LinkConsts.LINK_INFO_APP);
}