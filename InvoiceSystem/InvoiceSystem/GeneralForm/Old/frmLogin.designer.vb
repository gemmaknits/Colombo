<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.TextBox2 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Button1 = New System.Windows.Forms.Button
		Me.Button2 = New System.Windows.Forms.Button
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Location = New System.Drawing.Point(28, 18)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(87, 84)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(124, 37)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(135, 20)
		Me.TextBox1.TabIndex = 1
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(124, 82)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox2.Size = New System.Drawing.Size(135, 20)
		Me.TextBox2.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(121, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "User name:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(121, 66)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Password:"
		'
		'Button1
		'
		Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button1.Location = New System.Drawing.Point(287, 31)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(74, 31)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
		Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Button2.Location = New System.Drawing.Point(286, 66)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 32)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Exit"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'formLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(373, 136)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "formLogin"
		Me.Text = "Login"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
