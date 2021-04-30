/*
*
*/

public class RectangleDemo
{
	public static void main(String[] args)
	{
		//Declares the rectangle named "box".
		Rectangle box = new Rectangle();
		
		//Sets the length and width of rectangle "box".
		box.setLength(10.0);
		box.sexWidth(20.0);
		
		//Displays the length, width, and area of rectangle "box".
		System.out.println("The box's length is " + box.getLength());
		System.out.println("The box's width is " + box.getWidth());
		System.out.println("The box's area is " + box.getArea());
		
	}
}