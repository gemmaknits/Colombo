<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuttingIN))
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.lblOutNo = New System.Windows.Forms.Label()
        Me.txtCInNo = New System.Windows.Forms.TextBox()
        Me.lblCInNo = New System.Windows.Forms.Label()
        Me.dtpCinDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCinDate = New System.Windows.Forms.Label()
        Me.dgvDout = New System.Windows.Forms.DataGridView()
        Me.colDyedOutIdStrollsDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutSoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutSoNoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedOutYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCuttingIN = New System.Windows.Forms.DataGridView()
        Me.lblOutReqNo = New System.Windows.Forms.Label()
        Me.txtOutReqNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbCINDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbCINTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchCIN = New System.Windows.Forms.Button()
        Me.lblDyedOut = New System.Windows.Forms.Label()
        Me.lblCuttingIN = New System.Windows.Forms.Label()
        Me.lblTotalRolls = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.lblTotalKg = New System.Windows.Forms.Label()
        Me.txtTotalKg = New System.Windows.Forms.TextBox()
        Me.lblTotalMts = New System.Windows.Forms.Label()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.lblTotalYds = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.colCuttingINIdStrollsDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINSoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINSoNoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINDfNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRollNoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCuttingINMtlWarehouse = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colCuttingINMtlSubInventory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colCuttingINMtlLocation = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgvDout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCuttingIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(12, 46)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(100, 22)
        Me.txtOutNo.TabIndex = 0
        '
        'lblOutNo
        '
        Me.lblOutNo.AutoSize = True
        Me.lblOutNo.Location = New System.Drawing.Point(9, 31)
        Me.lblOutNo.Name = "lblOutNo"
        Me.lblOutNo.Size = New System.Drawing.Size(48, 13)
        Me.lblOutNo.TabIndex = 1
        Me.lblOutNo.Text = "Out No."
        '
        'txtCInNo
        '
        Me.txtCInNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCInNo.Location = New System.Drawing.Point(800, 46)
        Me.txtCInNo.Name = "txtCInNo"
        Me.txtCInNo.Size = New System.Drawing.Size(100, 22)
        Me.txtCInNo.TabIndex = 2
        '
        'lblCInNo
        '
        Me.lblCInNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCInNo.AutoSize = True
        Me.lblCInNo.Location = New System.Drawing.Point(797, 31)
        Me.lblCInNo.Name = "lblCInNo"
        Me.lblCInNo.Size = New System.Drawing.Size(46, 13)
        Me.lblCInNo.TabIndex = 3
        Me.lblCInNo.Text = "CIN No."
        '
        'dtpCinDate
        '
        Me.dtpCinDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpCinDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCinDate.Location = New System.Drawing.Point(693, 46)
        Me.dtpCinDate.Name = "dtpCinDate"
        Me.dtpCinDate.Size = New System.Drawing.Size(100, 22)
        Me.dtpCinDate.TabIndex = 4
        '
        'lblCinDate
        '
        Me.lblCinDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCinDate.AutoSize = True
        Me.lblCinDate.Location = New System.Drawing.Point(690, 31)
        Me.lblCinDate.Name = "lblCinDate"
        Me.lblCinDate.Size = New System.Drawing.Size(34, 13)
        Me.lblCinDate.TabIndex = 5
        Me.lblCinDate.Text = "Date."
        '
        'dgvDout
        '
        Me.dgvDout.AllowUserToAddRows = False
        Me.dgvDout.AllowUserToDeleteRows = False
        Me.dgvDout.AllowUserToResizeColumns = False
        Me.dgvDout.AllowUserToResizeRows = False
        Me.dgvDout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDout.ColumnHeadersHeight = 35
        Me.dgvDout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDyedOutIdStrollsDO, Me.colDyedOutSoNo, Me.colDyedOutSoNoId, Me.colRollNoD, Me.colDyedOutDesignNo, Me.colLot, Me.colCol, Me.colDyedOutKg, Me.colDyedOutMts, Me.colDyedOutYds})
        Me.dgvDout.Location = New System.Drawing.Point(12, 91)
        Me.dgvDout.Name = "dgvDout"
        Me.dgvDout.Size = New System.Drawing.Size(917, 155)
        Me.dgvDout.TabIndex = 6
        '
        'colDyedOutIdStrollsDO
        '
        Me.colDyedOutIdStrollsDO.DataPropertyName = "id_strolls_d_o"
        Me.colDyedOutIdStrollsDO.HeaderText = "IdStrollsDO"
        Me.colDyedOutIdStrollsDO.Name = "colDyedOutIdStrollsDO"
        Me.colDyedOutIdStrollsDO.ReadOnly = True
        Me.colDyedOutIdStrollsDO.Visible = False
        '
        'colDyedOutSoNo
        '
        Me.colDyedOutSoNo.DataPropertyName = "sono"
        Me.colDyedOutSoNo.HeaderText = "S/O No."
        Me.colDyedOutSoNo.Name = "colDyedOutSoNo"
        Me.colDyedOutSoNo.ReadOnly = True
        Me.colDyedOutSoNo.Visible = False
        '
        'colDyedOutSoNoId
        '
        Me.colDyedOutSoNoId.DataPropertyName = "sonoid"
        Me.colDyedOutSoNoId.HeaderText = "S/O No Id"
        Me.colDyedOutSoNoId.Name = "colDyedOutSoNoId"
        Me.colDyedOutSoNoId.ReadOnly = True
        Me.colDyedOutSoNoId.Visible = False
        '
        'colRollNoD
        '
        Me.colRollNoD.DataPropertyName = "roll_no_d"
        Me.colRollNoD.HeaderText = "Roll No D"
        Me.colRollNoD.Name = "colRollNoD"
        Me.colRollNoD.ReadOnly = True
        '
        'colDyedOutDesignNo
        '
        Me.colDyedOutDesignNo.DataPropertyName = "design_no"
        Me.colDyedOutDesignNo.HeaderText = "Design No."
        Me.colDyedOutDesignNo.Name = "colDyedOutDesignNo"
        Me.colDyedOutDesignNo.ReadOnly = True
        '
        'colLot
        '
        Me.colLot.DataPropertyName = "lot"
        Me.colLot.HeaderText = "Lot"
        Me.colLot.Name = "colLot"
        Me.colLot.ReadOnly = True
        '
        'colCol
        '
        Me.colCol.DataPropertyName = "col"
        Me.colCol.HeaderText = "Color Code"
        Me.colCol.Name = "colCol"
        Me.colCol.ReadOnly = True
        '
        'colDyedOutKg
        '
        Me.colDyedOutKg.DataPropertyName = "kg"
        Me.colDyedOutKg.HeaderText = "Kg"
        Me.colDyedOutKg.Name = "colDyedOutKg"
        Me.colDyedOutKg.ReadOnly = True
        Me.colDyedOutKg.Width = 50
        '
        'colDyedOutMts
        '
        Me.colDyedOutMts.DataPropertyName = "mts"
        Me.colDyedOutMts.HeaderText = "Mts"
        Me.colDyedOutMts.Name = "colDyedOutMts"
        Me.colDyedOutMts.ReadOnly = True
        Me.colDyedOutMts.Width = 50
        '
        'colDyedOutYds
        '
        Me.colDyedOutYds.DataPropertyName = "yds"
        Me.colDyedOutYds.HeaderText = "Yds"
        Me.colDyedOutYds.Name = "colDyedOutYds"
        Me.colDyedOutYds.ReadOnly = True
        Me.colDyedOutYds.Width = 50
        '
        'dgvCuttingIN
        '
        Me.dgvCuttingIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuttingIN.ColumnHeadersHeight = 35
        Me.dgvCuttingIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCuttingINIdStrollsDO, Me.colCuttingINSoNo, Me.colCuttingINSoNoId, Me.colCuttingINDfNo, Me.colRollNoP, Me.colCuttingINDesignNo, Me.colCuttingRollNoD, Me.colRollNoO, Me.colGr, Me.colCuttingINKg, Me.colCuttingINMts, Me.colCuttingINYds, Me.colCuttingINMtlWarehouse, Me.colCuttingINMtlSubInventory, Me.colCuttingINMtlLocation})
        Me.dgvCuttingIN.Location = New System.Drawing.Point(12, 274)
        Me.dgvCuttingIN.Name = "dgvCuttingIN"
        Me.dgvCuttingIN.Size = New System.Drawing.Size(917, 208)
        Me.dgvCuttingIN.TabIndex = 7
        '
        'lblOutReqNo
        '
        Me.lblOutReqNo.AutoSize = True
        Me.lblOutReqNo.Location = New System.Drawing.Point(114, 31)
        Me.lblOutReqNo.Name = "lblOutReqNo"
        Me.lblOutReqNo.Size = New System.Drawing.Size(70, 13)
        Me.lblOutReqNo.TabIndex = 9
        Me.lblOutReqNo.Text = "Request No."
        '
        'txtOutReqNo
        '
        Me.txtOutReqNo.Location = New System.Drawing.Point(117, 46)
        Me.txtOutReqNo.Name = "txtOutReqNo"
        Me.txtOutReqNo.ReadOnly = True
        Me.txtOutReqNo.Size = New System.Drawing.Size(100, 22)
        Me.txtOutReqNo.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.ToolStripDropDownButton1, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(941, 25)
        Me.ToolStrip1.TabIndex = 328
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.Visible = False
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCINDocument, Me.tsbCINTag})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbCINDocument
        '
        Me.tsbCINDocument.Name = "tsbCINDocument"
        Me.tsbCINDocument.Size = New System.Drawing.Size(158, 22)
        Me.tsbCINDocument.Text = "C-IN Document"
        '
        'tsbCINTag
        '
        Me.tsbCINTag.Name = "tsbCINTag"
        Me.tsbCINTag.Size = New System.Drawing.Size(158, 22)
        Me.tsbCINTag.Text = "C-IN Tag"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnSearchCIN
        '
        Me.btnSearchCIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchCIN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCIN.Image = CType(resources.GetObject("btnSearchCIN.Image"), System.Drawing.Image)
        Me.btnSearchCIN.Location = New System.Drawing.Point(906, 46)
        Me.btnSearchCIN.Name = "btnSearchCIN"
        Me.btnSearchCIN.Size = New System.Drawing.Size(25, 25)
        Me.btnSearchCIN.TabIndex = 337
        Me.btnSearchCIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchCIN.UseVisualStyleBackColor = True
        Me.btnSearchCIN.Visible = False
        '
        'lblDyedOut
        '
        Me.lblDyedOut.AutoSize = True
        Me.lblDyedOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDyedOut.Location = New System.Drawing.Point(13, 75)
        Me.lblDyedOut.Name = "lblDyedOut"
        Me.lblDyedOut.Size = New System.Drawing.Size(56, 13)
        Me.lblDyedOut.TabIndex = 338
        Me.lblDyedOut.Text = "Dyed Out"
        '
        'lblCuttingIN
        '
        Me.lblCuttingIN.AutoSize = True
        Me.lblCuttingIN.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuttingIN.Location = New System.Drawing.Point(9, 256)
        Me.lblCuttingIN.Name = "lblCuttingIN"
        Me.lblCuttingIN.Size = New System.Drawing.Size(61, 13)
        Me.lblCuttingIN.TabIndex = 339
        Me.lblCuttingIN.Text = "Cutting IN"
        '
        'lblTotalRolls
        '
        Me.lblTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalRolls.AutoSize = True
        Me.lblTotalRolls.Location = New System.Drawing.Point(315, 255)
        Me.lblTotalRolls.Name = "lblTotalRolls"
        Me.lblTotalRolls.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalRolls.TabIndex = 346
        Me.lblTotalRolls.Text = "Total Rolls"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalRolls.Location = New System.Drawing.Point(382, 251)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(88, 22)
        Me.txtTotalRolls.TabIndex = 347
        Me.txtTotalRolls.Text = "0"
        Me.txtTotalRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalKg
        '
        Me.lblTotalKg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalKg.AutoSize = True
        Me.lblTotalKg.Location = New System.Drawing.Point(482, 255)
        Me.lblTotalKg.Name = "lblTotalKg"
        Me.lblTotalKg.Size = New System.Drawing.Size(47, 13)
        Me.lblTotalKg.TabIndex = 340
        Me.lblTotalKg.Text = "Total Kg"
        '
        'txtTotalKg
        '
        Me.txtTotalKg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKg.Location = New System.Drawing.Point(535, 251)
        Me.txtTotalKg.Name = "txtTotalKg"
        Me.txtTotalKg.ReadOnly = True
        Me.txtTotalKg.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalKg.TabIndex = 341
        Me.txtTotalKg.Text = "0.00"
        Me.txtTotalKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalMts
        '
        Me.lblTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalMts.AutoSize = True
        Me.lblTotalMts.Location = New System.Drawing.Point(641, 255)
        Me.lblTotalMts.Name = "lblTotalMts"
        Me.lblTotalMts.Size = New System.Drawing.Size(52, 13)
        Me.lblTotalMts.TabIndex = 342
        Me.lblTotalMts.Text = "Total Mts"
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMts.Location = New System.Drawing.Point(699, 251)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalMts.TabIndex = 343
        Me.txtTotalMts.Text = "0.00"
        Me.txtTotalMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalYds
        '
        Me.lblTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalYds.AutoSize = True
        Me.lblTotalYds.Location = New System.Drawing.Point(805, 255)
        Me.lblTotalYds.Name = "lblTotalYds"
        Me.lblTotalYds.Size = New System.Drawing.Size(51, 13)
        Me.lblTotalYds.TabIndex = 344
        Me.lblTotalYds.Text = "Total Yds"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalYds.Location = New System.Drawing.Point(862, 251)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(67, 22)
        Me.txtTotalYds.TabIndex = 345
        Me.txtTotalYds.Text = "0.00"
        Me.txtTotalYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'colCuttingINIdStrollsDO
        '
        Me.colCuttingINIdStrollsDO.DataPropertyName = "id_strolls_d_o"
        Me.colCuttingINIdStrollsDO.HeaderText = "ID Strolls D O"
        Me.colCuttingINIdStrollsDO.Name = "colCuttingINIdStrollsDO"
        Me.colCuttingINIdStrollsDO.ReadOnly = True
        Me.colCuttingINIdStrollsDO.Visible = False
        '
        'colCuttingINSoNo
        '
        Me.colCuttingINSoNo.DataPropertyName = "sono"
        Me.colCuttingINSoNo.HeaderText = "S/O No"
        Me.colCuttingINSoNo.Name = "colCuttingINSoNo"
        Me.colCuttingINSoNo.ReadOnly = True
        Me.colCuttingINSoNo.Visible = False
        '
        'colCuttingINSoNoId
        '
        Me.colCuttingINSoNoId.DataPropertyName = "sonoid"
        Me.colCuttingINSoNoId.HeaderText = "S/O No Id"
        Me.colCuttingINSoNoId.Name = "colCuttingINSoNoId"
        Me.colCuttingINSoNoId.ReadOnly = True
        Me.colCuttingINSoNoId.Visible = False
        '
        'colCuttingINDfNo
        '
        Me.colCuttingINDfNo.DataPropertyName = "dfno"
        Me.colCuttingINDfNo.HeaderText = "D/F No."
        Me.colCuttingINDfNo.Name = "colCuttingINDfNo"
        Me.colCuttingINDfNo.ReadOnly = True
        Me.colCuttingINDfNo.Visible = False
        '
        'colRollNoP
        '
        Me.colRollNoP.DataPropertyName = "roll_no_p"
        Me.colRollNoP.HeaderText = "Parent Roll No D"
        Me.colRollNoP.Name = "colRollNoP"
        Me.colRollNoP.ReadOnly = True
        Me.colRollNoP.Width = 80
        '
        'colCuttingINDesignNo
        '
        Me.colCuttingINDesignNo.DataPropertyName = "design_no"
        Me.colCuttingINDesignNo.HeaderText = "Design No."
        Me.colCuttingINDesignNo.Name = "colCuttingINDesignNo"
        Me.colCuttingINDesignNo.ReadOnly = True
        Me.colCuttingINDesignNo.Visible = False
        '
        'colCuttingRollNoD
        '
        Me.colCuttingRollNoD.DataPropertyName = "roll_no_d"
        Me.colCuttingRollNoD.HeaderText = "Roll No"
        Me.colCuttingRollNoD.Name = "colCuttingRollNoD"
        '
        'colRollNoO
        '
        Me.colRollNoO.DataPropertyName = "roll_no_o"
        Me.colRollNoO.HeaderText = "Roll No O"
        Me.colRollNoO.Name = "colRollNoO"
        Me.colRollNoO.Width = 80
        '
        'colGr
        '
        Me.colGr.DataPropertyName = "gr"
        Me.colGr.HeaderText = "Grade"
        Me.colGr.Name = "colGr"
        Me.colGr.Width = 50
        '
        'colCuttingINKg
        '
        Me.colCuttingINKg.DataPropertyName = "kg"
        Me.colCuttingINKg.HeaderText = "Kg"
        Me.colCuttingINKg.Name = "colCuttingINKg"
        Me.colCuttingINKg.Width = 50
        '
        'colCuttingINMts
        '
        Me.colCuttingINMts.DataPropertyName = "mts"
        Me.colCuttingINMts.HeaderText = "Mts"
        Me.colCuttingINMts.Name = "colCuttingINMts"
        Me.colCuttingINMts.Width = 50
        '
        'colCuttingINYds
        '
        Me.colCuttingINYds.DataPropertyName = "yds"
        Me.colCuttingINYds.HeaderText = "Yds"
        Me.colCuttingINYds.Name = "colCuttingINYds"
        Me.colCuttingINYds.Width = 50
        '
        'colCuttingINMtlWarehouse
        '
        Me.colCuttingINMtlWarehouse.DataPropertyName = "mtl_warehouse_id"
        Me.colCuttingINMtlWarehouse.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colCuttingINMtlWarehouse.HeaderText = "W/H"
        Me.colCuttingINMtlWarehouse.Name = "colCuttingINMtlWarehouse"
        Me.colCuttingINMtlWarehouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCuttingINMtlWarehouse.Visible = False
        '
        'colCuttingINMtlSubInventory
        '
        Me.colCuttingINMtlSubInventory.DataPropertyName = "mtl_subinventory_id"
        Me.colCuttingINMtlSubInventory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colCuttingINMtlSubInventory.HeaderText = "Sub"
        Me.colCuttingINMtlSubInventory.Name = "colCuttingINMtlSubInventory"
        Me.colCuttingINMtlSubInventory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colCuttingINMtlLocation
        '
        Me.colCuttingINMtlLocation.DataPropertyName = "mtl_locations_id"
        Me.colCuttingINMtlLocation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colCuttingINMtlLocation.HeaderText = "Location"
        Me.colCuttingINMtlLocation.Name = "colCuttingINMtlLocation"
        Me.colCuttingINMtlLocation.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'frmCuttingIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 504)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.lblTotalRolls)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.lblTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.lblTotalMts)
        Me.Controls.Add(Me.txtTotalKg)
        Me.Controls.Add(Me.lblTotalKg)
        Me.Controls.Add(Me.lblCuttingIN)
        Me.Controls.Add(Me.lblDyedOut)
        Me.Controls.Add(Me.btnSearchCIN)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblOutReqNo)
        Me.Controls.Add(Me.txtOutReqNo)
        Me.Controls.Add(Me.dgvCuttingIN)
        Me.Controls.Add(Me.dgvDout)
        Me.Controls.Add(Me.lblCinDate)
        Me.Controls.Add(Me.dtpCinDate)
        Me.Controls.Add(Me.lblCInNo)
        Me.Controls.Add(Me.txtCInNo)
        Me.Controls.Add(Me.lblOutNo)
        Me.Controls.Add(Me.txtOutNo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCuttingIN"
        Me.Text = "Cutting IN"
        CType(Me.dgvDout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCuttingIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents lblOutNo As Label
    Friend WithEvents txtCInNo As TextBox
    Friend WithEvents lblCInNo As Label
    Friend WithEvents dtpCinDate As DateTimePicker
    Friend WithEvents lblCinDate As Label
    Friend WithEvents dgvDout As DataGridView
    Friend WithEvents dgvCuttingIN As DataGridView
    Friend WithEvents lblOutReqNo As Label
    Friend WithEvents txtOutReqNo As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnSearchCIN As Button
    Friend WithEvents lblDyedOut As Label
    Friend WithEvents lblCuttingIN As Label
    Friend WithEvents lblTotalRolls As Label
    Friend WithEvents txtTotalRolls As TextBox
    Friend WithEvents lblTotalKg As Label
    Friend WithEvents txtTotalKg As TextBox
    Friend WithEvents lblTotalMts As Label
    Friend WithEvents txtTotalMts As TextBox
    Friend WithEvents lblTotalYds As Label
    Friend WithEvents txtTotalYds As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbCINDocument As ToolStripMenuItem
    Friend WithEvents tsbCINTag As ToolStripMenuItem
    Friend WithEvents colDyedOutIdStrollsDO As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutSoNo As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutSoNoId As DataGridViewTextBoxColumn
    Friend WithEvents colRollNoD As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents colLot As DataGridViewTextBoxColumn
    Friend WithEvents colCol As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutKg As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutMts As DataGridViewTextBoxColumn
    Friend WithEvents colDyedOutYds As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINIdStrollsDO As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINSoNo As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINSoNoId As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINDfNo As DataGridViewTextBoxColumn
    Friend WithEvents colRollNoP As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingRollNoD As DataGridViewTextBoxColumn
    Friend WithEvents colRollNoO As DataGridViewTextBoxColumn
    Friend WithEvents colGr As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINKg As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINMts As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINYds As DataGridViewTextBoxColumn
    Friend WithEvents colCuttingINMtlWarehouse As DataGridViewComboBoxColumn
    Friend WithEvents colCuttingINMtlSubInventory As DataGridViewComboBoxColumn
    Friend WithEvents colCuttingINMtlLocation As DataGridViewComboBoxColumn
End Class
