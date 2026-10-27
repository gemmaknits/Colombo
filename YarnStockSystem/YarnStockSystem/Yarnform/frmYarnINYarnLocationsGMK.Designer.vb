<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYarnINYarnLocationsGMK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnINYarnLocationsGMK))
        Me.grdYarnIN = New System.Windows.Forms.DataGridView()
        Me.colsel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colInterfaceYarnLogid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInterfaceYarnLogno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGradeOur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colboxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colspools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colkg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colkg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colboxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colmtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colmtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colmtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colloc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colloc_sub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotnoSup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotnoOur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbox_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpsinvdt = New System.Windows.Forms.DateTimePicker()
        Me.BtnSearchYL = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInterfaceYarnLogno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsinvno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtlotnosup = New System.Windows.Forms.TextBox()
        Me.txtsrefno = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox()
        Me.txtTotalTubes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotalBoxes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotalGrossWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboMtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboMtlLocations = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboMtlSubInventory = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdYarnIN
        '
        Me.grdYarnIN.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdYarnIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdYarnIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colsel, Me.colInterfaceYarnLogid, Me.colInterfaceYarnLogno, Me.colitcd, Me.colGradeOur, Me.colGrade, Me.colboxno_s, Me.colspools, Me.colkg_gr, Me.colkg_nt, Me.colcart_tearwt, Me.colboxno, Me.colmtl_warehouse_id, Me.colmtl_subinventory_id, Me.colmtl_locations_id, Me.colloc, Me.colloc_sub, Me.colLotnoSup, Me.colLotnoOur, Me.colbox_remark})
        Me.grdYarnIN.Location = New System.Drawing.Point(5, 196)
        Me.grdYarnIN.Name = "grdYarnIN"
        Me.grdYarnIN.Size = New System.Drawing.Size(947, 299)
        Me.grdYarnIN.TabIndex = 375
        '
        'colsel
        '
        Me.colsel.DataPropertyName = "sel"
        Me.colsel.HeaderText = "sel"
        Me.colsel.Name = "colsel"
        Me.colsel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colsel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colsel.Width = 25
        '
        'colInterfaceYarnLogid
        '
        Me.colInterfaceYarnLogid.DataPropertyName = "interface_yarn_logid"
        Me.colInterfaceYarnLogid.HeaderText = "Log ID"
        Me.colInterfaceYarnLogid.Name = "colInterfaceYarnLogid"
        Me.colInterfaceYarnLogid.Visible = False
        '
        'colInterfaceYarnLogno
        '
        Me.colInterfaceYarnLogno.DataPropertyName = "interface_yarn_logno"
        Me.colInterfaceYarnLogno.HeaderText = "YL No."
        Me.colInterfaceYarnLogno.Name = "colInterfaceYarnLogno"
        Me.colInterfaceYarnLogno.Width = 80
        '
        'colitcd
        '
        Me.colitcd.DataPropertyName = "itcd"
        Me.colitcd.HeaderText = "Items Code"
        Me.colitcd.Name = "colitcd"
        Me.colitcd.ReadOnly = True
        Me.colitcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colitcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colGradeOur
        '
        Me.colGradeOur.DataPropertyName = "grade_our"
        Me.colGradeOur.HeaderText = "Grade Our"
        Me.colGradeOur.Name = "colGradeOur"
        Me.colGradeOur.Width = 50
        '
        'colGrade
        '
        Me.colGrade.DataPropertyName = "grade"
        Me.colGrade.HeaderText = "Grade"
        Me.colGrade.MaxInputLength = 15
        Me.colGrade.Name = "colGrade"
        Me.colGrade.Width = 50
        '
        'colboxno_s
        '
        Me.colboxno_s.DataPropertyName = "boxno_s"
        Me.colboxno_s.HeaderText = "Supplier Box no."
        Me.colboxno_s.MaxInputLength = 15
        Me.colboxno_s.Name = "colboxno_s"
        Me.colboxno_s.Width = 75
        '
        'colspools
        '
        Me.colspools.DataPropertyName = "spools"
        Me.colspools.HeaderText = "Tube /Spools"
        Me.colspools.MaxInputLength = 15
        Me.colspools.Name = "colspools"
        Me.colspools.Width = 50
        '
        'colkg_gr
        '
        Me.colkg_gr.DataPropertyName = "kg_gr"
        Me.colkg_gr.HeaderText = "Gross weight{Kg}"
        Me.colkg_gr.MaxInputLength = 15
        Me.colkg_gr.Name = "colkg_gr"
        Me.colkg_gr.Width = 75
        '
        'colkg_nt
        '
        Me.colkg_nt.DataPropertyName = "kg_nt"
        Me.colkg_nt.HeaderText = "Net weight{Kg}"
        Me.colkg_nt.MaxInputLength = 15
        Me.colkg_nt.Name = "colkg_nt"
        Me.colkg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colkg_nt.Width = 75
        '
        'colcart_tearwt
        '
        Me.colcart_tearwt.DataPropertyName = "cart_tearwt"
        Me.colcart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.colcart_tearwt.MaxInputLength = 15
        Me.colcart_tearwt.Name = "colcart_tearwt"
        Me.colcart_tearwt.Width = 75
        '
        'colboxno
        '
        Me.colboxno.DataPropertyName = "boxno"
        Me.colboxno.HeaderText = "Internal box no. (auto)"
        Me.colboxno.MaxInputLength = 15
        Me.colboxno.Name = "colboxno"
        Me.colboxno.ReadOnly = True
        Me.colboxno.Width = 60
        '
        'colmtl_warehouse_id
        '
        Me.colmtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.colmtl_warehouse_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colmtl_warehouse_id.HeaderText = "Warehouse"
        Me.colmtl_warehouse_id.Name = "colmtl_warehouse_id"
        Me.colmtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colmtl_warehouse_id.Visible = False
        Me.colmtl_warehouse_id.Width = 70
        '
        'colmtl_subinventory_id
        '
        Me.colmtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.colmtl_subinventory_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colmtl_subinventory_id.HeaderText = "Subinventory"
        Me.colmtl_subinventory_id.Name = "colmtl_subinventory_id"
        Me.colmtl_subinventory_id.Visible = False
        '
        'colmtl_locations_id
        '
        Me.colmtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.colmtl_locations_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colmtl_locations_id.HeaderText = "Location"
        Me.colmtl_locations_id.Name = "colmtl_locations_id"
        Me.colmtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colmtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colmtl_locations_id.Visible = False
        '
        'colloc
        '
        Me.colloc.DataPropertyName = "loc"
        Me.colloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colloc.HeaderText = "Loc"
        Me.colloc.Name = "colloc"
        Me.colloc.Visible = False
        '
        'colloc_sub
        '
        Me.colloc_sub.DataPropertyName = "loc_sub"
        Me.colloc_sub.HeaderText = "Sub Location"
        Me.colloc_sub.Name = "colloc_sub"
        Me.colloc_sub.Visible = False
        '
        'colLotnoSup
        '
        Me.colLotnoSup.DataPropertyName = "lotno_sup"
        Me.colLotnoSup.HeaderText = "Lot No. Sup"
        Me.colLotnoSup.Name = "colLotnoSup"
        Me.colLotnoSup.ReadOnly = True
        '
        'colLotnoOur
        '
        Me.colLotnoOur.DataPropertyName = "lotno_our"
        Me.colLotnoOur.HeaderText = "Lot No. Our"
        Me.colLotnoOur.Name = "colLotnoOur"
        Me.colLotnoOur.ReadOnly = True
        '
        'colbox_remark
        '
        Me.colbox_remark.DataPropertyName = "box_remark"
        Me.colbox_remark.HeaderText = "Remark"
        Me.colbox_remark.Name = "colbox_remark"
        Me.colbox_remark.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpsinvdt)
        Me.GroupBox1.Controls.Add(Me.BtnSearchYL)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtInterfaceYarnLogno)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtsinvno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtlotnosup)
        Me.GroupBox1.Controls.Add(Me.txtsrefno)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 139)
        Me.GroupBox1.TabIndex = 381
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transfer GMK details:"
        '
        'dtpsinvdt
        '
        Me.dtpsinvdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpsinvdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsinvdt.Location = New System.Drawing.Point(86, 105)
        Me.dtpsinvdt.Name = "dtpsinvdt"
        Me.dtpsinvdt.Size = New System.Drawing.Size(113, 22)
        Me.dtpsinvdt.TabIndex = 393
        '
        'BtnSearchYL
        '
        Me.BtnSearchYL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchYL.Image = CType(resources.GetObject("BtnSearchYL.Image"), System.Drawing.Image)
        Me.BtnSearchYL.Location = New System.Drawing.Point(206, 18)
        Me.BtnSearchYL.Name = "BtnSearchYL"
        Me.BtnSearchYL.Size = New System.Drawing.Size(25, 23)
        Me.BtnSearchYL.TabIndex = 126
        Me.BtnSearchYL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearchYL.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(235, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 392
        Me.Label9.Text = "*1 Yarn IN Only 1 YL"
        '
        'txtInterfaceYarnLogno
        '
        Me.txtInterfaceYarnLogno.CausesValidation = False
        Me.txtInterfaceYarnLogno.Location = New System.Drawing.Point(87, 20)
        Me.txtInterfaceYarnLogno.Name = "txtInterfaceYarnLogno"
        Me.txtInterfaceYarnLogno.Size = New System.Drawing.Size(115, 22)
        Me.txtInterfaceYarnLogno.TabIndex = 123
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "YL #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(199, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(87, 49)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(273, 21)
        Me.cboSupplier.TabIndex = 1
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Date:"
        '
        'txtsinvno
        '
        Me.txtsinvno.Location = New System.Drawing.Point(87, 81)
        Me.txtsinvno.Name = "txtsinvno"
        Me.txtsinvno.Size = New System.Drawing.Size(112, 22)
        Me.txtsinvno.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtlotnosup
        '
        Me.txtlotnosup.Location = New System.Drawing.Point(264, 80)
        Me.txtlotnosup.Name = "txtlotnosup"
        Me.txtlotnosup.Size = New System.Drawing.Size(96, 22)
        Me.txtlotnosup.TabIndex = 3
        '
        'txtsrefno
        '
        Me.txtsrefno.Location = New System.Drawing.Point(264, 104)
        Me.txtsrefno.Name = "txtsrefno"
        Me.txtsrefno.Size = New System.Drawing.Size(96, 22)
        Me.txtsrefno.TabIndex = 5
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(636, 525)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 44)
        Me.btnNew.TabIndex = 385
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.PeachPuff
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(700, 525)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 44)
        Me.btnSave.TabIndex = 386
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(764, 525)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(60, 44)
        Me.btnPrint.TabIndex = 387
        Me.btnPrint.Text = "Print Doc"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBarcode.BackColor = System.Drawing.Color.PeachPuff
        Me.btnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPrintBarcode.Image = CType(resources.GetObject("btnPrintBarcode.Image"), System.Drawing.Image)
        Me.btnPrintBarcode.Location = New System.Drawing.Point(828, 525)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(60, 44)
        Me.btnPrintBarcode.TabIndex = 388
        Me.btnPrintBarcode.Text = "Print bar label"
        Me.btnPrintBarcode.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrintBarcode.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtTotalNetWeight)
        Me.GroupBox4.Controls.Add(Me.txtTotalTubes)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.TextBox18)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtTotalBoxes)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtTotalGrossWeight)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(373, 501)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox4.TabIndex = 391
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Quantity"
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(192, 48)
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalNetWeight.TabIndex = 4
        '
        'txtTotalTubes
        '
        Me.txtTotalTubes.Location = New System.Drawing.Point(48, 48)
        Me.txtTotalTubes.Name = "txtTotalTubes"
        Me.txtTotalTubes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalTubes.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Tubes:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(112, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 86
        Me.Label23.Text = "Net wt (kg):"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 0
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
        'txtTotalBoxes
        '
        Me.txtTotalBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalBoxes.Location = New System.Drawing.Point(48, 24)
        Me.txtTotalBoxes.Name = "txtTotalBoxes"
        Me.txtTotalBoxes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalBoxes.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Boxes:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(112, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Gross wt (kg):"
        '
        'txtTotalGrossWeight
        '
        Me.txtTotalGrossWeight.Location = New System.Drawing.Point(192, 24)
        Me.txtTotalGrossWeight.Name = "txtTotalGrossWeight"
        Me.txtTotalGrossWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalGrossWeight.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 501)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox3.TabIndex = 390
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(8, 16)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(344, 56)
        Me.txtRemark.TabIndex = 0
        '
        'txtitcd
        '
        Me.txtitcd.Location = New System.Drawing.Point(17, 34)
        Me.txtitcd.Name = "txtitcd"
        Me.txtitcd.Size = New System.Drawing.Size(100, 20)
        Me.txtitcd.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(892, 525)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 44)
        Me.btnExit.TabIndex = 389
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cboMtlWarehouse)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboMtlLocations)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cboMtlSubInventory)
        Me.GroupBox2.Location = New System.Drawing.Point(723, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 99)
        Me.GroupBox2.TabIndex = 394
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Locations"
        '
        'cboMtlWarehouse
        '
        Me.cboMtlWarehouse.FormattingEnabled = True
        Me.cboMtlWarehouse.Location = New System.Drawing.Point(82, 19)
        Me.cboMtlWarehouse.Name = "cboMtlWarehouse"
        Me.cboMtlWarehouse.Size = New System.Drawing.Size(134, 21)
        Me.cboMtlWarehouse.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = "Location"
        '
        'cboMtlLocations
        '
        Me.cboMtlLocations.FormattingEnabled = True
        Me.cboMtlLocations.Location = New System.Drawing.Point(82, 73)
        Me.cboMtlLocations.Name = "cboMtlLocations"
        Me.cboMtlLocations.Size = New System.Drawing.Size(134, 21)
        Me.cboMtlLocations.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(44, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 295
        Me.Label17.Text = "Sub"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(39, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 298
        Me.Label18.Text = "W/H"
        '
        'cboMtlSubInventory
        '
        Me.cboMtlSubInventory.FormattingEnabled = True
        Me.cboMtlSubInventory.Location = New System.Drawing.Point(82, 46)
        Me.cboMtlSubInventory.Name = "cboMtlSubInventory"
        Me.cboMtlSubInventory.Size = New System.Drawing.Size(134, 21)
        Me.cboMtlSubInventory.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtDocNo)
        Me.GroupBox5.Controls.Add(Me.dtpDocDate)
        Me.GroupBox5.Controls.Add(Me.lblYINno)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TextBox24)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(723, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 80)
        Me.GroupBox5.TabIndex = 393
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(82, 21)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(134, 22)
        Me.txtDocNo.TabIndex = 0
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDate.Location = New System.Drawing.Point(82, 45)
        Me.dtpDocDate.Name = "dtpDocDate"
        Me.dtpDocDate.Size = New System.Drawing.Size(134, 22)
        Me.dtpDocDate.TabIndex = 1
        '
        'lblYINno
        '
        Me.lblYINno.AutoSize = True
        Me.lblYINno.Location = New System.Drawing.Point(85, 20)
        Me.lblYINno.Name = "lblYINno"
        Me.lblYINno.Size = New System.Drawing.Size(0, 13)
        Me.lblYINno.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Y-IN No.:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(-113, 40)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(100, 22)
        Me.TextBox24.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-158, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmYarnINYarnLocationsGMK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 582)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdYarnIN)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYarnINYarnLocationsGMK"
        Me.Text = "Y-IN Transfer GMK"
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdYarnIN As DataGridView
    Friend WithEvents cboItems As DataGridViewComboBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInterfaceYarnLogno As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsinvno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtlotnosup As TextBox
    Friend WithEvents txtsrefno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrintBarcode As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalNetWeight As TextBox
    Friend WithEvents txtTotalTubes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTotalBoxes As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTotalGrossWeight As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtitcd As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboMtlWarehouse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboMtlLocations As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cboMtlSubInventory As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents dtpDocDate As DateTimePicker
    Friend WithEvents lblYINno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnSearchYL As Button
    Friend WithEvents dtpsinvdt As DateTimePicker
    Friend WithEvents colsel As DataGridViewCheckBoxColumn
    Friend WithEvents colInterfaceYarnLogid As DataGridViewTextBoxColumn
    Friend WithEvents colInterfaceYarnLogno As DataGridViewTextBoxColumn
    Friend WithEvents colitcd As DataGridViewTextBoxColumn
    Friend WithEvents colGradeOur As DataGridViewTextBoxColumn
    Friend WithEvents colGrade As DataGridViewTextBoxColumn
    Friend WithEvents colboxno_s As DataGridViewTextBoxColumn
    Friend WithEvents colspools As DataGridViewTextBoxColumn
    Friend WithEvents colkg_gr As DataGridViewTextBoxColumn
    Friend WithEvents colkg_nt As DataGridViewTextBoxColumn
    Friend WithEvents colcart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents colboxno As DataGridViewTextBoxColumn
    Friend WithEvents colmtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents colmtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents colmtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents colloc As DataGridViewComboBoxColumn
    Friend WithEvents colloc_sub As DataGridViewTextBoxColumn
    Friend WithEvents colLotnoSup As DataGridViewTextBoxColumn
    Friend WithEvents colLotnoOur As DataGridViewTextBoxColumn
    Friend WithEvents colbox_remark As DataGridViewTextBoxColumn
End Class
