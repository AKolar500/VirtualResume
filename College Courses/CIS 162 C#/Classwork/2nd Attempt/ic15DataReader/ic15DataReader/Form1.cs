using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic15DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Transcript> colTranscripts = new List<Transcript>();
        private int cintCurrentRcd = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                colTranscripts = clsDataTier.GetAllTranscriptsList();

                UpdateForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateForm()
        {
            if (colTranscripts.Count == 0)
            {
                InsertForm();

            }
            else
            {
                txtID.Text = colTranscripts[cintCurrentRcd].ID.ToString();
                txtClassName.Text = colTranscripts[cintCurrentRcd].ClassName;
                txtClassCreditHours.Text = colTranscripts[cintCurrentRcd].CreditHours.ToString();
                txtClassGrade.Text = colTranscripts[cintCurrentRcd].Grade;
                txtGradePoints.Text = colTranscripts[cintCurrentRcd].gradePoints().ToString();
            }


        }

  
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cintCurrentRcd > 0)
            {
                cintCurrentRcd -= 1;
            }

            UpdateForm();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cintCurrentRcd + 1 < colTranscripts.Count)
            {
                cintCurrentRcd += 1;
            }

            UpdateForm();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm();
        }
        private void InsertForm()
        {

            txtID.Text = "";
            txtClassName.Text = "";
            txtClassCreditHours.Text = "";
            txtClassGrade.Text = "";
            txtGradePoints.Text = "";

            btnInsert.Enabled = false;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Transcript objOriginal_Transcript;
            Transcript objNew_Transcript;

            try
            {
                if (btnInsert.Enabled == true)
                {

                    objOriginal_Transcript = colTranscripts[cintCurrentRcd];


                    objNew_Transcript = new Transcript();

                    objNew_Transcript.ID = int.Parse(txtID.Text);
                    objNew_Transcript.ClassName = txtClassName.Text;
                    objNew_Transcript.CreditHours = int.Parse(txtClassCreditHours.Text);
                    objNew_Transcript.Grade = txtClassGrade.Text;

                    clsDataTier.UpdateTranscript(objOriginal_Transcript, objNew_Transcript);

                }
                else
                {
                    objNew_Transcript = new Transcript();

                    objNew_Transcript.ClassName = txtClassName.Text;
                    objNew_Transcript.CreditHours = int.Parse(txtClassCreditHours.Text);
                    objNew_Transcript.Grade = txtClassGrade.Text;

                    clsDataTier.InsertTranscript(objNew_Transcript);

                    cintCurrentRcd = colTranscripts.Count;
                }

                colTranscripts = clsDataTier.GetAllTranscriptsList();

                UpdateForm();

                btnInsert.Enabled = true;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
 
            btnInsert.Enabled = true;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;

            UpdateForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                Transcript objOriginal_Transcript = colTranscripts[cintCurrentRcd];


                clsDataTier.DeleteTranscript(objOriginal_Transcript);

                colTranscripts = clsDataTier.GetAllTranscriptsList();

                if (cintCurrentRcd >= colTranscripts.Count)
                    cintCurrentRcd = colTranscripts.Count - 1;

                UpdateForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }


    }
}
