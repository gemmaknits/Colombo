<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPLD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.btngout = New System.Windows.Forms.Button()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.grdDataCartons_netwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_CartRolls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.grdDataPackingList = New System.Windows.Forms.DataGridView()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_packno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.CartMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons = New System.Windows.Forms.DataGridView()
        Me.grdDataCartons_grswt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_dimension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchREQD = New System.Windows.Forms.Button()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSearchPackno = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboCartonsNo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrintPLD = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnPrintDOut = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Request No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.btngout)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(707, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 84)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(16, 56)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(64, 13)
        Me.lblOutdt.TabIndex = 39
        Me.lblOutdt.Text = "DOUT Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "DOUT No."
        '
        'DtpOutdt
        '
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(90, 53)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.Size = New System.Drawing.Size(117, 20)
        Me.DtpOutdt.TabIndex = 38
        '
        'btngout
        '
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngout.Location = New System.Drawing.Point(223, 24)
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
        Me.txtOutNo.Location = New System.Drawing.Point(90, 23)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(117, 20)
        Me.txtOutNo.TabIndex = 36
        '
        'grdDataCartons_netwt
        '
        Me.grdDataCartons_netwt.DataPropertyName = "netwt"
        Me.grdDataCartons_netwt.HeaderText = "Net wt (Kg.)"
        Me.grdDataCartons_netwt.Name = "grdDataCartons_netwt"
        Me.grdDataCartons_netwt.Width = 60
        '
        'grdDataCartons_CartRolls
        '
        Me.grdDataCartons_CartRolls.DataPropertyName = "CartRolls"
        Me.grdDataCartons_CartRolls.HeaderText = "Rolls"
        Me.grdDataCartons_CartRolls.Name = "grdDataCartons_CartRolls"
        Me.grdDataCartons_CartRolls.Width = 30
        '
        'txtReqNo
        '
        Me.txtReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(81, 23)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(119, 20)
        Me.txtReqNo.TabIndex = 44
        '
        'grdDataPackingList
        '
        Me.grdDataPackingList.AllowUserToAddRows = False
        Me.grdDataPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.grdDataPackingList_lot, Me.grdDataPackingList_custcolor, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.grdDataPackingList_col, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.grdDataPackingList_fwth})
        Me.grdDataPackingList.Location = New System.Drawing.Point(557, 129)
        Me.grdDataPackingList.Name = "grdDataPackingList"
        Me.grdDataPackingList.Size = New System.Drawing.Size(691, 443)
        Me.grdDataPackingList.TabIndex = 76
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 40
        '
        'grdDataPackingList_lot
        '
        Me.grdDataPackingList_lot.DataPropertyName = "lot"
        Me.grdDataPackingList_lot.HeaderText = "Lot"
        Me.grdDataPackingList_lot.Name = "grdDataPackingList_lot"
        '
        'grdDataPackingList_custcolor
        '
        Me.grdDataPackingList_custcolor.DataPropertyName = "custcolor"
        Me.grdDataPackingList_custcolor.HeaderText = "Custcolor"
        Me.grdDataPackingList_custcolor.Name = "grdDataPackingList_custcolor"
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_d"
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (D)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.ReadOnly = True
        Me.grdDataPackingList_roll_no_g.Width = 110
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.ReadOnly = True
        Me.grdDataPackingList_roll_no_o.Width = 120
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.Width = 40
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.HeaderText = "design_no"
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        Me.grdDataPackingList_design_no.Width = 90
        '
        'grdDataPackingList_col
        '
        Me.grdDataPackingList_col.DataPropertyName = "col"
        Me.grdDataPackingList_col.HeaderText = "Col"
        Me.grdDataPackingList_col.Name = "grdDataPackingList_col"
        Me.grdDataPackingList_col.Width = 80
        '
        'grdDataPackingList_outkg_g
        '
        Me.grdDataPackingList_outkg_g.DataPropertyName = "outkg_g"
        Me.grdDataPackingList_outkg_g.HeaderText = "Kgs"
        Me.grdDataPackingList_outkg_g.Name = "grdDataPackingList_outkg_g"
        Me.grdDataPackingList_outkg_g.Width = 60
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
        'grdDataPackingList_fwth
        '
        Me.grdDataPackingList_fwth.DataPropertyName = "Fwth"
        Me.grdDataPackingList_fwth.HeaderText = "Fwth"
        Me.grdDataPackingList_fwth.Name = "grdDataPackingList_fwth"
        Me.grdDataPackingList_fwth.Width = 60
        '
        'grdDataCartons_packno
        '
        Me.grdDataCartons_packno.DataPropertyName = "packno"
        Me.grdDataCartons_packno.HeaderText = "packno"
        Me.grdDataCartons_packno.Name = "grdDataCartons_packno"
        Me.grdDataCartons_packno.Visible = False
        '
        'grdDataCartons_cartno
        '
        Me.grdDataCartons_cartno.DataPropertyName = "cartno"
        Me.grdDataCartons_cartno.HeaderText = "Carton No."
        Me.grdDataCartons_cartno.Name = "grdDataCartons_cartno"
        Me.grdDataCartons_cartno.Width = 40
        '
        'CartYds
        '
        Me.CartYds.HeaderText = "(Yds.)"
        Me.CartYds.Name = "CartYds"
        Me.CartYds.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1023, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Packing No."
        '
        'txtPackNo
        '
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(1095, 55)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.Size = New System.Drawing.Size(117, 20)
        Me.txtPackNo.TabIndex = 73
        '
        'CartMts
        '
        Me.CartMts.HeaderText = "(Mts.)"
        Me.CartMts.Name = "CartMts"
        Me.CartMts.Width = 60
        '
        'grdDataCartons
        '
        Me.grdDataCartons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataCartons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataCartons_cartno, Me.grdDataCartons_packno, Me.grdDataCartons_CartRolls, Me.grdDataCartons_netwt, Me.grdDataCartons_grswt, Me.CartMts, Me.CartYds, Me.grdDataCartons_dimension})
        Me.grdDataCartons.Location = New System.Drawing.Point(12, 129)
        Me.grdDataCartons.Name = "grdDataCartons"
        Me.grdDataCartons.Size = New System.Drawing.Size(537, 443)
        Me.grdDataCartons.TabIndex = 72
        '
        'grdDataCartons_grswt
        '
        Me.grdDataCartons_grswt.DataPropertyName = "grswt"
        Me.grdDataCartons_grswt.HeaderText = "Gross wt. (Kg.)"
        Me.grdDataCartons_grswt.Name = "grdDataCartons_grswt"
        Me.grdDataCartons_grswt.Width = 60
        '
        'grdDataCartons_dimension
        '
        Me.grdDataCartons_dimension.DataPropertyName = "dimension"
        Me.grdDataCartons_dimension.HeaderText = "Dimension"
        Me.grdDataCartons_dimension.Name = "grdDataCartons_dimension"
        Me.grdDataCartons_dimension.Width = 200
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(1056, 103)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(192, 24)
        Me.lblCancelled.TabIndex = 92
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.Visible = False
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(299, 26)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 70
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(401, 22)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(121, 21)
        Me.CboDoc_type.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LbDoctype)
        Me.GroupBox2.Controls.Add(Me.txtReqNo)
        Me.GroupBox2.Controls.Add(Me.CboDoc_type)
        Me.GroupBox2.Controls.Add(Me.btnSearchREQD)
        Me.GroupBox2.Controls.Add(Me.txtcustomer)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 85)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        '
        'btnSearchREQD
        '
        Me.btnSearchREQD.Image = CType(resources.GetObject("btnSearchREQD.Image"), System.Drawing.Image)
        Me.btnSearchREQD.Location = New System.Drawing.Point(206, 21)
        Me.btnSearchREQD.Name = "btnSearchREQD"
        Me.btnSearchREQD.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQD.TabIndex = 64
        Me.btnSearchREQD.UseVisualStyleBackColor = True
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(81, 55)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(269, 20)
        Me.txtcustomer.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Customer"
        '
        'btnSearchPackno
        '
        Me.btnSearchPackno.Image = CType(resources.GetObject("btnSearchPackno.Image"), System.Drawing.Image)
        Me.btnSearchPackno.Location = New System.Drawing.Point(1218, 55)
        Me.btnSearchPackno.Name = "btnSearchPackno"
        Me.btnSearchPackno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchPackno.TabIndex = 90
        Me.btnSearchPackno.Text = "PackingList Dyes & Out"
        Me.btnSearchPackno.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(571, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Carton No."
        '
        'CboCartonsNo
        '
        Me.CboCartonsNo.FormattingEnabled = True
        Me.CboCartonsNo.Location = New System.Drawing.Point(574, 97)
        Me.CboCartonsNo.Name = "CboCartonsNo"
        Me.CboCartonsNo.Size = New System.Drawing.Size(121, 21)
        Me.CboCartonsNo.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1059, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Date"
        '
        'DtpPackDate
        '
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(1095, 79)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpPackDate.TabIndex = 86
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1201, 582)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Yds"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnPrintPLD
        '
        Me.BtnPrintPLD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintPLD.Image = CType(resources.GetObject("BtnPrintPLD.Image"), System.Drawing.Image)
        Me.BtnPrintPLD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPLD.Name = "BtnPrintPLD"
        Me.BtnPrintPLD.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintPLD.Text = "Print"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1065, 580)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Mts"
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
        'txtTotalRolls
        '
        Me.txtTotalRolls.Location = New System.Drawing.Point(678, 579)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(785, 581)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Rolls"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(927, 581)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Kgs"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Location = New System.Drawing.Point(1095, 578)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 81
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Location = New System.Drawing.Point(958, 579)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 80
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Location = New System.Drawing.Point(821, 579)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Total"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNew, Me.BtnSave, Me.BtnPrintPLD, Me.BtnPrintDOut, Me.BtnCancel, Me.BtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1265, 25)
        Me.ToolStrip1.TabIndex = 75
        '
        'BtnPrintDOut
        '
        Me.BtnPrintDOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintDOut.Image = CType(resources.GetObject("BtnPrintDOut.Image"), System.Drawing.Image)
        Me.BtnPrintDOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintDOut.Name = "BtnPrintDOut"
        Me.BtnPrintDOut.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintDOut.Text = "Print (Dyed Out)"
        '
        'frmPLD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 741)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdDataPackingList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPackNo)
        Me.Controls.Add(Me.grdDataCartons)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSearchPackno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboCartonsNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpPackDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmPLD"
        Me.Text = "Dyed Out From PLD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutdt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DtpOutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngout As System.Windows.Forms.Button
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataCartons_netwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_CartRolls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataPackingList As System.Windows.Forms.DataGridView
    Friend WithEvents grdDataPackingList_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_fwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_packno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartYds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
    Friend WithEvents CartMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons As System.Windows.Forms.DataGridView
    Friend WithEvents grdDataCartons_grswt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_dimension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents CboDoc_type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchREQD As System.Windows.Forms.Button
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSearchPackno As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CboCartonsNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DtpPackDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintPLD As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnPrintDOut As System.Windows.Forms.ToolStripButton
End Class
