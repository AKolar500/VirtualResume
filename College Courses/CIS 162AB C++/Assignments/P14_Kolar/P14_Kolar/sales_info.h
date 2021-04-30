//P14  SalesInfo 
//Interface file - sales_info.h  - function prototypes

#ifndef SALES_INFO_H
#define SALES_INFO_H

#include "sales_person.h"   //SalesPerson definition required for inheritance


//SalesInfo class
class SalesInfo : public SalesPerson
{
private:
	double rate;
	int    qty;

public:
	SalesInfo::SalesInfo();
	SalesInfo::SalesInfo(int id, string fn, string ln, double rt, int qt);
	SalesInfo::~SalesInfo();

	void SalesInfo::setRate(double rt);
	void SalesInfo::setQty(int qt);

	double SalesInfo::getRate();
	int SalesInfo::getQty();

	void SalesInfo::inputRate();
	void SalesInfo::inputQty();
};


#endif  // End of SALES_INFO_H
