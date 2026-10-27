<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOutSample
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOutSample))
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.optStockC = New System.Windows.Forms.RadioButton
		Me.optStockD = New System.Windows.Forms.RadioButton
		Me.optStockG = New System.Windows.Forms.RadioButton
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.optOrderOwner = New System.Windows.Forms.RadioButton
		Me.optOrderDesignNo = New System.Windows.Forms.RadioButton
		Me.optOrderDate = New System.Windows.Forms.RadioButton
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(232, 32)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 30
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(329, 25)
		Me.ToolStrip1.TabIndex = 32
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
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label6.Location = New System.Drawing.Point(8, 168)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(320, 32)
		Me.Label6.TabIndex = 31
		Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 13)
		Me.Label2.TabIndex = 29
		Me.Label2.Text = "From Date"
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(80, 32)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(192, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(20, 13)
		Me.Label1.TabIndex = 34
		Me.Label1.Text = "To"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.optStockC)
		Me.GroupBox3.Controls.Add(Me.optStockD)
		Me.GroupBox3.Controls.Add(Me.optStockG)
		Me.GroupBox3.Location = New System.Drawing.Point(8, 56)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(312, 48)
		Me.GroupBox3.TabIndex = 36
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Stock Type"
		'
		'optStockC
		'
		Me.optStockC.AutoSize = True
		Me.optStockC.Location = New System.Drawing.Point(216, 16)
		Me.optStockC.Name = "optStockC"
		Me.optStockC.Size = New System.Drawing.Size(63, 17)
		Me.optStockC.TabIndex = 24
		Me.optStockC.Text = "Stock C"
		Me.optStockC.UseVisualStyleBackColor = True
		'
		'optStockD
		'
		Me.optStockD.AutoSize = True
		Me.optStockD.Location = New System.Drawing.Point(120, 16)
		Me.optStockD.Name = "optStockD"
		Me.optStockD.Size = New System.Drawing.Size(64, 17)
		Me.optStockD.TabIndex = 9
		Me.optStockD.Text = "Stock D"
		Me.optStockD.UseVisualStyleBackColor = True
		'
		'optStockG
		'
		Me.optStockG.AutoSize = True
		Me.optStockG.Checked = True
		Me.optStockG.Location = New System.Drawing.Point(16, 16)
		Me.optStockG.Name = "optStockG"
		Me.optStockG.Size = New System.Drawing.Size(64, 17)
		Me.optStockG.TabIndex = 8
		Me.optStockG.TabStop = True
		Me.optStockG.Text = "Stock G"
		Me.optStockG.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.optOrderOwner)
		Me.GroupBox2.Controls.Add(Me.optOrderDesignNo)
		Me.GroupBox2.Controls.Add(Me.optOrderDate)
		Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(312, 48)
		Me.GroupBox2.TabIndex = 35
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Order By"
		'
		'optOrderOwner
		'
		Me.optOrderOwner.AutoSize = True
		Me.optOrderOwner.Location = New System.Drawing.Point(216, 16)
		Me.optOrderOwner.Name = "optOrderOwner"
		Me.optOrderOwner.Size = New System.Drawing.Size(56, 17)
		Me.optOrderOwner.TabIndex = 24
		Me.optOrderOwner.Text = "Owner"
		Me.optOrderOwner.UseVisualStyleBackColor = True
		'
		'optOrderDesignNo
		'
		Me.optOrderDesignNo.AutoSize = True
		Me.optOrderDesignNo.Checked = True
		Me.optOrderDesignNo.Location = New System.Drawing.Point(120, 16)
		Me.optOrderDesignNo.Name = "optOrderDesignNo"
		Me.optOrderDesignNo.Size = New System.Drawing.Size(78, 17)
		Me.optOrderDesignNo.TabIndex = 9
		Me.optOrderDesignNo.TabStop = True
		Me.optOrderDesignNo.Text = "Design No."
		Me.optOrderDesignNo.UseVisualStyleBackColor = True
		'
		'optOrderDate
		'
		Me.optOrderDate.AutoSize = True
		Me.optOrderDate.Location = New System.Drawing.Point(16, 16)
		Me.optOrderDate.Name = "optOrderDate"
		Me.optOrderDate.Size = New System.Drawing.Size(74, 17)
		Me.optOrderDate.TabIndex = 8
		Me.optOrderDate.Text = "Doc. Date"
		Me.optOrderDate.UseVisualStyleBackColor = True
		'
		'frmStockOutSample
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(329, 201)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dtpDateFr)
		Me.Controls.Add(Me.dtpDateTo)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmStockOutSample"
		Me.Text = "Stock Out For Sample"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents optStockC As System.Windows.Forms.RadioButton
	Friend WithEvents optStockD As System.Windows.Forms.RadioButton
	Friend WithEvents optStockG As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents optOrderOwner As System.Windows.Forms.RadioButton
	Friend WithEvents optOrderDesignNo As System.Windows.Forms.RadioButton
	Friend WithEvents optOrderDate As System.Windows.Forms.RadioButton
End Class
