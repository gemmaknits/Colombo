<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesignBOMNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesignBOMNew))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDesignBOM = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBOMDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkApproved = New System.Windows.Forms.CheckBox()
        Me.chkEnabled = New System.Windows.Forms.CheckBox()
        Me.txtBOMCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBOMUsage = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_yarnchangedet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReqdQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ynmerge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yarnusage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.usage1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalNotRound = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalWithRound = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbodesign_ver = New System.Windows.Forms.ComboBox()
        Me.BtnDeleteStep = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBom_remarks = New System.Windows.Forms.Label()
        Me.lblBom_Remarks = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRequiredQty = New System.Windows.Forms.TextBox()
        Me.cboBomUOM = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnBomVer = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDesignBOM, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnCopy, Me.btnSave, Me.btnPrint, Me.BtnCancel, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1056, 25)
        Me.ToolStrip1.TabIndex = 39
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripLabel1.Text = "Design BOM"
        '
        'cboDesignBOM
        '
        Me.cboDesignBOM.Name = "cboDesignBOM"
        Me.cboDesignBOM.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "Search"
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(55, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(122, 22)
        Me.BtnCancel.Text = "Cancel Document"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(246, 22)
        Me.ToolStripLabel2.Text = "กดติ๊กเลือก Items แล้ว กด Delete Item เพื่อลบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "BOM Date:"
        '
        'dtpBOMDate
        '
        Me.dtpBOMDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpBOMDate.Enabled = False
        Me.dtpBOMDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBOMDate.Location = New System.Drawing.Point(98, 87)
        Me.dtpBOMDate.Name = "dtpBOMDate"
        Me.dtpBOMDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpBOMDate.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "BOM  item :"
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkApproved.Location = New System.Drawing.Point(895, 44)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(105, 17)
        Me.chkApproved.TabIndex = 49
        Me.chkApproved.Text = "BOM Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnabled.Location = New System.Drawing.Point(895, 21)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(97, 17)
        Me.chkEnabled.TabIndex = 48
        Me.chkEnabled.Text = "BOM Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'txtBOMCode
        '
        Me.txtBOMCode.Location = New System.Drawing.Point(433, 38)
        Me.txtBOMCode.Name = "txtBOMCode"
        Me.txtBOMCode.ReadOnly = True
        Me.txtBOMCode.Size = New System.Drawing.Size(79, 20)
        Me.txtBOMCode.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "BOM Code"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(433, 62)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(310, 44)
        Me.txtRemark.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(383, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Remark"
        '
        'cboBOMUsage
        '
        Me.cboBOMUsage.BackColor = System.Drawing.Color.Khaki
        Me.cboBOMUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBOMUsage.FormattingEnabled = True
        Me.cboBOMUsage.Location = New System.Drawing.Point(433, 110)
        Me.cboBOMUsage.Name = "cboBOMUsage"
        Me.cboBOMUsage.Size = New System.Drawing.Size(215, 21)
        Me.cboBOMUsage.TabIndex = 198
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(334, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "BOM Usage Type"
        '
        'grdData
        '
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeight = 35
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.id_yarnchangedet, Me.itcd, Me.itdesc, Me.ynperc, Me.colReqdQty, Me.colUom, Me.ynmerge, Me.yarnusage, Me.suppcd, Me.usage1})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdData.Location = New System.Drawing.Point(8, 169)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowHeadersWidth = 25
        Me.grdData.RowTemplate.Height = 30
        Me.grdData.Size = New System.Drawing.Size(1040, 281)
        Me.grdData.TabIndex = 200
        '
        'chkSelect
        '
        Me.chkSelect.DataPropertyName = "chkSelect"
        Me.chkSelect.HeaderText = "#"
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.ReadOnly = True
        Me.chkSelect.Width = 20
        '
        'id_yarnchangedet
        '
        Me.id_yarnchangedet.DataPropertyName = "id_yarnchangedet"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki
        Me.id_yarnchangedet.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_yarnchangedet.HeaderText = "ID"
        Me.id_yarnchangedet.Name = "id_yarnchangedet"
        Me.id_yarnchangedet.ReadOnly = True
        Me.id_yarnchangedet.Visible = False
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki
        Me.itcd.DefaultCellStyle = DataGridViewCellStyle3
        Me.itcd.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.itcd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.itcd.HeaderText = "Item Code "
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.itcd.Width = 200
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki
        Me.itdesc.DefaultCellStyle = DataGridViewCellStyle4
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 175
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki
        Me.ynperc.DefaultCellStyle = DataGridViewCellStyle5
        Me.ynperc.HeaderText = "%"
        Me.ynperc.Name = "ynperc"
        Me.ynperc.ReadOnly = True
        Me.ynperc.Width = 50
        '
        'colReqdQty
        '
        Me.colReqdQty.DataPropertyName = "rqdet_qty"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colReqdQty.DefaultCellStyle = DataGridViewCellStyle6
        Me.colReqdQty.HeaderText = "Reqd. Qty"
        Me.colReqdQty.Name = "colReqdQty"
        Me.colReqdQty.ReadOnly = True
        Me.colReqdQty.Width = 80
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "rqdet_bom_uom_id"
        Me.colUom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colUom.HeaderText = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.ReadOnly = True
        Me.colUom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colUom.Width = 80
        '
        'ynmerge
        '
        Me.ynmerge.DataPropertyName = "ynmerge"
        Me.ynmerge.HeaderText = "Merge"
        Me.ynmerge.Name = "ynmerge"
        Me.ynmerge.ReadOnly = True
        Me.ynmerge.Width = 50
        '
        'yarnusage
        '
        Me.yarnusage.DataPropertyName = "yarnusage"
        Me.yarnusage.HeaderText = "Pattern"
        Me.yarnusage.Name = "yarnusage"
        Me.yarnusage.ReadOnly = True
        Me.yarnusage.Width = 150
        '
        'suppcd
        '
        Me.suppcd.DataPropertyName = "suppcd"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Khaki
        Me.suppcd.DefaultCellStyle = DataGridViewCellStyle7
        Me.suppcd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.suppcd.HeaderText = "Supplier"
        Me.suppcd.Name = "suppcd"
        Me.suppcd.ReadOnly = True
        Me.suppcd.Width = 250
        '
        'usage1
        '
        Me.usage1.HeaderText = "Pattern"
        Me.usage1.Name = "usage1"
        Me.usage1.ReadOnly = True
        Me.usage1.Visible = False
        Me.usage1.Width = 150
        '
        'txtTotalNotRound
        '
        Me.txtTotalNotRound.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNotRound.Location = New System.Drawing.Point(412, 485)
        Me.txtTotalNotRound.Name = "txtTotalNotRound"
        Me.txtTotalNotRound.ReadOnly = True
        Me.txtTotalNotRound.Size = New System.Drawing.Size(88, 22)
        Me.txtTotalNotRound.TabIndex = 202
        Me.txtTotalNotRound.Tag = "0"
        Me.txtTotalNotRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(204, 13)
        Me.Label6.TabIndex = 203
        Me.Label6.Text = "Total Proportion (Without Rounding) :"
        '
        'txtTotalWithRound
        '
        Me.txtTotalWithRound.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalWithRound.Location = New System.Drawing.Point(412, 509)
        Me.txtTotalWithRound.Name = "txtTotalWithRound"
        Me.txtTotalWithRound.ReadOnly = True
        Me.txtTotalWithRound.Size = New System.Drawing.Size(88, 22)
        Me.txtTotalWithRound.TabIndex = 204
        Me.txtTotalWithRound.Tag = "0"
        Me.txtTotalWithRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 509)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 13)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Total Proportion (By Rounding Before) :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(508, 485)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(508, 509)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(521, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 209
        Me.Label11.Text = "PROD. Ver."
        '
        'cbodesign_ver
        '
        Me.cbodesign_ver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodesign_ver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodesign_ver.FormattingEnabled = True
        Me.cbodesign_ver.Location = New System.Drawing.Point(607, 38)
        Me.cbodesign_ver.Name = "cbodesign_ver"
        Me.cbodesign_ver.Size = New System.Drawing.Size(136, 21)
        Me.cbodesign_ver.TabIndex = 210
        '
        'BtnDeleteStep
        '
        Me.BtnDeleteStep.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteStep.Location = New System.Drawing.Point(874, 124)
        Me.BtnDeleteStep.Name = "BtnDeleteStep"
        Me.BtnDeleteStep.Size = New System.Drawing.Size(116, 39)
        Me.BtnDeleteStep.TabIndex = 457
        Me.BtnDeleteStep.Text = "Delete BOM Lines"
        Me.BtnDeleteStep.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtBom_remarks
        '
        Me.txtBom_remarks.AutoSize = True
        Me.txtBom_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBom_remarks.Location = New System.Drawing.Point(838, 67)
        Me.txtBom_remarks.Name = "txtBom_remarks"
        Me.txtBom_remarks.Size = New System.Drawing.Size(30, 13)
        Me.txtBom_remarks.TabIndex = 462
        Me.txtBom_remarks.Text = "N/A"
        '
        'lblBom_Remarks
        '
        Me.lblBom_Remarks.AutoSize = True
        Me.lblBom_Remarks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBom_Remarks.Location = New System.Drawing.Point(764, 67)
        Me.lblBom_Remarks.Name = "lblBom_Remarks"
        Me.lblBom_Remarks.Size = New System.Drawing.Size(77, 13)
        Me.lblBom_Remarks.TabIndex = 461
        Me.lblBom_Remarks.Text = "Bom Remark :"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.BackColor = System.Drawing.Color.Khaki
        Me.txtDesignNo.Location = New System.Drawing.Point(98, 38)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(210, 20)
        Me.txtDesignNo.TabIndex = 463
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.Color.Khaki
        Me.cboColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Location = New System.Drawing.Point(98, 110)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(210, 21)
        Me.cboColor.TabIndex = 464
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 465
        Me.Label12.Text = "COLOR WAY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 466
        Me.Label5.Text = "MATERIALS USED"
        '
        'txtRequiredQty
        '
        Me.txtRequiredQty.Location = New System.Drawing.Point(98, 62)
        Me.txtRequiredQty.Name = "txtRequiredQty"
        Me.txtRequiredQty.Size = New System.Drawing.Size(50, 20)
        Me.txtRequiredQty.TabIndex = 467
        '
        'cboBomUOM
        '
        Me.cboBomUOM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboBomUOM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboBomUOM.FormattingEnabled = True
        Me.cboBomUOM.Location = New System.Drawing.Point(154, 62)
        Me.cboBomUOM.Name = "cboBomUOM"
        Me.cboBomUOM.Size = New System.Drawing.Size(72, 21)
        Me.cboBomUOM.TabIndex = 468
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 469
        Me.Label13.Text = "Required Qty :"
        '
        'BtnBomVer
        '
        Me.BtnBomVer.Location = New System.Drawing.Point(761, 124)
        Me.BtnBomVer.Name = "BtnBomVer"
        Me.BtnBomVer.Size = New System.Drawing.Size(107, 39)
        Me.BtnBomVer.TabIndex = 471
        Me.BtnBomVer.Text = "Search Bom Version "
        Me.BtnBomVer.UseVisualStyleBackColor = True
        '
        'frmDesignBOMNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 572)
        Me.Controls.Add(Me.BtnBomVer)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboBomUOM)
        Me.Controls.Add(Me.txtRequiredQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.txtBom_remarks)
        Me.Controls.Add(Me.lblBom_Remarks)
        Me.Controls.Add(Me.BtnDeleteStep)
        Me.Controls.Add(Me.cbodesign_ver)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalWithRound)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalNotRound)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.cboBOMUsage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBOMCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.chkEnabled)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBOMDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDesignBOMNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Design BOM Color Way"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDesignBOM As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpBOMDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkApproved As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents txtBOMCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboBOMUsage As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalNotRound As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalWithRound As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbodesign_ver As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDeleteStep As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtBom_remarks As System.Windows.Forms.Label
    Friend WithEvents lblBom_Remarks As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBomUOM As ComboBox
    Friend WithEvents txtRequiredQty As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkSelect As DataGridViewCheckBoxColumn
    Friend WithEvents id_yarnchangedet As DataGridViewTextBoxColumn
    Friend WithEvents itcd As DataGridViewComboBoxColumn
    Friend WithEvents itdesc As DataGridViewTextBoxColumn
    Friend WithEvents ynperc As DataGridViewTextBoxColumn
    Friend WithEvents colReqdQty As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewComboBoxColumn
    Friend WithEvents ynmerge As DataGridViewTextBoxColumn
    Friend WithEvents yarnusage As DataGridViewTextBoxColumn
    Friend WithEvents suppcd As DataGridViewComboBoxColumn
    Friend WithEvents usage1 As DataGridViewTextBoxColumn
    Friend WithEvents BtnBomVer As Button
End Class
