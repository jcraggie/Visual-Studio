#pragma once

#include <iostream>

class CStats
{
public:
	static int s_TotalGamesInMemory;

	std::string Season{ "NEW_SEASON" };
	int NumSheets{ 0 };
	int GamesPicked[100]{ 0 };
	int SpreadPicked[100]{ 0 };
	int JMCgw[100]{ 0 };
	int JCRgw[100]{ 0 };
	int JMCsw[100]{ 0 };
	int JCRsw[100]{ 0 };

	int SeasonGamesPicked{ 0 };
	int SeasonSpreadPicked{ 0 };
	int SeasonCFBPicked{ 0 };
	int SeasonNFLPicked{ 0 };

	int SeasonCFBGamesPicked{ 0 };
	int SeasonCFBSpreadPicked{ 0 };
	int SeasonNFLGamesPicked{ 0 };
	int SeasonNFLSpreadPicked{ 0 };

	int SeasonJMCgw{ 0 };
	int SeasonJCRgw{ 0 };
	int SeasonJMCsw{ 0 };
	int SeasonJCRsw{ 0 };

	int SeasonJMCCFBgw{ 0 };
	int SeasonJMCNFLgw{ 0 };
	int SeasonJMCCFBsw{ 0 };
	int SeasonJMCNFLsw{ 0 };

	int SeasonJCRCFBgw{ 0 };
	int SeasonJCRNFLgw{ 0 };
	int SeasonJCRCFBsw{ 0 };
	int SeasonJCRNFLsw{ 0 };

};

int CStats::s_TotalGamesInMemory{ 0 };



class CGame
{
public:
	CGame();

	static int const s_DateBorder = 11;
	static int const s_GameBorder = 35;
	static int const s_ScoreBorder = 8;
	static int const s_UDBorder = 22;
	static int const s_JMCGameBorder = 24;
	static int const s_JCRGameBorder = 24;
	static int const s_JMCSpreadBorder = 24;
	static int const s_JCRSpreadBorder = 24;
	static int const s_SeasonSheetBorder = 7;
	static int const s_GameNumIDBorder = 12;

	static int s_NumGamesPlayed[100];
	static int s_NumSpreadPlayed[100];
	static int s_JMCgamesWon[100];
	static int s_JCRgamesWon[100];
	static int s_JMCspreadWon[100];
	static int s_JCRspreadWon[100];

	// getters
	std::string GetTime() const;
	std::string GetAwayTeam() const;
	std::string GetHomeTeam() const;
	std::string GetUDTeam() const;
	std::string GetUDline() const;
	float GetUDPts();
	std::string GetAwayRank() const;
	std::string GetHomeRank() const;
	std::string GetUDrank() const;
	std::string GetAwayConf() const;
	std::string GetHomeConf() const;
	std::string GetDate() const;
	int GetAwayScore() const;
	int GetHomeScore() const;
	std::string GetJMCgamePick() const;
	std::string GetJCRgamePick() const;
	std::string GetJMCspreadPick() const;
	std::string GetJCRspreadPick() const;
	std::string GetTeamGameWinner() const;
	std::string GetTeamSpreadWinner() const;
	bool GetJMCwinGame() const;
	bool GetJCRwinGame() const;
	bool GetJMCwinSpread() const;
	bool GetJCRwinSpread() const;
	std::string GetGameType() const;
	std::string GetSeason() const;
	std::string GetSheet() const;
	int GetGameNum() const;
	std::string GetGameID() const;

