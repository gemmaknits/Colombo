<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocAttachments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocAttachments))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtrow_number = New System.Windows.Forms.TextBox()
        Me.lblDocno = New System.Windows.Forms.Label()
        Me.lblItemsNature = New System.Windows.Forms.Label()
        Me.txtDocno = New System.Windows.Forms.TextBox()
        Me.cbosource_doc_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.lbldoc_attachments_id = New System.Windows.Forms.Label()
        Me.txtdoc_attachments_id = New System.Windows.Forms.TextBox()
        Me.CboPhotoNo = New System.Windows.Forms.ComboBox()
        Me.lblPhotoNo = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtfile_location = New System.Windows.Forms.TextBox()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.btnImagePath = New System.Windows.Forms.Button()
        Me.btnright = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.row_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDownLoad = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.file_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doc_attachments_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStrip1.TabIndex = 14
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtrow_number)
        Me.GroupBox1.Controls.Add(Me.lblDocno)
        Me.GroupBox1.Controls.Add(Me.lblItemsNature)
        Me.GroupBox1.Controls.Add(Me.txtDocno)
        Me.GroupBox1.Controls.Add(Me.cbosource_doc_type)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 52)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'txtrow_number
        '
        Me.txtrow_number.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtrow_number.Location = New System.Drawing.Point(840, 19)
        Me.txtrow_number.Name = "txtrow_number"
        Me.txtrow_number.Size = New System.Drawing.Size(307, 20)
        Me.txtrow_number.TabIndex = 62
        Me.txtrow_number.Visible = False
        '
        'lblDocno
        '
        Me.lblDocno.AutoSize = True
        Me.lblDocno.Location = New System.Drawing.Point(16, 19)
        Me.lblDocno.Name = "lblDocno"
        Me.lblDocno.Size = New System.Drawing.Size(47, 13)
        Me.lblDocno.TabIndex = 2
        Me.lblDocno.Text = "Doc No."
        '
        'lblItemsNature
        '
        Me.lblItemsNature.AutoSize = True
        Me.lblItemsNature.Location = New System.Drawing.Point(212, 20)
        Me.lblItemsNature.Name = "lblItemsNature"
        Me.lblItemsNature.Size = New System.Drawing.Size(59, 13)
        Me.lblItemsNature.TabIndex = 61
        Me.lblItemsNature.Text = "Doc Types"
        '
        'txtDocno
        '
        Me.txtDocno.Enabled = False
        Me.txtDocno.Location = New System.Drawing.Point(80, 19)
        Me.txtDocno.Name = "txtDocno"
        Me.txtDocno.Size = New System.Drawing.Size(100, 20)
        Me.txtDocno.TabIndex = 1
        '
        'cbosource_doc_type
        '
        Me.cbosource_doc_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbosource_doc_type.Enabled = False
        Me.cbosource_doc_type.FormattingEnabled = True
        Me.cbosource_doc_type.Location = New System.Drawing.Point(286, 19)
        Me.cbosource_doc_type.Name = "cbosource_doc_type"
        Me.cbosource_doc_type.Size = New System.Drawing.Size(119, 21)
        Me.cbosource_doc_type.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grddata)
        Me.GroupBox2.Controls.Add(Me.lbldoc_attachments_id)
        Me.GroupBox2.Controls.Add(Me.txtdoc_attachments_id)
        Me.GroupBox2.Controls.Add(Me.CboPhotoNo)
        Me.GroupBox2.Controls.Add(Me.lblPhotoNo)
        Me.GroupBox2.Controls.Add(Me.btnUpload)
        Me.GroupBox2.Controls.Add(Me.txtfile_location)
        Me.GroupBox2.Controls.Add(Me.btnleft)
        Me.GroupBox2.Controls.Add(Me.btnImagePath)
        Me.GroupBox2.Controls.Add(Me.btnright)
        Me.GroupBox2.Controls.Add(Me.txtCount)
        Me.GroupBox2.Controls.Add(Me.txtRemark)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1160, 425)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row_number, Me.btnView, Me.btnDownLoad, Me.file_description, Me.file_location, Me.file_type, Me.doc_attachments_id})
        Me.grddata.Location = New System.Drawing.Point(12, 48)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(737, 277)
        Me.grddata.TabIndex = 68
        '
        'lbldoc_attachments_id
        '
        Me.lbldoc_attachments_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldoc_attachments_id.AutoSize = True
        Me.lbldoc_attachments_id.Location = New System.Drawing.Point(1042, 23)
        Me.lbldoc_attachments_id.Name = "lbldoc_attachments_id"
        Me.lbldoc_attachments_id.Size = New System.Drawing.Size(54, 13)
        Me.lbldoc_attachments_id.TabIndex = 67
        Me.lbldoc_attachments_id.Text = "Picture ID"
        Me.lbldoc_attachments_id.Visible = False
        '
        'txtdoc_attachments_id
        '
        Me.txtdoc_attachments_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdoc_attachments_id.Location = New System.Drawing.Point(1102, 22)
        Me.txtdoc_attachments_id.Name = "txtdoc_attachments_id"
        Me.txtdoc_attachments_id.ReadOnly = True
        Me.txtdoc_attachments_id.Size = New System.Drawing.Size(45, 20)
        Me.txtdoc_attachments_id.TabIndex = 66
        Me.txtdoc_attachments_id.Visible = False
        '
        'CboPhotoNo
        '
        Me.CboPhotoNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CboPhotoNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CboPhotoNo.Enabled = False
        Me.CboPhotoNo.FormattingEnabled = True
        Me.CboPhotoNo.Location = New System.Drawing.Point(518, 19)
        Me.CboPhotoNo.Name = "CboPhotoNo"
        Me.CboPhotoNo.Size = New System.Drawing.Size(100, 21)
        Me.CboPhotoNo.TabIndex = 64
        Me.CboPhotoNo.Visible = False
        '
        'lblPhotoNo
        '
        Me.lblPhotoNo.AutoSize = True
        Me.lblPhotoNo.Location = New System.Drawing.Point(9, 22)
        Me.lblPhotoNo.Name = "lblPhotoNo"
        Me.lblPhotoNo.Size = New System.Drawing.Size(55, 13)
        Me.lblPhotoNo.TabIndex = 65
        Me.lblPhotoNo.Text = "Photo No."
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.Location = New System.Drawing.Point(1064, 396)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 59
        Me.btnUpload.Text = "UpLoad"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'txtfile_location
        '
        Me.txtfile_location.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfile_location.Location = New System.Drawing.Point(570, 398)
        Me.txtfile_location.Name = "txtfile_location"
        Me.txtfile_location.ReadOnly = True
        Me.txtfile_location.Size = New System.Drawing.Size(446, 20)
        Me.txtfile_location.TabIndex = 58
        '
        'btnleft
        '
        Me.btnleft.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnleft.Location = New System.Drawing.Point(481, 19)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(31, 23)
        Me.btnleft.TabIndex = 15
        Me.btnleft.Text = "<"
        Me.btnleft.UseVisualStyleBackColor = True
        Me.btnleft.Visible = False
        '
        'btnImagePath
        '
        Me.btnImagePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImagePath.Location = New System.Drawing.Point(1034, 396)
        Me.btnImagePath.Name = "btnImagePath"
        Me.btnImagePath.Size = New System.Drawing.Size(24, 23)
        Me.btnImagePath.TabIndex = 57
        Me.btnImagePath.Text = "..."
        Me.btnImagePath.UseVisualStyleBackColor = True
        '
        'btnright
        '
        Me.btnright.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnright.Location = New System.Drawing.Point(624, 19)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(30, 23)
        Me.btnright.TabIndex = 14
        Me.btnright.Text = ">"
        Me.btnright.UseVisualStyleBackColor = True
        Me.btnright.Visible = False
        '
        'txtCount
        '
        Me.txtCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCount.Location = New System.Drawing.Point(897, 20)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(57, 20)
        Me.txtCount.TabIndex = 18
        Me.txtCount.Visible = False
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(12, 345)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(1135, 45)
        Me.txtRemark.TabIndex = 3
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(864, 24)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(27, 13)
        Me.lblCount.TabIndex = 17
        Me.lblCount.Text = "Max"
        Me.lblCount.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(755, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'row_number
        '
        Me.row_number.DataPropertyName = "row_number"
        Me.row_number.HeaderText = "#"
        Me.row_number.Name = "row_number"
        Me.row_number.Width = 50
        '
        'btnView
        '
        Me.btnView.DataPropertyName = "btnView"
        Me.btnView.HeaderText = "View"
        Me.btnView.Name = "btnView"
        Me.btnView.Text = "View"
        Me.btnView.Width = 50
        '
        'btnDownLoad
        '
        Me.btnDownLoad.DataPropertyName = "btnDownLoad"
        Me.btnDownLoad.HeaderText = "D/L"
        Me.btnDownLoad.Name = "btnDownLoad"
        Me.btnDownLoad.Text = "D/L"
        Me.btnDownLoad.Width = 50
        '
        'file_description
        '
        Me.file_description.DataPropertyName = "file_description"
        Me.file_description.HeaderText = "Description"
        Me.file_description.Name = "file_description"
        Me.file_description.Width = 250
        '
        'file_location
        '
        Me.file_location.DataPropertyName = "file_location"
        Me.file_location.HeaderText = "Location"
        Me.file_location.Name = "file_location"
        Me.file_location.Width = 400
        '
        'file_type
        '
        Me.file_type.DataPropertyName = "file_type"
        Me.file_type.HeaderText = "Type"
        Me.file_type.Name = "file_type"
        Me.file_type.Width = 50
        '
        'doc_attachments_id
        '
        Me.doc_attachments_id.DataPropertyName = "doc_attachments_id"
        Me.doc_attachments_id.HeaderText = "doc_attachments_id"
        Me.doc_attachments_id.Name = "doc_attachments_id"
        Me.doc_attachments_id.Visible = False
        Me.doc_attachments_id.Width = 50
        '
        'frmDocAttachments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 533)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDocAttachments"
        Me.Text = "Photo Album"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDocno As Label
    Friend WithEvents lblItemsNature As Label
    Friend WithEvents txtDocno As TextBox
    Friend WithEvents cbosource_doc_type As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grddata As DataGridView
    Friend WithEvents lbldoc_attachments_id As Label
    Friend WithEvents txtdoc_attachments_id As TextBox
    Friend WithEvents CboPhotoNo As ComboBox
    Friend WithEvents lblPhotoNo As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtfile_location As TextBox
    Friend WithEvents btnleft As Button
    Friend WithEvents btnImagePath As Button
    Friend WithEvents btnright As Button
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents PictureBox1 As PictureBox
    'Private WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txtrow_number As TextBox
    Friend WithEvents row_number As DataGridViewTextBoxColumn
    Friend WithEvents btnView As DataGridViewButtonColumn
    Friend WithEvents btnDownLoad As DataGridViewButtonColumn
    Friend WithEvents file_description As DataGridViewTextBoxColumn
    Friend WithEvents file_location As DataGridViewTextBoxColumn
    Friend WithEvents file_type As DataGridViewTextBoxColumn
    Friend WithEvents doc_attachments_id As DataGridViewTextBoxColumn
End Class
