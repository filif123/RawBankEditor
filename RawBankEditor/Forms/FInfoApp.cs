using ToolsCore.Tools;

namespace RawBankEditor.Forms;

public partial class FInfoApp : Form
{
    public FInfoApp()
    {
        InitializeComponent();

        FormUtils.SetFormFont(this);
        this.ApplyTheme();

        lAppVersion.Text = Application.ProductVersion;
        lAppName.Text = Application.ProductName;
        lAppName.Font = new Font(lAppName.Font, FontStyle.Bold);

        linkWeb.Text = LinkConsts.LINK_INFO_APP;
        linkEmail.Text = LinkConsts.EMAIL;
    }

    private void linkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(LinkConsts.LINK_INFO_APP);
    }

    private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start("mailto:" + LinkConsts.EMAIL);
    }

    private void FInfoApp_HelpButtonClicked(object sender, CancelEventArgs e)
    {
        Process.Start(LinkConsts.LINK_INFO_APP);
    }
}