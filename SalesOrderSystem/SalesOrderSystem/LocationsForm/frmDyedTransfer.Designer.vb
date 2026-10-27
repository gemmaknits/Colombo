<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDyedTransfer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedTransfer))
        Me.optRollNoD = New System.Windows.Forms.RadioButton()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkLocationsEmply = New System.Windows.Forms.CheckBox()
        Me.btnApplyCurRow = New System.Windows.Forms.Button()
        Me.cbomtlLocation = New System.Windows.Forms.ComboBox()
        Me.cbomtlwarehouse = New System.Windows.Forms.ComboBox()
        Me.btnApplyAll = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.cbomtlsubinventory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.optLotNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GradeTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GradeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnApplyGrAll = New System.Windows.Forms.Button()
        Me.btnApplyGrCurRow = New System.Windows.Forms.Button()
        Me.txtGradeTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.old_mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtpTrnDate = New System.Windows.Forms.DateTimePicker()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.txtTrnNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboTrnNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdRollNo = New System.Windows.Forms.DataGridView()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optRollNoD
        '
        Me.optRollNoD.AutoSize = True
        Me.optRollNoD.Checked = True
        Me.optRollNoD.Location = New System.Drawing.Point(12, 19)
        Me.optRollNoD.Name = "optRollNoD"
        Me.optRollNoD.Size = New System.Drawing.Size(104, 17)
        Me.optRollNoD.TabIndex = 303
        Me.optRollNoD.TabStop = True
        Me.optRollNoD.Text = "System Roll No."
        Me.optRollNoD.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(17, 53)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(179, 22)
        Me.txtBarcode.TabIndex = 302
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkLocationsEmply)
        Me.GroupBox2.Controls.Add(Me.btnApplyCurRow)
        Me.GroupBox2.Controls.Add(Me.cbomtlLocation)
        Me.GroupBox2.Controls.Add(Me.cbomtlwarehouse)
        Me.GroupBox2.Controls.Add(Me.btnApplyAll)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblWarehourse)
        Me.GroupBox2.Controls.Add(Me.cbomtlsubinventory)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(277, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 119)
        Me.GroupBox2.TabIndex = 357
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apply Stock Location"
        '
        'ChkLocationsEmply
        '
        Me.ChkLocationsEmply.AutoSize = True
        Me.ChkLocationsEmply.Checked = True
        Me.ChkLocationsEmply.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLocationsEmply.Location = New System.Drawing.Point(77, 93)
        Me.ChkLocationsEmply.Name = "ChkLocationsEmply"
        Me.ChkLocationsEmply.Size = New System.Drawing.Size(226, 17)
        Me.ChkLocationsEmply.TabIndex = 359
        Me.ChkLocationsEmply.Text = "Locations Emply (โชว์เฉพาะโลเคชั่นที่ว่างอยู่)"
        Me.ChkLocationsEmply.UseVisualStyleBackColor = True
        '
        'btnApplyCurRow
        '
        Me.btnApplyCurRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurRow.Location = New System.Drawing.Point(236, 16)
        Me.btnApplyCurRow.Name = "btnApplyCurRow"
        Me.btnApplyCurRow.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyCurRow.TabIndex = 345
        Me.btnApplyCurRow.Text = "Curent Row"
        Me.btnApplyCurRow.UseVisualStyleBackColor = True
        '
        'cbomtlLocation
        '
        Me.cbomtlLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlLocation.FormattingEnabled = True
        Me.cbomtlLocation.Location = New System.Drawing.Point(102, 66)
        Me.cbomtlLocation.Name = "cbomtlLocation"
        Me.cbomtlLocation.Size = New System.Drawing.Size(128, 21)
        Me.cbomtlLocation.TabIndex = 341
        '
        'cbomtlwarehouse
        '
        Me.cbomtlwarehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlwarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtlwarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlwarehouse.FormattingEnabled = True
        Me.cbomtlwarehouse.Location = New System.Drawing.Point(102, 17)
        Me.cbomtlwarehouse.Name = "cbomtlwarehouse"
        Me.cbomtlwarehouse.Size = New System.Drawing.Size(128, 21)
        Me.cbomtlwarehouse.TabIndex = 340
        '
        'btnApplyAll
        '
        Me.btnApplyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAll.Location = New System.Drawing.Point(236, 53)
        Me.btnApplyAll.Name = "btnApplyAll"
        Me.btnApplyAll.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyAll.TabIndex = 338
        Me.btnApplyAll.Text = "ALL Row"
        Me.btnApplyAll.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 344
        Me.Label8.Text = "Subinventory to"
        '
        'lblWarehourse
        '
        Me.lblWarehourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(7, 20)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(80, 13)
        Me.lblWarehourse.TabIndex = 342
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'cbomtlsubinventory
        '
        Me.cbomtlsubinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtlsubinventory.FormattingEnabled = True
        Me.cbomtlsubinventory.Location = New System.Drawing.Point(102, 41)
        Me.cbomtlsubinventory.Name = "cbomtlsubinventory"
        Me.cbomtlsubinventory.Size = New System.Drawing.Size(128, 21)
        Me.cbomtlsubinventory.TabIndex = 343
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 339
        Me.Label9.Text = "Location to"
        '
        'optLotNo
        '
        Me.optLotNo.AutoSize = True
        Me.optLotNo.Location = New System.Drawing.Point(120, 19)
        Me.optLotNo.Name = "optLotNo"
        Me.optLotNo.Size = New System.Drawing.Size(62, 17)
        Me.optLotNo.TabIndex = 304
        Me.optLotNo.Text = "Lot No."
        Me.optLotNo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optLotNo)
        Me.GroupBox1.Controls.Add(Me.optRollNoD)
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 96)
        Me.GroupBox1.TabIndex = 356
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Document"
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.DisplayStyleForCurrentCellOnly = True
        Me.mtl_subinventory_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtl_subinventory_id.HeaderText = "SubInventory To"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.ReadOnly = True
        Me.mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GradeTo
        '
        Me.GradeTo.DataPropertyName = "grade_to"
        Me.GradeTo.HeaderText = "Grade To"
        Me.GradeTo.MaxInputLength = 3
        Me.GradeTo.Name = "GradeTo"
        Me.GradeTo.ReadOnly = True
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.DisplayStyleForCurrentCellOnly = True
        Me.mtl_locations_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtl_locations_id.HeaderText = "Location To"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.ReadOnly = True
        Me.mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GradeFrom
        '
        Me.GradeFrom.DataPropertyName = "grade_from"
        Me.GradeFrom.HeaderText = "Grade From"
        Me.GradeFrom.MaxInputLength = 3
        Me.GradeFrom.MinimumWidth = 3
        Me.GradeFrom.Name = "GradeFrom"
        Me.GradeFrom.ReadOnly = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnApplyGrAll)
        Me.GroupBox3.Controls.Add(Me.btnApplyGrCurRow)
        Me.GroupBox3.Controls.Add(Me.txtGradeTo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(601, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 96)
        Me.GroupBox3.TabIndex = 358
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Apply Grade"
        '
        'btnApplyGrAll
        '
        Me.btnApplyGrAll.Location = New System.Drawing.Point(137, 54)
        Me.btnApplyGrAll.Name = "btnApplyGrAll"
        Me.btnApplyGrAll.Size = New System.Drawing.Size(77, 33)
        Me.btnApplyGrAll.TabIndex = 346
        Me.btnApplyGrAll.Text = "ALL Row"
        Me.btnApplyGrAll.UseVisualStyleBackColor = True
        '
        'btnApplyGrCurRow
        '
        Me.btnApplyGrCurRow.Location = New System.Drawing.Point(137, 19)
        Me.btnApplyGrCurRow.Name = "btnApplyGrCurRow"
        Me.btnApplyGrCurRow.Size = New System.Drawing.Size(77, 33)
        Me.btnApplyGrCurRow.TabIndex = 346
        Me.btnApplyGrCurRow.Text = "Curent Row"
        Me.btnApplyGrCurRow.UseVisualStyleBackColor = True
        '
        'txtGradeTo
        '
        Me.txtGradeTo.Location = New System.Drawing.Point(64, 23)
        Me.txtGradeTo.Name = "txtGradeTo"
        Me.txtGradeTo.Size = New System.Drawing.Size(67, 22)
        Me.txtGradeTo.TabIndex = 347
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 346
        Me.Label3.Text = "Grade to"
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.DisplayStyleForCurrentCellOnly = True
        Me.mtl_warehouse_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtl_warehouse_id.HeaderText = "Warehouse To"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.ReadOnly = True
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'old_mtl_locations_id
        '
        Me.old_mtl_locations_id.DataPropertyName = "old_mtl_locations_id"
        Me.old_mtl_locations_id.DisplayStyleForCurrentCellOnly = True
        Me.old_mtl_locations_id.HeaderText = "Location From"
        Me.old_mtl_locations_id.Name = "old_mtl_locations_id"
        Me.old_mtl_locations_id.ReadOnly = True
        Me.old_mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.old_mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dtpTrnDate
        '
        Me.dtpTrnDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTrnDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTrnDate.Enabled = False
        Me.dtpTrnDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTrnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrnDate.Location = New System.Drawing.Point(888, 85)
        Me.dtpTrnDate.Name = "dtpTrnDate"
        Me.dtpTrnDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpTrnDate.TabIndex = 355
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'txtTrnNo
        '
        Me.txtTrnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrnNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrnNo.Location = New System.Drawing.Point(888, 61)
        Me.txtTrnNo.Name = "txtTrnNo"
        Me.txtTrnNo.Size = New System.Drawing.Size(96, 22)
        Me.txtTrnNo.TabIndex = 354
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(832, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 353
        Me.Label2.Text = "Tran Date"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(832, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 352
        Me.Label1.Text = "Tran No."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cboTrnNo
        '
        Me.cboTrnNo.Name = "cboTrnNo"
        Me.cboTrnNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel1.Text = "Transfer No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboTrnNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnCancel, Me.btnPrint, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(996, 25)
        Me.ToolStrip1.TabIndex = 350
        '
        'btnSave
        '
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
        Me.btnCancel.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripLabel2.Text = "**Show Only Location Emply"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        '
        'old_mtl_warehouse_id
        '
        Me.old_mtl_warehouse_id.DataPropertyName = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.DisplayStyleForCurrentCellOnly = True
        Me.old_mtl_warehouse_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.old_mtl_warehouse_id.HeaderText = "Warehouse From"
        Me.old_mtl_warehouse_id.Name = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.ReadOnly = True
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        Me.Lot.ReadOnly = True
        '
        'old_mtl_subinventory_id
        '
        Me.old_mtl_subinventory_id.DataPropertyName = "old_mtl_subinventory_id"
        Me.old_mtl_subinventory_id.DisplayStyleForCurrentCellOnly = True
        Me.old_mtl_subinventory_id.HeaderText = "SubInventory From"
        Me.old_mtl_subinventory_id.Name = "old_mtl_subinventory_id"
        Me.old_mtl_subinventory_id.ReadOnly = True
        Me.old_mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.old_mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        '
        'sub_location
        '
        Me.sub_location.DataPropertyName = "sub_location"
        Me.sub_location.HeaderText = "Sub Location"
        Me.sub_location.Name = "sub_location"
        Me.sub_location.ReadOnly = True
        Me.sub_location.Visible = False
        '
        'grdRollNo
        '
        Me.grdRollNo.AllowUserToAddRows = False
        Me.grdRollNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRollNo.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdRollNo.ColumnHeadersHeight = 50
        Me.grdRollNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdRollNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roll_no_g, Me.sub_location, Me.design_no, Me.Lot, Me.col, Me.old_mtl_warehouse_id, Me.old_mtl_subinventory_id, Me.old_mtl_locations_id, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.GradeFrom, Me.GradeTo})
        Me.grdRollNo.Location = New System.Drawing.Point(34, 176)
        Me.grdRollNo.Name = "grdRollNo"
        Me.grdRollNo.Size = New System.Drawing.Size(950, 232)
        Me.grdRollNo.TabIndex = 351
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_d"
        Me.roll_no_g.HeaderText = "Sys Roll No."
        Me.roll_no_g.Name = "roll_no_g"
        Me.roll_no_g.ReadOnly = True
        '
        'frmDyedTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 430)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpTrnDate)
        Me.Controls.Add(Me.txtTrnNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdRollNo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDyedTransfer"
        Me.Text = "Dyed Transfer"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optRollNoD As RadioButton
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnApplyCurRow As Button
    Friend WithEvents cbomtlLocation As ComboBox
    Friend WithEvents cbomtlwarehouse As ComboBox
    Friend WithEvents btnApplyAll As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblWarehourse As Label
    Friend WithEvents cbomtlsubinventory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents optLotNo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents GradeTo As DataGridViewTextBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents GradeFrom As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnApplyGrAll As Button
    Friend WithEvents btnApplyGrCurRow As Button
    Friend WithEvents txtGradeTo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents old_mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents dtpTrnDate As DateTimePicker
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents txtTrnNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cboTrnNo As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents old_mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents Lot As DataGridViewTextBoxColumn
    Friend WithEvents old_mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents sub_location As DataGridViewTextBoxColumn
    Friend WithEvents grdRollNo As DataGridView
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ChkLocationsEmply As CheckBox
End Class
