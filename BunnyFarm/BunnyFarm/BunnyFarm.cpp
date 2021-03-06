// BunnyFarm.cpp : Defines the entry point for the console application.
//
// using concepts and ideas from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// 
// 2016-09-20 pm - working on BreedBunnies()
// 2016-09-22 latest update - all appears to be working; tons of debugging cin and cout; 
//            TO DO LIST
//            Menu to auto play to end
//            remove all debugging items and unneeded comments
//
//            BONUS - add 3rd column for output log ( bunny born, bunny died, bunny turned into rmvb, bunnies moved, etc.
//                    keep detailed log in vector<string> and output 3rd column is short (bred 3 bunnies, killed 10 bunnies, etc.)
//            BONUS - learn to write info to a file to play back later

// output menu column is 90 - 135. start log column at 140

// how to cull
// when total bunnies = 1000 or menu item is executed, randomly kill 1/2 of the population (total bunnies / 2)
// how to randomize killings..... 
// maybe create vector of bunnies and pick (total bunnies/2) random iterations -- ?? how to create the vector - maybe pIter through list of bunnies
// don't think the above is practical... lots of coding to update linked list
// how about generating a random # between 0 and total bunnies, then pIter through the list rnd times, then DelBunny. Generate another # and repeat.
// 2016-09-22 pm... working on cull routine


#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>

//the following line is necessary for the
//  GetConsoleWindow() function to work!
//it basically says that you are running this
//  program on Windows 2000 or higher
#define _WIN32_WINNT 0x0500

//it is important that the above line be typed
//  BEFORE <windows.h> is included



#include <Windows.h>
#include <time.h>
#include <iomanip>

#include <fstream>


// global constants
const int MAX_BOARD_ROW = 80;
const int MAX_BOARD_COL = 80;
const int OUTPUT_COL    = 90;



using namespace std;


// prototypes
int getRandNum(int min, int max); 
char getRandomSex(int age);
bool isRMVB();

void Gotoxy(int x, int y)   //moves the cursor in the console window x = column, y = row
{
	COORD point;
	point.X = x+3;
	point.Y = y+1;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), point);
}


class Bunny
{
public:
	Bunny(const string& name = "", const int& age = 0, const char& sex = ' ', const bool& isRMVB = false, const int& r = 0, const int& c = 0);
	string GetName() const;
	int GetAge() const;
	void SetAge(int age);
	char GetSex() const;
	void SetSex(char sex);
	bool GetRMVB() const;
	void SetRMVB(bool isRMVB);
	int GetRow() const;
	void SetRow(int r);
	int GetCol() const;
	void SetCol(int c);


	Bunny* GetNext() const;
	void SetNext(Bunny* next);

private:
	string         m_Name;    // determined from a pre-defined list of names listOfNames
	int            m_Age;     // 0-10 ages 1 year with each turn / dies at 10 years unless rmvb, which die at age 50
	char           m_Sex;     // ADULT (M)ale (F)emale OR JUVENILE (m)ale (f)emale OR (X) indicates rmvb and does not breed        
	string         m_Color;   // white, brown, black, spotted
	bool           m_IsRMVB;  // radioactive_mutant_vampire_bunny (RMVB) true / false
	int            m_Row;     // row coord of bunny on 80 x 80 grid
	int            m_Col;     // col coord of bunny on 80 x 80 grid
	Bunny*         m_pNext;   // pointer to next bunny in the list
};

Bunny::Bunny(const string& name, const int& age, const char& sex, const bool& isRMVB, const int& r, const int& c) : // constructor used to assign the name passed to the class to m_Name
	m_Name(name),
	m_Age(age),
	m_Sex(sex),
	m_IsRMVB(isRMVB),
	m_Row(r),
	m_Col(c),
	m_pNext(0)
{} // empty constructor body

string Bunny::GetName() const
{
	return m_Name;
}

int Bunny::GetAge() const
{
	return m_Age;
}

void Bunny::SetAge(int age)
{
	m_Age = age;
}

char Bunny::GetSex() const
{
	return m_Sex;
}

void Bunny::SetSex(char sex)
{
	m_Sex = sex;
}

bool Bunny::GetRMVB() const
{
	return m_IsRMVB;
}

void Bunny::SetRMVB(bool isRMVB)
{
	m_IsRMVB = isRMVB;
}

int Bunny::GetRow() const
{
	return m_Row;
}

void Bunny::SetRow(int r)
{
	m_Row = r;
}

int Bunny::GetCol() const
{
	return m_Col;
}

void Bunny::SetCol(int c)
{
	m_Col = c;
}

Bunny* Bunny::GetNext() const
{
	return m_pNext;
}

void Bunny::SetNext(Bunny* next)
{
	m_pNext = next;
}


class BunnyFarm
{
	friend ostream& operator<<(ostream& os, BunnyFarm& aBunnyFarm);
	//friend ostream& operator<<(ostream& oStats, BunnyFarm& aBunnyFarm);

public:
	BunnyFarm();        // constructor
	~BunnyFarm();       // destructor

