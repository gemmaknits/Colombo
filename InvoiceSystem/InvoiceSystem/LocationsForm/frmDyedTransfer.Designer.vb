<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyedTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedTransfer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.dtpTrnDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTrnNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cboTrnNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdRollNo = New System.Windows.Forms.DataGridView()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.old_mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.old_mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.location2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(72, 62)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(179, 20)
        Me.txtBarcode.TabIndex = 352
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(497, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 359
        Me.Label8.Text = "Subinventory to"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(592, 86)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_subinventory.TabIndex = 358
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(496, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 354
        Me.Label9.Text = "Location to"
        '
        'lblWarehourse
        '
        Me.lblWarehourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(497, 62)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(74, 13)
        Me.lblWarehourse.TabIndex = 357
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtl_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(592, 115)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_Location.TabIndex = 356
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(592, 59)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(128, 21)
        Me.cbomtl_warehouse.TabIndex = 355
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Location = New System.Drawing.Point(20, 64)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(47, 13)
        Me.lblBarcode.TabIndex = 351
        Me.lblBarcode.Text = "Barcode"
        '
        'dtpTrnDate
        '
        Me.dtpTrnDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTrnDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTrnDate.Enabled = False
        Me.dtpTrnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTrnDate.Location = New System.Drawing.Point(862, 82)
        Me.dtpTrnDate.Name = "dtpTrnDate"
        Me.dtpTrnDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpTrnDate.TabIndex = 350
        '
        'txtTrnNo
        '
        Me.txtTrnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTrnNo.Location = New System.Drawing.Point(862, 58)
        Me.txtTrnNo.Name = "txtTrnNo"
        Me.txtTrnNo.Size = New System.Drawing.Size(96, 20)
        Me.txtTrnNo.TabIndex = 349
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(782, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 348
        Me.Label2.Text = "Transfer Date"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel1.Text = "Transfer No."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(782, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 347
        Me.Label1.Text = "Transfer No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboTrnNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 345
        '
        'cboTrnNo
        '
        Me.cboTrnNo.Name = "cboTrnNo"
        Me.cboTrnNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
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
        Me.grdRollNo.Location = New System.Drawing.Point(34, 152)
        Me.grdRollNo.Name = "grdRollNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRollNo.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdRollNo.Size = New System.Drawing.Size(924, 256)
        Me.grdRollNo.TabIndex = 346
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_d"
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
        '
        'old_mtl_warehouse_id
        '
        Me.old_mtl_warehouse_id.DataPropertyName = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.HeaderText = "Old Warehouse"
        Me.old_mtl_warehouse_id.Name = "old_mtl_warehouse_id"
        Me.old_mtl_warehouse_id.ReadOnly = True
        '
        'old_mtl_subinventory_id
        '
        Me.old_mtl_subinventory_id.HeaderText = "Old Subinventory"
        Me.old_mtl_subinventory_id.Name = "old_mtl_subinventory_id"
        Me.old_mtl_subinventory_id.ReadOnly = True
        Me.old_mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.old_mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'old_mtl_locations_id
        '
        Me.old_mtl_locations_id.DataPropertyName = "old_mtl_locations_id"
        Me.old_mtl_locations_id.HeaderText = "Old Locations"
        Me.old_mtl_locations_id.Name = "old_mtl_locations_id"
        Me.old_mtl_locations_id.ReadOnly = True
        Me.old_mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.old_mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(726, 59)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(50, 77)
        Me.btnApply.TabIndex = 353
        Me.btnApply.Text = "APPLY ALL"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frmDyedTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 430)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblWarehourse)
        Me.Controls.Add(Me.cbomtl_Location)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.dtpTrnDate)
        Me.Controls.Add(Me.txtTrnNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdRollNo)
        Me.Controls.Add(Me.btnApply)
        Me.Name = "frmDyedTransfer"
        Me.Text = "Dyed Transfer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdRollNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblWarehourse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_Location As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents dtpTrnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTrnNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cboTrnNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdRollNo As System.Windows.Forms.DataGridView
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents old_mtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents old_mtl_locations_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents location2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
