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
    public partial class Form2 : Form
    {
        Transcript objOrigTrans;

         public Form2()
        {
            InitializeComponent();
        }
        public Form2(int intRcdNo)
        {
            InitializeComponent();
            txtID.Text = intRcdNo.ToString();
        }




        private void btnGet_Click(object sender, EventArgs e)
        {
            int intID;


            if (int.TryParse(txtID.Text, out intID))
            {

                objOrigTrans = TranscriptDB.GetTranscript(intID);
                if (objOrigTrans != null)
                {
                    txtClassName.Text = objOrigTrans.Course;
                    txtCreditHours.Text = objOrigTrans.CreditHrs.ToString();
                    txtLetterGrade.Text = objOrigTrans.Grade;
                    lblLetterGrade.Text = objOrigTrans.GradePoints.ToString();
 
                }
                else
                {
                    MessageBox.Show("No Rcd Found");
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                btnGet_Click(sender, e);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                Transcript objNewTrans = new Transcript();

                objNewTrans.ID = int.Parse(txtID.Text);
                objNewTrans.Course = txtClassName.Text;
                objNewTrans.CreditHrs = int.Parse(txtCreditHours.Text);
                objNewTrans.Grade = txtLetterGrade.Text;

                TranscriptDB.UpdateTranscript(objOrigTrans, objNewTrans);
            }

  
        }
        private bool validateForm()
        {
            int intDummy;

            if (!int.TryParse(txtID.Text, out intDummy))
            {
                MessageBox.Show("Invalid ID");
                txtID.Focus();
                return false;
            }

            if ((txtClassName.Text == string.Empty))
            {
                MessageBox.Show("Invalid Class Name");
                txtClassName.Focus();
                return false;
            }

            if (!int.TryParse(txtCreditHours.Text, out intDummy))
            {
                MessageBox.Show("Invalid Credit Hours");
                txtCreditHours.Focus();
                return false;
            }

            if ((txtLetterGrade.Text == string.Empty))
            {
                MessageBox.Show("Invalid Letter Grade");
                txtLetterGrade.Focus();
                return false;
            }



            return true;
        }

    }

}