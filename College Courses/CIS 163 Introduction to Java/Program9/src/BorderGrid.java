/*Alex Kolar
 *11/2/2011
 *Mr. R. Grover
 *Cis163
 *26279
 *
 *This file makes a GridLayout JFrame with 2 JPanels inside of it. 3 buttons reside in each JPanel.
 */
import java.awt.*;
import javax.swing.*;

public class BorderGrid extends JFrame{
	public BorderGrid(){
		setLayout(new BorderLayout());
    	setSize(600, 300);
    	setTitle("BorderGrid");
    	setLocationRelativeTo(null);
    	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    	JPanel p1 = new JPanel();
    	p1.setBackground(Color.BLUE);
    	p1.setLayout(new GridLayout(2, 2, 5, 5));
    	JPanel p2 = new JPanel();
    	p2.setBackground(Color.GREEN);
    	p2.setLayout(new GridLayout(2, 2, 5, 5));
    	JButton lake = new JButton("1");
    	p1.add(lake);
    	JButton river = new JButton("2");
    	p1.add(river);
    	JButton stream = new JButton("3");
    	p1.add(stream);
    	JButton gallon = new JButton("4");
    	p2.add(gallon);
    	JButton cup = new JButton("5");
    	p2.add(cup);
    	JButton drop = new JButton("6");
    	p2.add(drop);
    	add(p1, BorderLayout.NORTH);
    	add(p2, BorderLayout.SOUTH);
    	setVisible(true);
	}
}