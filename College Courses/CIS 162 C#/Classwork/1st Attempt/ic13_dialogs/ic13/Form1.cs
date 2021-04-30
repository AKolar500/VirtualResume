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
        bool isDirty = false;

        Font printFont = new Font("Arial", 12);
        Color printColor = Color.Black;

        public string strFileAndPath = "Transcripts.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string strClass;
            int intCreditHrs;
            string strGrade;
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
                MessageBox.Show(ex.ToString(), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            
            isDirty = true;
        }

        private void loadTranscriptListBox()
        {

            lstTranscript.Items.Clear();

            foreach (Transcript objTranscript in colTranscripts)
            {

                lstTranscript.Items.Add(objTranscript);

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



        private void readTranscripts()
        {
            try
            {
                colTranscripts.Clear();
                colTranscripts = TranscriptsData.readTranscripts(strFileAndPath);
                loadTranscriptListBox();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Critical Error");

            }



        }



        private void writeTranscript()
        {
            try
            {
                TranscriptsData.writeTranscripts(colTranscripts, strFileAndPath);
                isDirty = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Critical Error");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readTranscripts();

        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            writeTranscript();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty)
            {


                DialogResult drRtnVal = MessageBox.Show("Do You Want To Save You Data?", "Save", MessageBoxButtons.YesNoCancel);

                switch (drRtnVal)
                {

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Yes:
                        writeTranscript();
                        break;

                    default:
                        break;
                }

            }

        }



        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush objBrush = new SolidBrush(printColor);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float fltLineHeight = printFont.GetHeight();
            float fltPrintX = e.MarginBounds.Left;
            float fltPrintY = e.MarginBounds.Top;
            string strHeaderLine = "   Course     Credit Hours          Grade     Points";

            e.Graphics.DrawString(strHeaderLine, headingFont, objBrush, fltPrintX, fltPrintY);
            fltPrintY += fltLineHeight;

            foreach (Transcript objTranscript in colTranscripts)
            {
                e.Graphics.DrawString(objTranscript.ToString(), printFont, objBrush, fltPrintX, fltPrintY);
                fltPrintY += fltLineHeight;

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = printFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                printFont = fontDialog1.Font;


            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = printColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                printColor = colorDialog1.Color;


            }


        }

        private void SaveAsMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = strFileAndPath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileAndPath = saveFileDialog1.FileName;
                writeTranscript();

            }
        }

        private void OpenMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = strFileAndPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileAndPath = openFileDialog1.FileName;
                readTranscripts();


            }



        }

 


    }
}
