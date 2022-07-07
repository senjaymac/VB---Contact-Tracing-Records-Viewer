Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Public Class formQrCodeScanner
    Dim img As Bitmap
    Dim Scan As VideoCaptureDevice

    Private Sub readQrCode(sender As Object, eventArgs As NewFrameEventArgs)
        img = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbxQrScanner.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnScanQr_Click(sender As Object, e As EventArgs) Handles btnScanQr.Click
        Dim qrScan As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If qrScan.ShowDialog() = DialogResult.OK Then
            Scan = qrScan.VideoDevice
            AddHandler Scan.NewFrame, New NewFrameEventHandler(AddressOf readQrCode)
            Scan.Start()
            timerQrScan.Start()
        End If
    End Sub

    Private Sub timerQrScan_Tick(sender As Object, e As EventArgs) Handles timerQrScan.Tick
        If pbxQrScanner.Image IsNot Nothing Then
            Dim QRscanner As BarcodeReader = New BarcodeReader
            Dim qrInputs As Result = QRscanner.Decode(DirectCast(pbxQrScanner.Image, Bitmap))
            If qrInputs IsNot Nothing Then
                Dim DataMainf As New formMain
                DataMainf.saveData = qrInputs.ToString()
                DataMainf.QR = True
                DataMainf.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formMain.Show()
        Me.Hide()
    End Sub



End Class