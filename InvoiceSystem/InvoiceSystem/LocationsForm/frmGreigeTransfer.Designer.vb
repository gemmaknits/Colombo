<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeTransfer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txttrnNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.optGinNo = New System.Windows.Forms.RadioButton()
        Me.optRollNo = New System.Windows.Forms.RadioButton()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdRollNo = New System.Windows.Forms.DataGridView()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.old_mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.location2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.dtpLogdt = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel1.Text = "Transfer No."
        '
        'txttrnNo
        '
        Me.txttrnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttrnNo.Location = New System.Drawing.Point(854, 47)
        Me.txttrnNo.Name = "txttrnNo"
        Me.txttrnNo.Size = New System.Drawing.Size(104, 20)
        Me.txttrnNo.TabIndex = 358
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(798, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 357
        Me.Label2.Text = "Doc Date"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(798, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 356
        Me.Label1.Text = "Doc No."
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(23, 22)
        Me.btnCancel.Text = "Cancel Document"
        Me.btnCancel.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(513, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 355
        Me.Label3.Text = "Subinventory to"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(608, 70)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_subinventory.TabIndex = 354
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 350
        Me.Label4.Text = "Location to"
        '
        'lblWarehourse
        '
        Me.lblWarehourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(513, 46)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(74, 13)
        Me.lblWarehourse.TabIndex = 353
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtl_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(608, 99)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_Location.TabIndex = 352
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(608, 43)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_warehouse.TabIndex = 351
        '
        'optGinNo
        '
        Me.optGinNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optGinNo.AutoSize = True
        Me.optGinNo.Location = New System.Drawing.Point(147, 62)
        Me.optGinNo.Name = "optGinNo"
        Me.optGinNo.Size = New System.Drawing.Size(64, 17)
        Me.optGinNo.TabIndex = 349
        Me.optGinNo.TabStop = True
        Me.optGinNo.Text = "GIN No."
        Me.optGinNo.UseVisualStyleBackColor = True
        Me.optGinNo.Visible = False
        '
        'optRollNo
        '
        Me.optRollNo.AutoSize = True
        Me.optRollNo.Checked = True
        Me.optRollNo.Location = New System.Drawing.Point(32, 62)
        Me.optRollNo.Name = "optRollNo"
        Me.optRollNo.Size = New System.Drawing.Size(63, 17)
        Me.optRollNo.TabIndex = 348
        Me.optRollNo.TabStop = True
        Me.optRollNo.Text = "Roll No."
        Me.optRollNo.UseVisualStyleBackColor = True
        Me.optRollNo.Visible = False
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(742, 43)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(50, 77)
        Me.btnApply.TabIndex = 347
        Me.btnApply.Text = "APPLY ALL"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(146, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 13)
        Me.Label5.TabIndex = 346
        Me.Label5.Text = "***Example Roll No. : 1200260"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 342
        '
        'cboDocNo
        '
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(125, 25)
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
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(13, 100)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(128, 13)
        Me.lblBarcode.TabIndex = 344
        Me.lblBarcode.Text = "Greige Roll No. Barcode :"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.Width = 80
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        '
        'old_mtl_warehouse_id
        '
        Me.old_mtl_warehouse_id.DataPropertyName = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.HeaderText = "Old Warehouse"
        Me.old_mtl_warehouse_id.Name = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.ReadOnly = True
        Me.old_mtl_warehouse_id.Width = 80
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRollNo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdRollNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRollNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roll_no_g, Me.sub_location, Me.design_no, Me.Lot, Me.col, Me.old_mtl_warehouse_id, Me.old_mtl_subinventory_id, Me.old_mtl_locations_id, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.location2})
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
        Me.grdRollNo.Size = New System.Drawing.Size(950, 273)
        Me.grdRollNo.TabIndex = 343
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No."
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
        'old_mtl_subinventory_id
        '
        Me.old_mtl_subinventory_id.DataPropertyName = "old_mtl_subinventory_id"
        Me.old_mtl_subinventory_id.HeaderText = "Old Subinventory"
        Me.old_mtl_subinventory_id.Name = "old_mtl_subinventory_id"
        Me.old_mtl_subinventory_id.ReadOnly = True
        Me.old_mtl_subinventory_id.Width = 80
        '
        'old_mtl_locations_id
        '
        Me.old_mtl_locations_id.DataPropertyName = "old_mtl_locations_id"
        Me.old_mtl_locations_id.HeaderText = "Old Locations"
        Me.old_mtl_locations_id.Name = "old_mtl_locations_id"
        Me.old_mtl_locations_id.ReadOnly = True
        Me.old_mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.old_mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.old_mtl_locations_id.Width = 80
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "New Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "New Sub Inventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.mtl_locations_id.HeaderText = "New Locations"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'location2
        '
        Me.location2.DataPropertyName = "location"
        Me.location2.HeaderText = "Location"
        Me.location2.Name = "location2"
        Me.location2.ReadOnly = True
        Me.location2.Visible = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(147, 97)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(179, 20)
        Me.txtBarcode.TabIndex = 345
        '
        'dtpLogdt
        '
        Me.dtpLogdt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpLogdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogdt.Location = New System.Drawing.Point(854, 75)
        Me.dtpLogdt.Name = "dtpLogdt"
        Me.dtpLogdt.Size = New System.Drawing.Size(104, 20)
        Me.dtpLogdt.TabIndex = 359
        '
        'frmGreigeTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 430)
        Me.Controls.Add(Me.txttrnNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblWarehourse)
        Me.Controls.Add(Me.cbomtl_Location)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.optGinNo)
        Me.Controls.Add(Me.optRollNo)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.grdRollNo)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.dtpLogdt)
        Me.Name = "frmGreigeTransfer"
        Me.Text = "Greige Transfer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txttrnNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWarehourse As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbomtl_Location As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents optGinNo As System.Windows.Forms.RadioButton
    Friend WithEvents optRollNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdRollNo As System.Windows.Forms.DataGridView
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_mtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents old_mtl_locations_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents location2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents dtpLogdt As System.Windows.Forms.DateTimePicker
End Class
