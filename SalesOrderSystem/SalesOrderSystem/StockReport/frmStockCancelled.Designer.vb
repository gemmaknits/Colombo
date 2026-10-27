<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockCancelled
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockCancelled))
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.RadioButton8 = New System.Windows.Forms.RadioButton
		Me.RadioButton7 = New System.Windows.Forms.RadioButton
		Me.RadioButton6 = New System.Windows.Forms.RadioButton
		Me.RadioButton5 = New System.Windows.Forms.RadioButton
		Me.RadioButton4 = New System.Windows.Forms.RadioButton
		Me.RadioButton3 = New System.Windows.Forms.RadioButton
		Me.RadioButton2 = New System.Windows.Forms.RadioButton
		Me.RadioButton1 = New System.Windows.Forms.RadioButton
		Me.Label1 = New System.Windows.Forms.Label
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(305, 25)
		Me.ToolStrip1.TabIndex = 42
		'
		'btnPrint
		'
		Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
		Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(23, 22)
		Me.btnPrint.Text = "&Print"
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
		Me.btnExit.Text = "E&xit"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RadioButton8)
		Me.GroupBox1.Controls.Add(Me.RadioButton7)
		Me.GroupBox1.Controls.Add(Me.RadioButton6)
		Me.GroupBox1.Controls.Add(Me.RadioButton5)
		Me.GroupBox1.Controls.Add(Me.RadioButton4)
		Me.GroupBox1.Controls.Add(Me.RadioButton3)
		Me.GroupBox1.Controls.Add(Me.RadioButton2)
		Me.GroupBox1.Controls.Add(Me.RadioButton1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(288, 64)
		Me.GroupBox1.TabIndex = 43
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Report Type"
		'
		'RadioButton8
		'
		Me.RadioButton8.AutoSize = True
		Me.RadioButton8.Location = New System.Drawing.Point(224, 40)
		Me.RadioButton8.Name = "RadioButton8"
		Me.RadioButton8.Size = New System.Drawing.Size(58, 17)
		Me.RadioButton8.TabIndex = 7
		Me.RadioButton8.Tag = "COUT"
		Me.RadioButton8.Text = "C OUT"
		Me.RadioButton8.UseVisualStyleBackColor = True
		'
		'RadioButton7
		'
		Me.RadioButton7.AutoSize = True
		Me.RadioButton7.Location = New System.Drawing.Point(224, 16)
		Me.RadioButton7.Name = "RadioButton7"
		Me.RadioButton7.Size = New System.Drawing.Size(46, 17)
		Me.RadioButton7.TabIndex = 6
		Me.RadioButton7.Tag = "CIN"
		Me.RadioButton7.Text = "C IN"
		Me.RadioButton7.UseVisualStyleBackColor = True
		'
		'RadioButton6
		'
		Me.RadioButton6.AutoSize = True
		Me.RadioButton6.Location = New System.Drawing.Point(160, 40)
		Me.RadioButton6.Name = "RadioButton6"
		Me.RadioButton6.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton6.TabIndex = 5
		Me.RadioButton6.Tag = "DOUT"
		Me.RadioButton6.Text = "D OUT"
		Me.RadioButton6.UseVisualStyleBackColor = True
		'
		'RadioButton5
		'
		Me.RadioButton5.AutoSize = True
		Me.RadioButton5.Location = New System.Drawing.Point(160, 16)
		Me.RadioButton5.Name = "RadioButton5"
		Me.RadioButton5.Size = New System.Drawing.Size(47, 17)
		Me.RadioButton5.TabIndex = 4
		Me.RadioButton5.Tag = "DIN"
		Me.RadioButton5.Text = "D IN"
		Me.RadioButton5.UseVisualStyleBackColor = True
		'
		'RadioButton4
		'
		Me.RadioButton4.AutoSize = True
		Me.RadioButton4.Location = New System.Drawing.Point(88, 40)
		Me.RadioButton4.Name = "RadioButton4"
		Me.RadioButton4.Size = New System.Drawing.Size(59, 17)
		Me.RadioButton4.TabIndex = 3
		Me.RadioButton4.Tag = "GOUT"
		Me.RadioButton4.Text = "G OUT"
		Me.RadioButton4.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(88, 16)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(47, 17)
		Me.RadioButton3.TabIndex = 2
		Me.RadioButton3.Tag = "GIN"
		Me.RadioButton3.Text = "G IN"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(8, 40)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(73, 17)
		Me.RadioButton2.TabIndex = 1
		Me.RadioButton2.Tag = "YOUT"
		Me.RadioButton2.Text = "Yarn OUT"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(8, 16)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(61, 17)
		Me.RadioButton1.TabIndex = 0
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Tag = "YIN"
		Me.RadioButton1.Text = "Yarn IN"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(176, 104)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(20, 13)
		Me.Label1.TabIndex = 47
		Me.Label1.Text = "To"
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(72, 104)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 44
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(208, 104)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 46
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 104)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 13)
		Me.Label2.TabIndex = 45
		Me.Label2.Text = "From Date"
		'
		'frmStockCancelled
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(305, 137)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dtpDateFr)
		Me.Controls.Add(Me.dtpDateTo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmStockCancelled"
		Me.Text = "Stock Cancelled Report"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
