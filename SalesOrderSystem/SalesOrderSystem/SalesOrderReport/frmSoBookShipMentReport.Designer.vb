<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoBookShipMentReport
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.tabReports = New System.Windows.Forms.TabControl()
        Me.tabGenerateReport = New System.Windows.Forms.TabPage()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpGenerateDateFr = New System.Windows.Forms.DateTimePicker()
        Me.lblGenerateDateFr = New System.Windows.Forms.Label()
        Me.dtpGenerateDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblGenerateDateTo = New System.Windows.Forms.Label()
        Me.lblGeneratePendFrom = New System.Windows.Forms.Label()
        Me.dtpGeneratePendFrom = New System.Windows.Forms.DateTimePicker()
        Me.tabOrderBooked = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpBookedDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBookedDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dgvOrderBooked = New System.Windows.Forms.DataGridView()
        Me.grpBookedCustomer = New System.Windows.Forms.GroupBox()
        Me.btnBookedClearCustomer = New System.Windows.Forms.Button()
        Me.btnBookedGetCustomer = New System.Windows.Forms.Button()
        Me.txtBookedCustomerName = New System.Windows.Forms.TextBox()
        Me.txtBookedCustomerCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpBookedDate = New System.Windows.Forms.GroupBox()
        Me.tabOrderInvoiced = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpInvoicedDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpInvoicedDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dgvOrderInvoiced = New System.Windows.Forms.DataGridView()
        Me.grpInvoicedArticle = New System.Windows.Forms.GroupBox()
        Me.btnInvoicedClearArticle = New System.Windows.Forms.Button()
        Me.btnInvoicedGetArticle = New System.Windows.Forms.Button()
        Me.txtInvoicedDesignNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpInvoicedCustomer = New System.Windows.Forms.GroupBox()
        Me.btnInvoicedClearCustomer = New System.Windows.Forms.Button()
        Me.btnInvoicedGetCustomer = New System.Windows.Forms.Button()
        Me.txtInvoicedCustomerName = New System.Windows.Forms.TextBox()
        Me.txtInvoicedCustomerCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpInvoicedOption = New System.Windows.Forms.GroupBox()
        Me.chkInvoicedExclGMK = New System.Windows.Forms.CheckBox()
        Me.rbInvoicedAll = New System.Windows.Forms.RadioButton()
        Me.rbInvoicedExport = New System.Windows.Forms.RadioButton()
        Me.rbInvoicedLocal = New System.Windows.Forms.RadioButton()
        Me.txtInvoicedYearTo = New System.Windows.Forms.TextBox()
        Me.txtInvoicedYearFr = New System.Windows.Forms.TextBox()
        Me.tabOrderPending = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpPendingDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPendingDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblPendingPendFrom = New System.Windows.Forms.Label()
        Me.dtpPendingPendFrom = New System.Windows.Forms.DateTimePicker()
        Me.dgvOrderPending = New System.Windows.Forms.DataGridView()
        Me.grpPendingCondition = New System.Windows.Forms.GroupBox()
        Me.rbPendingDateCustDue = New System.Windows.Forms.RadioButton()
        Me.rbPendingDateSO = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbPendingSortBy = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPendingCustomerName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboPendingSalesPerson = New System.Windows.Forms.ComboBox()
        Me.rbPendingSalesExcept = New System.Windows.Forms.RadioButton()
        Me.rbPendingSalesOnly = New System.Windows.Forms.RadioButton()
        Me.rbPendingSalesAll = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbPendingAll = New System.Windows.Forms.RadioButton()
        Me.rbPendingClosed = New System.Windows.Forms.RadioButton()
        Me.rbPendingNotClosed = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpPendingArticle = New System.Windows.Forms.GroupBox()
        Me.btnPendingClearArticle = New System.Windows.Forms.Button()
        Me.btnPendingGetArticle = New System.Windows.Forms.Button()
        Me.txtPendingDesignNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpPendingDate = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.tabReports.SuspendLayout()
        Me.tabGenerateReport.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabOrderBooked.SuspendLayout()
        CType(Me.dgvOrderBooked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBookedCustomer.SuspendLayout()
        Me.tabOrderInvoiced.SuspendLayout()
        CType(Me.dgvOrderInvoiced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoicedArticle.SuspendLayout()
        Me.grpInvoicedCustomer.SuspendLayout()
        Me.grpInvoicedOption.SuspendLayout()
        Me.tabOrderPending.SuspendLayout()
        CType(Me.dgvOrderPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPendingCondition.SuspendLayout()
        Me.grpPendingArticle.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.btnPrint, Me.btnExportToExcel, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(590, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(106, 22)
        Me.btnPrint.Text = "&Generte Report"
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Image = Global.SalesOrderSystem.My.Resources.Resources.ExcelWorksheetView_16x
        Me.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(54, 22)
        Me.btnExportToExcel.Text = "Excel"
        Me.btnExportToExcel.Visible = False
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = Global.SalesOrderSystem.My.Resources.Resources.Expand_16x
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = Global.SalesOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 22)
        Me.btnExit.Text = "E&xit"
        '
        'tabReports
        '
        Me.tabReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabReports.Controls.Add(Me.tabGenerateReport)
        Me.tabReports.Location = New System.Drawing.Point(8, 32)
        Me.tabReports.Name = "tabReports"
        Me.tabReports.SelectedIndex = 0
        Me.tabReports.Size = New System.Drawing.Size(570, 236)
        Me.tabReports.TabIndex = 1
        '
        'tabGenerateReport
        '
        Me.tabGenerateReport.Controls.Add(Me.lblNote)
        Me.tabGenerateReport.Controls.Add(Me.GroupBox1)
        Me.tabGenerateReport.Controls.Add(Me.lblGeneratePendFrom)
        Me.tabGenerateReport.Controls.Add(Me.dtpGeneratePendFrom)
        Me.tabGenerateReport.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerateReport.Name = "tabGenerateReport"
        Me.tabGenerateReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerateReport.Size = New System.Drawing.Size(562, 210)
        Me.tabGenerateReport.TabIndex = 0
        Me.tabGenerateReport.Text = "Generate Report"
        Me.tabGenerateReport.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNote.Location = New System.Drawing.Point(7, 175)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(552, 32)
        Me.lblNote.TabIndex = 2
        Me.lblNote.Text = "* This report may take a long time to preview. Please wait a few minutes."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpGenerateDateFr)
        Me.GroupBox1.Controls.Add(Me.lblGenerateDateFr)
        Me.GroupBox1.Controls.Add(Me.dtpGenerateDateTo)
        Me.GroupBox1.Controls.Add(Me.lblGenerateDateTo)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "S/O && Invoice Date range"
        '
        'dtpGenerateDateFr
        '
        Me.dtpGenerateDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpGenerateDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGenerateDateFr.Location = New System.Drawing.Point(99, 25)
        Me.dtpGenerateDateFr.Name = "dtpGenerateDateFr"
        Me.dtpGenerateDateFr.Size = New System.Drawing.Size(112, 20)
        Me.dtpGenerateDateFr.TabIndex = 1
        '
        'lblGenerateDateFr
        '
        Me.lblGenerateDateFr.AutoSize = True
        Me.lblGenerateDateFr.Location = New System.Drawing.Point(14, 19)
        Me.lblGenerateDateFr.Name = "lblGenerateDateFr"
        Me.lblGenerateDateFr.Size = New System.Drawing.Size(30, 13)
        Me.lblGenerateDateFr.TabIndex = 0
        Me.lblGenerateDateFr.Text = "From"
        '
        'dtpGenerateDateTo
        '
        Me.dtpGenerateDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpGenerateDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGenerateDateTo.Location = New System.Drawing.Point(99, 61)
        Me.dtpGenerateDateTo.Name = "dtpGenerateDateTo"
        Me.dtpGenerateDateTo.Size = New System.Drawing.Size(112, 20)
        Me.dtpGenerateDateTo.TabIndex = 3
        '
        'lblGenerateDateTo
        '
        Me.lblGenerateDateTo.AutoSize = True
        Me.lblGenerateDateTo.Location = New System.Drawing.Point(14, 55)
        Me.lblGenerateDateTo.Name = "lblGenerateDateTo"
        Me.lblGenerateDateTo.Size = New System.Drawing.Size(20, 13)
        Me.lblGenerateDateTo.TabIndex = 2
        Me.lblGenerateDateTo.Text = "To"
        '
        'lblGeneratePendFrom
        '
        Me.lblGeneratePendFrom.AutoSize = True
        Me.lblGeneratePendFrom.Location = New System.Drawing.Point(21, 123)
        Me.lblGeneratePendFrom.Name = "lblGeneratePendFrom"
        Me.lblGeneratePendFrom.Size = New System.Drawing.Size(81, 13)
        Me.lblGeneratePendFrom.TabIndex = 4
        Me.lblGeneratePendFrom.Text = "S/O Pending Fr"
        '
        'dtpGeneratePendFrom
        '
        Me.dtpGeneratePendFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpGeneratePendFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGeneratePendFrom.Location = New System.Drawing.Point(112, 122)
        Me.dtpGeneratePendFrom.Name = "dtpGeneratePendFrom"
        Me.dtpGeneratePendFrom.Size = New System.Drawing.Size(112, 20)
        Me.dtpGeneratePendFrom.TabIndex = 5
        '
        'tabOrderBooked
        '
        Me.tabOrderBooked.Controls.Add(Me.Label3)
        Me.tabOrderBooked.Controls.Add(Me.dtpBookedDateFr)
        Me.tabOrderBooked.Controls.Add(Me.Label2)
        Me.tabOrderBooked.Controls.Add(Me.dtpBookedDateTo)
        Me.tabOrderBooked.Controls.Add(Me.dgvOrderBooked)
        Me.tabOrderBooked.Controls.Add(Me.grpBookedCustomer)
        Me.tabOrderBooked.Controls.Add(Me.grpBookedDate)
        Me.tabOrderBooked.Location = New System.Drawing.Point(4, 22)
        Me.tabOrderBooked.Name = "tabOrderBooked"
        Me.tabOrderBooked.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrderBooked.Size = New System.Drawing.Size(570, 494)
        Me.tabOrderBooked.TabIndex = 1
        Me.tabOrderBooked.Text = "Order Booked"
        Me.tabOrderBooked.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'dtpBookedDateFr
        '
        Me.dtpBookedDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpBookedDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBookedDateFr.Location = New System.Drawing.Point(64, 10)
        Me.dtpBookedDateFr.Name = "dtpBookedDateFr"
        Me.dtpBookedDateFr.Size = New System.Drawing.Size(96, 20)
        Me.dtpBookedDateFr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'dtpBookedDateTo
        '
        Me.dtpBookedDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpBookedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBookedDateTo.Location = New System.Drawing.Point(216, 10)
        Me.dtpBookedDateTo.Name = "dtpBookedDateTo"
        Me.dtpBookedDateTo.Size = New System.Drawing.Size(96, 20)
        Me.dtpBookedDateTo.TabIndex = 3
        '
        'dgvOrderBooked
        '
        Me.dgvOrderBooked.AllowUserToAddRows = False
        Me.dgvOrderBooked.AllowUserToDeleteRows = False
        Me.dgvOrderBooked.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderBooked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvOrderBooked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderBooked.Location = New System.Drawing.Point(8, 40)
        Me.dgvOrderBooked.Name = "dgvOrderBooked"
        Me.dgvOrderBooked.ReadOnly = True
        Me.dgvOrderBooked.Size = New System.Drawing.Size(554, 446)
        Me.dgvOrderBooked.TabIndex = 2
        '
        'grpBookedCustomer
        '
        Me.grpBookedCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBookedCustomer.Controls.Add(Me.btnBookedClearCustomer)
        Me.grpBookedCustomer.Controls.Add(Me.btnBookedGetCustomer)
        Me.grpBookedCustomer.Controls.Add(Me.txtBookedCustomerName)
        Me.grpBookedCustomer.Controls.Add(Me.txtBookedCustomerCode)
        Me.grpBookedCustomer.Controls.Add(Me.Label4)
        Me.grpBookedCustomer.Controls.Add(Me.Label5)
        Me.grpBookedCustomer.Location = New System.Drawing.Point(16, 96)
        Me.grpBookedCustomer.Name = "grpBookedCustomer"
        Me.grpBookedCustomer.Size = New System.Drawing.Size(536, 80)
        Me.grpBookedCustomer.TabIndex = 1
        Me.grpBookedCustomer.TabStop = False
        Me.grpBookedCustomer.Text = "Customer"
        Me.grpBookedCustomer.Visible = False
        '
        'btnBookedClearCustomer
        '
        Me.btnBookedClearCustomer.Location = New System.Drawing.Point(256, 16)
        Me.btnBookedClearCustomer.Name = "btnBookedClearCustomer"
        Me.btnBookedClearCustomer.Size = New System.Drawing.Size(32, 22)
        Me.btnBookedClearCustomer.TabIndex = 3
        Me.btnBookedClearCustomer.Text = "X"
        Me.btnBookedClearCustomer.UseVisualStyleBackColor = True
        '
        'btnBookedGetCustomer
        '
        Me.btnBookedGetCustomer.Location = New System.Drawing.Point(216, 16)
        Me.btnBookedGetCustomer.Name = "btnBookedGetCustomer"
        Me.btnBookedGetCustomer.Size = New System.Drawing.Size(32, 22)
        Me.btnBookedGetCustomer.TabIndex = 2
        Me.btnBookedGetCustomer.Text = "..."
        Me.btnBookedGetCustomer.UseVisualStyleBackColor = True
        '
        'txtBookedCustomerName
        '
        Me.txtBookedCustomerName.Location = New System.Drawing.Point(96, 43)
        Me.txtBookedCustomerName.Name = "txtBookedCustomerName"
        Me.txtBookedCustomerName.ReadOnly = True
        Me.txtBookedCustomerName.Size = New System.Drawing.Size(336, 20)
        Me.txtBookedCustomerName.TabIndex = 5
        '
        'txtBookedCustomerCode
        '
        Me.txtBookedCustomerCode.Location = New System.Drawing.Point(96, 18)
        Me.txtBookedCustomerCode.Name = "txtBookedCustomerCode"
        Me.txtBookedCustomerCode.Size = New System.Drawing.Size(112, 20)
        Me.txtBookedCustomerCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Code"
        '
        'grpBookedDate
        '
        Me.grpBookedDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBookedDate.Location = New System.Drawing.Point(16, 16)
        Me.grpBookedDate.Name = "grpBookedDate"
        Me.grpBookedDate.Size = New System.Drawing.Size(536, 64)
        Me.grpBookedDate.TabIndex = 0
        Me.grpBookedDate.TabStop = False
        Me.grpBookedDate.Text = "S/O Date"
        Me.grpBookedDate.Visible = False
        '
        'tabOrderInvoiced
        '
        Me.tabOrderInvoiced.Controls.Add(Me.Label8)
        Me.tabOrderInvoiced.Controls.Add(Me.dtpInvoicedDateFr)
        Me.tabOrderInvoiced.Controls.Add(Me.Label7)
        Me.tabOrderInvoiced.Controls.Add(Me.dtpInvoicedDateTo)
        Me.tabOrderInvoiced.Controls.Add(Me.dgvOrderInvoiced)
        Me.tabOrderInvoiced.Controls.Add(Me.grpInvoicedArticle)
        Me.tabOrderInvoiced.Controls.Add(Me.grpInvoicedCustomer)
        Me.tabOrderInvoiced.Controls.Add(Me.grpInvoicedOption)
        Me.tabOrderInvoiced.Location = New System.Drawing.Point(4, 22)
        Me.tabOrderInvoiced.Name = "tabOrderInvoiced"
        Me.tabOrderInvoiced.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrderInvoiced.Size = New System.Drawing.Size(570, 494)
        Me.tabOrderInvoiced.TabIndex = 2
        Me.tabOrderInvoiced.Text = "Order Invoiced"
        Me.tabOrderInvoiced.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "From"
        '
        'dtpInvoicedDateFr
        '
        Me.dtpInvoicedDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpInvoicedDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoicedDateFr.Location = New System.Drawing.Point(64, 10)
        Me.dtpInvoicedDateFr.Name = "dtpInvoicedDateFr"
        Me.dtpInvoicedDateFr.Size = New System.Drawing.Size(112, 20)
        Me.dtpInvoicedDateFr.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "To"
        '
        'dtpInvoicedDateTo
        '
        Me.dtpInvoicedDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpInvoicedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoicedDateTo.Location = New System.Drawing.Point(216, 10)
        Me.dtpInvoicedDateTo.Name = "dtpInvoicedDateTo"
        Me.dtpInvoicedDateTo.Size = New System.Drawing.Size(112, 20)
        Me.dtpInvoicedDateTo.TabIndex = 3
        '
        'dgvOrderInvoiced
        '
        Me.dgvOrderInvoiced.AllowUserToAddRows = False
        Me.dgvOrderInvoiced.AllowUserToDeleteRows = False
        Me.dgvOrderInvoiced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderInvoiced.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvOrderInvoiced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderInvoiced.Location = New System.Drawing.Point(8, 40)
        Me.dgvOrderInvoiced.Name = "dgvOrderInvoiced"
        Me.dgvOrderInvoiced.ReadOnly = True
        Me.dgvOrderInvoiced.Size = New System.Drawing.Size(554, 446)
        Me.dgvOrderInvoiced.TabIndex = 3
        '
        'grpInvoicedArticle
        '
        Me.grpInvoicedArticle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInvoicedArticle.Controls.Add(Me.btnInvoicedClearArticle)
        Me.grpInvoicedArticle.Controls.Add(Me.btnInvoicedGetArticle)
        Me.grpInvoicedArticle.Controls.Add(Me.txtInvoicedDesignNo)
        Me.grpInvoicedArticle.Controls.Add(Me.Label11)
        Me.grpInvoicedArticle.Location = New System.Drawing.Point(16, 184)
        Me.grpInvoicedArticle.Name = "grpInvoicedArticle"
        Me.grpInvoicedArticle.Size = New System.Drawing.Size(536, 64)
        Me.grpInvoicedArticle.TabIndex = 2
        Me.grpInvoicedArticle.TabStop = False
        Me.grpInvoicedArticle.Text = "Article"
        Me.grpInvoicedArticle.Visible = False
        '
        'btnInvoicedClearArticle
        '
        Me.btnInvoicedClearArticle.Location = New System.Drawing.Point(360, 24)
        Me.btnInvoicedClearArticle.Name = "btnInvoicedClearArticle"
        Me.btnInvoicedClearArticle.Size = New System.Drawing.Size(48, 22)
        Me.btnInvoicedClearArticle.TabIndex = 3
        Me.btnInvoicedClearArticle.Text = "Clear"
        Me.btnInvoicedClearArticle.UseVisualStyleBackColor = True
        '
        'btnInvoicedGetArticle
        '
        Me.btnInvoicedGetArticle.Location = New System.Drawing.Point(320, 24)
        Me.btnInvoicedGetArticle.Name = "btnInvoicedGetArticle"
        Me.btnInvoicedGetArticle.Size = New System.Drawing.Size(32, 22)
        Me.btnInvoicedGetArticle.TabIndex = 2
        Me.btnInvoicedGetArticle.Text = "..."
        Me.btnInvoicedGetArticle.UseVisualStyleBackColor = True
        '
        'txtInvoicedDesignNo
        '
        Me.txtInvoicedDesignNo.Location = New System.Drawing.Point(96, 25)
        Me.txtInvoicedDesignNo.Name = "txtInvoicedDesignNo"
        Me.txtInvoicedDesignNo.Size = New System.Drawing.Size(216, 20)
        Me.txtInvoicedDesignNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Design No."
        '
        'grpInvoicedCustomer
        '
        Me.grpInvoicedCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInvoicedCustomer.Controls.Add(Me.btnInvoicedClearCustomer)
        Me.grpInvoicedCustomer.Controls.Add(Me.btnInvoicedGetCustomer)
        Me.grpInvoicedCustomer.Controls.Add(Me.txtInvoicedCustomerName)
        Me.grpInvoicedCustomer.Controls.Add(Me.txtInvoicedCustomerCode)
        Me.grpInvoicedCustomer.Controls.Add(Me.Label9)
        Me.grpInvoicedCustomer.Controls.Add(Me.Label10)
        Me.grpInvoicedCustomer.Location = New System.Drawing.Point(16, 96)
        Me.grpInvoicedCustomer.Name = "grpInvoicedCustomer"
        Me.grpInvoicedCustomer.Size = New System.Drawing.Size(536, 80)
        Me.grpInvoicedCustomer.TabIndex = 1
        Me.grpInvoicedCustomer.TabStop = False
        Me.grpInvoicedCustomer.Text = "Customer"
        Me.grpInvoicedCustomer.Visible = False
        '
        'btnInvoicedClearCustomer
        '
        Me.btnInvoicedClearCustomer.Location = New System.Drawing.Point(256, 16)
        Me.btnInvoicedClearCustomer.Name = "btnInvoicedClearCustomer"
        Me.btnInvoicedClearCustomer.Size = New System.Drawing.Size(32, 22)
        Me.btnInvoicedClearCustomer.TabIndex = 3
        Me.btnInvoicedClearCustomer.Text = "X"
        Me.btnInvoicedClearCustomer.UseVisualStyleBackColor = True
        '
        'btnInvoicedGetCustomer
        '
        Me.btnInvoicedGetCustomer.Location = New System.Drawing.Point(216, 16)
        Me.btnInvoicedGetCustomer.Name = "btnInvoicedGetCustomer"
        Me.btnInvoicedGetCustomer.Size = New System.Drawing.Size(32, 22)
        Me.btnInvoicedGetCustomer.TabIndex = 2
        Me.btnInvoicedGetCustomer.Text = "..."
        Me.btnInvoicedGetCustomer.UseVisualStyleBackColor = True
        '
        'txtInvoicedCustomerName
        '
        Me.txtInvoicedCustomerName.Location = New System.Drawing.Point(96, 43)
        Me.txtInvoicedCustomerName.Name = "txtInvoicedCustomerName"
        Me.txtInvoicedCustomerName.ReadOnly = True
        Me.txtInvoicedCustomerName.Size = New System.Drawing.Size(336, 20)
        Me.txtInvoicedCustomerName.TabIndex = 5
        '
        'txtInvoicedCustomerCode
        '
        Me.txtInvoicedCustomerCode.Location = New System.Drawing.Point(96, 18)
        Me.txtInvoicedCustomerCode.Name = "txtInvoicedCustomerCode"
        Me.txtInvoicedCustomerCode.Size = New System.Drawing.Size(112, 20)
        Me.txtInvoicedCustomerCode.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Code"
        '
        'grpInvoicedOption
        '
        Me.grpInvoicedOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInvoicedOption.Controls.Add(Me.chkInvoicedExclGMK)
        Me.grpInvoicedOption.Controls.Add(Me.rbInvoicedAll)
        Me.grpInvoicedOption.Controls.Add(Me.rbInvoicedExport)
        Me.grpInvoicedOption.Controls.Add(Me.rbInvoicedLocal)
        Me.grpInvoicedOption.Controls.Add(Me.txtInvoicedYearTo)
        Me.grpInvoicedOption.Controls.Add(Me.txtInvoicedYearFr)
        Me.grpInvoicedOption.Location = New System.Drawing.Point(16, 16)
        Me.grpInvoicedOption.Name = "grpInvoicedOption"
        Me.grpInvoicedOption.Size = New System.Drawing.Size(536, 72)
        Me.grpInvoicedOption.TabIndex = 0
        Me.grpInvoicedOption.TabStop = False
        Me.grpInvoicedOption.Text = "Invoice"
        Me.grpInvoicedOption.Visible = False
        '
        'chkInvoicedExclGMK
        '
        Me.chkInvoicedExclGMK.AutoSize = True
        Me.chkInvoicedExclGMK.Location = New System.Drawing.Point(376, 21)
        Me.chkInvoicedExclGMK.Name = "chkInvoicedExclGMK"
        Me.chkInvoicedExclGMK.Size = New System.Drawing.Size(91, 17)
        Me.chkInvoicedExclGMK.TabIndex = 7
        Me.chkInvoicedExclGMK.Text = "Exclude GMK"
        Me.chkInvoicedExclGMK.UseVisualStyleBackColor = True
        '
        'rbInvoicedAll
        '
        Me.rbInvoicedAll.AutoSize = True
        Me.rbInvoicedAll.Checked = True
        Me.rbInvoicedAll.Location = New System.Drawing.Point(240, 43)
        Me.rbInvoicedAll.Name = "rbInvoicedAll"
        Me.rbInvoicedAll.Size = New System.Drawing.Size(36, 17)
        Me.rbInvoicedAll.TabIndex = 6
        Me.rbInvoicedAll.TabStop = True
        Me.rbInvoicedAll.Text = "All"
        Me.rbInvoicedAll.UseVisualStyleBackColor = True
        '
        'rbInvoicedExport
        '
        Me.rbInvoicedExport.AutoSize = True
        Me.rbInvoicedExport.Location = New System.Drawing.Point(240, 21)
        Me.rbInvoicedExport.Name = "rbInvoicedExport"
        Me.rbInvoicedExport.Size = New System.Drawing.Size(55, 17)
        Me.rbInvoicedExport.TabIndex = 5
        Me.rbInvoicedExport.Text = "Export"
        Me.rbInvoicedExport.UseVisualStyleBackColor = True
        '
        'rbInvoicedLocal
        '
        Me.rbInvoicedLocal.AutoSize = True
        Me.rbInvoicedLocal.Location = New System.Drawing.Point(160, 21)
        Me.rbInvoicedLocal.Name = "rbInvoicedLocal"
        Me.rbInvoicedLocal.Size = New System.Drawing.Size(51, 17)
        Me.rbInvoicedLocal.TabIndex = 4
        Me.rbInvoicedLocal.Text = "Local"
        Me.rbInvoicedLocal.UseVisualStyleBackColor = True
        '
        'txtInvoicedYearTo
        '
        Me.txtInvoicedYearTo.Location = New System.Drawing.Point(64, 43)
        Me.txtInvoicedYearTo.MaxLength = 4
        Me.txtInvoicedYearTo.Name = "txtInvoicedYearTo"
        Me.txtInvoicedYearTo.Size = New System.Drawing.Size(64, 20)
        Me.txtInvoicedYearTo.TabIndex = 3
        '
        'txtInvoicedYearFr
        '
        Me.txtInvoicedYearFr.Location = New System.Drawing.Point(64, 19)
        Me.txtInvoicedYearFr.MaxLength = 4
        Me.txtInvoicedYearFr.Name = "txtInvoicedYearFr"
        Me.txtInvoicedYearFr.Size = New System.Drawing.Size(64, 20)
        Me.txtInvoicedYearFr.TabIndex = 1
        '
        'tabOrderPending
        '
        Me.tabOrderPending.Controls.Add(Me.Label6)
        Me.tabOrderPending.Controls.Add(Me.dtpPendingDateFr)
        Me.tabOrderPending.Controls.Add(Me.Label1)
        Me.tabOrderPending.Controls.Add(Me.dtpPendingDateTo)
        Me.tabOrderPending.Controls.Add(Me.lblPendingPendFrom)
        Me.tabOrderPending.Controls.Add(Me.dtpPendingPendFrom)
        Me.tabOrderPending.Controls.Add(Me.dgvOrderPending)
        Me.tabOrderPending.Controls.Add(Me.grpPendingCondition)
        Me.tabOrderPending.Controls.Add(Me.grpPendingArticle)
        Me.tabOrderPending.Controls.Add(Me.grpPendingDate)
        Me.tabOrderPending.Location = New System.Drawing.Point(4, 22)
        Me.tabOrderPending.Name = "tabOrderPending"
        Me.tabOrderPending.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrderPending.Size = New System.Drawing.Size(570, 494)
        Me.tabOrderPending.TabIndex = 3
        Me.tabOrderPending.Text = "Order Pending"
        Me.tabOrderPending.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "From"
        '
        'dtpPendingDateFr
        '
        Me.dtpPendingDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpPendingDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPendingDateFr.Location = New System.Drawing.Point(64, 10)
        Me.dtpPendingDateFr.Name = "dtpPendingDateFr"
        Me.dtpPendingDateFr.Size = New System.Drawing.Size(112, 20)
        Me.dtpPendingDateFr.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'dtpPendingDateTo
        '
        Me.dtpPendingDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpPendingDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPendingDateTo.Location = New System.Drawing.Point(216, 10)
        Me.dtpPendingDateTo.Name = "dtpPendingDateTo"
        Me.dtpPendingDateTo.Size = New System.Drawing.Size(112, 20)
        Me.dtpPendingDateTo.TabIndex = 3
        '
        'lblPendingPendFrom
        '
        Me.lblPendingPendFrom.AutoSize = True
        Me.lblPendingPendFrom.Location = New System.Drawing.Point(336, 14)
        Me.lblPendingPendFrom.Name = "lblPendingPendFrom"
        Me.lblPendingPendFrom.Size = New System.Drawing.Size(72, 13)
        Me.lblPendingPendFrom.TabIndex = 4
        Me.lblPendingPendFrom.Text = "Pending From"
        '
        'dtpPendingPendFrom
        '
        Me.dtpPendingPendFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpPendingPendFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPendingPendFrom.Location = New System.Drawing.Point(424, 10)
        Me.dtpPendingPendFrom.Name = "dtpPendingPendFrom"
        Me.dtpPendingPendFrom.Size = New System.Drawing.Size(112, 20)
        Me.dtpPendingPendFrom.TabIndex = 5
        '
        'dgvOrderPending
        '
        Me.dgvOrderPending.AllowUserToAddRows = False
        Me.dgvOrderPending.AllowUserToDeleteRows = False
        Me.dgvOrderPending.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvOrderPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderPending.Location = New System.Drawing.Point(8, 40)
        Me.dgvOrderPending.Name = "dgvOrderPending"
        Me.dgvOrderPending.ReadOnly = True
        Me.dgvOrderPending.Size = New System.Drawing.Size(554, 446)
        Me.dgvOrderPending.TabIndex = 3
        '
        'grpPendingCondition
        '
        Me.grpPendingCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingDateCustDue)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingDateSO)
        Me.grpPendingCondition.Controls.Add(Me.Label17)
        Me.grpPendingCondition.Controls.Add(Me.cmbPendingSortBy)
        Me.grpPendingCondition.Controls.Add(Me.Label16)
        Me.grpPendingCondition.Controls.Add(Me.txtPendingCustomerName)
        Me.grpPendingCondition.Controls.Add(Me.Label15)
        Me.grpPendingCondition.Controls.Add(Me.cboPendingSalesPerson)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingSalesExcept)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingSalesOnly)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingSalesAll)
        Me.grpPendingCondition.Controls.Add(Me.Label14)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingAll)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingClosed)
        Me.grpPendingCondition.Controls.Add(Me.rbPendingNotClosed)
        Me.grpPendingCondition.Controls.Add(Me.Label13)
        Me.grpPendingCondition.Location = New System.Drawing.Point(16, 144)
        Me.grpPendingCondition.Name = "grpPendingCondition"
        Me.grpPendingCondition.Size = New System.Drawing.Size(536, 136)
        Me.grpPendingCondition.TabIndex = 2
        Me.grpPendingCondition.TabStop = False
        Me.grpPendingCondition.Text = "Condition"
        Me.grpPendingCondition.Visible = False
        '
        'rbPendingDateCustDue
        '
        Me.rbPendingDateCustDue.AutoSize = True
        Me.rbPendingDateCustDue.Location = New System.Drawing.Point(160, 104)
        Me.rbPendingDateCustDue.Name = "rbPendingDateCustDue"
        Me.rbPendingDateCustDue.Size = New System.Drawing.Size(92, 17)
        Me.rbPendingDateCustDue.TabIndex = 15
        Me.rbPendingDateCustDue.Text = "Customer Due"
        Me.rbPendingDateCustDue.UseVisualStyleBackColor = True
        '
        'rbPendingDateSO
        '
        Me.rbPendingDateSO.AutoSize = True
        Me.rbPendingDateSO.Checked = True
        Me.rbPendingDateSO.Location = New System.Drawing.Point(88, 104)
        Me.rbPendingDateSO.Name = "rbPendingDateSO"
        Me.rbPendingDateSO.Size = New System.Drawing.Size(45, 17)
        Me.rbPendingDateSO.TabIndex = 14
        Me.rbPendingDateSO.TabStop = True
        Me.rbPendingDateSO.Text = "S/O"
        Me.rbPendingDateSO.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Date Of"
        '
        'cmbPendingSortBy
        '
        Me.cmbPendingSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPendingSortBy.FormattingEnabled = True
        Me.cmbPendingSortBy.Location = New System.Drawing.Point(360, 76)
        Me.cmbPendingSortBy.Name = "cmbPendingSortBy"
        Me.cmbPendingSortBy.Size = New System.Drawing.Size(152, 21)
        Me.cmbPendingSortBy.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(312, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Sort By"
        '
        'txtPendingCustomerName
        '
        Me.txtPendingCustomerName.Location = New System.Drawing.Point(88, 77)
        Me.txtPendingCustomerName.Name = "txtPendingCustomerName"
        Me.txtPendingCustomerName.Size = New System.Drawing.Size(200, 20)
        Me.txtPendingCustomerName.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Customer"
        '
        'cboPendingSalesPerson
        '
        Me.cboPendingSalesPerson.FormattingEnabled = True
        Me.cboPendingSalesPerson.Location = New System.Drawing.Point(360, 48)
        Me.cboPendingSalesPerson.Name = "cboPendingSalesPerson"
        Me.cboPendingSalesPerson.Size = New System.Drawing.Size(152, 21)
        Me.cboPendingSalesPerson.TabIndex = 8
        '
        'rbPendingSalesExcept
        '
        Me.rbPendingSalesExcept.AutoSize = True
        Me.rbPendingSalesExcept.Location = New System.Drawing.Point(224, 51)
        Me.rbPendingSalesExcept.Name = "rbPendingSalesExcept"
        Me.rbPendingSalesExcept.Size = New System.Drawing.Size(58, 17)
        Me.rbPendingSalesExcept.TabIndex = 7
        Me.rbPendingSalesExcept.Text = "Except"
        Me.rbPendingSalesExcept.UseVisualStyleBackColor = True
        '
        'rbPendingSalesOnly
        '
        Me.rbPendingSalesOnly.AutoSize = True
        Me.rbPendingSalesOnly.Location = New System.Drawing.Point(160, 51)
        Me.rbPendingSalesOnly.Name = "rbPendingSalesOnly"
        Me.rbPendingSalesOnly.Size = New System.Drawing.Size(46, 17)
        Me.rbPendingSalesOnly.TabIndex = 6
        Me.rbPendingSalesOnly.Text = "Only"
        Me.rbPendingSalesOnly.UseVisualStyleBackColor = True
        '
        'rbPendingSalesAll
        '
        Me.rbPendingSalesAll.AutoSize = True
        Me.rbPendingSalesAll.Checked = True
        Me.rbPendingSalesAll.Location = New System.Drawing.Point(88, 51)
        Me.rbPendingSalesAll.Name = "rbPendingSalesAll"
        Me.rbPendingSalesAll.Size = New System.Drawing.Size(36, 17)
        Me.rbPendingSalesAll.TabIndex = 5
        Me.rbPendingSalesAll.TabStop = True
        Me.rbPendingSalesAll.Text = "All"
        Me.rbPendingSalesAll.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Salesperson"
        '
        'rbPendingAll
        '
        Me.rbPendingAll.AutoSize = True
        Me.rbPendingAll.Location = New System.Drawing.Point(224, 24)
        Me.rbPendingAll.Name = "rbPendingAll"
        Me.rbPendingAll.Size = New System.Drawing.Size(36, 17)
        Me.rbPendingAll.TabIndex = 3
        Me.rbPendingAll.Text = "All"
        Me.rbPendingAll.UseVisualStyleBackColor = True
        '
        'rbPendingClosed
        '
        Me.rbPendingClosed.AutoSize = True
        Me.rbPendingClosed.Location = New System.Drawing.Point(160, 24)
        Me.rbPendingClosed.Name = "rbPendingClosed"
        Me.rbPendingClosed.Size = New System.Drawing.Size(57, 17)
        Me.rbPendingClosed.TabIndex = 2
        Me.rbPendingClosed.Text = "Closed"
        Me.rbPendingClosed.UseVisualStyleBackColor = True
        '
        'rbPendingNotClosed
        '
        Me.rbPendingNotClosed.AutoSize = True
        Me.rbPendingNotClosed.Checked = True
        Me.rbPendingNotClosed.Location = New System.Drawing.Point(88, 24)
        Me.rbPendingNotClosed.Name = "rbPendingNotClosed"
        Me.rbPendingNotClosed.Size = New System.Drawing.Size(42, 17)
        Me.rbPendingNotClosed.TabIndex = 1
        Me.rbPendingNotClosed.TabStop = True
        Me.rbPendingNotClosed.Text = "Not"
        Me.rbPendingNotClosed.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Closed"
        '
        'grpPendingArticle
        '
        Me.grpPendingArticle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPendingArticle.Controls.Add(Me.btnPendingClearArticle)
        Me.grpPendingArticle.Controls.Add(Me.btnPendingGetArticle)
        Me.grpPendingArticle.Controls.Add(Me.txtPendingDesignNo)
        Me.grpPendingArticle.Controls.Add(Me.Label12)
        Me.grpPendingArticle.Location = New System.Drawing.Point(16, 80)
        Me.grpPendingArticle.Name = "grpPendingArticle"
        Me.grpPendingArticle.Size = New System.Drawing.Size(536, 56)
        Me.grpPendingArticle.TabIndex = 1
        Me.grpPendingArticle.TabStop = False
        Me.grpPendingArticle.Text = "Article"
        Me.grpPendingArticle.Visible = False
        '
        'btnPendingClearArticle
        '
        Me.btnPendingClearArticle.Location = New System.Drawing.Point(360, 19)
        Me.btnPendingClearArticle.Name = "btnPendingClearArticle"
        Me.btnPendingClearArticle.Size = New System.Drawing.Size(48, 22)
        Me.btnPendingClearArticle.TabIndex = 3
        Me.btnPendingClearArticle.Text = "Clear"
        Me.btnPendingClearArticle.UseVisualStyleBackColor = True
        '
        'btnPendingGetArticle
        '
        Me.btnPendingGetArticle.Location = New System.Drawing.Point(320, 19)
        Me.btnPendingGetArticle.Name = "btnPendingGetArticle"
        Me.btnPendingGetArticle.Size = New System.Drawing.Size(32, 22)
        Me.btnPendingGetArticle.TabIndex = 2
        Me.btnPendingGetArticle.Text = "..."
        Me.btnPendingGetArticle.UseVisualStyleBackColor = True
        '
        'txtPendingDesignNo
        '
        Me.txtPendingDesignNo.Location = New System.Drawing.Point(96, 20)
        Me.txtPendingDesignNo.Name = "txtPendingDesignNo"
        Me.txtPendingDesignNo.Size = New System.Drawing.Size(216, 20)
        Me.txtPendingDesignNo.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Design No."
        '
        'grpPendingDate
        '
        Me.grpPendingDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPendingDate.Location = New System.Drawing.Point(16, 16)
        Me.grpPendingDate.Name = "grpPendingDate"
        Me.grpPendingDate.Size = New System.Drawing.Size(536, 56)
        Me.grpPendingDate.TabIndex = 0
        Me.grpPendingDate.TabStop = False
        Me.grpPendingDate.Text = "Date"
        Me.grpPendingDate.Visible = False
        '
        'frmSoBookShipMentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 274)
        Me.Controls.Add(Me.tabReports)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSoBookShipMentReport"
        Me.Text = "S/O Book Shipment"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tabReports.ResumeLayout(False)
        Me.tabGenerateReport.ResumeLayout(False)
        Me.tabGenerateReport.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabOrderBooked.ResumeLayout(False)
        Me.tabOrderBooked.PerformLayout()
        CType(Me.dgvOrderBooked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBookedCustomer.ResumeLayout(False)
        Me.grpBookedCustomer.PerformLayout()
        Me.tabOrderInvoiced.ResumeLayout(False)
        Me.tabOrderInvoiced.PerformLayout()
        CType(Me.dgvOrderInvoiced, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoicedArticle.ResumeLayout(False)
        Me.grpInvoicedArticle.PerformLayout()
        Me.grpInvoicedCustomer.ResumeLayout(False)
        Me.grpInvoicedCustomer.PerformLayout()
        Me.grpInvoicedOption.ResumeLayout(False)
        Me.grpInvoicedOption.PerformLayout()
        Me.tabOrderPending.ResumeLayout(False)
        Me.tabOrderPending.PerformLayout()
        CType(Me.dgvOrderPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPendingCondition.ResumeLayout(False)
        Me.grpPendingCondition.PerformLayout()
        Me.grpPendingArticle.ResumeLayout(False)
        Me.grpPendingArticle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportToExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tabReports As System.Windows.Forms.TabControl
    Friend WithEvents tabGenerateReport As System.Windows.Forms.TabPage
    Friend WithEvents lblGenerateDateFr As System.Windows.Forms.Label
    Friend WithEvents dtpGenerateDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGenerateDateTo As System.Windows.Forms.Label
    Friend WithEvents dtpGenerateDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGeneratePendFrom As System.Windows.Forms.Label
    Friend WithEvents dtpGeneratePendFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabOrderBooked As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrderBooked As System.Windows.Forms.DataGridView
    Friend WithEvents grpBookedCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents btnBookedClearCustomer As System.Windows.Forms.Button
    Friend WithEvents btnBookedGetCustomer As System.Windows.Forms.Button
    Friend WithEvents txtBookedCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtBookedCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpBookedDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpBookedDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBookedDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabOrderInvoiced As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrderInvoiced As System.Windows.Forms.DataGridView
    Friend WithEvents grpInvoicedArticle As System.Windows.Forms.GroupBox
    Friend WithEvents btnInvoicedClearArticle As System.Windows.Forms.Button
    Friend WithEvents btnInvoicedGetArticle As System.Windows.Forms.Button
    Friend WithEvents txtInvoicedDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grpInvoicedCustomer As System.Windows.Forms.GroupBox
    Friend WithEvents btnInvoicedClearCustomer As System.Windows.Forms.Button
    Friend WithEvents btnInvoicedGetCustomer As System.Windows.Forms.Button
    Friend WithEvents txtInvoicedCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoicedCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpInvoicedOption As System.Windows.Forms.GroupBox
    Friend WithEvents chkInvoicedExclGMK As System.Windows.Forms.CheckBox
    Friend WithEvents rbInvoicedAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbInvoicedExport As System.Windows.Forms.RadioButton
    Friend WithEvents rbInvoicedLocal As System.Windows.Forms.RadioButton
    Friend WithEvents txtInvoicedYearTo As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoicedYearFr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpInvoicedDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInvoicedDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabOrderPending As System.Windows.Forms.TabPage
    Friend WithEvents dgvOrderPending As System.Windows.Forms.DataGridView
    Friend WithEvents grpPendingCondition As System.Windows.Forms.GroupBox
    Friend WithEvents rbPendingDateCustDue As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendingDateSO As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbPendingSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPendingCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboPendingSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents rbPendingSalesExcept As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendingSalesOnly As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendingSalesAll As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbPendingAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendingClosed As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendingNotClosed As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpPendingArticle As System.Windows.Forms.GroupBox
    Friend WithEvents btnPendingClearArticle As System.Windows.Forms.Button
    Friend WithEvents btnPendingGetArticle As System.Windows.Forms.Button
    Friend WithEvents txtPendingDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpPendingDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpPendingDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPendingDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPendingPendFrom As System.Windows.Forms.Label
    Friend WithEvents dtpPendingPendFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
