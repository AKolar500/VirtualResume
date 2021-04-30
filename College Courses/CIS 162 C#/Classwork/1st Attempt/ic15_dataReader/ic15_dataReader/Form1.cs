using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic15_DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            List<Transcript> colTranscripts;

            colTranscripts = TranscriptDB.GetAllTranscripts();

            dataGridView1.DataSource = colTranscripts;


            lblGPA.Text = GetGPA().ToString();

        }
        private decimal GetGPA()
        {
            List<Transcript> colTranscripts;
            decimal decTotalGradePoints = 0, intTotalCreditHours = 0;
            decimal decTotalGPA;

            colTranscripts = TranscriptDB.GetAllTranscripts();
            foreach (Transcript objTranscript in colTranscripts)
            {
                decTotalGradePoints += objTranscript.gradePoints();
                intTotalCreditHours += objTranscript.CreditHrs;

            }
            decTotalGPA = decTotalGradePoints / intTotalCreditHours;

            return decTotalGPA;

        }

  

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int intElement = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


            Form2 objForm2 = new Form2(intElement);
            objForm2.ShowDialog();

        }
    }
}
