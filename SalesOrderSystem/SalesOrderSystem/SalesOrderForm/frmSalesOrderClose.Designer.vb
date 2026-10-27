<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderClose
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderClose))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdSalesOrder = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboSoNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblCancelled = New System.Windows.Forms.ToolStripLabel()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labeldes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inv_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoClosed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.grdSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdSalesOrder
        '
        Me.grdSalesOrder.AllowUserToAddRows = False
        Me.grdSalesOrder.AllowUserToDeleteRows = False
        Me.grdSalesOrder.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSalesOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sonoid, Me.design_no, Me.labeldes, Me.gwth, Me.col, Me.custcol, Me.fwth, Me.qty, Me.uom, Me.colRem, Me.inv_qty, Me.SoClosed})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSalesOrder.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdSalesOrder.Location = New System.Drawing.Point(8, 32)
        Me.grdSalesOrder.Name = "grdSalesOrder"
        Me.grdSalesOrder.Size = New System.Drawing.Size(1000, 440)
        Me.grdSalesOrder.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboSoNo, Me.ToolStripSeparator1, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.lblCancelled})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1017, 25)
        Me.ToolStrip1.TabIndex = 16
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "Sales Order No."
        '
        'cboSoNo
        '
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "Search"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(133, 22)
        Me.lblCancelled.Text = "Document is cancelled"
        Me.lblCancelled.Visible = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        Me.sonoid.Width = 85
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 65
        '
        'labeldes
        '
        Me.labeldes.DataPropertyName = "labeldes"
        Me.labeldes.HeaderText = "Customer Design"
        Me.labeldes.Name = "labeldes"
        Me.labeldes.ReadOnly = True
        Me.labeldes.Width = 65
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.ReadOnly = True
        Me.gwth.Width = 50
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col.DefaultCellStyle = DataGridViewCellStyle1
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 65
        '
        'custcol
        '
        Me.custcol.DataPropertyName = "custcol"
        Me.custcol.HeaderText = "Customer Color"
        Me.custcol.Name = "custcol"
        Me.custcol.ReadOnly = True
        Me.custcol.Width = 75
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fwth.DefaultCellStyle = DataGridViewCellStyle2
        Me.fwth.HeaderText = "Finished Width (cm)"
        Me.fwth.Name = "fwth"
        Me.fwth.ReadOnly = True
        Me.fwth.Width = 50
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "#.#0"
        Me.qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.qty.HeaderText = "Qty."
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 50
        '
        'uom
        '
        Me.uom.DataPropertyName = "uom"
        Me.uom.HeaderText = "UOM"
        Me.uom.Name = "uom"
        Me.uom.ReadOnly = True
        Me.uom.Width = 50
        '
        'colRem
        '
        Me.colRem.DataPropertyName = "rem_soitm"
        Me.colRem.HeaderText = "Remarks"
        Me.colRem.Name = "colRem"
        Me.colRem.Width = 250
        '
        'inv_qty
        '
        Me.inv_qty.DataPropertyName = "inv_qty"
        Me.inv_qty.HeaderText = "Invoice Qty."
        Me.inv_qty.Name = "inv_qty"
        Me.inv_qty.ReadOnly = True
        '
        'SoClosed
        '
        Me.SoClosed.DataPropertyName = "Closed"
        Me.SoClosed.HeaderText = "Closed"
        Me.SoClosed.Name = "SoClosed"
        Me.SoClosed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SoClosed.Width = 50
        '
        'frmSalesOrderClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 481)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdSalesOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesOrderClose"
        Me.Text = "Close Sales Order"
        CType(Me.grdSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdSalesOrder As System.Windows.Forms.DataGridView
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboSoNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblCancelled As System.Windows.Forms.ToolStripLabel
    Friend WithEvents closed3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents labeldes As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcol As DataGridViewTextBoxColumn
    Friend WithEvents fwth As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewTextBoxColumn
    Friend WithEvents colRem As DataGridViewTextBoxColumn
    Friend WithEvents inv_qty As DataGridViewTextBoxColumn
    Friend WithEvents SoClosed As DataGridViewCheckBoxColumn
End Class
