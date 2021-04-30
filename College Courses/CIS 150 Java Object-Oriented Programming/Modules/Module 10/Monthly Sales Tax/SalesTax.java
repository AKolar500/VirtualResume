/*Alex Kolar
*5/2/2013
*CIS150 Section
*P. 798: Monthly Sales Tax
*/

//look on p. 790-791 for help with the code.

//import GUI classes
import javax.swing.*;
import java.awt.event.*;

//import DecimalFormat class
import java.text.DecimalFormat;

public class SalesTax extends JFrame
{
	private JPanel panel; //a panel to hold everything
	private JLabel totalSalesMsg; //Label propmting for total sales
	private JTextField totalSales; //to get total sales
	private JButton calcButton; //calculates everything
	
	//constants for tax rates
	private final double COUNTY_RATE = 0.02;
	private final double STATE_RATE = 0.04;
	
	//constants for window size
	private final int WINDOW_WIDTH = 360;
	private final int WINDOW_HEIGHT = 100;
	
	//constructor
	public SalesTax()
	{
		//set the title
		super("Monthly Sales Tax Report");
		
		//specify what happens when the close button is clicked
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		//build the panel that contains the other components
		buildPanel();
		
		//add panel to the content pane
		add(panel);
		
		//size and display the window
		setSize(WINDOW_WIDTH, WINDOW_HEIGHT);
		setVisible(true);
	}
	
	//buildPanel method
	private void buildPanel()
	{
		//create a label prompting for the total sales
		totalSalesMsg = new JLabel("Enter the total sales:");
		
		//create a text field for total sales
		totalSales = new JTextField(10);
		
		//create a button to click
		calcButton = new JButton("Calculate Sales Tax");
		
		//add an action listener to the button. VERY IMPORTANT
		calcButton.addActionListener(new CalcButtonListener());
		
		//create a panel
		panel = new JPanel();
		
		//add the label, text field, and button to the panel
		panel.add(totalSalesMsg);
		panel.add(totalSales);
		panel.add(calcButton);
	}
	
	//CalcButtonListener is an action listener class for the calcButton component
	private class CalcButtonListener implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
		{
			double totalSalesAmount, countyTaxAmount, stateTaxAmount, totalTaxAmount;
			
			//create a DecimalFormat object to format output
			DecimalFormat dollar = new DecimalFormat("#,##0.00");
			
			//get the total sales
			totalSalesAmount = Double.parseDouble(totalSales.getText());
			
			//calculate the county tax
			countyTaxAmount = totalSalesAmount * COUNTY_RATE;
			
			//calculate the state tax
			stateTaxAmount = totalSalesAmount * STATE_RATE;
			
			//calculate the total sales
			totalTaxAmount = countyTaxAmount + stateTaxAmount;
			
			//display results
			JOptionPane.showMessageDialog(null, "County Sales Tax: $" + dollar.format(countyTaxAmount) +
													"\nState Sales Tax: $" + dollar.format(stateTaxAmount) +
													"\nTotal Sales Tax: $" + dollar.format(totalTaxAmount));

		}
	}
	
	public static void main(String[] args)
	{
		SalesTax st = new SalesTax();
	}
}