	int s_NumAdultMales;
	int s_NumAdultFemales;
	int s_NumJuvMales;
	int s_NumJuvFemales;
	int s_NumMales;
	int s_NumFemales;
	int s_NumBirths;
	int s_NumDeaths;
	int s_NumRMVB;
	int s_TotalBunnies;
	int s_NumOfTurns;
	vector<int> RowsToChange; // row nums to change to RMVB - corresponds to col vector below
	vector<int> ColsToChange; // col nums to change to RMVB - corresponds to row vector above
	vector<Bunny*> ChangeToRMVB;
	vector<string> BunnyLog;

	char Board[MAX_BOARD_ROW][MAX_BOARD_COL]; // 80 x 80 game board
	int  oRow;          // output row
	const int oCol = 90;           // output col
	const int lCol = 140;          // log output col
	int lRow;          // log output row


	void InitBoard();   // initialize game board with '.'
	void DrawBoard();   // draw the game board;
	void InitBunnies(); // initialize first 5 bunnies
	void InitStats(); // initialize stats
	bool CheckCoords(int r, int c); // check the random coords assigned to see if they are already taken
	void AdvBunnyAges(); // increase age of all bunnies
	void MainMenu();    // writes the menu to the screen
	void AddBunny(bool birth, int momR, int momC);    // addBunny instantiates a Bunny object on the heap and adds it to the end of the list
	void DelFirstBunny();    // DelFirstBunny removes the first Bunny object in the list
	void DelBunny(Bunny* delThisBunny, Bunny* prevBunny);     // deletes a bunny
	void MoveAllBunnies(); // move all bunnies in a random direction
	bool CheckNewCoords(int mR, int mC); // checks new coordinates for valid coords
	bool CheckRMVBCoords(int mR, int mC); // checks new coordinates for valid RMVB conversion of bunny
	void CheckForBunnyDeaths(); // checks all bunnies for age 10. if 10, remove them from the list and board
	void BreedBunnies(); // reproduce bunnies based on number of adult males and females. requires at least 1 adult male and 1 adult female.
	void ConvertRMVBs(); // convert bunnies adjacent to existing RMVBs to RMVBs
	void ClearFarm();   // clearFarm removes all the bunny objects from the farm list, freeing the allocated memory
	void ListBunnies(BunnyFarm& rMyBunnyFarm); // lists all the bunnies and their attributes
	void PrintStats();
	void ClearOutput(); // clears the output side
	void TakeTurn(); // move all bunnies, advance ages, check for deaths, breed
	void UpdateStats(); // update all the statistics
	bool GetAdjCoords(bool checkingForRMVB, int r, int c, int& mR, int& mC); // used to find empty adj coords from given coords
	bool AnyBlanksAroundBunny(int r, int c); // test to see if there are any blank spaces around bunny
	bool AnyBunnyAroundRMVB(int r, int c); // test to see if there are any bunnies around an RMVB bunny
	void CullBunnyFluffle();
	void CheckIfCullingNeeded(); // check to see if population has reached 1000. if so, cull bunnies
	void SendInfoToLog(const string logEntry);

private:
	Bunny* m_pHead;     // pointer to a Bunny object which represents the first bunny in the list
	Bunny* m_pLast;     // pointer to the last Bunny object in the list
};

// farm constructor
BunnyFarm::BunnyFarm() :
	m_pHead(0),
	m_pLast(0)
{
	oRow = 0;
}

// farm destructor
// calls clearFarm which removes all the bunny objects from the farm list, freeing the allocated memory
BunnyFarm::~BunnyFarm()
{
	SendInfoToLog("Clearing the farm.");
	ClearFarm();
}

void BunnyFarm::SendInfoToLog(const string logEntry)
{
	int& lR = lRow;
	int lC = lCol;

	BunnyLog.push_back(logEntry);
	Gotoxy(lC, lR); cout << logEntry << endl; lR++;

}

void BunnyFarm::CullBunnyFluffle()
{
	Bunny* pThis = m_pHead;
	Bunny* pPrev = m_pHead;
	//int i = 0;
	int totalToCull = s_TotalBunnies / 2;
	int tBunnies = totalToCull;
	int cullBunnyNum;
	int&r = oRow;
	int c = oCol;

	SendInfoToLog("Culling the farm of " + to_string(totalToCull) + ".");

	for (int i = 0; i < totalToCull; ++i)
	{
		
		cullBunnyNum = getRandNum(0, tBunnies); // get a random # between 0 and tBunnies, which is the running total of the number of bunnies left

		for (int j = 0; j < cullBunnyNum - 1; ++j) // using cullBunnyNum - 1 to get the PREVIOUS bunny. this way I can link previous to next easily
		{
			pPrev = pPrev->GetNext();
		}

		pThis = pPrev->GetNext();
		pPrev->SetNext(pThis->GetNext());
		int delR, delC;
		delR = pThis->GetRow();
		delC = pThis->GetCol();
		Board[delR][delC] = '.';
		delete pThis;
		tBunnies -= 1; // decrease tBunnies since we killed one.

		pThis = m_pHead;
		pPrev = m_pHead;
	}

	DrawBoard();
	UpdateStats();
}

