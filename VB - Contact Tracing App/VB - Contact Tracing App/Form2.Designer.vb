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
        Me.txtbxRecordViewerTextFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtbxRecordViewerTextFile
        '
        Me.txtbxRecordViewerTextFile.Location = New System.Drawing.Point(106, 52)
        Me.txtbxRecordViewerTextFile.Multiline = True
        Me.txtbxRecordViewerTextFile.Name = "txtbxRecordViewerTextFile"
        Me.txtbxRecordViewerTextFile.Size = New System.Drawing.Size(100, 20)
        Me.txtbxRecordViewerTextFile.TabIndex = 0
        '
        'formRecordViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbxRecordViewerTextFile)
        Me.Name = "formRecordViewer"
        Me.ShowIcon = False
        Me.Text = "Records Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxRecordViewerTextFile As TextBox
End Class
