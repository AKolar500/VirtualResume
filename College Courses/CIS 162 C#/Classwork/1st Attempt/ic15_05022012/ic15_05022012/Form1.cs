//This Program's Open control is busted
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ic15_05022012
{
    public partial class Form1 : Form
    {
        Font printFont = new Font("Arial", 12);
        Color printColor = Color.Black;

        string strCnString1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        string strCnString2 = "F:\\College Courses\\CIS 162\\Classwork\\ic15_05022012\\ic15_05022012\\bin\\Debug\\Transcripts.accdb";
        string strCnString3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCommand = " Select * " +
                " From tblTranscripts ";
            string strCourse;
            string strLetterGrade;
            string strLine;
            int intID;
            int intCreditHours;

            strCnString3 = strCnString1 + strCnString2;

            OleDbConnection cn = new OleDbConnection(strCnString3);
            
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(strCommand, cn);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                intID = Convert.ToInt32(dr["ID"]);
                strCourse = dr["ClassName"].ToString();
                intCreditHours = Convert.ToInt32(dr["CreditHours"]);
                strLetterGrade = dr["LetterGrade"].ToString();

                strLine = " " + intID.ToString() + "\t\t" +
                        strCourse + "\t\t" +
                        intCreditHours.ToString() + "\t\t" +
                        strLetterGrade;

                lstTranscripts.Items.Add(strLine);
            }
            dr.Close();
            cn.Close();
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
            string strHeaderLine = "Credit Hours     Course          Points     Grade";

            e.Graphics.DrawString(strHeaderLine, headingFont, objBrush, fltPrintX, fltPrintY);
            fltPrintY += fltLineHeight;

            foreach (string objString in lstTranscripts.Items)
            {
                e.Graphics.DrawString(objString.ToString(), printFont, objBrush, fltPrintX, fltPrintY);
                fltPrintY += fltLineHeight;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = printFont;
            DialogResult rslt = fontDialog1.ShowDialog();

            if (rslt == DialogResult.OK)
            {
                printFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = printColor;
            DialogResult rslt = colorDialog1.ShowDialog();
            
            if (rslt == DialogResult.OK)
            {
                printColor = colorDialog1.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = strCnString2;
            DialogResult rslt = openFileDialog1.ShowDialog();

            if (rslt == DialogResult.OK)
            {
                strCnString2 = openFileDialog1.FileName;
                Form1_Load(sender, e);
            }
        }
    }
}
