/*Alex Kolar
*4/11-18/2013
*CIS150 Section 28951
*Demo file
*/

public class workerDemo
{
	public static void main(String[] args)
	{
		String bonus;

		//create an object and pass the initialization data to the constructor
		ShiftSupervisor pw = new ShiftSupervisor("John Smith", "123-A", "11-15-2005", ShiftSupervisor.DIDNT_MEET, 16.5);

		//display the data
		System.out.println("Here's the first shift supervisor.");
		System.out.println(pw);

		//create another object of the same type and use the set methods
		ShiftSupervisor pw2 = new ShiftSupervisor();

		pw2.setName("Alex Kolar");
		pw2.setEmployeeNumber("666-A");
		pw2.setHireDate("6-06-2006");
		pw2.setBonus(ShiftSupervisor.MET);
		pw2.setPayRate(18.5);

		//display the data
		System.out.println("\nHere's the second shift supervisor.");
		System.out.println(pw2);
	}
}