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

        public static readonly string version = "b5" + version_;
        public static bool bHideLevelProgress = true;
        public static string sUsername = "";
        public static User u = null;
    }
}
