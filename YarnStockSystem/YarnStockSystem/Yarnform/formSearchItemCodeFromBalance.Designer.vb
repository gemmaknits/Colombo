<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchItemCodeFromBalance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dgYarn = New System.Windows.Forms.DataGridView()
        Me.colMfgProductionOrderLinesId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuppname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSumBalKgNt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSumBalSpools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtItcd = New System.Windows.Forms.TextBox()
        Me.lbItcd = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(928, 427)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(84, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Exit"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(837, 427)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dgYarn
        '
        Me.dgYarn.AllowUserToAddRows = False
        Me.dgYarn.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgYarn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgYarn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgYarn.ColumnHeadersHeight = 35
        Me.dgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMfgProductionOrderLinesId, Me.gb, Me.colItemcd, Me.colDesc, Me.colSuppname, Me.colLotno_our, Me.wono, Me.colSumBalKgNt, Me.colSumBalSpools})
        Me.dgYarn.Location = New System.Drawing.Point(7, 19)
        Me.dgYarn.Name = "dgYarn"
        Me.dgYarn.ReadOnly = True
        Me.dgYarn.Size = New System.Drawing.Size(989, 249)
        Me.dgYarn.TabIndex = 4
        '
        'colMfgProductionOrderLinesId
        '
        Me.colMfgProductionOrderLinesId.DataPropertyName = "mfg_production_order_lines_id"
        Me.colMfgProductionOrderLinesId.HeaderText = "Production Order Lines ID"
        Me.colMfgProductionOrderLinesId.Name = "colMfgProductionOrderLinesId"
        Me.colMfgProductionOrderLinesId.ReadOnly = True
        Me.colMfgProductionOrderLinesId.Width = 90
        '
        'gb
        '
        Me.gb.DataPropertyName = "gb"
        Me.gb.HeaderText = "GB"
        Me.gb.Name = "gb"
        Me.gb.ReadOnly = True
        Me.gb.Width = 60
        '
        'colItemcd
        '
        Me.colItemcd.DataPropertyName = "itcd"
        Me.colItemcd.HeaderText = "Item code"
        Me.colItemcd.Name = "colItemcd"
        Me.colItemcd.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "itdesc2"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 250
        '
        'colSuppname
        '
        Me.colSuppname.DataPropertyName = "supname"
        Me.colSuppname.HeaderText = "Supp. name"
        Me.colSuppname.Name = "colSuppname"
        Me.colSuppname.ReadOnly = True
        '
        'colLotno_our
        '
        Me.colLotno_our.DataPropertyName = "lotno_our"
        Me.colLotno_our.HeaderText = "Lot-batch"
        Me.colLotno_our.Name = "colLotno_our"
        Me.colLotno_our.ReadOnly = True
        Me.colLotno_our.Width = 200
        '
        'wono
        '
        Me.wono.DataPropertyName = "wono"
        Me.wono.HeaderText = "W/O No."
        Me.wono.Name = "wono"
        Me.wono.ReadOnly = True
        Me.wono.Width = 200
        '
        'colSumBalKgNt
        '
        Me.colSumBalKgNt.DataPropertyName = "sum_bal_kg_nt"
        Me.colSumBalKgNt.HeaderText = "Balance Kg"
        Me.colSumBalKgNt.Name = "colSumBalKgNt"
        Me.colSumBalKgNt.ReadOnly = True
        '
        'colSumBalSpools
        '
        Me.colSumBalSpools.DataPropertyName = "sum_bal_spools"
        Me.colSumBalSpools.HeaderText = "Balance Spools"
        Me.colSumBalSpools.Name = "colSumBalSpools"
        Me.colSumBalSpools.ReadOnly = True
        '
        'txtItcd
        '
        Me.txtItcd.Location = New System.Drawing.Point(119, 19)
        Me.txtItcd.Name = "txtItcd"
        Me.txtItcd.Size = New System.Drawing.Size(138, 22)
        Me.txtItcd.TabIndex = 7
        '
        'lbItcd
        '
        Me.lbItcd.AutoSize = True
        Me.lbItcd.Location = New System.Drawing.Point(24, 22)
        Me.lbItcd.Name = "lbItcd"
        Me.lbItcd.Size = New System.Drawing.Size(59, 13)
        Me.lbItcd.TabIndex = 8
        Me.lbItcd.Text = "Item Code"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtWordFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 49)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter (กรองข้อมูล)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Enter Text"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(119, 19)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(187, 22)
        Me.txtWordFilter.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKoNo)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtItcd)
        Me.GroupBox1.Controls.Add(Me.lbItcd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 80)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(277, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 23)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Show"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgYarn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1002, 274)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Prod No."
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(119, 52)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.Size = New System.Drawing.Size(138, 22)
        Me.txtKoNo.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(274, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "***Enter Item Code or Prod No."
        '
        'formSearchItemCodeFromBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formSearchItemCodeFromBalance"
        Me.Text = "Search Yarn Balance"
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dgYarn As System.Windows.Forms.DataGridView
    Friend WithEvents txtItcd As System.Windows.Forms.TextBox
    Friend WithEvents lbItcd As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents colMfgProductionOrderLinesId As DataGridViewTextBoxColumn
    Friend WithEvents gb As DataGridViewTextBoxColumn
    Friend WithEvents colItemcd As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colSuppname As DataGridViewTextBoxColumn
    Friend WithEvents colLotno_our As DataGridViewTextBoxColumn
    Friend WithEvents wono As DataGridViewTextBoxColumn
    Friend WithEvents colSumBalKgNt As DataGridViewTextBoxColumn
    Friend WithEvents colSumBalSpools As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKoNo As TextBox
End Class
