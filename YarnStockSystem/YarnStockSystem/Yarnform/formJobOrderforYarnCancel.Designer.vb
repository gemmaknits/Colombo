<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJobOrderforYarnCancel
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
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formJobOrderforYarnCancel))
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.BtnExit = New System.Windows.Forms.Button
		Me.Btnprint = New System.Windows.Forms.Button
		Me.buttonApprove = New System.Windows.Forms.Button
		Me.Label14 = New System.Windows.Forms.Label
		Me.txtftube = New System.Windows.Forms.TextBox
		Me.Dg_jobYarndet = New System.Windows.Forms.DataGridView
		Me.DGV_select = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.clmitcd = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmgrade = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmboxno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmspools = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmkg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmkg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.clmlotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.Cbcolor = New System.Windows.Forms.ComboBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.txtftpm = New System.Windows.Forms.TextBox
		Me.Label12 = New System.Windows.Forms.Label
		Me.txtfspools = New System.Windows.Forms.TextBox
		Me.txtjbo = New System.Windows.Forms.TextBox
		Me.BtnSearchItem = New System.Windows.Forms.Button
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label17 = New System.Windows.Forms.Label
		Me.txtbox = New System.Windows.Forms.TextBox
		Me.txtkg_nt = New System.Windows.Forms.TextBox
		Me.txtspools = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.txtkg_gr = New System.Windows.Forms.TextBox
		Me.txtremark = New System.Windows.Forms.TextBox
		Me.GroupBox3 = New System.Windows.Forms.GroupBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtjobno = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.CbSuppcd = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Cbjobtype = New System.Windows.Forms.ComboBox
		Me.txtjobdt = New System.Windows.Forms.DateTimePicker
		Me.Label15 = New System.Windows.Forms.Label
		Me.textKono = New System.Windows.Forms.TextBox
		Me.btnFindJob_no = New System.Windows.Forms.Button
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.textRemCancel = New System.Windows.Forms.TextBox
		CType(Me.Dg_jobYarndet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox4.SuspendLayout()
		Me.SuspendLayout()
		'
		'BtnExit
		'
		Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
		Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.BtnExit.Location = New System.Drawing.Point(676, 642)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(63, 40)
		Me.BtnExit.TabIndex = 150
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.BtnExit.UseVisualStyleBackColor = True
		'
		'Btnprint
		'
		Me.Btnprint.Image = CType(resources.GetObject("Btnprint.Image"), System.Drawing.Image)
		Me.Btnprint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Btnprint.Location = New System.Drawing.Point(612, 642)
		Me.Btnprint.Name = "Btnprint"
		Me.Btnprint.Size = New System.Drawing.Size(63, 40)
		Me.Btnprint.TabIndex = 149
		Me.Btnprint.Text = "Print"
		Me.Btnprint.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.Btnprint.UseVisualStyleBackColor = True
		'
		'buttonApprove
		'
		Me.buttonApprove.Image = CType(resources.GetObject("buttonApprove.Image"), System.Drawing.Image)
		Me.buttonApprove.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.buttonApprove.Location = New System.Drawing.Point(545, 642)
		Me.buttonApprove.Name = "buttonApprove"
		Me.buttonApprove.Size = New System.Drawing.Size(63, 40)
		Me.buttonApprove.TabIndex = 148
		Me.buttonApprove.Text = "Canc.Job"
		Me.buttonApprove.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.buttonApprove.UseVisualStyleBackColor = True
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label14.Location = New System.Drawing.Point(6, 56)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(83, 13)
		Me.Label14.TabIndex = 123
		Me.Label14.Text = "Tubes / Spools:"
		'
		'txtftube
		'
		Me.txtftube.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtftube.Location = New System.Drawing.Point(226, 55)
		Me.txtftube.Name = "txtftube"
		Me.txtftube.Size = New System.Drawing.Size(55, 22)
		Me.txtftube.TabIndex = 121
		'
		'Dg_jobYarndet
		'
		Me.Dg_jobYarndet.BackgroundColor = System.Drawing.Color.PeachPuff
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.Dg_jobYarndet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.Dg_jobYarndet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Dg_jobYarndet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_select, Me.clmitcd, Me.clmgrade, Me.clmboxno, Me.clmspools, Me.clmkg_gr, Me.clmkg_nt, Me.clmlotno_our})
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.Dg_jobYarndet.DefaultCellStyle = DataGridViewCellStyle4
		Me.Dg_jobYarndet.Location = New System.Drawing.Point(31, 96)
		Me.Dg_jobYarndet.Name = "Dg_jobYarndet"
		Me.Dg_jobYarndet.Size = New System.Drawing.Size(597, 310)
		Me.Dg_jobYarndet.TabIndex = 152
		'
		'DGV_select
		'
		Me.DGV_select.HeaderText = "*"
		Me.DGV_select.Name = "DGV_select"
		Me.DGV_select.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGV_select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DGV_select.Width = 20
		'
		'clmitcd
		'
		Me.clmitcd.DataPropertyName = "itcd"
		Me.clmitcd.HeaderText = "Item Code"
		Me.clmitcd.Name = "clmitcd"
		Me.clmitcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.clmitcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		Me.clmitcd.Width = 80
		'
		'clmgrade
		'
		Me.clmgrade.DataPropertyName = "grade"
		Me.clmgrade.HeaderText = "Grade"
		Me.clmgrade.Name = "clmgrade"
		Me.clmgrade.Visible = False
		Me.clmgrade.Width = 40
		'
		'clmboxno
		'
		Me.clmboxno.DataPropertyName = "boxno"
		Me.clmboxno.HeaderText = "Box#"
		Me.clmboxno.Name = "clmboxno"
		Me.clmboxno.ReadOnly = True
		'
		'clmspools
		'
		Me.clmspools.DataPropertyName = "spools"
		Me.clmspools.HeaderText = "Tube/Spools"
		Me.clmspools.Name = "clmspools"
		Me.clmspools.Width = 40
		'
		'clmkg_gr
		'
		Me.clmkg_gr.DataPropertyName = "kg_gr"
		Me.clmkg_gr.HeaderText = "Gross wt{Kg}"
		Me.clmkg_gr.MaxInputLength = 10
		Me.clmkg_gr.Name = "clmkg_gr"
		Me.clmkg_gr.Width = 50
		'
		'clmkg_nt
		'
		Me.clmkg_nt.DataPropertyName = "kg_nt"
		Me.clmkg_nt.HeaderText = "Net wt{Kg}"
		Me.clmkg_nt.Name = "clmkg_nt"
		Me.clmkg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.clmkg_nt.Width = 50
		'
		'clmlotno_our
		'
		Me.clmlotno_our.DataPropertyName = "lotno_our"
		Me.clmlotno_our.HeaderText = "Merge/ Lot#"
		Me.clmlotno_our.Name = "clmlotno_our"
		Me.clmlotno_our.Width = 80
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Cbcolor)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Controls.Add(Me.txtftpm)
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.txtfspools)
		Me.GroupBox2.Controls.Add(Me.txtjbo)
		Me.GroupBox2.Controls.Add(Me.BtnSearchItem)
		Me.GroupBox2.Controls.Add(Me.Label13)
		Me.GroupBox2.Controls.Add(Me.Label14)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.txtftube)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(22, 412)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(504, 86)
		Me.GroupBox2.TabIndex = 147
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Finished stock:"
		'
		'Cbcolor
		'
		Me.Cbcolor.FormattingEnabled = True
		Me.Cbcolor.Location = New System.Drawing.Point(399, 59)
		Me.Cbcolor.Name = "Cbcolor"
		Me.Cbcolor.Size = New System.Drawing.Size(95, 21)
		Me.Cbcolor.TabIndex = 128
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label16.Location = New System.Drawing.Point(314, 61)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(79, 13)
		Me.Label16.TabIndex = 127
		Me.Label16.Text = "Color (if dyeing)"
		'
		'txtftpm
		'
		Me.txtftpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtftpm.Location = New System.Drawing.Point(399, 27)
		Me.txtftpm.Name = "txtftpm"
		Me.txtftpm.Size = New System.Drawing.Size(95, 22)
		Me.txtftpm.TabIndex = 126
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label12.Location = New System.Drawing.Point(314, 27)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(82, 13)
		Me.Label12.TabIndex = 125
		Me.Label12.Text = "TPM (if twisting)"
		'
		'txtfspools
		'
		Me.txtfspools.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtfspools.Location = New System.Drawing.Point(92, 53)
		Me.txtfspools.Name = "txtfspools"
		Me.txtfspools.Size = New System.Drawing.Size(48, 22)
		Me.txtfspools.TabIndex = 124
		'
		'txtjbo
		'
		Me.txtjbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtjbo.Location = New System.Drawing.Point(92, 24)
		Me.txtjbo.Name = "txtjbo"
		Me.txtjbo.Size = New System.Drawing.Size(137, 22)
		Me.txtjbo.TabIndex = 118
		'
		'BtnSearchItem
		'
		Me.BtnSearchItem.Location = New System.Drawing.Point(232, 24)
		Me.BtnSearchItem.Name = "BtnSearchItem"
		Me.BtnSearchItem.Size = New System.Drawing.Size(48, 22)
		Me.BtnSearchItem.TabIndex = 117
		Me.BtnSearchItem.Text = "Find"
		Me.BtnSearchItem.UseVisualStyleBackColor = True
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label13.Location = New System.Drawing.Point(153, 59)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(70, 13)
		Me.Label13.TabIndex = 119
		Me.Label13.Text = "Weight/tube:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label8.Location = New System.Drawing.Point(6, 27)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(82, 13)
		Me.Label8.TabIndex = 112
		Me.Label8.Text = "New yarn code:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label17)
		Me.GroupBox1.Controls.Add(Me.txtbox)
		Me.GroupBox1.Controls.Add(Me.txtkg_nt)
		Me.GroupBox1.Controls.Add(Me.txtspools)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label11)
		Me.GroupBox1.Controls.Add(Me.Label10)
		Me.GroupBox1.Controls.Add(Me.txtkg_gr)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(539, 412)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(225, 146)
		Me.GroupBox1.TabIndex = 146
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Total order qty:"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label17.Location = New System.Drawing.Point(14, 34)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(30, 13)
		Me.Label17.TabIndex = 127
		Me.Label17.Text = "box :"
		'
		'txtbox
		'
		Me.txtbox.Location = New System.Drawing.Point(100, 27)
		Me.txtbox.Name = "txtbox"
		Me.txtbox.Size = New System.Drawing.Size(95, 20)
		Me.txtbox.TabIndex = 126
		Me.txtbox.Text = "0"
		'
		'txtkg_nt
		'
		Me.txtkg_nt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtkg_nt.Location = New System.Drawing.Point(100, 109)
		Me.txtkg_nt.Name = "txtkg_nt"
		Me.txtkg_nt.Size = New System.Drawing.Size(95, 22)
		Me.txtkg_nt.TabIndex = 122
		Me.txtkg_nt.Text = "0"
		'
		'txtspools
		'
		Me.txtspools.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtspools.Location = New System.Drawing.Point(100, 53)
		Me.txtspools.Name = "txtspools"
		Me.txtspools.Size = New System.Drawing.Size(95, 22)
		Me.txtspools.TabIndex = 124
		Me.txtspools.Text = "0"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label9.Location = New System.Drawing.Point(14, 90)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(75, 13)
		Me.Label9.TabIndex = 119
		Me.Label9.Text = "Gross wt. (kg):"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label11.Location = New System.Drawing.Point(14, 62)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(83, 13)
		Me.Label11.TabIndex = 123
		Me.Label11.Text = "Tubes / Spools:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label10.Location = New System.Drawing.Point(14, 118)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(65, 13)
		Me.Label10.TabIndex = 120
		Me.Label10.Text = "Net wt. (kg):"
		'
		'txtkg_gr
		'
		Me.txtkg_gr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtkg_gr.Location = New System.Drawing.Point(100, 81)
		Me.txtkg_gr.Name = "txtkg_gr"
		Me.txtkg_gr.Size = New System.Drawing.Size(95, 22)
		Me.txtkg_gr.TabIndex = 121
		Me.txtkg_gr.Text = "0"
		'
		'txtremark
		'
		Me.txtremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtremark.Location = New System.Drawing.Point(7, 19)
		Me.txtremark.Multiline = True
		Me.txtremark.Name = "txtremark"
		Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtremark.Size = New System.Drawing.Size(471, 66)
		Me.txtremark.TabIndex = 129
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.txtremark)
		Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox3.Location = New System.Drawing.Point(24, 515)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(502, 91)
		Me.GroupBox3.TabIndex = 153
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Remarks"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label7.Location = New System.Drawing.Point(28, 78)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(128, 13)
		Me.Label7.TabIndex = 145
		Me.Label7.Text = "Selected for process:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label4.Location = New System.Drawing.Point(522, 50)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(78, 13)
		Me.Label4.TabIndex = 139
		Me.Label4.Text = "Job order date:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label2.Location = New System.Drawing.Point(536, 20)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 13)
		Me.Label2.TabIndex = 137
		Me.Label2.Text = "Job order #:"
		'
		'txtjobno
		'
		Me.txtjobno.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.txtjobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtjobno.Location = New System.Drawing.Point(603, 12)
		Me.txtjobno.Name = "txtjobno"
		Me.txtjobno.Size = New System.Drawing.Size(137, 29)
		Me.txtjobno.TabIndex = 136
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label1.Location = New System.Drawing.Point(19, 43)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 13)
		Me.Label1.TabIndex = 135
		Me.Label1.Text = "Supplier:"
		'
		'CbSuppcd
		'
		Me.CbSuppcd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CbSuppcd.Enabled = False
		Me.CbSuppcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.CbSuppcd.FormattingEnabled = True
		Me.CbSuppcd.Location = New System.Drawing.Point(73, 38)
		Me.CbSuppcd.Name = "CbSuppcd"
		Me.CbSuppcd.Size = New System.Drawing.Size(199, 24)
		Me.CbSuppcd.TabIndex = 134
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label3.Location = New System.Drawing.Point(19, 17)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(48, 13)
		Me.Label3.TabIndex = 133
		Me.Label3.Text = "Process:"
		'
		'Cbjobtype
		'
		Me.Cbjobtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Cbjobtype.Enabled = False
		Me.Cbjobtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Cbjobtype.FormattingEnabled = True
		Me.Cbjobtype.Location = New System.Drawing.Point(73, 12)
		Me.Cbjobtype.Name = "Cbjobtype"
		Me.Cbjobtype.Size = New System.Drawing.Size(199, 24)
		Me.Cbjobtype.TabIndex = 132
		'
		'txtjobdt
		'
		Me.txtjobdt.Enabled = False
		Me.txtjobdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.txtjobdt.Location = New System.Drawing.Point(603, 47)
		Me.txtjobdt.Name = "txtjobdt"
		Me.txtjobdt.Size = New System.Drawing.Size(137, 20)
		Me.txtjobdt.TabIndex = 154
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label15.Location = New System.Drawing.Point(278, 17)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(92, 13)
		Me.Label15.TabIndex = 155
		Me.Label15.Text = "Knitting order No.:"
		'
		'textKono
		'
		Me.textKono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.textKono.Location = New System.Drawing.Point(376, 14)
		Me.textKono.Name = "textKono"
		Me.textKono.Size = New System.Drawing.Size(95, 22)
		Me.textKono.TabIndex = 129
		'
		'btnFindJob_no
		'
		Me.btnFindJob_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.btnFindJob_no.Location = New System.Drawing.Point(746, 12)
		Me.btnFindJob_no.Name = "btnFindJob_no"
		Me.btnFindJob_no.Size = New System.Drawing.Size(48, 29)
		Me.btnFindJob_no.TabIndex = 156
		Me.btnFindJob_no.Text = "Find"
		Me.btnFindJob_no.UseVisualStyleBackColor = True
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.textRemCancel)
		Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox4.Location = New System.Drawing.Point(539, 564)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(225, 72)
		Me.GroupBox4.TabIndex = 154
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Cancel remark"
		'
		'textRemCancel
		'
		Me.textRemCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.textRemCancel.Location = New System.Drawing.Point(6, 13)
		Me.textRemCancel.Multiline = True
		Me.textRemCancel.Name = "textRemCancel"
		Me.textRemCancel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textRemCancel.Size = New System.Drawing.Size(218, 53)
		Me.textRemCancel.TabIndex = 129
		'
		'formJobOrderforYarnCancel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(814, 686)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.btnFindJob_no)
		Me.Controls.Add(Me.textKono)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.txtjobdt)
		Me.Controls.Add(Me.BtnExit)
		Me.Controls.Add(Me.Btnprint)
		Me.Controls.Add(Me.buttonApprove)
		Me.Controls.Add(Me.Dg_jobYarndet)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtjobno)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CbSuppcd)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Cbjobtype)
		Me.Name = "formJobOrderforYarnCancel"
		Me.Text = "Cancel job order"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.Dg_jobYarndet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents BtnExit As System.Windows.Forms.Button
	Friend WithEvents Btnprint As System.Windows.Forms.Button
	Friend WithEvents buttonApprove As System.Windows.Forms.Button
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents txtftube As System.Windows.Forms.TextBox
	Friend WithEvents Dg_jobYarndet As System.Windows.Forms.DataGridView
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents txtftpm As System.Windows.Forms.TextBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtfspools As System.Windows.Forms.TextBox
	Friend WithEvents txtjbo As System.Windows.Forms.TextBox
	Friend WithEvents BtnSearchItem As System.Windows.Forms.Button
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents txtkg_nt As System.Windows.Forms.TextBox
	Friend WithEvents txtspools As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents txtkg_gr As System.Windows.Forms.TextBox
	Friend WithEvents txtremark As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtjobno As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents CbSuppcd As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Cbjobtype As System.Windows.Forms.ComboBox
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents txtbox As System.Windows.Forms.TextBox
	Friend WithEvents Cbcolor As System.Windows.Forms.ComboBox
	Friend WithEvents txtjobdt As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents textKono As System.Windows.Forms.TextBox
	Friend WithEvents btnFindJob_no As System.Windows.Forms.Button
	Friend WithEvents DGV_select As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents clmitcd As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmgrade As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmboxno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmspools As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmkg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmkg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents clmlotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents textRemCancel As System.Windows.Forms.TextBox
End Class
