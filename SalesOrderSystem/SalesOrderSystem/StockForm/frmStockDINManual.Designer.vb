<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDINManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDINManual))
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.dono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GammaRollSeqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gross_wt_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gross_mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboDinNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDINDate = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtDINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbDInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnDINTagStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnDINTagSTG = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbMInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpdodt = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchDFNo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.BtnCopyRoll = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tsmnDINTagPTIndonesiaWacoal = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeight = 50
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dono, Me.lot, Me.sono, Me.sonoid, Me.design_no, Me.fwth, Me.gwth, Me.col, Me.custcolor, Me.gr, Me.roll_no_g, Me.roll_no_d, Me.roll_no_o, Me.GammaRollSeqNo, Me.gross_wt_kg, Me.kg, Me.gross_mts, Me.mts, Me.yds, Me.remark, Me.roll_no_f, Me.loc})
        Me.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.grdData.Location = New System.Drawing.Point(7, 180)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1119, 260)
        Me.grdData.TabIndex = 294
        Me.grdData.TabStop = False
        '
        'dono
        '
        Me.dono.DataPropertyName = "dono"
        Me.dono.HeaderText = "Bill No."
        Me.dono.Name = "dono"
        Me.dono.Width = 80
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        Me.fwth.HeaderText = "Fwth"
        Me.fwth.Name = "fwth"
        Me.fwth.Width = 50
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.Visible = False
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.MaxInputLength = 10
        Me.col.Name = "col"
        Me.col.Width = 75
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Gr"
        Me.gr.Name = "gr"
        Me.gr.Width = 25
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No (Greige)"
        Me.roll_no_g.Name = "roll_no_g"
        Me.roll_no_g.ReadOnly = True
        Me.roll_no_g.Width = 60
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "System Roll No. (Tag)"
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.Width = 75
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        '
        'GammaRollSeqNo
        '
        Me.GammaRollSeqNo.DataPropertyName = "gamma_roll_seq_no"
        Me.GammaRollSeqNo.HeaderText = "Gamma Roll Seq No."
        Me.GammaRollSeqNo.Name = "GammaRollSeqNo"
        Me.GammaRollSeqNo.Width = 60
        '
        'gross_wt_kg
        '
        Me.gross_wt_kg.DataPropertyName = "gross_wt_kg"
        Me.gross_wt_kg.HeaderText = "Gross Wt Kg"
        Me.gross_wt_kg.Name = "gross_wt_kg"
        Me.gross_wt_kg.Width = 60
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'gross_mts
        '
        Me.gross_mts.DataPropertyName = "gross_mts"
        Me.gross_mts.HeaderText = "Gross Mts."
        Me.gross_mts.Name = "gross_mts"
        Me.gross_mts.Width = 60
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'remark
        '
        Me.remark.DataPropertyName = "rem_qc"
        Me.remark.HeaderText = "remark"
        Me.remark.Name = "remark"
        '
        'roll_no_f
        '
        Me.roll_no_f.DataPropertyName = "roll_no_f"
        Me.roll_no_f.HeaderText = "roll_no_f"
        Me.roll_no_f.Name = "roll_no_f"
        Me.roll_no_f.Visible = False
        Me.roll_no_f.Width = 5
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 293
        Me.Label6.Text = "Bill No."
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(251, 75)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(96, 22)
        Me.txtLotNo.TabIndex = 292
        Me.txtLotNo.TabStop = False
        Me.txtLotNo.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 291
        Me.Label5.Text = "Lot No."
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
        'cboDinNo
        '
        Me.cboDinNo.Name = "cboDinNo"
        Me.cboDinNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "DIN No."
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
        Me.txtDFNo.Location = New System.Drawing.Point(251, 21)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.Size = New System.Drawing.Size(96, 22)
        Me.txtDFNo.TabIndex = 290
        Me.txtDFNo.TabStop = False
        Me.txtDFNo.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 289
        Me.Label1.Text = "DF No."
        '
        'dtpDINDate
        '
        Me.dtpDINDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDINDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDINDate.Enabled = False
        Me.dtpDINDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDINDate.Location = New System.Drawing.Point(1024, 69)
        Me.dtpDINDate.Name = "dtpDINDate"
        Me.dtpDINDate.Size = New System.Drawing.Size(96, 22)
        Me.dtpDINDate.TabIndex = 288
        Me.dtpDINDate.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtDINNo
        '
        Me.txtDINNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDINNo.Location = New System.Drawing.Point(1024, 28)
        Me.txtDINNo.Name = "txtDINNo"
        Me.txtDINNo.ReadOnly = True
        Me.txtDINNo.Size = New System.Drawing.Size(96, 22)
        Me.txtDINNo.TabIndex = 287
        Me.txtDINNo.TabStop = False
        Me.txtDINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(963, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 286
        Me.Label3.Text = "DIN No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDinNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1132, 25)
        Me.ToolStrip1.TabIndex = 285
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDInDocument, Me.tsbDInTag, Me.tsbMInDocument})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbDInDocument
        '
        Me.tsbDInDocument.Name = "tsbDInDocument"
        Me.tsbDInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInDocument.Text = "D-IN Document"
        '
        'tsbDInTag
        '
        Me.tsbDInTag.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnDINTagStandard, Me.tsmnDINTagSTG, Me.tsmnDINTagPTIndonesiaWacoal})
        Me.tsbDInTag.Name = "tsbDInTag"
        Me.tsbDInTag.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInTag.Text = "D-IN Tag"
        '
        'tsmnDINTagStandard
        '
        Me.tsmnDINTagStandard.Name = "tsmnDINTagStandard"
        Me.tsmnDINTagStandard.Size = New System.Drawing.Size(243, 22)
        Me.tsmnDINTagStandard.Text = "D-IN Tag (Standard)"
        '
        'tsmnDINTagSTG
        '
        Me.tsmnDINTagSTG.Name = "tsmnDINTagSTG"
        Me.tsmnDINTagSTG.Size = New System.Drawing.Size(243, 22)
        Me.tsmnDINTagSTG.Text = "D-IN Tag (STG)"
        '
        'tsbMInDocument
        '
        Me.tsbMInDocument.Name = "tsbMInDocument"
        Me.tsbMInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbMInDocument.Text = "M-IN Document"
        Me.tsbMInDocument.Visible = False
        '
        'dtpdodt
        '
        Me.dtpdodt.CustomFormat = "dd/MM/yyyy"
        Me.dtpdodt.Enabled = False
        Me.dtpdodt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdodt.Location = New System.Drawing.Point(87, 74)
        Me.dtpdodt.Name = "dtpdodt"
        Me.dtpdodt.Size = New System.Drawing.Size(100, 22)
        Me.dtpdodt.TabIndex = 297
        Me.dtpdodt.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 23)
        '
        'btnSearchDFNo
        '
        Me.btnSearchDFNo.Image = CType(resources.GetObject("btnSearchDFNo.Image"), System.Drawing.Image)
        Me.btnSearchDFNo.Location = New System.Drawing.Point(353, 20)
        Me.btnSearchDFNo.Name = "btnSearchDFNo"
        Me.btnSearchDFNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDFNo.TabIndex = 298
        Me.btnSearchDFNo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(900, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 307
        Me.Label4.Text = "Yds"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(764, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 306
        Me.Label7.Text = "Mts"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(377, 447)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalRolls.TabIndex = 299
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(626, 449)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 305
        Me.Label8.Text = "Kgs"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 304
        Me.Label9.Text = "Rolls"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(794, 446)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalYds.TabIndex = 303
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(657, 447)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMts.TabIndex = 302
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(520, 447)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalKgs.TabIndex = 301
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(340, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 300
        Me.Label10.Text = "Total"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 473)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 295
        Me.Label2.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(63, 473)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(866, 22)
        Me.txtRemark.TabIndex = 296
        Me.txtRemark.TabStop = False
        Me.txtRemark.Tag = ""
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(87, 22)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(100, 22)
        Me.txtBillNo.TabIndex = 308
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(957, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 309
        Me.Label11.Text = "DIN Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 310
        Me.Label12.Text = "Bill Date"
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(1022, 142)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(104, 32)
        Me.chkAutoCalculate.TabIndex = 357
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'BtnCopyRoll
        '
        Me.BtnCopyRoll.Location = New System.Drawing.Point(7, 151)
        Me.BtnCopyRoll.Name = "BtnCopyRoll"
        Me.BtnCopyRoll.Size = New System.Drawing.Size(75, 23)
        Me.BtnCopyRoll.TabIndex = 358
        Me.BtnCopyRoll.Text = "Copy Roll"
        Me.BtnCopyRoll.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtDFNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSearchDFNo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBillNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLotNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpdodt)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 117)
        Me.GroupBox1.TabIndex = 359
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "D/F Detail"
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDyedHouse.FormattingEnabled = True
        Me.cboDyedHouse.Location = New System.Drawing.Point(87, 50)
        Me.cboDyedHouse.Name = "cboDyedHouse"
        Me.cboDyedHouse.Size = New System.Drawing.Size(260, 21)
        Me.cboDyedHouse.TabIndex = 366
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(10, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 365
        Me.Label17.Text = "Dyed House"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(91, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(788, 13)
        Me.Label13.TabIndex = 360
        Me.Label13.Text = "*** ถ้า S/O เป็นของ Wacoal Dominiican (Customer Code = '067','068','069','070' ) " &
    "และใส่ Roll No = 'W' จะรันหมายเลข Roll No ของ Wacoal Dominican"
        '
        'tsmnDINTagPTIndonesiaWacoal
        '
        Me.tsmnDINTagPTIndonesiaWacoal.Name = "tsmnDINTagPTIndonesiaWacoal"
        Me.tsmnDINTagPTIndonesiaWacoal.Size = New System.Drawing.Size(243, 22)
        Me.tsmnDINTagPTIndonesiaWacoal.Text = "D-IN Tag (PT indonesia Wacoal)"
        '
        'frmStockDINManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 546)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCopyRoll)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.dtpDINDate)
        Me.Controls.Add(Me.txtDINNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStockDINManual"
        Me.Text = "D-IN Manual"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboDinNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDINNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents dtpdodt As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearchDFNo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCopyRoll As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboDyedHouse As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbDInDocument As ToolStripMenuItem
    Friend WithEvents tsbDInTag As ToolStripMenuItem
    Friend WithEvents tsbMInDocument As ToolStripMenuItem
    Friend WithEvents tsmnDINTagStandard As ToolStripMenuItem
    Friend WithEvents tsmnDINTagSTG As ToolStripMenuItem
    Friend WithEvents dono As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents fwth As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_d As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents GammaRollSeqNo As DataGridViewTextBoxColumn
    Friend WithEvents gross_wt_kg As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents gross_mts As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_f As DataGridViewTextBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents tsmnDINTagPTIndonesiaWacoal As ToolStripMenuItem
End Class
