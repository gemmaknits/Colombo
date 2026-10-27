<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPriceList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minimum_ppu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maximum_ppu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount1_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount1_percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount2_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount2_percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount3_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount3_percent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.strategy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCopy, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(921, 25)
        Me.ToolStrip1.TabIndex = 5
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "Copy from last month"
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
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.period, Me.design_no, Me.minimum_order, Me.cpu, Me.minimum_ppu, Me.maximum_ppu, Me.discount1_kg, Me.discount1_percent, Me.discount2_kg, Me.discount2_percent, Me.discount3_kg, Me.discount3_percent, Me.strategy})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle12
        Me.grdData.Location = New System.Drawing.Point(8, 64)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeadersWidth = 30
        Me.grdData.Size = New System.Drawing.Size(904, 432)
        Me.grdData.TabIndex = 6
        '
        'dtpPeriod
        '
        Me.dtpPeriod.CustomFormat = "MMMM yyyy"
        Me.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriod.Location = New System.Drawing.Point(56, 32)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(136, 20)
        Me.dtpPeriod.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Month"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(200, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(288, 32)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(624, 24)
        Me.ProgressBar1.TabIndex = 10
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'period
        '
        Me.period.DataPropertyName = "period"
        Me.period.HeaderText = "Period"
        Me.period.Name = "period"
        Me.period.ReadOnly = True
        Me.period.Visible = False
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 105
        '
        'minimum_order
        '
        Me.minimum_order.DataPropertyName = "minimum_order"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        Me.minimum_order.DefaultCellStyle = DataGridViewCellStyle2
        Me.minimum_order.HeaderText = "Minimum Order"
        Me.minimum_order.Name = "minimum_order"
        Me.minimum_order.Width = 75
        '
        'cpu
        '
        Me.cpu.DataPropertyName = "cpu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.cpu.DefaultCellStyle = DataGridViewCellStyle3
        Me.cpu.HeaderText = "Cost per Kg."
        Me.cpu.Name = "cpu"
        Me.cpu.Width = 75
        '
        'minimum_ppu
        '
        Me.minimum_ppu.DataPropertyName = "minimum_ppu"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.minimum_ppu.DefaultCellStyle = DataGridViewCellStyle4
        Me.minimum_ppu.HeaderText = "Min Price/Kg."
        Me.minimum_ppu.Name = "minimum_ppu"
        Me.minimum_ppu.Width = 75
        '
        'maximum_ppu
        '
        Me.maximum_ppu.DataPropertyName = "maximum_ppu"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.maximum_ppu.DefaultCellStyle = DataGridViewCellStyle5
        Me.maximum_ppu.HeaderText = "Max Price/Kg."
        Me.maximum_ppu.Name = "maximum_ppu"
        Me.maximum_ppu.Width = 75
        '
        'discount1_kg
        '
        Me.discount1_kg.DataPropertyName = "discount1_kg"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.discount1_kg.DefaultCellStyle = DataGridViewCellStyle6
        Me.discount1_kg.HeaderText = "Discount #1 (Kgs.)"
        Me.discount1_kg.Name = "discount1_kg"
        Me.discount1_kg.Width = 75
        '
        'discount1_percent
        '
        Me.discount1_percent.DataPropertyName = "discount1_percent"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.discount1_percent.DefaultCellStyle = DataGridViewCellStyle7
        Me.discount1_percent.HeaderText = "Discount #1 (%)"
        Me.discount1_percent.Name = "discount1_percent"
        Me.discount1_percent.Width = 75
        '
        'discount2_kg
        '
        Me.discount2_kg.DataPropertyName = "discount2_kg"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.discount2_kg.DefaultCellStyle = DataGridViewCellStyle8
        Me.discount2_kg.HeaderText = "Discount #2 (Kgs.)"
        Me.discount2_kg.Name = "discount2_kg"
        Me.discount2_kg.Width = 75
        '
        'discount2_percent
        '
        Me.discount2_percent.DataPropertyName = "discount2_percent"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.discount2_percent.DefaultCellStyle = DataGridViewCellStyle9
        Me.discount2_percent.HeaderText = "Discount #2 (%)"
        Me.discount2_percent.Name = "discount2_percent"
        Me.discount2_percent.Width = 75
        '
        'discount3_kg
        '
        Me.discount3_kg.DataPropertyName = "discount3_kg"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.discount3_kg.DefaultCellStyle = DataGridViewCellStyle10
        Me.discount3_kg.HeaderText = "Discount #3 (Kgs.)"
        Me.discount3_kg.Name = "discount3_kg"
        Me.discount3_kg.Width = 75
        '
        'discount3_percent
        '
        Me.discount3_percent.DataPropertyName = "discount3_percent"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.discount3_percent.DefaultCellStyle = DataGridViewCellStyle11
        Me.discount3_percent.HeaderText = "Discount #3 (%)"
        Me.discount3_percent.Name = "discount3_percent"
        Me.discount3_percent.Width = 75
        '
        'strategy
        '
        Me.strategy.DataPropertyName = "strategy"
        Me.strategy.HeaderText = "Strategy"
        Me.strategy.Name = "strategy"
        Me.strategy.Width = 200
        '
        'frmPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 505)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpPeriod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Price List"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents period As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum_order As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents minimum_ppu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents maximum_ppu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount1_kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount1_percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount2_kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount2_percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount3_kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount3_percent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents strategy As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
