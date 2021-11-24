using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Storm
{
    public partial class Settings : Form
    { 
        public Settings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Path == "")
            {
                PathBox.Text = Util.Helper.GetFNPath();
            }
            else
            {
                PathBox.Text = Properties.Settings.Default.Path;
            }


            string JSON = Util.Helper.HTTPGet("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/VersionManager/Main.json");

            dynamic jsondata = JsonConvert.DeserializeObject<dynamic>(JSON);

            string version = jsondata["version"].ToString();

            AppVersion1.Text = version;
            AppVersion2.Text = Util.Global.VERSION;

            string EnablePath = Util.Helper.ReadIni("Main", "EnablePath");

            PathBox.Visible = Convert.ToBoolean(EnablePath);
            guna2Button4.Visible = Convert.ToBoolean(EnablePath);
            guna2Button2.Visible = Convert.ToBoolean(EnablePath);
            guna2Button3.Visible = Convert.ToBoolean(EnablePath);
            guna2ComboBox1.SelectedItem = Properties.Settings.Default.Method;

            if (Convert.ToBoolean(Util.Helper.ReadIni("Themes", "ThemesEnabled")) == true)
            {
                string Theme = Util.Helper.ReadIni("Themes", "Theme");
                if (Theme == "Halloween")
                {
                    guna2Button1.FillColor = Color.FromArgb(255, 128, 0);
                    guna2Button1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2Button2.FillColor = Color.FromArgb(255, 128, 0);
                    guna2Button2.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2Button3.FillColor = Color.FromArgb(255, 128, 0);
                    guna2Button3.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2Button4.FillColor = Color.FromArgb(255, 128, 0);
                    guna2Button4.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientPanel1.FillColor = Color.FromArgb(255, 192, 128);
                    guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 128, 0);
                    guna2GradientPanel1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.FillColor = Color.FromArgb(255, 128, 0); 
                    guna2GradientButton1.FillColor2 = Color.FromArgb(255, 192, 128);
                    //AccCust.FillColor = Color.FromArgb(255, 128, 0);
                    //AccCust.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);

                }
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/dev");
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PathBox.Text = Util.Helper.GetFNPath();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(PathBox.Text))
            {
                if (Directory.Exists(PathBox.Text + "\\FortniteGame")) {
                    if (Directory.Exists(PathBox.Text + "\\Engine"))
                    {
                        Properties.Settings.Default.Path = PathBox.Text;
                        Properties.Settings.Default.Save();
                        Util.Helper.Msg("Path saved successfully!", "Success", "Default");
                        
                    } else
                    {
                        Util.Helper.Msg("Engine folder missing! Please make sure both FortniteGame and Engine folder exists.", "Error", "Default");
                    }
                    
                } else
                {
                    Util.Helper.Msg("FortniteGame folder missing! Please make sure both FortniteGame and Engine folder exists.", "Error", "Default");
                }
            } else
            {
                Util.Helper.Msg("Path doesnt exist or you selected an file, please check your path and make sure its correct.", "Error", "Default");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }



        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void AppVersion1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Method = guna2ComboBox1.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

       /* private void AccCust_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();

            accountSettings.ShowDialog();

       
        }*/
    }
}
