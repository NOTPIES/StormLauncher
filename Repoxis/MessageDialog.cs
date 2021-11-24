using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storm
{
    public partial class MessageDialog : Form
    {
        public MessageDialog()
        {
            InitializeComponent();

            if (Convert.ToBoolean(Util.Helper.ReadIni("Themes", "ThemesEnabled")) == true)
            {
                string Theme = Util.Helper.ReadIni("Themes", "Theme");
                if (Theme == "Halloween")
                {
                    VersionButton1.FillColor = Color.FromArgb(255, 128, 0);
                    VersionButton1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    VersionButton2.FillColor = Color.FromArgb(255, 128, 0);
                    VersionButton2.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    OKButton.FillColor = Color.FromArgb(255, 128, 0);
                    OKButton.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);

                }
            }

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageDialog_Load(object sender, EventArgs e)
        {

        }

        private async void VersionButton1_Click(object sender, EventArgs e) // update
        {
            //await Util.Helper.Update();

            Process.Start("https://discord.gg/dev");
        }

        private void VersionButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
