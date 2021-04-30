/*Alex Kolar
 *CIS 163
 *Section 26279
 *10/20/2011
 *Mr. R. B. Grover
 *Program 7
 */

public class Program7 {
    public static void main(String[] args) {
    	//rect1
   		Rectangle rect1 = new Rectangle();
   		System.out.println("-Rectangle 1-");
   		printRectangle(rect1);

   		//rect2
   		Rectangle rect2 = new Rectangle(3.5, 4.2);
   		System.out.println("-Rectangle 2-");
   		printRectangle(rect2);
   		rect1.setWidth(4.2);
   		rect1.setHeight(3.5);
   		rect1.setColor("blue");
   		System.out.println("-Rectangle 1-");
   		printRectangle(rect1);
   		System.out.println("Color of Rectangle 2 is " + rect2.getColor());
   }
	public static void printRectangle(Rectangle r) {
		System.out.println("Width is " + r.getWidth());
		System.out.println("Height is " + r.getHeight());
		System.out.println("Area is " + r.getArea());
		System.out.println("Perimeter is " + r.getPerimeter());
		System.out.println("Color is " + r.getColor());
	}

}
