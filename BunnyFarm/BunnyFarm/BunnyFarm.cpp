// BunnyFarm.cpp : Defines the entry point for the console application.
//
// using concepts and ideas from Beginning C++ Through Game Programming 4th Edition by Michael Dawson
// 

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


// global constants
const int MAX_BOARD_ROW = 80;
const int MAX_BOARD_COL = 80;
const int OUTPUT_COL    = 90;



using namespace std;
// prototypes
int getRandNum(int min, int max); 
char getRandomSex(int age);

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
	Bunny(const string& name = "", const int& age = 0, const char& sex = ' ', const int& r = 0, const int& c = 0);
	string GetName() const;
	int GetAge() const;
	void SetAge(int age);
	char GetSex() const;
	void SetSex(char sex);
	int GetRow() const;
	int GetCol() const;


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

Bunny::Bunny(const string& name, const int& age, const char& sex, const int& r, const int& c) : // constructor used to assign the name passed to the class to m_Name
	m_Name(name),
	m_Age(age),
	m_Sex(sex),
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

int Bunny::GetRow() const
{
	return m_Row;
}

int Bunny::GetCol() const
{
	return m_Col;
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

public:
	BunnyFarm();        // constructor
	~BunnyFarm();       // destructor
	char Board[MAX_BOARD_ROW][MAX_BOARD_COL]; // 80 x 80 game board
	int  oRow;          // output row
	const int oCol = 90;           // output col

	void InitBoard();   // initialize game board with '.'
	void DrawBoard();   // draw the game board;
	void InitBunnies(); // initialize first 5 bunnies
	bool CheckCoords(int r, int c); // check the random coords assigned to see if they are already taken
	void AdvBunnyAges(); // increase age of all bunnies
	void MainMenu();    // writes the menu to the screen
	void AddBunny();    // addBunny instantiates a Bunny object on the heap and adds it to the end of the list
	void DelFirstBunny();    // DelFirstBunny removes the first Bunny object in the list
	void DelBunny(Bunny* delThisBunny, Bunny* prevBunny);     // deletes a bunny
	void CheckForBunnyDeaths(); // checks all bunnies for age 10. if 10, remove them from the list and board
	void ClearFarm();   // clearFarm removes all the bunny objects from the farm list, freeing the allocated memory
	void ListBunnies(BunnyFarm& rMyBunnyFarm); // lists all the bunnies and their attributes
	void ClearOutput(); // clears the output side

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
	ClearFarm();
}

void BunnyFarm::InitBunnies()
{
	for (int i = 0; i < 5; ++i)
	{
		AddBunny();
	}
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
}



void BunnyFarm::ClearOutput()
{
	int& r = oRow;
	int c = oCol;

	r = 0;

	for (int i = 0; i < 82; ++i)
	{
		Gotoxy(c, r); cout << "                                           " << endl; r++;
	}
	r = 0; // reset output row
}

void BunnyFarm::ListBunnies(BunnyFarm& rMyBunnyFarm)
{
	int& r = oRow;
	int c = oCol;

	r = 0;
	ClearOutput();
	//Gotoxy(r, c); cout << "ListBunnies" << endl; r++;
	Gotoxy(c, r); cout << rMyBunnyFarm; r++;
	Gotoxy(c, r); cout << "Press any key to continue..."; r++;
	cin.get();
	ClearOutput();
}

void BunnyFarm::InitBoard()
{
	//const int MAX_BOARD_ROW    = 79;
	//const int MAX_BOARD_COL = 79;
	int r, c;

	for (r = 0; r < MAX_BOARD_ROW; ++r)
		for (c = 0; c < MAX_BOARD_COL; ++c)
			Board[r][c] = '.';
}

void BunnyFarm::DrawBoard()
{
	int r, c, i;

	//system("cls"); // clear the screen and re-draw
	//cout << endl;
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
	Gotoxy(c, r); cout << "2 - Delete first bunny from the farm." << endl; r++;
	Gotoxy(c, r); cout << "3 - Clear the bunny farm." << endl; r++;
	Gotoxy(c, r); cout << "4 - List bunnies." << endl; r++;
	Gotoxy(c, r); cout << "5 - Advance all bunny ages." << endl; r++;
	Gotoxy(c, r); cout << "6 - Check for bunny deaths." << endl; r++;
	Gotoxy(c, r); cout << endl; r++;
	Gotoxy(c, r); cout << "Enter your choice: "; r++;
}

// addBunny adds a player to the end of the list in the bunnyFarm
void BunnyFarm::AddBunny()
{
	// create a new bunny node

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
	int r, c;
	bool goodCoords = false;
	

	rnd = ::getRandNum(min, maxNames);	
	name = bunnyNames[rnd]; // assign a random name from list of names
	age = ::getRandNum(0, 9);
	sex = ::getRandomSex(age);

	while (!goodCoords)
	{
		r = ::getRandNum(0, MAX_BOARD_ROW-1);
		c = ::getRandNum(0, MAX_BOARD_COL-1);
		goodCoords = CheckCoords(r, c);
	}
	Board[r][c] = sex; // update the board
	Gotoxy(0, 0);
	DrawBoard();



	Bunny* pNewBunny = new Bunny(name, age, sex, r, c); // instantiate a new Bunny object on the heap, setting the object's pointer data member to 0 (null)

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

}



