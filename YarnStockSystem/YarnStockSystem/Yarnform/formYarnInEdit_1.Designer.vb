<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnInEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnInEdit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpdocdt = New System.Windows.Forms.DateTimePicker()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.BtnYarnExit = New System.Windows.Forms.Button()
        Me.BtnYarnPrintDoc = New System.Windows.Forms.Button()
        Me.BtnYarnEdit_and_Save = New System.Windows.Forms.Button()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.txtSupDt = New System.Windows.Forms.TextBox()
        Me.CbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSupp = New System.Windows.Forms.TextBox()
        Me.txtSupRefno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupLot = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtremark = New System.Windows.Forms.TextBox()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txttotalnet = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.textTotaltubes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.txttotalgross = New System.Windows.Forms.TextBox()
        Me.txttotalboxes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DgYarn = New System.Windows.Forms.DataGridView()
        Me.DgYarnIDJobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboitcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgYarnGradeOur = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Docno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textStatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnApplyCurrentBox = New System.Windows.Forms.Button()
        Me.grdPO = New System.Windows.Forms.DataGridView()
        Me.grdPOIdJobDet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdPOitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdPOqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdPOdelidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnApplyAllBox = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtoutno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.dtpdocdt)
        Me.GroupBox5.Controls.Add(Me.Btnsearch)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtDocNo)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(782, 15)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(280, 85)
        Me.GroupBox5.TabIndex = 131
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'dtpdocdt
        '
        Me.dtpdocdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpdocdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdocdt.Location = New System.Drawing.Point(66, 53)
        Me.dtpdocdt.Name = "dtpdocdt"
        Me.dtpdocdt.Size = New System.Drawing.Size(136, 20)
        Me.dtpdocdt.TabIndex = 138
        '
        'Btnsearch
        '
        Me.Btnsearch.Image = CType(resources.GetObject("Btnsearch.Image"), System.Drawing.Image)
        Me.Btnsearch.Location = New System.Drawing.Point(203, 24)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(27, 23)
        Me.Btnsearch.TabIndex = 1
        Me.Btnsearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(66, 26)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(136, 20)
        Me.txtDocNo.TabIndex = 0
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
        'BtnYarnExit
        '
        Me.BtnYarnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnExit.Image = CType(resources.GetObject("BtnYarnExit.Image"), System.Drawing.Image)
        Me.BtnYarnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnExit.Location = New System.Drawing.Point(941, 600)
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
        Me.BtnYarnPrintDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnPrintDoc.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintDoc.Image = CType(resources.GetObject("BtnYarnPrintDoc.Image"), System.Drawing.Image)
        Me.BtnYarnPrintDoc.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnPrintDoc.Location = New System.Drawing.Point(761, 600)
        Me.BtnYarnPrintDoc.Name = "BtnYarnPrintDoc"
        Me.BtnYarnPrintDoc.Size = New System.Drawing.Size(54, 46)
        Me.BtnYarnPrintDoc.TabIndex = 128
        Me.BtnYarnPrintDoc.Text = "Print"
        Me.BtnYarnPrintDoc.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnYarnPrintDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnYarnPrintDoc.UseVisualStyleBackColor = False
        '
        'BtnYarnEdit_and_Save
        '
        Me.BtnYarnEdit_and_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnEdit_and_Save.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnEdit_and_Save.Image = CType(resources.GetObject("BtnYarnEdit_and_Save.Image"), System.Drawing.Image)
        Me.BtnYarnEdit_and_Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnEdit_and_Save.Location = New System.Drawing.Point(701, 600)
        Me.BtnYarnEdit_and_Save.Name = "BtnYarnEdit_and_Save"
        Me.BtnYarnEdit_and_Save.Size = New System.Drawing.Size(54, 46)
        Me.BtnYarnEdit_and_Save.TabIndex = 127
        Me.BtnYarnEdit_and_Save.Text = "Save"
        Me.BtnYarnEdit_and_Save.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnYarnEdit_and_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnYarnEdit_and_Save.UseVisualStyleBackColor = False
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnPrintBar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnYarnPrintBar.Image = CType(resources.GetObject("BtnYarnPrintBar.Image"), System.Drawing.Image)
        Me.BtnYarnPrintBar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(821, 600)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(54, 46)
        Me.BtnYarnPrintBar.TabIndex = 132
        Me.BtnYarnPrintBar.Text = "Print bar"
        Me.BtnYarnPrintBar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnYarnPrintBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancel.Location = New System.Drawing.Point(881, 600)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(54, 46)
        Me.btnCancel.TabIndex = 136
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.txtSupDt)
        Me.GroupBox1.Controls.Add(Me.CbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSupp)
        Me.GroupBox1.Controls.Add(Me.txtSupRefno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSupLot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 141)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "P/O Detail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "P/O No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(68, 29)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(116, 20)
        Me.txtPONo.TabIndex = 101
        '
        'txtSupDt
        '
        Me.txtSupDt.Location = New System.Drawing.Point(68, 113)
        Me.txtSupDt.Name = "txtSupDt"
        Me.txtSupDt.Size = New System.Drawing.Size(97, 20)
        Me.txtSupDt.TabIndex = 1
        '
        'CbSupplier
        '
        Me.CbSupplier.DisplayMember = "name"
        Me.CbSupplier.FormattingEnabled = True
        Me.CbSupplier.Location = New System.Drawing.Point(68, 56)
        Me.CbSupplier.Name = "CbSupplier"
        Me.CbSupplier.Size = New System.Drawing.Size(219, 21)
        Me.CbSupplier.TabIndex = 1
        Me.CbSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Dt:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtSupp
        '
        Me.txtSupp.Location = New System.Drawing.Point(69, 85)
        Me.txtSupp.Name = "txtSupp"
        Me.txtSupp.Size = New System.Drawing.Size(96, 20)
        Me.txtSupp.TabIndex = 0
        '
        'txtSupRefno
        '
        Me.txtSupRefno.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSupRefno.Location = New System.Drawing.Point(229, 112)
        Me.txtSupRefno.Name = "txtSupRefno"
        Me.txtSupRefno.Size = New System.Drawing.Size(96, 21)
        Me.txtSupRefno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'txtSupLot
        '
        Me.txtSupLot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSupLot.Location = New System.Drawing.Point(229, 84)
        Me.txtSupLot.Name = "txtSupLot"
        Me.txtSupLot.Size = New System.Drawing.Size(96, 21)
        Me.txtSupLot.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtremark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 539)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(462, 111)
        Me.GroupBox3.TabIndex = 140
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'txtremark
        '
        Me.txtremark.Location = New System.Drawing.Point(17, 15)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(424, 87)
        Me.txtremark.TabIndex = 104
        '
        'txtitcd
        '
        Me.txtitcd.Location = New System.Drawing.Point(17, 34)
        Me.txtitcd.Name = "txtitcd"
        Me.txtitcd.Size = New System.Drawing.Size(100, 20)
        Me.txtitcd.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txttotalnet)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.textTotaltubes)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgYarn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgYarn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgYarn.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DgYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgYarnIDJobdet, Me.colItcd, Me.cboitcd, Me.cart_tearwt, Me.DgYarnGradeOur, Me.Grade, Me.boxno_s, Me.boxno, Me.spools, Me.kg_gr, Me.kg_gr2, Me.kg_nt, Me.actual_cone_weight, Me.Docno, Me.lotno_our})
        Me.DgYarn.Location = New System.Drawing.Point(5, 218)
        Me.DgYarn.Name = "DgYarn"
        Me.DgYarn.Size = New System.Drawing.Size(1057, 315)
        Me.DgYarn.TabIndex = 141
        '
        'DgYarnIDJobdet
        '
        Me.DgYarnIDJobdet.DataPropertyName = "id_jobdet"
        Me.DgYarnIDJobdet.HeaderText = "P/O Line ID"
        Me.DgYarnIDJobdet.Name = "DgYarnIDJobdet"
        Me.DgYarnIDJobdet.Width = 60
        '
        'colItcd
        '
        Me.colItcd.DataPropertyName = "itcd"
        Me.colItcd.HeaderText = "Item code"
        Me.colItcd.Name = "colItcd"
        '
        'cboitcd
        '
        Me.cboitcd.DataPropertyName = "itcd"
        Me.cboitcd.HeaderText = "Description"
        Me.cboitcd.Name = "cboitcd"
        Me.cboitcd.Width = 250
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "itcd"
        Me.cart_tearwt.HeaderText = "Description"
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Visible = False
        '
        'DgYarnGradeOur
        '
        Me.DgYarnGradeOur.DataPropertyName = "grade_our"
        Me.DgYarnGradeOur.HeaderText = "Grade Our"
        Me.DgYarnGradeOur.Name = "DgYarnGradeOur"
        Me.DgYarnGradeOur.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgYarnGradeOur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MaxInputLength = 15
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 60
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.MaxInputLength = 17
        Me.boxno_s.Name = "boxno_s"
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no."
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube/Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 75
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross box weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 75
        '
        'kg_gr2
        '
        Me.kg_gr2.HeaderText = "Box Tear Weight{Kg}"
        Me.kg_gr2.MaxInputLength = 15
        Me.kg_gr2.Name = "kg_gr2"
        Me.kg_gr2.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net Box weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kg_nt.Width = 75
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight{Kg}"
        Me.actual_cone_weight.Name = "actual_cone_weight"
        Me.actual_cone_weight.Width = 70
        '
        'Docno
        '
        Me.Docno.DataPropertyName = "docno"
        Me.Docno.HeaderText = "Docno"
        Me.Docno.Name = "Docno"
        Me.Docno.Visible = False
        '
        'lotno_our
        '
        Me.lotno_our.DataPropertyName = "lotno_our"
        Me.lotno_our.HeaderText = "Batch no."
        Me.lotno_our.Name = "lotno_our"
        '
        'textStatus
        '
        Me.textStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textStatus.Location = New System.Drawing.Point(881, 543)
        Me.textStatus.Name = "textStatus"
        Me.textStatus.ReadOnly = True
        Me.textStatus.Size = New System.Drawing.Size(123, 20)
        Me.textStatus.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(832, 544)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Status:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(503, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 13)
        Me.Label10.TabIndex = 331
        Me.Label10.Text = "***Program Not Show P/O Closed"
        '
        'btnApplyCurrentBox
        '
        Me.btnApplyCurrentBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyCurrentBox.Location = New System.Drawing.Point(531, 177)
        Me.btnApplyCurrentBox.Name = "btnApplyCurrentBox"
        Me.btnApplyCurrentBox.Size = New System.Drawing.Size(79, 35)
        Me.btnApplyCurrentBox.TabIndex = 330
        Me.btnApplyCurrentBox.Text = "Apply Current Box"
        Me.btnApplyCurrentBox.UseVisualStyleBackColor = True
        '
        'grdPO
        '
        Me.grdPO.AllowUserToAddRows = False
        Me.grdPO.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdPO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPO.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdPOIdJobDet, Me.grdPOitcd, Me.grdPOqty, Me.grdPOdelidt})
        Me.grdPO.Location = New System.Drawing.Point(349, 30)
        Me.grdPO.Name = "grdPO"
        Me.grdPO.Size = New System.Drawing.Size(350, 142)
        Me.grdPO.TabIndex = 329
        '
        'grdPOIdJobDet
        '
        Me.grdPOIdJobDet.DataPropertyName = "id_jobdet"
        Me.grdPOIdJobDet.HeaderText = "P/O Line ID"
        Me.grdPOIdJobDet.Name = "grdPOIdJobDet"
        Me.grdPOIdJobDet.ReadOnly = True
        Me.grdPOIdJobDet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPOIdJobDet.Width = 60
        '
        'grdPOitcd
        '
        Me.grdPOitcd.DataPropertyName = "itcd"
        Me.grdPOitcd.HeaderText = "Item Code"
        Me.grdPOitcd.Name = "grdPOitcd"
        Me.grdPOitcd.ReadOnly = True
        Me.grdPOitcd.Width = 70
        '
        'grdPOqty
        '
        Me.grdPOqty.DataPropertyName = "qty"
        Me.grdPOqty.HeaderText = "Qty."
        Me.grdPOqty.Name = "grdPOqty"
        Me.grdPOqty.ReadOnly = True
        Me.grdPOqty.Width = 80
        '
        'grdPOdelidt
        '
        Me.grdPOdelidt.DataPropertyName = "delidt"
        Me.grdPOdelidt.HeaderText = "Delivery"
        Me.grdPOdelidt.Name = "grdPOdelidt"
        Me.grdPOdelidt.ReadOnly = True
        '
        'btnApplyAllBox
        '
        Me.btnApplyAllBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAllBox.Location = New System.Drawing.Point(626, 177)
        Me.btnApplyAllBox.Name = "btnApplyAllBox"
        Me.btnApplyAllBox.Size = New System.Drawing.Size(73, 35)
        Me.btnApplyAllBox.TabIndex = 328
        Me.btnApplyAllBox.Text = "Apply All Box"
        Me.btnApplyAllBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtoutno)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 57)
        Me.GroupBox2.TabIndex = 332
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Y Out Detail"
        '
        'txtoutno
        '
        Me.txtoutno.Enabled = False
        Me.txtoutno.Location = New System.Drawing.Point(80, 24)
        Me.txtoutno.Name = "txtoutno"
        Me.txtoutno.Size = New System.Drawing.Size(115, 20)
        Me.txtoutno.TabIndex = 121
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(85, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 83
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Y-Out no.:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 77
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-158, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Boxes:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(82, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 335
        Me.Label9.Text = "***Enter P/O no."
        '
        'formYarnInEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 669)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnApplyCurrentBox)
        Me.Controls.Add(Me.grdPO)
        Me.Controls.Add(Me.btnApplyAllBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textStatus)
        Me.Controls.Add(Me.DgYarn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnYarnExit)
        Me.Controls.Add(Me.BtnYarnPrintDoc)
        Me.Controls.Add(Me.BtnYarnEdit_and_Save)
        Me.Controls.Add(Me.BtnYarnPrintBar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "formYarnInEdit"
        Me.Text = "Edit Yarn In"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
	Friend WithEvents BtnYarnExit As System.Windows.Forms.Button
	Friend WithEvents BtnYarnPrintDoc As System.Windows.Forms.Button
	Friend WithEvents BtnYarnEdit_and_Save As System.Windows.Forms.Button
	Friend WithEvents BtnYarnPrintBar As System.Windows.Forms.Button
	Friend WithEvents Btnsearch As System.Windows.Forms.Button
	Friend WithEvents txtDocNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtPONo As System.Windows.Forms.TextBox
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
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents txtremark As System.Windows.Forms.TextBox
	Friend WithEvents txtitcd As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents txttotalnet As System.Windows.Forms.TextBox
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents textTotaltubes As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents txttotalgross As System.Windows.Forms.TextBox
    Friend WithEvents txttotalboxes As System.Windows.Forms.TextBox
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents DgYarn As System.Windows.Forms.DataGridView
    Friend WithEvents textStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpdocdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnApplyCurrentBox As Button
    Friend WithEvents grdPO As DataGridView
    Friend WithEvents btnApplyAllBox As Button
    Friend WithEvents DgYarnIDJobdet As DataGridViewTextBoxColumn
    Friend WithEvents colItcd As DataGridViewTextBoxColumn
    Friend WithEvents cboitcd As DataGridViewComboBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents DgYarnGradeOur As DataGridViewComboBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr2 As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As DataGridViewTextBoxColumn
    Friend WithEvents Docno As DataGridViewTextBoxColumn
    Friend WithEvents lotno_our As DataGridViewTextBoxColumn
    Friend WithEvents grdPOIdJobDet As DataGridViewTextBoxColumn
    Friend WithEvents grdPOitcd As DataGridViewTextBoxColumn
    Friend WithEvents grdPOqty As DataGridViewTextBoxColumn
    Friend WithEvents grdPOdelidt As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtoutno As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
End Class
