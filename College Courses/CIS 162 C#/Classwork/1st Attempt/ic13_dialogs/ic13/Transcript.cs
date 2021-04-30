using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic13
{
    public  class Transcript
    {

        protected string cstrCourse;
        protected int cintCreditHrs;
        protected string cstrGrade;

        public Transcript()
        {
        
        }
        
        public Transcript(string strCourse, int intCreditHrs, string strGrade)
        {

            Course = strCourse;
            CreditHrs = intCreditHrs;
            Grade = strGrade;

        
        }

 
        public string Course
        {
            get { return cstrCourse; }
            set { cstrCourse = value; }
        }


        public int CreditHrs
        {
            get { return cintCreditHrs; }
            set { cintCreditHrs = value; }
        }

         
        public virtual string Grade
        {
            get { return cstrGrade; }
            set { cstrGrade = value; }
        }

        public virtual int gradePoints()
        {
            int intCredits;
            string strGrade;

            int intGradePoints;
            int intMult;

            intCredits = CreditHrs;
            strGrade = Grade;

            switch (strGrade)
            {
                case "A":
                    intMult = 4;
                    break;

                case "B":
                    intMult = 3;
                    break;

                case "C":
                    intMult = 2;
                    break;

                case "D":
                    intMult = 1;
                    break;

                case "F":
                    intMult = 0;
                    break;

                default:
                    intMult = 0;
                    break;
            }

            intGradePoints = intCredits * intMult;

            return intGradePoints;
        }
 

        public override  string ToString()
        {
            string strTranscript;

            strTranscript = "\t" + Course +
                    "\t\t" + CreditHrs.ToString("n0") +
                    "\t\t" + Grade +
                    "\t" + gradePoints().ToString("n0");

            return strTranscript;
        
        }

    }
}
