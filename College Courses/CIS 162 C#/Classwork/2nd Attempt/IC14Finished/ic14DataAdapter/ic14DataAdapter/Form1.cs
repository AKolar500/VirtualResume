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
 * */

namespace ic14DataAdapter
{
    public partial class Form1 : Form
    {
        private SqlConnection cnTranscripts;
        private SqlDataAdapter daTranscripts;
        private DataSet dsTranscripts;
        private BindingSource bsTranscripts;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string strConnectionString = ConfigurationManager.ConnectionStrings["ic14DataAdapter.Properties.Settings.dbTranscriptsConnectionString"].ToString();

            cnTranscripts = new SqlConnection(strConnectionString);
            
            string strCommand = "Select ID, ClassName, ClassCreditHours, ClassGrade " + 
                                " From tblTranscripts";
            daTranscripts = new SqlDataAdapter(strCommand, cnTranscripts);
            
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(daTranscripts);
            
            dsTranscripts = new DataSet();
            daTranscripts.Fill(dsTranscripts, "tblTranscripts");

            bsTranscripts = new BindingSource(dsTranscripts, "tblTranscripts");
            
            bindingNavigator1.BindingSource = bsTranscripts;

            dgvTranscripts.DataSource = bsTranscripts;

            cnTranscripts.Close();

        }

         private void bindingNavigatorUpdate_Click(object sender, EventArgs e)
        {
            daTranscripts.Update(dsTranscripts, "tblTranscripts");
 
        }
    
    
    
    }
}
