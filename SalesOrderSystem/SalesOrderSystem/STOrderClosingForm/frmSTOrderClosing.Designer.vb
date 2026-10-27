<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSTOrderClosing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTOrderClosing))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.chkClose = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboSalesPerson1 = New Classes.comboSalesPerson()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustmer = New System.Windows.Forms.TextBox()
        Me.txtSTNO = New System.Windows.Forms.TextBox()
        Me.txtArticle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSTClose = New System.Windows.Forms.DataGridView()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sodt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESIGN_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTICLE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST_QTY_KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KI_KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KI_BAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SO_QTY_KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.st_bal_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUST_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.closed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sales_person_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.so_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvKnitting = New System.Windows.Forms.DataGridView()
        Me.KIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KIKO_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K_DESIGN_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KNITTING_KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.K_GIN_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KOCLOSED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.KOCLOSEDDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvGreige = New System.Windows.Forms.DataGridView()
        Me.G_SONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MACHINE_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OH_KG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmnKnittingOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnSOApplied = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnSOAppliedBySTNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnSOAppliedByDesignNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnSOAppliedBySales = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.tstripStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslDataBaseName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvSOApplied = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGetKnittingDesign = New System.Windows.Forms.Button()
        Me.txtKnittingDesign = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SO_SONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SO_SODT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_cUSTOMER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_DESIGN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.so_color_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S_UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOQTYKG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.so_closed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSTClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKnitting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGreige, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tstripStatus.SuspendLayout()
        CType(Me.dgvSOApplied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOpen)
        Me.GroupBox1.Controls.Add(Me.chkClose)
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 77)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Status"
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Checked = True
        Me.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpen.Location = New System.Drawing.Point(27, 18)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(55, 17)
        Me.chkOpen.TabIndex = 9
        Me.chkOpen.Text = "Open"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'chkClose
        '
        Me.chkClose.AutoCheck = False
        Me.chkClose.AutoSize = True
        Me.chkClose.Location = New System.Drawing.Point(27, 37)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(54, 17)
        Me.chkClose.TabIndex = 2
        Me.chkClose.Text = "Close"
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoCheck = False
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(27, 55)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(39, 17)
        Me.chkAll.TabIndex = 10
        Me.chkAll.Text = "All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(301, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "SALE:"
        '
        'ComboSalesPerson1
        '
        Me.ComboSalesPerson1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSalesPerson1.FormattingEnabled = True
        Me.ComboSalesPerson1.Location = New System.Drawing.Point(382, 72)
        Me.ComboSalesPerson1.Name = "ComboSalesPerson1"
        Me.ComboSalesPerson1.Size = New System.Drawing.Size(114, 21)
        Me.ComboSalesPerson1.TabIndex = 12
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(870, 21)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 11
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Customer"
        '
        'txtCustmer
        '
        Me.txtCustmer.Location = New System.Drawing.Point(382, 19)
        Me.txtCustmer.Name = "txtCustmer"
        Me.txtCustmer.Size = New System.Drawing.Size(79, 22)
        Me.txtCustmer.TabIndex = 5
        '
        'txtSTNO
        '
        Me.txtSTNO.Location = New System.Drawing.Point(382, 45)
        Me.txtSTNO.Name = "txtSTNO"
        Me.txtSTNO.Size = New System.Drawing.Size(114, 22)
        Me.txtSTNO.TabIndex = 4
        '
        'txtArticle
        '
        Me.txtArticle.Location = New System.Drawing.Point(133, 71)
        Me.txtArticle.Name = "txtArticle"
        Me.txtArticle.Size = New System.Drawing.Size(119, 22)
        Me.txtArticle.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ST NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Article"
        '
        'dgvSTClose
        '
        Me.dgvSTClose.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sono, Me.sodt, Me.DESIGN_NO, Me.ARTICLE_NAME, Me.color_name, Me.ST_QTY, Me.UOM, Me.ST_QTY_KG, Me.KI_KG, Me.KI_BAL, Me.SO_QTY_KG, Me.st_bal_kg, Me.CUST_NAME, Me.closed, Me.sales_person_code, Me.so_line_id})
        Me.dgvSTClose.Location = New System.Drawing.Point(12, 129)
        Me.dgvSTClose.Name = "dgvSTClose"
        Me.dgvSTClose.Size = New System.Drawing.Size(1293, 266)
        Me.dgvSTClose.TabIndex = 2
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "STNO"
        Me.sono.Name = "sono"
        Me.sono.ReadOnly = True
        Me.sono.Width = 70
        '
        'sodt
        '
        Me.sodt.DataPropertyName = "sodt"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.sodt.DefaultCellStyle = DataGridViewCellStyle1
        Me.sodt.HeaderText = "STDATE"
        Me.sodt.Name = "sodt"
        Me.sodt.ReadOnly = True
        Me.sodt.Width = 80
        '
        'DESIGN_NO
        '
        Me.DESIGN_NO.DataPropertyName = "design_no"
        Me.DESIGN_NO.HeaderText = "DESIGN NO"
        Me.DESIGN_NO.Name = "DESIGN_NO"
        Me.DESIGN_NO.ReadOnly = True
        '
        'ARTICLE_NAME
        '
        Me.ARTICLE_NAME.DataPropertyName = "article_name"
        Me.ARTICLE_NAME.HeaderText = "ARTICLE NAME"
        Me.ARTICLE_NAME.Name = "ARTICLE_NAME"
        Me.ARTICLE_NAME.ReadOnly = True
        '
        'color_name
        '
        Me.color_name.DataPropertyName = "color_name"
        Me.color_name.HeaderText = "COLOR"
        Me.color_name.Name = "color_name"
        Me.color_name.Width = 70
        '
        'ST_QTY
        '
        Me.ST_QTY.DataPropertyName = "st_qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ST_QTY.DefaultCellStyle = DataGridViewCellStyle2
        Me.ST_QTY.HeaderText = "ST QTY"
        Me.ST_QTY.Name = "ST_QTY"
        Me.ST_QTY.ReadOnly = True
        Me.ST_QTY.Width = 60
        '
        'UOM
        '
        Me.UOM.DataPropertyName = "uom"
        Me.UOM.HeaderText = "UOM"
        Me.UOM.Name = "UOM"
        Me.UOM.ReadOnly = True
        Me.UOM.Width = 50
        '
        'ST_QTY_KG
        '
        Me.ST_QTY_KG.DataPropertyName = "st_qty_kg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ST_QTY_KG.DefaultCellStyle = DataGridViewCellStyle3
        Me.ST_QTY_KG.HeaderText = "ST QTY KG"
        Me.ST_QTY_KG.Name = "ST_QTY_KG"
        Me.ST_QTY_KG.ReadOnly = True
        Me.ST_QTY_KG.Width = 70
        '
        'KI_KG
        '
        Me.KI_KG.DataPropertyName = "knitting_qty"
        Me.KI_KG.HeaderText = "KI OPENED"
        Me.KI_KG.Name = "KI_KG"
        Me.KI_KG.Width = 80
        '
        'KI_BAL
        '
        Me.KI_BAL.DataPropertyName = "KO_BAL_KG"
        Me.KI_BAL.HeaderText = "KI_BAL"
        Me.KI_BAL.Name = "KI_BAL"
        Me.KI_BAL.Width = 80
        '
        'SO_QTY_KG
        '
        Me.SO_QTY_KG.DataPropertyName = "SO_QTY_KG"
        Me.SO_QTY_KG.HeaderText = "SO APPLIED KG"
        Me.SO_QTY_KG.Name = "SO_QTY_KG"
        Me.SO_QTY_KG.Width = 80
        '
        'st_bal_kg
        '
        Me.st_bal_kg.DataPropertyName = "st_bal_kg"
        Me.st_bal_kg.HeaderText = "ST BAL KG"
        Me.st_bal_kg.Name = "st_bal_kg"
        Me.st_bal_kg.Width = 70
        '
        'CUST_NAME
        '
        Me.CUST_NAME.DataPropertyName = "cust_name"
        Me.CUST_NAME.HeaderText = "CUST NAME"
        Me.CUST_NAME.Name = "CUST_NAME"
        Me.CUST_NAME.ReadOnly = True
        '
        'closed
        '
        Me.closed.DataPropertyName = "closed"
        Me.closed.HeaderText = "CLOSE"
        Me.closed.Name = "closed"
        Me.closed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.closed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.closed.Width = 50
        '
        'sales_person_code
        '
        Me.sales_person_code.DataPropertyName = "_person_code"
        Me.sales_person_code.HeaderText = "Sales"
        Me.sales_person_code.Name = "sales_person_code"
        '
        'so_line_id
        '
        Me.so_line_id.DataPropertyName = "so_line_id"
        Me.so_line_id.HeaderText = "so_line_id"
        Me.so_line_id.Name = "so_line_id"
        Me.so_line_id.Visible = False
        '
        'dgvKnitting
        '
        Me.dgvKnitting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvKnitting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKnitting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KIKO, Me.KIKO_DT, Me.K_DESIGN_NO, Me.KNITTING_KG, Me.K_GIN_QTY, Me.KOCLOSED, Me.KOCLOSEDDT, Me.BOM})
        Me.dgvKnitting.Location = New System.Drawing.Point(6, 24)
        Me.dgvKnitting.Name = "dgvKnitting"
        Me.dgvKnitting.ReadOnly = True
        Me.dgvKnitting.Size = New System.Drawing.Size(928, 104)
        Me.dgvKnitting.TabIndex = 3
        '
        'KIKO
        '
        Me.KIKO.DataPropertyName = "KONO"
        Me.KIKO.HeaderText = "KI/KO"
        Me.KIKO.Name = "KIKO"
        Me.KIKO.ReadOnly = True
        Me.KIKO.Width = 60
        '
        'KIKO_DT
        '
        Me.KIKO_DT.DataPropertyName = "KO_DATE"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.KIKO_DT.DefaultCellStyle = DataGridViewCellStyle4
        Me.KIKO_DT.HeaderText = "KI/KO DATE"
        Me.KIKO_DT.Name = "KIKO_DT"
        Me.KIKO_DT.ReadOnly = True
        Me.KIKO_DT.Width = 89
        '
        'K_DESIGN_NO
        '
        Me.K_DESIGN_NO.DataPropertyName = "DESIGN_NO"
        Me.K_DESIGN_NO.HeaderText = "DESIGN NO"
        Me.K_DESIGN_NO.Name = "K_DESIGN_NO"
        Me.K_DESIGN_NO.ReadOnly = True
        Me.K_DESIGN_NO.Width = 91
        '
        'KNITTING_KG
        '
        Me.KNITTING_KG.DataPropertyName = "KNITTING_QTY"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.KNITTING_KG.DefaultCellStyle = DataGridViewCellStyle5
        Me.KNITTING_KG.HeaderText = "KNITTING KG"
        Me.KNITTING_KG.Name = "KNITTING_KG"
        Me.KNITTING_KG.ReadOnly = True
        Me.KNITTING_KG.Width = 97
        '
        'K_GIN_QTY
        '
        Me.K_GIN_QTY.DataPropertyName = "GIN_QTY"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.K_GIN_QTY.DefaultCellStyle = DataGridViewCellStyle6
        Me.K_GIN_QTY.HeaderText = "GIN QTY"
        Me.K_GIN_QTY.Name = "K_GIN_QTY"
        Me.K_GIN_QTY.ReadOnly = True
        Me.K_GIN_QTY.Width = 73
        '
        'KOCLOSED
        '
        Me.KOCLOSED.DataPropertyName = "KOCLOSED"
        Me.KOCLOSED.HeaderText = "CLOSED"
        Me.KOCLOSED.Name = "KOCLOSED"
        Me.KOCLOSED.ReadOnly = True
        Me.KOCLOSED.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KOCLOSED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.KOCLOSED.Width = 73
        '
        'KOCLOSEDDT
        '
        Me.KOCLOSEDDT.DataPropertyName = "KOCLOSEDT"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.KOCLOSEDDT.DefaultCellStyle = DataGridViewCellStyle7
        Me.KOCLOSEDDT.HeaderText = "CLOSED DATE"
        Me.KOCLOSEDDT.Name = "KOCLOSEDDT"
        Me.KOCLOSEDDT.ReadOnly = True
        Me.KOCLOSEDDT.Width = 102
        '
        'BOM
        '
        Me.BOM.HeaderText = "BOM"
        Me.BOM.Name = "BOM"
        Me.BOM.ReadOnly = True
        Me.BOM.Width = 57
        '
        'dgvGreige
        '
        Me.dgvGreige.ColumnHeadersHeight = 21
        Me.dgvGreige.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.G_SONO, Me.KONO, Me.MACHINE_NO, Me.GRADE, Me.OH_KG})
        Me.dgvGreige.Location = New System.Drawing.Point(945, 435)
        Me.dgvGreige.Name = "dgvGreige"
        Me.dgvGreige.ReadOnly = True
        Me.dgvGreige.Size = New System.Drawing.Size(367, 270)
        Me.dgvGreige.TabIndex = 4
        '
        'G_SONO
        '
        Me.G_SONO.DataPropertyName = "SONO"
        Me.G_SONO.HeaderText = "ST NO"
        Me.G_SONO.Name = "G_SONO"
        Me.G_SONO.ReadOnly = True
        Me.G_SONO.Width = 80
        '
        'KONO
        '
        Me.KONO.DataPropertyName = "kono"
        Me.KONO.HeaderText = "KONO"
        Me.KONO.Name = "KONO"
        Me.KONO.ReadOnly = True
        Me.KONO.Width = 80
        '
        'MACHINE_NO
        '
        Me.MACHINE_NO.DataPropertyName = "MCNO"
        Me.MACHINE_NO.HeaderText = "M/C NO"
        Me.MACHINE_NO.Name = "MACHINE_NO"
        Me.MACHINE_NO.ReadOnly = True
        Me.MACHINE_NO.Width = 60
        '
        'GRADE
        '
        Me.GRADE.DataPropertyName = "GRADE"
        Me.GRADE.HeaderText = "GRADE"
        Me.GRADE.Name = "GRADE"
        Me.GRADE.ReadOnly = True
        Me.GRADE.Width = 40
        '
        'OH_KG
        '
        Me.OH_KG.DataPropertyName = "BAL_kg"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.OH_KG.DefaultCellStyle = DataGridViewCellStyle8
        Me.OH_KG.HeaderText = "OH KG"
        Me.OH_KG.Name = "OH_KG"
        Me.OH_KG.ReadOnly = True
        Me.OH_KG.Width = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "KNITTING ORDERS"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(948, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "GREIGE OH"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnPrint, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1320, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipText = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnKnittingOrder, Me.tsmnSOApplied})
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(61, 22)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ToolTipText = "Print"
        '
        'tsmnKnittingOrder
        '
        Me.tsmnKnittingOrder.Name = "tsmnKnittingOrder"
        Me.tsmnKnittingOrder.Size = New System.Drawing.Size(180, 22)
        Me.tsmnKnittingOrder.Text = "Knitting Order"
        '
        'tsmnSOApplied
        '
        Me.tsmnSOApplied.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnSOAppliedBySTNo, Me.tsmnSOAppliedByDesignNo, Me.tsmnSOAppliedBySales})
        Me.tsmnSOApplied.Name = "tsmnSOApplied"
        Me.tsmnSOApplied.Size = New System.Drawing.Size(180, 22)
        Me.tsmnSOApplied.Text = "SO Applied"
        '
        'tsmnSOAppliedBySTNo
        '
        Me.tsmnSOAppliedBySTNo.Name = "tsmnSOAppliedBySTNo"
        Me.tsmnSOAppliedBySTNo.Size = New System.Drawing.Size(145, 22)
        Me.tsmnSOAppliedBySTNo.Text = "By ST-No"
        '
        'tsmnSOAppliedByDesignNo
        '
        Me.tsmnSOAppliedByDesignNo.Name = "tsmnSOAppliedByDesignNo"
        Me.tsmnSOAppliedByDesignNo.Size = New System.Drawing.Size(145, 22)
        Me.tsmnSOAppliedByDesignNo.Text = "By Design No"
        '
        'tsmnSOAppliedBySales
        '
        Me.tsmnSOAppliedBySales.Name = "tsmnSOAppliedBySales"
        Me.tsmnSOAppliedBySales.Size = New System.Drawing.Size(145, 22)
        Me.tsmnSOAppliedBySales.Text = "By Sales"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 22)
        Me.btnExit.Text = "Exit"
        Me.btnExit.ToolTipText = "Exit"
        '
        'tstripStatus
        '
        Me.tstripStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsslDataBaseName, Me.ToolStripProgressBar1})
        Me.tstripStatus.Location = New System.Drawing.Point(0, 711)
        Me.tstripStatus.Name = "tstripStatus"
        Me.tstripStatus.Size = New System.Drawing.Size(1320, 22)
        Me.tstripStatus.TabIndex = 9
        Me.tstripStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'tsslDataBaseName
        '
        Me.tsslDataBaseName.Name = "tsslDataBaseName"
        Me.tsslDataBaseName.Size = New System.Drawing.Size(96, 17)
        Me.tsslDataBaseName.Text = "Database Name :"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "SO APPLIED"
        '
        'dgvSOApplied
        '
        Me.dgvSOApplied.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvSOApplied.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSOApplied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSOApplied.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SO_SONO, Me.SO_SODT, Me.S_cUSTOMER, Me.S_DESIGN, Me.so_color_name, Me.QTY, Me.S_UOM, Me.SOQTYKG, Me.so_closed})
        Me.dgvSOApplied.Location = New System.Drawing.Point(3, 21)
        Me.dgvSOApplied.Name = "dgvSOApplied"
        Me.dgvSOApplied.Size = New System.Drawing.Size(928, 136)
        Me.dgvSOApplied.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dgvKnitting)
        Me.Panel2.Location = New System.Drawing.Point(5, 411)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 135)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.dgvSOApplied)
        Me.Panel3.Location = New System.Drawing.Point(8, 548)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 160)
        Me.Panel3.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ComboSalesPerson1)
        Me.GroupBox2.Controls.Add(Me.txtCustName)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtSTNO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtDesignNo)
        Me.GroupBox2.Controls.Add(Me.txtCustmer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnGetKnittingDesign)
        Me.GroupBox2.Controls.Add(Me.txtKnittingDesign)
        Me.GroupBox2.Controls.Add(Me.txtArticle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(975, 100)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condition"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(366, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(366, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = ":"
        '
        'Button2
        '
        Me.Button2.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.Button2.Location = New System.Drawing.Point(466, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = ".."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCustName.Location = New System.Drawing.Point(494, 19)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(233, 22)
        Me.txtCustName.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(366, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(117, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(117, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = ":"
        '
        'Button1
        '
        Me.Button1.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.Button1.Location = New System.Drawing.Point(230, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = ".."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(133, 45)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(91, 22)
        Me.txtDesignNo.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Design No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = ":"
        '
        'btnGetKnittingDesign
        '
        Me.btnGetKnittingDesign.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnGetKnittingDesign.Location = New System.Drawing.Point(230, 17)
        Me.btnGetKnittingDesign.Name = "btnGetKnittingDesign"
        Me.btnGetKnittingDesign.Size = New System.Drawing.Size(22, 23)
        Me.btnGetKnittingDesign.TabIndex = 15
        Me.btnGetKnittingDesign.Text = ".."
        Me.btnGetKnittingDesign.UseVisualStyleBackColor = True
        '
        'txtKnittingDesign
        '
        Me.txtKnittingDesign.Location = New System.Drawing.Point(133, 19)
        Me.txtKnittingDesign.Name = "txtKnittingDesign"
        Me.txtKnittingDesign.Size = New System.Drawing.Size(91, 22)
        Me.txtKnittingDesign.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Knitting Design"
        '
        'SO_SONO
        '
        Me.SO_SONO.DataPropertyName = "sonoid"
        Me.SO_SONO.HeaderText = " SONO ID"
        Me.SO_SONO.Name = "SO_SONO"
        Me.SO_SONO.Width = 81
        '
        'SO_SODT
        '
        Me.SO_SODT.DataPropertyName = "sodt"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.SO_SODT.DefaultCellStyle = DataGridViewCellStyle9
        Me.SO_SODT.HeaderText = "SO DATE"
        Me.SO_SODT.Name = "SO_SODT"
        Me.SO_SODT.Width = 76
        '
        'S_cUSTOMER
        '
        Me.S_cUSTOMER.DataPropertyName = "customer_name"
        Me.S_cUSTOMER.HeaderText = "CUSTOMER"
        Me.S_cUSTOMER.Name = "S_cUSTOMER"
        Me.S_cUSTOMER.Width = 90
        '
        'S_DESIGN
        '
        Me.S_DESIGN.DataPropertyName = "design_no"
        Me.S_DESIGN.HeaderText = "DESIGN"
        Me.S_DESIGN.Name = "S_DESIGN"
        Me.S_DESIGN.Width = 71
        '
        'so_color_name
        '
        Me.so_color_name.DataPropertyName = "color_name"
        Me.so_color_name.HeaderText = "COLOR"
        Me.so_color_name.Name = "so_color_name"
        Me.so_color_name.Width = 69
        '
        'QTY
        '
        Me.QTY.DataPropertyName = "SO_QTY"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.QTY.DefaultCellStyle = DataGridViewCellStyle10
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 51
        '
        'S_UOM
        '
        Me.S_UOM.DataPropertyName = "so_uom"
        Me.S_UOM.HeaderText = "UOM"
        Me.S_UOM.Name = "S_UOM"
        Me.S_UOM.Width = 59
        '
        'SOQTYKG
        '
        Me.SOQTYKG.DataPropertyName = "SO_QTY_KG"
        Me.SOQTYKG.HeaderText = "ALLOC KG"
        Me.SOQTYKG.Name = "SOQTYKG"
        Me.SOQTYKG.Width = 84
        '
        'so_closed
        '
        Me.so_closed.DataPropertyName = "closed"
        Me.so_closed.HeaderText = "CLOSED"
        Me.so_closed.Name = "so_closed"
        Me.so_closed.ReadOnly = True
        Me.so_closed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.so_closed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.so_closed.Width = 73
        '
        'frmSTOrderClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1320, 733)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tstripStatus)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvGreige)
        Me.Controls.Add(Me.dgvSTClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSTOrderClosing"
        Me.Text = "ST ORDER CLOSING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSTClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKnitting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGreige, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tstripStatus.ResumeLayout(False)
        Me.tstripStatus.PerformLayout()
        CType(Me.dgvSOApplied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustmer As TextBox
    Friend WithEvents txtSTNO As TextBox
    Friend WithEvents txtArticle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents chkClose As CheckBox
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents btnFind As Button
    Friend WithEvents dgvSTClose As DataGridView
    Friend WithEvents dgvKnitting As DataGridView
    Friend WithEvents dgvGreige As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents tstripStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvSOApplied As DataGridView
    Friend WithEvents ComboSalesPerson1 As Classes.comboSalesPerson
    Friend WithEvents KIKO As DataGridViewTextBoxColumn
    Friend WithEvents KIKO_DT As DataGridViewTextBoxColumn
    Friend WithEvents K_DESIGN_NO As DataGridViewTextBoxColumn
    Friend WithEvents KNITTING_KG As DataGridViewTextBoxColumn
    Friend WithEvents K_GIN_QTY As DataGridViewTextBoxColumn
    Friend WithEvents KOCLOSED As DataGridViewCheckBoxColumn
    Friend WithEvents KOCLOSEDDT As DataGridViewTextBoxColumn
    Friend WithEvents BOM As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents OH_KG As DataGridViewTextBoxColumn
    Friend WithEvents GRADE As DataGridViewTextBoxColumn
    Friend WithEvents MACHINE_NO As DataGridViewTextBoxColumn
    Friend WithEvents KONO As DataGridViewTextBoxColumn
    Friend WithEvents G_SONO As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As ToolStripDropDownButton
    Friend WithEvents tsmnKnittingOrder As ToolStripMenuItem
    Friend WithEvents tsmnSOApplied As ToolStripMenuItem
    Friend WithEvents tsmnSOAppliedBySTNo As ToolStripMenuItem
    Friend WithEvents tsmnSOAppliedByDesignNo As ToolStripMenuItem
    Friend WithEvents tsmnSOAppliedBySales As ToolStripMenuItem
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sodt As DataGridViewTextBoxColumn
    Friend WithEvents DESIGN_NO As DataGridViewTextBoxColumn
    Friend WithEvents ARTICLE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents color_name As DataGridViewTextBoxColumn
    Friend WithEvents ST_QTY As DataGridViewTextBoxColumn
    Friend WithEvents UOM As DataGridViewTextBoxColumn
    Friend WithEvents ST_QTY_KG As DataGridViewTextBoxColumn
    Friend WithEvents KI_KG As DataGridViewTextBoxColumn
    Friend WithEvents KI_BAL As DataGridViewTextBoxColumn
    Friend WithEvents SO_QTY_KG As DataGridViewTextBoxColumn
    Friend WithEvents st_bal_kg As DataGridViewTextBoxColumn
    Friend WithEvents CUST_NAME As DataGridViewTextBoxColumn
    Friend WithEvents closed As DataGridViewCheckBoxColumn
    Friend WithEvents sales_person_code As DataGridViewTextBoxColumn
    Friend WithEvents so_line_id As DataGridViewTextBoxColumn
    Friend WithEvents tsslDataBaseName As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGetKnittingDesign As Button
    Friend WithEvents txtKnittingDesign As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SO_SONO As DataGridViewTextBoxColumn
    Friend WithEvents SO_SODT As DataGridViewTextBoxColumn
    Friend WithEvents S_cUSTOMER As DataGridViewTextBoxColumn
    Friend WithEvents S_DESIGN As DataGridViewTextBoxColumn
    Friend WithEvents so_color_name As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents S_UOM As DataGridViewTextBoxColumn
    Friend WithEvents SOQTYKG As DataGridViewTextBoxColumn
    Friend WithEvents so_closed As DataGridViewCheckBoxColumn
End Class
