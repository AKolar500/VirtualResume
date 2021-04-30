/*Alex Kolar
 * 3/28/2012
 * Instructor: John Corker
 * CIS 162
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic10_3_28_2012
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
            if (validateCourse())
            {
                //string strCourseLine;
                
                //This line of code is a suitable substitute for the following four commented lines
                Transcript objTranscript = new Transcript(txtClass.Text, int.Parse(txtCreditHrs.Text), txtGrade.Text);
                
                //Transcript objTranscript = new Transcript();

                //objTranscript.CourseName = txtClass.Text;
                //objTranscript.CourseCreditHrs = int.Parse(txtCreditHrs.Text);
                //objTranscript.CourseGrade = txtGrade.Text;

                //strCourseLine = "\t" + objTranscript.CourseName +
                //        "\t\t" + objTranscript.CourseCreditHrs.ToString("n0") +
                //        "\t\t" + objTranscript.CourseGrade +
                //        "\t\t" + objTranscript.GradePoints().ToString("n0");

                colTranscripts.Add(objTranscript);

                LoadListBox();
                lblTotalGPA.Text = GetGPA().ToString("n2");
                
            }
        }

        private void LoadListBox()
        {
            lstTranscript.Items.Clear();
            foreach (Transcript objT in colTranscripts)
            {
                lstTranscript.Items.Add(objT);
            }
        }

        private decimal GetGPA()
        {
            decimal decTotalPoints = 0, decTotalHrs = 0;

            foreach (Transcript objT in colTranscripts)
            {
                decTotalPoints += objT.GradePoints();
                decTotalHrs += objT.CourseCreditHrs;
            }
            return decTotalPoints / decTotalHrs;
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
    }
}
