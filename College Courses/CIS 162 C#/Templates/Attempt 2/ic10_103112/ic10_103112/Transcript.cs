using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic10_103112
{
    class Transcript
    {

        private string cstrCourseName;
        private int cintCourseCreditHours;
        private string cstrCourseGrade;

                

        public string CourseName
        {
            get { return cstrCourseName; }
            set { cstrCourseName = value; }
        }

        public int CourseCreditHours
        {
            get { return cintCourseCreditHours; }
            set { cintCourseCreditHours = value; }
        }

        public string CourseGrade
        {
            get { return cstrCourseGrade; }
            set { cstrCourseGrade = value; }
        }

        public int gradePoints()
        {
            int intGradePoints;


            switch (CourseGrade)
            {
                case "A":
                    intGradePoints = CourseCreditHours * 4;

                    break;

                case "B":
                    intGradePoints = CourseCreditHours * 3;

                    break;

                case "C":
                    intGradePoints = CourseCreditHours * 2;

                    break;

                case "D":
                    intGradePoints = CourseCreditHours * 1;

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
            return "\t" + CourseName + "\t\t" + CourseCreditHours + "\t\t" + 
                CourseGrade + "\t\t" + gradePoints();
        }    
        
 






    }
}
