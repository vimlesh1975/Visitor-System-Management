Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class Form1
    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim Cap As String = "Capture"
    Dim osd2 As New SaveFileDialog
    Dim cameraStarted = False
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If cameraStarted = True Then
                CAMARA.Stop()
            End If
            ' PictureBox2.Image = Nothing
        Catch ex As Exception
            Me.Dispose()
            'PictureBox2.Image = Nothing
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdno.Visible = False
        cmdok.Visible = False
        dgv1.Rows.Add(1)
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        ' CAMARAS.VideoDevice.Source = "USB2.0 PC CAMERA"
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice

            'CAMARA.Source = "USB2.0 PC CAMERA"
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()
            cameraStarted = True
        Else
            Me.Close()
        End If
        opeFile()
        dgv1.Rows(1).Selected = True
    End Sub
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)

        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbcaptureimage.Image = BMP ' DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub
    Private Sub pbcapture_Click(sender As Object, e As EventArgs) Handles pbcapture.Click
        If Cap = "Capture" Then
            cmdno.Visible = True
            cmdok.Visible = True
            pbcapture.Visible = False
            CAMARA.Stop()
            Cap = "Start"
        ElseIf Cap = "Start" Then
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdno.Visible = False
            cmdok.Visible = False
            Cap = "Capture"
        End If
    End Sub

    Private Sub cmdno_Click(sender As Object, e As EventArgs) Handles cmdno.Click
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        CAMARA.Start()
        cmdno.Visible = False
        cmdok.Visible = False
        pbcapture.Visible = True
        Cap = "Capture"
    End Sub

    Private Sub cmdok_Click(sender As Object, e As EventArgs) Handles cmdok.Click
        Dim SD As New SaveFileDialog
        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = "Visual Capture " & Date.Now.ToString("MM/dd/yy/HH/mm/ss")
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        'If SD.ShowDialog() = DialogResult.OK Then
        '    Try
        '        pbcaptureimage.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
        '        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        '        CAMARA.Start()
        '        cmdno.Visible = False
        '        cmdok.Visible = False
        '        pbcapture.Visible = True
        '        Cap = "Capture"
        '        dgv1.CurrentRow.Cells(3).Value = pbcaptureimage.Image
        '        savefile()


        '    Catch ex As Exception

        '    End Try
        'Else
        '    Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        '    CAMARA.Start()
        '    cmdno.Visible = False
        '    cmdok.Visible = False
        '    pbcapture.Visible = True
        '    Cap = "Capture"
        'End If 
        dgv1.CurrentRow.Cells("VisitorImage").Value = pbcaptureimage.Image
        dgv1.CurrentRow.Cells("VisitorName").Value = "Vimlesh Kumar" & dgv1.CurrentRow.Index
        dgv1.CurrentRow.Cells("Age").Value = 30 + dgv1.CurrentRow.Index * 2
        dgv1.CurrentRow.Cells("Address").Value = "Pratapgad 505, kamothe, Navi Mumbai, mh 410209"
        dgv1.CurrentRow.Cells("VisitordateAndTime").Value = Date.Now


        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        CAMARA.Start()
        cmdno.Visible = False
        cmdok.Visible = False
        pbcapture.Visible = True
        Cap = "Capture"
        If dgv1.CurrentRow.Index = 0 Then
            dgv1.Rows.Add(1)
            GoTo 50
        End If
        If dgv1.Rows(dgv1.RowCount - 1).Cells(3).Value IsNot Nothing Then
            dgv1.Rows.Add(1)
        End If
