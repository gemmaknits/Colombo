<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnInPurchaseFromSupplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnInPurchaseFromSupplier))
        Me.txtInterfaceYarnOutno = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppInvNo = New System.Windows.Forms.TextBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSuppLot = New System.Windows.Forms.TextBox()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSuppRefNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbomtl_locations = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.txtitcd = New System.Windows.Forms.TextBox()
        Me.txtTotalTubes = New System.Windows.Forms.TextBox()
        Me.txtDocNo = New System.Windows.Forms.TextBox()
        Me.dtpDocDate = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdPO = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotalBoxes = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTotalGrossWeight = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdYarnIN = New System.Windows.Forms.DataGridView()
        Me.cboITCD = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbograde_our = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.loc_sub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotnoSup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotnoOur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_jobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterfaceYarnOutno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpSinvdt = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintBarcode = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delidt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInterfaceYarnOutno
        '
        Me.txtInterfaceYarnOutno.CausesValidation = False
        Me.txtInterfaceYarnOutno.Location = New System.Drawing.Point(86, 23)
        Me.txtInterfaceYarnOutno.Name = "txtInterfaceYarnOutno"
        Me.txtInterfaceYarnOutno.Size = New System.Drawing.Size(115, 22)
        Me.txtInterfaceYarnOutno.TabIndex = 123
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Sup Y-Out #:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(198, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Other ref:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sup.Lot#:"
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(86, 80)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(264, 21)
        Me.cboSupplier.TabIndex = 1
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Sup.Inv.Date:"
        '
        'txtSuppInvNo
        '
        Me.txtSuppInvNo.Location = New System.Drawing.Point(86, 112)
        Me.txtSuppInvNo.Name = "txtSuppInvNo"
        Me.txtSuppInvNo.Size = New System.Drawing.Size(112, 22)
        Me.txtSuppInvNo.TabIndex = 2
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Sup.inv.#:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Supplier:"
        '
        'txtSuppLot
        '
        Me.txtSuppLot.Location = New System.Drawing.Point(254, 112)
        Me.txtSuppLot.Name = "txtSuppLot"
        Me.txtSuppLot.Size = New System.Drawing.Size(96, 22)
        Me.txtSuppLot.TabIndex = 3
        '
        'txtPONo
        '
        Me.txtPONo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPONo.Location = New System.Drawing.Point(86, 51)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(112, 20)
        Me.txtPONo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PO No."
        '
        'txtSuppRefNo
        '
        Me.txtSuppRefNo.Location = New System.Drawing.Point(254, 136)
        Me.txtSuppRefNo.Name = "txtSuppRefNo"
        Me.txtSuppRefNo.Size = New System.Drawing.Size(96, 22)
        Me.txtSuppRefNo.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbomtl_locations)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(708, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 99)
        Me.GroupBox2.TabIndex = 387
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock Locations"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_warehouse.TabIndex = 2
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
        'cbomtl_locations
        '
        Me.cbomtl_locations.FormattingEnabled = True
        Me.cbomtl_locations.Location = New System.Drawing.Point(82, 73)
        Me.cbomtl_locations.Name = "cbomtl_locations"
        Me.cbomtl_locations.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_locations.TabIndex = 4
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
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(134, 21)
        Me.cbomtl_subinventory.TabIndex = 3
        '
        'txtitcd
        '
        Me.txtitcd.Location = New System.Drawing.Point(17, 34)
        Me.txtitcd.Name = "txtitcd"
        Me.txtitcd.Size = New System.Drawing.Size(100, 20)
        Me.txtitcd.TabIndex = 12
        '
        'txtTotalTubes
        '
        Me.txtTotalTubes.Location = New System.Drawing.Point(48, 48)
        Me.txtTotalTubes.Name = "txtTotalTubes"
        Me.txtTotalTubes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalTubes.TabIndex = 3
        '
        'txtDocNo
        '
        Me.txtDocNo.Location = New System.Drawing.Point(82, 20)
        Me.txtDocNo.Name = "txtDocNo"
        Me.txtDocNo.Size = New System.Drawing.Size(134, 22)
        Me.txtDocNo.TabIndex = 0
        '
        'dtpDocDate
        '
        Me.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDate.Location = New System.Drawing.Point(82, 44)
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Y-IN Date:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(781, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 384
        Me.Label9.Text = "*1 Yarn IN Only 1 P/O Item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Y-IN No.:"
        '
        'grdPO
        '
        Me.grdPO.AllowUserToAddRows = False
        Me.grdPO.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdPO.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPO.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdPO.ColumnHeadersHeight = 35
        Me.grdPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.itcd, Me.suppitcd, Me.qty, Me.delidt})
        Me.grdPO.Location = New System.Drawing.Point(380, 8)
        Me.grdPO.Name = "grdPO"
        Me.grdPO.RowHeadersVisible = False
        Me.grdPO.Size = New System.Drawing.Size(322, 134)
        Me.grdPO.TabIndex = 373
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
        'txtTotalBoxes
        '
        Me.txtTotalBoxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotalBoxes.Location = New System.Drawing.Point(48, 24)
        Me.txtTotalBoxes.Name = "txtTotalBoxes"
        Me.txtTotalBoxes.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalBoxes.TabIndex = 1
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
        Me.GroupBox5.Location = New System.Drawing.Point(708, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(229, 80)
        Me.GroupBox5.TabIndex = 383
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Document"
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
        'txtTotalGrossWeight
        '
        Me.txtTotalGrossWeight.Location = New System.Drawing.Point(192, 24)
        Me.txtTotalGrossWeight.Name = "txtTotalGrossWeight"
        Me.txtTotalGrossWeight.Size = New System.Drawing.Size(56, 20)
        Me.txtTotalGrossWeight.TabIndex = 2
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
        Me.GroupBox4.Location = New System.Drawing.Point(369, 499)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 80)
        Me.GroupBox4.TabIndex = 382
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
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.txtitcd)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1, 499)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox3.TabIndex = 381
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'grdYarnIN
        '
        Me.grdYarnIN.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdYarnIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdYarnIN.ColumnHeadersHeight = 35
        Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cboITCD, Me.cbograde_our, Me.Grade, Me.boxno_s, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt, Me.boxno, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.loc, Me.loc_sub, Me.LotnoSup, Me.LotnoOur, Me.box_remark, Me.id_jobdet, Me.InterfaceYarnOutno})
        Me.grdYarnIN.Location = New System.Drawing.Point(1, 192)
        Me.grdYarnIN.Name = "grdYarnIN"
        Me.grdYarnIN.Size = New System.Drawing.Size(944, 299)
        Me.grdYarnIN.TabIndex = 374
        '
        'cboITCD
        '
        Me.cboITCD.DataPropertyName = "itcd"
        Me.cboITCD.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cboITCD.HeaderText = "Description"
        Me.cboITCD.Name = "cboITCD"
        Me.cboITCD.ReadOnly = True
        Me.cboITCD.Width = 250
        '
        'cbograde_our
        '
        Me.cbograde_our.DataPropertyName = "grade_our"
        Me.cbograde_our.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cbograde_our.HeaderText = "Grade Our"
        Me.cbograde_our.Name = "cbograde_our"
        Me.cbograde_our.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbograde_our.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbograde_our.Width = 60
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
        Me.boxno_s.Width = 75
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube /Spools"
        Me.spools.MaxInputLength = 15
        Me.spools.Name = "spools"
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross weight{Kg}"
        Me.kg_gr.MaxInputLength = 15
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.Width = 75
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.MaxInputLength = 15
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kg_nt.Width = 75
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
        Me.cart_tearwt.MaxInputLength = 15
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.Width = 75
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal box no. (auto)"
        Me.boxno.MaxInputLength = 15
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 60
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_warehouse_id.Visible = False
        Me.mtl_warehouse_id.Width = 70
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "Subinventory"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Visible = False
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Location"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_locations_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.mtl_locations_id.Visible = False
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Loc"
        Me.loc.Name = "loc"
        Me.loc.Visible = False
        '
        'loc_sub
        '
        Me.loc_sub.DataPropertyName = "loc_sub"
        Me.loc_sub.HeaderText = "Sub Location"
        Me.loc_sub.Name = "loc_sub"
        Me.loc_sub.Visible = False
        '
        'LotnoSup
        '
        Me.LotnoSup.DataPropertyName = "lotno_sup"
        Me.LotnoSup.HeaderText = "Lot No. Sup"
        Me.LotnoSup.Name = "LotnoSup"
        Me.LotnoSup.ReadOnly = True
        '
        'LotnoOur
        '
        Me.LotnoOur.DataPropertyName = "lotno_our"
        Me.LotnoOur.HeaderText = "Lot No. Our"
        Me.LotnoOur.Name = "LotnoOur"
        Me.LotnoOur.ReadOnly = True
        '
        'box_remark
        '
        Me.box_remark.DataPropertyName = "box_remark"
        Me.box_remark.HeaderText = "Remark"
        Me.box_remark.Name = "box_remark"
        Me.box_remark.Width = 150
        '
        'id_jobdet
        '
        Me.id_jobdet.DataPropertyName = "id_jobdet"
        Me.id_jobdet.HeaderText = "ID Job Detail"
        Me.id_jobdet.Name = "id_jobdet"
        Me.id_jobdet.ReadOnly = True
        Me.id_jobdet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_jobdet.Width = 50
        '
        'InterfaceYarnOutno
        '
        Me.InterfaceYarnOutno.DataPropertyName = "interface_yarn_outno"
        Me.InterfaceYarnOutno.HeaderText = "Supplier Y-OUT No."
        Me.InterfaceYarnOutno.Name = "InterfaceYarnOutno"
        Me.InterfaceYarnOutno.Width = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSinvdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtInterfaceYarnOutno)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSuppInvNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSuppLot)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSuppRefNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 178)
        Me.GroupBox1.TabIndex = 380
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GMK Supplier details:"
        '
        'dtpSinvdt
        '
        Me.dtpSinvdt.Checked = False
        Me.dtpSinvdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpSinvdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSinvdt.Location = New System.Drawing.Point(85, 138)
        Me.dtpSinvdt.Name = "dtpSinvdt"
        Me.dtpSinvdt.ShowCheckBox = True
        Me.dtpSinvdt.Size = New System.Drawing.Size(113, 22)
        Me.dtpSinvdt.TabIndex = 389
        Me.dtpSinvdt.Value = New Date(2015, 4, 27, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(207, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 13)
        Me.Label10.TabIndex = 388
        Me.Label10.Text = "*1 YO Only 1 Item Code"
        '
        'btnDel
        '
        Me.btnDel.Image = Global.YarnStockSystem.My.Resources.Resources.Cancel_16x
        Me.btnDel.Location = New System.Drawing.Point(561, 145)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(93, 25)
        Me.btnDel.TabIndex = 386
        Me.btnDel.Text = "Delete Row"
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.YarnStockSystem.My.Resources.Resources.Add_16x
        Me.btnAdd.Location = New System.Drawing.Point(380, 145)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 25)
        Me.btnAdd.TabIndex = 385
        Me.btnAdd.Text = "Get Data"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(633, 523)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 44)
        Me.btnNew.TabIndex = 375
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
        Me.btnSave.Location = New System.Drawing.Point(697, 523)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 44)
        Me.btnSave.TabIndex = 376
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
        Me.btnPrint.Location = New System.Drawing.Point(761, 523)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(60, 44)
        Me.btnPrint.TabIndex = 377
        Me.btnPrint.Text = "Print"
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
        Me.btnPrintBarcode.Location = New System.Drawing.Point(825, 523)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(60, 44)
        Me.btnPrintBarcode.TabIndex = 378
        Me.btnPrintBarcode.Text = "Print bar label"
        Me.btnPrintBarcode.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnPrintBarcode.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(889, 523)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(60, 44)
        Me.btnExit.TabIndex = 379
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.Location = New System.Drawing.Point(469, 145)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(84, 25)
        Me.btnCopy.TabIndex = 403
        Me.btnCopy.Tag = "Copy"
        Me.btnCopy.Text = "Copy Row"
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(525, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 13)
        Me.Label15.TabIndex = 404
        Me.Label15.Text = "*Select P/O Items and Click +"
        '
        'colID
        '
        Me.colID.DataPropertyName = "id_jobdet"
        Me.colID.HeaderText = "ID Job Detail"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colID.Width = 50
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 70
        '
        'suppitcd
        '
        Me.suppitcd.DataPropertyName = "suppitcd"
        Me.suppitcd.HeaderText = "Supp Items Code"
        Me.suppitcd.Name = "suppitcd"
        Me.suppitcd.ReadOnly = True
        Me.suppitcd.Width = 70
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 80
        '
        'delidt
        '
        Me.delidt.DataPropertyName = "delidt"
        Me.delidt.HeaderText = "Delivery"
        Me.delidt.Name = "delidt"
        Me.delidt.ReadOnly = True
        '
        'formYarnInPurchaseFromSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 582)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grdPO)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPrintBarcode)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grdYarnIN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formYarnInPurchaseFromSupplier"
        Me.Text = "YarnIn Purchase From GMK"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutno As TextBox
    Friend WithEvents txtSuppInvDate As TextBox
    Friend WithEvents txtInterfaceYarnOutno As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuppInvNo As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSuppLot As TextBox
    Friend WithEvents txtPONo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSuppRefNo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbomtl_locations As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbomtl_subinventory As ComboBox
    Friend WithEvents txtitcd As TextBox
    Friend WithEvents txtTotalTubes As TextBox
    Friend WithEvents txtDocNo As TextBox
    Friend WithEvents dtpDocDate As DateTimePicker
    Friend WithEvents lblYINno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents grdPO As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtTotalBoxes As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTotalGrossWeight As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents btnPrintBarcode As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTotalNetWeight As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents grdYarnIN As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboITCD As DataGridViewComboBoxColumn
    Friend WithEvents cbograde_our As DataGridViewComboBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents loc As DataGridViewComboBoxColumn
    Friend WithEvents loc_sub As DataGridViewTextBoxColumn
    Friend WithEvents LotnoSup As DataGridViewTextBoxColumn
    Friend WithEvents LotnoOur As DataGridViewTextBoxColumn
    Friend WithEvents box_remark As DataGridViewTextBoxColumn
    Friend WithEvents id_jobdet As DataGridViewTextBoxColumn
    Friend WithEvents InterfaceYarnOutno As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpSinvdt As DateTimePicker
    Friend WithEvents btnCopy As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents itcd As DataGridViewTextBoxColumn
    Friend WithEvents suppitcd As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents delidt As DataGridViewTextBoxColumn
End Class
