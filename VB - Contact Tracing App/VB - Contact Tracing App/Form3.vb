Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Public Class formQrCodeScanner
    Dim img As Bitmap
    Dim Scan As VideoCaptureDevice

    Private Sub QRreader(sender As Object, eventArgs As NewFrameEventArgs)
        img = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbxQrScanner.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnScanQr_Click(sender As Object, e As EventArgs) Handles btnScanQr.Click
        Dim qrScan As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If qrScan.ShowDialog() = DialogResult.OK Then
            Scan = qrScan.VideoDevice
            AddHandler Scan.NewFrame, New NewFrameEventHandler(AddressOf QRreader)
            Scan.Start()
            timerQrScan.Start()
        End If
    End Sub
End Class