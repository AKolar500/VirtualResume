/*Alex Kolar
*3/21/2013
*CIS150AB Section 28951
*Carpet Calculator: Room Carpet Class
*/

public class roomCarpet
{
	private roomDimension roomSize; //size of the room, based on the roomDimension object
	private double carpetCost; //carpet cost per square foot

	//Constructor
	public roomCarpet(roomDimension dim, double cost)
	{
		//assign input parameters to class variables
		//size = new roomDimension(dim.getLength(), dim.getWidth());
		roomSize = dim;
		carpetCost = cost;
	}

	//get total cost method
	public double getTotalCost()
	{
		//multiply the price by the area and return the total cost
		return carpetCost * roomSize.getArea();
	}

	//to string method
	public String toString()
	{
		return "Cost per Square Foot: $" + carpetCost;
	}
}