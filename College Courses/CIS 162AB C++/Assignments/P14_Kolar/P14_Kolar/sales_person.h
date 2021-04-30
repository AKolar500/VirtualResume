//P14 SalesPerson     
//Interface file - sales_person.h  - class definition

#ifndef SALES_PERSON_H
#define SALES_PERSON_H

#include <string>  // string class
using namespace std;


//SalesPerson class
class SalesPerson
{
protected:
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


#endif   // End of SALES_PERSON_H
