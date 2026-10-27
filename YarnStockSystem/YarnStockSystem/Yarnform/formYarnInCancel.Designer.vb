<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnInCancel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnInCancel))
		Me.Splitter1 = New System.Windows.Forms.Splitter
		Me.GroupBox5 = New System.Windows.Forms.GroupBox
		Me.Btnsearch = New System.Windows.Forms.Button
		Me.lbldate = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtyarnincode = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.TextBox24 = New System.Windows.Forms.TextBox
		Me.Label26 = New System.Windows.Forms.Label
		Me.BtnYarnExit = New System.Windows.Forms.Button
		Me.BtnYarnPrintDoc = New System.Windows.Forms.Button
		Me.btnCancel = New System.Windows.Forms.Button
		Me.GroupBox6 = New System.Windows.Forms.GroupBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.txtSupDt = New System.Windows.Forms.TextBox
		Me.CbSupplier = New System.Windows.Forms.ComboBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtSupp = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.txtSupLot = New System.Windows.Forms.TextBox
		Me.txtSupRefno = New System.Windows.Forms.TextBox
		Me.GroupBox4 = New System.Windows.Forms.GroupBox
		Me.txttotalnet = New System.Windows.Forms.TextBox
		Me.Label23 = New System.Windows.Forms.Label
		Me.textTotaltubes = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.TextBox18 = New System.Windows.Forms.TextBox
		Me.Label21 = New System.Windows.Forms.Label
		Me.txttotalgross = New System.Windows.Forms.TextBox
		Me.txttotalboxes = New System.Windows.Forms.TextBox
		Me.Label22 = New System.Windows.Forms.Label
		Me.Label24 = New System.Windows.Forms.Label
		Me.DgYarn = New System.Windows.Forms.DataGridView
		Me.cboitcd = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.kg_gr2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Docno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Splitter1
		'
		Me.Splitter1.Location = New System.Drawing.Point(0, 0)
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter1.Size = New System.Drawing.Size(3, 669)
		Me.Splitter1.TabIndex = 133
		Me.Splitter1.TabStop = False
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.Btnsearch)
		Me.GroupBox5.Controls.Add(Me.lbldate)
		Me.GroupBox5.Controls.Add(Me.Label2)
		Me.GroupBox5.Controls.Add(Me.txtyarnincode)
		Me.GroupBox5.Controls.Add(Me.Label1)
		Me.GroupBox5.Controls.Add(Me.TextBox24)
		Me.GroupBox5.Controls.Add(Me.Label26)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(425, 12)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(280, 85)
		Me.GroupBox5.TabIndex = 131
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Document"
		'
		'Btnsearch
		'
		Me.Btnsearch.Location = New System.Drawing.Point(208, 23)
		Me.Btnsearch.Name = "Btnsearch"
		Me.Btnsearch.Size = New System.Drawing.Size(58, 23)
		Me.Btnsearch.TabIndex = 1
		Me.Btnsearch.Text = "Search"
		Me.Btnsearch.UseVisualStyleBackColor = True
		'
		'lbldate
		'
		Me.lbldate.AutoSize = True
		Me.lbldate.Location = New System.Drawing.Point(57, 69)
		Me.lbldate.Name = "lbldate"
		Me.lbldate.Size = New System.Drawing.Size(0, 13)
		Me.lbldate.TabIndex = 136
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label2.Location = New System.Drawing.Point(8, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 13)
		Me.Label2.TabIndex = 82
		Me.Label2.Text = "Y-IN Date:"
		'
		'txtyarnincode
		'
		Me.txtyarnincode.Location = New System.Drawing.Point(66, 26)
		Me.txtyarnincode.Name = "txtyarnincode"
		Me.txtyarnincode.Size = New System.Drawing.Size(136, 20)
		Me.txtyarnincode.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 13)
		Me.Label1.TabIndex = 81
		Me.Label1.Text = "Y-IN No.:"
		'
		'TextBox24
		'
		Me.TextBox24.Location = New System.Drawing.Point(-113, 44)
		Me.TextBox24.Name = "TextBox24"
		Me.TextBox24.Size = New System.Drawing.Size(100, 20)
		Me.TextBox24.TabIndex = 77
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(-158, 47)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(45, 13)
		Me.Label26.TabIndex = 78
		Me.Label26.Text = "Boxes:"
		'
		'BtnYarnExit
		'
		Me.BtnYarnExit.BackColor = System.Drawing.Color.PeachPuff
		Me.BtnYarnExit.Image = CType(resources.GetObject("BtnYarnExit.Image"), System.Drawing.Image)
		Me.BtnYarnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.BtnYarnExit.Location = New System.Drawing.Point(939, 551)
		Me.BtnYarnExit.Name = "BtnYarnExit"
		Me.BtnYarnExit.Size = New System.Drawing.Size(54, 46)
		Me.BtnYarnExit.TabIndex = 129
		Me.BtnYarnExit.Text = "Exit"
		Me.BtnYarnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.BtnYarnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.BtnYarnExit.UseVisualStyleBackColor = False
		'
		'BtnYarnPrintDoc
		'
		Me.BtnYarnPrintDoc.BackColor = System.Drawing.Color.PeachPuff
		Me.BtnYarnPrintDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.BtnYarnPrintDoc.Image = CType(resources.GetObject("BtnYarnPrintDoc.Image"), System.Drawing.Image)
		Me.BtnYarnPrintDoc.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.BtnYarnPrintDoc.Location = New System.Drawing.Point(879, 551)
		Me.BtnYarnPrintDoc.Name = "BtnYarnPrintDoc"
		Me.BtnYarnPrintDoc.Size = New System.Drawing.Size(54, 46)
		Me.BtnYarnPrintDoc.TabIndex = 128
		Me.BtnYarnPrintDoc.Text = "Print"
		Me.BtnYarnPrintDoc.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.BtnYarnPrintDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.BtnYarnPrintDoc.UseVisualStyleBackColor = False
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.PeachPuff
		Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
		Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.btnCancel.Location = New System.Drawing.Point(819, 551)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(54, 46)
		Me.btnCancel.TabIndex = 136
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
		Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.Label6)
		Me.GroupBox6.Controls.Add(Me.Label5)
		Me.GroupBox6.Controls.Add(Me.txtSupDt)
		Me.GroupBox6.Controls.Add(Me.CbSupplier)
		Me.GroupBox6.Controls.Add(Me.Label4)
		Me.GroupBox6.Controls.Add(Me.txtSupp)
		Me.GroupBox6.Controls.Add(Me.Label3)
		Me.GroupBox6.Controls.Add(Me.Label11)
		Me.GroupBox6.Controls.Add(Me.txtSupLot)
		Me.GroupBox6.Controls.Add(Me.txtSupRefno)
		Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.GroupBox6.Location = New System.Drawing.Point(9, 12)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(410, 107)
		Me.GroupBox6.TabIndex = 137
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "Supplier details:"
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
		Me.txtSupDt.TabIndex = 1
		'
		'CbSupplier
		'
		Me.CbSupplier.DisplayMember = "name"
		Me.CbSupplier.FormattingEnabled = True
		Me.CbSupplier.Location = New System.Drawing.Point(99, 25)
		Me.CbSupplier.Name = "CbSupplier"
		Me.CbSupplier.Size = New System.Drawing.Size(225, 21)
		Me.CbSupplier.TabIndex = 1
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
		Me.txtSupp.TabIndex = 0
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
		Me.txtSupLot.Location = New System.Drawing.Point(269, 52)
		Me.txtSupLot.Name = "txtSupLot"
		Me.txtSupLot.Size = New System.Drawing.Size(100, 20)
		Me.txtSupLot.TabIndex = 2
		'
		'txtSupRefno
		'
		Me.txtSupRefno.Location = New System.Drawing.Point(269, 80)
		Me.txtSupRefno.Name = "txtSupRefno"
		Me.txtSupRefno.Size = New System.Drawing.Size(121, 20)
		Me.txtSupRefno.TabIndex = 4
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
		Me.GroupBox4.Location = New System.Drawing.Point(484, 543)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(196, 107)
		Me.GroupBox4.TabIndex = 139
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
		'TextBox18
		'
		Me.TextBox18.Location = New System.Drawing.Point(-113, 40)
		Me.TextBox18.Name = "TextBox18"
		Me.TextBox18.Size = New System.Drawing.Size(100, 20)
		Me.TextBox18.TabIndex = 77
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
		'DgYarn
		'
		Me.DgYarn.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.DgYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cboitcd, Me.cart_tearwt, Me.Grade, Me.boxno_s, Me.boxno, Me.spools, Me.kg_gr, Me.kg_gr2, Me.kg_nt, Me.Docno})
		Me.DgYarn.Location = New System.Drawing.Point(5, 128)
		Me.DgYarn.Name = "DgYarn"
		Me.DgYarn.Size = New System.Drawing.Size(999, 405)
		Me.DgYarn.TabIndex = 141
		'
		'cboitcd
		'
		Me.cboitcd.DataPropertyName = "itcd"
		Me.cboitcd.HeaderText = "Item Code"
		Me.cboitcd.Name = "cboitcd"
		Me.cboitcd.Width = 250
		'
		'cart_tearwt
		'
		Me.cart_tearwt.HeaderText = "Description"
		Me.cart_tearwt.Name = "cart_tearwt"
		Me.cart_tearwt.Visible = False
		'
		'Grade
		'
		Me.Grade.HeaderText = "Grade"
		Me.Grade.MaxInputLength = 15
		Me.Grade.Name = "Grade"
		Me.Grade.Width = 60
		'
		'boxno_s
		'
		Me.boxno_s.HeaderText = "Supplier Box no."
		Me.boxno_s.MaxInputLength = 15
		Me.boxno_s.Name = "boxno_s"
		'
		'boxno
		'
		Me.boxno.HeaderText = "Internal box no."
		Me.boxno.MaxInputLength = 15
		Me.boxno.Name = "boxno"
		Me.boxno.ReadOnly = True
		'
		'spools
		'
		Me.spools.HeaderText = "Tube/Spools"
		Me.spools.MaxInputLength = 15
		Me.spools.Name = "spools"
		'
		'kg_gr
		'
		Me.kg_gr.HeaderText = "Gross box weight{Kg}"
		Me.kg_gr.MaxInputLength = 15
		Me.kg_gr.Name = "kg_gr"
		'
		'kg_gr2
		'
		Me.kg_gr2.HeaderText = "Box Tear Weight{Kg}"
		Me.kg_gr2.MaxInputLength = 15
		Me.kg_gr2.Name = "kg_gr2"
		'
		'kg_nt
		'
		Me.kg_nt.HeaderText = "Net Box weight{Kg}"
		Me.kg_nt.MaxInputLength = 15
		Me.kg_nt.Name = "kg_nt"
		Me.kg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		'
		'Docno
		'
		Me.Docno.HeaderText = "Docno"
		Me.Docno.Name = "Docno"
		Me.Docno.Visible = False
		'
		'formYarnInCancel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1020, 669)
		Me.Controls.Add(Me.DgYarn)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox6)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.Splitter1)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.BtnYarnExit)
		Me.Controls.Add(Me.BtnYarnPrintDoc)
		Me.Name = "formYarnInCancel"
		Me.Text = "Cancel Yarn-in"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox6.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents BtnYarnExit As System.Windows.Forms.Button
	Friend WithEvents BtnYarnPrintDoc As System.Windows.Forms.Button
	Friend WithEvents Btnsearch As System.Windows.Forms.Button
	Friend WithEvents txtyarnincode As System.Windows.Forms.TextBox
	Friend WithEvents lbldate As System.Windows.Forms.Label
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents txtSupDt As System.Windows.Forms.TextBox
	Friend WithEvents CbSupplier As System.Windows.Forms.ComboBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtSupp As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents txtSupLot As System.Windows.Forms.TextBox
	Friend WithEvents txtSupRefno As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents txttotalnet As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents textTotaltubes As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents txttotalgross As System.Windows.Forms.TextBox
	Friend WithEvents txttotalboxes As System.Windows.Forms.TextBox
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents DgYarn As System.Windows.Forms.DataGridView
	Friend WithEvents cboitcd As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_gr2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Docno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
