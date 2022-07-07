<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formQrCodeScanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formQrCodeScanner))
        Me.pbxQrScanner = New System.Windows.Forms.PictureBox()
        Me.grpbxTitle = New System.Windows.Forms.GroupBox()
        Me.lblPleaseFillUp = New System.Windows.Forms.Label()
        Me.lblContactTraceForm = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnScanQr = New System.Windows.Forms.Button()
        Me.timerQrScan = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxQrScanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxTitle.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxQrScanner
        '
        Me.pbxQrScanner.Location = New System.Drawing.Point(48, 138)
        Me.pbxQrScanner.Name = "pbxQrScanner"
        Me.pbxQrScanner.Size = New System.Drawing.Size(483, 254)
        Me.pbxQrScanner.TabIndex = 0
        Me.pbxQrScanner.TabStop = False
        '
        'grpbxTitle
        '
        Me.grpbxTitle.BackColor = System.Drawing.Color.PaleGreen
        Me.grpbxTitle.Controls.Add(Me.lblPleaseFillUp)
        Me.grpbxTitle.Controls.Add(Me.lblContactTraceForm)
        Me.grpbxTitle.Controls.Add(Me.PictureBox2)
        Me.grpbxTitle.Location = New System.Drawing.Point(48, 32)
        Me.grpbxTitle.Name = "grpbxTitle"
        Me.grpbxTitle.Size = New System.Drawing.Size(483, 100)
        Me.grpbxTitle.TabIndex = 3
        Me.grpbxTitle.TabStop = False
        '
        'lblPleaseFillUp
        '
        Me.lblPleaseFillUp.AutoSize = True
        Me.lblPleaseFillUp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseFillUp.ForeColor = System.Drawing.Color.Green
        Me.lblPleaseFillUp.Location = New System.Drawing.Point(129, 64)
        Me.lblPleaseFillUp.Name = "lblPleaseFillUp"
        Me.lblPleaseFillUp.Size = New System.Drawing.Size(130, 21)
        Me.lblPleaseFillUp.TabIndex = 4
        Me.lblPleaseFillUp.Text = "Qr Code Scanner"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(366, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(117, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnScanQr
        '
        Me.btnScanQr.Location = New System.Drawing.Point(411, 398)
        Me.btnScanQr.Name = "btnScanQr"
        Me.btnScanQr.Size = New System.Drawing.Size(120, 30)
        Me.btnScanQr.TabIndex = 34
        Me.btnScanQr.Text = "Scan Qr"
        Me.btnScanQr.UseVisualStyleBackColor = True
        '
        'timerQrScan
        '
        Me.timerQrScan.Interval = 1000
        '
        'formQrCodeScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(565, 567)
        Me.Controls.Add(Me.btnScanQr)
        Me.Controls.Add(Me.grpbxTitle)
        Me.Controls.Add(Me.pbxQrScanner)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximumSize = New System.Drawing.Size(581, 606)
        Me.MinimumSize = New System.Drawing.Size(581, 606)
        Me.Name = "formQrCodeScanner"
        Me.ShowIcon = False
        Me.Text = "Qr Code Scanner"
        CType(Me.pbxQrScanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxTitle.ResumeLayout(False)
        Me.grpbxTitle.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxQrScanner As PictureBox
    Friend WithEvents grpbxTitle As GroupBox
    Friend WithEvents lblPleaseFillUp As Label
    Friend WithEvents lblContactTraceForm As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnScanQr As Button
    Friend WithEvents timerQrScan As Timer
End Class
