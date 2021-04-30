/**
 * @(#)Student.java
 *
 *
 * @author
 * @version 1.00 2011/11/3
 */


public class Student extends Person {
	private int status;

	public Student(String name, String address, String phone, String email, int status){
		super(name, address, phone, email);
		this.status=status;
	}
	public String toString(){
		return super.toString()+" "+status;
	}


}