namespace CS15_Kolar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dbTranscriptsDataSet = new CS15_Kolar.dbTranscriptsDataSet();
            this.tblTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionsTableAdapter = new CS15_Kolar.dbTranscriptsDataSetTableAdapters.tblTransactionsTableAdapter();
            this.tableAdapterManager = new CS15_Kolar.dbTranscriptsDataSetTableAdapters.TableAdapterManager();
            this.tblTransactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbTranscriptsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTranscriptsDataSet
            // 
            this.dbTranscriptsDataSet.DataSetName = "dbTranscriptsDataSet";
            this.dbTranscriptsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTransactionsBindingSource
            // 
            this.tblTransactionsBindingSource.DataMember = "tblTransactions";
            this.tblTransactionsBindingSource.DataSource = this.dbTranscriptsDataSet;
            // 
            // tblTransactionsTableAdapter
            // 
            this.tblTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblTransactionsTableAdapter = this.tblTransactionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS15_Kolar.dbTranscriptsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblTransactionsBindingSource1
            // 
            this.tblTransactionsBindingSource1.DataSource = typeof(ClassLibrary1.tblTransaction);
            // 
            // tblTransactionsDataGridView
            // 
            this.tblTransactionsDataGridView.AutoGenerateColumns = false;
            this.tblTransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblTransactionsDataGridView.DataSource = this.tblTransactionsBindingSource;
            this.tblTransactionsDataGridView.Location = new System.Drawing.Point(28, 78);
            this.tblTransactionsDataGridView.Name = "tblTransactionsDataGridView";
            this.tblTransactionsDataGridView.Size = new System.Drawing.Size(446, 220);
            this.tblTransactionsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemDescription";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "ItemPrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.tblTransactionsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTranscriptsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dbTranscriptsDataSet dbTranscriptsDataSet;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource;
        private dbTranscriptsDataSetTableAdapters.tblTransactionsTableAdapter tblTransactionsTableAdapter;
        private dbTranscriptsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tblTransactionsBindingSource1;
        private System.Windows.Forms.DataGridView tblTransactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

