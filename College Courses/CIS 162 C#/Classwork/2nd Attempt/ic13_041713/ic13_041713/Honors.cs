using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ic13_041713
{
    class Honors:Transcript
    {
        public Honors()
        {
        }
        public Honors(string strClassName, int intCreditHours, string strGrade)
        {
            ClassName = strClassName;
            CreditHours = intCreditHours;
            Grade = strGrade;
        }

        public override string Grade
        {
            get { return cstrGrade; }
            set
            {
                string strGrade = value.ToUpper();
                if (!Regex.Match(strGrade, "^[ABC]$").Success)
                    throw new FormatException("Honors Student:Grade is not A,B,C");

                cstrGrade = value;
            }
        }

        public override int gradePoints()
        {
            int intGradePoints;


            switch (Grade)
            {
                case "A":
                    intGradePoints = CreditHours * 5;

                    break;

                case "B":
                    intGradePoints = CreditHours * 4;

                    break;

                case "C":
                    intGradePoints = CreditHours * 3;

                    break;

                case "D":
                    intGradePoints = CreditHours * 2;

                    break;

                case "F":
                    intGradePoints = CreditHours * 1;

                    break;

                default:
                    intGradePoints = 0;

                    break;
            }

            return intGradePoints;
        }



        public override string ToString()
        {
            string strCourseLine;

            strCourseLine = "\t" + ClassName +
                 "\t\t" + CreditHours.ToString("n0") +
                 "\t\t" + Grade +
             "\t\t" + gradePoints().ToString("n0") +
             "\tH";
            return strCourseLine;


        }

    }
}
