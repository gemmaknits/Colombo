<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockCOnhand
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockCOnhand))
		Me.txtDesignNo = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.txtRptWth = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.txtAB = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtGr = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtQtyFr = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.txtQtyTo = New System.Windows.Forms.TextBox
		Me.cboUOM = New System.Windows.Forms.ComboBox
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.cboColor = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtDesignNo
		'
		Me.txtDesignNo.Location = New System.Drawing.Point(72, 32)
		Me.txtDesignNo.Name = "txtDesignNo"
		Me.txtDesignNo.Size = New System.Drawing.Size(120, 20)
		Me.txtDesignNo.TabIndex = 25
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(8, 32)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(60, 13)
		Me.Label7.TabIndex = 24
		Me.Label7.Text = "Design No."
		'
		'txtRptWth
		'
		Me.txtRptWth.Location = New System.Drawing.Point(120, 56)
		Me.txtRptWth.Name = "txtRptWth"
		Me.txtRptWth.Size = New System.Drawing.Size(72, 20)
		Me.txtRptWth.TabIndex = 27
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(101, 13)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Repeat Width (cms)"
		'
		'txtAB
		'
		Me.txtAB.Location = New System.Drawing.Point(120, 80)
		Me.txtAB.Name = "txtAB"
		Me.txtAB.Size = New System.Drawing.Size(72, 20)
		Me.txtAB.TabIndex = 29
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 80)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 13)
		Me.Label2.TabIndex = 28
		Me.Label2.Text = "Allover / Band (A/B)"
		'
		'txtGr
		'
		Me.txtGr.Location = New System.Drawing.Point(120, 104)
		Me.txtGr.Name = "txtGr"
		Me.txtGr.Size = New System.Drawing.Size(72, 20)
		Me.txtGr.TabIndex = 31
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 104)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(36, 13)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Grade"
		'
		'txtQtyFr
		'
		Me.txtQtyFr.Location = New System.Drawing.Point(72, 128)
		Me.txtQtyFr.Name = "txtQtyFr"
		Me.txtQtyFr.Size = New System.Drawing.Size(40, 20)
		Me.txtQtyFr.TabIndex = 33
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 128)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 13)
		Me.Label4.TabIndex = 32
		Me.Label4.Text = "Qty. From "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(120, 128)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(20, 13)
		Me.Label5.TabIndex = 34
		Me.Label5.Text = "To"
		'
		'txtQtyTo
		'
		Me.txtQtyTo.Location = New System.Drawing.Point(152, 128)
		Me.txtQtyTo.Name = "txtQtyTo"
		Me.txtQtyTo.Size = New System.Drawing.Size(40, 20)
		Me.txtQtyTo.TabIndex = 35
		'
		'cboUOM
		'
		Me.cboUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboUOM.FormattingEnabled = True
		Me.cboUOM.Location = New System.Drawing.Point(200, 128)
		Me.cboUOM.Name = "cboUOM"
		Me.cboUOM.Size = New System.Drawing.Size(56, 21)
		Me.cboUOM.TabIndex = 36
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(265, 25)
		Me.ToolStrip1.TabIndex = 37
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
		'cboColor
		'
		Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboColor.FormattingEnabled = True
		Me.cboColor.Location = New System.Drawing.Point(72, 152)
		Me.cboColor.Name = "cboColor"
		Me.cboColor.Size = New System.Drawing.Size(120, 21)
		Me.cboColor.TabIndex = 38
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(8, 152)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(31, 13)
		Me.Label6.TabIndex = 39
		Me.Label6.Text = "Color"
		'
		'frmStockCOnhand
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(265, 186)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.cboColor)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.cboUOM)
		Me.Controls.Add(Me.txtQtyTo)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtQtyFr)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtGr)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtAB)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtRptWth)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtDesignNo)
		Me.Controls.Add(Me.Label7)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmStockCOnhand"
		Me.Text = "C - Onhand"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents txtRptWth As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtAB As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtGr As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtQtyFr As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents txtQtyTo As System.Windows.Forms.TextBox
	Friend WithEvents cboUOM As System.Windows.Forms.ComboBox
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents cboColor As System.Windows.Forms.ComboBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