	// setters
	void SetTime(std::string time);
	void SetAwayTeam(std::string awayTeam);
	void SetHomeTeam(std::string homeTeam);
	void SetUDTeam(std::string UDteam);
	void SetUDline(std::string UDline);
	void SetUDPts(float UDpts);
	void SetAwayRank(std::string awayRank);
	void SetHomeRank(std::string homeRank);
	void SetUDrank(std::string UDrank);
	void SetAwayConf(std::string awayConf);
	void SetHomeConf(std::string homeConf);
	void SetDate(std::string date);
	void SetAwayScore(int awayScore);
	void SetHomeScore(int homeScore);
	void SetJMCgamePick(std::string JMCgamePick);
	void SetJCRgamePick(std::string JCRgamePick);
	void SetJMCspreadPick(std::string JMCspreadPick);
	void SetJCRspreadPick(std::string JCRspreadPick);
	void SetTeamGameWinner(std::string gameWinner);
	void SetTeamSpreadWinner(std::string spreadWinner);
	void SetJMCwinGame(bool JMCwinGame);
	void SetJCRwinGame(bool JCRwinGame);
	void SetJMCwinSpread(bool JMCwinSpread);
	void SetJCRwinSpread(bool JCRwinSpread);
	void SetGameType(std::string gameType);
	void SetSeason(std::string season);
	void SetSheet(std::string sheet);
	void SetGameNum(int gameNum);
	void SetGameID(std::string gameID);

private:
	std::string m_Time;
	std::string m_AwayTeam;
	std::string m_HomeTeam;
	std::string m_UDTeam;
	std::string m_UDline;
	float m_UDpts;
	std::string m_AwayRank;
	std::string m_HomeRank;
	std::string m_UDrank;
	std::string m_AwayConf;
	std::string m_HomeConf;
	std::string m_Date;
	std::string m_GameType; // CFB or NFL
	std::string m_Season; // season year
	std::string m_Sheet; // sheet name
	int m_GameNum; // used to enumerate games on a sheet
	std::string m_GameID;
	int m_AwayScore;
	int m_HomeScore;
	std::string m_JMCgamePick;
	std::string m_JCRgamePick;
	std::string m_JMCspreadPick;
	std::string m_JCRspreadPick;
	std::string m_WinnerGame;
	std::string m_WinnerSpread;
	bool m_JMCwinGame;
	bool m_JCRwinGame;
	bool m_JMCwinSpread;
	bool m_JCRwinSpread;


};

CGame::CGame() :
	m_AwayScore(0),
	m_HomeScore(0),
	m_JMCgamePick(" "),
	m_JCRgamePick(" "),
	m_JMCspreadPick(" "),
	m_JCRspreadPick(" "),
	m_WinnerGame(" "),
	m_WinnerSpread(" "),
	m_JMCwinGame(0),
	m_JCRwinGame(0),
	m_JMCwinSpread(0),
	m_JCRwinSpread(0)


{

}

int CGame::s_NumGamesPlayed[100];
int CGame::s_NumSpreadPlayed[100];
int CGame::s_JMCgamesWon[100];
int CGame::s_JCRgamesWon[100];
int CGame::s_JMCspreadWon[100];
int CGame::s_JCRspreadWon[100];

// CLASS GETTERS

std::string CGame::GetTime() const
{
	return m_Time;
}

std::string CGame::GetAwayTeam() const
{
	return m_AwayTeam;
}

std::string CGame::GetHomeTeam() const
{
	return m_HomeTeam;
}

std::string CGame::GetUDTeam() const
{
	return m_UDTeam;
}

std::string CGame::GetUDline() const
{
	return m_UDline;
}

float CGame::GetUDPts()
{
	return m_UDpts;
}

std::string CGame::GetAwayRank() const
{
	return m_AwayRank;
}

std::string CGame::GetHomeRank() const
{
	return m_HomeRank;
}

std::string CGame::GetUDrank() const
{
	return m_UDrank;
}

std::string CGame::GetAwayConf() const
{
	return m_AwayConf;
}

std::string CGame::GetHomeConf() const
{
	return m_HomeConf;
}

std::string CGame::GetDate() const
{
	return m_Date;
}

int CGame::GetAwayScore() const
{
	return m_AwayScore;
}

int CGame::GetHomeScore() const
{
	return m_HomeScore;
}

std::string CGame::GetJMCgamePick() const
{
	return m_JMCgamePick;
}

std::string CGame::GetJCRgamePick() const
{
	return m_JCRgamePick;
}

std::string CGame::GetJMCspreadPick() const
{
	return m_JMCspreadPick;
}

std::string CGame::GetJCRspreadPick() const
{
	return m_JCRspreadPick;
}

