using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic12_Start
{
    class HonorsTranscript : Transcipt
    {
        private string cstrHonorsType;

        public HonorsTranscript(string strCourseName, int intCourseCreditHrs,
                            string strCourseGrade, string strHonorsType)
        {
            CourseName = strCourseName;
            CourseCreditHrs = intCourseCreditHrs;
            CourseGrade = strCourseGrade;
            HonorsType = strHonorsType;
        }
        public string HonorsType
        {
            get
            {
                return cstrHonorsType;
            }
            set
            {
                cstrHonorsType = value;
            }
        }
        public override int GradePoints()
        {
            int intGradePoints;

            switch (CourseGrade)
            {
                case "A":
                    intGradePoints = CourseCreditHrs * 5;
                    break;

                case "B":
                    intGradePoints = CourseCreditHrs * 4;
                    break;

                case "C":
                    intGradePoints = CourseCreditHrs * 3;
                    break;

                case "D":
                    intGradePoints = CourseCreditHrs * 2;
                    break;

                case "F":
                    intGradePoints = 1;
                    break;

                default:
                    intGradePoints = 1;
                    break;
            }
            return intGradePoints;
        }
        public override string ToString()
        {
            string strToString;

            strToString = base.ToString() + "\t\t" + "H" + "\t" + HonorsType;
            return strToString;

        }
    }
}
