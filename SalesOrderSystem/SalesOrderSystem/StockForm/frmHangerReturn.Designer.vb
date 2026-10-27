<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangerReturnBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangerReturnBarcode))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnPrintDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPrintTagMini = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPrintTagFair = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDindt = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdHangerIN = New System.Windows.Forms.DataGridView()
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
        Me.grdHangerINKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINMtlWareHouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdHangerINMtlSubinventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdHangerINMtlLocations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbRollNoD = New System.Windows.Forms.Label()
        Me.txtRollNoD = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddr1 = New System.Windows.Forms.TextBox()
        Me.cboempcd = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchCustomers = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnApplyCurRow = New System.Windows.Forms.Button()
        Me.cbomtlLocation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdHangerIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.ToolStripDropDownButton1, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1121, 25)
        Me.ToolStrip1.TabIndex = 343
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
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintDocument, Me.BtnPrintTagMini, Me.BtnPrintTagFair})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'BtnPrintDocument
        '
        Me.BtnPrintDocument.Image = CType(resources.GetObject("BtnPrintDocument.Image"), System.Drawing.Image)
        Me.BtnPrintDocument.Name = "BtnPrintDocument"
        Me.BtnPrintDocument.Size = New System.Drawing.Size(130, 22)
        Me.BtnPrintDocument.Text = "Document"
        '
        'BtnPrintTagMini
        '
        Me.BtnPrintTagMini.Image = CType(resources.GetObject("BtnPrintTagMini.Image"), System.Drawing.Image)
        Me.BtnPrintTagMini.Name = "BtnPrintTagMini"
        Me.BtnPrintTagMini.Size = New System.Drawing.Size(130, 22)
        Me.BtnPrintTagMini.Text = "Tag Mini"
        '
        'BtnPrintTagFair
        '
        Me.BtnPrintTagFair.Image = CType(resources.GetObject("BtnPrintTagFair.Image"), System.Drawing.Image)
        Me.BtnPrintTagFair.Name = "BtnPrintTagFair"
        Me.BtnPrintTagFair.Size = New System.Drawing.Size(130, 22)
        Me.BtnPrintTagFair.Text = "Tag Fair"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Date"
        '
        'dtpDindt
        '
        Me.dtpDindt.CustomFormat = "dd/MM/yyyy"
        Me.dtpDindt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDindt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDindt.Location = New System.Drawing.Point(116, 65)
        Me.dtpDindt.Name = "dtpDindt"
        Me.dtpDindt.Size = New System.Drawing.Size(149, 25)
        Me.dtpDindt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Hanger IN No."
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(116, 26)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(149, 22)
        Me.txtDocNo.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpDindt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDocNo)
        Me.GroupBox3.Controls.Add(Me.cboDocType)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(819, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 154)
        Me.GroupBox3.TabIndex = 347
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document"
        '
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(116, 108)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(149, 24)
        Me.cboDocType.TabIndex = 336
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 335
        Me.Label7.Text = "Doc Type"
        '
        'grdHangerIN
        '
        Me.grdHangerIN.AllowUserToAddRows = False
        Me.grdHangerIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHangerIN.ColumnHeadersHeight = 60
        Me.grdHangerIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdHangerIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdHangerINSel, Me.grdHangerINStrollsDO, Me.grdHangerINRollNoD, Me.grdHangerINDesignNo, Me.grdHangerINRefdesno, Me.grdHangerINComPo, Me.grdHangerINgmpersqm, Me.grdHangerINLot, Me.grdHangerINSoNo, Me.grdHangerINCol, Me.grdHangerINCustColor, Me.grdHangerINKg, Me.grdHangerINMtlWareHouse, Me.grdHangerINMtlSubinventory, Me.grdHangerINMtlLocations})
        Me.grdHangerIN.Location = New System.Drawing.Point(23, 230)
        Me.grdHangerIN.Name = "grdHangerIN"
        Me.grdHangerIN.Size = New System.Drawing.Size(1067, 278)
        Me.grdHangerIN.TabIndex = 346
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
        Me.grdHangerINStrollsDO.Width = 90
        '
        'grdHangerINRollNoD
        '
        Me.grdHangerINRollNoD.DataPropertyName = "roll_no_d"
        Me.grdHangerINRollNoD.HeaderText = "Roll No."
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
        Me.grdHangerINRefdesno.DataPropertyName = "refdesco"
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
        'grdHangerINKg
        '
        Me.grdHangerINKg.DataPropertyName = "kg"
        Me.grdHangerINKg.HeaderText = "Qty"
        Me.grdHangerINKg.Name = "grdHangerINKg"
        Me.grdHangerINKg.Width = 50
        '
        'grdHangerINMtlWareHouse
        '
        Me.grdHangerINMtlWareHouse.DataPropertyName = "mtl_warehouse_id"
        Me.grdHangerINMtlWareHouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.grdHangerINMtlWareHouse.HeaderText = "W/H"
        Me.grdHangerINMtlWareHouse.Name = "grdHangerINMtlWareHouse"
        Me.grdHangerINMtlWareHouse.ReadOnly = True
        Me.grdHangerINMtlWareHouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerINMtlWareHouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'grdHangerINMtlSubinventory
        '
        Me.grdHangerINMtlSubinventory.DataPropertyName = "mtl_subinventory_id"
        Me.grdHangerINMtlSubinventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.grdHangerINMtlSubinventory.HeaderText = "Sub"
        Me.grdHangerINMtlSubinventory.Name = "grdHangerINMtlSubinventory"
        Me.grdHangerINMtlSubinventory.ReadOnly = True
        Me.grdHangerINMtlSubinventory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerINMtlSubinventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'grdHangerINMtlLocations
        '
        Me.grdHangerINMtlLocations.DataPropertyName = "mtl_locations_id"
        Me.grdHangerINMtlLocations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.grdHangerINMtlLocations.HeaderText = "Loc"
        Me.grdHangerINMtlLocations.Name = "grdHangerINMtlLocations"
        Me.grdHangerINMtlLocations.ReadOnly = True
        Me.grdHangerINMtlLocations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerINMtlLocations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbRollNoD)
        Me.GroupBox1.Controls.Add(Me.txtRollNoD)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 59)
        Me.GroupBox1.TabIndex = 344
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
        Me.txtRollNoD.Location = New System.Drawing.Point(98, 21)
        Me.txtRollNoD.Name = "txtRollNoD"
        Me.txtRollNoD.Size = New System.Drawing.Size(168, 25)
        Me.txtRollNoD.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtaddr1)
        Me.GroupBox2.Controls.Add(Me.cboempcd)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnSearchCustomers)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 85)
        Me.GroupBox2.TabIndex = 345
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Doctype Detail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 340
        Me.Label8.Text = "Cust Addr."
        '
        'txtaddr1
        '
        Me.txtaddr1.Enabled = False
        Me.txtaddr1.Location = New System.Drawing.Point(344, 49)
        Me.txtaddr1.Name = "txtaddr1"
        Me.txtaddr1.ReadOnly = True
        Me.txtaddr1.Size = New System.Drawing.Size(401, 25)
        Me.txtaddr1.TabIndex = 339
        '
        'cboempcd
        '
        Me.cboempcd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboempcd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempcd.FormattingEnabled = True
        Me.cboempcd.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cboempcd.Location = New System.Drawing.Point(98, 21)
        Me.cboempcd.Name = "cboempcd"
        Me.cboempcd.Size = New System.Drawing.Size(168, 25)
        Me.cboempcd.TabIndex = 337
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(8, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 17)
        Me.Label24.TabIndex = 338
        Me.Label24.Text = "Requested by:"
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(344, 21)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(401, 21)
        Me.cboCustomer.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer ."
        '
        'btnSearchCustomers
        '
        Me.btnSearchCustomers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomers.Image = CType(resources.GetObject("btnSearchCustomers.Image"), System.Drawing.Image)
        Me.btnSearchCustomers.Location = New System.Drawing.Point(751, 18)
        Me.btnSearchCustomers.Name = "btnSearchCustomers"
        Me.btnSearchCustomers.Size = New System.Drawing.Size(27, 26)
        Me.btnSearchCustomers.TabIndex = 299
        Me.btnSearchCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchCustomers.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnApplyCurRow)
        Me.GroupBox4.Controls.Add(Me.cbomtlLocation)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(301, 57)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 59)
        Me.GroupBox4.TabIndex = 359
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock Locations"
        Me.GroupBox4.Visible = False
        '
        'btnApplyCurRow
        '
        Me.btnApplyCurRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurRow.Image = CType(resources.GetObject("btnApplyCurRow.Image"), System.Drawing.Image)
        Me.btnApplyCurRow.Location = New System.Drawing.Point(473, 23)
        Me.btnApplyCurRow.Name = "btnApplyCurRow"
        Me.btnApplyCurRow.Size = New System.Drawing.Size(27, 26)
        Me.btnApplyCurRow.TabIndex = 351
        Me.btnApplyCurRow.Tag = "Apply"
        Me.btnApplyCurRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplyCurRow.UseVisualStyleBackColor = True
        '
        'cbomtlLocation
        '
        Me.cbomtlLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlLocation.FormattingEnabled = True
        Me.cbomtlLocation.Location = New System.Drawing.Point(350, 26)
        Me.cbomtlLocation.Name = "cbomtlLocation"
        Me.cbomtlLocation.Size = New System.Drawing.Size(117, 21)
        Me.cbomtlLocation.TabIndex = 348
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 350
        Me.Label1.Text = "Sub."
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(197, 25)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(114, 21)
        Me.cbomtlSubinventory.TabIndex = 349
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Loc."
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(48, 25)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(93, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "W/H"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.Location = New System.Drawing.Point(25, 200)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(104, 24)
        Me.btnSelectAll.TabIndex = 361
        Me.btnSelectAll.Text = "Selected All"
        Me.btnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'frmHangerReturnBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 525)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grdHangerIN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmHangerReturnBarcode"
        Me.Text = "Hanger Return"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdHangerIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDindt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdHangerIN As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbRollNoD As System.Windows.Forms.Label
    Friend WithEvents txtRollNoD As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtaddr1 As System.Windows.Forms.TextBox
    Friend WithEvents cboempcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchCustomers As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnApplyCurRow As System.Windows.Forms.Button
    Friend WithEvents cbomtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbomtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbomtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnPrintDocument As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnPrintTagMini As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents grdHangerINKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINMtlWareHouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdHangerINMtlSubinventory As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdHangerINMtlLocations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BtnPrintTagFair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
End Class
