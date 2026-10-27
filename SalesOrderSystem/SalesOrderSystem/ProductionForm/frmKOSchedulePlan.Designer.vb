<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKOSchedulePlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKOSchedulePlan))
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ddlKO = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintKO = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKONo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpKODate = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpModifyDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.daily_capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.df_batch_kgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_kgs_std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adjustment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtYarnChangeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMachineNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdLab = New System.Windows.Forms.DataGridView()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.txtGwth = New System.Windows.Forms.TextBox()
        Me.txtSONo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ddlMachineNo = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddlYarnChangeCode = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdjustment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDFBatchKgs = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRollKgsStd = New System.Windows.Forms.TextBox()
        Me.txtKgs = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDailyCapacity = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLossPercent = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grdDue = New System.Windows.Forms.DataGridView()
        Me.due_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_name_en = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_name_th = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdDue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ddlKO, Me.ToolStripSeparator1, Me.btnSave, Me.btnPrint, Me.btnPrintKO, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 4
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "K/O No."
        '
        'ddlKO
        '
        Me.ddlKO.Name = "ddlKO"
        Me.ddlKO.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.btnPrint.Size = New System.Drawing.Size(93, 22)
        Me.btnPrint.Text = "Print History"
        '
        'btnPrintKO
        '
        Me.btnPrintKO.Image = CType(resources.GetObject("btnPrintKO.Image"), System.Drawing.Image)
        Me.btnPrintKO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintKO.Name = "btnPrintKO"
        Me.btnPrintKO.Size = New System.Drawing.Size(71, 22)
        Me.btnPrintKO.Text = "Print KO"
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
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDeliveryDate.Enabled = False
        Me.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(64, 72)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpDeliveryDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "K/O No."
        '
        'txtKONo
        '
        Me.txtKONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtKONo.Location = New System.Drawing.Point(64, 24)
        Me.txtKONo.Name = "txtKONo"
        Me.txtKONo.Size = New System.Drawing.Size(96, 22)
        Me.txtKONo.TabIndex = 0
        Me.txtKONo.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "K/O Date"
        '
        'dtpKODate
        '
        Me.dtpKODate.CustomFormat = "dd/MM/yyyy"
        Me.dtpKODate.Enabled = False
        Me.dtpKODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKODate.Location = New System.Drawing.Point(64, 48)
        Me.dtpKODate.Name = "dtpKODate"
        Me.dtpKODate.Size = New System.Drawing.Size(96, 20)
        Me.dtpKODate.TabIndex = 1
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
        'dtpModifyDate
        '
        Me.dtpModifyDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpModifyDate.Enabled = False
        Me.dtpModifyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModifyDate.Location = New System.Drawing.Point(64, 96)
        Me.dtpModifyDate.Name = "dtpModifyDate"
        Me.dtpModifyDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpModifyDate.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "Modify On"
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(88, 120)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(72, 17)
        Me.chkApproved.TabIndex = 185
        Me.chkApproved.Text = "Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkApproved)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpModifyDate)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.dtpKODate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKONo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDeliveryDate)
        Me.GroupBox1.Location = New System.Drawing.Point(620, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 144)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Knitting Order"
        '
        'remark
        '
        Me.remark.DataPropertyName = "remark"
        Me.remark.HeaderText = "Remark"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        Me.remark.Width = 150
        '
        'daily_capacity
        '
        Me.daily_capacity.DataPropertyName = "daily_capacity"
        Me.daily_capacity.HeaderText = "Daily Capacity"
        Me.daily_capacity.Name = "daily_capacity"
        Me.daily_capacity.ReadOnly = True
        '
        'df_batch_kgs
        '
        Me.df_batch_kgs.DataPropertyName = "df_batch_kgs"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.df_batch_kgs.DefaultCellStyle = DataGridViewCellStyle14
        Me.df_batch_kgs.HeaderText = "D/F Batch Size"
        Me.df_batch_kgs.Name = "df_batch_kgs"
        Me.df_batch_kgs.ReadOnly = True
        Me.df_batch_kgs.Width = 85
        '
        'roll_kgs_std
        '
        Me.roll_kgs_std.DataPropertyName = "roll_kgs_std"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.roll_kgs_std.DefaultCellStyle = DataGridViewCellStyle15
        Me.roll_kgs_std.HeaderText = "Standard Roll Kgs."
        Me.roll_kgs_std.Name = "roll_kgs_std"
        Me.roll_kgs_std.ReadOnly = True
        Me.roll_kgs_std.Width = 85
        '
        'adjustment
        '
        Me.adjustment.DataPropertyName = "adjustment"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.adjustment.DefaultCellStyle = DataGridViewCellStyle16
        Me.adjustment.HeaderText = "Setup Days"
        Me.adjustment.Name = "adjustment"
        Me.adjustment.ReadOnly = True
        Me.adjustment.Width = 50
        '
        'txtEndDate
        '
        Me.txtEndDate.DataPropertyName = "end_date"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtEndDate.DefaultCellStyle = DataGridViewCellStyle17
        Me.txtEndDate.HeaderText = "End Date"
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Width = 90
        '
        'txtStartDate
        '
        Me.txtStartDate.DataPropertyName = "start_date"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtStartDate.DefaultCellStyle = DataGridViewCellStyle18
        Me.txtStartDate.HeaderText = "Start Date"
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Width = 90
        '
        'txtQty
        '
        Me.txtQty.DataPropertyName = "kgs"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.txtQty.DefaultCellStyle = DataGridViewCellStyle19
        Me.txtQty.HeaderText = "Qty."
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Width = 75
        '
        'txtYarnChangeCode
        '
        Me.txtYarnChangeCode.DataPropertyName = "ynchgcd"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtYarnChangeCode.DefaultCellStyle = DataGridViewCellStyle20
        Me.txtYarnChangeCode.HeaderText = "Yarn Change"
        Me.txtYarnChangeCode.Name = "txtYarnChangeCode"
        Me.txtYarnChangeCode.ReadOnly = True
        Me.txtYarnChangeCode.Width = 75
        '
        'txtMachineNo
        '
        Me.txtMachineNo.DataPropertyName = "mcno"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtMachineNo.DefaultCellStyle = DataGridViewCellStyle21
        Me.txtMachineNo.HeaderText = "Machine No."
        Me.txtMachineNo.Name = "txtMachineNo"
        Me.txtMachineNo.ReadOnly = True
        '
        'txtCreateDate
        '
        Me.txtCreateDate.DataPropertyName = "create_date"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.txtCreateDate.DefaultCellStyle = DataGridViewCellStyle22
        Me.txtCreateDate.HeaderText = "Modify Date"
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.ReadOnly = True
        Me.txtCreateDate.Width = 90
        '
        'txtID
        '
        Me.txtID.DataPropertyName = "id"
        Me.txtID.HeaderText = "ID"
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Visible = False
        '
        'grdLab
        '
        Me.grdLab.AllowUserToAddRows = False
        Me.grdLab.AllowUserToDeleteRows = False
        Me.grdLab.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.grdLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtID, Me.txtCreateDate, Me.txtMachineNo, Me.txtYarnChangeCode, Me.txtQty, Me.txtStartDate, Me.txtEndDate, Me.adjustment, Me.roll_kgs_std, Me.df_batch_kgs, Me.daily_capacity, Me.remark})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdLab.DefaultCellStyle = DataGridViewCellStyle24
        Me.grdLab.Location = New System.Drawing.Point(4, 186)
        Me.grdLab.Name = "grdLab"
        Me.grdLab.ReadOnly = True
        Me.grdLab.RowHeadersWidth = 30
        Me.grdLab.Size = New System.Drawing.Size(792, 296)
        Me.grdLab.TabIndex = 5
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(60, 162)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(736, 20)
        Me.txtRemark.TabIndex = 1
        Me.txtRemark.Tag = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 162)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 204
        Me.Label16.Text = "Remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Gwth"
        Me.Label4.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 181
        Me.Label19.Text = "Design No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "S/O No."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(72, 48)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.ReadOnly = True
        Me.txtDesignNo.Size = New System.Drawing.Size(144, 20)
        Me.txtDesignNo.TabIndex = 1
        Me.txtDesignNo.Tag = ""
        '
        'txtGwth
        '
        Me.txtGwth.Location = New System.Drawing.Point(72, 72)
        Me.txtGwth.Name = "txtGwth"
        Me.txtGwth.ReadOnly = True
        Me.txtGwth.Size = New System.Drawing.Size(144, 20)
        Me.txtGwth.TabIndex = 2
        Me.txtGwth.Tag = ""
        Me.txtGwth.Visible = False
        '
        'txtSONo
        '
        Me.txtSONo.Location = New System.Drawing.Point(72, 24)
        Me.txtSONo.Name = "txtSONo"
        Me.txtSONo.Size = New System.Drawing.Size(144, 20)
        Me.txtSONo.TabIndex = 0
        Me.txtSONo.Tag = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSONo)
        Me.GroupBox5.Controls.Add(Me.txtGwth)
        Me.GroupBox5.Controls.Add(Me.txtDesignNo)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(224, 104)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sales Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "Start Date"
        '
        'ddlMachineNo
        '
        Me.ddlMachineNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlMachineNo.FormattingEnabled = True
        Me.ddlMachineNo.Location = New System.Drawing.Point(88, 24)
        Me.ddlMachineNo.Name = "ddlMachineNo"
        Me.ddlMachineNo.Size = New System.Drawing.Size(96, 21)
        Me.ddlMachineNo.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 13)
        Me.Label27.TabIndex = 187
        Me.Label27.Text = "Machine No."
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpStartDate.TabIndex = 2
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(88, 72)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 20)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 190
        Me.Label5.Text = "Yarn Change No."
        '
        'ddlYarnChangeCode
        '
        Me.ddlYarnChangeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlYarnChangeCode.FormattingEnabled = True
        Me.ddlYarnChangeCode.Location = New System.Drawing.Point(296, 24)
        Me.ddlYarnChangeCode.Name = "ddlYarnChangeCode"
        Me.ddlYarnChangeCode.Size = New System.Drawing.Size(64, 21)
        Me.ddlYarnChangeCode.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 212
        Me.Label8.Text = "K/I Kgs."
        '
        'txtAdjustment
        '
        Me.txtAdjustment.Location = New System.Drawing.Point(312, 72)
        Me.txtAdjustment.Name = "txtAdjustment"
        Me.txtAdjustment.Size = New System.Drawing.Size(48, 20)
        Me.txtAdjustment.TabIndex = 5
        Me.txtAdjustment.Tag = ""
        Me.txtAdjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(248, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 214
        Me.Label10.Text = "Setup Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "Std. Roll Kgs."
        '
        'txtDFBatchKgs
        '
        Me.txtDFBatchKgs.Location = New System.Drawing.Point(296, 96)
        Me.txtDFBatchKgs.Name = "txtDFBatchKgs"
        Me.txtDFBatchKgs.Size = New System.Drawing.Size(64, 20)
        Me.txtDFBatchKgs.TabIndex = 7
        Me.txtDFBatchKgs.Tag = ""
        Me.txtDFBatchKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 218
        Me.Label12.Text = "D/F Batch Size"
        '
        'txtRollKgsStd
        '
        Me.txtRollKgsStd.Location = New System.Drawing.Point(88, 96)
        Me.txtRollKgsStd.Name = "txtRollKgsStd"
        Me.txtRollKgsStd.Size = New System.Drawing.Size(64, 20)
        Me.txtRollKgsStd.TabIndex = 6
        Me.txtRollKgsStd.Tag = ""
        Me.txtRollKgsStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgs
        '
        Me.txtKgs.Location = New System.Drawing.Point(296, 48)
        Me.txtKgs.Name = "txtKgs"
        Me.txtKgs.Size = New System.Drawing.Size(64, 20)
        Me.txtKgs.TabIndex = 4
        Me.txtKgs.Tag = ""
        Me.txtKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 220
        Me.Label13.Text = "Daily Capacity"
        '
        'txtDailyCapacity
        '
        Me.txtDailyCapacity.Location = New System.Drawing.Point(88, 120)
        Me.txtDailyCapacity.Name = "txtDailyCapacity"
        Me.txtDailyCapacity.Size = New System.Drawing.Size(64, 20)
        Me.txtDailyCapacity.TabIndex = 8
        Me.txtDailyCapacity.Tag = ""
        Me.txtDailyCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(216, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 222
        Me.Label14.Text = "Loss Percent"
        '
        'txtLossPercent
        '
        Me.txtLossPercent.Location = New System.Drawing.Point(296, 120)
        Me.txtLossPercent.Name = "txtLossPercent"
        Me.txtLossPercent.Size = New System.Drawing.Size(64, 20)
        Me.txtLossPercent.TabIndex = 221
        Me.txtLossPercent.Tag = ""
        Me.txtLossPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLossPercent)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtDailyCapacity)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtKgs)
        Me.GroupBox2.Controls.Add(Me.txtRollKgsStd)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDFBatchKgs)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtAdjustment)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ddlYarnChangeCode)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpEndDate)
        Me.GroupBox2.Controls.Add(Me.dtpStartDate)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.ddlMachineNo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 144)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule Plan"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 512)
        Me.TabControl1.TabIndex = 205
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.grdLab)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtRemark)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 486)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "K/O Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdDue)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 486)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "D/F Due"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grdDue
        '
        Me.grdDue.AllowUserToDeleteRows = False
        Me.grdDue.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.grdDue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.due_id, Me.due_name_en, Me.due_name_th, Me.due_date, Me.due_kg, Me.due_color, Me.due_custcolor, Me.due_remark, Me.due_active})
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDue.DefaultCellStyle = DataGridViewCellStyle26
        Me.grdDue.Location = New System.Drawing.Point(8, 8)
        Me.grdDue.Name = "grdDue"
        Me.grdDue.RowHeadersWidth = 30
        Me.grdDue.Size = New System.Drawing.Size(784, 472)
        Me.grdDue.TabIndex = 6
        '
        'due_id
        '
        Me.due_id.DataPropertyName = "id"
        Me.due_id.HeaderText = "ID"
        Me.due_id.Name = "due_id"
        Me.due_id.Visible = False
        '
        'due_name_en
        '
        Me.due_name_en.DataPropertyName = "name_en"
        Me.due_name_en.HeaderText = "K/O Due No."
        Me.due_name_en.Name = "due_name_en"
        '
        'due_name_th
        '
        Me.due_name_th.DataPropertyName = "name_th"
        Me.due_name_th.HeaderText = "D/F No."
        Me.due_name_th.Name = "due_name_th"
        '
        'due_date
        '
        Me.due_date.DataPropertyName = "due_date"
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.Name = "due_date"
        '
        'due_kg
        '
        Me.due_kg.DataPropertyName = "kg"
        Me.due_kg.HeaderText = "Kgs."
        Me.due_kg.Name = "due_kg"
        '
        'due_color
        '
        Me.due_color.DataPropertyName = "color"
        Me.due_color.HeaderText = "Color"
        Me.due_color.Name = "due_color"
        '
        'due_custcolor
        '
        Me.due_custcolor.DataPropertyName = "custcolor"
        Me.due_custcolor.HeaderText = "Customer Color"
        Me.due_custcolor.Name = "due_custcolor"
        '
        'due_remark
        '
        Me.due_remark.DataPropertyName = "remark"
        Me.due_remark.HeaderText = "Remark"
        Me.due_remark.Name = "due_remark"
        Me.due_remark.Width = 300
        '
        'due_active
        '
        Me.due_active.DataPropertyName = "active"
        Me.due_active.HeaderText = "Active"
        Me.due_active.Name = "due_active"
        Me.due_active.ReadOnly = True
        Me.due_active.Visible = False
        '
        'frmKOSchedulePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 553)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKOSchedulePlan"
        Me.Text = "K/O Schedule Plan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grdDue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ddlKO As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintKO As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKONo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpKODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpModifyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkApproved As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents daily_capacity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents df_batch_kgs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_kgs_std As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adjustment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtEndDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtStartDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtYarnChangeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMachineNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdLab As System.Windows.Forms.DataGridView
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents txtGwth As System.Windows.Forms.TextBox
    Friend WithEvents txtSONo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ddlMachineNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ddlYarnChangeCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDFBatchKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRollKgsStd As System.Windows.Forms.TextBox
    Friend WithEvents txtKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDailyCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLossPercent As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdDue As System.Windows.Forms.DataGridView
    Friend WithEvents due_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_name_en As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_name_th As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_active As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
