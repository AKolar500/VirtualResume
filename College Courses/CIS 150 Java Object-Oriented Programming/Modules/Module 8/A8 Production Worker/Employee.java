/*Alex Kolar
*4/11/2013
*CIS150 Section 28951
*Employee class
*/

public class Employee
{
	//declare variables
	private String name, employeeNumber, hireDate;
	
	//constructors
	public Employee(String n, String num, String date)
	{
		name = n;
		setEmployeeNumber(num);
		hireDate = date;
	}
	public Employee()
	{
		name = "";
		employeeNumber = "";
		hireDate = "";
	}
	
	//mutators (setters)
	public void setName(String n)
	{
		name = n;
	}
	public void setEmployeeNumber(String e)
	{
		if (isValidEmpNum(e))
			employeeNumber = e;
		else
			employeeNumber = "";
	}
	public void setHireDate(String h)
	{
		hireDate = h;
	}
	
	//accessors (getters)
	public String getName()
	{
		return name;
	}
	public String getEmployeeNumber()
	{
		return employeeNumber;
	}
	public String getHireDate()
	{
		return hireDate;
	}
	
	//other methods
	private boolean isValidEmpNum(String e)
	{
		boolean status = true;
		
		if (e.length() != 5)
			status = false;
		else
		{
			if ((!Character.isDigit(e.charAt(0))) ||
				(!Character.isDigit(e.charAt(1))) ||
				(!Character.isDigit(e.charAt(2))) ||
				(e.charAt(3) != '-') ||
				(!Character.isLetter(e.charAt(4))))
					status = false;
		}
		return status;
	}
	
	public String toString()
	{
		String str = "Name: " + name + "\nEmployee Number: "; //declare str
		
		//add to str
		if (employeeNumber == "")
			str += "INVALID EMPLOYEE NUMBER";
		else
			str += employeeNumber;
		
		str += ("\nHire Date: " + hireDate);
		
		return str;
	}
}