50:
        Dim aa = dgv1.RowCount - 1
        'dgv1.CurrentCell = dgv1(0, aa - 1)
        For i = 0 To dgv1.RowCount - 1
            If dgv1.Rows(i).Cells(3).Value Is Nothing Then
                dgv1.CurrentCell = dgv1(0, i)
                Exit For
            End If
        Next
        'savefile()

    End Sub

    Sub savefile()
        'On Error Resume Next
        osd2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        osd2.InitialDirectory = "d:\_camera\"

        osd2.FileName = Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((Date.Today).DayOfWeek) & "_" & (Date.Today).Day & "_" & (Date.Today).Month & "_" & (Date.Today).Year & "_" & (TimeOfDay.Hour + 1) & "HRS"
        'If (osd2.ShowDialog() = Windows.Forms.DialogResult.OK) Then
        'Using sw As StreamWriter = New StreamWriter(osd2.FileName)
        Using sw As StreamWriter = New StreamWriter("aa.txt")

            If dgv1.Rows.Count = 0 Then
                sw.Write("")
            Else
                'Loop through and add list to the file.
                Dim f As Integer = 0
                Do Until f = dgv1.Rows.Count - 1
                    'If dgv1.Rows(f).Cells("x").Value = False Then dgv1.Rows(f).Cells("x").Value = "0"
                    'If dgv1.Rows(f).Cells("Column11").Value = False Then dgv1.Rows(f).Cells("Column11").Value = "0"
                    'If dgv1.Rows(f).Cells("Conversion").Value = False Then dgv1.Rows(f).Cells("Conversion").Value = "0"
                    'If dgv1.Rows(f).Cells("BackIn").Value = False Then dgv1.Rows(f).Cells("BackIn").Value = "0"

                    sw.WriteLine(dgv1.Rows(f).Cells("VisitorName").Value & Chr(2) & dgv1.Rows(f).Cells("Age").Value & Chr(2) & dgv1.Rows(f).Cells("Address").Value & Chr(2) & ImageToBase64(dgv1.Rows(f).Cells("VisitorImage").Value, Imaging.ImageFormat.Png) & Chr(2) & dgv1.Rows(f).Cells("VisitordateAndTime").Value)
                    f = f + 1
                Loop
            End If
            sw.Close()
        End Using
        'Me.lblplalistname.Text = "playlist=  " & osd2.FileName
        'SaveToolStripMenuItem.Enabled = True
        'End If
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.ColumnIndex = 0 Then
            Form2.Show()
            Form2.pbcaptureimage.Image = dgv1.CurrentRow.Cells("VisitorImage").Value
        End If
    End Sub

    Private Sub dgv1_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgv1.DefaultValuesNeeded
        e.Row.Cells(0).Value = "Vimlesh Kumar"
    End Sub

    Public Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray() ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Public Function Base64ToImage(ByVal base64String As String) As Image
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
        Return ConvertedBase64Image
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savefile()
    End Sub

    Private Sub cmdopen_Click(sender As Object, e As EventArgs) Handles cmdopen.Click
        opeFile()
    End Sub

    Sub opeFile()
        Using sr As StreamReader = New StreamReader("aa.txt")
            Dim g As Integer = 0
            Dim li As String
            Do Until sr.EndOfStream = True
                li = sr.ReadLine()
                dgv1.Rows.Insert(dgv1.CurrentRow.Index, 1)
                Dim xyz As Array = Split(li, Chr(2))
                dgv1.Rows(g).Cells("VisitorName").Value = xyz(0)
                dgv1.Rows(g).Cells("Age").Value = xyz(1)
                dgv1.Rows(g).Cells("Address").Value = xyz(2)
                dgv1.Rows(g).Cells("VisitorImage").Value = Base64ToImage(xyz(3))
                dgv1.Rows(g).Cells("VisitordateAndTime").Value = xyz(4)
                g = g + 1
            Loop
            sr.Close()
        End Using
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim image As Image = dgv1.CurrentRow.Cells("VisitorImage").Value
        Dim scale As Single = 0.25
        Dim newWidth As Single = image.Width * scale
        Dim newHeight As Single = image.Height * scale
        Dim destinationRect As New RectangleF(100, 100, newWidth, newHeight)
        e.Graphics.DrawImage(image, destinationRect)

        Dim printFont As New Font("Arial", 12)
        Dim printBrush As New SolidBrush(Color.Black)
        Dim textToPrint As String =
         "Name:" + dgv1.CurrentRow.Cells("VisitorName").Value + vbNewLine _
       + "Age: " + dgv1.CurrentRow.Cells("Age").Value + vbNewLine _
       + "Address: " + dgv1.CurrentRow.Cells("Address").Value + vbNewLine _
       + "Time: " + dgv1.CurrentRow.Cells("VisitordateAndTime").Value + vbNewLine

        e.Graphics.DrawString(textToPrint, printFont, printBrush, 270, 100)

    End Sub

    Private Sub cmdPrintSelected_Click(sender As Object, e As EventArgs) Handles cmdPrintSelected.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub cmdPrintPreview_Click(sender As Object, e As EventArgs) Handles cmdPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1

        ' Show the print preview dialog
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
