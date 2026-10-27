<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndingGreigeInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEndingGreigeInventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnApplyLocCurrent = New System.Windows.Forms.Button()
        Me.BtnApplyLocAll = New System.Windows.Forms.Button()
        Me.gbApplyDataRemark = New System.Windows.Forms.GroupBox()
        Me.btnApplyCurRow = New System.Windows.Forms.Button()
        Me.btnApplyAll = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.row_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbApplyDataRemark.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(95, 60)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(136, 21)
        Me.cbomtl_subinventory.TabIndex = 313
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-1, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 312
        Me.Label12.Text = "Sub Inventory :"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(14, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 13)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "เลือก WareHouse ก่อน เช่น GMK"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'cbomtl_location
        '
        Me.cbomtl_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(95, 89)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(136, 21)
        Me.cbomtl_location.TabIndex = 309
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(95, 33)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(136, 21)
        Me.cbomtl_warehouse.TabIndex = 308
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(10, 36)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(68, 13)
        Me.lblmtl_warehouse_id.TabIndex = 307
        Me.lblmtl_warehouse_id.Text = "Warehouse :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(440, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 13)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "***Example Roll No. : 120110SA363M019"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 304
        Me.Label3.Text = "Location :"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(274, 40)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 303
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripLabel1.Text = "*** 1 User Per Use ***"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(144, 34)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(288, 20)
        Me.txtBarcode.TabIndex = 301
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 300
        Me.Label1.Text = "Greige Roll No. Barcode :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1014, 25)
        Me.ToolStrip1.TabIndex = 299
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row_number, Me.id, Me.kono, Me.mcno, Me.design_no, Me.gwth, Me.mtl_warehouse, Me.mtl_subinventory, Me.mtl_locations, Me.loc, Me.sub_location, Me.tran_no, Me.tran_dt, Me.grade, Me.roll_no, Me.roll_no_o, Me.kg, Me.rem_qc})
        Me.grdData.Location = New System.Drawing.Point(8, 164)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1000, 362)
        Me.grdData.TabIndex = 302
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(440, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 13)
        Me.Label4.TabIndex = 305
        Me.Label4.Text = "***Example Roll No. : 1200260"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(8, 58)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(104, 23)
        Me.btnDel.TabIndex = 314
        Me.btnDel.Text = "Delete Sel Box"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnApplyLocCurrent)
        Me.GroupBox1.Controls.Add(Me.BtnApplyLocAll)
        Me.GroupBox1.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox1.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbomtl_location)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(754, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 158)
        Me.GroupBox1.TabIndex = 315
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Locations"
        '
        'BtnApplyLocCurrent
        '
        Me.BtnApplyLocCurrent.Location = New System.Drawing.Point(87, 115)
        Me.BtnApplyLocCurrent.Name = "BtnApplyLocCurrent"
        Me.BtnApplyLocCurrent.Size = New System.Drawing.Size(65, 37)
        Me.BtnApplyLocCurrent.TabIndex = 315
        Me.BtnApplyLocCurrent.Text = "Apply Current"
        Me.BtnApplyLocCurrent.UseVisualStyleBackColor = True
        '
        'BtnApplyLocAll
        '
        Me.BtnApplyLocAll.Location = New System.Drawing.Point(170, 115)
        Me.BtnApplyLocAll.Name = "BtnApplyLocAll"
        Me.BtnApplyLocAll.Size = New System.Drawing.Size(61, 37)
        Me.BtnApplyLocAll.TabIndex = 314
        Me.BtnApplyLocAll.Text = "Apply All"
        Me.BtnApplyLocAll.UseVisualStyleBackColor = True
        '
        'gbApplyDataRemark
        '
        Me.gbApplyDataRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbApplyDataRemark.Controls.Add(Me.btnApplyCurRow)
        Me.gbApplyDataRemark.Controls.Add(Me.btnApplyAll)
        Me.gbApplyDataRemark.Controls.Add(Me.txtRemark)
        Me.gbApplyDataRemark.Controls.Add(Me.Label6)
        Me.gbApplyDataRemark.Location = New System.Drawing.Point(8, 93)
        Me.gbApplyDataRemark.Name = "gbApplyDataRemark"
        Me.gbApplyDataRemark.Size = New System.Drawing.Size(740, 65)
        Me.gbApplyDataRemark.TabIndex = 316
        Me.gbApplyDataRemark.TabStop = False
        Me.gbApplyDataRemark.Text = "Apply Data Remark"
        '
        'btnApplyCurRow
        '
        Me.btnApplyCurRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurRow.Location = New System.Drawing.Point(563, 19)
        Me.btnApplyCurRow.Name = "btnApplyCurRow"
        Me.btnApplyCurRow.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyCurRow.TabIndex = 347
        Me.btnApplyCurRow.Text = "Curent Row"
        Me.btnApplyCurRow.UseVisualStyleBackColor = True
        '
        'btnApplyAll
        '
        Me.btnApplyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAll.Location = New System.Drawing.Point(645, 19)
        Me.btnApplyAll.Name = "btnApplyAll"
        Me.btnApplyAll.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyAll.TabIndex = 346
        Me.btnApplyAll.Text = "ALL Row"
        Me.btnApplyAll.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(65, 19)
        Me.txtRemark.MaxLength = 255
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(492, 20)
        Me.txtRemark.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Remark"
        '
        'row_number
        '
        Me.row_number.DataPropertyName = "row_number"
        Me.row_number.HeaderText = "#"
        Me.row_number.Name = "row_number"
        Me.row_number.ReadOnly = True
        Me.row_number.Width = 30
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id.Visible = False
        Me.id.Width = 30
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kono.DefaultCellStyle = DataGridViewCellStyle2
        Me.kono.HeaderText = "K/O No."
        Me.kono.Name = "kono"
        Me.kono.ReadOnly = True
        Me.kono.Width = 75
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.mcno.DefaultCellStyle = DataGridViewCellStyle3
        Me.mcno.HeaderText = "Machine"
        Me.mcno.Name = "mcno"
        Me.mcno.ReadOnly = True
        Me.mcno.Width = 75
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 75
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gwth.DefaultCellStyle = DataGridViewCellStyle4
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.ReadOnly = True
        Me.gwth.Width = 50
        '
        'mtl_warehouse
        '
        Me.mtl_warehouse.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_warehouse.HeaderText = "W/H"
        Me.mtl_warehouse.Name = "mtl_warehouse"
        Me.mtl_warehouse.ReadOnly = True
        Me.mtl_warehouse.Width = 75
        '
        'mtl_subinventory
        '
        Me.mtl_subinventory.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_subinventory.HeaderText = "Sub Inven."
        Me.mtl_subinventory.Name = "mtl_subinventory"
        Me.mtl_subinventory.ReadOnly = True
        '
        'mtl_locations
        '
        Me.mtl_locations.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.mtl_locations.HeaderText = "Loc."
        Me.mtl_locations.Name = "mtl_locations"
        Me.mtl_locations.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_locations.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_locations.Width = 75
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.ReadOnly = True
        Me.loc.Visible = False
        Me.loc.Width = 75
        '
        'sub_location
        '
        Me.sub_location.DataPropertyName = "sub_location"
        Me.sub_location.HeaderText = "Sub Location"
        Me.sub_location.Name = "sub_location"
        Me.sub_location.ReadOnly = True
        Me.sub_location.Visible = False
        '
        'tran_no
        '
        Me.tran_no.DataPropertyName = "tran_no"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.tran_no.DefaultCellStyle = DataGridViewCellStyle5
        Me.tran_no.HeaderText = "G-IN No."
        Me.tran_no.Name = "tran_no"
        Me.tran_no.ReadOnly = True
        Me.tran_no.Width = 75
        '
        'tran_dt
        '
        Me.tran_dt.DataPropertyName = "tran_dt"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.tran_dt.DefaultCellStyle = DataGridViewCellStyle6
        Me.tran_dt.HeaderText = "Date"
        Me.tran_dt.Name = "tran_dt"
        Me.tran_dt.ReadOnly = True
        Me.tran_dt.Width = 75
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grade.DefaultCellStyle = DataGridViewCellStyle7
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 50
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 75
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 120
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.kg.DefaultCellStyle = DataGridViewCellStyle8
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        Me.kg.Width = 50
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Remark"
        Me.rem_qc.Name = "rem_qc"
        Me.rem_qc.ReadOnly = True
        '
        'frmEndingGreigeInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 520)
        Me.Controls.Add(Me.gbApplyDataRemark)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEndingGreigeInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ending Greige Inventory"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbApplyDataRemark.ResumeLayout(False)
        Me.gbApplyDataRemark.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbomtl_location As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnDel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnApplyLocCurrent As Button
    Friend WithEvents BtnApplyLocAll As Button
    Friend WithEvents gbApplyDataRemark As GroupBox
    Friend WithEvents btnApplyCurRow As Button
    Friend WithEvents btnApplyAll As Button
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents row_number As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents kono As DataGridViewTextBoxColumn
    Friend WithEvents mcno As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations As DataGridViewComboBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents sub_location As DataGridViewTextBoxColumn
    Friend WithEvents tran_no As DataGridViewTextBoxColumn
    Friend WithEvents tran_dt As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As DataGridViewTextBoxColumn
End Class
