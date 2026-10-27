<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDFApvSheet
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDFApvSheet))
        Me.dgvDfoitems = New System.Windows.Forms.DataGridView()
        Me.comboColor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDFNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyeBatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSentToCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustReplyOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colNotOK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDfoitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDfoitems
        '
        Me.dgvDfoitems.AllowUserToAddRows = False
        Me.dgvDfoitems.AllowUserToDeleteRows = False
        Me.dgvDfoitems.AllowUserToOrderColumns = True
        Me.dgvDfoitems.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvDfoitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDfoitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.colDfno, Me.design_no_d, Me.col, Me.custcolor, Me.lot, Me.colDyeBatchNo, Me.colSentToCust, Me.colCustReplyOn, Me.colOk, Me.colNotOK, Me.colRemark})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDfoitems.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDfoitems.Location = New System.Drawing.Point(8, 72)
        Me.dgvDfoitems.Name = "dgvDfoitems"
        Me.dgvDfoitems.Size = New System.Drawing.Size(936, 385)
        Me.dgvDfoitems.TabIndex = 22
        '
        'comboColor
        '
        Me.comboColor.FormattingEnabled = True
        Me.comboColor.Location = New System.Drawing.Point(56, 40)
        Me.comboColor.Name = "comboColor"
        Me.comboColor.Size = New System.Drawing.Size(208, 21)
        Me.comboColor.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Color:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDFNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
        Me.ToolStrip1.TabIndex = 30
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripLabel1.Text = "D/F Order No."
        '
        'cboDFNo
        '
        Me.cboDFNo.Name = "cboDFNo"
        Me.cboDFNo.Size = New System.Drawing.Size(100, 25)
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
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
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
        'id
        '
        Me.id.DataPropertyName = "id_dforder_result"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'colDfno
        '
        Me.colDfno.DataPropertyName = "dfno"
        Me.colDfno.HeaderText = "D/F No."
        Me.colDfno.Name = "colDfno"
        Me.colDfno.Width = 80
        '
        'design_no_d
        '
        Me.design_no_d.DataPropertyName = "design_no"
        Me.design_no_d.HeaderText = "Design No."
        Me.design_no_d.Name = "design_no_d"
        Me.design_no_d.Width = 85
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Width = 75
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        Me.lot.Width = 80
        '
        'colDyeBatchNo
        '
        Me.colDyeBatchNo.DataPropertyName = "dyebatchno"
        Me.colDyeBatchNo.HeaderText = "Batch no."
        Me.colDyeBatchNo.Name = "colDyeBatchNo"
        Me.colDyeBatchNo.Width = 80
        '
        'colSentToCust
        '
        Me.colSentToCust.DataPropertyName = "senttocustdt"
        Me.colSentToCust.HeaderText = "Sent to Cust on"
        Me.colSentToCust.Name = "colSentToCust"
        Me.colSentToCust.Width = 75
        '
        'colCustReplyOn
        '
        Me.colCustReplyOn.DataPropertyName = "custreplydt"
        Me.colCustReplyOn.HeaderText = "Cust. reply on"
        Me.colCustReplyOn.Name = "colCustReplyOn"
        Me.colCustReplyOn.Width = 75
        '
        'colOk
        '
        Me.colOk.DataPropertyName = "bulkok"
        Me.colOk.HeaderText = "Approved"
        Me.colOk.Name = "colOk"
        Me.colOk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colOk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colOk.Width = 25
        '
        'colNotOK
        '
        Me.colNotOK.DataPropertyName = "bulknotok"
        Me.colNotOK.HeaderText = "Rejected"
        Me.colNotOK.Name = "colNotOK"
        Me.colNotOK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colNotOK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colNotOK.Width = 25
        '
        'colRemark
        '
        Me.colRemark.DataPropertyName = "remarks"
        Me.colRemark.HeaderText = "Remark"
        Me.colRemark.Name = "colRemark"
        Me.colRemark.Width = 1000
        '
        'formDFApvSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 465)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboColor)
        Me.Controls.Add(Me.dgvDfoitems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formDFApvSheet"
        Me.Text = "D/F approval sheet "
        CType(Me.dgvDfoitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDfoitems As System.Windows.Forms.DataGridView
    Friend WithEvents comboColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDFNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDfno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDyeBatchNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSentToCust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustReplyOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colNotOK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colRemark As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
