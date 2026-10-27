<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangerOutBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangerOutBarcode))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintHangerOut = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbRollNoD = New System.Windows.Forms.Label()
        Me.txtRollNoD = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddr1 = New System.Windows.Forms.TextBox()
        Me.cboempcd = New System.Windows.Forms.ComboBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.btnSearchCustomers = New System.Windows.Forms.Button()
        Me.grdHanger = New System.Windows.Forms.DataGridView()
        Me.grdHangerINSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdHangerINStrollsDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINComPo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINgmpersqm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINSoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINBalKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdHangerINSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINLocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpPackdt = New System.Windows.Forms.DateTimePicker()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpOutDt = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOutno = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdHanger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.btnPrintHangerOut, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1097, 25)
        Me.ToolStrip1.TabIndex = 328
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
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 22)
        Me.btnCancel.Text = "Cancel Document"
        '
        'btnPrintHangerOut
        '
        Me.btnPrintHangerOut.Image = CType(resources.GetObject("btnPrintHangerOut.Image"), System.Drawing.Image)
        Me.btnPrintHangerOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintHangerOut.Name = "btnPrintHangerOut"
        Me.btnPrintHangerOut.Size = New System.Drawing.Size(184, 22)
        Me.btnPrintHangerOut.Tag = "p_mfg_dout_sample_pkg_pls_rep"
        Me.btnPrintHangerOut.Text = "Print (Hanger Out Document)"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbRollNoD)
        Me.GroupBox1.Controls.Add(Me.txtRollNoD)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 95)
        Me.GroupBox1.TabIndex = 336
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Filter"
        '
        'lbRollNoD
        '
        Me.lbRollNoD.AutoSize = True
        Me.lbRollNoD.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRollNoD.Location = New System.Drawing.Point(12, 24)
        Me.lbRollNoD.Name = "lbRollNoD"
        Me.lbRollNoD.Size = New System.Drawing.Size(77, 17)
        Me.lbRollNoD.TabIndex = 2
        Me.lbRollNoD.Text = "Hanger Tag"
        '
        'txtRollNoD
        '
        Me.txtRollNoD.Location = New System.Drawing.Point(15, 50)
        Me.txtRollNoD.Name = "txtRollNoD"
        Me.txtRollNoD.Size = New System.Drawing.Size(122, 25)
        Me.txtRollNoD.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtaddr1)
        Me.GroupBox2.Controls.Add(Me.cboempcd)
        Me.GroupBox2.Controls.Add(Me.txtRemark)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboDocType)
        Me.GroupBox2.Controls.Add(Me.btnSearchCustomers)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(188, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 167)
        Me.GroupBox2.TabIndex = 340
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(480, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 344
        Me.Label6.Text = "Remark"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 340
        Me.Label8.Text = "Cust Address."
        '
        'txtaddr1
        '
        Me.txtaddr1.Enabled = False
        Me.txtaddr1.Location = New System.Drawing.Point(213, 98)
        Me.txtaddr1.Multiline = True
        Me.txtaddr1.Name = "txtaddr1"
        Me.txtaddr1.ReadOnly = True
        Me.txtaddr1.Size = New System.Drawing.Size(245, 44)
        Me.txtaddr1.TabIndex = 339
        '
        'cboempcd
        '
        Me.cboempcd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboempcd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempcd.FormattingEnabled = True
        Me.cboempcd.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cboempcd.Location = New System.Drawing.Point(9, 98)
        Me.cboempcd.Name = "cboempcd"
        Me.cboempcd.Size = New System.Drawing.Size(183, 25)
        Me.cboempcd.TabIndex = 337
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(475, 52)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(158, 90)
        Me.txtRemark.TabIndex = 343
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(6, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 17)
        Me.Label24.TabIndex = 338
        Me.Label24.Text = "Request by:"
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(215, 52)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(208, 21)
        Me.cboCustomer.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer ."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 335
        Me.Label7.Text = "Doc Type"
        '
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(9, 50)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(183, 25)
        Me.cboDocType.TabIndex = 336
        '
        'btnSearchCustomers
        '
        Me.btnSearchCustomers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomers.Image = CType(resources.GetObject("btnSearchCustomers.Image"), System.Drawing.Image)
        Me.btnSearchCustomers.Location = New System.Drawing.Point(429, 50)
        Me.btnSearchCustomers.Name = "btnSearchCustomers"
        Me.btnSearchCustomers.Size = New System.Drawing.Size(29, 22)
        Me.btnSearchCustomers.TabIndex = 299
        Me.btnSearchCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchCustomers.UseVisualStyleBackColor = True
        '
        'grdHanger
        '
        Me.grdHanger.AllowUserToAddRows = False
        Me.grdHanger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHanger.ColumnHeadersHeight = 60
        Me.grdHanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdHanger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdHangerINSel, Me.grdHangerINStrollsDO, Me.grdHangerINRollNoD, Me.grdHangerINDesignNo, Me.grdHangerINRefdesno, Me.grdHangerINComPo, Me.grdHangerINgmpersqm, Me.grdHangerINLot, Me.grdHangerINSoNo, Me.grdHangerINCol, Me.grdHangerINCustColor, Me.grdHangerINBalKg, Me.grdHangerINKg, Me.grdHangerINWarehouseCode, Me.GrdHangerINSubinventoryCode, Me.grdHangerINLocationName})
        Me.grdHanger.Location = New System.Drawing.Point(23, 201)
        Me.grdHanger.Name = "grdHanger"
        Me.grdHanger.Size = New System.Drawing.Size(1043, 291)
        Me.grdHanger.TabIndex = 341
        '
        'grdHangerINSel
        '
        Me.grdHangerINSel.DataPropertyName = "Sel"
        Me.grdHangerINSel.HeaderText = "Sel"
        Me.grdHangerINSel.Name = "grdHangerINSel"
        Me.grdHangerINSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerINSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdHangerINSel.Width = 50
        '
        'grdHangerINStrollsDO
        '
        Me.grdHangerINStrollsDO.DataPropertyName = "id_strolls_d_o"
        Me.grdHangerINStrollsDO.HeaderText = "Sample Tag ID"
        Me.grdHangerINStrollsDO.Name = "grdHangerINStrollsDO"
        Me.grdHangerINStrollsDO.ReadOnly = True
        Me.grdHangerINStrollsDO.Visible = False
        Me.grdHangerINStrollsDO.Width = 90
        '
        'grdHangerINRollNoD
        '
        Me.grdHangerINRollNoD.DataPropertyName = "roll_no_d"
        Me.grdHangerINRollNoD.HeaderText = "Hanger Tag"
        Me.grdHangerINRollNoD.Name = "grdHangerINRollNoD"
        Me.grdHangerINRollNoD.ReadOnly = True
        Me.grdHangerINRollNoD.Width = 90
        '
        'grdHangerINDesignNo
        '
        Me.grdHangerINDesignNo.DataPropertyName = "design_no"
        Me.grdHangerINDesignNo.HeaderText = "Design No"
        Me.grdHangerINDesignNo.Name = "grdHangerINDesignNo"
        Me.grdHangerINDesignNo.ReadOnly = True
        '
        'grdHangerINRefdesno
        '
        Me.grdHangerINRefdesno.DataPropertyName = "refdesno"
        Me.grdHangerINRefdesno.HeaderText = "Artical"
        Me.grdHangerINRefdesno.Name = "grdHangerINRefdesno"
        Me.grdHangerINRefdesno.ReadOnly = True
        '
        'grdHangerINComPo
        '
        Me.grdHangerINComPo.DataPropertyName = "compo"
        Me.grdHangerINComPo.HeaderText = "ComPo"
        Me.grdHangerINComPo.Name = "grdHangerINComPo"
        Me.grdHangerINComPo.ReadOnly = True
        '
        'grdHangerINgmpersqm
        '
        Me.grdHangerINgmpersqm.DataPropertyName = "gmpersqm"
        Me.grdHangerINgmpersqm.HeaderText = "g/m²"
        Me.grdHangerINgmpersqm.Name = "grdHangerINgmpersqm"
        Me.grdHangerINgmpersqm.ReadOnly = True
        Me.grdHangerINgmpersqm.Width = 60
        '
        'grdHangerINLot
        '
        Me.grdHangerINLot.DataPropertyName = "lot"
        Me.grdHangerINLot.HeaderText = "Lot"
        Me.grdHangerINLot.Name = "grdHangerINLot"
        Me.grdHangerINLot.ReadOnly = True
        Me.grdHangerINLot.Width = 80
        '
        'grdHangerINSoNo
        '
        Me.grdHangerINSoNo.DataPropertyName = "sono"
        Me.grdHangerINSoNo.HeaderText = "SO No."
        Me.grdHangerINSoNo.Name = "grdHangerINSoNo"
        Me.grdHangerINSoNo.ReadOnly = True
        '
        'grdHangerINCol
        '
        Me.grdHangerINCol.DataPropertyName = "col"
        Me.grdHangerINCol.HeaderText = "Col"
        Me.grdHangerINCol.Name = "grdHangerINCol"
        Me.grdHangerINCol.ReadOnly = True
        Me.grdHangerINCol.Width = 80
        '
        'grdHangerINCustColor
        '
        Me.grdHangerINCustColor.DataPropertyName = "custcolor"
        Me.grdHangerINCustColor.HeaderText = "Cust. Col."
        Me.grdHangerINCustColor.Name = "grdHangerINCustColor"
        Me.grdHangerINCustColor.ReadOnly = True
        Me.grdHangerINCustColor.Width = 80
        '
        'grdHangerINBalKg
        '
        Me.grdHangerINBalKg.DataPropertyName = "bal_kg"
        Me.grdHangerINBalKg.HeaderText = "Bal Qty"
        Me.grdHangerINBalKg.Name = "grdHangerINBalKg"
        Me.grdHangerINBalKg.ReadOnly = True
        '
        'grdHangerINKg
        '
        Me.grdHangerINKg.DataPropertyName = "kg"
        Me.grdHangerINKg.HeaderText = "Qty"
        Me.grdHangerINKg.Name = "grdHangerINKg"
        Me.grdHangerINKg.Width = 50
        '
        'grdHangerINWarehouseCode
        '
        Me.grdHangerINWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdHangerINWarehouseCode.HeaderText = "W/H"
        Me.grdHangerINWarehouseCode.Name = "grdHangerINWarehouseCode"
        Me.grdHangerINWarehouseCode.ReadOnly = True
        '
        'GrdHangerINSubinventoryCode
        '
        Me.GrdHangerINSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.GrdHangerINSubinventoryCode.HeaderText = "Sub"
        Me.GrdHangerINSubinventoryCode.Name = "GrdHangerINSubinventoryCode"
        Me.GrdHangerINSubinventoryCode.ReadOnly = True
        '
        'grdHangerINLocationName
        '
        Me.grdHangerINLocationName.DataPropertyName = "location_name"
        Me.grdHangerINLocationName.HeaderText = "Loc"
        Me.grdHangerINLocationName.Name = "grdHangerINLocationName"
        Me.grdHangerINLocationName.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpPackdt)
        Me.GroupBox3.Controls.Add(Me.txtPackNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpOutDt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtOutno)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(843, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 167)
        Me.GroupBox3.TabIndex = 342
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date"
        '
        'dtpPackdt
        '
        Me.dtpPackdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpPackdt.Enabled = False
        Me.dtpPackdt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPackdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPackdt.Location = New System.Drawing.Point(84, 130)
        Me.dtpPackdt.Name = "dtpPackdt"
        Me.dtpPackdt.Size = New System.Drawing.Size(123, 25)
        Me.dtpPackdt.TabIndex = 8
        '
        'txtPackNo
        '
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(84, 96)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.ReadOnly = True
        Me.txtPackNo.Size = New System.Drawing.Size(123, 22)
        Me.txtPackNo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "H Pack No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Date"
        '
        'dtpOutDt
        '
        Me.dtpOutDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpOutDt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOutDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutDt.Location = New System.Drawing.Point(84, 60)
        Me.dtpOutDt.Name = "dtpOutDt"
        Me.dtpOutDt.Size = New System.Drawing.Size(123, 25)
        Me.dtpOutDt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "H Out No."
        '
        'txtOutno
        '
        Me.txtOutno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutno.Location = New System.Drawing.Point(84, 21)
        Me.txtOutno.Name = "txtOutno"
        Me.txtOutno.Size = New System.Drawing.Size(123, 22)
        Me.txtOutno.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmHangerOutBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 525)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grdHanger)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHangerOutBarcode"
        Me.Text = "Hanger Out"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdHanger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintHangerOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbRollNoD As System.Windows.Forms.Label
    Friend WithEvents txtRollNoD As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtaddr1 As System.Windows.Forms.TextBox
    Friend WithEvents cboempcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchCustomers As System.Windows.Forms.Button
    Friend WithEvents grdHanger As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpOutDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOutno As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents grdHangerINSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdHangerINStrollsDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINRollNoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINDesignNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINRefdesno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINComPo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINgmpersqm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINSoNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINCustColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINBalKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINWarehouseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrdHangerINSubinventoryCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINLocationName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpPackdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
End Class
