<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPOHistoryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPOHistoryReport))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dgselectItem = New System.Windows.Forms.DataGridView()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkAllSuppliers = New System.Windows.Forms.CheckBox()
        Me.optLocal = New System.Windows.Forms.RadioButton()
        Me.optImport = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optUnclosed = New System.Windows.Forms.RadioButton()
        Me.optClosed = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optYarns = New System.Windows.Forms.RadioButton()
        Me.optOthers = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtSuppCd = New System.Windows.Forms.TextBox()
        Me.btnSelectSupplier = New System.Windows.Forms.Button()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboSaleOrderType1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtItmFind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optPrintExcept = New System.Windows.Forms.RadioButton()
        Me.optPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 54)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P/O Date range"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(192, 24)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From"
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(64, 24)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1091, 25)
        Me.ToolStrip1.TabIndex = 22
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
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
        Me.btnExit.Text = "E&xit"
        '
        'dgselectItem
        '
        Me.dgselectItem.AllowUserToAddRows = False
        Me.dgselectItem.AllowUserToDeleteRows = False
        Me.dgselectItem.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgselectItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgselectItem.ColumnHeadersHeight = 35
        Me.dgselectItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSelect, Me.colitcd, Me.colItemDesc, Me.supp_name})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgselectItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgselectItem.Location = New System.Drawing.Point(334, 99)
        Me.dgselectItem.Name = "dgselectItem"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgselectItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgselectItem.Size = New System.Drawing.Size(727, 419)
        Me.dgselectItem.TabIndex = 23
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
        Me.colitcd.ReadOnly = True
        '
        'colItemDesc
        '
        Me.colItemDesc.DataPropertyName = "itcd_desc2"
        Me.colItemDesc.HeaderText = "Yarn Description"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.ReadOnly = True
        Me.colItemDesc.Width = 300
        '
        'supp_name
        '
        Me.supp_name.DataPropertyName = "supp_name"
        Me.supp_name.HeaderText = "Supplier"
        Me.supp_name.Name = "supp_name"
        Me.supp_name.Width = 250
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(336, 29)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 24)
        Me.btnClear.TabIndex = 151
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(336, 59)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(72, 24)
        Me.btnSelectAll.TabIndex = 150
        Me.btnSelectAll.Text = "SelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Select"
        '
        'checkAllSuppliers
        '
        Me.checkAllSuppliers.AutoSize = True
        Me.checkAllSuppliers.Checked = True
        Me.checkAllSuppliers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAllSuppliers.Location = New System.Drawing.Point(49, 20)
        Me.checkAllSuppliers.Name = "checkAllSuppliers"
        Me.checkAllSuppliers.Size = New System.Drawing.Size(37, 17)
        Me.checkAllSuppliers.TabIndex = 157
        Me.checkAllSuppliers.Text = "All"
        Me.checkAllSuppliers.UseVisualStyleBackColor = True
        '
        'optLocal
        '
        Me.optLocal.AutoSize = True
        Me.optLocal.Checked = True
        Me.optLocal.Location = New System.Drawing.Point(15, 23)
        Me.optLocal.Name = "optLocal"
        Me.optLocal.Size = New System.Drawing.Size(51, 17)
        Me.optLocal.TabIndex = 161
        Me.optLocal.TabStop = True
        Me.optLocal.Text = "Local"
        Me.optLocal.UseVisualStyleBackColor = True
        '
        'optImport
        '
        Me.optImport.AutoSize = True
        Me.optImport.Location = New System.Drawing.Point(15, 44)
        Me.optImport.Name = "optImport"
        Me.optImport.Size = New System.Drawing.Size(54, 17)
        Me.optImport.TabIndex = 162
        Me.optImport.TabStop = True
        Me.optImport.Text = "Import"
        Me.optImport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optLocal)
        Me.GroupBox2.Controls.Add(Me.optImport)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 80)
        Me.GroupBox2.TabIndex = 163
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optAll)
        Me.GroupBox3.Controls.Add(Me.optUnclosed)
        Me.GroupBox3.Controls.Add(Me.optClosed)
        Me.GroupBox3.Location = New System.Drawing.Point(145, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 80)
        Me.GroupBox3.TabIndex = 164
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "P/O Status"
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Checked = True
        Me.optAll.Location = New System.Drawing.Point(6, 60)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(65, 17)
        Me.optAll.TabIndex = 163
        Me.optAll.TabStop = True
        Me.optAll.Text = "Show all"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optUnclosed
        '
        Me.optUnclosed.AutoSize = True
        Me.optUnclosed.Location = New System.Drawing.Point(6, 19)
        Me.optUnclosed.Name = "optUnclosed"
        Me.optUnclosed.Size = New System.Drawing.Size(131, 17)
        Me.optUnclosed.TabIndex = 161
        Me.optUnclosed.TabStop = True
        Me.optUnclosed.Text = "Show items not closed"
        Me.optUnclosed.UseVisualStyleBackColor = True
        '
        'optClosed
        '
        Me.optClosed.AutoSize = True
        Me.optClosed.Location = New System.Drawing.Point(6, 40)
        Me.optClosed.Name = "optClosed"
        Me.optClosed.Size = New System.Drawing.Size(113, 17)
        Me.optClosed.TabIndex = 162
        Me.optClosed.TabStop = True
        Me.optClosed.Text = "Show items closed"
        Me.optClosed.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(415, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "ถ้าต้องการพิมพ์ทุก Yarn Code ไม่ต้องเลือกอะไรเลย หรือ คลิกปุ่ม Clear All"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optYarns)
        Me.GroupBox4.Controls.Add(Me.optOthers)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(295, 56)
        Me.GroupBox4.TabIndex = 166
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Type of Product"
        '
        'optYarns
        '
        Me.optYarns.AutoSize = True
        Me.optYarns.Checked = True
        Me.optYarns.Location = New System.Drawing.Point(15, 23)
        Me.optYarns.Name = "optYarns"
        Me.optYarns.Size = New System.Drawing.Size(52, 17)
        Me.optYarns.TabIndex = 161
        Me.optYarns.TabStop = True
        Me.optYarns.Text = "Yarns"
        Me.optYarns.UseVisualStyleBackColor = True
        '
        'optOthers
        '
        Me.optOthers.AutoSize = True
        Me.optOthers.Location = New System.Drawing.Point(144, 24)
        Me.optOthers.Name = "optOthers"
        Me.optOthers.Size = New System.Drawing.Size(56, 17)
        Me.optOthers.TabIndex = 162
        Me.optOthers.TabStop = True
        Me.optOthers.Text = "Others"
        Me.optOthers.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSuppCd)
        Me.GroupBox5.Controls.Add(Me.btnSelectSupplier)
        Me.GroupBox5.Controls.Add(Me.txtSuppName)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.checkAllSuppliers)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(317, 74)
        Me.GroupBox5.TabIndex = 169
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Supplier"
        '
        'txtSuppCd
        '
        Me.txtSuppCd.Location = New System.Drawing.Point(6, 43)
        Me.txtSuppCd.Name = "txtSuppCd"
        Me.txtSuppCd.ReadOnly = True
        Me.txtSuppCd.Size = New System.Drawing.Size(61, 20)
        Me.txtSuppCd.TabIndex = 163
        '
        'btnSelectSupplier
        '
        Me.btnSelectSupplier.BackgroundImage = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSelectSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectSupplier.Location = New System.Drawing.Point(70, 41)
        Me.btnSelectSupplier.Name = "btnSelectSupplier"
        Me.btnSelectSupplier.Size = New System.Drawing.Size(22, 23)
        Me.btnSelectSupplier.TabIndex = 162
        Me.btnSelectSupplier.UseVisualStyleBackColor = True
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(98, 43)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.ReadOnly = True
        Me.txtSuppName.Size = New System.Drawing.Size(213, 20)
        Me.txtSuppName.TabIndex = 161
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.ComboSaleOrderType1)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 320)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(293, 65)
        Me.GroupBox6.TabIndex = 170
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Order Detail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Type"
        '
        'ComboSaleOrderType1
        '
        Me.ComboSaleOrderType1.FormattingEnabled = True
        Me.ComboSaleOrderType1.Location = New System.Drawing.Point(62, 19)
        Me.ComboSaleOrderType1.Name = "ComboSaleOrderType1"
        Me.ComboSaleOrderType1.Size = New System.Drawing.Size(211, 21)
        Me.ComboSaleOrderType1.TabIndex = 170
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtItmFind)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Location = New System.Drawing.Point(420, 49)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(339, 44)
        Me.GroupBox7.TabIndex = 171
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ค้นหา ข้อมูลใน Data Grid"
        '
        'txtItmFind
        '
        Me.txtItmFind.Location = New System.Drawing.Point(146, 18)
        Me.txtItmFind.Name = "txtItmFind"
        Me.txtItmFind.Size = New System.Drawing.Size(133, 20)
        Me.txtItmFind.TabIndex = 359
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Wording To Find"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optPrintExcept)
        Me.GroupBox8.Controls.Add(Me.optPrintOnly)
        Me.GroupBox8.Controls.Add(Me.optPrintAll)
        Me.GroupBox8.Location = New System.Drawing.Point(11, 392)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(153, 102)
        Me.GroupBox8.TabIndex = 172
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Sell Back To Vendor"
        '
        'optPrintExcept
        '
        Me.optPrintExcept.AutoSize = True
        Me.optPrintExcept.Location = New System.Drawing.Point(27, 67)
        Me.optPrintExcept.Name = "optPrintExcept"
        Me.optPrintExcept.Size = New System.Drawing.Size(88, 17)
        Me.optPrintExcept.TabIndex = 171
        Me.optPrintExcept.Text = "Show Except"
        Me.optPrintExcept.UseVisualStyleBackColor = True
        '
        'optPrintOnly
        '
        Me.optPrintOnly.AutoSize = True
        Me.optPrintOnly.Location = New System.Drawing.Point(27, 43)
        Me.optPrintOnly.Name = "optPrintOnly"
        Me.optPrintOnly.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnly.TabIndex = 170
        Me.optPrintOnly.Text = "Show Only"
        Me.optPrintOnly.UseVisualStyleBackColor = True
        '
        'optPrintAll
        '
        Me.optPrintAll.AutoSize = True
        Me.optPrintAll.Checked = True
        Me.optPrintAll.Location = New System.Drawing.Point(27, 19)
        Me.optPrintAll.Name = "optPrintAll"
        Me.optPrintAll.Size = New System.Drawing.Size(66, 17)
        Me.optPrintAll.TabIndex = 169
        Me.optPrintAll.TabStop = True
        Me.optPrintAll.Text = "Show All"
        Me.optPrintAll.UseVisualStyleBackColor = True
        '
        'formPOHistoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 530)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.dgselectItem)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPOHistoryReport"
        Me.Text = "P/O history report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgselectItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgselectItem As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents checkAllSuppliers As System.Windows.Forms.CheckBox
    Friend WithEvents optLocal As System.Windows.Forms.RadioButton
    Friend WithEvents optImport As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optUnclosed As System.Windows.Forms.RadioButton
    Friend WithEvents optClosed As System.Windows.Forms.RadioButton
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optYarns As System.Windows.Forms.RadioButton
    Friend WithEvents optOthers As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboSaleOrderType1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtItmFind As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents colSelect As DataGridViewCheckBoxColumn
    Friend WithEvents colitcd As DataGridViewTextBoxColumn
    Friend WithEvents colItemDesc As DataGridViewTextBoxColumn
    Friend WithEvents supp_name As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents optPrintAll As RadioButton
    Friend WithEvents optPrintExcept As RadioButton
    Friend WithEvents optPrintOnly As RadioButton
    Friend WithEvents btnSelectSupplier As Button
    Friend WithEvents txtSuppName As TextBox
    Friend WithEvents txtSuppCd As TextBox
End Class
