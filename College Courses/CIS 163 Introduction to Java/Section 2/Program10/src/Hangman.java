/**
 * @(#)Hangman.java
 *
 *
 * @author
 * @version 1.00 2011/11/10
 */

import java.awt.*;
import javax.swing.*;
import java.util.*;

public class Hangman extends JPanel {

    public Hangman() {
    }
    protected void paintComponent(Graphics g){
    	super.paintComponent(g);
    	//(x, y, w, h) From top left corner of box
    	g.drawOval(200, 50, 30, 30); //Head
    	g.drawLine(215, 80, 215, 150); //Torso
    	g.drawLine(215, 150, 230, 210); //Right Leg
    	g.drawLine(215, 150, 200, 210); //Left Leg
    	g.drawLine(215, 85, 235, 155); //Right Arm
    	g.drawLine(215, 85, 195, 155); //Left Arm
    	//(Right/Top x, Right/Top y, Left/Bottom x, Left/Bottom y)
    	g.drawLine(215, 20, 215, 50); //Noose
    	g.drawLine(215, 20, 150, 20); //Top post
    	g.drawLine(150, 20, 150, 300); //Vertical Post
    }

}