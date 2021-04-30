/**
 * @(#)Program10.java
 *
 * Program10 application
 *
 * @author
 * @version 1.00 2011/11/10
 */
import java.awt.*;
import javax.swing.*;
import java.util.*;
public class Program10 extends JFrame {

    public static void main(String[] args) {
    	Program10 frame = new Program10();
    }
    public Program10() {
    	add(new Hangman());
    	setSize(600, 300);
    	setTitle("Hangman Graphic");
    	setLocationRelativeTo(null);
    	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    	setVisible(true);
    }
}
