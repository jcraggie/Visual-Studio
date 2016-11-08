using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CS_file_reader2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string fName = "\\2016 1-20 data.txt";
            string fileName = path + fName;
            char[] separators = new char[] { '\t' };

            List<Game> games = new List<Game>();
            List<Stats> stats = new List<Stats>();
            

            //Console.WriteLine("{0}\n\n", fileName);

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    
                    lineNumber++;
                    int subItem = 0;
                    //Console.WriteLine("{0,-2}: {1}\n\n", lineNumber, line);

                    string[] gameInfo = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    games.Add(new Game() {
                        Time = gameInfo[0],
                        Away = gameInfo[1],
                        Home = gameInfo[2],
                        UDteam = gameInfo[3],
                        UDline = gameInfo[4],
                        AwayRank = gameInfo[5],
                        HomeRank = gameInfo[6],
                        UDrank = gameInfo[7],
                        AwayConf = gameInfo[8],
                        HomeConf = gameInfo[9],
                        Date = gameInfo[10],
                        GameType = gameInfo[11],
                        Season = gameInfo[12],
                        Sheet = gameInfo[13],
                        GameNum = Int32.Parse(gameInfo[14]),
                        GameID = gameInfo[15],
                        AwayScore = Int32.Parse(gameInfo[16]),
                        HomeScore = Int32.Parse(gameInfo[17]),
                        JMCgamePick = gameInfo[18],
                        JCRgamePick = gameInfo[19],
                        JMCspreadPick = gameInfo[20],
                        JCRspreadPick = gameInfo[21],
                        GameWinner = gameInfo[22],
                        SpreadWinner = gameInfo[23],
                        JMCwinGame = Int32.Parse(gameInfo[24]),
                        JCRwinGame = Int32.Parse(gameInfo[25]),
                        JMCwinSpread = Int32.Parse(gameInfo[26]),
                        JCRwinSpread = Int32.Parse(gameInfo[27]),

                    });
                    


                    foreach (string gameItem in gameInfo)
                    {
                        if (gameItem != "")
                        {

                            //Console.WriteLine("{0}-{1,-2}: {2}",lineNumber, subItem, gameItem);
                            subItem++;
                        }
                    }
                    //Console.WriteLine("\n\n");
                    line = reader.ReadLine();
                }
            }
            // reader.Close();  // <--- not necessary now because of the using() construct

            foreach (Game aGame in games)
            {
                string thisYear = aGame.Season;
                

                
                //Console.WriteLine("Away: {0,-30}   Home: {1,-30}", aGame.Away, aGame.Home);
                
                
                var thisStat = stats.Find(x => x.Season == thisYear);
                int sht = 0;

                if (thisStat == null)
                {
                    stats.Add(new Stats() { Season = thisYear });
                    thisStat = stats.Find(x => x.Season == thisYear);
                    const int ARR_SIZE = 100;
                    //initialize arrays - find better way of allocating these vars
                    thisStat.SheetGamesPicked = new int[ARR_SIZE];
                    thisStat.SheetSpreadPicked = new int[ARR_SIZE];
                    thisStat.SheetJMCgw = new int[ARR_SIZE];
                    thisStat.SheetJCRgw = new int[ARR_SIZE];
                    thisStat.SheetJMCsw = new int[ARR_SIZE];
                    thisStat.SheetJCRsw = new int[ARR_SIZE];
                    thisStat.SheetJMCtotalWon = new int[ARR_SIZE];
                    thisStat.SheetJCRtotalWon = new int[ARR_SIZE];
                }

                Stats.s_TotalGamesInMemory++;

                sht = int.Parse(aGame.Sheet);  // saves current sheet number as an int

                // if NumSheets in Stats for the year is < the sheet number on the game line, update
                if (thisStat.NumSheets < int.Parse(aGame.Sheet))
                {
                    thisStat.NumSheets = int.Parse(aGame.Sheet);
                }

                // if game type is CFB, increase all CFB counters (will deduct for no spread later)
                if (aGame.GameType == "CFB")
                {
                    thisStat.SeasonCFBGamesPicked++;
                    thisStat.SeasonCFBPicked++;
                    thisStat.SeasonCFBSpreadPicked++;
                }
                
                // if game type is NFL, increase all NFL counters (will deduct for no spread later)
                if (aGame.GameType=="NFL")
                {
                    thisStat.SeasonNFLGamesPicked++;
                    thisStat.SeasonNFLPicked++;
                    thisStat.SeasonNFLSpreadPicked++;
                }

                // update total counts for the selected season (year)
                thisStat.SheetGamesPicked[sht]++;
                thisStat.SheetSpreadPicked[sht]++;
                thisStat.SeasonGamesPicked++;
                thisStat.SeasonSpreadPicked++;

                // if the underdog is either PK or NL, need to decrease the stats
                if ( (aGame.UDline == "PK") || (aGame.UDline == "NL") )
                {
                    thisStat.SheetSpreadPicked[sht]--;
                    thisStat.SeasonSpreadPicked--;
                    if (aGame.GameType == "CFB")
                    {
                        thisStat.SeasonCFBSpreadPicked--;
                    }
                    if (aGame.GameType == "NFL")
                    {
                        thisStat.SeasonNFLSpreadPicked--;
                    }
                }

                if (aGame.JMCwinGame == 1)
                {
                    thisStat.SheetJMCgw[sht]++;
                    thisStat.SeasonJMCgw++;
                    if (aGame.GameType == "CFB")
                    {
                        thisStat.SeasonJMCCFBgw++;
                    }
                    if (aGame.GameType == "NFL")
                    {
                        thisStat.SeasonJMCNFLgw++;
                    }
                }

                if (aGame.JCRwinGame == 1)
                {
                    thisStat.SheetJCRgw[sht]++;
                    thisStat.SeasonJCRgw++;
                    if (aGame.GameType == "CFB")
                    {
                        thisStat.SeasonJCRCFBgw++;
                    }
                    if (aGame.GameType == "NFL")
                    {
                        thisStat.SeasonJCRNFLgw++;
                    }
                }

                if (aGame.JMCwinSpread == 1)
                {
                    thisStat.SheetJMCsw[sht]++;
                    thisStat.SeasonJMCsw++;
                    if (aGame.GameType == "CFB")
                    {
                        thisStat.SeasonJMCCFBsw++;
                    }
                    if (aGame.GameType == "NFL")
                    {
                        thisStat.SeasonJMCNFLsw++;
                    }
                }

                if (aGame.JCRwinSpread == 1)
                {
                    thisStat.SheetJCRsw[sht]++;
                    thisStat.SeasonJCRsw++;
                    if (aGame.GameType == "CFB")
                    {
                        thisStat.SeasonJCRCFBsw++;
                    }
                    if (aGame.GameType == "NFL")
                    {
                        thisStat.SeasonJCRNFLsw++;
                    }
                }
                thisStat.SheetJMCtotalWon[sht] = thisStat.SheetJMCgw[sht] + thisStat.SheetJMCsw[sht];
                thisStat.SheetJCRtotalWon[sht] = thisStat.SheetJCRgw[sht] + thisStat.SheetJCRsw[sht];

                //thisStat.SeasonJMCwon = thisStat.SheetJMCtotalWon[sht];
                //thisStat.SeasonJCRwon = thisStat.SheetJCRtotalWon[sht];

                thisStat.SeasonJMCwon = thisStat.SeasonJMCgw + thisStat.SeasonJMCsw;
                thisStat.SeasonJCRwon = thisStat.SeasonJCRgw + thisStat.SeasonJCRsw;
                //Console.WriteLine("season JMC: {0}     sheetJMC: {1}", thisStat.SeasonJMCwon, thisStat.SheetJMCtotalWon[sht]);


            }


            char hChar = '\u2500';
            string hLine="";
            for (int i = 0; i < 95; ++i)
            {
                hLine += hChar;
            }

            Console.WriteLine(hLine);
            Console.WriteLine("{0,50}", "S T A T I S T I C S");
            Console.WriteLine(hLine);
            Console.WriteLine();
            Console.WriteLine("{0,40}{1,40}", "Correct Game Winners", "Correct Spread Winners");
            Console.WriteLine("{0,28}{1,7}{0,32}{1,7}", "JMC", "JCR");
            Console.WriteLine(hLine);
            foreach (Stats aStats in stats)
            {
                for (int sht = 1; sht <= aStats.NumSheets; ++sht)
                {
                    Console.WriteLine("{0} Sheet:{1,3}{2,5}{3,9}{4,7}{5,22}{6,10}{7,7}{8,10}{9,10}"
                        , aStats.Season,sht,
                        aStats.SheetGamesPicked[sht],aStats.SheetJMCgw[sht],aStats.SheetJCRgw[sht],
                        aStats.SheetSpreadPicked[sht],aStats.SheetJMCsw[sht],aStats.SheetJCRsw[sht],
                        aStats.SheetJMCtotalWon[sht],aStats.SheetJCRtotalWon[sht]);
                }
                Console.WriteLine(hLine);
                Console.WriteLine("{0,11}{1,3}{2,5}{3,9}{4,7}{5,22}{6,10}{7,7}{8,10}{9,10}", "Totals:",
                    aStats.NumSheets, aStats.SeasonGamesPicked, aStats.SeasonJMCgw, aStats.SeasonJCRgw,
                    aStats.SeasonSpreadPicked, aStats.SeasonJMCsw, aStats.SeasonJCRsw,
                    aStats.SeasonJMCwon,aStats.SeasonJCRwon);
                Console.WriteLine("{0,11}{1,8}{2,9}{3,7}{4,22}{5,10}{6,7}", "CFB:",
                    aStats.SeasonCFBPicked, aStats.SeasonJMCCFBgw, aStats.SeasonJCRCFBgw,
                    aStats.SeasonCFBSpreadPicked, aStats.SeasonJMCCFBsw, aStats.SeasonJCRCFBsw);
                Console.WriteLine("{0,11}{1,8}{2,9}{3,7}{4,22}{5,10}{6,7}", "NFL:",
                    aStats.SeasonNFLPicked, aStats.SeasonJMCNFLgw, aStats.SeasonJCRNFLgw,
                    aStats.SeasonNFLSpreadPicked, aStats.SeasonJMCNFLsw, aStats.SeasonJCRNFLsw);

                Console.WriteLine("Num Sheets: {0}",aStats.NumSheets);
                Console.WriteLine("");
                Console.WriteLine("Total Games in Memory: {0}", Stats.s_TotalGamesInMemory);
            }

            //string txt = "";
            //int cnt = 0;
            //for (int i = 0x2500; i < 0x257f; i++)
            //{
            //    Console.Write("{0}  ", (char)i);
            //    if (cnt >=15)
            //    {
            //        Console.WriteLine();
            //        cnt = 0;
            //    }
            //    else
            //    {
            //        cnt++;
            //    }
            //    txt += (char)i;
            //}
            //Console.WriteLine("\n\n");
            //Console.WriteLine(txt);


            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}