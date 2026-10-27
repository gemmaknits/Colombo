<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChatRoom
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
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChatRoom))
		Me.cboOnlineUser = New System.Windows.Forms.ComboBox
		Me.txtShowMessage = New System.Windows.Forms.TextBox
		Me.txtSendMessage = New System.Windows.Forms.TextBox
		Me.btnSend = New System.Windows.Forms.Button
		Me.btnAlert = New System.Windows.Forms.Button
		Me.btnClear = New System.Windows.Forms.Button
		Me.btnSendAll = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnChangeWindowStyle = New System.Windows.Forms.Button
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cboOnlineUser
		'
		Me.cboOnlineUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOnlineUser.FormattingEnabled = True
		Me.cboOnlineUser.Location = New System.Drawing.Point(80, 320)
		Me.cboOnlineUser.Name = "cboOnlineUser"
		Me.cboOnlineUser.Size = New System.Drawing.Size(72, 21)
		Me.cboOnlineUser.TabIndex = 5
		'
		'txtShowMessage
		'
		Me.txtShowMessage.Location = New System.Drawing.Point(8, 8)
		Me.txtShowMessage.Multiline = True
		Me.txtShowMessage.Name = "txtShowMessage"
		Me.txtShowMessage.ReadOnly = True
		Me.txtShowMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtShowMessage.Size = New System.Drawing.Size(320, 304)
		Me.txtShowMessage.TabIndex = 6
		Me.txtShowMessage.TabStop = False
		'
		'txtSendMessage
		'
		Me.txtSendMessage.Location = New System.Drawing.Point(152, 320)
		Me.txtSendMessage.Name = "txtSendMessage"
		Me.txtSendMessage.Size = New System.Drawing.Size(160, 20)
		Me.txtSendMessage.TabIndex = 0
		'
		'btnSend
		'
		Me.btnSend.Location = New System.Drawing.Point(80, 344)
		Me.btnSend.Name = "btnSend"
		Me.btnSend.Size = New System.Drawing.Size(56, 24)
		Me.btnSend.TabIndex = 1
		Me.btnSend.Text = "&Send"
		Me.btnSend.UseVisualStyleBackColor = True
		'
		'btnAlert
		'
		Me.btnAlert.Location = New System.Drawing.Point(208, 344)
		Me.btnAlert.Name = "btnAlert"
		Me.btnAlert.Size = New System.Drawing.Size(56, 24)
		Me.btnAlert.TabIndex = 3
		Me.btnAlert.Text = "&Alert"
		Me.btnAlert.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(272, 344)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(56, 24)
		Me.btnClear.TabIndex = 4
		Me.btnClear.Text = "&Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnSendAll
		'
		Me.btnSendAll.Location = New System.Drawing.Point(144, 344)
		Me.btnSendAll.Name = "btnSendAll"
		Me.btnSendAll.Size = New System.Drawing.Size(56, 24)
		Me.btnSendAll.TabIndex = 2
		Me.btnSendAll.Text = "Send A&ll"
		Me.btnSendAll.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(88, 368)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(32, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Enter"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(136, 368)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Shift + Enter"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(208, 368)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(59, 13)
		Me.Label3.TabIndex = 9
		Me.Label3.Text = "Ctrl + Enter"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(280, 368)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(41, 13)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "Ctrl + C"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(8, 312)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(64, 72)
		Me.PictureBox1.TabIndex = 11
		Me.PictureBox1.TabStop = False
		'
		'btnChangeWindowStyle
		'
		Me.btnChangeWindowStyle.Location = New System.Drawing.Point(312, 320)
		Me.btnChangeWindowStyle.Name = "btnChangeWindowStyle"
		Me.btnChangeWindowStyle.Size = New System.Drawing.Size(16, 24)
		Me.btnChangeWindowStyle.TabIndex = 12
		Me.btnChangeWindowStyle.Text = "1"
		Me.btnChangeWindowStyle.UseVisualStyleBackColor = True
		'
		'frmChatRoom
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(337, 385)
		Me.Controls.Add(Me.btnChangeWindowStyle)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnSendAll)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAlert)
		Me.Controls.Add(Me.cboOnlineUser)
		Me.Controls.Add(Me.txtSendMessage)
		Me.Controls.Add(Me.btnSend)
		Me.Controls.Add(Me.txtShowMessage)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmChatRoom"
		Me.Text = "Chat Room"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents cboOnlineUser As System.Windows.Forms.ComboBox
	Friend WithEvents txtShowMessage As System.Windows.Forms.TextBox
	Friend WithEvents txtSendMessage As System.Windows.Forms.TextBox
	Friend WithEvents btnSend As System.Windows.Forms.Button
	Friend WithEvents btnAlert As System.Windows.Forms.Button
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnSendAll As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents btnChangeWindowStyle As System.Windows.Forms.Button
End Class