void BunnyFarm::CheckIfCullingNeeded()
{
	if (s_TotalBunnies >= 1000)
	{
		CullBunnyFluffle();
	}
}



void BunnyFarm::TakeTurn()
{
	int numTurns = 0;
	int& r = oRow;
	int c = oCol;

	ClearOutput();
	Gotoxy(c, r); cout << "How many turns to you want to take? "; cin >> numTurns; getchar(); r++;

	for (int i = 0; i < numTurns; ++i)
	{
		SendInfoToLog("Taking turn #" + to_string(i) + ".");
		ConvertRMVBs();
		MoveAllBunnies();		
		BreedBunnies();
		AdvBunnyAges();
		CheckForBunnyDeaths();
		CheckIfCullingNeeded();

		s_NumOfTurns += 1;
	}

	UpdateStats();
}



void BunnyFarm::BreedBunnies()
{
	Bunny* pIter = m_pHead;
	bool okToBreed = false;
	int momR, momC;
	bool birth = true;
	bool ableToGiveBirth = false;

	if (s_NumAdultMales >= 1 && s_NumAdultFemales >= 1)
	{
		while (pIter != 0)
		{
			if (pIter->GetSex() == 'F')
			{
				momR = pIter->GetRow();
				momC = pIter->GetCol();
				ableToGiveBirth = AnyBlanksAroundBunny(momR, momC);
				if (ableToGiveBirth)
				{
					AddBunny(birth, momR, momC);
				}
			}

			pIter = pIter->GetNext();
		}
	}
	else
		return;


	UpdateStats();
}

void BunnyFarm::ConvertRMVBs()
{
	Bunny* pIter = m_pHead;
	
	bool okToBreed = false;
	int rmvbR, rmvbC;
	int adjR, adjC;
	bool birth = true;
	bool findAdjRMVB = false;

	RowsToChange.clear();
	ColsToChange.clear();
	ChangeToRMVB.clear();
	if (s_NumRMVB > 0)
	{
		

		while (pIter != 0)
		{
			if (pIter->GetSex() == 'X')
			{
				rmvbR = pIter->GetRow();
				rmvbC = pIter->GetCol();
				findAdjRMVB = AnyBunnyAroundRMVB(rmvbR, rmvbC);
				if (findAdjRMVB)
				{
					adjR = rmvbR;
					adjC = rmvbC;
					GetAdjCoords(true, rmvbR, rmvbC, adjR, adjC); // using true since checking for RMVB situation and not bunny situation
					// need to find the pIter of the chosen bunny to change to RMVB... maybe try to match the coords found above?
					Bunny* rmvbIter = m_pHead;
					while (rmvbIter != 0)
					{
						if (rmvbIter->GetRow() == adjR)
							if (rmvbIter->GetCol() == adjC)
							{
								int& r = oRow;
								int c = oCol;
								ChangeToRMVB.push_back(rmvbIter);
							}
						rmvbIter = rmvbIter->GetNext();
					}
				}
			}

			pIter = pIter->GetNext();
		}
		int iR, iC; // use these to iterate through the vectors and change the bunnies at iR,iC to RMVB
		int numBunniesToChange = ChangeToRMVB.size();
		int& r = oRow;
		int c = oCol;
		for (int i = 0; i < numBunniesToChange; ++i)
		{
			iR = ChangeToRMVB[i]->GetRow();
			iC = ChangeToRMVB[i]->GetCol();
			SendInfoToLog("Converting " + ChangeToRMVB[i]->GetName() + " at " + to_string(iR) + "," + to_string(iC) + " to RMVB.");
			ChangeToRMVB[i]->SetSex('X');
			ChangeToRMVB[i]->SetRMVB(true);
			Board[iR][iC] = 'X';
			
		}
		UpdateStats();
	}
	DrawBoard();
	UpdateStats();
}


void BunnyFarm::UpdateStats()
{
	Bunny* pIter = m_pHead;

	s_NumAdultMales = 0;
	s_NumAdultFemales = 0;
	s_NumJuvMales = 0;
	s_NumJuvFemales = 0;
	s_NumMales = 0;
	s_NumFemales = 0;
	s_NumRMVB = 0;
	s_TotalBunnies = 0;
	

	while (pIter != 0)
	{
		s_TotalBunnies += 1;
		if (pIter->GetAge() > 1)
		{
			if (pIter->GetSex() == 'M')
			{
				s_NumAdultMales += 1;
				s_NumMales += 1;
			}
			else if (pIter->GetSex() == 'F')
			{
				s_NumAdultFemales += 1;
				s_NumFemales += 1;
			}
			else
			{
				s_NumRMVB += 1;
			}
		}
		else
		{
			if (pIter->GetSex() == 'm')
			{
				s_NumJuvMales += 1;
				s_NumMales += 1;
			}
			else if (pIter->GetSex() == 'f')
			{
				s_NumJuvFemales += 1;
				s_NumFemales += 1;
			}
			else
			{
				s_NumRMVB += 1;
			}
		}
		pIter = pIter->GetNext();
	}

	SendInfoToLog("Updating the statistics.");
}

