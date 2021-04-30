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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPatientInfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.radInjury = New System.Windows.Forms.RadioButton()
        Me.radDisease = New System.Windows.Forms.RadioButton()
        Me.grpInjurySymptoms = New System.Windows.Forms.GroupBox()
        Me.chkBleeding = New System.Windows.Forms.CheckBox()
        Me.chkAnorexic = New System.Windows.Forms.CheckBox()
        Me.chkBrokenBones = New System.Windows.Forms.CheckBox()
        Me.chkOrganDamage = New System.Windows.Forms.CheckBox()
        Me.chkForeignObject = New System.Windows.Forms.CheckBox()
        Me.grpDiseaseSymptoms = New System.Windows.Forms.GroupBox()
        Me.chkDiarrhea = New System.Windows.Forms.CheckBox()
        Me.chkFever = New System.Windows.Forms.CheckBox()
        Me.chkBlindness = New System.Windows.Forms.CheckBox()
        Me.chkHallucinating = New System.Windows.Forms.CheckBox()
        Me.chkVomiting = New System.Windows.Forms.CheckBox()
        Me.btnAdmit = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.tabTreatment = New System.Windows.Forms.TabPage()
        Me.lblTreatmentOptions = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.cboGroupSelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabCost = New System.Windows.Forms.TabPage()
        Me.lblYearlyIncome = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDailyIncome = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBedCost = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMaterialCost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpInjurySymptoms.SuspendLayout()
        Me.grpDiseaseSymptoms.SuspendLayout()
        Me.tabTreatment.SuspendLayout()
        Me.tabCost.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPatientInfo)
        Me.TabControl1.Controls.Add(Me.tabTreatment)
        Me.TabControl1.Controls.Add(Me.tabCost)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(484, 406)
        Me.TabControl1.TabIndex = 0
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.GroupBox1)
        Me.tabPatientInfo.Controls.Add(Me.grpInjurySymptoms)
        Me.tabPatientInfo.Controls.Add(Me.grpDiseaseSymptoms)
        Me.tabPatientInfo.Controls.Add(Me.btnAdmit)
        Me.tabPatientInfo.Controls.Add(Me.txtLastName)
        Me.tabPatientInfo.Controls.Add(Me.Label3)
        Me.tabPatientInfo.Controls.Add(Me.txtFirstName)
        Me.tabPatientInfo.Controls.Add(Me.Label2)
        Me.tabPatientInfo.Controls.Add(Me.VScrollBar1)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatientInfo.Size = New System.Drawing.Size(476, 380)
        Me.tabPatientInfo.TabIndex = 0
        Me.tabPatientInfo.Text = "Patient Information"
        Me.tabPatientInfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBoth)
        Me.GroupBox1.Controls.Add(Me.radInjury)
        Me.GroupBox1.Controls.Add(Me.radDisease)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 107)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Location = New System.Drawing.Point(13, 76)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(47, 17)
        Me.radBoth.TabIndex = 22
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "Both"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'radInjury
        '
        Me.radInjury.AutoSize = True
        Me.radInjury.Location = New System.Drawing.Point(13, 46)
        Me.radInjury.Name = "radInjury"
        Me.radInjury.Size = New System.Drawing.Size(50, 17)
        Me.radInjury.TabIndex = 21
        Me.radInjury.TabStop = True
        Me.radInjury.Text = "Injury"
        Me.radInjury.UseVisualStyleBackColor = True
        '
        'radDisease
        '
        Me.radDisease.AutoSize = True
        Me.radDisease.Location = New System.Drawing.Point(13, 17)
        Me.radDisease.Name = "radDisease"
        Me.radDisease.Size = New System.Drawing.Size(63, 17)
        Me.radDisease.TabIndex = 20
        Me.radDisease.TabStop = True
        Me.radDisease.Text = "Disease"
        Me.radDisease.UseVisualStyleBackColor = True
        '
        'grpInjurySymptoms
        '
        Me.grpInjurySymptoms.Controls.Add(Me.chkBleeding)
        Me.grpInjurySymptoms.Controls.Add(Me.chkAnorexic)
        Me.grpInjurySymptoms.Controls.Add(Me.chkBrokenBones)
        Me.grpInjurySymptoms.Controls.Add(Me.chkOrganDamage)
        Me.grpInjurySymptoms.Controls.Add(Me.chkForeignObject)
        Me.grpInjurySymptoms.Location = New System.Drawing.Point(182, 240)
        Me.grpInjurySymptoms.Name = "grpInjurySymptoms"
        Me.grpInjurySymptoms.Size = New System.Drawing.Size(128, 137)
        Me.grpInjurySymptoms.TabIndex = 19
        Me.grpInjurySymptoms.TabStop = False
        Me.grpInjurySymptoms.Text = "Injury Symptoms"
        Me.grpInjurySymptoms.Visible = False
        '
        'chkBleeding
        '
        Me.chkBleeding.AutoSize = True
        Me.chkBleeding.Location = New System.Drawing.Point(13, 66)
        Me.chkBleeding.Name = "chkBleeding"
        Me.chkBleeding.Size = New System.Drawing.Size(67, 17)
        Me.chkBleeding.TabIndex = 17
        Me.chkBleeding.Text = "Bleeding"
        Me.chkBleeding.UseVisualStyleBackColor = True
        '
        'chkAnorexic
        '
        Me.chkAnorexic.AutoSize = True
        Me.chkAnorexic.Location = New System.Drawing.Point(13, 42)
        Me.chkAnorexic.Name = "chkAnorexic"
        Me.chkAnorexic.Size = New System.Drawing.Size(67, 17)
        Me.chkAnorexic.TabIndex = 16
        Me.chkAnorexic.Text = "Anorexic"
        Me.chkAnorexic.UseVisualStyleBackColor = True
        '
        'chkBrokenBones
        '
        Me.chkBrokenBones.AutoSize = True
        Me.chkBrokenBones.Location = New System.Drawing.Point(13, 89)
        Me.chkBrokenBones.Name = "chkBrokenBones"
        Me.chkBrokenBones.Size = New System.Drawing.Size(99, 17)
        Me.chkBrokenBones.TabIndex = 15
        Me.chkBrokenBones.Text = "Broken Bone(s)"
        Me.chkBrokenBones.UseVisualStyleBackColor = True
        '
        'chkOrganDamage
        '
        Me.chkOrganDamage.AutoSize = True
        Me.chkOrganDamage.Location = New System.Drawing.Point(13, 112)
        Me.chkOrganDamage.Name = "chkOrganDamage"
        Me.chkOrganDamage.Size = New System.Drawing.Size(98, 17)
        Me.chkOrganDamage.TabIndex = 14
        Me.chkOrganDamage.Text = "Organ Damage"
        Me.chkOrganDamage.UseVisualStyleBackColor = True
        '
        'chkForeignObject
        '
        Me.chkForeignObject.AutoSize = True
        Me.chkForeignObject.Location = New System.Drawing.Point(13, 19)
        Me.chkForeignObject.Name = "chkForeignObject"
        Me.chkForeignObject.Size = New System.Drawing.Size(95, 17)
        Me.chkForeignObject.TabIndex = 13
        Me.chkForeignObject.Text = "Foreign Object"
        Me.chkForeignObject.UseVisualStyleBackColor = True
        '
        'grpDiseaseSymptoms
        '
        Me.grpDiseaseSymptoms.Controls.Add(Me.chkDiarrhea)
        Me.grpDiseaseSymptoms.Controls.Add(Me.chkFever)
        Me.grpDiseaseSymptoms.Controls.Add(Me.chkBlindness)
        Me.grpDiseaseSymptoms.Controls.Add(Me.chkHallucinating)
        Me.grpDiseaseSymptoms.Controls.Add(Me.chkVomiting)
        Me.grpDiseaseSymptoms.Location = New System.Drawing.Point(25, 240)
        Me.grpDiseaseSymptoms.Name = "grpDiseaseSymptoms"
        Me.grpDiseaseSymptoms.Size = New System.Drawing.Size(128, 137)
        Me.grpDiseaseSymptoms.TabIndex = 18
        Me.grpDiseaseSymptoms.TabStop = False
        Me.grpDiseaseSymptoms.Text = "Disease Symptoms"
        Me.grpDiseaseSymptoms.Visible = False
        '
        'chkDiarrhea
        '
        Me.chkDiarrhea.AutoSize = True
        Me.chkDiarrhea.Location = New System.Drawing.Point(13, 66)
        Me.chkDiarrhea.Name = "chkDiarrhea"
        Me.chkDiarrhea.Size = New System.Drawing.Size(66, 17)
        Me.chkDiarrhea.TabIndex = 17
        Me.chkDiarrhea.Text = "Diarrhea"
        Me.chkDiarrhea.UseVisualStyleBackColor = True
        '
        'chkFever
        '
        Me.chkFever.AutoSize = True
        Me.chkFever.Location = New System.Drawing.Point(13, 42)
        Me.chkFever.Name = "chkFever"
        Me.chkFever.Size = New System.Drawing.Size(53, 17)
        Me.chkFever.TabIndex = 16
        Me.chkFever.Text = "Fever"
        Me.chkFever.UseVisualStyleBackColor = True
        '
        'chkBlindness
        '
        Me.chkBlindness.AutoSize = True
        Me.chkBlindness.Location = New System.Drawing.Point(13, 89)
        Me.chkBlindness.Name = "chkBlindness"
        Me.chkBlindness.Size = New System.Drawing.Size(71, 17)
        Me.chkBlindness.TabIndex = 15
        Me.chkBlindness.Text = "Blindness"
        Me.chkBlindness.UseVisualStyleBackColor = True
        '
        'chkHallucinating
        '
        Me.chkHallucinating.AutoSize = True
        Me.chkHallucinating.Location = New System.Drawing.Point(13, 112)
        Me.chkHallucinating.Name = "chkHallucinating"
        Me.chkHallucinating.Size = New System.Drawing.Size(87, 17)
        Me.chkHallucinating.TabIndex = 14
        Me.chkHallucinating.Text = "Hallucinating"
        Me.chkHallucinating.UseVisualStyleBackColor = True
        '
        'chkVomiting
        '
        Me.chkVomiting.AutoSize = True
        Me.chkVomiting.Location = New System.Drawing.Point(13, 19)
        Me.chkVomiting.Name = "chkVomiting"
        Me.chkVomiting.Size = New System.Drawing.Size(66, 17)
        Me.chkVomiting.TabIndex = 13
        Me.chkVomiting.Text = "Vomiting"
        Me.chkVomiting.UseVisualStyleBackColor = True
        '
        'btnAdmit
        '
        Me.btnAdmit.Location = New System.Drawing.Point(327, 329)
        Me.btnAdmit.Name = "btnAdmit"
        Me.btnAdmit.Size = New System.Drawing.Size(100, 35)
        Me.btnAdmit.TabIndex = 12
        Me.btnAdmit.Text = "Admit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Patient"
        Me.btnAdmit.UseVisualStyleBackColor = True
        Me.btnAdmit.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(288, 25)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(139, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(85, 25)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(134, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(454, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 245)
        Me.VScrollBar1.TabIndex = 0
        '
        'tabTreatment
        '
        Me.tabTreatment.Controls.Add(Me.lblTreatmentOptions)
        Me.tabTreatment.Controls.Add(Me.lstNames)
        Me.tabTreatment.Controls.Add(Me.cboGroupSelection)
        Me.tabTreatment.Controls.Add(Me.Label1)
        Me.tabTreatment.Location = New System.Drawing.Point(4, 22)
        Me.tabTreatment.Name = "tabTreatment"
        Me.tabTreatment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTreatment.Size = New System.Drawing.Size(476, 380)
        Me.tabTreatment.TabIndex = 1
        Me.tabTreatment.Text = "Treatment"
        Me.tabTreatment.UseVisualStyleBackColor = True
        '
        'lblTreatmentOptions
        '
        Me.lblTreatmentOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTreatmentOptions.Location = New System.Drawing.Point(23, 117)
        Me.lblTreatmentOptions.Name = "lblTreatmentOptions"
        Me.lblTreatmentOptions.Size = New System.Drawing.Size(401, 86)
        Me.lblTreatmentOptions.TabIndex = 4
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(158, 34)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(266, 56)
        Me.lstNames.TabIndex = 3
        '
        'cboGroupSelection
        '
        Me.cboGroupSelection.FormattingEnabled = True
        Me.cboGroupSelection.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboGroupSelection.Location = New System.Drawing.Point(65, 34)
        Me.cboGroupSelection.Name = "cboGroupSelection"
        Me.cboGroupSelection.Size = New System.Drawing.Size(63, 21)
        Me.cboGroupSelection.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Group"
        '
        'tabCost
        '
        Me.tabCost.Controls.Add(Me.lblYearlyIncome)
        Me.tabCost.Controls.Add(Me.Label12)
        Me.tabCost.Controls.Add(Me.lblDailyIncome)
        Me.tabCost.Controls.Add(Me.Label10)
        Me.tabCost.Controls.Add(Me.lblBedCost)
        Me.tabCost.Controls.Add(Me.Label8)
        Me.tabCost.Controls.Add(Me.lblMaterialCost)
        Me.tabCost.Controls.Add(Me.Label6)
        Me.tabCost.Location = New System.Drawing.Point(4, 22)
        Me.tabCost.Name = "tabCost"
        Me.tabCost.Size = New System.Drawing.Size(476, 380)
        Me.tabCost.TabIndex = 2
        Me.tabCost.Text = "Cost"
        Me.tabCost.UseVisualStyleBackColor = True
        '
        'lblYearlyIncome
        '
        Me.lblYearlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYearlyIncome.Location = New System.Drawing.Point(193, 174)
        Me.lblYearlyIncome.Name = "lblYearlyIncome"
        Me.lblYearlyIncome.Size = New System.Drawing.Size(144, 23)
        Me.lblYearlyIncome.TabIndex = 7
        Me.lblYearlyIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(90, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Income of the Year"
        '
        'lblDailyIncome
        '
        Me.lblDailyIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyIncome.Location = New System.Drawing.Point(193, 135)
        Me.lblDailyIncome.Name = "lblDailyIncome"
        Me.lblDailyIncome.Size = New System.Drawing.Size(144, 23)
        Me.lblDailyIncome.TabIndex = 5
        Me.lblDailyIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Daily Income"
        '
        'lblBedCost
        '
        Me.lblBedCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBedCost.Location = New System.Drawing.Point(193, 94)
        Me.lblBedCost.Name = "lblBedCost"
        Me.lblBedCost.Size = New System.Drawing.Size(144, 23)
        Me.lblBedCost.TabIndex = 3
        Me.lblBedCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Bed Cost"
        '
        'lblMaterialCost
        '
        Me.lblMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaterialCost.Location = New System.Drawing.Point(193, 54)
        Me.lblMaterialCost.Name = "lblMaterialCost"
        Me.lblMaterialCost.Size = New System.Drawing.Size(144, 23)
        Me.lblMaterialCost.TabIndex = 1
        Me.lblMaterialCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Material Cost"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.tabPatientInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpInjurySymptoms.ResumeLayout(False)
        Me.grpInjurySymptoms.PerformLayout()
        Me.grpDiseaseSymptoms.ResumeLayout(False)
        Me.grpDiseaseSymptoms.PerformLayout()
        Me.tabTreatment.ResumeLayout(False)
        Me.tabTreatment.PerformLayout()
        Me.tabCost.ResumeLayout(False)
        Me.tabCost.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPatientInfo As System.Windows.Forms.TabPage
    Friend WithEvents tabTreatment As System.Windows.Forms.TabPage
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents cboGroupSelection As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnAdmit As System.Windows.Forms.Button
    Friend WithEvents lblTreatmentOptions As System.Windows.Forms.Label
    Friend WithEvents lstNames As System.Windows.Forms.ListBox
    Friend WithEvents tabCost As System.Windows.Forms.TabPage
    Friend WithEvents lblYearlyIncome As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblDailyIncome As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblBedCost As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMaterialCost As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpDiseaseSymptoms As System.Windows.Forms.GroupBox
    Friend WithEvents chkDiarrhea As System.Windows.Forms.CheckBox
    Friend WithEvents chkFever As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlindness As System.Windows.Forms.CheckBox
    Friend WithEvents chkHallucinating As System.Windows.Forms.CheckBox
    Friend WithEvents chkVomiting As System.Windows.Forms.CheckBox
    Friend WithEvents grpInjurySymptoms As System.Windows.Forms.GroupBox
    Friend WithEvents chkBleeding As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnorexic As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrokenBones As System.Windows.Forms.CheckBox
    Friend WithEvents chkOrganDamage As System.Windows.Forms.CheckBox
    Friend WithEvents chkForeignObject As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents radInjury As System.Windows.Forms.RadioButton
    Friend WithEvents radDisease As System.Windows.Forms.RadioButton

End Class
