// Pockenacci_v1.cpp : Defines the entry point for the console application.
// taken from Github by justin troutman
// printed off github 9/14/2016
//
// version 1 involves the key.
// First we need a key; let's start with a keyword: SECRET
//
// Now we need to convert this keyword into numbers; we do that by numbering each letter based on wehre it appears in the 
// alphabet. If the keyword has two or more of the same letters, we number them from left to right.
//
// S E C R E T
// 5 2 1 4 3 6
//
// in alphabetical order, "C" appears in the alphabet before the other letters, so it gets the number "1". There are two instances
// of the letter "E", which is the next letter in the alphabetical order. Since we go from left to right, the first "E" get the number "2",
// while the 2nd "E" gets the number 3. When we finish the process, we get 5 2 1 4 3 6.
//


#include "stdafx.h"
#include <stdio.h>
#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

class KeyChar
{
public:
	KeyChar(const char& c = ' ', const int& pos = 0, const int& sort_pos = 0, const int& value = 0);
	char c;
	int  pos;
	int  sort_pos;
	int  value;

	KeyChar* GetNext() const;
	void SetNext(KeyChar* next);

private:
	KeyChar* m_pNext;
};

KeyChar::KeyChar(const char& c, const int& pos, const int& sort_pos, const int& value )
{
	// constructor
}

KeyChar* KeyChar::GetNext() const
{
	return m_pNext;
}

void KeyChar::SetNext(KeyChar* next)
{
	m_pNext = next;
}

class Key
{
public:
	Key();
	~Key();
	void ClearKey();
	void DelFirstKey();
	void AddKeyChar(string keyString);

private:
	KeyChar* m_pHead;
	KeyChar* m_pLast;
};

// key constructor
Key::Key() :
	m_pHead(0),
	m_pLast(0)
{

}

// key destructor
Key::~Key()
{
	ClearKey();
}

void Key::AddKeyChar(string keyString)
{
	// need to parse out keyString and get all it's atributes

	string key = keyString;
	vector<char> vKeyCharOriginal(key.begin(), key.end());
	vector<char> vSortedKey = vKeyCharOriginal;
	vector<int>vKeyInt;
	vector<char>::const_iterator iterC;
	vector<int>::const_iterator iterI;
	vector<char>::const_iterator iterO;
	int keySize = key.size();
	int pos = 0;
	char c;
	int sorted_pos;
	int value;

	cout << key << " is the original key string keyString. " << keySize << " is the size of keyString." << endl;

	for (iterC = vKeyCharOriginal.begin(); iterC != vKeyCharOriginal.end(); ++iterC)
	{
		pos++;
		cout << *iterC << " is at position " << pos << "." << endl;
	}
	cout << " is the orginal key in the vector vKeyCharOriginal." << endl;

	sort(vSortedKey.begin(), vSortedKey.end());

	for (iterC = vSortedKey.begin(); iterC != vSortedKey.end(); ++iterC)
	{
		cout << *iterC;
	}
	cout << " is the sorted key. " << endl;
	return;

	int i = 1;
	for (iterC = vSortedKey.begin(); iterC != vSortedKey.end(); ++iterC)
	{
		vKeyInt.push_back(i);
		i++;
	}

	KeyChar* pNewKeyChar = new KeyChar();

	if (m_pHead == 0)
	{
		m_pHead = pNewKeyChar;
		m_pLast = pNewKeyChar;
	}
	else
	{
		KeyChar* pIter = m_pHead;
		m_pLast->SetNext(pNewKeyChar);
		m_pLast = pNewKeyChar;
	}
}

void Key::ClearKey()
{
	while (m_pHead != 0)
	{
		DelFirstKey();
	}
}

void Key::DelFirstKey()
{
	if (m_pHead == 0)
	{
		cout << "There are no keys!" << endl;
	}
	else
	{
		KeyChar* pTemp = m_pHead;

		m_pHead = m_pHead->GetNext();

		delete pTemp;
	}
}

int main()
{
	string key("SECRET");
	
	Key myKey;
	Key& rMyKey = myKey;

	myKey.AddKeyChar(key); // sends key string to AddKeyChars

	

	cout << endl;

	cin.get();

    return 0;
}

