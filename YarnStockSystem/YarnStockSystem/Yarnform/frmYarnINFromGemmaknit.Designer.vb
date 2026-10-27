<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnINFromGemmaknit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnINFromGemmaknit))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtYINNo = New System.Windows.Forms.TextBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.grdTransfer = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnDeselect = New System.Windows.Forms.Button()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.grdYarnIN = New System.Windows.Forms.DataGridView()
        Me.yn_chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.yn_boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_itcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.yn_lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.yn_mtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.yn_kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yn_cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtLogNo = New System.Windows.Forms.TextBox()
        Me.lblLogNo = New System.Windows.Forms.Label()
        Me.gbTransfer = New System.Windows.Forms.GroupBox()
        Me.btnChangeYarnCode = New System.Windows.Forms.Button()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboYarnCode = New System.Windows.Forms.ComboBox()
        Me.txtlotno_sup = New System.Windows.Forms.TextBox()
        Me.txtSuppRefNo = New System.Windows.Forms.TextBox()
        Me.lblSinvdt = New System.Windows.Forms.Label()
        Me.dtpLogDt = New System.Windows.Forms.DateTimePicker()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tr_chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tr_boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_itcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tr_Lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tr_mtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tr_spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.gbTransfer.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtYINNo)
        Me.GroupBox5.Controls.Add(Me.dtpDocDate)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(752, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(187, 93)
        Me.GroupBox5.TabIndex = 114
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'txtYINNo
        '
        Me.txtYINNo.Location = New System.Drawing.Point(71, 20)
        Me.txtYINNo.Name = "txtYINNo"
        Me.txtYINNo.Size = New System.Drawing.Size(96, 20)
        Me.txtYINNo.TabIndex = 0
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDate.Location = New System.Drawing.Point(71, 49)
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
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 20)
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
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(384, 133)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(32, 32)
        Me.btnSelect.TabIndex = 125
        Me.btnSelect.Text = ">"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'grdTransfer
        '
        Me.grdTransfer.AllowUserToAddRows = False
        Me.grdTransfer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdTransfer.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTransfer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tr_chkSelect, Me.tr_boxno, Me.tr_boxno_s, Me.tr_itcd, Me.tr_Lotno_our, Me.tr_loc, Me.tr_mtl_warehouse, Me.tr_mtl_locations, Me.tr_spools, Me.tr_kg_gr, Me.tr_kg_nt, Me.tr_cart_tearwt})
        Me.grdTransfer.Location = New System.Drawing.Point(11, 133)
        Me.grdTransfer.Name = "grdTransfer"
        Me.grdTransfer.Size = New System.Drawing.Size(368, 405)
        Me.grdTransfer.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Location"
        '
        'btnLoad
        '
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Location = New System.Drawing.Point(201, 22)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(29, 24)
        Me.btnLoad.TabIndex = 128
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnDeselect
        '
        Me.btnDeselect.Location = New System.Drawing.Point(384, 171)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(32, 32)
        Me.btnDeselect.TabIndex = 127
        Me.btnDeselect.Text = "<"
        Me.btnDeselect.UseVisualStyleBackColor = True
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
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'grdYarnIN
        '
        Me.grdYarnIN.AllowUserToAddRows = False
        Me.grdYarnIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdYarnIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdYarnIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.yn_chkSelect, Me.yn_boxno, Me.yn_boxno_s, Me.yn_itcd, Me.yn_lotno_our, Me.yn_loc, Me.yn_spools, Me.yn_mtl_warehouse, Me.yn_mtl_locations, Me.yn_kg_gr, Me.yn_kg_nt, Me.yn_cart_tearwt})
        Me.grdYarnIN.Location = New System.Drawing.Point(422, 133)
        Me.grdYarnIN.Name = "grdYarnIN"
        Me.grdYarnIN.Size = New System.Drawing.Size(518, 405)
        Me.grdYarnIN.TabIndex = 116
        '
        'yn_chkSelect
        '
        Me.yn_chkSelect.DataPropertyName = "chkSelect"
        Me.yn_chkSelect.HeaderText = ""
        Me.yn_chkSelect.Name = "yn_chkSelect"
        Me.yn_chkSelect.Width = 25
        '
        'yn_boxno
        '
        Me.yn_boxno.DataPropertyName = "boxno"
        Me.yn_boxno.HeaderText = "Internal box no. (auto)"
        Me.yn_boxno.MaxInputLength = 15
        Me.yn_boxno.Name = "yn_boxno"
        Me.yn_boxno.ReadOnly = True
        Me.yn_boxno.Width = 75
        '
        'yn_boxno_s
        '
        Me.yn_boxno_s.DataPropertyName = "boxno_s"
        Me.yn_boxno_s.HeaderText = "Supplier Box no."
        Me.yn_boxno_s.MaxInputLength = 15
        Me.yn_boxno_s.Name = "yn_boxno_s"
        Me.yn_boxno_s.ReadOnly = True
        Me.yn_boxno_s.Width = 75
        '
        'yn_itcd
        '
        Me.yn_itcd.DataPropertyName = "itcd"
        Me.yn_itcd.HeaderText = "Item Code"
        Me.yn_itcd.Name = "yn_itcd"
        Me.yn_itcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yn_itcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'yn_lotno_our
        '
        Me.yn_lotno_our.DataPropertyName = "lotno_our"
        Me.yn_lotno_our.HeaderText = "Lot No."
        Me.yn_lotno_our.Name = "yn_lotno_our"
        Me.yn_lotno_our.ReadOnly = True
        '
        'yn_loc
        '
        Me.yn_loc.DataPropertyName = "loc"
        Me.yn_loc.HeaderText = "Location"
        Me.yn_loc.Name = "yn_loc"
        Me.yn_loc.ReadOnly = True
        '
        'yn_spools
        '
        Me.yn_spools.DataPropertyName = "spools"
        Me.yn_spools.HeaderText = "Tube /Spools"
        Me.yn_spools.MaxInputLength = 15
        Me.yn_spools.Name = "yn_spools"
        Me.yn_spools.ReadOnly = True
        Me.yn_spools.Width = 50
        '
        'yn_mtl_warehouse
        '
        Me.yn_mtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.yn_mtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.yn_mtl_warehouse.HeaderText = "Warehouse"
        Me.yn_mtl_warehouse.Name = "yn_mtl_warehouse"
        Me.yn_mtl_warehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yn_mtl_warehouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'yn_mtl_locations
        '
        Me.yn_mtl_locations.DataPropertyName = "mtl_locations_id"
        Me.yn_mtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.yn_mtl_locations.HeaderText = "Locations"
        Me.yn_mtl_locations.Name = "yn_mtl_locations"
        Me.yn_mtl_locations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yn_mtl_locations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'yn_kg_gr
        '
        Me.yn_kg_gr.DataPropertyName = "kg_gr"
        Me.yn_kg_gr.HeaderText = "Gross weight{Kg}"
        Me.yn_kg_gr.MaxInputLength = 15
        Me.yn_kg_gr.Name = "yn_kg_gr"
        Me.yn_kg_gr.ReadOnly = True
        Me.yn_kg_gr.Width = 75
        '
        'yn_kg_nt
        '
        Me.yn_kg_nt.DataPropertyName = "kg_nt"
        Me.yn_kg_nt.HeaderText = "Net weight{Kg}"
        Me.yn_kg_nt.MaxInputLength = 15
        Me.yn_kg_nt.Name = "yn_kg_nt"
        Me.yn_kg_nt.ReadOnly = True
        Me.yn_kg_nt.Width = 75
        '
        'yn_cart_tearwt
        '
        Me.yn_cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.yn_cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.yn_cart_tearwt.MaxInputLength = 15
        Me.yn_cart_tearwt.Name = "yn_cart_tearwt"
        Me.yn_cart_tearwt.ReadOnly = True
        Me.yn_cart_tearwt.Width = 75
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "YIN No."
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
        'cboDocNo
        '
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(125, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(952, 25)
        Me.ToolStrip1.TabIndex = 115
        '
        'txtLogNo
        '
        Me.txtLogNo.Location = New System.Drawing.Point(67, 23)
        Me.txtLogNo.Name = "txtLogNo"
        Me.txtLogNo.Size = New System.Drawing.Size(128, 20)
        Me.txtLogNo.TabIndex = 134
        '
        'lblLogNo
        '
        Me.lblLogNo.AutoSize = True
        Me.lblLogNo.Location = New System.Drawing.Point(14, 23)
        Me.lblLogNo.Name = "lblLogNo"
        Me.lblLogNo.Size = New System.Drawing.Size(47, 13)
        Me.lblLogNo.TabIndex = 133
        Me.lblLogNo.Text = "Doc No."
        '
        'gbTransfer
        '
        Me.gbTransfer.Controls.Add(Me.btnChangeYarnCode)
        Me.gbTransfer.Controls.Add(Me.cboSupplier)
        Me.gbTransfer.Controls.Add(Me.Label11)
        Me.gbTransfer.Controls.Add(Me.Label17)
        Me.gbTransfer.Controls.Add(Me.Label6)
        Me.gbTransfer.Controls.Add(Me.Label5)
        Me.gbTransfer.Controls.Add(Me.cboYarnCode)
        Me.gbTransfer.Controls.Add(Me.txtlotno_sup)
        Me.gbTransfer.Controls.Add(Me.txtSuppRefNo)
        Me.gbTransfer.Controls.Add(Me.lblSinvdt)
        Me.gbTransfer.Controls.Add(Me.dtpLogDt)
        Me.gbTransfer.Controls.Add(Me.cbomtl_Location)
        Me.gbTransfer.Controls.Add(Me.lblWarehourse)
        Me.gbTransfer.Controls.Add(Me.cbomtl_warehouse)
        Me.gbTransfer.Controls.Add(Me.btnLoad)
        Me.gbTransfer.Controls.Add(Me.lblLogNo)
        Me.gbTransfer.Controls.Add(Me.txtLogNo)
        Me.gbTransfer.Controls.Add(Me.Label4)
        Me.gbTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbTransfer.Location = New System.Drawing.Point(12, 28)
        Me.gbTransfer.Name = "gbTransfer"
        Me.gbTransfer.Size = New System.Drawing.Size(734, 93)
        Me.gbTransfer.TabIndex = 135
        Me.gbTransfer.TabStop = False
        Me.gbTransfer.Text = "Supplier Detail"
        '
        'btnChangeYarnCode
        '
        Me.btnChangeYarnCode.Location = New System.Drawing.Point(483, 61)
        Me.btnChangeYarnCode.Name = "btnChangeYarnCode"
        Me.btnChangeYarnCode.Size = New System.Drawing.Size(32, 24)
        Me.btnChangeYarnCode.TabIndex = 157
        Me.btnChangeYarnCode.Text = "OK"
        Me.btnChangeYarnCode.UseVisualStyleBackColor = True
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Gold
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(614, 15)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(114, 21)
        Me.cboSupplier.TabIndex = 144
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(557, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "Supplier:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(206, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 158
        Me.Label17.Text = "Change Yarn Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(557, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Sup.Lot#:"
        '
        'cboYarnCode
        '
        Me.cboYarnCode.FormattingEnabled = True
        Me.cboYarnCode.Location = New System.Drawing.Point(309, 65)
        Me.cboYarnCode.Name = "cboYarnCode"
        Me.cboYarnCode.Size = New System.Drawing.Size(168, 21)
        Me.cboYarnCode.TabIndex = 156
        '
        'txtlotno_sup
        '
        Me.txtlotno_sup.BackColor = System.Drawing.Color.Gold
        Me.txtlotno_sup.Location = New System.Drawing.Point(614, 42)
        Me.txtlotno_sup.Name = "txtlotno_sup"
        Me.txtlotno_sup.Size = New System.Drawing.Size(114, 20)
        Me.txtlotno_sup.TabIndex = 140
        '
        'txtSuppRefNo
        '
        Me.txtSuppRefNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuppRefNo.Location = New System.Drawing.Point(614, 68)
        Me.txtSuppRefNo.Name = "txtSuppRefNo"
        Me.txtSuppRefNo.Size = New System.Drawing.Size(114, 20)
        Me.txtSuppRefNo.TabIndex = 141
        '
        'lblSinvdt
        '
        Me.lblSinvdt.AutoSize = True
        Me.lblSinvdt.Location = New System.Drawing.Point(14, 63)
        Me.lblSinvdt.Name = "lblSinvdt"
        Me.lblSinvdt.Size = New System.Drawing.Size(30, 13)
        Me.lblSinvdt.TabIndex = 139
        Me.lblSinvdt.Text = "Date"
        '
        'dtpLogDt
        '
        Me.dtpLogDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogDt.Location = New System.Drawing.Point(67, 61)
        Me.dtpLogDt.Name = "dtpLogDt"
        Me.dtpLogDt.Size = New System.Drawing.Size(128, 20)
        Me.dtpLogDt.TabIndex = 138
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(309, 40)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(85, 21)
        Me.cbomtl_Location.TabIndex = 137
        '
        'lblWarehourse
        '
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(238, 17)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(65, 13)
        Me.lblWarehourse.TabIndex = 136
        Me.lblWarehourse.Text = "Warehourse"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(309, 17)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(85, 21)
        Me.cbomtl_warehouse.TabIndex = 135
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 544)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
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
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBarcode.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrintBarcode.Image = CType(resources.GetObject("btnPrintBarcode.Image"), System.Drawing.Image)
        Me.btnPrintBarcode.Location = New System.Drawing.Point(814, 559)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(60, 44)
        Me.btnPrintBarcode.TabIndex = 137
        Me.btnPrintBarcode.Text = "Print bar label"
        Me.btnPrintBarcode.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrintBarcode.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("IDAutomationHC39M", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 319
        Me.Label1.Text = "*NEW*"
        '
        'tr_chkSelect
        '
        Me.tr_chkSelect.DataPropertyName = "chkSelect"
        Me.tr_chkSelect.HeaderText = ""
        Me.tr_chkSelect.Name = "tr_chkSelect"
        Me.tr_chkSelect.Width = 25
        '
        'tr_boxno
        '
        Me.tr_boxno.DataPropertyName = "boxno"
        Me.tr_boxno.HeaderText = "Internal box no. (auto)"
        Me.tr_boxno.MaxInputLength = 15
        Me.tr_boxno.Name = "tr_boxno"
        Me.tr_boxno.ReadOnly = True
        Me.tr_boxno.Width = 75
        '
        'tr_boxno_s
        '
        Me.tr_boxno_s.DataPropertyName = "boxno_s"
        Me.tr_boxno_s.HeaderText = "Supplier Box no."
        Me.tr_boxno_s.MaxInputLength = 15
        Me.tr_boxno_s.Name = "tr_boxno_s"
        Me.tr_boxno_s.ReadOnly = True
        Me.tr_boxno_s.Width = 75
        '
        'tr_itcd
        '
        Me.tr_itcd.DataPropertyName = "itcd"
        Me.tr_itcd.HeaderText = "Items Code"
        Me.tr_itcd.Name = "tr_itcd"
        Me.tr_itcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tr_itcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'tr_Lotno_our
        '
        Me.tr_Lotno_our.DataPropertyName = "lotno_our"
        Me.tr_Lotno_our.HeaderText = "Lot No."
        Me.tr_Lotno_our.Name = "tr_Lotno_our"
        Me.tr_Lotno_our.ReadOnly = True
        '
        'tr_loc
        '
        Me.tr_loc.DataPropertyName = "loc"
        Me.tr_loc.HeaderText = "Location"
        Me.tr_loc.Name = "tr_loc"
        Me.tr_loc.ReadOnly = True
        '
        'tr_mtl_warehouse
        '
        Me.tr_mtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.tr_mtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.tr_mtl_warehouse.HeaderText = "Warehouse"
        Me.tr_mtl_warehouse.Name = "tr_mtl_warehouse"
        Me.tr_mtl_warehouse.ReadOnly = True
        Me.tr_mtl_warehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tr_mtl_warehouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'tr_mtl_locations
        '
        Me.tr_mtl_locations.DataPropertyName = "mtl_locations_id"
        Me.tr_mtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.tr_mtl_locations.HeaderText = "Locations"
        Me.tr_mtl_locations.Name = "tr_mtl_locations"
        Me.tr_mtl_locations.ReadOnly = True
        Me.tr_mtl_locations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tr_mtl_locations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'tr_spools
        '
        Me.tr_spools.DataPropertyName = "spools"
        Me.tr_spools.HeaderText = "Tube /Spools"
        Me.tr_spools.MaxInputLength = 15
        Me.tr_spools.Name = "tr_spools"
        Me.tr_spools.ReadOnly = True
        Me.tr_spools.Width = 50
        '
        'tr_kg_gr
        '
        Me.tr_kg_gr.DataPropertyName = "kg_gr"
        Me.tr_kg_gr.HeaderText = "Gross weight{Kg}"
        Me.tr_kg_gr.MaxInputLength = 15
        Me.tr_kg_gr.Name = "tr_kg_gr"
        Me.tr_kg_gr.ReadOnly = True
        Me.tr_kg_gr.Width = 75
        '
        'tr_kg_nt
        '
        Me.tr_kg_nt.DataPropertyName = "kg_nt"
        Me.tr_kg_nt.HeaderText = "Net weight{Kg}"
        Me.tr_kg_nt.MaxInputLength = 15
        Me.tr_kg_nt.Name = "tr_kg_nt"
        Me.tr_kg_nt.ReadOnly = True
        Me.tr_kg_nt.Width = 75
        '
        'tr_cart_tearwt
        '
        Me.tr_cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.tr_cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.tr_cart_tearwt.MaxInputLength = 15
        Me.tr_cart_tearwt.Name = "tr_cart_tearwt"
        Me.tr_cart_tearwt.ReadOnly = True
        Me.tr_cart_tearwt.Width = 75
        '
        'frmYarnINFromGemmaknit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbTransfer)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.grdTransfer)
        Me.Controls.Add(Me.btnDeselect)
        Me.Controls.Add(Me.grdYarnIN)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "frmYarnINFromGemmaknit"
        Me.Text = "Yarn IN Transfer From Gemmaknit"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbTransfer.ResumeLayout(False)
        Me.gbTransfer.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYINNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblYINno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents grdTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnDeselect As System.Windows.Forms.Button
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdYarnIN As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtLogNo As System.Windows.Forms.TextBox
    Friend WithEvents lblLogNo As System.Windows.Forms.Label
    Friend WithEvents gbTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents cbomtl_Location As System.Windows.Forms.ComboBox
    Friend WithEvents lblWarehourse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblSinvdt As System.Windows.Forms.Label
    Friend WithEvents dtpLogDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlotno_sup As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppRefNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtitcd As System.Windows.Forms.TextBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnChangeYarnCode As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cboYarnCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrintBarcode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yn_chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents yn_boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_itcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents yn_lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_mtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents yn_mtl_locations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents yn_kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yn_cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tr_boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_itcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tr_Lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_mtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tr_mtl_locations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tr_spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
