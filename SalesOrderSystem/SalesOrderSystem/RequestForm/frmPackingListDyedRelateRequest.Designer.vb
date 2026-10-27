<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackingListDyedRelateRequest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackingListDyedRelateRequest))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalCBMCarton = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCBMRoll = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAutoGenCarntonNo = New System.Windows.Forms.CheckBox()
        Me.btnPrintChantasiaLabel = New System.Windows.Forms.Button()
        Me.btnPrintCartonLabel = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.grdDataCartons = New System.Windows.Forms.DataGridView()
        Me.grdDataCartons_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_packno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_CartRolls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_netwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_grswt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_carton_wide = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_carton_long = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_carton_high = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_dimension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_CBMForCarton = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_CBMForRoll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList = New System.Windows.Forms.DataGridView()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_strolls_d_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.btngout = New System.Windows.Forms.Button()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbDInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLDDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DOUTDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnDINTagStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnDINTagSTG = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnTagChantasia = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnTagHanesbrandsVietnam = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.CboCartonsNo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.mnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtTotalYds)
        Me.GroupBox5.Controls.Add(Me.txtTotalKgs)
        Me.GroupBox5.Controls.Add(Me.txtTotalMts)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtTotalRolls)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(522, 436)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(650, 48)
        Me.GroupBox5.TabIndex = 157
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(484, 18)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 122
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(221, 18)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 120
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(359, 18)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Rolls"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Kgs"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(67, 18)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(590, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Yds"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtTotalCBMCarton)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtTotalCBMRoll)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 436)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(464, 48)
        Me.GroupBox4.TabIndex = 156
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total CBM"
        '
        'txtTotalCBMCarton
        '
        Me.txtTotalCBMCarton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCBMCarton.Location = New System.Drawing.Point(104, 18)
        Me.txtTotalCBMCarton.Name = "txtTotalCBMCarton"
        Me.txtTotalCBMCarton.ReadOnly = True
        Me.txtTotalCBMCarton.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCBMCarton.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "CBM Carton"
        '
        'txtTotalCBMRoll
        '
        Me.txtTotalCBMRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCBMRoll.Location = New System.Drawing.Point(329, 18)
        Me.txtTotalCBMRoll.Name = "txtTotalCBMRoll"
        Me.txtTotalCBMRoll.ReadOnly = True
        Me.txtTotalCBMRoll.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCBMRoll.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "CBM Roll"
        '
        'chkAutoGenCarntonNo
        '
        Me.chkAutoGenCarntonNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoGenCarntonNo.AutoSize = True
        Me.chkAutoGenCarntonNo.Checked = True
        Me.chkAutoGenCarntonNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenCarntonNo.Location = New System.Drawing.Point(794, 126)
        Me.chkAutoGenCarntonNo.Name = "chkAutoGenCarntonNo"
        Me.chkAutoGenCarntonNo.Size = New System.Drawing.Size(125, 17)
        Me.chkAutoGenCarntonNo.TabIndex = 155
        Me.chkAutoGenCarntonNo.Text = "Auto Gen Carton No."
        Me.chkAutoGenCarntonNo.UseVisualStyleBackColor = True
        Me.chkAutoGenCarntonNo.Visible = False
        '
        'btnPrintChantasiaLabel
        '
        Me.btnPrintChantasiaLabel.Location = New System.Drawing.Point(135, 120)
        Me.btnPrintChantasiaLabel.Name = "btnPrintChantasiaLabel"
        Me.btnPrintChantasiaLabel.Size = New System.Drawing.Size(176, 22)
        Me.btnPrintChantasiaLabel.TabIndex = 154
        Me.btnPrintChantasiaLabel.Text = "Print Carton Chantasia Label"
        Me.btnPrintChantasiaLabel.UseVisualStyleBackColor = True
        '
        'btnPrintCartonLabel
        '
        Me.btnPrintCartonLabel.Location = New System.Drawing.Point(9, 120)
        Me.btnPrintCartonLabel.Name = "btnPrintCartonLabel"
        Me.btnPrintCartonLabel.Size = New System.Drawing.Size(99, 22)
        Me.btnPrintCartonLabel.TabIndex = 153
        Me.btnPrintCartonLabel.Text = "Print Carton Label"
        Me.btnPrintCartonLabel.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(546, 244)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveLeft.TabIndex = 151
        Me.btnMoveLeft.Text = "<..."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(546, 285)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveRight.TabIndex = 152
        Me.btnMoveRight.Text = "...>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'grdDataCartons
        '
        Me.grdDataCartons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDataCartons.ColumnHeadersHeight = 35
        Me.grdDataCartons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataCartons_cartno, Me.grdDataCartons_packno, Me.grdDataCartons_CartRolls, Me.grdDataCartons_netwt, Me.grdDataCartons_grswt, Me.CartMts, Me.CartYds, Me.grdData_carton_wide, Me.grdData_carton_long, Me.grdData_carton_high, Me.grdDataCartons_dimension, Me.grdData_CBMForCarton, Me.grdData_CBMForRoll})
        Me.grdDataCartons.Location = New System.Drawing.Point(12, 148)
        Me.grdDataCartons.Name = "grdDataCartons"
        Me.grdDataCartons.Size = New System.Drawing.Size(528, 283)
        Me.grdDataCartons.TabIndex = 149
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
        DataGridViewCellStyle1.Format = "N2"
        Me.grdDataCartons_netwt.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdDataCartons_netwt.HeaderText = "Net wt (Kg.)"
        Me.grdDataCartons_netwt.Name = "grdDataCartons_netwt"
        Me.grdDataCartons_netwt.Width = 50
        '
        'grdDataCartons_grswt
        '
        Me.grdDataCartons_grswt.DataPropertyName = "grswt"
        DataGridViewCellStyle2.Format = "N2"
        Me.grdDataCartons_grswt.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDataCartons_grswt.HeaderText = "Gross wt. (Kg.)"
        Me.grdDataCartons_grswt.Name = "grdDataCartons_grswt"
        Me.grdDataCartons_grswt.Width = 50
        '
        'CartMts
        '
        DataGridViewCellStyle3.Format = "N2"
        Me.CartMts.DefaultCellStyle = DataGridViewCellStyle3
        Me.CartMts.HeaderText = "(Mts.)"
        Me.CartMts.Name = "CartMts"
        Me.CartMts.Width = 50
        '
        'CartYds
        '
        DataGridViewCellStyle4.Format = "N2"
        Me.CartYds.DefaultCellStyle = DataGridViewCellStyle4
        Me.CartYds.HeaderText = "(Yds.)"
        Me.CartYds.Name = "CartYds"
        Me.CartYds.Width = 50
        '
        'grdData_carton_wide
        '
        Me.grdData_carton_wide.DataPropertyName = "carton_wide"
        Me.grdData_carton_wide.HeaderText = "Carton Width"
        Me.grdData_carton_wide.Name = "grdData_carton_wide"
        Me.grdData_carton_wide.Width = 50
        '
        'grdData_carton_long
        '
        Me.grdData_carton_long.DataPropertyName = "carton_long"
        Me.grdData_carton_long.HeaderText = "Carton Length"
        Me.grdData_carton_long.Name = "grdData_carton_long"
        Me.grdData_carton_long.Width = 50
        '
        'grdData_carton_high
        '
        Me.grdData_carton_high.DataPropertyName = "carton_high"
        Me.grdData_carton_high.HeaderText = "Carton Height"
        Me.grdData_carton_high.Name = "grdData_carton_high"
        Me.grdData_carton_high.Width = 50
        '
        'grdDataCartons_dimension
        '
        Me.grdDataCartons_dimension.DataPropertyName = "dimension"
        Me.grdDataCartons_dimension.HeaderText = "Dimension"
        Me.grdDataCartons_dimension.Name = "grdDataCartons_dimension"
        Me.grdDataCartons_dimension.Width = 140
        '
        'grdData_CBMForCarton
        '
        Me.grdData_CBMForCarton.DataPropertyName = "CBMForCarton"
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.grdData_CBMForCarton.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdData_CBMForCarton.HeaderText = "CBM Carton"
        Me.grdData_CBMForCarton.Name = "grdData_CBMForCarton"
        Me.grdData_CBMForCarton.ReadOnly = True
        Me.grdData_CBMForCarton.Width = 50
        '
        'grdData_CBMForRoll
        '
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.grdData_CBMForRoll.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdData_CBMForRoll.HeaderText = "CBM Roll"
        Me.grdData_CBMForRoll.Name = "grdData_CBMForRoll"
        Me.grdData_CBMForRoll.ReadOnly = True
        Me.grdData_CBMForRoll.Width = 50
        '
        'grdDataPackingList
        '
        Me.grdDataPackingList.AllowUserToAddRows = False
        Me.grdDataPackingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataPackingList.ColumnHeadersHeight = 35
        Me.grdDataPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.batch, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_lot, Me.grdDataPackingList_custcolor, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.grdDataPackingList_col, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.grdDataPackingList_fwth, Me.id_strolls_d_o})
        Me.grdDataPackingList.Location = New System.Drawing.Point(584, 148)
        Me.grdDataPackingList.Name = "grdDataPackingList"
        Me.grdDataPackingList.Size = New System.Drawing.Size(588, 283)
        Me.grdDataPackingList.TabIndex = 150
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        Me.grdDataPackingList_cartno.Frozen = True
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 40
        '
        'batch
        '
        Me.batch.DataPropertyName = "batch"
        Me.batch.HeaderText = "Box No"
        Me.batch.Name = "batch"
        Me.batch.Width = 40
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_d"
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (D)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.ReadOnly = True
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.ReadOnly = True
        Me.grdDataPackingList_roll_no_o.Width = 110
        '
        'grdDataPackingList_lot
        '
        Me.grdDataPackingList_lot.DataPropertyName = "lot"
        Me.grdDataPackingList_lot.HeaderText = "Lot"
        Me.grdDataPackingList_lot.Name = "grdDataPackingList_lot"
        Me.grdDataPackingList_lot.ReadOnly = True
        Me.grdDataPackingList_lot.Width = 80
        '
        'grdDataPackingList_custcolor
        '
        Me.grdDataPackingList_custcolor.DataPropertyName = "custcolor"
        Me.grdDataPackingList_custcolor.HeaderText = "Custcolor"
        Me.grdDataPackingList_custcolor.Name = "grdDataPackingList_custcolor"
        Me.grdDataPackingList_custcolor.Width = 90
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.ReadOnly = True
        Me.grdDataPackingList_grade.Width = 40
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.HeaderText = "Design No."
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        Me.grdDataPackingList_design_no.ReadOnly = True
        Me.grdDataPackingList_design_no.Width = 90
        '
        'grdDataPackingList_col
        '
        Me.grdDataPackingList_col.DataPropertyName = "col"
        Me.grdDataPackingList_col.HeaderText = "Col"
        Me.grdDataPackingList_col.Name = "grdDataPackingList_col"
        Me.grdDataPackingList_col.ReadOnly = True
        Me.grdDataPackingList_col.Width = 70
        '
        'grdDataPackingList_outkg_g
        '
        Me.grdDataPackingList_outkg_g.DataPropertyName = "outkg_g"
        Me.grdDataPackingList_outkg_g.HeaderText = "Kgs"
        Me.grdDataPackingList_outkg_g.Name = "grdDataPackingList_outkg_g"
        Me.grdDataPackingList_outkg_g.Width = 50
        '
        'grdDataPackingList_outmt_g
        '
        Me.grdDataPackingList_outmt_g.DataPropertyName = "outmt_g"
        Me.grdDataPackingList_outmt_g.HeaderText = "Mts"
        Me.grdDataPackingList_outmt_g.Name = "grdDataPackingList_outmt_g"
        Me.grdDataPackingList_outmt_g.Width = 50
        '
        'grdDataPackingList_outyd_g
        '
        Me.grdDataPackingList_outyd_g.DataPropertyName = "outyd_g"
        Me.grdDataPackingList_outyd_g.HeaderText = "Yds"
        Me.grdDataPackingList_outyd_g.Name = "grdDataPackingList_outyd_g"
        Me.grdDataPackingList_outyd_g.Width = 50
        '
        'grdDataPackingList_fwth
        '
        Me.grdDataPackingList_fwth.DataPropertyName = "Fwth"
        Me.grdDataPackingList_fwth.HeaderText = "Fwth"
        Me.grdDataPackingList_fwth.Name = "grdDataPackingList_fwth"
        Me.grdDataPackingList_fwth.Width = 50
        '
        'id_strolls_d_o
        '
        Me.id_strolls_d_o.DataPropertyName = "id_strolls_d_o"
        Me.id_strolls_d_o.HeaderText = "id_strolls_d_o"
        Me.id_strolls_d_o.Name = "id_strolls_d_o"
        Me.id_strolls_d_o.Width = 60
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtPackNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DtpPackDate)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(991, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 77)
        Me.GroupBox3.TabIndex = 159
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Pack"
        '
        'txtPackNo
        '
        Me.txtPackNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(71, 20)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.ReadOnly = True
        Me.txtPackNo.Size = New System.Drawing.Size(94, 20)
        Me.txtPackNo.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Pack No."
        '
        'DtpPackDate
        '
        Me.DtpPackDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(71, 45)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(94, 20)
        Me.DtpPackDate.TabIndex = 127
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.btngout)
        Me.GroupBox1.Controls.Add(Me.BtnYarnPrintBar)
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(730, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 77)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documents Dyed Out"
        '
        'DtpOutdt
        '
        Me.DtpOutdt.Checked = False
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(91, 45)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.ShowCheckBox = True
        Me.DtpOutdt.Size = New System.Drawing.Size(100, 20)
        Me.DtpOutdt.TabIndex = 147
        '
        'btngout
        '
        Me.btngout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.Location = New System.Drawing.Point(201, 16)
        Me.btngout.Name = "btngout"
        Me.btngout.Size = New System.Drawing.Size(40, 26)
        Me.btngout.TabIndex = 146
        Me.btngout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngout.UseVisualStyleBackColor = True
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnYarnPrintBar.Enabled = False
        Me.BtnYarnPrintBar.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(201, 42)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(40, 26)
        Me.BtnYarnPrintBar.TabIndex = 145
        Me.BtnYarnPrintBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = True
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(14, 48)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(64, 13)
        Me.lblOutdt.TabIndex = 39
        Me.lblOutdt.Text = "DOUT Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "DOUT No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(91, 20)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(98, 20)
        Me.txtOutNo.TabIndex = 36
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.BtnSave, Me.ToolStripDropDownButton1, Me.BtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStrip1.TabIndex = 160
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 22)
        Me.BtnSave.Text = "Save"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDInDocument, Me.tsbDInTag})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbDInDocument
        '
        Me.tsbDInDocument.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLDDocumentToolStripMenuItem, Me.DOUTDocumentToolStripMenuItem})
        Me.tsbDInDocument.Name = "tsbDInDocument"
        Me.tsbDInDocument.Size = New System.Drawing.Size(130, 22)
        Me.tsbDInDocument.Text = "Document"
        '
        'PLDDocumentToolStripMenuItem
        '
        Me.PLDDocumentToolStripMenuItem.Name = "PLDDocumentToolStripMenuItem"
        Me.PLDDocumentToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PLDDocumentToolStripMenuItem.Text = "PLD Document"
        '
        'DOUTDocumentToolStripMenuItem
        '
        Me.DOUTDocumentToolStripMenuItem.Name = "DOUTDocumentToolStripMenuItem"
        Me.DOUTDocumentToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DOUTDocumentToolStripMenuItem.Text = "D-OUT Document"
        '
        'tsbDInTag
        '
        Me.tsbDInTag.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnDINTagStandard, Me.tsmnDINTagSTG, Me.tsmnTagChantasia, Me.tsmnTagHanesbrandsVietnam})
        Me.tsbDInTag.Name = "tsbDInTag"
        Me.tsbDInTag.Size = New System.Drawing.Size(130, 22)
        Me.tsbDInTag.Text = "Tag"
        '
        'tsmnDINTagStandard
        '
        Me.tsmnDINTagStandard.Name = "tsmnDINTagStandard"
        Me.tsmnDINTagStandard.Size = New System.Drawing.Size(221, 22)
        Me.tsmnDINTagStandard.Text = "Tag (Standard)"
        '
        'tsmnDINTagSTG
        '
        Me.tsmnDINTagSTG.Name = "tsmnDINTagSTG"
        Me.tsmnDINTagSTG.Size = New System.Drawing.Size(221, 22)
        Me.tsmnDINTagSTG.Text = "Tag (STG)"
        '
        'tsmnTagChantasia
        '
        Me.tsmnTagChantasia.Name = "tsmnTagChantasia"
        Me.tsmnTagChantasia.Size = New System.Drawing.Size(221, 22)
        Me.tsmnTagChantasia.Text = "Tag (Chantasia)"
        '
        'tsmnTagHanesbrandsVietnam
        '
        Me.tsmnTagHanesbrandsVietnam.Name = "tsmnTagHanesbrandsVietnam"
        Me.tsmnTagHanesbrandsVietnam.Size = New System.Drawing.Size(221, 22)
        Me.tsmnTagHanesbrandsVietnam.Text = "Tag (Hanesbrands Vietnam)"
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(45, 22)
        Me.BtnExit.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblDocNo)
        Me.GroupBox2.Controls.Add(Me.txtReqNo)
        Me.GroupBox2.Controls.Add(Me.txtcustomer)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 77)
        Me.GroupBox2.TabIndex = 161
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Request Info"
        '
        'lblDocNo
        '
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(22, 23)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(47, 13)
        Me.lblDocNo.TabIndex = 43
        Me.lblDocNo.Text = "Req No."
        '
        'txtReqNo
        '
        Me.txtReqNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(98, 20)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.ReadOnly = True
        Me.txtReqNo.Size = New System.Drawing.Size(87, 22)
        Me.txtReqNo.TabIndex = 44
        '
        'txtcustomer
        '
        Me.txtcustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcustomer.Location = New System.Drawing.Point(98, 45)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(300, 20)
        Me.txtcustomer.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Customer"
        '
        'LbDoctype
        '
        Me.LbDoctype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(10, 23)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 70
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(113, 20)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(107, 21)
        Me.CboDoc_type.TabIndex = 69
        '
        'CboCartonsNo
        '
        Me.CboCartonsNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboCartonsNo.Enabled = False
        Me.CboCartonsNo.FormattingEnabled = True
        Me.CboCartonsNo.Location = New System.Drawing.Point(113, 45)
        Me.CboCartonsNo.Name = "CboCartonsNo"
        Me.CboCartonsNo.Size = New System.Drawing.Size(107, 21)
        Me.CboCartonsNo.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Carton No. :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CboCartonsNo)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.LbDoctype)
        Me.GroupBox6.Controls.Add(Me.CboDoc_type)
        Me.GroupBox6.Location = New System.Drawing.Point(435, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(233, 77)
        Me.GroupBox6.TabIndex = 162
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Delivery Info"
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
        'frmPackingListDyedRelateRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 496)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkAutoGenCarntonNo)
        Me.Controls.Add(Me.btnPrintChantasiaLabel)
        Me.Controls.Add(Me.btnPrintCartonLabel)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.grdDataCartons)
        Me.Controls.Add(Me.grdDataPackingList)
        Me.Name = "frmPackingListDyedRelateRequest"
        Me.Text = "Packing List Dyed Relate Request"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtTotalYds As TextBox
    Friend WithEvents txtTotalKgs As TextBox
    Friend WithEvents txtTotalMts As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalRolls As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalCBMCarton As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalCBMRoll As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAutoGenCarntonNo As CheckBox
    Friend WithEvents btnPrintChantasiaLabel As Button
    Friend WithEvents btnPrintCartonLabel As Button
    Friend WithEvents btnMoveLeft As Button
    Friend WithEvents btnMoveRight As Button
    Friend WithEvents grdDataCartons As DataGridView
    Friend WithEvents grdDataCartons_cartno As DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_packno As DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_CartRolls As DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_netwt As DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_grswt As DataGridViewTextBoxColumn
    Friend WithEvents CartMts As DataGridViewTextBoxColumn
    Friend WithEvents CartYds As DataGridViewTextBoxColumn
    Friend WithEvents grdData_carton_wide As DataGridViewTextBoxColumn
    Friend WithEvents grdData_carton_long As DataGridViewTextBoxColumn
    Friend WithEvents grdData_carton_high As DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_dimension As DataGridViewTextBoxColumn
    Friend WithEvents grdData_CBMForCarton As DataGridViewTextBoxColumn
    Friend WithEvents grdData_CBMForRoll As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPackNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpPackDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblOutdt As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnSave As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbDInDocument As ToolStripMenuItem
    Friend WithEvents PLDDocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DOUTDocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbDInTag As ToolStripMenuItem
    Friend WithEvents tsmnDINTagStandard As ToolStripMenuItem
    Friend WithEvents tsmnDINTagSTG As ToolStripMenuItem
    Friend WithEvents tsmnTagChantasia As ToolStripMenuItem
    Friend WithEvents tsmnTagHanesbrandsVietnam As ToolStripMenuItem
    Friend WithEvents BtnExit As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDocNo As Label
    Friend WithEvents LbDoctype As Label
    Friend WithEvents txtReqNo As TextBox
    Friend WithEvents CboDoc_type As ComboBox
    Friend WithEvents CboCartonsNo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtcustomer As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnYarnPrintBar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btngout As Button
    Friend WithEvents DtpOutdt As DateTimePicker
    Friend WithEvents mnu As ContextMenuStrip
    Friend WithEvents Cut As ToolStripMenuItem
    Friend WithEvents Copy As ToolStripMenuItem
    Friend WithEvents Paste As ToolStripMenuItem
    Friend WithEvents grdDataPackingList_cartno As DataGridViewTextBoxColumn
    Friend WithEvents batch As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_lot As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_custcolor As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_grade As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_col As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_fwth As DataGridViewTextBoxColumn
    Friend WithEvents id_strolls_d_o As DataGridViewTextBoxColumn
End Class
