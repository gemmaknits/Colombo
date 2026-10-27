<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangerINBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangerINBarcode))
        Me.grdHangerIN = New System.Windows.Forms.DataGridView()
        Me.grdHangerINSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdHangerINStrollsDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINComPo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINgmpersqm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINSoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdHangerINMtlWareHouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdHangerINMtlSubinventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdHangerINMtlLocations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOutNo = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.lbSampleBarcode = New System.Windows.Forms.Label()
        Me.txtIDStrollsDO = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.cboDoctype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDindt = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintDocument = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintTagMini = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintTagBig = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnApplyCurRow = New System.Windows.Forms.Button()
        Me.cbomtlLocation = New System.Windows.Forms.ComboBox()
        Me.btnApplyAll = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        CType(Me.grdHangerIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdHangerIN
        '
        Me.grdHangerIN.AllowUserToAddRows = False
        Me.grdHangerIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdHangerIN.ColumnHeadersHeight = 60
        Me.grdHangerIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdHangerIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdHangerINSel, Me.grdHangerINStrollsDO, Me.grdHangerINDesignNo, Me.grdHangerINRefdesno, Me.grdHangerINComPo, Me.grdHangerINgmpersqm, Me.grdHangerINLot, Me.grdHangerINSoNo, Me.grdHangerINCol, Me.grdHangerINCustColor, Me.grdHangerINRollNoD, Me.grdHangerINKg, Me.grdHangerINMtlWareHouse, Me.grdHangerINMtlSubinventory, Me.grdHangerINMtlLocations})
        Me.grdHangerIN.Location = New System.Drawing.Point(54, 214)
        Me.grdHangerIN.Name = "grdHangerIN"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdHangerIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdHangerIN.Size = New System.Drawing.Size(1002, 299)
        Me.grdHangerIN.TabIndex = 302
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
        Me.grdHangerINStrollsDO.Width = 90
        '
        'grdHangerINDesignNo
        '
        Me.grdHangerINDesignNo.DataPropertyName = "design_no"
        Me.grdHangerINDesignNo.HeaderText = "Design No"
        Me.grdHangerINDesignNo.Name = "grdHangerINDesignNo"
        '
        'grdHangerINRefdesno
        '
        Me.grdHangerINRefdesno.DataPropertyName = "refdesco"
        Me.grdHangerINRefdesno.HeaderText = "Artical"
        Me.grdHangerINRefdesno.Name = "grdHangerINRefdesno"
        '
        'grdHangerINComPo
        '
        Me.grdHangerINComPo.DataPropertyName = "compo"
        Me.grdHangerINComPo.HeaderText = "ComPo"
        Me.grdHangerINComPo.Name = "grdHangerINComPo"
        '
        'grdHangerINgmpersqm
        '
        Me.grdHangerINgmpersqm.DataPropertyName = "gmpersqm"
        Me.grdHangerINgmpersqm.HeaderText = "g/m²"
        Me.grdHangerINgmpersqm.Name = "grdHangerINgmpersqm"
        Me.grdHangerINgmpersqm.Width = 60
        '
        'grdHangerINLot
        '
        Me.grdHangerINLot.DataPropertyName = "lot"
        Me.grdHangerINLot.HeaderText = "Lot"
        Me.grdHangerINLot.Name = "grdHangerINLot"
        Me.grdHangerINLot.Width = 80
        '
        'grdHangerINSoNo
        '
        Me.grdHangerINSoNo.DataPropertyName = "sono"
        Me.grdHangerINSoNo.HeaderText = "SO No."
        Me.grdHangerINSoNo.Name = "grdHangerINSoNo"
        '
        'grdHangerINCol
        '
        Me.grdHangerINCol.DataPropertyName = "col"
        Me.grdHangerINCol.HeaderText = "Col"
        Me.grdHangerINCol.Name = "grdHangerINCol"
        Me.grdHangerINCol.Width = 80
        '
        'grdHangerINCustColor
        '
        Me.grdHangerINCustColor.DataPropertyName = "custcolor"
        Me.grdHangerINCustColor.HeaderText = "Cust. Col."
        Me.grdHangerINCustColor.Name = "grdHangerINCustColor"
        Me.grdHangerINCustColor.Width = 80
        '
        'grdHangerINRollNoD
        '
        Me.grdHangerINRollNoD.DataPropertyName = "roll_no_d"
        Me.grdHangerINRollNoD.HeaderText = "Hanger Tag No."
        Me.grdHangerINRollNoD.Name = "grdHangerINRollNoD"
        Me.grdHangerINRollNoD.ReadOnly = True
        Me.grdHangerINRollNoD.Width = 90
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
        Me.grdHangerINMtlWareHouse.Width = 60
        '
        'grdHangerINMtlSubinventory
        '
        Me.grdHangerINMtlSubinventory.DataPropertyName = "mtl_subinventory_id"
        Me.grdHangerINMtlSubinventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.grdHangerINMtlSubinventory.HeaderText = "SubInventory"
        Me.grdHangerINMtlSubinventory.Name = "grdHangerINMtlSubinventory"
        Me.grdHangerINMtlSubinventory.ReadOnly = True
        Me.grdHangerINMtlSubinventory.Width = 150
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
        Me.GroupBox1.Controls.Add(Me.lblOutNo)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Controls.Add(Me.lbSampleBarcode)
        Me.GroupBox1.Controls.Add(Me.txtIDStrollsDO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 62)
        Me.GroupBox1.TabIndex = 336
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sample Out Detail"
        '
        'lblOutNo
        '
        Me.lblOutNo.AutoSize = True
        Me.lblOutNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutNo.Location = New System.Drawing.Point(242, 26)
        Me.lblOutNo.Name = "lblOutNo"
        Me.lblOutNo.Size = New System.Drawing.Size(101, 17)
        Me.lblOutNo.TabIndex = 4
        Me.lblOutNo.Text = "Sample Out No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(351, 26)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(119, 22)
        Me.txtOutNo.TabIndex = 5
        '
        'lbSampleBarcode
        '
        Me.lbSampleBarcode.AutoSize = True
        Me.lbSampleBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSampleBarcode.Location = New System.Drawing.Point(17, 26)
        Me.lbSampleBarcode.Name = "lbSampleBarcode"
        Me.lbSampleBarcode.Size = New System.Drawing.Size(128, 17)
        Me.lbSampleBarcode.TabIndex = 2
        Me.lbSampleBarcode.Text = "Sample Out Barcode"
        '
        'txtIDStrollsDO
        '
        Me.txtIDStrollsDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIDStrollsDO.Location = New System.Drawing.Point(151, 25)
        Me.txtIDStrollsDO.Name = "txtIDStrollsDO"
        Me.txtIDStrollsDO.Size = New System.Drawing.Size(88, 22)
        Me.txtIDStrollsDO.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LbDoctype)
        Me.GroupBox2.Controls.Add(Me.cboDoctype)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpDindt)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDocNo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(811, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 134)
        Me.GroupBox2.TabIndex = 337
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HIN Document"
        '
        'LbDoctype
        '
        Me.LbDoctype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDoctype.Location = New System.Drawing.Point(58, 96)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(36, 17)
        Me.LbDoctype.TabIndex = 307
        Me.LbDoctype.Text = "Type"
        '
        'cboDoctype
        '
        Me.cboDoctype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDoctype.Enabled = False
        Me.cboDoctype.FormattingEnabled = True
        Me.cboDoctype.Location = New System.Drawing.Point(111, 94)
        Me.cboDoctype.Name = "cboDoctype"
        Me.cboDoctype.Size = New System.Drawing.Size(123, 24)
        Me.cboDoctype.TabIndex = 306
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "HIN Date"
        '
        'dtpDindt
        '
        Me.dtpDindt.CustomFormat = "dd/MM/yyyy"
        Me.dtpDindt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDindt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDindt.Location = New System.Drawing.Point(111, 63)
        Me.dtpDindt.Name = "dtpDindt"
        Me.dtpDindt.Size = New System.Drawing.Size(123, 25)
        Me.dtpDindt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HIN No."
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(111, 24)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(123, 25)
        Me.txtDocNo.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.btnPrintDocument, Me.btnPrintTagMini, Me.btnPrintTagBig, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1097, 25)
        Me.ToolStrip1.TabIndex = 357
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
        Me.btnCancel.Visible = False
        '
        'btnPrintDocument
        '
        Me.btnPrintDocument.Image = CType(resources.GetObject("btnPrintDocument.Image"), System.Drawing.Image)
        Me.btnPrintDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintDocument.Name = "btnPrintDocument"
        Me.btnPrintDocument.Size = New System.Drawing.Size(119, 22)
        Me.btnPrintDocument.Text = "Print (Document)"
        '
        'btnPrintTagMini
        '
        Me.btnPrintTagMini.Image = CType(resources.GetObject("btnPrintTagMini.Image"), System.Drawing.Image)
        Me.btnPrintTagMini.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintTagMini.Name = "btnPrintTagMini"
        Me.btnPrintTagMini.Size = New System.Drawing.Size(110, 22)
        Me.btnPrintTagMini.Text = "Print (Tag) Mini"
        '
        'btnPrintTagBig
        '
        Me.btnPrintTagBig.Image = CType(resources.GetObject("btnPrintTagBig.Image"), System.Drawing.Image)
        Me.btnPrintTagBig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintTagBig.Name = "btnPrintTagBig"
        Me.btnPrintTagBig.Size = New System.Drawing.Size(105, 22)
        Me.btnPrintTagBig.Text = "Print (Tag) Fair"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnApplyCurRow)
        Me.GroupBox3.Controls.Add(Me.cbomtlLocation)
        Me.GroupBox3.Controls.Add(Me.btnApplyAll)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(530, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 134)
        Me.GroupBox3.TabIndex = 358
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Locations"
        '
        'btnApplyCurRow
        '
        Me.btnApplyCurRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurRow.Location = New System.Drawing.Point(182, 29)
        Me.btnApplyCurRow.Name = "btnApplyCurRow"
        Me.btnApplyCurRow.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyCurRow.TabIndex = 351
        Me.btnApplyCurRow.Text = "Curent Row"
        Me.btnApplyCurRow.UseVisualStyleBackColor = True
        '
        'cbomtlLocation
        '
        Me.cbomtlLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlLocation.FormattingEnabled = True
        Me.cbomtlLocation.Location = New System.Drawing.Point(51, 92)
        Me.cbomtlLocation.Name = "cbomtlLocation"
        Me.cbomtlLocation.Size = New System.Drawing.Size(125, 21)
        Me.cbomtlLocation.TabIndex = 348
        '
        'btnApplyAll
        '
        Me.btnApplyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAll.Location = New System.Drawing.Point(182, 72)
        Me.btnApplyAll.Name = "btnApplyAll"
        Me.btnApplyAll.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyAll.TabIndex = 346
        Me.btnApplyAll.Text = "ALL Row"
        Me.btnApplyAll.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "Sub."
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(51, 60)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(125, 21)
        Me.cbomtlSubinventory.TabIndex = 349
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Loc."
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(51, 28)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(125, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "W/H"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(132, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 24)
        Me.btnClear.TabIndex = 360
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(52, 184)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.btnSelectAll.TabIndex = 359
        Me.btnSelectAll.Text = "SelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'frmHangerINBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 525)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdHangerIN)
        Me.Name = "frmHangerINBarcode"
        Me.Text = "Hanger IN"
        CType(Me.grdHangerIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdHangerIN As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbSampleBarcode As System.Windows.Forms.Label
    Friend WithEvents txtIDStrollsDO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDindt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintDocument As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintTagMini As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbomtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents cboDoctype As System.Windows.Forms.ComboBox
    Friend WithEvents lblOutNo As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents btnApplyCurRow As System.Windows.Forms.Button
    Friend WithEvents cbomtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnApplyAll As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbomtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintTagBig As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents grdHangerINSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdHangerINStrollsDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINDesignNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINRefdesno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINComPo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINgmpersqm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINSoNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINCustColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINRollNoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdHangerINMtlWareHouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdHangerINMtlSubinventory As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents grdHangerINMtlLocations As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
