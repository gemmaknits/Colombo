<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnIn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txttotalgross = New System.Windows.Forms.TextBox()
        Me.txttotalboxes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupDt = New System.Windows.Forms.TextBox()
        Me.CbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSupLot = New System.Windows.Forms.TextBox()
        Me.txtSRefno = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DateYIN = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.BtnYarnExit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotalnet = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.textTotaltubes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnYarnPrintDoc = New System.Windows.Forms.Button()
        Me.BtnYarnSave = New System.Windows.Forms.Button()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.DgYarn = New System.Windows.Forms.DataGridView()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboitcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.collocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtremark = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Y-IN No.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.TextBox24.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-158, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-158, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 78
        Me.Label21.Text = "Boxes:"
        '
        'txttotalgross
        '
        Me.txttotalgross.Location = New System.Drawing.Point(122, 57)
        Me.txttotalgross.Name = "txttotalgross"
        Me.txttotalgross.Size = New System.Drawing.Size(57, 20)
        Me.txttotalgross.TabIndex = 79
        '
        'txttotalboxes
        '
        Me.txttotalboxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttotalboxes.Location = New System.Drawing.Point(122, 11)
        Me.txttotalboxes.Name = "txttotalboxes"
        Me.txttotalboxes.Size = New System.Drawing.Size(57, 20)
        Me.txttotalboxes.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(44, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Gross wt (kg):"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(44, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Boxes:"
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintBar.Image = CType(resources.GetObject("BtnYarnPrintBar.Image"), System.Drawing.Image)
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(784, 592)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(60, 44)
        Me.BtnYarnPrintBar.TabIndex = 5
        Me.BtnYarnPrintBar.Text = "Print bar label"
        Me.BtnYarnPrintBar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnPrintBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSupDt)
        Me.GroupBox1.Controls.Add(Me.CbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSupp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSupLot)
        Me.GroupBox1.Controls.Add(Me.txtSRefno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(272, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 107)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier details:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'txtSupDt
        '
        Me.txtSupDt.Location = New System.Drawing.Point(98, 80)
        Me.txtSupDt.Name = "txtSupDt"
        Me.txtSupDt.Size = New System.Drawing.Size(100, 20)
        Me.txtSupDt.TabIndex = 3
        '
        'CbSupplier
        '
        Me.CbSupplier.DisplayMember = "name"
        Me.CbSupplier.FormattingEnabled = True
        Me.CbSupplier.Location = New System.Drawing.Point(99, 25)
        Me.CbSupplier.Name = "CbSupplier"
        Me.CbSupplier.Size = New System.Drawing.Size(225, 21)
        Me.CbSupplier.TabIndex = 0
        Me.CbSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Dt:"
        '
        'txtSupp
        '
        Me.txtSupp.Location = New System.Drawing.Point(99, 52)
        Me.txtSupp.Name = "txtSupp"
        Me.txtSupp.Size = New System.Drawing.Size(100, 20)
        Me.txtSupp.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtSupLot
        '
        Me.txtSupLot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSupLot.Location = New System.Drawing.Point(269, 52)
        Me.txtSupLot.Name = "txtSupLot"
        Me.txtSupLot.Size = New System.Drawing.Size(100, 21)
        Me.txtSupLot.TabIndex = 2
        '
        'txtSRefno
        '
        Me.txtSRefno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRefno.Location = New System.Drawing.Point(269, 80)
        Me.txtSRefno.Name = "txtSRefno"
        Me.txtSRefno.Size = New System.Drawing.Size(121, 21)
        Me.txtSRefno.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateYIN)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(704, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(209, 85)
        Me.GroupBox5.TabIndex = 111
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'DateYIN
        '
        Me.DateYIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateYIN.Location = New System.Drawing.Point(88, 47)
        Me.DateYIN.Name = "DateYIN"
        Me.DateYIN.Size = New System.Drawing.Size(115, 20)
        Me.DateYIN.TabIndex = 119
        '
        'lblYINno
        '
        Me.lblYINno.AutoSize = True
        Me.lblYINno.Location = New System.Drawing.Point(85, 20)
        Me.lblYINno.Name = "lblYINno"
        Me.lblYINno.Size = New System.Drawing.Size(0, 13)
        Me.lblYINno.TabIndex = 83
        '
        'BtnYarnExit
        '
        Me.BtnYarnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnExit.Image = CType(resources.GetObject("BtnYarnExit.Image"), System.Drawing.Image)
        Me.BtnYarnExit.Location = New System.Drawing.Point(848, 592)
        Me.BtnYarnExit.Name = "BtnYarnExit"
        Me.BtnYarnExit.Size = New System.Drawing.Size(60, 44)
        Me.BtnYarnExit.TabIndex = 6
        Me.BtnYarnExit.Text = "Exit"
        Me.BtnYarnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnYarnExit.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txttotalnet)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.textTotaltubes)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txttotalgross)
        Me.GroupBox4.Controls.Add(Me.txttotalboxes)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(480, 536)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(206, 107)
        Me.GroupBox4.TabIndex = 110
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Quantity"
        '
        'txttotalnet
        '
        Me.txttotalnet.Location = New System.Drawing.Point(122, 80)
        Me.txttotalnet.Name = "txttotalnet"
        Me.txttotalnet.Size = New System.Drawing.Size(57, 20)
        Me.txttotalnet.TabIndex = 85
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(44, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Net wt (kg):"
        '
        'textTotaltubes
        '
        Me.textTotaltubes.Location = New System.Drawing.Point(122, 34)
        Me.textTotaltubes.Name = "textTotaltubes"
        Me.textTotaltubes.Size = New System.Drawing.Size(57, 20)
        Me.textTotaltubes.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Tubes:"
        '
        'BtnYarnPrintDoc
        '
        Me.BtnYarnPrintDoc.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintDoc.Image = CType(resources.GetObject("BtnYarnPrintDoc.Image"), System.Drawing.Image)
        Me.BtnYarnPrintDoc.Location = New System.Drawing.Point(720, 592)
        Me.BtnYarnPrintDoc.Name = "BtnYarnPrintDoc"
        Me.BtnYarnPrintDoc.Size = New System.Drawing.Size(60, 44)
        Me.BtnYarnPrintDoc.TabIndex = 4
        Me.BtnYarnPrintDoc.Text = "Print"
        Me.BtnYarnPrintDoc.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnPrintDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnYarnPrintDoc.UseVisualStyleBackColor = False
        '
        'BtnYarnSave
        '
        Me.BtnYarnSave.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnSave.Image = CType(resources.GetObject("BtnYarnSave.Image"), System.Drawing.Image)
        Me.BtnYarnSave.Location = New System.Drawing.Point(848, 536)
        Me.BtnYarnSave.Name = "BtnYarnSave"
        Me.BtnYarnSave.Size = New System.Drawing.Size(60, 44)
        Me.BtnYarnSave.TabIndex = 2
        Me.BtnYarnSave.Text = "Save"
        Me.BtnYarnSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnYarnSave.UseVisualStyleBackColor = False
        '
        'txtitcd
        '
        Me.txtitcd.Location = New System.Drawing.Point(17, 34)
        Me.txtitcd.Name = "txtitcd"
        Me.txtitcd.Size = New System.Drawing.Size(100, 20)
        Me.txtitcd.TabIndex = 12
        '
        'DgYarn
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgYarn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgYarn.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DgYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItcd, Me.cboitcd, Me.Grade, Me.boxno_s, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt, Me.actual_cone_weight, Me.boxno, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.collocation})
        Me.DgYarn.Location = New System.Drawing.Point(8, 120)
        Me.DgYarn.Name = "DgYarn"
        Me.DgYarn.RowHeadersWidth = 25
        Me.DgYarn.Size = New System.Drawing.Size(904, 405)
        Me.DgYarn.TabIndex = 2
        '
        'colItcd
        '
        Me.colItcd.HeaderText = "Item code"
        Me.colItcd.Name = "colItcd"
        Me.colItcd.Width = 75
        '
        'cboitcd
        '
        Me.cboitcd.DataPropertyName = "itcd"
        Me.cboitcd.HeaderText = "Description"
        Me.cboitcd.Items.AddRange(New Object() {"rt"})
        Me.cboitcd.Name = "cboitcd"
        Me.cboitcd.Width = 200
        '
        'Grade
        '
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MaxInputLength = 15
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 30
        '
        'boxno_s
        '
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 15
        Me.boxno_s.Name = "boxno_s"
        '
        'spools
        '
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kg_nt.Width = 75
        '
        'cart_tearwt
        '
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Width = 75
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight{Kg}"
        Me.actual_cone_weight.Name = "actual_cone_weight"
        Me.actual_cone_weight.Width = 70
        '
        'boxno
        '
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 70
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "Subinventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Locations"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        '
        'collocation
        '
        Me.collocation.DataPropertyName = "loc"
        Me.collocation.HeaderText = "Location"
        Me.collocation.Name = "collocation"
        Me.collocation.Visible = False
        Me.collocation.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPO)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 57)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Job or P/o #:"
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(94, 26)
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(136, 20)
        Me.txtPO.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtremark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 528)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 112)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(16, 24)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(432, 81)
        Me.txtremark.TabIndex = 104
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(784, 536)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 44)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'formYarnIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 649)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DgYarn)
        Me.Controls.Add(Me.BtnYarnPrintBar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnYarnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnYarnPrintDoc)
        Me.Controls.Add(Me.BtnYarnSave)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formYarnIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Yarn-in"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents txttotalgross As System.Windows.Forms.TextBox
	Friend WithEvents txttotalboxes As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents BtnYarnPrintBar As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents txtSupDt As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtSupp As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtSupLot As System.Windows.Forms.TextBox
	Friend WithEvents txtSRefno As System.Windows.Forms.TextBox
	Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents BtnYarnExit As System.Windows.Forms.Button
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents BtnYarnPrintDoc As System.Windows.Forms.Button
	Friend WithEvents BtnYarnSave As System.Windows.Forms.Button
	Friend WithEvents CbSupplier As System.Windows.Forms.ComboBox
	Friend WithEvents lblYINno As System.Windows.Forms.Label
	Friend WithEvents DateYIN As System.Windows.Forms.DateTimePicker
	Friend WithEvents txtitcd As System.Windows.Forms.TextBox
	Friend WithEvents textTotaltubes As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents txttotalnet As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents DgYarn As System.Windows.Forms.DataGridView
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtPO As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents colItcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboitcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents collocation As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
