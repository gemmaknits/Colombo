<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequestD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestD))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboReqNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSerachReqNo = New System.Windows.Forms.Button()
        Me.dtpReqDate = New System.Windows.Forms.DateTimePicker()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdReqDetD = New System.Windows.Forms.DataGridView()
        Me.sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReqDetDSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReqDetDGammaRollSeqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.m = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboUOM = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVerNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optSize2 = New System.Windows.Forms.RadioButton()
        Me.optSize1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optTube2 = New System.Windows.Forms.RadioButton()
        Me.optTube1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optLogo2 = New System.Windows.Forms.RadioButton()
        Me.optLogo1 = New System.Windows.Forms.RadioButton()
        Me.grdFreeStockD = New System.Windows.Forms.DataGridView()
        Me.stk_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.req_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_custcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_subinventory_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_gamma_roll_seq_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.txtSelectRolls = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSelectKgs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSelectYds = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSelectMts = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.grdDesign = New System.Windows.Forms.DataGridView()
        Me.ds_sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_nob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_rptlen_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_rptwth_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.dtpReleaseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gbTotalSelection = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnPrintPackNo = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSavePackNo = New System.Windows.Forms.Button()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.btngout = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.btnShowLockedStock = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdReqDetD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdFreeStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.gbTotalSelection.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboReqNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1213, 25)
        Me.ToolStrip1.TabIndex = 16
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel1.Text = "Request No."
        Me.ToolStripLabel1.Visible = False
        '
        'cboReqNo
        '
        Me.cboReqNo.Name = "cboReqNo"
        Me.cboReqNo.Size = New System.Drawing.Size(100, 25)
        Me.cboReqNo.Visible = False
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
        Me.btnSearch.Visible = False
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(359, 22)
        Me.ToolStripLabel2.Text = "** 1 RD / 1 Design No., not show S/O ENT , Not Show S/O Closed"
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(49, -6)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(168, 24)
        Me.lblCancelled.TabIndex = 30
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCancelled.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Req Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSerachReqNo)
        Me.GroupBox1.Controls.Add(Me.lblCancelled)
        Me.GroupBox1.Controls.Add(Me.dtpReqDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtReqNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(975, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 84)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'btnSerachReqNo
        '
        Me.btnSerachReqNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSerachReqNo.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSerachReqNo.Location = New System.Drawing.Point(184, 28)
        Me.btnSerachReqNo.Name = "btnSerachReqNo"
        Me.btnSerachReqNo.Size = New System.Drawing.Size(31, 26)
        Me.btnSerachReqNo.TabIndex = 137
        Me.btnSerachReqNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSerachReqNo.UseVisualStyleBackColor = True
        '
        'dtpReqDate
        '
        Me.dtpReqDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReqDate.Location = New System.Drawing.Point(82, 54)
        Me.dtpReqDate.Name = "dtpReqDate"
        Me.dtpReqDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpReqDate.TabIndex = 1
        '
        'txtReqNo
        '
        Me.txtReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(82, 28)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(96, 22)
        Me.txtReqNo.TabIndex = 0
        Me.txtReqNo.Tag = "str"
        Me.txtReqNo.Text = "SO07060000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Req No."
        '
        'grdReqDetD
        '
        Me.grdReqDetD.AllowUserToAddRows = False
        Me.grdReqDetD.AllowUserToDeleteRows = False
        Me.grdReqDetD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdReqDetD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdReqDetD.ColumnHeadersHeight = 30
        Me.grdReqDetD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.ReqDetDSubinventoryCode, Me.roll_no, Me.roll_no_o, Me.ReqDetDGammaRollSeqNo, Me.col, Me.custcolor, Me.gr, Me.k, Me.y, Me.m, Me.sonoid, Me.rem_qc})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdReqDetD.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdReqDetD.Location = New System.Drawing.Point(679, 286)
        Me.grdReqDetD.Name = "grdReqDetD"
        Me.grdReqDetD.Size = New System.Drawing.Size(525, 219)
        Me.grdReqDetD.TabIndex = 18
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Choose"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel.Width = 50
        '
        'ReqDetDSubinventoryCode
        '
        Me.ReqDetDSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.ReqDetDSubinventoryCode.HeaderText = "Subinventory Code"
        Me.ReqDetDSubinventoryCode.Name = "ReqDetDSubinventoryCode"
        Me.ReqDetDSubinventoryCode.ReadOnly = True
        Me.ReqDetDSubinventoryCode.Width = 70
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 65
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 80
        '
        'ReqDetDGammaRollSeqNo
        '
        Me.ReqDetDGammaRollSeqNo.DataPropertyName = "gamma_roll_seq_no"
        Me.ReqDetDGammaRollSeqNo.HeaderText = "Gamma Roll No"
        Me.ReqDetDGammaRollSeqNo.Name = "ReqDetDGammaRollSeqNo"
        Me.ReqDetDGammaRollSeqNo.ReadOnly = True
        Me.ReqDetDGammaRollSeqNo.Width = 40
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col.DefaultCellStyle = DataGridViewCellStyle1
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col.Width = 50
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        Me.custcolor.Width = 65
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Gr"
        Me.gr.Name = "gr"
        Me.gr.ReadOnly = True
        Me.gr.Width = 30
        '
        'k
        '
        Me.k.DataPropertyName = "k"
        Me.k.HeaderText = "Kgs."
        Me.k.Name = "k"
        Me.k.Width = 65
        '
        'y
        '
        Me.y.DataPropertyName = "y"
        Me.y.HeaderText = "Yds."
        Me.y.Name = "y"
        Me.y.Width = 65
        '
        'm
        '
        Me.m.DataPropertyName = "m"
        Me.m.HeaderText = "Mts."
        Me.m.Name = "m"
        Me.m.Width = 65
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        Me.sonoid.Width = 90
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Remark QC"
        Me.rem_qc.Name = "rem_qc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "S/O No."
        '
        'cboUOM
        '
        Me.cboUOM.FormattingEnabled = True
        Me.cboUOM.Location = New System.Drawing.Point(120, 56)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Size = New System.Drawing.Size(128, 21)
        Me.cboUOM.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Unit Of Mesurement"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(568, 32)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(240, 21)
        Me.cboCustomer.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Request For"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Customer Name"
        '
        'txtVerNo
        '
        Me.txtVerNo.Location = New System.Drawing.Point(120, 80)
        Me.txtVerNo.Name = "txtVerNo"
        Me.txtVerNo.Size = New System.Drawing.Size(128, 20)
        Me.txtVerNo.TabIndex = 28
        Me.txtVerNo.Tag = "str"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(264, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(344, 80)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(320, 20)
        Me.txtRemark.TabIndex = 27
        Me.txtRemark.Tag = "str"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Version No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.optSize2)
        Me.GroupBox2.Controls.Add(Me.optSize1)
        Me.GroupBox2.Location = New System.Drawing.Point(248, 513)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 80)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carton Size (Box Size)"
        '
        'optSize2
        '
        Me.optSize2.AutoSize = True
        Me.optSize2.Location = New System.Drawing.Point(16, 48)
        Me.optSize2.Name = "optSize2"
        Me.optSize2.Size = New System.Drawing.Size(89, 17)
        Me.optSize2.TabIndex = 1
        Me.optSize2.Text = "52 x 52 x 118"
        Me.optSize2.UseVisualStyleBackColor = True
        '
        'optSize1
        '
        Me.optSize1.AutoSize = True
        Me.optSize1.Checked = True
        Me.optSize1.Location = New System.Drawing.Point(16, 24)
        Me.optSize1.Name = "optSize1"
        Me.optSize1.Size = New System.Drawing.Size(83, 17)
        Me.optSize1.TabIndex = 0
        Me.optSize1.TabStop = True
        Me.optSize1.Text = "52 x 52 x 52"
        Me.optSize1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.optTube2)
        Me.GroupBox3.Controls.Add(Me.optTube1)
        Me.GroupBox3.Location = New System.Drawing.Point(392, 513)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 80)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tube"
        '
        'optTube2
        '
        Me.optTube2.AutoSize = True
        Me.optTube2.Location = New System.Drawing.Point(16, 48)
        Me.optTube2.Name = "optTube2"
        Me.optTube2.Size = New System.Drawing.Size(161, 17)
        Me.optTube2.TabIndex = 1
        Me.optTube2.Text = "Flat Board (ม้วนแผงกระดาษ)"
        Me.optTube2.UseVisualStyleBackColor = True
        '
        'optTube1
        '
        Me.optTube1.AutoSize = True
        Me.optTube1.Checked = True
        Me.optTube1.Location = New System.Drawing.Point(16, 24)
        Me.optTube1.Name = "optTube1"
        Me.optTube1.Size = New System.Drawing.Size(108, 17)
        Me.optTube1.TabIndex = 0
        Me.optTube1.TabStop = True
        Me.optTube1.Text = "Spool (ม้วนหลอด)"
        Me.optTube1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.optLogo2)
        Me.GroupBox4.Controls.Add(Me.optLogo1)
        Me.GroupBox4.Location = New System.Drawing.Point(616, 513)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(97, 80)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calista Logo"
        '
        'optLogo2
        '
        Me.optLogo2.AutoSize = True
        Me.optLogo2.Location = New System.Drawing.Point(16, 48)
        Me.optLogo2.Name = "optLogo2"
        Me.optLogo2.Size = New System.Drawing.Size(66, 17)
        Me.optLogo2.TabIndex = 1
        Me.optLogo2.Text = "No Logo"
        Me.optLogo2.UseVisualStyleBackColor = True
        '
        'optLogo1
        '
        Me.optLogo1.AutoSize = True
        Me.optLogo1.Checked = True
        Me.optLogo1.Location = New System.Drawing.Point(16, 24)
        Me.optLogo1.Name = "optLogo1"
        Me.optLogo1.Size = New System.Drawing.Size(78, 17)
        Me.optLogo1.TabIndex = 0
        Me.optLogo1.TabStop = True
        Me.optLogo1.Text = "Have Logo"
        Me.optLogo1.UseVisualStyleBackColor = True
        '
        'grdFreeStockD
        '
        Me.grdFreeStockD.AllowUserToAddRows = False
        Me.grdFreeStockD.AllowUserToDeleteRows = False
        Me.grdFreeStockD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdFreeStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdFreeStockD.ColumnHeadersHeight = 30
        Me.grdFreeStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stk_sel, Me.req_col, Me.stk_custcol, Me.stk_gr, Me.stk_lot, Me.stk_batch, Me.stk_subinventory_code, Me.stk_roll_no, Me.stk_roll_no_o, Me.stk_gamma_roll_seq_no, Me.stk_kg, Me.stk_yds, Me.stk_mts, Me.n_yds, Me.n_mts, Me.stk_rem_qc})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdFreeStockD.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdFreeStockD.Location = New System.Drawing.Point(8, 286)
        Me.grdFreeStockD.Name = "grdFreeStockD"
        Me.grdFreeStockD.Size = New System.Drawing.Size(627, 219)
        Me.grdFreeStockD.TabIndex = 34
        '
        'stk_sel
        '
        Me.stk_sel.DataPropertyName = "sel"
        Me.stk_sel.HeaderText = "Choose"
        Me.stk_sel.Name = "stk_sel"
        Me.stk_sel.Width = 50
        '
        'req_col
        '
        Me.req_col.DataPropertyName = "col"
        Me.req_col.HeaderText = "Color"
        Me.req_col.Name = "req_col"
        Me.req_col.ReadOnly = True
        Me.req_col.Width = 50
        '
        'stk_custcol
        '
        Me.stk_custcol.DataPropertyName = "custcolor"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stk_custcol.DefaultCellStyle = DataGridViewCellStyle3
        Me.stk_custcol.HeaderText = "Customer Color"
        Me.stk_custcol.Name = "stk_custcol"
        Me.stk_custcol.ReadOnly = True
        Me.stk_custcol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'stk_gr
        '
        Me.stk_gr.DataPropertyName = "gr"
        Me.stk_gr.HeaderText = "Grade"
        Me.stk_gr.Name = "stk_gr"
        Me.stk_gr.Width = 50
        '
        'stk_lot
        '
        Me.stk_lot.DataPropertyName = "lot"
        Me.stk_lot.HeaderText = "Lot#"
        Me.stk_lot.Name = "stk_lot"
        Me.stk_lot.ReadOnly = True
        Me.stk_lot.Width = 45
        '
        'stk_batch
        '
        Me.stk_batch.DataPropertyName = "batch"
        Me.stk_batch.HeaderText = "Batch"
        Me.stk_batch.Name = "stk_batch"
        Me.stk_batch.ReadOnly = True
        Me.stk_batch.Width = 45
        '
        'stk_subinventory_code
        '
        Me.stk_subinventory_code.DataPropertyName = "subinventory_code"
        Me.stk_subinventory_code.HeaderText = "Subinventory"
        Me.stk_subinventory_code.Name = "stk_subinventory_code"
        Me.stk_subinventory_code.ReadOnly = True
        Me.stk_subinventory_code.Width = 80
        '
        'stk_roll_no
        '
        Me.stk_roll_no.DataPropertyName = "roll_no"
        Me.stk_roll_no.HeaderText = "Roll No."
        Me.stk_roll_no.Name = "stk_roll_no"
        Me.stk_roll_no.ReadOnly = True
        Me.stk_roll_no.Width = 65
        '
        'stk_roll_no_o
        '
        Me.stk_roll_no_o.DataPropertyName = "roll_no_o"
        Me.stk_roll_no_o.HeaderText = "Factory Roll No."
        Me.stk_roll_no_o.Name = "stk_roll_no_o"
        Me.stk_roll_no_o.ReadOnly = True
        Me.stk_roll_no_o.Width = 60
        '
        'stk_gamma_roll_seq_no
        '
        Me.stk_gamma_roll_seq_no.DataPropertyName = "gamma_roll_seq_no"
        Me.stk_gamma_roll_seq_no.HeaderText = "Gamma Roll No"
        Me.stk_gamma_roll_seq_no.Name = "stk_gamma_roll_seq_no"
        Me.stk_gamma_roll_seq_no.Width = 40
        '
        'stk_kg
        '
        Me.stk_kg.DataPropertyName = "kg"
        Me.stk_kg.HeaderText = "Kgs."
        Me.stk_kg.Name = "stk_kg"
        Me.stk_kg.ReadOnly = True
        Me.stk_kg.Width = 50
        '
        'stk_yds
        '
        Me.stk_yds.DataPropertyName = "yds"
        Me.stk_yds.HeaderText = "Yds."
        Me.stk_yds.Name = "stk_yds"
        Me.stk_yds.ReadOnly = True
        Me.stk_yds.Width = 50
        '
        'stk_mts
        '
        Me.stk_mts.DataPropertyName = "mts"
        Me.stk_mts.HeaderText = "Mts."
        Me.stk_mts.Name = "stk_mts"
        Me.stk_mts.ReadOnly = True
        Me.stk_mts.Width = 50
        '
        'n_yds
        '
        Me.n_yds.DataPropertyName = "n_yds"
        Me.n_yds.HeaderText = "Yds. (Bands)"
        Me.n_yds.Name = "n_yds"
        Me.n_yds.ReadOnly = True
        Me.n_yds.Width = 50
        '
        'n_mts
        '
        Me.n_mts.DataPropertyName = "n_mts"
        Me.n_mts.HeaderText = "Mts. (Bands)"
        Me.n_mts.Name = "n_mts"
        Me.n_mts.ReadOnly = True
        Me.n_mts.Width = 50
        '
        'stk_rem_qc
        '
        Me.stk_rem_qc.DataPropertyName = "rem_qc"
        Me.stk_rem_qc.HeaderText = "Remark QC"
        Me.stk_rem_qc.Name = "stk_rem_qc"
        Me.stk_rem_qc.Width = 150
        '
        'btnDelAll
        '
        Me.btnDelAll.Location = New System.Drawing.Point(641, 434)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(32, 32)
        Me.btnDelAll.TabIndex = 56
        Me.btnDelAll.Text = "<<"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(641, 402)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 32)
        Me.btnDel.TabIndex = 55
        Me.btnDel.Text = "<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(641, 370)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(641, 317)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveRight.TabIndex = 58
        Me.btnMoveRight.Text = "...>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(641, 293)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveLeft.TabIndex = 57
        Me.btnMoveLeft.Text = "<..."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'txtSelectRolls
        '
        Me.txtSelectRolls.Location = New System.Drawing.Point(59, 19)
        Me.txtSelectRolls.Name = "txtSelectRolls"
        Me.txtSelectRolls.ReadOnly = True
        Me.txtSelectRolls.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectRolls.TabIndex = 59
        Me.txtSelectRolls.Tag = "0.00"
        Me.txtSelectRolls.Text = "0.00"
        Me.txtSelectRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Rolls"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(163, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Kgs."
        '
        'txtSelectKgs
        '
        Me.txtSelectKgs.Location = New System.Drawing.Point(59, 43)
        Me.txtSelectKgs.Name = "txtSelectKgs"
        Me.txtSelectKgs.ReadOnly = True
        Me.txtSelectKgs.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectKgs.TabIndex = 62
        Me.txtSelectKgs.Tag = "0.00"
        Me.txtSelectKgs.Text = "0.00"
        Me.txtSelectKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(163, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Yds."
        '
        'txtSelectYds
        '
        Me.txtSelectYds.Location = New System.Drawing.Point(59, 67)
        Me.txtSelectYds.Name = "txtSelectYds"
        Me.txtSelectYds.ReadOnly = True
        Me.txtSelectYds.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectYds.TabIndex = 64
        Me.txtSelectYds.Tag = "0.00"
        Me.txtSelectYds.Text = "0.00"
        Me.txtSelectYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(163, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Mts."
        '
        'txtSelectMts
        '
        Me.txtSelectMts.Location = New System.Drawing.Point(59, 91)
        Me.txtSelectMts.Name = "txtSelectMts"
        Me.txtSelectMts.ReadOnly = True
        Me.txtSelectMts.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectMts.TabIndex = 66
        Me.txtSelectMts.Tag = "0.00"
        Me.txtSelectMts.Text = "0.00"
        Me.txtSelectMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(153, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Location = New System.Drawing.Point(47, 91)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedMts.TabIndex = 75
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(152, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Location = New System.Drawing.Point(47, 67)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedYds.TabIndex = 73
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(152, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Location = New System.Drawing.Point(47, 43)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedKgs.TabIndex = 71
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(151, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Location = New System.Drawing.Point(47, 19)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedRolls.TabIndex = 68
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-26, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 69
        '
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(120, 32)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(128, 21)
        Me.cboDocType.TabIndex = 79
        '
        'grdDesign
        '
        Me.grdDesign.AllowUserToAddRows = False
        Me.grdDesign.AllowUserToDeleteRows = False
        Me.grdDesign.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDesign.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDesign.ColumnHeadersHeight = 30
        Me.grdDesign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ds_sonoid, Me.ds_design_no, Me.ds_gwth, Me.ds_col, Me.ds_custcolor, Me.ds_nob, Me.ds_gr, Me.ds_rptlen_s, Me.ds_rptwth_s, Me.kg_onhand, Me.yds_onhand, Me.mts_onhand})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDesign.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdDesign.Location = New System.Drawing.Point(8, 112)
        Me.grdDesign.Name = "grdDesign"
        Me.grdDesign.Size = New System.Drawing.Size(961, 162)
        Me.grdDesign.TabIndex = 80
        '
        'ds_sonoid
        '
        Me.ds_sonoid.DataPropertyName = "sonoid"
        Me.ds_sonoid.HeaderText = "S/O No. ID"
        Me.ds_sonoid.Name = "ds_sonoid"
        Me.ds_sonoid.ReadOnly = True
        '
        'ds_design_no
        '
        Me.ds_design_no.DataPropertyName = "design_no"
        Me.ds_design_no.HeaderText = "Design No."
        Me.ds_design_no.Name = "ds_design_no"
        Me.ds_design_no.ReadOnly = True
        '
        'ds_gwth
        '
        Me.ds_gwth.DataPropertyName = "gwth"
        Me.ds_gwth.HeaderText = "Gwth"
        Me.ds_gwth.Name = "ds_gwth"
        Me.ds_gwth.ReadOnly = True
        Me.ds_gwth.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ds_gwth.Width = 45
        '
        'ds_col
        '
        Me.ds_col.DataPropertyName = "col"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds_col.DefaultCellStyle = DataGridViewCellStyle5
        Me.ds_col.HeaderText = "Color"
        Me.ds_col.Name = "ds_col"
        Me.ds_col.ReadOnly = True
        Me.ds_col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ds_col.Width = 65
        '
        'ds_custcolor
        '
        Me.ds_custcolor.DataPropertyName = "custcol"
        Me.ds_custcolor.HeaderText = "Customer Color"
        Me.ds_custcolor.Name = "ds_custcolor"
        Me.ds_custcolor.ReadOnly = True
        '
        'ds_nob
        '
        Me.ds_nob.DataPropertyName = "nob"
        Me.ds_nob.HeaderText = "Nob"
        Me.ds_nob.Name = "ds_nob"
        Me.ds_nob.ReadOnly = True
        Me.ds_nob.Width = 40
        '
        'ds_gr
        '
        Me.ds_gr.DataPropertyName = "gr"
        Me.ds_gr.HeaderText = "Gr"
        Me.ds_gr.Name = "ds_gr"
        Me.ds_gr.ReadOnly = True
        Me.ds_gr.Width = 35
        '
        'ds_rptlen_s
        '
        Me.ds_rptlen_s.DataPropertyName = "rptlen_s"
        Me.ds_rptlen_s.HeaderText = "Repeat Len (cms)"
        Me.ds_rptlen_s.Name = "ds_rptlen_s"
        Me.ds_rptlen_s.ReadOnly = True
        Me.ds_rptlen_s.Width = 115
        '
        'ds_rptwth_s
        '
        Me.ds_rptwth_s.DataPropertyName = "rptwth_s"
        Me.ds_rptwth_s.HeaderText = "Repeat Wth (cms)"
        Me.ds_rptwth_s.Name = "ds_rptwth_s"
        Me.ds_rptwth_s.ReadOnly = True
        Me.ds_rptwth_s.Width = 120
        '
        'kg_onhand
        '
        Me.kg_onhand.DataPropertyName = "stk_kg"
        Me.kg_onhand.HeaderText = "Kgs."
        Me.kg_onhand.Name = "kg_onhand"
        Me.kg_onhand.ReadOnly = True
        Me.kg_onhand.Width = 65
        '
        'yds_onhand
        '
        Me.yds_onhand.DataPropertyName = "stk_yds"
        Me.yds_onhand.HeaderText = "Yds."
        Me.yds_onhand.Name = "yds_onhand"
        Me.yds_onhand.ReadOnly = True
        Me.yds_onhand.Width = 65
        '
        'mts_onhand
        '
        Me.mts_onhand.DataPropertyName = "stk_mts"
        Me.mts_onhand.HeaderText = "Mts."
        Me.mts_onhand.Name = "mts_onhand"
        Me.mts_onhand.ReadOnly = True
        Me.mts_onhand.Width = 65
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(264, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Design No."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(344, 56)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(128, 21)
        Me.cboDesignNo.TabIndex = 81
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(344, 32)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(128, 21)
        Me.cboSoNo.TabIndex = 84
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReleaseDate.Location = New System.Drawing.Point(568, 56)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpReleaseDate.TabIndex = 85
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(480, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Release Date"
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(823, 70)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(104, 32)
        Me.chkAutoCalculate.TabIndex = 136
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(825, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 140
        Me.Label21.Text = "Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.Location = New System.Drawing.Point(825, 49)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(104, 20)
        Me.txtBarcode.TabIndex = 139
        Me.txtBarcode.Tag = "str"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtSelectedRolls)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtSelectedKgs)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtSelectedYds)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtSelectedMts)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(1004, 511)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(197, 120)
        Me.GroupBox5.TabIndex = 141
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Selected Request"
        '
        'gbTotalSelection
        '
        Me.gbTotalSelection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbTotalSelection.Controls.Add(Me.txtSelectRolls)
        Me.gbTotalSelection.Controls.Add(Me.Label8)
        Me.gbTotalSelection.Controls.Add(Me.txtSelectKgs)
        Me.gbTotalSelection.Controls.Add(Me.Label9)
        Me.gbTotalSelection.Controls.Add(Me.txtSelectYds)
        Me.gbTotalSelection.Controls.Add(Me.Label10)
        Me.gbTotalSelection.Controls.Add(Me.txtSelectMts)
        Me.gbTotalSelection.Controls.Add(Me.Label11)
        Me.gbTotalSelection.Location = New System.Drawing.Point(11, 511)
        Me.gbTotalSelection.Name = "gbTotalSelection"
        Me.gbTotalSelection.Size = New System.Drawing.Size(200, 120)
        Me.gbTotalSelection.TabIndex = 142
        Me.gbTotalSelection.TabStop = False
        Me.gbTotalSelection.Text = "Total Selection Stk"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.btnPrintPackNo)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.btnSavePackNo)
        Me.GroupBox6.Controls.Add(Me.txtPackNo)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.DtpPackDate)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Location = New System.Drawing.Point(975, 100)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 91)
        Me.GroupBox6.TabIndex = 143
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Packing List"
        '
        'btnPrintPackNo
        '
        Me.btnPrintPackNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrintPackNo.Enabled = False
        Me.btnPrintPackNo.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrintPackNo.Location = New System.Drawing.Point(185, 48)
        Me.btnPrintPackNo.Name = "btnPrintPackNo"
        Me.btnPrintPackNo.Size = New System.Drawing.Size(32, 26)
        Me.btnPrintPackNo.TabIndex = 138
        Me.btnPrintPackNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintPackNo.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(72, 69)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 22)
        Me.Label24.TabIndex = 137
        Me.Label24.Text = "Cancelled"
        Me.Label24.Visible = False
        '
        'btnSavePackNo
        '
        Me.btnSavePackNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSavePackNo.Enabled = False
        Me.btnSavePackNo.Image = CType(resources.GetObject("btnSavePackNo.Image"), System.Drawing.Image)
        Me.btnSavePackNo.Location = New System.Drawing.Point(185, 18)
        Me.btnSavePackNo.Name = "btnSavePackNo"
        Me.btnSavePackNo.Size = New System.Drawing.Size(31, 26)
        Me.btnSavePackNo.TabIndex = 136
        Me.btnSavePackNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSavePackNo.UseVisualStyleBackColor = True
        '
        'txtPackNo
        '
        Me.txtPackNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(75, 20)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.ReadOnly = True
        Me.txtPackNo.Size = New System.Drawing.Size(104, 20)
        Me.txtPackNo.TabIndex = 129
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "Pack No."
        '
        'DtpPackDate
        '
        Me.DtpPackDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPackDate.Checked = False
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(75, 46)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.ShowCheckBox = True
        Me.DtpPackDate.Size = New System.Drawing.Size(104, 20)
        Me.DtpPackDate.TabIndex = 131
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 13)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "Date"
        '
        'txtOutNo
        '
        Me.txtOutNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(75, 20)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(104, 20)
        Me.txtOutNo.TabIndex = 139
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "DOUT No."
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.BtnYarnPrintBar)
        Me.GroupBox7.Controls.Add(Me.btngout)
        Me.GroupBox7.Controls.Add(Me.lblOutdt)
        Me.GroupBox7.Controls.Add(Me.DtpOutdt)
        Me.GroupBox7.Controls.Add(Me.txtOutNo)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Location = New System.Drawing.Point(975, 194)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(225, 81)
        Me.GroupBox7.TabIndex = 144
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Dyed Out"
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnYarnPrintBar.Enabled = False
        Me.BtnYarnPrintBar.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(185, 46)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(34, 26)
        Me.BtnYarnPrintBar.TabIndex = 144
        Me.BtnYarnPrintBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = True
        '
        'btngout
        '
        Me.btngout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.Location = New System.Drawing.Point(185, 16)
        Me.btngout.Name = "btngout"
        Me.btngout.Size = New System.Drawing.Size(34, 26)
        Me.btngout.TabIndex = 143
        Me.btngout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngout.UseVisualStyleBackColor = True
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(7, 49)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(64, 13)
        Me.lblOutdt.TabIndex = 142
        Me.lblOutdt.Text = "DOUT Date"
        '
        'DtpOutdt
        '
        Me.DtpOutdt.Checked = False
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(75, 46)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.ShowCheckBox = True
        Me.DtpOutdt.Size = New System.Drawing.Size(104, 20)
        Me.DtpOutdt.TabIndex = 141
        '
        'btnShowLockedStock
        '
        Me.btnShowLockedStock.Image = CType(resources.GetObject("btnShowLockedStock.Image"), System.Drawing.Image)
        Me.btnShowLockedStock.Location = New System.Drawing.Point(672, 72)
        Me.btnShowLockedStock.Name = "btnShowLockedStock"
        Me.btnShowLockedStock.Size = New System.Drawing.Size(136, 32)
        Me.btnShowLockedStock.TabIndex = 77
        Me.btnShowLockedStock.Text = "Show Locked Stock"
        Me.btnShowLockedStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowLockedStock.UseVisualStyleBackColor = True
        '
        'frmRequestD
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1213, 639)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.gbTotalSelection)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.dtpReleaseDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboSoNo)
        Me.Controls.Add(Me.cboDesignNo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.grdDesign)
        Me.Controls.Add(Me.grdReqDetD)
        Me.Controls.Add(Me.cboDocType)
        Me.Controls.Add(Me.btnShowLockedStock)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdFreeStockD)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtVerNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboUOM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRequestD"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Request Dyed Lace"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdReqDetD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdFreeStockD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDesign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbTotalSelection.ResumeLayout(False)
        Me.gbTotalSelection.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboReqNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpReqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdReqDetD As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optSize2 As System.Windows.Forms.RadioButton
    Friend WithEvents optSize1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optTube2 As System.Windows.Forms.RadioButton
    Friend WithEvents optTube1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents optLogo2 As System.Windows.Forms.RadioButton
    Friend WithEvents optLogo1 As System.Windows.Forms.RadioButton
    Friend WithEvents grdFreeStockD As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents txtSelectRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSelectKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSelectYds As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSelectMts As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnShowLockedStock As System.Windows.Forms.Button
    Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
    Friend WithEvents grdDesign As System.Windows.Forms.DataGridView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dtpReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents gbTotalSelection As System.Windows.Forms.GroupBox
    Friend WithEvents ds_sonoid As DataGridViewTextBoxColumn
    Friend WithEvents ds_design_no As DataGridViewTextBoxColumn
    Friend WithEvents ds_gwth As DataGridViewTextBoxColumn
    Friend WithEvents ds_col As DataGridViewTextBoxColumn
    Friend WithEvents ds_custcolor As DataGridViewTextBoxColumn
    Friend WithEvents ds_nob As DataGridViewTextBoxColumn
    Friend WithEvents ds_gr As DataGridViewTextBoxColumn
    Friend WithEvents ds_rptlen_s As DataGridViewTextBoxColumn
    Friend WithEvents ds_rptwth_s As DataGridViewTextBoxColumn
    Friend WithEvents kg_onhand As DataGridViewTextBoxColumn
    Friend WithEvents yds_onhand As DataGridViewTextBoxColumn
    Friend WithEvents mts_onhand As DataGridViewTextBoxColumn
    Friend WithEvents sel As DataGridViewCheckBoxColumn
    Friend WithEvents ReqDetDSubinventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents ReqDetDGammaRollSeqNo As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents k As DataGridViewTextBoxColumn
    Friend WithEvents y As DataGridViewTextBoxColumn
    Friend WithEvents m As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As DataGridViewTextBoxColumn
    Friend WithEvents stk_sel As DataGridViewCheckBoxColumn
    Friend WithEvents req_col As DataGridViewTextBoxColumn
    Friend WithEvents stk_custcol As DataGridViewTextBoxColumn
    Friend WithEvents stk_gr As DataGridViewTextBoxColumn
    Friend WithEvents stk_lot As DataGridViewTextBoxColumn
    Friend WithEvents stk_batch As DataGridViewTextBoxColumn
    Friend WithEvents stk_subinventory_code As DataGridViewTextBoxColumn
    Friend WithEvents stk_roll_no As DataGridViewTextBoxColumn
    Friend WithEvents stk_roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents stk_gamma_roll_seq_no As DataGridViewTextBoxColumn
    Friend WithEvents stk_kg As DataGridViewTextBoxColumn
    Friend WithEvents stk_yds As DataGridViewTextBoxColumn
    Friend WithEvents stk_mts As DataGridViewTextBoxColumn
    Friend WithEvents n_yds As DataGridViewTextBoxColumn
    Friend WithEvents n_mts As DataGridViewTextBoxColumn
    Friend WithEvents stk_rem_qc As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtPackNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpPackDate As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents btnSavePackNo As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents btnPrintPackNo As Button
    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnYarnPrintBar As Button
    Friend WithEvents btngout As Button
    Friend WithEvents lblOutdt As Label
    Friend WithEvents DtpOutdt As DateTimePicker
    Friend WithEvents btnSerachReqNo As Button
End Class
