<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyedOutSample
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedOutSample))
        Me.lbDesignNo = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.lblStockMts = New System.Windows.Forms.Label()
        Me.txtSelectMts = New System.Windows.Forms.TextBox()
        Me.lblStockYds = New System.Windows.Forms.Label()
        Me.txtSelectYds = New System.Windows.Forms.TextBox()
        Me.lblStockKgs = New System.Windows.Forms.Label()
        Me.txtSelectKgs = New System.Windows.Forms.TextBox()
        Me.lblStockRoll = New System.Windows.Forms.Label()
        Me.txtSelectRolls = New System.Windows.Forms.TextBox()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.grdDoutNew = New System.Windows.Forms.DataGridView()
        Me.grdDoutNewSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdDoutNewoutno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewoutdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewsonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestMtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRemQC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewLocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStock = New System.Windows.Forms.DataGridView()
        Me.grdDoutStockSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdDoutStockDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStocksonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRequestkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRequestMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRequestYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRequestMtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockRemQC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutStockLocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintPLS = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintSampleOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.btnPrinttagForSample = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrinttagForSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPrintTag = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtOutno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpOutDt = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCol = New System.Windows.Forms.TextBox()
        Me.txtRefdesno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbBalanceStock = New System.Windows.Forms.Label()
        Me.lbStockOut = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddr1 = New System.Windows.Forms.TextBox()
        Me.cboempcd = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSearchCustomers = New System.Windows.Forms.Button()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnMakeDyedout = New System.Windows.Forms.Button()
        Me.dtpPackdt = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtpackno = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblTitleSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.lblCountHeader = New System.Windows.Forms.ToolStripLabel()
        Me.btnSearchPLS = New System.Windows.Forms.Button()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.grdDoutNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDoutStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbDesignNo
        '
        Me.lbDesignNo.AutoSize = True
        Me.lbDesignNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesignNo.Location = New System.Drawing.Point(6, 26)
        Me.lbDesignNo.Name = "lbDesignNo"
        Me.lbDesignNo.Size = New System.Drawing.Size(73, 17)
        Me.lbDesignNo.TabIndex = 2
        Me.lbDesignNo.Text = "Design No."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(81, 21)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(168, 25)
        Me.txtDesignNo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(643, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Col Code No."
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(684, 23)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(100, 25)
        Me.txtLot.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Customer ."
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(344, 30)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(317, 21)
        Me.cboCustomer.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1064, 550)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 17)
        Me.Label12.TabIndex = 324
        Me.Label12.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedMts.Location = New System.Drawing.Point(986, 546)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(72, 25)
        Me.txtSelectedMts.TabIndex = 323
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1176, 550)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 322
        Me.Label13.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedYds.Location = New System.Drawing.Point(1098, 546)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(72, 25)
        Me.txtSelectedYds.TabIndex = 321
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(945, 550)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 17)
        Me.Label15.TabIndex = 320
        Me.Label15.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedKgs.Location = New System.Drawing.Point(861, 546)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(78, 25)
        Me.txtSelectedKgs.TabIndex = 319
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(834, 550)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 17)
        Me.Label17.TabIndex = 318
        Me.Label17.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectedRolls.Location = New System.Drawing.Point(750, 546)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(78, 25)
        Me.txtSelectedRolls.TabIndex = 317
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockMts
        '
        Me.lblStockMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockMts.AutoSize = True
        Me.lblStockMts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockMts.Location = New System.Drawing.Point(1063, 371)
        Me.lblStockMts.Name = "lblStockMts"
        Me.lblStockMts.Size = New System.Drawing.Size(33, 17)
        Me.lblStockMts.TabIndex = 314
        Me.lblStockMts.Text = "Mts."
        '
        'txtSelectMts
        '
        Me.txtSelectMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectMts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectMts.Location = New System.Drawing.Point(985, 367)
        Me.txtSelectMts.Name = "txtSelectMts"
        Me.txtSelectMts.ReadOnly = True
        Me.txtSelectMts.Size = New System.Drawing.Size(72, 25)
        Me.txtSelectMts.TabIndex = 313
        Me.txtSelectMts.Tag = "0.00"
        Me.txtSelectMts.Text = "0.00"
        Me.txtSelectMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockYds
        '
        Me.lblStockYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockYds.AutoSize = True
        Me.lblStockYds.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockYds.Location = New System.Drawing.Point(1175, 371)
        Me.lblStockYds.Name = "lblStockYds"
        Me.lblStockYds.Size = New System.Drawing.Size(32, 17)
        Me.lblStockYds.TabIndex = 312
        Me.lblStockYds.Text = "Yds."
        '
        'txtSelectYds
        '
        Me.txtSelectYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectYds.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectYds.Location = New System.Drawing.Point(1097, 367)
        Me.txtSelectYds.Name = "txtSelectYds"
        Me.txtSelectYds.ReadOnly = True
        Me.txtSelectYds.Size = New System.Drawing.Size(72, 25)
        Me.txtSelectYds.TabIndex = 311
        Me.txtSelectYds.Tag = "0.00"
        Me.txtSelectYds.Text = "0.00"
        Me.txtSelectYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockKgs
        '
        Me.lblStockKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockKgs.AutoSize = True
        Me.lblStockKgs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockKgs.Location = New System.Drawing.Point(944, 371)
        Me.lblStockKgs.Name = "lblStockKgs"
        Me.lblStockKgs.Size = New System.Drawing.Size(33, 17)
        Me.lblStockKgs.TabIndex = 310
        Me.lblStockKgs.Text = "Kgs."
        '
        'txtSelectKgs
        '
        Me.txtSelectKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectKgs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectKgs.Location = New System.Drawing.Point(865, 367)
        Me.txtSelectKgs.Name = "txtSelectKgs"
        Me.txtSelectKgs.ReadOnly = True
        Me.txtSelectKgs.Size = New System.Drawing.Size(73, 25)
        Me.txtSelectKgs.TabIndex = 309
        Me.txtSelectKgs.Tag = "0.00"
        Me.txtSelectKgs.Text = "0.00"
        Me.txtSelectKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockRoll
        '
        Me.lblStockRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockRoll.AutoSize = True
        Me.lblStockRoll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockRoll.Location = New System.Drawing.Point(833, 371)
        Me.lblStockRoll.Name = "lblStockRoll"
        Me.lblStockRoll.Size = New System.Drawing.Size(36, 17)
        Me.lblStockRoll.TabIndex = 308
        Me.lblStockRoll.Text = "Rolls"
        '
        'txtSelectRolls
        '
        Me.txtSelectRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectRolls.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelectRolls.Location = New System.Drawing.Point(754, 367)
        Me.txtSelectRolls.Name = "txtSelectRolls"
        Me.txtSelectRolls.ReadOnly = True
        Me.txtSelectRolls.Size = New System.Drawing.Size(73, 25)
        Me.txtSelectRolls.TabIndex = 307
        Me.txtSelectRolls.Tag = "0.00"
        Me.txtSelectRolls.Text = "0.00"
        Me.txtSelectRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(416, 366)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(56, 32)
        Me.btnMoveRight.TabIndex = 306
        Me.btnMoveRight.Text = "Down"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(478, 367)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(56, 32)
        Me.btnMoveLeft.TabIndex = 305
        Me.btnMoveLeft.Text = "Up"
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'grdDoutNew
        '
        Me.grdDoutNew.AllowUserToAddRows = False
        Me.grdDoutNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDoutNew.ColumnHeadersHeight = 60
        Me.grdDoutNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdDoutNew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDoutNewSel, Me.grdDoutNewoutno, Me.grdDoutNewoutdt, Me.grdDoutNewDesignNo, Me.grdDoutNewRefdesno, Me.grdDoutNewCol, Me.grdDoutNewCustColor, Me.grdDoutNewLot, Me.grdDoutNewRollNoD, Me.grdDoutNewRollNoO, Me.grdDoutNewsonoid, Me.grdDoutNewKg, Me.grdDoutNewMts, Me.grdDoutNewYds, Me.grdDoutNewRequestKg, Me.grdDoutNewRequestMts, Me.grdDoutNewRequestYds, Me.grdDoutNewRequestMtkg, Me.grdDoutNewRemQC, Me.grdDoutNewWarehouseCode, Me.grdDoutNewSubinventoryCode, Me.grdDoutNewLocationName})
        Me.grdDoutNew.Location = New System.Drawing.Point(36, 405)
        Me.grdDoutNew.Name = "grdDoutNew"
        Me.grdDoutNew.Size = New System.Drawing.Size(1172, 132)
        Me.grdDoutNew.TabIndex = 301
        '
        'grdDoutNewSel
        '
        Me.grdDoutNewSel.DataPropertyName = "Sel"
        Me.grdDoutNewSel.HeaderText = "Sel"
        Me.grdDoutNewSel.Name = "grdDoutNewSel"
        Me.grdDoutNewSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDoutNewSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdDoutNewSel.Width = 50
        '
        'grdDoutNewoutno
        '
        Me.grdDoutNewoutno.DataPropertyName = "outno"
        Me.grdDoutNewoutno.HeaderText = "Out No."
        Me.grdDoutNewoutno.Name = "grdDoutNewoutno"
        Me.grdDoutNewoutno.Visible = False
        Me.grdDoutNewoutno.Width = 80
        '
        'grdDoutNewoutdt
        '
        Me.grdDoutNewoutdt.DataPropertyName = "outdt"
        Me.grdDoutNewoutdt.HeaderText = "Out Date."
        Me.grdDoutNewoutdt.Name = "grdDoutNewoutdt"
        Me.grdDoutNewoutdt.Visible = False
        Me.grdDoutNewoutdt.Width = 80
        '
        'grdDoutNewDesignNo
        '
        Me.grdDoutNewDesignNo.DataPropertyName = "design_no"
        Me.grdDoutNewDesignNo.HeaderText = "Design No"
        Me.grdDoutNewDesignNo.Name = "grdDoutNewDesignNo"
        Me.grdDoutNewDesignNo.Width = 120
        '
        'grdDoutNewRefdesno
        '
        Me.grdDoutNewRefdesno.DataPropertyName = "refdesco"
        Me.grdDoutNewRefdesno.HeaderText = "Article"
        Me.grdDoutNewRefdesno.Name = "grdDoutNewRefdesno"
        '
        'grdDoutNewCol
        '
        Me.grdDoutNewCol.DataPropertyName = "col"
        Me.grdDoutNewCol.HeaderText = "Col Code"
        Me.grdDoutNewCol.Name = "grdDoutNewCol"
        '
        'grdDoutNewCustColor
        '
        Me.grdDoutNewCustColor.DataPropertyName = "custcolor"
        Me.grdDoutNewCustColor.HeaderText = "Cust. Col."
        Me.grdDoutNewCustColor.Name = "grdDoutNewCustColor"
        '
        'grdDoutNewLot
        '
        Me.grdDoutNewLot.DataPropertyName = "lot"
        Me.grdDoutNewLot.HeaderText = "Lot"
        Me.grdDoutNewLot.Name = "grdDoutNewLot"
        '
        'grdDoutNewRollNoD
        '
        Me.grdDoutNewRollNoD.DataPropertyName = "roll_no_d"
        Me.grdDoutNewRollNoD.HeaderText = "Roll No."
        Me.grdDoutNewRollNoD.Name = "grdDoutNewRollNoD"
        '
        'grdDoutNewRollNoO
        '
        Me.grdDoutNewRollNoO.DataPropertyName = "roll_no_o"
        Me.grdDoutNewRollNoO.HeaderText = "Fact. Roll."
        Me.grdDoutNewRollNoO.Name = "grdDoutNewRollNoO"
        '
        'grdDoutNewsonoid
        '
        Me.grdDoutNewsonoid.DataPropertyName = "sonoid"
        Me.grdDoutNewsonoid.HeaderText = "SO ID"
        Me.grdDoutNewsonoid.Name = "grdDoutNewsonoid"
        '
        'grdDoutNewKg
        '
        Me.grdDoutNewKg.DataPropertyName = "kg"
        Me.grdDoutNewKg.HeaderText = "Bal Kg"
        Me.grdDoutNewKg.Name = "grdDoutNewKg"
        Me.grdDoutNewKg.Visible = False
        Me.grdDoutNewKg.Width = 50
        '
        'grdDoutNewMts
        '
        Me.grdDoutNewMts.DataPropertyName = "mts"
        Me.grdDoutNewMts.HeaderText = "Bal Mts."
        Me.grdDoutNewMts.Name = "grdDoutNewMts"
        Me.grdDoutNewMts.Visible = False
        Me.grdDoutNewMts.Width = 50
        '
        'grdDoutNewYds
        '
        Me.grdDoutNewYds.DataPropertyName = "yds"
        Me.grdDoutNewYds.HeaderText = "Bal Yds."
        Me.grdDoutNewYds.Name = "grdDoutNewYds"
        Me.grdDoutNewYds.Visible = False
        Me.grdDoutNewYds.Width = 50
        '
        'grdDoutNewRequestKg
        '
        Me.grdDoutNewRequestKg.DataPropertyName = "request_kg"
        Me.grdDoutNewRequestKg.HeaderText = "Req Kg"
        Me.grdDoutNewRequestKg.Name = "grdDoutNewRequestKg"
        Me.grdDoutNewRequestKg.Width = 50
        '
        'grdDoutNewRequestMts
        '
        Me.grdDoutNewRequestMts.DataPropertyName = "request_mts"
        Me.grdDoutNewRequestMts.HeaderText = "Req Mts"
        Me.grdDoutNewRequestMts.Name = "grdDoutNewRequestMts"
        Me.grdDoutNewRequestMts.Width = 50
        '
        'grdDoutNewRequestYds
        '
        Me.grdDoutNewRequestYds.DataPropertyName = "request_yds"
        Me.grdDoutNewRequestYds.HeaderText = "Req Yds"
        Me.grdDoutNewRequestYds.Name = "grdDoutNewRequestYds"
        Me.grdDoutNewRequestYds.Width = 50
        '
        'grdDoutNewRequestMtkg
        '
        Me.grdDoutNewRequestMtkg.DataPropertyName = "mtkg"
        Me.grdDoutNewRequestMtkg.HeaderText = "Mtkg"
        Me.grdDoutNewRequestMtkg.Name = "grdDoutNewRequestMtkg"
        Me.grdDoutNewRequestMtkg.Width = 50
        '
        'grdDoutNewRemQC
        '
        Me.grdDoutNewRemQC.DataPropertyName = "rem_qc"
        Me.grdDoutNewRemQC.HeaderText = "Remark QC"
        Me.grdDoutNewRemQC.Name = "grdDoutNewRemQC"
        Me.grdDoutNewRemQC.Width = 150
        '
        'grdDoutNewWarehouseCode
        '
        Me.grdDoutNewWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdDoutNewWarehouseCode.HeaderText = "W/H"
        Me.grdDoutNewWarehouseCode.Name = "grdDoutNewWarehouseCode"
        Me.grdDoutNewWarehouseCode.Width = 50
        '
        'grdDoutNewSubinventoryCode
        '
        Me.grdDoutNewSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.grdDoutNewSubinventoryCode.HeaderText = "SubInven"
        Me.grdDoutNewSubinventoryCode.Name = "grdDoutNewSubinventoryCode"
        Me.grdDoutNewSubinventoryCode.Width = 90
        '
        'grdDoutNewLocationName
        '
        Me.grdDoutNewLocationName.DataPropertyName = "location_name"
        Me.grdDoutNewLocationName.HeaderText = "Loc"
        Me.grdDoutNewLocationName.Name = "grdDoutNewLocationName"
        Me.grdDoutNewLocationName.Width = 50
        '
        'grdDoutStock
        '
        Me.grdDoutStock.AllowUserToAddRows = False
        Me.grdDoutStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDoutStock.ColumnHeadersHeight = 60
        Me.grdDoutStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdDoutStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDoutStockSel, Me.grdDoutStockDesignNo, Me.grdDoutStockRefdesno, Me.grdDoutStockCol, Me.grdDoutStockCustColor, Me.grdDoutStockLot, Me.grdDoutStockRollNoO, Me.grdDoutStockRollNoD, Me.grdDoutStocksonoid, Me.grdDoutStockKg, Me.grdDoutStockMts, Me.grdDoutStockYds, Me.grdDoutStockRequestkg, Me.grdDoutStockRequestMts, Me.grdDoutStockRequestYds, Me.grdDoutStockRequestMtkg, Me.grdDoutStockRemQC, Me.grdDoutStockWarehouseCode, Me.grdDoutStockSubinventoryCode, Me.grdDoutStockLocationName})
        Me.grdDoutStock.Location = New System.Drawing.Point(36, 231)
        Me.grdDoutStock.Name = "grdDoutStock"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDoutStock.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdDoutStock.Size = New System.Drawing.Size(1171, 134)
        Me.grdDoutStock.TabIndex = 300
        '
        'grdDoutStockSel
        '
        Me.grdDoutStockSel.DataPropertyName = "sel"
        Me.grdDoutStockSel.HeaderText = "Sel"
        Me.grdDoutStockSel.Name = "grdDoutStockSel"
        Me.grdDoutStockSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDoutStockSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdDoutStockSel.Width = 50
        '
        'grdDoutStockDesignNo
        '
        Me.grdDoutStockDesignNo.DataPropertyName = "design_no"
        Me.grdDoutStockDesignNo.HeaderText = "Design No"
        Me.grdDoutStockDesignNo.Name = "grdDoutStockDesignNo"
        Me.grdDoutStockDesignNo.Width = 120
        '
        'grdDoutStockRefdesno
        '
        Me.grdDoutStockRefdesno.DataPropertyName = "refdesno"
        Me.grdDoutStockRefdesno.HeaderText = "Article"
        Me.grdDoutStockRefdesno.Name = "grdDoutStockRefdesno"
        '
        'grdDoutStockCol
        '
        Me.grdDoutStockCol.DataPropertyName = "col"
        Me.grdDoutStockCol.HeaderText = "Col Code"
        Me.grdDoutStockCol.Name = "grdDoutStockCol"
        '
        'grdDoutStockCustColor
        '
        Me.grdDoutStockCustColor.DataPropertyName = "custcolor"
        Me.grdDoutStockCustColor.HeaderText = "Cust. Col"
        Me.grdDoutStockCustColor.Name = "grdDoutStockCustColor"
        '
        'grdDoutStockLot
        '
        Me.grdDoutStockLot.DataPropertyName = "lot"
        Me.grdDoutStockLot.HeaderText = "Lot"
        Me.grdDoutStockLot.Name = "grdDoutStockLot"
        '
        'grdDoutStockRollNoO
        '
        Me.grdDoutStockRollNoO.DataPropertyName = "roll_no_o"
        Me.grdDoutStockRollNoO.HeaderText = "Fact. Roll"
        Me.grdDoutStockRollNoO.Name = "grdDoutStockRollNoO"
        '
        'grdDoutStockRollNoD
        '
        Me.grdDoutStockRollNoD.DataPropertyName = "roll_no_d"
        Me.grdDoutStockRollNoD.HeaderText = "Roll No"
        Me.grdDoutStockRollNoD.Name = "grdDoutStockRollNoD"
        '
        'grdDoutStocksonoid
        '
        Me.grdDoutStocksonoid.DataPropertyName = "sonoid"
        Me.grdDoutStocksonoid.HeaderText = "SO ID"
        Me.grdDoutStocksonoid.Name = "grdDoutStocksonoid"
        '
        'grdDoutStockKg
        '
        Me.grdDoutStockKg.DataPropertyName = "kg"
        Me.grdDoutStockKg.HeaderText = "Bal Kg."
        Me.grdDoutStockKg.Name = "grdDoutStockKg"
        Me.grdDoutStockKg.ReadOnly = True
        Me.grdDoutStockKg.Width = 50
        '
        'grdDoutStockMts
        '
        Me.grdDoutStockMts.DataPropertyName = "mts"
        Me.grdDoutStockMts.HeaderText = "Bal Mts"
        Me.grdDoutStockMts.Name = "grdDoutStockMts"
        Me.grdDoutStockMts.ReadOnly = True
        Me.grdDoutStockMts.Width = 50
        '
        'grdDoutStockYds
        '
        Me.grdDoutStockYds.DataPropertyName = "yds"
        Me.grdDoutStockYds.HeaderText = "Bal Yds"
        Me.grdDoutStockYds.Name = "grdDoutStockYds"
        Me.grdDoutStockYds.ReadOnly = True
        Me.grdDoutStockYds.Width = 50
        '
        'grdDoutStockRequestkg
        '
        Me.grdDoutStockRequestkg.DataPropertyName = "request_kg"
        Me.grdDoutStockRequestkg.HeaderText = "Req Kg"
        Me.grdDoutStockRequestkg.Name = "grdDoutStockRequestkg"
        Me.grdDoutStockRequestkg.Visible = False
        Me.grdDoutStockRequestkg.Width = 50
        '
        'grdDoutStockRequestMts
        '
        Me.grdDoutStockRequestMts.DataPropertyName = "request_mts"
        Me.grdDoutStockRequestMts.HeaderText = "Req Mts"
        Me.grdDoutStockRequestMts.Name = "grdDoutStockRequestMts"
        Me.grdDoutStockRequestMts.Visible = False
        Me.grdDoutStockRequestMts.Width = 50
        '
        'grdDoutStockRequestYds
        '
        Me.grdDoutStockRequestYds.DataPropertyName = "request_yds"
        Me.grdDoutStockRequestYds.HeaderText = "Req Yds"
        Me.grdDoutStockRequestYds.Name = "grdDoutStockRequestYds"
        Me.grdDoutStockRequestYds.Visible = False
        Me.grdDoutStockRequestYds.Width = 50
        '
        'grdDoutStockRequestMtkg
        '
        Me.grdDoutStockRequestMtkg.DataPropertyName = "mtkg"
        Me.grdDoutStockRequestMtkg.HeaderText = "Mtkg"
        Me.grdDoutStockRequestMtkg.Name = "grdDoutStockRequestMtkg"
        Me.grdDoutStockRequestMtkg.Width = 50
        '
        'grdDoutStockRemQC
        '
        Me.grdDoutStockRemQC.DataPropertyName = "rem_qc"
        Me.grdDoutStockRemQC.HeaderText = "Remark QC"
        Me.grdDoutStockRemQC.Name = "grdDoutStockRemQC"
        Me.grdDoutStockRemQC.Width = 150
        '
        'grdDoutStockWarehouseCode
        '
        Me.grdDoutStockWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdDoutStockWarehouseCode.HeaderText = "W/H"
        Me.grdDoutStockWarehouseCode.Name = "grdDoutStockWarehouseCode"
        Me.grdDoutStockWarehouseCode.Width = 50
        '
        'grdDoutStockSubinventoryCode
        '
        Me.grdDoutStockSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.grdDoutStockSubinventoryCode.HeaderText = "SubInven."
        Me.grdDoutStockSubinventoryCode.Name = "grdDoutStockSubinventoryCode"
        Me.grdDoutStockSubinventoryCode.Width = 90
        '
        'grdDoutStockLocationName
        '
        Me.grdDoutStockLocationName.DataPropertyName = "location_name"
        Me.grdDoutStockLocationName.HeaderText = "Loc."
        Me.grdDoutStockLocationName.Name = "grdDoutStockLocationName"
        Me.grdDoutStockLocationName.Width = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.btnPrintPLS, Me.btnPrintSampleOut, Me.ToolStripSplitButton1, Me.BtnPrintTag, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1220, 25)
        Me.ToolStrip1.TabIndex = 327
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 22)
        Me.btnSave.Text = "Save PLS"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 22)
        Me.btnCancel.Text = "Cancel PLS"
        '
        'btnPrintPLS
        '
        Me.btnPrintPLS.Image = CType(resources.GetObject("btnPrintPLS.Image"), System.Drawing.Image)
        Me.btnPrintPLS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintPLS.Name = "btnPrintPLS"
        Me.btnPrintPLS.Size = New System.Drawing.Size(74, 22)
        Me.btnPrintPLS.Tag = "p_mfg_dout_sample_pkg_pls_rep"
        Me.btnPrintPLS.Text = "Print PLS"
        '
        'btnPrintSampleOut
        '
        Me.btnPrintSampleOut.Image = CType(resources.GetObject("btnPrintSampleOut.Image"), System.Drawing.Image)
        Me.btnPrintSampleOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintSampleOut.Name = "btnPrintSampleOut"
        Me.btnPrintSampleOut.Size = New System.Drawing.Size(83, 22)
        Me.btnPrintSampleOut.Tag = "p_mfg_dout_sample_pkg_pls_rep"
        Me.btnPrintSampleOut.Text = "Print DOM"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrinttagForSample, Me.btnPrinttagForSales})
        Me.ToolStripSplitButton1.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripSplitButton1.Text = "Print Tag"
        '
        'btnPrinttagForSample
        '
        Me.btnPrinttagForSample.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrinttagForSample.Name = "btnPrinttagForSample"
        Me.btnPrinttagForSample.Size = New System.Drawing.Size(156, 22)
        Me.btnPrinttagForSample.Text = "Tag For Sample"
        '
        'btnPrinttagForSales
        '
        Me.btnPrinttagForSales.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrinttagForSales.Name = "btnPrinttagForSales"
        Me.btnPrinttagForSales.Size = New System.Drawing.Size(156, 22)
        Me.btnPrinttagForSales.Text = "Tag For Sales"
        '
        'BtnPrintTag
        '
        Me.BtnPrintTag.Image = CType(resources.GetObject("BtnPrintTag.Image"), System.Drawing.Image)
        Me.BtnPrintTag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintTag.Name = "BtnPrintTag"
        Me.BtnPrintTag.Size = New System.Drawing.Size(83, 22)
        Me.BtnPrintTag.Text = "Print (Tag)"
        Me.BtnPrintTag.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtOutno
        '
        Me.txtOutno.Enabled = False
        Me.txtOutno.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOutno.Location = New System.Drawing.Point(59, 21)
        Me.txtOutno.Name = "txtOutno"
        Me.txtOutno.ReadOnly = True
        Me.txtOutno.Size = New System.Drawing.Size(108, 25)
        Me.txtOutno.TabIndex = 329
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Out No."
        '
        'dtpOutDt
        '
        Me.dtpOutDt.Checked = False
        Me.dtpOutDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpOutDt.Enabled = False
        Me.dtpOutDt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtpOutDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutDt.Location = New System.Drawing.Point(59, 52)
        Me.dtpOutDt.Name = "dtpOutDt"
        Me.dtpOutDt.ShowCheckBox = True
        Me.dtpOutDt.Size = New System.Drawing.Size(108, 25)
        Me.dtpOutDt.TabIndex = 330
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Out Date"
        '
        'txtCol
        '
        Me.txtCol.Location = New System.Drawing.Point(551, 21)
        Me.txtCol.Name = "txtCol"
        Me.txtCol.Size = New System.Drawing.Size(81, 25)
        Me.txtCol.TabIndex = 332
        '
        'txtRefdesno
        '
        Me.txtRefdesno.Location = New System.Drawing.Point(344, 21)
        Me.txtRefdesno.Name = "txtRefdesno"
        Me.txtRefdesno.Size = New System.Drawing.Size(117, 25)
        Me.txtRefdesno.TabIndex = 334
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 333
        Me.Label6.Text = "Article Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbDesignNo)
        Me.GroupBox1.Controls.Add(Me.txtRefdesno)
        Me.GroupBox1.Controls.Add(Me.txtDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCol)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLot)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 59)
        Me.GroupBox1.TabIndex = 335
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Filter"
        '
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(81, 29)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(183, 25)
        Me.cboDocType.TabIndex = 336
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 335
        Me.Label7.Text = "Doc Type"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lbBalanceStock
        '
        Me.lbBalanceStock.AutoSize = True
        Me.lbBalanceStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBalanceStock.Location = New System.Drawing.Point(33, 211)
        Me.lbBalanceStock.Name = "lbBalanceStock"
        Me.lbBalanceStock.Size = New System.Drawing.Size(92, 17)
        Me.lbBalanceStock.TabIndex = 337
        Me.lbBalanceStock.Text = "Balance Stock"
        '
        'lbStockOut
        '
        Me.lbStockOut.AutoSize = True
        Me.lbStockOut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStockOut.Location = New System.Drawing.Point(33, 376)
        Me.lbStockOut.Name = "lbStockOut"
        Me.lbStockOut.Size = New System.Drawing.Size(68, 17)
        Me.lbStockOut.TabIndex = 338
        Me.lbStockOut.Text = "Stock Out"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtRemark)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtaddr1)
        Me.GroupBox2.Controls.Add(Me.cboempcd)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboDocType)
        Me.GroupBox2.Controls.Add(Me.btnSearchCustomers)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(928, 100)
        Me.GroupBox2.TabIndex = 339
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(753, 30)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(161, 50)
        Me.txtRemark.TabIndex = 342
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(694, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 341
        Me.Label9.Text = "Remark"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(282, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 340
        Me.Label8.Text = "Address"
        '
        'txtaddr1
        '
        Me.txtaddr1.Enabled = False
        Me.txtaddr1.Location = New System.Drawing.Point(344, 58)
        Me.txtaddr1.Name = "txtaddr1"
        Me.txtaddr1.ReadOnly = True
        Me.txtaddr1.Size = New System.Drawing.Size(317, 25)
        Me.txtaddr1.TabIndex = 339
        '
        'cboempcd
        '
        Me.cboempcd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboempcd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempcd.FormattingEnabled = True
        Me.cboempcd.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.cboempcd.Location = New System.Drawing.Point(81, 58)
        Me.cboempcd.Name = "cboempcd"
        Me.cboempcd.Size = New System.Drawing.Size(183, 25)
        Me.cboempcd.TabIndex = 337
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(6, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 17)
        Me.Label24.TabIndex = 338
        Me.Label24.Text = "Request by:"
        '
        'btnSearchCustomers
        '
        Me.btnSearchCustomers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomers.Image = CType(resources.GetObject("btnSearchCustomers.Image"), System.Drawing.Image)
        Me.btnSearchCustomers.Location = New System.Drawing.Point(662, 30)
        Me.btnSearchCustomers.Name = "btnSearchCustomers"
        Me.btnSearchCustomers.Size = New System.Drawing.Size(27, 21)
        Me.btnSearchCustomers.TabIndex = 299
        Me.btnSearchCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchCustomers.UseVisualStyleBackColor = True
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Checked = True
        Me.chkAutoCalculate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoCalculate.Location = New System.Drawing.Point(1029, 211)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(178, 18)
        Me.chkAutoCalculate.TabIndex = 340
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs.. ,Mts. ,Yds."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.txtOutno)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpOutDt)
        Me.GroupBox3.Controls.Add(Me.BtnMakeDyedout)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(970, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(238, 81)
        Me.GroupBox3.TabIndex = 341
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Out Detail"
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 100)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 87)
        Me.GroupBox4.TabIndex = 344
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'BtnMakeDyedout
        '
        Me.BtnMakeDyedout.Enabled = False
        Me.BtnMakeDyedout.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMakeDyedout.Image = Global.SalesOrderSystem.My.Resources.Resources.Save_16x
        Me.BtnMakeDyedout.Location = New System.Drawing.Point(173, 21)
        Me.BtnMakeDyedout.Name = "BtnMakeDyedout"
        Me.BtnMakeDyedout.Size = New System.Drawing.Size(59, 56)
        Me.BtnMakeDyedout.TabIndex = 342
        Me.BtnMakeDyedout.Text = "D OUT"
        Me.BtnMakeDyedout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMakeDyedout.UseVisualStyleBackColor = True
        '
        'dtpPackdt
        '
        Me.dtpPackdt.Checked = False
        Me.dtpPackdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpPackdt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtpPackdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPackdt.Location = New System.Drawing.Point(59, 56)
        Me.dtpPackdt.Name = "dtpPackdt"
        Me.dtpPackdt.ShowCheckBox = True
        Me.dtpPackdt.Size = New System.Drawing.Size(108, 25)
        Me.dtpPackdt.TabIndex = 334
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 335
        Me.Label16.Text = "PLS Date"
        '
        'txtpackno
        '
        Me.txtpackno.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtpackno.Location = New System.Drawing.Point(59, 24)
        Me.txtpackno.Name = "txtpackno"
        Me.txtpackno.Size = New System.Drawing.Size(108, 25)
        Me.txtpackno.TabIndex = 333
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 332
        Me.Label14.Text = "PLS No."
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSum, Me.lblTitleSum, Me.lblCount, Me.lblCountHeader})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 594)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip2.Size = New System.Drawing.Size(1220, 25)
        Me.ToolStrip2.TabIndex = 343
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSum
        '
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(13, 22)
        Me.lblSum.Text = "0"
        '
        'lblTitleSum
        '
        Me.lblTitleSum.Name = "lblTitleSum"
        Me.lblTitleSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitleSum.Size = New System.Drawing.Size(40, 22)
        Me.lblTitleSum.Text = " Sum :"
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 22)
        Me.lblCount.Text = "0"
        '
        'lblCountHeader
        '
        Me.lblCountHeader.Name = "lblCountHeader"
        Me.lblCountHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountHeader.Size = New System.Drawing.Size(43, 22)
        Me.lblCountHeader.Text = "Count:"
        '
        'btnSearchPLS
        '
        Me.btnSearchPLS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPLS.Image = CType(resources.GetObject("btnSearchPLS.Image"), System.Drawing.Image)
        Me.btnSearchPLS.Location = New System.Drawing.Point(173, 24)
        Me.btnSearchPLS.Name = "btnSearchPLS"
        Me.btnSearchPLS.Size = New System.Drawing.Size(27, 25)
        Me.btnSearchPLS.TabIndex = 336
        Me.btnSearchPLS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchPLS.UseVisualStyleBackColor = True
        '
        'btnDelAll
        '
        Me.btnDelAll.Image = Global.SalesOrderSystem.My.Resources.Resources.ASX_Upload_blue_16x
        Me.btnDelAll.Location = New System.Drawing.Point(306, 367)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(95, 32)
        Me.btnDelAll.TabIndex = 304
        Me.btnDelAll.Text = "Remove ALL"
        Me.btnDelAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Image = Global.SalesOrderSystem.My.Resources.Resources.ASX_Upload_blue_16x
        Me.btnDel.Location = New System.Drawing.Point(218, 366)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(82, 32)
        Me.btnDel.TabIndex = 303
        Me.btnDel.Text = "Remove"
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.SalesOrderSystem.My.Resources.Resources.ASX_Download_blue_16x
        Me.btnAdd.Location = New System.Drawing.Point(136, 367)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 32)
        Me.btnAdd.TabIndex = 302
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtpackno)
        Me.GroupBox5.Controls.Add(Me.btnSearchPLS)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.dtpPackdt)
        Me.GroupBox5.Location = New System.Drawing.Point(970, 108)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 100)
        Me.GroupBox5.TabIndex = 344
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document Detail"
        '
        'frmDyedOutSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 619)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbStockOut)
        Me.Controls.Add(Me.lbBalanceStock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSelectedMts)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSelectedYds)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtSelectedKgs)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSelectedRolls)
        Me.Controls.Add(Me.lblStockMts)
        Me.Controls.Add(Me.txtSelectMts)
        Me.Controls.Add(Me.lblStockYds)
        Me.Controls.Add(Me.txtSelectYds)
        Me.Controls.Add(Me.lblStockKgs)
        Me.Controls.Add(Me.txtSelectKgs)
        Me.Controls.Add(Me.lblStockRoll)
        Me.Controls.Add(Me.txtSelectRolls)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdDoutNew)
        Me.Controls.Add(Me.grdDoutStock)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDyedOutSample"
        Me.Text = "Dyed Out Sample"
        CType(Me.grdDoutNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDoutStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbDesignNo As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchCustomers As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents lblStockMts As System.Windows.Forms.Label
    Friend WithEvents txtSelectMts As System.Windows.Forms.TextBox
    Friend WithEvents lblStockYds As System.Windows.Forms.Label
    Friend WithEvents txtSelectYds As System.Windows.Forms.TextBox
    Friend WithEvents lblStockKgs As System.Windows.Forms.Label
    Friend WithEvents txtSelectKgs As System.Windows.Forms.TextBox
    Friend WithEvents lblStockRoll As System.Windows.Forms.Label
    Friend WithEvents txtSelectRolls As System.Windows.Forms.TextBox
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grdDoutNew As System.Windows.Forms.DataGridView
    Friend WithEvents grdDoutStock As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtOutno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpOutDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCol As System.Windows.Forms.TextBox
    Friend WithEvents txtRefdesno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbStockOut As System.Windows.Forms.Label
    Friend WithEvents lbBalanceStock As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrintSampleOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintTag As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents cboempcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpackno As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpPackdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnMakeDyedout As System.Windows.Forms.Button
    Friend WithEvents btnPrintPLS As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtaddr1 As System.Windows.Forms.TextBox
    Friend WithEvents grdDoutNewSel As DataGridViewCheckBoxColumn
    Friend WithEvents grdDoutNewoutno As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewoutdt As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRefdesno As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewCol As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewCustColor As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewLot As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRollNoD As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRollNoO As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewsonoid As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewKg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewMts As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewYds As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestKg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestMts As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestYds As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestMtkg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRemQC As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewSubinventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewLocationName As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockSel As DataGridViewCheckBoxColumn
    Friend WithEvents grdDoutStockDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRefdesno As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockCol As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockCustColor As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockLot As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRollNoO As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRollNoD As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStocksonoid As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockKg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockMts As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockYds As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRequestkg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRequestMts As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRequestYds As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRequestMtkg As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockRemQC As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockSubinventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents grdDoutStockLocationName As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnPrinttagForSample As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrinttagForSales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblSum As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTitleSum As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblCountHeader As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSearchPLS As System.Windows.Forms.Button
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
