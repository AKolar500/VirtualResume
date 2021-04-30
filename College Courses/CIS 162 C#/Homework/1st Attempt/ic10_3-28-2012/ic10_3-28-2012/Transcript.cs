using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic10_3_28_2012
{
    class Transcript
    {
        private string cstrCourseName;
        private int cintCourseCreditHrs;
        private string cstrCourseGrade;

        //Default constructor: at this point, always leave empty
        public Transcript()
        {

        }
        //end default constructor

        //parameterized constructor
        public Transcript(string strCourseName, int intCourseCreditHrs, string strCourseGrade)
        {
            CourseName = strCourseName;
            CourseCreditHrs = intCourseCreditHrs;
            CourseGrade = strCourseGrade;
        }

        public string CourseName
        {
            get { return cstrCourseName; }
            set { cstrCourseName = value; }
        }

        public int CourseCreditHrs
        {
            get { return cintCourseCreditHrs; }
            set { cintCourseCreditHrs = value; }
        }

        public string CourseGrade
        {
            get { return cstrCourseGrade; }
            set { cstrCourseGrade = value;
                if (value != "A" && value != "B" && value != "C" && value != "D" && value != "F")
                {
                    throw new Exception("Bad Course Grade");
                }
            }
        }

        public int GradePoints()
        {
            int intGradePoints;

            switch (CourseGrade)
            {
                case "A":
                    intGradePoints = CourseCreditHrs * 4;
                    break;

                case "B":
                    intGradePoints = CourseCreditHrs * 3;
                    break;

                case "C":
                    intGradePoints = CourseCreditHrs * 2;
                    break;

                case "D":
                    intGradePoints = CourseCreditHrs * 1;
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
            string strToString;

            strToString = "\t" + CourseName +
                       "\t\t" + CourseCreditHrs.ToString("n0") +
                       "\t\t" + CourseGrade +
                       "\t\t" + GradePoints().ToString("n0");

            return strToString;
        }

    }
}
