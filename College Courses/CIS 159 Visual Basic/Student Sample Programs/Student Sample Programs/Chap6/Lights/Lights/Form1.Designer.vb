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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSwitchLight = New System.Windows.Forms.Button()
        Me.lblLightState = New System.Windows.Forms.Label()
        Me.picLightOn = New System.Windows.Forms.PictureBox()
        Me.picLightOff = New System.Windows.Forms.PictureBox()
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 249)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSwitchLight
        '
        Me.btnSwitchLight.Location = New System.Drawing.Point(13, 249)
        Me.btnSwitchLight.Name = "btnSwitchLight"
        Me.btnSwitchLight.Size = New System.Drawing.Size(75, 23)
        Me.btnSwitchLight.TabIndex = 7
        Me.btnSwitchLight.Text = "Switch Light"
        Me.btnSwitchLight.UseVisualStyleBackColor = True
        '
        'lblLightState
        '
        Me.lblLightState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLightState.Location = New System.Drawing.Point(91, 223)
        Me.lblLightState.Name = "lblLightState"
        Me.lblLightState.Size = New System.Drawing.Size(153, 23)
        Me.lblLightState.TabIndex = 6
        Me.lblLightState.Text = "ON"
        Me.lblLightState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLightOn
        '
        Me.picLightOn.Image = CType(resources.GetObject("picLightOn.Image"), System.Drawing.Image)
        Me.picLightOn.Location = New System.Drawing.Point(13, 12)
        Me.picLightOn.Name = "picLightOn"
        Me.picLightOn.Size = New System.Drawing.Size(150, 197)
        Me.picLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightOn.TabIndex = 5
        Me.picLightOn.TabStop = False
        '
        'picLightOff
        '
        Me.picLightOff.Image = CType(resources.GetObject("picLightOff.Image"), System.Drawing.Image)
        Me.picLightOff.Location = New System.Drawing.Point(172, 12)
        Me.picLightOff.Name = "picLightOff"
        Me.picLightOff.Size = New System.Drawing.Size(149, 197)
        Me.picLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightOff.TabIndex = 8
        Me.picLightOff.TabStop = False
        Me.picLightOff.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 284)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSwitchLight)
        Me.Controls.Add(Me.lblLightState)
        Me.Controls.Add(Me.picLightOn)
        Me.Controls.Add(Me.picLightOff)
        Me.Name = "Form1"
        Me.Text = "Lights"
        CType(Me.picLightOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSwitchLight As System.Windows.Forms.Button
    Friend WithEvents lblLightState As System.Windows.Forms.Label
    Friend WithEvents picLightOn As System.Windows.Forms.PictureBox
    Friend WithEvents picLightOff As System.Windows.Forms.PictureBox

End Class
