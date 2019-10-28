using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient; // added by JCR 2016-11-13 taken from football_picksDataSet1.Designer.cs -> gameTableAdapter


//server=localhost;user id=root;password=TrekSQL6c69!;database=football_picks

namespace CS_windows_forms_testing
{
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>();
        List<Stats> stats = new List<Stats>();
        List<ListBox> gameBox = new List<ListBox>();
        List<ListBox> scoreBox = new List<ListBox>();
        List<ListBox> lineBox = new List<ListBox>();
        List<TextBox> timeBox = new List<TextBox>();
        List<TextBox> rankBox = new List<TextBox>();
        List<TextBox> teamsBox = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            gameBox.Add(this.listJMCwin01);
            gameBox.Add(this.listJCRwin01);
            gameBox.Add(this.listJMCspread01);
            gameBox.Add(this.listJCRspread01);
            gameBox.Add(this.listJMCwin02);
            gameBox.Add(this.listJCRwin02);
            gameBox.Add(this.listJMCspread02);
            gameBox.Add(this.listJCRspread02);
            gameBox.Add(this.listJMCwin03);
            gameBox.Add(this.listJCRwin03);
            gameBox.Add(this.listJMCspread03);
            gameBox.Add(this.listJCRspread03);
            gameBox.Add(this.listJMCwin04);
            gameBox.Add(this.listJCRwin04);
            gameBox.Add(this.listJMCspread04);
            gameBox.Add(this.listJCRspread04);
            gameBox.Add(this.listJMCwin05);
            gameBox.Add(this.listJCRwin05);
            gameBox.Add(this.listJMCspread05);
            gameBox.Add(this.listJCRspread05);
            gameBox.Add(this.listJMCwin06);
            gameBox.Add(this.listJCRwin06);
            gameBox.Add(this.listJMCspread06);
            gameBox.Add(this.listJCRspread06);

            scoreBox.Add(this.listScore01);
            scoreBox.Add(this.listScore02);
            scoreBox.Add(this.listScore03);
            scoreBox.Add(this.listScore04);
            scoreBox.Add(this.listScore05);
            scoreBox.Add(this.listScore06);

            lineBox.Add(this.listLine01);
            lineBox.Add(this.listLine02);
            lineBox.Add(this.listLine03);
            lineBox.Add(this.listLine04);
            lineBox.Add(this.listLine05);
            lineBox.Add(this.listLine06);

            timeBox.Add(this.txtTime01);
            timeBox.Add(this.txtTime02);
            timeBox.Add(this.txtTime03);
            timeBox.Add(this.txtTime04);
            timeBox.Add(this.txtTime05);
            timeBox.Add(this.txtTime06);

            rankBox.Add(this.txtRanks01);
            rankBox.Add(this.txtRanks02);
            rankBox.Add(this.txtRanks03);
            rankBox.Add(this.txtRanks04);
            rankBox.Add(this.txtRanks05);
            rankBox.Add(this.txtRanks06);

            teamsBox.Add(this.txtTeams01);
            teamsBox.Add(this.txtTeams02);
            teamsBox.Add(this.txtTeams03);
            teamsBox.Add(this.txtTeams04);
            teamsBox.Add(this.txtTeams05);
            teamsBox.Add(this.txtTeams06);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string x = listJMCwin01.SelectedItems[0].ToString();
            //MessageBox.Show(x);
            //txt_Output.Text += x + "\r\n";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'football_picksDataSet.game' table. You can move, or remove it, as needed.
            //this.gameTableAdapter.Fill(this.football_picksDataSet.game);

            //listJMCwin01.Items.Add("TAMU");
            //listJMCwin01.Items.Add("OLD MISS");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            string fName = "\\2016 1-20 data2.txt";
            string fileName = path + fName;
            char[] separators = new char[] { '\t' };

            //List<Game> games = new List<Game>();
            //List<Stats> stats = new List<Stats>();


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
                if (aGame.UDline != "PK" && aGame.UDline != "NL" && aGame.UDline != "NO LINE")
                {
                    double intLine;
                    intLine = Math.Abs(double.Parse(aGame.UDline));
                    aGame.UDline = intLine.ToString();
                }


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

