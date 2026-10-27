<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitNoteExport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitNoteExport))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDbNoteNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnApprove = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGrossAmt = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtNetAmt = New System.Windows.Forms.TextBox()
        Me.txtVatAmt = New System.Windows.Forms.TextBox()
        Me.txtPreTaxAmt = New System.Windows.Forms.TextBox()
        Me.txtDiscAmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grdDetails = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpresent_status = New System.Windows.Forms.TextBox()
        Me.btnLoadINV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchInvNo = New System.Windows.Forms.Button()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboinvno = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRefInv = New System.Windows.Forms.RadioButton()
        Me.rbNotRefInv = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboInvtype = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboSalesMan = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnExchangeRate = New System.Windows.Forms.Button()
        Me.invord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_goods = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_in_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_cnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.uprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linediscamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linenetamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboCurrency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReference
        '
        Me.txtReference.AccessibleName = "reference"
        Me.txtReference.Location = New System.Drawing.Point(83, 123)
        Me.txtReference.MaxLength = 100
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(203, 22)
        Me.txtReference.TabIndex = 119
        Me.txtReference.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Customer"
        '
        'dtpDocDate
        '
        Me.dtpDocDate.AccessibleName = "dbnote_date"
        Me.dtpDocDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDate.Location = New System.Drawing.Point(112, 40)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(103, 22)
        Me.dtpDocDate.TabIndex = 109
        Me.dtpDocDate.Tag = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 13)
        Me.Label28.TabIndex = 111
        Me.Label28.Text = "Debit Note Date"
        '
        'txtDbNoteNo
        '
        Me.txtDbNoteNo.AccessibleName = "dbnote_no"
        Me.txtDbNoteNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDbNoteNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDbNoteNo.Location = New System.Drawing.Point(112, 14)
        Me.txtDbNoteNo.Name = "txtDbNoteNo"
        Me.txtDbNoteNo.ReadOnly = True
        Me.txtDbNoteNo.Size = New System.Drawing.Size(103, 20)
        Me.txtDbNoteNo.TabIndex = 108
        Me.txtDbNoteNo.Tag = ""
        Me.txtDbNoteNo.Text = "CN-07050020"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnApprove, Me.btnCancel, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(936, 25)
        Me.ToolStrip1.TabIndex = 107
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel1.Text = "Db Note No."
        '
        'cboDocNo
        '
        Me.cboDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "Search"
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
        'btnApprove
        '
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(79, 22)
        Me.btnApprove.Text = "Apporved"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
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
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(21, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 13)
        Me.Label29.TabIndex = 110
        Me.Label29.Text = "Debit Note No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Reference"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(708, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Gross Amount"
        '
        'txtGrossAmt
        '
        Me.txtGrossAmt.AccessibleDescription = "0.00"
        Me.txtGrossAmt.AccessibleName = "grossamt"
        Me.txtGrossAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrossAmt.Location = New System.Drawing.Point(816, 392)
        Me.txtGrossAmt.Name = "txtGrossAmt"
        Me.txtGrossAmt.ReadOnly = True
        Me.txtGrossAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtGrossAmt.TabIndex = 139
        Me.txtGrossAmt.Tag = ""
        Me.txtGrossAmt.Text = "0.00"
        Me.txtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.AccessibleName = "remarks"
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Location = New System.Drawing.Point(7, 403)
        Me.txtRemarks.MaxLength = 255
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(676, 101)
        Me.txtRemarks.TabIndex = 134
        Me.txtRemarks.Tag = ""
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Remarks"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(708, 491)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "Net Amount"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(778, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(708, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "VAT"
        '
        'txtVat
        '
        Me.txtVat.AccessibleDescription = "0.00"
        Me.txtVat.AccessibleName = "vat"
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.Location = New System.Drawing.Point(740, 464)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(32, 22)
        Me.txtVat.TabIndex = 129
        Me.txtVat.Tag = ""
        Me.txtVat.Text = "7.00"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmt
        '
        Me.txtNetAmt.AccessibleDescription = "0.00"
        Me.txtNetAmt.AccessibleName = "netamt"
        Me.txtNetAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetAmt.Location = New System.Drawing.Point(816, 488)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtNetAmt.TabIndex = 132
        Me.txtNetAmt.Tag = ""
        Me.txtNetAmt.Text = "0.00"
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatAmt
        '
        Me.txtVatAmt.AccessibleDescription = "0.00"
        Me.txtVatAmt.AccessibleName = "vatamt"
        Me.txtVatAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVatAmt.Location = New System.Drawing.Point(816, 464)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.ReadOnly = True
        Me.txtVatAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtVatAmt.TabIndex = 131
        Me.txtVatAmt.Tag = ""
        Me.txtVatAmt.Text = "0.00"
        Me.txtVatAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPreTaxAmt
        '
        Me.txtPreTaxAmt.AccessibleDescription = "0.00"
        Me.txtPreTaxAmt.AccessibleName = "pretaxamt"
        Me.txtPreTaxAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreTaxAmt.Location = New System.Drawing.Point(816, 440)
        Me.txtPreTaxAmt.Name = "txtPreTaxAmt"
        Me.txtPreTaxAmt.ReadOnly = True
        Me.txtPreTaxAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtPreTaxAmt.TabIndex = 128
        Me.txtPreTaxAmt.Tag = ""
        Me.txtPreTaxAmt.Text = "0.00"
        Me.txtPreTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscAmt
        '
        Me.txtDiscAmt.AccessibleDescription = "0.00"
        Me.txtDiscAmt.AccessibleName = "discamt"
        Me.txtDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscAmt.Location = New System.Drawing.Point(816, 416)
        Me.txtDiscAmt.Name = "txtDiscAmt"
        Me.txtDiscAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtDiscAmt.TabIndex = 127
        Me.txtDiscAmt.Tag = ""
        Me.txtDiscAmt.Text = "0.00"
        Me.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(708, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Pre - Tax Amount"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(708, 419)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Discount Amount"
        '
        'grdDetails
        '
        Me.grdDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetails.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invord, Me.return_goods, Me.sono, Me.sonoid, Me.pono, Me.stk_in_no, Me.roll_cnt, Me.design_no, Me.col, Me.grade, Me.qty, Me.uom, Me.uprice, Me.lineamt, Me.linediscamt, Me.linenetamt, Me.exchange_rate, Me.cboCurrency})
        Me.grdDetails.Location = New System.Drawing.Point(7, 162)
        Me.grdDetails.Name = "grdDetails"
        Me.grdDetails.Size = New System.Drawing.Size(921, 212)
        Me.grdDetails.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Invoice No."
        '
        'txtpresent_status
        '
        Me.txtpresent_status.AccessibleName = "show_status"
        Me.txtpresent_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpresent_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtpresent_status.Location = New System.Drawing.Point(112, 68)
        Me.txtpresent_status.Name = "txtpresent_status"
        Me.txtpresent_status.ReadOnly = True
        Me.txtpresent_status.Size = New System.Drawing.Size(103, 20)
        Me.txtpresent_status.TabIndex = 113
        Me.txtpresent_status.Tag = ""
        Me.txtpresent_status.Text = "CANCELLED"
        '
        'btnLoadINV
        '
        Me.btnLoadINV.Image = CType(resources.GetObject("btnLoadINV.Image"), System.Drawing.Image)
        Me.btnLoadINV.Location = New System.Drawing.Point(135, 40)
        Me.btnLoadINV.Name = "btnLoadINV"
        Me.btnLoadINV.Size = New System.Drawing.Size(144, 24)
        Me.btnLoadINV.TabIndex = 143
        Me.btnLoadINV.Text = "&Load Original Invoice"
        Me.btnLoadINV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoadINV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Status"
        '
        'btnSearchInvNo
        '
        Me.btnSearchInvNo.Image = CType(resources.GetObject("btnSearchInvNo.Image"), System.Drawing.Image)
        Me.btnSearchInvNo.Location = New System.Drawing.Point(256, 17)
        Me.btnSearchInvNo.Name = "btnSearchInvNo"
        Me.btnSearchInvNo.Size = New System.Drawing.Size(27, 21)
        Me.btnSearchInvNo.TabIndex = 299
        Me.btnSearchInvNo.UseVisualStyleBackColor = True
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(83, 98)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(203, 21)
        Me.cboCustomer.TabIndex = 300
        '
        'cboinvno
        '
        Me.cboinvno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboinvno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboinvno.FormattingEnabled = True
        Me.cboinvno.Location = New System.Drawing.Point(135, 17)
        Me.cboinvno.Name = "cboinvno"
        Me.cboinvno.Size = New System.Drawing.Size(117, 21)
        Me.cboinvno.TabIndex = 302
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRefInv)
        Me.GroupBox1.Controls.Add(Me.cboinvno)
        Me.GroupBox1.Controls.Add(Me.rbNotRefInv)
        Me.GroupBox1.Controls.Add(Me.btnLoadINV)
        Me.GroupBox1.Controls.Add(Me.btnSearchInvNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 66)
        Me.GroupBox1.TabIndex = 303
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice Reference"
        '
        'rbRefInv
        '
        Me.rbRefInv.AutoSize = True
        Me.rbRefInv.Checked = True
        Me.rbRefInv.Location = New System.Drawing.Point(11, 19)
        Me.rbRefInv.Name = "rbRefInv"
        Me.rbRefInv.Size = New System.Drawing.Size(41, 17)
        Me.rbRefInv.TabIndex = 1
        Me.rbRefInv.TabStop = True
        Me.rbRefInv.Text = "Yes"
        Me.rbRefInv.UseVisualStyleBackColor = True
        '
        'rbNotRefInv
        '
        Me.rbNotRefInv.AutoSize = True
        Me.rbNotRefInv.Location = New System.Drawing.Point(11, 41)
        Me.rbNotRefInv.Name = "rbNotRefInv"
        Me.rbNotRefInv.Size = New System.Drawing.Size(40, 17)
        Me.rbNotRefInv.TabIndex = 0
        Me.rbNotRefInv.Text = "No"
        Me.rbNotRefInv.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cboInvtype)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtpresent_status)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtDbNoteNo)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.dtpDocDate)
        Me.GroupBox2.Location = New System.Drawing.Point(696, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 130)
        Me.GroupBox2.TabIndex = 304
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Document Info"
        '
        'cboInvtype
        '
        Me.cboInvtype.AccessibleName = "Invtype"
        Me.cboInvtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboInvtype.FormattingEnabled = True
        Me.cboInvtype.Location = New System.Drawing.Point(112, 94)
        Me.cboInvtype.Name = "cboInvtype"
        Me.cboInvtype.Size = New System.Drawing.Size(103, 21)
        Me.cboInvtype.TabIndex = 115
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 114
        Me.Label16.Text = "Invoice Type"
        '
        'cboSalesMan
        '
        Me.cboSalesMan.AccessibleName = "empcd"
        Me.cboSalesMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSalesMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSalesMan.FormattingEnabled = True
        Me.cboSalesMan.Location = New System.Drawing.Point(363, 43)
        Me.cboSalesMan.Name = "cboSalesMan"
        Me.cboSalesMan.Size = New System.Drawing.Size(168, 21)
        Me.cboSalesMan.TabIndex = 306
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(298, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 305
        Me.Label17.Text = "Sale Person"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnExchangeRate
        '
        Me.btnExchangeRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExchangeRate.Image = CType(resources.GetObject("btnExchangeRate.Image"), System.Drawing.Image)
        Me.btnExchangeRate.Location = New System.Drawing.Point(546, 116)
        Me.btnExchangeRate.Name = "btnExchangeRate"
        Me.btnExchangeRate.Size = New System.Drawing.Size(144, 40)
        Me.btnExchangeRate.TabIndex = 307
        Me.btnExchangeRate.Text = "&Input  Exchange Rate To All Items"
        Me.btnExchangeRate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExchangeRate.UseVisualStyleBackColor = True
        '
        'invord
        '
        Me.invord.DataPropertyName = "invord"
        Me.invord.HeaderText = "#"
        Me.invord.Name = "invord"
        Me.invord.Width = 20
        '
        'return_goods
        '
        Me.return_goods.DataPropertyName = "return_goods"
        Me.return_goods.HeaderText = "Return Goods"
        Me.return_goods.Name = "return_goods"
        Me.return_goods.Visible = False
        Me.return_goods.Width = 50
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        Me.sono.ReadOnly = True
        Me.sono.Visible = False
        Me.sono.Width = 60
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O Item No."
        Me.sonoid.Name = "sonoid"
        '
        'pono
        '
        Me.pono.DataPropertyName = "pono"
        Me.pono.HeaderText = "Customer P/O No."
        Me.pono.Name = "pono"
        '
        'stk_in_no
        '
        Me.stk_in_no.DataPropertyName = "stk_in_no"
        Me.stk_in_no.HeaderText = "Document No."
        Me.stk_in_no.Name = "stk_in_no"
        '
        'roll_cnt
        '
        Me.roll_cnt.DataPropertyName = "roll_cnt"
        Me.roll_cnt.HeaderText = "Rolls"
        Me.roll_cnt.Name = "roll_cnt"
        Me.roll_cnt.ReadOnly = True
        Me.roll_cnt.Visible = False
        Me.roll_cnt.Width = 50
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Charge Type"
        Me.design_no.Name = "design_no"
        Me.design_no.Width = 125
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Visible = False
        Me.col.Width = 50
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grade.DefaultCellStyle = DataGridViewCellStyle1
        Me.grade.HeaderText = "Gr"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Visible = False
        Me.grade.Width = 25
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "#.#0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.Width = 60
        '
        'uom
        '
        Me.uom.DataPropertyName = "uom_id"
        Me.uom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.uom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uom.HeaderText = "UOM"
        Me.uom.Name = "uom"
        Me.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.uom.Width = 50
        '
        'uprice
        '
        Me.uprice.DataPropertyName = "uprice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#.#0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.uprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.uprice.HeaderText = "Unit Price"
        Me.uprice.Name = "uprice"
        Me.uprice.Width = 75
        '
        'lineamt
        '
        Me.lineamt.DataPropertyName = "lineamt"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#.###0"
        Me.lineamt.DefaultCellStyle = DataGridViewCellStyle4
        Me.lineamt.HeaderText = "Amout"
        Me.lineamt.Name = "lineamt"
        Me.lineamt.ReadOnly = True
        '
        'linediscamt
        '
        Me.linediscamt.DataPropertyName = "linediscamt"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "#.###0"
        Me.linediscamt.DefaultCellStyle = DataGridViewCellStyle5
        Me.linediscamt.HeaderText = "Item Discount Amount"
        Me.linediscamt.Name = "linediscamt"
        Me.linediscamt.ReadOnly = True
        Me.linediscamt.Visible = False
        Me.linediscamt.Width = 65
        '
        'linenetamt
        '
        Me.linenetamt.DataPropertyName = "linenetamt"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "#.#0"
        Me.linenetamt.DefaultCellStyle = DataGridViewCellStyle6
        Me.linenetamt.HeaderText = "Item Net Amount"
        Me.linenetamt.Name = "linenetamt"
        Me.linenetamt.ReadOnly = True
        Me.linenetamt.Visible = False
        '
        'exchange_rate
        '
        Me.exchange_rate.DataPropertyName = "exchange_rate"
        Me.exchange_rate.HeaderText = "Exchange Rate"
        Me.exchange_rate.Name = "exchange_rate"
        Me.exchange_rate.Width = 75
        '
        'cboCurrency
        '
        Me.cboCurrency.DataPropertyName = "currency"
        Me.cboCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCurrency.HeaderText = "Currency"
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmDebitNoteExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 519)
        Me.Controls.Add(Me.btnExchangeRate)
        Me.Controls.Add(Me.cboSalesMan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGrossAmt)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtNetAmt)
        Me.Controls.Add(Me.txtVatAmt)
        Me.Controls.Add(Me.txtPreTaxAmt)
        Me.Controls.Add(Me.txtDiscAmt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.grdDetails)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDebitNoteExport"
        Me.Text = "Debit Note Export"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtDbNoteNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnApprove As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGrossAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtNetAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grdDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpresent_status As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadINV As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearchInvNo As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents cboinvno As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbRefInv As RadioButton
    Friend WithEvents rbNotRefInv As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboSalesMan As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cboInvtype As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnExchangeRate As Button
    Friend WithEvents invord As DataGridViewTextBoxColumn
    Friend WithEvents return_goods As DataGridViewCheckBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents pono As DataGridViewTextBoxColumn
    Friend WithEvents stk_in_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_cnt As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewComboBoxColumn
    Friend WithEvents uprice As DataGridViewTextBoxColumn
    Friend WithEvents lineamt As DataGridViewTextBoxColumn
    Friend WithEvents linediscamt As DataGridViewTextBoxColumn
    Friend WithEvents linenetamt As DataGridViewTextBoxColumn
    Friend WithEvents exchange_rate As DataGridViewTextBoxColumn
    Friend WithEvents cboCurrency As DataGridViewComboBoxColumn
End Class
