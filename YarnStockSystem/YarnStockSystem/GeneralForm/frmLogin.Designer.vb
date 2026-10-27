<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.txtPasswordNew = New System.Windows.Forms.TextBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.grbChangePassword = New System.Windows.Forms.GroupBox()
        Me.chbChangePassword = New System.Windows.Forms.CheckBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.cboDatabase = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grbChangePassword.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(139, 105)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(135, 22)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(139, 145)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(135, 22)
        Me.txtPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLogin.Location = New System.Drawing.Point(312, 70)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 31)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(312, 107)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "New Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Confirm Password"
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(108, 45)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(122, 22)
        Me.txtPasswordConfirm.TabIndex = 1
        '
        'txtPasswordNew
        '
        Me.txtPasswordNew.Location = New System.Drawing.Point(108, 19)
        Me.txtPasswordNew.Name = "txtPasswordNew"
        Me.txtPasswordNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordNew.Size = New System.Drawing.Size(122, 22)
        Me.txtPasswordNew.TabIndex = 0
        '
        'btnChangePassword
        '
        Me.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnChangePassword.Location = New System.Drawing.Point(128, 71)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(102, 22)
        Me.btnChangePassword.TabIndex = 11
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'grbChangePassword
        '
        Me.grbChangePassword.Controls.Add(Me.btnChangePassword)
        Me.grbChangePassword.Controls.Add(Me.txtPasswordNew)
        Me.grbChangePassword.Controls.Add(Me.txtPasswordConfirm)
        Me.grbChangePassword.Controls.Add(Me.Label6)
        Me.grbChangePassword.Controls.Add(Me.Label5)
        Me.grbChangePassword.Location = New System.Drawing.Point(137, 186)
        Me.grbChangePassword.Name = "grbChangePassword"
        Me.grbChangePassword.Size = New System.Drawing.Size(246, 100)
        Me.grbChangePassword.TabIndex = 10
        Me.grbChangePassword.TabStop = False
        '
        'chbChangePassword
        '
        Me.chbChangePassword.AutoSize = True
        Me.chbChangePassword.Location = New System.Drawing.Point(140, 173)
        Me.chbChangePassword.Name = "chbChangePassword"
        Me.chbChangePassword.Size = New System.Drawing.Size(118, 17)
        Me.chbChangePassword.TabIndex = 11
        Me.chbChangePassword.Text = "Change Password"
        Me.chbChangePassword.UseVisualStyleBackColor = True
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(244, 9)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(58, 13)
        Me.lblDatabase.TabIndex = 12
        Me.lblDatabase.Text = "Database:"
        '
        'cboDatabase
        '
        Me.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDatabase.FormattingEnabled = True
        Me.cboDatabase.Location = New System.Drawing.Point(312, 9)
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(95, 21)
        Me.cboDatabase.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "YARN STOCK SYS."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 84)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cboWarehouse
        '
        Me.cboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboWarehouse.FormattingEnabled = True
        Me.cboWarehouse.Location = New System.Drawing.Point(139, 70)
        Me.cboWarehouse.Name = "cboWarehouse"
        Me.cboWarehouse.Size = New System.Drawing.Size(134, 21)
        Me.cboWarehouse.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Warehouse:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 287)
        Me.Controls.Add(Me.cboWarehouse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDatabase)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.chbChangePassword)
        Me.Controls.Add(Me.grbChangePassword)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.grbChangePassword.ResumeLayout(False)
        Me.grbChangePassword.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPasswordConfirm As TextBox
    Friend WithEvents txtPasswordNew As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents grbChangePassword As GroupBox
    Friend WithEvents chbChangePassword As CheckBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents cboDatabase As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboWarehouse As ComboBox
    Friend WithEvents Label4 As Label
End Class
