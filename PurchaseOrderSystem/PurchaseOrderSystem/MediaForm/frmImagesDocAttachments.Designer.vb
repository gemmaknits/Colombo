<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagesDocAttachments
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImagesDocAttachments))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFileDescription = New System.Windows.Forms.TextBox()
        Me.btnGetOutputFileName = New System.Windows.Forms.Button()
        Me.txtInputFileName = New System.Windows.Forms.TextBox()
        Me.txtOutputFileName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutputPathName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGetSourceFileName = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.grpImage = New System.Windows.Forms.GroupBox()
        Me.lblReducingSize = New System.Windows.Forms.Label()
        Me.lblReducingFactor = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCurrentSize = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPhotoNo = New System.Windows.Forms.Label()
        Me.lblDocno = New System.Windows.Forms.Label()
        Me.txtSourceDocType = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblItemsNature = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSourceDocNumber = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tsbtnUpload = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnView = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpImage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 334)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image"
        '
        'txtFileDescription
        '
        Me.txtFileDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileDescription.Location = New System.Drawing.Point(143, 16)
        Me.txtFileDescription.Name = "txtFileDescription"
        Me.txtFileDescription.Size = New System.Drawing.Size(453, 20)
        Me.txtFileDescription.TabIndex = 72
        '
        'btnGetOutputFileName
        '
        Me.btnGetOutputFileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetOutputFileName.Location = New System.Drawing.Point(579, 65)
        Me.btnGetOutputFileName.Name = "btnGetOutputFileName"
        Me.btnGetOutputFileName.Size = New System.Drawing.Size(22, 23)
        Me.btnGetOutputFileName.TabIndex = 82
        Me.btnGetOutputFileName.Text = "..."
        Me.btnGetOutputFileName.UseVisualStyleBackColor = True
        '
        'txtInputFileName
        '
        Me.txtInputFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInputFileName.Location = New System.Drawing.Point(144, 17)
        Me.txtInputFileName.Name = "txtInputFileName"
        Me.txtInputFileName.ReadOnly = True
        Me.txtInputFileName.Size = New System.Drawing.Size(429, 20)
        Me.txtInputFileName.TabIndex = 70
        '
        'txtOutputFileName
        '
        Me.txtOutputFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputFileName.Enabled = False
        Me.txtOutputFileName.Location = New System.Drawing.Point(144, 66)
        Me.txtOutputFileName.Name = "txtOutputFileName"
        Me.txtOutputFileName.ReadOnly = True
        Me.txtOutputFileName.Size = New System.Drawing.Size(429, 20)
        Me.txtOutputFileName.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = ":"
        '
        'txtOutputPathName
        '
        Me.txtOutputPathName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputPathName.Enabled = False
        Me.txtOutputPathName.Location = New System.Drawing.Point(144, 41)
        Me.txtOutputPathName.Name = "txtOutputPathName"
        Me.txtOutputPathName.ReadOnly = True
        Me.txtOutputPathName.Size = New System.Drawing.Size(429, 20)
        Me.txtOutputPathName.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = ":"
        '
        'btnGetSourceFileName
        '
        Me.btnGetSourceFileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetSourceFileName.Location = New System.Drawing.Point(579, 15)
        Me.btnGetSourceFileName.Name = "btnGetSourceFileName"
        Me.btnGetSourceFileName.Size = New System.Drawing.Size(21, 23)
        Me.btnGetSourceFileName.TabIndex = 67
        Me.btnGetSourceFileName.Text = "..."
        Me.btnGetSourceFileName.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Output File Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Output Path"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtFileLocation)
        Me.GroupBox3.Controls.Add(Me.txtFileDescription)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(608, 66)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data In Database (Had File already)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(129, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Title"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(129, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "File Name & Locaton"
        '
        'txtFileLocation
        '
        Me.txtFileLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileLocation.Location = New System.Drawing.Point(144, 39)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.ReadOnly = True
        Me.txtFileLocation.Size = New System.Drawing.Size(452, 20)
        Me.txtFileLocation.TabIndex = 73
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.GroupBox2)
        Me.grpImage.Controls.Add(Me.lblReducingSize)
        Me.grpImage.Controls.Add(Me.lblReducingFactor)
        Me.grpImage.Controls.Add(Me.Label9)
        Me.grpImage.Controls.Add(Me.Label1)
        Me.grpImage.Controls.Add(Me.Label6)
        Me.grpImage.Controls.Add(Me.lblCurrentSize)
        Me.grpImage.Controls.Add(Me.Label5)
        Me.grpImage.Controls.Add(Me.Label4)
        Me.grpImage.Controls.Add(Me.Label3)
        Me.grpImage.Location = New System.Drawing.Point(693, 32)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(469, 432)
        Me.grpImage.TabIndex = 75
        Me.grpImage.TabStop = False
        Me.grpImage.Text = "Source Photo"
        '
        'lblReducingSize
        '
        Me.lblReducingSize.AutoSize = True
        Me.lblReducingSize.Location = New System.Drawing.Point(142, 69)
        Me.lblReducingSize.Name = "lblReducingSize"
        Me.lblReducingSize.Size = New System.Drawing.Size(76, 13)
        Me.lblReducingSize.TabIndex = 77
        Me.lblReducingSize.Text = "Reducing Size"
        '
        'lblReducingFactor
        '
        Me.lblReducingFactor.AutoSize = True
        Me.lblReducingFactor.Location = New System.Drawing.Point(142, 46)
        Me.lblReducingFactor.Name = "lblReducingFactor"
        Me.lblReducingFactor.Size = New System.Drawing.Size(86, 13)
        Me.lblReducingFactor.TabIndex = 75
        Me.lblReducingFactor.Text = "Reducing Factor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Reducing Factor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = ":"
        '
        'lblCurrentSize
        '
        Me.lblCurrentSize.AutoSize = True
        Me.lblCurrentSize.Location = New System.Drawing.Point(142, 23)
        Me.lblCurrentSize.Name = "lblCurrentSize"
        Me.lblCurrentSize.Size = New System.Drawing.Size(64, 13)
        Me.lblCurrentSize.TabIndex = 71
        Me.lblCurrentSize.Text = "Current Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Reducing Size"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Current Size"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(128, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = ":"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGetOutputFileName)
        Me.GroupBox4.Controls.Add(Me.txtInputFileName)
        Me.GroupBox4.Controls.Add(Me.txtOutputFileName)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtOutputPathName)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnGetSourceFileName)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblPhotoNo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(609, 97)
        Me.GroupBox4.TabIndex = 77
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "For Upload File Only (Physical File)"
        '
        'lblPhotoNo
        '
        Me.lblPhotoNo.AutoSize = True
        Me.lblPhotoNo.Location = New System.Drawing.Point(20, 20)
        Me.lblPhotoNo.Name = "lblPhotoNo"
        Me.lblPhotoNo.Size = New System.Drawing.Size(91, 13)
        Me.lblPhotoNo.TabIndex = 65
        Me.lblPhotoNo.Text = "Source File Name"
        '
        'lblDocno
        '
        Me.lblDocno.AutoSize = True
        Me.lblDocno.Location = New System.Drawing.Point(20, 16)
        Me.lblDocno.Name = "lblDocno"
        Me.lblDocno.Size = New System.Drawing.Size(47, 13)
        Me.lblDocno.TabIndex = 2
        Me.lblDocno.Text = "Doc No."
        '
        'txtSourceDocType
        '
        Me.txtSourceDocType.Enabled = False
        Me.txtSourceDocType.Location = New System.Drawing.Point(145, 37)
        Me.txtSourceDocType.Name = "txtSourceDocType"
        Me.txtSourceDocType.ReadOnly = True
        Me.txtSourceDocType.Size = New System.Drawing.Size(155, 20)
        Me.txtSourceDocType.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnUpload, Me.tsbtnView, Me.ToolStripSeparator1, Me.tsbtnSave, Me.ToolStripSeparator2, Me.tsbtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(635, 25)
        Me.ToolStrip1.TabIndex = 73
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblItemsNature
        '
        Me.lblItemsNature.AutoSize = True
        Me.lblItemsNature.Location = New System.Drawing.Point(20, 40)
        Me.lblItemsNature.Name = "lblItemsNature"
        Me.lblItemsNature.Size = New System.Drawing.Size(59, 13)
        Me.lblItemsNature.TabIndex = 61
        Me.lblItemsNature.Text = "Doc Types"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSourceDocNumber)
        Me.GroupBox1.Controls.Add(Me.lblDocno)
        Me.GroupBox1.Controls.Add(Me.lblItemsNature)
        Me.GroupBox1.Controls.Add(Me.txtSourceDocType)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 64)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(130, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = ":"
        Me.Label12.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = ":"
        Me.Label10.Visible = False
        '
        'txtSourceDocNumber
        '
        Me.txtSourceDocNumber.Enabled = False
        Me.txtSourceDocNumber.Location = New System.Drawing.Point(145, 13)
        Me.txtSourceDocNumber.Name = "txtSourceDocNumber"
        Me.txtSourceDocNumber.ReadOnly = True
        Me.txtSourceDocNumber.Size = New System.Drawing.Size(155, 20)
        Me.txtSourceDocNumber.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "row_number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "file_description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "file_location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "file_type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "doc_attachments_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "doc_attachments_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tsbtnUpload
        '
        Me.tsbtnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnUpload.Image = CType(resources.GetObject("tsbtnUpload.Image"), System.Drawing.Image)
        Me.tsbtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnUpload.Name = "tsbtnUpload"
        Me.tsbtnUpload.Size = New System.Drawing.Size(49, 22)
        Me.tsbtnUpload.Text = "Upload"
        '
        'tsbtnView
        '
        Me.tsbtnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnView.Image = CType(resources.GetObject("tsbtnView.Image"), System.Drawing.Image)
        Me.tsbtnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnView.Name = "tsbtnView"
        Me.tsbtnView.Size = New System.Drawing.Size(36, 22)
        Me.tsbtnView.Text = "View"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"), System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(51, 22)
        Me.tsbtnSave.Text = "Save"
        '
        'tsbtnExit
        '
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"), System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(45, 22)
        Me.tsbtnExit.Text = "Exit"
        '
        'frmImagesDocAttachments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 271)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpImage)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmImagesDocAttachments"
        Me.Text = "Photo Album"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpImage.ResumeLayout(False)
        Me.grpImage.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtFileDescription As TextBox
    Friend WithEvents btnGetOutputFileName As Button
    Friend WithEvents txtInputFileName As TextBox
    Friend WithEvents txtOutputFileName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutputPathName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGetSourceFileName As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFileLocation As TextBox
    Friend WithEvents grpImage As GroupBox
    Friend WithEvents lblReducingSize As Label
    Friend WithEvents lblReducingFactor As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCurrentSize As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblPhotoNo As Label
    Friend WithEvents lblDocno As Label
    Friend WithEvents txtSourceDocType As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnUpload As ToolStripButton
    Friend WithEvents tsbtnView As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbtnExit As ToolStripButton
    Friend WithEvents lblItemsNature As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSourceDocNumber As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
