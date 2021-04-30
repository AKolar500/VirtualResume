/*
*Alex Kolar
*2/07/2013
*CIS150AB
*"Car" Driver file
*/

public class CarDemo
{
	public static void main(String[] args)
	{
		Car copCar = new Car(2009, "Ford Fiesta");
		
		//Display the current status.
		System.out.println("Current status of the car:");
		System.out.println("Year model: " + copCar.getYearModel());
		System.out.println("Make: " + copCar.getMake());
		System.out.println("Speed: " + copCar.getSpeed());
		
		//Accelerate the car five times.
		System.out.println("\nAccelerating...");
		copCar.accelerate();
		copCar.accelerate();
		copCar.accelerate();
		copCar.accelerate();
		copCar.accelerate();
		
		//Display the speed.
		System.out.println("Now the speed is " + copCar.getSpeed());
		
		//Brake the car two times.
		System.out.println("\nSlowing down...");
		copCar.brake();
		copCar.brake();
		
		//Display the speed again.
		System.out.println("Now the speed is " + copCar.getSpeed());
		
		//Brake the car three times.
		System.out.println("\nStopping...");
		copCar.brake();
		copCar.brake();
		copCar.brake();
		
		//Display the speed again.
		System.out.println("Now the speed is " + copCar.getSpeed());
		
		//Brake the car one more time, to display the error message.
		System.out.println("\nStopping...");
		copCar.brake();
		
		//Display the speed one last time.
		System.out.println("Now the speed is " + copCar.getSpeed());
	}
}