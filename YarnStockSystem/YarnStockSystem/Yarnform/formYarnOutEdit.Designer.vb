<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnOutEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnOutEdit))
        Me.DgYarnOut = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTrantype = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textYarnInNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtJobNo = New System.Windows.Forms.TextBox()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotalnet = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txttotalgross = New System.Windows.Forms.TextBox()
        Me.txttotalboxes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpoutdt = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchYout = New System.Windows.Forms.Button()
        Me.txtOutno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPrintYarnout = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textStatus = New System.Windows.Forms.TextBox()
        Me.DgCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DgCombobox = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgYarnOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgYarnOut
        '
        Me.DgYarnOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgYarnOut.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DgYarnOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgYarnOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgCheckbox, Me.DgCombobox, Me.Grade, Me.boxno_s, Me.boxno, Me.spools, Me.kg_gr, Me.kg_nt, Me.actual_cone_weight, Me.outno})
        Me.DgYarnOut.Location = New System.Drawing.Point(19, 138)
        Me.DgYarnOut.Name = "DgYarnOut"
        Me.DgYarnOut.Size = New System.Drawing.Size(997, 356)
        Me.DgYarnOut.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Job type:"
        '
        'CbTrantype
        '
        Me.CbTrantype.Enabled = False
        Me.CbTrantype.FormattingEnabled = True
        Me.CbTrantype.Location = New System.Drawing.Point(328, 112)
        Me.CbTrantype.Name = "CbTrantype"
        Me.CbTrantype.Size = New System.Drawing.Size(162, 21)
        Me.CbTrantype.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.textYarnInNo)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.btnSearch)
        Me.GroupBox5.Controls.Add(Me.txtJobNo)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(329, 85)
        Me.GroupBox5.TabIndex = 112
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Source document"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textYarnInNo
        '
        Me.textYarnInNo.Location = New System.Drawing.Point(93, 19)
        Me.textYarnInNo.Name = "textYarnInNo"
        Me.textYarnInNo.ReadOnly = True
        Me.textYarnInNo.Size = New System.Drawing.Size(161, 20)
        Me.textYarnInNo.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Y-IN no.:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(260, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(47, 23)
        Me.btnSearch.TabIndex = 120
        Me.btnSearch.Text = "Find"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtJobNo
        '
        Me.txtJobNo.Location = New System.Drawing.Point(93, 52)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(161, 20)
        Me.txtJobNo.TabIndex = 119
        '
        'lblYINno
        '
        Me.lblYINno.AutoSize = True
        Me.lblYINno.Location = New System.Drawing.Point(81, 32)
        Me.lblYINno.Name = "lblYINno"
        Me.lblYINno.Size = New System.Drawing.Size(0, 13)
        Me.lblYINno.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Job order no.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-111, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 77
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-156, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'txtsupplier
        '
        Me.txtsupplier.Location = New System.Drawing.Point(79, 112)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.ReadOnly = True
        Me.txtsupplier.Size = New System.Drawing.Size(161, 22)
        Me.txtsupplier.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Supplier:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txttotalnet)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txttotalgross)
        Me.GroupBox4.Controls.Add(Me.txttotalboxes)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(784, 532)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(169, 106)
        Me.GroupBox4.TabIndex = 113
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quantity"
        '
        'txttotalnet
        '
        Me.txttotalnet.Location = New System.Drawing.Point(82, 71)
        Me.txttotalnet.Name = "txttotalnet"
        Me.txttotalnet.Size = New System.Drawing.Size(67, 20)
        Me.txttotalnet.TabIndex = 81
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(-111, 40)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 77
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 74)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 82
        Me.Label23.Text = "Net wt (kg):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-156, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 78
        Me.Label21.Text = "Boxes:"
        '
        'txttotalgross
        '
        Me.txttotalgross.Location = New System.Drawing.Point(82, 45)
        Me.txttotalgross.Name = "txttotalgross"
        Me.txttotalgross.Size = New System.Drawing.Size(67, 20)
        Me.txttotalgross.TabIndex = 79
        '
        'txttotalboxes
        '
        Me.txttotalboxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotalboxes.Location = New System.Drawing.Point(82, 19)
        Me.txttotalboxes.Name = "txttotalboxes"
        Me.txttotalboxes.Size = New System.Drawing.Size(67, 20)
        Me.txttotalboxes.TabIndex = 77
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Gross wt (kg):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(37, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Boxes:"
        '
        'butSelectAll
        '
        Me.butSelectAll.Image = Global.YarnStockSystem.My.Resources.Resources.SelectAllItems_16x
        Me.butSelectAll.Location = New System.Drawing.Point(964, 111)
        Me.butSelectAll.Name = "butSelectAll"
        Me.butSelectAll.Size = New System.Drawing.Size(23, 23)
        Me.butSelectAll.TabIndex = 117
        Me.butSelectAll.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.YarnStockSystem.My.Resources.Resources.SelectNoItems_16x
        Me.Button5.Location = New System.Drawing.Point(993, 111)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 118
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtpoutdt)
        Me.GroupBox1.Controls.Add(Me.btnSearchYout)
        Me.GroupBox1.Controls.Add(Me.txtOutno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(754, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 85)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Y-OUT Document"
        '
        'dtpoutdt
        '
        Me.dtpoutdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpoutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoutdt.Location = New System.Drawing.Point(90, 48)
        Me.dtpoutdt.Name = "dtpoutdt"
        Me.dtpoutdt.Size = New System.Drawing.Size(128, 20)
        Me.dtpoutdt.TabIndex = 139
        '
        'btnSearchYout
        '
        Me.btnSearchYout.Image = CType(resources.GetObject("btnSearchYout.Image"), System.Drawing.Image)
        Me.btnSearchYout.Location = New System.Drawing.Point(219, 18)
        Me.btnSearchYout.Name = "btnSearchYout"
        Me.btnSearchYout.Size = New System.Drawing.Size(32, 23)
        Me.btnSearchYout.TabIndex = 123
        Me.btnSearchYout.UseVisualStyleBackColor = True
        '
        'txtOutno
        '
        Me.txtOutno.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutno.Location = New System.Drawing.Point(90, 19)
        Me.txtOutno.Name = "txtOutno"
        Me.txtOutno.Size = New System.Drawing.Size(128, 20)
        Me.txtOutno.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Y-OUT Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Y-OUT No.:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(-111, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-156, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Boxes:"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(75, 500)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(380, 109)
        Me.txtRemark.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Remark :"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(963, 600)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 38)
        Me.Button3.TabIndex = 116
        Me.Button3.Text = "Exit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnPrintYarnout
        '
        Me.btnPrintYarnout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintYarnout.Image = CType(resources.GetObject("btnPrintYarnout.Image"), System.Drawing.Image)
        Me.btnPrintYarnout.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintYarnout.Location = New System.Drawing.Point(963, 560)
        Me.btnPrintYarnout.Name = "btnPrintYarnout"
        Me.btnPrintYarnout.Size = New System.Drawing.Size(51, 38)
        Me.btnPrintYarnout.TabIndex = 115
        Me.btnPrintYarnout.Text = "Print"
        Me.btnPrintYarnout.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnPrintYarnout.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(963, 520)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 38)
        Me.BtnSave.TabIndex = 114
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(792, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Status:"
        '
        'textStatus
        '
        Me.textStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textStatus.Location = New System.Drawing.Point(840, 497)
        Me.textStatus.Name = "textStatus"
        Me.textStatus.ReadOnly = True
        Me.textStatus.Size = New System.Drawing.Size(113, 22)
        Me.textStatus.TabIndex = 124
        '
        'DgCheckbox
        '
        Me.DgCheckbox.Frozen = True
        Me.DgCheckbox.HeaderText = ""
        Me.DgCheckbox.Name = "DgCheckbox"
        Me.DgCheckbox.Width = 20
        '
        'DgCombobox
        '
        Me.DgCombobox.DataPropertyName = "itcd"
        Me.DgCombobox.HeaderText = "Item Code"
        Me.DgCombobox.Name = "DgCombobox"
        Me.DgCombobox.Width = 200
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MaxInputLength = 15
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 50
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no."
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.Width = 80
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube/ Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross box weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 70
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net Box weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.Width = 70
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight{Kg}"
        Me.actual_cone_weight.Name = "actual_cone_weight"
        Me.actual_cone_weight.Width = 70
        '
        'outno
        '
        Me.outno.DataPropertyName = "outno"
        Me.outno.HeaderText = "Outno"
        Me.outno.Name = "outno"
        Me.outno.Visible = False
        '
        'formYarnOutEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 642)
        Me.Controls.Add(Me.textStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtsupplier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.butSelectAll)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPrintYarnout)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.CbTrantype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgYarnOut)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formYarnOutEdit"
        Me.Text = "Edit yarn out"
        CType(Me.DgYarnOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgYarnOut As System.Windows.Forms.DataGridView
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents CbTrantype As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents lblYINno As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents txttotalnet As System.Windows.Forms.TextBox
	Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents txttotalgross As System.Windows.Forms.TextBox
	Friend WithEvents txttotalboxes As System.Windows.Forms.TextBox
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents BtnSave As System.Windows.Forms.Button
	Friend WithEvents btnPrintYarnout As System.Windows.Forms.Button
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents butSelectAll As System.Windows.Forms.Button
	Friend WithEvents Button5 As System.Windows.Forms.Button
	Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents btnSearch As System.Windows.Forms.Button
	Friend WithEvents txtsupplier As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents txtOutno As System.Windows.Forms.TextBox
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents textYarnInNo As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents textStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchYout As System.Windows.Forms.Button
    Friend WithEvents dtpoutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents DgCombobox As DataGridViewComboBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As DataGridViewTextBoxColumn
    Friend WithEvents outno As DataGridViewTextBoxColumn
End Class
