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
        Me.SuspendLayout()
        '
        'formQrCodeScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(565, 567)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximumSize = New System.Drawing.Size(581, 606)
        Me.MinimumSize = New System.Drawing.Size(581, 606)
        Me.Name = "formQrCodeScanner"
        Me.ShowIcon = False
        Me.Text = "Qr Code Scanner"
        Me.ResumeLayout(False)

    End Sub
End Class
