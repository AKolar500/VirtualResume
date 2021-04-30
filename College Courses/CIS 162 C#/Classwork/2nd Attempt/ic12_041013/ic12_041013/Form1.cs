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

namespace ic12_041013
{
    public partial class Form1 : Form
    {
        List<Transcript> colTranscripts = new List<Transcript>();

        Transcript cobjCurrentTranscript;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string strCourseName, strCourseGrade;
            int intCourseCreditHrs;
            bool blnHonors;

            try
            {
                if (validateCourse())
                {
                    strCourseName = txtClass.Text;
                    intCourseCreditHrs = int.Parse(txtCreditHrs.Text);
                    strCourseGrade = txtGrade.Text;
                    blnHonors = chkHonors.Checked;

                    AddCourse(strCourseName, intCourseCreditHrs, strCourseGrade, blnHonors);

                    clearInputFields();

                    UpdateFormData();


                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            decTotalGPA /= intTotalCreditHrs;

            return decTotalGPA;

        }

        public void AddCourse(string strCourseName, int intCreditHrs, string strLetterGrade, bool blnHonors)
        {
            if (blnHonors)
            {
                Honors objHonors = new Honors(strCourseName, intCreditHrs, strLetterGrade);
                colTranscripts.Add(objHonors);
            }
            else
            {
                Transcript objTranscript = new Transcript(strCourseName, intCreditHrs, strLetterGrade);
                colTranscripts.Add(objTranscript);
            }
        }

        public void UpdateFormData()
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
            string strGrade;

            if (txtClass.Text == "")
            {
                MessageBox.Show("Error:Class Name");
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
            try
            {
                lstTranscripts.Items.Clear();

                clearInputFields();

                lblTotalGPA.Text = "";

                txtClass.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                clearInputFields();

                lstTranscripts.SelectedIndex = -1;

                btnAddItem.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void clearInputFields()
        {
            txtClass.Text = "";
            txtCreditHrs.Text = "";
            txtGrade.Text = "";
            chkHonors.Checked = false;
        }

        private void lstTranscripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstTranscripts.SelectedIndex > -1)
                {

                    btnAddItem.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    if (colTranscripts[lstTranscripts.SelectedIndex] is Honors)
                    {
                        Honors objHonors = (Honors)colTranscripts[lstTranscripts.SelectedIndex];
                        txtClass.Text = objHonors.ClassName;
                        txtCreditHrs.Text = objHonors.CreditHours.ToString();
                        txtGrade.Text = objHonors.Grade;

                        chkHonors.Checked = true;
                    }
                    else
                    {
                        Transcript objTranscript = colTranscripts[lstTranscripts.SelectedIndex];

                        txtClass.Text = cobjCurrentTranscript.ClassName;
                        txtCreditHrs.Text = cobjCurrentTranscript.CreditHours.ToString();
                        txtGrade.Text = cobjCurrentTranscript.Grade;

                        chkHonors.Checked = false;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateCourse())
                {
                    if (chkHonors.Checked)
                    {
                        Honors objHonors = new Honors();

                        objHonors.ClassName = txtClass.Text;
                        objHonors.CreditHours = int.Parse(txtCreditHrs.Text);
                        objHonors.Grade = txtGrade.Text;

                        colTranscripts[lstTranscripts.SelectedIndex] = objHonors;
                    }
                    else
                    {
                        Transcript objTranscript = new Transcript();

                        objTranscript.ClassName = txtClass.Text;
                        objTranscript.CreditHours = int.Parse(txtCreditHrs.Text);
                        objTranscript.Grade = txtGrade.Text;

                        colTranscripts[lstTranscripts.SelectedIndex] = objTranscript;
                    }
                    

                    clearInputFields();

                    UpdateFormData();

                    lblTotalGPA.Text = getTotalGPA().ToString("n2");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTranscripts.SelectedIndex > -1)
                {
                    colTranscripts.RemoveAt(lstTranscripts.SelectedIndex);

                    clearInputFields();

                    btnAddItem.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;

                    UpdateFormData();

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Critcal Error\n" + ex.ToString(), "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void chkHonors_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHonors.Checked)
            {
                cboHonorsType.Enabled = true;
            }
            else
            {
                cboHonorsType.Enabled = false;
                cboHonorsType.SelectedIndex = -1;
                cboHonorsType.Text = "Honors Type";
            }
        }

    }
}
