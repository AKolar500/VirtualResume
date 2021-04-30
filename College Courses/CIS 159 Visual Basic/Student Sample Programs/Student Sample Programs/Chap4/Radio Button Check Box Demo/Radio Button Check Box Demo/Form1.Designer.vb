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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radChoice3 = New System.Windows.Forms.RadioButton()
        Me.radChoice2 = New System.Windows.Forms.RadioButton()
        Me.radChoice1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkChoice6 = New System.Windows.Forms.CheckBox()
        Me.chkChoice5 = New System.Windows.Forms.CheckBox()
        Me.chkChoice4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(60, 159)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(150, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radChoice3)
        Me.GroupBox1.Controls.Add(Me.radChoice2)
        Me.GroupBox1.Controls.Add(Me.radChoice1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Radio Buttons"
        '
        'radChoice3
        '
        Me.radChoice3.AutoSize = True
        Me.radChoice3.Location = New System.Drawing.Point(19, 93)
        Me.radChoice3.Name = "radChoice3"
        Me.radChoice3.Size = New System.Drawing.Size(67, 17)
        Me.radChoice3.TabIndex = 2
        Me.radChoice3.TabStop = True
        Me.radChoice3.Text = "Choice 3"
        Me.radChoice3.UseVisualStyleBackColor = True
        '
        'radChoice2
        '
        Me.radChoice2.AutoSize = True
        Me.radChoice2.Location = New System.Drawing.Point(19, 57)
        Me.radChoice2.Name = "radChoice2"
        Me.radChoice2.Size = New System.Drawing.Size(67, 17)
        Me.radChoice2.TabIndex = 1
        Me.radChoice2.TabStop = True
        Me.radChoice2.Text = "Choice 2"
        Me.radChoice2.UseVisualStyleBackColor = True
        '
        'radChoice1
        '
        Me.radChoice1.AutoSize = True
        Me.radChoice1.Location = New System.Drawing.Point(19, 21)
        Me.radChoice1.Name = "radChoice1"
        Me.radChoice1.Size = New System.Drawing.Size(67, 17)
        Me.radChoice1.TabIndex = 0
        Me.radChoice1.TabStop = True
        Me.radChoice1.Text = "Choice 1"
        Me.radChoice1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkChoice6)
        Me.GroupBox2.Controls.Add(Me.chkChoice5)
        Me.GroupBox2.Controls.Add(Me.chkChoice4)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check Boxes"
        '
        'chkChoice6
        '
        Me.chkChoice6.AutoSize = True
        Me.chkChoice6.Location = New System.Drawing.Point(18, 93)
        Me.chkChoice6.Name = "chkChoice6"
        Me.chkChoice6.Size = New System.Drawing.Size(68, 17)
        Me.chkChoice6.TabIndex = 2
        Me.chkChoice6.Text = "Choice 6"
        Me.chkChoice6.UseVisualStyleBackColor = True
        '
        'chkChoice5
        '
        Me.chkChoice5.AutoSize = True
        Me.chkChoice5.Location = New System.Drawing.Point(18, 57)
        Me.chkChoice5.Name = "chkChoice5"
        Me.chkChoice5.Size = New System.Drawing.Size(68, 17)
        Me.chkChoice5.TabIndex = 1
        Me.chkChoice5.Text = "Choice 5"
        Me.chkChoice5.UseVisualStyleBackColor = True
        '
        'chkChoice4
        '
        Me.chkChoice4.AutoSize = True
        Me.chkChoice4.Location = New System.Drawing.Point(18, 21)
        Me.chkChoice4.Name = "chkChoice4"
        Me.chkChoice4.Size = New System.Drawing.Size(68, 17)
        Me.chkChoice4.TabIndex = 0
        Me.chkChoice4.Text = "Choice 4"
        Me.chkChoice4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "Form1"
        Me.Text = "Radio Button Check Box Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radChoice3 As System.Windows.Forms.RadioButton
    Friend WithEvents radChoice2 As System.Windows.Forms.RadioButton
    Friend WithEvents radChoice1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkChoice6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkChoice5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkChoice4 As System.Windows.Forms.CheckBox

End Class
