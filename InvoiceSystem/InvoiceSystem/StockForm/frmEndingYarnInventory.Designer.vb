<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndingYarnInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndingYarnInventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.row_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinvno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dye_test_result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optNone = New System.Windows.Forms.RadioButton()
        Me.optPassed = New System.Windows.Forms.RadioButton()
        Me.optFailed = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(274, 34)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 53
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(144, 32)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(288, 20)
        Me.txtBarcode.TabIndex = 51
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
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Stock Y Box No. Barcode :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1017, 25)
        Me.ToolStrip1.TabIndex = 49
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row_number, Me.id, Me.purno, Me.itcd, Me.lotno_our, Me.sinvno, Me.docno, Me.docdt, Me.grade, Me.boxno, Me.boxno_s, Me.spools, Me.kg_gr, Me.kg_nt, Me.mtl_warehouse, Me.mtl_subinventory, Me.mtl_locations, Me.loc, Me.dye_test_result, Me.box_remark})
        Me.grdData.Location = New System.Drawing.Point(8, 130)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1000, 374)
        Me.grdData.TabIndex = 52
        '
        'row_number
        '
        Me.row_number.DataPropertyName = "row_number"
        Me.row_number.HeaderText = "#"
        Me.row_number.Name = "row_number"
        Me.row_number.ReadOnly = True
        Me.row_number.Width = 40
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id.Width = 30
        '
        'purno
        '
        Me.purno.DataPropertyName = "purno"
        Me.purno.HeaderText = "P/O No."
        Me.purno.Name = "purno"
        Me.purno.ReadOnly = True
        Me.purno.Width = 75
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Yarn Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 75
        '
        'lotno_our
        '
        Me.lotno_our.DataPropertyName = "lotno_our"
        Me.lotno_our.HeaderText = "Lot No."
        Me.lotno_our.Name = "lotno_our"
        Me.lotno_our.ReadOnly = True
        Me.lotno_our.Width = 125
        '
        'sinvno
        '
        Me.sinvno.DataPropertyName = "sinvno"
        Me.sinvno.HeaderText = "Supplier Invoice"
        Me.sinvno.Name = "sinvno"
        Me.sinvno.ReadOnly = True
        Me.sinvno.Width = 75
        '
        'docno
        '
        Me.docno.DataPropertyName = "docno"
        Me.docno.HeaderText = "Y-IN No."
        Me.docno.Name = "docno"
        Me.docno.ReadOnly = True
        Me.docno.Width = 75
        '
        'docdt
        '
        Me.docdt.DataPropertyName = "docdt"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.docdt.DefaultCellStyle = DataGridViewCellStyle2
        Me.docdt.HeaderText = "Date"
        Me.docdt.Name = "docdt"
        Me.docdt.ReadOnly = True
        Me.docdt.Width = 75
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grade.DefaultCellStyle = DataGridViewCellStyle3
        Me.grade.HeaderText = "Gr"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 35
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Box No."
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supp. Box No."
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.ReadOnly = True
        Me.boxno_s.Width = 75
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.spools.DefaultCellStyle = DataGridViewCellStyle4
        Me.spools.HeaderText = "Spools"
        Me.spools.Name = "spools"
        Me.spools.ReadOnly = True
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.kg_gr.DefaultCellStyle = DataGridViewCellStyle5
        Me.kg_gr.HeaderText = "Gross Kgs."
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.ReadOnly = True
        Me.kg_gr.Width = 65
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.kg_nt.DefaultCellStyle = DataGridViewCellStyle6
        Me.kg_nt.HeaderText = "Net Kgs."
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.ReadOnly = True
        Me.kg_nt.Width = 65
        '
        'mtl_warehouse
        '
        Me.mtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_warehouse.HeaderText = "WareHouse"
        Me.mtl_warehouse.Name = "mtl_warehouse"
        Me.mtl_warehouse.ReadOnly = True
        Me.mtl_warehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_subinventory
        '
        Me.mtl_subinventory.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_subinventory.HeaderText = "Subinventory"
        Me.mtl_subinventory.Name = "mtl_subinventory"
        Me.mtl_subinventory.ReadOnly = True
        Me.mtl_subinventory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_subinventory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_locations
        '
        Me.mtl_locations.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.mtl_locations.HeaderText = "Locations"
        Me.mtl_locations.Name = "mtl_locations"
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'dye_test_result
        '
        Me.dye_test_result.DataPropertyName = "dye_test_result"
        Me.dye_test_result.HeaderText = "Dye Test"
        Me.dye_test_result.Name = "dye_test_result"
        Me.dye_test_result.ReadOnly = True
        Me.dye_test_result.Width = 50
        '
        'box_remark
        '
        Me.box_remark.DataPropertyName = "box_remark"
        Me.box_remark.HeaderText = "Remark"
        Me.box_remark.Name = "box_remark"
        Me.box_remark.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(440, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "***Example : BF1200075"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(440, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "***Example : RF-1034853/15"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Dye Test"
        '
        'optNone
        '
        Me.optNone.AutoSize = True
        Me.optNone.Checked = True
        Me.optNone.Location = New System.Drawing.Point(64, 56)
        Me.optNone.Name = "optNone"
        Me.optNone.Size = New System.Drawing.Size(85, 17)
        Me.optNone.TabIndex = 59
        Me.optNone.TabStop = True
        Me.optNone.Text = "No Dye Test"
        Me.optNone.UseVisualStyleBackColor = True
        '
        'optPassed
        '
        Me.optPassed.AutoSize = True
        Me.optPassed.Location = New System.Drawing.Point(160, 56)
        Me.optPassed.Name = "optPassed"
        Me.optPassed.Size = New System.Drawing.Size(60, 17)
        Me.optPassed.TabIndex = 60
        Me.optPassed.Text = "Passed"
        Me.optPassed.UseVisualStyleBackColor = True
        '
        'optFailed
        '
        Me.optFailed.AutoSize = True
        Me.optFailed.Location = New System.Drawing.Point(232, 56)
        Me.optFailed.Name = "optFailed"
        Me.optFailed.Size = New System.Drawing.Size(53, 17)
        Me.optFailed.TabIndex = 61
        Me.optFailed.Text = "Failed"
        Me.optFailed.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(64, 79)
        Me.txtRemark.MaxLength = 255
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(578, 20)
        Me.txtRemark.TabIndex = 62
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(861, 52)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(144, 21)
        Me.cbomtl_subinventory.TabIndex = 306
        Me.cbomtl_subinventory.Visible = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(789, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 305
        Me.Label12.Text = "Sub Inven :"
        Me.Label12.Visible = False
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(861, 24)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(144, 21)
        Me.cbomtl_warehouse.TabIndex = 304
        Me.cbomtl_warehouse.Visible = False
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(783, 27)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(68, 13)
        Me.lblmtl_warehouse_id.TabIndex = 303
        Me.lblmtl_warehouse_id.Text = "Warehouse :"
        Me.lblmtl_warehouse_id.Visible = False
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(861, 79)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(144, 21)
        Me.cbomtl_Location.TabIndex = 302
        Me.cbomtl_Location.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(797, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 301
        Me.Label3.Text = "Location :"
        Me.Label3.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(901, 103)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(104, 23)
        Me.btnDel.TabIndex = 307
        Me.btnDel.Text = "Delete Sel Box"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(814, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 13)
        Me.Label7.TabIndex = 308
        Me.Label7.Text = "เลือก WareHouse ก่อน เช่น ESH"
        Me.Label7.Visible = False
        '
        'frmEndingYarnInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 513)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.lblmtl_warehouse_id)
        Me.Controls.Add(Me.cbomtl_Location)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.optFailed)
        Me.Controls.Add(Me.optPassed)
        Me.Controls.Add(Me.optNone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEndingYarnInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ending Yarn Inventory"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout
        CType(Me.grdData,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents optNone As System.Windows.Forms.RadioButton
    Friend WithEvents optPassed As System.Windows.Forms.RadioButton
    Friend WithEvents optFailed As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents cbomtl_Location As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents row_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents purno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sinvno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents docdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dye_test_result As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents box_remark As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
