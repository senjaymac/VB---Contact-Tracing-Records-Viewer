<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.pickerDate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpbxTitle = New System.Windows.Forms.GroupBox()
        Me.lblPleaseFillUp = New System.Windows.Forms.Label()
        Me.lblContactTraceForm = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtbxFirstName = New System.Windows.Forms.TextBox()
        Me.txtbxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtbxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.grpbxGender = New System.Windows.Forms.GroupBox()
        Me.txtbxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtbxTemperature = New System.Windows.Forms.TextBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblQuestion2 = New System.Windows.Forms.Label()
        Me.lblQuestion3 = New System.Windows.Forms.Label()
        Me.LblQuestion4 = New System.Windows.Forms.Label()
        Me.lblQuestion1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.grpbxQ1 = New System.Windows.Forms.GroupBox()
        Me.rbNo1 = New System.Windows.Forms.RadioButton()
        Me.rbYes1 = New System.Windows.Forms.RadioButton()
        Me.grpbxQ2 = New System.Windows.Forms.GroupBox()
        Me.rbNo2 = New System.Windows.Forms.RadioButton()
        Me.rbYes2 = New System.Windows.Forms.RadioButton()
        Me.grpbxQ3 = New System.Windows.Forms.GroupBox()
        Me.rbNo3 = New System.Windows.Forms.RadioButton()
        Me.rbYes3 = New System.Windows.Forms.RadioButton()
        Me.grpbxQ4 = New System.Windows.Forms.GroupBox()
        Me.rbNo4 = New System.Windows.Forms.RadioButton()
        Me.rbYes4 = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.btnScanQr = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxTitle.SuspendLayout()
        Me.grpbxGender.SuspendLayout()
        Me.grpbxQ1.SuspendLayout()
        Me.grpbxQ2.SuspendLayout()
        Me.grpbxQ3.SuspendLayout()
        Me.grpbxQ4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pickerDate
        '
        Me.pickerDate.Location = New System.Drawing.Point(119, 138)
        Me.pickerDate.Name = "pickerDate"
        Me.pickerDate.Size = New System.Drawing.Size(200, 20)
        Me.pickerDate.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(366, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpbxTitle
        '
        Me.grpbxTitle.BackColor = System.Drawing.Color.PaleGreen
        Me.grpbxTitle.Controls.Add(Me.lblPleaseFillUp)
        Me.grpbxTitle.Controls.Add(Me.lblContactTraceForm)
        Me.grpbxTitle.Controls.Add(Me.PictureBox1)
        Me.grpbxTitle.Location = New System.Drawing.Point(48, 32)
        Me.grpbxTitle.Name = "grpbxTitle"
        Me.grpbxTitle.Size = New System.Drawing.Size(483, 100)
        Me.grpbxTitle.TabIndex = 2
        Me.grpbxTitle.TabStop = False
        '
        'lblPleaseFillUp
        '
        Me.lblPleaseFillUp.AutoSize = True
        Me.lblPleaseFillUp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseFillUp.ForeColor = System.Drawing.Color.Green
        Me.lblPleaseFillUp.Location = New System.Drawing.Point(26, 64)
        Me.lblPleaseFillUp.Name = "lblPleaseFillUp"
        Me.lblPleaseFillUp.Size = New System.Drawing.Size(322, 21)
        Me.lblPleaseFillUp.TabIndex = 4
        Me.lblPleaseFillUp.Text = "* Please Fill up the informations correctly *"
        '
        'lblContactTraceForm
        '
        Me.lblContactTraceForm.AutoSize = True
        Me.lblContactTraceForm.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactTraceForm.Location = New System.Drawing.Point(29, 27)
        Me.lblContactTraceForm.Name = "lblContactTraceForm"
        Me.lblContactTraceForm.Size = New System.Drawing.Size(319, 37)
        Me.lblContactTraceForm.TabIndex = 3
        Me.lblContactTraceForm.Text = "Contact Tracing Form"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(53, 182)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'txtbxFirstName
        '
        Me.txtbxFirstName.Location = New System.Drawing.Point(119, 179)
        Me.txtbxFirstName.Name = "txtbxFirstName"
        Me.txtbxFirstName.Size = New System.Drawing.Size(170, 20)
        Me.txtbxFirstName.TabIndex = 4
        '
        'txtbxLastName
        '
        Me.txtbxLastName.Location = New System.Drawing.Point(361, 179)
        Me.txtbxLastName.Name = "txtbxLastName"
        Me.txtbxLastName.Size = New System.Drawing.Size(170, 20)
        Me.txtbxLastName.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(295, 182)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name:"
        '
        'txtbxAddress
        '
        Me.txtbxAddress.Location = New System.Drawing.Point(152, 210)
        Me.txtbxAddress.Name = "txtbxAddress"
        Me.txtbxAddress.Size = New System.Drawing.Size(275, 20)
        Me.txtbxAddress.TabIndex = 8
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(53, 213)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(95, 13)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Complete Address:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(449, 213)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 9
        Me.lblAge.Text = "Age:"
        '
        'txtbxAge
        '
        Me.txtbxAge.Location = New System.Drawing.Point(484, 210)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(47, 20)
        Me.txtbxAge.TabIndex = 10
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(6, 16)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Gender:"
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(54, 14)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 12
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(96, 14)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 13
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'grpbxGender
        '
        Me.grpbxGender.Controls.Add(Me.lblGender)
        Me.grpbxGender.Controls.Add(Me.rbFemale)
        Me.grpbxGender.Controls.Add(Me.rbMale)
        Me.grpbxGender.Location = New System.Drawing.Point(56, 236)
        Me.grpbxGender.Name = "grpbxGender"
        Me.grpbxGender.Size = New System.Drawing.Size(158, 42)
        Me.grpbxGender.TabIndex = 14
        Me.grpbxGender.TabStop = False
        '
        'txtbxPhoneNumber
        '
        Me.txtbxPhoneNumber.Location = New System.Drawing.Point(304, 249)
        Me.txtbxPhoneNumber.Name = "txtbxPhoneNumber"
        Me.txtbxPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtbxPhoneNumber.TabIndex = 16
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(217, 252)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 15
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtbxTemperature
        '
        Me.txtbxTemperature.Location = New System.Drawing.Point(484, 249)
        Me.txtbxTemperature.Name = "txtbxTemperature"
        Me.txtbxTemperature.Size = New System.Drawing.Size(47, 20)
        Me.txtbxTemperature.TabIndex = 18
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(410, 252)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(70, 13)
        Me.lblTemperature.TabIndex = 17
        Me.lblTemperature.Text = "Temperature:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Time:"
        '
        'timerClock
        '
        Me.timerClock.Enabled = True
        Me.timerClock.Interval = 1
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(107, 290)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(352, 16)
        Me.lblInstructions.TabIndex = 20
        Me.lblInstructions.Text = "Instructions: Check Yes or No depending on the questions applies."
        '
        'lblQuestion2
        '
        Me.lblQuestion2.AutoSize = True
        Me.lblQuestion2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion2.Location = New System.Drawing.Point(51, 367)
        Me.lblQuestion2.Name = "lblQuestion2"
        Me.lblQuestion2.Size = New System.Drawing.Size(221, 15)
        Me.lblQuestion2.TabIndex = 21
        Me.lblQuestion2.Text = "Are you experiencing any sickness recently? "
        '
        'lblQuestion3
        '
        Me.lblQuestion3.AutoSize = True
        Me.lblQuestion3.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion3.Location = New System.Drawing.Point(51, 415)
        Me.lblQuestion3.Name = "lblQuestion3"
        Me.lblQuestion3.Size = New System.Drawing.Size(294, 15)
        Me.lblQuestion3.TabIndex = 22
        Me.lblQuestion3.Text = "Have you traveled outside of the country in the past 14days?"
        '
        'LblQuestion4
        '
        Me.LblQuestion4.AutoSize = True
        Me.LblQuestion4.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion4.Location = New System.Drawing.Point(51, 463)
        Me.LblQuestion4.Name = "LblQuestion4"
        Me.LblQuestion4.Size = New System.Drawing.Size(302, 15)
        Me.LblQuestion4.TabIndex = 23
        Me.LblQuestion4.Text = "Do you have a close contact with a probable covid 19 person?"
        '
        'lblQuestion1
        '
        Me.lblQuestion1.AutoSize = True
        Me.lblQuestion1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1.Location = New System.Drawing.Point(51, 324)
        Me.lblQuestion1.Name = "lblQuestion1"
        Me.lblQuestion1.Size = New System.Drawing.Size(191, 15)
        Me.lblQuestion1.TabIndex = 24
        Me.lblQuestion1.Text = "Have you've been tested for COVID-19?"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(411, 503)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 30)
        Me.btnSubmit.TabIndex = 33
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(375, 144)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 13)
        Me.lblTimer.TabIndex = 34
        '
        'grpbxQ1
        '
        Me.grpbxQ1.Controls.Add(Me.rbNo1)
        Me.grpbxQ1.Controls.Add(Me.rbYes1)
        Me.grpbxQ1.Location = New System.Drawing.Point(361, 303)
        Me.grpbxQ1.Name = "grpbxQ1"
        Me.grpbxQ1.Size = New System.Drawing.Size(119, 42)
        Me.grpbxQ1.TabIndex = 35
        Me.grpbxQ1.TabStop = False
        '
        'rbNo1
        '
        Me.rbNo1.AutoSize = True
        Me.rbNo1.Location = New System.Drawing.Point(72, 19)
        Me.rbNo1.Name = "rbNo1"
        Me.rbNo1.Size = New System.Drawing.Size(39, 17)
        Me.rbNo1.TabIndex = 13
        Me.rbNo1.Text = "No"
        Me.rbNo1.UseVisualStyleBackColor = True
        '
        'rbYes1
        '
        Me.rbYes1.AutoSize = True
        Me.rbYes1.Location = New System.Drawing.Point(18, 19)
        Me.rbYes1.Name = "rbYes1"
        Me.rbYes1.Size = New System.Drawing.Size(43, 17)
        Me.rbYes1.TabIndex = 12
        Me.rbYes1.Text = "Yes"
        Me.rbYes1.UseVisualStyleBackColor = True
        '
        'grpbxQ2
        '
        Me.grpbxQ2.Controls.Add(Me.rbNo2)
        Me.grpbxQ2.Controls.Add(Me.rbYes2)
        Me.grpbxQ2.Location = New System.Drawing.Point(361, 351)
        Me.grpbxQ2.Name = "grpbxQ2"
        Me.grpbxQ2.Size = New System.Drawing.Size(119, 42)
        Me.grpbxQ2.TabIndex = 15
        Me.grpbxQ2.TabStop = False
        '
        'rbNo2
        '
        Me.rbNo2.AutoSize = True
        Me.rbNo2.Location = New System.Drawing.Point(72, 14)
        Me.rbNo2.Name = "rbNo2"
        Me.rbNo2.Size = New System.Drawing.Size(39, 17)
        Me.rbNo2.TabIndex = 13
        Me.rbNo2.Text = "No"
        Me.rbNo2.UseVisualStyleBackColor = True
        '
        'rbYes2
        '
        Me.rbYes2.AutoSize = True
        Me.rbYes2.Location = New System.Drawing.Point(18, 14)
        Me.rbYes2.Name = "rbYes2"
        Me.rbYes2.Size = New System.Drawing.Size(43, 17)
        Me.rbYes2.TabIndex = 12
        Me.rbYes2.Text = "Yes"
        Me.rbYes2.UseVisualStyleBackColor = True
        '
        'grpbxQ3
        '
        Me.grpbxQ3.Controls.Add(Me.rbNo3)
        Me.grpbxQ3.Controls.Add(Me.rbYes3)
        Me.grpbxQ3.Location = New System.Drawing.Point(361, 399)
        Me.grpbxQ3.Name = "grpbxQ3"
        Me.grpbxQ3.Size = New System.Drawing.Size(119, 42)
        Me.grpbxQ3.TabIndex = 36
        Me.grpbxQ3.TabStop = False
        '
        'rbNo3
        '
        Me.rbNo3.AutoSize = True
        Me.rbNo3.Location = New System.Drawing.Point(72, 14)
        Me.rbNo3.Name = "rbNo3"
        Me.rbNo3.Size = New System.Drawing.Size(39, 17)
        Me.rbNo3.TabIndex = 13
        Me.rbNo3.TabStop = True
        Me.rbNo3.Text = "No"
        Me.rbNo3.UseVisualStyleBackColor = True
        '
        'rbYes3
        '
        Me.rbYes3.AutoSize = True
        Me.rbYes3.Location = New System.Drawing.Point(18, 14)
        Me.rbYes3.Name = "rbYes3"
        Me.rbYes3.Size = New System.Drawing.Size(43, 17)
        Me.rbYes3.TabIndex = 12
        Me.rbYes3.TabStop = True
        Me.rbYes3.Text = "Yes"
        Me.rbYes3.UseVisualStyleBackColor = True
        '
        'grpbxQ4
        '
        Me.grpbxQ4.Controls.Add(Me.rbNo4)
        Me.grpbxQ4.Controls.Add(Me.rbYes4)
        Me.grpbxQ4.Location = New System.Drawing.Point(361, 447)
        Me.grpbxQ4.Name = "grpbxQ4"
        Me.grpbxQ4.Size = New System.Drawing.Size(119, 42)
        Me.grpbxQ4.TabIndex = 37
        Me.grpbxQ4.TabStop = False
        '
        'rbNo4
        '
        Me.rbNo4.AutoSize = True
        Me.rbNo4.Location = New System.Drawing.Point(72, 14)
        Me.rbNo4.Name = "rbNo4"
        Me.rbNo4.Size = New System.Drawing.Size(39, 17)
        Me.rbNo4.TabIndex = 13
        Me.rbNo4.TabStop = True
        Me.rbNo4.Text = "No"
        Me.rbNo4.UseVisualStyleBackColor = True
        '
        'rbYes4
        '
        Me.rbYes4.AutoSize = True
        Me.rbYes4.Location = New System.Drawing.Point(18, 14)
        Me.rbYes4.Name = "rbYes4"
        Me.rbYes4.Size = New System.Drawing.Size(43, 17)
        Me.rbYes4.TabIndex = 12
        Me.rbYes4.TabStop = True
        Me.rbYes4.Text = "Yes"
        Me.rbYes4.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(285, 503)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Location = New System.Drawing.Point(159, 503)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(120, 30)
        Me.btnViewRecords.TabIndex = 39
        Me.btnViewRecords.Text = "View Records"
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'btnScanQr
        '
        Me.btnScanQr.Location = New System.Drawing.Point(33, 503)
        Me.btnScanQr.Name = "btnScanQr"
        Me.btnScanQr.Size = New System.Drawing.Size(120, 30)
        Me.btnScanQr.TabIndex = 40
        Me.btnScanQr.Text = "Scan Qr Code"
        Me.btnScanQr.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(565, 567)
        Me.Controls.Add(Me.btnScanQr)
        Me.Controls.Add(Me.btnViewRecords)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpbxQ4)
        Me.Controls.Add(Me.grpbxQ3)
        Me.Controls.Add(Me.grpbxQ2)
        Me.Controls.Add(Me.grpbxQ1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQuestion1)
        Me.Controls.Add(Me.LblQuestion4)
        Me.Controls.Add(Me.lblQuestion3)
        Me.Controls.Add(Me.lblQuestion2)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxTemperature)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.txtbxPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.grpbxGender)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtbxAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtbxLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtbxFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.grpbxTitle)
        Me.Controls.Add(Me.pickerDate)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(581, 606)
        Me.MinimumSize = New System.Drawing.Size(581, 606)
        Me.Name = "formMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB - Contact Tracing App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxTitle.ResumeLayout(False)
        Me.grpbxTitle.PerformLayout()
        Me.grpbxGender.ResumeLayout(False)
        Me.grpbxGender.PerformLayout()
        Me.grpbxQ1.ResumeLayout(False)
        Me.grpbxQ1.PerformLayout()
        Me.grpbxQ2.ResumeLayout(False)
        Me.grpbxQ2.PerformLayout()
        Me.grpbxQ3.ResumeLayout(False)
        Me.grpbxQ3.PerformLayout()
        Me.grpbxQ4.ResumeLayout(False)
        Me.grpbxQ4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pickerDate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpbxTitle As GroupBox
    Friend WithEvents lblPleaseFillUp As Label
    Friend WithEvents lblContactTraceForm As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtbxFirstName As TextBox
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtbxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents grpbxGender As GroupBox
    Friend WithEvents txtbxPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtbxTemperature As TextBox
    Friend WithEvents lblTemperature As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents timerClock As Timer
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblQuestion2 As Label
    Friend WithEvents lblQuestion3 As Label
    Friend WithEvents LblQuestion4 As Label
    Friend WithEvents lblQuestion1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents grpbxQ1 As GroupBox
    Friend WithEvents rbNo1 As RadioButton
    Friend WithEvents rbYes1 As RadioButton
    Friend WithEvents grpbxQ2 As GroupBox
    Friend WithEvents rbNo2 As RadioButton
    Friend WithEvents rbYes2 As RadioButton
    Friend WithEvents grpbxQ3 As GroupBox
    Friend WithEvents rbNo3 As RadioButton
    Friend WithEvents rbYes3 As RadioButton
    Friend WithEvents grpbxQ4 As GroupBox
    Friend WithEvents rbNo4 As RadioButton
    Friend WithEvents rbYes4 As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents btnScanQr As Button
End Class
