<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesignBOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesignBOM))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDesignBOM = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBOMDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
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
        Me.id_yarnchangedet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynmerge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yarnusage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suppcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.usage1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalNotRound = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalWithRound = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbodesign_ver = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnDeleteStep = New System.Windows.Forms.Button()
        Me.lblBom_Remarks = New System.Windows.Forms.Label()
        Me.txtBom_remarks = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDesignBOM, Me.ToolStripSeparator1, Me.btnSearch, Me.btnNew, Me.btnCopy, Me.btnSave, Me.btnPrint, Me.BtnCancel, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(798, 25)
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
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
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
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnCopy.Text = "Copy"
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
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'BtnCancel
        '
        Me.BtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(23, 22)
        Me.BtnCancel.Text = "Cancel Document"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Used Date"
        '
        'dtpBOMDate
        '
        Me.dtpBOMDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpBOMDate.Enabled = False
        Me.dtpBOMDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBOMDate.Location = New System.Drawing.Point(112, 64)
        Me.dtpBOMDate.Name = "dtpBOMDate"
        Me.dtpBOMDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpBOMDate.TabIndex = 45
        '
        'txtDesignNo
        '
        Me.txtDesignNo.BackColor = System.Drawing.Color.Gold
        Me.txtDesignNo.Location = New System.Drawing.Point(112, 40)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(104, 20)
        Me.txtDesignNo.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "PROD. Item."
        '
        'chkApproved
        '
        Me.chkApproved.AutoSize = True
        Me.chkApproved.Location = New System.Drawing.Point(432, 112)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.Size = New System.Drawing.Size(72, 17)
        Me.chkApproved.TabIndex = 49
        Me.chkApproved.Text = "Approved"
        Me.chkApproved.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Location = New System.Drawing.Point(336, 112)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkEnabled.TabIndex = 48
        Me.chkEnabled.Text = "Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'txtBOMCode
        '
        Me.txtBOMCode.Location = New System.Drawing.Point(112, 88)
        Me.txtBOMCode.Name = "txtBOMCode"
        Me.txtBOMCode.ReadOnly = True
        Me.txtBOMCode.Size = New System.Drawing.Size(48, 20)
        Me.txtBOMCode.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "BOM Code"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(336, 64)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(454, 20)
        Me.txtRemark.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Remark"
        '
        'cboBOMUsage
        '
        Me.cboBOMUsage.BackColor = System.Drawing.Color.Gold
        Me.cboBOMUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBOMUsage.FormattingEnabled = True
        Me.cboBOMUsage.Location = New System.Drawing.Point(336, 88)
        Me.cboBOMUsage.Name = "cboBOMUsage"
        Me.cboBOMUsage.Size = New System.Drawing.Size(136, 21)
        Me.cboBOMUsage.TabIndex = 198
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 199
        Me.Label9.Text = "BOM Usage Type"
        '
        'grdData
        '
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_yarnchangedet, Me.itcd, Me.itdesc, Me.ynperc, Me.ynmerge, Me.yarnusage, Me.suppcd, Me.usage1})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdData.Location = New System.Drawing.Point(8, 145)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowHeadersWidth = 30
        Me.grdData.Size = New System.Drawing.Size(782, 159)
        Me.grdData.TabIndex = 200
        '
        'id_yarnchangedet
        '
        Me.id_yarnchangedet.DataPropertyName = "id_yarnchangedet"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        Me.id_yarnchangedet.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_yarnchangedet.HeaderText = "ID"
        Me.id_yarnchangedet.Name = "id_yarnchangedet"
        Me.id_yarnchangedet.ReadOnly = True
        Me.id_yarnchangedet.Visible = False
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold
        Me.itcd.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gold
        Me.itdesc.DefaultCellStyle = DataGridViewCellStyle4
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 150
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        Me.ynperc.DefaultCellStyle = DataGridViewCellStyle5
        Me.ynperc.HeaderText = "%"
        Me.ynperc.Name = "ynperc"
        Me.ynperc.ReadOnly = True
        Me.ynperc.Width = 50
        '
        'ynmerge
        '
        Me.ynmerge.DataPropertyName = "ynmerge"
        Me.ynmerge.HeaderText = "Run-in"
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gold
        Me.suppcd.DefaultCellStyle = DataGridViewCellStyle6
        Me.suppcd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.suppcd.HeaderText = "Supplier"
        Me.suppcd.Name = "suppcd"
        Me.suppcd.ReadOnly = True
        Me.suppcd.Width = 150
        '
        'usage1
        '
        Me.usage1.HeaderText = "Pattern"
        Me.usage1.Name = "usage1"
        Me.usage1.ReadOnly = True
        Me.usage1.Visible = False
        Me.usage1.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "(Use For ?)"
        '
        'txtTotalNotRound
        '
        Me.txtTotalNotRound.Location = New System.Drawing.Point(560, 312)
        Me.txtTotalNotRound.Name = "txtTotalNotRound"
        Me.txtTotalNotRound.ReadOnly = True
        Me.txtTotalNotRound.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalNotRound.TabIndex = 202
        Me.txtTotalNotRound.Tag = "0"
        Me.txtTotalNotRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 13)
        Me.Label6.TabIndex = 203
        Me.Label6.Text = "Total Proportion (Without Rounding) :"
        '
        'txtTotalWithRound
        '
        Me.txtTotalWithRound.Location = New System.Drawing.Point(560, 336)
        Me.txtTotalWithRound.Name = "txtTotalWithRound"
        Me.txtTotalWithRound.ReadOnly = True
        Me.txtTotalWithRound.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalWithRound.TabIndex = 204
        Me.txtTotalWithRound.Tag = "0"
        Me.txtTotalWithRound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 13)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Total Proportion (By Rounding Before) :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(656, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 206
        Me.Label8.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(656, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 207
        Me.Label10.Text = "%"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cbodesign_ver
        '
        Me.cbodesign_ver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodesign_ver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodesign_ver.FormattingEnabled = True
        Me.cbodesign_ver.Location = New System.Drawing.Point(336, 40)
        Me.cbodesign_ver.Name = "cbodesign_ver"
        Me.cbodesign_ver.Size = New System.Drawing.Size(136, 21)
        Me.cbodesign_ver.TabIndex = 212
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "PROD. Ver."
        '
        'BtnDeleteStep
        '
        Me.BtnDeleteStep.Location = New System.Drawing.Point(715, 116)
        Me.BtnDeleteStep.Name = "BtnDeleteStep"
        Me.BtnDeleteStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteStep.TabIndex = 458
        Me.BtnDeleteStep.Text = "Delete Items"
        Me.BtnDeleteStep.UseVisualStyleBackColor = True
        '
        'lblBom_Remarks
        '
        Me.lblBom_Remarks.AutoSize = True
        Me.lblBom_Remarks.Location = New System.Drawing.Point(490, 41)
        Me.lblBom_Remarks.Name = "lblBom_Remarks"
        Me.lblBom_Remarks.Size = New System.Drawing.Size(68, 13)
        Me.lblBom_Remarks.TabIndex = 459
        Me.lblBom_Remarks.Text = "Bom Remark"
        '
        'txtBom_remarks
        '
        Me.txtBom_remarks.AutoSize = True
        Me.txtBom_remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBom_remarks.Location = New System.Drawing.Point(564, 43)
        Me.txtBom_remarks.Name = "txtBom_remarks"
        Me.txtBom_remarks.Size = New System.Drawing.Size(30, 13)
        Me.txtBom_remarks.TabIndex = 460
        Me.txtBom_remarks.Text = "N/A"
        '
        'frmDesignBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 361)
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
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDesignBOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Design BOM"
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
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNotRound As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalWithRound As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents id_yarnchangedet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents itdesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ynperc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ynmerge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yarnusage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents suppcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents usage1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbodesign_ver As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnDeleteStep As System.Windows.Forms.Button
    Friend WithEvents lblBom_Remarks As System.Windows.Forms.Label
    Friend WithEvents txtBom_remarks As System.Windows.Forms.Label
End Class
