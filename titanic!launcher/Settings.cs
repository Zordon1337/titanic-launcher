using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanic_launcher
{
    internal class Settings
    {
        public static readonly string version = "b1"+version_;
#if TESTRELEASE
        public static readonly string version_ = ".release";
#endif
#if DEBUG
        public static readonly string version_ = ".dev";
#endif
#if RELEASE
        public static readonly string version_ = "";
#endif
        public static bool bHideLevelProgress = true;
    }
}
