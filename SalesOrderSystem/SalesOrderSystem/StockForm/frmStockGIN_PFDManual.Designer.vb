<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_PFDManual
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_PFDManual))
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.targetsono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source_refno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_bdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_adt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GammaRollSeqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thickness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useable_mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboGINPFDNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtGINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbGInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbGInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnGINTagStandared = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnGINTagSTGCustomerFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagPresslessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearchDFNo = New System.Windows.Forms.Button()
        Me.dtpGINDATE = New System.Windows.Forms.DateTimePicker()
        Me.lblGINDATE = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.btncopyRoll = New System.Windows.Forms.Button()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEntryDefectRoll = New System.Windows.Forms.Button()
        Me.tsmnGINDocumentStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnGINDocumentSTG = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sono, Me.sonoid, Me.targetsono, Me.source_refno, Me.Lot, Me.design_no, Me.col, Me.gwth, Me.grade_bdt, Me.grade_adt, Me.grade, Me.roll_no, Me.roll_no_o, Me.GammaRollSeqNo, Me.thickness, Me.kg, Me.mts, Me.yds, Me.useable_mts, Me.bar_weight, Me.roll_no_f, Me.mcno, Me.rem_qc})
        Me.grdData.Location = New System.Drawing.Point(8, 180)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1091, 283)
        Me.grdData.TabIndex = 294
        Me.grdData.TabStop = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No. From D/F"
        Me.sono.Name = "sono"
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No ID From D/F"
        Me.sonoid.Name = "sonoid"
        '
        'targetsono
        '
        Me.targetsono.DataPropertyName = "target_sono"
        Me.targetsono.HeaderText = "Target S/O No."
        Me.targetsono.Name = "targetsono"
        '
        'source_refno
        '
        Me.source_refno.DataPropertyName = "source_refno"
        Me.source_refno.HeaderText = "Bill No."
        Me.source_refno.Name = "source_refno"
        Me.source_refno.Visible = False
        Me.source_refno.Width = 80
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        Me.Lot.Visible = False
        Me.Lot.Width = 80
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No. (FG)"
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Width = 50
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.Width = 50
        '
        'grade_bdt
        '
        Me.grade_bdt.DataPropertyName = "grade_bdt"
        Me.grade_bdt.HeaderText = "Grade of Inspection"
        Me.grade_bdt.Name = "grade_bdt"
        Me.grade_bdt.Width = 40
        '
        'grade_adt
        '
        Me.grade_adt.DataPropertyName = "grade_adt"
        Me.grade_adt.HeaderText = "Grade of Dye Test"
        Me.grade_adt.Name = "grade_adt"
        Me.grade_adt.Width = 40
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.Width = 40
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 80
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.Width = 150
        '
        'GammaRollSeqNo
        '
        Me.GammaRollSeqNo.DataPropertyName = "gamma_roll_seq_no"
        Me.GammaRollSeqNo.HeaderText = "Gamma Roll Seq No."
        Me.GammaRollSeqNo.Name = "GammaRollSeqNo"
        Me.GammaRollSeqNo.Width = 50
        '
        'thickness
        '
        Me.thickness.DataPropertyName = "thickness"
        Me.thickness.HeaderText = "Thickness"
        Me.thickness.Name = "thickness"
        Me.thickness.Width = 80
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.kg.DefaultCellStyle = DataGridViewCellStyle4
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.Width = 75
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.mts.DefaultCellStyle = DataGridViewCellStyle5
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 75
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.yds.DefaultCellStyle = DataGridViewCellStyle6
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 75
        '
        'useable_mts
        '
        Me.useable_mts.DataPropertyName = "useable_mts"
        Me.useable_mts.HeaderText = "Useable (mts)"
        Me.useable_mts.Name = "useable_mts"
        Me.useable_mts.Width = 80
        '
        'bar_weight
        '
        Me.bar_weight.DataPropertyName = "bar_weight"
        Me.bar_weight.HeaderText = "Bar Weight"
        Me.bar_weight.Name = "bar_weight"
        Me.bar_weight.Width = 50
        '
        'roll_no_f
        '
        Me.roll_no_f.DataPropertyName = "roll_no_f"
        Me.roll_no_f.HeaderText = "roll_no_f"
        Me.roll_no_f.Name = "roll_no_f"
        Me.roll_no_f.Visible = False
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        Me.mcno.HeaderText = "mcno"
        Me.mcno.Name = "mcno"
        Me.mcno.Visible = False
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Remark"
        Me.rem_qc.Name = "rem_qc"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cboGINPFDNo
        '
        Me.cboGINPFDNo.Name = "cboGINPFDNo"
        Me.cboGINPFDNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "GIN No."
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'txtDFNo
        '
        Me.txtDFNo.Location = New System.Drawing.Point(254, 24)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.Size = New System.Drawing.Size(96, 22)
        Me.txtDFNo.TabIndex = 290
        Me.txtDFNo.TabStop = False
        Me.txtDFNo.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "DF No."
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtGINNo
        '
        Me.txtGINNo.Location = New System.Drawing.Point(88, 30)
        Me.txtGINNo.Name = "txtGINNo"
        Me.txtGINNo.ReadOnly = True
        Me.txtGINNo.Size = New System.Drawing.Size(106, 22)
        Me.txtGINNo.TabIndex = 287
        Me.txtGINNo.TabStop = False
        Me.txtGINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 286
        Me.Label3.Text = "GIN No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGINPFDNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1113, 25)
        Me.ToolStrip1.TabIndex = 285
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
        Me.tsbGInDocument.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnGINDocumentStandard, Me.tsmnGINDocumentSTG})
        Me.tsbGInDocument.Name = "tsbGInDocument"
        Me.tsbGInDocument.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInDocument.Text = "G-IN DOCUMENT"
        '
        'tsbGInTag
        '
        Me.tsbGInTag.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnGINTagStandared, Me.tsmnGINTagSTGCustomerFormat, Me.TagPresslessToolStripMenuItem})
        Me.tsbGInTag.Name = "tsbGInTag"
        Me.tsbGInTag.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInTag.Text = "G-IN Tag"
        '
        'tsmnGINTagStandared
        '
        Me.tsmnGINTagStandared.Name = "tsmnGINTagStandared"
        Me.tsmnGINTagStandared.Size = New System.Drawing.Size(242, 22)
        Me.tsmnGINTagStandared.Text = "G-IN Tag Standared"
        '
        'tsmnGINTagSTGCustomerFormat
        '
        Me.tsmnGINTagSTGCustomerFormat.Name = "tsmnGINTagSTGCustomerFormat"
        Me.tsmnGINTagSTGCustomerFormat.Size = New System.Drawing.Size(242, 22)
        Me.tsmnGINTagSTGCustomerFormat.Text = "G-IN Tag STG Customer Format"
        '
        'TagPresslessToolStripMenuItem
        '
        Me.TagPresslessToolStripMenuItem.Name = "TagPresslessToolStripMenuItem"
        Me.TagPresslessToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.TagPresslessToolStripMenuItem.Text = "G-IN Tag Pressless"
        '
        'btnSearchDFNo
        '
        Me.btnSearchDFNo.Image = CType(resources.GetObject("btnSearchDFNo.Image"), System.Drawing.Image)
        Me.btnSearchDFNo.Location = New System.Drawing.Point(362, 22)
        Me.btnSearchDFNo.Name = "btnSearchDFNo"
        Me.btnSearchDFNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDFNo.TabIndex = 299
        Me.btnSearchDFNo.UseVisualStyleBackColor = True
        '
        'dtpGINDATE
        '
        Me.dtpGINDATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGINDATE.Location = New System.Drawing.Point(88, 66)
        Me.dtpGINDATE.Name = "dtpGINDATE"
        Me.dtpGINDATE.Size = New System.Drawing.Size(106, 22)
        Me.dtpGINDATE.TabIndex = 301
        '
        'lblGINDATE
        '
        Me.lblGINDATE.AutoSize = True
        Me.lblGINDATE.Location = New System.Drawing.Point(15, 66)
        Me.lblGINDATE.Name = "lblGINDATE"
        Me.lblGINDATE.Size = New System.Drawing.Size(55, 13)
        Me.lblGINDATE.TabIndex = 302
        Me.lblGINDATE.Text = "GIN DATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtGINNo)
        Me.GroupBox1.Controls.Add(Me.lblGINDATE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpGINDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(899, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox1.TabIndex = 303
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greige IN Preset Document"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Type"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(106, 22)
        Me.TextBox1.TabIndex = 303
        Me.TextBox1.TabStop = False
        Me.TextBox1.Tag = ""
        Me.TextBox1.Text = "PRESET"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtBillNo)
        Me.GroupBox2.Controls.Add(Me.btnSearchDFNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtLotNo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDFNo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 115)
        Me.GroupBox2.TabIndex = 306
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bill Detail"
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(92, 24)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(96, 22)
        Me.txtBillNo.TabIndex = 0
        Me.txtBillNo.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Bill No."
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(92, 83)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(96, 22)
        Me.txtLotNo.TabIndex = 278
        Me.txtLotNo.TabStop = False
        Me.txtLotNo.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Lot No."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbomtl_location)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox3.Location = New System.Drawing.Point(437, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 115)
        Me.GroupBox3.TabIndex = 305
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Loactions"
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
        'btncopyRoll
        '
        Me.btncopyRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncopyRoll.Image = Global.SalesOrderSystem.My.Resources.Resources.Copy_16x
        Me.btncopyRoll.Location = New System.Drawing.Point(8, 151)
        Me.btncopyRoll.Name = "btncopyRoll"
        Me.btncopyRoll.Size = New System.Drawing.Size(80, 23)
        Me.btncopyRoll.TabIndex = 330
        Me.btncopyRoll.Text = "Copy Roll"
        Me.btncopyRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncopyRoll.UseVisualStyleBackColor = True
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(997, 147)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(104, 32)
        Me.chkAutoCalculate.TabIndex = 329
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1071, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 339
        Me.Label2.Text = "Yds"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(935, 471)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 338
        Me.Label7.Text = "Mts"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(548, 470)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalRolls.TabIndex = 331
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(797, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "Kgs"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(655, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 336
        Me.Label9.Text = "Rolls"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(965, 469)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalYds.TabIndex = 335
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(828, 470)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMts.TabIndex = 334
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(691, 470)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalKgs.TabIndex = 333
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(511, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 332
        Me.Label10.Text = "Total"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEntryDefectRoll)
        Me.GroupBox4.Location = New System.Drawing.Point(684, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(151, 55)
        Me.GroupBox4.TabIndex = 340
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quality Internal Control"
        '
        'btnEntryDefectRoll
        '
        Me.btnEntryDefectRoll.Location = New System.Drawing.Point(43, 24)
        Me.btnEntryDefectRoll.Name = "btnEntryDefectRoll"
        Me.btnEntryDefectRoll.Size = New System.Drawing.Size(74, 22)
        Me.btnEntryDefectRoll.TabIndex = 306
        Me.btnEntryDefectRoll.Text = "Defect Roll"
        Me.btnEntryDefectRoll.UseVisualStyleBackColor = True
        '
        'tsmnGINDocumentStandard
        '
        Me.tsmnGINDocumentStandard.Name = "tsmnGINDocumentStandard"
        Me.tsmnGINDocumentStandard.Size = New System.Drawing.Size(208, 22)
        Me.tsmnGINDocumentStandard.Text = "G-IN Document Standard"
        '
        'tsmnGINDocumentSTG
        '
        Me.tsmnGINDocumentSTG.Name = "tsmnGINDocumentSTG"
        Me.tsmnGINDocumentSTG.Size = New System.Drawing.Size(208, 22)
        Me.tsmnGINDocumentSTG.Text = "G-IN Document  STG"
        '
        'frmStockGIN_PFDManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 502)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btncopyRoll)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStockGIN_PFDManual"
        Me.Text = "GIN PFD Manual"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboGINPFDNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtGINNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSearchDFNo As System.Windows.Forms.Button
    Friend WithEvents lblGINDATE As System.Windows.Forms.Label
    Private WithEvents dtpGINDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboDyedHouse As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLotNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbomtl_location As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents btncopyRoll As Button
    Friend WithEvents chkAutoCalculate As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalRolls As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTotalYds As TextBox
    Friend WithEvents txtTotalMts As TextBox
    Friend WithEvents txtTotalKgs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnEntryDefectRoll As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbGInDocument As ToolStripMenuItem
    Friend WithEvents tsbGInTag As ToolStripMenuItem
    Friend WithEvents tsmnGINTagStandared As ToolStripMenuItem
    Friend WithEvents tsmnGINTagSTGCustomerFormat As ToolStripMenuItem
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents targetsono As DataGridViewTextBoxColumn
    Friend WithEvents source_refno As DataGridViewTextBoxColumn
    Friend WithEvents Lot As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents grade_bdt As DataGridViewTextBoxColumn
    Friend WithEvents grade_adt As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents GammaRollSeqNo As DataGridViewTextBoxColumn
    Friend WithEvents thickness As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents useable_mts As DataGridViewTextBoxColumn
    Friend WithEvents bar_weight As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_f As DataGridViewTextBoxColumn
    Friend WithEvents mcno As DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As DataGridViewTextBoxColumn
    Friend WithEvents TagPresslessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmnGINDocumentStandard As ToolStripMenuItem
    Friend WithEvents tsmnGINDocumentSTG As ToolStripMenuItem
End Class
