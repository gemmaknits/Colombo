<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGReturn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboGinNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btncopy = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpGINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtGinno = New System.Windows.Forms.TextBox()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblGOutNo = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpoutdt = New System.Windows.Forms.DateTimePicker()
        Me.lblsource_refno = New System.Windows.Forms.Label()
        Me.txtsource_refno = New System.Windows.Forms.TextBox()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preseted = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_adt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_bdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source_refno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mcno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_greige_do = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selected, Me.Design_no, Me.roll_no_g, Me.preseted, Me.roll_no, Me.roll_no_o, Me.col, Me.grade_adt, Me.grade_bdt, Me.grade, Me.Lot, Me.gwth, Me.kg, Me.mts, Me.yds, Me.rem_qc, Me.roll_no_f, Me.source_refno, Me.sono, Me.sonoid, Me.suppcd, Me.dfno, Me.mcno, Me.kono, Me.id_greige_do})
        Me.grdData.Location = New System.Drawing.Point(17, 138)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(1024, 254)
        Me.grdData.TabIndex = 291
        Me.grdData.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "Return Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Return No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGinNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btncopy, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 289
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "GIN No."
        '
        'cboGinNo
        '
        Me.cboGinNo.Name = "cboGinNo"
        Me.cboGinNo.Size = New System.Drawing.Size(100, 25)
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
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btncopy
        '
        Me.btncopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btncopy.Image = CType(resources.GetObject("btncopy.Image"), System.Drawing.Image)
        Me.btncopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncopy.Name = "btncopy"
        Me.btncopy.Size = New System.Drawing.Size(23, 22)
        Me.btncopy.Tag = "copy"
        Me.btncopy.Text = "copy"
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'dtpGINDate
        '
        Me.dtpGINDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGINDate.Location = New System.Drawing.Point(105, 47)
        Me.dtpGINDate.Name = "dtpGINDate"
        Me.dtpGINDate.Size = New System.Drawing.Size(127, 20)
        Me.dtpGINDate.TabIndex = 289
        '
        'txtGinno
        '
        Me.txtGinno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtGinno.Location = New System.Drawing.Point(105, 21)
        Me.txtGinno.Name = "txtGinno"
        Me.txtGinno.ReadOnly = True
        Me.txtGinno.Size = New System.Drawing.Size(127, 20)
        Me.txtGinno.TabIndex = 300
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(218, 19)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'lblGOutNo
        '
        Me.lblGOutNo.AutoSize = True
        Me.lblGOutNo.Location = New System.Drawing.Point(16, 29)
        Me.lblGOutNo.Name = "lblGOutNo"
        Me.lblGOutNo.Size = New System.Drawing.Size(58, 13)
        Me.lblGOutNo.TabIndex = 1
        Me.lblGOutNo.Text = "GOUT No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(80, 22)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.ReadOnly = True
        Me.txtOutNo.Size = New System.Drawing.Size(132, 20)
        Me.txtOutNo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpoutdt)
        Me.GroupBox1.Controls.Add(Me.lblsource_refno)
        Me.GroupBox1.Controls.Add(Me.txtsource_refno)
        Me.GroupBox1.Controls.Add(Me.chkAutoCalculate)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutNo)
        Me.GroupBox1.Controls.Add(Me.lblGOutNo)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 79)
        Me.GroupBox1.TabIndex = 290
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 304
        Me.Label1.Text = "OUT Dt."
        '
        'dtpoutdt
        '
        Me.dtpoutdt.Checked = False
        Me.dtpoutdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpoutdt.Location = New System.Drawing.Point(80, 53)
        Me.dtpoutdt.Name = "dtpoutdt"
        Me.dtpoutdt.ShowCheckBox = True
        Me.dtpoutdt.Size = New System.Drawing.Size(132, 20)
        Me.dtpoutdt.TabIndex = 302
        '
        'lblsource_refno
        '
        Me.lblsource_refno.AutoSize = True
        Me.lblsource_refno.Location = New System.Drawing.Point(272, 29)
        Me.lblsource_refno.Name = "lblsource_refno"
        Me.lblsource_refno.Size = New System.Drawing.Size(81, 13)
        Me.lblsource_refno.TabIndex = 301
        Me.lblsource_refno.Text = "Source Ref No."
        '
        'txtsource_refno
        '
        Me.txtsource_refno.Location = New System.Drawing.Point(359, 24)
        Me.txtsource_refno.Name = "txtsource_refno"
        Me.txtsource_refno.ReadOnly = True
        Me.txtsource_refno.Size = New System.Drawing.Size(100, 20)
        Me.txtsource_refno.TabIndex = 300
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Location = New System.Drawing.Point(645, 24)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(104, 32)
        Me.chkAutoCalculate.TabIndex = 292
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(129, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 296
        Me.Label15.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Location = New System.Drawing.Point(25, 43)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedKgs.TabIndex = 295
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(129, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 294
        Me.Label17.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Location = New System.Drawing.Point(25, 19)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedRolls.TabIndex = 292
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(129, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Location = New System.Drawing.Point(25, 91)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedMts.TabIndex = 299
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(129, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 298
        Me.Label13.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Location = New System.Drawing.Point(25, 67)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedYds.TabIndex = 297
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtSelectedKgs)
        Me.GroupBox2.Controls.Add(Me.txtSelectedYds)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtSelectedRolls)
        Me.GroupBox2.Controls.Add(Me.txtSelectedMts)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(870, 411)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 127)
        Me.GroupBox2.TabIndex = 301
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtGinno)
        Me.GroupBox3.Controls.Add(Me.dtpGINDate)
        Me.GroupBox3.Location = New System.Drawing.Point(782, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 79)
        Me.GroupBox3.TabIndex = 302
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(785, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 13)
        Me.Label4.TabIndex = 303
        Me.Label4.Text = "Only 1 Greige IN Return / 1 Greige Out"
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.selected.Width = 50
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No. (Greige)"
        Me.roll_no_g.Name = "roll_no_g"
        '
        'preseted
        '
        Me.preseted.DataPropertyName = "preseted"
        Me.preseted.HeaderText = "Preseted"
        Me.preseted.Name = "preseted"
        Me.preseted.ReadOnly = True
        Me.preseted.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.preseted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.preseted.Width = 50
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Width = 50
        '
        'grade_adt
        '
        Me.grade_adt.DataPropertyName = "grade_adt"
        Me.grade_adt.HeaderText = "Grade (After Dye Test)"
        Me.grade_adt.Name = "grade_adt"
        '
        'grade_bdt
        '
        Me.grade_bdt.DataPropertyName = "grade_bdt"
        Me.grade_bdt.HeaderText = "Grade (Before Dye Test)"
        Me.grade_bdt.Name = "grade_bdt"
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.Width = 40
        '
        'Lot
        '
        Me.Lot.DataPropertyName = "Lot"
        Me.Lot.HeaderText = "Lot"
        Me.Lot.Name = "Lot"
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.Width = 40
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        DataGridViewCellStyle1.Format = "N2"
        Me.kg.DefaultCellStyle = DataGridViewCellStyle1
        Me.kg.HeaderText = "Kg."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        DataGridViewCellStyle2.Format = "N2"
        Me.mts.DefaultCellStyle = DataGridViewCellStyle2
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        DataGridViewCellStyle3.Format = "N2"
        Me.yds.DefaultCellStyle = DataGridViewCellStyle3
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Remark QC"
        Me.rem_qc.Name = "rem_qc"
        '
        'roll_no_f
        '
        Me.roll_no_f.DataPropertyName = "roll_no_f"
        Me.roll_no_f.HeaderText = "roll_no_f(Don't Show)"
        Me.roll_no_f.Name = "roll_no_f"
        Me.roll_no_f.Visible = False
        '
        'source_refno
        '
        Me.source_refno.DataPropertyName = "source_refno"
        Me.source_refno.HeaderText = "source_refno(Don't Show)"
        Me.source_refno.Name = "source_refno"
        Me.source_refno.Visible = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "sono(Don't Show)"
        Me.sono.Name = "sono"
        Me.sono.Visible = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "sonoid(Don't Show)"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Visible = False
        '
        'suppcd
        '
        Me.suppcd.DataPropertyName = "suppcd"
        Me.suppcd.HeaderText = "suppcd(Don't Show)"
        Me.suppcd.Name = "suppcd"
        Me.suppcd.Visible = False
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "dfno(Don't Show)"
        Me.dfno.Name = "dfno"
        Me.dfno.Visible = False
        '
        'mcno
        '
        Me.mcno.DataPropertyName = "mcno"
        Me.mcno.HeaderText = "mcno(Don't Show)"
        Me.mcno.Name = "mcno"
        Me.mcno.Visible = False
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        Me.kono.HeaderText = "kono(Don't Show)"
        Me.kono.Name = "kono"
        Me.kono.Visible = False
        '
        'id_greige_do
        '
        Me.id_greige_do.DataPropertyName = "id_greige_do"
        Me.id_greige_do.HeaderText = "ID Greige Out"
        Me.id_greige_do.Name = "id_greige_do"
        Me.id_greige_do.Visible = False
        '
        'frmStockGReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 542)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockGReturn"
        Me.Text = "Stock G Return Manual(Good)"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboGinNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btncopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpGINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGinno As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblGOutNo As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsource_refno As System.Windows.Forms.TextBox
    Friend WithEvents lblsource_refno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpoutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents selected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preseted As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents roll_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade_adt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade_bdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_f As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents source_refno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suppcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dfno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mcno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_greige_do As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
