namespace ic14TableAdapter
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label classNameLabel;
            System.Windows.Forms.Label classCreditHoursLabel;
            System.Windows.Forms.Label classGradeLabel;
            this.dbTranscriptsDataSet = new ic14TableAdapter.dbTranscriptsDataSet();
            this.tblTranscriptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTranscriptsTableAdapter = new ic14TableAdapter.dbTranscriptsDataSetTableAdapters.tblTranscriptsTableAdapter();
            this.tableAdapterManager = new ic14TableAdapter.dbTranscriptsDataSetTableAdapters.TableAdapterManager();
            this.tblTranscriptsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblTranscriptsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.classCreditHoursTextBox = new System.Windows.Forms.TextBox();
            this.classGradeTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            classNameLabel = new System.Windows.Forms.Label();
            classCreditHoursLabel = new System.Windows.Forms.Label();
            classGradeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbTranscriptsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTranscriptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTranscriptsBindingNavigator)).BeginInit();
            this.tblTranscriptsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTranscriptsDataSet
            // 
            this.dbTranscriptsDataSet.DataSetName = "dbTranscriptsDataSet";
            this.dbTranscriptsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTranscriptsBindingSource
            // 
            this.tblTranscriptsBindingSource.DataMember = "tblTranscripts";
            this.tblTranscriptsBindingSource.DataSource = this.dbTranscriptsDataSet;
            // 
            // tblTranscriptsTableAdapter
            // 
            this.tblTranscriptsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblTranscriptsTableAdapter = this.tblTranscriptsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ic14TableAdapter.dbTranscriptsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblTranscriptsBindingNavigator
            // 
            this.tblTranscriptsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblTranscriptsBindingNavigator.BindingSource = this.tblTranscriptsBindingSource;
            this.tblTranscriptsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblTranscriptsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblTranscriptsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblTranscriptsBindingNavigatorSaveItem});
            this.tblTranscriptsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblTranscriptsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblTranscriptsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblTranscriptsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblTranscriptsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblTranscriptsBindingNavigator.Name = "tblTranscriptsBindingNavigator";
            this.tblTranscriptsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblTranscriptsBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.tblTranscriptsBindingNavigator.TabIndex = 0;
            this.tblTranscriptsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblTranscriptsBindingNavigatorSaveItem
            // 
            this.tblTranscriptsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblTranscriptsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblTranscriptsBindingNavigatorSaveItem.Image")));
            this.tblTranscriptsBindingNavigatorSaveItem.Name = "tblTranscriptsBindingNavigatorSaveItem";
            this.tblTranscriptsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblTranscriptsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblTranscriptsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblTranscriptsBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(44, 77);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTranscriptsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(146, 74);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // classNameLabel
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.Location = new System.Drawing.Point(44, 103);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new System.Drawing.Size(66, 13);
            classNameLabel.TabIndex = 3;
            classNameLabel.Text = "Class Name:";
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTranscriptsBindingSource, "ClassName", true));
            this.classNameTextBox.Location = new System.Drawing.Point(146, 100);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.classNameTextBox.TabIndex = 4;
            // 
            // classCreditHoursLabel
            // 
            classCreditHoursLabel.AutoSize = true;
            classCreditHoursLabel.Location = new System.Drawing.Point(44, 129);
            classCreditHoursLabel.Name = "classCreditHoursLabel";
            classCreditHoursLabel.Size = new System.Drawing.Size(96, 13);
            classCreditHoursLabel.TabIndex = 5;
            classCreditHoursLabel.Text = "Class Credit Hours:";
            // 
            // classCreditHoursTextBox
            // 
            this.classCreditHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTranscriptsBindingSource, "ClassCreditHours", true));
            this.classCreditHoursTextBox.Location = new System.Drawing.Point(146, 126);
            this.classCreditHoursTextBox.Name = "classCreditHoursTextBox";
            this.classCreditHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.classCreditHoursTextBox.TabIndex = 6;
            // 
            // classGradeLabel
            // 
            classGradeLabel.AutoSize = true;
            classGradeLabel.Location = new System.Drawing.Point(44, 155);
            classGradeLabel.Name = "classGradeLabel";
            classGradeLabel.Size = new System.Drawing.Size(67, 13);
            classGradeLabel.TabIndex = 7;
            classGradeLabel.Text = "Class Grade:";
            // 
            // classGradeTextBox
            // 
            this.classGradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTranscriptsBindingSource, "ClassGrade", true));
            this.classGradeTextBox.Location = new System.Drawing.Point(146, 152);
            this.classGradeTextBox.Name = "classGradeTextBox";
            this.classGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.classGradeTextBox.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(classNameLabel);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(classCreditHoursLabel);
            this.Controls.Add(this.classCreditHoursTextBox);
            this.Controls.Add(classGradeLabel);
            this.Controls.Add(this.classGradeTextBox);
            this.Controls.Add(this.tblTranscriptsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTranscriptsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTranscriptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTranscriptsBindingNavigator)).EndInit();
            this.tblTranscriptsBindingNavigator.ResumeLayout(false);
            this.tblTranscriptsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbTranscriptsDataSet dbTranscriptsDataSet;
        private System.Windows.Forms.BindingSource tblTranscriptsBindingSource;
        private dbTranscriptsDataSetTableAdapters.tblTranscriptsTableAdapter tblTranscriptsTableAdapter;
        private dbTranscriptsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblTranscriptsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblTranscriptsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.TextBox classCreditHoursTextBox;
        private System.Windows.Forms.TextBox classGradeTextBox;
    }
}