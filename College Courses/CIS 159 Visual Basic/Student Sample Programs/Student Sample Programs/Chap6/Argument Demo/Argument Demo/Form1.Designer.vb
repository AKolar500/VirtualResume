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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDemo3 = New System.Windows.Forms.Button()
        Me.btnDemo2 = New System.Windows.Forms.Button()
        Me.btnDemo1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(95, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDemo3
        '
        Me.btnDemo3.Location = New System.Drawing.Point(176, 21)
        Me.btnDemo3.Name = "btnDemo3"
        Me.btnDemo3.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo3.TabIndex = 2
        Me.btnDemo3.Text = "Demo &3"
        Me.btnDemo3.UseVisualStyleBackColor = True
        '
        'btnDemo2
        '
        Me.btnDemo2.Location = New System.Drawing.Point(95, 21)
        Me.btnDemo2.Name = "btnDemo2"
        Me.btnDemo2.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo2.TabIndex = 1
        Me.btnDemo2.Text = "Demo &2"
        Me.btnDemo2.UseVisualStyleBackColor = True
        '
        'btnDemo1
        '
        Me.btnDemo1.Location = New System.Drawing.Point(14, 21)
        Me.btnDemo1.Name = "btnDemo1"
        Me.btnDemo1.Size = New System.Drawing.Size(75, 23)
        Me.btnDemo1.TabIndex = 0
        Me.btnDemo1.Text = "Demo &1"
        Me.btnDemo1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 94)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDemo3)
        Me.Controls.Add(Me.btnDemo2)
        Me.Controls.Add(Me.btnDemo1)
        Me.Name = "Form1"
        Me.Text = "Argument Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDemo3 As System.Windows.Forms.Button
    Friend WithEvents btnDemo2 As System.Windows.Forms.Button
    Friend WithEvents btnDemo1 As System.Windows.Forms.Button

End Class
