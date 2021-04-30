<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstTypes = New System.Windows.Forms.ListBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.KayaksDataSet = New WindowsApplication1.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kayak_TypesTableAdapter = New WindowsApplication1.KayaksDataSetTableAdapters.Kayak_TypesTableAdapter()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTypes
        '
        Me.lstTypes.DataSource = Me.KayakTypesBindingSource
        Me.lstTypes.DisplayMember = "Name"
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.Location = New System.Drawing.Point(23, 64)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(200, 186)
        Me.lstTypes.TabIndex = 0
        Me.lstTypes.ValueMember = "Description"
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Location = New System.Drawing.Point(268, 64)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(370, 186)
        Me.lblDescription.TabIndex = 1
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "Kayak Types"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'Kayak_TypesTableAdapter
        '
        Me.Kayak_TypesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 321)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lstTypes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstTypes As System.Windows.Forms.ListBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents KayaksDataSet As WindowsApplication1.KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Kayak_TypesTableAdapter As WindowsApplication1.KayaksDataSetTableAdapters.Kayak_TypesTableAdapter

End Class
