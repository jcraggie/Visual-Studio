using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_file_reader2
{
    class Stats
    {
        public static int s_TotalGamesInMemory = 0;

        public string Season { get; set; }
        public int NumSheets { get; set; }

        public int[] SheetGamesPicked { get; set; }
        public int[] SheetSpreadPicked { get; set; }
        public int[] SheetJMCgw { get; set; }
        public int[] SheetJCRgw { get; set; }
        public int[] SheetJMCsw { get; set; }
        public int[] SheetJCRsw { get; set; }
        public int[] SheetJMCtotalWon { get; set; }
        public int[] SheetJCRtotalWon { get; set; }

        public int SeasonGamesPicked { get; set; }
        public int SeasonSpreadPicked { get; set; }
        public int SeasonCFBPicked { get; set; }
        public int SeasonNFLPicked { get; set; }

        public int SeasonCFBGamesPicked { get; set; }
        public int SeasonCFBSpreadPicked { get; set; }
        public int SeasonNFLGamesPicked { get; set; }
        public int SeasonNFLSpreadPicked { get; set; }

        public int SeasonJMCgw { get; set; }
        public int SeasonJCRgw { get; set; }
        public int SeasonJMCsw { get; set; }
        public int SeasonJCRsw { get; set; }

        public int SeasonJMCCFBgw { get; set; }
        public int SeasonJCRCFBgw { get; set; }
        public int SeasonJMCCFBsw { get; set; }
        public int SeasonJCRCFBsw { get; set; }

        public int SeasonJMCNFLgw { get; set; }
        public int SeasonJCRNFLgw { get; set; }
        public int SeasonJMCNFLsw { get; set; }
        public int SeasonJCRNFLsw { get; set; }

        public int SeasonTotalPicked { get; set; }
        public int SeasonJMCwon { get; set; }
        public int SeasonJCRwon { get; set; }


    }
}
