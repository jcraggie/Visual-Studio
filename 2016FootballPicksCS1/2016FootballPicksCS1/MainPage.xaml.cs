﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using System.IO;
using System.Text;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _2016FootballPicksCS1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
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
                    games.Add(new Game()
                    {
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
                if (aGame.GameType == "NFL")
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
                if ((aGame.UDline == "PK") || (aGame.UDline == "NL"))
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
        }
    }
}
