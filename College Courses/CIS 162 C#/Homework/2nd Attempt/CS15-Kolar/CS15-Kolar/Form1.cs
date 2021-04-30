/*Alex Kolar
 * 5/08/2013
 * CIS162AD Section 29153
 * CS15 - Databases Part 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;

namespace CS15_Kolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void tblTransactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.tblTransactionsBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dbTranscriptsDataSet);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dbTranscriptsEntities db = new dbTranscriptsEntities();

            tblTransactionsBindingSource.DataSource = db.tblTransactions;
        }

        //private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        //{
        //    //delete selected row
        //    if (this.tblTransactionsDataGridView.SelectedRows.Count > 0)
        //    {
        //        tblTransactionsDataGridView.Rows.RemoveAt(this.tblTransactionsDataGridView.SelectedRows[0].Index);
        //    }
        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
