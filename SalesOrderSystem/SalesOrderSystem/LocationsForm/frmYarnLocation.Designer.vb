<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnLocation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtLogNo = New System.Windows.Forms.TextBox()
        Me.grdTransfer = New System.Windows.Forms.DataGridView()
        Me.tr_chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tr_boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trmtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.trmtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.trmtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tr_spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpActualMoveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeselect = New System.Windows.Forms.Button()
        Me.grdYarnIN = New System.Windows.Forms.DataGridView()
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frmtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.frmtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.frmtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblTitleSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.lblCountHeader = New System.Windows.Forms.ToolStripLabel()
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpLogDate
        '
        Me.dtpLogDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpLogDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogDate.Location = New System.Drawing.Point(886, 56)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpLogDate.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(535, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Subinventory to"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(630, 56)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(111, 21)
        Me.cbomtl_subinventory.TabIndex = 119
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 118
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(142, 28)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(157, 20)
        Me.txtBarcode.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Y Barcode Or Items Code:"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "Doc No."
        '
        'cboDocNo
        '
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(125, 25)
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
        'txtLogNo
        '
        Me.txtLogNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogNo.Location = New System.Drawing.Point(886, 31)
        Me.txtLogNo.Name = "txtLogNo"
        Me.txtLogNo.Size = New System.Drawing.Size(104, 20)
        Me.txtLogNo.TabIndex = 104
        '
        'grdTransfer
        '
        Me.grdTransfer.AllowUserToAddRows = False
        Me.grdTransfer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTransfer.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransfer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTransfer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tr_chkSelect, Me.tr_boxno, Me.tr_boxno_s, Me.colLotno_our, Me.tr_loc, Me.trmtl_warehouse, Me.trmtl_subinventory_id, Me.trmtl_locations, Me.tr_spools, Me.tr_kg_gr, Me.tr_kg_nt, Me.tr_cart_tearwt})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTransfer.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdTransfer.Location = New System.Drawing.Point(622, 108)
        Me.grdTransfer.Name = "grdTransfer"
        Me.grdTransfer.Size = New System.Drawing.Size(368, 333)
        Me.grdTransfer.TabIndex = 107
        '
        'tr_chkSelect
        '
        Me.tr_chkSelect.DataPropertyName = "chkSelect"
        Me.tr_chkSelect.HeaderText = ""
        Me.tr_chkSelect.Name = "tr_chkSelect"
        Me.tr_chkSelect.ReadOnly = True
        Me.tr_chkSelect.Width = 25
        '
        'tr_boxno
        '
        Me.tr_boxno.DataPropertyName = "boxno"
        Me.tr_boxno.HeaderText = "Internal box no. (auto)"
        Me.tr_boxno.MaxInputLength = 15
        Me.tr_boxno.Name = "tr_boxno"
        Me.tr_boxno.ReadOnly = True
        Me.tr_boxno.Width = 85
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
        'colLotno_our
        '
        Me.colLotno_our.DataPropertyName = "lotno_our"
        Me.colLotno_our.HeaderText = "Lot No."
        Me.colLotno_our.Name = "colLotno_our"
        Me.colLotno_our.ReadOnly = True
        '
        'tr_loc
        '
        Me.tr_loc.DataPropertyName = "loc"
        Me.tr_loc.HeaderText = "Location to"
        Me.tr_loc.Name = "tr_loc"
        Me.tr_loc.ReadOnly = True
        Me.tr_loc.Visible = False
        '
        'trmtl_warehouse
        '
        Me.trmtl_warehouse.DataPropertyName = "mtl_warehouse_id_to"
        Me.trmtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_warehouse.HeaderText = "Warehouse to"
        Me.trmtl_warehouse.Name = "trmtl_warehouse"
        Me.trmtl_warehouse.ReadOnly = True
        Me.trmtl_warehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_warehouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'trmtl_subinventory_id
        '
        Me.trmtl_subinventory_id.DataPropertyName = "mtl_subinventory_id_to"
        Me.trmtl_subinventory_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_subinventory_id.HeaderText = "Subinventory To"
        Me.trmtl_subinventory_id.Name = "trmtl_subinventory_id"
        Me.trmtl_subinventory_id.ReadOnly = True
        Me.trmtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'trmtl_locations
        '
        Me.trmtl_locations.DataPropertyName = "mtl_locations_id_to"
        Me.trmtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_locations.HeaderText = "Locations to"
        Me.trmtl_locations.Name = "trmtl_locations"
        Me.trmtl_locations.ReadOnly = True
        Me.trmtl_locations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_locations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(830, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Doc Date"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(830, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Doc No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 100
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(298, 22)
        Me.ToolStripLabel2.Text = "เลือก WareHouse ที่จะย้ายไปด้วยครับ เช่น ESH (Eschler) "
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.Location = New System.Drawing.Point(584, 108)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(32, 32)
        Me.btnSelect.TabIndex = 106
        Me.btnSelect.Text = ">"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(534, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Location to"
        '
        'lblWarehourse
        '
        Me.lblWarehourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(535, 31)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(74, 13)
        Me.lblWarehourse.TabIndex = 115
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtl_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(630, 82)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(111, 21)
        Me.cbomtl_Location.TabIndex = 114
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(630, 31)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(111, 21)
        Me.cbomtl_warehouse.TabIndex = 113
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReceiveDate.Location = New System.Drawing.Point(441, 56)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpReceiveDate.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Receive Date"
        '
        'dtpActualMoveDate
        '
        Me.dtpActualMoveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpActualMoveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActualMoveDate.Location = New System.Drawing.Point(441, 31)
        Me.dtpActualMoveDate.Name = "dtpActualMoveDate"
        Me.dtpActualMoveDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpActualMoveDate.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Actual Move Date"
        '
        'btnDeselect
        '
        Me.btnDeselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeselect.Location = New System.Drawing.Point(584, 148)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(32, 32)
        Me.btnDeselect.TabIndex = 108
        Me.btnDeselect.Text = "<"
        Me.btnDeselect.UseVisualStyleBackColor = True
        '
        'grdYarnIN
        '
        Me.grdYarnIN.AllowUserToAddRows = False
        Me.grdYarnIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdYarnIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdYarnIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdYarnIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.boxno, Me.boxno_s, Me.lotno_our, Me.loc, Me.frmtl_warehouse, Me.frmtl_subinventory_id, Me.frmtl_locations, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdYarnIN.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdYarnIN.Location = New System.Drawing.Point(8, 108)
        Me.grdYarnIN.Name = "grdYarnIN"
        Me.grdYarnIN.Size = New System.Drawing.Size(570, 333)
        Me.grdYarnIN.TabIndex = 101
        '
        'chkSelect
        '
        Me.chkSelect.DataPropertyName = "chkSelect"
        Me.chkSelect.HeaderText = ""
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Width = 25
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 85
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.ReadOnly = True
        Me.boxno_s.Width = 75
        '
        'lotno_our
        '
        Me.lotno_our.DataPropertyName = "lotno_our"
        Me.lotno_our.HeaderText = "Lot No."
        Me.lotno_our.Name = "lotno_our"
        Me.lotno_our.ReadOnly = True
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.ReadOnly = True
        Me.loc.Visible = False
        '
        'frmtl_warehouse
        '
        Me.frmtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.frmtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_warehouse.HeaderText = "Warehouse"
        Me.frmtl_warehouse.Name = "frmtl_warehouse"
        Me.frmtl_warehouse.ReadOnly = True
        Me.frmtl_warehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.frmtl_warehouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmtl_subinventory_id
        '
        Me.frmtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.frmtl_subinventory_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_subinventory_id.HeaderText = "Subinventory"
        Me.frmtl_subinventory_id.Name = "frmtl_subinventory_id"
        '
        'frmtl_locations
        '
        Me.frmtl_locations.DataPropertyName = "mtl_locations_id"
        Me.frmtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_locations.HeaderText = "Locations"
        Me.frmtl_locations.Name = "frmtl_locations"
        Me.frmtl_locations.ReadOnly = True
        Me.frmtl_locations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.frmtl_locations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.ReadOnly = True
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.ReadOnly = True
        Me.kg_gr.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.ReadOnly = True
        Me.kg_nt.Width = 75
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.ReadOnly = True
        Me.cart_tearwt.Width = 75
        '
        'btnLocations
        '
        Me.btnLocations.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLocations.Location = New System.Drawing.Point(747, 26)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(77, 79)
        Me.btnLocations.TabIndex = 116
        Me.btnLocations.Text = "LOCATIONS MASTER"
        Me.btnLocations.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSum, Me.lblTitleSum, Me.lblCount, Me.lblCountHeader})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 461)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 323
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSum
        '
        Me.lblSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(13, 22)
        Me.lblSum.Text = "0"
        '
        'lblTitleSum
        '
        Me.lblTitleSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTitleSum.Name = "lblTitleSum"
        Me.lblTitleSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitleSum.Size = New System.Drawing.Size(40, 22)
        Me.lblTitleSum.Text = " Sum :"
        '
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 22)
        Me.lblCount.Text = "0"
        '
        'lblCountHeader
        '
        Me.lblCountHeader.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCountHeader.Name = "lblCountHeader"
        Me.lblCountHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountHeader.Size = New System.Drawing.Size(43, 22)
        Me.lblCountHeader.Text = "Count:"
        '
        'frmYarnLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 486)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.dtpLogDate)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLogNo)
        Me.Controls.Add(Me.grdTransfer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWarehourse)
        Me.Controls.Add(Me.cbomtl_Location)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.dtpReceiveDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpActualMoveDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDeselect)
        Me.Controls.Add(Me.grdYarnIN)
        Me.Name = "frmYarnLocation"
        Me.Text = "Yarn Transfer Location"
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpLogDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtLogNo As System.Windows.Forms.TextBox
    Friend WithEvents grdTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWarehourse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_Location As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpActualMoveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDeselect As System.Windows.Forms.Button
    Friend WithEvents grdYarnIN As System.Windows.Forms.DataGridView
    Friend WithEvents tr_chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tr_boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents trmtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents trmtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents trmtl_locations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tr_spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tr_cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frmtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents frmtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents frmtl_locations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLocations As Button
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblSum As ToolStripLabel
    Friend WithEvents lblTitleSum As ToolStripLabel
    Friend WithEvents lblCount As ToolStripLabel
    Friend WithEvents lblCountHeader As ToolStripLabel
End Class
