<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDINPurchase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDINPurchase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpsinvdt = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSuppInvNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSuppLot = New System.Windows.Forms.TextBox()
        Me.txtSuppRefNo = New System.Windows.Forms.TextBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslblDocNo = New System.Windows.Forms.ToolStripLabel()
        Me.cboDinNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbDInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbMInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblGOutNo = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.lblDocDate = New System.Windows.Forms.Label()
        Me.cboMtlLocation = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboMtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.cboMtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.po_job_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.delidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdPO = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.dtpDINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDINNo = New System.Windows.Forms.TextBox()
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.id_jobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.job_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhcod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCopyRoll = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpsinvdt
        '
        Me.dtpsinvdt.Checked = False
        Me.dtpsinvdt.CustomFormat = ""
        Me.dtpsinvdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsinvdt.Location = New System.Drawing.Point(92, 98)
        Me.dtpsinvdt.Name = "dtpsinvdt"
        Me.dtpsinvdt.ShowCheckBox = True
        Me.dtpsinvdt.ShowUpDown = True
        Me.dtpsinvdt.Size = New System.Drawing.Size(104, 22)
        Me.dtpsinvdt.TabIndex = 310
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(202, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 309
        Me.Label6.Text = "Other ref:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(202, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 308
        Me.Label11.Text = "Sup.Lot#:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 307
        Me.Label12.Text = "Sup.Inv.Date:"
        '
        'txtSuppInvNo
        '
        Me.txtSuppInvNo.Location = New System.Drawing.Point(92, 74)
        Me.txtSuppInvNo.Name = "txtSuppInvNo"
        Me.txtSuppInvNo.Size = New System.Drawing.Size(104, 22)
        Me.txtSuppInvNo.TabIndex = 302
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 306
        Me.Label13.Text = "Sup.inv.#:"
        '
        'txtSuppLot
        '
        Me.txtSuppLot.Location = New System.Drawing.Point(258, 74)
        Me.txtSuppLot.Name = "txtSuppLot"
        Me.txtSuppLot.Size = New System.Drawing.Size(96, 22)
        Me.txtSuppLot.TabIndex = 303
        '
        'txtSuppRefNo
        '
        Me.txtSuppRefNo.Location = New System.Drawing.Point(258, 98)
        Me.txtSuppRefNo.Name = "txtSuppRefNo"
        Me.txtSuppRefNo.Size = New System.Drawing.Size(96, 22)
        Me.txtSuppRefNo.TabIndex = 305
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(92, 47)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(244, 21)
        Me.cboSupplier.TabIndex = 300
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblDocNo, Me.cboDinNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1045, 25)
        Me.ToolStrip1.TabIndex = 374
        '
        'tslblDocNo
        '
        Me.tslblDocNo.Name = "tslblDocNo"
        Me.tslblDocNo.Size = New System.Drawing.Size(50, 22)
        Me.tslblDocNo.Text = "Doc No."
        '
        'cboDinNo
        '
        Me.cboDinNo.Name = "cboDinNo"
        Me.cboDinNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDInDocument, Me.tsbDInTag, Me.tsbMInDocument})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbDInDocument
        '
        Me.tsbDInDocument.Name = "tsbDInDocument"
        Me.tsbDInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInDocument.Text = "IN Document"
        '
        'tsbDInTag
        '
        Me.tsbDInTag.Name = "tsbDInTag"
        Me.tsbDInTag.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInTag.Text = "Tag"
        '
        'tsbMInDocument
        '
        Me.tsbMInDocument.Name = "tsbMInDocument"
        Me.tsbMInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbMInDocument.Text = "M-IN Document"
        Me.tsbMInDocument.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "Supplier:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpsinvdt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSuppInvNo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSuppLot)
        Me.GroupBox1.Controls.Add(Me.txtSuppRefNo)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutNo)
        Me.GroupBox1.Controls.Add(Me.lblGOutNo)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 142)
        Me.GroupBox1.TabIndex = 376
        Me.GroupBox1.TabStop = False
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(277, 18)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'lblGOutNo
        '
        Me.lblGOutNo.AutoSize = True
        Me.lblGOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGOutNo.Location = New System.Drawing.Point(16, 26)
        Me.lblGOutNo.Name = "lblGOutNo"
        Me.lblGOutNo.Size = New System.Drawing.Size(112, 13)
        Me.lblGOutNo.TabIndex = 1
        Me.lblGOutNo.Text = "P/O No. / Job No."
        '
        'txtPONo
        '
        Me.txtPONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPONo.Location = New System.Drawing.Point(134, 21)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(132, 20)
        Me.txtPONo.TabIndex = 0
        '
        'lblDocDate
        '
        Me.lblDocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocDate.AutoSize = True
        Me.lblDocDate.Location = New System.Drawing.Point(844, 81)
        Me.lblDocDate.Name = "lblDocDate"
        Me.lblDocDate.Size = New System.Drawing.Size(57, 13)
        Me.lblDocDate.TabIndex = 375
        Me.lblDocDate.Text = "Doc Date."
        '
        'cboMtlLocation
        '
        Me.cboMtlLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboMtlLocation.FormattingEnabled = True
        Me.cboMtlLocation.Location = New System.Drawing.Point(96, 69)
        Me.cboMtlLocation.Name = "cboMtlLocation"
        Me.cboMtlLocation.Size = New System.Drawing.Size(121, 21)
        Me.cboMtlLocation.TabIndex = 310
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 309
        Me.Label15.Text = "Location :"
        '
        'cboMtlSubinventory
        '
        Me.cboMtlSubinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMtlSubinventory.FormattingEnabled = True
        Me.cboMtlSubinventory.Location = New System.Drawing.Point(96, 45)
        Me.cboMtlSubinventory.Name = "cboMtlSubinventory"
        Me.cboMtlSubinventory.Size = New System.Drawing.Size(121, 21)
        Me.cboMtlSubinventory.TabIndex = 308
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 307
        Me.Label16.Text = "Sub Inven :"
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Location = New System.Drawing.Point(274, 174)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(192, 32)
        Me.chkAutoCalculate.TabIndex = 381
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'cboMtlWarehouse
        '
        Me.cboMtlWarehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMtlWarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMtlWarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMtlWarehouse.FormattingEnabled = True
        Me.cboMtlWarehouse.Location = New System.Drawing.Point(96, 19)
        Me.cboMtlWarehouse.Name = "cboMtlWarehouse"
        Me.cboMtlWarehouse.Size = New System.Drawing.Size(121, 21)
        Me.cboMtlWarehouse.TabIndex = 306
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(20, 21)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(72, 13)
        Me.lblmtl_warehouse_id.TabIndex = 305
        Me.lblmtl_warehouse_id.Text = "Warehouse :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cboMtlLocation)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cboMtlSubinventory)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cboMtlWarehouse)
        Me.GroupBox2.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GroupBox2.Location = New System.Drawing.Point(812, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox2.TabIndex = 380
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "W/H Detail"
        '
        'po_job_line_id
        '
        Me.po_job_line_id.DataPropertyName = "job_line_id"
        Me.po_job_line_id.HeaderText = "job_line_id"
        Me.po_job_line_id.Name = "po_job_line_id"
        Me.po_job_line_id.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Image = Global.SalesOrderSystem.My.Resources.Resources.DeleteQuery_16x
        Me.btnDel.Location = New System.Drawing.Point(178, 177)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 24)
        Me.btnDel.TabIndex = 379
        Me.btnDel.Text = "Delete Roll"
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'delidt
        '
        Me.delidt.DataPropertyName = "delidt"
        Me.delidt.HeaderText = "Delivery"
        Me.delidt.Name = "delidt"
        Me.delidt.ReadOnly = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.SalesOrderSystem.My.Resources.Resources.AddQuery_16x
        Me.btnAdd.Location = New System.Drawing.Point(9, 177)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 24)
        Me.btnAdd.TabIndex = 378
        Me.btnAdd.Text = "Add Roll"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grdPO
        '
        Me.grdPO.AllowUserToAddRows = False
        Me.grdPO.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPO.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.itcd, Me.qty, Me.delidt, Me.po_job_line_id})
        Me.grdPO.Location = New System.Drawing.Point(17, 13)
        Me.grdPO.Name = "grdPO"
        Me.grdPO.Size = New System.Drawing.Size(401, 121)
        Me.grdPO.TabIndex = 377
        '
        'colID
        '
        Me.colID.DataPropertyName = "id_jobdet"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Width = 50
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 70
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 80
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(591, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 373
        Me.Label4.Text = "Yds"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(68, 444)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(866, 22)
        Me.txtRemark.TabIndex = 364
        Me.txtRemark.TabStop = False
        Me.txtRemark.Tag = ""
        '
        'dtpDINDate
        '
        Me.dtpDINDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDINDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDINDate.Enabled = False
        Me.dtpDINDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDINDate.Location = New System.Drawing.Point(910, 79)
        Me.dtpDINDate.Name = "dtpDINDate"
        Me.dtpDINDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpDINDate.TabIndex = 361
        Me.dtpDINDate.TabStop = False
        '
        'txtDINNo
        '
        Me.txtDINNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDINNo.Location = New System.Drawing.Point(910, 53)
        Me.txtDINNo.Name = "txtDINNo"
        Me.txtDINNo.ReadOnly = True
        Me.txtDINNo.Size = New System.Drawing.Size(119, 22)
        Me.txtDINNo.TabIndex = 360
        Me.txtDINNo.TabStop = False
        Me.txtDINNo.Tag = ""
        '
        'lblDocNo
        '
        Me.lblDocNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(854, 53)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(48, 13)
        Me.lblDocNo.TabIndex = 359
        Me.lblDocNo.Text = "Doc No."
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(485, 416)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalYds.TabIndex = 369
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(348, 417)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMts.TabIndex = 368
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(211, 417)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalKgs.TabIndex = 367
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 420)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "Total"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(455, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "Mts"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(68, 417)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalRolls.TabIndex = 365
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 371
        Me.Label8.Text = "Kgs"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(175, 419)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 370
        Me.Label9.Text = "Rolls"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 363
        Me.Label2.Text = "Remark"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jobdet, Me.job_line_id, Me.lot, Me.dhcod, Me.dfno, Me.sono, Me.sonoid, Me.design_no, Me.fwth, Me.gwth, Me.col, Me.custcolor, Me.gr, Me.roll_no_d, Me.roll_no_o, Me.kg, Me.mts, Me.yds, Me.remark, Me.roll_no_f, Me.loc})
        Me.grdData.Location = New System.Drawing.Point(9, 217)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1020, 194)
        Me.grdData.TabIndex = 362
        Me.grdData.TabStop = False
        '
        'id_jobdet
        '
        Me.id_jobdet.DataPropertyName = "id_jobdet"
        Me.id_jobdet.HeaderText = "ID"
        Me.id_jobdet.Name = "id_jobdet"
        '
        'job_line_id
        '
        Me.job_line_id.DataPropertyName = "job_line_id"
        Me.job_line_id.HeaderText = "Job Line ID"
        Me.job_line_id.Name = "job_line_id"
        Me.job_line_id.ReadOnly = True
        Me.job_line_id.Visible = False
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        '
        'dhcod
        '
        Me.dhcod.DataPropertyName = "dhcod"
        Me.dhcod.HeaderText = "Suppliers"
        Me.dhcod.Name = "dhcod"
        Me.dhcod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dhcod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dhcod.Visible = False
        Me.dhcod.Width = 150
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "Suppliers Inv No. (D/F)"
        Me.dfno.Name = "dfno"
        Me.dfno.Visible = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        Me.sono.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sono.Visible = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sonoid.Visible = False
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        Me.fwth.HeaderText = "Fwth"
        Me.fwth.Name = "fwth"
        Me.fwth.Width = 50
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.Visible = False
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Codes"
        Me.col.Name = "col"
        Me.col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col.Width = 75
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Color Customer"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Grade"
        Me.gr.Name = "gr"
        Me.gr.Width = 25
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No."
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.ReadOnly = True
        Me.roll_no_d.Width = 75
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.kg.DefaultCellStyle = DataGridViewCellStyle2
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.mts.DefaultCellStyle = DataGridViewCellStyle3
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.yds.DefaultCellStyle = DataGridViewCellStyle4
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'remark
        '
        Me.remark.DataPropertyName = "rem_qc"
        Me.remark.HeaderText = "Remark (QC)"
        Me.remark.Name = "remark"
        Me.remark.Width = 250
        '
        'roll_no_f
        '
        Me.roll_no_f.DataPropertyName = "roll_no_f"
        Me.roll_no_f.HeaderText = "roll_no_f"
        Me.roll_no_f.Name = "roll_no_f"
        Me.roll_no_f.Visible = False
        Me.roll_no_f.Width = 5
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCopyRoll
        '
        Me.btnCopyRoll.Image = Global.SalesOrderSystem.My.Resources.Resources.Copy_16x
        Me.btnCopyRoll.Location = New System.Drawing.Point(84, 177)
        Me.btnCopyRoll.Name = "btnCopyRoll"
        Me.btnCopyRoll.Size = New System.Drawing.Size(90, 24)
        Me.btnCopyRoll.TabIndex = 382
        Me.btnCopyRoll.Text = "Copy Roll"
        Me.btnCopyRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopyRoll.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.grdPO)
        Me.GroupBox3.Location = New System.Drawing.Point(382, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 140)
        Me.GroupBox3.TabIndex = 383
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select P/O Items"
        '
        'frmStockDINPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 476)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnCopyRoll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDocDate)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.dtpDINDate)
        Me.Controls.Add(Me.txtDINNo)
        Me.Controls.Add(Me.lblDocNo)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStockDINPurchase"
        Me.Text = "DIN Purchase"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpsinvdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSuppInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSuppLot As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppRefNo As System.Windows.Forms.TextBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslblDocNo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDinNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblGOutNo As System.Windows.Forms.Label
    Friend WithEvents txtPONo As System.Windows.Forms.TextBox
    Friend WithEvents lblDocDate As System.Windows.Forms.Label
    Friend WithEvents cboMtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboMtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents cboMtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents po_job_line_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents delidt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdPO As System.Windows.Forms.DataGridView
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents dtpDINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDINNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDocNo As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCopyRoll As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbDInDocument As ToolStripMenuItem
    Friend WithEvents tsbDInTag As ToolStripMenuItem
    Friend WithEvents tsbMInDocument As ToolStripMenuItem
    Friend WithEvents id_jobdet As DataGridViewTextBoxColumn
    Friend WithEvents job_line_id As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents dhcod As DataGridViewComboBoxColumn
    Friend WithEvents dfno As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents fwth As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewComboBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_d As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_f As DataGridViewTextBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
End Class
