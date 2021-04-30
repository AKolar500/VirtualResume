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

namespace ic11_040313
{
    public partial class Form1 : Form
    {
        List<Transcript> colTranscripts = new List<Transcript>();
        Transcript objCurrentTranscript;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string strCourseName, strCourseGrade;
            int intCourseCreditHrs;

            try
            {
                if (validateCourse())
                {
                    strCourseName = txtClass.Text;
                    intCourseCreditHrs = int.Parse(txtCreditHrs.Text);
                    strCourseGrade = txtGrade.Text;

                    AddCourse(strCourseName, intCourseCreditHrs, strCourseGrade);

                    loadCourseListBox();

                    clearTextBoxes();

                    //lblTotalGPA.Text = getTotalGPA().ToString("n2");
                }
            }
            //This guy catches every exception that the entire transcript object would normally catch.
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error:\n" + ex.Message + "\nHeart Attack!");
            }

            //if (validateCourse())
            //{
            //    strCourseName = txtClass.Text;
            //    intCourseCreditHrs = int.Parse(txtCreditHrs.Text);
            //    strCourseGrade = txtGrade.Text;

            //    AddCourse(strCourseName, intCourseCreditHrs, strCourseGrade);

            //    loadCourseListBox();

            //    lblTotalGPA.Text = getTotalGPA().ToString("n2");
            //}
        }

        public void clearTextBoxes()
        {
            txtClass.Clear();
            txtCreditHrs.Clear();
            txtGrade.Clear();
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
            if (intTotalCreditHrs != 0)
            {
                decTotalGPA /= intTotalCreditHrs;
            }

            return decTotalGPA;

        }

        public void AddCourse(string strCourseName, int intCreditHrs, string strLetterGrade)
        {
            Transcript objTranscript = new Transcript(strCourseName, intCreditHrs, strLetterGrade);

            colTranscripts.Add(objTranscript);

        }

        public void loadCourseListBox()
        {
            lstTranscripts.Items.Clear();

            foreach (Transcript objTranscript in colTranscripts)
            {
                lstTranscripts.Items.Add(objTranscript);
            }

            lblTotalGPA.Text = getTotalGPA().ToString("n2");
        }


        private bool validateCourse()
        {
            int intDummy;
            string strGrade;

            if (txtClass.Text == "")
            {
                MessageBox.Show("Error:Class Hours");
                txtClass.Focus();
                txtClass.SelectAll();

                return false;
            }

            try
            {
                int.Parse(txtCreditHrs.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error:Credit Hours");
                txtCreditHrs.Focus();
                txtCreditHrs.SelectAll();

                return false;
            }

            //if (!int.TryParse(txtCreditHrs.Text, out intDummy))
            //{
            //    MessageBox.Show("Error:Credit Hours");
            //    txtCreditHrs.Focus();
            //    txtCreditHrs.SelectAll();

            //    return false;

            //}

            strGrade = txtGrade.Text.ToUpper();
            if (!Regex.Match(strGrade, "^[ABCDF]$").Success)
            {
                MessageBox.Show("Error:Grade");
                txtGrade.Focus();
                txtGrade.SelectAll();

                return false;

            }

            return true;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateCourse())
                {
                    objCurrentTranscript.ClassName = txtClass.Text;
                    objCurrentTranscript.CreditHours = int.Parse(txtCreditHrs.Text);
                    objCurrentTranscript.Grade = txtGrade.Text;

                    loadCourseListBox();
                    clearTextBoxes();

                    btnAddItem.Enabled = true;

                    txtClass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Critical Error:\n" + ex.Message + "\nStroke!");
            }

        }

        private void lstTranscripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            objCurrentTranscript = colTranscripts[lstTranscripts.SelectedIndex];

            txtClass.Text = objCurrentTranscript.ClassName;
            txtCreditHrs.Text = objCurrentTranscript.CreditHours.ToString();
            txtGrade.Text = objCurrentTranscript.Grade;

            btnAddItem.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            colTranscripts.RemoveAt(lstTranscripts.SelectedIndex);
            loadCourseListBox();
            clearTextBoxes();

            btnDelete.Enabled = false;
            btnAddItem.Enabled = true;
            txtClass.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBoxes();

            btnAddItem.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtClass.Focus();
        }

    }
}
