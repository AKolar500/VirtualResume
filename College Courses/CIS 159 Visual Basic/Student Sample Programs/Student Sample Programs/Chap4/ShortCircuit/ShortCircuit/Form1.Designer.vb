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
        Me.btnAndAlso = New System.Windows.Forms.Button()
        Me.btnAnd = New System.Windows.Forms.Button()
        Me.btnOrElse = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(144, 147)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        '
        'btnAndAlso
        '
        Me.btnAndAlso.Location = New System.Drawing.Point(197, 64)
        Me.btnAndAlso.Name = "btnAndAlso"
        Me.btnAndAlso.Size = New System.Drawing.Size(120, 23)
        Me.btnAndAlso.TabIndex = 16
        Me.btnAndAlso.Text = "AndAlso Operator"
        '
        'btnAnd
        '
        Me.btnAnd.Location = New System.Drawing.Point(197, 25)
        Me.btnAnd.Name = "btnAnd"
        Me.btnAnd.Size = New System.Drawing.Size(120, 23)
        Me.btnAnd.TabIndex = 15
        Me.btnAnd.Text = "AND Operator"
        '
        'btnOrElse
        '
        Me.btnOrElse.Location = New System.Drawing.Point(37, 64)
        Me.btnOrElse.Name = "btnOrElse"
        Me.btnOrElse.Size = New System.Drawing.Size(120, 23)
        Me.btnOrElse.TabIndex = 14
        Me.btnOrElse.Text = "OrElse Operator"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(14, 107)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(326, 23)
        Me.lblResult.TabIndex = 13
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOr
        '
        Me.btnOr.Location = New System.Drawing.Point(37, 25)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(120, 23)
        Me.btnOr.TabIndex = 12
        Me.btnOr.Text = "OR Operator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 194)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAndAlso)
        Me.Controls.Add(Me.btnAnd)
        Me.Controls.Add(Me.btnOrElse)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnOr)
        Me.Name = "Form1"
        Me.Text = "Short Circuit Evaluation"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAndAlso As System.Windows.Forms.Button
    Friend WithEvents btnAnd As System.Windows.Forms.Button
    Friend WithEvents btnOrElse As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnOr As System.Windows.Forms.Button

End Class
