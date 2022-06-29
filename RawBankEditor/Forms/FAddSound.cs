using ToolsCore.Entities;
using ToolsCore.Tools;

namespace RawBankEditor.Forms;

public partial class FAddSound : Form
{
    public FyzSound NewSound { get; private set; }
    private SoundFileElement File { get; }

    public FAddSound(SoundFileElement file = null)
    {
        InitializeComponent();
        File = file;
    }

    private void BSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbKey.Text) || string.IsNullOrWhiteSpace(tbName.Text))
        {
            Utils.ShowError("Nie sú vyplnené všetky požadované polia.");
            DialogResult = DialogResult.None;
            return;
        }

        NewSound = new FyzSound
        {
            Key = tbKey.Text,
            Name = tbName.Text,
            AdditionalRelativePath = tbRelativePath.Text,
            Text = rtbText.Text
        };

        if (File is not null) 
            File.Sound = NewSound;

        DialogResult = DialogResult.OK;
    }

    private void BStorno_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}