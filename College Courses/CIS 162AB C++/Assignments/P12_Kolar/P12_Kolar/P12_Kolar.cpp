//P12 SalesPerson - Alex Kolar 
/*
This program is a driver to test the SalesPerson class.
It is used to create 2 objects, which test the constructors and accessors.
The objects created are saved to p12.txt.
*/
#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <iomanip>  // setw
#include <string>   // string class
using namespace std;


/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}*/

// int id;
// string fn, ln;

//class definition - the interface for the class
class SalesPerson
{
private:
	int salesPersonId;
	string firstName;
	string lastName;

public:
	SalesPerson(); //default constructor doesn't have parameters 
	SalesPerson(int id, string fn, string ln); //overloaded constructor; 
	//parameter names in overloaded constructors should be different
	//from the class variable names, because the parameter values 
	//are going to be assigned to the class variables. 

	~SalesPerson(); //destructor

	//Set accessors do NOT return a value (void) because they are used 
	//to assign a value to a private variable. The value to assign is 
	//passed through the parameter.
	void setSalesPersonId(int id);
	void setFirstName(string fn);
	void setLastName(string ln);

	//Get accessors are used to return the value stored in a private 
	//variable, so a parameter is not passed.
	int getSalesPersonId();
	string getFirstName();
	string getLastName();

	//Input accessors prompt for, get, and store a value in a private 
	//variable. A value is not returned and a parameter is not passed.
	void inputSalesPersonId();
	void inputFirstName();
	void inputLastName();
};

//Application Starts here (prototypes, main(), and definitions for application)

//saves info to a file or displays to screen (cout) through ostream& parameter
void outputSalesInfo(ostream& target, SalesPerson& salesPersonObj);

//empty main: gotta have a main
void main()
{
	//Open the file for output; if there are any errors, we need to 
	//display an error message.

	ofstream outFile;
	outFile.open("P12.txt");
	if (outFile.fail())
	{
		cout << "Error opening output file for sales information.\n"
			<< "Exiting program \n\n";
		return;
	}

	cout << "\nP12     Alex Kolar  \n\n";


	//1001 Joe Smith - use default constructor and input functions
	SalesPerson salesPersonObj;

	//Save the validated sales info data as a record to the file.
	outputSalesInfo(outFile, salesPersonObj);
	//display the record on the screen
	outputSalesInfo(cout, salesPersonObj);



	//1002  Larry Jones - use set functions to change values.
	salesPersonObj.setSalesPersonId(1002);
	salesPersonObj.setFirstName("Larry");
	salesPersonObj.setLastName("Jones");

	//Save the sales info data as a record to the file.
	outputSalesInfo(outFile, salesPersonObj);
	//display the record on the screen
	outputSalesInfo(cout, salesPersonObj);



	//1003 Paul Sailor - use overloaded constructor 
	SalesPerson salesPersonObj2(1003, "Paul", "Sailor");

	//Save the sales info data as a record to the file.
	outputSalesInfo(outFile, salesPersonObj2);
	//display the record on the screen
	outputSalesInfo(cout, salesPersonObj2);



	// Close the output file and exit program
	outFile.close();
	return;
}//end of main


//save the order information to a file or display to screen.
//target can be either cout or outFile because ofstream inherits ostream.
//ofstream objects are also ostream objects.
//also, must be ostream because cout is already declared as an ostream.

void outputSalesInfo(ostream& target, SalesPerson& salesPersonObj)
{
	//declare local variables
	int    salesPersonId;
	string lastName, firstName;

	//Have the class return the private values to the local variables.
	//Then store them in the file.
	salesPersonId = salesPersonObj.getSalesPersonId();
	firstName = salesPersonObj.getFirstName();
	lastName = salesPersonObj.getLastName();

	if (target == cout)
		target << "\n\nSales Person's Information Saved! \n";

	target.setf(ios::left);
	target << setw(6) << salesPersonId
		<< setw(18) << firstName
		<< setw(18) << lastName
		<< endl;
	target.unsetf(ios::left);

	return;
}



//Student must complete the 2 constructors, 3 set and 3 get accessors,
//and 3 input function definitions.  A total of 11 functions.

//default constructor
//The default constructor should call the 3 input functions.
SalesPerson::SalesPerson()
{
	inputSalesPersonId();
	inputFirstName();
	inputLastName();
}

//overloaded constructor
SalesPerson::SalesPerson(int id, string fn, string ln)
{
	salesPersonId = id;
	firstName = fn;
	lastName = ln;
}

//Destructor function definition is provided below
SalesPerson::~SalesPerson()
{
	cout << "\nSalesPerson Object going out of scope. Id = "
		<< salesPersonId << endl;
	return;
}

//set accessors
void SalesPerson::setSalesPersonId(int id)
{
	salesPersonId = id;
}
void SalesPerson::setFirstName(string fn)
{
	firstName = fn;
}
void SalesPerson::setLastName(string ln)
{
	lastName = ln;
}

//get accessors
int SalesPerson::getSalesPersonId()
{
	return salesPersonId;
}
string SalesPerson::getFirstName()
{
	return firstName;
}
string SalesPerson::getLastName()
{
	return lastName;
}

//input accessors
void SalesPerson::inputSalesPersonId()
{
	cout << "Enter Sales Person ID (1000 - 9999): ";
	cin >> salesPersonId;
}
void SalesPerson::inputFirstName()
{
	cout << "Enter First Name without spaces: ";
	cin >> firstName;
}
void SalesPerson::inputLastName()
{
	cout << "Enter Last Name without spaces: ";
	cin >> lastName;
}