std::string CGame::GetTeamGameWinner() const
{
	return m_WinnerGame;
}

std::string CGame::GetTeamSpreadWinner() const
{
	return m_WinnerSpread;
}

bool CGame::GetJMCwinGame() const
{
	return m_JMCwinGame;
}

bool CGame::GetJCRwinGame() const
{
	return m_JCRwinGame;
}

bool CGame::GetJMCwinSpread() const
{
	return m_JMCwinSpread;
}

bool CGame::GetJCRwinSpread() const
{
	return m_JCRwinSpread;
}

std::string CGame::GetGameType() const
{
	return m_GameType;
}

std::string CGame::GetSeason() const
{
	return m_Season;
}

std::string CGame::GetSheet() const
{
	return m_Sheet;
}

int CGame::GetGameNum() const
{
	return m_GameNum;
}

std::string CGame::GetGameID() const
{
	return m_GameID;
}


// CLASS SETTERS

void CGame::SetTime(std::string time)
{
	m_Time = time;
}

void CGame::SetAwayTeam(std::string awayTeam)
{
	m_AwayTeam = awayTeam;
}

void CGame::SetHomeTeam(std::string homeTeam)
{
	m_HomeTeam = homeTeam;
}

void CGame::SetUDTeam(std::string UDteam)
{
	m_UDTeam = UDteam;
}

void CGame::SetUDline(std::string UDline)
{
	m_UDline = UDline;
}

void CGame::SetUDPts(float UDpts)
{
	m_UDpts = UDpts;
}

void CGame::SetAwayRank(std::string awayRank)
{
	m_AwayRank = awayRank;
}

void CGame::SetHomeRank(std::string homeRank)
{
	m_HomeRank = homeRank;
}

void CGame::SetUDrank(std::string UDrank)
{
	m_UDrank = UDrank;
}

void CGame::SetAwayConf(std::string awayConf)
{
	m_AwayConf = awayConf;
}

void CGame::SetHomeConf(std::string homeConf)
{
	m_HomeConf = homeConf;
}

void CGame::SetDate(std::string date)
{
	m_Date = date;
}

void CGame::SetAwayScore(int awayScore)
{
	m_AwayScore = awayScore;
}

void CGame::SetHomeScore(int homeScore)
{
	m_HomeScore = homeScore;
}

void CGame::SetJMCgamePick(std::string JMCgamePick)
{
	m_JMCgamePick = JMCgamePick;
}

void CGame::SetJCRgamePick(std::string JCRgamePick)
{
	m_JCRgamePick = JCRgamePick;
}

void CGame::SetJMCspreadPick(std::string JMCspreadPick)
{
	m_JMCspreadPick = JMCspreadPick;
}

void CGame::SetJCRspreadPick(std::string JCRspreadPick)
{
	m_JCRspreadPick = JCRspreadPick;
}

void CGame::SetTeamGameWinner(std::string teamGameWinner)
{
	m_WinnerGame = teamGameWinner;
}

void CGame::SetTeamSpreadWinner(std::string teamSpreadWinner)
{
	m_WinnerSpread = teamSpreadWinner;
}

void CGame::SetJMCwinGame(bool JMCwinGame)
{
	m_JMCwinGame = JMCwinGame;
}

void CGame::SetJCRwinGame(bool JCRwinGame)
{
	m_JCRwinGame = JCRwinGame;
}

void CGame::SetJMCwinSpread(bool JMCwinSpread)
{
	m_JMCwinSpread = JMCwinSpread;
}

void CGame::SetJCRwinSpread(bool JCRwinSpread)
{
	m_JCRwinSpread = JCRwinSpread;
}

void CGame::SetGameType(std::string gameType)
{
	m_GameType = gameType;
}

void CGame::SetSeason(std::string season)
{
	m_Season = season;
}

void CGame::SetSheet(std::string sheet)
{
	m_Sheet = sheet;
}

void CGame::SetGameNum(int gameNum)
{
	m_GameNum = gameNum;
}

void CGame::SetGameID(std::string gameID)
{
	m_GameID = gameID;
}


