using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Storm.Properties;
using IniParser;
using IniParser.Model;
using System.Threading;
using System.Diagnostics;

namespace Storm
{
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();

            string el = Util.Helper.GetFNPath();
            if (Properties.Settings.Default.Path == "") {
                VersionLabel.Text = "Fortnite v" + Util.Helper.GetFNVer();
            } else if (Properties.Settings.Default.Path == el)
            {
                VersionLabel.Text = "Fortnite v" + Util.Helper.GetFNVer();
            } else
            {
                VersionLabel.Text = "UNKNOWN VERSION";
            }
            
            Util.Helper.DiscordRPC();


            Util.Helper.LoadIni();
            Util.Helper.StartupMessage();
            
            string EnableConfig = Util.Helper.ReadIni("Main", "EnableSettings");
            string EnableChangeLog = Util.Helper.ReadIni("Main", "EnableChangelog");

            SettingsButton.Visible = Convert.ToBoolean(EnableConfig);
            ChangelogButton.Visible = Convert.ToBoolean(EnableChangeLog);

            if (Convert.ToBoolean(Util.Helper.ReadIni("Themes", "ThemesEnabled")) == true)
            {
                string Theme = Util.Helper.ReadIni("Themes", "Theme");
                if (Theme == "Halloween") {
                    SettingsButton.FillColor = Color.FromArgb(255, 128, 0);
                    SettingsButton.FillColor2 = Color.FromArgb(255, 192, 128);
                    SettingsButton.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.FillColor = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientButton1.FillColor2 = Color.FromArgb(255, 192, 128);
                    guna2GradientButton2.FillColor = Color.FromArgb(255, 128, 0);
                    guna2GradientButton2.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                    guna2GradientButton2.FillColor2 = Color.FromArgb(255, 192, 128);
                    guna2ControlBox1.FillColor = Color.FromArgb(255, 128, 0);
                    guna2ControlBox1.ShadowDecoration.Color = Color.FromArgb(255, 128, 0);
                }
            }

            Util.Helper.CheckUpdate();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Util.Helper.ReadIni("Launching", "EnableFNLaunching")) == true)
            {
                Hide();
                await Util.Helper.InstallAC();
                Util.Helper.ReplaceSplash();
                await Util.Helper.InstallDLL();
                Thread.Sleep(1200);
                Util.Helper.StartFortnite();
            }
            else
            {
                if (Convert.ToBoolean(Util.Helper.ReadIni("Launching", "DisabledLaunchMessage")) == true)
                {
                    Util.Helper.Msg(Util.Helper.ReadIni("Launching", "Message"), "Launching Error", "Default");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();

            Settings.ShowDialog();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/dev");
        }
    }
}
