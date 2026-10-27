<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestG))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpReleaseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSelectKgs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSelectRolls = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grdDesign = New System.Windows.Forms.DataGridView()
        Me.ds_sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_nob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_rptlen_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ds_rptwth_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts_onhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.btnShowLockedStock = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSelectMts = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSelectYds = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchReqNo = New System.Windows.Forms.Button()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.dtpReqDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboReqNo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optTube2 = New System.Windows.Forms.RadioButton()
        Me.optTube1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optSize2 = New System.Windows.Forms.RadioButton()
        Me.optSize1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.optLogo1 = New System.Windows.Forms.RadioButton()
        Me.grdFreeStockD = New System.Windows.Forms.DataGridView()
        Me.stk_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stk_rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optLogo2 = New System.Windows.Forms.RadioButton()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtVerNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboUOM = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnPrintPackNo = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSavePackNo = New System.Windows.Forms.Button()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.btngout = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        CType(Me.grdDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdReqDetD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdFreeStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReleaseDate.Location = New System.Drawing.Point(568, 56)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpReleaseDate.TabIndex = 133
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(480, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "Release Date"
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(344, 32)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(128, 21)
        Me.cboSoNo.TabIndex = 132
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(344, 56)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(128, 21)
        Me.cboDesignNo.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(264, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "Design No."
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 562)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Kgs."
        '
        'txtSelectKgs
        '
        Me.txtSelectKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectKgs.Location = New System.Drawing.Point(110, 562)
        Me.txtSelectKgs.Name = "txtSelectKgs"
        Me.txtSelectKgs.ReadOnly = True
        Me.txtSelectKgs.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectKgs.TabIndex = 112
        Me.txtSelectKgs.Tag = "0.00"
        Me.txtSelectKgs.Text = "0.00"
        Me.txtSelectKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 538)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Rolls"
        '
        'txtSelectRolls
        '
        Me.txtSelectRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectRolls.Location = New System.Drawing.Point(110, 538)
        Me.txtSelectRolls.Name = "txtSelectRolls"
        Me.txtSelectRolls.ReadOnly = True
        Me.txtSelectRolls.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectRolls.TabIndex = 109
        Me.txtSelectRolls.Tag = "0.00"
        Me.txtSelectRolls.Text = "0.00"
        Me.txtSelectRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 541)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Total Selection"
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveRight.Location = New System.Drawing.Point(586, 351)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveRight.TabIndex = 108
        Me.btnMoveRight.Text = "...>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveLeft.Location = New System.Drawing.Point(586, 327)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveLeft.TabIndex = 107
        Me.btnMoveLeft.Text = "<..."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnDelAll
        '
        Me.btnDelAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelAll.Location = New System.Drawing.Point(586, 462)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(32, 32)
        Me.btnDelAll.TabIndex = 106
        Me.btnDelAll.Text = "<<"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(586, 430)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 32)
        Me.btnDel.TabIndex = 105
        Me.btnDel.Text = "<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(586, 398)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 104
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grdDesign
        '
        Me.grdDesign.AllowUserToAddRows = False
        Me.grdDesign.AllowUserToDeleteRows = False
        Me.grdDesign.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDesign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ds_sonoid, Me.ds_design_no, Me.ds_gwth, Me.ds_col, Me.ds_nob, Me.ds_gr, Me.ds_rptlen_s, Me.ds_rptwth_s, Me.kg_onhand, Me.yds_onhand, Me.mts_onhand})
        Me.grdDesign.Location = New System.Drawing.Point(8, 112)
        Me.grdDesign.Name = "grdDesign"
        Me.grdDesign.Size = New System.Drawing.Size(983, 175)
        Me.grdDesign.TabIndex = 129
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds_col.DefaultCellStyle = DataGridViewCellStyle1
        Me.ds_col.HeaderText = "Color"
        Me.ds_col.Name = "ds_col"
        Me.ds_col.ReadOnly = True
        Me.ds_col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ds_col.Width = 65
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
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(120, 32)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(128, 21)
        Me.cboDocType.TabIndex = 128
        '
        'btnShowLockedStock
        '
        Me.btnShowLockedStock.Image = CType(resources.GetObject("btnShowLockedStock.Image"), System.Drawing.Image)
        Me.btnShowLockedStock.Location = New System.Drawing.Point(672, 72)
        Me.btnShowLockedStock.Name = "btnShowLockedStock"
        Me.btnShowLockedStock.Size = New System.Drawing.Size(136, 32)
        Me.btnShowLockedStock.TabIndex = 127
        Me.btnShowLockedStock.Text = "Show Locked Stock"
        Me.btnShowLockedStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShowLockedStock.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1179, 565)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Location = New System.Drawing.Point(1075, 565)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectedKgs.TabIndex = 121
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1179, 541)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 120
        Me.Label17.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Location = New System.Drawing.Point(1075, 541)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectedRolls.TabIndex = 118
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(979, 541)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 119
        Me.Label18.Text = "Total Selected"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1179, 613)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Location = New System.Drawing.Point(1075, 613)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectedMts.TabIndex = 125
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1179, 589)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Location = New System.Drawing.Point(1075, 589)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectedYds.TabIndex = 123
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(214, 610)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Mts."
        '
        'txtSelectMts
        '
        Me.txtSelectMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectMts.Location = New System.Drawing.Point(110, 610)
        Me.txtSelectMts.Name = "txtSelectMts"
        Me.txtSelectMts.ReadOnly = True
        Me.txtSelectMts.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectMts.TabIndex = 116
        Me.txtSelectMts.Tag = "0.00"
        Me.txtSelectMts.Text = "0.00"
        Me.txtSelectMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(214, 586)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Yds."
        '
        'txtSelectYds
        '
        Me.txtSelectYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectYds.Location = New System.Drawing.Point(110, 586)
        Me.txtSelectYds.Name = "txtSelectYds"
        Me.txtSelectYds.ReadOnly = True
        Me.txtSelectYds.Size = New System.Drawing.Size(96, 22)
        Me.txtSelectYds.TabIndex = 114
        Me.txtSelectYds.Tag = "0.00"
        Me.txtSelectYds.Text = "0.00"
        Me.txtSelectYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSearchReqNo)
        Me.GroupBox1.Controls.Add(Me.lblCancelled)
        Me.GroupBox1.Controls.Add(Me.dtpReqDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtReqNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(1009, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 72)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request Order"
        '
        'btnSearchReqNo
        '
        Me.btnSearchReqNo.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSearchReqNo.Location = New System.Drawing.Point(194, 21)
        Me.btnSearchReqNo.Name = "btnSearchReqNo"
        Me.btnSearchReqNo.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchReqNo.TabIndex = 137
        Me.btnSearchReqNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchReqNo.UseVisualStyleBackColor = True
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(63, 0)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(168, 24)
        Me.lblCancelled.TabIndex = 30
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCancelled.Visible = False
        '
        'dtpReqDate
        '
        Me.dtpReqDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReqDate.Location = New System.Drawing.Point(64, 48)
        Me.dtpReqDate.Name = "dtpReqDate"
        Me.dtpReqDate.Size = New System.Drawing.Size(124, 22)
        Me.dtpReqDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Req Date"
        '
        'txtReqNo
        '
        Me.txtReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(64, 24)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(124, 22)
        Me.txtReqNo.TabIndex = 0
        Me.txtReqNo.Tag = "str"
        Me.txtReqNo.Text = "SO07060000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Req No."
        '
        'grdReqDetD
        '
        Me.grdReqDetD.AllowUserToAddRows = False
        Me.grdReqDetD.AllowUserToDeleteRows = False
        Me.grdReqDetD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdReqDetD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdReqDetD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReqDetD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sel, Me.ReqDetDSubinventoryCode, Me.roll_no, Me.roll_no_o, Me.ReqDetDGammaRollSeqNo, Me.col, Me.custcolor, Me.gr, Me.k, Me.y, Me.m, Me.sonoid, Me.rem_qc})
        Me.grdReqDetD.Location = New System.Drawing.Point(627, 293)
        Me.grdReqDetD.Name = "grdReqDetD"
        Me.grdReqDetD.Size = New System.Drawing.Size(607, 233)
        Me.grdReqDetD.TabIndex = 89
        '
        'sel
        '
        Me.sel.DataPropertyName = "sel"
        Me.sel.HeaderText = "Sel"
        Me.sel.Name = "sel"
        Me.sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sel.Width = 25
        '
        'ReqDetDSubinventoryCode
        '
        Me.ReqDetDSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.ReqDetDSubinventoryCode.HeaderText = "Sub Inventory Code"
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
        Me.roll_no_o.Width = 120
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col.DefaultCellStyle = DataGridViewCellStyle2
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col.Visible = False
        Me.col.Width = 50
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        Me.custcolor.Visible = False
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(382, 22)
        Me.ToolStripLabel2.Text = "** 1 RG / 1 Design No. ,  Don't Show S/O ENT,Don't Show S/O Closed"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboReqNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1246, 25)
        Me.ToolStrip1.TabIndex = 87
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.optTube2)
        Me.GroupBox3.Controls.Add(Me.optTube1)
        Me.GroupBox3.Location = New System.Drawing.Point(413, 539)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 80)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tube"
        '
        'optTube2
        '
        Me.optTube2.AutoSize = True
        Me.optTube2.Location = New System.Drawing.Point(16, 48)
        Me.optTube2.Name = "optTube2"
        Me.optTube2.Size = New System.Drawing.Size(166, 17)
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
        Me.optTube1.Size = New System.Drawing.Size(111, 17)
        Me.optTube1.TabIndex = 0
        Me.optTube1.TabStop = True
        Me.optTube1.Text = "Spool (ม้วนหลอด)"
        Me.optTube1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.optSize2)
        Me.GroupBox2.Controls.Add(Me.optSize1)
        Me.GroupBox2.Location = New System.Drawing.Point(267, 538)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 80)
        Me.GroupBox2.TabIndex = 100
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Version No."
        '
        'optLogo1
        '
        Me.optLogo1.AutoSize = True
        Me.optLogo1.Checked = True
        Me.optLogo1.Location = New System.Drawing.Point(16, 24)
        Me.optLogo1.Name = "optLogo1"
        Me.optLogo1.Size = New System.Drawing.Size(79, 17)
        Me.optLogo1.TabIndex = 0
        Me.optLogo1.TabStop = True
        Me.optLogo1.Text = "Have Logo"
        Me.optLogo1.UseVisualStyleBackColor = True
        '
        'grdFreeStockD
        '
        Me.grdFreeStockD.AllowUserToAddRows = False
        Me.grdFreeStockD.AllowUserToDeleteRows = False
        Me.grdFreeStockD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdFreeStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdFreeStockD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFreeStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stk_sel, Me.stk_custcol, Me.stk_gr, Me.stk_lot, Me.stk_batch, Me.stk_subinventory_code, Me.stk_roll_no, Me.stk_roll_no_o, Me.stk_gamma_roll_seq_no, Me.stk_kg, Me.stk_yds, Me.stk_mts, Me.n_yds, Me.n_mts, Me.A, Me.B, Me.C, Me.D, Me.E, Me.stk_rem_qc})
        Me.grdFreeStockD.Location = New System.Drawing.Point(8, 293)
        Me.grdFreeStockD.Name = "grdFreeStockD"
        Me.grdFreeStockD.Size = New System.Drawing.Size(569, 233)
        Me.grdFreeStockD.TabIndex = 103
        '
        'stk_sel
        '
        Me.stk_sel.DataPropertyName = "sel"
        Me.stk_sel.HeaderText = "Choose"
        Me.stk_sel.Name = "stk_sel"
        Me.stk_sel.Width = 20
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
        Me.stk_custcol.Width = 50
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
        Me.stk_lot.Width = 70
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
        Me.stk_subinventory_code.HeaderText = "Sub Inventory Code"
        Me.stk_subinventory_code.Name = "stk_subinventory_code"
        Me.stk_subinventory_code.ReadOnly = True
        Me.stk_subinventory_code.Width = 70
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
        Me.stk_roll_no_o.Width = 120
        '
        'stk_gamma_roll_seq_no
        '
        Me.stk_gamma_roll_seq_no.DataPropertyName = "gamma_roll_seq_no"
        Me.stk_gamma_roll_seq_no.HeaderText = "Gamma Roll No"
        Me.stk_gamma_roll_seq_no.Name = "stk_gamma_roll_seq_no"
        Me.stk_gamma_roll_seq_no.ReadOnly = True
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
        'A
        '
        Me.A.DataPropertyName = "A"
        Me.A.HeaderText = "A"
        Me.A.Name = "A"
        Me.A.Width = 15
        '
        'B
        '
        Me.B.DataPropertyName = "B"
        Me.B.HeaderText = "B"
        Me.B.Name = "B"
        Me.B.Width = 15
        '
        'C
        '
        Me.C.DataPropertyName = "C"
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        Me.C.Width = 15
        '
        'D
        '
        Me.D.DataPropertyName = "D"
        Me.D.HeaderText = "D"
        Me.D.Name = "D"
        Me.D.Width = 15
        '
        'E
        '
        Me.E.DataPropertyName = "E"
        Me.E.HeaderText = "E"
        Me.E.Name = "E"
        Me.E.Width = 15
        '
        'stk_rem_qc
        '
        Me.stk_rem_qc.DataPropertyName = "rem_qc"
        Me.stk_rem_qc.HeaderText = "Remark QC"
        Me.stk_rem_qc.Name = "stk_rem_qc"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.optLogo2)
        Me.GroupBox4.Controls.Add(Me.optLogo1)
        Me.GroupBox4.Location = New System.Drawing.Point(643, 538)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(128, 80)
        Me.GroupBox4.TabIndex = 102
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calista Logo"
        '
        'optLogo2
        '
        Me.optLogo2.AutoSize = True
        Me.optLogo2.Location = New System.Drawing.Point(16, 48)
        Me.optLogo2.Name = "optLogo2"
        Me.optLogo2.Size = New System.Drawing.Size(69, 17)
        Me.optLogo2.TabIndex = 1
        Me.optLogo2.Text = "No Logo"
        Me.optLogo2.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(344, 80)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(320, 22)
        Me.txtRemark.TabIndex = 96
        Me.txtRemark.Tag = "str"
        '
        'txtVerNo
        '
        Me.txtVerNo.Location = New System.Drawing.Point(120, 80)
        Me.txtVerNo.Name = "txtVerNo"
        Me.txtVerNo.Size = New System.Drawing.Size(128, 22)
        Me.txtVerNo.TabIndex = 97
        Me.txtVerNo.Tag = "str"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(264, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Remarks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Customer Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "S/O No."
        '
        'cboUOM
        '
        Me.cboUOM.FormattingEnabled = True
        Me.cboUOM.Location = New System.Drawing.Point(120, 56)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Size = New System.Drawing.Size(128, 21)
        Me.cboUOM.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Unit Of Mesurement"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(568, 32)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(240, 21)
        Me.cboCustomer.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Request For"
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(814, 73)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(182, 32)
        Me.chkAutoCalculate.TabIndex = 136
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.Location = New System.Drawing.Point(814, 53)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(104, 22)
        Me.txtBarcode.TabIndex = 137
        Me.txtBarcode.Tag = "str"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(814, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 138
        Me.Label21.Text = "Barcode"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.btnPrintPackNo)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.btnSavePackNo)
        Me.GroupBox6.Controls.Add(Me.txtPackNo)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.DtpPackDate)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Location = New System.Drawing.Point(1009, 107)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(225, 94)
        Me.GroupBox6.TabIndex = 144
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Packing List"
        '
        'btnPrintPackNo
        '
        Me.btnPrintPackNo.Enabled = False
        Me.btnPrintPackNo.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrintPackNo.Location = New System.Drawing.Point(194, 46)
        Me.btnPrintPackNo.Name = "btnPrintPackNo"
        Me.btnPrintPackNo.Size = New System.Drawing.Size(25, 25)
        Me.btnPrintPackNo.TabIndex = 138
        Me.btnPrintPackNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintPackNo.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(69, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 21)
        Me.Label24.TabIndex = 137
        Me.Label24.Text = "Cancelled"
        Me.Label24.Visible = False
        '
        'btnSavePackNo
        '
        Me.btnSavePackNo.Enabled = False
        Me.btnSavePackNo.Image = CType(resources.GetObject("btnSavePackNo.Image"), System.Drawing.Image)
        Me.btnSavePackNo.Location = New System.Drawing.Point(194, 16)
        Me.btnSavePackNo.Name = "btnSavePackNo"
        Me.btnSavePackNo.Size = New System.Drawing.Size(25, 25)
        Me.btnSavePackNo.TabIndex = 136
        Me.btnSavePackNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSavePackNo.UseVisualStyleBackColor = True
        '
        'txtPackNo
        '
        Me.txtPackNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(73, 21)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.ReadOnly = True
        Me.txtPackNo.Size = New System.Drawing.Size(115, 20)
        Me.txtPackNo.TabIndex = 129
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 130
        Me.Label22.Text = "Pack No."
        '
        'DtpPackDate
        '
        Me.DtpPackDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(73, 47)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(115, 22)
        Me.DtpPackDate.TabIndex = 131
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 132
        Me.Label23.Text = "Date"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.BtnYarnPrintBar)
        Me.GroupBox7.Controls.Add(Me.btngout)
        Me.GroupBox7.Controls.Add(Me.lblOutdt)
        Me.GroupBox7.Controls.Add(Me.DtpOutdt)
        Me.GroupBox7.Controls.Add(Me.txtOutNo)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Location = New System.Drawing.Point(1009, 205)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(225, 81)
        Me.GroupBox7.TabIndex = 145
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Out"
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnYarnPrintBar.Enabled = False
        Me.BtnYarnPrintBar.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(194, 45)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(25, 25)
        Me.BtnYarnPrintBar.TabIndex = 144
        Me.BtnYarnPrintBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = True
        '
        'btngout
        '
        Me.btngout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.Location = New System.Drawing.Point(194, 15)
        Me.btngout.Name = "btngout"
        Me.btngout.Size = New System.Drawing.Size(25, 25)
        Me.btngout.TabIndex = 143
        Me.btngout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngout.UseVisualStyleBackColor = True
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(7, 49)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(56, 13)
        Me.lblOutdt.TabIndex = 142
        Me.lblOutdt.Text = "OUT Date"
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
        Me.DtpOutdt.Size = New System.Drawing.Size(113, 22)
        Me.DtpOutdt.TabIndex = 141
        '
        'txtOutNo
        '
        Me.txtOutNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(75, 20)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(113, 20)
        Me.txtOutNo.TabIndex = 139
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 140
        Me.Label25.Text = "OUT No."
        '
        'frmRequestG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 639)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.dtpReleaseDate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cboSoNo)
        Me.Controls.Add(Me.cboDesignNo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSelectKgs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSelectRolls)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdDesign)
        Me.Controls.Add(Me.cboDocType)
        Me.Controls.Add(Me.btnShowLockedStock)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSelectedKgs)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSelectedRolls)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSelectedMts)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSelectedYds)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSelectMts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSelectYds)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdReqDetD)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.grdFreeStockD)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtVerNo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboUOM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRequestG"
        Me.Text = "Request Greige"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdDesign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdReqDetD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdFreeStockD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpReleaseDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents txtSelectKgs As System.Windows.Forms.TextBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents txtSelectRolls As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents btnMoveRight As System.Windows.Forms.Button
	Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
	Friend WithEvents btnDelAll As System.Windows.Forms.Button
	Friend WithEvents btnDel As System.Windows.Forms.Button
	Friend WithEvents btnAdd As System.Windows.Forms.Button
	Friend WithEvents grdDesign As System.Windows.Forms.DataGridView
	Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
	Friend WithEvents btnShowLockedStock As System.Windows.Forms.Button
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents txtSelectMts As System.Windows.Forms.TextBox
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents txtSelectYds As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents lblCancelled As System.Windows.Forms.Label
	Friend WithEvents dtpReqDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents grdReqDetD As System.Windows.Forms.DataGridView
	Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboReqNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents optTube2 As System.Windows.Forms.RadioButton
	Friend WithEvents optTube1 As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents optSize2 As System.Windows.Forms.RadioButton
	Friend WithEvents optSize1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents optLogo1 As System.Windows.Forms.RadioButton
	Friend WithEvents grdFreeStockD As System.Windows.Forms.DataGridView
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents optLogo2 As System.Windows.Forms.RadioButton
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
	Friend WithEvents txtVerNo As System.Windows.Forms.TextBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents cboUOM As System.Windows.Forms.ComboBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents ds_sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_design_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_gwth As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_col As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_nob As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_rptlen_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ds_rptwth_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_onhand As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents yds_onhand As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents mts_onhand As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnPrintPackNo As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents btnSavePackNo As Button
    Friend WithEvents txtPackNo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents DtpPackDate As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents stk_sel As DataGridViewCheckBoxColumn
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
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents B As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents D As DataGridViewTextBoxColumn
    Friend WithEvents E As DataGridViewTextBoxColumn
    Friend WithEvents stk_rem_qc As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnYarnPrintBar As Button
    Friend WithEvents btngout As Button
    Friend WithEvents lblOutdt As Label
    Friend WithEvents DtpOutdt As DateTimePicker
    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents btnSearchReqNo As Button
End Class