// DelFirstBunny removes the bunny at the head of the list
void BunnyFarm::DelFirstBunny()
{
	// test m_pHead. if it is 0, then the farm is empty
	if (m_pHead == 0)
	{
		cout << "The Bunny Farm is empty. No bunnies to remove!" << endl;
	}
	else // otherwise, the first bunny in the list is removed.
	{
		Bunny* pTemp = m_pHead;         // temp points to the first bunny in the list
		int r = pTemp->GetRow();
		int c = pTemp->GetCol();
		Board[r][c] = '.';
		m_pHead = m_pHead->GetNext();   // sets m_pHead to the next bunny in the list
		delete pTemp;                   // destroys the Bunny object pointed to by pTemp
	}
	DrawBoard();
}
// DelBunny removes the bunny at the head of the list
void BunnyFarm::DelBunny(Bunny* delThisBunny, Bunny* prevBunny)
{
	
	Bunny* pTemp = delThisBunny;         // temp points to the first bunny in the list
	int r = pTemp->GetRow();
	int c = pTemp->GetCol();
	Board[r][c] = '.';
	//prevBunny->SetNext(pTemp->GetNext());
	//m_pHead = m_pHead->GetNext();   // sets m_pHead to the next bunny in the list
	delete pTemp;                   // destroys the Bunny object pointed to by pTemp
	
	DrawBoard();
}

void BunnyFarm::CheckForBunnyDeaths()
{
	Bunny* pThis = m_pHead;
	Bunny* pPrev = m_pHead;

	int age;
	if (pThis == 0)
		return;
	while (pThis != 0)
	{
		while (pThis->GetAge() == 10)
		{
			DelFirstBunny();
			pThis = m_pHead;
			if (pThis == 0)
				return;
		}

		pPrev = m_pHead;
		pThis = m_pHead->GetNext();

		while (pThis != 0)
		{
			age = pThis->GetAge();
			if (age == 10)
			{
				pPrev->SetNext(pThis->GetNext()); // set prev bunny's next to this bunny's next
				DelBunny(pThis, pPrev);
			}
			else
				pPrev = pThis;
			//pPrev = pPrev->GetNext();
			pThis = pPrev->GetNext();
		}
	}
}


// ClearFarm removes all the bunnies from the farm
void BunnyFarm::ClearFarm()
{
	while (m_pHead != 0)
	{
		DelFirstBunny();
	}
	//InitBoard();
	//DrawBoard();
	ClearOutput();
}

// operator<<() function overloads the << operator so I can display a BunnyFarm objecct by sending it to cout
ostream& operator<<(ostream& os, BunnyFarm& aBunnyFarm)
{
	Bunny* pIter = aBunnyFarm.m_pHead;
	string name;
	int age;
	char sex;
	int row;
	int col;
	int& r = aBunnyFarm.oRow;
	int c = aBunnyFarm.oCol;


	//os << endl << "Here's who is on the Bunny Farm:" << endl;

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
			row = pIter->GetRow();
			col = pIter->GetCol();

			Gotoxy(c, r); os << setw(12) << name << " " << setw(3) << age << " " << setw(3) << sex << " " << setw(2) << row << "," << setw(2) << col << endl;
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

	int choice;

	myBunnyFarm.InitBoard();
	myBunnyFarm.DrawBoard();
	myBunnyFarm.InitBunnies();

	do
	{
		//myBunnyFarm.ListBunnies(rMyBunnyFarm); // use this to print a list of bunnies from main()

		myBunnyFarm.MainMenu();
		cin >> choice;
		cin.get(); // gets ENTER from above cin >>

		switch (choice)
		{
		case 0: cout << "Goodbye." << endl; break;
		case 1: myBunnyFarm.AddBunny(); break;
		case 2: myBunnyFarm.DelFirstBunny(); break;
		case 3: myBunnyFarm.ClearFarm(); break;
		case 4: myBunnyFarm.ListBunnies(rMyBunnyFarm); break;
		case 5: myBunnyFarm.AdvBunnyAges(); break;
		case 6: myBunnyFarm.CheckForBunnyDeaths(); break;

		default: cout << "That was not a valid choice." << endl;
		}
	} while (choice != 0);

	
	
	system("cls");

	cout << endl << endl << "Press any key to end.";
	cin.get();


	// restore output window size to same size as when starting program
	MoveWindow(console, r.left, r.top, r.right - r.left, r.bottom - r.top, TRUE);

	return 0;
}

