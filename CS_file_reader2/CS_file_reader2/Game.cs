using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_file_reader2
{
    public class Game
    {
        public string Time { get; set; } // 0
        public string Away { get; set; }
        public string Home { get; set; }
        public string UDteam { get; set; }
        public string UDline { get; set; } // 4
        public string AwayRank { get; set; }
        public string HomeRank { get; set; }
        public string UDrank { get; set; }
        public string AwayConf { get; set; }
        public string HomeConf { get; set; }
        public string Date { get; set; }
        public string GameType { get; set; }
        public string Season { get; set; }
        public string Sheet { get; set; }
        public int    GameNum { get; set; }
        public string GameID { get; set; }
        public int    AwayScore { get; set; }
        public int    HomeScore { get; set; }
        public string JMCgamePick { get; set; }
        public string JCRgamePick { get; set; }
        public string JMCspreadPick { get; set; }
        public string JCRspreadPick { get; set; }
        public string GameWinner { get; set; }
        public string SpreadWinner { get; set; }
        public int    JMCwinGame { get; set; }
        public int    JCRwinGame { get; set; }
        public int    JMCwinSpread { get; set; }
        public int    JCRwinSpread { get; set; }


        // used for calculations - not imported from txt file
        public float UDpts { get; set; }
    }
}
