<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackingListDyed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackingListDyed))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.grdDataPackingList_lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.btngout = New System.Windows.Forms.Button()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.grdDataPackingList_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OptLotNo = New System.Windows.Forms.RadioButton()
        Me.optDinNo = New System.Windows.Forms.RadioButton()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.optReqNo = New System.Windows.Forms.RadioButton()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.btnSearchREQD = New System.Windows.Forms.Button()
        Me.CboCartonsNo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.grdDataPackingList_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_strolls_d_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearchPackno = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintPLD = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintDOUT = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdDataCartons = New System.Windows.Forms.DataGridView()
        Me.grdDataCartons_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_packno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_CartRolls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_netwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_grswt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_dimension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.grdDataPackingList = New System.Windows.Forms.DataGridView()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.btnPrintChantasiaLabel = New System.Windows.Forms.Button()
        Me.btnPrintCartonLabel = New System.Windows.Forms.Button()
        Me.chkAutoGenCarntonNo = New System.Windows.Forms.CheckBox()
        Me.mnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        Me.grdDataPackingList_cartno.Frozen = True
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 40
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMoveLeft.Location = New System.Drawing.Point(528, 204)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveLeft.TabIndex = 133
        Me.btnMoveLeft.Text = "<..."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'batch
        '
        Me.batch.DataPropertyName = "batch"
        Me.batch.HeaderText = "Box No"
        Me.batch.Name = "batch"
        Me.batch.Width = 40
        '
        'lblDocNo
        '
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(22, 54)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(47, 13)
        Me.lblDocNo.TabIndex = 43
        Me.lblDocNo.Text = "Req No."
        '
        'grdDataPackingList_lot
        '
        Me.grdDataPackingList_lot.DataPropertyName = "lot"
        Me.grdDataPackingList_lot.HeaderText = "Lot"
        Me.grdDataPackingList_lot.Name = "grdDataPackingList_lot"
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_d"
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (D)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.ReadOnly = True
        Me.grdDataPackingList_roll_no_g.Width = 110
        '
        'txtDocNo
        '
        Me.txtDocNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(85, 51)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(119, 20)
        Me.txtDocNo.TabIndex = 44
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.ReadOnly = True
        Me.grdDataPackingList_roll_no_o.Width = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnYarnPrintBar)
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.btngout)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(519, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 119)
        Me.GroupBox1.TabIndex = 130
        Me.GroupBox1.TabStop = False
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(154, 70)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(93, 43)
        Me.BtnYarnPrintBar.TabIndex = 135
        Me.BtnYarnPrintBar.Text = "Print bar label"
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = False
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(12, 47)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(64, 13)
        Me.lblOutdt.TabIndex = 39
        Me.lblOutdt.Text = "DOUT Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "DOUT No."
        '
        'DtpOutdt
        '
        Me.DtpOutdt.Checked = False
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(86, 44)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.ShowCheckBox = True
        Me.DtpOutdt.Size = New System.Drawing.Size(98, 20)
        Me.DtpOutdt.TabIndex = 38
        '
        'btngout
        '
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngout.Location = New System.Drawing.Point(190, 15)
        Me.btngout.Name = "btngout"
        Me.btngout.Size = New System.Drawing.Size(57, 49)
        Me.btngout.TabIndex = 34
        Me.btngout.Text = "DOUT"
        Me.btngout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngout.UseVisualStyleBackColor = True
        '
        'txtOutNo
        '
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(86, 16)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(98, 20)
        Me.txtOutNo.TabIndex = 36
        '
        'grdDataPackingList_custcolor
        '
        Me.grdDataPackingList_custcolor.DataPropertyName = "custcolor"
        Me.grdDataPackingList_custcolor.HeaderText = "Custcolor"
        Me.grdDataPackingList_custcolor.Name = "grdDataPackingList_custcolor"
        '
        'OptLotNo
        '
        Me.OptLotNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptLotNo.AutoSize = True
        Me.OptLotNo.Location = New System.Drawing.Point(258, 19)
        Me.OptLotNo.Name = "OptLotNo"
        Me.OptLotNo.Size = New System.Drawing.Size(63, 17)
        Me.OptLotNo.TabIndex = 79
        Me.OptLotNo.TabStop = True
        Me.OptLotNo.Text = "Lot  No."
        Me.OptLotNo.UseVisualStyleBackColor = True
        '
        'optDinNo
        '
        Me.optDinNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.optDinNo.AutoSize = True
        Me.optDinNo.Location = New System.Drawing.Point(153, 19)
        Me.optDinNo.Name = "optDinNo"
        Me.optDinNo.Size = New System.Drawing.Size(64, 17)
        Me.optDinNo.TabIndex = 78
        Me.optDinNo.TabStop = True
        Me.optDinNo.Text = "DIN No."
        Me.optDinNo.UseVisualStyleBackColor = True
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.Width = 40
        '
        'optReqNo
        '
        Me.optReqNo.AutoSize = True
        Me.optReqNo.Checked = True
        Me.optReqNo.Location = New System.Drawing.Point(24, 19)
        Me.optReqNo.Name = "optReqNo"
        Me.optReqNo.Size = New System.Drawing.Size(85, 17)
        Me.optReqNo.TabIndex = 77
        Me.optReqNo.TabStop = True
        Me.optReqNo.Text = "Request No."
        Me.optReqNo.UseVisualStyleBackColor = True
        '
        'LbDoctype
        '
        Me.LbDoctype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(272, 53)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 70
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.OptLotNo)
        Me.GroupBox2.Controls.Add(Me.optDinNo)
        Me.GroupBox2.Controls.Add(Me.optReqNo)
        Me.GroupBox2.Controls.Add(Me.lblDocNo)
        Me.GroupBox2.Controls.Add(Me.LbDoctype)
        Me.GroupBox2.Controls.Add(Me.txtDocNo)
        Me.GroupBox2.Controls.Add(Me.CboDoc_type)
        Me.GroupBox2.Controls.Add(Me.btnSearchREQD)
        Me.GroupBox2.Controls.Add(Me.CboCartonsNo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcustomer)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 119)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        '
        'CboDoc_type
        '
        Me.CboDoc_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(374, 49)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(121, 21)
        Me.CboDoc_type.TabIndex = 69
        '
        'btnSearchREQD
        '
        Me.btnSearchREQD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchREQD.Image = CType(resources.GetObject("btnSearchREQD.Image"), System.Drawing.Image)
        Me.btnSearchREQD.Location = New System.Drawing.Point(210, 49)
        Me.btnSearchREQD.Name = "btnSearchREQD"
        Me.btnSearchREQD.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQD.TabIndex = 64
        Me.btnSearchREQD.UseVisualStyleBackColor = True
        '
        'CboCartonsNo
        '
        Me.CboCartonsNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboCartonsNo.Enabled = False
        Me.CboCartonsNo.FormattingEnabled = True
        Me.CboCartonsNo.Location = New System.Drawing.Point(374, 81)
        Me.CboCartonsNo.Name = "CboCartonsNo"
        Me.CboCartonsNo.Size = New System.Drawing.Size(121, 21)
        Me.CboCartonsNo.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Carton No."
        '
        'txtcustomer
        '
        Me.txtcustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcustomer.Location = New System.Drawing.Point(85, 79)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(217, 20)
        Me.txtcustomer.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Customer"
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMoveRight.Location = New System.Drawing.Point(528, 228)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveRight.TabIndex = 134
        Me.btnMoveRight.Text = "...>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'grdDataPackingList_col
        '
        Me.grdDataPackingList_col.DataPropertyName = "col"
        Me.grdDataPackingList_col.HeaderText = "Col"
        Me.grdDataPackingList_col.Name = "grdDataPackingList_col"
        Me.grdDataPackingList_col.Width = 80
        '
        'id_strolls_d_o
        '
        Me.id_strolls_d_o.DataPropertyName = "id_strolls_d_o"
        Me.id_strolls_d_o.HeaderText = "id_strolls_d_o"
        Me.id_strolls_d_o.Name = "id_strolls_d_o"
        Me.id_strolls_d_o.Visible = False
        '
        'grdDataPackingList_outkg_g
        '
        Me.grdDataPackingList_outkg_g.DataPropertyName = "outkg_g"
        Me.grdDataPackingList_outkg_g.HeaderText = "Kgs"
        Me.grdDataPackingList_outkg_g.Name = "grdDataPackingList_outkg_g"
        Me.grdDataPackingList_outkg_g.Width = 60
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.HeaderText = "design_no"
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        Me.grdDataPackingList_design_no.Width = 90
        '
        'grdDataPackingList_fwth
        '
        Me.grdDataPackingList_fwth.DataPropertyName = "Fwth"
        Me.grdDataPackingList_fwth.HeaderText = "Fwth"
        Me.grdDataPackingList_fwth.Name = "grdDataPackingList_fwth"
        Me.grdDataPackingList_fwth.Width = 60
        '
        'grdDataPackingList_outmt_g
        '
        Me.grdDataPackingList_outmt_g.DataPropertyName = "outmt_g"
        Me.grdDataPackingList_outmt_g.HeaderText = "Mts"
        Me.grdDataPackingList_outmt_g.Name = "grdDataPackingList_outmt_g"
        Me.grdDataPackingList_outmt_g.Width = 60
        '
        'grdDataPackingList_outyd_g
        '
        Me.grdDataPackingList_outyd_g.DataPropertyName = "outyd_g"
        Me.grdDataPackingList_outyd_g.HeaderText = "Yds"
        Me.grdDataPackingList_outyd_g.Name = "grdDataPackingList_outyd_g"
        Me.grdDataPackingList_outyd_g.Width = 60
        '
        'btnSearchPackno
        '
        Me.btnSearchPackno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchPackno.Image = CType(resources.GetObject("btnSearchPackno.Image"), System.Drawing.Image)
        Me.btnSearchPackno.Location = New System.Drawing.Point(969, 47)
        Me.btnSearchPackno.Name = "btnSearchPackno"
        Me.btnSearchPackno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchPackno.TabIndex = 129
        Me.btnSearchPackno.Text = "PackingList Dyes & Out"
        Me.btnSearchPackno.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(789, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Date"
        '
        'DtpPackDate
        '
        Me.DtpPackDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(846, 71)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpPackDate.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 550)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Yds"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 548)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Mts"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(57, 547)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Kgs"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Rolls"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(474, 546)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 122
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(337, 547)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 121
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(316, 22)
        Me.ToolStripLabel1.Text = "**โปรแกรม จะไม่ทำการแก้ไข Packing List  ที่ Costing ไปแล้ว"
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(200, 547)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 550)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Total"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNew, Me.BtnSave, Me.BtnPrintPLD, Me.BtnPrintDOUT, Me.BtnCancel, Me.BtnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 116
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'BtnSave
        '
        Me.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(23, 22)
        Me.BtnSave.Text = "Save"
        '
        'BtnPrintPLD
        '
        Me.BtnPrintPLD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintPLD.Image = CType(resources.GetObject("BtnPrintPLD.Image"), System.Drawing.Image)
        Me.BtnPrintPLD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPLD.Name = "BtnPrintPLD"
        Me.BtnPrintPLD.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintPLD.Text = "Print (Packing List Dyed)"
        '
        'BtnPrintDOUT
        '
        Me.BtnPrintDOUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintDOUT.Image = CType(resources.GetObject("BtnPrintDOUT.Image"), System.Drawing.Image)
        Me.BtnPrintDOUT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintDOUT.Name = "BtnPrintDOUT"
        Me.BtnPrintDOUT.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintDOUT.Text = "Print (Dyed Out)"
        '
        'BtnCancel
        '
        Me.BtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(23, 22)
        Me.BtnCancel.Text = "Cancel Document"
        '
        'BtnExit
        '
        Me.BtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(23, 22)
        Me.BtnExit.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(787, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Pack No."
        '
        'grdDataCartons
        '
        Me.grdDataCartons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDataCartons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataCartons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataCartons_cartno, Me.grdDataCartons_packno, Me.grdDataCartons_CartRolls, Me.grdDataCartons_netwt, Me.grdDataCartons_grswt, Me.CartMts, Me.CartYds, Me.grdDataCartons_dimension})
        Me.grdDataCartons.Location = New System.Drawing.Point(12, 204)
        Me.grdDataCartons.Name = "grdDataCartons"
        Me.grdDataCartons.Size = New System.Drawing.Size(510, 325)
        Me.grdDataCartons.TabIndex = 113
        '
        'grdDataCartons_cartno
        '
        Me.grdDataCartons_cartno.DataPropertyName = "cartno"
        Me.grdDataCartons_cartno.HeaderText = "Carton No."
        Me.grdDataCartons_cartno.Name = "grdDataCartons_cartno"
        Me.grdDataCartons_cartno.ReadOnly = True
        Me.grdDataCartons_cartno.Width = 40
        '
        'grdDataCartons_packno
        '
        Me.grdDataCartons_packno.DataPropertyName = "packno"
        Me.grdDataCartons_packno.HeaderText = "packno"
        Me.grdDataCartons_packno.Name = "grdDataCartons_packno"
        Me.grdDataCartons_packno.Visible = False
        '
        'grdDataCartons_CartRolls
        '
        Me.grdDataCartons_CartRolls.DataPropertyName = "CartRolls"
        Me.grdDataCartons_CartRolls.HeaderText = "Rolls"
        Me.grdDataCartons_CartRolls.Name = "grdDataCartons_CartRolls"
        Me.grdDataCartons_CartRolls.Width = 30
        '
        'grdDataCartons_netwt
        '
        Me.grdDataCartons_netwt.DataPropertyName = "netwt"
        DataGridViewCellStyle9.Format = "N2"
        Me.grdDataCartons_netwt.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdDataCartons_netwt.HeaderText = "Net wt (Kg.)"
        Me.grdDataCartons_netwt.Name = "grdDataCartons_netwt"
        Me.grdDataCartons_netwt.Width = 60
        '
        'grdDataCartons_grswt
        '
        Me.grdDataCartons_grswt.DataPropertyName = "grswt"
        DataGridViewCellStyle10.Format = "N2"
        Me.grdDataCartons_grswt.DefaultCellStyle = DataGridViewCellStyle10
        Me.grdDataCartons_grswt.HeaderText = "Gross wt. (Kg.)"
        Me.grdDataCartons_grswt.Name = "grdDataCartons_grswt"
        Me.grdDataCartons_grswt.Width = 60
        '
        'CartMts
        '
        DataGridViewCellStyle11.Format = "N2"
        Me.CartMts.DefaultCellStyle = DataGridViewCellStyle11
        Me.CartMts.HeaderText = "(Mts.)"
        Me.CartMts.Name = "CartMts"
        Me.CartMts.Width = 60
        '
        'CartYds
        '
        DataGridViewCellStyle12.Format = "N2"
        Me.CartYds.DefaultCellStyle = DataGridViewCellStyle12
        Me.CartYds.HeaderText = "(Yds.)"
        Me.CartYds.Name = "CartYds"
        Me.CartYds.Width = 60
        '
        'grdDataCartons_dimension
        '
        Me.grdDataCartons_dimension.DataPropertyName = "dimension"
        Me.grdDataCartons_dimension.HeaderText = "Dimension"
        Me.grdDataCartons_dimension.Name = "grdDataCartons_dimension"
        Me.grdDataCartons_dimension.Width = 200
        '
        'txtPackNo
        '
        Me.txtPackNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(846, 47)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.Size = New System.Drawing.Size(117, 20)
        Me.txtPackNo.TabIndex = 114
        '
        'grdDataPackingList
        '
        Me.grdDataPackingList.AllowUserToAddRows = False
        Me.grdDataPackingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.batch, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_lot, Me.grdDataPackingList_custcolor, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.grdDataPackingList_col, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.grdDataPackingList_fwth, Me.id_strolls_d_o})
        Me.grdDataPackingList.Location = New System.Drawing.Point(566, 204)
        Me.grdDataPackingList.Name = "grdDataPackingList"
        Me.grdDataPackingList.Size = New System.Drawing.Size(430, 325)
        Me.grdDataPackingList.TabIndex = 117
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(786, 95)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(192, 24)
        Me.lblCancelled.TabIndex = 131
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.Visible = False
        '
        'btnPrintChantasiaLabel
        '
        Me.btnPrintChantasiaLabel.Location = New System.Drawing.Point(138, 174)
        Me.btnPrintChantasiaLabel.Name = "btnPrintChantasiaLabel"
        Me.btnPrintChantasiaLabel.Size = New System.Drawing.Size(143, 22)
        Me.btnPrintChantasiaLabel.TabIndex = 136
        Me.btnPrintChantasiaLabel.Text = "Print Chantasia Label"
        Me.btnPrintChantasiaLabel.UseVisualStyleBackColor = True
        '
        'btnPrintCartonLabel
        '
        Me.btnPrintCartonLabel.Location = New System.Drawing.Point(12, 174)
        Me.btnPrintCartonLabel.Name = "btnPrintCartonLabel"
        Me.btnPrintCartonLabel.Size = New System.Drawing.Size(99, 22)
        Me.btnPrintCartonLabel.TabIndex = 135
        Me.btnPrintCartonLabel.Text = "Print Carton Label"
        Me.btnPrintCartonLabel.UseVisualStyleBackColor = True
        '
        'chkAutoGenCarntonNo
        '
        Me.chkAutoGenCarntonNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoGenCarntonNo.AutoSize = True
        Me.chkAutoGenCarntonNo.Checked = True
        Me.chkAutoGenCarntonNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenCarntonNo.Location = New System.Drawing.Point(871, 176)
        Me.chkAutoGenCarntonNo.Name = "chkAutoGenCarntonNo"
        Me.chkAutoGenCarntonNo.Size = New System.Drawing.Size(125, 17)
        Me.chkAutoGenCarntonNo.TabIndex = 137
        Me.chkAutoGenCarntonNo.Text = "Auto Gen Carton No."
        Me.chkAutoGenCarntonNo.UseVisualStyleBackColor = True
        Me.chkAutoGenCarntonNo.Visible = False
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cut, Me.Copy, Me.Paste})
        Me.mnu.Name = "ContextMenuStrip1"
        Me.mnu.Size = New System.Drawing.Size(145, 70)
        '
        'Cut
        '
        Me.Cut.Name = "Cut"
        Me.Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Cut.Size = New System.Drawing.Size(144, 22)
        Me.Cut.Text = "Cut"
        '
        'Copy
        '
        Me.Copy.Name = "Copy"
        Me.Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Copy.Size = New System.Drawing.Size(144, 22)
        Me.Copy.Text = "Copy"
        '
        'Paste
        '
        Me.Paste.Name = "Paste"
        Me.Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Paste.Size = New System.Drawing.Size(144, 22)
        Me.Paste.Text = "Paste"
        '
        'frmPackingListDyed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 580)
        Me.Controls.Add(Me.chkAutoGenCarntonNo)
        Me.Controls.Add(Me.btnPrintChantasiaLabel)
        Me.Controls.Add(Me.btnPrintCartonLabel)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnSearchPackno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpPackDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdDataCartons)
        Me.Controls.Add(Me.txtPackNo)
        Me.Controls.Add(Me.grdDataPackingList)
        Me.Controls.Add(Me.lblCancelled)
        Me.Name = "frmPackingListDyed"
        Me.Text = "Packing List Dyed & Out"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDataPackingList_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDocNo As System.Windows.Forms.Label
    Friend WithEvents grdDataPackingList_lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataPackingList_roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutdt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DtpOutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngout As System.Windows.Forms.Button
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataPackingList_custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OptLotNo As System.Windows.Forms.RadioButton
    Friend WithEvents optDinNo As System.Windows.Forms.RadioButton
    Friend WithEvents grdDataPackingList_grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents optReqNo As System.Windows.Forms.RadioButton
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CboDoc_type As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchREQD As System.Windows.Forms.Button
    Friend WithEvents CboCartonsNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents grdDataPackingList_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_strolls_d_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_fwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchPackno As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DtpPackDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintPLD As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintDOUT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdDataCartons As System.Windows.Forms.DataGridView
    Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataPackingList As System.Windows.Forms.DataGridView
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents BtnYarnPrintBar As System.Windows.Forms.Button
    Friend WithEvents grdDataCartons_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_packno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_CartRolls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_netwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_grswt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartYds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_dimension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintChantasiaLabel As System.Windows.Forms.Button
    Friend WithEvents btnPrintCartonLabel As System.Windows.Forms.Button
    Friend WithEvents chkAutoGenCarntonNo As System.Windows.Forms.CheckBox
    Friend WithEvents mnu As ContextMenuStrip
    Friend WithEvents Cut As ToolStripMenuItem
    Friend WithEvents Copy As ToolStripMenuItem
    Friend WithEvents Paste As ToolStripMenuItem
End Class
