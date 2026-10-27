<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceLocal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceLocal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mcboCustomersBillToFlag = New InvoiceSystemESH.Controls.MultiColumnComboBox()
        Me.cboorder_type = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTermCondition = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.dtpInvDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInvNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLocked = New System.Windows.Forms.Label()
        Me.grdInv = New System.Windows.Forms.DataGridView()
        Me.invord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.uprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.exchange_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linediscamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.linenetamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiscAmt = New System.Windows.Forms.TextBox()
        Me.txtPreTaxAmt = New System.Windows.Forms.TextBox()
        Me.txtVatAmt = New System.Windows.Forms.TextBox()
        Me.txtNetAmt = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboInvNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmnInvoiceTH = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnInvoiceTHStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnInvoiceTHNoPackingDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnInvoiceEN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnInvoiceENStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceENNoPackingDatail = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtGrossAmt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optStockY = New System.Windows.Forms.RadioButton()
        Me.optStockC = New System.Windows.Forms.RadioButton()
        Me.optStockD = New System.Windows.Forms.RadioButton()
        Me.optStockG = New System.Windows.Forms.RadioButton()
        Me.cboPackNo = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.txtSonoId = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtsono = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboUOM = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblSoNo = New System.Windows.Forms.Label()
        Me.lblCustPO = New System.Windows.Forms.Label()
        Me.txtCustPO = New System.Windows.Forms.TextBox()
        Me.txtUprice = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtItdesc = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnSpecialCharges = New System.Windows.Forms.Button()
        Me.txtChargeAmt = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtChargeIssue = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cboSalesMan = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.mcboCustomersShipToFlag = New InvoiceSystemESH.Controls.MultiColumnComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBankBranch = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBankCode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.mcboBanks = New InvoiceSystemESH.Controls.MultiColumnComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSearchPacking = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCustDesign = New System.Windows.Forms.TextBox()
        Me.BtnLoadCharge = New System.Windows.Forms.Button()
        Me.btnSearchInvNo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.mcboCustomersBillToFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.mcboCustomersShipToFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.mcboBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.mcboCustomersBillToFlag)
        Me.GroupBox1.Controls.Add(Me.cboorder_type)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtTermCondition)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Order Details"
        '
        'mcboCustomersBillToFlag
        '
        Me.mcboCustomersBillToFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcboCustomersBillToFlag.BeforeTouchSize = New System.Drawing.Size(726, 21)
        Me.mcboCustomersBillToFlag.Location = New System.Drawing.Point(107, 24)
        Me.mcboCustomersBillToFlag.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.mcboCustomersBillToFlag.Name = "mcboCustomersBillToFlag"
        Me.mcboCustomersBillToFlag.Size = New System.Drawing.Size(726, 21)
        Me.mcboCustomersBillToFlag.TabIndex = 37
        '
        'cboorder_type
        '
        Me.cboorder_type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboorder_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboorder_type.FormattingEnabled = True
        Me.cboorder_type.Location = New System.Drawing.Point(107, 71)
        Me.cboorder_type.Name = "cboorder_type"
        Me.cboorder_type.Size = New System.Drawing.Size(726, 21)
        Me.cboorder_type.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Order Type"
        '
        'txtTermCondition
        '
        Me.txtTermCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTermCondition.Location = New System.Drawing.Point(107, 48)
        Me.txtTermCondition.Name = "txtTermCondition"
        Me.txtTermCondition.ReadOnly = True
        Me.txtTermCondition.Size = New System.Drawing.Size(727, 22)
        Me.txtTermCondition.TabIndex = 5
        Me.txtTermCondition.Tag = "str"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Term Condition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnSearchInvNo)
        Me.GroupBox2.Controls.Add(Me.dtpInvDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtInvNo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(1055, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 116)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local Invoice"
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.BackColor = System.Drawing.Color.Transparent
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(1023, 166)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(168, 24)
        Me.lblCancelled.TabIndex = 29
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCancelled.Visible = False
        '
        'dtpInvDate
        '
        Me.dtpInvDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvDate.Location = New System.Drawing.Point(16, 88)
        Me.dtpInvDate.Name = "dtpInvDate"
        Me.dtpInvDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpInvDate.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Invoice Date"
        '
        'txtInvNo
        '
        Me.txtInvNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInvNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtInvNo.Location = New System.Drawing.Point(16, 38)
        Me.txtInvNo.Name = "txtInvNo"
        Me.txtInvNo.Size = New System.Drawing.Size(96, 20)
        Me.txtInvNo.TabIndex = 0
        Me.txtInvNo.Tag = "str"
        Me.txtInvNo.Text = "LI-07050020"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Invoice No."
        '
        'lblLocked
        '
        Me.lblLocked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLocked.ForeColor = System.Drawing.Color.Blue
        Me.lblLocked.Location = New System.Drawing.Point(1018, 204)
        Me.lblLocked.Name = "lblLocked"
        Me.lblLocked.Size = New System.Drawing.Size(168, 24)
        Me.lblLocked.TabIndex = 30
        Me.lblLocked.Text = "Locked"
        Me.lblLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLocked.Visible = False
        '
        'grdInv
        '
        Me.grdInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdInv.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invord, Me.pono, Me.sono, Me.sonoid, Me.design_no, Me.itdesc, Me.col, Me.grade, Me.qty, Me.uom, Me.uprice, Me.currency, Me.exchange_rate, Me.lineamt, Me.linediscamt, Me.linenetamt})
        Me.grdInv.Location = New System.Drawing.Point(6, 82)
        Me.grdInv.Name = "grdInv"
        Me.grdInv.Size = New System.Drawing.Size(977, 210)
        Me.grdInv.TabIndex = 7
        '
        'invord
        '
        Me.invord.DataPropertyName = "invord"
        Me.invord.HeaderText = "#"
        Me.invord.Name = "invord"
        Me.invord.Width = 20
        '
        'pono
        '
        Me.pono.DataPropertyName = "pono"
        Me.pono.HeaderText = "Customer P/O No."
        Me.pono.Name = "pono"
        Me.pono.Width = 60
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        Me.sono.Width = 60
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O Item No."
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Width = 70
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Code"
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 75
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 50
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grade.DefaultCellStyle = DataGridViewCellStyle7
        Me.grade.HeaderText = "Gr"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 25
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "#.#0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.qty.DefaultCellStyle = DataGridViewCellStyle8
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 50
        '
        'uom
        '
        Me.uom.DataPropertyName = "uom"
        Me.uom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.uom.HeaderText = "UOM"
        Me.uom.Name = "uom"
        Me.uom.ReadOnly = True
        Me.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.uom.Width = 50
        '
        'uprice
        '
        Me.uprice.DataPropertyName = "uprice"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "#.#0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.uprice.DefaultCellStyle = DataGridViewCellStyle9
        Me.uprice.HeaderText = "Unit Price"
        Me.uprice.Name = "uprice"
        Me.uprice.ReadOnly = True
        Me.uprice.Width = 50
        '
        'currency
        '
        Me.currency.DataPropertyName = "currency"
        Me.currency.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.currency.HeaderText = "Currency"
        Me.currency.Name = "currency"
        Me.currency.Width = 60
        '
        'exchange_rate
        '
        Me.exchange_rate.DataPropertyName = "exchange_rate"
        Me.exchange_rate.HeaderText = "Exchange Rate"
        Me.exchange_rate.Name = "exchange_rate"
        Me.exchange_rate.Width = 60
        '
        'lineamt
        '
        Me.lineamt.DataPropertyName = "lineamt"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "#.###0"
        Me.lineamt.DefaultCellStyle = DataGridViewCellStyle10
        Me.lineamt.HeaderText = "Amout"
        Me.lineamt.Name = "lineamt"
        Me.lineamt.ReadOnly = True
        Me.lineamt.Width = 65
        '
        'linediscamt
        '
        Me.linediscamt.DataPropertyName = "linediscamt"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "#.###0"
        Me.linediscamt.DefaultCellStyle = DataGridViewCellStyle11
        Me.linediscamt.HeaderText = "Item Discount Amount"
        Me.linediscamt.Name = "linediscamt"
        Me.linediscamt.ReadOnly = True
        Me.linediscamt.Width = 65
        '
        'linenetamt
        '
        Me.linenetamt.DataPropertyName = "linenetamt"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "#.###0"
        Me.linenetamt.DefaultCellStyle = DataGridViewCellStyle12
        Me.linenetamt.HeaderText = "Item Net Amount"
        Me.linenetamt.Name = "linenetamt"
        Me.linenetamt.ReadOnly = True
        Me.linenetamt.Width = 65
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(738, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Pre - Tax Amount"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(738, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Discount Amount"
        '
        'txtDiscAmt
        '
        Me.txtDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscAmt.Location = New System.Drawing.Point(834, 326)
        Me.txtDiscAmt.Name = "txtDiscAmt"
        Me.txtDiscAmt.Size = New System.Drawing.Size(148, 22)
        Me.txtDiscAmt.TabIndex = 8
        Me.txtDiscAmt.Tag = "int"
        Me.txtDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPreTaxAmt
        '
        Me.txtPreTaxAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreTaxAmt.Location = New System.Drawing.Point(834, 350)
        Me.txtPreTaxAmt.Name = "txtPreTaxAmt"
        Me.txtPreTaxAmt.ReadOnly = True
        Me.txtPreTaxAmt.Size = New System.Drawing.Size(148, 22)
        Me.txtPreTaxAmt.TabIndex = 9
        Me.txtPreTaxAmt.Tag = "int"
        Me.txtPreTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatAmt
        '
        Me.txtVatAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVatAmt.Location = New System.Drawing.Point(834, 374)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.ReadOnly = True
        Me.txtVatAmt.Size = New System.Drawing.Size(148, 22)
        Me.txtVatAmt.TabIndex = 11
        Me.txtVatAmt.Tag = "int"
        Me.txtVatAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmt
        '
        Me.txtNetAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNetAmt.Location = New System.Drawing.Point(834, 398)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.ReadOnly = True
        Me.txtNetAmt.Size = New System.Drawing.Size(148, 22)
        Me.txtNetAmt.TabIndex = 12
        Me.txtNetAmt.Tag = "int"
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVat
        '
        Me.txtVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVat.Location = New System.Drawing.Point(770, 374)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(32, 22)
        Me.txtVat.TabIndex = 10
        Me.txtVat.Tag = "int"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(738, 374)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "VAT"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(810, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(738, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Net Amount"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(62, 299)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(670, 134)
        Me.txtRemark.TabIndex = 13
        Me.txtRemark.Tag = "str"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboInvNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1206, 25)
        Me.ToolStrip1.TabIndex = 14
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel1.Text = "Invoice No."
        '
        'cboInvNo
        '
        Me.cboInvNo.Name = "cboInvNo"
        Me.cboInvNo.Size = New System.Drawing.Size(100, 25)
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
        Me.btnPrint.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnInvoiceTH, Me.tsmnInvoiceEN})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsmnInvoiceTH
        '
        Me.tsmnInvoiceTH.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnInvoiceTHStandard, Me.tsmnInvoiceTHNoPackingDetail})
        Me.tsmnInvoiceTH.Name = "tsmnInvoiceTH"
        Me.tsmnInvoiceTH.Size = New System.Drawing.Size(131, 22)
        Me.tsmnInvoiceTH.Text = "Invoice TH"
        '
        'tsmnInvoiceTHStandard
        '
        Me.tsmnInvoiceTHStandard.Name = "tsmnInvoiceTHStandard"
        Me.tsmnInvoiceTHStandard.Size = New System.Drawing.Size(228, 22)
        Me.tsmnInvoiceTHStandard.Text = "Invoice TH Standard"
        '
        'tsmnInvoiceTHNoPackingDetail
        '
        Me.tsmnInvoiceTHNoPackingDetail.Name = "tsmnInvoiceTHNoPackingDetail"
        Me.tsmnInvoiceTHNoPackingDetail.Size = New System.Drawing.Size(228, 22)
        Me.tsmnInvoiceTHNoPackingDetail.Text = "Invoice TH No Packing Detail"
        '
        'tsmnInvoiceEN
        '
        Me.tsmnInvoiceEN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnInvoiceENStandard, Me.InvoiceENNoPackingDatail})
        Me.tsmnInvoiceEN.Name = "tsmnInvoiceEN"
        Me.tsmnInvoiceEN.Size = New System.Drawing.Size(131, 22)
        Me.tsmnInvoiceEN.Text = "Invoice EN"
        '
        'tsmnInvoiceENStandard
        '
        Me.tsmnInvoiceENStandard.Name = "tsmnInvoiceENStandard"
        Me.tsmnInvoiceENStandard.Size = New System.Drawing.Size(227, 22)
        Me.tsmnInvoiceENStandard.Text = "Invoice EN Standard"
        '
        'InvoiceENNoPackingDatail
        '
        Me.InvoiceENNoPackingDatail.Name = "InvoiceENNoPackingDatail"
        Me.InvoiceENNoPackingDatail.Size = New System.Drawing.Size(227, 22)
        Me.InvoiceENNoPackingDatail.Text = "Invoice EN No Packing Datail"
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripLabel2.Text = "** Don't Show S/O Closed"
        '
        'txtGrossAmt
        '
        Me.txtGrossAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrossAmt.Location = New System.Drawing.Point(834, 302)
        Me.txtGrossAmt.Name = "txtGrossAmt"
        Me.txtGrossAmt.ReadOnly = True
        Me.txtGrossAmt.Size = New System.Drawing.Size(148, 22)
        Me.txtGrossAmt.TabIndex = 27
        Me.txtGrossAmt.Tag = "int"
        Me.txtGrossAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(738, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Gross Amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(496, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(257, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "ไม่แสดง Pack + Cartno ที่ทำ Invoice แล้ว  "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(498, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "**ถ้า Qty = 0 ให้ไปกำหนดที่ SO Item ***"
        '
        'optStockY
        '
        Me.optStockY.AutoSize = True
        Me.optStockY.Location = New System.Drawing.Point(179, 11)
        Me.optStockY.Name = "optStockY"
        Me.optStockY.Size = New System.Drawing.Size(46, 17)
        Me.optStockY.TabIndex = 10
        Me.optStockY.Text = "StkY"
        Me.optStockY.UseVisualStyleBackColor = True
        '
        'optStockC
        '
        Me.optStockC.AutoSize = True
        Me.optStockC.Location = New System.Drawing.Point(123, 11)
        Me.optStockC.Name = "optStockC"
        Me.optStockC.Size = New System.Drawing.Size(48, 17)
        Me.optStockC.TabIndex = 8
        Me.optStockC.Text = "StkC"
        Me.optStockC.UseVisualStyleBackColor = True
        '
        'optStockD
        '
        Me.optStockD.AutoSize = True
        Me.optStockD.Location = New System.Drawing.Point(67, 11)
        Me.optStockD.Name = "optStockD"
        Me.optStockD.Size = New System.Drawing.Size(49, 17)
        Me.optStockD.TabIndex = 7
        Me.optStockD.Text = "StkD"
        Me.optStockD.UseVisualStyleBackColor = True
        '
        'optStockG
        '
        Me.optStockG.AutoSize = True
        Me.optStockG.Checked = True
        Me.optStockG.Location = New System.Drawing.Point(11, 11)
        Me.optStockG.Name = "optStockG"
        Me.optStockG.Size = New System.Drawing.Size(49, 17)
        Me.optStockG.TabIndex = 6
        Me.optStockG.TabStop = True
        Me.optStockG.Text = "StkG"
        Me.optStockG.UseVisualStyleBackColor = True
        '
        'cboPackNo
        '
        Me.cboPackNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPackNo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPackNo.FormattingEnabled = True
        Me.cboPackNo.Location = New System.Drawing.Point(231, 7)
        Me.cboPackNo.Name = "cboPackNo"
        Me.cboPackNo.Size = New System.Drawing.Size(180, 24)
        Me.cboPackNo.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 13)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Aricle No."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(11, 22)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(87, 22)
        Me.txtDesignNo.TabIndex = 69
        Me.txtDesignNo.Tag = "str"
        '
        'txtSonoId
        '
        Me.txtSonoId.Location = New System.Drawing.Point(747, 19)
        Me.txtSonoId.Name = "txtSonoId"
        Me.txtSonoId.Size = New System.Drawing.Size(91, 22)
        Me.txtSonoId.TabIndex = 68
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(744, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "S/O Item No."
        '
        'txtsono
        '
        Me.txtsono.Location = New System.Drawing.Point(646, 19)
        Me.txtsono.Name = "txtsono"
        Me.txtsono.Size = New System.Drawing.Size(92, 22)
        Me.txtsono.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(432, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "UOM"
        '
        'cboUOM
        '
        Me.cboUOM.FormattingEnabled = True
        Me.cboUOM.Location = New System.Drawing.Point(435, 20)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Size = New System.Drawing.Size(55, 21)
        Me.cboUOM.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Qty."
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(392, 20)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(37, 22)
        Me.txtqty.TabIndex = 63
        '
        'lblSoNo
        '
        Me.lblSoNo.AutoSize = True
        Me.lblSoNo.Location = New System.Drawing.Point(643, 3)
        Me.lblSoNo.Name = "lblSoNo"
        Me.lblSoNo.Size = New System.Drawing.Size(47, 13)
        Me.lblSoNo.TabIndex = 62
        Me.lblSoNo.Text = "S/O No."
        '
        'lblCustPO
        '
        Me.lblCustPO.AutoSize = True
        Me.lblCustPO.Location = New System.Drawing.Point(552, 3)
        Me.lblCustPO.Name = "lblCustPO"
        Me.lblCustPO.Size = New System.Drawing.Size(52, 13)
        Me.lblCustPO.TabIndex = 61
        Me.lblCustPO.Text = "Cust P/O"
        '
        'txtCustPO
        '
        Me.txtCustPO.Location = New System.Drawing.Point(555, 19)
        Me.txtCustPO.Name = "txtCustPO"
        Me.txtCustPO.Size = New System.Drawing.Size(85, 22)
        Me.txtCustPO.TabIndex = 60
        '
        'txtUprice
        '
        Me.txtUprice.Location = New System.Drawing.Point(496, 19)
        Me.txtUprice.Name = "txtUprice"
        Me.txtUprice.Size = New System.Drawing.Size(53, 22)
        Me.txtUprice.TabIndex = 2
        Me.txtUprice.Tag = "int"
        Me.txtUprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(493, 3)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Unti Price"
        '
        'txtItdesc
        '
        Me.txtItdesc.Location = New System.Drawing.Point(104, 22)
        Me.txtItdesc.Name = "txtItdesc"
        Me.txtItdesc.Size = New System.Drawing.Size(92, 22)
        Me.txtItdesc.TabIndex = 1
        Me.txtItdesc.Tag = "str"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(106, 6)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Descpition"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 478)
        Me.TabControl1.TabIndex = 52
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(996, 452)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Invoice Info."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSpecialCharges)
        Me.GroupBox5.Controls.Add(Me.txtChargeAmt)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.txtChargeIssue)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 347)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(449, 72)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Charge"
        '
        'btnSpecialCharges
        '
        Me.btnSpecialCharges.Location = New System.Drawing.Point(200, 45)
        Me.btnSpecialCharges.Name = "btnSpecialCharges"
        Me.btnSpecialCharges.Size = New System.Drawing.Size(112, 24)
        Me.btnSpecialCharges.TabIndex = 31
        Me.btnSpecialCharges.Text = "Special Charges"
        Me.btnSpecialCharges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSpecialCharges.UseVisualStyleBackColor = True
        '
        'txtChargeAmt
        '
        Me.txtChargeAmt.Location = New System.Drawing.Point(80, 48)
        Me.txtChargeAmt.Name = "txtChargeAmt"
        Me.txtChargeAmt.Size = New System.Drawing.Size(88, 22)
        Me.txtChargeAmt.TabIndex = 2
        Me.txtChargeAmt.Tag = "int"
        Me.txtChargeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 13)
        Me.Label30.TabIndex = 30
        Me.Label30.Text = "Amount"
        '
        'txtChargeIssue
        '
        Me.txtChargeIssue.Location = New System.Drawing.Point(80, 24)
        Me.txtChargeIssue.Name = "txtChargeIssue"
        Me.txtChargeIssue.Size = New System.Drawing.Size(363, 22)
        Me.txtChargeIssue.TabIndex = 1
        Me.txtChargeIssue.Tag = "str"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 13)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Issue Text"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.cboSalesMan)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 174)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(845, 46)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sale "
        '
        'cboSalesMan
        '
        Me.cboSalesMan.BackColor = System.Drawing.Color.Gold
        Me.cboSalesMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSalesMan.FormattingEnabled = True
        Me.cboSalesMan.Location = New System.Drawing.Point(110, 19)
        Me.cboSalesMan.Name = "cboSalesMan"
        Me.cboSalesMan.Size = New System.Drawing.Size(231, 21)
        Me.cboSalesMan.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Sales person (C/S)"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.mcboCustomersShipToFlag)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 124)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(842, 50)
        Me.GroupBox7.TabIndex = 54
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Delivery Detail"
        '
        'mcboCustomersShipToFlag
        '
        Me.mcboCustomersShipToFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcboCustomersShipToFlag.BeforeTouchSize = New System.Drawing.Size(757, 21)
        Me.mcboCustomersShipToFlag.Location = New System.Drawing.Point(77, 18)
        Me.mcboCustomersShipToFlag.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.mcboCustomersShipToFlag.Name = "mcboCustomersShipToFlag"
        Me.mcboCustomersShipToFlag.Size = New System.Drawing.Size(757, 21)
        Me.mcboCustomersShipToFlag.TabIndex = 48
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Delivery To"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtBankBranch)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtBankName)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtBankCode)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label68)
        Me.GroupBox4.Controls.Add(Me.mcboBanks)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 226)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(842, 115)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payments"
        '
        'txtBankBranch
        '
        Me.txtBankBranch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBankBranch.Location = New System.Drawing.Point(399, 48)
        Me.txtBankBranch.Name = "txtBankBranch"
        Me.txtBankBranch.ReadOnly = True
        Me.txtBankBranch.Size = New System.Drawing.Size(437, 22)
        Me.txtBankBranch.TabIndex = 58
        Me.txtBankBranch.Tag = "str"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(320, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Bank Branch"
        '
        'txtBankName
        '
        Me.txtBankName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBankName.Location = New System.Drawing.Point(80, 77)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.Size = New System.Drawing.Size(756, 22)
        Me.txtBankName.TabIndex = 56
        Me.txtBankName.Tag = "str"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Bank Name"
        '
        'txtBankCode
        '
        Me.txtBankCode.Location = New System.Drawing.Point(80, 48)
        Me.txtBankCode.Name = "txtBankCode"
        Me.txtBankCode.ReadOnly = True
        Me.txtBankCode.Size = New System.Drawing.Size(218, 22)
        Me.txtBankCode.TabIndex = 54
        Me.txtBankCode.Tag = "str"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Bank Code"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(9, 25)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(33, 13)
        Me.Label68.TabIndex = 52
        Me.Label68.Text = "Bank"
        '
        'mcboBanks
        '
        Me.mcboBanks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcboBanks.BeforeTouchSize = New System.Drawing.Size(757, 21)
        Me.mcboBanks.Location = New System.Drawing.Point(80, 17)
        Me.mcboBanks.MetroColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.mcboBanks.Name = "mcboBanks"
        Me.mcboBanks.Size = New System.Drawing.Size(757, 21)
        Me.mcboBanks.TabIndex = 51
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Controls.Add(Me.grdInv)
        Me.TabPage2.Controls.Add(Me.txtRemark)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtGrossAmt)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtDiscAmt)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtPreTaxAmt)
        Me.TabPage2.Controls.Add(Me.txtVat)
        Me.TabPage2.Controls.Add(Me.txtVatAmt)
        Me.TabPage2.Controls.Add(Me.txtNetAmt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(977, 452)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Item Info."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 10)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(976, 70)
        Me.TabControl2.TabIndex = 51
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.cboPackNo)
        Me.TabPage3.Controls.Add(Me.btnLoad)
        Me.TabPage3.Controls.Add(Me.optStockG)
        Me.TabPage3.Controls.Add(Me.optStockY)
        Me.TabPage3.Controls.Add(Me.optStockD)
        Me.TabPage3.Controls.Add(Me.optStockC)
        Me.TabPage3.Controls.Add(Me.btnSearchPacking)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(968, 41)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Load Packing (UOM from S/O)"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Location = New System.Drawing.Point(417, 7)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(32, 24)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSearchPacking
        '
        Me.btnSearchPacking.Image = CType(resources.GetObject("btnSearchPacking.Image"), System.Drawing.Image)
        Me.btnSearchPacking.Location = New System.Drawing.Point(449, 7)
        Me.btnSearchPacking.Name = "btnSearchPacking"
        Me.btnSearchPacking.Size = New System.Drawing.Size(32, 24)
        Me.btnSearchPacking.TabIndex = 9
        Me.btnSearchPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchPacking.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.txtGrade)
        Me.TabPage4.Controls.Add(Me.lblSoNo)
        Me.TabPage4.Controls.Add(Me.txtCustPO)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.lblCustPO)
        Me.TabPage4.Controls.Add(Me.txtsono)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.txtSonoId)
        Me.TabPage4.Controls.Add(Me.txtCol)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.txtItdesc)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.txtCustDesign)
        Me.TabPage4.Controls.Add(Me.txtUprice)
        Me.TabPage4.Controls.Add(Me.txtqty)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.txtDesignNo)
        Me.TabPage4.Controls.Add(Me.cboUOM)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.BtnLoadCharge)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(968, 41)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Load Manual (Charge & Issue)"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(821, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(139, 13)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "เลือกข้อมูลก่อนกด Add"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(351, 20)
        Me.txtGrade.MaxLength = 3
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(35, 22)
        Me.txtGrade.TabIndex = 78
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(348, 2)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 13)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "Grade"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(272, 3)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 76
        Me.Label25.Text = "Colors Code"
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(275, 21)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(70, 22)
        Me.txtCol.TabIndex = 75
        Me.txtCol.Tag = "str"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(200, 3)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Cust Design"
        '
        'txtCustDesign
        '
        Me.txtCustDesign.Location = New System.Drawing.Point(202, 21)
        Me.txtCustDesign.Name = "txtCustDesign"
        Me.txtCustDesign.Size = New System.Drawing.Size(67, 22)
        Me.txtCustDesign.TabIndex = 73
        Me.txtCustDesign.Tag = "str"
        '
        'BtnLoadCharge
        '
        Me.BtnLoadCharge.Image = Global.InvoiceSystemESH.My.Resources.Resources.ASX_Download_blue_16x
        Me.BtnLoadCharge.Location = New System.Drawing.Point(867, 17)
        Me.BtnLoadCharge.Name = "BtnLoadCharge"
        Me.BtnLoadCharge.Size = New System.Drawing.Size(95, 27)
        Me.BtnLoadCharge.TabIndex = 31
        Me.BtnLoadCharge.Text = "Add Inv Line"
        Me.BtnLoadCharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLoadCharge.UseVisualStyleBackColor = True
        '
        'btnSearchInvNo
        '
        Me.btnSearchInvNo.Image = Global.InvoiceSystemESH.My.Resources.Resources.Search_16x
        Me.btnSearchInvNo.Location = New System.Drawing.Point(116, 37)
        Me.btnSearchInvNo.Name = "btnSearchInvNo"
        Me.btnSearchInvNo.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchInvNo.TabIndex = 10
        Me.btnSearchInvNo.UseVisualStyleBackColor = True
        '
        'frmInvoiceLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 522)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblLocked)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInvoiceLocal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Local Invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.mcboCustomersBillToFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.mcboCustomersShipToFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.mcboBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTermCondition As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpInvDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtInvNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiscAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtPreTaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtNetAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents cboInvNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdInv As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtGrossAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents cboPackNo As System.Windows.Forms.ComboBox
    Friend WithEvents optStockC As System.Windows.Forms.RadioButton
    Friend WithEvents optStockD As System.Windows.Forms.RadioButton
    Friend WithEvents optStockG As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearchPacking As System.Windows.Forms.Button
    Friend WithEvents lblLocked As System.Windows.Forms.Label
    Friend WithEvents optStockY As System.Windows.Forms.RadioButton
    Friend WithEvents txtUprice As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtItdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BtnLoadCharge As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents lblSoNo As System.Windows.Forms.Label
    Friend WithEvents lblCustPO As System.Windows.Forms.Label
    Friend WithEvents txtCustPO As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cboorder_type As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtBankBranch As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBankCode As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents mcboBanks As InvoiceSystemESH.Controls.MultiColumnComboBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents mcboCustomersShipToFlag As InvoiceSystemESH.Controls.MultiColumnComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents cboSalesMan As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents mcboCustomersBillToFlag As InvoiceSystemESH.Controls.MultiColumnComboBox
    Friend WithEvents txtsono As TextBox
    Friend WithEvents txtSonoId As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtCol As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCustDesign As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnSpecialCharges As Button
    Friend WithEvents txtChargeAmt As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtChargeIssue As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsmnInvoiceTH As ToolStripMenuItem
    Friend WithEvents tsmnInvoiceTHStandard As ToolStripMenuItem
    Friend WithEvents tsmnInvoiceTHNoPackingDetail As ToolStripMenuItem
    Friend WithEvents tsmnInvoiceEN As ToolStripMenuItem
    Friend WithEvents tsmnInvoiceENStandard As ToolStripMenuItem
    Friend WithEvents InvoiceENNoPackingDatail As ToolStripMenuItem
    Friend WithEvents invord As DataGridViewTextBoxColumn
    Friend WithEvents pono As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents itdesc As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewComboBoxColumn
    Friend WithEvents uprice As DataGridViewTextBoxColumn
    Friend WithEvents currency As DataGridViewComboBoxColumn
    Friend WithEvents exchange_rate As DataGridViewTextBoxColumn
    Friend WithEvents lineamt As DataGridViewTextBoxColumn
    Friend WithEvents linediscamt As DataGridViewTextBoxColumn
    Friend WithEvents linenetamt As DataGridViewTextBoxColumn
    Friend WithEvents btnSearchInvNo As Button
End Class
