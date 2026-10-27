<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
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
        Me.grdDatamtl_reservations = New System.Windows.Forms.DataGridView()
        Me.btnAddReser = New System.Windows.Forms.Button()
        Me.btnDelReser = New System.Windows.Forms.Button()
        Me.cbodemand_source_header_id = New System.Windows.Forms.ComboBox()
        Me.lbldemand_source_header_id = New System.Windows.Forms.Label()
        Me.lbldemand_source_type_id = New System.Windows.Forms.Label()
        Me.cbodemand_source_type_id = New System.Windows.Forms.ComboBox()
        Me.lbldemand_source_line_id = New System.Windows.Forms.Label()
        Me.cbodemand_source_line_id = New System.Windows.Forms.ComboBox()
        Me.cbosupply_source_line_id = New System.Windows.Forms.ComboBox()
        Me.lblsupply_source_line_id = New System.Windows.Forms.Label()
        Me.lblsupply_source_type_id = New System.Windows.Forms.Label()
        Me.cbosupply_source_type_id = New System.Windows.Forms.ComboBox()
        Me.lblsupply_source_header_id = New System.Windows.Forms.Label()
        Me.cbosupply_source_header_id = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbosupply_source_lot_number = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lbl_demand_lot_number = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtl_reservations_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demand_source_type_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.demand_source_header_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.demand_source_line_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.demand_source_item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demand_source_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reserve_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reserve_qty2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reserve_uom_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reserve_uom_id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom_id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.base_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supply_source_type_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.supply_source_header_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.supply_source_line_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.supply_source_item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supply_source_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creation_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_modified_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_modified_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expected_release_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdDatamtl_reservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDatamtl_reservations
        '
        Me.grdDatamtl_reservations.AllowUserToAddRows = False
        Me.grdDatamtl_reservations.AllowUserToDeleteRows = False
        Me.grdDatamtl_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatamtl_reservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selected, Me.mtl_reservations_id, Me.mtl_warehouse_id, Me.mtl_locations_id, Me.demand_source_type_id, Me.demand_source_header_id, Me.demand_source_line_id, Me.demand_source_item_id, Me.demand_source_lot_number, Me.reserve_qty, Me.reserve_qty2, Me.reserve_uom_id, Me.reserve_uom_id2, Me.uom_id, Me.uom_id2, Me.base_qty, Me.supply_source_type_id, Me.supply_source_header_id, Me.supply_source_line_id, Me.supply_source_item_id, Me.supply_source_lot_number, Me.mtl_subinventory_id, Me.creation_date, Me.created_by, Me.last_modified_date, Me.last_modified_by, Me.expected_release_date})
        Me.grdDatamtl_reservations.Location = New System.Drawing.Point(50, 246)
        Me.grdDatamtl_reservations.Name = "grdDatamtl_reservations"
        Me.grdDatamtl_reservations.Size = New System.Drawing.Size(698, 129)
        Me.grdDatamtl_reservations.TabIndex = 0
        '
        'btnAddReser
        '
        Me.btnAddReser.Location = New System.Drawing.Point(50, 217)
        Me.btnAddReser.Name = "btnAddReser"
        Me.btnAddReser.Size = New System.Drawing.Size(75, 23)
        Me.btnAddReser.TabIndex = 456
        Me.btnAddReser.Text = "Add"
        Me.btnAddReser.UseVisualStyleBackColor = True
        '
        'btnDelReser
        '
        Me.btnDelReser.Location = New System.Drawing.Point(131, 217)
        Me.btnDelReser.Name = "btnDelReser"
        Me.btnDelReser.Size = New System.Drawing.Size(75, 23)
        Me.btnDelReser.TabIndex = 457
        Me.btnDelReser.Text = "Remove"
        Me.btnDelReser.UseVisualStyleBackColor = True
        '
        'cbodemand_source_header_id
        '
        Me.cbodemand_source_header_id.FormattingEnabled = True
        Me.cbodemand_source_header_id.Location = New System.Drawing.Point(164, 77)
        Me.cbodemand_source_header_id.Name = "cbodemand_source_header_id"
        Me.cbodemand_source_header_id.Size = New System.Drawing.Size(121, 21)
        Me.cbodemand_source_header_id.TabIndex = 458
        '
        'lbldemand_source_header_id
        '
        Me.lbldemand_source_header_id.AutoSize = True
        Me.lbldemand_source_header_id.Location = New System.Drawing.Point(47, 80)
        Me.lbldemand_source_header_id.Name = "lbldemand_source_header_id"
        Me.lbldemand_source_header_id.Size = New System.Drawing.Size(84, 13)
        Me.lbldemand_source_header_id.TabIndex = 459
        Me.lbldemand_source_header_id.Text = "Demand Source"
        '
        'lbldemand_source_type_id
        '
        Me.lbldemand_source_type_id.AutoSize = True
        Me.lbldemand_source_type_id.Location = New System.Drawing.Point(47, 44)
        Me.lbldemand_source_type_id.Name = "lbldemand_source_type_id"
        Me.lbldemand_source_type_id.Size = New System.Drawing.Size(111, 13)
        Me.lbldemand_source_type_id.TabIndex = 461
        Me.lbldemand_source_type_id.Text = "Demand Source Type"
        '
        'cbodemand_source_type_id
        '
        Me.cbodemand_source_type_id.FormattingEnabled = True
        Me.cbodemand_source_type_id.Location = New System.Drawing.Point(164, 41)
        Me.cbodemand_source_type_id.Name = "cbodemand_source_type_id"
        Me.cbodemand_source_type_id.Size = New System.Drawing.Size(121, 21)
        Me.cbodemand_source_type_id.TabIndex = 460
        '
        'lbldemand_source_line_id
        '
        Me.lbldemand_source_line_id.AutoSize = True
        Me.lbldemand_source_line_id.Location = New System.Drawing.Point(47, 115)
        Me.lbldemand_source_line_id.Name = "lbldemand_source_line_id"
        Me.lbldemand_source_line_id.Size = New System.Drawing.Size(107, 13)
        Me.lbldemand_source_line_id.TabIndex = 462
        Me.lbldemand_source_line_id.Text = "Demand Source Line"
        '
        'cbodemand_source_line_id
        '
        Me.cbodemand_source_line_id.FormattingEnabled = True
        Me.cbodemand_source_line_id.Location = New System.Drawing.Point(164, 112)
        Me.cbodemand_source_line_id.Name = "cbodemand_source_line_id"
        Me.cbodemand_source_line_id.Size = New System.Drawing.Size(121, 21)
        Me.cbodemand_source_line_id.TabIndex = 463
        '
        'cbosupply_source_line_id
        '
        Me.cbosupply_source_line_id.Enabled = False
        Me.cbosupply_source_line_id.FormattingEnabled = True
        Me.cbosupply_source_line_id.Location = New System.Drawing.Point(627, 115)
        Me.cbosupply_source_line_id.Name = "cbosupply_source_line_id"
        Me.cbosupply_source_line_id.Size = New System.Drawing.Size(121, 21)
        Me.cbosupply_source_line_id.TabIndex = 469
        '
        'lblsupply_source_line_id
        '
        Me.lblsupply_source_line_id.AutoSize = True
        Me.lblsupply_source_line_id.Location = New System.Drawing.Point(510, 118)
        Me.lblsupply_source_line_id.Name = "lblsupply_source_line_id"
        Me.lblsupply_source_line_id.Size = New System.Drawing.Size(99, 13)
        Me.lblsupply_source_line_id.TabIndex = 468
        Me.lblsupply_source_line_id.Text = "Supply Source Line"
        '
        'lblsupply_source_type_id
        '
        Me.lblsupply_source_type_id.AutoSize = True
        Me.lblsupply_source_type_id.Location = New System.Drawing.Point(510, 47)
        Me.lblsupply_source_type_id.Name = "lblsupply_source_type_id"
        Me.lblsupply_source_type_id.Size = New System.Drawing.Size(103, 13)
        Me.lblsupply_source_type_id.TabIndex = 467
        Me.lblsupply_source_type_id.Text = "Supply Source Type"
        '
        'cbosupply_source_type_id
        '
        Me.cbosupply_source_type_id.Enabled = False
        Me.cbosupply_source_type_id.FormattingEnabled = True
        Me.cbosupply_source_type_id.Location = New System.Drawing.Point(627, 44)
        Me.cbosupply_source_type_id.Name = "cbosupply_source_type_id"
        Me.cbosupply_source_type_id.Size = New System.Drawing.Size(121, 21)
        Me.cbosupply_source_type_id.TabIndex = 466
        '
        'lblsupply_source_header_id
        '
        Me.lblsupply_source_header_id.AutoSize = True
        Me.lblsupply_source_header_id.Location = New System.Drawing.Point(510, 83)
        Me.lblsupply_source_header_id.Name = "lblsupply_source_header_id"
        Me.lblsupply_source_header_id.Size = New System.Drawing.Size(76, 13)
        Me.lblsupply_source_header_id.TabIndex = 465
        Me.lblsupply_source_header_id.Text = "Supply Source"
        '
        'cbosupply_source_header_id
        '
        Me.cbosupply_source_header_id.Enabled = False
        Me.cbosupply_source_header_id.FormattingEnabled = True
        Me.cbosupply_source_header_id.Location = New System.Drawing.Point(627, 80)
        Me.cbosupply_source_header_id.Name = "cbosupply_source_header_id"
        Me.cbosupply_source_header_id.Size = New System.Drawing.Size(121, 21)
        Me.cbosupply_source_header_id.TabIndex = 464
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(673, 393)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 470
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbosupply_source_lot_number
        '
        Me.cbosupply_source_lot_number.FormattingEnabled = True
        Me.cbosupply_source_lot_number.Location = New System.Drawing.Point(627, 151)
        Me.cbosupply_source_lot_number.Name = "cbosupply_source_lot_number"
        Me.cbosupply_source_lot_number.Size = New System.Drawing.Size(121, 21)
        Me.cbosupply_source_lot_number.TabIndex = 474
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 473
        Me.Label1.Text = "Supply Lot Number"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(164, 148)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 472
        '
        'lbl_demand_lot_number
        '
        Me.lbl_demand_lot_number.AutoSize = True
        Me.lbl_demand_lot_number.Location = New System.Drawing.Point(47, 151)
        Me.lbl_demand_lot_number.Name = "lbl_demand_lot_number"
        Me.lbl_demand_lot_number.Size = New System.Drawing.Size(105, 13)
        Me.lbl_demand_lot_number.TabIndex = 471
        Me.lbl_demand_lot_number.Text = "Demand Lot Number"
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.selected.Width = 50
        '
        'mtl_reservations_id
        '
        Me.mtl_reservations_id.DataPropertyName = "mtl_reservations_id"
        Me.mtl_reservations_id.HeaderText = "mtl_reservations_id"
        Me.mtl_reservations_id.Name = "mtl_reservations_id"
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Locations"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        '
        'demand_source_type_id
        '
        Me.demand_source_type_id.DataPropertyName = "demand_source_type_id"
        Me.demand_source_type_id.HeaderText = "Deman Soure Type"
        Me.demand_source_type_id.Name = "demand_source_type_id"
        Me.demand_source_type_id.ReadOnly = True
        Me.demand_source_type_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.demand_source_type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'demand_source_header_id
        '
        Me.demand_source_header_id.DataPropertyName = "demand_source_header_id"
        Me.demand_source_header_id.HeaderText = "Demand Source Header"
        Me.demand_source_header_id.Name = "demand_source_header_id"
        Me.demand_source_header_id.ReadOnly = True
        Me.demand_source_header_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.demand_source_header_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'demand_source_line_id
        '
        Me.demand_source_line_id.DataPropertyName = "demand_source_line_id"
        Me.demand_source_line_id.HeaderText = "Demand Source Line"
        Me.demand_source_line_id.Name = "demand_source_line_id"
        Me.demand_source_line_id.ReadOnly = True
        Me.demand_source_line_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.demand_source_line_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'demand_source_item_id
        '
        Me.demand_source_item_id.DataPropertyName = "demand_source_item_id"
        Me.demand_source_item_id.HeaderText = "Demand Source Item"
        Me.demand_source_item_id.Name = "demand_source_item_id"
        '
        'demand_source_lot_number
        '
        Me.demand_source_lot_number.DataPropertyName = "demand_source_lot_number"
        Me.demand_source_lot_number.HeaderText = "Demand Source Lot Number"
        Me.demand_source_lot_number.Name = "demand_source_lot_number"
        '
        'reserve_qty
        '
        Me.reserve_qty.DataPropertyName = "reserve_qty"
        Me.reserve_qty.HeaderText = "reserve_qty"
        Me.reserve_qty.Name = "reserve_qty"
        '
        'reserve_qty2
        '
        Me.reserve_qty2.DataPropertyName = "reserve_qty2"
        Me.reserve_qty2.HeaderText = "reserve_qty2"
        Me.reserve_qty2.Name = "reserve_qty2"
        '
        'reserve_uom_id
        '
        Me.reserve_uom_id.DataPropertyName = "reserve_uom_id"
        Me.reserve_uom_id.HeaderText = "reserve_uom_id"
        Me.reserve_uom_id.Name = "reserve_uom_id"
        '
        'reserve_uom_id2
        '
        Me.reserve_uom_id2.DataPropertyName = "reserve_uom_id2"
        Me.reserve_uom_id2.HeaderText = "reserve_uom_id2"
        Me.reserve_uom_id2.Name = "reserve_uom_id2"
        '
        'uom_id
        '
        Me.uom_id.DataPropertyName = "uom_id"
        Me.uom_id.HeaderText = "uom_id"
        Me.uom_id.Name = "uom_id"
        '
        'uom_id2
        '
        Me.uom_id2.DataPropertyName = "uom_id2"
        Me.uom_id2.HeaderText = "uom_id2"
        Me.uom_id2.Name = "uom_id2"
        '
        'base_qty
        '
        Me.base_qty.DataPropertyName = "base_qty"
        Me.base_qty.HeaderText = "base_qty"
        Me.base_qty.Name = "base_qty"
        '
        'supply_source_type_id
        '
        Me.supply_source_type_id.DataPropertyName = "supply_source_type_id"
        Me.supply_source_type_id.HeaderText = "Supply Source Type"
        Me.supply_source_type_id.Name = "supply_source_type_id"
        Me.supply_source_type_id.ReadOnly = True
        Me.supply_source_type_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supply_source_type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'supply_source_header_id
        '
        Me.supply_source_header_id.DataPropertyName = "supply_source_header_id"
        Me.supply_source_header_id.HeaderText = "Supply Source Header"
        Me.supply_source_header_id.Name = "supply_source_header_id"
        Me.supply_source_header_id.ReadOnly = True
        Me.supply_source_header_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supply_source_header_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'supply_source_line_id
        '
        Me.supply_source_line_id.DataPropertyName = "supply_source_line_id"
        Me.supply_source_line_id.HeaderText = "Supply Source Line"
        Me.supply_source_line_id.Name = "supply_source_line_id"
        Me.supply_source_line_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supply_source_line_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'supply_source_item_id
        '
        Me.supply_source_item_id.DataPropertyName = "supply_source_item_id"
        Me.supply_source_item_id.HeaderText = "Supply Source Item"
        Me.supply_source_item_id.Name = "supply_source_item_id"
        '
        'supply_source_lot_number
        '
        Me.supply_source_lot_number.DataPropertyName = "supply_source_lot_number"
        Me.supply_source_lot_number.HeaderText = "Supply Source Lot Number"
        Me.supply_source_lot_number.Name = "supply_source_lot_number"
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        '
        'creation_date
        '
        Me.creation_date.DataPropertyName = "creation_date"
        Me.creation_date.HeaderText = "Creation Date"
        Me.creation_date.Name = "creation_date"
        '
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "Created By"
        Me.created_by.Name = "created_by"
        '
        'last_modified_date
        '
        Me.last_modified_date.DataPropertyName = "last_modified_date"
        Me.last_modified_date.HeaderText = "Last Modified Date"
        Me.last_modified_date.Name = "last_modified_date"
        '
        'last_modified_by
        '
        Me.last_modified_by.DataPropertyName = "last_modified_by"
        Me.last_modified_by.HeaderText = "Last Modified By"
        Me.last_modified_by.Name = "last_modified_by"
        '
        'expected_release_date
        '
        Me.expected_release_date.DataPropertyName = "expected_release_date"
        Me.expected_release_date.HeaderText = "Expected Release Date"
        Me.expected_release_date.Name = "expected_release_date"
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 440)
        Me.Controls.Add(Me.cbosupply_source_lot_number)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lbl_demand_lot_number)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbosupply_source_line_id)
        Me.Controls.Add(Me.lblsupply_source_line_id)
        Me.Controls.Add(Me.lblsupply_source_type_id)
        Me.Controls.Add(Me.cbosupply_source_type_id)
        Me.Controls.Add(Me.lblsupply_source_header_id)
        Me.Controls.Add(Me.cbosupply_source_header_id)
        Me.Controls.Add(Me.cbodemand_source_line_id)
        Me.Controls.Add(Me.lbldemand_source_line_id)
        Me.Controls.Add(Me.lbldemand_source_type_id)
        Me.Controls.Add(Me.cbodemand_source_type_id)
        Me.Controls.Add(Me.lbldemand_source_header_id)
        Me.Controls.Add(Me.cbodemand_source_header_id)
        Me.Controls.Add(Me.btnDelReser)
        Me.Controls.Add(Me.btnAddReser)
        Me.Controls.Add(Me.grdDatamtl_reservations)
        Me.Name = "frmReservation"
        Me.Text = "Reservations Management"
        CType(Me.grdDatamtl_reservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDatamtl_reservations As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddReser As System.Windows.Forms.Button
    Friend WithEvents btnDelReser As System.Windows.Forms.Button
    Friend WithEvents cbodemand_source_header_id As System.Windows.Forms.ComboBox
    Friend WithEvents lbldemand_source_header_id As System.Windows.Forms.Label
    Friend WithEvents lbldemand_source_type_id As System.Windows.Forms.Label
    Friend WithEvents cbodemand_source_type_id As System.Windows.Forms.ComboBox
    Friend WithEvents lbldemand_source_line_id As System.Windows.Forms.Label
    Friend WithEvents cbodemand_source_line_id As System.Windows.Forms.ComboBox
    Friend WithEvents cbosupply_source_line_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblsupply_source_line_id As System.Windows.Forms.Label
    Friend WithEvents lblsupply_source_type_id As System.Windows.Forms.Label
    Friend WithEvents cbosupply_source_type_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblsupply_source_header_id As System.Windows.Forms.Label
    Friend WithEvents cbosupply_source_header_id As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbosupply_source_lot_number As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_demand_lot_number As System.Windows.Forms.Label
    Friend WithEvents selected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mtl_reservations_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents demand_source_type_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents demand_source_header_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents demand_source_line_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents demand_source_item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents demand_source_lot_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reserve_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reserve_qty2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reserve_uom_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reserve_uom_id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uom_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uom_id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents base_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supply_source_type_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supply_source_header_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supply_source_line_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents supply_source_item_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supply_source_lot_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_subinventory_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creation_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents created_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_modified_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_modified_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expected_release_date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
