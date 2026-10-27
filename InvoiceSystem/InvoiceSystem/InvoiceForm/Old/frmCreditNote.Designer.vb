<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditNote
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreditNote))
		Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
		Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.btnNew = New System.Windows.Forms.ToolStripButton
		Me.btnSearch = New System.Windows.Forms.ToolStripButton
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnApprove = New System.Windows.Forms.ToolStripButton
		Me.btnCancel = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.dtpDocDate = New System.Windows.Forms.DateTimePicker
		Me.Label28 = New System.Windows.Forms.Label
		Me.txtDocNo = New System.Windows.Forms.TextBox
		Me.Label29 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.txtStatus = New System.Windows.Forms.TextBox
		Me.cboInvNo = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.grdDetails = New System.Windows.Forms.DataGridView
		Me.invord = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.return_goods = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.stk_in_no = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.pono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.roll_cnt = New System.Windows.Forms.DataGridViewTextBoxColumn
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
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtCustomer = New System.Windows.Forms.TextBox
		Me.txtReference = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.cboReason = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.cboReason2 = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.cboReason3 = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.txtGrossAmt = New System.Windows.Forms.TextBox
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.txtVat = New System.Windows.Forms.TextBox
		Me.txtNetAmt = New System.Windows.Forms.TextBox
		Me.txtVatAmt = New System.Windows.Forms.TextBox
		Me.txtPreTaxAmt = New System.Windows.Forms.TextBox
		Me.txtDiscAmt = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.txtRemarks = New System.Windows.Forms.TextBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.cboStkINNo = New System.Windows.Forms.ComboBox
		Me.btnLoadINV = New System.Windows.Forms.Button
		Me.btnLoadStkIN = New System.Windows.Forms.Button
		Me.ToolStrip1.SuspendLayout()
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnApprove, Me.btnCancel, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(777, 25)
		Me.ToolStrip1.TabIndex = 29
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
		Me.ToolStripLabel1.Text = "Credit Note No."
		'
		'cboDocNo
		'
		Me.cboDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDocNo.Name = "cboDocNo"
		Me.cboDocNo.Size = New System.Drawing.Size(100, 25)
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
		'btnApprove
		'
		Me.btnApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
		Me.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnApprove.Name = "btnApprove"
		Me.btnApprove.Size = New System.Drawing.Size(23, 22)
		Me.btnApprove.Text = "ToolStripButton1"
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
		'dtpDocDate
		'
		Me.dtpDocDate.AccessibleName = "crnote_date"
		Me.dtpDocDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDocDate.Location = New System.Drawing.Point(680, 56)
		Me.dtpDocDate.Name = "dtpDocDate"
		Me.dtpDocDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpDocDate.TabIndex = 31
		Me.dtpDocDate.Tag = ""
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(584, 56)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(86, 13)
		Me.Label28.TabIndex = 33
		Me.Label28.Text = "Credit Note Date"
		'
		'txtDocNo
		'
		Me.txtDocNo.AccessibleName = "crnote_no"
		Me.txtDocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtDocNo.Location = New System.Drawing.Point(680, 32)
		Me.txtDocNo.Name = "txtDocNo"
		Me.txtDocNo.Size = New System.Drawing.Size(88, 20)
		Me.txtDocNo.TabIndex = 30
		Me.txtDocNo.Tag = ""
		Me.txtDocNo.Text = "CN-07050020"
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(592, 32)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(80, 13)
		Me.Label29.TabIndex = 32
		Me.Label29.Text = "Credit Note No."
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(632, 80)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(37, 13)
		Me.Label1.TabIndex = 35
		Me.Label1.Text = "Status"
		'
		'txtStatus
		'
		Me.txtStatus.AccessibleName = "show_status"
		Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtStatus.Location = New System.Drawing.Point(680, 80)
		Me.txtStatus.Name = "txtStatus"
		Me.txtStatus.ReadOnly = True
		Me.txtStatus.Size = New System.Drawing.Size(88, 20)
		Me.txtStatus.TabIndex = 36
		Me.txtStatus.Tag = ""
		Me.txtStatus.Text = "CANCELLED"
		'
		'cboInvNo
		'
		Me.cboInvNo.AccessibleDescription = ""
		Me.cboInvNo.AccessibleName = "invid2"
		Me.cboInvNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboInvNo.FormattingEnabled = True
		Me.cboInvNo.Location = New System.Drawing.Point(80, 32)
		Me.cboInvNo.Name = "cboInvNo"
		Me.cboInvNo.Size = New System.Drawing.Size(112, 21)
		Me.cboInvNo.TabIndex = 37
		Me.cboInvNo.Tag = ""
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(62, 13)
		Me.Label2.TabIndex = 38
		Me.Label2.Text = "Invoice No."
		'
		'grdDetails
		'
		Me.grdDetails.AllowUserToAddRows = False
		Me.grdDetails.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invord, Me.return_goods, Me.stk_in_no, Me.pono, Me.roll_cnt, Me.sono, Me.sonoid, Me.design_no, Me.col, Me.grade, Me.qty, Me.uom, Me.uprice, Me.lineamt, Me.linediscamt, Me.linenetamt})
		DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdDetails.DefaultCellStyle = DataGridViewCellStyle14
		Me.grdDetails.Location = New System.Drawing.Point(8, 136)
		Me.grdDetails.Name = "grdDetails"
		Me.grdDetails.Size = New System.Drawing.Size(760, 192)
		Me.grdDetails.TabIndex = 39
		'
		'invord
		'
		Me.invord.DataPropertyName = "invord"
		Me.invord.HeaderText = "#"
		Me.invord.Name = "invord"
		Me.invord.Width = 20
		'
		'return_goods
		'
		Me.return_goods.DataPropertyName = "return_goods"
		Me.return_goods.HeaderText = "Return Goods"
		Me.return_goods.Name = "return_goods"
		Me.return_goods.Width = 50
		'
		'stk_in_no
		'
		Me.stk_in_no.DataPropertyName = "stk_in_no"
		Me.stk_in_no.HeaderText = "STK-IN No."
		Me.stk_in_no.Name = "stk_in_no"
		Me.stk_in_no.Width = 75
		'
		'pono
		'
		Me.pono.DataPropertyName = "pono"
		Me.pono.HeaderText = "Customer P/O No."
		Me.pono.Name = "pono"
		Me.pono.ReadOnly = True
		Me.pono.Visible = False
		Me.pono.Width = 60
		'
		'roll_cnt
		'
		Me.roll_cnt.DataPropertyName = "roll_cnt"
		Me.roll_cnt.HeaderText = "Rolls"
		Me.roll_cnt.Name = "roll_cnt"
		Me.roll_cnt.Width = 50
		'
		'sono
		'
		Me.sono.DataPropertyName = "sono"
		Me.sono.HeaderText = "S/O No."
		Me.sono.Name = "sono"
		Me.sono.ReadOnly = True
		Me.sono.Visible = False
		Me.sono.Width = 60
		'
		'sonoid
		'
		Me.sonoid.DataPropertyName = "sonoid"
		Me.sonoid.HeaderText = "S/O Item No."
		Me.sonoid.Name = "sonoid"
		Me.sonoid.ReadOnly = True
		Me.sonoid.Width = 85
		'
		'design_no
		'
		Me.design_no.DataPropertyName = "cust_design"
		Me.design_no.HeaderText = "Design No."
		Me.design_no.Name = "design_no"
		Me.design_no.ReadOnly = True
		Me.design_no.Width = 85
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
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.grade.DefaultCellStyle = DataGridViewCellStyle8
		Me.grade.HeaderText = "Gr"
		Me.grade.Name = "grade"
		Me.grade.ReadOnly = True
		Me.grade.Width = 25
		'
		'qty
		'
		Me.qty.DataPropertyName = "qty"
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle9.Format = "#.#0"
		DataGridViewCellStyle9.NullValue = Nothing
		Me.qty.DefaultCellStyle = DataGridViewCellStyle9
		Me.qty.HeaderText = "Qty."
		Me.qty.Name = "qty"
		Me.qty.Width = 65
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
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle10.Format = "#.#0"
		DataGridViewCellStyle10.NullValue = Nothing
		Me.uprice.DefaultCellStyle = DataGridViewCellStyle10
		Me.uprice.HeaderText = "Unit Price"
		Me.uprice.Name = "uprice"
		Me.uprice.Width = 65
		'
		'lineamt
		'
		Me.lineamt.DataPropertyName = "lineamt"
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle11.Format = "#.###0"
		Me.lineamt.DefaultCellStyle = DataGridViewCellStyle11
		Me.lineamt.HeaderText = "Amout"
		Me.lineamt.Name = "lineamt"
		Me.lineamt.ReadOnly = True
		Me.lineamt.Width = 65
		'
		'linediscamt
		'
		Me.linediscamt.DataPropertyName = "linediscamt"
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle12.Format = "#.###0"
		Me.linediscamt.DefaultCellStyle = DataGridViewCellStyle12
		Me.linediscamt.HeaderText = "Item Discount Amount"
		Me.linediscamt.Name = "linediscamt"
		Me.linediscamt.ReadOnly = True
		Me.linediscamt.Visible = False
		Me.linediscamt.Width = 65
		'
		'linenetamt
		'
		Me.linenetamt.DataPropertyName = "linenetamt"
		DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle13.Format = "#.#0"
		Me.linenetamt.DefaultCellStyle = DataGridViewCellStyle13
		Me.linenetamt.HeaderText = "Item Net Amount"
		Me.linenetamt.Name = "linenetamt"
		Me.linenetamt.ReadOnly = True
		Me.linenetamt.Visible = False
		Me.linenetamt.Width = 75
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(51, 13)
		Me.Label3.TabIndex = 40
		Me.Label3.Text = "Customer"
		'
		'txtCustomer
		'
		Me.txtCustomer.AccessibleName = "custname"
		Me.txtCustomer.Location = New System.Drawing.Point(80, 80)
		Me.txtCustomer.Name = "txtCustomer"
		Me.txtCustomer.ReadOnly = True
		Me.txtCustomer.Size = New System.Drawing.Size(264, 20)
		Me.txtCustomer.TabIndex = 41
		Me.txtCustomer.Tag = ""
		'
		'txtReference
		'
		Me.txtReference.AccessibleName = "reference"
		Me.txtReference.Location = New System.Drawing.Point(80, 104)
		Me.txtReference.MaxLength = 100
		Me.txtReference.Name = "txtReference"
		Me.txtReference.Size = New System.Drawing.Size(496, 20)
		Me.txtReference.TabIndex = 43
		Me.txtReference.Tag = ""
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(352, 32)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(53, 13)
		Me.Label4.TabIndex = 44
		Me.Label4.Text = "Reason 1"
		'
		'cboReason
		'
		Me.cboReason.AccessibleDescription = "0"
		Me.cboReason.AccessibleName = "crnote_reason1"
		Me.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboReason.FormattingEnabled = True
		Me.cboReason.Location = New System.Drawing.Point(408, 32)
		Me.cboReason.Name = "cboReason"
		Me.cboReason.Size = New System.Drawing.Size(168, 21)
		Me.cboReason.TabIndex = 45
		Me.cboReason.Tag = ""
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 104)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 13)
		Me.Label5.TabIndex = 46
		Me.Label5.Text = "Reference"
		'
		'cboReason2
		'
		Me.cboReason2.AccessibleDescription = "0"
		Me.cboReason2.AccessibleName = "crnote_reason2"
		Me.cboReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboReason2.FormattingEnabled = True
		Me.cboReason2.Location = New System.Drawing.Point(408, 56)
		Me.cboReason2.Name = "cboReason2"
		Me.cboReason2.Size = New System.Drawing.Size(168, 21)
		Me.cboReason2.TabIndex = 48
		Me.cboReason2.Tag = ""
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(352, 56)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(53, 13)
		Me.Label6.TabIndex = 47
		Me.Label6.Text = "Reason 2"
		'
		'cboReason3
		'
		Me.cboReason3.AccessibleDescription = "0"
		Me.cboReason3.AccessibleName = "crnote_reason3"
		Me.cboReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboReason3.FormattingEnabled = True
		Me.cboReason3.Location = New System.Drawing.Point(408, 80)
		Me.cboReason3.Name = "cboReason3"
		Me.cboReason3.Size = New System.Drawing.Size(168, 21)
		Me.cboReason3.TabIndex = 50
		Me.cboReason3.Tag = ""
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(352, 80)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(53, 13)
		Me.Label7.TabIndex = 49
		Me.Label7.Text = "Reason 3"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(560, 336)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(73, 13)
		Me.Label8.TabIndex = 64
		Me.Label8.Text = "Gross Amount"
		'
		'txtGrossAmt
		'
		Me.txtGrossAmt.AccessibleDescription = "0.00"
		Me.txtGrossAmt.AccessibleName = "grossamt"
		Me.txtGrossAmt.Location = New System.Drawing.Point(656, 336)
		Me.txtGrossAmt.Name = "txtGrossAmt"
		Me.txtGrossAmt.ReadOnly = True
		Me.txtGrossAmt.Size = New System.Drawing.Size(112, 20)
		Me.txtGrossAmt.TabIndex = 63
		Me.txtGrossAmt.Tag = ""
		Me.txtGrossAmt.Text = "0.00"
		Me.txtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(8, 336)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(49, 13)
		Me.Label13.TabIndex = 62
		Me.Label13.Text = "Remarks"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(560, 432)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(63, 13)
		Me.Label12.TabIndex = 61
		Me.Label12.Text = "Net Amount"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(632, 408)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(15, 13)
		Me.Label11.TabIndex = 60
		Me.Label11.Text = "%"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(560, 408)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(28, 13)
		Me.Label10.TabIndex = 59
		Me.Label10.Text = "VAT"
		'
		'txtVat
		'
		Me.txtVat.AccessibleDescription = "0.00"
		Me.txtVat.AccessibleName = "vat"
		Me.txtVat.Location = New System.Drawing.Point(592, 408)
		Me.txtVat.Name = "txtVat"
		Me.txtVat.Size = New System.Drawing.Size(32, 20)
		Me.txtVat.TabIndex = 53
		Me.txtVat.Tag = ""
		Me.txtVat.Text = "7.00"
		Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtNetAmt
		'
		Me.txtNetAmt.AccessibleDescription = "0.00"
		Me.txtNetAmt.AccessibleName = "netamt"
		Me.txtNetAmt.Location = New System.Drawing.Point(656, 432)
		Me.txtNetAmt.Name = "txtNetAmt"
		Me.txtNetAmt.ReadOnly = True
		Me.txtNetAmt.Size = New System.Drawing.Size(112, 20)
		Me.txtNetAmt.TabIndex = 56
		Me.txtNetAmt.Tag = ""
		Me.txtNetAmt.Text = "0.00"
		Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtVatAmt
		'
		Me.txtVatAmt.AccessibleDescription = "0.00"
		Me.txtVatAmt.AccessibleName = "vatamt"
		Me.txtVatAmt.Location = New System.Drawing.Point(656, 408)
		Me.txtVatAmt.Name = "txtVatAmt"
		Me.txtVatAmt.ReadOnly = True
		Me.txtVatAmt.Size = New System.Drawing.Size(112, 20)
		Me.txtVatAmt.TabIndex = 55
		Me.txtVatAmt.Tag = ""
		Me.txtVatAmt.Text = "0.00"
		Me.txtVatAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtPreTaxAmt
		'
		Me.txtPreTaxAmt.AccessibleDescription = "0.00"
		Me.txtPreTaxAmt.AccessibleName = "pretaxamt"
		Me.txtPreTaxAmt.Location = New System.Drawing.Point(656, 384)
		Me.txtPreTaxAmt.Name = "txtPreTaxAmt"
		Me.txtPreTaxAmt.ReadOnly = True
		Me.txtPreTaxAmt.Size = New System.Drawing.Size(112, 20)
		Me.txtPreTaxAmt.TabIndex = 52
		Me.txtPreTaxAmt.Tag = ""
		Me.txtPreTaxAmt.Text = "0.00"
		Me.txtPreTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtDiscAmt
		'
		Me.txtDiscAmt.AccessibleDescription = "0.00"
		Me.txtDiscAmt.AccessibleName = "discamt"
		Me.txtDiscAmt.Location = New System.Drawing.Point(656, 360)
		Me.txtDiscAmt.Name = "txtDiscAmt"
		Me.txtDiscAmt.Size = New System.Drawing.Size(112, 20)
		Me.txtDiscAmt.TabIndex = 51
		Me.txtDiscAmt.Tag = ""
		Me.txtDiscAmt.Text = "0.00"
		Me.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(560, 384)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(89, 13)
		Me.Label9.TabIndex = 57
		Me.Label9.Text = "Pre - Tax Amount"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(560, 360)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(88, 13)
		Me.Label14.TabIndex = 54
		Me.Label14.Text = "Discount Amount"
		'
		'txtRemarks
		'
		Me.txtRemarks.AccessibleName = "remarks"
		Me.txtRemarks.Location = New System.Drawing.Point(8, 360)
		Me.txtRemarks.MaxLength = 255
		Me.txtRemarks.Multiline = True
		Me.txtRemarks.Name = "txtRemarks"
		Me.txtRemarks.Size = New System.Drawing.Size(544, 88)
		Me.txtRemarks.TabIndex = 58
		Me.txtRemarks.Tag = ""
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(8, 56)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(69, 13)
		Me.Label15.TabIndex = 66
		Me.Label15.Text = "Stock-IN No."
		'
		'cboStkINNo
		'
		Me.cboStkINNo.AccessibleDescription = ""
		Me.cboStkINNo.AccessibleName = ""
		Me.cboStkINNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStkINNo.FormattingEnabled = True
		Me.cboStkINNo.Location = New System.Drawing.Point(80, 56)
		Me.cboStkINNo.Name = "cboStkINNo"
		Me.cboStkINNo.Size = New System.Drawing.Size(112, 21)
		Me.cboStkINNo.TabIndex = 65
		Me.cboStkINNo.Tag = ""
		'
		'btnLoadINV
		'
		Me.btnLoadINV.Image = CType(resources.GetObject("btnLoadINV.Image"), System.Drawing.Image)
		Me.btnLoadINV.Location = New System.Drawing.Point(200, 32)
		Me.btnLoadINV.Name = "btnLoadINV"
		Me.btnLoadINV.Size = New System.Drawing.Size(144, 24)
		Me.btnLoadINV.TabIndex = 67
		Me.btnLoadINV.Text = "&Load Original Invoice"
		Me.btnLoadINV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnLoadINV.UseVisualStyleBackColor = True
		'
		'btnLoadStkIN
		'
		Me.btnLoadStkIN.Image = CType(resources.GetObject("btnLoadStkIN.Image"), System.Drawing.Image)
		Me.btnLoadStkIN.Location = New System.Drawing.Point(200, 56)
		Me.btnLoadStkIN.Name = "btnLoadStkIN"
		Me.btnLoadStkIN.Size = New System.Drawing.Size(144, 24)
		Me.btnLoadStkIN.TabIndex = 68
		Me.btnLoadStkIN.Text = "&Load Stock IN Items"
		Me.btnLoadStkIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnLoadStkIN.UseVisualStyleBackColor = True
		'
		'frmCreditNote
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(777, 458)
		Me.Controls.Add(Me.btnLoadStkIN)
		Me.Controls.Add(Me.btnLoadINV)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.cboStkINNo)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtGrossAmt)
		Me.Controls.Add(Me.txtRemarks)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.txtVat)
		Me.Controls.Add(Me.txtNetAmt)
		Me.Controls.Add(Me.txtVatAmt)
		Me.Controls.Add(Me.txtPreTaxAmt)
		Me.Controls.Add(Me.txtDiscAmt)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.cboReason3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.cboReason2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.cboReason)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtReference)
		Me.Controls.Add(Me.txtCustomer)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.grdDetails)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.cboInvNo)
		Me.Controls.Add(Me.txtStatus)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.dtpDocDate)
		Me.Controls.Add(Me.Label28)
		Me.Controls.Add(Me.txtDocNo)
		Me.Controls.Add(Me.Label29)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmCreditNote"
		Me.Text = "Credit Note"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label28 As System.Windows.Forms.Label
	Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtStatus As System.Windows.Forms.TextBox
	Friend WithEvents cboInvNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents grdDetails As System.Windows.Forms.DataGridView
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
	Friend WithEvents txtReference As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboReason As System.Windows.Forms.ComboBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents cboReason2 As System.Windows.Forms.ComboBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents cboReason3 As System.Windows.Forms.ComboBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents txtGrossAmt As System.Windows.Forms.TextBox
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents txtVat As System.Windows.Forms.TextBox
	Friend WithEvents txtNetAmt As System.Windows.Forms.TextBox
	Friend WithEvents txtVatAmt As System.Windows.Forms.TextBox
	Friend WithEvents txtPreTaxAmt As System.Windows.Forms.TextBox
	Friend WithEvents txtDiscAmt As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
	Friend WithEvents invord As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents return_goods As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents stk_in_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents pono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents roll_cnt As System.Windows.Forms.DataGridViewTextBoxColumn
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
	Friend WithEvents btnApprove As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents cboStkINNo As System.Windows.Forms.ComboBox
	Friend WithEvents btnLoadINV As System.Windows.Forms.Button
	Friend WithEvents btnLoadStkIN As System.Windows.Forms.Button
End Class
