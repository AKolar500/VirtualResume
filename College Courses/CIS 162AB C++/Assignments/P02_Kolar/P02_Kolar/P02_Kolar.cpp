// P02 Weekly Pay Calculator - Kolar
/* This program is used by employees to determine what
their weekly net pay would be based on their hourly rate
and number of hours worked.*/

#include "stdafx.h"
#include <iostream>
using namespace std;


/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}
*/

void main()
{
	//constants
	const double UNION_DUES = 10.00, FICA_RATE = 0.06,
		FEDERAL_RATE = 0.15, STATE_RATE = 0.05;
	//variables
	int hours;
	double rate, gross, fica, federal, state, netPay, netHourly;

	//set the decimal point to 2 positions
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	//display name and the input prompt
	cout << "P02 - Alex Kolar \n\n";

	cout << "Enter the hourly rate and the number of hours \n"
		<< "worked on the same line, but separated by a space. \n"
		<< "Press the enter key after entering both values."
		<< endl << endl
		<< "Enter the hourly rate and hours worked: ";

	//get input
	cin >> rate >> hours;

	//calculate values
	gross = rate * hours;
	fica = gross * FICA_RATE;
	federal = gross * FEDERAL_RATE;
	state = gross * STATE_RATE;
	netPay = gross - (fica + federal + state + UNION_DUES);
	netHourly = netPay / hours;

	//display the results and echo the input (rate and hours)
	//display the values stored in constants
	cout << endl
		<< "Hourly Rate: \t" << rate << endl
		<< "Hours Worked: \t" << hours << endl
		<< "Gross Pay: \t" << gross << endl
		<< "FICA Tax: \t" << fica << " at " << FICA_RATE << endl
		<< "Federal Tax: \t" << federal << " at " << FEDERAL_RATE << endl
		<< "State Tax: \t" << state << " at " << STATE_RATE << endl
		<< "Union Dues: \t" << UNION_DUES << endl
		<< "Net Pay: \t" << netPay << endl
		<< "Net Hourly: \t" << netHourly << endl;

	cout << "\nThank You Very Much!\n";
}

