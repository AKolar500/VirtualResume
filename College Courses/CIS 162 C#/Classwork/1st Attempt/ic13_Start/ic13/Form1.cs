//programmer: John Corker
//Program: ic13
//Date:5.17.12
//class:cis162ad

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ic13
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

            string strClass;
            int intCreditHrs;
            string  strGrade;
            bool blnHonors;

            try
            {

                if (validateForm())
                {
 
                    strClass = txtClass.Text;
                    intCreditHrs = int.Parse(txtCreditHrs.Text);
                    strGrade = txtGrade.Text;
                    blnHonors = chkHonors.Checked;

                    saveTranscript(strClass, intCreditHrs, strGrade, blnHonors);

                    loadTranscriptListBox();

                    lblTotalGPA.Text = totalGPA().ToString("n2");

   
                }


            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString(),"Fatal Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void saveTranscript(string strClass, int intCreditHrs, string strGrade, bool blnHonors)
        {
            Transcript objTranscript; 

            if (blnHonors)
            {
                objTranscript = new HonorsTranscript(strClass, intCreditHrs, strGrade);
            }
            else
            {
                objTranscript = new Transcript(strClass, intCreditHrs, strGrade);
            
            }
 
            colTranscripts.Add(objTranscript);
        }

        private void loadTranscriptListBox()
        {

            lstTranscript.Items.Clear();

            foreach (Transcript objTranscript in colTranscripts)
        	{
  
                lstTranscript.Items.Add(objTranscript );

            }
        
        
        }



        private decimal totalGPA()
        {
            decimal decTotalGPA;
            int intPoints = 0;
            int intCredits = 0;

            foreach (Transcript objTranscript in colTranscripts)
            {
                intCredits += objTranscript.CreditHrs;
                intPoints += objTranscript.gradePoints();
            }

            if (intCredits != 0)
            {
                decTotalGPA = (decimal)intPoints / intCredits;
            }
            else
                decTotalGPA = 0;

            return decTotalGPA;
        }

        private bool validateForm()
        {
            bool isValid = false;

 
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
                catch (FormatException)
                {
                    MessageBox.Show("Error:Credit Hours");
                    txtCreditHrs.Focus();
                    txtCreditHrs.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Error:Class");
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



        }



        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }



        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //private void readTranscripts()
        //{
        //    FileStream fsTranscripts = new FileStream("Transcripts.txt", FileMode.Open);
        //    StreamReader srTranscripts = new StreamReader(fsTranscripts);
        //    string strLine;
        //    string[] aryLine;

        //    string strClass;
        //    string strGrade;
        //    string strHonors;

        //    int intCreditHrs;

        //    Transcript objTranscript;

        //    while (srTranscripts.Peek() != -1)
        //    {
        //        strLine = srTranscripts.ReadLine();
        //        aryLine = strLine.Split(';');

        //        strClass = aryLine[0];
        //        intCreditHrs = int.Parse(aryLine[1]);
        //        strGrade = aryLine[2];
        //        strHonors = aryLine[3];

        //        if (strHonors == "H")
        //        {
        //            objTranscript = new HonorsTranscript(strClass, intCreditHrs, strGrade);
        //        }
        //        else
        //        {
        //            objTranscript = new Transcript(strClass, intCreditHrs, strGrade);
        //        }

        //        colTranscripts.Add(objTranscript);
        //    }
        //    fsTranscripts.Close();
        //    srTranscripts.Close();
        //}

        //private void writeTranscripts()
        //{
        //    FileStream fsTranscripts = new FileStream("Transcripts.txt", FileMode.Create);
        //    StreamWriter swTranscripts = new StreamWriter(fsTranscripts);

        //    foreach (Transcript objTranscript in colTranscripts)
        //    {
        //        string strLine = objTranscript.Course + ';' + objTranscript.CreditHrs.ToString() + ';' +
        //            objTranscript.Grade + ';';

        //        if (objTranscript.GetType().Name == "HonorsTranscript")
        //        {
        //            strLine += "H";
        //        }
        //        swTranscripts.WriteLine(strLine);
        //    }
        //    swTranscripts.Close();
        //    fsTranscripts.Close();
        //}
        private void btnRead_Click(object sender, EventArgs e)
        {
            colTranscripts.Clear();
            TranscriptsData objTranscriptData = new TranscriptsData();
            colTranscripts = objTranscriptData.readTranscripts();
            loadTranscriptListBox();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            TranscriptsData objTranscriptData = new TranscriptsData();
            objTranscriptData.writeTranscripts(colTranscripts);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRead_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drRtnVal = MessageBox.Show("Do you want to save the puppies?", "Save", MessageBoxButtons.YesNoCancel);
            switch (drRtnVal)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    writeTranscripts();
                    break;
                default:
                    break;
            }
        }
    }
}
