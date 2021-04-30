/*Alex Kolar
*4/11-18/2013
*CIS150 Section 28951
*ProductionWorker class
*/

import java.text.DecimalFormat;

public class ProductionWorker extends Employee
{
	//declare variables and constants
	//constants for day and night shifts
	public static final int DAY_SHIFT = 1;
	public static final int NIGHT_SHIFT = 2;
	
	private int shift; //worker's shift
	private double payRate; //worker's pay rate
	
	//constructors
	public ProductionWorker(String n, String num, String date, int sh, double rate) throws InvalidEmployeeNumber, InvalidShift, InvalidPayRate
	{
		super(n, num, date);
		setShift(sh);
		setPayRate(rate);
	}
	public ProductionWorker()
	{
		super();
		shift = DAY_SHIFT;
		payRate = 0.0;
	}
	
	//mutators (setters)
	public void setShift(int s) throws InvalidShift
	{
		if (s != DAY_SHIFT && s != NIGHT_SHIFT)
			throw new InvalidShift();
		else
			shift = s;
	}
	public void setPayRate(double p) throws InvalidPayRate
	{
		if (p < 0)
			throw new InvalidPayRate();
		else
			payRate = p;
	}
	
	//accessors (getters)
	public int getShift()
	{
		return shift;
	}
	public double getPayRate()
	{
		return payRate;
	}
	
	//other methods
	public String toString() //This method uses the decimalformat class that I imported
	{
		DecimalFormat dollar = new DecimalFormat("#,##0.00");
		
		//str has the value of the toString method in the Employee class
		String str = super.toString();
		
		//add more to str
		str += "\nShift: ";
		
		if (shift == DAY_SHIFT)
			str += "Day";
		else if (shift == NIGHT_SHIFT)
			str += "Night";
		else
			str += "INVALID SHIFT NUMBER";
		
		str += ("\nHourly Pay Rate: $" + dollar.format(payRate));
		
		return str;
	}
}