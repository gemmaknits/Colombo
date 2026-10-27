<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLab))
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.cboDyingMethod = New System.Windows.Forms.ComboBox()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboIssueBy = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.dtpLabDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLabNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdLab = New System.Windows.Forms.DataGridView()
        Me.id_labdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.onet = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.twot = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.threet = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nyon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rayon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poly = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.net = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.yarn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.plies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ltime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApvSheet = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnClose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboLabNo = New System.Windows.Forms.ToolStripComboBox()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTolerance = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboGwth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPrimaryLightSource = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtStandardLayer = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSampleLayer = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDyingMethod = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAttention = New System.Windows.Forms.TextBox()
        Me.optSample = New System.Windows.Forms.RadioButton()
        Me.optApprove = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkPhenolicYellowing = New System.Windows.Forms.CheckBox()
        Me.chkNoAZO = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboSecondaryLightSource = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(64, 72)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpDeliveryDate.TabIndex = 183
        '
        'cboDyingMethod
        '
        Me.cboDyingMethod.FormattingEnabled = True
        Me.cboDyingMethod.Location = New System.Drawing.Point(88, 64)
        Me.cboDyingMethod.Name = "cboDyingMethod"
        Me.cboDyingMethod.Size = New System.Drawing.Size(144, 21)
        Me.cboDyingMethod.TabIndex = 182
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(72, 16)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(144, 21)
        Me.cboDesignNo.TabIndex = 180
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 181
        Me.Label19.Text = "Design No."
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.FormattingEnabled = True
        Me.cboDyedHouse.Location = New System.Drawing.Point(88, 16)
        Me.cboDyedHouse.Name = "cboDyedHouse"
        Me.cboDyedHouse.Size = New System.Drawing.Size(144, 21)
        Me.cboDyedHouse.TabIndex = 178
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpIssueDate)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.cboIssueBy)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lblCancelled)
        Me.GroupBox1.Controls.Add(Me.dtpLabDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLabNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDeliveryDate)
        Me.GroupBox1.Location = New System.Drawing.Point(776, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 152)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Order"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssueDate.Location = New System.Drawing.Point(64, 120)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpIssueDate.TabIndex = 185
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 96)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 13)
        Me.Label27.TabIndex = 187
        Me.Label27.Text = "Issue By"
        '
        'cboIssueBy
        '
        Me.cboIssueBy.FormattingEnabled = True
        Me.cboIssueBy.Location = New System.Drawing.Point(64, 96)
        Me.cboIssueBy.Name = "cboIssueBy"
        Me.cboIssueBy.Size = New System.Drawing.Size(96, 21)
        Me.cboIssueBy.TabIndex = 186
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Issue Date"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Delivery"
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(0, 0)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(168, 24)
        Me.lblCancelled.TabIndex = 30
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCancelled.Visible = False
        '
        'dtpLabDate
        '
        Me.dtpLabDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpLabDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLabDate.Location = New System.Drawing.Point(64, 48)
        Me.dtpLabDate.Name = "dtpLabDate"
        Me.dtpLabDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpLabDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LAB Date"
        '
        'txtLabNo
        '
        Me.txtLabNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLabNo.Location = New System.Drawing.Point(64, 24)
        Me.txtLabNo.Name = "txtLabNo"
        Me.txtLabNo.Size = New System.Drawing.Size(96, 22)
        Me.txtLabNo.TabIndex = 0
        Me.txtLabNo.Tag = ""
        Me.txtLabNo.Text = "SO07060000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LAB No."
        '
        'grdLab
        '
        Me.grdLab.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_labdet, Me.col, Me.onet, Me.twot, Me.threet, Me.nyon, Me.rayon, Me.poly, Me.net, Me.yarn, Me.plies, Me.ltime, Me.remark, Me.btnApvSheet, Me.btnClose})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdLab.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdLab.Location = New System.Drawing.Point(8, 192)
        Me.grdLab.Name = "grdLab"
        Me.grdLab.Size = New System.Drawing.Size(936, 408)
        Me.grdLab.TabIndex = 139
        '
        'id_labdet
        '
        Me.id_labdet.DataPropertyName = "id_labdet"
        Me.id_labdet.HeaderText = "ID LabDet"
        Me.id_labdet.Name = "id_labdet"
        Me.id_labdet.ReadOnly = True
        Me.id_labdet.Visible = False
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col.Width = 75
        '
        'onet
        '
        Me.onet.DataPropertyName = "onet"
        Me.onet.HeaderText = "One Tone"
        Me.onet.Name = "onet"
        Me.onet.Width = 45
        '
        'twot
        '
        Me.twot.DataPropertyName = "twot"
        Me.twot.HeaderText = "Two Tone"
        Me.twot.Name = "twot"
        Me.twot.Width = 45
        '
        'threet
        '
        Me.threet.DataPropertyName = "threet"
        Me.threet.HeaderText = "Three Tone"
        Me.threet.Name = "threet"
        Me.threet.Width = 45
        '
        'nyon
        '
        Me.nyon.DataPropertyName = "nyon"
        Me.nyon.HeaderText = "Color For Nylon"
        Me.nyon.Name = "nyon"
        Me.nyon.Width = 95
        '
        'rayon
        '
        Me.rayon.DataPropertyName = "rayon"
        Me.rayon.HeaderText = "Color For Rayon"
        Me.rayon.Name = "rayon"
        Me.rayon.Width = 95
        '
        'poly
        '
        Me.poly.DataPropertyName = "poly"
        Me.poly.HeaderText = "Color For Polyester"
        Me.poly.Name = "poly"
        Me.poly.Width = 95
        '
        'net
        '
        Me.net.DataPropertyName = "net"
        Me.net.HeaderText = "Swatch Net"
        Me.net.Name = "net"
        Me.net.Width = 55
        '
        'yarn
        '
        Me.yarn.DataPropertyName = "yarn"
        Me.yarn.HeaderText = "Swatch Flower"
        Me.yarn.Name = "yarn"
        Me.yarn.Width = 55
        '
        'plies
        '
        Me.plies.DataPropertyName = "plies"
        Me.plies.HeaderText = "No. Of Plies"
        Me.plies.Name = "plies"
        Me.plies.Width = 50
        '
        'ltime
        '
        Me.ltime.DataPropertyName = "ltime"
        Me.ltime.HeaderText = "Times"
        Me.ltime.Name = "ltime"
        Me.ltime.Width = 45
        '
        'remark
        '
        Me.remark.DataPropertyName = "remark_det"
        Me.remark.HeaderText = "Remark"
        Me.remark.Name = "remark"
        Me.remark.Width = 90
        '
        'btnApvSheet
        '
        Me.btnApvSheet.HeaderText = "Approval Sheet"
        Me.btnApvSheet.Name = "btnApvSheet"
        Me.btnApvSheet.Width = 60
        '
        'btnClose
        '
        Me.btnClose.HeaderText = "Close"
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Text = "Close"
        Me.btnClose.Width = 40
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboLabNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnCopy, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
        Me.ToolStrip1.TabIndex = 137
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "LAB No."
        '
        'cboLabNo
        '
        Me.cboLabNo.Name = "cboLabNo"
        Me.cboLabNo.Size = New System.Drawing.Size(100, 25)
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(23, 22)
        Me.btnCancel.Text = "Cancel Document"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(175, 22)
        Me.ToolStripLabel2.Text = "** 1 Lab has only 1 Design No."
        '
        'txtTolerance
        '
        Me.txtTolerance.Location = New System.Drawing.Point(168, 40)
        Me.txtTolerance.Name = "txtTolerance"
        Me.txtTolerance.Size = New System.Drawing.Size(24, 20)
        Me.txtTolerance.TabIndex = 147
        Me.txtTolerance.Tag = "5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(64, 160)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(408, 20)
        Me.txtRemark.TabIndex = 146
        Me.txtRemark.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Primary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Dying Method"
        '
        'cboGwth
        '
        Me.cboGwth.FormattingEnabled = True
        Me.cboGwth.Location = New System.Drawing.Point(72, 40)
        Me.cboGwth.Name = "cboGwth"
        Me.cboGwth.Size = New System.Drawing.Size(64, 21)
        Me.cboGwth.TabIndex = 143
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Gwth"
        '
        'cboPrimaryLightSource
        '
        Me.cboPrimaryLightSource.FormattingEnabled = True
        Me.cboPrimaryLightSource.Location = New System.Drawing.Point(72, 16)
        Me.cboPrimaryLightSource.Name = "cboPrimaryLightSource"
        Me.cboPrimaryLightSource.Size = New System.Drawing.Size(112, 21)
        Me.cboPrimaryLightSource.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Dyed House"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(144, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 148
        Me.Label14.Text = "+/-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(200, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 186
        Me.Label21.Text = "%"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "Standard Layer"
        '
        'txtStandardLayer
        '
        Me.txtStandardLayer.Location = New System.Drawing.Point(96, 64)
        Me.txtStandardLayer.Name = "txtStandardLayer"
        Me.txtStandardLayer.Size = New System.Drawing.Size(40, 20)
        Me.txtStandardLayer.TabIndex = 187
        Me.txtStandardLayer.Tag = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "Sample Layer"
        '
        'txtSampleLayer
        '
        Me.txtSampleLayer.Location = New System.Drawing.Point(96, 88)
        Me.txtSampleLayer.Name = "txtSampleLayer"
        Me.txtSampleLayer.Size = New System.Drawing.Size(40, 20)
        Me.txtSampleLayer.TabIndex = 189
        Me.txtSampleLayer.Tag = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtSampleLayer)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtStandardLayer)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.cboDesignNo)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtTolerance)
        Me.GroupBox5.Controls.Add(Me.cboGwth)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(224, 120)
        Me.GroupBox5.TabIndex = 191
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Design"
        '
        'txtDyingMethod
        '
        Me.txtDyingMethod.Location = New System.Drawing.Point(88, 88)
        Me.txtDyingMethod.Name = "txtDyingMethod"
        Me.txtDyingMethod.Size = New System.Drawing.Size(144, 20)
        Me.txtDyingMethod.TabIndex = 192
        Me.txtDyingMethod.Tag = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtDyingMethod)
        Me.GroupBox6.Controls.Add(Me.txtAttention)
        Me.GroupBox6.Controls.Add(Me.cboDyingMethod)
        Me.GroupBox6.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(240, 32)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(240, 120)
        Me.GroupBox6.TabIndex = 193
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Dying"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "Method Desc."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 195
        Me.Label24.Text = "Attention To"
        '
        'txtAttention
        '
        Me.txtAttention.Location = New System.Drawing.Point(88, 40)
        Me.txtAttention.Name = "txtAttention"
        Me.txtAttention.Size = New System.Drawing.Size(144, 20)
        Me.txtAttention.TabIndex = 194
        Me.txtAttention.Tag = ""
        '
        'optSample
        '
        Me.optSample.AutoSize = True
        Me.optSample.Location = New System.Drawing.Point(16, 16)
        Me.optSample.Name = "optSample"
        Me.optSample.Size = New System.Drawing.Size(224, 17)
        Me.optSample.TabIndex = 194
        Me.optSample.Text = "Sample (Only see repeat length and width)"
        Me.optSample.UseVisualStyleBackColor = True
        '
        'optApprove
        '
        Me.optApprove.AutoSize = True
        Me.optApprove.Checked = True
        Me.optApprove.Location = New System.Drawing.Point(16, 40)
        Me.optApprove.Name = "optApprove"
        Me.optApprove.Size = New System.Drawing.Size(123, 17)
        Me.optApprove.TabIndex = 195
        Me.optApprove.TabStop = True
        Me.optApprove.Text = "Lab DIP for approval"
        Me.optApprove.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.optSample)
        Me.GroupBox7.Controls.Add(Me.optApprove)
        Me.GroupBox7.Location = New System.Drawing.Point(488, 112)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(280, 72)
        Me.GroupBox7.TabIndex = 196
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Request LAB For"
        '
        'chkPhenolicYellowing
        '
        Me.chkPhenolicYellowing.Location = New System.Drawing.Point(8, 32)
        Me.chkPhenolicYellowing.Name = "chkPhenolicYellowing"
        Me.chkPhenolicYellowing.Size = New System.Drawing.Size(72, 32)
        Me.chkPhenolicYellowing.TabIndex = 197
        Me.chkPhenolicYellowing.Text = "Phenolic Yellowing"
        Me.chkPhenolicYellowing.UseVisualStyleBackColor = True
        '
        'chkNoAZO
        '
        Me.chkNoAZO.AutoSize = True
        Me.chkNoAZO.Location = New System.Drawing.Point(8, 16)
        Me.chkNoAZO.Name = "chkNoAZO"
        Me.chkNoAZO.Size = New System.Drawing.Size(65, 17)
        Me.chkNoAZO.TabIndex = 198
        Me.chkNoAZO.Text = "No AZO"
        Me.chkNoAZO.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 200
        Me.Label25.Text = "Secondary"
        '
        'cboSecondaryLightSource
        '
        Me.cboSecondaryLightSource.FormattingEnabled = True
        Me.cboSecondaryLightSource.Location = New System.Drawing.Point(72, 40)
        Me.cboSecondaryLightSource.Name = "cboSecondaryLightSource"
        Me.cboSecondaryLightSource.Size = New System.Drawing.Size(112, 21)
        Me.cboSecondaryLightSource.TabIndex = 199
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.cboSecondaryLightSource)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.cboPrimaryLightSource)
        Me.GroupBox8.Location = New System.Drawing.Point(488, 32)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(192, 72)
        Me.GroupBox8.TabIndex = 201
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Light Source"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPhenolicYellowing)
        Me.GroupBox2.Controls.Add(Me.chkNoAZO)
        Me.GroupBox2.Location = New System.Drawing.Point(688, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(80, 72)
        Me.GroupBox2.TabIndex = 202
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'frmLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 609)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdLab)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtRemark)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lab"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents dtpDeliveryDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents cboDyingMethod As System.Windows.Forms.ComboBox
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents cboDyedHouse As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents lblCancelled As System.Windows.Forms.Label
	Friend WithEvents dtpLabDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtLabNo As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents grdLab As System.Windows.Forms.DataGridView
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboLabNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents txtTolerance As System.Windows.Forms.TextBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents cboGwth As System.Windows.Forms.ComboBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboPrimaryLightSource As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents txtStandardLayer As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents txtSampleLayer As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents txtDyingMethod As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents txtAttention As System.Windows.Forms.TextBox
	Friend WithEvents optSample As System.Windows.Forms.RadioButton
	Friend WithEvents optApprove As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
	Friend WithEvents chkPhenolicYellowing As System.Windows.Forms.CheckBox
	Friend WithEvents chkNoAZO As System.Windows.Forms.CheckBox
	Friend WithEvents Label25 As System.Windows.Forms.Label
	Friend WithEvents cboSecondaryLightSource As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label27 As System.Windows.Forms.Label
	Friend WithEvents cboIssueBy As System.Windows.Forms.ComboBox
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents id_labdet As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents onet As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents twot As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents threet As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents nyon As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents rayon As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents poly As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents net As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents yarn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents plies As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ltime As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents remark As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents btnApvSheet As System.Windows.Forms.DataGridViewButtonColumn
	Friend WithEvents btnClose As System.Windows.Forms.DataGridViewButtonColumn
	Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
End Class
