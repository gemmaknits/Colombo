<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceSearchPacking
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceSearchPacking))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnRefresh = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.txtSoNo = New System.Windows.Forms.TextBox
		Me.optStockC = New System.Windows.Forms.RadioButton
		Me.optStockD = New System.Windows.Forms.RadioButton
		Me.optStockG = New System.Windows.Forms.RadioButton
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.Label1 = New System.Windows.Forms.Label
		Me.cboCustomer = New System.Windows.Forms.ComboBox
		Me.txtPackNo = New System.Windows.Forms.TextBox
		Me.btnRefresh2 = New System.Windows.Forms.Button
		Me.grdInv = New System.Windows.Forms.DataGridView
		Me.packno_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.packdt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.pono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.grdInv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(481, 25)
		Me.ToolStrip1.TabIndex = 16
		'
		'btnRefresh
		'
		Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
		Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
		Me.btnRefresh.Text = "&Refresh"
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
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.txtSoNo)
		Me.GroupBox1.Controls.Add(Me.optStockC)
		Me.GroupBox1.Controls.Add(Me.optStockD)
		Me.GroupBox1.Controls.Add(Me.optStockG)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cboCustomer)
		Me.GroupBox1.Controls.Add(Me.txtPackNo)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(336, 112)
		Me.GroupBox1.TabIndex = 17
		Me.GroupBox1.TabStop = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(184, 88)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(47, 13)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "S/O No."
		'
		'txtSoNo
		'
		Me.txtSoNo.Location = New System.Drawing.Point(240, 88)
		Me.txtSoNo.Name = "txtSoNo"
		Me.txtSoNo.Size = New System.Drawing.Size(88, 20)
		Me.txtSoNo.TabIndex = 22
		'
		'optStockC
		'
		Me.optStockC.AutoSize = True
		Me.optStockC.Location = New System.Drawing.Point(256, 16)
		Me.optStockC.Name = "optStockC"
		Me.optStockC.Size = New System.Drawing.Size(56, 17)
		Me.optStockC.TabIndex = 21
		Me.optStockC.Text = "Cutted"
		Me.optStockC.UseVisualStyleBackColor = True
		'
		'optStockD
		'
		Me.optStockD.AutoSize = True
		Me.optStockD.Location = New System.Drawing.Point(176, 16)
		Me.optStockD.Name = "optStockD"
		Me.optStockD.Size = New System.Drawing.Size(50, 17)
		Me.optStockD.TabIndex = 20
		Me.optStockD.Text = "Dyed"
		Me.optStockD.UseVisualStyleBackColor = True
		'
		'optStockG
		'
		Me.optStockG.AutoSize = True
		Me.optStockG.Checked = True
		Me.optStockG.Location = New System.Drawing.Point(88, 16)
		Me.optStockG.Name = "optStockG"
		Me.optStockG.Size = New System.Drawing.Size(56, 17)
		Me.optStockG.TabIndex = 19
		Me.optStockG.TabStop = True
		Me.optStockG.Text = "Greige"
		Me.optStockG.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 13)
		Me.Label5.TabIndex = 18
		Me.Label5.Text = "Stock Type"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 88)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(66, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Packing No."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(184, 64)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "To"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Packing Date"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(240, 64)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 14
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(88, 64)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 13
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Customer"
		'
		'cboCustomer
		'
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(88, 40)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(240, 21)
		Me.cboCustomer.TabIndex = 11
		'
		'txtPackNo
		'
		Me.txtPackNo.Location = New System.Drawing.Point(88, 88)
		Me.txtPackNo.Name = "txtPackNo"
		Me.txtPackNo.Size = New System.Drawing.Size(88, 20)
		Me.txtPackNo.TabIndex = 10
		'
		'btnRefresh2
		'
		Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
		Me.btnRefresh2.Location = New System.Drawing.Point(352, 40)
		Me.btnRefresh2.Name = "btnRefresh2"
		Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
		Me.btnRefresh2.TabIndex = 20
		Me.btnRefresh2.Text = "&Refresh"
		Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnRefresh2.UseVisualStyleBackColor = True
		'
		'grdInv
		'
		Me.grdInv.AllowUserToAddRows = False
		Me.grdInv.AllowUserToDeleteRows = False
		Me.grdInv.AllowUserToOrderColumns = True
		Me.grdInv.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.packno_cartno, Me.packdt, Me.sonoid, Me.custname, Me.pono, Me.design_no, Me.gwth})
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdInv.DefaultCellStyle = DataGridViewCellStyle1
		Me.grdInv.Location = New System.Drawing.Point(8, 152)
		Me.grdInv.Name = "grdInv"
		Me.grdInv.ReadOnly = True
		Me.grdInv.Size = New System.Drawing.Size(464, 288)
		Me.grdInv.TabIndex = 21
		'
		'packno_cartno
		'
		Me.packno_cartno.DataPropertyName = "packno_cartno"
		Me.packno_cartno.HeaderText = "Pack No. / Carton No."
		Me.packno_cartno.Name = "packno_cartno"
		Me.packno_cartno.ReadOnly = True
		Me.packno_cartno.Width = 85
		'
		'packdt
		'
		Me.packdt.DataPropertyName = "packdt2"
		Me.packdt.HeaderText = "Pack Date"
		Me.packdt.Name = "packdt"
		Me.packdt.ReadOnly = True
		Me.packdt.Width = 85
		'
		'sonoid
		'
		Me.sonoid.DataPropertyName = "sonoid"
		Me.sonoid.HeaderText = "S/O No."
		Me.sonoid.Name = "sonoid"
		Me.sonoid.ReadOnly = True
		Me.sonoid.Width = 85
		'
		'custname
		'
		Me.custname.DataPropertyName = "custname"
		Me.custname.HeaderText = "Customer"
		Me.custname.Name = "custname"
		Me.custname.ReadOnly = True
		Me.custname.Width = 150
		'
		'pono
		'
		Me.pono.DataPropertyName = "pono"
		Me.pono.HeaderText = "P/O No."
		Me.pono.Name = "pono"
		Me.pono.ReadOnly = True
		'
		'design_no
		'
		Me.design_no.DataPropertyName = "design_no"
		Me.design_no.HeaderText = "Design No."
		Me.design_no.Name = "design_no"
		Me.design_no.ReadOnly = True
		'
		'gwth
		'
		Me.gwth.DataPropertyName = "gwth"
		Me.gwth.HeaderText = "Gwth"
		Me.gwth.Name = "gwth"
		Me.gwth.ReadOnly = True
		Me.gwth.Width = 50
		'
		'FormInvoiceLocalSearchPacking
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(481, 449)
		Me.Controls.Add(Me.grdInv)
		Me.Controls.Add(Me.btnRefresh2)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormInvoiceLocalSearchPacking"
		Me.Text = "Packing Search"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.grdInv, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
	Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
	Friend WithEvents grdInv As System.Windows.Forms.DataGridView
	Friend WithEvents optStockC As System.Windows.Forms.RadioButton
	Friend WithEvents optStockD As System.Windows.Forms.RadioButton
	Friend WithEvents optStockG As System.Windows.Forms.RadioButton
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents txtSoNo As System.Windows.Forms.TextBox
	Friend WithEvents packno_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents packdt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents pono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
