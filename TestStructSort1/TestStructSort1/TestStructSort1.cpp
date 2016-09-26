#include <iostream>
#include <vector>
#include <string>
#include <algorithm>


using namespace std;

struct tKey
{
	char c;
	int o_Order;
	int s_Order;
};

bool Compare_Rows(const tKey& a, const tKey &b)
{
	return a.c < b.c;
}

bool Return_Original_Order(const tKey& a, const tKey &b)
{
	return a.o_Order < b.o_Order;
}


int main()
{

	tKey tData[6]{};



	string key{ "SECRET" };
	vector<char> vKey(key.begin(), key.end());
	vector<char> vSortKey{ vKey };
	vector<char>::const_iterator iterC;
	int pos = 0;
	cout << "Original key: " << endl;
	for (iterC = vKey.begin(); iterC != vKey.end(); ++iterC)
	{
		//cout << *iterC << " " << pos << endl;
		tData[pos].c = *iterC;
		tData[pos].o_Order = pos + 1;
		//cout << tData[pos].c << " is now in tData.c and " << tData[pos].o_Order << " is at tData.o_Order." << endl;
		pos += 1;
	}

for (pos = 0; pos < 6; ++pos)
	{
		cout << tData[pos].c << " is at pos " << pos << " and o_Order is " << tData[pos].o_Order << endl;
	}

	cout << endl << endl;

	std::sort(&tData[0], &tData[6], Compare_Rows);

	cout << "Key is now sorted by char c.  ";

	for (pos = 0; pos < 6; ++pos)
	{
		//cout << *iterC << " " << pos << endl;
		//tData[pos].c = *iterC;
		tData[pos].s_Order = pos + 1;
		//cout << tData[pos].c << " is now in tData.c and " << tData[pos].o_Order << " is at tData.o_Order." << endl;
		//pos += 1;
	}

	cout << "Assigning sorted order to tData.s_Order:" << endl;

	for (pos = 0; pos < 6; ++pos)
	{
		cout << tData[pos].c << " is at pos " << pos << ".   o_Order is " << tData[pos].o_Order << ".   s_Order is " << tData[pos].s_Order << endl;
	}
	cout << endl << endl;

	std::sort(&tData[0], &tData[6], Return_Original_Order);

	cout << "Key is now back in original order: " << endl;
	for (pos = 0; pos < 6; ++pos)
	{
		cout << tData[pos].c << " is at pos " << pos << ".   o_Order is " << tData[pos].o_Order << ".   s_Order is " << tData[pos].s_Order << endl;
	}

	// s_Order is now the key value for the crypto.

	return 0;
}