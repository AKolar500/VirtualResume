/*Alex Kolar
*3/21/2013
*CIS150AB Section 28951
*Carpet Calculator: Room Dimension Class
*/

public class roomDimension
{
	private double length, width;

	//Constructor
	//initialize the room's user-specified dimensions
	public roomDimension(double len, double wid)
	{
		length = len;
		width = wid;
	}
	//public void set

	//get area
	public double getArea()
	{
		//multiply the length and width and return the area
		return length * width;
	}

	//to string method
	public String toString()
	{
		return "Room Dimensions: " + length + " feet long by " + width + " feet wide.";
	}
}