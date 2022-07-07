Imports System.IO

Public Class formRecordViewer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        FileSelector.ShowDialog()
    End Sub

    Private Sub FileSelector_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FileSelector.FileOk
        If FileSelector.FileName <> "" Then
            Dim info As New StreamReader(FileSelector.FileName)

            Do Until info.EndOfStream
                txtbxRecordViewerTextFile.Text = txtbxRecordViewerTextFile.Text & info.ReadLine & vbCrLf
            Loop
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbxRecordViewerTextFile.Clear()
    End Sub
End Class