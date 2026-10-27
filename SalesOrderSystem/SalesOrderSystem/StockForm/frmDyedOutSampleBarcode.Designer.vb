<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyedOutSampleBarcode
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedOutSampleBarcode))
        Me.grdDoutNew = New System.Windows.Forms.DataGridView()
        Me.grdDoutNewSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDStrollsDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewCustColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRollNoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRequestMtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewRemQC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDoutNewLocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbDesignNo = New System.Windows.Forms.Label()
        Me.txtIDstrollsdo = New System.Windows.Forms.TextBox()
        Me.txtkgs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMts = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOutno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpOutDt = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYds = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmtkg = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.BtnMakeDyedout = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        CType(Me.grdDoutNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDoutNew
        '
        Me.grdDoutNew.AllowUserToAddRows = False
        Me.grdDoutNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDoutNew.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdDoutNew.ColumnHeadersHeight = 60
        Me.grdDoutNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdDoutNew.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDoutNewSel, Me.IDStrollsDO, Me.grdDoutNewDesignNo, Me.grdDoutNewRefdesno, Me.grdDoutNewCol, Me.grdDoutNewCustColor, Me.grdDoutNewLot, Me.grdDoutNewRollNoD, Me.grdDoutNewRollNoO, Me.grdDoutNewKg, Me.grdDoutNewMts, Me.grdDoutNewYds, Me.grdDoutNewRequestKg, Me.grdDoutNewRequestMts, Me.grdDoutNewRequestYds, Me.grdDoutNewRequestMtkg, Me.grdDoutNewRemQC, Me.grdDoutNewWarehouseCode, Me.grdDoutNewLocationName})
        Me.grdDoutNew.Location = New System.Drawing.Point(40, 187)
        Me.grdDoutNew.Name = "grdDoutNew"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDoutNew.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdDoutNew.Size = New System.Drawing.Size(938, 304)
        Me.grdDoutNew.TabIndex = 302
        '
        'grdDoutNewSel
        '
        Me.grdDoutNewSel.DataPropertyName = "Sel"
        Me.grdDoutNewSel.HeaderText = "Sel"
        Me.grdDoutNewSel.Name = "grdDoutNewSel"
        Me.grdDoutNewSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDoutNewSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdDoutNewSel.Width = 50
        '
        'IDStrollsDO
        '
        Me.IDStrollsDO.DataPropertyName = "id_strolls_d_o"
        Me.IDStrollsDO.HeaderText = "Barcode ID"
        Me.IDStrollsDO.Name = "IDStrollsDO"
        '
        'grdDoutNewDesignNo
        '
        Me.grdDoutNewDesignNo.DataPropertyName = "design_no"
        Me.grdDoutNewDesignNo.HeaderText = "Design No"
        Me.grdDoutNewDesignNo.Name = "grdDoutNewDesignNo"
        '
        'grdDoutNewRefdesno
        '
        Me.grdDoutNewRefdesno.DataPropertyName = "refdesco"
        Me.grdDoutNewRefdesno.HeaderText = "Artical"
        Me.grdDoutNewRefdesno.Name = "grdDoutNewRefdesno"
        '
        'grdDoutNewCol
        '
        Me.grdDoutNewCol.DataPropertyName = "col"
        Me.grdDoutNewCol.HeaderText = "Col"
        Me.grdDoutNewCol.Name = "grdDoutNewCol"
        '
        'grdDoutNewCustColor
        '
        Me.grdDoutNewCustColor.DataPropertyName = "custcolor"
        Me.grdDoutNewCustColor.HeaderText = "Cust. Col."
        Me.grdDoutNewCustColor.Name = "grdDoutNewCustColor"
        '
        'grdDoutNewLot
        '
        Me.grdDoutNewLot.DataPropertyName = "lot"
        Me.grdDoutNewLot.HeaderText = "Lot"
        Me.grdDoutNewLot.Name = "grdDoutNewLot"
        '
        'grdDoutNewRollNoD
        '
        Me.grdDoutNewRollNoD.DataPropertyName = "roll_no_d"
        Me.grdDoutNewRollNoD.HeaderText = "Roll No."
        Me.grdDoutNewRollNoD.Name = "grdDoutNewRollNoD"
        '
        'grdDoutNewRollNoO
        '
        Me.grdDoutNewRollNoO.DataPropertyName = "roll_no_o"
        Me.grdDoutNewRollNoO.HeaderText = "Fact. Roll."
        Me.grdDoutNewRollNoO.Name = "grdDoutNewRollNoO"
        '
        'grdDoutNewKg
        '
        Me.grdDoutNewKg.DataPropertyName = "kg"
        Me.grdDoutNewKg.HeaderText = "Bal Kg"
        Me.grdDoutNewKg.Name = "grdDoutNewKg"
        Me.grdDoutNewKg.Visible = False
        Me.grdDoutNewKg.Width = 50
        '
        'grdDoutNewMts
        '
        Me.grdDoutNewMts.DataPropertyName = "mts"
        Me.grdDoutNewMts.HeaderText = "Bal Mts."
        Me.grdDoutNewMts.Name = "grdDoutNewMts"
        Me.grdDoutNewMts.Visible = False
        Me.grdDoutNewMts.Width = 50
        '
        'grdDoutNewYds
        '
        Me.grdDoutNewYds.DataPropertyName = "yds"
        Me.grdDoutNewYds.HeaderText = "Bal Yds."
        Me.grdDoutNewYds.Name = "grdDoutNewYds"
        Me.grdDoutNewYds.Visible = False
        Me.grdDoutNewYds.Width = 50
        '
        'grdDoutNewRequestKg
        '
        Me.grdDoutNewRequestKg.DataPropertyName = "request_kg"
        Me.grdDoutNewRequestKg.HeaderText = "Req Kg"
        Me.grdDoutNewRequestKg.Name = "grdDoutNewRequestKg"
        Me.grdDoutNewRequestKg.Width = 50
        '
        'grdDoutNewRequestMts
        '
        Me.grdDoutNewRequestMts.DataPropertyName = "request_mts"
        Me.grdDoutNewRequestMts.HeaderText = "Req Mts"
        Me.grdDoutNewRequestMts.Name = "grdDoutNewRequestMts"
        Me.grdDoutNewRequestMts.Width = 50
        '
        'grdDoutNewRequestYds
        '
        Me.grdDoutNewRequestYds.DataPropertyName = "request_yds"
        Me.grdDoutNewRequestYds.HeaderText = "Req Yds"
        Me.grdDoutNewRequestYds.Name = "grdDoutNewRequestYds"
        Me.grdDoutNewRequestYds.Width = 50
        '
        'grdDoutNewRequestMtkg
        '
        Me.grdDoutNewRequestMtkg.DataPropertyName = "mtkg"
        Me.grdDoutNewRequestMtkg.HeaderText = "Mtkg"
        Me.grdDoutNewRequestMtkg.Name = "grdDoutNewRequestMtkg"
        Me.grdDoutNewRequestMtkg.Width = 50
        '
        'grdDoutNewRemQC
        '
        Me.grdDoutNewRemQC.DataPropertyName = "rem_qc"
        Me.grdDoutNewRemQC.HeaderText = "Remark QC"
        Me.grdDoutNewRemQC.Name = "grdDoutNewRemQC"
        '
        'grdDoutNewWarehouseCode
        '
        Me.grdDoutNewWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdDoutNewWarehouseCode.HeaderText = "W/H"
        Me.grdDoutNewWarehouseCode.Name = "grdDoutNewWarehouseCode"
        Me.grdDoutNewWarehouseCode.Width = 50
        '
        'grdDoutNewLocationName
        '
        Me.grdDoutNewLocationName.DataPropertyName = "location_name"
        Me.grdDoutNewLocationName.HeaderText = "Location"
        Me.grdDoutNewLocationName.Name = "grdDoutNewLocationName"
        Me.grdDoutNewLocationName.Width = 50
        '
        'lbDesignNo
        '
        Me.lbDesignNo.AutoSize = True
        Me.lbDesignNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDesignNo.Location = New System.Drawing.Point(12, 27)
        Me.lbDesignNo.Name = "lbDesignNo"
        Me.lbDesignNo.Size = New System.Drawing.Size(56, 17)
        Me.lbDesignNo.TabIndex = 2
        Me.lbDesignNo.Text = "Barcode"
        '
        'txtIDstrollsdo
        '
        Me.txtIDstrollsdo.BackColor = System.Drawing.Color.Yellow
        Me.txtIDstrollsdo.Location = New System.Drawing.Point(74, 24)
        Me.txtIDstrollsdo.Name = "txtIDstrollsdo"
        Me.txtIDstrollsdo.Size = New System.Drawing.Size(168, 25)
        Me.txtIDstrollsdo.TabIndex = 1
        '
        'txtkgs
        '
        Me.txtkgs.BackColor = System.Drawing.Color.Yellow
        Me.txtkgs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtkgs.Location = New System.Drawing.Point(11, 37)
        Me.txtkgs.Name = "txtkgs"
        Me.txtkgs.Size = New System.Drawing.Size(98, 25)
        Me.txtkgs.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Kgs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Mts"
        '
        'txtMts
        '
        Me.txtMts.Location = New System.Drawing.Point(132, 37)
        Me.txtMts.Name = "txtMts"
        Me.txtMts.Size = New System.Drawing.Size(106, 25)
        Me.txtMts.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtOutno)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpOutDt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(760, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 91)
        Me.GroupBox3.TabIndex = 348
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Detail"
        '
        'txtOutno
        '
        Me.txtOutno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutno.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOutno.Location = New System.Drawing.Point(83, 24)
        Me.txtOutno.Name = "txtOutno"
        Me.txtOutno.Size = New System.Drawing.Size(125, 25)
        Me.txtOutno.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 328
        Me.Label4.Text = "Out No."
        '
        'dtpOutDt
        '
        Me.dtpOutDt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpOutDt.Checked = False
        Me.dtpOutDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpOutDt.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtpOutDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutDt.Location = New System.Drawing.Point(83, 55)
        Me.dtpOutDt.Name = "dtpOutDt"
        Me.dtpOutDt.ShowCheckBox = True
        Me.dtpOutDt.Size = New System.Drawing.Size(125, 25)
        Me.dtpOutDt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 331
        Me.Label5.Text = "Out Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIDstrollsdo)
        Me.GroupBox1.Controls.Add(Me.lbDesignNo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 65)
        Me.GroupBox1.TabIndex = 349
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 351
        Me.Label3.Text = "Yds"
        '
        'txtYds
        '
        Me.txtYds.Location = New System.Drawing.Point(271, 37)
        Me.txtYds.Name = "txtYds"
        Me.txtYds.Size = New System.Drawing.Size(109, 25)
        Me.txtYds.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(434, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 353
        Me.Label6.Text = "Mtkg"
        '
        'txtmtkg
        '
        Me.txtmtkg.BackColor = System.Drawing.Color.Yellow
        Me.txtmtkg.Location = New System.Drawing.Point(397, 37)
        Me.txtmtkg.Name = "txtmtkg"
        Me.txtmtkg.Size = New System.Drawing.Size(109, 25)
        Me.txtmtkg.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.chkAutoCalculate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtmtkg)
        Me.GroupBox2.Controls.Add(Me.txtkgs)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtYds)
        Me.GroupBox2.Controls.Add(Me.txtMts)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 71)
        Me.GroupBox2.TabIndex = 350
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill Up"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Checked = True
        Me.chkAutoCalculate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoCalculate.Location = New System.Drawing.Point(524, 40)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(184, 18)
        Me.chkAutoCalculate.TabIndex = 351
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs.. ,Mts. ,Yds."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'BtnMakeDyedout
        '
        Me.BtnMakeDyedout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMakeDyedout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnMakeDyedout.Image = Global.SalesOrderSystem.My.Resources.Resources.GenerateAllFromTemplate_16x
        Me.BtnMakeDyedout.Location = New System.Drawing.Point(820, 131)
        Me.BtnMakeDyedout.Name = "BtnMakeDyedout"
        Me.BtnMakeDyedout.Size = New System.Drawing.Size(158, 29)
        Me.BtnMakeDyedout.TabIndex = 343
        Me.BtnMakeDyedout.Text = "Make Sample Out"
        Me.BtnMakeDyedout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnMakeDyedout.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 25)
        Me.ToolStrip1.TabIndex = 352
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'frmDyedOutSampleBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 526)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnMakeDyedout)
        Me.Controls.Add(Me.grdDoutNew)
        Me.Name = "frmDyedOutSampleBarcode"
        Me.Text = "Dyed Out Sample Barcode"
        CType(Me.grdDoutNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDoutNew As System.Windows.Forms.DataGridView
    Friend WithEvents BtnMakeDyedout As System.Windows.Forms.Button
    Friend WithEvents lbDesignNo As System.Windows.Forms.Label
    Friend WithEvents txtIDstrollsdo As System.Windows.Forms.TextBox
    Friend WithEvents txtkgs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMts As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpOutDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtYds As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmtkg As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents grdDoutNewSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDStrollsDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewDesignNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRefdesno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewCustColor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRollNoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRollNoO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewYds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestYds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRequestMtkg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewRemQC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewWarehouseCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDoutNewLocationName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
End Class
