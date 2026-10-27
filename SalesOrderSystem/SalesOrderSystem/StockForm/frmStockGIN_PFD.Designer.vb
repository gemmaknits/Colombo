<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_PFD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_PFD))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpGINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtGINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.targetsono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gammaRollSeqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thickness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useable_mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnEntryDefectRoll = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbGInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbGInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1054, 25)
        Me.ToolStrip1.TabIndex = 140
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "GIN No."
        '
        'cboDocNo
        '
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
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'dtpGINDate
        '
        Me.dtpGINDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpGINDate.Enabled = False
        Me.dtpGINDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGINDate.Location = New System.Drawing.Point(84, 59)
        Me.dtpGINDate.Name = "dtpGINDate"
        Me.dtpGINDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpGINDate.TabIndex = 269
        Me.dtpGINDate.TabStop = False
        '
        'txtGINNo
        '
        Me.txtGINNo.Location = New System.Drawing.Point(84, 19)
        Me.txtGINNo.Name = "txtGINNo"
        Me.txtGINNo.ReadOnly = True
        Me.txtGINNo.Size = New System.Drawing.Size(96, 22)
        Me.txtGINNo.TabIndex = 268
        Me.txtGINNo.TabStop = False
        Me.txtGINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "GIN No."
        '
        'txtDFNo
        '
        Me.txtDFNo.Location = New System.Drawing.Point(92, 79)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.ReadOnly = True
        Me.txtDFNo.Size = New System.Drawing.Size(96, 22)
        Me.txtDFNo.TabIndex = 272
        Me.txtDFNo.TabStop = False
        Me.txtDFNo.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "DF No."
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(288, 19)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(104, 22)
        Me.txtLotNo.TabIndex = 278
        Me.txtLotNo.TabStop = False
        Me.txtLotNo.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Lot No."
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(92, 19)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(104, 22)
        Me.txtBillNo.TabIndex = 0
        Me.txtBillNo.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Bill No."
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sono, Me.sonoid, Me.targetsono, Me.kono, Me.design_no, Me.gwth, Me.grade, Me.roll_no, Me.roll_no_o, Me.gammaRollSeqNo, Me.thickness, Me.kg, Me.mts, Me.yds, Me.useable_mts})
        Me.grdData.Location = New System.Drawing.Point(8, 149)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1037, 315)
        Me.grdData.TabIndex = 281
        Me.grdData.TabStop = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No From D/F"
        Me.sono.Name = "sono"
        Me.sono.Width = 80
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No ID From D/F"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Width = 80
        '
        'targetsono
        '
        Me.targetsono.DataPropertyName = "target_sono"
        Me.targetsono.HeaderText = "Target S/O No."
        Me.targetsono.Name = "targetsono"
        Me.targetsono.Width = 80
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        Me.kono.HeaderText = "K/O No."
        Me.kono.Name = "kono"
        Me.kono.Width = 80
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 150
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.ReadOnly = True
        Me.gwth.Width = 50
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 50
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "System Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 80
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 120
        '
        'gammaRollSeqNo
        '
        Me.gammaRollSeqNo.DataPropertyName = "gamma_roll_seq_no"
        Me.gammaRollSeqNo.HeaderText = "Gamma Roll Seq No."
        Me.gammaRollSeqNo.Name = "gammaRollSeqNo"
        Me.gammaRollSeqNo.ReadOnly = True
        Me.gammaRollSeqNo.Width = 80
        '
        'thickness
        '
        Me.thickness.DataPropertyName = "thickness"
        Me.thickness.HeaderText = "Thickness (mm)"
        Me.thickness.Name = "thickness"
        Me.thickness.Visible = False
        Me.thickness.Width = 80
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.Width = 75
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 75
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 75
        '
        'useable_mts
        '
        Me.useable_mts.DataPropertyName = "useable_mts"
        Me.useable_mts.HeaderText = "Useable (mts)"
        Me.useable_mts.Name = "useable_mts"
        Me.useable_mts.Visible = False
        Me.useable_mts.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGINNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpGINDate)
        Me.GroupBox1.Location = New System.Drawing.Point(845, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 115)
        Me.GroupBox1.TabIndex = 284
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "G-IN Document"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "GIN Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbomtl_location)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 115)
        Me.GroupBox2.TabIndex = 303
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Locations"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(217, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 303
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(217, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 302
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(217, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "*"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(129, 21)
        Me.cbomtl_warehouse.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = "Location"
        '
        'cbomtl_location
        '
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(82, 73)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(129, 21)
        Me.cbomtl_location.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 295
        Me.Label12.Text = "Sub Inven"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "W/H"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(129, 21)
        Me.cbomtl_subinventory.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtBillNo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtDFNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtLotNo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 115)
        Me.GroupBox3.TabIndex = 305
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bill Detail"
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDyedHouse.Enabled = False
        Me.cboDyedHouse.FormattingEnabled = True
        Me.cboDyedHouse.Location = New System.Drawing.Point(92, 52)
        Me.cboDyedHouse.Name = "cboDyedHouse"
        Me.cboDyedHouse.Size = New System.Drawing.Size(300, 21)
        Me.cboDyedHouse.TabIndex = 364
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 363
        Me.Label17.Text = "Dyed House"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 282
        Me.Label2.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(64, 472)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(840, 22)
        Me.txtRemark.TabIndex = 283
        Me.txtRemark.TabStop = False
        Me.txtRemark.Tag = ""
        '
        'btnEntryDefectRoll
        '
        Me.btnEntryDefectRoll.Location = New System.Drawing.Point(29, 21)
        Me.btnEntryDefectRoll.Name = "btnEntryDefectRoll"
        Me.btnEntryDefectRoll.Size = New System.Drawing.Size(74, 22)
        Me.btnEntryDefectRoll.TabIndex = 306
        Me.btnEntryDefectRoll.Text = "Defect Roll"
        Me.btnEntryDefectRoll.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEntryDefectRoll)
        Me.GroupBox4.Location = New System.Drawing.Point(700, 35)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(127, 55)
        Me.GroupBox4.TabIndex = 307
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quality Internal Control"
        Me.GroupBox4.Visible = False
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintBarcode.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnPrintBarcode.Image = CType(resources.GetObject("BtnPrintBarcode.Image"), System.Drawing.Image)
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(751, 97)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(88, 25)
        Me.BtnPrintBarcode.TabIndex = 341
        Me.BtnPrintBarcode.Text = "Print Tag"
        Me.BtnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintBarcode.UseVisualStyleBackColor = False
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.Location = New System.Drawing.Point(751, 122)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(88, 23)
        Me.BtnCopy.TabIndex = 340
        Me.BtnCopy.Text = "Copy Roll"
        Me.BtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopy.UseVisualStyleBackColor = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGInDocument, Me.tsbGInTag})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbGInDocument
        '
        Me.tsbGInDocument.Name = "tsbGInDocument"
        Me.tsbGInDocument.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInDocument.Text = "G-IN DOCUMENT"
        '
        'tsbGInTag
        '
        Me.tsbGInTag.Name = "tsbGInTag"
        Me.tsbGInTag.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInTag.Text = "G-IN Tag"
        '
        'frmStockGIN_PFD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 505)
        Me.Controls.Add(Me.BtnPrintBarcode)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStockGIN_PFD"
        Me.Text = "G-IN PFD From Gamma"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpGINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGINNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbomtl_location As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboDyedHouse As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents btnEntryDefectRoll As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents targetsono As DataGridViewTextBoxColumn
    Friend WithEvents kono As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents gammaRollSeqNo As DataGridViewTextBoxColumn
    Friend WithEvents thickness As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents useable_mts As DataGridViewTextBoxColumn
    Friend WithEvents BtnPrintBarcode As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbGInDocument As ToolStripMenuItem
    Friend WithEvents tsbGInTag As ToolStripMenuItem
End Class
