<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOClose
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOClose))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdPurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboPONo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.id_jobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.closed1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.grdPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPurchaseOrder
        '
        Me.grdPurchaseOrder.AllowUserToAddRows = False
        Me.grdPurchaseOrder.AllowUserToDeleteRows = False
        Me.grdPurchaseOrder.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPurchaseOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jobdet, Me.itcd, Me.itdesc, Me.qty, Me.uom, Me.closed1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdPurchaseOrder.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdPurchaseOrder.Location = New System.Drawing.Point(8, 32)
        Me.grdPurchaseOrder.Name = "grdPurchaseOrder"
        Me.grdPurchaseOrder.Size = New System.Drawing.Size(664, 440)
        Me.grdPurchaseOrder.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboPONo, Me.ToolStripSeparator1, Me.btnSearch, Me.btnSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(681, 25)
        Me.ToolStrip1.TabIndex = 16
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripLabel1.Text = "Purchase Order No."
        '
        'cboPONo
        '
        Me.cboPONo.BackColor = System.Drawing.Color.Gold
        Me.cboPONo.Name = "cboPONo"
        Me.cboPONo.Size = New System.Drawing.Size(100, 25)
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
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'id_jobdet
        '
        Me.id_jobdet.DataPropertyName = "id_jobdet"
        Me.id_jobdet.HeaderText = "ID JOBDET"
        Me.id_jobdet.Name = "id_jobdet"
        Me.id_jobdet.ReadOnly = True
        Me.id_jobdet.Visible = False
        Me.id_jobdet.Width = 85
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 250
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "#.#0"
        Me.qty.DefaultCellStyle = DataGridViewCellStyle1
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'uom
        '
        Me.uom.DataPropertyName = "uom"
        Me.uom.HeaderText = "UOM"
        Me.uom.Name = "uom"
        Me.uom.ReadOnly = True
        '
        'closed1
        '
        Me.closed1.DataPropertyName = "closed"
        Me.closed1.HeaderText = "Closed"
        Me.closed1.Name = "closed1"
        Me.closed1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.closed1.Width = 50
        '
        'frmPOClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 481)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdPurchaseOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOClose"
        Me.Text = "Close Purchase Order"
        CType(Me.grdPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents grdPurchaseOrder As System.Windows.Forms.DataGridView
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboPONo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents id_jobdet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itdesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents closed1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
