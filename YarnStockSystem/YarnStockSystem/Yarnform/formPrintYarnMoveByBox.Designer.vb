<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPrintYarnMoveByBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboNewmtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgselectItem = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboNewmtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.optMoveByBatch = New System.Windows.Forms.RadioButton()
        Me.optMoveByItcd = New System.Windows.Forms.RadioButton()
        Me.optBalByBoxWithMove = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbitgroupcd = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboNewmtl_locations_id = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpShowBalanceByYyarnCode = New System.Windows.Forms.GroupBox()
        Me.optBalShowBalanceMultiColumnSortByDescp = New System.Windows.Forms.RadioButton()
        Me.optBalShowBalanceMultiColumnSortByCode = New System.Windows.Forms.RadioButton()
        Me.optBalByItcdSummary = New System.Windows.Forms.RadioButton()
        Me.optBalByBoxGrpByLocation = New System.Windows.Forms.RadioButton()
        Me.optBalByLoc = New System.Windows.Forms.RadioButton()
        Me.optBalByItcdUsage = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDateShowBF = New System.Windows.Forms.DateTimePicker()
        Me.optBalByItcd = New System.Windows.Forms.RadioButton()
        Me.optBalByBox = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlookup = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpShowBalanceByYyarnCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(94, 110)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShowCheckBox = True
        Me.dtpDateTo.Size = New System.Drawing.Size(96, 22)
        Me.dtpDateTo.TabIndex = 155
        '
        'cboGrade
        '
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboGrade.Location = New System.Drawing.Point(87, 115)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(156, 21)
        Me.cboGrade.TabIndex = 159
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Grade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Sub Inven"
        '
        'cboNewmtl_warehouse
        '
        Me.cboNewmtl_warehouse.FormattingEnabled = True
        Me.cboNewmtl_warehouse.Location = New System.Drawing.Point(87, 20)
        Me.cboNewmtl_warehouse.Name = "cboNewmtl_warehouse"
        Me.cboNewmtl_warehouse.Size = New System.Drawing.Size(156, 21)
        Me.cboNewmtl_warehouse.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "To Date"
        '
        'dgselectItem
        '
        Me.dgselectItem.AllowUserToAddRows = False
        Me.dgselectItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgselectItem.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgselectItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgselectItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colitcd, Me.colItemDesc, Me.suppname})
        Me.dgselectItem.Location = New System.Drawing.Point(16, 34)
        Me.dgselectItem.Name = "dgselectItem"
        Me.dgselectItem.Size = New System.Drawing.Size(666, 582)
        Me.dgselectItem.TabIndex = 163
        '
        'colSelect
        '
        Me.colSelect.HeaderText = ""
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSelect.Width = 25
        '
        'colitcd
        '
        Me.colitcd.DataPropertyName = "itcd"
        Me.colitcd.HeaderText = "Item Code"
        Me.colitcd.Name = "colitcd"
        Me.colitcd.Visible = False
        '
        'colItemDesc
        '
        Me.colItemDesc.DataPropertyName = "itdesc"
        Me.colItemDesc.HeaderText = "Yarn Description"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.Width = 300
        '
        'suppname
        '
        Me.suppname.DataPropertyName = "suppname"
        Me.suppname.HeaderText = "Supplier"
        Me.suppname.Name = "suppname"
        Me.suppname.Width = 250
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "From Date"
        '
        'cboNewmtl_subinventory
        '
        Me.cboNewmtl_subinventory.FormattingEnabled = True
        Me.cboNewmtl_subinventory.Location = New System.Drawing.Point(87, 44)
        Me.cboNewmtl_subinventory.Name = "cboNewmtl_subinventory"
        Me.cboNewmtl_subinventory.Size = New System.Drawing.Size(156, 21)
        Me.cboNewmtl_subinventory.TabIndex = 2
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(93, 84)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.ShowCheckBox = True
        Me.dtpDateFr.Size = New System.Drawing.Size(96, 22)
        Me.dtpDateFr.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "W/H"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.optMoveByBatch)
        Me.GroupBox3.Controls.Add(Me.optMoveByItcd)
        Me.GroupBox3.Controls.Add(Me.optBalByBoxWithMove)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtpDateTo)
        Me.GroupBox3.Controls.Add(Me.dtpDateFr)
        Me.GroupBox3.Location = New System.Drawing.Point(701, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 138)
        Me.GroupBox3.TabIndex = 172
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type of Movement report"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(78, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = " :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = " :"
        '
        'optMoveByBatch
        '
        Me.optMoveByBatch.AutoSize = True
        Me.optMoveByBatch.Location = New System.Drawing.Point(16, 62)
        Me.optMoveByBatch.Name = "optMoveByBatch"
        Me.optMoveByBatch.Size = New System.Drawing.Size(157, 17)
        Me.optMoveByBatch.TabIndex = 4
        Me.optMoveByBatch.Text = "Show movement by batch"
        Me.optMoveByBatch.UseVisualStyleBackColor = True
        '
        'optMoveByItcd
        '
        Me.optMoveByItcd.AutoSize = True
        Me.optMoveByItcd.Checked = True
        Me.optMoveByItcd.Location = New System.Drawing.Point(16, 40)
        Me.optMoveByItcd.Name = "optMoveByItcd"
        Me.optMoveByItcd.Size = New System.Drawing.Size(178, 17)
        Me.optMoveByItcd.TabIndex = 3
        Me.optMoveByItcd.TabStop = True
        Me.optMoveByItcd.Text = "Show movement by yarn code"
        Me.optMoveByItcd.UseVisualStyleBackColor = True
        '
        'optBalByBoxWithMove
        '
        Me.optBalByBoxWithMove.AutoSize = True
        Me.optBalByBoxWithMove.Location = New System.Drawing.Point(16, 19)
        Me.optBalByBoxWithMove.Name = "optBalByBoxWithMove"
        Me.optBalByBoxWithMove.Size = New System.Drawing.Size(150, 17)
        Me.optBalByBoxWithMove.TabIndex = 0
        Me.optBalByBoxWithMove.Text = "Show movement by box "
        Me.optBalByBoxWithMove.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Location"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cbitgroupcd)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboNewmtl_locations_id)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.cboGrade)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboNewmtl_subinventory)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboNewmtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(701, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 166)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter for balance stock"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(69, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 181
        Me.Label15.Text = " :"
        '
        'cbitgroupcd
        '
        Me.cbitgroupcd.FormattingEnabled = True
        Me.cbitgroupcd.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbitgroupcd.Location = New System.Drawing.Point(87, 139)
        Me.cbitgroupcd.Name = "cbitgroupcd"
        Me.cbitgroupcd.Size = New System.Drawing.Size(156, 21)
        Me.cbitgroupcd.TabIndex = 180
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 179
        Me.Label16.Text = "Yarn group"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(69, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 178
        Me.Label14.Text = " :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 177
        Me.Label13.Text = " :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = " :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = " :"
        '
        'cboNewmtl_locations_id
        '
        Me.cboNewmtl_locations_id.FormattingEnabled = True
        Me.cboNewmtl_locations_id.Location = New System.Drawing.Point(87, 68)
        Me.cboNewmtl_locations_id.Name = "cboNewmtl_locations_id"
        Me.cboNewmtl_locations_id.Size = New System.Drawing.Size(156, 21)
        Me.cboNewmtl_locations_id.TabIndex = 174
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(87, 92)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(156, 22)
        Me.txtLocation.TabIndex = 173
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.grpShowBalanceByYyarnCode)
        Me.GroupBox1.Controls.Add(Me.optBalByItcdSummary)
        Me.GroupBox1.Controls.Add(Me.optBalByBoxGrpByLocation)
        Me.GroupBox1.Controls.Add(Me.optBalByLoc)
        Me.GroupBox1.Controls.Add(Me.optBalByItcdUsage)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpDateShowBF)
        Me.GroupBox1.Controls.Add(Me.optBalByItcd)
        Me.GroupBox1.Controls.Add(Me.optBalByBox)
        Me.GroupBox1.Location = New System.Drawing.Point(701, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 242)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Balance report"
        '
        'grpShowBalanceByYyarnCode
        '
        Me.grpShowBalanceByYyarnCode.Controls.Add(Me.optBalShowBalanceMultiColumnSortByDescp)
        Me.grpShowBalanceByYyarnCode.Controls.Add(Me.optBalShowBalanceMultiColumnSortByCode)
        Me.grpShowBalanceByYyarnCode.Location = New System.Drawing.Point(20, 90)
        Me.grpShowBalanceByYyarnCode.Name = "grpShowBalanceByYyarnCode"
        Me.grpShowBalanceByYyarnCode.Size = New System.Drawing.Size(241, 54)
        Me.grpShowBalanceByYyarnCode.TabIndex = 165
        Me.grpShowBalanceByYyarnCode.TabStop = False
        Me.grpShowBalanceByYyarnCode.Text = "Show balance by yarn code( Multi Column)"
        '
        'optBalShowBalanceMultiColumnSortByDescp
        '
        Me.optBalShowBalanceMultiColumnSortByDescp.AutoSize = True
        Me.optBalShowBalanceMultiColumnSortByDescp.Location = New System.Drawing.Point(28, 33)
        Me.optBalShowBalanceMultiColumnSortByDescp.Name = "optBalShowBalanceMultiColumnSortByDescp"
        Me.optBalShowBalanceMultiColumnSortByDescp.Size = New System.Drawing.Size(123, 17)
        Me.optBalShowBalanceMultiColumnSortByDescp.TabIndex = 166
        Me.optBalShowBalanceMultiColumnSortByDescp.Text = "Sort By Description"
        Me.optBalShowBalanceMultiColumnSortByDescp.UseVisualStyleBackColor = True
        '
        'optBalShowBalanceMultiColumnSortByCode
        '
        Me.optBalShowBalanceMultiColumnSortByCode.AutoSize = True
        Me.optBalShowBalanceMultiColumnSortByCode.Location = New System.Drawing.Point(28, 14)
        Me.optBalShowBalanceMultiColumnSortByCode.Name = "optBalShowBalanceMultiColumnSortByCode"
        Me.optBalShowBalanceMultiColumnSortByCode.Size = New System.Drawing.Size(91, 17)
        Me.optBalShowBalanceMultiColumnSortByCode.TabIndex = 165
        Me.optBalShowBalanceMultiColumnSortByCode.Text = "Sort By Code"
        Me.optBalShowBalanceMultiColumnSortByCode.UseVisualStyleBackColor = True
        '
        'optBalByItcdSummary
        '
        Me.optBalByItcdSummary.AutoSize = True
        Me.optBalByItcdSummary.Location = New System.Drawing.Point(11, 173)
        Me.optBalByItcdSummary.Name = "optBalByItcdSummary"
        Me.optBalByItcdSummary.Size = New System.Drawing.Size(214, 17)
        Me.optBalByItcdSummary.TabIndex = 164
        Me.optBalByItcdSummary.Text = "Show balance by yarn code Summary"
        Me.optBalByItcdSummary.UseVisualStyleBackColor = True
        '
        'optBalByBoxGrpByLocation
        '
        Me.optBalByBoxGrpByLocation.AutoSize = True
        Me.optBalByBoxGrpByLocation.Location = New System.Drawing.Point(11, 44)
        Me.optBalByBoxGrpByLocation.Name = "optBalByBoxGrpByLocation"
        Me.optBalByBoxGrpByLocation.Size = New System.Drawing.Size(238, 17)
        Me.optBalByBoxGrpByLocation.TabIndex = 163
        Me.optBalByBoxGrpByLocation.Text = "Show balance by box (Group by Location)"
        Me.optBalByBoxGrpByLocation.UseVisualStyleBackColor = True
        '
        'optBalByLoc
        '
        Me.optBalByLoc.AutoSize = True
        Me.optBalByLoc.Location = New System.Drawing.Point(11, 195)
        Me.optBalByLoc.Name = "optBalByLoc"
        Me.optBalByLoc.Size = New System.Drawing.Size(159, 17)
        Me.optBalByLoc.TabIndex = 162
        Me.optBalByLoc.Text = "Show balance by Location"
        Me.optBalByLoc.UseVisualStyleBackColor = True
        '
        'optBalByItcdUsage
        '
        Me.optBalByItcdUsage.AutoSize = True
        Me.optBalByItcdUsage.Location = New System.Drawing.Point(11, 150)
        Me.optBalByItcdUsage.Name = "optBalByItcdUsage"
        Me.optBalByItcdUsage.Size = New System.Drawing.Size(200, 17)
        Me.optBalByItcdUsage.TabIndex = 161
        Me.optBalByItcdUsage.Text = "Show balance by yarn code Usage"
        Me.optBalByItcdUsage.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "As on Date"
        '
        'dtpDateShowBF
        '
        Me.dtpDateShowBF.Checked = False
        Me.dtpDateShowBF.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateShowBF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateShowBF.Location = New System.Drawing.Point(94, 214)
        Me.dtpDateShowBF.Name = "dtpDateShowBF"
        Me.dtpDateShowBF.ShowCheckBox = True
        Me.dtpDateShowBF.Size = New System.Drawing.Size(95, 22)
        Me.dtpDateShowBF.TabIndex = 42
        '
        'optBalByItcd
        '
        Me.optBalByItcd.AutoSize = True
        Me.optBalByItcd.Location = New System.Drawing.Point(11, 66)
        Me.optBalByItcd.Name = "optBalByItcd"
        Me.optBalByItcd.Size = New System.Drawing.Size(165, 17)
        Me.optBalByItcd.TabIndex = 2
        Me.optBalByItcd.Text = "Show balance by yarn code"
        Me.optBalByItcd.UseVisualStyleBackColor = True
        '
        'optBalByBox
        '
        Me.optBalByBox.AutoSize = True
        Me.optBalByBox.Location = New System.Drawing.Point(11, 23)
        Me.optBalByBox.Name = "optBalByBox"
        Me.optBalByBox.Size = New System.Drawing.Size(134, 17)
        Me.optBalByBox.TabIndex = 1
        Me.optBalByBox.Text = "Show balance by box"
        Me.optBalByBox.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(509, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 24)
        Me.btnClear.TabIndex = 169
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(429, 4)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.btnSelectAll.TabIndex = 168
        Me.btnSelectAll.Text = "SelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Location = New System.Drawing.Point(786, 588)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 24)
        Me.btnExit.TabIndex = 167
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(706, 588)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(74, 24)
        Me.btnPrint.TabIndex = 166
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Lookup:"
        '
        'txtlookup
        '
        Me.txtlookup.Location = New System.Drawing.Point(72, 2)
        Me.txtlookup.Name = "txtlookup"
        Me.txtlookup.Size = New System.Drawing.Size(326, 22)
        Me.txtlookup.TabIndex = 164
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(78, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 159
        Me.Label17.Text = " :"
        '
        'formPrintYarnMoveByBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 618)
        Me.Controls.Add(Me.dgselectItem)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlookup)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formPrintYarnMoveByBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Yarn On Hand"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpShowBalanceByYyarnCode.ResumeLayout(False)
        Me.grpShowBalanceByYyarnCode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboNewmtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgselectItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboNewmtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optMoveByBatch As System.Windows.Forms.RadioButton
    Friend WithEvents optMoveByItcd As System.Windows.Forms.RadioButton
    Friend WithEvents optBalByBoxWithMove As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDateShowBF As System.Windows.Forms.DateTimePicker
    Friend WithEvents optBalByBox As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlookup As System.Windows.Forms.TextBox
    Friend WithEvents colSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colitcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suppname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents optBalByItcdUsage As System.Windows.Forms.RadioButton
    Friend WithEvents optBalByLoc As System.Windows.Forms.RadioButton
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cboNewmtl_locations_id As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbitgroupcd As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents optBalByBoxGrpByLocation As RadioButton
    Friend WithEvents optBalByItcdSummary As RadioButton
    Friend WithEvents optBalShowBalanceMultiColumnSortByCode As RadioButton
    Friend WithEvents grpShowBalanceByYyarnCode As GroupBox
    Friend WithEvents optBalShowBalanceMultiColumnSortByDescp As RadioButton
    Friend WithEvents optBalByItcd As RadioButton
    Friend WithEvents Label17 As Label
End Class
