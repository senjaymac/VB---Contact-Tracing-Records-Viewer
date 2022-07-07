<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRecordViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formRecordViewer))
        Me.txtbxRecordViewerTextFile = New System.Windows.Forms.TextBox()
        Me.grpbxTitle = New System.Windows.Forms.GroupBox()
        Me.lblPleaseFillUp = New System.Windows.Forms.Label()
        Me.lblContactTraceForm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.FileSelector = New System.Windows.Forms.OpenFileDialog()
        Me.grpbxTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbxRecordViewerTextFile
        '
        Me.txtbxRecordViewerTextFile.Location = New System.Drawing.Point(12, 143)
        Me.txtbxRecordViewerTextFile.Multiline = True
        Me.txtbxRecordViewerTextFile.Name = "txtbxRecordViewerTextFile"
        Me.txtbxRecordViewerTextFile.ReadOnly = True
        Me.txtbxRecordViewerTextFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxRecordViewerTextFile.Size = New System.Drawing.Size(541, 356)
        Me.txtbxRecordViewerTextFile.TabIndex = 0
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
        Me.grpbxTitle.TabIndex = 3
        Me.grpbxTitle.TabStop = False
        '
        'lblPleaseFillUp
        '
        Me.lblPleaseFillUp.AutoSize = True
        Me.lblPleaseFillUp.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleaseFillUp.ForeColor = System.Drawing.Color.Green
        Me.lblPleaseFillUp.Location = New System.Drawing.Point(129, 63)
        Me.lblPleaseFillUp.Name = "lblPleaseFillUp"
        Me.lblPleaseFillUp.Size = New System.Drawing.Size(123, 21)
        Me.lblPleaseFillUp.TabIndex = 4
        Me.lblPleaseFillUp.Text = "Records Viewer"
        '
        'lblContactTraceForm
        '
        Me.lblContactTraceForm.AutoSize = True
        Me.lblContactTraceForm.Font = New System.Drawing.Font("Franklin Gothic Demi", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactTraceForm.Location = New System.Drawing.Point(29, 16)
        Me.lblContactTraceForm.Name = "lblContactTraceForm"
        Me.lblContactTraceForm.Size = New System.Drawing.Size(319, 37)
        Me.lblContactTraceForm.TabIndex = 3
        Me.lblContactTraceForm.Text = "Contact Tracing Form"
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
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(433, 505)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(120, 30)
        Me.btnSelect.TabIndex = 34
        Me.btnSelect.Text = "Select File"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 505)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 30)
        Me.btnBack.TabIndex = 35
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(307, 505)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FileSelector
        '
        Me.FileSelector.FileName = "ofdSelector"
        Me.FileSelector.Filter = "Text Files|*.txt"
        '
        'formRecordViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(565, 567)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.grpbxTitle)
        Me.Controls.Add(Me.txtbxRecordViewerTextFile)
        Me.Name = "formRecordViewer"
        Me.ShowIcon = False
        Me.Text = "Records Viewer"
        Me.grpbxTitle.ResumeLayout(False)
        Me.grpbxTitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxRecordViewerTextFile As TextBox
    Friend WithEvents grpbxTitle As GroupBox
    Friend WithEvents lblPleaseFillUp As Label
    Friend WithEvents lblContactTraceForm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents FileSelector As OpenFileDialog
End Class
