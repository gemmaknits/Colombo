<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataEntry
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso Components IsNot Nothing Then
			Components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	<System.Diagnostics.DebuggerNonUserCode()> _
	   Public Sub New(ByVal Container As System.ComponentModel.IContainer)
		MyClass.New()

		'Required for Windows.Forms Class Composition Designer support
		Container.Add(Me)

	End Sub

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()

	End Sub

	'Required by the Windows Form Designer
	Public Components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataEntry))
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.lblDocNo = New System.Windows.Forms.ToolStripLabel
		Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.btnNew = New System.Windows.Forms.ToolStripButton
		Me.btnSearch = New System.Windows.Forms.ToolStripButton
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnCancel = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.btnHelp = New System.Windows.Forms.ToolStripButton
		Me.lblRemark = New System.Windows.Forms.ToolStripLabel
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.lblCancelled = New System.Windows.Forms.Label
		Me.dtpDocDate = New System.Windows.Forms.DateTimePicker
		Me.txtDocNo = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.grdDetails = New System.Windows.Forms.DataGridView
		Me.invord = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.pono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.uom = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.uprice = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.lineamt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.linediscamt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.linenetamt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDocNo, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.btnHelp, Me.lblRemark})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(541, 25)
		Me.ToolStrip1.TabIndex = 139
		'
		'lblDocNo
		'
		Me.lblDocNo.Name = "lblDocNo"
		Me.lblDocNo.Size = New System.Drawing.Size(75, 22)
		Me.lblDocNo.Text = "Document No."
		'
		'cboDocNo
		'
		Me.cboDocNo.Name = "cboDocNo"
		Me.cboDocNo.Size = New System.Drawing.Size(150, 25)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'btnNew
		'
		Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
		Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnNew.Name = "btnNew"
		Me.btnNew.Size = New System.Drawing.Size(23, 22)
		Me.btnNew.Text = "New"
		'
		'btnSearch
		'
		Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
		Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(23, 22)
		Me.btnSearch.Text = "Search"
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
		'btnPrint
		'
		Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
		Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(23, 22)
		Me.btnPrint.Text = "Print"
		'
		'btnCancel
		'
		Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
		Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(23, 22)
		Me.btnCancel.Text = "Cancel Document"
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
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'btnHelp
		'
		Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
		Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnHelp.Name = "btnHelp"
		Me.btnHelp.Size = New System.Drawing.Size(23, 22)
		Me.btnHelp.Text = "He&lp"
		'
		'lblRemark
		'
		Me.lblRemark.ForeColor = System.Drawing.Color.Red
		Me.lblRemark.Name = "lblRemark"
		Me.lblRemark.Size = New System.Drawing.Size(0, 22)
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblCancelled)
		Me.GroupBox1.Controls.Add(Me.dtpDocDate)
		Me.GroupBox1.Controls.Add(Me.txtDocNo)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(168, 88)
		Me.GroupBox1.TabIndex = 140
		Me.GroupBox1.TabStop = False
		'
		'lblCancelled
		'
		Me.lblCancelled.AutoSize = True
		Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.lblCancelled.ForeColor = System.Drawing.Color.Red
		Me.lblCancelled.Location = New System.Drawing.Point(40, 0)
		Me.lblCancelled.Name = "lblCancelled"
		Me.lblCancelled.Size = New System.Drawing.Size(88, 20)
		Me.lblCancelled.TabIndex = 141
		Me.lblCancelled.Text = "Cancelled"
		'
		'dtpDocDate
		'
		Me.dtpDocDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDocDate.Location = New System.Drawing.Point(64, 56)
		Me.dtpDocDate.Name = "dtpDocDate"
		Me.dtpDocDate.Size = New System.Drawing.Size(96, 20)
		Me.dtpDocDate.TabIndex = 3
		'
		'txtDocNo
		'
		Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtDocNo.Location = New System.Drawing.Point(64, 32)
		Me.txtDocNo.Name = "txtDocNo"
		Me.txtDocNo.Size = New System.Drawing.Size(96, 20)
		Me.txtDocNo.TabIndex = 2
		Me.txtDocNo.Text = "GO07100001"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Doc Date"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Doc No."
		'
		'grdDetails
		'
		Me.grdDetails.AllowUserToAddRows = False
		Me.grdDetails.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invord, Me.pono, Me.sono, Me.sonoid, Me.design_no, Me.col, Me.grade, Me.qty, Me.uom, Me.uprice, Me.lineamt, Me.linediscamt, Me.linenetamt})
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdDetails.DefaultCellStyle = DataGridViewCellStyle7
		Me.grdDetails.Location = New System.Drawing.Point(8, 128)
		Me.grdDetails.Name = "grdDetails"
		Me.grdDetails.Size = New System.Drawing.Size(520, 216)
		Me.grdDetails.TabIndex = 141
		'
		'invord
		'
		Me.invord.DataPropertyName = "invord"
		Me.invord.HeaderText = "#"
		Me.invord.Name = "invord"
		Me.invord.Width = 20
		'
		'pono
		'
		Me.pono.DataPropertyName = "pono"
		Me.pono.HeaderText = "Customer P/O No."
		Me.pono.Name = "pono"
		Me.pono.ReadOnly = True
		Me.pono.Width = 60
		'
		'sono
		'
		Me.sono.DataPropertyName = "sono"
		Me.sono.HeaderText = "S/O No."
		Me.sono.Name = "sono"
		Me.sono.ReadOnly = True
		Me.sono.Width = 60
		'
		'sonoid
		'
		Me.sonoid.DataPropertyName = "sonoid"
		Me.sonoid.HeaderText = "S/O Item No."
		Me.sonoid.Name = "sonoid"
		Me.sonoid.ReadOnly = True
		Me.sonoid.Width = 70
		'
		'design_no
		'
		Me.design_no.DataPropertyName = "cust_design"
		Me.design_no.HeaderText = "Design No."
		Me.design_no.Name = "design_no"
		Me.design_no.ReadOnly = True
		Me.design_no.Width = 75
		'
		'col
		'
		Me.col.DataPropertyName = "col"
		Me.col.HeaderText = "Color"
		Me.col.Name = "col"
		Me.col.ReadOnly = True
		Me.col.Width = 50
		'
		'grade
		'
		Me.grade.DataPropertyName = "grade"
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.grade.DefaultCellStyle = DataGridViewCellStyle1
		Me.grade.HeaderText = "Gr"
		Me.grade.Name = "grade"
		Me.grade.ReadOnly = True
		Me.grade.Width = 25
		'
		'qty
		'
		Me.qty.DataPropertyName = "qty"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle2.Format = "#.#0"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.qty.DefaultCellStyle = DataGridViewCellStyle2
		Me.qty.HeaderText = "Qty."
		Me.qty.Name = "qty"
		Me.qty.Width = 50
		'
		'uom
		'
		Me.uom.DataPropertyName = "uom"
		Me.uom.HeaderText = "UOM"
		Me.uom.Name = "uom"
		Me.uom.ReadOnly = True
		Me.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.uom.Width = 50
		'
		'uprice
		'
		Me.uprice.DataPropertyName = "uprice"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle3.Format = "#.#0"
		DataGridViewCellStyle3.NullValue = Nothing
		Me.uprice.DefaultCellStyle = DataGridViewCellStyle3
		Me.uprice.HeaderText = "Unit Price"
		Me.uprice.Name = "uprice"
		Me.uprice.Width = 50
		'
		'lineamt
		'
		Me.lineamt.DataPropertyName = "lineamt"
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle4.Format = "#.###0"
		Me.lineamt.DefaultCellStyle = DataGridViewCellStyle4
		Me.lineamt.HeaderText = "Amout"
		Me.lineamt.Name = "lineamt"
		Me.lineamt.ReadOnly = True
		Me.lineamt.Width = 65
		'
		'linediscamt
		'
		Me.linediscamt.DataPropertyName = "linediscamt"
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle5.Format = "#.###0"
		Me.linediscamt.DefaultCellStyle = DataGridViewCellStyle5
		Me.linediscamt.HeaderText = "Item Discount Amount"
		Me.linediscamt.Name = "linediscamt"
		Me.linediscamt.ReadOnly = True
		Me.linediscamt.Width = 65
		'
		'linenetamt
		'
		Me.linenetamt.DataPropertyName = "linenetamt"
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle6.Format = "#.###0"
		Me.linenetamt.DefaultCellStyle = DataGridViewCellStyle6
		Me.linenetamt.HeaderText = "Item Net Amount"
		Me.linenetamt.Name = "linenetamt"
		Me.linenetamt.ReadOnly = True
		Me.linenetamt.Width = 65
		'
		'frmDataEntry
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(541, 371)
		Me.Controls.Add(Me.grdDetails)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDataEntry"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "frmDataEntry"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents lblDocNo As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
	Friend WithEvents lblRemark As System.Windows.Forms.ToolStripLabel
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblCancelled As System.Windows.Forms.Label
	Friend WithEvents grdDetails As System.Windows.Forms.DataGridView
	Friend WithEvents invord As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents pono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents sono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents grade As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents uom As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents uprice As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents lineamt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents linediscamt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents linenetamt As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
