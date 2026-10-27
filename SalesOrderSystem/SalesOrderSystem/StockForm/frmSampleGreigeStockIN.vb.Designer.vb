<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleGreigeStockIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleGreigeStockIN))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdStockD = New System.Windows.Forms.DataGridView()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchDinNo = New System.Windows.Forms.Button()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbomtlLocations = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDocType = New System.Windows.Forms.ComboBox()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDinno = New System.Windows.Forms.TextBox()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(999, 25)
        Me.ToolStrip1.TabIndex = 311
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
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(330, 22)
        Me.ToolStripLabel2.Text = "**โปรแกรม จะไม่ทำการเพิ่ม,ลบ และแก้ไข DIN ที่ Costing ไปแล้ว"
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No. Old"
        Me.roll_no_d.Name = "roll_no_d"
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.roll_no_o.Name = "roll_no_o"
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "SO No."
        Me.sono.Name = "sono"
        Me.sono.Visible = False
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        Me.lot.Width = 110
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.Width = 60
        '
        'grdStockD
        '
        Me.grdStockD.AllowUserToAddRows = False
        Me.grdStockD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdStockD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selected, Me.lot, Me.Design_no, Me.roll_no_d, Me.roll_no_o, Me.sono, Me.roll_no_g, Me.sonoid, Me.col, Me.custcolor, Me.gr, Me.batch, Me.fwth, Me.kg, Me.yds, Me.mts, Me.mtkg, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id})
        Me.grdStockD.Location = New System.Drawing.Point(31, 169)
        Me.grdStockD.Name = "grdStockD"
        Me.grdStockD.Size = New System.Drawing.Size(956, 325)
        Me.grdStockD.TabIndex = 313
        Me.grdStockD.TabStop = False
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No. (G)"
        Me.roll_no_g.Name = "roll_no_g"
        Me.roll_no_g.Visible = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "SO ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Visible = False
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.Width = 60
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Color Customer"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.Width = 60
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Grade"
        Me.gr.Name = "gr"
        Me.gr.Width = 40
        '
        'batch
        '
        Me.batch.DataPropertyName = "batch"
        Me.batch.HeaderText = "Batch"
        Me.batch.Name = "batch"
        Me.batch.Visible = False
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        Me.fwth.HeaderText = "Fwth"
        Me.fwth.Name = "fwth"
        Me.fwth.Width = 40
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kg."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'mtkg
        '
        Me.mtkg.DataPropertyName = "mtkg"
        Me.mtkg.HeaderText = "mtkg(For Cal)"
        Me.mtkg.Name = "mtkg"
        Me.mtkg.Visible = False
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
        Me.mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_subinventory_id.Visible = False
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Loc"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(438, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 296
        Me.Label15.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Location = New System.Drawing.Point(334, 14)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(110, 22)
        Me.txtSelectedKgs.TabIndex = 295
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Location = New System.Drawing.Point(472, 14)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(110, 22)
        Me.txtSelectedYds.TabIndex = 297
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtSelectedKgs)
        Me.GroupBox2.Controls.Add(Me.txtSelectedYds)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtSelectedRolls)
        Me.GroupBox2.Controls.Add(Me.txtSelectedMts)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 500)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 48)
        Me.GroupBox2.TabIndex = 314
        Me.GroupBox2.TabStop = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 293
        Me.Label18.Text = "Total :"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(204, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 294
        Me.Label17.Text = "Rolls"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(576, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 298
        Me.Label13.Text = "Yds."
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Location = New System.Drawing.Point(100, 14)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(110, 22)
        Me.txtSelectedRolls.TabIndex = 292
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Location = New System.Drawing.Point(640, 14)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(110, 22)
        Me.txtSelectedMts.TabIndex = 299
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(744, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Mts."
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSearchDinNo)
        Me.GroupBox1.Controls.Add(Me.BtnPrintBarcode)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LbDoctype)
        Me.GroupBox1.Controls.Add(Me.CboDocType)
        Me.GroupBox1.Controls.Add(Me.chkAutoCalculate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDINDate)
        Me.GroupBox1.Controls.Add(Me.txtDinno)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(956, 133)
        Me.GroupBox1.TabIndex = 312
        Me.GroupBox1.TabStop = False
        '
        'btnSearchDinNo
        '
        Me.btnSearchDinNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchDinNo.Image = CType(resources.GetObject("btnSearchDinNo.Image"), System.Drawing.Image)
        Me.btnSearchDinNo.Location = New System.Drawing.Point(901, 19)
        Me.btnSearchDinNo.Name = "btnSearchDinNo"
        Me.btnSearchDinNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDinNo.TabIndex = 358
        Me.btnSearchDinNo.UseVisualStyleBackColor = True
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintBarcode.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintBarcode.Image = Global.SalesOrderSystem.My.Resources.Resources.Tag_16x
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(715, 92)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(86, 35)
        Me.BtnPrintBarcode.TabIndex = 315
        Me.BtnPrintBarcode.Text = "Print Tag"
        Me.BtnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintBarcode.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbomtlLocations)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox3.Location = New System.Drawing.Point(446, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 99)
        Me.GroupBox3.TabIndex = 357
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = "Location"
        '
        'cbomtlLocations
        '
        Me.cbomtlLocations.FormattingEnabled = True
        Me.cbomtlLocations.Location = New System.Drawing.Point(82, 73)
        Me.cbomtlLocations.Name = "cbomtlLocations"
        Me.cbomtlLocations.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlLocations.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 295
        Me.Label5.Text = "Sub Inven"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "W/H"
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlSubinventory.TabIndex = 3
        '
        'LbDoctype
        '
        Me.LbDoctype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(699, 73)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(71, 13)
        Me.LbDoctype.TabIndex = 305
        Me.LbDoctype.Text = "Fabric form :"
        '
        'CboDocType
        '
        Me.CboDocType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboDocType.Enabled = False
        Me.CboDocType.FormattingEnabled = True
        Me.CboDocType.Location = New System.Drawing.Point(782, 70)
        Me.CboDocType.Name = "CboDocType"
        Me.CboDocType.Size = New System.Drawing.Size(127, 21)
        Me.CboDocType.TabIndex = 304
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(830, 92)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(104, 32)
        Me.chkAutoCalculate.TabIndex = 303
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(699, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "DIN Date"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(699, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "DIN No."
        '
        'dtpDINDate
        '
        Me.dtpDINDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDINDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDINDate.Location = New System.Drawing.Point(782, 45)
        Me.dtpDINDate.Name = "dtpDINDate"
        Me.dtpDINDate.Size = New System.Drawing.Size(112, 22)
        Me.dtpDINDate.TabIndex = 289
        '
        'txtDinno
        '
        Me.txtDinno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDinno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDinno.Location = New System.Drawing.Point(782, 21)
        Me.txtDinno.Name = "txtDinno"
        Me.txtDinno.ReadOnly = True
        Me.txtDinno.Size = New System.Drawing.Size(112, 20)
        Me.txtDinno.TabIndex = 300
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(243, 23)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        Me.btnSearchOutNo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GOUT No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(110, 23)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(132, 22)
        Me.txtOutNo.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSampleGreigeStockIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 549)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdStockD)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSampleGreigeStockIN"
        Me.Text = "Sample IN (From Greige Out)"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_d As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents selected As DataGridViewCheckBoxColumn
    Friend WithEvents grdStockD As DataGridView
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents batch As DataGridViewTextBoxColumn
    Friend WithEvents fwth As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents mtkg As DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSelectedKgs As TextBox
    Friend WithEvents txtSelectedYds As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSelectedRolls As TextBox
    Friend WithEvents txtSelectedMts As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbomtlWarehouse As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbomtlLocations As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbomtlSubinventory As ComboBox
    Friend WithEvents LbDoctype As Label
    Friend WithEvents CboDocType As ComboBox
    Friend WithEvents chkAutoCalculate As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDINDate As DateTimePicker
    Friend WithEvents txtDinno As TextBox
    Friend WithEvents btnSearchOutNo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnPrintBarcode As Button
    Friend WithEvents btnSearchDinNo As Button
End Class
