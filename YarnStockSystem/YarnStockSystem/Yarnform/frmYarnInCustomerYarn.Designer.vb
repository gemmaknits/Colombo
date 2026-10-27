<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnInCustomerYarn
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnInCustomerYarn))
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbograde_our = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboITCD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.id_jobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSinvno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLotno_sup = New System.Windows.Forms.TextBox()
        Me.grdYarnINDet = New System.Windows.Forms.DataGridView()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc_sub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalGrossWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox()
        Me.txtTotalTubes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotalBoxes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.dtpDocDt = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpSinvdt = New System.Windows.Forms.DateTimePicker()
        Me.txtPurNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSrefno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtItmFind = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnPrnYarnTest = New System.Windows.Forms.Button()
        Me.cboGKNo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbomtl_locations = New System.Windows.Forms.ComboBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.delidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty_bal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdJobDet = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEditYarnTest = New System.Windows.Forms.Button()
        Me.btnNewYarnTest = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.grdYarnINDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdJobDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 60
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
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 75
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 50
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.Width = 75
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MaxInputLength = 15
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 50
        '
        'cbograde_our
        '
        Me.cbograde_our.DataPropertyName = "grade_our"
        Me.cbograde_our.HeaderText = "Grade Our"
        Me.cbograde_our.Name = "cbograde_our"
        Me.cbograde_our.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbograde_our.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbograde_our.Width = 60
        '
        'cboITCD
        '
        Me.cboITCD.DataPropertyName = "itcd"
        Me.cboITCD.HeaderText = "Description"
        Me.cboITCD.Name = "cboITCD"
        Me.cboITCD.ReadOnly = True
        Me.cboITCD.Width = 250
        '
        'id_jobdet
        '
        Me.id_jobdet.DataPropertyName = "id_jobdet"
        Me.id_jobdet.HeaderText = "P/O Line ID"
        Me.id_jobdet.Name = "id_jobdet"
        Me.id_jobdet.ReadOnly = True
        Me.id_jobdet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_jobdet.Width = 50
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Width = 75
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "sel"
        Me.sel.Name = "sel"
        Me.sel.Visible = False
        Me.sel.Width = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(80, 48)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(264, 21)
        Me.cboSupplier.TabIndex = 1
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Date:"
        '
        'txtSinvno
        '
        Me.txtSinvno.Location = New System.Drawing.Point(80, 74)
        Me.txtSinvno.Name = "txtSinvno"
        Me.txtSinvno.Size = New System.Drawing.Size(96, 22)
        Me.txtSinvno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtLotno_sup
        '
        Me.txtLotno_sup.Location = New System.Drawing.Point(248, 74)
        Me.txtLotno_sup.Name = "txtLotno_sup"
        Me.txtLotno_sup.Size = New System.Drawing.Size(96, 22)
        Me.txtLotno_sup.TabIndex = 3
        '
        'grdYarnINDet
        '
        Me.grdYarnINDet.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnINDet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdYarnINDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnINDet.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdYarnINDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdYarnINDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.id_jobdet, Me.cboITCD, Me.cbograde_our, Me.Grade, Me.boxno_s, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt, Me.boxno, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.loc, Me.loc_sub, Me.box_remark})
        Me.grdYarnINDet.Location = New System.Drawing.Point(7, 216)
        Me.grdYarnINDet.Name = "grdYarnINDet"
        Me.grdYarnINDet.Size = New System.Drawing.Size(965, 280)
        Me.grdYarnINDet.TabIndex = 383
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_warehouse_id.Visible = False
        Me.mtl_warehouse_id.Width = 70
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "Subinventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Visible = False
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Location"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_locations_id.Visible = False
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Loc"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'loc_sub
        '
        Me.loc_sub.DataPropertyName = "loc_sub"
        Me.loc_sub.HeaderText = "Sub Location"
        Me.loc_sub.Name = "loc_sub"
        '
        'box_remark
        '
        Me.box_remark.DataPropertyName = "box_remark"
        Me.box_remark.HeaderText = "Remark"
        Me.box_remark.Name = "box_remark"
        Me.box_remark.Width = 150
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
        Me.GroupBox4.Location = New System.Drawing.Point(375, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox4.TabIndex = 391
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
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(8, 16)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(344, 56)
        Me.txtRemark.TabIndex = 0
        '
        'txtitcd
        '
        Me.txtitcd.Location = New System.Drawing.Point(17, 34)
        Me.txtitcd.Name = "txtitcd"
        Me.txtitcd.Size = New System.Drawing.Size(100, 20)
        Me.txtitcd.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 504)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox3.TabIndex = 390
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(182, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 13)
        Me.Label16.TabIndex = 381
        Me.Label16.Text = "***ต้องมีลุกค้าเป็น Supplier"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtDocNo)
        Me.GroupBox5.Controls.Add(Me.dtpDocDt)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(735, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 96)
        Me.GroupBox5.TabIndex = 392
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(82, 21)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(134, 22)
        Me.txtDocNo.TabIndex = 0
        '
        'dtpDocDt
        '
        Me.dtpDocDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpDocDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDt.Location = New System.Drawing.Point(82, 45)
        Me.dtpDocDt.Name = "dtpDocDt"
        Me.dtpDocDt.Size = New System.Drawing.Size(134, 22)
        Me.dtpDocDt.TabIndex = 1
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Y-IN No.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 22)
        Me.TextBox24.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-158, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'dtpSinvdt
        '
        Me.dtpSinvdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpSinvdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSinvdt.Location = New System.Drawing.Point(80, 98)
        Me.dtpSinvdt.Name = "dtpSinvdt"
        Me.dtpSinvdt.Size = New System.Drawing.Size(96, 22)
        Me.dtpSinvdt.TabIndex = 100
        '
        'txtPurNo
        '
        Me.txtPurNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPurNo.Location = New System.Drawing.Point(80, 22)
        Me.txtPurNo.Name = "txtPurNo"
        Me.txtPurNo.ReadOnly = True
        Me.txtPurNo.Size = New System.Drawing.Size(96, 20)
        Me.txtPurNo.TabIndex = 0
        Me.txtPurNo.Text = "COMMPROC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PO No."
        '
        'txtSrefno
        '
        Me.txtSrefno.Location = New System.Drawing.Point(248, 98)
        Me.txtSrefno.Name = "txtSrefno"
        Me.txtSrefno.Size = New System.Drawing.Size(96, 22)
        Me.txtSrefno.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.dtpSinvdt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSinvno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtLotno_sup)
        Me.GroupBox1.Controls.Add(Me.txtPurNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSrefno)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 123)
        Me.GroupBox1.TabIndex = 388
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier details:"
        '
        'txtItmFind
        '
        Me.txtItmFind.Location = New System.Drawing.Point(517, 13)
        Me.txtItmFind.Name = "txtItmFind"
        Me.txtItmFind.Size = New System.Drawing.Size(133, 20)
        Me.txtItmFind.TabIndex = 399
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnEditYarnTest)
        Me.GroupBox6.Controls.Add(Me.btnNewYarnTest)
        Me.GroupBox6.Controls.Add(Me.btnPrnYarnTest)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.cboGKNo)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 133)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 77)
        Me.GroupBox6.TabIndex = 400
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Yarn Test Requirement Form (YT)"
        '
        'btnPrnYarnTest
        '
        Me.btnPrnYarnTest.Location = New System.Drawing.Point(215, 45)
        Me.btnPrnYarnTest.Name = "btnPrnYarnTest"
        Me.btnPrnYarnTest.Size = New System.Drawing.Size(97, 29)
        Me.btnPrnYarnTest.TabIndex = 359
        Me.btnPrnYarnTest.Text = "Yarn Test Form"
        Me.btnPrnYarnTest.UseVisualStyleBackColor = True
        '
        'cboGKNo
        '
        Me.cboGKNo.FormattingEnabled = True
        Me.cboGKNo.Location = New System.Drawing.Point(89, 22)
        Me.cboGKNo.Name = "cboGKNo"
        Me.cboGKNo.Size = New System.Drawing.Size(112, 21)
        Me.cboGKNo.TabIndex = 361
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 360
        Me.Label12.Text = "GK-No :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(39, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 298
        Me.Label18.Text = "W/H"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_subinventory.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 295
        Me.Label17.Text = "Sub Inven"
        '
        'cbomtl_locations
        '
        Me.cbomtl_locations.FormattingEnabled = True
        Me.cbomtl_locations.Location = New System.Drawing.Point(82, 73)
        Me.cbomtl_locations.Name = "cbomtl_locations"
        Me.cbomtl_locations.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_locations.TabIndex = 4
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_warehouse.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = "Location"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbomtl_locations)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(736, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 99)
        Me.GroupBox2.TabIndex = 397
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Address Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(373, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 13)
        Me.Label14.TabIndex = 398
        Me.Label14.Text = "Look Up (Key Enter to Find)"
        '
        'delidt
        '
        Me.delidt.DataPropertyName = "delidt"
        Me.delidt.HeaderText = "Delivery"
        Me.delidt.Name = "delidt"
        Me.delidt.ReadOnly = True
        '
        'qty_bal
        '
        Me.qty_bal.DataPropertyName = "qty_bal"
        Me.qty_bal.HeaderText = "Balance Qty"
        Me.qty_bal.Name = "qty_bal"
        Me.qty_bal.ReadOnly = True
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 80
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(552, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 13)
        Me.Label15.TabIndex = 401
        Me.Label15.Text = "*Select P/O Items and Click +"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(657, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 396
        Me.Label10.Text = "*Key Enter to copy item"
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 70
        '
        'grdJobDet
        '
        Me.grdJobDet.AllowUserToAddRows = False
        Me.grdJobDet.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdJobDet.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdJobDet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdJobDet.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdJobDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdJobDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.itcd, Me.qty, Me.qty_bal, Me.delidt})
        Me.grdJobDet.Location = New System.Drawing.Point(375, 36)
        Me.grdJobDet.Name = "grdJobDet"
        Me.grdJobDet.RowHeadersVisible = False
        Me.grdJobDet.Size = New System.Drawing.Size(354, 143)
        Me.grdJobDet.TabIndex = 382
        '
        'colID
        '
        Me.colID.DataPropertyName = "id_jobdet"
        Me.colID.HeaderText = "P/O Line ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Width = 50
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(808, 504)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 393
        Me.Label9.Text = "*1 Yarn IN Only 1 P/O Item"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnDel
        '
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.Location = New System.Drawing.Point(446, 183)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(30, 25)
        Me.btnDel.TabIndex = 395
        Me.btnDel.Tag = "Delete"
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Location = New System.Drawing.Point(409, 183)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(30, 25)
        Me.btnCopy.TabIndex = 402
        Me.btnCopy.Tag = "Copy"
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(788, 528)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(60, 44)
        Me.btnPrint.TabIndex = 386
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnEditYarnTest
        '
        Me.btnEditYarnTest.Image = Global.YarnStockSystem.My.Resources.Resources.EditWindow_16x
        Me.btnEditYarnTest.Location = New System.Drawing.Point(248, 19)
        Me.btnEditYarnTest.Name = "btnEditYarnTest"
        Me.btnEditYarnTest.Size = New System.Drawing.Size(30, 25)
        Me.btnEditYarnTest.TabIndex = 365
        Me.btnEditYarnTest.UseVisualStyleBackColor = True
        '
        'btnNewYarnTest
        '
        Me.btnNewYarnTest.Image = Global.YarnStockSystem.My.Resources.Resources.NewTest_16x
        Me.btnNewYarnTest.Location = New System.Drawing.Point(215, 19)
        Me.btnNewYarnTest.Name = "btnNewYarnTest"
        Me.btnNewYarnTest.Size = New System.Drawing.Size(30, 25)
        Me.btnNewYarnTest.TabIndex = 364
        Me.btnNewYarnTest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.YarnStockSystem.My.Resources.Resources.Print_16x
        Me.Button1.Location = New System.Drawing.Point(282, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 25)
        Me.Button1.TabIndex = 363
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(724, 528)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 44)
        Me.btnSave.TabIndex = 385
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(373, 184)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 25)
        Me.btnAdd.TabIndex = 394
        Me.btnAdd.Tag = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(660, 528)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 44)
        Me.btnNew.TabIndex = 384
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
        Me.btnPrintBarcode.Location = New System.Drawing.Point(852, 528)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(60, 44)
        Me.btnPrintBarcode.TabIndex = 387
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
        Me.btnExit.Location = New System.Drawing.Point(916, 528)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 44)
        Me.btnExit.TabIndex = 389
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmYarnInCustomerYarn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 592)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.grdYarnINDet)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtItmFind)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grdJobDet)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frmYarnInCustomerYarn"
        Me.Text = "Yarn In - Customer Yarn"
        CType(Me.grdYarnINDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdJobDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents cbograde_our As DataGridViewComboBoxColumn
    Friend WithEvents cboITCD As DataGridViewComboBoxColumn
    Friend WithEvents id_jobdet As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSinvno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLotno_sup As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents grdYarnINDet As DataGridView
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents loc As DataGridViewComboBoxColumn
    Friend WithEvents loc_sub As DataGridViewTextBoxColumn
    Friend WithEvents box_remark As DataGridViewTextBoxColumn
    Friend WithEvents btnCopy As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTotalGrossWeight As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalNetWeight As TextBox
    Friend WithEvents txtTotalTubes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTotalBoxes As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtitcd As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents dtpDocDt As DateTimePicker
    Friend WithEvents lblYINno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents dtpSinvdt As DateTimePicker
    Friend WithEvents txtPurNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSrefno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtItmFind As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnEditYarnTest As Button
    Friend WithEvents btnNewYarnTest As Button
    Friend WithEvents btnPrnYarnTest As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cboGKNo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbomtl_locations As ComboBox
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents delidt As DataGridViewTextBoxColumn
    Friend WithEvents qty_bal As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnPrintBarcode As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents itcd As DataGridViewTextBoxColumn
    Friend WithEvents grdJobDet As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
