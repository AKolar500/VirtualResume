using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public partial class tblTranscript
    {


        public decimal GradePoints
        {
            get { return gradePoints(); }

        }
        private int gradePoints()
        {
            int intGradePoints;


            switch (ClassGrade)
            {
                case "A":
                    intGradePoints = ClassCreditHours * 4;

                    break;

                case "B":
                    intGradePoints = ClassCreditHours * 3;

                    break;

                case "C":
                    intGradePoints = ClassCreditHours * 2;

                    break;

                case "D":
                    intGradePoints = ClassCreditHours * 1;

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

    }

}