                thisStat.SeasonJMCwon = thisStat.SeasonJMCgw + thisStat.SeasonJMCsw;
                thisStat.SeasonJCRwon = thisStat.SeasonJCRgw + thisStat.SeasonJCRsw;

            }
            txt_GamesInMemory.Text = "Total Games in memory " + Stats.s_TotalGamesInMemory;
        }

        private void btn_GetSheetData_Click(object sender, EventArgs e)
        {
            int sht = (int)numUD_Sheet.Value;
            string ssht = numUD_Sheet.Value.ToString();
            string year = combo_Year.Text;
            txt_Output.Text += "Year: " + year + "  Sheet: " + sht + Environment.NewLine;
            List<Game> thisSheetGame = new List<Game>();
            foreach (Game aGame in games)
            {
                if (aGame.Season == year && aGame.Sheet == ssht)   
                {
                    thisSheetGame.Add(aGame);
                }
            }
            txt_NumGames.Text = "Num Games: " + thisSheetGame.Count.ToString();
            int idx = 0;
            int sidx = 0;
            foreach (Game thisGame in thisSheetGame)
            {
                int udIdx = -1;

                txt_Output.Text += thisGame.JMCgamePick + Environment.NewLine;
                txt_Output.Text += thisGame.JCRgamePick + Environment.NewLine;
                txt_Output.Text += thisGame.JMCspreadPick + Environment.NewLine;
                txt_Output.Text += thisGame.JCRspreadPick + Environment.NewLine;

                scoreBox[sidx].Items.Clear();
                scoreBox[sidx].Items.Add(thisGame.AwayScore);
                scoreBox[sidx].Items.Add(thisGame.HomeScore);

                

                for (int i = 0; i < 4; ++i)
                {
                    gameBox[idx].Items.Clear();
                    gameBox[idx].Items.Add(thisGame.Away);
                    gameBox[idx].Items.Add(thisGame.Home);
                    

                    int index = -1;
                    

                    switch (i)
                    {
                        case 0:
                            index = gameBox[idx].FindString(thisGame.JMCgamePick);
                            //udIdx = gameBox[idx].FindString(thisGame.UDteam);
                            txt_Output.Text += index + Environment.NewLine;
                            if (index != ListBox.NoMatches)
                                gameBox[idx].SetSelected(index, true);
                            break;
                        case 1:
                            index = gameBox[idx].FindString(thisGame.JCRgamePick);
                            txt_Output.Text += index + Environment.NewLine;
                            if (index != ListBox.NoMatches)
                                gameBox[idx].SetSelected(index, true);
                            break;
                        case 2:
                            index = gameBox[idx].FindString(thisGame.JMCspreadPick);
                            txt_Output.Text += index + Environment.NewLine;
                            if (index != ListBox.NoMatches)
                                gameBox[idx].SetSelected(index, true);
                            break;
                        case 3:
                            index = gameBox[idx].FindString(thisGame.JCRspreadPick);
                            txt_Output.Text += index + Environment.NewLine;
                            if (index != ListBox.NoMatches)
                                gameBox[idx].SetSelected(index, true);
                            break;
                    }

                    


                    idx++;
                    
                }

                udIdx = gameBox[sidx * 4].FindString(thisGame.UDteam);
                txt_Output.Text += "idx: " + idx + Environment.NewLine;
                txt_Output.Text += "UD: " + thisGame.UDteam + Environment.NewLine;
                txt_Output.Text += "Line index: " + udIdx + Environment.NewLine;
                lineBox[sidx].Items.Clear();
                if (udIdx == 1)
                    lineBox[sidx].Items.Add("");
                lineBox[sidx].Items.Add(thisGame.UDline);
                teamsBox[sidx].Text = thisGame.Away + "\r\n" + thisGame.Home;
                timeBox[sidx].Text = thisGame.Time;
                if (int.Parse(thisGame.AwayRank) != 0)
                {
                    rankBox[sidx].Text = thisGame.AwayRank;
                }
                else
                {
                    rankBox[sidx].Text = "\r\n";
                }
                if (int.Parse(thisGame.HomeRank) != 0)
                {
                    rankBox[sidx].Text += thisGame.HomeRank;
                }

                sidx++;
            }


        } // end btn_GetSheetData_Click

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListBox aList in gameBox)
            {
                aList.ClearSelected();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
