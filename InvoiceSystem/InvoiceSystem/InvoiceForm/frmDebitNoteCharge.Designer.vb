<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitNoteCharge
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitNoteCharge))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLoadStkIN = New System.Windows.Forms.Button()
        Me.btnLoadINV = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboStkINNo = New System.Windows.Forms.ComboBox()
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
        Me.cboReason3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboReason2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnApprove = New System.Windows.Forms.ToolStripButton()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.grdDetails = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboInvNo = New System.Windows.Forms.ComboBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboSalesMan = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnExchangeRate = New System.Windows.Forms.Button()
        Me.cboInvtype = New System.Windows.Forms.ComboBox()
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadStkIN
        '
        Me.btnLoadStkIN.Image = CType(resources.GetObject("btnLoadStkIN.Image"), System.Drawing.Image)
        Me.btnLoadStkIN.Location = New System.Drawing.Point(200, 160)
        Me.btnLoadStkIN.Name = "btnLoadStkIN"
        Me.btnLoadStkIN.Size = New System.Drawing.Size(144, 24)
        Me.btnLoadStkIN.TabIndex = 106
        Me.btnLoadStkIN.Text = "&Load Stock IN Items"
        Me.btnLoadStkIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoadStkIN.UseVisualStyleBackColor = True
        Me.btnLoadStkIN.Visible = False
        '
        'btnLoadINV
        '
        Me.btnLoadINV.Image = CType(resources.GetObject("btnLoadINV.Image"), System.Drawing.Image)
        Me.btnLoadINV.Location = New System.Drawing.Point(200, 32)
        Me.btnLoadINV.Name = "btnLoadINV"
        Me.btnLoadINV.Size = New System.Drawing.Size(144, 24)
        Me.btnLoadINV.TabIndex = 105
        Me.btnLoadINV.Text = "&Load Original Invoice"
        Me.btnLoadINV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoadINV.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Stock-IN No."
        Me.Label15.Visible = False
        '
        'cboStkINNo
        '
        Me.cboStkINNo.AccessibleDescription = ""
        Me.cboStkINNo.AccessibleName = ""
        Me.cboStkINNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStkINNo.FormattingEnabled = True
        Me.cboStkINNo.Location = New System.Drawing.Point(80, 160)
        Me.cboStkINNo.Name = "cboStkINNo"
        Me.cboStkINNo.Size = New System.Drawing.Size(112, 21)
        Me.cboStkINNo.TabIndex = 103
        Me.cboStkINNo.Tag = ""
        Me.cboStkINNo.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(718, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Gross Amount"
        '
        'txtGrossAmt
        '
        Me.txtGrossAmt.AccessibleDescription = "0.00"
        Me.txtGrossAmt.AccessibleName = "grossamt"
        Me.txtGrossAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrossAmt.Location = New System.Drawing.Point(814, 373)
        Me.txtGrossAmt.Name = "txtGrossAmt"
        Me.txtGrossAmt.ReadOnly = True
        Me.txtGrossAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtGrossAmt.TabIndex = 101
        Me.txtGrossAmt.Tag = ""
        Me.txtGrossAmt.Text = "0.00"
        Me.txtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRemarks
        '
        Me.txtRemarks.AccessibleName = "remarks"
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.Location = New System.Drawing.Point(8, 397)
        Me.txtRemarks.MaxLength = 255
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(702, 88)
        Me.txtRemarks.TabIndex = 96
        Me.txtRemarks.Tag = ""
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Remarks"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(718, 469)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Net Amount"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(790, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(718, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "VAT"
        '
        'txtVat
        '
        Me.txtVat.AccessibleDescription = "0.00"
        Me.txtVat.AccessibleName = "vat"
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.Location = New System.Drawing.Point(750, 445)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(32, 22)
        Me.txtVat.TabIndex = 91
        Me.txtVat.Tag = ""
        Me.txtVat.Text = "7.00"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmt
        '
        Me.txtNetAmt.AccessibleDescription = "0.00"
        Me.txtNetAmt.AccessibleName = "netamt"
        Me.txtNetAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetAmt.Location = New System.Drawing.Point(814, 469)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtNetAmt.TabIndex = 94
        Me.txtNetAmt.Tag = ""
        Me.txtNetAmt.Text = "0.00"
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatAmt
        '
        Me.txtVatAmt.AccessibleDescription = "0.00"
        Me.txtVatAmt.AccessibleName = "vatamt"
        Me.txtVatAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVatAmt.Location = New System.Drawing.Point(814, 445)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.ReadOnly = True
        Me.txtVatAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtVatAmt.TabIndex = 93
        Me.txtVatAmt.Tag = ""
        Me.txtVatAmt.Text = "0.00"
        Me.txtVatAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPreTaxAmt
        '
        Me.txtPreTaxAmt.AccessibleDescription = "0.00"
        Me.txtPreTaxAmt.AccessibleName = "pretaxamt"
        Me.txtPreTaxAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreTaxAmt.Location = New System.Drawing.Point(814, 421)
        Me.txtPreTaxAmt.Name = "txtPreTaxAmt"
        Me.txtPreTaxAmt.ReadOnly = True
        Me.txtPreTaxAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtPreTaxAmt.TabIndex = 90
        Me.txtPreTaxAmt.Tag = ""
        Me.txtPreTaxAmt.Text = "0.00"
        Me.txtPreTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscAmt
        '
        Me.txtDiscAmt.AccessibleDescription = "0.00"
        Me.txtDiscAmt.AccessibleName = "discamt"
        Me.txtDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscAmt.Location = New System.Drawing.Point(814, 397)
        Me.txtDiscAmt.Name = "txtDiscAmt"
        Me.txtDiscAmt.Size = New System.Drawing.Size(112, 22)
        Me.txtDiscAmt.TabIndex = 89
        Me.txtDiscAmt.Tag = ""
        Me.txtDiscAmt.Text = "0.00"
        Me.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(718, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Pre - Tax Amount"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(718, 397)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Discount Amount"
        '
        'cboReason3
        '
        Me.cboReason3.AccessibleDescription = "0"
        Me.cboReason3.AccessibleName = "dbnote_reason3"
        Me.cboReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReason3.FormattingEnabled = True
        Me.cboReason3.Location = New System.Drawing.Point(408, 184)
        Me.cboReason3.Name = "cboReason3"
        Me.cboReason3.Size = New System.Drawing.Size(168, 21)
        Me.cboReason3.TabIndex = 88
        Me.cboReason3.Tag = ""
        Me.cboReason3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Reason 3"
        Me.Label7.Visible = False
        '
        'cboReason2
        '
        Me.cboReason2.AccessibleDescription = "0"
        Me.cboReason2.AccessibleName = "dbnote_reason2"
        Me.cboReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReason2.FormattingEnabled = True
        Me.cboReason2.Location = New System.Drawing.Point(408, 160)
        Me.cboReason2.Name = "cboReason2"
        Me.cboReason2.Size = New System.Drawing.Size(168, 21)
        Me.cboReason2.TabIndex = 86
        Me.cboReason2.Tag = ""
        Me.cboReason2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Reason 2"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Reference"
        '
        'cboReason
        '
        Me.cboReason.AccessibleDescription = "0"
        Me.cboReason.AccessibleName = "dbnote_reason1"
        Me.cboReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReason.FormattingEnabled = True
        Me.cboReason.Location = New System.Drawing.Point(408, 136)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(168, 21)
        Me.cboReason.TabIndex = 83
        Me.cboReason.Tag = ""
        Me.cboReason.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Reason 1"
        Me.Label4.Visible = False
        '
        'txtReference
        '
        Me.txtReference.AccessibleName = "reference"
        Me.txtReference.Location = New System.Drawing.Point(80, 80)
        Me.txtReference.MaxLength = 100
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(264, 22)
        Me.txtReference.TabIndex = 81
        Me.txtReference.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Customer"
        '
        'dtpDocDate
        '
        Me.dtpDocDate.AccessibleName = "dbnote_date"
        Me.dtpDocDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDocDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDocDate.Location = New System.Drawing.Point(814, 56)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(112, 22)
        Me.dtpDocDate.TabIndex = 71
        Me.dtpDocDate.Tag = ""
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(724, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 13)
        Me.Label28.TabIndex = 73
        Me.Label28.Text = "Debit Note Date"
        '
        'btnApprove
        '
        Me.btnApprove.Image = CType(resources.GetObject("btnApprove.Image"), System.Drawing.Image)
        Me.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(72, 22)
        Me.btnApprove.Text = "Approve"
        '
        'txtDocNo
        '
        Me.txtDocNo.AccessibleName = "dbnote_no"
        Me.txtDocNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(814, 32)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(112, 20)
        Me.txtDocNo.TabIndex = 70
        Me.txtDocNo.Tag = ""
        Me.txtDocNo.Text = "CN-07050020"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(732, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(84, 13)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "Debit Note No."
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'cboDocNo
        '
        Me.cboDocNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(115, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnApprove, Me.btnCancel, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(937, 25)
        Me.ToolStrip1.TabIndex = 69
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel1.Text = "Debit Note No."
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
        'grdDetails
        '
        Me.grdDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDetails.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invord, Me.return_goods, Me.sono, Me.sonoid, Me.pono, Me.stk_in_no, Me.roll_cnt, Me.design_no, Me.col, Me.grade, Me.qty, Me.uom, Me.uprice, Me.lineamt, Me.linediscamt, Me.linenetamt, Me.exchange_rate, Me.cboCurrency})
        Me.grdDetails.Location = New System.Drawing.Point(8, 131)
        Me.grdDetails.Name = "grdDetails"
        Me.grdDetails.Size = New System.Drawing.Size(918, 234)
        Me.grdDetails.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Invoice No."
        '
        'cboInvNo
        '
        Me.cboInvNo.AccessibleDescription = ""
        Me.cboInvNo.AccessibleName = "invid"
        Me.cboInvNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvNo.FormattingEnabled = True
        Me.cboInvNo.Location = New System.Drawing.Point(80, 32)
        Me.cboInvNo.Name = "cboInvNo"
        Me.cboInvNo.Size = New System.Drawing.Size(112, 21)
        Me.cboInvNo.TabIndex = 76
        Me.cboInvNo.Tag = ""
        '
        'txtStatus
        '
        Me.txtStatus.AccessibleName = "show_status"
        Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(814, 80)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(112, 20)
        Me.txtStatus.TabIndex = 75
        Me.txtStatus.Tag = ""
        Me.txtStatus.Text = "CANCELLED"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(772, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Status"
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(80, 56)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(264, 21)
        Me.cboCustomer.TabIndex = 107
        '
        'cboSalesMan
        '
        Me.cboSalesMan.AccessibleName = "empcd"
        Me.cboSalesMan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSalesMan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSalesMan.FormattingEnabled = True
        Me.cboSalesMan.Location = New System.Drawing.Point(408, 32)
        Me.cboSalesMan.Name = "cboSalesMan"
        Me.cboSalesMan.Size = New System.Drawing.Size(160, 21)
        Me.cboSalesMan.TabIndex = 308
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(343, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 307
        Me.Label17.Text = "Sale Person"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(742, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 309
        Me.Label16.Text = "Invoice Type"
        '
        'btnExchangeRate
        '
        Me.btnExchangeRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExchangeRate.Image = CType(resources.GetObject("btnExchangeRate.Image"), System.Drawing.Image)
        Me.btnExchangeRate.Location = New System.Drawing.Point(566, 85)
        Me.btnExchangeRate.Name = "btnExchangeRate"
        Me.btnExchangeRate.Size = New System.Drawing.Size(144, 40)
        Me.btnExchangeRate.TabIndex = 311
        Me.btnExchangeRate.Text = "&Input  Exchange Rate To All Items"
        Me.btnExchangeRate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExchangeRate.UseVisualStyleBackColor = True
        '
        'cboInvtype
        '
        Me.cboInvtype.AccessibleName = "Invtype"
        Me.cboInvtype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvtype.FormattingEnabled = True
        Me.cboInvtype.Location = New System.Drawing.Point(814, 106)
        Me.cboInvtype.Name = "cboInvtype"
        Me.cboInvtype.Size = New System.Drawing.Size(111, 21)
        Me.cboInvtype.TabIndex = 312
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
        Me.cboCurrency.Width = 75
        '
        'frmDebitNoteCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 494)
        Me.Controls.Add(Me.cboInvtype)
        Me.Controls.Add(Me.btnExchangeRate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboSalesMan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cboCustomer)
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDocDate)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtDocNo)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboInvNo)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoadStkIN)
        Me.Controls.Add(Me.btnLoadINV)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboStkINNo)
        Me.Controls.Add(Me.cboReason3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboReason2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboReason)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDebitNoteCharge"
        Me.Text = "Debit Note Charge"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoadStkIN As System.Windows.Forms.Button
    Friend WithEvents btnLoadINV As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboStkINNo As System.Windows.Forms.ComboBox
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
    Friend WithEvents cboReason3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboReason2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReference As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnApprove As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboInvNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents cboSalesMan As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label16 As Label
    Friend WithEvents btnExchangeRate As Button
    Friend WithEvents cboInvtype As ComboBox
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
