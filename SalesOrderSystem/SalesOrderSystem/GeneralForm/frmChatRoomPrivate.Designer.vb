<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChatRoomPrivate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChatRoomPrivate))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.RightClickMenu = New System.Windows.Forms.ContextMenu
		Me.mnuRestore = New System.Windows.Forms.MenuItem
		Me.btnClear = New System.Windows.Forms.Button
		Me.cboOnlineUser = New System.Windows.Forms.ComboBox
		Me.txtSendMessage = New System.Windows.Forms.TextBox
		Me.btnSend = New System.Windows.Forms.Button
		Me.txtShowMessage = New System.Windows.Forms.TextBox
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.grdOnlineUser = New System.Windows.Forms.DataGridView
		Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ip_address = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.flag = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.btnLoad = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnChangeWindowStyle = New System.Windows.Forms.Button
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdOnlineUser, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RightClickMenu
		'
		Me.RightClickMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRestore})
		'
		'mnuRestore
		'
		Me.mnuRestore.Index = 0
		Me.mnuRestore.Text = "&Kick"
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(376, 360)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(40, 24)
		Me.btnClear.TabIndex = 16
		Me.btnClear.Text = "&Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'cboOnlineUser
		'
		Me.cboOnlineUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOnlineUser.FormattingEnabled = True
		Me.cboOnlineUser.Location = New System.Drawing.Point(8, 24)
		Me.cboOnlineUser.Name = "cboOnlineUser"
		Me.cboOnlineUser.Size = New System.Drawing.Size(72, 21)
		Me.cboOnlineUser.TabIndex = 17
		'
		'txtSendMessage
		'
		Me.txtSendMessage.Location = New System.Drawing.Point(184, 320)
		Me.txtSendMessage.Multiline = True
		Me.txtSendMessage.Name = "txtSendMessage"
		Me.txtSendMessage.Size = New System.Drawing.Size(184, 64)
		Me.txtSendMessage.TabIndex = 12
		'
		'btnSend
		'
		Me.btnSend.Location = New System.Drawing.Point(376, 320)
		Me.btnSend.Name = "btnSend"
		Me.btnSend.Size = New System.Drawing.Size(56, 24)
		Me.btnSend.TabIndex = 13
		Me.btnSend.Text = "&Send"
		Me.btnSend.UseVisualStyleBackColor = True
		'
		'txtShowMessage
		'
		Me.txtShowMessage.Location = New System.Drawing.Point(112, 8)
		Me.txtShowMessage.Multiline = True
		Me.txtShowMessage.Name = "txtShowMessage"
		Me.txtShowMessage.ReadOnly = True
		Me.txtShowMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtShowMessage.Size = New System.Drawing.Size(320, 304)
		Me.txtShowMessage.TabIndex = 18
		Me.txtShowMessage.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(112, 312)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(64, 72)
		Me.PictureBox1.TabIndex = 23
		Me.PictureBox1.TabStop = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 8)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(91, 13)
		Me.Label5.TabIndex = 24
		Me.Label5.Text = "เลือกผู้ร่วมสนทนา"
		'
		'grdOnlineUser
		'
		Me.grdOnlineUser.AllowUserToAddRows = False
		Me.grdOnlineUser.AllowUserToResizeColumns = False
		Me.grdOnlineUser.AllowUserToResizeRows = False
		Me.grdOnlineUser.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdOnlineUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdOnlineUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.username, Me.ip_address, Me.flag})
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdOnlineUser.DefaultCellStyle = DataGridViewCellStyle1
		Me.grdOnlineUser.Location = New System.Drawing.Point(8, 56)
		Me.grdOnlineUser.Name = "grdOnlineUser"
		Me.grdOnlineUser.RowHeadersWidth = 15
		Me.grdOnlineUser.Size = New System.Drawing.Size(96, 328)
		Me.grdOnlineUser.TabIndex = 44
		'
		'username
		'
		Me.username.DataPropertyName = "username"
		Me.username.HeaderText = "ผู้ร่วมสนทนา"
		Me.username.Name = "username"
		Me.username.ReadOnly = True
		Me.username.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.username.Width = 90
		'
		'ip_address
		'
		Me.ip_address.DataPropertyName = "ip_address"
		Me.ip_address.HeaderText = "ip_address"
		Me.ip_address.Name = "ip_address"
		Me.ip_address.Visible = False
		'
		'flag
		'
		Me.flag.DataPropertyName = "flag"
		Me.flag.FalseValue = "0"
		Me.flag.HeaderText = "Online"
		Me.flag.Name = "flag"
		Me.flag.ReadOnly = True
		Me.flag.TrueValue = "1"
		Me.flag.Width = 50
		'
		'btnLoad
		'
		Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
		Me.btnLoad.Location = New System.Drawing.Point(80, 24)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(24, 24)
		Me.btnLoad.TabIndex = 67
		Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(376, 344)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(59, 13)
		Me.Label1.TabIndex = 68
		Me.Label1.Text = "Ctrl + Enter"
		'
		'btnChangeWindowStyle
		'
		Me.btnChangeWindowStyle.Location = New System.Drawing.Point(416, 360)
		Me.btnChangeWindowStyle.Name = "btnChangeWindowStyle"
		Me.btnChangeWindowStyle.Size = New System.Drawing.Size(16, 24)
		Me.btnChangeWindowStyle.TabIndex = 69
		Me.btnChangeWindowStyle.Text = "1"
		Me.btnChangeWindowStyle.UseVisualStyleBackColor = True
		'
		'frmChatRoomPrivate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(441, 393)
		Me.Controls.Add(Me.btnChangeWindowStyle)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnLoad)
		Me.Controls.Add(Me.grdOnlineUser)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.cboOnlineUser)
		Me.Controls.Add(Me.txtSendMessage)
		Me.Controls.Add(Me.btnSend)
		Me.Controls.Add(Me.txtShowMessage)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmChatRoomPrivate"
		Me.Text = "Private Chat Room"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdOnlineUser, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RightClickMenu As System.Windows.Forms.ContextMenu
	Friend WithEvents mnuRestore As System.Windows.Forms.MenuItem
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents cboOnlineUser As System.Windows.Forms.ComboBox
	Friend WithEvents txtSendMessage As System.Windows.Forms.TextBox
	Friend WithEvents btnSend As System.Windows.Forms.Button
	Friend WithEvents txtShowMessage As System.Windows.Forms.TextBox
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents grdOnlineUser As System.Windows.Forms.DataGridView
	Friend WithEvents btnLoad As System.Windows.Forms.Button
	Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ip_address As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents flag As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnChangeWindowStyle As System.Windows.Forms.Button
End Class
