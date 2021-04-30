/*Alex Kolar
*2/07/2013
*CIS150AB 28951
*"Car" class file
*/

public class Car
{
	private int yearModel; //The car's year model
	private String make;  //The car's make
	private int speed; //The car's current speed
	
	//Initialize the car's year model and make.
	Car(int y, String m)
	{
		yearModel = y;
		make = m;
		speed = 0;
	}
	
	//Set the car's year model.
	public void setYearModel(int y)
	{
		yearModel = y;
	}
	
	//Set the car's make.
	public void setMake(String m)
	{
		make = m;
	}
	
	//Set the car's current speed.
	public void setSpeed(int s)
	{
		speed = s;
	}
	
	//Return the car's year model.
	public int getYearModel()
	{
		return yearModel;
	}
	
	//Return the car's make.
	public String getMake()
	{
		return make;
	}
	
	//Return the car's current speed.
	public int getSpeed()
	{
		return speed;
	}
	
	//Add 5 to the current speed each time this method is called.
	public void accelerate()
	{
			speed += 5;
	}
	
	//Subtract 5 from the current speed each time this method is called.
	public void brake()
	{
		if (speed >= 5)
		{
			speed -= 5;
		}
		else
		{
			speed = 0;
			System.out.println("\nWe are already stopped!");
		}
	}
}