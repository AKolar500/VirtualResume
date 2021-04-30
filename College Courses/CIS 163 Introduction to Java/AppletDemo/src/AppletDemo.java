/**
 * @(#)AppletDemo.java
 *
 * AppletDemo application
 *
 * @author
 * @version 1.00 2011/4/28
 */
import java.awt.*;
import javax.swing.*;

public class AppletDemo extends JApplet {
DrawingPanel drawing;

	public AppletDemo(){
		setLayout(new BorderLayout());
		JLabel label = new JLabel("Fuck you!");
		label.setBackground(Color.YELLOW);
		label.setForeground(Color.BLUE);
		add(label, BorderLayout.NORTH);
		DrawingPanel drawing = new DrawingPanel();
		add(drawing, BorderLayout.CENTER);
	}
	public void init(){
		int redint = Integer.parseInt(getParameter("red"));
		int greenint = Integer.parseInt(getParameter("green"));
		int blueint = Integer.parseInt(getParameter("blue"));
		setBackground(new Color(redInt, greenInt, blueInt));
		repaint();
	}
	private class DrawingPanel extends JPanel{
		public void paintComponent(Graphics g){
			g.setColor(Color.BLUE);
			g.fillRect(100, 10, 60, 30);
			g.SetColor(Color.RED);
			g.fillOval(30, 100 ,100, 90);
		}
	}
	public void paint(Graphics g){
		g.drawString("Blow me!");
	}
}
