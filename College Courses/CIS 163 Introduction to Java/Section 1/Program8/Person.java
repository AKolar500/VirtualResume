/**
 * @(#)Person.java
 *
 *
 * @author
 * @version 1.00 2011/11/3
 */


public class Person {
	private String name;
	private String address;
	private String phone;
	private String email;

    public Person(String name, String address, String phone, String email) {
    	this.name=name;
    	this.address=address;
    	this.phone=phone;
    	this.email=email;
    }
    public String toString(){
    	return name+" "+address+" "+phone+" "+email;
    }
}