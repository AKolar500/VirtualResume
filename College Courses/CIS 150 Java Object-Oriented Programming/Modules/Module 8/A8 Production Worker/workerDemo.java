/*Alex Kolar
*4/11-18/2013
*CIS150 Section 28951
*Demo file
*/

public class workerDemo
{
	public static void main(String[] args)
	{
		String shift;
		
		//create an object and pass the initialization data to the constructor
		ProductionWorker pw = new ProductionWorker("John Smith", "123-A", "11-15-2005", ProductionWorker.DAY_SHIFT, 16.5);
		
		//display the data
		System.out.println("Here's the first production worker.");
		System.out.println(pw);
		
		//create another object of the same type and use the set methods
		ProductionWorker pw2 = new ProductionWorker();
		
		pw2.setName("Alex Kolar");
		pw2.setEmployeeNumber("666-A");
		pw2.setHireDate("6-06-2006");
		pw2.setShift(ProductionWorker.NIGHT_SHIFT);
		pw2.setPayRate(18.5);
		
		//display the data
		System.out.println("\nHere's the second production worker.");
		System.out.println(pw2);
	}
}