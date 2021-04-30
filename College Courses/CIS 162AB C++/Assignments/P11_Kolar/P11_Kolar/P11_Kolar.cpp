// P11_Kolar.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <string> //string class

using namespace std;


/*int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}*/

int id;
string fn, ln;

//class definition - the interface for the class
class SalesPerson
{
private:
	int salesPersonID;
	string firstName;
	string lastName;

public:
	SalesPerson();
	SalesPerson(int id, string fn, string ln);
	~SalesPerson();

	void setSalesPersonId(int id);
	void setFirstName(string fn);
	void setLastName(string ln);

	void getSalesPersonId(int id);
	void getFirstName(string fn);
	void getLastName(string ln);

	void inputSalesPersonId(int id);
	void inputFirstName(string fn);
	void inputLastName(string ln);

};


//empty main: gotta have a main
void main()
{
	return;
}

