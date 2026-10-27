<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesignSpec
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesignSpec))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnNew = New System.Windows.Forms.ToolStripButton
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
		Me.Label1 = New System.Windows.Forms.Label
		Me.cboCustomer = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.btnLoad = New System.Windows.Forms.Button
		Me.Label3 = New System.Windows.Forms.Label
		Me.dtpSpecDate = New System.Windows.Forms.DateTimePicker
		Me.Label4 = New System.Windows.Forms.Label
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.grdMaterial = New System.Windows.Forms.DataGridView
		Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ratio = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Label6 = New System.Windows.Forms.Label
		Me.txtComposition = New System.Windows.Forms.TextBox
		Me.txtDescription = New System.Windows.Forms.TextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.txtRevise = New System.Windows.Forms.TextBox
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.Label54 = New System.Windows.Forms.Label
		Me.txtProcessRoute = New System.Windows.Forms.TextBox
		Me.Label53 = New System.Windows.Forms.Label
		Me.txtSeperationMethod = New System.Windows.Forms.TextBox
		Me.GroupBox8 = New System.Windows.Forms.GroupBox
		Me.txtModWthVal3 = New System.Windows.Forms.TextBox
		Me.txtModWthVal2 = New System.Windows.Forms.TextBox
		Me.txtModWthVal1 = New System.Windows.Forms.TextBox
		Me.Label50 = New System.Windows.Forms.Label
		Me.Label51 = New System.Windows.Forms.Label
		Me.Label52 = New System.Windows.Forms.Label
		Me.txtModWthPerc3 = New System.Windows.Forms.TextBox
		Me.txtModWthPerc2 = New System.Windows.Forms.TextBox
		Me.txtModWthPerc1 = New System.Windows.Forms.TextBox
		Me.txtModLenVal3 = New System.Windows.Forms.TextBox
		Me.txtModLenVal2 = New System.Windows.Forms.TextBox
		Me.txtModLenVal1 = New System.Windows.Forms.TextBox
		Me.Label49 = New System.Windows.Forms.Label
		Me.Label48 = New System.Windows.Forms.Label
		Me.Label47 = New System.Windows.Forms.Label
		Me.Label42 = New System.Windows.Forms.Label
		Me.Label46 = New System.Windows.Forms.Label
		Me.Label43 = New System.Windows.Forms.Label
		Me.txtModLenPerc3 = New System.Windows.Forms.TextBox
		Me.Label44 = New System.Windows.Forms.Label
		Me.txtModLenPerc2 = New System.Windows.Forms.TextBox
		Me.Label45 = New System.Windows.Forms.Label
		Me.txtModLenPerc1 = New System.Windows.Forms.TextBox
		Me.GroupBox7 = New System.Windows.Forms.GroupBox
		Me.txtElongationMachineWth = New System.Windows.Forms.TextBox
		Me.txtElongationHandWth = New System.Windows.Forms.TextBox
		Me.Label41 = New System.Windows.Forms.Label
		Me.Label40 = New System.Windows.Forms.Label
		Me.Label31 = New System.Windows.Forms.Label
		Me.txtElongationMachineLen = New System.Windows.Forms.TextBox
		Me.Label33 = New System.Windows.Forms.Label
		Me.txtElongationHandLen = New System.Windows.Forms.TextBox
		Me.GroupBox6 = New System.Windows.Forms.GroupBox
		Me.txtShrinkageWidthTemp = New System.Windows.Forms.TextBox
		Me.Label38 = New System.Windows.Forms.Label
		Me.Label39 = New System.Windows.Forms.Label
		Me.txtShrinkageWidth = New System.Windows.Forms.TextBox
		Me.txtShrinkageLengthTemp = New System.Windows.Forms.TextBox
		Me.Label37 = New System.Windows.Forms.Label
		Me.Label36 = New System.Windows.Forms.Label
		Me.Label27 = New System.Windows.Forms.Label
		Me.txtBurstStrengthMax = New System.Windows.Forms.TextBox
		Me.Label28 = New System.Windows.Forms.Label
		Me.txtBurstStrengthMin = New System.Windows.Forms.TextBox
		Me.Label29 = New System.Windows.Forms.Label
		Me.Label30 = New System.Windows.Forms.Label
		Me.txtBurstStrengthAvg = New System.Windows.Forms.TextBox
		Me.Label32 = New System.Windows.Forms.Label
		Me.txtGMSPerSqM = New System.Windows.Forms.TextBox
		Me.Label34 = New System.Windows.Forms.Label
		Me.txtGMSPerRunMt = New System.Windows.Forms.TextBox
		Me.Label35 = New System.Windows.Forms.Label
		Me.txtShrinkageLength = New System.Windows.Forms.TextBox
		Me.GroupBox5 = New System.Windows.Forms.GroupBox
		Me.Label25 = New System.Windows.Forms.Label
		Me.txtBursting = New System.Windows.Forms.TextBox
		Me.Label26 = New System.Windows.Forms.Label
		Me.txtWeight = New System.Windows.Forms.TextBox
		Me.Label23 = New System.Windows.Forms.Label
		Me.txtShrinkage = New System.Windows.Forms.TextBox
		Me.Label24 = New System.Windows.Forms.Label
		Me.txtElongation = New System.Windows.Forms.TextBox
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.Label22 = New System.Windows.Forms.Label
		Me.txtColor = New System.Windows.Forms.TextBox
		Me.Label21 = New System.Windows.Forms.Label
		Me.txtLotNo = New System.Windows.Forms.TextBox
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.Label17 = New System.Windows.Forms.Label
		Me.txtRWMax = New System.Windows.Forms.TextBox
		Me.Label18 = New System.Windows.Forms.Label
		Me.txtRWMin = New System.Windows.Forms.TextBox
		Me.Label19 = New System.Windows.Forms.Label
		Me.Label20 = New System.Windows.Forms.Label
		Me.txtRWAvg = New System.Windows.Forms.TextBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.txtRLMax = New System.Windows.Forms.TextBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.txtRLMin = New System.Windows.Forms.TextBox
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.txtRLAvg = New System.Windows.Forms.TextBox
		Me.Label12 = New System.Windows.Forms.Label
		Me.txtUsableWidth = New System.Windows.Forms.TextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.txtBars = New System.Windows.Forms.TextBox
		Me.Label10 = New System.Windows.Forms.Label
		Me.cboMCType = New System.Windows.Forms.ComboBox
		Me.txtGauge = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.cboDesignNo = New System.Windows.Forms.ComboBox
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.grdMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox8.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator1, Me.ToolStripLabel1})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(769, 25)
		Me.ToolStrip1.TabIndex = 18
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
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(294, 22)
		Me.ToolStripLabel1.Text = "* Leave the customer blank to load the original design spec."
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 20
		Me.Label1.Text = "Design No."
		'
		'cboCustomer
		'
		Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(256, 32)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(176, 21)
		Me.cboCustomer.TabIndex = 21
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(200, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(51, 13)
		Me.Label2.TabIndex = 22
		Me.Label2.Text = "Customer"
		'
		'btnLoad
		'
		Me.btnLoad.Location = New System.Drawing.Point(440, 32)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(56, 24)
		Me.btnLoad.TabIndex = 23
		Me.btnLoad.Text = "Load"
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(256, 56)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(0, 13)
		Me.Label3.TabIndex = 24
		'
		'dtpSpecDate
		'
		Me.dtpSpecDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpSpecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpSpecDate.Location = New System.Drawing.Point(568, 32)
		Me.dtpSpecDate.Name = "dtpSpecDate"
		Me.dtpSpecDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpSpecDate.TabIndex = 25
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(504, 32)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(61, 13)
		Me.Label4.TabIndex = 26
		Me.Label4.Text = "Spec. Date"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.grdMaterial)
		Me.GroupBox1.Controls.Add(Me.Label6)
		Me.GroupBox1.Controls.Add(Me.txtComposition)
		Me.GroupBox1.Controls.Add(Me.txtDescription)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(752, 224)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(8, 40)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(106, 13)
		Me.Label8.TabIndex = 33
		Me.Label8.Text = "Material Components"
		'
		'grdMaterial
		'
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.grdMaterial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.grdMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desc, Me.ratio})
		Me.grdMaterial.Location = New System.Drawing.Point(8, 56)
		Me.grdMaterial.Name = "grdMaterial"
		Me.grdMaterial.Size = New System.Drawing.Size(736, 160)
		Me.grdMaterial.TabIndex = 32
		'
		'desc
		'
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.desc.DefaultCellStyle = DataGridViewCellStyle2
		Me.desc.HeaderText = "Description Spec."
		Me.desc.Name = "desc"
		Me.desc.Width = 450
		'
		'ratio
		'
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.ratio.DefaultCellStyle = DataGridViewCellStyle3
		Me.ratio.HeaderText = "Proportion 0 %"
		Me.ratio.Name = "ratio"
		Me.ratio.Width = 225
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(296, 16)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(64, 13)
		Me.Label6.TabIndex = 31
		Me.Label6.Text = "Composition"
		'
		'txtComposition
		'
		Me.txtComposition.Location = New System.Drawing.Point(368, 16)
		Me.txtComposition.Name = "txtComposition"
		Me.txtComposition.Size = New System.Drawing.Size(376, 20)
		Me.txtComposition.TabIndex = 30
		'
		'txtDescription
		'
		Me.txtDescription.Location = New System.Drawing.Point(104, 16)
		Me.txtDescription.Name = "txtDescription"
		Me.txtDescription.Size = New System.Drawing.Size(184, 20)
		Me.txtDescription.TabIndex = 28
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 16)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(60, 13)
		Me.Label5.TabIndex = 29
		Me.Label5.Text = "Description"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(664, 32)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(40, 13)
		Me.Label7.TabIndex = 29
		Me.Label7.Text = "Revise"
		'
		'txtRevise
		'
		Me.txtRevise.Location = New System.Drawing.Point(712, 32)
		Me.txtRevise.Name = "txtRevise"
		Me.txtRevise.Size = New System.Drawing.Size(40, 20)
		Me.txtRevise.TabIndex = 28
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label54)
		Me.GroupBox2.Controls.Add(Me.txtProcessRoute)
		Me.GroupBox2.Controls.Add(Me.Label53)
		Me.GroupBox2.Controls.Add(Me.txtSeperationMethod)
		Me.GroupBox2.Controls.Add(Me.GroupBox8)
		Me.GroupBox2.Controls.Add(Me.GroupBox7)
		Me.GroupBox2.Controls.Add(Me.GroupBox6)
		Me.GroupBox2.Controls.Add(Me.GroupBox5)
		Me.GroupBox2.Controls.Add(Me.GroupBox4)
		Me.GroupBox2.Controls.Add(Me.GroupBox3)
		Me.GroupBox2.Controls.Add(Me.Label11)
		Me.GroupBox2.Controls.Add(Me.txtBars)
		Me.GroupBox2.Controls.Add(Me.Label10)
		Me.GroupBox2.Controls.Add(Me.cboMCType)
		Me.GroupBox2.Controls.Add(Me.txtGauge)
		Me.GroupBox2.Controls.Add(Me.Label9)
		Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(752, 328)
		Me.GroupBox2.TabIndex = 30
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Detailed Fabric Specification"
		'
		'Label54
		'
		Me.Label54.AutoSize = True
		Me.Label54.Location = New System.Drawing.Point(320, 304)
		Me.Label54.Name = "Label54"
		Me.Label54.Size = New System.Drawing.Size(77, 13)
		Me.Label54.TabIndex = 50
		Me.Label54.Text = "Process Route"
		'
		'txtProcessRoute
		'
		Me.txtProcessRoute.Location = New System.Drawing.Point(416, 304)
		Me.txtProcessRoute.Name = "txtProcessRoute"
		Me.txtProcessRoute.Size = New System.Drawing.Size(320, 20)
		Me.txtProcessRoute.TabIndex = 49
		'
		'Label53
		'
		Me.Label53.AutoSize = True
		Me.Label53.Location = New System.Drawing.Point(8, 304)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(97, 13)
		Me.Label53.TabIndex = 48
		Me.Label53.Text = "Seperation Method"
		'
		'txtSeperationMethod
		'
		Me.txtSeperationMethod.Location = New System.Drawing.Point(120, 304)
		Me.txtSeperationMethod.Name = "txtSeperationMethod"
		Me.txtSeperationMethod.Size = New System.Drawing.Size(192, 20)
		Me.txtSeperationMethod.TabIndex = 47
		'
		'GroupBox8
		'
		Me.GroupBox8.Controls.Add(Me.txtModWthVal3)
		Me.GroupBox8.Controls.Add(Me.txtModWthVal2)
		Me.GroupBox8.Controls.Add(Me.txtModWthVal1)
		Me.GroupBox8.Controls.Add(Me.Label50)
		Me.GroupBox8.Controls.Add(Me.Label51)
		Me.GroupBox8.Controls.Add(Me.Label52)
		Me.GroupBox8.Controls.Add(Me.txtModWthPerc3)
		Me.GroupBox8.Controls.Add(Me.txtModWthPerc2)
		Me.GroupBox8.Controls.Add(Me.txtModWthPerc1)
		Me.GroupBox8.Controls.Add(Me.txtModLenVal3)
		Me.GroupBox8.Controls.Add(Me.txtModLenVal2)
		Me.GroupBox8.Controls.Add(Me.txtModLenVal1)
		Me.GroupBox8.Controls.Add(Me.Label49)
		Me.GroupBox8.Controls.Add(Me.Label48)
		Me.GroupBox8.Controls.Add(Me.Label47)
		Me.GroupBox8.Controls.Add(Me.Label42)
		Me.GroupBox8.Controls.Add(Me.Label46)
		Me.GroupBox8.Controls.Add(Me.Label43)
		Me.GroupBox8.Controls.Add(Me.txtModLenPerc3)
		Me.GroupBox8.Controls.Add(Me.Label44)
		Me.GroupBox8.Controls.Add(Me.txtModLenPerc2)
		Me.GroupBox8.Controls.Add(Me.Label45)
		Me.GroupBox8.Controls.Add(Me.txtModLenPerc1)
		Me.GroupBox8.Location = New System.Drawing.Point(464, 176)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Size = New System.Drawing.Size(280, 120)
		Me.GroupBox8.TabIndex = 45
		Me.GroupBox8.TabStop = False
		Me.GroupBox8.Text = "Modulus"
		'
		'txtModWthVal3
		'
		Me.txtModWthVal3.Location = New System.Drawing.Point(232, 96)
		Me.txtModWthVal3.Name = "txtModWthVal3"
		Me.txtModWthVal3.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthVal3.TabIndex = 59
		'
		'txtModWthVal2
		'
		Me.txtModWthVal2.Location = New System.Drawing.Point(232, 72)
		Me.txtModWthVal2.Name = "txtModWthVal2"
		Me.txtModWthVal2.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthVal2.TabIndex = 58
		'
		'txtModWthVal1
		'
		Me.txtModWthVal1.Location = New System.Drawing.Point(232, 48)
		Me.txtModWthVal1.Name = "txtModWthVal1"
		Me.txtModWthVal1.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthVal1.TabIndex = 57
		'
		'Label50
		'
		Me.Label50.AutoSize = True
		Me.Label50.Location = New System.Drawing.Point(216, 96)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(15, 13)
		Me.Label50.TabIndex = 56
		Me.Label50.Text = "%"
		'
		'Label51
		'
		Me.Label51.AutoSize = True
		Me.Label51.Location = New System.Drawing.Point(216, 72)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(15, 13)
		Me.Label51.TabIndex = 55
		Me.Label51.Text = "%"
		'
		'Label52
		'
		Me.Label52.AutoSize = True
		Me.Label52.Location = New System.Drawing.Point(216, 48)
		Me.Label52.Name = "Label52"
		Me.Label52.Size = New System.Drawing.Size(15, 13)
		Me.Label52.TabIndex = 54
		Me.Label52.Text = "%"
		'
		'txtModWthPerc3
		'
		Me.txtModWthPerc3.Location = New System.Drawing.Point(176, 96)
		Me.txtModWthPerc3.Name = "txtModWthPerc3"
		Me.txtModWthPerc3.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthPerc3.TabIndex = 53
		'
		'txtModWthPerc2
		'
		Me.txtModWthPerc2.Location = New System.Drawing.Point(176, 72)
		Me.txtModWthPerc2.Name = "txtModWthPerc2"
		Me.txtModWthPerc2.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthPerc2.TabIndex = 52
		'
		'txtModWthPerc1
		'
		Me.txtModWthPerc1.Location = New System.Drawing.Point(176, 48)
		Me.txtModWthPerc1.Name = "txtModWthPerc1"
		Me.txtModWthPerc1.Size = New System.Drawing.Size(40, 20)
		Me.txtModWthPerc1.TabIndex = 51
		'
		'txtModLenVal3
		'
		Me.txtModLenVal3.Location = New System.Drawing.Point(128, 96)
		Me.txtModLenVal3.Name = "txtModLenVal3"
		Me.txtModLenVal3.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenVal3.TabIndex = 50
		'
		'txtModLenVal2
		'
		Me.txtModLenVal2.Location = New System.Drawing.Point(128, 72)
		Me.txtModLenVal2.Name = "txtModLenVal2"
		Me.txtModLenVal2.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenVal2.TabIndex = 49
		'
		'txtModLenVal1
		'
		Me.txtModLenVal1.Location = New System.Drawing.Point(128, 48)
		Me.txtModLenVal1.Name = "txtModLenVal1"
		Me.txtModLenVal1.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenVal1.TabIndex = 48
		'
		'Label49
		'
		Me.Label49.AutoSize = True
		Me.Label49.Location = New System.Drawing.Point(112, 96)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(15, 13)
		Me.Label49.TabIndex = 47
		Me.Label49.Text = "%"
		'
		'Label48
		'
		Me.Label48.AutoSize = True
		Me.Label48.Location = New System.Drawing.Point(112, 72)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(15, 13)
		Me.Label48.TabIndex = 46
		Me.Label48.Text = "%"
		'
		'Label47
		'
		Me.Label47.AutoSize = True
		Me.Label47.Location = New System.Drawing.Point(112, 48)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(15, 13)
		Me.Label47.TabIndex = 45
		Me.Label47.Text = "%"
		'
		'Label42
		'
		Me.Label42.AutoSize = True
		Me.Label42.Location = New System.Drawing.Point(208, 24)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(35, 13)
		Me.Label42.TabIndex = 44
		Me.Label42.Text = "Width"
		'
		'Label46
		'
		Me.Label46.AutoSize = True
		Me.Label46.Location = New System.Drawing.Point(96, 24)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(40, 13)
		Me.Label46.TabIndex = 43
		Me.Label46.Text = "Length"
		'
		'Label43
		'
		Me.Label43.AutoSize = True
		Me.Label43.Location = New System.Drawing.Point(8, 96)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(56, 13)
		Me.Label43.TabIndex = 42
		Me.Label43.Text = "Tension@"
		'
		'txtModLenPerc3
		'
		Me.txtModLenPerc3.Location = New System.Drawing.Point(72, 96)
		Me.txtModLenPerc3.Name = "txtModLenPerc3"
		Me.txtModLenPerc3.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenPerc3.TabIndex = 41
		'
		'Label44
		'
		Me.Label44.AutoSize = True
		Me.Label44.Location = New System.Drawing.Point(8, 72)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(56, 13)
		Me.Label44.TabIndex = 40
		Me.Label44.Text = "Tension@"
		'
		'txtModLenPerc2
		'
		Me.txtModLenPerc2.Location = New System.Drawing.Point(72, 72)
		Me.txtModLenPerc2.Name = "txtModLenPerc2"
		Me.txtModLenPerc2.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenPerc2.TabIndex = 39
		'
		'Label45
		'
		Me.Label45.AutoSize = True
		Me.Label45.Location = New System.Drawing.Point(8, 48)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(56, 13)
		Me.Label45.TabIndex = 38
		Me.Label45.Text = "Tension@"
		'
		'txtModLenPerc1
		'
		Me.txtModLenPerc1.Location = New System.Drawing.Point(72, 48)
		Me.txtModLenPerc1.Name = "txtModLenPerc1"
		Me.txtModLenPerc1.Size = New System.Drawing.Size(40, 20)
		Me.txtModLenPerc1.TabIndex = 37
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.txtElongationMachineWth)
		Me.GroupBox7.Controls.Add(Me.txtElongationHandWth)
		Me.GroupBox7.Controls.Add(Me.Label41)
		Me.GroupBox7.Controls.Add(Me.Label40)
		Me.GroupBox7.Controls.Add(Me.Label31)
		Me.GroupBox7.Controls.Add(Me.txtElongationMachineLen)
		Me.GroupBox7.Controls.Add(Me.Label33)
		Me.GroupBox7.Controls.Add(Me.txtElongationHandLen)
		Me.GroupBox7.Location = New System.Drawing.Point(312, 176)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(152, 120)
		Me.GroupBox7.TabIndex = 41
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Elongation"
		'
		'txtElongationMachineWth
		'
		Me.txtElongationMachineWth.Location = New System.Drawing.Point(104, 72)
		Me.txtElongationMachineWth.Name = "txtElongationMachineWth"
		Me.txtElongationMachineWth.Size = New System.Drawing.Size(40, 20)
		Me.txtElongationMachineWth.TabIndex = 44
		'
		'txtElongationHandWth
		'
		Me.txtElongationHandWth.Location = New System.Drawing.Point(104, 48)
		Me.txtElongationHandWth.Name = "txtElongationHandWth"
		Me.txtElongationHandWth.Size = New System.Drawing.Size(40, 20)
		Me.txtElongationHandWth.TabIndex = 43
		'
		'Label41
		'
		Me.Label41.AutoSize = True
		Me.Label41.Location = New System.Drawing.Point(104, 24)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(35, 13)
		Me.Label41.TabIndex = 42
		Me.Label41.Text = "Width"
		'
		'Label40
		'
		Me.Label40.AutoSize = True
		Me.Label40.Location = New System.Drawing.Point(56, 24)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(40, 13)
		Me.Label40.TabIndex = 41
		Me.Label40.Text = "Length"
		'
		'Label31
		'
		Me.Label31.AutoSize = True
		Me.Label31.Location = New System.Drawing.Point(8, 72)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(48, 13)
		Me.Label31.TabIndex = 40
		Me.Label31.Text = "Machine"
		'
		'txtElongationMachineLen
		'
		Me.txtElongationMachineLen.Location = New System.Drawing.Point(56, 72)
		Me.txtElongationMachineLen.Name = "txtElongationMachineLen"
		Me.txtElongationMachineLen.Size = New System.Drawing.Size(40, 20)
		Me.txtElongationMachineLen.TabIndex = 39
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Location = New System.Drawing.Point(8, 48)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(33, 13)
		Me.Label33.TabIndex = 38
		Me.Label33.Text = "Hand"
		'
		'txtElongationHandLen
		'
		Me.txtElongationHandLen.Location = New System.Drawing.Point(56, 48)
		Me.txtElongationHandLen.Name = "txtElongationHandLen"
		Me.txtElongationHandLen.Size = New System.Drawing.Size(40, 20)
		Me.txtElongationHandLen.TabIndex = 37
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.txtShrinkageWidthTemp)
		Me.GroupBox6.Controls.Add(Me.Label38)
		Me.GroupBox6.Controls.Add(Me.Label39)
		Me.GroupBox6.Controls.Add(Me.txtShrinkageWidth)
		Me.GroupBox6.Controls.Add(Me.txtShrinkageLengthTemp)
		Me.GroupBox6.Controls.Add(Me.Label37)
		Me.GroupBox6.Controls.Add(Me.Label36)
		Me.GroupBox6.Controls.Add(Me.Label27)
		Me.GroupBox6.Controls.Add(Me.txtBurstStrengthMax)
		Me.GroupBox6.Controls.Add(Me.Label28)
		Me.GroupBox6.Controls.Add(Me.txtBurstStrengthMin)
		Me.GroupBox6.Controls.Add(Me.Label29)
		Me.GroupBox6.Controls.Add(Me.Label30)
		Me.GroupBox6.Controls.Add(Me.txtBurstStrengthAvg)
		Me.GroupBox6.Controls.Add(Me.Label32)
		Me.GroupBox6.Controls.Add(Me.txtGMSPerSqM)
		Me.GroupBox6.Controls.Add(Me.Label34)
		Me.GroupBox6.Controls.Add(Me.txtGMSPerRunMt)
		Me.GroupBox6.Controls.Add(Me.Label35)
		Me.GroupBox6.Controls.Add(Me.txtShrinkageLength)
		Me.GroupBox6.Location = New System.Drawing.Point(8, 176)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(304, 120)
		Me.GroupBox6.TabIndex = 46
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "Physical Testing"
		'
		'txtShrinkageWidthTemp
		'
		Me.txtShrinkageWidthTemp.Location = New System.Drawing.Point(256, 48)
		Me.txtShrinkageWidthTemp.Name = "txtShrinkageWidthTemp"
		Me.txtShrinkageWidthTemp.Size = New System.Drawing.Size(40, 20)
		Me.txtShrinkageWidthTemp.TabIndex = 52
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Location = New System.Drawing.Point(168, 48)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(25, 13)
		Me.Label38.TabIndex = 51
		Me.Label38.Text = "@C"
		'
		'Label39
		'
		Me.Label39.AutoSize = True
		Me.Label39.Location = New System.Drawing.Point(64, 48)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(35, 13)
		Me.Label39.TabIndex = 50
		Me.Label39.Text = "Width"
		'
		'txtShrinkageWidth
		'
		Me.txtShrinkageWidth.Location = New System.Drawing.Point(112, 48)
		Me.txtShrinkageWidth.Name = "txtShrinkageWidth"
		Me.txtShrinkageWidth.Size = New System.Drawing.Size(40, 20)
		Me.txtShrinkageWidth.TabIndex = 49
		'
		'txtShrinkageLengthTemp
		'
		Me.txtShrinkageLengthTemp.Location = New System.Drawing.Point(256, 24)
		Me.txtShrinkageLengthTemp.Name = "txtShrinkageLengthTemp"
		Me.txtShrinkageLengthTemp.Size = New System.Drawing.Size(40, 20)
		Me.txtShrinkageLengthTemp.TabIndex = 48
		'
		'Label37
		'
		Me.Label37.AutoSize = True
		Me.Label37.Location = New System.Drawing.Point(168, 24)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(25, 13)
		Me.Label37.TabIndex = 47
		Me.Label37.Text = "@C"
		'
		'Label36
		'
		Me.Label36.AutoSize = True
		Me.Label36.Location = New System.Drawing.Point(64, 24)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(40, 13)
		Me.Label36.TabIndex = 46
		Me.Label36.Text = "Length"
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(224, 96)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(30, 13)
		Me.Label27.TabIndex = 45
		Me.Label27.Text = "Max."
		'
		'txtBurstStrengthMax
		'
		Me.txtBurstStrengthMax.Location = New System.Drawing.Point(256, 96)
		Me.txtBurstStrengthMax.Name = "txtBurstStrengthMax"
		Me.txtBurstStrengthMax.Size = New System.Drawing.Size(40, 20)
		Me.txtBurstStrengthMax.TabIndex = 44
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(152, 96)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(27, 13)
		Me.Label28.TabIndex = 43
		Me.Label28.Text = "Min."
		'
		'txtBurstStrengthMin
		'
		Me.txtBurstStrengthMin.Location = New System.Drawing.Point(184, 96)
		Me.txtBurstStrengthMin.Name = "txtBurstStrengthMin"
		Me.txtBurstStrengthMin.Size = New System.Drawing.Size(40, 20)
		Me.txtBurstStrengthMin.TabIndex = 42
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(80, 96)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(29, 13)
		Me.Label29.TabIndex = 41
		Me.Label29.Text = "Avg."
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Location = New System.Drawing.Point(8, 96)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(74, 13)
		Me.Label30.TabIndex = 40
		Me.Label30.Text = "Burst Strength"
		'
		'txtBurstStrengthAvg
		'
		Me.txtBurstStrengthAvg.Location = New System.Drawing.Point(112, 96)
		Me.txtBurstStrengthAvg.Name = "txtBurstStrengthAvg"
		Me.txtBurstStrengthAvg.Size = New System.Drawing.Size(40, 20)
		Me.txtBurstStrengthAvg.TabIndex = 39
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Location = New System.Drawing.Point(168, 72)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(75, 13)
		Me.Label32.TabIndex = 36
		Me.Label32.Text = "GMS / SQ. M."
		'
		'txtGMSPerSqM
		'
		Me.txtGMSPerSqM.Location = New System.Drawing.Point(256, 72)
		Me.txtGMSPerSqM.Name = "txtGMSPerSqM"
		Me.txtGMSPerSqM.Size = New System.Drawing.Size(40, 20)
		Me.txtGMSPerSqM.TabIndex = 35
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(8, 72)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(80, 13)
		Me.Label34.TabIndex = 33
		Me.Label34.Text = "GMS / Run Mt."
		'
		'txtGMSPerRunMt
		'
		Me.txtGMSPerRunMt.Location = New System.Drawing.Point(112, 72)
		Me.txtGMSPerRunMt.Name = "txtGMSPerRunMt"
		Me.txtGMSPerRunMt.Size = New System.Drawing.Size(40, 20)
		Me.txtGMSPerRunMt.TabIndex = 32
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(8, 24)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(55, 13)
		Me.Label35.TabIndex = 31
		Me.Label35.Text = "Shrinkage"
		'
		'txtShrinkageLength
		'
		Me.txtShrinkageLength.Location = New System.Drawing.Point(112, 24)
		Me.txtShrinkageLength.Name = "txtShrinkageLength"
		Me.txtShrinkageLength.Size = New System.Drawing.Size(40, 20)
		Me.txtShrinkageLength.TabIndex = 30
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.Label25)
		Me.GroupBox5.Controls.Add(Me.txtBursting)
		Me.GroupBox5.Controls.Add(Me.Label26)
		Me.GroupBox5.Controls.Add(Me.txtWeight)
		Me.GroupBox5.Controls.Add(Me.Label23)
		Me.GroupBox5.Controls.Add(Me.txtShrinkage)
		Me.GroupBox5.Controls.Add(Me.Label24)
		Me.GroupBox5.Controls.Add(Me.txtElongation)
		Me.GroupBox5.Location = New System.Drawing.Point(464, 48)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(280, 120)
		Me.GroupBox5.TabIndex = 41
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Methods"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Location = New System.Drawing.Point(8, 96)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(45, 13)
		Me.Label25.TabIndex = 44
		Me.Label25.Text = "Bursting"
		'
		'txtBursting
		'
		Me.txtBursting.Location = New System.Drawing.Point(72, 96)
		Me.txtBursting.Name = "txtBursting"
		Me.txtBursting.Size = New System.Drawing.Size(200, 20)
		Me.txtBursting.TabIndex = 43
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(8, 72)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(41, 13)
		Me.Label26.TabIndex = 42
		Me.Label26.Text = "Weight"
		'
		'txtWeight
		'
		Me.txtWeight.Location = New System.Drawing.Point(72, 72)
		Me.txtWeight.Name = "txtWeight"
		Me.txtWeight.Size = New System.Drawing.Size(200, 20)
		Me.txtWeight.TabIndex = 41
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(8, 48)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(55, 13)
		Me.Label23.TabIndex = 40
		Me.Label23.Text = "Shrinkage"
		'
		'txtShrinkage
		'
		Me.txtShrinkage.Location = New System.Drawing.Point(72, 48)
		Me.txtShrinkage.Name = "txtShrinkage"
		Me.txtShrinkage.Size = New System.Drawing.Size(200, 20)
		Me.txtShrinkage.TabIndex = 39
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(8, 24)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(57, 13)
		Me.Label24.TabIndex = 38
		Me.Label24.Text = "Elongation"
		'
		'txtElongation
		'
		Me.txtElongation.Location = New System.Drawing.Point(72, 24)
		Me.txtElongation.Name = "txtElongation"
		Me.txtElongation.Size = New System.Drawing.Size(200, 20)
		Me.txtElongation.TabIndex = 37
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label22)
		Me.GroupBox4.Controls.Add(Me.txtColor)
		Me.GroupBox4.Controls.Add(Me.Label21)
		Me.GroupBox4.Controls.Add(Me.txtLotNo)
		Me.GroupBox4.Location = New System.Drawing.Point(312, 48)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(152, 120)
		Me.GroupBox4.TabIndex = 36
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Lot Details"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(8, 88)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(31, 13)
		Me.Label22.TabIndex = 40
		Me.Label22.Text = "Color"
		'
		'txtColor
		'
		Me.txtColor.Location = New System.Drawing.Point(56, 88)
		Me.txtColor.Name = "txtColor"
		Me.txtColor.Size = New System.Drawing.Size(88, 20)
		Me.txtColor.TabIndex = 39
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(8, 56)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(42, 13)
		Me.Label21.TabIndex = 38
		Me.Label21.Text = "Lot No."
		'
		'txtLotNo
		'
		Me.txtLotNo.Location = New System.Drawing.Point(56, 56)
		Me.txtLotNo.Name = "txtLotNo"
		Me.txtLotNo.Size = New System.Drawing.Size(88, 20)
		Me.txtLotNo.TabIndex = 37
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label17)
		Me.GroupBox3.Controls.Add(Me.txtRWMax)
		Me.GroupBox3.Controls.Add(Me.Label18)
		Me.GroupBox3.Controls.Add(Me.txtRWMin)
		Me.GroupBox3.Controls.Add(Me.Label19)
		Me.GroupBox3.Controls.Add(Me.Label20)
		Me.GroupBox3.Controls.Add(Me.txtRWAvg)
		Me.GroupBox3.Controls.Add(Me.Label16)
		Me.GroupBox3.Controls.Add(Me.txtRLMax)
		Me.GroupBox3.Controls.Add(Me.Label15)
		Me.GroupBox3.Controls.Add(Me.txtRLMin)
		Me.GroupBox3.Controls.Add(Me.Label14)
		Me.GroupBox3.Controls.Add(Me.Label13)
		Me.GroupBox3.Controls.Add(Me.txtRLAvg)
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.txtUsableWidth)
		Me.GroupBox3.Location = New System.Drawing.Point(8, 48)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(304, 120)
		Me.GroupBox3.TabIndex = 35
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Finished Spec."
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(224, 88)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(30, 13)
		Me.Label17.TabIndex = 45
		Me.Label17.Text = "Max."
		'
		'txtRWMax
		'
		Me.txtRWMax.Location = New System.Drawing.Point(256, 88)
		Me.txtRWMax.Name = "txtRWMax"
		Me.txtRWMax.Size = New System.Drawing.Size(40, 20)
		Me.txtRWMax.TabIndex = 44
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(144, 88)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(27, 13)
		Me.Label18.TabIndex = 43
		Me.Label18.Text = "Min."
		'
		'txtRWMin
		'
		Me.txtRWMin.Location = New System.Drawing.Point(176, 88)
		Me.txtRWMin.Name = "txtRWMin"
		Me.txtRWMin.Size = New System.Drawing.Size(40, 20)
		Me.txtRWMin.TabIndex = 42
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(64, 88)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(29, 13)
		Me.Label19.TabIndex = 41
		Me.Label19.Text = "Avg."
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(8, 88)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(54, 13)
		Me.Label20.TabIndex = 40
		Me.Label20.Text = "R/W (cm)"
		'
		'txtRWAvg
		'
		Me.txtRWAvg.Location = New System.Drawing.Point(96, 88)
		Me.txtRWAvg.Name = "txtRWAvg"
		Me.txtRWAvg.Size = New System.Drawing.Size(40, 20)
		Me.txtRWAvg.TabIndex = 39
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(224, 56)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(30, 13)
		Me.Label16.TabIndex = 38
		Me.Label16.Text = "Max."
		'
		'txtRLMax
		'
		Me.txtRLMax.Location = New System.Drawing.Point(256, 56)
		Me.txtRLMax.Name = "txtRLMax"
		Me.txtRLMax.Size = New System.Drawing.Size(40, 20)
		Me.txtRLMax.TabIndex = 37
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(144, 56)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(27, 13)
		Me.Label15.TabIndex = 36
		Me.Label15.Text = "Min."
		'
		'txtRLMin
		'
		Me.txtRLMin.Location = New System.Drawing.Point(176, 56)
		Me.txtRLMin.Name = "txtRLMin"
		Me.txtRLMin.Size = New System.Drawing.Size(40, 20)
		Me.txtRLMin.TabIndex = 35
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(64, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(29, 13)
		Me.Label14.TabIndex = 34
		Me.Label14.Text = "Avg."
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(8, 56)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(49, 13)
		Me.Label13.TabIndex = 33
		Me.Label13.Text = "R/L (cm)"
		'
		'txtRLAvg
		'
		Me.txtRLAvg.Location = New System.Drawing.Point(96, 56)
		Me.txtRLAvg.Name = "txtRLAvg"
		Me.txtRLAvg.Size = New System.Drawing.Size(40, 20)
		Me.txtRLAvg.TabIndex = 32
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(8, 24)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(138, 13)
		Me.Label12.TabIndex = 31
		Me.Label12.Text = "Minimum Usable Width (cm)"
		'
		'txtUsableWidth
		'
		Me.txtUsableWidth.Location = New System.Drawing.Point(176, 24)
		Me.txtUsableWidth.Name = "txtUsableWidth"
		Me.txtUsableWidth.Size = New System.Drawing.Size(40, 20)
		Me.txtUsableWidth.TabIndex = 30
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(352, 24)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(28, 13)
		Me.Label11.TabIndex = 34
		Me.Label11.Text = "Bars"
		'
		'txtBars
		'
		Me.txtBars.Location = New System.Drawing.Point(392, 24)
		Me.txtBars.Name = "txtBars"
		Me.txtBars.Size = New System.Drawing.Size(40, 20)
		Me.txtBars.TabIndex = 33
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(240, 24)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(39, 13)
		Me.Label10.TabIndex = 32
		Me.Label10.Text = "Gauge"
		'
		'cboMCType
		'
		Me.cboMCType.FormattingEnabled = True
		Me.cboMCType.Location = New System.Drawing.Point(88, 24)
		Me.cboMCType.Name = "cboMCType"
		Me.cboMCType.Size = New System.Drawing.Size(128, 21)
		Me.cboMCType.TabIndex = 31
		'
		'txtGauge
		'
		Me.txtGauge.Location = New System.Drawing.Point(288, 24)
		Me.txtGauge.Name = "txtGauge"
		Me.txtGauge.Size = New System.Drawing.Size(40, 20)
		Me.txtGauge.TabIndex = 31
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(8, 24)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(67, 13)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Type of M/C"
		'
		'cboDesignNo
		'
		Me.cboDesignNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDesignNo.FormattingEnabled = True
		Me.cboDesignNo.Location = New System.Drawing.Point(72, 32)
		Me.cboDesignNo.Name = "cboDesignNo"
		Me.cboDesignNo.Size = New System.Drawing.Size(120, 21)
		Me.cboDesignNo.TabIndex = 31
		'
		'frmDesignSpec
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(769, 625)
		Me.Controls.Add(Me.cboDesignNo)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtRevise)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.dtpSpecDate)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnLoad)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.cboCustomer)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmDesignSpec"
		Me.Text = "Design Specification"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.grdMaterial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox8.ResumeLayout(False)
		Me.GroupBox8.PerformLayout()
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox7.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox6.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents btnLoad As System.Windows.Forms.Button
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents dtpSpecDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents txtComposition As System.Windows.Forms.TextBox
	Friend WithEvents txtDescription As System.Windows.Forms.TextBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents grdMaterial As System.Windows.Forms.DataGridView
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents txtRevise As System.Windows.Forms.TextBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents txtBars As System.Windows.Forms.TextBox
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents cboMCType As System.Windows.Forms.ComboBox
	Friend WithEvents txtGauge As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents txtRLMax As System.Windows.Forms.TextBox
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents txtRLMin As System.Windows.Forms.TextBox
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents txtRLAvg As System.Windows.Forms.TextBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtUsableWidth As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents Label25 As System.Windows.Forms.Label
	Friend WithEvents txtBursting As System.Windows.Forms.TextBox
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents txtWeight As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents txtShrinkage As System.Windows.Forms.TextBox
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents txtElongation As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents txtColor As System.Windows.Forms.TextBox
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents txtRWMax As System.Windows.Forms.TextBox
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents txtRWMin As System.Windows.Forms.TextBox
	Friend WithEvents Label19 As System.Windows.Forms.Label
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents txtRWAvg As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
	Friend WithEvents txtShrinkageWidthTemp As System.Windows.Forms.TextBox
	Friend WithEvents Label38 As System.Windows.Forms.Label
	Friend WithEvents Label39 As System.Windows.Forms.Label
	Friend WithEvents txtShrinkageWidth As System.Windows.Forms.TextBox
	Friend WithEvents txtShrinkageLengthTemp As System.Windows.Forms.TextBox
	Friend WithEvents Label37 As System.Windows.Forms.Label
	Friend WithEvents Label36 As System.Windows.Forms.Label
	Friend WithEvents Label27 As System.Windows.Forms.Label
	Friend WithEvents txtBurstStrengthMax As System.Windows.Forms.TextBox
	Friend WithEvents Label28 As System.Windows.Forms.Label
	Friend WithEvents txtBurstStrengthMin As System.Windows.Forms.TextBox
	Friend WithEvents Label29 As System.Windows.Forms.Label
	Friend WithEvents Label30 As System.Windows.Forms.Label
	Friend WithEvents txtBurstStrengthAvg As System.Windows.Forms.TextBox
	Friend WithEvents Label32 As System.Windows.Forms.Label
	Friend WithEvents txtGMSPerSqM As System.Windows.Forms.TextBox
	Friend WithEvents Label34 As System.Windows.Forms.Label
	Friend WithEvents txtGMSPerRunMt As System.Windows.Forms.TextBox
	Friend WithEvents Label35 As System.Windows.Forms.Label
	Friend WithEvents txtShrinkageLength As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
	Friend WithEvents Label43 As System.Windows.Forms.Label
	Friend WithEvents txtModLenPerc3 As System.Windows.Forms.TextBox
	Friend WithEvents Label44 As System.Windows.Forms.Label
	Friend WithEvents txtModLenPerc2 As System.Windows.Forms.TextBox
	Friend WithEvents Label45 As System.Windows.Forms.Label
	Friend WithEvents txtModLenPerc1 As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
	Friend WithEvents txtElongationMachineWth As System.Windows.Forms.TextBox
	Friend WithEvents txtElongationHandWth As System.Windows.Forms.TextBox
	Friend WithEvents Label41 As System.Windows.Forms.Label
	Friend WithEvents Label40 As System.Windows.Forms.Label
	Friend WithEvents Label31 As System.Windows.Forms.Label
	Friend WithEvents txtElongationMachineLen As System.Windows.Forms.TextBox
	Friend WithEvents Label33 As System.Windows.Forms.Label
	Friend WithEvents txtElongationHandLen As System.Windows.Forms.TextBox
	Friend WithEvents Label54 As System.Windows.Forms.Label
	Friend WithEvents txtProcessRoute As System.Windows.Forms.TextBox
	Friend WithEvents Label53 As System.Windows.Forms.Label
	Friend WithEvents txtSeperationMethod As System.Windows.Forms.TextBox
	Friend WithEvents txtModWthVal3 As System.Windows.Forms.TextBox
	Friend WithEvents txtModWthVal2 As System.Windows.Forms.TextBox
	Friend WithEvents txtModWthVal1 As System.Windows.Forms.TextBox
	Friend WithEvents Label50 As System.Windows.Forms.Label
	Friend WithEvents Label51 As System.Windows.Forms.Label
	Friend WithEvents Label52 As System.Windows.Forms.Label
	Friend WithEvents txtModWthPerc3 As System.Windows.Forms.TextBox
	Friend WithEvents txtModWthPerc2 As System.Windows.Forms.TextBox
	Friend WithEvents txtModWthPerc1 As System.Windows.Forms.TextBox
	Friend WithEvents txtModLenVal3 As System.Windows.Forms.TextBox
	Friend WithEvents txtModLenVal2 As System.Windows.Forms.TextBox
	Friend WithEvents txtModLenVal1 As System.Windows.Forms.TextBox
	Friend WithEvents Label49 As System.Windows.Forms.Label
	Friend WithEvents Label48 As System.Windows.Forms.Label
	Friend WithEvents Label47 As System.Windows.Forms.Label
	Friend WithEvents Label42 As System.Windows.Forms.Label
	Friend WithEvents Label46 As System.Windows.Forms.Label
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ratio As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
