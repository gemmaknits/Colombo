<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGreigeTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeTransfer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txttrnNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpLogdt = New System.Windows.Forms.DateTimePicker()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.optGinNo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optRollNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnApplyLocAllRow = New System.Windows.Forms.Button()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnApplyCurLocRow = New System.Windows.Forms.Button()
        Me.txtGradeAdtTo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.grdRollNo = New System.Windows.Forms.DataGridView()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MtlWarehouseIdFrom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MtlSubinventoryIdFrom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MtlLocationsIdFrom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MtlWarehouseIdTo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MtlSubinventoryIdTo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MtlLocationsIdTo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LocFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeBdtFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeAdtFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeBdtTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeAdtTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtGradeBdtTo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnApplyGrAll = New System.Windows.Forms.Button()
        Me.btnApplyGrCurRow = New System.Windows.Forms.Button()
        Me.txtGradeTo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txttrnNo
        '
        Me.txttrnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttrnNo.Location = New System.Drawing.Point(60, 19)
        Me.txttrnNo.Name = "txttrnNo"
        Me.txttrnNo.Size = New System.Drawing.Size(104, 22)
        Me.txttrnNo.TabIndex = 340
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 338
        Me.Label1.Text = "Tran No."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 339
        Me.Label2.Text = "Tran Date"
        '
        'dtpLogdt
        '
        Me.dtpLogdt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpLogdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogdt.Location = New System.Drawing.Point(60, 47)
        Me.dtpLogdt.Name = "dtpLogdt"
        Me.dtpLogdt.Size = New System.Drawing.Size(104, 22)
        Me.dtpLogdt.TabIndex = 341
        '
        'lblWarehourse
        '
        Me.lblWarehourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(18, 21)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(80, 13)
        Me.lblWarehourse.TabIndex = 335
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'optGinNo
        '
        Me.optGinNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optGinNo.AutoSize = True
        Me.optGinNo.Location = New System.Drawing.Point(112, 18)
        Me.optGinNo.Name = "optGinNo"
        Me.optGinNo.Size = New System.Drawing.Size(65, 17)
        Me.optGinNo.TabIndex = 331
        Me.optGinNo.TabStop = True
        Me.optGinNo.Text = "GIN No."
        Me.optGinNo.UseVisualStyleBackColor = True
        Me.optGinNo.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 332
        Me.Label4.Text = "Location to"
        '
        'optRollNo
        '
        Me.optRollNo.AutoSize = True
        Me.optRollNo.Checked = True
        Me.optRollNo.Location = New System.Drawing.Point(20, 18)
        Me.optRollNo.Name = "optRollNo"
        Me.optRollNo.Size = New System.Drawing.Size(88, 17)
        Me.optRollNo.TabIndex = 330
        Me.optRollNo.TabStop = True
        Me.optRollNo.Text = "Sys. Roll No."
        Me.optRollNo.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txttrnNo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.dtpLogdt)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(911, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 93)
        Me.GroupBox4.TabIndex = 357
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Document"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 337
        Me.Label3.Text = "Subinventory to"
        '
        'btnApplyLocAllRow
        '
        Me.btnApplyLocAllRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyLocAllRow.Image = CType(resources.GetObject("btnApplyLocAllRow.Image"), System.Drawing.Image)
        Me.btnApplyLocAllRow.Location = New System.Drawing.Point(237, 58)
        Me.btnApplyLocAllRow.Name = "btnApplyLocAllRow"
        Me.btnApplyLocAllRow.Size = New System.Drawing.Size(74, 33)
        Me.btnApplyLocAllRow.TabIndex = 329
        Me.btnApplyLocAllRow.Text = "All Row"
        Me.btnApplyLocAllRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnApplyLocAllRow.UseVisualStyleBackColor = True
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(103, 16)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_warehouse.TabIndex = 333
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtl_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(103, 72)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_Location.TabIndex = 334
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(103, 43)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_subinventory.TabIndex = 336
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "Grade of Dye Test To"
        '
        'btnApplyCurLocRow
        '
        Me.btnApplyCurLocRow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurLocRow.Image = CType(resources.GetObject("btnApplyCurLocRow.Image"), System.Drawing.Image)
        Me.btnApplyCurLocRow.Location = New System.Drawing.Point(235, 16)
        Me.btnApplyCurLocRow.Name = "btnApplyCurLocRow"
        Me.btnApplyCurLocRow.Size = New System.Drawing.Size(76, 33)
        Me.btnApplyCurLocRow.TabIndex = 346
        Me.btnApplyCurLocRow.Text = "Curent Row"
        Me.btnApplyCurLocRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnApplyCurLocRow.UseVisualStyleBackColor = True
        '
        'txtGradeAdtTo
        '
        Me.txtGradeAdtTo.Location = New System.Drawing.Point(141, 47)
        Me.txtGradeAdtTo.Name = "txtGradeAdtTo"
        Me.txtGradeAdtTo.Size = New System.Drawing.Size(67, 22)
        Me.txtGradeAdtTo.TabIndex = 351
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
        'grdRollNo
        '
        Me.grdRollNo.AllowUserToAddRows = False
        Me.grdRollNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRollNo.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRollNo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdRollNo.ColumnHeadersHeight = 70
        Me.grdRollNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roll_no_g, Me.sub_location, Me.design_no, Me.Lot, Me.col, Me.MtlWarehouseIdFrom, Me.MtlSubinventoryIdFrom, Me.MtlLocationsIdFrom, Me.MtlWarehouseIdTo, Me.MtlSubinventoryIdTo, Me.MtlLocationsIdTo, Me.LocFrom, Me.LocTo, Me.GradeBdtFrom, Me.GradeAdtFrom, Me.GradeFrom, Me.GradeBdtTo, Me.GradeAdtTo, Me.GradeTo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdRollNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdRollNo.Location = New System.Drawing.Point(8, 146)
        Me.grdRollNo.Name = "grdRollNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRollNo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdRollNo.Size = New System.Drawing.Size(1073, 273)
        Me.grdRollNo.TabIndex = 353
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Sys. Roll No."
        Me.roll_no_g.Name = "roll_no_g"
        '
        'sub_location
        '
        Me.sub_location.DataPropertyName = "sub_location"
        Me.sub_location.HeaderText = "Sub Location"
        Me.sub_location.Name = "sub_location"
        Me.sub_location.ReadOnly = True
        Me.sub_location.Visible = False
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.Visible = False
        Me.col.Width = 80
        '
        'MtlWarehouseIdFrom
        '
        Me.MtlWarehouseIdFrom.DataPropertyName = "mtl_warehouse_id_from"
        Me.MtlWarehouseIdFrom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlWarehouseIdFrom.HeaderText = "Warehouse From"
        Me.MtlWarehouseIdFrom.Name = "MtlWarehouseIdFrom"
        Me.MtlWarehouseIdFrom.ReadOnly = True
        Me.MtlWarehouseIdFrom.Width = 80
        '
        'MtlSubinventoryIdFrom
        '
        Me.MtlSubinventoryIdFrom.DataPropertyName = "mtl_subinventory_id_from"
        Me.MtlSubinventoryIdFrom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlSubinventoryIdFrom.HeaderText = "Subinventory From"
        Me.MtlSubinventoryIdFrom.Name = "MtlSubinventoryIdFrom"
        Me.MtlSubinventoryIdFrom.ReadOnly = True
        Me.MtlSubinventoryIdFrom.Width = 80
        '
        'MtlLocationsIdFrom
        '
        Me.MtlLocationsIdFrom.DataPropertyName = "mtl_locations_id_from"
        Me.MtlLocationsIdFrom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlLocationsIdFrom.HeaderText = "Locations From"
        Me.MtlLocationsIdFrom.Name = "MtlLocationsIdFrom"
        Me.MtlLocationsIdFrom.ReadOnly = True
        Me.MtlLocationsIdFrom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MtlLocationsIdFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MtlLocationsIdFrom.Width = 80
        '
        'MtlWarehouseIdTo
        '
        Me.MtlWarehouseIdTo.DataPropertyName = "mtl_warehouse_id_to"
        Me.MtlWarehouseIdTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlWarehouseIdTo.HeaderText = "Warehouse to"
        Me.MtlWarehouseIdTo.Name = "MtlWarehouseIdTo"
        Me.MtlWarehouseIdTo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MtlWarehouseIdTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MtlSubinventoryIdTo
        '
        Me.MtlSubinventoryIdTo.DataPropertyName = "mtl_subinventory_id_to"
        Me.MtlSubinventoryIdTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlSubinventoryIdTo.HeaderText = "SubInventory to"
        Me.MtlSubinventoryIdTo.Name = "MtlSubinventoryIdTo"
        Me.MtlSubinventoryIdTo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MtlSubinventoryIdTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MtlLocationsIdTo
        '
        Me.MtlLocationsIdTo.DataPropertyName = "mtl_locations_id_to"
        Me.MtlLocationsIdTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MtlLocationsIdTo.HeaderText = "Locations To"
        Me.MtlLocationsIdTo.Name = "MtlLocationsIdTo"
        Me.MtlLocationsIdTo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MtlLocationsIdTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LocFrom
        '
        Me.LocFrom.DataPropertyName = "loc_from"
        Me.LocFrom.HeaderText = "Loc From"
        Me.LocFrom.Name = "LocFrom"
        Me.LocFrom.ReadOnly = True
        Me.LocFrom.Visible = False
        Me.LocFrom.Width = 50
        '
        'LocTo
        '
        Me.LocTo.DataPropertyName = "loc_to"
        Me.LocTo.HeaderText = "Loc To"
        Me.LocTo.Name = "LocTo"
        Me.LocTo.Visible = False
        Me.LocTo.Width = 50
        '
        'GradeBdtFrom
        '
        Me.GradeBdtFrom.DataPropertyName = "grade_bdt_from"
        Me.GradeBdtFrom.HeaderText = "Grade of Inspection From"
        Me.GradeBdtFrom.Name = "GradeBdtFrom"
        Me.GradeBdtFrom.Width = 50
        '
        'GradeAdtFrom
        '
        Me.GradeAdtFrom.DataPropertyName = "grade_adt_from"
        Me.GradeAdtFrom.HeaderText = "Grade of Dye Test From"
        Me.GradeAdtFrom.Name = "GradeAdtFrom"
        Me.GradeAdtFrom.Width = 50
        '
        'GradeFrom
        '
        Me.GradeFrom.DataPropertyName = "grade_from"
        Me.GradeFrom.HeaderText = "Grade From"
        Me.GradeFrom.Name = "GradeFrom"
        Me.GradeFrom.Width = 50
        '
        'GradeBdtTo
        '
        Me.GradeBdtTo.DataPropertyName = "grade_bdt_to"
        Me.GradeBdtTo.HeaderText = "Grade of Inspection To"
        Me.GradeBdtTo.Name = "GradeBdtTo"
        Me.GradeBdtTo.Width = 50
        '
        'GradeAdtTo
        '
        Me.GradeAdtTo.DataPropertyName = "grade_adt_to"
        Me.GradeAdtTo.HeaderText = "Grade of Dye Test To"
        Me.GradeAdtTo.Name = "GradeAdtTo"
        Me.GradeAdtTo.Width = 50
        '
        'GradeTo
        '
        Me.GradeTo.DataPropertyName = "grade_to"
        Me.GradeTo.HeaderText = "Grade To"
        Me.GradeTo.Name = "GradeTo"
        Me.GradeTo.Width = 50
        '
        'txtGradeBdtTo
        '
        Me.txtGradeBdtTo.Location = New System.Drawing.Point(141, 19)
        Me.txtGradeBdtTo.Name = "txtGradeBdtTo"
        Me.txtGradeBdtTo.Size = New System.Drawing.Size(67, 22)
        Me.txtGradeBdtTo.TabIndex = 349
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(17, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 13)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "***Example Roll No. : 1200260"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 348
        Me.Label7.Text = "Grade of Inspection To"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtGradeAdtTo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtGradeBdtTo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnApplyGrAll)
        Me.GroupBox3.Controls.Add(Me.btnApplyGrCurRow)
        Me.GroupBox3.Controls.Add(Me.txtGradeTo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(551, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 96)
        Me.GroupBox3.TabIndex = 356
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Apply Grade"
        '
        'btnApplyGrAll
        '
        Me.btnApplyGrAll.Image = CType(resources.GetObject("btnApplyGrAll.Image"), System.Drawing.Image)
        Me.btnApplyGrAll.Location = New System.Drawing.Point(229, 62)
        Me.btnApplyGrAll.Name = "btnApplyGrAll"
        Me.btnApplyGrAll.Size = New System.Drawing.Size(77, 33)
        Me.btnApplyGrAll.TabIndex = 346
        Me.btnApplyGrAll.Text = "ALL Row"
        Me.btnApplyGrAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnApplyGrAll.UseVisualStyleBackColor = True
        '
        'btnApplyGrCurRow
        '
        Me.btnApplyGrCurRow.Image = CType(resources.GetObject("btnApplyGrCurRow.Image"), System.Drawing.Image)
        Me.btnApplyGrCurRow.Location = New System.Drawing.Point(229, 20)
        Me.btnApplyGrCurRow.Name = "btnApplyGrCurRow"
        Me.btnApplyGrCurRow.Size = New System.Drawing.Size(77, 33)
        Me.btnApplyGrCurRow.TabIndex = 346
        Me.btnApplyGrCurRow.Text = "Curent Row"
        Me.btnApplyGrCurRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnApplyGrCurRow.UseVisualStyleBackColor = True
        '
        'txtGradeTo
        '
        Me.txtGradeTo.Location = New System.Drawing.Point(141, 73)
        Me.txtGradeTo.Name = "txtGradeTo"
        Me.txtGradeTo.ReadOnly = True
        Me.txtGradeTo.Size = New System.Drawing.Size(67, 22)
        Me.txtGradeTo.TabIndex = 347
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 346
        Me.Label6.Text = "Grade to"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Controls.Add(Me.optGinNo)
        Me.GroupBox1.Controls.Add(Me.optRollNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 100)
        Me.GroupBox1.TabIndex = 354
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greige Detail"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(20, 57)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(177, 22)
        Me.txtBarcode.TabIndex = 320
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnApplyCurLocRow)
        Me.GroupBox2.Controls.Add(Me.lblWarehourse)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnApplyLocAllRow)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.cbomtl_Location)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(228, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 104)
        Me.GroupBox2.TabIndex = 355
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apply Stock Location"
        '
        'cboDocNo
        '
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(125, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel1.Text = "Transfer No."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1093, 25)
        Me.ToolStrip1.TabIndex = 352
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
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'frmGreigeTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 430)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grdRollNo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGreigeTransfer"
        Me.Text = "Greige Transfer"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttrnNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpLogdt As DateTimePicker
    Friend WithEvents lblWarehourse As Label
    Friend WithEvents optGinNo As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents optRollNo As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnApplyLocAllRow As Button
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents cbomtl_Location As ComboBox
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnApplyCurLocRow As Button
    Friend WithEvents txtGradeAdtTo As TextBox
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents grdRollNo As DataGridView
    Friend WithEvents txtGradeBdtTo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnApplyGrAll As Button
    Friend WithEvents btnApplyGrCurRow As Button
    Friend WithEvents txtGradeTo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboDocNo As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents sub_location As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents Lot As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents MtlWarehouseIdFrom As DataGridViewComboBoxColumn
    Friend WithEvents MtlSubinventoryIdFrom As DataGridViewComboBoxColumn
    Friend WithEvents MtlLocationsIdFrom As DataGridViewComboBoxColumn
    Friend WithEvents MtlWarehouseIdTo As DataGridViewComboBoxColumn
    Friend WithEvents MtlSubinventoryIdTo As DataGridViewComboBoxColumn
    Friend WithEvents MtlLocationsIdTo As DataGridViewComboBoxColumn
    Friend WithEvents LocFrom As DataGridViewTextBoxColumn
    Friend WithEvents LocTo As DataGridViewTextBoxColumn
    Friend WithEvents GradeBdtFrom As DataGridViewTextBoxColumn
    Friend WithEvents GradeAdtFrom As DataGridViewTextBoxColumn
    Friend WithEvents GradeFrom As DataGridViewTextBoxColumn
    Friend WithEvents GradeBdtTo As DataGridViewTextBoxColumn
    Friend WithEvents GradeAdtTo As DataGridViewTextBoxColumn
    Friend WithEvents GradeTo As DataGridViewTextBoxColumn
End Class
