<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnShowModal = New System.Windows.Forms.Button()
        Me.btnShowModeless = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(180, 160)
        Me.lstOutput.TabIndex = 0
        '
        'btnShowModal
        '
        Me.btnShowModal.Location = New System.Drawing.Point(209, 12)
        Me.btnShowModal.Name = "btnShowModal"
        Me.btnShowModal.Size = New System.Drawing.Size(90, 40)
        Me.btnShowModal.TabIndex = 1
        Me.btnShowModal.Text = "&Show a Modal Form"
        Me.btnShowModal.UseVisualStyleBackColor = True
        '
        'btnShowModeless
        '
        Me.btnShowModeless.Location = New System.Drawing.Point(209, 58)
        Me.btnShowModeless.Name = "btnShowModeless"
        Me.btnShowModeless.Size = New System.Drawing.Size(90, 40)
        Me.btnShowModeless.TabIndex = 2
        Me.btnShowModeless.Text = "Show a &Modeless Form"
        Me.btnShowModeless.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(209, 104)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear List Box"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(209, 142)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 184)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowModeless)
        Me.Controls.Add(Me.btnShowModal)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "MainForm"
        Me.Text = "Modal Modeless Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnShowModal As System.Windows.Forms.Button
    Friend WithEvents btnShowModeless As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
