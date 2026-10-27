<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackingListGreige
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackingListGreige))
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintPLG = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintGout = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdDataPackingList = New System.Windows.Forms.DataGridView()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_greige_do = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpPackDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCartonsNo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearchPackno = New System.Windows.Forms.Button()
        Me.btnSearchREQG = New System.Windows.Forms.Button()
        Me.btngout = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optGinNo = New System.Windows.Forms.RadioButton()
        Me.optReqNo = New System.Windows.Forms.RadioButton()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.chkAutoGenCarntonNo = New System.Windows.Forms.CheckBox()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDocNo
        '
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(10, 69)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(50, 13)
        Me.lblDocNo.TabIndex = 0
        Me.lblDocNo.Text = "REQ No."
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(73, 67)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(119, 20)
        Me.txtDocNo.TabIndex = 1
        '
        'grdDataCartons
        '
        Me.grdDataCartons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDataCartons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataCartons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataCartons_cartno, Me.grdDataCartons_packno, Me.grdDataCartons_CartRolls, Me.grdDataCartons_netwt, Me.grdDataCartons_grswt, Me.CartMts, Me.CartYds, Me.grdDataCartons_dimension})
        Me.grdDataCartons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdDataCartons.Location = New System.Drawing.Point(12, 182)
        Me.grdDataCartons.Name = "grdDataCartons"
        Me.grdDataCartons.Size = New System.Drawing.Size(501, 360)
        Me.grdDataCartons.TabIndex = 3
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
        DataGridViewCellStyle17.Format = "N2"
        Me.grdDataCartons_netwt.DefaultCellStyle = DataGridViewCellStyle17
        Me.grdDataCartons_netwt.HeaderText = "Net wt (Kg.)"
        Me.grdDataCartons_netwt.Name = "grdDataCartons_netwt"
        Me.grdDataCartons_netwt.Width = 60
        '
        'grdDataCartons_grswt
        '
        Me.grdDataCartons_grswt.DataPropertyName = "grswt"
        DataGridViewCellStyle18.Format = "N2"
        Me.grdDataCartons_grswt.DefaultCellStyle = DataGridViewCellStyle18
        Me.grdDataCartons_grswt.HeaderText = "Gross wt. (Kg.)"
        Me.grdDataCartons_grswt.Name = "grdDataCartons_grswt"
        Me.grdDataCartons_grswt.Width = 60
        '
        'CartMts
        '
        DataGridViewCellStyle19.Format = "N2"
        Me.CartMts.DefaultCellStyle = DataGridViewCellStyle19
        Me.CartMts.HeaderText = "(Mts.)"
        Me.CartMts.Name = "CartMts"
        Me.CartMts.Width = 60
        '
        'CartYds
        '
        DataGridViewCellStyle20.Format = "N2"
        Me.CartYds.DefaultCellStyle = DataGridViewCellStyle20
        Me.CartYds.HeaderText = "(Yds.)"
        Me.CartYds.Name = "CartYds"
        Me.CartYds.Width = 60
        '
        'grdDataCartons_dimension
        '
        Me.grdDataCartons_dimension.DataPropertyName = "dimension"
        Me.grdDataCartons_dimension.HeaderText = "Dimension"
        Me.grdDataCartons_dimension.Name = "grdDataCartons_dimension"
        Me.grdDataCartons_dimension.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDataCartons_dimension.Width = 160
        '
        'txtPackNo
        '
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(834, 47)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.Size = New System.Drawing.Size(117, 20)
        Me.txtPackNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(762, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Packing No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNew, Me.BtnSave, Me.BtnPrintPLG, Me.BtnPrintGout, Me.BtnCancel, Me.BtnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1009, 25)
        Me.ToolStrip1.TabIndex = 7
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
        'BtnPrintPLG
        '
        Me.BtnPrintPLG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintPLG.Image = CType(resources.GetObject("BtnPrintPLG.Image"), System.Drawing.Image)
        Me.BtnPrintPLG.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPLG.Name = "BtnPrintPLG"
        Me.BtnPrintPLG.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintPLG.Text = "Print (Packing List Greige)"
        '
        'BtnPrintGout
        '
        Me.BtnPrintGout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrintGout.Image = CType(resources.GetObject("BtnPrintGout.Image"), System.Drawing.Image)
        Me.BtnPrintGout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintGout.Name = "BtnPrintGout"
        Me.BtnPrintGout.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrintGout.Text = "Print (Greige Out)"
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
        'grdDataPackingList
        '
        Me.grdDataPackingList.AllowUserToAddRows = False
        Me.grdDataPackingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataPackingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.Gwth, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.id_greige_do})
        Me.grdDataPackingList.Location = New System.Drawing.Point(554, 182)
        Me.grdDataPackingList.Name = "grdDataPackingList"
        Me.grdDataPackingList.Size = New System.Drawing.Size(430, 360)
        Me.grdDataPackingList.TabIndex = 8
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        Me.grdDataPackingList_cartno.Frozen = True
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 40
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_g"
        Me.grdDataPackingList_roll_no_g.Frozen = True
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (G)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.Width = 90
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.Frozen = True
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.Width = 110
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.Frozen = True
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.Width = 40
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.Frozen = True
        Me.grdDataPackingList_design_no.HeaderText = "design_no"
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        '
        'Gwth
        '
        Me.Gwth.DataPropertyName = "Gwth"
        Me.Gwth.Frozen = True
        Me.Gwth.HeaderText = "Gwth"
        Me.Gwth.Name = "Gwth"
        Me.Gwth.Width = 40
        '
        'grdDataPackingList_outkg_g
        '
        Me.grdDataPackingList_outkg_g.DataPropertyName = "outkg_g"
        Me.grdDataPackingList_outkg_g.Frozen = True
        Me.grdDataPackingList_outkg_g.HeaderText = "Kgs"
        Me.grdDataPackingList_outkg_g.Name = "grdDataPackingList_outkg_g"
        Me.grdDataPackingList_outkg_g.Width = 80
        '
        'grdDataPackingList_outmt_g
        '
        Me.grdDataPackingList_outmt_g.DataPropertyName = "outmt_g"
        Me.grdDataPackingList_outmt_g.Frozen = True
        Me.grdDataPackingList_outmt_g.HeaderText = "Mts"
        Me.grdDataPackingList_outmt_g.Name = "grdDataPackingList_outmt_g"
        Me.grdDataPackingList_outmt_g.Width = 80
        '
        'grdDataPackingList_outyd_g
        '
        Me.grdDataPackingList_outyd_g.DataPropertyName = "outyd_g"
        Me.grdDataPackingList_outyd_g.Frozen = True
        Me.grdDataPackingList_outyd_g.HeaderText = "Yds"
        Me.grdDataPackingList_outyd_g.Name = "grdDataPackingList_outyd_g"
        Me.grdDataPackingList_outyd_g.Width = 80
        '
        'id_greige_do
        '
        Me.id_greige_do.DataPropertyName = "id_greige_do"
        Me.id_greige_do.HeaderText = "#"
        Me.id_greige_do.Name = "id_greige_do"
        Me.id_greige_do.Visible = False
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(45, 559)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 562)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total"
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(188, 559)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 18
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(325, 559)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 19
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(462, 558)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 561)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Rolls"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 561)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kgs"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mts"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(568, 562)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Yds"
        '
        'DtpPackDate
        '
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(834, 71)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpPackDate.TabIndex = 28
        Me.DtpPackDate.Value = New Date(2016, 1, 4, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(798, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Date"
        '
        'CboCartonsNo
        '
        Me.CboCartonsNo.FormattingEnabled = True
        Me.CboCartonsNo.Location = New System.Drawing.Point(340, 96)
        Me.CboCartonsNo.Name = "CboCartonsNo"
        Me.CboCartonsNo.Size = New System.Drawing.Size(121, 21)
        Me.CboCartonsNo.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Carton No."
        '
        'btnSearchPackno
        '
        Me.btnSearchPackno.Image = CType(resources.GetObject("btnSearchPackno.Image"), System.Drawing.Image)
        Me.btnSearchPackno.Location = New System.Drawing.Point(957, 47)
        Me.btnSearchPackno.Name = "btnSearchPackno"
        Me.btnSearchPackno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchPackno.TabIndex = 32
        Me.btnSearchPackno.UseVisualStyleBackColor = True
        '
        'btnSearchREQG
        '
        Me.btnSearchREQG.Image = CType(resources.GetObject("btnSearchREQG.Image"), System.Drawing.Image)
        Me.btnSearchREQG.Location = New System.Drawing.Point(198, 65)
        Me.btnSearchREQG.Name = "btnSearchREQG"
        Me.btnSearchREQG.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQG.TabIndex = 33
        Me.btnSearchREQG.UseVisualStyleBackColor = True
        '
        'btngout
        '
        Me.btngout.Enabled = False
        Me.btngout.Image = CType(resources.GetObject("btngout.Image"), System.Drawing.Image)
        Me.btngout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngout.Location = New System.Drawing.Point(201, 24)
        Me.btngout.Name = "btngout"
        Me.btngout.Size = New System.Drawing.Size(57, 49)
        Me.btngout.TabIndex = 34
        Me.btngout.Text = "GOUT"
        Me.btngout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngout.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "GOUT No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(78, 23)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(117, 20)
        Me.txtOutNo.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnYarnPrintBar)
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.btngout)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 138)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(165, 85)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(93, 43)
        Me.BtnYarnPrintBar.TabIndex = 136
        Me.BtnYarnPrintBar.Text = "Print bar label"
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = False
        Me.BtnYarnPrintBar.Visible = False
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(4, 56)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(64, 13)
        Me.lblOutdt.TabIndex = 39
        Me.lblOutdt.Text = "GOUT Date"
        '
        'DtpOutdt
        '
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(78, 53)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.Size = New System.Drawing.Size(117, 20)
        Me.DtpOutdt.TabIndex = 38
        Me.DtpOutdt.Value = New Date(2016, 1, 4, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Customer"
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(73, 99)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(194, 20)
        Me.txtcustomer.TabIndex = 41
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(765, 82)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(192, 24)
        Me.lblCancelled.TabIndex = 42
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.Visible = False
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(238, 70)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 72
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(340, 66)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(121, 21)
        Me.CboDoc_type.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optGinNo)
        Me.GroupBox2.Controls.Add(Me.optReqNo)
        Me.GroupBox2.Controls.Add(Me.lblDocNo)
        Me.GroupBox2.Controls.Add(Me.LbDoctype)
        Me.GroupBox2.Controls.Add(Me.txtDocNo)
        Me.GroupBox2.Controls.Add(Me.CboDoc_type)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnSearchREQG)
        Me.GroupBox2.Controls.Add(Me.CboCartonsNo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtcustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 137)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        '
        'optGinNo
        '
        Me.optGinNo.AutoSize = True
        Me.optGinNo.Location = New System.Drawing.Point(143, 28)
        Me.optGinNo.Name = "optGinNo"
        Me.optGinNo.Size = New System.Drawing.Size(64, 17)
        Me.optGinNo.TabIndex = 74
        Me.optGinNo.Text = "GIN No."
        Me.optGinNo.UseVisualStyleBackColor = True
        '
        'optReqNo
        '
        Me.optReqNo.AutoSize = True
        Me.optReqNo.Checked = True
        Me.optReqNo.Location = New System.Drawing.Point(13, 28)
        Me.optReqNo.Name = "optReqNo"
        Me.optReqNo.Size = New System.Drawing.Size(85, 17)
        Me.optReqNo.TabIndex = 73
        Me.optReqNo.TabStop = True
        Me.optReqNo.Text = "Request No."
        Me.optReqNo.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMoveLeft.Location = New System.Drawing.Point(519, 182)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLeft.TabIndex = 74
        Me.btnMoveLeft.Text = "<.."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMoveRight.Location = New System.Drawing.Point(520, 206)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(28, 23)
        Me.btnMoveRight.TabIndex = 75
        Me.btnMoveRight.Text = "..>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'chkAutoGenCarntonNo
        '
        Me.chkAutoGenCarntonNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoGenCarntonNo.AutoSize = True
        Me.chkAutoGenCarntonNo.Checked = True
        Me.chkAutoGenCarntonNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoGenCarntonNo.Location = New System.Drawing.Point(859, 159)
        Me.chkAutoGenCarntonNo.Name = "chkAutoGenCarntonNo"
        Me.chkAutoGenCarntonNo.Size = New System.Drawing.Size(125, 17)
        Me.chkAutoGenCarntonNo.TabIndex = 138
        Me.chkAutoGenCarntonNo.Text = "Auto Gen Carton No."
        Me.chkAutoGenCarntonNo.UseVisualStyleBackColor = True
        Me.chkAutoGenCarntonNo.Visible = False
        '
        'frmPackingListGreige
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 590)
        Me.Controls.Add(Me.chkAutoGenCarntonNo)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearchPackno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpPackDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.grdDataPackingList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPackNo)
        Me.Controls.Add(Me.grdDataCartons)
        Me.Name = "frmPackingListGreige"
        Me.Text = "PackingList Greige & Out"
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDocNo As System.Windows.Forms.Label
    Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents grdDataCartons As System.Windows.Forms.DataGridView
    Friend WithEvents txtPackNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintPLG As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdDataPackingList As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpPackDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboCartonsNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearchPackno As System.Windows.Forms.Button
    Friend WithEvents btnSearchREQG As System.Windows.Forms.Button
    Friend WithEvents btngout As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutdt As System.Windows.Forms.Label
    Friend WithEvents DtpOutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents CboDoc_type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintGout As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMoveLeft As System.Windows.Forms.Button
    Friend WithEvents btnMoveRight As System.Windows.Forms.Button
    Friend WithEvents optGinNo As System.Windows.Forms.RadioButton
    Friend WithEvents optReqNo As System.Windows.Forms.RadioButton
    Friend WithEvents grdDataCartons_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_packno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_CartRolls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_netwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_grswt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartYds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataCartons_dimension As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_greige_do As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnYarnPrintBar As System.Windows.Forms.Button
    Friend WithEvents chkAutoGenCarntonNo As System.Windows.Forms.CheckBox
End Class
