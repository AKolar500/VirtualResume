// P05-Kolar.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}*/
//constants
const double OVERTIME_RATE = 1.5;
const double UNION_DUES = 10.0, FICA_RATE = 0.06,
FEDERAL_RATE = 0.15, STATE_RATE = 0.05;

//variables
double rateOfHours, hoursWorked;
double gross, dues, fica, federal, state;
double netPay, netHourly;

double confirmation;

//prototypes
bool validateData(double hoursWorked, double rateOfHours);
double calculateGross(double rateOfHours, double hoursWorked);
double calculateFica(double gross, double FICA_RATE);
double calculateFederal(double gross, double FEDERAL_RATE);
double calculateState(double gross, double STATE_RATE);

void main()
{

	//ask for input
	cout << "Enter the hourly rate and the number of hours \n"
		<< "worked on the same line, but separated by a space. \n"
		<< "Press the enter key after entering both values."
		<< endl
		<< "Hourly rate must be from 10 to 15, and \n"
		<< "hours worked must be from 1 to 50."
		<< endl << endl
		<< "Enter the hourly rate and hours worked: ";

	//get input
	cin >> rateOfHours >> hoursWorked;

	//validate data
	if (validateData(hoursWorked, rateOfHours) == true)
	{
		gross = calculateGross(rateOfHours, hoursWorked);
		fica = calculateFica(gross, FICA_RATE);
		federal = calculateFederal(gross, FEDERAL_RATE);
		state = calculateState(gross, STATE_RATE);

		//calculate net pay
		netPay = gross - (UNION_DUES + fica + federal + state);

		//calculate net hourly pay
		netHourly = netPay / hoursWorked;

		cout << "Hourly Rate: " << rateOfHours << endl
			<< "Hours Worked: " << hoursWorked << endl
			<< "Gross Pay: " << gross << endl
			<< "FICA Tax: " << fica << " at " << FICA_RATE << endl
			<< "Federal Tax: " << federal << " at " << FEDERAL_RATE << endl
			<< "State Tax: " << state << " at " << STATE_RATE << endl
			<< "Union Dues: " << UNION_DUES << endl
			<< "Net Pay: " << netPay << endl
			<< "Net Hourly: " << netHourly << endl
			<< endl << endl
			<< "Thank you! Come again!";

		//I add this to my code so I have the time to look at my results. Without this,
		//my debug window would close as soon as it was finished processing the above
		//information.
		cout << "Press any number key, then Enter, to continue.";
		cin >> confirmation;
	}
	else
		cout << "Hourly rate must be from 10 to 15, and \n"
		<< "hours worked must be from 1 to 50. \n"
		<< "Run the program again.";
}

//validate data
bool validateData(double hoursWorked, double rateOfHours)
{
	if (hoursWorked >= 1 && hoursWorked <= 50)
		return true;
	else
		return false;
	if (rateOfHours >= 10 && rateOfHours <= 15)
		return true;
	else
		return false;
}

//calculate gross pay
double calculateGross(double rateOfHours, double hoursWorked)
{
	if (hoursWorked > 40)
	{
		gross = (rateOfHours * OVERTIME_RATE) * hoursWorked;
	}
	else
		gross = rateOfHours * hoursWorked;
	
	return gross;
}

//calculate fica tax
double calculateFica(double gross, double FICA_RATE)
{
	fica = gross * FICA_RATE;
	return fica;
}

//calculate federal tax
double calculateFederal(double gross, double FEDERAL_RATE)
{
	federal = gross * FEDERAL_RATE;
	return federal;
}

//calculate state tax
double calculateState(double gross, double STATE_RATE)
{
	state = gross * STATE_RATE;
	return state;
}

