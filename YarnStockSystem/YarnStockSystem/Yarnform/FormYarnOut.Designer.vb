<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnout))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtsupplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtYOUT = New System.Windows.Forms.TextBox()
        Me.Datetime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.CbTrantype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgYarnOut = New System.Windows.Forms.DataGridView()
        Me.colCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colitcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBoxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSpools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKgGr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKgNt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActualConeWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colidJobDetYarn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMfgProductionOrderLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotalnet = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txttotalgross = New System.Windows.Forms.TextBox()
        Me.txttotalboxes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPrintYarnout = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.butSelectAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DgYarnOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(364, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Barcode file:"
        '
        'Button2
        '
        Me.Button2.Image = Global.YarnStockSystem.My.Resources.Resources.Search_16x
        Me.Button2.Location = New System.Drawing.Point(496, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 23)
        Me.Button2.TabIndex = 136
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 134
        '
        'txtsupplier
        '
        Me.txtsupplier.Location = New System.Drawing.Point(79, 117)
        Me.txtsupplier.Name = "txtsupplier"
        Me.txtsupplier.ReadOnly = True
        Me.txtsupplier.Size = New System.Drawing.Size(161, 22)
        Me.txtsupplier.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Supplier:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtYOUT)
        Me.GroupBox1.Controls.Add(Me.Datetime)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(791, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 85)
        Me.GroupBox1.TabIndex = 131
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Y-OUT Document"
        '
        'txtYOUT
        '
        Me.txtYOUT.Location = New System.Drawing.Point(90, 19)
        Me.txtYOUT.Name = "txtYOUT"
        Me.txtYOUT.ReadOnly = True
        Me.txtYOUT.Size = New System.Drawing.Size(161, 22)
        Me.txtYOUT.TabIndex = 121
        '
        'Datetime
        '
        Me.Datetime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datetime.Location = New System.Drawing.Point(90, 48)
        Me.Datetime.Name = "Datetime"
        Me.Datetime.Size = New System.Drawing.Size(161, 22)
        Me.Datetime.TabIndex = 120
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
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Y-OUT Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Y-OUT No.:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(-111, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-156, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Boxes:"
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
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(329, 85)
        Me.GroupBox5.TabIndex = 128
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Source document"
        '
        'Button1
        '
        Me.Button1.Image = Global.YarnStockSystem.My.Resources.Resources.Search_16x1
        Me.Button1.Location = New System.Drawing.Point(260, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 123
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textYarnInNo
        '
        Me.textYarnInNo.Enabled = False
        Me.textYarnInNo.Location = New System.Drawing.Point(93, 19)
        Me.textYarnInNo.Name = "textYarnInNo"
        Me.textYarnInNo.ReadOnly = True
        Me.textYarnInNo.Size = New System.Drawing.Size(161, 22)
        Me.textYarnInNo.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Y-IN no.:"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.YarnStockSystem.My.Resources.Resources.Search_16x
        Me.btnSearch.Location = New System.Drawing.Point(260, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 23)
        Me.btnSearch.TabIndex = 120
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtJobNo
        '
        Me.txtJobNo.Location = New System.Drawing.Point(93, 52)
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(161, 22)
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
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Job order no.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-111, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 22)
        Me.TextBox24.TabIndex = 77
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-156, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'CbTrantype
        '
        Me.CbTrantype.Enabled = False
        Me.CbTrantype.FormattingEnabled = True
        Me.CbTrantype.Location = New System.Drawing.Point(328, 117)
        Me.CbTrantype.Name = "CbTrantype"
        Me.CbTrantype.Size = New System.Drawing.Size(162, 21)
        Me.CbTrantype.TabIndex = 127
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Job type:"
        '
        'DgYarnOut
        '
        Me.DgYarnOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgYarnOut.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DgYarnOut.ColumnHeadersHeight = 60
        Me.DgYarnOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgYarnOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheckbox, Me.colitcd, Me.colGrade, Me.boxno_s, Me.colBoxno, Me.colSpools, Me.colKgGr, Me.cart_tearwt, Me.colKgNt, Me.colActualConeWeight, Me.colidJobDetYarn, Me.colGb, Me.colMfgProductionOrderLineId, Me.colKoNo})
        Me.DgYarnOut.Location = New System.Drawing.Point(19, 143)
        Me.DgYarnOut.Name = "DgYarnOut"
        Me.DgYarnOut.Size = New System.Drawing.Size(1034, 357)
        Me.DgYarnOut.TabIndex = 125
        '
        'colCheckbox
        '
        Me.colCheckbox.Frozen = True
        Me.colCheckbox.HeaderText = ""
        Me.colCheckbox.Name = "colCheckbox"
        Me.colCheckbox.Width = 20
        '
        'colitcd
        '
        Me.colitcd.DataPropertyName = "itcd"
        Me.colitcd.HeaderText = "Item Code"
        Me.colitcd.Name = "colitcd"
        Me.colitcd.ReadOnly = True
        Me.colitcd.Width = 200
        '
        'colGrade
        '
        Me.colGrade.DataPropertyName = "grade"
        Me.colGrade.HeaderText = "Grade"
        Me.colGrade.MaxInputLength = 15
        Me.colGrade.Name = "colGrade"
        Me.colGrade.ReadOnly = True
        Me.colGrade.Width = 40
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.ReadOnly = True
        '
        'colBoxno
        '
        Me.colBoxno.DataPropertyName = "boxno"
        Me.colBoxno.HeaderText = "Internal box no."
        Me.colBoxno.MaxInputLength = 15
        Me.colBoxno.Name = "colBoxno"
        Me.colBoxno.ReadOnly = True
        '
        'colSpools
        '
        Me.colSpools.DataPropertyName = "spools"
        Me.colSpools.HeaderText = "Tube/ Spools"
        Me.colSpools.MaxInputLength = 15
        Me.colSpools.Name = "colSpools"
        Me.colSpools.Width = 50
        '
        'colKgGr
        '
        Me.colKgGr.DataPropertyName = "kg_gr"
        Me.colKgGr.HeaderText = "Gross box weight{Kg}"
        Me.colKgGr.MaxInputLength = 15
        Me.colKgGr.Name = "colKgGr"
        Me.colKgGr.Width = 80
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Width = 70
        '
        'colKgNt
        '
        Me.colKgNt.DataPropertyName = "kg_nt"
        Me.colKgNt.HeaderText = "Net Box weight{Kg}"
        Me.colKgNt.MaxInputLength = 15
        Me.colKgNt.Name = "colKgNt"
        Me.colKgNt.Width = 70
        '
        'colActualConeWeight
        '
        Me.colActualConeWeight.DataPropertyName = "actual_cone_weight"
        Me.colActualConeWeight.HeaderText = "Actual Cone Weight"
        Me.colActualConeWeight.Name = "colActualConeWeight"
        '
        'colidJobDetYarn
        '
        Me.colidJobDetYarn.DataPropertyName = "id_job_det_yarn"
        Me.colidJobDetYarn.HeaderText = "ID Job Det Yarn"
        Me.colidJobDetYarn.Name = "colidJobDetYarn"
        Me.colidJobDetYarn.ReadOnly = True
        Me.colidJobDetYarn.Visible = False
        '
        'colGb
        '
        Me.colGb.DataPropertyName = "gb"
        Me.colGb.HeaderText = "GB#"
        Me.colGb.Name = "colGb"
        Me.colGb.ReadOnly = True
        Me.colGb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colGb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colGb.Width = 80
        '
        'colMfgProductionOrderLineId
        '
        Me.colMfgProductionOrderLineId.DataPropertyName = "mfg_production_order_line_id"
        Me.colMfgProductionOrderLineId.HeaderText = "Prod Order Line ID"
        Me.colMfgProductionOrderLineId.Name = "colMfgProductionOrderLineId"
        Me.colMfgProductionOrderLineId.ReadOnly = True
        '
        'colKoNo
        '
        Me.colKoNo.DataPropertyName = "kono"
        Me.colKoNo.HeaderText = "K/O No."
        Me.colKoNo.Name = "colKoNo"
        Me.colKoNo.ReadOnly = True
        Me.colKoNo.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 509)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Remark :"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(75, 506)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(445, 109)
        Me.txtRemark.TabIndex = 141
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
        Me.GroupBox4.Location = New System.Drawing.Point(649, 509)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(404, 42)
        Me.GroupBox4.TabIndex = 137
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Quantity"
        '
        'txttotalnet
        '
        Me.txttotalnet.Location = New System.Drawing.Point(336, 16)
        Me.txttotalnet.Name = "txttotalnet"
        Me.txttotalnet.Size = New System.Drawing.Size(60, 20)
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
        Me.Label23.Location = New System.Drawing.Point(271, 19)
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
        Me.txttotalgross.Location = New System.Drawing.Point(203, 16)
        Me.txttotalgross.Name = "txttotalgross"
        Me.txttotalgross.Size = New System.Drawing.Size(67, 20)
        Me.txttotalgross.TabIndex = 79
        '
        'txttotalboxes
        '
        Me.txttotalboxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotalboxes.Location = New System.Drawing.Point(67, 16)
        Me.txttotalboxes.Name = "txttotalboxes"
        Me.txttotalboxes.Size = New System.Drawing.Size(57, 20)
        Me.txttotalboxes.TabIndex = 77
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(132, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Gross wt (kg):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(22, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Boxes:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNew.Location = New System.Drawing.Point(797, 579)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(57, 36)
        Me.btnNew.TabIndex = 143
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(985, 579)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 36)
        Me.Button3.TabIndex = 140
        Me.Button3.Text = "Exit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnPrintYarnout
        '
        Me.btnPrintYarnout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintYarnout.Image = CType(resources.GetObject("btnPrintYarnout.Image"), System.Drawing.Image)
        Me.btnPrintYarnout.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintYarnout.Location = New System.Drawing.Point(923, 579)
        Me.btnPrintYarnout.Name = "btnPrintYarnout"
        Me.btnPrintYarnout.Size = New System.Drawing.Size(57, 36)
        Me.btnPrintYarnout.TabIndex = 139
        Me.btnPrintYarnout.Text = "Print"
        Me.btnPrintYarnout.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnPrintYarnout.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(860, 579)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(57, 36)
        Me.BtnSave.TabIndex = 138
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.YarnStockSystem.My.Resources.Resources.SelectNoItems_16x
        Me.Button5.Location = New System.Drawing.Point(1030, 114)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 23)
        Me.Button5.TabIndex = 130
        Me.Button5.Text = "Clear All Item"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'butSelectAll
        '
        Me.butSelectAll.Image = Global.YarnStockSystem.My.Resources.Resources.SelectAllItems_16x
        Me.butSelectAll.Location = New System.Drawing.Point(1000, 114)
        Me.butSelectAll.Name = "butSelectAll"
        Me.butSelectAll.Size = New System.Drawing.Size(24, 23)
        Me.butSelectAll.TabIndex = 129
        Me.butSelectAll.UseVisualStyleBackColor = True
        '
        'formYarnout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 643)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPrintYarnout)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtsupplier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.butSelectAll)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.CbTrantype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgYarnOut)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formYarnout"
        Me.Text = "Yarn Out New"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DgYarnOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtYOUT As System.Windows.Forms.TextBox
    Friend WithEvents Datetime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents butSelectAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textYarnInNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtJobNo As System.Windows.Forms.TextBox
    Friend WithEvents lblYINno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CbTrantype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgYarnOut As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnPrintYarnout As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txttotalnet As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txttotalgross As System.Windows.Forms.TextBox
    Friend WithEvents txttotalboxes As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents colCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents colitcd As DataGridViewComboBoxColumn
    Friend WithEvents colGrade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents colBoxno As DataGridViewTextBoxColumn
    Friend WithEvents colSpools As DataGridViewTextBoxColumn
    Friend WithEvents colKgGr As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents colKgNt As DataGridViewTextBoxColumn
    Friend WithEvents colActualConeWeight As DataGridViewTextBoxColumn
    Friend WithEvents colidJobDetYarn As DataGridViewTextBoxColumn
    Friend WithEvents colGb As DataGridViewTextBoxColumn
    Friend WithEvents colMfgProductionOrderLineId As DataGridViewTextBoxColumn
    Friend WithEvents colKoNo As DataGridViewTextBoxColumn
End Class
