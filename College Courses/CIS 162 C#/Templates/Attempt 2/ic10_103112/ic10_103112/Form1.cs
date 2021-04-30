using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic10_103112
{
    public partial class Form1 : Form
    {

        List<Transcript> colTranscripts = new List<Transcript>();



        public Form1()
        {
            InitializeComponent();
        }

 

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            Transcript objTranscript;

            if (validateCourse())
            {
                objTranscript = new Transcript();

                objTranscript.CourseName = txtClass.Text;
                objTranscript.CourseCreditHours = int.Parse(txtCreditHrs.Text);
                objTranscript.CourseGrade = txtGrade.Text;

                colTranscripts.Add(objTranscript);

                DisplayTranscripts();

                lblTotalGPA.Text = GetTotalGPA().ToString("n2");

            }

        }

        public void DisplayTranscripts()
        {

            lstTranscript.Items.Clear();

            foreach (Transcript objTranscript in colTranscripts)
            {
                lstTranscript.Items.Add(objTranscript);
            }

        }

        public decimal GetTotalGPA()
        {
            decimal decTotalHours = 0, decTotalGradePoints=0;

            foreach (Transcript objTranscript in colTranscripts)
            {
                decTotalHours += objTranscript.CourseCreditHours;
                decTotalGradePoints += objTranscript.gradePoints();

            }

            return decTotalGradePoints / decTotalHours;

        }


        private bool validateCourse()
        {
            bool isValid = false;
            int intDummy;


            if (txtClass.Text != "")
            {

                if (int.TryParse(txtCreditHrs.Text, out intDummy))
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
            colTranscripts.Clear();
            lstTranscript.Items.Clear();

            txtClass.Clear();
            txtGrade.Clear();
            txtCreditHrs.Clear();

            lblTotalGPA.Text = "";

            txtClass.Focus();

        }


    }
}
