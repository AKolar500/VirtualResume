using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic12_Start
{
    public partial class Form1 : Form
    {
        List<Transcipt> colTrascripts = new List<Transcipt>();



        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Transcipt objTranscript;

            //global try/catch for ALL POSSIBLE exceptions
            try
            {
                if (validateCourse())
                {
                    if (chkHonors.Checked)
                    {
                        Transcipt objHonorsTranscript = new HonorsTranscript(txtClass.Text,
                                int.Parse(txtCreditHrs.Text), txtGrade.Text, cboHonorsType.Text);
                        colTrascripts.Add(objHonorsTranscript);
                    }
                    else
                    {
                        Transcipt objTranscript = new Transcipt(txtClass.Text,
                                int.Parse(txtCreditHrs.Text), txtGrade.Text);
                        colTrascripts.Add(objTranscript);
                    }

                    LoadListBox();
                    lblTotalGPA.Text = GetGPA().ToString("n2");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Critical Error");

            }
        }

        private void LoadListBox()
        {
            lstTranscript.Items.Clear();
            foreach (Transcipt objTran in colTrascripts)
            {
                lstTranscript.Items.Add(objTran);
            }
        }

        private decimal GetGPA()
        {
            decimal decTotalPoints = 0, decTotalHrs = 0;

            foreach (Transcipt objTran in colTrascripts)
            {
                decTotalPoints += objTran.GradePoints();
                decTotalHrs += objTran.CourseCreditHrs;
            }
            return decTotalPoints / decTotalHrs;

        }

        private bool validateCourse()
        {
            bool isValid = false;
           // int intDummy;


            if (txtClass.Text != "")
            {
                try
                {

                    int.Parse(txtCreditHrs.Text);

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
                //catch only numeric conversion exceptions 
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void chkHonors_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHonors.Checked)
            {
                cboHonorsType.Visible = true;
            }
            else
            {
                cboHonorsType.Visible = false;
            }
        }

        private void lstTranscript_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intTranscriptIndex;
            intTranscriptIndex = lstTranscript.SelectedIndex;

            Transcipt objTranscript = colTrascripts[intTranscriptIndex];

            txtClass.Text = objTranscript.CourseName;
            txtCreditHrs.Text = objTranscript.CourseCreditHrs.ToString();
            txtGrade.Text = objTranscript.CourseGrade;

            if (objTranscript.GetType().Name == "HonorsTranscript")
            {
                chkHonors.Checked = true;
                HonorsTranscript objHonorsTranscript = (HonorsTranscript)objTranscript;
                cboHonorsType.Text = objHonorsTranscript.HonorsType;
            }
            else
            {
                chkHonors.Checked = false;
            }
        }
    }
}
