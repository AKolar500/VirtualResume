using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ic15_DataReader
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int intID;
            String strCourse;
            int intCreditHours;
            string strLetterGrade;
            string strLine;


            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Transcripts.accdb");

            string strCommand = "Select * " +
                                " from tblTranscripts ";

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


            cn.Close();
 
        }
    }
}
