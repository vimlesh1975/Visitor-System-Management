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
        Me.VisitorImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VisitorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitordateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitorImage, Me.VisitorName, Me.Age, Me.Address, Me.VisitordateAndTime})
        Me.dgv1.Location = New System.Drawing.Point(12, 46)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 50
        Me.dgv1.Size = New System.Drawing.Size(864, 717)
        Me.dgv1.TabIndex = 4
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
        'VisitordateAndTime
        '
        Me.VisitordateAndTime.HeaderText = "Time"
        Me.VisitordateAndTime.Name = "VisitordateAndTime"
        Me.VisitordateAndTime.Width = 150
        '
        'cmdno
        '
        Me.cmdno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdno.Image = Global.WebCam.My.Resources.Resources.Actions_edit_delete_icon
        Me.cmdno.Location = New System.Drawing.Point(1159, 380)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(32, 24)
        Me.cmdno.TabIndex = 3
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.Image = Global.WebCam.My.Resources.Resources.Ok_icon__1_1
        Me.cmdok.Location = New System.Drawing.Point(1121, 380)
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
        Me.pbcapture.Location = New System.Drawing.Point(1128, 364)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(52, 50)
        Me.pbcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.TabStop = False
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(882, 43)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(487, 313)
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdopen
        '
        Me.cmdopen.Location = New System.Drawing.Point(14, 12)
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
        Me.cmdPrintSelected.Location = New System.Drawing.Point(336, 17)
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
        Me.cmdPrintPreview.Location = New System.Drawing.Point(220, 17)
        Me.cmdPrintPreview.Name = "cmdPrintPreview"
        Me.cmdPrintPreview.Size = New System.Drawing.Size(110, 23)
        Me.cmdPrintPreview.TabIndex = 8
        Me.cmdPrintPreview.Text = "Print Preview"
        Me.cmdPrintPreview.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1385, 793)
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
    Friend WithEvents VisitorImage As DataGridViewImageColumn
    Friend WithEvents VisitorName As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents VisitordateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmdPrintSelected As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cmdPrintPreview As Button
End Class
