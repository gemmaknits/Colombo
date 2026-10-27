<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDLocation))
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.optDFNo = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.optCol = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optLotNo = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.grdStockD = New System.Windows.Forms.DataGridView()
        Me.dinno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dindt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Roll_No_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSeach
        '
        Me.txtSeach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSeach.Location = New System.Drawing.Point(33, 58)
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(385, 20)
        Me.txtSeach.TabIndex = 0
        '
        'optDFNo
        '
        Me.optDFNo.AutoSize = True
        Me.optDFNo.Location = New System.Drawing.Point(367, 18)
        Me.optDFNo.Name = "optDFNo"
        Me.optDFNo.Size = New System.Drawing.Size(64, 17)
        Me.optDFNo.TabIndex = 8
        Me.optDFNo.TabStop = True
        Me.optDFNo.Text = "D/F No."
        Me.optDFNo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1178, 25)
        Me.ToolStrip1.TabIndex = 292
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'optCol
        '
        Me.optCol.AutoSize = True
        Me.optCol.Location = New System.Drawing.Point(244, 18)
        Me.optCol.Name = "optCol"
        Me.optCol.Size = New System.Drawing.Size(83, 17)
        Me.optCol.TabIndex = 7
        Me.optCol.TabStop = True
        Me.optCol.Text = "Colour Code"
        Me.optCol.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.optDFNo)
        Me.GroupBox1.Controls.Add(Me.optCol)
        Me.GroupBox1.Controls.Add(Me.optLotNo)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Controls.Add(Me.txtSeach)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1154, 100)
        Me.GroupBox1.TabIndex = 290
        Me.GroupBox1.TabStop = False
        '
        'optLotNo
        '
        Me.optLotNo.AutoSize = True
        Me.optLotNo.Location = New System.Drawing.Point(141, 18)
        Me.optLotNo.Name = "optLotNo"
        Me.optLotNo.Size = New System.Drawing.Size(60, 17)
        Me.optLotNo.TabIndex = 6
        Me.optLotNo.Text = "Lot No."
        Me.optLotNo.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Checked = True
        Me.optDesignNo.Location = New System.Drawing.Point(33, 18)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(78, 17)
        Me.optDesignNo.TabIndex = 5
        Me.optDesignNo.TabStop = True
        Me.optDesignNo.Text = "Design No."
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'grdStockD
        '
        Me.grdStockD.AllowUserToAddRows = False
        Me.grdStockD.AllowUserToDeleteRows = False
        Me.grdStockD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdStockD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dinno, Me.dindt, Me.Design_no, Me.lot, Me.col, Me.gr, Me.Roll_No_d, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.Loc, Me.kg, Me.mts, Me.yds, Me.rem_qc})
        Me.grdStockD.Location = New System.Drawing.Point(12, 152)
        Me.grdStockD.Name = "grdStockD"
        Me.grdStockD.Size = New System.Drawing.Size(1154, 577)
        Me.grdStockD.TabIndex = 291
        '
        'dinno
        '
        Me.dinno.DataPropertyName = "dinno"
        Me.dinno.HeaderText = "DIN No."
        Me.dinno.Name = "dinno"
        Me.dinno.ReadOnly = True
        Me.dinno.Width = 80
        '
        'dindt
        '
        Me.dindt.DataPropertyName = "dindt"
        Me.dindt.HeaderText = "DIN Date"
        Me.dindt.Name = "dindt"
        Me.dindt.ReadOnly = True
        Me.dindt.Width = 50
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        Me.Design_no.Width = 80
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot No."
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        Me.lot.Width = 80
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 50
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Grade"
        Me.gr.Name = "gr"
        Me.gr.ReadOnly = True
        Me.gr.Width = 40
        '
        'Roll_No_d
        '
        Me.Roll_No_d.DataPropertyName = "roll_no_d"
        Me.Roll_No_d.HeaderText = "Roll No (Dyed)"
        Me.Roll_No_d.Name = "Roll_No_d"
        Me.Roll_No_d.Width = 80
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.ReadOnly = True
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_subinventory_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtl_subinventory_id.HeaderText = "Sub Inventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.ReadOnly = True
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.mtl_locations_id.HeaderText = "Location"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.ReadOnly = True
        '
        'Loc
        '
        Me.Loc.DataPropertyName = "loc"
        Me.Loc.HeaderText = "Loc"
        Me.Loc.Name = "Loc"
        Me.Loc.ReadOnly = True
        Me.Loc.Visible = False
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "kg"
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.ReadOnly = True
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.ReadOnly = True
        Me.yds.Width = 50
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Q/c Rem"
        Me.rem_qc.Name = "rem_qc"
        Me.rem_qc.Width = 230
        '
        'frmStockDLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 741)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdStockD)
        Me.Name = "frmStockDLocation"
        Me.Text = "Stock D Location"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeach As TextBox
    Friend WithEvents optDFNo As RadioButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents optCol As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optLotNo As RadioButton
    Friend WithEvents optDesignNo As RadioButton
    Friend WithEvents grdStockD As DataGridView
    Friend WithEvents dinno As DataGridViewTextBoxColumn
    Friend WithEvents dindt As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents Roll_No_d As DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents Loc As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As DataGridViewTextBoxColumn
End Class