void BunnyFarm::PrintStats()
{
	int& r = oRow;
	int c = oCol;

	int tM = s_NumMales;
	int tF = s_NumFemales;
	int tR = s_NumRMVB;
	int nJM = s_NumJuvMales;
	int nJF = s_NumJuvFemales;
	int nAM = s_NumAdultMales;
	int nAF = s_NumAdultFemales;
	int tB = s_TotalBunnies;
	int nB = s_NumBirths;
	int nD = s_NumDeaths;
	int tT = s_NumOfTurns;

	ClearOutput();

	Gotoxy(c, r); cout << "--------------------------" << endl; r++;
	Gotoxy(c, r); cout << "     BUNNY STATISTICS     " << endl; r++;
	Gotoxy(c, r); cout << "--------------------------" << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "Total Males: " << setw(4) << tM << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "Total Females: " << setw(4) << tF << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "RMVB: " << setw(4) << tR << endl; r++; r++;
	Gotoxy(c, r); cout << setw(20) << "TOTAL BUNNIES: " << setw(4) << tB << endl; r++; r++;
	Gotoxy(c, r); cout << setw(20) << "Adult Males: " << setw(4) << nAM << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "Adult Females: " << setw(4) << nAF << endl; r++; r++;
	Gotoxy(c, r); cout << setw(20) << "Juvenile Males: " << setw(4) << nJM << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "Juvenile Females: " << setw(4) << nJF << endl; r++; r++;
	Gotoxy(c, r); cout << setw(20) << "Births: " << setw(4) << nB << endl; r++;
	Gotoxy(c, r); cout << setw(20) << "Deaths: " << setw(4) << nD << endl; r++; r++;
	Gotoxy(c, r); cout << setw(20) << "Total turns taken: " << setw(4) << tT << endl; r++; r++;

	Gotoxy(c, r); cout << "Press any key to continue..."; r++;
	cin.get();
	ClearOutput();
}

void BunnyFarm::InitStats()
{
	s_NumAdultMales = 0;
	s_NumAdultFemales = 0;
	s_NumJuvMales = 0;
	s_NumJuvFemales = 0;
	s_NumMales = 0;
	s_NumFemales = 0;
	s_NumBirths = 0;
	s_NumDeaths = 0;
	s_NumRMVB = 0;
	s_TotalBunnies = 0;
	s_NumOfTurns = 0;

	SendInfoToLog("Initializing the statistics.");
}

void BunnyFarm::InitBunnies()
{
	for (int i = 0; i < 5; ++i)
	{
		AddBunny(false,0,0);
	}
	// above lines are correct. below lines are for testing only.
	//AddBunny(false, 10, 10);
	//AddBunny(false, 9, 10);
	//AddBunny(false, 11, 10);
	//AddBunny(false, 10, 9);
	//AddBunny(false, 10, 11);
	SendInfoToLog("Initializing the bunnies.");
	UpdateStats();
}

void BunnyFarm::AdvBunnyAges()
{
	Bunny* pIter = m_pHead;
	int age;
	char sex;
	int r, c;

	while (pIter != 0)
	{
		age = pIter->GetAge();
		age += 1;
		pIter->SetAge(age);
		sex = pIter->GetSex();
		if (age == 2)
		{
			if (sex == 'm')
			{
				sex = 'M';
			}
			else if (sex == 'f')
			{
				sex = 'F';
			}
			r = pIter->GetRow();
			c = pIter->GetCol();
			Board[r][c] = sex;
			DrawBoard();
			pIter->SetSex(sex);
		}

		pIter = pIter->GetNext();
	}
	SendInfoToLog("Advancing the ages of all bunnies.");
}

