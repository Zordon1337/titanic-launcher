using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titanic_launcher
{
    public class Level
    {
        public int lvl;
        public long current_xp;
        public long required_xp;
    }
    public class User
    {
        public static readonly long[] toNextLevel = new long[]
        {
            30000L,
            100000L,
            210000L,
            360000L,
            550000L,
            780000L,
            1050000L,
            1360000L,
            1710000L,
            2100000L,
            2530000L,
            3000000L,
            3510000L,
            4060000L,
            4650000L,
            5280000L,
            5950000L,
            6660000L,
            7410000L,
            8200000L,
            9030000L,
            9900000L,
            10810000L,
            11760000L,
            12750000L,
            13780000L,
            14850000L,
            15960000L,
            17110000L,
            18300000L,
            19530000L,
            20800000L,
            22110000L,
            23460000L,
            24850000L,
            26280000L,
            27750000L,
            29260000L,
            30810000L,
            32400000L,
            34030000L,
            35700000L,
            37410000L,
            39160000L,
            40950000L,
            42780000L,
            44650000L,
            46560000L,
            48510000L,
            50500000L,
            52530000L,
            54600000L,
            56710000L,
            58860000L,
            61050000L,
            63280000L,
            65550000L,
            67860000L,
            70210001L,
            72600001L,
            75030002L,
            77500003L,
            80010006L,
            82560010L,
            85150019L,
            87780034L,
            90450061L,
            93160110L,
            95910198L,
            98700357L,
            101530643L,
            104401157L,
            107312082L,
            110263748L,
            113256747L,
            116292144L,
            119371859L,
            122499346L,
            125680824L,
            128927482L,
            132259468L,
            135713043L,
            139353477L,
            143298259L,
            147758866L,
            153115959L,
            160054726L,
            169808506L,
            184597311L,
            208417160L,
            248460887L,
            317675597L,
            439366075L,
            655480935L,
            1041527682L,
            1733419828L,
            2975801691L,
            5209033044L,
            9225761479L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L,
            99999999999L
        };
        public string Username { get; set; }
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public Score StdScore { get; set; }
        public Score CtbScore { get; set; }
        public Score TaikoScore { get; set; }
        public Score ManiaScore { get; set; }
        public Level CalculateLevel(Score sc)
        {
            Level lvl = new Level();
            long xpscore = sc.TotalScore;
            long cumulativeXP = 0;

            for (int i = 0; i < toNextLevel.Length; i++)
            {
                if (xpscore < toNextLevel[i])
                {
                    lvl.lvl = i + 1;
                    lvl.current_xp = xpscore;
                    lvl.required_xp = toNextLevel[i];

                    return lvl;
                }
                xpscore -= toNextLevel[i];
                cumulativeXP += toNextLevel[i];
            }

            lvl.lvl = toNextLevel.Length;
            lvl.current_xp = xpscore;
            lvl.required_xp = toNextLevel[toNextLevel.Length - 1];

            return lvl;
        }


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
        public int id { get; set; }
        public List<Stat> Stats { get; set; }
    }

}
