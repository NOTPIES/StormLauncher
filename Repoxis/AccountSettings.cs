using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storm
{
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
            if (Convert.ToBoolean(Util.Helper.ReadIni("Themes", "ThemesEnabled")) == true)
            {
                string Theme = Util.Helper.ReadIni("Themes", "Theme");
                if (Theme == "Halloween")
                {
                    guna2GradientButton1.FillColor = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.FillColor2 = Color.FromArgb(255, 192, 128);
                    guna2GradientButton1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                }
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
