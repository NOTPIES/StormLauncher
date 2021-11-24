using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using IniParser;
using IniParser.Model;
using Newtonsoft.Json;

namespace Storm.Util
{
    class Helper
    {

       

        public static void DiscordRPC()
        {
            DiscordRpcClient client;
            client = new DiscordRpcClient("875776898989437019");
            client.Initialize();


            
            client.SetPresence(new RichPresence()
            {
                Details = "Using Storm v" + Util.Global.VERSION,
                State = "Made by NOTPIES",
                Assets = new Assets()
                {
                    LargeImageKey = "stormlarge",
                    LargeImageText = "notpies cool"
                }
            });
        }
        public static string GetFNVer() 
        {
            var FNVer = "";
            var EpicInstalled = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(EpicInstalled);

            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    FNVer = installion.AppVersion.ToString().Split('-')[1];
                }
            }

            return FNVer;
        }

        public static string GetFNPath()
        {
            var FNPath = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"));
            dynamic Json = JsonConvert.DeserializeObject(FNPath);
            foreach (var installion in Json.InstallationList)
            {
                if (installion.AppName == "Fortnite")
                {
                    FNPath = installion.InstallLocation.ToString(); // FortniteGame
                }
            }


            return FNPath;
        }

        public static void StartFortnite() 
        {
            var Proc = new ProcessStartInfo();
            Proc.CreateNoWindow = true;
            Proc.FileName = "cmd.exe";
            Proc.Arguments = "/C start com.epicgames.launcher://apps/Fortnite?action=launch";
            Process.Start(Proc);
        }
        public static async Task InstallDLL() 
        {
            WebClient webClient = new WebClient();
            string Temp = Path.GetTempPath();
            if (!File.Exists(Temp + "\\RepoxisNative.dll"))
            {
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/Storm.dll", Temp + "\\Storm.dll");
            }
            else
            {
                File.Delete(Temp + "\\RepoxisNative.dll");
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/Storm.dll", Temp + "\\Storm.dll");
            }

            if (!File.Exists(Temp + "\\nokick.dll"))
            {
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/nokick.dll", Temp + "\\nokick.dll");
            }
            else
            {
                File.Delete(Temp + "\\nokick.dll");
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/nokick.dll", Temp + "\\nokick.dll");
            }
        }

        public static string HTTPGet(string url)
        {
            string result = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public static void LoadIni()
        {
            string Temp = Path.GetTempPath();
            string a = HTTPGet("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/Default.ini");
            if (!File.Exists(Temp + "\\SDFOPKDSFODSFSDKFDSOP.ini"))
            {
                File.WriteAllText(Temp + "\\SDFOPKDSFODSFSDKFDSOP.ini", a, Encoding.UTF8);
            }
            else
            {
                File.Delete(Temp + "\\SDFOPKDSFODSFSDKFDSOP.ini");
                File.WriteAllText(Temp + "\\SDFOPKDSFODSFSDKFDSOP.ini", a, Encoding.UTF8);
            }

        }

        public static string ReadIni(string section, string value)
        {
            string Temp = Path.GetTempPath();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Temp + "\\SDFOPKDSFODSFSDKFDSOP.ini");
            string Settings1 = data["Storm." + section][value].Replace("\u0022", "");

            return Settings1;
            
        }


        public static void CheckUpdate()
        {
            if (Directory.Exists(Directory.GetCurrentDirectory() + "Updater"))
            {
                Directory.Delete(Directory.GetCurrentDirectory() + "Updater");
            }
            string JSON = HTTPGet("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/VersionManager/Main.json"); // https://fdsg54g54g5667j.elproxxjunoxx.repl.co/VersionManager/Main.json

            dynamic jsondata = JsonConvert.DeserializeObject<dynamic>(JSON);

            string version = jsondata["version"].ToString();
            if (Util.Global.VERSION != version)
            {
                Msg("An new version of Storm is available, please update to version " + version + " by\ndownloading from the discord.", "Storm", "NewVer");
            }
        }


        public static async Task InstallAC() // Install AC and SplashScreen
        {

            string Temp = Path.GetTempPath();


            if (!Directory.Exists(Temp + "\\StormACSave"))
            {
                Directory.CreateDirectory(Temp + "StormACSave");
            } 
            
            var RealACDir = Temp + "\\StormACSave";


            WebClient webClient = new WebClient();
            var e = Properties.Settings.Default.Path;

            if (e == "")
            {
                e = GetFNPath();
            }

            if (!File.Exists(RealACDir + "\\Splash.bmp"))
            {
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/Splash.bmp", RealACDir + "\\Splash.bmp");
            } else
            {
                File.Delete(RealACDir + "\\Splash.bmp");
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/Splash.bmp", RealACDir + "\\Splash.bmp");
            }

            if (Properties.Settings.Default.Method == "Verify")
            {
                if (!File.Exists(e + "\\FortniteGame\\Binaries\\Win64\\dontdeletemeverify1243141242141.txt"))
                {
                    File.Create(e + "\\FortniteGame\\Binaries\\Win64\\dontdeletemeverify1243141242141.txt");
                }
            }
            else
            {
                if (File.Exists(e + "\\FortniteGame\\Binaries\\Win64\\dontdeletemeverify1243141242141.txt"))
                {
                    File.Delete(e + "\\FortniteGame\\Binaries\\Win64\\dontdeletemeverify1243141242141.txt");
                }
            }





            if (!File.Exists(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe"))
            {
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/ac1.exe", e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
            }
            else
            {
                if (Properties.Settings.Default.Method == "AC Replace")
                {
                    if (!File.Exists(RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe"))
                    {
                        File.Move(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe");
                    } else
                    {
                        File.Delete(RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe");
                        File.Move(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe");
                    }
                    
                } else
                {
                    File.Delete(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
                    if (File.Exists(RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe"))
                    {
                        File.Delete(RealACDir + "\\FortniteClient-Win64-Shipping_EAC.exe");
                    }
                }
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/ac1.exe", e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe");
            }


            if (!File.Exists(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe"))
            {
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/ac1.exe", e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe");
            }
            else
            {
                if (Properties.Settings.Default.Method == "AC Replace")
                {
                    if (!File.Exists(RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe"))
                    {
                        File.Move(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe");
                    }
                    else
                    {
                        File.Delete(RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe");
                        File.Move(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe");
                    }
                }
                else
                {
                    File.Delete(e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe");
                    if (File.Exists(RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe"))
                    {
                        File.Delete(RealACDir + "\\FortniteClient-Win64-Shipping_BE.exe");
                    }
                }
                await webClient.DownloadFileTaskAsync("https://fdsg54g54g5667j.elproxxjunoxx.repl.co/storm/files/ac1.exe", e + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe");
            }
        }
        public static void Msg(string msg, string title, string type)
        {

            if (ReadIni("Main", "UseLegacyMsg") == "true")
            {
                MessageBox.Show(msg, title);
            }
            else
            {

                MessageDialog MessageForm = new MessageDialog();

                MessageForm.Title.Text = title;
                MessageForm.MessageText.Text = msg;

                if (type == "Default")
                {
                    MessageForm.OKButton.Visible = true;
                }
                if (type == "NewVer")
                {
                    MessageForm.VersionButton1.Visible = true;
                    MessageForm.VersionButton2.Visible = true;
                }
                MessageForm.ShowDialog();
            }
            
        }

        public static void StartupMessage()
        {
            if (ReadIni("MessageStartup", "MessageAtLaunch") == "true")
            {
                Msg(ReadIni("MessageStartup", "Message"), ReadIni("MessageStartup", "Title"), "Default");
            }
        }
       
 
        public static void ReplaceSplash()
        {
            string Temp = Path.GetTempPath();
            var RealACDir = Temp + "\\StormACSave";

            var FNPath = Properties.Settings.Default.Path;

            if (FNPath == "")
            {
                FNPath = GetFNPath();
            }

            if (File.Exists(RealACDir + "\\Splash.bmp"))
            {
                if (File.Exists(FNPath + "\\FortniteGame\\Content\\Splash\\Splash.bmp"))
                {
                    if (!File.Exists(RealACDir + "\\SplashOriginal.bmp"))
                    {
                        File.Move(FNPath + "\\FortniteGame\\Content\\Splash\\Splash.bmp", RealACDir + "\\SplashOriginal.bmp");
                    } else
                    {
                        File.Delete(RealACDir + "\\SplashOriginal.bmp");
                        File.Move(FNPath + "\\FortniteGame\\Content\\Splash\\Splash.bmp", RealACDir + "\\SplashOriginal.bmp");
                    }
                    
                    File.Move(RealACDir + "\\Splash.bmp", FNPath + "\\FortniteGame\\Content\\Splash\\Splash.bmp");
                } else
                {
                    File.Move(RealACDir + "\\Splash.bmp", FNPath + "\\FortniteGame\\Content\\Splash\\Splash.bmp");
                }
            }
        }
    }
}
