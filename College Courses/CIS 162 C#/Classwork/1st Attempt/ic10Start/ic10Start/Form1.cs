//programmer: John Corker
//Program: ic09
//Date:3.23.11
//class:cis162ad

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic10Start
{
    public partial class Form1 : Form
    {

 

        public Form1()
        {
            InitializeComponent();
        }

        private int intTotalCreditHrs, intTotalPoints;

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string strCourseName, strCourseGrade, strCourseLine;
            int intCourseCreditHrs;
            int intCourseGradePoints;
            decimal decTotalGPA;
 
  



            try
            {

                if (validateCourse())
                {

                    strCourseName = txtClass.Text;
                    intCourseCreditHrs = int.Parse(txtCreditHrs.Text);
                    strCourseGrade = txtGrade.Text;

                    intCourseGradePoints = gradePoints(intCourseCreditHrs, strCourseGrade);

                    strCourseLine = "\t" + strCourseName +
                         "\t\t" + intCourseCreditHrs.ToString("n0") +
                         "\t\t" + strCourseGrade +
                         "\t\t" + intCourseGradePoints.ToString("n0");

                    lstTranscript.Items.Add(strCourseLine);

                    intTotalPoints += intCourseGradePoints;
                    intTotalCreditHrs += intCourseCreditHrs;

                    decTotalGPA = intTotalPoints / intTotalCreditHrs;
                    lblTotalGPA.Text = decTotalGPA.ToString("n2");

                }


            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString(),"Fatal Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public int gradePoints(int intCredits, string strGrade)
        {
            int intGradePoints;
     

             switch (strGrade)
            {
                case "A":
                    intGradePoints = intCredits * 4;

                    break;

                case "B":
                    intGradePoints = intCredits * 3;

                    break;

                case "C":
                    intGradePoints = intCredits * 2;

                    break;

                case "D":
                    intGradePoints = intCredits * 1;
  
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

 
        private bool validateCourse()
        {
            bool isValid = false;
            int intDummy;
  
 
                    if (txtClass.Text != "")
                    {

                        if (int.TryParse(txtCreditHrs.Text,out intDummy))
                        {

                            if (txtGrade.Text != "")
                            {
                                isValid = true; 
                            }
                            else
                            {
                                MessageBox.Show("Error:Grade");
                                txtGrade.Focus();
                                txtGrade.SelectAll();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error:Credit Hours");
                            txtCreditHrs.Focus();
                            txtCreditHrs.SelectAll();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Error:Class Hours");
                        txtClass.Focus();
                        txtClass.SelectAll();
                    }

                
 
            return isValid;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            lstTranscript.Items.Clear();

            txtClass.Clear();
            txtGrade.Clear();
            txtCreditHrs.Clear();

            lblTotalGPA.Text = "";

            txtClass.Focus();

        }
             
    }
}
