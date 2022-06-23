<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.VisitorImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VisitorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitordateAndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdno = New System.Windows.Forms.Button()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.pbcapture = New PictureBoxAbouAmmar.صورة_دائرة()
        Me.pbcaptureimage = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdopen = New System.Windows.Forms.Button()
        Me.cmdSetOutTime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeacrh = New System.Windows.Forms.TextBox()
        Me.cmdClearSearch = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcaptureimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitorImage, Me.VisitorName, Me.Age, Me.Address, Me.VisitordateAndTime, Me.OutTime})
        Me.dgv1.Location = New System.Drawing.Point(12, 12)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 50
        Me.dgv1.Size = New System.Drawing.Size(650, 313)
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
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'VisitordateAndTime
        '
        Me.VisitordateAndTime.HeaderText = "In Time"
        Me.VisitordateAndTime.Name = "VisitordateAndTime"
        '
        'OutTime
        '
        Me.OutTime.HeaderText = "Out Time"
        Me.OutTime.Name = "OutTime"
        '
        'cmdno
        '
        Me.cmdno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdno.Image = Global.WebCam.My.Resources.Resources.Actions_edit_delete_icon
        Me.cmdno.Location = New System.Drawing.Point(958, 347)
        Me.cmdno.Name = "cmdno"
        Me.cmdno.Size = New System.Drawing.Size(32, 24)
        Me.cmdno.TabIndex = 3
        Me.cmdno.UseVisualStyleBackColor = True
        '
        'cmdok
        '
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.Image = Global.WebCam.My.Resources.Resources.Ok_icon__1_1
        Me.cmdok.Location = New System.Drawing.Point(920, 347)
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
        Me.pbcapture.Location = New System.Drawing.Point(927, 331)
        Me.pbcapture.Name = "pbcapture"
        Me.pbcapture.Size = New System.Drawing.Size(52, 50)
        Me.pbcapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcapture.TabIndex = 1
        Me.pbcapture.TabStop = False
        '
        'pbcaptureimage
        '
        Me.pbcaptureimage.Location = New System.Drawing.Point(702, 12)
        Me.pbcaptureimage.Name = "pbcaptureimage"
        Me.pbcaptureimage.Size = New System.Drawing.Size(487, 313)
        Me.pbcaptureimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcaptureimage.TabIndex = 0
        Me.pbcaptureimage.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdopen
        '
        Me.cmdopen.Location = New System.Drawing.Point(206, 383)
        Me.cmdopen.Name = "cmdopen"
        Me.cmdopen.Size = New System.Drawing.Size(75, 23)
        Me.cmdopen.TabIndex = 6
        Me.cmdopen.Text = "Open"
        Me.cmdopen.UseVisualStyleBackColor = True
        '
        'cmdSetOutTime
        '
        Me.cmdSetOutTime.Location = New System.Drawing.Point(587, 330)
        Me.cmdSetOutTime.Name = "cmdSetOutTime"
        Me.cmdSetOutTime.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetOutTime.TabIndex = 7
        Me.cmdSetOutTime.Text = "Set Out Time"
        Me.cmdSetOutTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search"
        '
        'txtSeacrh
        '
        Me.txtSeacrh.Location = New System.Drawing.Point(60, 332)
        Me.txtSeacrh.Name = "txtSeacrh"
        Me.txtSeacrh.Size = New System.Drawing.Size(140, 20)
        Me.txtSeacrh.TabIndex = 9
        '
        'cmdClearSearch
        '
        Me.cmdClearSearch.Location = New System.Drawing.Point(207, 328)
        Me.cmdClearSearch.Name = "cmdClearSearch"
        Me.cmdClearSearch.Size = New System.Drawing.Size(84, 23)
        Me.cmdClearSearch.TabIndex = 10
        Me.cmdClearSearch.Text = "Clear Serach"
        Me.cmdClearSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 583)
        Me.Controls.Add(Me.cmdClearSearch)
        Me.Controls.Add(Me.txtSeacrh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSetOutTime)
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
    Friend WithEvents VisitorImage As DataGridViewImageColumn
    Friend WithEvents VisitorName As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents VisitordateAndTime As DataGridViewTextBoxColumn
    Friend WithEvents OutTime As DataGridViewTextBoxColumn
    Friend WithEvents cmdSetOutTime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSeacrh As TextBox
    Friend WithEvents cmdClearSearch As Button
End Class
