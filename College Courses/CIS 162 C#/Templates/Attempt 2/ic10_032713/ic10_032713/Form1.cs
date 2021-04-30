//programmer: John Corker
//Program: ic10
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
using System.Text.RegularExpressions;

namespace ic10_032713
{
    public partial class Form1 : Form
    {
        List<Transcript> colTranscripts = new List<Transcript>();

        private string[] aryClassName = new string[100];
        private int[] aryClassCreditHrs = new int[100];
        private string[] aryClassGrade = new string[100];
        private int[] aryGradePoints = new int[100];
        
        private int intNextElement;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string strCourseName, strCourseGrade;
            int intCourseCreditHrs;
 
                if (validateCourse())
                {
                    strCourseName = txtClass.Text;
                    intCourseCreditHrs = int.Parse(txtCreditHrs.Text);
                    strCourseGrade = txtGrade.Text;

                    AddCourse(strCourseName, intCourseCreditHrs, strCourseGrade);

                    loadCourseListBox();

                    lblTotalGPA.Text = getTotalGPA().ToString("n2");
                }
        }

        public decimal getTotalGPA()
        {
            decimal decTotalGPA = 0;
            int intTotalCreditHrs = 0;

            foreach (Transcript objTranscript in colTranscripts)
            {
                decTotalGPA += objTranscript.gradePoints();
                intTotalCreditHrs += objTranscript.CreditHours;                
            }

            //for (int i = 0; i < intNextElement; i++)
            //{
            //    decTotalGPA += aryGradePoints[i];
            //    intTotalCreditHrs += aryClassCreditHrs[i];
            //}

            if (intTotalCreditHrs != 0)
                decTotalGPA /= intTotalCreditHrs;
            else
                decTotalGPA = 0;

            return decTotalGPA;

        }

        public void AddCourse(string strCourseName, int intCreditHrs, string strLetterGrade)
        {
            Transcript objTranscript = new Transcript(strCourseName, intCreditHrs, strLetterGrade);

            //objTranscript.ClassName = strCourseName;
            //objTranscript.CreditHours = intCreditHrs;
            //objTranscript.Grade = strLetterGrade;
            //aryGradePoints[intNextElement] = gradePoints(intCreditHrs, strLetterGrade);

            //intNextElement++;
            colTranscripts.Add(objTranscript);
        }

        public void loadCourseListBox()
        {
            string strCourseLine;

            lstTranscripts.Items.Clear();

            foreach (Transcript objTranscript in colTranscripts)
            {
                lstTranscripts.Items.Add(objTranscript);
            }

            //for (int i = 0; i < intNextElement; i++)
            //{
            //    strCourseLine = "\t" + aryClassName[i] +
            //         "\t\t" + aryClassCreditHrs[i].ToString("n0") +
            //         "\t\t" + aryClassGrade[i] +
            //         "\t\t" + aryGradePoints[i].ToString("n0");

            //    lstTranscripts.Items.Add(strCourseLine);
            //}
        }

        //public int gradePoints(int intCredits, string strGrade)
        //{
        //    int intGradePoints;
     

        //     switch (strGrade)
        //    {
        //        case "A":
        //            intGradePoints = intCredits * 4;

        //            break;

        //        case "B":
        //            intGradePoints = intCredits * 3;

        //            break;

        //        case "C":
        //            intGradePoints = intCredits * 2;

        //            break;

        //        case "D":
        //            intGradePoints = intCredits * 1;
  
        //            break;

        //        case "F":
        //            intGradePoints = 0;

        //            break;

        //        default:
        //            intGradePoints = 0;

        //            break;
        //    }

        //    return intGradePoints;
        //}


        private bool validateCourse()
        {
            bool isValid = false;
            int intDummy;


            if (txtClass.Text != "")
            {

                if (int.TryParse(txtCreditHrs.Text, out intDummy))
                {
                    txtGrade.Text = txtGrade.Text.ToUpper();
                    if (Regex.Match(txtGrade.Text, "^[ABCDF]$").Success)
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

            lstTranscripts.Items.Clear();

            txtClass.Clear();
            txtGrade.Clear();
            txtCreditHrs.Clear();

            lblTotalGPA.Text = "";

            txtClass.Focus();

        }
             
    }
}
