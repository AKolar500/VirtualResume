// P08_Kolar.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
using namespace std;



/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}*/


void main(){

	//declare local variables
	ifstream intoFile;
	ofstream outOfFile;
	
	int empId, w1, w2, w3, w4;
	int userContinue;

	double rate;

	do
	{
		//prompt user input
		cout << "Enter the employee ID, rate, w1, w2, w3, and w4. Press" << endl <<
			"enter after each value: " << endl << endl;
		cin >> empId >> rate >> w1 >> w2 >> w3 >> w4;

		//store input in file
		intoFile.open("intoFile.txt");

		if (intoFile.fail())
		{
			cout << "In Error...";
			exit(1);
		}
		else
		{
			intoFile >> empId >> rate >> w1 >> w2 >> w3 >> w4;
		}


		outOfFile.open("outOfFile.txt");

		if (outOfFile.fail())
		{
			cout << "In Error...";
			exit(1);
		}
		else
		{
			outOfFile << empId << " " << rate << " " << w1 << " " << w2 << " " <<
				w3 << " " << w4 << endl;
		}

		//close files
		intoFile.close();
		outOfFile.close();

		//ask if user wants to continue
		cout << "Do you want to add another employee? 1 for yes, 0 for no. ";
		cin >> userContinue;

		//mock user if necessary
		if (userContinue > 1)
		{
			cout << "Nice try, smartass. For entering an invalid number," << endl
				<< "you get to enter more data. Enjoy.";
		}

	} while (userContinue >= 1);

	cout << "Thank you for your input. Please look for your file.";
}
