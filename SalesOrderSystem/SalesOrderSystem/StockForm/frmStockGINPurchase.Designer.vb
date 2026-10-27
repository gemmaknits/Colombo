<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGINPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGINPurchase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.cboMtlLocation = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboMtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboMtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelRoll = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdPO = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po_job_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ydkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpsinvdt = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppInvNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSuppLot = New System.Windows.Forms.TextBox()
        Me.txtSuppRefNo = New System.Windows.Forms.TextBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblGOutNo = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpGINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtGinno = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboGINNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbGInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbGInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.colIDJobDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.job_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colydkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_bdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_adt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preseted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source_refno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.BtnCopyRoll = New System.Windows.Forms.Button()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.lblTotalKg = New System.Windows.Forms.Label()
        Me.txtTotalKg = New System.Windows.Forms.TextBox()
        Me.lblTotalMts = New System.Windows.Forms.Label()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.lblTotalYds = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
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
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 309
        Me.Label7.Text = "Location :"
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
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 307
        Me.Label12.Text = "Sub Inven :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboMtlSubinventory)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboMtlWarehouse)
        Me.GroupBox2.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GroupBox2.Location = New System.Drawing.Point(818, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox2.TabIndex = 368
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "W/H Detail"
        '
        'btnDelRoll
        '
        Me.btnDelRoll.Image = Global.SalesOrderSystem.My.Resources.Resources.DeleteQuery_16x
        Me.btnDelRoll.Location = New System.Drawing.Point(209, 179)
        Me.btnDelRoll.Name = "btnDelRoll"
        Me.btnDelRoll.Size = New System.Drawing.Size(88, 25)
        Me.btnDelRoll.TabIndex = 367
        Me.btnDelRoll.Text = "Delete Roll"
        Me.btnDelRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelRoll.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.SalesOrderSystem.My.Resources.Resources.AddQuery_16x
        Me.btnAdd.Location = New System.Drawing.Point(20, 179)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 25)
        Me.btnAdd.TabIndex = 366
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
        Me.grdPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.itcd, Me.qty, Me.delidt, Me.po_job_line_id, Me.ydkg})
        Me.grdPO.Location = New System.Drawing.Point(383, 43)
        Me.grdPO.Name = "grdPO"
        Me.grdPO.Size = New System.Drawing.Size(412, 130)
        Me.grdPO.TabIndex = 365
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
        'delidt
        '
        Me.delidt.DataPropertyName = "delidt"
        Me.delidt.HeaderText = "Delivery"
        Me.delidt.Name = "delidt"
        Me.delidt.ReadOnly = True
        '
        'po_job_line_id
        '
        Me.po_job_line_id.DataPropertyName = "job_line_id"
        Me.po_job_line_id.HeaderText = "job_line_id"
        Me.po_job_line_id.Name = "po_job_line_id"
        Me.po_job_line_id.Visible = False
        '
        'ydkg
        '
        Me.ydkg.DataPropertyName = "ydkg"
        Me.ydkg.HeaderText = "ydkg"
        Me.ydkg.Name = "ydkg"
        Me.ydkg.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpsinvdt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSuppInvNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSuppLot)
        Me.GroupBox1.Controls.Add(Me.txtSuppRefNo)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutNo)
        Me.GroupBox1.Controls.Add(Me.lblGOutNo)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 132)
        Me.GroupBox1.TabIndex = 360
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Detail"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "Sup.Lot#:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 307
        Me.Label4.Text = "Sup.Inv.Date:"
        '
        'txtSuppInvNo
        '
        Me.txtSuppInvNo.Location = New System.Drawing.Point(92, 74)
        Me.txtSuppInvNo.Name = "txtSuppInvNo"
        Me.txtSuppInvNo.Size = New System.Drawing.Size(104, 22)
        Me.txtSuppInvNo.TabIndex = 302
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 306
        Me.Label1.Text = "Sup.inv.#:"
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 301
        Me.Label11.Text = "Supplier:"
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
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(854, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 364
        Me.Label3.Text = "GIN Date"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'dtpGINDate
        '
        Me.dtpGINDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpGINDate.Enabled = False
        Me.dtpGINDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGINDate.Location = New System.Drawing.Point(914, 64)
        Me.dtpGINDate.Name = "dtpGINDate"
        Me.dtpGINDate.Size = New System.Drawing.Size(127, 22)
        Me.dtpGINDate.TabIndex = 358
        '
        'txtGinno
        '
        Me.txtGinno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGinno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGinno.Location = New System.Drawing.Point(914, 38)
        Me.txtGinno.Name = "txtGinno"
        Me.txtGinno.ReadOnly = True
        Me.txtGinno.Size = New System.Drawing.Size(127, 20)
        Me.txtGinno.TabIndex = 362
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGINNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 359
        Me.ToolStrip1.Text = "*P"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "GIN No."
        '
        'cboGINNo
        '
        Me.cboGINNo.Name = "cboGINNo"
        Me.cboGINNo.Size = New System.Drawing.Size(100, 25)
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
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGInDocument, Me.tsbGInTag})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbGInDocument
        '
        Me.tsbGInDocument.Name = "tsbGInDocument"
        Me.tsbGInDocument.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInDocument.Text = "G-IN DOCUMENT"
        '
        'tsbGInTag
        '
        Me.tsbGInTag.Name = "tsbGInTag"
        Me.tsbGInTag.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInTag.Text = "G-IN Tag"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 22)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(854, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 363
        Me.Label2.Text = "GIN No."
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDJobDet, Me.job_line_id, Me.Design_no, Me.colydkg, Me.roll_no_g, Me.roll_no, Me.roll_no_o, Me.col, Me.grade_bdt, Me.grade_adt, Me.grade, Me.Lot, Me.gwth, Me.kg, Me.mts, Me.yds, Me.preseted, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.loc, Me.roll_no_f, Me.source_refno, Me.sono, Me.sonoid, Me.suppcd, Me.dfno, Me.mcno, Me.kono, Me.purno})
        Me.grdData.Location = New System.Drawing.Point(17, 240)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1024, 246)
        Me.grdData.TabIndex = 361
        Me.grdData.TabStop = False
        '
        'colIDJobDet
        '
        Me.colIDJobDet.DataPropertyName = "id_jobdet"
        Me.colIDJobDet.HeaderText = "ID"
        Me.colIDJobDet.Name = "colIDJobDet"
        Me.colIDJobDet.Width = 50
        '
        'job_line_id
        '
        Me.job_line_id.DataPropertyName = "job_line_id"
        Me.job_line_id.HeaderText = "Job Line ID"
        Me.job_line_id.Name = "job_line_id"
        Me.job_line_id.ReadOnly = True
        Me.job_line_id.Visible = False
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        '
        'colydkg
        '
        Me.colydkg.DataPropertyName = "ydkg"
        Me.colydkg.HeaderText = "yd/kg"
        Me.colydkg.Name = "colydkg"
        Me.colydkg.Width = 50
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No. Old"
        Me.roll_no_g.Name = "roll_no_g"
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Width = 50
        '
        'grade_bdt
        '
        Me.grade_bdt.DataPropertyName = "grade_bdt"
        Me.grade_bdt.HeaderText = "Grade (Before Dye Test)"
        Me.grade_bdt.Name = "grade_bdt"
        Me.grade_bdt.Width = 70
        '
        'grade_adt
        '
        Me.grade_adt.DataPropertyName = "grade_adt"
        Me.grade_adt.HeaderText = "Grade (After Dye Test)"
        Me.grade_adt.Name = "grade_adt"
        Me.grade_adt.Width = 70
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.Width = 40
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "Lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.Width = 40
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.kg.DefaultCellStyle = DataGridViewCellStyle2
        Me.kg.HeaderText = "Kg."
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
        'preseted
        '
        Me.preseted.DataPropertyName = "preseted"
        Me.preseted.HeaderText = "Preseted"
        Me.preseted.Name = "preseted"
        Me.preseted.Width = 50
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Visible = False
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "Sub Inventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Visible = False
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Locations"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Visible = False
        '
        'loc
        '
        Me.loc.HeaderText = "loc (not Show)"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'roll_no_f
        '
        Me.roll_no_f.DataPropertyName = "roll_no_f"
        Me.roll_no_f.HeaderText = "roll_no_f(Don't Show)"
        Me.roll_no_f.Name = "roll_no_f"
        Me.roll_no_f.Visible = False
        '
        'source_refno
        '
        Me.source_refno.DataPropertyName = "source_refno"
        Me.source_refno.HeaderText = "source_refno(Don't Show)"
        Me.source_refno.Name = "source_refno"
        Me.source_refno.Visible = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "sono(Don't Show)"
        Me.sono.Name = "sono"
        Me.sono.Visible = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "sonoid(Don't Show)"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Visible = False
        '
        'suppcd
        '
        Me.suppcd.DataPropertyName = "suppcd"
        Me.suppcd.HeaderText = "suppcd(Don't Show)"
        Me.suppcd.Name = "suppcd"
        Me.suppcd.Visible = False
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "dfno(Don't Show)"
        Me.dfno.Name = "dfno"
        Me.dfno.Visible = False
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        Me.mcno.HeaderText = "mcno(Don't Show)"
        Me.mcno.Name = "mcno"
        Me.mcno.Visible = False
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        Me.kono.HeaderText = "kono(Don't Show)"
        Me.kono.Name = "kono"
        Me.kono.Visible = False
        '
        'purno
        '
        Me.purno.DataPropertyName = "purno"
        Me.purno.HeaderText = "purno(Don't Show)"
        Me.purno.Name = "purno"
        Me.purno.Visible = False
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Location = New System.Drawing.Point(398, 176)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(189, 32)
        Me.chkAutoCalculate.TabIndex = 369
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'BtnCopyRoll
        '
        Me.BtnCopyRoll.Image = CType(resources.GetObject("BtnCopyRoll.Image"), System.Drawing.Image)
        Me.BtnCopyRoll.Location = New System.Drawing.Point(114, 179)
        Me.BtnCopyRoll.Name = "BtnCopyRoll"
        Me.BtnCopyRoll.Size = New System.Drawing.Size(89, 23)
        Me.BtnCopyRoll.TabIndex = 370
        Me.BtnCopyRoll.Text = "Copy Roll"
        Me.BtnCopyRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopyRoll.UseVisualStyleBackColor = True
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnPrintBarcode.Image = CType(resources.GetObject("BtnPrintBarcode.Image"), System.Drawing.Image)
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(304, 179)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(88, 25)
        Me.BtnPrintBarcode.TabIndex = 371
        Me.BtnPrintBarcode.Text = "Print Tag"
        Me.BtnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintBarcode.UseVisualStyleBackColor = False
        '
        'lblTotalKg
        '
        Me.lblTotalKg.AutoSize = True
        Me.lblTotalKg.Location = New System.Drawing.Point(17, 218)
        Me.lblTotalKg.Name = "lblTotalKg"
        Me.lblTotalKg.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalKg.TabIndex = 380
        Me.lblTotalKg.Text = "Total Kgs:"
        '
        'txtTotalKg
        '
        Me.txtTotalKg.Location = New System.Drawing.Point(78, 215)
        Me.txtTotalKg.Name = "txtTotalKg"
        Me.txtTotalKg.ReadOnly = True
        Me.txtTotalKg.Size = New System.Drawing.Size(80, 22)
        Me.txtTotalKg.TabIndex = 381
        Me.txtTotalKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalMts
        '
        Me.lblTotalMts.AutoSize = True
        Me.lblTotalMts.Location = New System.Drawing.Point(170, 218)
        Me.lblTotalMts.Name = "lblTotalMts"
        Me.lblTotalMts.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalMts.TabIndex = 382
        Me.lblTotalMts.Text = "Total Mts:"
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Location = New System.Drawing.Point(231, 215)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(80, 22)
        Me.txtTotalMts.TabIndex = 383
        Me.txtTotalMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalYds
        '
        Me.lblTotalYds.AutoSize = True
        Me.lblTotalYds.Location = New System.Drawing.Point(323, 218)
        Me.lblTotalYds.Name = "lblTotalYds"
        Me.lblTotalYds.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalYds.TabIndex = 384
        Me.lblTotalYds.Text = "Total Yds:"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Location = New System.Drawing.Point(384, 215)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(80, 22)
        Me.txtTotalYds.TabIndex = 385
        Me.txtTotalYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmStockGINPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 465)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.lblTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.lblTotalMts)
        Me.Controls.Add(Me.txtTotalKg)
        Me.Controls.Add(Me.lblTotalKg)
        Me.Controls.Add(Me.BtnPrintBarcode)
        Me.Controls.Add(Me.BtnCopyRoll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDelRoll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdPO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpGINDate)
        Me.Controls.Add(Me.txtGinno)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStockGINPurchase"
        Me.Text = "Stock G Purchase"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboMtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents btnDelRoll As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdPO As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpsinvdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSuppInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSuppLot As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppRefNo As System.Windows.Forms.TextBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblGOutNo As System.Windows.Forms.Label
    Friend WithEvents txtPONo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpGINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGinno As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboGINNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delidt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents po_job_line_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ydkg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCopyRoll As Button
    Friend WithEvents colIDJobDet As DataGridViewTextBoxColumn
    Friend WithEvents job_line_id As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents colydkg As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents grade_bdt As DataGridViewTextBoxColumn
    Friend WithEvents grade_adt As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents Lot As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents preseted As DataGridViewCheckBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_f As DataGridViewTextBoxColumn
    Friend WithEvents source_refno As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents suppcd As DataGridViewTextBoxColumn
    Friend WithEvents dfno As DataGridViewTextBoxColumn
    Friend WithEvents mcno As DataGridViewTextBoxColumn
    Friend WithEvents kono As DataGridViewTextBoxColumn
    Friend WithEvents purno As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents BtnPrintBarcode As Button
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbGInDocument As ToolStripMenuItem
    Friend WithEvents tsbGInTag As ToolStripMenuItem
    Friend WithEvents lblTotalKg As System.Windows.Forms.Label
    Friend WithEvents txtTotalKg As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalMts As System.Windows.Forms.Label
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalYds As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
End Class
