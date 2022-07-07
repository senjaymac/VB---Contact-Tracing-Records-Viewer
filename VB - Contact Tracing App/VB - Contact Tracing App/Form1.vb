Public Class formMain
    Dim Gender, Q1, Q2, Q3, Q4 As String
    Public Property Qr As Boolean
    Public Property saveData As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim form As System.IO.StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Element 54\Documents\Repos\VB - Contact Tracing\VB - Contact Tracing App\Contact TracingForm.Txt", True)
        form.WriteLine("")
        form.WriteLine("Date: " + pickerDate.Text)
        form.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"))
        form.WriteLine("")
        form.WriteLine("Personal Informations")
        form.WriteLine("First Name: " + txtbxFirstName.Text)
        form.WriteLine("Last Name: " + txtbxLastName.Text)
        form.WriteLine("Complete Address: " + txtbxAddress.Text)
        form.WriteLine("Age: " + txtbxAge.Text)
        form.WriteLine("Phone Number: " + txtbxPhoneNumber.Text)
        form.WriteLine("Temperature: " + txtbxTemperature.Text)
        form.WriteLine("Gender: " + Gender)
        form.WriteLine("")
        form.WriteLine("Health Questions")
        form.WriteLine("Have you've been tested for COVID-19? " + Q1)
        form.WriteLine("Are you experiencing any sickness recently? " + Q2)
        form.WriteLine("Have you traveled outside of the country in the past 14days? " + Q3)
        form.WriteLine("Do you have a close contact with a probable covid 19 person? " + Q4)
        form.WriteLine("__________________________________________________________________________")
        form.WriteLine("")
        form.WriteLine("")
        MessageBox.Show("Succesfully Submitted, Thank You!")
        form.Close()


    End Sub


    Private Sub time(sender As Object, e As EventArgs) Handles timerClock.Tick

        lblTimer.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub txtbxNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPhoneNumber.KeyPress, txtbxAge.KeyPress, MyBase.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Input Numbers Only on this Field!")

        End If
    End Sub

    Private Sub txtbxAge_keypress(sender As Object, e As KeyPressEventArgs) Handles txtbxAge.KeyPress
        If txtbxAge.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("This field is up to 2 digits only")
            End If
        End If
    End Sub

    Private Sub rbYes4_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes4.CheckedChanged
        Q4 = "Yes"
    End Sub

    Private Sub rbYes3_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes3.CheckedChanged
        Q3 = "Yes"
    End Sub

    Private Sub rbYes2_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes2.CheckedChanged
        Q2 = "Yes"
    End Sub

    Private Sub rbYes1_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes1.CheckedChanged
        Q1 = "Yes"
    End Sub

    Private Sub rbNo1_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo1.CheckedChanged
        Q1 = "No"
    End Sub

    Private Sub rbNo3_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo3.CheckedChanged
        Q3 = "No"
    End Sub

    Private Sub rbNo2_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo2.CheckedChanged
        Q2 = "No"
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        formRecordViewer.Show()
        Me.Hide()
    End Sub

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Qr Then
            Dim Save As String()
            Save = saveData.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            txtbxFirstName.Text = Save(0)
            txtbxLastName.Text = Save(1)
            txtbxAddress.Text = Save(2)
            txtbxPhoneNumber.Text = Save(3)

        End If
    End Sub

    Private Sub btnScanQr_Click(sender As Object, e As EventArgs) Handles btnScanQr.Click
        formQrCodeScanner.Show()
        Me.Hide()
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbxFirstName.Clear()
        txtbxLastName.Clear()
        txtbxAddress.Clear()
        txtbxAge.Clear()
        txtbxPhoneNumber.Clear()
        txtbxTemperature.Clear()

        rbMale.Checked = False
        rbFemale.Checked = False

        rbYes1.Checked = False
        rbYes2.Checked = False
        rbYes3.Checked = False
        rbYes4.Checked = False

        rbNo1.Checked = False
        rbNo2.Checked = False
        rbNo3.Checked = False
        rbNo4.Checked = False

    End Sub

    Private Sub rbNo4_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo4.CheckedChanged
        Q4 = "No"
    End Sub

    Private Sub txtbxTemperature_keypress(sender As Object, e As KeyPressEventArgs) Handles txtbxTemperature.KeyPress
        If txtbxTemperature.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("This field is up to 2 digits only")
            End If
        End If
    End Sub


End Class
