using RawBankEditor.Entities;
using ToolsCore.Tools;

namespace RawBankEditor.Forms;

public partial class FEditGroup : Form
{
    public FEditGroup(FyzGroup group = null)
    {
        InitializeComponent();

        if (group == null) Text = "Pridanie skupiny zvukov";

        NewGroup = group;
    }

    public FyzGroup NewGroup { get; private set; }

    private void bOK_Click(object sender, EventArgs e)
    {
        var key = tbKey.Text;
        var name = tbName.Text;
        var relative = tbRelativePath.Text;

        if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(relative))
        {
            Utils.ShowError("Nie sú vyplnené všetky polia.");
            DialogResult = DialogResult.None;
            return;
        }

        foreach (var grp in FMain.CurrentLanguage.Groups)
        {
            if (grp.Key == key)
            {
                Utils.ShowError("Položka s rovnakým kľučom už existuje.");
                DialogResult = DialogResult.None;
                return;
            }

            if (grp.Name == name)
            {
                Utils.ShowError("Položka s rovnakým názvom už existuje.");
                DialogResult = DialogResult.None;
                return;
            }

            if (grp.RelativePath == relative)
            {
                Utils.ShowError("Položka s rovnakou relatívnou cestou už existuje.");
                DialogResult = DialogResult.None;
                return;
            }
        }

        NewGroup = NewGroup == null ? new FyzGroup(FMain.CurrentLanguage, key, name, relative) : new FyzGroup(NewGroup); //TODO

        DialogResult = DialogResult.OK;
    }
}