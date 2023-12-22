<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.cmdno = New System.Windows.Forms.Button()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.pbcapture = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.pbcaptureimage = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdopen = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmdPrintSelected = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.cmdPrintPreview = New System.Windows.Forms.Button()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VisitorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitordateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficerToMeet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NatureOfWork = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuingOfficer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reference = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TotalPerson = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SN, Me.VisitorImage, Me.VisitorName, Me.Age, Me.Address, Me.MobileNumber, Me.VisitordateAndTime, Me.OutTime, Me.OfficerToMeet, Me.NatureOfWork, Me.IssuingOfficer, Me.Reference, Me.TotalPerson})
        Me.dgv1.Location = New System.Drawing.Point(3, 419)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 50
        Me.dgv1.Size = New System.Drawing.Size(1859, 363)
        Me.dgv1.TabIndex = 4
        '
        'cmdno
        '
        Me.cmdno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdno.Image = Global.WebCam.My.Resources.Resources.Actions_edit_delete_icon
        Me.cmdno.Location = New System.Drawing.Point(717, 345)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(32, 24)
        Me.cmdno.TabIndex = 3
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.Image = Global.WebCam.My.Resources.Resources.Ok_icon__1_1
        Me.cmdok.Location = New System.Drawing.Point(679, 345)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(32, 24)
        Me.cmdok.TabIndex = 2
        Me.cmdok.UseVisualStyleBackColor = True
        '
        'pbcapture
        '
        Me.pbcapture.BackColor = System.Drawing.Color.DarkGray
        Me.pbcapture.BackgroundImage = Global.WebCam.My.Resources.Resources.Image_Capture_icon
        Me.pbcapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbcapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbcapture.Location = New System.Drawing.Point(686, 329)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(52, 50)
        Me.pbcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.TabStop = False
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(440, 8)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(487, 313)
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdopen
        '
        Me.cmdopen.Location = New System.Drawing.Point(10, 385)
        Me.cmdopen.Name = "cmdopen"
        Me.cmdopen.Size = New System.Drawing.Size(75, 23)
        Me.cmdopen.TabIndex = 6
        Me.cmdopen.Text = "Open"
        Me.cmdopen.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'cmdPrintSelected
        '
        Me.cmdPrintSelected.Location = New System.Drawing.Point(332, 390)
        Me.cmdPrintSelected.Name = "cmdPrintSelected"
        Me.cmdPrintSelected.Size = New System.Drawing.Size(90, 23)
        Me.cmdPrintSelected.TabIndex = 7
        Me.cmdPrintSelected.Text = "Print"
        Me.cmdPrintSelected.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'cmdPrintPreview
        '
        Me.cmdPrintPreview.Location = New System.Drawing.Point(216, 390)
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.Size = New System.Drawing.Size(110, 23)
        Me.cmdPrintPreview.TabIndex = 8
        Me.cmdPrintPreview.Text = "Print Preview"
        Me.cmdPrintPreview.UseVisualStyleBackColor = True
        '
        'SN
        '
        Me.SN.HeaderText = "SN"
        Me.SN.Name = "SN"
        Me.SN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.Width = 40
        '
        'VisitorImage
        '
        Me.VisitorImage.HeaderText = "Image"
        Me.VisitorImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.VisitorImage.Name = "VisitorImage"
        '
        'VisitorName
        '
        Me.VisitorName.HeaderText = "Name"
        Me.VisitorName.Name = "VisitorName"
        Me.VisitorName.Width = 200
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.Width = 30
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.Width = 300
        '
        'MobileNumber
        '
        Me.MobileNumber.HeaderText = "Mobile Number"
        Me.MobileNumber.Name = "MobileNumber"
        Me.MobileNumber.Width = 120
        '
        'VisitordateAndTime
        '
        Me.VisitordateAndTime.HeaderText = "Time"
        Me.VisitordateAndTime.Name = "VisitordateAndTime"
        Me.VisitordateAndTime.Width = 150
        '
        'OutTime
        '
        Me.OutTime.HeaderText = "OutTime"
        Me.OutTime.Name = "OutTime"
        Me.OutTime.Width = 150
        '
        'OfficerToMeet
        '
        Me.OfficerToMeet.HeaderText = "OfficerToMeet"
        Me.OfficerToMeet.Name = "OfficerToMeet"
        Me.OfficerToMeet.Width = 200
        '
        'NatureOfWork
        '
        Me.NatureOfWork.HeaderText = "Nature Of Work"
        Me.NatureOfWork.Name = "NatureOfWork"
        Me.NatureOfWork.Width = 150
        '
        'IssuingOfficer
        '
        Me.IssuingOfficer.HeaderText = "Issuing Officer"
        Me.IssuingOfficer.Name = "IssuingOfficer"
        Me.IssuingOfficer.Width = 150
        '
        'Reference
        '
        Me.Reference.HeaderText = "Reference"
        Me.Reference.Items.AddRange(New Object() {"Rehersal", "Recording", "Live Telecast", "Personal Meet", "Reference"})
        Me.Reference.Name = "Reference"
        '
        'TotalPerson
        '
        Me.TotalPerson.HeaderText = "Total Person"
        Me.TotalPerson.Name = "TotalPerson"
        Me.TotalPerson.Width = 90
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1866, 793)
        Me.Controls.Add(Me.cmdPrintPreview)
        Me.Controls.Add(Me.cmdPrintSelected)
        Me.Controls.Add(Me.cmdopen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.cmdno)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.pbcapture)
        Me.Controls.Add(Me.pbcaptureimage)
        Me.Name = "Form1"
        Me.Text = "WebCam"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbcaptureimage As System.Windows.Forms.PictureBox
    Friend WithEvents pbcapture As PictureBoxAbouAmmar.صورة_دائرة
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents cmdno As System.Windows.Forms.Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdopen As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmdPrintSelected As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cmdPrintPreview As Button
    Friend WithEvents SN As DataGridViewTextBoxColumn
    Friend WithEvents VisitorImage As DataGridViewImageColumn
    Friend WithEvents VisitorName As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumber As DataGridViewTextBoxColumn
    Friend WithEvents VisitordateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents OutTime As DataGridViewTextBoxColumn
    Friend WithEvents OfficerToMeet As DataGridViewTextBoxColumn
    Friend WithEvents NatureOfWork As DataGridViewTextBoxColumn
    Friend WithEvents IssuingOfficer As DataGridViewTextBoxColumn
    Friend WithEvents Reference As DataGridViewComboBoxColumn
    Friend WithEvents TotalPerson As DataGridViewTextBoxColumn
End Class
