/*Alex Kolar
 * 5/1/2013
 * CIS162AD Section 29153
 * CS14 - Databases
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS14_Kolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblTransactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTransactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbTranscriptsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTranscriptsDataSet.tblTransactions' table. You can move, or remove it, as needed.
            this.tblTransactionsTableAdapter.Fill(this.dbTranscriptsDataSet.tblTransactions);

        }
    }
}
