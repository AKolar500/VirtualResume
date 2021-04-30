using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ic15DataReader
{
    class Transcript
    {
        protected int cintID;
        protected string cstrClassName;
        protected int cintCreditHours;
        protected string cstrGrade;

        public Transcript()
        {

        }


        public Transcript(string strClassName, int intCreditHours, string strGrade)
        {
            ClassName = strClassName;
            CreditHours = intCreditHours;
            Grade = strGrade;

        }

        public Transcript(int intID, string strClassName, int intCreditHours, string strGrade)
        {
            ID = intID;
            ClassName = strClassName;
            CreditHours = intCreditHours;
            Grade = strGrade;

        }

 
        virtual public int ID
        {
            get { return cintID; }
            set { cintID = value; }
        }
        
        virtual public string ClassName
        {
            get { return cstrClassName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new FormatException("Error:Class Name is Empty");
                }
                cstrClassName = value;
            }
        }

        virtual public int CreditHours
        {
            get
            {
                return cintCreditHours;

            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Error:Credit Hours <= 0");
                }
                cintCreditHours = value;
            }


        }



        virtual public string Grade
        {
            get { return cstrGrade; }
            set
            {
                string strGrade = value.ToUpper();
                if (!Regex.Match(strGrade, "^[ABCDF]$").Success)
                    throw new FormatException("Error:Grade is not A,B,C,D,F");

                cstrGrade = value;
            }
        }

        virtual public int gradePoints()
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
