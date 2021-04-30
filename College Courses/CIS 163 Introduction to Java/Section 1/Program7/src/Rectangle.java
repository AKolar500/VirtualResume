public class Rectangle {
	private double height = 1;
   	private double width = 1;
   	//private String static ((color- red, blue, black, green. might need new line for each color, always private.)){  }
   	private static String color = "red";
	public Rectangle(){
    }
    public Rectangle(double height, double width){
    	this.height = height;
    	this.width = width;
    }
    public double getHeight(){
    	return height;
    }
    public void setHeight(double height){
    	this.height = height;
    }
    public double getWidth(){
    	return width;
    }
    public void setWidth(double width){
    	this.width = width;
    }
    public double getArea(){
    	return width*height;
    }
    public double getPerimeter(){
    	return 2*(width+height);
    }
    public String getColor(){
    	return color;
    }
    public void setColor(String color){
    	this.color = color;
    }
}
//	    	double h = rect1.getheight(); //here or getHeight?
//	    	double w = rect1.getwidth(); //here or getWidth?
//	    	double h = rect2.getheight(); //here or getHeight?
//	    	double w = rect2.getwidth(); //here or getWidth?