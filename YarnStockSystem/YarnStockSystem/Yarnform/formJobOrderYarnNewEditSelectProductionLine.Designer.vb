<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJobOrderYarnNewEditSelectProductionLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formJobOrderYarnNewEditSelectProductionLine))
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.colMfgProductionOrderLinesId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouting.Location = New System.Drawing.Point(37, 12)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(159, 21)
        Me.lblRouting.TabIndex = 65
        Me.lblRouting.Text = "กรอกคีย์เวิร์ดในการค้นหา"
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.ColumnHeadersHeight = 40
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMfgProductionOrderLinesId, Me.colGb, Me.colItemId, Me.colItcd, Me.colitdesc, Me.plan_qty, Me.colUomid, Me.colUom})
        Me.grddata.Location = New System.Drawing.Point(18, 94)
        Me.grddata.Name = "grddata"
        Me.grddata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grddata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grddata.Size = New System.Drawing.Size(753, 190)
        Me.grddata.TabIndex = 67
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(658, 290)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 41)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(577, 290)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 41)
        Me.btnOk.TabIndex = 68
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(282, 47)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 32)
        Me.btnRefresh.TabIndex = 66
        Me.btnRefresh.Text = "&ค้นหาทันที"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(222, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(243, 29)
        Me.txtFilter.TabIndex = 64
        Me.txtFilter.Tag = "กรอกข้อมูลในการค้นหา"
        '
        'colMfgProductionOrderLinesId
        '
        Me.colMfgProductionOrderLinesId.DataPropertyName = "mfg_production_order_lines_id"
        Me.colMfgProductionOrderLinesId.HeaderText = "Production Line ID"
        Me.colMfgProductionOrderLinesId.Name = "colMfgProductionOrderLinesId"
        '
        'colGb
        '
        Me.colGb.DataPropertyName = "gb"
        Me.colGb.HeaderText = "GB #"
        Me.colGb.Name = "colGb"
        Me.colGb.Width = 50
        '
        'colItemId
        '
        Me.colItemId.DataPropertyName = "item_id"
        Me.colItemId.HeaderText = "Items ID"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = False
        '
        'colItcd
        '
        Me.colItcd.DataPropertyName = "itcd"
        Me.colItcd.HeaderText = "Item Code"
        Me.colItcd.Name = "colItcd"
        '
        'colitdesc
        '
        Me.colitdesc.DataPropertyName = "itdesc"
        Me.colitdesc.HeaderText = "Desceptions"
        Me.colitdesc.Name = "colitdesc"
        Me.colitdesc.Width = 300
        '
        'plan_qty
        '
        Me.plan_qty.DataPropertyName = "plan_qty"
        Me.plan_qty.HeaderText = "Plan Qty"
        Me.plan_qty.Name = "plan_qty"
        Me.plan_qty.ReadOnly = True
        Me.plan_qty.Width = 50
        '
        'colUomid
        '
        Me.colUomid.DataPropertyName = "uom_id"
        Me.colUomid.HeaderText = "UOM ID"
        Me.colUomid.Name = "colUomid"
        Me.colUomid.Visible = False
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "uom"
        Me.colUom.HeaderText = "UOM"
        Me.colUom.Name = "colUom"
        '
        'formJobOrderYarnNewEditSelectProductionLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 342)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "formJobOrderYarnNewEditSelectProductionLine"
        Me.Text = "Select Production Line"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRouting As Label
    Friend WithEvents grddata As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents colMfgProductionOrderLinesId As DataGridViewTextBoxColumn
    Friend WithEvents colGb As DataGridViewTextBoxColumn
    Friend WithEvents colItemId As DataGridViewTextBoxColumn
    Friend WithEvents colItcd As DataGridViewTextBoxColumn
    Friend WithEvents colitdesc As DataGridViewTextBoxColumn
    Friend WithEvents plan_qty As DataGridViewTextBoxColumn
    Friend WithEvents colUomid As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewTextBoxColumn
End Class
