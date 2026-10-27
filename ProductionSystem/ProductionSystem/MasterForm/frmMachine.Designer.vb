<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachine))
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dgvMachines = New System.Windows.Forms.DataGridView()
        Me.active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mctyp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.needle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.setout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcwthcm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcsize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcserialno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gauge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feeder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilowatt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cylinder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sinker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.counter_per_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_per_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts_per_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_per_day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rpm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMtlWarehouseId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvMachines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(307, 22)
        Me.ToolStripLabel2.Text = "*** หากต้องการลบ Machine Master เพียงติ๊ก Active ออก"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(998, 25)
        Me.ToolStrip1.TabIndex = 38
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
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'dgvMachines
        '
        Me.dgvMachines.AllowUserToDeleteRows = False
        Me.dgvMachines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMachines.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMachines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.active, Me.mcno, Me.mcdesc, Me.mctyp, Me.bar, Me.fine, Me.needle, Me.setout, Me.mcwthcm, Me.mcsize, Me.mcmodel, Me.mcserialno, Me.gauge, Me.diameter, Me.feeder, Me.kilowatt, Me.hp, Me.dial, Me.cylinder, Me.sinker, Me.counter_per_roll, Me.kg_per_roll, Me.mts_per_roll, Me.kg_per_day, Me.rpm, Me.colMtlWarehouseId, Me.colWarehouseCode, Me.loc, Me.boi})
        Me.dgvMachines.Location = New System.Drawing.Point(8, 32)
        Me.dgvMachines.Name = "dgvMachines"
        Me.dgvMachines.Size = New System.Drawing.Size(984, 464)
        Me.dgvMachines.TabIndex = 44
        '
        'active
        '
        Me.active.DataPropertyName = "active"
        Me.active.FalseValue = "False"
        Me.active.HeaderText = "Active"
        Me.active.Name = "active"
        Me.active.TrueValue = "True"
        Me.active.Width = 50
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        Me.mcno.HeaderText = "Machine No."
        Me.mcno.Name = "mcno"
        Me.mcno.Width = 80
        '
        'mcdesc
        '
        Me.mcdesc.DataPropertyName = "mcdesc"
        Me.mcdesc.HeaderText = "Description"
        Me.mcdesc.Name = "mcdesc"
        Me.mcdesc.Width = 150
        '
        'mctyp
        '
        Me.mctyp.DataPropertyName = "mctyp"
        Me.mctyp.HeaderText = "Type"
        Me.mctyp.Name = "mctyp"
        Me.mctyp.Width = 50
        '
        'bar
        '
        Me.bar.DataPropertyName = "bar"
        Me.bar.HeaderText = "Bar"
        Me.bar.Name = "bar"
        Me.bar.Width = 50
        '
        'fine
        '
        Me.fine.DataPropertyName = "fine"
        Me.fine.HeaderText = "Fine"
        Me.fine.Name = "fine"
        Me.fine.Width = 50
        '
        'needle
        '
        Me.needle.DataPropertyName = "needle"
        Me.needle.HeaderText = "Needle"
        Me.needle.Name = "needle"
        Me.needle.Width = 50
        '
        'setout
        '
        Me.setout.DataPropertyName = "setout"
        Me.setout.HeaderText = "Set Out"
        Me.setout.Name = "setout"
        Me.setout.Width = 50
        '
        'mcwthcm
        '
        Me.mcwthcm.DataPropertyName = "mcwthcm"
        Me.mcwthcm.HeaderText = "Width (cm)"
        Me.mcwthcm.Name = "mcwthcm"
        Me.mcwthcm.Width = 50
        '
        'mcsize
        '
        Me.mcsize.DataPropertyName = "mcsize"
        Me.mcsize.HeaderText = "Size"
        Me.mcsize.Name = "mcsize"
        Me.mcsize.Width = 50
        '
        'mcmodel
        '
        Me.mcmodel.DataPropertyName = "mcmodel"
        Me.mcmodel.HeaderText = "Model"
        Me.mcmodel.Name = "mcmodel"
        Me.mcmodel.Width = 80
        '
        'mcserialno
        '
        Me.mcserialno.DataPropertyName = "mcserialno"
        Me.mcserialno.HeaderText = "Serial No."
        Me.mcserialno.Name = "mcserialno"
        Me.mcserialno.Width = 80
        '
        'gauge
        '
        Me.gauge.DataPropertyName = "gauge"
        Me.gauge.HeaderText = "Gauge"
        Me.gauge.Name = "gauge"
        Me.gauge.Width = 50
        '
        'diameter
        '
        Me.diameter.DataPropertyName = "diameter"
        Me.diameter.HeaderText = "Diameter"
        Me.diameter.Name = "diameter"
        Me.diameter.Width = 50
        '
        'feeder
        '
        Me.feeder.DataPropertyName = "feeder"
        Me.feeder.HeaderText = "Feeder"
        Me.feeder.Name = "feeder"
        Me.feeder.Width = 50
        '
        'kilowatt
        '
        Me.kilowatt.DataPropertyName = "kilowatt"
        Me.kilowatt.HeaderText = "KiloWatt"
        Me.kilowatt.Name = "kilowatt"
        Me.kilowatt.Width = 50
        '
        'hp
        '
        Me.hp.DataPropertyName = "hp"
        Me.hp.HeaderText = "HP"
        Me.hp.Name = "hp"
        Me.hp.Width = 50
        '
        'dial
        '
        Me.dial.DataPropertyName = "dial"
        Me.dial.HeaderText = "Dial"
        Me.dial.Name = "dial"
        Me.dial.Width = 50
        '
        'cylinder
        '
        Me.cylinder.DataPropertyName = "cylinder"
        Me.cylinder.HeaderText = "Cylinder"
        Me.cylinder.Name = "cylinder"
        Me.cylinder.Width = 50
        '
        'sinker
        '
        Me.sinker.DataPropertyName = "sinker"
        Me.sinker.HeaderText = "Sinker"
        Me.sinker.Name = "sinker"
        Me.sinker.Width = 50
        '
        'counter_per_roll
        '
        Me.counter_per_roll.DataPropertyName = "counter_per_roll"
        Me.counter_per_roll.HeaderText = "Counter Per Roll"
        Me.counter_per_roll.Name = "counter_per_roll"
        Me.counter_per_roll.Width = 50
        '
        'kg_per_roll
        '
        Me.kg_per_roll.DataPropertyName = "kg_per_roll"
        Me.kg_per_roll.HeaderText = "Kgs. Per Roll"
        Me.kg_per_roll.Name = "kg_per_roll"
        Me.kg_per_roll.Width = 50
        '
        'mts_per_roll
        '
        Me.mts_per_roll.DataPropertyName = "mts_per_day"
        Me.mts_per_roll.HeaderText = "Mts. Per Roll"
        Me.mts_per_roll.Name = "mts_per_roll"
        Me.mts_per_roll.Width = 50
        '
        'kg_per_day
        '
        Me.kg_per_day.DataPropertyName = "kg_per_day"
        Me.kg_per_day.HeaderText = "Kgs. Per Day"
        Me.kg_per_day.Name = "kg_per_day"
        Me.kg_per_day.Width = 50
        '
        'rpm
        '
        Me.rpm.DataPropertyName = "rpm"
        Me.rpm.HeaderText = "RPM"
        Me.rpm.Name = "rpm"
        Me.rpm.Width = 50
        '
        'colMtlWarehouseId
        '
        Me.colMtlWarehouseId.DataPropertyName = "mtl_warehouse_id"
        Me.colMtlWarehouseId.HeaderText = "W/H ID"
        Me.colMtlWarehouseId.Name = "colMtlWarehouseId"
        Me.colMtlWarehouseId.ReadOnly = True
        Me.colMtlWarehouseId.Visible = False
        '
        'colWarehouseCode
        '
        Me.colWarehouseCode.DataPropertyName = "warehouse_code"
        Me.colWarehouseCode.HeaderText = "W/H"
        Me.colWarehouseCode.Name = "colWarehouseCode"
        Me.colWarehouseCode.ReadOnly = True
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        Me.loc.Width = 80
        '
        'boi
        '
        Me.boi.DataPropertyName = "boi"
        Me.boi.HeaderText = "BOI"
        Me.boi.Name = "boi"
        Me.boi.Width = 50
        '
        'frmMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 505)
        Me.Controls.Add(Me.dgvMachines)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMachine"
        Me.Text = "Machine Master"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvMachines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents dgvMachines As System.Windows.Forms.DataGridView
    Friend WithEvents active As DataGridViewCheckBoxColumn
    Friend WithEvents mcno As DataGridViewTextBoxColumn
    Friend WithEvents mcdesc As DataGridViewTextBoxColumn
    Friend WithEvents mctyp As DataGridViewTextBoxColumn
    Friend WithEvents bar As DataGridViewTextBoxColumn
    Friend WithEvents fine As DataGridViewTextBoxColumn
    Friend WithEvents needle As DataGridViewTextBoxColumn
    Friend WithEvents setout As DataGridViewTextBoxColumn
    Friend WithEvents mcwthcm As DataGridViewTextBoxColumn
    Friend WithEvents mcsize As DataGridViewTextBoxColumn
    Friend WithEvents mcmodel As DataGridViewTextBoxColumn
    Friend WithEvents mcserialno As DataGridViewTextBoxColumn
    Friend WithEvents gauge As DataGridViewTextBoxColumn
    Friend WithEvents diameter As DataGridViewTextBoxColumn
    Friend WithEvents feeder As DataGridViewTextBoxColumn
    Friend WithEvents kilowatt As DataGridViewTextBoxColumn
    Friend WithEvents hp As DataGridViewTextBoxColumn
    Friend WithEvents dial As DataGridViewTextBoxColumn
    Friend WithEvents cylinder As DataGridViewTextBoxColumn
    Friend WithEvents sinker As DataGridViewTextBoxColumn
    Friend WithEvents counter_per_roll As DataGridViewTextBoxColumn
    Friend WithEvents kg_per_roll As DataGridViewTextBoxColumn
    Friend WithEvents mts_per_roll As DataGridViewTextBoxColumn
    Friend WithEvents kg_per_day As DataGridViewTextBoxColumn
    Friend WithEvents rpm As DataGridViewTextBoxColumn
    Friend WithEvents colMtlWarehouseId As DataGridViewTextBoxColumn
    Friend WithEvents colWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents boi As DataGridViewTextBoxColumn
End Class
