using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanic_launcher
{
    internal class Settings
    {
#if TESTRELEASE
    public static readonly string version_ = ".test";
#elif DEBUG
        public static readonly string version_ = ".dev";
#elif PUBLIC
    public static readonly string version_ = "";
#endif

        public static readonly string version = "b25" + version_;
        public static bool bHideLevelProgress = true;
        public static string sUsername = "";
        public static User u = null;
        public static int FavoriteMode = 0;
        public static string manifest;
        public static List<Client> clients;
        public static bool bClientUpdateRequired = false;
        private static string BoolToString(bool value)
        {
            return value ? "true" : "false";
        }
        public static void WriteToConfig()
        {
            string write = $"{Settings.sUsername}\n{BoolToString(Settings.bHideLevelProgress)}\n{FavoriteMode}\n{manifest}";
            for (int i = 0; i < clients.Count; i++) {
                if (clients[i].LastPlayed == null)
                    continue;
                write += $"\n{clients[i].Name}|{clients[i].LastPlayed}";
            }
            File.WriteAllText("./config.tl",write);
        }
        private static Client FindClient(string value)
        {
            return Settings.clients.Find(x => x.Name == value);
        }
        public static void ReadFromConfig() 
        {
            if(File.Exists("./config.tl"))
            {
                string config = File.ReadAllText("./config.tl");
                string[] lines = config.Split(new char[] { '\n' });
                Settings.sUsername = lines[0];
                Settings.bHideLevelProgress = lines[1] == "true";
                Settings.FavoriteMode = int.Parse(lines[2]);
                Settings.manifest = lines[3];
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    for (int i = 4; i < lines.Length; i++)
                    {
                        var split = lines[i].Split("|");
                        var client = FindClient(split[0]);
                        var LastPlayed = split[1];
                        client.LastPlayed = LastPlayed;
                    }
                }).Start();
            } else
            {
                Settings.manifest = "https://osu.titanic.sh/api/clients";
            } 
            
        }
    }
}
