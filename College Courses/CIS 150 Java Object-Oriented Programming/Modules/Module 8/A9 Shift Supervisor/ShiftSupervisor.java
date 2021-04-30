/*Alex Kolar
*4/11-18/2013
*CIS150 Section 28951
*ProductionWorker class
*/

import java.text.DecimalFormat;

public class ShiftSupervisor extends Employee
{
	//declare variables and constants
	//constants for day and night shifts
	public static final int DIDNT_MEET = 1;
	public static final int MET = 2;

	private int bonus; //worker's shift
	private double payRate; //worker's pay rate

	//constructors
	public ShiftSupervisor(String n, String num, String date, int bo, double rate)
	{
		super(n, num, date);
		bonus = bo;
		payRate = rate;
	}
	public ShiftSupervisor()
	{
		super();
		bonus = DIDNT_MEET;
		payRate = 0.0;
	}

	//mutators (setters)
	public void setBonus(int b)
	{
		bonus = b;
	}
	public void setPayRate(double p)
	{
		payRate = p;
	}

	//accessors (getters)
	public int getBonus()
	{
		return bonus;
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
		str += "\nBonus: ";

		if (bonus == DIDNT_MEET)
			str += "This supervisor did not receive a bonus.";
		else if (bonus == MET)
		{
			str += "This supervisor received a bonus of $1,000.";
			payRate += 1000;
		}
		else
			str += "INVALID BONUS NUMBER";

		str += ("\nPaycheck For the Final Hour: $" + dollar.format(payRate));

		return str;
	}
}