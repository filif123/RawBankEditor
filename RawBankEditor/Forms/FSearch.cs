using ToolsCore.Entities;
using ToolsCore.Tools;

namespace RawBankEditor.Forms;

public partial class FSearch : Form
{
    private bool textChanged;

    private readonly List<(FyzGroup group,int index)> founded = new();
    private int foundIndex;
    private SearchType lastSearchType = SearchType.Key;

    public FSearch()
    {
        InitializeComponent();
        FormUtils.SetFormFont(this);
        this.ApplyTheme();
    }

    private void trackBarOpacity_Scroll(object sender, EventArgs e) => Opacity = trackBarOpacity.Value / 100d;

    private void bSearch_Click(object sender, EventArgs e)
    {
        var searchType = GetSearchType();
        if (!textChanged && lastSearchType == searchType)
        {
            if (foundIndex + 1 == founded.Count) 
                foundIndex = 0;
            else
                foundIndex++;
            SelectRow();
            return;
        }

        lastSearchType = searchType;
        textChanged = false;

        Search();
        if (founded.Count == 0)
        {
            Utils.ShowInfo("Nič sa nenašlo.");
            return;
        }

        foundIndex = 0;
        SelectRow();
    }

    private void bStorno_Click(object sender, EventArgs e) => Close();

    private void TbText_TextChanged(object sender, EventArgs e) => textChanged = true;

    private void Search()
    {
        founded.Clear();

        var ignoreCase = cboxIgnoreCase.Checked;
        foreach (var grp in Program.MainForm.CurrentLanguage.Groups)
        {
            for (var i = 0; i < grp.Sounds.Count; i++)
            {
                switch (lastSearchType)
                {
                    case SearchType.Key:
                        if (tbText.Text.Equals(grp.Sounds[i].Key, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture))
                            founded.Add((grp, i));
                        break;
                    case SearchType.Name:
                        if (tbText.Text.Equals(grp.Sounds[i].Name, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture))
                            founded.Add((grp, i));
                        break;
                    case SearchType.Text:
                        if (tbText.Text.Equals(grp.Sounds[i].Text, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture))
                            founded.Add((grp, i));
                        break;
                    case SearchType.FileName:
                        if (tbText.Text.Equals(grp.Sounds[i].FileName, ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture))
                            founded.Add((grp, i));
                        break;
                }
            }
        }
    }

    private SearchType GetSearchType()
    {
        if (rbKey.Checked)
            return SearchType.Key;
        if (rbName.Checked)
            return SearchType.Name;
        if (rbText.Checked)
            return SearchType.Text;
        return SearchType.FileName;
    }

    private void SelectRow()
    {
        if (founded.Count == 0)
            return;

        Program.MainForm.lboxGroups.SelectedItem = founded[foundIndex].group;
        Program.MainForm.dgvSounds.ClearSelection();
        Program.MainForm.dgvSounds.Rows[founded[foundIndex].index].Selected = true;
    }

    private enum SearchType
    {
        Key,
        Name,
        Text,
        FileName
    }
}