<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnInPurchase
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnInPurchase))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvYarnIN = New System.Windows.Forms.DataGridView()
        Me.cboITCD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_jobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJobLineId2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rptPurchase = New System.Windows.Forms.RadioButton()
        Me.dtpSinvdt = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppInvNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSuppLot = New System.Windows.Forms.TextBox()
        Me.txtSuppRefNo = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox()
        Me.txtTotalTubes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotalBoxes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalGrossWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvPO = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rcv_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rcv_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rcv_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colJobLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbomtlLocations = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.txtItmFind = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblQtyMisMatchReason = New System.Windows.Forms.Label()
        Me.cboQtyMismatchReason = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvYarnIN
        '
        Me.dgvYarnIN.AllowUserToAddRows = False
        Me.dgvYarnIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvYarnIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvYarnIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cboITCD, Me.Grade, Me.boxno_s, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt, Me.actual_cone_weight, Me.boxno, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.loc, Me.box_remark, Me.id_jobdet, Me.colJobLineId2})
        Me.dgvYarnIN.Location = New System.Drawing.Point(12, 212)
        Me.dgvYarnIN.Name = "dgvYarnIN"
        Me.dgvYarnIN.Size = New System.Drawing.Size(1154, 289)
        Me.dgvYarnIN.TabIndex = 1
        '
        'cboITCD
        '
        Me.cboITCD.DataPropertyName = "itcd"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        Me.cboITCD.DefaultCellStyle = DataGridViewCellStyle2
        Me.cboITCD.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cboITCD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboITCD.HeaderText = "Item Code & Description"
        Me.cboITCD.Name = "cboITCD"
        Me.cboITCD.ReadOnly = True
        Me.cboITCD.Width = 250
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "grade"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold
        Me.Grade.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MaxInputLength = 15
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 50
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold
        Me.boxno_s.DefaultCellStyle = DataGridViewCellStyle4
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.Width = 75
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        Me.spools.DefaultCellStyle = DataGridViewCellStyle5
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kg_nt.Width = 75
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold
        Me.cart_tearwt.DefaultCellStyle = DataGridViewCellStyle6
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Width = 75
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight{Kg}"
        Me.actual_cone_weight.MaxInputLength = 15
        Me.actual_cone_weight.Name = "actual_cone_weight"
        Me.actual_cone_weight.Width = 75
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 75
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_warehouse_id.Visible = False
        Me.mtl_warehouse_id.Width = 120
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.mtl_subinventory_id.HeaderText = "Sub Inventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Visible = False
        Me.mtl_subinventory_id.Width = 130
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
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'box_remark
        '
        Me.box_remark.DataPropertyName = "box_remark"
        Me.box_remark.HeaderText = "Remark"
        Me.box_remark.Name = "box_remark"
        Me.box_remark.Width = 150
        '
        'id_jobdet
        '
        Me.id_jobdet.DataPropertyName = "id_jobdet"
        Me.id_jobdet.HeaderText = "ID"
        Me.id_jobdet.Name = "id_jobdet"
        Me.id_jobdet.ReadOnly = True
        Me.id_jobdet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_jobdet.Visible = False
        Me.id_jobdet.Width = 50
        '
        'colJobLineId2
        '
        Me.colJobLineId2.DataPropertyName = "job_line_id"
        Me.colJobLineId2.HeaderText = "P/O Line Id"
        Me.colJobLineId2.Name = "colJobLineId2"
        Me.colJobLineId2.ReadOnly = True
        Me.colJobLineId2.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PO No. / Job No."
        '
        'txtPONo
        '
        Me.txtPONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPONo.Location = New System.Drawing.Point(139, 45)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(112, 20)
        Me.txtPONo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.rptPurchase)
        Me.GroupBox1.Controls.Add(Me.dtpSinvdt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSuppInvNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSuppLot)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSuppRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 165)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier details:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(136, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 13)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "*Only Show P/O Not Closed"
        '
        'rptPurchase
        '
        Me.rptPurchase.AutoSize = True
        Me.rptPurchase.Checked = True
        Me.rptPurchase.Location = New System.Drawing.Point(17, 21)
        Me.rptPurchase.Name = "rptPurchase"
        Me.rptPurchase.Size = New System.Drawing.Size(78, 17)
        Me.rptPurchase.TabIndex = 101
        Me.rptPurchase.TabStop = True
        Me.rptPurchase.Text = "Purchase"
        Me.rptPurchase.UseVisualStyleBackColor = True
        '
        'dtpSinvdt
        '
        Me.dtpSinvdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSinvdt.Location = New System.Drawing.Point(107, 133)
        Me.dtpSinvdt.Name = "dtpSinvdt"
        Me.dtpSinvdt.Size = New System.Drawing.Size(96, 20)
        Me.dtpSinvdt.TabIndex = 100
        Me.dtpSinvdt.Value = New Date(2015, 4, 27, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(225, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(225, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Gold
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(107, 74)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(288, 21)
        Me.cboSupplier.TabIndex = 1
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Date:"
        '
        'txtSuppInvNo
        '
        Me.txtSuppInvNo.BackColor = System.Drawing.Color.Gold
        Me.txtSuppInvNo.Location = New System.Drawing.Point(107, 102)
        Me.txtSuppInvNo.Name = "txtSuppInvNo"
        Me.txtSuppInvNo.Size = New System.Drawing.Size(96, 20)
        Me.txtSuppInvNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtSuppLot
        '
        Me.txtSuppLot.BackColor = System.Drawing.Color.Gold
        Me.txtSuppLot.Location = New System.Drawing.Point(299, 102)
        Me.txtSuppLot.Name = "txtSuppLot"
        Me.txtSuppLot.Size = New System.Drawing.Size(96, 20)
        Me.txtSuppLot.TabIndex = 3
        '
        'txtSuppRefNo
        '
        Me.txtSuppRefNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuppRefNo.Location = New System.Drawing.Point(299, 131)
        Me.txtSuppRefNo.Name = "txtSuppRefNo"
        Me.txtSuppRefNo.Size = New System.Drawing.Size(96, 20)
        Me.txtSuppRefNo.TabIndex = 5
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(12, 528)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(344, 56)
        Me.txtRemark.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtTotalNetWeight)
        Me.GroupBox4.Controls.Add(Me.txtTotalTubes)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtTotalBoxes)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtTotalGrossWeight)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(578, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox4.TabIndex = 112
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Quantity"
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(192, 48)
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalNetWeight.TabIndex = 4
        '
        'txtTotalTubes
        '
        Me.txtTotalTubes.Location = New System.Drawing.Point(48, 48)
        Me.txtTotalTubes.Name = "txtTotalTubes"
        Me.txtTotalTubes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalTubes.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Tubes:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(112, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Net wt (kg):"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-158, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 78
        Me.Label21.Text = "Boxes:"
        '
        'txtTotalBoxes
        '
        Me.txtTotalBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalBoxes.Location = New System.Drawing.Point(48, 24)
        Me.txtTotalBoxes.Name = "txtTotalBoxes"
        Me.txtTotalBoxes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalBoxes.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Boxes:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(112, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Gross wt (kg):"
        '
        'txtTotalGrossWeight
        '
        Me.txtTotalGrossWeight.Location = New System.Drawing.Point(192, 24)
        Me.txtTotalGrossWeight.Name = "txtTotalGrossWeight"
        Me.txtTotalGrossWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalGrossWeight.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtDocNo)
        Me.GroupBox5.Controls.Add(Me.dtpDocDate)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(919, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(247, 82)
        Me.GroupBox5.TabIndex = 113
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(116, 23)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(96, 20)
        Me.txtDocNo.TabIndex = 0
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDate.Location = New System.Drawing.Point(116, 52)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpDocDate.TabIndex = 1
        '
        'lblYINno
        '
        Me.lblYINno.AutoSize = True
        Me.lblYINno.Location = New System.Drawing.Point(85, 20)
        Me.lblYINno.Name = "lblYINno"
        Me.lblYINno.Size = New System.Drawing.Size(0, 13)
        Me.lblYINno.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Y-IN No.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-158, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(840, 528)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 44)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBarcode.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrintBarcode.Image = CType(resources.GetObject("btnPrintBarcode.Image"), System.Drawing.Image)
        Me.btnPrintBarcode.Location = New System.Drawing.Point(1038, 528)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(60, 44)
        Me.btnPrintBarcode.TabIndex = 5
        Me.btnPrintBarcode.Text = "Print bar label"
        Me.btnPrintBarcode.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrintBarcode.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1104, 528)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(972, 528)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(60, 44)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(906, 528)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 44)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvPO
        '
        Me.dgvPO.AllowUserToAddRows = False
        Me.dgvPO.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPO.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvPO.ColumnHeadersHeight = 30
        Me.dgvPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.itcd, Me.qty, Me.colUom, Me.colQty2, Me.colUom2, Me.delidt, Me.rcv_warehouse_id, Me.rcv_subinventory_id, Me.rcv_locations_id, Me.colJobLineId})
        Me.dgvPO.Location = New System.Drawing.Point(431, 32)
        Me.dgvPO.Name = "dgvPO"
        Me.dgvPO.Size = New System.Drawing.Size(483, 148)
        Me.dgvPO.TabIndex = 0
        '
        'colID
        '
        Me.colID.DataPropertyName = "id_jobdet"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Visible = False
        Me.colID.Width = 50
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 60
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "uom"
        Me.colUom.HeaderText = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.ReadOnly = True
        Me.colUom.Width = 50
        '
        'colQty2
        '
        Me.colQty2.DataPropertyName = "qty2"
        Me.colQty2.HeaderText = "Qty2"
        Me.colQty2.Name = "colQty2"
        Me.colQty2.ReadOnly = True
        Me.colQty2.Width = 50
        '
        'colUom2
        '
        Me.colUom2.DataPropertyName = "uom2"
        Me.colUom2.HeaderText = "Uom2"
        Me.colUom2.Name = "colUom2"
        Me.colUom2.ReadOnly = True
        Me.colUom2.Width = 60
        '
        'delidt
        '
        Me.delidt.DataPropertyName = "delidt"
        Me.delidt.HeaderText = "Delivery"
        Me.delidt.Name = "delidt"
        Me.delidt.ReadOnly = True
        Me.delidt.Width = 70
        '
        'rcv_warehouse_id
        '
        Me.rcv_warehouse_id.DataPropertyName = "rcv_warehouse_id"
        Me.rcv_warehouse_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.rcv_warehouse_id.HeaderText = "W/H"
        Me.rcv_warehouse_id.Name = "rcv_warehouse_id"
        Me.rcv_warehouse_id.ReadOnly = True
        Me.rcv_warehouse_id.Width = 50
        '
        'rcv_subinventory_id
        '
        Me.rcv_subinventory_id.DataPropertyName = "rcv_subinventory_id"
        Me.rcv_subinventory_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.rcv_subinventory_id.HeaderText = "Subinventory"
        Me.rcv_subinventory_id.Name = "rcv_subinventory_id"
        Me.rcv_subinventory_id.ReadOnly = True
        Me.rcv_subinventory_id.Width = 70
        '
        'rcv_locations_id
        '
        Me.rcv_locations_id.DataPropertyName = "rcv_locations_id"
        Me.rcv_locations_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.rcv_locations_id.HeaderText = "Locations"
        Me.rcv_locations_id.Name = "rcv_locations_id"
        Me.rcv_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rcv_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.rcv_locations_id.Width = 70
        '
        'colJobLineId
        '
        Me.colJobLineId.DataPropertyName = "job_line_id"
        Me.colJobLineId.HeaderText = "P/O Line Id"
        Me.colJobLineId.Name = "colJobLineId"
        Me.colJobLineId.Width = 90
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(930, 504)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 13)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "*1 Yarn IN เปิดเฉพาะ 1 P/O Item เท่านั้น"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(688, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "*Key Enter to copy item"
        '
        'btnDel
        '
        Me.btnDel.Image = Global.YarnStockSystem.My.Resources.Resources.Cancel_16x
        Me.btnDel.Location = New System.Drawing.Point(504, 182)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(30, 25)
        Me.btnDel.TabIndex = 120
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.YarnStockSystem.My.Resources.Resources.Add_16x
        Me.btnAdd.Location = New System.Drawing.Point(431, 182)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 25)
        Me.btnAdd.TabIndex = 119
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(13, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 13)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "*ถ้าไม่สามารถพิมพ์ได้ ให้กด Esc"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.cbomtlLocations)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(919, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 106)
        Me.GroupBox2.TabIndex = 304
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address Information"
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(116, 18)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(118, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 13)
        Me.Label25.TabIndex = 294
        Me.Label25.Text = "Location"
        '
        'cbomtlLocations
        '
        Me.cbomtlLocations.FormattingEnabled = True
        Me.cbomtlLocations.Location = New System.Drawing.Point(116, 72)
        Me.cbomtlLocations.Name = "cbomtlLocations"
        Me.cbomtlLocations.Size = New System.Drawing.Size(118, 21)
        Me.cbomtlLocations.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 46)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 13)
        Me.Label27.TabIndex = 295
        Me.Label27.Text = "Sub Inven"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 298
        Me.Label28.Text = "W/H"
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(116, 45)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(118, 21)
        Me.cbomtlSubinventory.TabIndex = 3
        '
        'txtItmFind
        '
        Me.txtItmFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItmFind.Location = New System.Drawing.Point(562, 6)
        Me.txtItmFind.Name = "txtItmFind"
        Me.txtItmFind.Size = New System.Drawing.Size(218, 22)
        Me.txtItmFind.TabIndex = 305
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(462, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "Item Code To Find"
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Location = New System.Drawing.Point(468, 182)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(30, 25)
        Me.btnCopy.TabIndex = 403
        Me.btnCopy.Tag = "Copy"
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(590, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 13)
        Me.Label15.TabIndex = 404
        Me.Label15.Text = "*Select P/O Items and Click +"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 508)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 405
        Me.Label16.Text = "Remark"
        '
        'lblQtyMisMatchReason
        '
        Me.lblQtyMisMatchReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQtyMisMatchReason.AutoSize = True
        Me.lblQtyMisMatchReason.Location = New System.Drawing.Point(362, 508)
        Me.lblQtyMisMatchReason.Name = "lblQtyMisMatchReason"
        Me.lblQtyMisMatchReason.Size = New System.Drawing.Size(118, 13)
        Me.lblQtyMisMatchReason.TabIndex = 407
        Me.lblQtyMisMatchReason.Text = "Qty Mismatch Reason"
        '
        'cboQtyMismatchReason
        '
        Me.cboQtyMismatchReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboQtyMismatchReason.FormattingEnabled = True
        Me.cboQtyMismatchReason.Location = New System.Drawing.Point(365, 524)
        Me.cboQtyMismatchReason.Name = "cboQtyMismatchReason"
        Me.cboQtyMismatchReason.Size = New System.Drawing.Size(202, 21)
        Me.cboQtyMismatchReason.TabIndex = 406
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmYarnInPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1176, 589)
        Me.Controls.Add(Me.lblQtyMisMatchReason)
        Me.Controls.Add(Me.cboQtyMismatchReason)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtItmFind)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvPO)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvYarnIN)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYarnInPurchase"
        Me.Text = "New Yarn IN"
        CType(Me.dgvYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvYarnIN As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPONo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSuppInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSuppLot As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppRefNo As System.Windows.Forms.TextBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTubes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTotalGrossWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBoxes As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblYINno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnPrintBarcode As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvPO As System.Windows.Forms.DataGridView
    Friend WithEvents yarn_location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpSinvdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents rptPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbomtlWarehouse As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cbomtlLocations As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cbomtlSubinventory As ComboBox
    Friend WithEvents txtItmFind As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCopy As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblQtyMisMatchReason As Label
    Friend WithEvents cboQtyMismatchReason As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cboITCD As DataGridViewComboBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents box_remark As DataGridViewTextBoxColumn
    Friend WithEvents id_jobdet As DataGridViewTextBoxColumn
    Friend WithEvents colJobLineId2 As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents itcd As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewTextBoxColumn
    Friend WithEvents colQty2 As DataGridViewTextBoxColumn
    Friend WithEvents colUom2 As DataGridViewTextBoxColumn
    Friend WithEvents delidt As DataGridViewTextBoxColumn
    Friend WithEvents rcv_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents rcv_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents rcv_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents colJobLineId As DataGridViewTextBoxColumn
End Class
