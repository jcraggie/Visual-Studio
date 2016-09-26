// VectorOfVectors1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <vector>

using namespace std;

int main()
{
	vector<vector<int>> vec;

	for (int i = 0; i < 10; ++i)
	{
		vector<int> row; // create an empty row
		for (int j = 0; j < 20; ++j)
		{
			row.push_back(i*j); // add an element (column) to the row
		}
		vec.push_back(row); // add the row to the main vector
	}

	for (int i = 0; )

    return 0;
}

