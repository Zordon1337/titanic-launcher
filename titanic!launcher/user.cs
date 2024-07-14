using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanic_launcher
{
    public class User
    {
        public string Username { get; set; }
        public string ImagePath { get; set; }
        public Score StdScore { get; set; }
        public Score CtbScore { get; set; }
        public Score TaikoScore { get; set; }
        public Score ManiaScore { get; set; }
    }

    public class Score
    {
        public long TotalScore { get; set; }
        public long RankedScore { get; set; }
        public double PP { get; set; }
        public float Accuracy { get; set; }
    }

    public class Stat
    {
        public long tscore { get; set; }
        public long rscore { get; set; }
        public double pp { get; set; }
        public double acc { get; set; }
    }

    public class Root
    {
        public string Name { get; set; }
        public List<Stat> Stats { get; set; }
    }

}
