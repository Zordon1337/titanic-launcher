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
#elif RELEASE
    public static readonly string version_ = "";
#endif

        public static readonly string version = "b17" + version_;
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
            File.WriteAllText("./config.tl",$"{Settings.sUsername}\n{BoolToString(Settings.bHideLevelProgress)}\n{FavoriteMode}\n{manifest}");
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
            } else
            {
                Settings.manifest = "https://osu.lekuru.xyz/api/clients";
            } 
            
        }
    }
}
