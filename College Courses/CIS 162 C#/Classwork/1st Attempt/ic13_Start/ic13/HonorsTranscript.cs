using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic13
{
    class HonorsTranscript:Transcript
    {
 
        public HonorsTranscript()
        {
        
        }

        public HonorsTranscript(string strCourse, int intCreditHrs, string strGrade)
            :base(strCourse,  intCreditHrs,  strGrade)
        {

       
        }


        public override string Grade
        {
            get { return cstrGrade; }
            set
            {
                if (value != "A" & value != "B")
                    throw new Exception("must be an A or B");

                cstrGrade = value;

            }
        }


        public override int gradePoints()
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
                    intMult = 5;
                    break;

                case "B":
                    intMult = 4;
                    break;

                case "C":
                    intMult = 3;
                    break;

                case "D":
                    intMult = 2;
                    break;

                case "F":
                    intMult = 1;
                    break;

                default:
                    intMult = 0;
                    break;
            }

            intGradePoints = intCredits * intMult;

            return intGradePoints;
        }

        public override string ToString()
        {
            string strMessage;

            strMessage = base.ToString() + "\t" + "H";
            return strMessage;
        
        }


    }
}
