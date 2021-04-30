using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic14TableAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblTranscriptsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblTranscriptsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbTranscriptsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTranscriptsDataSet.tblTranscripts' table. You can move, or remove it, as needed.
            this.tblTranscriptsTableAdapter.Fill(this.dbTranscriptsDataSet.tblTranscripts);

        }
    }
}
