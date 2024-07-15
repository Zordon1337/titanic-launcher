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
    public static readonly string version_ = ".release";
#elif DEBUG
        public static readonly string version_ = ".dev";
#elif RELEASE
    public static readonly string version_ = "";
#endif

        public static readonly string version = "b9" + version_;
        public static bool bHideLevelProgress = true;
        public static string sUsername = "";
        public static User u = null;
        static string tr = "true";
        static string fl = "false";
        public static int FavoriteMode = 0;
        private static string BoolToString(bool value)
        {
            return value ? "true" : "false";
        }
        public static void WriteToConfig()
        {
            File.WriteAllText("./config.tl",$"{Settings.sUsername}\n{BoolToString(Settings.bHideLevelProgress)}\n{FavoriteMode}");
        }
        public static void ReadFromConfig() 
        {
            if(File.Exists("./config.tl"))
            {
                string config = File.ReadAllText("./config.tl");
                string[] lines = config.Split(new char[] { '\n' });
                sUsername = lines[0];
                bHideLevelProgress = lines[1] == "true";
                FavoriteMode = int.Parse(lines[2]);
            }
        }
    }
}
