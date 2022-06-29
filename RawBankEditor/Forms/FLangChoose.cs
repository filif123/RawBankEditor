using RawBankEditor.Entities;
using ToolsCore.Entities;
using ToolsCore.Tools;

namespace RawBankEditor.Forms;

public partial class FLangChoose : Form
{
    public FLangChoose()
    {
        InitializeComponent();
        FormUtils.SetFormFont(this);
        this.ApplyTheme();
        cboxLanguages.DataSource = GlobData.OpenedProject.Languages;
    }

    public FyzLanguage Selected { get; private set; }

    private void bOK_Click(object sender, EventArgs e)
    {
        Selected = cboxLanguages.SelectedItem as FyzLanguage;
        DialogResult = DialogResult.OK;
    }
}