using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic10_032713
{
    class Transcript
    {
        private string cstrClassName;
        private int cintCreditHours;
        private string cstrGrade;

        public Transcript()
        {

        }
        public Transcript(string strClassName, int intCreditHours, string strGrade)
        {
            ClassName = strClassName;
            CreditHours = intCreditHours;
            Grade = strGrade;
        }

        public string ClassName
        {
            get { return cstrClassName; }
            set { cstrClassName = value; }
        }

        public int CreditHours
        {
            get { return cintCreditHours; }
            set { cintCreditHours = value; }
        }

        public string Grade
        {
            get { return cstrGrade; }
            set { cstrGrade = value; }
        }

        public int gradePoints()
        {
            int intGradePoints;


            switch (Grade)
            {
                case "A":
                    intGradePoints = CreditHours * 4;

                    break;

                case "B":
                    intGradePoints = CreditHours * 3;

                    break;

                case "C":
                    intGradePoints = CreditHours * 2;

                    break;

                case "D":
                    intGradePoints = CreditHours * 1;

                    break;

                case "F":
                    intGradePoints = 0;

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
                         "\t\t" + gradePoints().ToString("n0");
            return strCourseLine;
        }
    }
}
