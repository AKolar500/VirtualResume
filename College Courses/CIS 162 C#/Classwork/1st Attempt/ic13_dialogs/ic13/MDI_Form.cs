using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ic13
{
    public partial class MDI_Form : Form
    {
        public MDI_Form()
        {
            InitializeComponent();
        }

        private void MDI_Form_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private void activeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmForm1 = new Form1();
            frmForm1.MdiParent = this;
            frmForm1.Show();

        }
    }
}
