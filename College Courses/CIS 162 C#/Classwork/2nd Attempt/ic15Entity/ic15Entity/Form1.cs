using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;


namespace ic15Entity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dbTranscriptsEntities db;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dbTranscriptsEntities();


            var xxx = from x in db.tblTranscripts
                      orderby x.ClassGrade descending
                      where x.ClassGrade == "A" || x.ClassGrade == "B" 
                      select x;

            var yyy = db.tblTranscripts.Where(x => x.ClassGrade == "A" || x.ClassGrade == "B").OrderByDescending(x => x.ClassGrade);

            tblTranscriptsBindingSource.DataSource = xxx;



            lblGPA.Text = totalGPA().ToString("n2");
        }

        private decimal totalGPA()
        {
            decimal decTotalGPA = 0;
            decimal intCreditHours = 0;

            foreach (tblTranscript objTranscrpt in db.tblTranscripts)
            {
                decTotalGPA += objTranscrpt.GradePoints;
                intCreditHours += objTranscrpt.ClassCreditHours;
            }


            return decTotalGPA / intCreditHours;



        }
    }
}
