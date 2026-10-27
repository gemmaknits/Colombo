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
        Me.dtpProdFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.chkdyeing_pass = New System.Windows.Forms.CheckBox()
        Me.txtrem_qc = New System.Windows.Forms.TextBox()
        Me.lblrem_qc = New System.Windows.Forms.Label()
        Me.txtdefect_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldefect_loss_kg = New System.Windows.Forms.Label()
        Me.txtlab_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbllab_loss_kg = New System.Windows.Forms.Label()
        Me.txtdyed_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyed_loss_kg = New System.Windows.Forms.Label()
        Me.txtqc_loss_kg = New System.Windows.Forms.TextBox()
        Me.lblqc_loss_kg = New System.Windows.Forms.Label()
        Me.lbladjust_loss_kg = New System.Windows.Forms.Label()
        Me.txtadjust_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyeing_pass = New System.Windows.Forms.Label()
        Me.lblProdFinishTime = New System.Windows.Forms.Label()
        Me.lblProdFinishDate = New System.Windows.Forms.Label()
        Me.chkcliped = New System.Windows.Forms.CheckBox()
        Me.txtshift = New System.Windows.Forms.TextBox()
        Me.lblshift = New System.Windows.Forms.Label()
        Me.lblcliped = New System.Windows.Forms.Label()
        Me.txtgrade_adt = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.lblgrade_adt = New System.Windows.Forms.Label()
        Me.txtgrade_bdt = New System.Windows.Forms.TextBox()
        Me.lblgrade_bdt = New System.Windows.Forms.Label()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.txtgwth = New System.Windows.Forms.TextBox()
        Me.lblgwth = New System.Windows.Forms.Label()
        Me.txtbar_weight = New System.Windows.Forms.TextBox()
        Me.lblpcv_item_id = New System.Windows.Forms.Label()
        Me.txtkg = New System.Windows.Forms.TextBox()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblmcno = New System.Windows.Forms.Label()
        Me.txtmcno = New System.Windows.Forms.TextBox()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblkono = New System.Windows.Forms.Label()
        Me.lbltran_no = New System.Windows.Forms.Label()
        Me.txtkono = New System.Windows.Forms.TextBox()
        Me.txttran_no = New System.Windows.Forms.TextBox()
        Me.lbltran_dt = New System.Windows.Forms.Label()
        Me.txtdesign_no = New System.Windows.Forms.TextBox()
        Me.lbldesign_no = New System.Windows.Forms.Label()
        Me.dtptran_dt = New System.Windows.Forms.DateTimePicker()
        Me.txtynchgcd = New System.Windows.Forms.TextBox()
        Me.lblynchgcd = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdDefect = New System.Windows.Forms.DataGridView()
        Me.id_defect_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Defect_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblmts = New System.Windows.Forms.Label()
        Me.txtmts = New System.Windows.Forms.TextBox()
        Me.lblroll_no_o = New System.Windows.Forms.Label()
        Me.txtroll_no_o = New System.Windows.Forms.TextBox()
        Me.lblroll_no = New System.Windows.Forms.Label()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.gbDefect = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.txtdefect_details = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.cbodefect_code = New System.Windows.Forms.ComboBox()
        Me.lblDefect_code = New System.Windows.Forms.Label()
        Me.chkEsc = New System.Windows.Forms.RadioButton()
        Me.chkGMK = New System.Windows.Forms.RadioButton()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblbar_weight = New System.Windows.Forms.Label()
        Me.cbopcv_item_id = New System.Windows.Forms.ComboBox()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProdFinishTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDefect.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpProdFinishDate
        '
        Me.dtpProdFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProdFinishDate.Location = New System.Drawing.Point(615, 155)
        Me.dtpProdFinishDate.Name = "dtpProdFinishDate"
        Me.dtpProdFinishDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpProdFinishDate.TabIndex = 18
        '
        'chkdyeing_pass
        '
        Me.chkdyeing_pass.AutoSize = True
        Me.chkdyeing_pass.Location = New System.Drawing.Point(615, 218)
        Me.chkdyeing_pass.Name = "chkdyeing_pass"
        Me.chkdyeing_pass.Size = New System.Drawing.Size(15, 14)
        Me.chkdyeing_pass.TabIndex = 20
        Me.chkdyeing_pass.UseVisualStyleBackColor = True
        '
        'txtrem_qc
        '
        Me.txtrem_qc.Location = New System.Drawing.Point(418, 418)
        Me.txtrem_qc.Multiline = True
        Me.txtrem_qc.Name = "txtrem_qc"
        Me.txtrem_qc.Size = New System.Drawing.Size(329, 181)
        Me.txtrem_qc.TabIndex = 26
        '
        'lblrem_qc
        '
        Me.lblrem_qc.AutoSize = True
        Me.lblrem_qc.Location = New System.Drawing.Point(415, 388)
        Me.lblrem_qc.Name = "lblrem_qc"
        Me.lblrem_qc.Size = New System.Drawing.Size(44, 13)
        Me.lblrem_qc.TabIndex = 401
        Me.lblrem_qc.Text = "Remark"
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(615, 349)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtdefect_loss_kg.TabIndex = 25
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(412, 357)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(94, 13)
        Me.lbldefect_loss_kg.TabIndex = 399
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(615, 320)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtlab_loss_kg.TabIndex = 24
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(410, 325)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 397
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(615, 294)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtdyed_loss_kg.TabIndex = 23
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(409, 298)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(105, 13)
        Me.lbldyed_loss_kg.TabIndex = 395
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(615, 267)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtqc_loss_kg.TabIndex = 22
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(410, 274)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 393
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(410, 250)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 392
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(615, 241)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(132, 20)
        Me.txtadjust_loss_kg.TabIndex = 21
        '
        'lbldyeing_pass
        '
        Me.lbldyeing_pass.AutoSize = True
        Me.lbldyeing_pass.Location = New System.Drawing.Point(407, 221)
        Me.lbldyeing_pass.Name = "lbldyeing_pass"
        Me.lbldyeing_pass.Size = New System.Drawing.Size(76, 13)
        Me.lbldyeing_pass.TabIndex = 390
        Me.lbldyeing_pass.Text = "Pass Dye Test"
        '
        'lblProdFinishTime
        '
        Me.lblProdFinishTime.AutoSize = True
        Me.lblProdFinishTime.Location = New System.Drawing.Point(407, 192)
        Me.lblProdFinishTime.Name = "lblProdFinishTime"
        Me.lblProdFinishTime.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishTime.TabIndex = 388
        Me.lblProdFinishTime.Text = "Production Finished Time"
        '
        'lblProdFinishDate
        '
        Me.lblProdFinishDate.AutoSize = True
        Me.lblProdFinishDate.Location = New System.Drawing.Point(407, 161)
        Me.lblProdFinishDate.Name = "lblProdFinishDate"
        Me.lblProdFinishDate.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishDate.TabIndex = 387
        Me.lblProdFinishDate.Text = "Production Finished Date"
        '
        'chkcliped
        '
        Me.chkcliped.AutoSize = True
        Me.chkcliped.Location = New System.Drawing.Point(247, 465)
        Me.chkcliped.Name = "chkcliped"
        Me.chkcliped.Size = New System.Drawing.Size(15, 14)
        Me.chkcliped.TabIndex = 13
        Me.chkcliped.UseVisualStyleBackColor = True
        '
        'txtshift
        '
        Me.txtshift.Location = New System.Drawing.Point(247, 579)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.Size = New System.Drawing.Size(132, 20)
        Me.txtshift.TabIndex = 17
        '
        'lblshift
        '
        Me.lblshift.AutoSize = True
        Me.lblshift.Location = New System.Drawing.Point(36, 582)
        Me.lblshift.Name = "lblshift"
        Me.lblshift.Size = New System.Drawing.Size(28, 13)
        Me.lblshift.TabIndex = 384
        Me.lblshift.Text = "Shift"
        '
        'lblcliped
        '
        Me.lblcliped.AutoSize = True
        Me.lblcliped.Location = New System.Drawing.Point(33, 465)
        Me.lblcliped.Name = "lblcliped"
        Me.lblcliped.Size = New System.Drawing.Size(106, 13)
        Me.lblcliped.TabIndex = 379
        Me.lblcliped.Text = "Open Width ? (ผ่าถุง)"
        '
        'txtgrade_adt
        '
        Me.txtgrade_adt.Location = New System.Drawing.Point(247, 427)
        Me.txtgrade_adt.Name = "txtgrade_adt"
        Me.txtgrade_adt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_adt.TabIndex = 12
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
        'lblgrade_adt
        '
        Me.lblgrade_adt.AutoSize = True
        Me.lblgrade_adt.Location = New System.Drawing.Point(33, 430)
        Me.lblgrade_adt.Name = "lblgrade_adt"
        Me.lblgrade_adt.Size = New System.Drawing.Size(171, 13)
        Me.lblgrade_adt.TabIndex = 377
        Me.lblgrade_adt.Text = "Grade of Dye Test (After Dye Test)"
        '
        'txtgrade_bdt
        '
        Me.txtgrade_bdt.Location = New System.Drawing.Point(247, 388)
        Me.txtgrade_bdt.Name = "txtgrade_bdt"
        Me.txtgrade_bdt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_bdt.TabIndex = 11
        '
        'lblgrade_bdt
        '
        Me.lblgrade_bdt.AutoSize = True
        Me.lblgrade_bdt.Location = New System.Drawing.Point(33, 391)
        Me.lblgrade_bdt.Name = "lblgrade_bdt"
        Me.lblgrade_bdt.Size = New System.Drawing.Size(186, 13)
        Me.lblgrade_bdt.TabIndex = 375
        Me.lblgrade_bdt.Text = "Grade of Inspection (Before Dye Test)"
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(247, 349)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(132, 20)
        Me.txtlot.TabIndex = 10
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Location = New System.Drawing.Point(33, 352)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(48, 13)
        Me.lbllot.TabIndex = 373
        Me.lbllot.Text = "Yarn Set"
        '
        'txtgwth
        '
        Me.txtgwth.Location = New System.Drawing.Point(247, 320)
        Me.txtgwth.Name = "txtgwth"
        Me.txtgwth.Size = New System.Drawing.Size(132, 20)
        Me.txtgwth.TabIndex = 9
        '
        'lblgwth
        '
        Me.lblgwth.AutoSize = True
        Me.lblgwth.Location = New System.Drawing.Point(33, 323)
        Me.lblgwth.Name = "lblgwth"
        Me.lblgwth.Size = New System.Drawing.Size(100, 13)
        Me.lblgwth.TabIndex = 371
        Me.lblgwth.Text = "Greige Width (cms.)"
        '
        'txtbar_weight
        '
        Me.txtbar_weight.Location = New System.Drawing.Point(247, 293)
        Me.txtbar_weight.Name = "txtbar_weight"
        Me.txtbar_weight.Size = New System.Drawing.Size(132, 20)
        Me.txtbar_weight.TabIndex = 8
        '
        'lblpcv_item_id
        '
        Me.lblpcv_item_id.AutoSize = True
        Me.lblpcv_item_id.Location = New System.Drawing.Point(33, 271)
        Me.lblpcv_item_id.Name = "lblpcv_item_id"
        Me.lblpcv_item_id.Size = New System.Drawing.Size(77, 13)
        Me.lblpcv_item_id.TabIndex = 369
        Me.lblpcv_item_id.Text = "Bar  (รหัสแกน)"
        '
        'txtkg
        '
        Me.txtkg.Location = New System.Drawing.Point(247, 242)
        Me.txtkg.Name = "txtkg"
        Me.txtkg.Size = New System.Drawing.Size(132, 20)
        Me.txtkg.TabIndex = 6
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Location = New System.Drawing.Point(33, 245)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(71, 13)
        Me.lblkg.TabIndex = 367
        Me.lblkg.Text = "Weight (Kgs.)"
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
        Me.GroupBox1.Location = New System.Drawing.Point(17, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 79)
        Me.GroupBox1.TabIndex = 359
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
        Me.txtmcno.TabIndex = 2
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
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(782, 20)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(76, 13)
        Me.lbltran_no.TabIndex = 301
        Me.lbltran_no.Text = "Document No."
        '
        'txtkono
        '
        Me.txtkono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtkono.Location = New System.Drawing.Point(230, 17)
        Me.txtkono.Name = "txtkono"
        Me.txtkono.ReadOnly = True
        Me.txtkono.Size = New System.Drawing.Size(132, 20)
        Me.txtkono.TabIndex = 1
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
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(781, 46)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(82, 13)
        Me.lbltran_dt.TabIndex = 302
        Me.lbltran_dt.Text = "Document Date"
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
        'dtptran_dt
        '
        Me.dtptran_dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptran_dt.Location = New System.Drawing.Point(886, 43)
        Me.dtptran_dt.Name = "dtptran_dt"
        Me.dtptran_dt.Size = New System.Drawing.Size(132, 20)
        Me.dtptran_dt.TabIndex = 289
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
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(23, 22)
        Me.btnCancel.Text = "Cancel Document"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 358
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'grdDefect
        '
        Me.grdDefect.AllowUserToAddRows = False
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_defect_roll, Me.DataGridViewTextBoxColumn3, Me.defect_code, Me.Defect_name, Me.defect_details, Me.stock_code})
        Me.grdDefect.Location = New System.Drawing.Point(17, 19)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(246, 332)
        Me.grdDefect.TabIndex = 360
        Me.grdDefect.TabStop = False
        '
        'id_defect_roll
        '
        Me.id_defect_roll.DataPropertyName = "id_defect_roll"
        Me.id_defect_roll.HeaderText = "ID"
        Me.id_defect_roll.Name = "id_defect_roll"
        Me.id_defect_roll.Visible = False
        Me.id_defect_roll.Width = 40
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
        Me.Defect_name.Visible = False
        '
        'defect_details
        '
        Me.defect_details.DataPropertyName = "defect_details"
        Me.defect_details.HeaderText = "Qty"
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
        'lblmts
        '
        Me.lblmts.AutoSize = True
        Me.lblmts.Location = New System.Drawing.Point(33, 212)
        Me.lblmts.Name = "lblmts"
        Me.lblmts.Size = New System.Drawing.Size(69, 13)
        Me.lblmts.TabIndex = 366
        Me.lblmts.Text = "Length (Mts.)"
        '
        'txtmts
        '
        Me.txtmts.Location = New System.Drawing.Point(247, 208)
        Me.txtmts.Name = "txtmts"
        Me.txtmts.Size = New System.Drawing.Size(132, 20)
        Me.txtmts.TabIndex = 5
        '
        'lblroll_no_o
        '
        Me.lblroll_no_o.AutoSize = True
        Me.lblroll_no_o.Location = New System.Drawing.Point(33, 184)
        Me.lblroll_no_o.Name = "lblroll_no_o"
        Me.lblroll_no_o.Size = New System.Drawing.Size(83, 13)
        Me.lblroll_no_o.TabIndex = 364
        Me.lblroll_no_o.Text = "Factory Roll No."
        '
        'txtroll_no_o
        '
        Me.txtroll_no_o.Location = New System.Drawing.Point(247, 181)
        Me.txtroll_no_o.Name = "txtroll_no_o"
        Me.txtroll_no_o.ReadOnly = True
        Me.txtroll_no_o.Size = New System.Drawing.Size(132, 20)
        Me.txtroll_no_o.TabIndex = 4
        '
        'lblroll_no
        '
        Me.lblroll_no.AutoSize = True
        Me.lblroll_no.Location = New System.Drawing.Point(33, 157)
        Me.lblroll_no.Name = "lblroll_no"
        Me.lblroll_no.Size = New System.Drawing.Size(82, 13)
        Me.lblroll_no.TabIndex = 362
        Me.lblroll_no.Text = "System Roll No."
        '
        'txtroll_no
        '
        Me.txtroll_no.Location = New System.Drawing.Point(247, 154)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.ReadOnly = True
        Me.txtroll_no.Size = New System.Drawing.Size(132, 20)
        Me.txtroll_no.TabIndex = 3
        '
        'gbDefect
        '
        Me.gbDefect.Controls.Add(Me.btnApply)
        Me.gbDefect.Controls.Add(Me.txtdefect_details)
        Me.gbDefect.Controls.Add(Me.lblQty)
        Me.gbDefect.Controls.Add(Me.cbodefect_code)
        Me.gbDefect.Controls.Add(Me.lblDefect_code)
        Me.gbDefect.Controls.Add(Me.grdDefect)
        Me.gbDefect.Location = New System.Drawing.Point(757, 155)
        Me.gbDefect.Name = "gbDefect"
        Me.gbDefect.Size = New System.Drawing.Size(284, 444)
        Me.gbDefect.TabIndex = 406
        Me.gbDefect.TabStop = False
        Me.gbDefect.Text = "Defect Detail"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(210, 390)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(53, 23)
        Me.btnApply.TabIndex = 365
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'txtdefect_details
        '
        Me.txtdefect_details.Location = New System.Drawing.Point(215, 366)
        Me.txtdefect_details.Name = "txtdefect_details"
        Me.txtdefect_details.Size = New System.Drawing.Size(48, 20)
        Me.txtdefect_details.TabIndex = 364
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(176, 368)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(23, 13)
        Me.lblQty.TabIndex = 363
        Me.lblQty.Text = "Qty"
        '
        'cbodefect_code
        '
        Me.cbodefect_code.FormattingEnabled = True
        Me.cbodefect_code.Location = New System.Drawing.Point(83, 368)
        Me.cbodefect_code.Name = "cbodefect_code"
        Me.cbodefect_code.Size = New System.Drawing.Size(87, 21)
        Me.cbodefect_code.TabIndex = 362
        '
        'lblDefect_code
        '
        Me.lblDefect_code.AutoSize = True
        Me.lblDefect_code.Location = New System.Drawing.Point(17, 371)
        Me.lblDefect_code.Name = "lblDefect_code"
        Me.lblDefect_code.Size = New System.Drawing.Size(52, 13)
        Me.lblDefect_code.TabIndex = 361
        Me.lblDefect_code.Text = "Def Code"
        '
        'chkEsc
        '
        Me.chkEsc.AutoSize = True
        Me.chkEsc.Checked = True
        Me.chkEsc.Location = New System.Drawing.Point(134, 184)
        Me.chkEsc.Name = "chkEsc"
        Me.chkEsc.Size = New System.Drawing.Size(47, 17)
        Me.chkEsc.TabIndex = 407
        Me.chkEsc.TabStop = True
        Me.chkEsc.Text = "ESH"
        Me.chkEsc.UseVisualStyleBackColor = True
        '
        'chkGMK
        '
        Me.chkGMK.AutoSize = True
        Me.chkGMK.Location = New System.Drawing.Point(187, 184)
        Me.chkGMK.Name = "chkGMK"
        Me.chkGMK.Size = New System.Drawing.Size(49, 17)
        Me.chkGMK.TabIndex = 408
        Me.chkGMK.Text = "GMK"
        Me.chkGMK.UseVisualStyleBackColor = True
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(36, 493)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(62, 13)
        Me.lblmtl_warehouse_id.TabIndex = 456
        Me.lblmtl_warehouse_id.Text = "Warehouse"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(247, 490)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_warehouse.TabIndex = 14
        '
        'cbomtl_location
        '
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(247, 552)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_location.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 555)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 457
        Me.Label1.Text = "Location"
        '
        'lblbar_weight
        '
        Me.lblbar_weight.AutoSize = True
        Me.lblbar_weight.Location = New System.Drawing.Point(33, 296)
        Me.lblbar_weight.Name = "lblbar_weight"
        Me.lblbar_weight.Size = New System.Drawing.Size(157, 13)
        Me.lblbar_weight.TabIndex = 459
        Me.lblbar_weight.Text = "Bar Weight (Kgs.) (น้ำหนักแกน)"
        '
        'cbopcv_item_id
        '
        Me.cbopcv_item_id.FormattingEnabled = True
        Me.cbopcv_item_id.Location = New System.Drawing.Point(247, 266)
        Me.cbopcv_item_id.Name = "cbopcv_item_id"
        Me.cbopcv_item_id.Size = New System.Drawing.Size(132, 21)
        Me.cbopcv_item_id.TabIndex = 7
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(247, 518)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_subinventory.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 521)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 462
        Me.Label2.Text = "SubInventory"
        '
        'txtProdFinishTime
        '
        Me.txtProdFinishTime.CustomFormat = "HH:mm"
        Me.txtProdFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtProdFinishTime.Location = New System.Drawing.Point(615, 186)
        Me.txtProdFinishTime.Name = "txtProdFinishTime"
        Me.txtProdFinishTime.ShowUpDown = True
        Me.txtProdFinishTime.Size = New System.Drawing.Size(133, 20)
        Me.txtProdFinishTime.TabIndex = 19
        '
        'frmStockGIN_KOManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 659)
        Me.Controls.Add(Me.txtProdFinishTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.cbopcv_item_id)
        Me.Controls.Add(Me.lblbar_weight)
        Me.Controls.Add(Me.cbomtl_location)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblmtl_warehouse_id)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.chkGMK)
        Me.Controls.Add(Me.chkEsc)
        Me.Controls.Add(Me.gbDefect)
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
        Me.Controls.Add(Me.lblProdFinishTime)
        Me.Controls.Add(Me.lblProdFinishDate)
        Me.Controls.Add(Me.chkcliped)
        Me.Controls.Add(Me.txtshift)
        Me.Controls.Add(Me.lblshift)
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
        Me.Controls.Add(Me.lblpcv_item_id)
        Me.Controls.Add(Me.txtkg)
        Me.Controls.Add(Me.lblkg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblmts)
        Me.Controls.Add(Me.txtmts)
        Me.Controls.Add(Me.lblroll_no_o)
        Me.Controls.Add(Me.txtroll_no_o)
        Me.Controls.Add(Me.lblroll_no)
        Me.Controls.Add(Me.txtroll_no)
        Me.Name = "frmStockGIN_KOManual"
        Me.Tag = "Greige IN Knitting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDefect.ResumeLayout(False)
        Me.gbDefect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpProdFinishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkdyeing_pass As System.Windows.Forms.CheckBox
    Friend WithEvents txtrem_qc As System.Windows.Forms.TextBox
    Friend WithEvents lblrem_qc As System.Windows.Forms.Label
    Friend WithEvents txtdefect_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldefect_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtlab_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbllab_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtdyed_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldyed_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtqc_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lblqc_loss_kg As System.Windows.Forms.Label
    Friend WithEvents lbladjust_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtadjust_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldyeing_pass As System.Windows.Forms.Label
    Friend WithEvents lblProdFinishTime As System.Windows.Forms.Label
    Friend WithEvents lblProdFinishDate As System.Windows.Forms.Label
    Friend WithEvents chkcliped As System.Windows.Forms.CheckBox
    Friend WithEvents txtshift As System.Windows.Forms.TextBox
    Friend WithEvents lblshift As System.Windows.Forms.Label
    Friend WithEvents lblcliped As System.Windows.Forms.Label
    Friend WithEvents txtgrade_adt As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblgrade_adt As System.Windows.Forms.Label
    Friend WithEvents txtgrade_bdt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_bdt As System.Windows.Forms.Label
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents lbllot As System.Windows.Forms.Label
    Friend WithEvents txtgwth As System.Windows.Forms.TextBox
    Friend WithEvents lblgwth As System.Windows.Forms.Label
    Friend WithEvents txtbar_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblpcv_item_id As System.Windows.Forms.Label
    Friend WithEvents txtkg As System.Windows.Forms.TextBox
    Friend WithEvents lblkg As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmcno As System.Windows.Forms.Label
    Friend WithEvents txtmcno As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblkono As System.Windows.Forms.Label
    Friend WithEvents lbltran_no As System.Windows.Forms.Label
    Friend WithEvents txtkono As System.Windows.Forms.TextBox
    Friend WithEvents txttran_no As System.Windows.Forms.TextBox
    Friend WithEvents lbltran_dt As System.Windows.Forms.Label
    Friend WithEvents txtdesign_no As System.Windows.Forms.TextBox
    Friend WithEvents lbldesign_no As System.Windows.Forms.Label
    Friend WithEvents dtptran_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtynchgcd As System.Windows.Forms.TextBox
    Friend WithEvents lblynchgcd As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdDefect As System.Windows.Forms.DataGridView
    Friend WithEvents lblmts As System.Windows.Forms.Label
    Friend WithEvents txtmts As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no_o As System.Windows.Forms.Label
    Friend WithEvents txtroll_no_o As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no As System.Windows.Forms.Label
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents gbDefect As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents txtdefect_details As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents cbodefect_code As System.Windows.Forms.ComboBox
    Friend WithEvents lblDefect_code As System.Windows.Forms.Label
    Friend WithEvents id_defect_roll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_code As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Defect_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkEsc As System.Windows.Forms.RadioButton
    Friend WithEvents chkGMK As System.Windows.Forms.RadioButton
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_location As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblbar_weight As System.Windows.Forms.Label
    Friend WithEvents cbopcv_item_id As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProdFinishTime As System.Windows.Forms.DateTimePicker
End Class
