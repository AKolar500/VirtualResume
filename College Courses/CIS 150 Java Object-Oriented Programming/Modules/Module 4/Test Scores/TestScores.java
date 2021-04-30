/*Alex Kolar
*2/14/2013
*CIS150AB Section 28951
*Test Scores Class File
*/

public class TestScores
{
	private double test1, test2, test3, average;
	

	TestScores(double t1, double t2, double t3)
	{
		test1 = t1;
		test2 = t2;
		test3 = t3;
	}
	//setters and getters.
	public void setTestScore1(double t1)
	{
		test1 = t1;
	}
	public void setTestScore2(double t2)
	{
		test2 = t2;
	}
	public void setTestScore3(double t3)
	{
		test3 = t3;
	}
	public double getTestScore1()
	{
		return test1;
	}
	public double getTestScore2()
	{
		return test2;
	}
	public double getTestScore3()
	{
		return test3;
	}
	// public void setAverage(double a)
// 	{
// 		average = a;
// 	}
	public double getAverage()
	{
		return average = (test1 + test2 + test3)/3;
	}
	
	//Here, the magic happens.
	public char getLetterGrade()
	{
	
		char LetterGrade;

		if (average < 60)
		{
			LetterGrade = 'F';
		//	return LetterGrade = (String)"A";
		}
		else if (average < 70)
		{
			LetterGrade = 'D';
		//	return String LetterGrade = Char('B');
		}
		else if (average < 80)
		{
			LetterGrade = 'C';
		//	return String LetterGrade = Char('C');
		}
		else if (average < 90)
		{
			LetterGrade = 'B';
		//	return String LetterGrade = Char('D');
		}
		else
		{
			LetterGrade = 'A';
		//	return String LetterGrade = Char('F');
		}
		return LetterGrade;
	}
}