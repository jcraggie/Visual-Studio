#pragma once

#include <iostream>

class CGame
{
public:
	CGame();

	// getters
	std::string GetTime() const;
	std::string GetAwayTeam() const;
	std::string GetHomeTeam() const;
	std::string GetUDTeam() const;
	std::string GetUDline() const;
	int GetUDPts() const;
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

	// setters
	void SetTime(std::string time);
	void SetAwayTeam(std::string awayTeam);
	void SetHomeTeam(std::string homeTeam);
	void SetUDTeam(std::string UDteam);
	void SetUDline(std::string UDline);
	void SetUDPts(int UDpts);
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
private:
	std::string m_Time;
	std::string m_AwayTeam;
	std::string m_HomeTeam;
	std::string m_UDTeam;
	std::string m_UDline;
	int m_UDpts;
	std::string m_AwayRank;
	std::string m_HomeRank;
	std::string m_UDrank;
	std::string m_AwayConf;
	std::string m_HomeConf;
	std::string m_Date;
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
	std::string m_GameType; // CFB or NFL
	std::string m_Season; // season year
	std::string m_Sheet; // sheet number
};

CGame::CGame()
{

}

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

int CGame::GetUDPts() const
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

void CGame::SetUDPts(int UDpts)
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



