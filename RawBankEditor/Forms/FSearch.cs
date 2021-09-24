using System;
using System.Windows.Forms;
using ToolsCore.Tools;

namespace RawBankEditor.Forms
{
    public partial class FSearch : Form
    {
        private readonly FMain fmain;

        public FSearch(FMain fmain)
        {
            this.fmain = fmain;
            InitializeComponent();
            FormUtils.SetFormFont(this);
            this.ApplyTheme();
        }

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            Opacity = trackBarOpacity.Value / 100d;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
        }

        private void bStorno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}