bool BunnyFarm::CheckNewCoords(int mR, int mC)
{
	if (mR < 0 || mR >= MAX_BOARD_ROW || mC < 0 || mC >= MAX_BOARD_COL) // if the coordinates are outside the bounds of the board
	{
		return false;
	}
	else
	{
		if (Board[mR][mC] != '.')
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}

bool BunnyFarm::CheckRMVBCoords(int mR, int mC)
{
	if (mR < 0 || mR >= MAX_BOARD_ROW || mC < 0 || mC >= MAX_BOARD_COL) // if the coordinates are outside the bounds of the board
	{
		return false;
	}
	else
	{
		if (Board[mR][mC] == '.' || Board[mR][mC] == 'X')
		{
			return false;
		}
		else
		{
			return true;
		}
	}
}



bool BunnyFarm::GetAdjCoords(bool checkingForRMVB, int momR, int momC, int& adjR, int& adjC)
{
	// assume that the coordinates of the mom DO have a blank space around them. no need to test for that.
	// given mom's r,c coords, find adj blank adjR and adjC coords

	bool triedUp = false, triedDown = false, triedLeft = false, triedRight = false;
	bool triedAllDirections = false;
	int checkR, checkC;
	bool checkCoords = false;
	bool found = false;
	int direction;
	int& r = oRow;
	int c = oCol;

	do
	{
		checkR = momR;
		checkC = momC;

		direction = ::getRandNum(0, 3);

		switch (direction)
		{
		case 0:
			triedUp = true;
			checkR -= 1;
			break;
		case 1:
			triedDown = true;
			checkR += 1;
			break;
		case 2:
			triedLeft = true;
			checkC -= 1;
			break;
		case 3:
			triedRight = true;
			checkC += 1;
			break;
		default:
			break;
		}

		if (checkingForRMVB)
		{
			checkCoords = CheckRMVBCoords(checkR, checkC);
		}
		else 
			checkCoords = CheckNewCoords(checkR, checkC);



		if (checkCoords) // if proposed coords are valid then
		{
			found = true; // valid coords have been found!
		}
		else if (triedUp && triedDown && triedLeft && triedRight)
		{
			triedAllDirections = true;
			found = false;
			return false;
		}

	} while (!found && !triedAllDirections);
	if (found = true)
	{
		adjR = checkR; // returns reference
		adjC = checkC; // returns reference
		return true;
	}
	else
		return false;
}

bool BunnyFarm::AnyBlanksAroundBunny(int r, int c)
{
	bool found = false;
	if (r + 1 < MAX_BOARD_ROW)
	{
		if (Board[r + 1][c] == '.')
		{
			found = true;
		}
		else if (r - 1 >= 0)
		{
			if (Board[r - 1][c] == '.')
			{
				found = true;
			}

			else if (c + 1 < MAX_BOARD_COL)
			{
				if (Board[r][c + 1] == '.')
				{
					found = true;
				}
				else if (c - 1 >= 0)
				{
					if (Board[r][c - 1] == '.')
					{
						found = true;
					}
				}
			}
		}
	}
	else
		found = false;

	return found;
}

bool BunnyFarm::AnyBunnyAroundRMVB(int r, int c)
{
	bool found = false;
	if (r + 1 < MAX_BOARD_ROW)
	{
		if (Board[r + 1][c] != '.' && Board[r + 1][c] != 'X')
		{
			found = true;
		}
		else if (r - 1 >= 0)
		{
			if (Board[r - 1][c] != '.' && Board[r - 1][c] != 'X')
			{
				found = true;
			}

			else if (c + 1 < MAX_BOARD_COL)
			{
				if (Board[r][c + 1] != '.' && Board[r][c + 1] != 'X')
				{
					found = true;
				}
				else if (c - 1 >= 0)
				{
					if (Board[r][c - 1] != '.' && Board[r][c - 1] != 'X')
					{
						found = true;
					}
				}
			}
		}
	}
	else
		found = false;

	return found;
}



void BunnyFarm::MoveAllBunnies()
{
	Bunny* pIter = m_pHead;

	char marker;
	int direction; // 0, 1, 2, 3 used for up, down, left, right
	bool triedUp = false, triedDown = false, triedLeft = false, triedRight = false;
	bool triedAllDirections = false;
	bool canMove = false;
	int r, c; 
	int mR, mC; // used to test proposed movement coordinates

	while (pIter != 0)
	{
		r = pIter->GetRow();
		c = pIter->GetCol();

		if (AnyBlanksAroundBunny(r, c))
		{
			mR = r;
			mC = c;
			marker = pIter->GetSex();
			GetAdjCoords(false, r, c, mR, mC); // false is for checking RMVBs
			Board[r][c] = '.';
			Board[mR][mC] = marker;
			pIter->SetRow(mR);
			pIter->SetCol(mC);
		}
		pIter = pIter->GetNext();
	}
	SendInfoToLog("Moving all bunnies to an adjacent space.");
	DrawBoard();
}

void BunnyFarm::ClearOutput()
{
	int& r = oRow;
	int c = oCol;

	r = 0;

	for (int i = 0; i < 82; ++i)
	{
		Gotoxy(c, r); cout << "                                             " << endl; r++;
	}
	r = 0; // reset output row
}

void BunnyFarm::ListBunnies(BunnyFarm& rMyBunnyFarm)
{
	int& r = oRow;
	int c = oCol;

	r = 0;
	ClearOutput();
	SendInfoToLog("Printing the bunny list.");
	Gotoxy(c, r); cout << rMyBunnyFarm; r++; r++;
	Gotoxy(c, r); cout << "Press any key to continue..."; r++;
	cin.get();
	ClearOutput();
}

void BunnyFarm::InitBoard()
{
	int r, c;

	for (r = 0; r < MAX_BOARD_ROW; ++r)
		for (c = 0; c < MAX_BOARD_COL; ++c)
			Board[r][c] = '.';

	SendInfoToLog("Initializing the game board.");
}

void BunnyFarm::DrawBoard()
{
	int r, c, i;

	::Gotoxy(0, 0);

	for (i = 0; i < MAX_BOARD_COL; ++i)
	{
		if (i == 0)
			cout << "0";
		else
			if (i % 10 == 0)
				cout << i / 10;
			else
				cout << " ";
	}
	cout << "\n";


	for (r = 0; r < MAX_BOARD_ROW; ++r)
	{
		cout << setw(2) << r << " ";

		for (c = 0; c < MAX_BOARD_COL; ++c)
		{
			cout << Board[r][c];

		}
		cout << setw(3) << r << "\n";

	}

	for (i = 0; i < MAX_BOARD_COL; ++i)
	{
		if (i == 0)
			cout << "   0";
		else
			if (i % 10 == 0)
				cout << i / 10;
			else
				cout << " ";
	}
	cout << "\n";

	SendInfoToLog("Drawing the game board.");
}

bool BunnyFarm::CheckCoords(int r, int c)
{
	if (Board[r][c] = '.')
	{
		return true;  // is empty and valid
	}
	else
	{
		return false; // is not empty and invalid
	}
}

void BunnyFarm::MainMenu()
{
	int& r = oRow;
	int c = oCol;

	ClearOutput();
	r = 0; // reset output row to the top of the screen

	Gotoxy(c, r); cout << "BUNNY FARM MENU" << endl; r++;
	Gotoxy(c, r); cout << "0 - Exit the program." << endl; r++;
	Gotoxy(c, r); cout << "1 - Add a bunny to the farm." << endl; r++;
	Gotoxy(c, r); cout << "2 - Take turn(s)." << endl; r++;
	Gotoxy(c, r); cout << "3 - Clear the bunny farm." << endl; r++;
	Gotoxy(c, r); cout << "4 - List bunnies." << endl; r++;
	Gotoxy(c, r); cout << "5 - Advance all bunny ages." << endl; r++;
	Gotoxy(c, r); cout << "6 - Check for bunny deaths." << endl; r++;
	Gotoxy(c, r); cout << "7 - Move all bunnies." << endl; r++;
	Gotoxy(c, r); cout << "8 - Breed bunnies." << endl; r++;
	Gotoxy(c, r); cout << "9 - Print stats." << endl; r++;
	Gotoxy(c, r); cout << "I - Initialize bunnies." << endl; r++;
	Gotoxy(c, r); cout << "K - Cull bunny farm." << endl; r++;
	Gotoxy(c, r); cout << endl; r++;
	Gotoxy(c, r); cout << "Enter your choice: "; r++;
}

// addBunny adds a player to the end of the list in the bunnyFarm
void BunnyFarm::AddBunny(bool birth, int momR, int momC)
{
	// create a new bunny node
	// if birth is true, then coords are next to mom's
	// if birth is false, then coords are random

	int min = 0, maxNames = 13;
	int rnd;
	string bunnyNames[14] =
	{
		{ "Thumper" },
		{ "Cottontail" },
		{ "Peter" },
		{ "Beatrix" },
		{ "Brer Rabbit" },
		{ "Trix" },
		{ "Payton" },
		{ "Jenny" },
		{ "Barbara" },
		{ "Tashi" },
		{ "Jason" },
		{ "Harry" },
		{ "Russell" },
		{ "Ryan" }
	};
	string name;
	int age;
	char sex;
	bool isRMVB = false;
	int r, c;
	bool goodCoords = false;
	//bool found = false;
	bool canGiveBirth = false;
	
	if (birth)
	{
		canGiveBirth = AnyBlanksAroundBunny(momR, momC);
		if (canGiveBirth)
		{

		}
		else
			return; // unable to give birth
	}

	// continue adding bunny since either canGiveBirth or this is not a birth, but a random bunny

	rnd = ::getRandNum(min, maxNames);	
	name = bunnyNames[rnd]; // assign a random name from list of names

	if (birth) // if true, then this is a birth and age should be 0
	{
		age = 0;
		s_NumBirths += 1;
	}
	else  // otherwise (false) this is a random bunny and age should be random
	{
		age = ::getRandNum(0, 9);
	}

	sex = ::getRandomSex(age);

	if (::isRMVB())
	{
		sex = 'X';
		isRMVB = true;
	}


	while (!goodCoords)
	{
		if (birth)
		{
			r = momR;
			c = momC;
			GetAdjCoords(false, momR, momC, r, c);
		}
		else
		{
			//r = momR;
			//c = momC;
			// below lines are for regular program. above lines are for testing only
			r = ::getRandNum(0, MAX_BOARD_ROW - 1);
			c = ::getRandNum(0, MAX_BOARD_COL - 1);
			//found = true;
		}
		goodCoords = CheckCoords(r, c);
	}

	Board[r][c] = sex; // update the board
	Gotoxy(0, 0);
	DrawBoard();

	if (birth)
	{
		SendInfoToLog("Birth: " + name + " " + to_string(age) + " " + sex + " " + to_string(isRMVB) + " " + to_string(r) + "," + to_string(c));
	}
	else
	{
		SendInfoToLog("Adding: " + name + " " + to_string(age) + " " + sex + " " + to_string(isRMVB) + " " + to_string(r) + "," + to_string(c));
	}

	Bunny* pNewBunny = new Bunny(name, age, sex, isRMVB, r, c); // instantiate a new Bunny object on the heap, setting the object's pointer data member to 0 (null)

	// if list is empty, make head of list this new bunny
	if (m_pHead == 0)
	{
		m_pHead = pNewBunny; // since list was empty, the first (head) is the new bunny
		m_pLast = pNewBunny; // since list was empty, last is also the new bunny
	}

	// otherwise go to the end of the list and add the player there
	else
	{
		Bunny* pIter = m_pLast;       // go to the last bunny
		m_pLast->SetNext(pNewBunny);  // set next to point to the new bunny. last becomes "next to last"
		m_pLast = pNewBunny;          // set last bunny to the new bunny
	}
	//s_TotalBunnies += 1;
	UpdateStats();
}



// DelFirstBunny removes the bunny at the head of the list
void BunnyFarm::DelFirstBunny()
{
	SendInfoToLog("Starting DelFirstBunny function.");
	// test m_pHead. if it is 0, then the farm is empty
	if (m_pHead == 0)
	{
		SendInfoToLog("The bunny farm is empty. No bunnies to delete!");
		cout << "The Bunny Farm is empty. No bunnies to remove!" << endl;
	}
	else // otherwise, the first bunny in the list is removed.
	{
		Bunny* pTemp = m_pHead;         // temp points to the first bunny in the list
		int r = pTemp->GetRow();
		int c = pTemp->GetCol();
		Board[r][c] = '.';
		m_pHead = m_pHead->GetNext();   // sets m_pHead to the next bunny in the list
		SendInfoToLog("Deleting " + pTemp->GetName() + " at coords " + to_string(pTemp->GetRow()) + "," + to_string(pTemp->GetCol()) + ".");
		delete pTemp;                   // destroys the Bunny object pointed to by pTemp
	}
	UpdateStats();
	s_NumDeaths += 1;
	DrawBoard();
}
// DelBunny removes the bunny at the head of the list
void BunnyFarm::DelBunny(Bunny* delThisBunny, Bunny* prevBunny)
{
	SendInfoToLog("Starting DelBunny function.");
	Bunny* pTemp = delThisBunny;         // temp points to the first bunny in the list
	int r = pTemp->GetRow();
	int c = pTemp->GetCol();
	Board[r][c] = '.';
	SendInfoToLog("Deleting " + pTemp->GetName() + " at coords " + to_string(pTemp->GetRow()) + "," + to_string(pTemp->GetCol()) + ".");
	delete pTemp;                   // destroys the Bunny object pointed to by pTemp
	
	UpdateStats();
	s_NumDeaths += 1;
	DrawBoard();
}

void BunnyFarm::CheckForBunnyDeaths()
{
	Bunny* pThis = m_pHead;
	Bunny* pPrev = m_pHead;

	int age;
	char sex;

	SendInfoToLog("Starting CheckForBunnyDeaths function.");

	if (pThis == 0)
		return;
	while (pThis != 0)
	{
		age = pThis->GetAge();
		sex = pThis->GetSex();

		while ( (age == 10 && sex != 'X') || (age == 50 && sex == 'X') )
		{
			SendInfoToLog("Deleting " + pThis->GetName() + " at coords " + to_string(pThis->GetRow()) + "," + to_string(pThis->GetCol()));
			DelFirstBunny();
			pThis = m_pHead;
			if (pThis == 0)
				return;
			age = pThis->GetAge(); // after deleting first bunny, pThis is the new head and need to reset age and sex
			sex = pThis->GetSex(); // resetting sex. see above
		}

		pPrev = m_pHead;
		pThis = m_pHead->GetNext();

		while (pThis != 0)
		{
			age = pThis->GetAge();
			sex = pThis->GetSex();

			if ( (age == 10 && sex != 'X') || (age == 50 && sex == 'X') )
			{
				pPrev->SetNext(pThis->GetNext()); // set prev bunny's next to this bunny's next
				SendInfoToLog("Deleting " + pThis->GetName() + " at coords " + to_string(pThis->GetRow()) + "," + to_string(pThis->GetCol()));
				DelBunny(pThis, pPrev);
			}
			else
			{
				pPrev = pThis;
			}

			pThis = pPrev->GetNext();
		}
	}
}


// ClearFarm removes all the bunnies from the farm
void BunnyFarm::ClearFarm()
{
	while (m_pHead != 0)
	{
		SendInfoToLog("Clearing the entire farm.");
		DelFirstBunny();
	}

	ClearOutput();
	InitStats();
}

// operator<<() function overloads the << operator so I can display a BunnyFarm objecct by sending it to cout
ostream& operator<<(ostream& os, BunnyFarm& aBunnyFarm)
{
	Bunny* pIter = aBunnyFarm.m_pHead;
	string name;
	int age;
	char sex;
	bool isRMVB;
	int row;
	int col;
	int& r = aBunnyFarm.oRow;
	int c = aBunnyFarm.oCol;

	if (pIter == 0) // if farm is empty send appropriate message
	{
		Gotoxy(c, r); os << "The farm is empty!" << endl; r++;
	}
	else // otherwise cycle through all the bunnies on the farm, creating an output stream os of all the names
	{
		while (pIter != 0)
		{
			name = pIter->GetName();
			age = pIter->GetAge();
			sex = pIter->GetSex();
			isRMVB = pIter->GetRMVB();
			row = pIter->GetRow();
			col = pIter->GetCol();

			Gotoxy(c, r); os << setw(12) << name << " ";
			os << setw(3) << age << " ";
			os << setw(3) << sex << " ";
			os << setw(6) << boolalpha << isRMVB << " ";
			os << setw(2) << row << "," << setw(2) << col << endl;
			
			r++;
			pIter = pIter->GetNext();
		}
	}
	return os;
}



int getRandNum(int min, int max)
{
	return min + (rand() % (int)(max - min + 1));
}

bool isRMVB()
{
	const int RMVB_PERCENT = 2; // default is 2%
	return (rand() % 100) < RMVB_PERCENT; // returns true RMVB_PERCENT of the time
}

char getRandomSex(int age)
{
	int min, max;
	int sex_num;

	min = 0; // (F)emale
	max = 1; // (M)ale

	sex_num = getRandNum(min, max);

	if (age > 1)
	{
		if (sex_num == 0)
		{
			return 'F';
		}
		else
		{
			return 'M';
		}
	}
	else
		if (sex_num == 0)
		{
			return 'f';
		}
		else
		{
			return 'm';
		}
}


int main()
{

	HWND console = GetConsoleWindow();
	RECT r;
	GetWindowRect(console, &r); //stores the console's current dimensions

								//MoveWindow(window_handle, x, y, width, height, redraw_window);
	//MoveWindow(console, r.left, r.top, 1500, 1050, TRUE);
	MoveWindow(console, 0, 0, 1500, 1050, TRUE);

	srand((unsigned)time(NULL)); // generate random seed each time the program runs

	BunnyFarm myBunnyFarm; // instantiates a new BunnyFarm
	BunnyFarm& rMyBunnyFarm = myBunnyFarm;
	//pMyBunnyFarm = myBunnyFarm; // pointer to myBunnyFarm

	char choice;

	myBunnyFarm.InitBoard();
	myBunnyFarm.DrawBoard();
	myBunnyFarm.InitStats();
	myBunnyFarm.InitBunnies();

	ofstream myfile;
	myfile.open("example.txt");
	myfile << "Writing this to a file.\n";
	myfile.close();

	cin.get();
	
	//cout << "Please enter input file name: ";
	//string iname;
	//cin >> iname;
	//ifstream ist{ iname }; // ist is an input stream for the file named name
	//if (!ist) error("can't open input file ", iname);

	do
	{
		//myBunnyFarm.ListBunnies(rMyBunnyFarm); // use this to print a list of bunnies from main()

		myBunnyFarm.MainMenu();
		cin >> choice;
		cin.get(); // gets ENTER from above cin >>
		choice = toupper(choice); // convert input to uppercase. makes input easier on user.

		switch (choice)
		{
		case '0': cout << "Goodbye." << endl; break;
		case '1': myBunnyFarm.AddBunny(false, 0,0); break;
		case '2': myBunnyFarm.TakeTurn(); break;
		case '3': myBunnyFarm.ClearFarm(); break;
		case '4': myBunnyFarm.ListBunnies(rMyBunnyFarm); break;
		case '5': myBunnyFarm.AdvBunnyAges(); break;
		case '6': myBunnyFarm.CheckForBunnyDeaths(); break;
		case '7': myBunnyFarm.MoveAllBunnies(); break;
		case '8': myBunnyFarm.BreedBunnies(); break;
		case '9': myBunnyFarm.PrintStats(); break;
		case 'I': myBunnyFarm.InitBunnies(); break;
		case 'K': myBunnyFarm.CullBunnyFluffle(); break;

		default: cout << "That was not a valid choice." << endl;
		}
	} while (choice != '0');

	
	
	system("cls");

	cout << endl << endl << "Press any key to end.";
	cin.get();
	system("cls");


	// restore output window size to same size as when starting program
	MoveWindow(console, r.left, r.top, r.right - r.left, r.bottom - r.top, TRUE);

	return 0;
}

