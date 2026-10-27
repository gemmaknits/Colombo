<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_KOManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_KOManual))
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.cboGINNo = New System.Windows.Forms.ToolStripComboBox()
        Me.lbltran_no = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lbltran_dt = New System.Windows.Forms.Label()
        Me.dtptran_dt = New System.Windows.Forms.DateTimePicker()
        Me.txttran_no = New System.Windows.Forms.TextBox()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblkono = New System.Windows.Forms.Label()
        Me.txtkono = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblmcno = New System.Windows.Forms.Label()
        Me.txtmcno = New System.Windows.Forms.TextBox()
        Me.txtdesign_no = New System.Windows.Forms.TextBox()
        Me.lbldesign_no = New System.Windows.Forms.Label()
        Me.txtynchgcd = New System.Windows.Forms.TextBox()
        Me.lblynchgcd = New System.Windows.Forms.Label()
        Me.grdDefect = New System.Windows.Forms.DataGridView()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.lblroll_no = New System.Windows.Forms.Label()
        Me.txtroll_no_o = New System.Windows.Forms.TextBox()
        Me.lblroll_no_o = New System.Windows.Forms.Label()
        Me.txtmts = New System.Windows.Forms.TextBox()
        Me.lblmts = New System.Windows.Forms.Label()
        Me.txtkg = New System.Windows.Forms.TextBox()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.txtbar_weight = New System.Windows.Forms.TextBox()
        Me.lblbar_weight = New System.Windows.Forms.Label()
        Me.txtgwth = New System.Windows.Forms.TextBox()
        Me.lblgwth = New System.Windows.Forms.Label()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.txtgrade_bdt = New System.Windows.Forms.TextBox()
        Me.lblgrade_bdt = New System.Windows.Forms.Label()
        Me.txtgrade_adt = New System.Windows.Forms.TextBox()
        Me.lblgrade_adt = New System.Windows.Forms.Label()
        Me.lblcliped = New System.Windows.Forms.Label()
        Me.lblloc = New System.Windows.Forms.Label()
        Me.txtloc = New System.Windows.Forms.TextBox()
        Me.lblsub_location = New System.Windows.Forms.Label()
        Me.txtsub_location = New System.Windows.Forms.TextBox()
        Me.lblshift = New System.Windows.Forms.Label()
        Me.txtshift = New System.Windows.Forms.TextBox()
        Me.chkcliped = New System.Windows.Forms.CheckBox()
        Me.lblProdFinishDate = New System.Windows.Forms.Label()
        Me.lblProdFinishTime = New System.Windows.Forms.Label()
        Me.txtProdFinishTime = New System.Windows.Forms.TextBox()
        Me.lbldyeing_pass = New System.Windows.Forms.Label()
        Me.txtadjust_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbladjust_loss_kg = New System.Windows.Forms.Label()
        Me.lblqc_loss_kg = New System.Windows.Forms.Label()
        Me.txtqc_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyed_loss_kg = New System.Windows.Forms.Label()
        Me.txtdyed_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbllab_loss_kg = New System.Windows.Forms.Label()
        Me.txtlab_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldefect_loss_kg = New System.Windows.Forms.Label()
        Me.txtdefect_loss_kg = New System.Windows.Forms.TextBox()
        Me.lblrem_qc = New System.Windows.Forms.Label()
        Me.txtrem_qc = New System.Windows.Forms.TextBox()
        Me.chkdyeing_pass = New System.Windows.Forms.CheckBox()
        Me.dtpProdFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Defect_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'cboGINNo
        '
        Me.cboGINNo.Name = "cboGINNo"
        Me.cboGINNo.Size = New System.Drawing.Size(100, 25)
        '
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(782, 20)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(76, 13)
        Me.lbltran_no.TabIndex = 301
        Me.lbltran_no.Text = "Document No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboGINNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 295
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel1.Text = "Document No."
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
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(781, 46)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(82, 13)
        Me.lbltran_dt.TabIndex = 302
        Me.lbltran_dt.Text = "Document Date"
        '
        'dtptran_dt
        '
        Me.dtptran_dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptran_dt.Location = New System.Drawing.Point(886, 43)
        Me.dtptran_dt.Name = "dtptran_dt"
        Me.dtptran_dt.Size = New System.Drawing.Size(132, 20)
        Me.dtptran_dt.TabIndex = 289
        '
        'txttran_no
        '
        Me.txttran_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttran_no.Location = New System.Drawing.Point(886, 17)
        Me.txttran_no.Name = "txttran_no"
        Me.txttran_no.ReadOnly = True
        Me.txttran_no.Size = New System.Drawing.Size(132, 20)
        Me.txttran_no.TabIndex = 300
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(366, 14)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'lblkono
        '
        Me.lblkono.AutoSize = True
        Me.lblkono.Location = New System.Drawing.Point(16, 26)
        Me.lblkono.Name = "lblkono"
        Me.lblkono.Size = New System.Drawing.Size(47, 13)
        Me.lblkono.TabIndex = 1
        Me.lblkono.Text = "K/O No."
        '
        'txtkono
        '
        Me.txtkono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtkono.Location = New System.Drawing.Point(230, 17)
        Me.txtkono.Name = "txtkono"
        Me.txtkono.ReadOnly = True
        Me.txtkono.Size = New System.Drawing.Size(132, 20)
        Me.txtkono.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblmcno)
        Me.GroupBox1.Controls.Add(Me.txtmcno)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutNo)
        Me.GroupBox1.Controls.Add(Me.lblkono)
        Me.GroupBox1.Controls.Add(Me.lbltran_no)
        Me.GroupBox1.Controls.Add(Me.txtkono)
        Me.GroupBox1.Controls.Add(Me.txttran_no)
        Me.GroupBox1.Controls.Add(Me.lbltran_dt)
        Me.GroupBox1.Controls.Add(Me.txtdesign_no)
        Me.GroupBox1.Controls.Add(Me.lbldesign_no)
        Me.GroupBox1.Controls.Add(Me.dtptran_dt)
        Me.GroupBox1.Controls.Add(Me.txtynchgcd)
        Me.GroupBox1.Controls.Add(Me.lblynchgcd)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 79)
        Me.GroupBox1.TabIndex = 296
        Me.GroupBox1.TabStop = False
        '
        'lblmcno
        '
        Me.lblmcno.AutoSize = True
        Me.lblmcno.Location = New System.Drawing.Point(16, 56)
        Me.lblmcno.Name = "lblmcno"
        Me.lblmcno.Size = New System.Drawing.Size(48, 13)
        Me.lblmcno.TabIndex = 304
        Me.lblmcno.Text = "M/C No."
        '
        'txtmcno
        '
        Me.txtmcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmcno.Location = New System.Drawing.Point(230, 48)
        Me.txtmcno.Name = "txtmcno"
        Me.txtmcno.ReadOnly = True
        Me.txtmcno.Size = New System.Drawing.Size(132, 20)
        Me.txtmcno.TabIndex = 303
        '
        'txtdesign_no
        '
        Me.txtdesign_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtdesign_no.Location = New System.Drawing.Point(535, 16)
        Me.txtdesign_no.Name = "txtdesign_no"
        Me.txtdesign_no.ReadOnly = True
        Me.txtdesign_no.Size = New System.Drawing.Size(132, 20)
        Me.txtdesign_no.TabIndex = 305
        '
        'lbldesign_no
        '
        Me.lbldesign_no.AutoSize = True
        Me.lbldesign_no.Location = New System.Drawing.Point(456, 16)
        Me.lbldesign_no.Name = "lbldesign_no"
        Me.lbldesign_no.Size = New System.Drawing.Size(60, 13)
        Me.lbldesign_no.TabIndex = 306
        Me.lbldesign_no.Text = "Design No."
        '
        'txtynchgcd
        '
        Me.txtynchgcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtynchgcd.Location = New System.Drawing.Point(534, 48)
        Me.txtynchgcd.Name = "txtynchgcd"
        Me.txtynchgcd.ReadOnly = True
        Me.txtynchgcd.Size = New System.Drawing.Size(132, 20)
        Me.txtynchgcd.TabIndex = 307
        '
        'lblynchgcd
        '
        Me.lblynchgcd.AutoSize = True
        Me.lblynchgcd.Location = New System.Drawing.Point(462, 52)
        Me.lblynchgcd.Name = "lblynchgcd"
        Me.lblynchgcd.Size = New System.Drawing.Size(31, 13)
        Me.lblynchgcd.TabIndex = 308
        Me.lblynchgcd.Text = "BOM"
        '
        'grdDefect
        '
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.defect_code, Me.Defect_name, Me.defect_details, Me.stock_code})
        Me.grdDefect.Location = New System.Drawing.Point(418, 421)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(336, 150)
        Me.grdDefect.TabIndex = 298
        Me.grdDefect.TabStop = False
        '
        'txtroll_no
        '
        Me.txtroll_no.Location = New System.Drawing.Point(247, 148)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.ReadOnly = True
        Me.txtroll_no.Size = New System.Drawing.Size(132, 20)
        Me.txtroll_no.TabIndex = 309
        '
        'lblroll_no
        '
        Me.lblroll_no.AutoSize = True
        Me.lblroll_no.Location = New System.Drawing.Point(33, 151)
        Me.lblroll_no.Name = "lblroll_no"
        Me.lblroll_no.Size = New System.Drawing.Size(82, 13)
        Me.lblroll_no.TabIndex = 310
        Me.lblroll_no.Text = "System Roll No."
        '
        'txtroll_no_o
        '
        Me.txtroll_no_o.Location = New System.Drawing.Point(247, 175)
        Me.txtroll_no_o.Name = "txtroll_no_o"
        Me.txtroll_no_o.ReadOnly = True
        Me.txtroll_no_o.Size = New System.Drawing.Size(132, 20)
        Me.txtroll_no_o.TabIndex = 311
        '
        'lblroll_no_o
        '
        Me.lblroll_no_o.AutoSize = True
        Me.lblroll_no_o.Location = New System.Drawing.Point(33, 178)
        Me.lblroll_no_o.Name = "lblroll_no_o"
        Me.lblroll_no_o.Size = New System.Drawing.Size(83, 13)
        Me.lblroll_no_o.TabIndex = 312
        Me.lblroll_no_o.Text = "Factory Roll No."
        '
        'txtmts
        '
        Me.txtmts.Location = New System.Drawing.Point(247, 202)
        Me.txtmts.Name = "txtmts"
        Me.txtmts.Size = New System.Drawing.Size(132, 20)
        Me.txtmts.TabIndex = 313
        '
        'lblmts
        '
        Me.lblmts.AutoSize = True
        Me.lblmts.Location = New System.Drawing.Point(33, 206)
        Me.lblmts.Name = "lblmts"
        Me.lblmts.Size = New System.Drawing.Size(69, 13)
        Me.lblmts.TabIndex = 314
        Me.lblmts.Text = "Length (Mts.)"
        '
        'txtkg
        '
        Me.txtkg.Location = New System.Drawing.Point(247, 236)
        Me.txtkg.Name = "txtkg"
        Me.txtkg.Size = New System.Drawing.Size(132, 20)
        Me.txtkg.TabIndex = 318
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Location = New System.Drawing.Point(33, 239)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(71, 13)
        Me.lblkg.TabIndex = 317
        Me.lblkg.Text = "Weight (Kgs.)"
        '
        'txtbar_weight
        '
        Me.txtbar_weight.Location = New System.Drawing.Point(247, 271)
        Me.txtbar_weight.Name = "txtbar_weight"
        Me.txtbar_weight.Size = New System.Drawing.Size(132, 20)
        Me.txtbar_weight.TabIndex = 320
        '
        'lblbar_weight
        '
        Me.lblbar_weight.AutoSize = True
        Me.lblbar_weight.Location = New System.Drawing.Point(33, 274)
        Me.lblbar_weight.Name = "lblbar_weight"
        Me.lblbar_weight.Size = New System.Drawing.Size(157, 13)
        Me.lblbar_weight.TabIndex = 319
        Me.lblbar_weight.Text = "Bar Weight (Kgs.) (น้ำหนักแกน)"
        '
        'txtgwth
        '
        Me.txtgwth.Location = New System.Drawing.Point(247, 306)
        Me.txtgwth.Name = "txtgwth"
        Me.txtgwth.Size = New System.Drawing.Size(132, 20)
        Me.txtgwth.TabIndex = 322
        '
        'lblgwth
        '
        Me.lblgwth.AutoSize = True
        Me.lblgwth.Location = New System.Drawing.Point(33, 309)
        Me.lblgwth.Name = "lblgwth"
        Me.lblgwth.Size = New System.Drawing.Size(100, 13)
        Me.lblgwth.TabIndex = 321
        Me.lblgwth.Text = "Greige Width (cms.)"
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(247, 343)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(132, 20)
        Me.txtlot.TabIndex = 324
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Location = New System.Drawing.Point(33, 346)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(48, 13)
        Me.lbllot.TabIndex = 323
        Me.lbllot.Text = "Yarn Set"
        '
        'txtgrade_bdt
        '
        Me.txtgrade_bdt.Location = New System.Drawing.Point(247, 382)
        Me.txtgrade_bdt.Name = "txtgrade_bdt"
        Me.txtgrade_bdt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_bdt.TabIndex = 326
        '
        'lblgrade_bdt
        '
        Me.lblgrade_bdt.AutoSize = True
        Me.lblgrade_bdt.Location = New System.Drawing.Point(33, 385)
        Me.lblgrade_bdt.Name = "lblgrade_bdt"
        Me.lblgrade_bdt.Size = New System.Drawing.Size(186, 13)
        Me.lblgrade_bdt.TabIndex = 325
        Me.lblgrade_bdt.Text = "Grade of Inspection (Before Dye Test)"
        '
        'txtgrade_adt
        '
        Me.txtgrade_adt.Location = New System.Drawing.Point(247, 421)
        Me.txtgrade_adt.Name = "txtgrade_adt"
        Me.txtgrade_adt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_adt.TabIndex = 328
        '
        'lblgrade_adt
        '
        Me.lblgrade_adt.AutoSize = True
        Me.lblgrade_adt.Location = New System.Drawing.Point(33, 424)
        Me.lblgrade_adt.Name = "lblgrade_adt"
        Me.lblgrade_adt.Size = New System.Drawing.Size(171, 13)
        Me.lblgrade_adt.TabIndex = 327
        Me.lblgrade_adt.Text = "Grade of Dye Test (After Dye Test)"
        '
        'lblcliped
        '
        Me.lblcliped.AutoSize = True
        Me.lblcliped.Location = New System.Drawing.Point(33, 459)
        Me.lblcliped.Name = "lblcliped"
        Me.lblcliped.Size = New System.Drawing.Size(106, 13)
        Me.lblcliped.TabIndex = 329
        Me.lblcliped.Text = "Open Width ? (ผ่าถุง)"
        '
        'lblloc
        '
        Me.lblloc.AutoSize = True
        Me.lblloc.Location = New System.Drawing.Point(36, 491)
        Me.lblloc.Name = "lblloc"
        Me.lblloc.Size = New System.Drawing.Size(48, 13)
        Me.lblloc.TabIndex = 331
        Me.lblloc.Text = "Location"
        '
        'txtloc
        '
        Me.txtloc.Location = New System.Drawing.Point(247, 484)
        Me.txtloc.Name = "txtloc"
        Me.txtloc.Size = New System.Drawing.Size(132, 20)
        Me.txtloc.TabIndex = 332
        '
        'lblsub_location
        '
        Me.lblsub_location.AutoSize = True
        Me.lblsub_location.Location = New System.Drawing.Point(36, 524)
        Me.lblsub_location.Name = "lblsub_location"
        Me.lblsub_location.Size = New System.Drawing.Size(70, 13)
        Me.lblsub_location.TabIndex = 333
        Me.lblsub_location.Text = "Sub Location"
        '
        'txtsub_location
        '
        Me.txtsub_location.Location = New System.Drawing.Point(247, 518)
        Me.txtsub_location.Name = "txtsub_location"
        Me.txtsub_location.Size = New System.Drawing.Size(132, 20)
        Me.txtsub_location.TabIndex = 334
        '
        'lblshift
        '
        Me.lblshift.AutoSize = True
        Me.lblshift.Location = New System.Drawing.Point(37, 554)
        Me.lblshift.Name = "lblshift"
        Me.lblshift.Size = New System.Drawing.Size(28, 13)
        Me.lblshift.TabIndex = 335
        Me.lblshift.Text = "Shift"
        '
        'txtshift
        '
        Me.txtshift.Location = New System.Drawing.Point(247, 551)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.Size = New System.Drawing.Size(132, 20)
        Me.txtshift.TabIndex = 336
        '
        'chkcliped
        '
        Me.chkcliped.AutoSize = True
        Me.chkcliped.Location = New System.Drawing.Point(247, 459)
        Me.chkcliped.Name = "chkcliped"
        Me.chkcliped.Size = New System.Drawing.Size(15, 14)
        Me.chkcliped.TabIndex = 337
        Me.chkcliped.UseVisualStyleBackColor = True
        '
        'lblProdFinishDate
        '
        Me.lblProdFinishDate.AutoSize = True
        Me.lblProdFinishDate.Location = New System.Drawing.Point(407, 155)
        Me.lblProdFinishDate.Name = "lblProdFinishDate"
        Me.lblProdFinishDate.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishDate.TabIndex = 338
        Me.lblProdFinishDate.Text = "Production Finished Date"
        '
        'lblProdFinishTime
        '
        Me.lblProdFinishTime.AutoSize = True
        Me.lblProdFinishTime.Location = New System.Drawing.Point(407, 186)
        Me.lblProdFinishTime.Name = "lblProdFinishTime"
        Me.lblProdFinishTime.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishTime.TabIndex = 340
        Me.lblProdFinishTime.Text = "Production Finished Time"
        '
        'txtProdFinishTime
        '
        Me.txtProdFinishTime.Location = New System.Drawing.Point(615, 180)
        Me.txtProdFinishTime.Name = "txtProdFinishTime"
        Me.txtProdFinishTime.Size = New System.Drawing.Size(132, 20)
        Me.txtProdFinishTime.TabIndex = 341
        '
        'lbldyeing_pass
        '
        Me.lbldyeing_pass.AutoSize = True
        Me.lbldyeing_pass.Location = New System.Drawing.Point(407, 215)
        Me.lbldyeing_pass.Name = "lbldyeing_pass"
        Me.lbldyeing_pass.Size = New System.Drawing.Size(76, 13)
        Me.lbldyeing_pass.TabIndex = 342
        Me.lbldyeing_pass.Text = "Pass Dye Test"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(615, 235)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtadjust_loss_kg.TabIndex = 344
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(410, 244)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 345
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(410, 268)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 346
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(615, 261)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtqc_loss_kg.TabIndex = 347
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(409, 292)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(105, 13)
        Me.lbldyed_loss_kg.TabIndex = 348
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(615, 288)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtdyed_loss_kg.TabIndex = 349
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(410, 319)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 350
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(615, 314)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtlab_loss_kg.TabIndex = 351
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(412, 351)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(94, 13)
        Me.lbldefect_loss_kg.TabIndex = 352
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(615, 343)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtdefect_loss_kg.TabIndex = 353
        '
        'lblrem_qc
        '
        Me.lblrem_qc.AutoSize = True
        Me.lblrem_qc.Location = New System.Drawing.Point(415, 383)
        Me.lblrem_qc.Name = "lblrem_qc"
        Me.lblrem_qc.Size = New System.Drawing.Size(44, 13)
        Me.lblrem_qc.TabIndex = 354
        Me.lblrem_qc.Text = "Remark"
        '
        'txtrem_qc
        '
        Me.txtrem_qc.Location = New System.Drawing.Point(615, 379)
        Me.txtrem_qc.Name = "txtrem_qc"
        Me.txtrem_qc.Size = New System.Drawing.Size(132, 20)
        Me.txtrem_qc.TabIndex = 355
        '
        'chkdyeing_pass
        '
        Me.chkdyeing_pass.AutoSize = True
        Me.chkdyeing_pass.Location = New System.Drawing.Point(615, 212)
        Me.chkdyeing_pass.Name = "chkdyeing_pass"
        Me.chkdyeing_pass.Size = New System.Drawing.Size(15, 14)
        Me.chkdyeing_pass.TabIndex = 356
        Me.chkdyeing_pass.UseVisualStyleBackColor = True
        '
        'dtpProdFinishDate
        '
        Me.dtpProdFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProdFinishDate.Location = New System.Drawing.Point(615, 149)
        Me.dtpProdFinishDate.Name = "dtpProdFinishDate"
        Me.dtpProdFinishDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpProdFinishDate.TabIndex = 357
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "roll_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Roll No."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'defect_code
        '
        Me.defect_code.DataPropertyName = "defect_code"
        Me.defect_code.HeaderText = "Defect Code"
        Me.defect_code.Name = "defect_code"
        Me.defect_code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.defect_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Defect_name
        '
        Me.Defect_name.DataPropertyName = "Defect_name"
        Me.Defect_name.HeaderText = "Defect Name"
        Me.Defect_name.Name = "Defect_name"
        Me.Defect_name.ReadOnly = True
        Me.Defect_name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'defect_details
        '
        Me.defect_details.DataPropertyName = "defect_details"
        Me.defect_details.HeaderText = "Defect Details"
        Me.defect_details.Name = "defect_details"
        Me.defect_details.Width = 90
        '
        'stock_code
        '
        Me.stock_code.DataPropertyName = "stock_code"
        Me.stock_code.HeaderText = "Stock Code"
        Me.stock_code.Name = "stock_code"
        Me.stock_code.Visible = False
        '
        'frmStockGIN_KOManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 582)
        Me.Controls.Add(Me.dtpProdFinishDate)
        Me.Controls.Add(Me.chkdyeing_pass)
        Me.Controls.Add(Me.txtrem_qc)
        Me.Controls.Add(Me.lblrem_qc)
        Me.Controls.Add(Me.txtdefect_loss_kg)
        Me.Controls.Add(Me.lbldefect_loss_kg)
        Me.Controls.Add(Me.txtlab_loss_kg)
        Me.Controls.Add(Me.lbllab_loss_kg)
        Me.Controls.Add(Me.txtdyed_loss_kg)
        Me.Controls.Add(Me.lbldyed_loss_kg)
        Me.Controls.Add(Me.txtqc_loss_kg)
        Me.Controls.Add(Me.lblqc_loss_kg)
        Me.Controls.Add(Me.lbladjust_loss_kg)
        Me.Controls.Add(Me.txtadjust_loss_kg)
        Me.Controls.Add(Me.lbldyeing_pass)
        Me.Controls.Add(Me.txtProdFinishTime)
        Me.Controls.Add(Me.lblProdFinishTime)
        Me.Controls.Add(Me.lblProdFinishDate)
        Me.Controls.Add(Me.chkcliped)
        Me.Controls.Add(Me.txtshift)
        Me.Controls.Add(Me.lblshift)
        Me.Controls.Add(Me.txtsub_location)
        Me.Controls.Add(Me.lblsub_location)
        Me.Controls.Add(Me.txtloc)
        Me.Controls.Add(Me.lblloc)
        Me.Controls.Add(Me.lblcliped)
        Me.Controls.Add(Me.txtgrade_adt)
        Me.Controls.Add(Me.lblgrade_adt)
        Me.Controls.Add(Me.txtgrade_bdt)
        Me.Controls.Add(Me.lblgrade_bdt)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Controls.Add(Me.txtgwth)
        Me.Controls.Add(Me.lblgwth)
        Me.Controls.Add(Me.txtbar_weight)
        Me.Controls.Add(Me.lblbar_weight)
        Me.Controls.Add(Me.txtkg)
        Me.Controls.Add(Me.lblkg)
        Me.Controls.Add(Me.lblmts)
        Me.Controls.Add(Me.txtmts)
        Me.Controls.Add(Me.lblroll_no_o)
        Me.Controls.Add(Me.txtroll_no_o)
        Me.Controls.Add(Me.lblroll_no)
        Me.Controls.Add(Me.txtroll_no)
        Me.Controls.Add(Me.grdDefect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockGIN_KOManual"
        Me.Text = "StockG IN Manual"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboGINNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lbltran_no As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbltran_dt As System.Windows.Forms.Label
    Friend WithEvents dtptran_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttran_no As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblkono As System.Windows.Forms.Label
    Friend WithEvents txtkono As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmcno As System.Windows.Forms.Label
    Friend WithEvents txtmcno As System.Windows.Forms.TextBox
    Friend WithEvents grdDefect As System.Windows.Forms.DataGridView
    Friend WithEvents lbldesign_no As System.Windows.Forms.Label
    Friend WithEvents txtdesign_no As System.Windows.Forms.TextBox
    Friend WithEvents lblynchgcd As System.Windows.Forms.Label
    Friend WithEvents txtynchgcd As System.Windows.Forms.TextBox
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no As System.Windows.Forms.Label
    Friend WithEvents txtroll_no_o As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no_o As System.Windows.Forms.Label
    Friend WithEvents txtmts As System.Windows.Forms.TextBox
    Friend WithEvents lblmts As System.Windows.Forms.Label
    Friend WithEvents txtkg As System.Windows.Forms.TextBox
    Friend WithEvents lblkg As System.Windows.Forms.Label
    Friend WithEvents txtbar_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblbar_weight As System.Windows.Forms.Label
    Friend WithEvents txtgwth As System.Windows.Forms.TextBox
    Friend WithEvents lblgwth As System.Windows.Forms.Label
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents lbllot As System.Windows.Forms.Label
    Friend WithEvents txtgrade_bdt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_bdt As System.Windows.Forms.Label
    Friend WithEvents txtgrade_adt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_adt As System.Windows.Forms.Label
    Friend WithEvents lblcliped As System.Windows.Forms.Label
    Friend WithEvents lblloc As System.Windows.Forms.Label
    Friend WithEvents txtloc As System.Windows.Forms.TextBox
    Friend WithEvents lblsub_location As System.Windows.Forms.Label
    Friend WithEvents txtsub_location As System.Windows.Forms.TextBox
    Friend WithEvents lblshift As System.Windows.Forms.Label
    Friend WithEvents txtshift As System.Windows.Forms.TextBox
    Friend WithEvents chkcliped As System.Windows.Forms.CheckBox
    Friend WithEvents lblProdFinishDate As System.Windows.Forms.Label
    Friend WithEvents lblProdFinishTime As System.Windows.Forms.Label
    Friend WithEvents txtProdFinishTime As System.Windows.Forms.TextBox
    Friend WithEvents lbldyeing_pass As System.Windows.Forms.Label
    Friend WithEvents txtadjust_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbladjust_loss_kg As System.Windows.Forms.Label
    Friend WithEvents lblqc_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtqc_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldyed_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtdyed_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbllab_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtlab_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldefect_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtdefect_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lblrem_qc As System.Windows.Forms.Label
    Friend WithEvents txtrem_qc As System.Windows.Forms.TextBox
    Friend WithEvents chkdyeing_pass As System.Windows.Forms.CheckBox
    Friend WithEvents dtpProdFinishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_code As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Defect_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_code As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
