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
        Me.cmdMarkOutTime = New System.Windows.Forms.Button()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VisitorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblplalistname = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdDeleteRow = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SN, Me.VisitorImage, Me.VisitorName, Me.ID, Me.Age, Me.Address, Me.MobileNumber, Me.VisitordateAndTime, Me.OutTime, Me.OfficerToMeet, Me.NatureOfWork, Me.IssuingOfficer, Me.Reference, Me.TotalPerson})
        Me.dgv1.Location = New System.Drawing.Point(15, 420)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 50
        Me.dgv1.Size = New System.Drawing.Size(1559, 337)
        Me.dgv1.TabIndex = 4
        '
        'cmdno
        '
        Me.cmdno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdno.Image = Global.WebCam.My.Resources.Resources.Actions_edit_delete_icon
        Me.cmdno.Location = New System.Drawing.Point(916, 343)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(32, 24)
        Me.cmdno.TabIndex = 3
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.Image = Global.WebCam.My.Resources.Resources.Ok_icon__1_1
        Me.cmdok.Location = New System.Drawing.Point(878, 343)
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
        Me.pbcapture.Location = New System.Drawing.Point(885, 327)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(52, 50)
        Me.pbcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.TabStop = False
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(659, 6)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(487, 313)
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdopen
        '
        Me.cmdopen.Location = New System.Drawing.Point(22, 386)
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
        Me.cmdPrintSelected.Location = New System.Drawing.Point(415, 386)
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
        Me.cmdPrintPreview.Location = New System.Drawing.Point(299, 386)
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.Size = New System.Drawing.Size(110, 23)
        Me.cmdPrintPreview.TabIndex = 8
        Me.cmdPrintPreview.Text = "Print Preview"
        Me.cmdPrintPreview.UseVisualStyleBackColor = True
        '
        'cmdMarkOutTime
        '
        Me.cmdMarkOutTime.Location = New System.Drawing.Point(938, 391)
        Me.cmdMarkOutTime.Name = "cmdMarkOutTime"
        Me.cmdMarkOutTime.Size = New System.Drawing.Size(107, 23)
        Me.cmdMarkOutTime.TabIndex = 9
        Me.cmdMarkOutTime.Text = "Mark Out Time"
        Me.cmdMarkOutTime.UseVisualStyleBackColor = True
        '
        'SN
        '
        Me.SN.HeaderText = "SN"
        Me.SN.Name = "SN"
        Me.SN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.Width = 30
        '
        'VisitorImage
        '
        Me.VisitorImage.HeaderText = "Photo"
        Me.VisitorImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.VisitorImage.Name = "VisitorImage"
        '
        'VisitorName
        '
        Me.VisitorName.HeaderText = "Name"
        Me.VisitorName.Name = "VisitorName"
        Me.VisitorName.Width = 120
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 200
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
        Me.Address.Width = 200
        '
        'MobileNumber
        '
        Me.MobileNumber.HeaderText = "Mobile Number"
        Me.MobileNumber.Name = "MobileNumber"
        Me.MobileNumber.Width = 80
        '
        'VisitordateAndTime
        '
        Me.VisitordateAndTime.HeaderText = "IN Time"
        Me.VisitordateAndTime.Name = "VisitordateAndTime"
        Me.VisitordateAndTime.Width = 120
        '
        'OutTime
        '
        Me.OutTime.HeaderText = "OutTime"
        Me.OutTime.Name = "OutTime"
        Me.OutTime.Width = 120
        '
        'OfficerToMeet
        '
        Me.OfficerToMeet.HeaderText = "OfficerToMeet"
        Me.OfficerToMeet.Name = "OfficerToMeet"
        Me.OfficerToMeet.Width = 120
        '
        'NatureOfWork
        '
        Me.NatureOfWork.HeaderText = "Nature Of Work"
        Me.NatureOfWork.Name = "NatureOfWork"
        '
        'IssuingOfficer
        '
        Me.IssuingOfficer.HeaderText = "Issuing Officer"
        Me.IssuingOfficer.Name = "IssuingOfficer"
        Me.IssuingOfficer.Width = 120
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
        Me.TotalPerson.Width = 50
        '
        'lblplalistname
        '
        Me.lblplalistname.AutoSize = True
        Me.lblplalistname.Location = New System.Drawing.Point(22, 312)
        Me.lblplalistname.Name = "lblplalistname"
        Me.lblplalistname.Size = New System.Drawing.Size(52, 13)
        Me.lblplalistname.TabIndex = 10
        Me.lblplalistname.Text = "File name"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(184, 386)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdNew.TabIndex = 11
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdDeleteRow
        '
        Me.cmdDeleteRow.Location = New System.Drawing.Point(540, 386)
        Me.cmdDeleteRow.Name = "cmdDeleteRow"
        Me.cmdDeleteRow.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteRow.TabIndex = 12
        Me.cmdDeleteRow.Text = "Delete Row"
        Me.cmdDeleteRow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1875, 825)
        Me.Controls.Add(Me.cmdDeleteRow)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.lblplalistname)
        Me.Controls.Add(Me.cmdMarkOutTime)
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
        Me.PerformLayout()

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
    Friend WithEvents cmdMarkOutTime As Button
    Friend WithEvents SN As DataGridViewTextBoxColumn
    Friend WithEvents VisitorImage As DataGridViewImageColumn
    Friend WithEvents VisitorName As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
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
    Friend WithEvents lblplalistname As Label
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdDeleteRow As Button
End Class
