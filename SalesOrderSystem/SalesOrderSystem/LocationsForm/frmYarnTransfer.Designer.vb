<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnTransfer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtLocationRemarks = New System.Windows.Forms.TextBox()
        Me.btnExpandGridTransfer = New System.Windows.Forms.Button()
        Me.lbTransfer = New System.Windows.Forms.Label()
        Me.lbBalanceStock = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtGradeOurTo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbtTransfferGrade = New System.Windows.Forms.RadioButton()
        Me.rbtTransferLocations = New System.Windows.Forms.RadioButton()
        Me.lblWarehourse = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGradeTo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtl_Location = New System.Windows.Forms.ComboBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblTitleSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.lblCountHeader = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboLogNo = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpActualMoveDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtLogNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnYOut = New System.Windows.Forms.Button()
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.grdTransfer = New System.Windows.Forms.DataGridView()
        Me.grdYarnIN = New System.Windows.Forms.DataGridView()
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.row_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fritcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frlotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frmtl_warehouse_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.frmtl_subinventory_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.frmtl_locations_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.frlocation_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frgrade_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frgrade_our_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExpandGridBalance = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tr_chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tr_row_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tritcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trmtl_warehouse_code_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trmtl_subinventory_code_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trlocation_name_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trlocation_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trmtl_warehouse_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.trmtl_subinventory_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.trmtl_locations_id_to = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.trlocation_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trgrade_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trgrade_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trgrade_our_fr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trgrade_our_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tr_cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLocationRemarks
        '
        Me.txtLocationRemarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocationRemarks.Location = New System.Drawing.Point(229, 28)
        Me.txtLocationRemarks.Multiline = True
        Me.txtLocationRemarks.Name = "txtLocationRemarks"
        Me.txtLocationRemarks.Size = New System.Drawing.Size(157, 46)
        Me.txtLocationRemarks.TabIndex = 107
        '
        'btnExpandGridTransfer
        '
        Me.btnExpandGridTransfer.Image = Global.SalesOrderSystem.My.Resources.Resources.Expand_16x
        Me.btnExpandGridTransfer.Location = New System.Drawing.Point(176, 315)
        Me.btnExpandGridTransfer.Name = "btnExpandGridTransfer"
        Me.btnExpandGridTransfer.Size = New System.Drawing.Size(140, 32)
        Me.btnExpandGridTransfer.TabIndex = 375
        Me.btnExpandGridTransfer.Text = "Expand Grid Transfer"
        Me.btnExpandGridTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpandGridTransfer.UseVisualStyleBackColor = True
        '
        'lbTransfer
        '
        Me.lbTransfer.AutoSize = True
        Me.lbTransfer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTransfer.Location = New System.Drawing.Point(9, 331)
        Me.lbTransfer.Name = "lbTransfer"
        Me.lbTransfer.Size = New System.Drawing.Size(85, 17)
        Me.lbTransfer.TabIndex = 374
        Me.lbTransfer.Text = "Transfer Log"
        '
        'lbBalanceStock
        '
        Me.lbBalanceStock.AutoSize = True
        Me.lbBalanceStock.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBalanceStock.Location = New System.Drawing.Point(9, 148)
        Me.lbBalanceStock.Name = "lbBalanceStock"
        Me.lbBalanceStock.Size = New System.Drawing.Size(92, 17)
        Me.lbBalanceStock.TabIndex = 373
        Me.lbBalanceStock.Text = "Balance Stock"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "Doc No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Subinventory to"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(127, 66)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(115, 21)
        Me.cbomtl_subinventory.TabIndex = 96
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGradeOurTo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.rbtTransfferGrade)
        Me.GroupBox2.Controls.Add(Me.rbtTransferLocations)
        Me.GroupBox2.Controls.Add(Me.lblWarehourse)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtGradeTo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.cbomtl_Location)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 119)
        Me.GroupBox2.TabIndex = 372
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transfer Type "
        '
        'txtGradeOurTo
        '
        Me.txtGradeOurTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGradeOurTo.Enabled = False
        Me.txtGradeOurTo.Location = New System.Drawing.Point(343, 69)
        Me.txtGradeOurTo.Name = "txtGradeOurTo"
        Me.txtGradeOurTo.Size = New System.Drawing.Size(91, 20)
        Me.txtGradeOurTo.TabIndex = 353
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 352
        Me.Label9.Text = "Grade Our to"
        '
        'rbtTransfferGrade
        '
        Me.rbtTransfferGrade.AutoSize = True
        Me.rbtTransfferGrade.Location = New System.Drawing.Point(264, 18)
        Me.rbtTransfferGrade.Name = "rbtTransfferGrade"
        Me.rbtTransfferGrade.Size = New System.Drawing.Size(96, 17)
        Me.rbtTransfferGrade.TabIndex = 351
        Me.rbtTransfferGrade.Text = "Transfer Grade"
        Me.rbtTransfferGrade.UseVisualStyleBackColor = True
        '
        'rbtTransferLocations
        '
        Me.rbtTransferLocations.AutoSize = True
        Me.rbtTransferLocations.Checked = True
        Me.rbtTransferLocations.Location = New System.Drawing.Point(17, 19)
        Me.rbtTransferLocations.Name = "rbtTransferLocations"
        Me.rbtTransferLocations.Size = New System.Drawing.Size(113, 17)
        Me.rbtTransferLocations.TabIndex = 350
        Me.rbtTransferLocations.TabStop = True
        Me.rbtTransferLocations.Text = "Transfer Locations"
        Me.rbtTransferLocations.UseVisualStyleBackColor = True
        '
        'lblWarehourse
        '
        Me.lblWarehourse.AutoSize = True
        Me.lblWarehourse.Location = New System.Drawing.Point(14, 50)
        Me.lblWarehourse.Name = "lblWarehourse"
        Me.lblWarehourse.Size = New System.Drawing.Size(74, 13)
        Me.lblWarehourse.TabIndex = 91
        Me.lblWarehourse.Text = "Warehouse to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Location to"
        '
        'txtGradeTo
        '
        Me.txtGradeTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGradeTo.Enabled = False
        Me.txtGradeTo.Location = New System.Drawing.Point(343, 41)
        Me.txtGradeTo.Name = "txtGradeTo"
        Me.txtGradeTo.Size = New System.Drawing.Size(91, 20)
        Me.txtGradeTo.TabIndex = 347
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(261, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 346
        Me.Label15.Text = "Grade to"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_warehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(127, 42)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(115, 21)
        Me.cbomtl_warehouse.TabIndex = 89
        '
        'cbomtl_Location
        '
        Me.cbomtl_Location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtl_Location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_Location.FormattingEnabled = True
        Me.cbomtl_Location.Location = New System.Drawing.Point(127, 90)
        Me.cbomtl_Location.Name = "cbomtl_Location"
        Me.cbomtl_Location.Size = New System.Drawing.Size(115, 21)
        Me.cbomtl_Location.TabIndex = 90
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSum, Me.lblTitleSum, Me.lblCount, Me.lblCountHeader})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 509)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip2.TabIndex = 370
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSum
        '
        Me.lblSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(13, 22)
        Me.lblSum.Text = "0"
        '
        'lblTitleSum
        '
        Me.lblTitleSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTitleSum.Name = "lblTitleSum"
        Me.lblTitleSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitleSum.Size = New System.Drawing.Size(40, 22)
        Me.lblTitleSum.Text = " Sum :"
        '
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 22)
        Me.lblCount.Text = "0"
        '
        'lblCountHeader
        '
        Me.lblCountHeader.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCountHeader.Name = "lblCountHeader"
        Me.lblCountHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountHeader.Size = New System.Drawing.Size(43, 22)
        Me.lblCountHeader.Text = "Count:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cboLogNo
        '
        Me.cboLogNo.Name = "cboLogNo"
        Me.cboLogNo.Size = New System.Drawing.Size(125, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpActualMoveDate)
        Me.GroupBox1.Controls.Add(Me.dtpReceiveDate)
        Me.GroupBox1.Controls.Add(Me.txtLocationRemarks)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 86)
        Me.GroupBox1.TabIndex = 371
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Actual Move Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Receive Date"
        '
        'dtpActualMoveDate
        '
        Me.dtpActualMoveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpActualMoveDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpActualMoveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActualMoveDate.Location = New System.Drawing.Point(135, 21)
        Me.dtpActualMoveDate.Name = "dtpActualMoveDate"
        Me.dtpActualMoveDate.Size = New System.Drawing.Size(88, 22)
        Me.dtpActualMoveDate.TabIndex = 87
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReceiveDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReceiveDate.Location = New System.Drawing.Point(135, 45)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.Size = New System.Drawing.Size(88, 22)
        Me.dtpReceiveDate.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(229, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 106
        Me.Label12.Text = "Remark :"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(922, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(101, 20)
        Me.TextBox3.TabIndex = 369
        '
        'txtLogNo
        '
        Me.txtLogNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogNo.Location = New System.Drawing.Point(919, 29)
        Me.txtLogNo.Name = "txtLogNo"
        Me.txtLogNo.Size = New System.Drawing.Size(104, 20)
        Me.txtLogNo.TabIndex = 360
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(863, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 359
        Me.Label2.Text = "Doc Date"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(863, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 358
        Me.Label1.Text = "Doc No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboLogNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1041, 25)
        Me.ToolStrip1.TabIndex = 356
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
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(298, 22)
        Me.ToolStripLabel2.Text = "เลือก WareHouse ที่จะย้ายไปด้วยครับ เช่น ESH (Eschler) "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 365
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(66, 31)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(229, 20)
        Me.txtBarcode.TabIndex = 355
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 364
        Me.Label7.Text = "Y Barcode"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(866, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 368
        Me.Label11.Text = "Out No.:"
        '
        'btnYOut
        '
        Me.btnYOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYOut.Enabled = False
        Me.btnYOut.Location = New System.Drawing.Point(935, 112)
        Me.btnYOut.Name = "btnYOut"
        Me.btnYOut.Size = New System.Drawing.Size(72, 21)
        Me.btnYOut.TabIndex = 367
        Me.btnYOut.Text = "Auto YOUT "
        Me.btnYOut.UseVisualStyleBackColor = True
        '
        'dtpLogDate
        '
        Me.dtpLogDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpLogDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogDate.Location = New System.Drawing.Point(919, 53)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpLogDate.TabIndex = 366
        '
        'grdTransfer
        '
        Me.grdTransfer.AllowUserToAddRows = False
        Me.grdTransfer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTransfer.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdTransfer.ColumnHeadersHeight = 40
        Me.grdTransfer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tr_chkSelect, Me.tr_row_number, Me.tr_boxno, Me.tr_boxno_s, Me.tritcd, Me.colLotno_our, Me.trmtl_warehouse_code_fr, Me.trmtl_subinventory_code_fr, Me.trlocation_name_fr, Me.trlocation_fr, Me.trmtl_warehouse_id_to, Me.trmtl_subinventory_id_to, Me.trmtl_locations_id_to, Me.trlocation_to, Me.trgrade_to, Me.trgrade_fr, Me.trgrade_our_fr, Me.trgrade_our_to, Me.tr_spools, Me.tr_kg_gr, Me.tr_kg_nt, Me.tr_cart_tearwt})
        Me.grdTransfer.Location = New System.Drawing.Point(12, 354)
        Me.grdTransfer.Name = "grdTransfer"
        Me.grdTransfer.Size = New System.Drawing.Size(1021, 139)
        Me.grdTransfer.TabIndex = 362
        '
        'grdYarnIN
        '
        Me.grdYarnIN.AllowUserToAddRows = False
        Me.grdYarnIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdYarnIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdYarnIN.ColumnHeadersHeight = 40
        Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.row_number, Me.boxno, Me.boxno_s, Me.fritcd, Me.frlotno_our, Me.frmtl_warehouse_id_to, Me.frmtl_subinventory_id_to, Me.frmtl_locations_id_to, Me.frlocation_to, Me.frgrade_to, Me.frgrade_our_to, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt})
        Me.grdYarnIN.Location = New System.Drawing.Point(8, 183)
        Me.grdYarnIN.Name = "grdYarnIN"
        Me.grdYarnIN.Size = New System.Drawing.Size(1025, 127)
        Me.grdYarnIN.TabIndex = 357
        '
        'chkSelect
        '
        Me.chkSelect.DataPropertyName = "chkSelect"
        Me.chkSelect.HeaderText = "Sel"
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Width = 25
        '
        'row_number
        '
        Me.row_number.DataPropertyName = "row_number"
        Me.row_number.HeaderText = "#"
        Me.row_number.Name = "row_number"
        Me.row_number.Width = 30
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.ReadOnly = True
        Me.boxno_s.Width = 75
        '
        'fritcd
        '
        Me.fritcd.DataPropertyName = "itcd"
        Me.fritcd.HeaderText = "Items Code"
        Me.fritcd.Name = "fritcd"
        Me.fritcd.ReadOnly = True
        Me.fritcd.Width = 85
        '
        'frlotno_our
        '
        Me.frlotno_our.DataPropertyName = "lotno_our"
        Me.frlotno_our.HeaderText = "Lot No."
        Me.frlotno_our.Name = "frlotno_our"
        Me.frlotno_our.ReadOnly = True
        Me.frlotno_our.Width = 110
        '
        'frmtl_warehouse_id_to
        '
        Me.frmtl_warehouse_id_to.DataPropertyName = "mtl_warehouse_id_to"
        Me.frmtl_warehouse_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_warehouse_id_to.HeaderText = "W/H"
        Me.frmtl_warehouse_id_to.Name = "frmtl_warehouse_id_to"
        Me.frmtl_warehouse_id_to.ReadOnly = True
        Me.frmtl_warehouse_id_to.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.frmtl_warehouse_id_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.frmtl_warehouse_id_to.Width = 50
        '
        'frmtl_subinventory_id_to
        '
        Me.frmtl_subinventory_id_to.DataPropertyName = "mtl_subinventory_id_to"
        Me.frmtl_subinventory_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_subinventory_id_to.HeaderText = "Sub Inven."
        Me.frmtl_subinventory_id_to.Name = "frmtl_subinventory_id_to"
        Me.frmtl_subinventory_id_to.Width = 80
        '
        'frmtl_locations_id_to
        '
        Me.frmtl_locations_id_to.DataPropertyName = "mtl_locations_id_to"
        Me.frmtl_locations_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.frmtl_locations_id_to.HeaderText = "Locations"
        Me.frmtl_locations_id_to.Name = "frmtl_locations_id_to"
        Me.frmtl_locations_id_to.ReadOnly = True
        Me.frmtl_locations_id_to.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.frmtl_locations_id_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.frmtl_locations_id_to.Width = 80
        '
        'frlocation_to
        '
        Me.frlocation_to.DataPropertyName = "location_to"
        Me.frlocation_to.HeaderText = "Location"
        Me.frlocation_to.Name = "frlocation_to"
        Me.frlocation_to.ReadOnly = True
        Me.frlocation_to.Visible = False
        '
        'frgrade_to
        '
        Me.frgrade_to.DataPropertyName = "grade_to"
        Me.frgrade_to.HeaderText = "Grade "
        Me.frgrade_to.Name = "frgrade_to"
        Me.frgrade_to.Width = 50
        '
        'frgrade_our_to
        '
        Me.frgrade_our_to.DataPropertyName = "grade_our_to"
        Me.frgrade_our_to.HeaderText = "Grade Our"
        Me.frgrade_our_to.Name = "frgrade_our_to"
        Me.frgrade_our_to.Width = 50
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.ReadOnly = True
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.ReadOnly = True
        Me.kg_gr.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.ReadOnly = True
        Me.kg_nt.Width = 75
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.ReadOnly = True
        Me.cart_tearwt.Width = 75
        '
        'btnExpandGridBalance
        '
        Me.btnExpandGridBalance.Image = Global.SalesOrderSystem.My.Resources.Resources.Expand_16x
        Me.btnExpandGridBalance.Location = New System.Drawing.Point(176, 148)
        Me.btnExpandGridBalance.Name = "btnExpandGridBalance"
        Me.btnExpandGridBalance.Size = New System.Drawing.Size(140, 32)
        Me.btnExpandGridBalance.TabIndex = 376
        Me.btnExpandGridBalance.Text = "Expand Grid Balance"
        Me.btnExpandGridBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExpandGridBalance.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Image = Global.SalesOrderSystem.My.Resources.Resources.ASX_Upload_blue_16x
        Me.btnDel.Location = New System.Drawing.Point(140, 315)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 32)
        Me.btnDel.TabIndex = 363
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.SalesOrderSystem.My.Resources.Resources.ASX_Download_blue_16x
        Me.btnAdd.Location = New System.Drawing.Point(102, 315)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 361
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tr_chkSelect
        '
        Me.tr_chkSelect.DataPropertyName = "chkSelect"
        Me.tr_chkSelect.Frozen = True
        Me.tr_chkSelect.HeaderText = "Sel"
        Me.tr_chkSelect.Name = "tr_chkSelect"
        Me.tr_chkSelect.Width = 25
        '
        'tr_row_number
        '
        Me.tr_row_number.DataPropertyName = "row_number"
        Me.tr_row_number.Frozen = True
        Me.tr_row_number.HeaderText = "#"
        Me.tr_row_number.Name = "tr_row_number"
        Me.tr_row_number.Width = 30
        '
        'tr_boxno
        '
        Me.tr_boxno.DataPropertyName = "boxno"
        Me.tr_boxno.Frozen = True
        Me.tr_boxno.HeaderText = "Internal box no. (auto)"
        Me.tr_boxno.MaxInputLength = 15
        Me.tr_boxno.Name = "tr_boxno"
        Me.tr_boxno.ReadOnly = True
        '
        'tr_boxno_s
        '
        Me.tr_boxno_s.DataPropertyName = "boxno_s"
        Me.tr_boxno_s.Frozen = True
        Me.tr_boxno_s.HeaderText = "Supplier Box no."
        Me.tr_boxno_s.MaxInputLength = 15
        Me.tr_boxno_s.Name = "tr_boxno_s"
        Me.tr_boxno_s.ReadOnly = True
        Me.tr_boxno_s.Width = 75
        '
        'tritcd
        '
        Me.tritcd.DataPropertyName = "itcd"
        Me.tritcd.Frozen = True
        Me.tritcd.HeaderText = "Item Code"
        Me.tritcd.Name = "tritcd"
        Me.tritcd.ReadOnly = True
        '
        'colLotno_our
        '
        Me.colLotno_our.DataPropertyName = "lotno_our"
        Me.colLotno_our.Frozen = True
        Me.colLotno_our.HeaderText = "Lot No."
        Me.colLotno_our.Name = "colLotno_our"
        Me.colLotno_our.ReadOnly = True
        Me.colLotno_our.Width = 120
        '
        'trmtl_warehouse_code_fr
        '
        Me.trmtl_warehouse_code_fr.DataPropertyName = "mtl_warehouse_code_fr"
        Me.trmtl_warehouse_code_fr.HeaderText = "From W/H"
        Me.trmtl_warehouse_code_fr.Name = "trmtl_warehouse_code_fr"
        Me.trmtl_warehouse_code_fr.ReadOnly = True
        Me.trmtl_warehouse_code_fr.Width = 60
        '
        'trmtl_subinventory_code_fr
        '
        Me.trmtl_subinventory_code_fr.DataPropertyName = "mtl_subinventory_code_fr"
        Me.trmtl_subinventory_code_fr.HeaderText = "From SubInven"
        Me.trmtl_subinventory_code_fr.Name = "trmtl_subinventory_code_fr"
        Me.trmtl_subinventory_code_fr.ReadOnly = True
        Me.trmtl_subinventory_code_fr.Width = 80
        '
        'trlocation_name_fr
        '
        Me.trlocation_name_fr.DataPropertyName = "location_name_fr"
        Me.trlocation_name_fr.HeaderText = "From Location"
        Me.trlocation_name_fr.Name = "trlocation_name_fr"
        Me.trlocation_name_fr.ReadOnly = True
        Me.trlocation_name_fr.Width = 80
        '
        'trlocation_fr
        '
        Me.trlocation_fr.DataPropertyName = "location_fr"
        Me.trlocation_fr.HeaderText = "From Location"
        Me.trlocation_fr.Name = "trlocation_fr"
        Me.trlocation_fr.Visible = False
        '
        'trmtl_warehouse_id_to
        '
        Me.trmtl_warehouse_id_to.DataPropertyName = "mtl_warehouse_id_to"
        Me.trmtl_warehouse_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_warehouse_id_to.HeaderText = "To Warehouse"
        Me.trmtl_warehouse_id_to.Name = "trmtl_warehouse_id_to"
        Me.trmtl_warehouse_id_to.ReadOnly = True
        Me.trmtl_warehouse_id_to.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_warehouse_id_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.trmtl_warehouse_id_to.Width = 60
        '
        'trmtl_subinventory_id_to
        '
        Me.trmtl_subinventory_id_to.DataPropertyName = "mtl_subinventory_id_to"
        Me.trmtl_subinventory_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_subinventory_id_to.HeaderText = "To Subinventory"
        Me.trmtl_subinventory_id_to.Name = "trmtl_subinventory_id_to"
        Me.trmtl_subinventory_id_to.ReadOnly = True
        Me.trmtl_subinventory_id_to.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_subinventory_id_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.trmtl_subinventory_id_to.Width = 80
        '
        'trmtl_locations_id_to
        '
        Me.trmtl_locations_id_to.DataPropertyName = "mtl_locations_id_to"
        Me.trmtl_locations_id_to.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.trmtl_locations_id_to.HeaderText = "To Locations"
        Me.trmtl_locations_id_to.Name = "trmtl_locations_id_to"
        Me.trmtl_locations_id_to.ReadOnly = True
        Me.trmtl_locations_id_to.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trmtl_locations_id_to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.trmtl_locations_id_to.Width = 80
        '
        'trlocation_to
        '
        Me.trlocation_to.DataPropertyName = "location_to"
        Me.trlocation_to.HeaderText = "To Location"
        Me.trlocation_to.Name = "trlocation_to"
        Me.trlocation_to.ReadOnly = True
        Me.trlocation_to.Visible = False
        '
        'trgrade_to
        '
        Me.trgrade_to.DataPropertyName = "grade_to"
        Me.trgrade_to.HeaderText = "To Grade"
        Me.trgrade_to.Name = "trgrade_to"
        Me.trgrade_to.ReadOnly = True
        Me.trgrade_to.Width = 50
        '
        'trgrade_fr
        '
        Me.trgrade_fr.DataPropertyName = "grade_fr"
        Me.trgrade_fr.HeaderText = "From Grade"
        Me.trgrade_fr.Name = "trgrade_fr"
        Me.trgrade_fr.ReadOnly = True
        Me.trgrade_fr.Width = 50
        '
        'trgrade_our_fr
        '
        Me.trgrade_our_fr.DataPropertyName = "grade_our_fr"
        Me.trgrade_our_fr.HeaderText = "From Grade Our"
        Me.trgrade_our_fr.Name = "trgrade_our_fr"
        Me.trgrade_our_fr.ReadOnly = True
        Me.trgrade_our_fr.Width = 50
        '
        'trgrade_our_to
        '
        Me.trgrade_our_to.DataPropertyName = "grade_our_to"
        Me.trgrade_our_to.HeaderText = "To Grade Our"
        Me.trgrade_our_to.Name = "trgrade_our_to"
        Me.trgrade_our_to.ReadOnly = True
        Me.trgrade_our_to.Width = 50
        '
        'tr_spools
        '
        Me.tr_spools.DataPropertyName = "spools"
        Me.tr_spools.HeaderText = "Tube /Spools"
        Me.tr_spools.MaxInputLength = 15
        Me.tr_spools.Name = "tr_spools"
        Me.tr_spools.ReadOnly = True
        Me.tr_spools.Width = 50
        '
        'tr_kg_gr
        '
        Me.tr_kg_gr.DataPropertyName = "kg_gr"
        Me.tr_kg_gr.HeaderText = "Gross weight{Kg}"
        Me.tr_kg_gr.MaxInputLength = 15
        Me.tr_kg_gr.Name = "tr_kg_gr"
        Me.tr_kg_gr.ReadOnly = True
        Me.tr_kg_gr.Width = 75
        '
        'tr_kg_nt
        '
        Me.tr_kg_nt.DataPropertyName = "kg_nt"
        Me.tr_kg_nt.HeaderText = "Net weight{Kg}"
        Me.tr_kg_nt.MaxInputLength = 15
        Me.tr_kg_nt.Name = "tr_kg_nt"
        Me.tr_kg_nt.ReadOnly = True
        Me.tr_kg_nt.Width = 75
        '
        'tr_cart_tearwt
        '
        Me.tr_cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.tr_cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.tr_cart_tearwt.MaxInputLength = 15
        Me.tr_cart_tearwt.Name = "tr_cart_tearwt"
        Me.tr_cart_tearwt.ReadOnly = True
        Me.tr_cart_tearwt.Width = 75
        '
        'frmYarnTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 534)
        Me.Controls.Add(Me.btnExpandGridBalance)
        Me.Controls.Add(Me.btnExpandGridTransfer)
        Me.Controls.Add(Me.lbTransfer)
        Me.Controls.Add(Me.lbBalanceStock)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtLogNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnYOut)
        Me.Controls.Add(Me.dtpLogDate)
        Me.Controls.Add(Me.grdTransfer)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdYarnIN)
        Me.Name = "frmYarnTransfer"
        Me.Text = "Yarn Transfer"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLocationRemarks As TextBox
    Friend WithEvents btnExpandGridBalance As Button
    Friend WithEvents btnExpandGridTransfer As Button
    Friend WithEvents lbTransfer As Label
    Friend WithEvents lbBalanceStock As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtGradeOurTo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents rbtTransfferGrade As RadioButton
    Friend WithEvents rbtTransferLocations As RadioButton
    Friend WithEvents lblWarehourse As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGradeTo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents cbomtl_Location As ComboBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblSum As ToolStripLabel
    Friend WithEvents lblTitleSum As ToolStripLabel
    Friend WithEvents lblCount As ToolStripLabel
    Friend WithEvents lblCountHeader As ToolStripLabel
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cboLogNo As ToolStripComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpActualMoveDate As DateTimePicker
    Friend WithEvents dtpReceiveDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents txtLogNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnYOut As Button
    Friend WithEvents dtpLogDate As DateTimePicker
    Friend WithEvents grdTransfer As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents grdYarnIN As DataGridView
    Friend WithEvents chkSelect As DataGridViewCheckBoxColumn
    Friend WithEvents row_number As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents fritcd As DataGridViewTextBoxColumn
    Friend WithEvents frlotno_our As DataGridViewTextBoxColumn
    Friend WithEvents frmtl_warehouse_id_to As DataGridViewComboBoxColumn
    Friend WithEvents frmtl_subinventory_id_to As DataGridViewComboBoxColumn
    Friend WithEvents frmtl_locations_id_to As DataGridViewComboBoxColumn
    Friend WithEvents frlocation_to As DataGridViewTextBoxColumn
    Friend WithEvents frgrade_to As DataGridViewTextBoxColumn
    Friend WithEvents frgrade_our_to As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents tr_chkSelect As DataGridViewCheckBoxColumn
    Friend WithEvents tr_row_number As DataGridViewTextBoxColumn
    Friend WithEvents tr_boxno As DataGridViewTextBoxColumn
    Friend WithEvents tr_boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents tritcd As DataGridViewTextBoxColumn
    Friend WithEvents colLotno_our As DataGridViewTextBoxColumn
    Friend WithEvents trmtl_warehouse_code_fr As DataGridViewTextBoxColumn
    Friend WithEvents trmtl_subinventory_code_fr As DataGridViewTextBoxColumn
    Friend WithEvents trlocation_name_fr As DataGridViewTextBoxColumn
    Friend WithEvents trlocation_fr As DataGridViewTextBoxColumn
    Friend WithEvents trmtl_warehouse_id_to As DataGridViewComboBoxColumn
    Friend WithEvents trmtl_subinventory_id_to As DataGridViewComboBoxColumn
    Friend WithEvents trmtl_locations_id_to As DataGridViewComboBoxColumn
    Friend WithEvents trlocation_to As DataGridViewTextBoxColumn
    Friend WithEvents trgrade_to As DataGridViewTextBoxColumn
    Friend WithEvents trgrade_fr As DataGridViewTextBoxColumn
    Friend WithEvents trgrade_our_fr As DataGridViewTextBoxColumn
    Friend WithEvents trgrade_our_to As DataGridViewTextBoxColumn
    Friend WithEvents tr_spools As DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents tr_kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents tr_cart_tearwt As DataGridViewTextBoxColumn
End Class
