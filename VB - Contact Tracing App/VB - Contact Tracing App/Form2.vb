Public Class formRecordViewer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Me.Hide()
    End Sub
End Class