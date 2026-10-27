<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSONotClosed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSONotClosed))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.optShowClosedSO = New System.Windows.Forms.RadioButton()
        Me.optShowNonClosedSO = New System.Windows.Forms.RadioButton()
        Me.comboSalesPerson = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.optPrintExcept = New System.Windows.Forms.RadioButton()
        Me.optPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintAll = New System.Windows.Forms.RadioButton()
        Me.rbReportForProduction = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbShowAllStatus = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGetCustomer = New System.Windows.Forms.Button()
        Me.txtCustCode = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbCustShipdt = New System.Windows.Forms.RadioButton()
        Me.rbSODate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvSaleRelateGammaJob = New System.Windows.Forms.DataGridView()
        Me.rbReportForSaleRelateGammaJob = New System.Windows.Forms.RadioButton()
        Me.rbForPresent = New System.Windows.Forms.RadioButton()
        Me.rbReportForSales = New System.Windows.Forms.RadioButton()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvSaleRelateGammaJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.tsbtnExportToExcel, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(450, 25)
        Me.ToolStrip1.TabIndex = 7
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'tsbtnExportToExcel
        '
        Me.tsbtnExportToExcel.Image = Global.SalesOrderSystem.My.Resources.Resources.ExcelWorksheetView_16x1
        Me.tsbtnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExportToExcel.Name = "tsbtnExportToExcel"
        Me.tsbtnExportToExcel.Size = New System.Drawing.Size(60, 22)
        Me.tsbtnExportToExcel.Text = "Export"
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
        Me.btnExit.Text = "E&xit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(271, 39)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShowCheckBox = True
        Me.dtpDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpDateTo.TabIndex = 26
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(271, 13)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.ShowCheckBox = True
        Me.dtpDateFr.Size = New System.Drawing.Size(104, 20)
        Me.dtpDateFr.TabIndex = 25
        '
        'optShowClosedSO
        '
        Me.optShowClosedSO.AutoSize = True
        Me.optShowClosedSO.Location = New System.Drawing.Point(272, 19)
        Me.optShowClosedSO.Name = "optShowClosedSO"
        Me.optShowClosedSO.Size = New System.Drawing.Size(134, 17)
        Me.optShowClosedSO.TabIndex = 29
        Me.optShowClosedSO.Text = "Show Only Closed S/O"
        Me.optShowClosedSO.UseVisualStyleBackColor = True
        '
        'optShowNonClosedSO
        '
        Me.optShowNonClosedSO.AutoSize = True
        Me.optShowNonClosedSO.Checked = True
        Me.optShowNonClosedSO.Location = New System.Drawing.Point(99, 19)
        Me.optShowNonClosedSO.Name = "optShowNonClosedSO"
        Me.optShowNonClosedSO.Size = New System.Drawing.Size(157, 17)
        Me.optShowNonClosedSO.TabIndex = 30
        Me.optShowNonClosedSO.TabStop = True
        Me.optShowNonClosedSO.Text = "Show Only Non Closed S/O"
        Me.optShowNonClosedSO.UseVisualStyleBackColor = True
        '
        'comboSalesPerson
        '
        Me.comboSalesPerson.FormattingEnabled = True
        Me.comboSalesPerson.Location = New System.Drawing.Point(110, 19)
        Me.comboSalesPerson.Name = "comboSalesPerson"
        Me.comboSalesPerson.Size = New System.Drawing.Size(133, 21)
        Me.comboSalesPerson.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.optPrintExcept)
        Me.GroupBox1.Controls.Add(Me.optPrintOnly)
        Me.GroupBox1.Controls.Add(Me.comboSalesPerson)
        Me.GroupBox1.Controls.Add(Me.optPrintAll)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 84)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sale Person"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 358
        Me.Label6.Text = "Sales Name"
        '
        'optPrintExcept
        '
        Me.optPrintExcept.AutoSize = True
        Me.optPrintExcept.Location = New System.Drawing.Point(319, 58)
        Me.optPrintExcept.Name = "optPrintExcept"
        Me.optPrintExcept.Size = New System.Drawing.Size(82, 17)
        Me.optPrintExcept.TabIndex = 357
        Me.optPrintExcept.Text = "Print Except"
        Me.optPrintExcept.UseVisualStyleBackColor = True
        '
        'optPrintOnly
        '
        Me.optPrintOnly.AutoSize = True
        Me.optPrintOnly.Location = New System.Drawing.Point(319, 37)
        Me.optPrintOnly.Name = "optPrintOnly"
        Me.optPrintOnly.Size = New System.Drawing.Size(70, 17)
        Me.optPrintOnly.TabIndex = 356
        Me.optPrintOnly.Text = "Print Only"
        Me.optPrintOnly.UseVisualStyleBackColor = True
        '
        'optPrintAll
        '
        Me.optPrintAll.AutoSize = True
        Me.optPrintAll.Checked = True
        Me.optPrintAll.Location = New System.Drawing.Point(319, 15)
        Me.optPrintAll.Name = "optPrintAll"
        Me.optPrintAll.Size = New System.Drawing.Size(60, 17)
        Me.optPrintAll.TabIndex = 355
        Me.optPrintAll.TabStop = True
        Me.optPrintAll.Text = "Print All"
        Me.optPrintAll.UseVisualStyleBackColor = True
        '
        'rbReportForProduction
        '
        Me.rbReportForProduction.AutoSize = True
        Me.rbReportForProduction.Location = New System.Drawing.Point(138, 19)
        Me.rbReportForProduction.Name = "rbReportForProduction"
        Me.rbReportForProduction.Size = New System.Drawing.Size(118, 17)
        Me.rbReportForProduction.TabIndex = 359
        Me.rbReportForProduction.Text = "For Production Plan"
        Me.rbReportForProduction.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbShowAllStatus)
        Me.GroupBox3.Controls.Add(Me.optShowClosedSO)
        Me.GroupBox3.Controls.Add(Me.optShowNonClosedSO)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 49)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SO Status"
        '
        'rbShowAllStatus
        '
        Me.rbShowAllStatus.AutoSize = True
        Me.rbShowAllStatus.Location = New System.Drawing.Point(20, 19)
        Me.rbShowAllStatus.Name = "rbShowAllStatus"
        Me.rbShowAllStatus.Size = New System.Drawing.Size(69, 17)
        Me.rbShowAllStatus.TabIndex = 31
        Me.rbShowAllStatus.Text = "All Status"
        Me.rbShowAllStatus.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGetCustomer)
        Me.GroupBox4.Controls.Add(Me.txtCustCode)
        Me.GroupBox4.Controls.Add(Me.txtCustomerName)
        Me.GroupBox4.Controls.Add(Me.txtDesignNo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 100)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(423, 164)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Condition"
        '
        'btnGetCustomer
        '
        Me.btnGetCustomer.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnGetCustomer.Location = New System.Drawing.Point(192, 104)
        Me.btnGetCustomer.Name = "btnGetCustomer"
        Me.btnGetCustomer.Size = New System.Drawing.Size(24, 22)
        Me.btnGetCustomer.TabIndex = 35
        Me.btnGetCustomer.UseVisualStyleBackColor = True
        '
        'txtCustCode
        '
        Me.txtCustCode.Location = New System.Drawing.Point(110, 108)
        Me.txtCustCode.Name = "txtCustCode"
        Me.txtCustCode.Size = New System.Drawing.Size(80, 20)
        Me.txtCustCode.TabIndex = 34
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(110, 132)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(282, 20)
        Me.txtCustomerName.TabIndex = 33
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(110, 84)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(105, 20)
        Me.txtDesignNo.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Design No."
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbCustShipdt)
        Me.GroupBox6.Controls.Add(Me.rbSODate)
        Me.GroupBox6.Controls.Add(Me.dtpDateTo)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.dtpDateFr)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(392, 67)
        Me.GroupBox6.TabIndex = 36
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Date"
        '
        'rbCustShipdt
        '
        Me.rbCustShipdt.AutoSize = True
        Me.rbCustShipdt.Location = New System.Drawing.Point(27, 43)
        Me.rbCustShipdt.Name = "rbCustShipdt"
        Me.rbCustShipdt.Size = New System.Drawing.Size(138, 17)
        Me.rbCustShipdt.TabIndex = 1
        Me.rbCustShipdt.Text = "Customer Request Date"
        Me.rbCustShipdt.UseVisualStyleBackColor = True
        '
        'rbSODate
        '
        Me.rbSODate.AutoSize = True
        Me.rbSODate.Checked = True
        Me.rbSODate.Location = New System.Drawing.Point(27, 18)
        Me.rbSODate.Name = "rbSODate"
        Me.rbSODate.Size = New System.Drawing.Size(66, 17)
        Me.rbSODate.TabIndex = 0
        Me.rbSODate.TabStop = True
        Me.rbSODate.Text = "SO Date"
        Me.rbSODate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "From"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvSaleRelateGammaJob)
        Me.GroupBox5.Controls.Add(Me.rbReportForSaleRelateGammaJob)
        Me.GroupBox5.Controls.Add(Me.rbForPresent)
        Me.GroupBox5.Controls.Add(Me.rbReportForProduction)
        Me.GroupBox5.Controls.Add(Me.rbReportForSales)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 28)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(423, 67)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Report Type"
        '
        'dgvSaleRelateGammaJob
        '
        Me.dgvSaleRelateGammaJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleRelateGammaJob.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column25, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24})
        Me.dgvSaleRelateGammaJob.Location = New System.Drawing.Point(368, -6)
        Me.dgvSaleRelateGammaJob.Name = "dgvSaleRelateGammaJob"
        Me.dgvSaleRelateGammaJob.Size = New System.Drawing.Size(240, 150)
        Me.dgvSaleRelateGammaJob.TabIndex = 37
        Me.dgvSaleRelateGammaJob.Visible = False
        '
        'rbReportForSaleRelateGammaJob
        '
        Me.rbReportForSaleRelateGammaJob.AutoSize = True
        Me.rbReportForSaleRelateGammaJob.Location = New System.Drawing.Point(42, 41)
        Me.rbReportForSaleRelateGammaJob.Name = "rbReportForSaleRelateGammaJob"
        Me.rbReportForSaleRelateGammaJob.Size = New System.Drawing.Size(157, 17)
        Me.rbReportForSaleRelateGammaJob.TabIndex = 361
        Me.rbReportForSaleRelateGammaJob.Text = "For Sale Relate Gamma Job"
        Me.rbReportForSaleRelateGammaJob.UseVisualStyleBackColor = True
        '
        'rbForPresent
        '
        Me.rbForPresent.AutoSize = True
        Me.rbForPresent.Location = New System.Drawing.Point(283, 19)
        Me.rbForPresent.Name = "rbForPresent"
        Me.rbForPresent.Size = New System.Drawing.Size(79, 17)
        Me.rbForPresent.TabIndex = 360
        Me.rbForPresent.Text = "For Present"
        Me.rbForPresent.UseVisualStyleBackColor = True
        '
        'rbReportForSales
        '
        Me.rbReportForSales.AutoSize = True
        Me.rbReportForSales.Checked = True
        Me.rbReportForSales.Location = New System.Drawing.Point(42, 20)
        Me.rbReportForSales.Name = "rbReportForSales"
        Me.rbReportForSales.Size = New System.Drawing.Size(64, 17)
        Me.rbReportForSales.TabIndex = 358
        Me.rbReportForSales.TabStop = True
        Me.rbReportForSales.Text = "For Sale"
        Me.rbReportForSales.UseVisualStyleBackColor = True
        '
        'cmbSortBy
        '
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Location = New System.Drawing.Point(111, 17)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(162, 21)
        Me.cmbSortBy.TabIndex = 359
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbSortBy)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 49)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sort By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 360
        Me.Label7.Text = "Sort By"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "sonoid"
        Me.Column1.HeaderText = "S/O No."
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "sodt"
        Me.Column2.HeaderText = "S/O Date"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "customer_name"
        Me.Column3.HeaderText = "Customer"
        Me.Column3.Name = "Column3"
        '
        'Column25
        '
        Me.Column25.DataPropertyName = "custpo"
        Me.Column25.HeaderText = "P/O No."
        Me.Column25.Name = "Column25"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "empcd"
        Me.Column4.HeaderText = "Sales"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "design_no"
        Me.Column5.HeaderText = "Design No."
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "labdipno"
        Me.Column6.HeaderText = "CMR No."
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "col"
        Me.Column7.HeaderText = "Color"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "custcol"
        Me.Column8.HeaderText = "Color Name"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "qty"
        Me.Column9.HeaderText = "Order Qty"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "uom"
        Me.Column10.HeaderText = "Unit"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "qtyship"
        Me.Column11.HeaderText = "Ship Qty"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "qtybal"
        Me.Column12.HeaderText = "Bal Qty"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "price"
        Me.Column13.HeaderText = "Price"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "curr"
        Me.Column14.HeaderText = "Curr"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "cust_shipdt"
        Me.Column15.HeaderText = "Due Date"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "dfno"
        Me.Column16.HeaderText = "DF No."
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "dfdt"
        Me.Column17.HeaderText = "DF Date"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.DataPropertyName = "mtkg"
        Me.Column18.HeaderText = "DF Fin Yield"
        Me.Column18.Name = "Column18"
        '
        'Column19
        '
        Me.Column19.DataPropertyName = "kgs"
        Me.Column19.HeaderText = "DF Fin kg"
        Me.Column19.Name = "Column19"
        '
        'Column20
        '
        Me.Column20.DataPropertyName = "fs_yds"
        Me.Column20.HeaderText = "DF Fin yd"
        Me.Column20.Name = "Column20"
        '
        'Column21
        '
        Me.Column21.DataPropertyName = "fs_mts"
        Me.Column21.HeaderText = "DF Fin mts"
        Me.Column21.Name = "Column21"
        '
        'Column22
        '
        Me.Column22.DataPropertyName = "gin_date"
        Me.Column22.HeaderText = "G-In Date"
        Me.Column22.Name = "Column22"
        '
        'Column23
        '
        Me.Column23.DataPropertyName = "job_no"
        Me.Column23.HeaderText = "Job No."
        Me.Column23.Name = "Column23"
        '
        'Column24
        '
        Me.Column24.DataPropertyName = "df_status"
        Me.Column24.HeaderText = "Status"
        Me.Column24.Name = "Column24"
        '
        'frmSONotClosed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSONotClosed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S/O Not Closed Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvSaleRelateGammaJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents optShowClosedSO As System.Windows.Forms.RadioButton
    Friend WithEvents optShowNonClosedSO As System.Windows.Forms.RadioButton
    Friend WithEvents comboSalesPerson As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optPrintExcept As RadioButton
    Friend WithEvents optPrintOnly As RadioButton
    Friend WithEvents optPrintAll As RadioButton
    Friend WithEvents rbReportForProduction As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbReportForSales As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSortBy As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGetCustomer As Button
    Friend WithEvents txtCustCode As TextBox
    Friend WithEvents rbShowAllStatus As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbCustShipdt As RadioButton
    Friend WithEvents rbSODate As RadioButton
    Friend WithEvents rbForPresent As RadioButton
    Friend WithEvents rbReportForSaleRelateGammaJob As RadioButton
    Friend WithEvents tsbtnExportToExcel As ToolStripButton
    Friend WithEvents dgvSaleRelateGammaJob As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
End Class
