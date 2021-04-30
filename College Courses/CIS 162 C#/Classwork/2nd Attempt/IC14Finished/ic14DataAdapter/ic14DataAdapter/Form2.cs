using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

/*Note:
 * to use ConfigurationManager.ConnectionStrings you have to import 
 * the System.Configuration Namespace ("using System.Configuration")
 * and add a reference to the System.Configuration dll assembly.
 * menu option: Project/Add Reference/.Net Tab
*/

namespace ic14DataAdapter
{
    public partial class Form2 : Form
    {
        string strConnectionString = ConfigurationManager.ConnectionStrings["ic14DataAdapter.Properties.Settings.dbTranscriptsConnectionString"].ToString();

        private SqlConnection cnTranscripts;

        private SqlDataAdapter daTranscripts;

        private DataSet dsTranscripts;
        private BindingSource bsTranscripts;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cnTranscripts = new SqlConnection(strConnectionString);

            string strCommand = "Select ID, ClassName, ClassCreditHours, ClassGrade " +
                                " From tblTranscripts";
            daTranscripts = new SqlDataAdapter(strCommand, cnTranscripts);

            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(daTranscripts);

            dsTranscripts = new DataSet();
            daTranscripts.Fill(dsTranscripts, "tblTranscripts");

            bsTranscripts = new BindingSource();
            bsTranscripts.DataSource = dsTranscripts.Tables["tblTranscripts"];

            txtID.DataBindings.Add("Text", bsTranscripts, "ID");
            txtClassName.DataBindings.Add("Text", bsTranscripts, "ClassName");
            txtClassCreditHours.DataBindings.Add("Text", bsTranscripts, "ClassCreditHours");
            txtClassGrade.DataBindings.Add("Text", bsTranscripts, "ClassGrade");

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsTranscripts.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsTranscripts.MoveNext();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bsTranscripts.EndEdit();
            daTranscripts.Update(dsTranscripts, "tblTranscripts");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bsTranscripts.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsTranscripts.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsTranscripts.CancelEdit();
        }
    }
}
