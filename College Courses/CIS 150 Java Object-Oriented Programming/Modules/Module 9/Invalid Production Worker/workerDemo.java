/*Alex Kolar
*5/1/2013
*CIS150 Section 28951
*Demo file
*/

public class workerDemo
{
	public static void main(String[] args)
	{
		String shift;
		
		//try to make this one have all the errors
		try
		{
			//create an object and pass the initialization data to the constructor
			ProductionWorker pw = new ProductionWorker("John Smith", "1234", "11-15-2005", ProductionWorker.DAY_SHIFT, -10.2);
			
			//display the data
			System.out.println("Here's the first production worker.");
			System.out.println(pw);
		}
		catch (InvalidEmployeeNumber e)
		{
			System.out.println(e.getMessage());
		}
		catch (InvalidShift e)
		{
			System.out.println(e.getMessage());
		}
		catch (InvalidPayRate e)
		{
			System.out.println(e.getMessage());
		}
		
		try
		{
			//create another object of the same type and use the set methods
			ProductionWorker pw2 = new ProductionWorker();
			
			pw2.setName("Alex Kolar");
			pw2.setEmployeeNumber("6661");
			pw2.setHireDate("6-06-2006");
			pw2.setShift(ProductionWorker.NIGHT_SHIFT);
			pw2.setPayRate(18.5);
			
			//display the data
			System.out.println("\nHere's the second production worker.");
			System.out.println(pw2);
		}
		catch (InvalidEmployeeNumber e)
		{
			System.out.println(e.getMessage());
		}
		catch (InvalidShift e)
		{
			System.out.println(e.getMessage());
		}
		catch (InvalidPayRate e)
		{
			System.out.println(e.getMessage());
		}
	}
}