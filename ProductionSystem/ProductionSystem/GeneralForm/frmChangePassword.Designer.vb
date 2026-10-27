<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtOldPassword = New System.Windows.Forms.TextBox
		Me.txtNewPassword = New System.Windows.Forms.TextBox
		Me.txtConfirmPassword = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Old Password"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(78, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "New Password"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Confirm New Password"
		'
		'txtOldPassword
		'
		Me.txtOldPassword.Location = New System.Drawing.Point(136, 32)
		Me.txtOldPassword.Name = "txtOldPassword"
		Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtOldPassword.Size = New System.Drawing.Size(128, 20)
		Me.txtOldPassword.TabIndex = 0
		'
		'txtNewPassword
		'
		Me.txtNewPassword.Location = New System.Drawing.Point(136, 56)
		Me.txtNewPassword.Name = "txtNewPassword"
		Me.txtNewPassword.Size = New System.Drawing.Size(128, 20)
		Me.txtNewPassword.TabIndex = 1
		'
		'txtConfirmPassword
		'
		Me.txtConfirmPassword.Location = New System.Drawing.Point(136, 80)
		Me.txtConfirmPassword.Name = "txtConfirmPassword"
		Me.txtConfirmPassword.Size = New System.Drawing.Size(128, 20)
		Me.txtConfirmPassword.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Red
		Me.Label4.Location = New System.Drawing.Point(8, 104)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(251, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "***Case Insensitive (ตัวพิมพ์ใหญ่และเล็กมีค่าเท่ากัน)"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Red
		Me.Label5.Location = New System.Drawing.Point(7, 128)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(261, 13)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "***Use English Only (ใช้ภาษาอังกฤษและตัวเลขเท่านั้น)"
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(273, 25)
		Me.ToolStrip1.TabIndex = 17
		'
		'btnSave
		'
		Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
		Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(23, 22)
		Me.btnSave.Text = "Save"
		'
		'btnMinimized
		'
		Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
		Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnMinimized.Name = "btnMinimized"
		Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
		Me.btnMinimized.Text = "Minimized"
		'
		'btnExit
		'
		Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
		Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(23, 22)
		Me.btnExit.Text = "Exit"
		'
		'frmChangePassword
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(273, 153)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtConfirmPassword)
		Me.Controls.Add(Me.txtNewPassword)
		Me.Controls.Add(Me.txtOldPassword)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmChangePassword"
		Me.Text = "Change Password"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
	Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
	Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
End Class
