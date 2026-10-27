<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPackingListGreige
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPackingListGreige))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.grdData_carton_wide = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_carton_long = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_carton_high = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataCartons_dimension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_CBMForCarton = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdData_CBMForRoll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintPLG = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrintGout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PLGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLGStdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLGPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLGPresslessShowBOIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GOStdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmnShowSentToCust = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagStdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagPressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmnShowSentToCustToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.grdDataPackingList = New System.Windows.Forms.DataGridView()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_gamma_roll_seq_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_greige_do = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.btngout = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optGinNo = New System.Windows.Forms.RadioButton()
        Me.optReqNo = New System.Windows.Forms.RadioButton()
        Me.btnSearchREQG = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.chkAutoGenCarntonNo = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearchPackno = New System.Windows.Forms.Button()
        Me.cbPresslessShowBOI = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCBMRoll = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalCBMCarton = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TagInterSpitzenAGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDocNo
        '
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Location = New System.Drawing.Point(10, 46)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(50, 13)
        Me.lblDocNo.TabIndex = 0
        Me.lblDocNo.Text = "REQ No."
        '
        'txtDocNo
        '
        Me.txtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDocNo.Location = New System.Drawing.Point(73, 44)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(119, 20)
        Me.txtDocNo.TabIndex = 1
        '
        'grdDataCartons
        '
        Me.grdDataCartons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDataCartons.ColumnHeadersHeight = 35
        Me.grdDataCartons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataCartons_cartno, Me.grdDataCartons_packno, Me.grdDataCartons_CartRolls, Me.grdDataCartons_netwt, Me.grdDataCartons_grswt, Me.CartMts, Me.CartYds, Me.grdData_carton_wide, Me.grdData_carton_long, Me.grdData_carton_high, Me.grdDataCartons_dimension, Me.grdData_CBMForCarton, Me.grdData_CBMForRoll})
        Me.grdDataCartons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdDataCartons.Location = New System.Drawing.Point(12, 143)
        Me.grdDataCartons.Name = "grdDataCartons"
        Me.grdDataCartons.Size = New System.Drawing.Size(728, 391)
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
        DataGridViewCellStyle1.Format = "N2"
        Me.grdDataCartons_netwt.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdDataCartons_netwt.HeaderText = "Net wt (Kg.)"
        Me.grdDataCartons_netwt.Name = "grdDataCartons_netwt"
        Me.grdDataCartons_netwt.Width = 60
        '
        'grdDataCartons_grswt
        '
        Me.grdDataCartons_grswt.DataPropertyName = "grswt"
        DataGridViewCellStyle2.Format = "N2"
        Me.grdDataCartons_grswt.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDataCartons_grswt.HeaderText = "Gross wt. (Kg.)"
        Me.grdDataCartons_grswt.Name = "grdDataCartons_grswt"
        Me.grdDataCartons_grswt.Width = 60
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
        Me.grdData_carton_long.HeaderText = "Carton Lenght"
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
        Me.grdDataCartons_dimension.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
        Me.grdData_CBMForCarton.Width = 50
        '
        'grdData_CBMForRoll
        '
        Me.grdData_CBMForRoll.DataPropertyName = "CBMForRoll"
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.grdData_CBMForRoll.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdData_CBMForRoll.HeaderText = "CBM Roll"
        Me.grdData_CBMForRoll.Name = "grdData_CBMForRoll"
        Me.grdData_CBMForRoll.Width = 50
        '
        'txtPackNo
        '
        Me.txtPackNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPackNo.Location = New System.Drawing.Point(59, 22)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.Size = New System.Drawing.Size(117, 20)
        Me.txtPackNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PLG No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNew, Me.BtnSave, Me.BtnPrintPLG, Me.BtnPrintGout, Me.ToolStripDropDownButton1, Me.BtnCancel, Me.BtnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1148, 25)
        Me.ToolStrip1.TabIndex = 7
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(83, 22)
        Me.BtnSave.Text = "Save (PLG)"
        '
        'BtnPrintPLG
        '
        Me.BtnPrintPLG.Image = CType(resources.GetObject("BtnPrintPLG.Image"), System.Drawing.Image)
        Me.BtnPrintPLG.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPLG.Name = "BtnPrintPLG"
        Me.BtnPrintPLG.Size = New System.Drawing.Size(84, 22)
        Me.BtnPrintPLG.Text = "Print (PLG)"
        Me.BtnPrintPLG.Visible = False
        '
        'BtnPrintGout
        '
        Me.BtnPrintGout.Image = CType(resources.GetObject("BtnPrintGout.Image"), System.Drawing.Image)
        Me.BtnPrintGout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintGout.Name = "BtnPrintGout"
        Me.BtnPrintGout.Size = New System.Drawing.Size(80, 22)
        Me.BtnPrintGout.Text = "Print (GO)"
        Me.BtnPrintGout.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLGToolStripMenuItem, Me.tsmnShowSentToCust})
        Me.ToolStripDropDownButton1.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'PLGToolStripMenuItem
        '
        Me.PLGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PLGStdToolStripMenuItem, Me.PLGPToolStripMenuItem, Me.PLGPresslessShowBOIToolStripMenuItem, Me.GOStdToolStripMenuItem})
        Me.PLGToolStripMenuItem.Image = Global.SalesOrderSystem.My.Resources.Resources.Document_16x
        Me.PLGToolStripMenuItem.Name = "PLGToolStripMenuItem"
        Me.PLGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PLGToolStripMenuItem.Text = "Document"
        '
        'PLGStdToolStripMenuItem
        '
        Me.PLGStdToolStripMenuItem.Name = "PLGStdToolStripMenuItem"
        Me.PLGStdToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PLGStdToolStripMenuItem.Text = "PLG Std"
        '
        'PLGPToolStripMenuItem
        '
        Me.PLGPToolStripMenuItem.Name = "PLGPToolStripMenuItem"
        Me.PLGPToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PLGPToolStripMenuItem.Text = "PLG Pressless"
        '
        'PLGPresslessShowBOIToolStripMenuItem
        '
        Me.PLGPresslessShowBOIToolStripMenuItem.Name = "PLGPresslessShowBOIToolStripMenuItem"
        Me.PLGPresslessShowBOIToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PLGPresslessShowBOIToolStripMenuItem.Text = "PLG Pressless Show BOI"
        '
        'GOStdToolStripMenuItem
        '
        Me.GOStdToolStripMenuItem.Name = "GOStdToolStripMenuItem"
        Me.GOStdToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.GOStdToolStripMenuItem.Text = "Greige Out Std"
        '
        'tsmnShowSentToCust
        '
        Me.tsmnShowSentToCust.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TagStdToolStripMenuItem, Me.TagPressToolStripMenuItem, Me.TsmnShowSentToCustToolStripMenuItem, Me.TagInterSpitzenAGToolStripMenuItem})
        Me.tsmnShowSentToCust.Image = Global.SalesOrderSystem.My.Resources.Resources.Tag_16x2
        Me.tsmnShowSentToCust.Name = "tsmnShowSentToCust"
        Me.tsmnShowSentToCust.Size = New System.Drawing.Size(152, 22)
        Me.tsmnShowSentToCust.Text = "Tag"
        '
        'TagStdToolStripMenuItem
        '
        Me.TagStdToolStripMenuItem.Name = "TagStdToolStripMenuItem"
        Me.TagStdToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TagStdToolStripMenuItem.Text = "Tag Std"
        '
        'TagPressToolStripMenuItem
        '
        Me.TagPressToolStripMenuItem.Name = "TagPressToolStripMenuItem"
        Me.TagPressToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TagPressToolStripMenuItem.Text = "Tag Pressless"
        '
        'TsmnShowSentToCustToolStripMenuItem
        '
        Me.TsmnShowSentToCustToolStripMenuItem.Name = "TsmnShowSentToCustToolStripMenuItem"
        Me.TsmnShowSentToCustToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TsmnShowSentToCustToolStripMenuItem.Text = "Tag (Show sent to cust)"
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(63, 22)
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(45, 22)
        Me.BtnExit.Text = "Exit"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripLabel2.Text = "** Don't Show S/O Closed and RG Cancel"
        '
        'grdDataPackingList
        '
        Me.grdDataPackingList.AllowUserToAddRows = False
        Me.grdDataPackingList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataPackingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdDataPackingList.ColumnHeadersHeight = 35
        Me.grdDataPackingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_gamma_roll_seq_no, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.Gwth, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.id_greige_do})
        Me.grdDataPackingList.Location = New System.Drawing.Point(782, 143)
        Me.grdDataPackingList.Name = "grdDataPackingList"
        Me.grdDataPackingList.Size = New System.Drawing.Size(354, 391)
        Me.grdDataPackingList.TabIndex = 8
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.grdDataPackingList_cartno.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdDataPackingList_cartno.Frozen = True
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 77
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_g"
        Me.grdDataPackingList_roll_no_g.Frozen = True
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (G)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.ReadOnly = True
        Me.grdDataPackingList_roll_no_g.Width = 68
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.Frozen = True
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.ReadOnly = True
        Me.grdDataPackingList_roll_no_o.Width = 105
        '
        'grdDataPackingList_gamma_roll_seq_no
        '
        Me.grdDataPackingList_gamma_roll_seq_no.DataPropertyName = "gamma_roll_seq_no"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.grdDataPackingList_gamma_roll_seq_no.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdDataPackingList_gamma_roll_seq_no.Frozen = True
        Me.grdDataPackingList_gamma_roll_seq_no.HeaderText = "Gamma Roll Seq No."
        Me.grdDataPackingList_gamma_roll_seq_no.Name = "grdDataPackingList_gamma_roll_seq_no"
        Me.grdDataPackingList_gamma_roll_seq_no.ReadOnly = True
        Me.grdDataPackingList_gamma_roll_seq_no.Width = 105
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.ReadOnly = True
        Me.grdDataPackingList_grade.Width = 61
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.HeaderText = "Design No."
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        Me.grdDataPackingList_design_no.ReadOnly = True
        Me.grdDataPackingList_design_no.Width = 78
        '
        'Gwth
        '
        Me.Gwth.DataPropertyName = "Gwth"
        Me.Gwth.HeaderText = "Gwth"
        Me.Gwth.Name = "Gwth"
        Me.Gwth.Width = 57
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
        Me.grdDataPackingList_outmt_g.Width = 49
        '
        'grdDataPackingList_outyd_g
        '
        Me.grdDataPackingList_outyd_g.DataPropertyName = "outyd_g"
        Me.grdDataPackingList_outyd_g.HeaderText = "Yds"
        Me.grdDataPackingList_outyd_g.Name = "grdDataPackingList_outyd_g"
        Me.grdDataPackingList_outyd_g.Width = 50
        '
        'id_greige_do
        '
        Me.id_greige_do.DataPropertyName = "id_greige_do"
        Me.id_greige_do.HeaderText = "#ID"
        Me.id_greige_do.Name = "id_greige_do"
        Me.id_greige_do.ReadOnly = True
        Me.id_greige_do.Visible = False
        Me.id_greige_do.Width = 50
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(26, 23)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 16
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKgs.Location = New System.Drawing.Point(192, 23)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 18
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(332, 23)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 19
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(489, 23)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(133, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Rolls"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(298, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kgs"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mts"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(595, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Yds"
        '
        'DtpPackDate
        '
        Me.DtpPackDate.CustomFormat = "dd/MM/yyyy"
        Me.DtpPackDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpPackDate.Location = New System.Drawing.Point(59, 46)
        Me.DtpPackDate.Name = "DtpPackDate"
        Me.DtpPackDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpPackDate.TabIndex = 28
        Me.DtpPackDate.Value = New Date(2016, 1, 4, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Date"
        '
        'CboCartonsNo
        '
        Me.CboCartonsNo.FormattingEnabled = True
        Me.CboCartonsNo.Location = New System.Drawing.Point(340, 73)
        Me.CboCartonsNo.Name = "CboCartonsNo"
        Me.CboCartonsNo.Size = New System.Drawing.Size(121, 21)
        Me.CboCartonsNo.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Carton No."
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
        Me.GroupBox1.Controls.Add(Me.BtnPrintBarcode)
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.btngout)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 109)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greige Out Document"
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(132, 78)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(126, 31)
        Me.BtnPrintBarcode.TabIndex = 136
        Me.BtnPrintBarcode.Text = "Print Roll barcore label"
        Me.BtnPrintBarcode.UseVisualStyleBackColor = False
        Me.BtnPrintBarcode.Visible = False
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Customer"
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(73, 76)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(194, 20)
        Me.txtcustomer.TabIndex = 41
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(124, -5)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(108, 24)
        Me.lblCancelled.TabIndex = 42
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.Visible = False
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(238, 47)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 72
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(340, 43)
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
        Me.GroupBox2.Size = New System.Drawing.Size(476, 101)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source"
        '
        'optGinNo
        '
        Me.optGinNo.AutoSize = True
        Me.optGinNo.Location = New System.Drawing.Point(104, 19)
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
        Me.optReqNo.Location = New System.Drawing.Point(13, 19)
        Me.optReqNo.Name = "optReqNo"
        Me.optReqNo.Size = New System.Drawing.Size(85, 17)
        Me.optReqNo.TabIndex = 73
        Me.optReqNo.TabStop = True
        Me.optReqNo.Text = "Request No."
        Me.optReqNo.UseVisualStyleBackColor = True
        '
        'btnSearchREQG
        '
        Me.btnSearchREQG.Image = CType(resources.GetObject("btnSearchREQG.Image"), System.Drawing.Image)
        Me.btnSearchREQG.Location = New System.Drawing.Point(198, 42)
        Me.btnSearchREQG.Name = "btnSearchREQG"
        Me.btnSearchREQG.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQG.TabIndex = 33
        Me.btnSearchREQG.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(746, 206)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(29, 23)
        Me.btnMoveLeft.TabIndex = 74
        Me.btnMoveLeft.Text = "<.."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(746, 235)
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
        Me.chkAutoGenCarntonNo.Location = New System.Drawing.Point(995, 112)
        Me.chkAutoGenCarntonNo.Name = "chkAutoGenCarntonNo"
        Me.chkAutoGenCarntonNo.Size = New System.Drawing.Size(125, 17)
        Me.chkAutoGenCarntonNo.TabIndex = 138
        Me.chkAutoGenCarntonNo.Text = "Auto Gen Carton No."
        Me.chkAutoGenCarntonNo.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblCancelled)
        Me.GroupBox3.Controls.Add(Me.txtPackNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DtpPackDate)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btnSearchPackno)
        Me.GroupBox3.Location = New System.Drawing.Point(920, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 73)
        Me.GroupBox3.TabIndex = 139
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PLG Document"
        '
        'btnSearchPackno
        '
        Me.btnSearchPackno.Image = CType(resources.GetObject("btnSearchPackno.Image"), System.Drawing.Image)
        Me.btnSearchPackno.Location = New System.Drawing.Point(182, 22)
        Me.btnSearchPackno.Name = "btnSearchPackno"
        Me.btnSearchPackno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchPackno.TabIndex = 32
        Me.btnSearchPackno.UseVisualStyleBackColor = True
        '
        'cbPresslessShowBOI
        '
        Me.cbPresslessShowBOI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPresslessShowBOI.AutoSize = True
        Me.cbPresslessShowBOI.Checked = True
        Me.cbPresslessShowBOI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPresslessShowBOI.Location = New System.Drawing.Point(832, 112)
        Me.cbPresslessShowBOI.Name = "cbPresslessShowBOI"
        Me.cbPresslessShowBOI.Size = New System.Drawing.Size(154, 17)
        Me.cbPresslessShowBOI.TabIndex = 140
        Me.cbPresslessShowBOI.Text = "Show BOI (Case Pressless)"
        Me.cbPresslessShowBOI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "CBM Roll"
        '
        'txtTotalCBMRoll
        '
        Me.txtTotalCBMRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCBMRoll.Location = New System.Drawing.Point(319, 23)
        Me.txtTotalCBMRoll.Name = "txtTotalCBMRoll"
        Me.txtTotalCBMRoll.ReadOnly = True
        Me.txtTotalCBMRoll.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCBMRoll.TabIndex = 143
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "CBM Carton"
        '
        'txtTotalCBMCarton
        '
        Me.txtTotalCBMCarton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCBMCarton.Location = New System.Drawing.Point(116, 23)
        Me.txtTotalCBMCarton.Name = "txtTotalCBMCarton"
        Me.txtTotalCBMCarton.ReadOnly = True
        Me.txtTotalCBMCarton.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCBMCarton.TabIndex = 141
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtTotalCBMCarton)
        Me.GroupBox4.Controls.Add(Me.txtTotalCBMRoll)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 540)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(449, 52)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total CBM"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtTotalYds)
        Me.GroupBox5.Controls.Add(Me.txtTotalRolls)
        Me.GroupBox5.Controls.Add(Me.txtTotalKgs)
        Me.GroupBox5.Controls.Add(Me.txtTotalMts)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(484, 540)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(653, 52)
        Me.GroupBox5.TabIndex = 146
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total"
        '
        'TagInterSpitzenAGToolStripMenuItem
        '
        Me.TagInterSpitzenAGToolStripMenuItem.Name = "TagInterSpitzenAGToolStripMenuItem"
        Me.TagInterSpitzenAGToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.TagInterSpitzenAGToolStripMenuItem.Text = "Tag Inter Spitzen AG "
        '
        'frmPackingListGreige
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 604)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cbPresslessShowBOI)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chkAutoGenCarntonNo)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdDataPackingList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDataCartons)
        Me.Name = "frmPackingListGreige"
        Me.Text = "PackingList Greige & Out"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdDataCartons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDataPackingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents BtnPrintBarcode As System.Windows.Forms.Button
    Friend WithEvents chkAutoGenCarntonNo As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cbPresslessShowBOI As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalCBMRoll As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalCBMCarton As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
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
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PLGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLGStdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLGPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLGPresslessShowBOIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GOStdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmnShowSentToCust As ToolStripMenuItem
    Friend WithEvents TagStdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagPressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grdDataPackingList_cartno As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_gamma_roll_seq_no As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_grade As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As DataGridViewTextBoxColumn
    Friend WithEvents Gwth As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As DataGridViewTextBoxColumn
    Friend WithEvents id_greige_do As DataGridViewTextBoxColumn
    Friend WithEvents TsmnShowSentToCustToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagInterSpitzenAGToolStripMenuItem As ToolStripMenuItem
End Class
