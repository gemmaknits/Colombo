<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderClose
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyingOrderClose))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDFNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblCancelled = New System.Windows.Forms.ToolStripLabel()
        Me.grdDF = New System.Windows.Forms.DataGridView()
        Me.design_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhcolref_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labdipno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colclosed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.closedt = New Classes.CalendarColumn()
        Me.colRem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDFNo, Me.ToolStripSeparator1, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripSeparator2, Me.lblCancelled})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1040, 25)
        Me.ToolStrip1.TabIndex = 17
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
        'grdDF
        '
        Me.grdDF.AllowUserToAddRows = False
        Me.grdDF.AllowUserToDeleteRows = False
        Me.grdDF.AllowUserToOrderColumns = True
        Me.grdDF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDF.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.design_no_d, Me.gwth_d, Me.col, Me.custcolor, Me.dhcolref_d, Me.labdipno, Me.sonoid, Me.custname, Me.dhname, Me.empname, Me.colclosed, Me.closedt, Me.colRem})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDF.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdDF.Location = New System.Drawing.Point(12, 28)
        Me.grdDF.Name = "grdDF"
        Me.grdDF.ReadOnly = True
        Me.grdDF.Size = New System.Drawing.Size(1028, 429)
        Me.grdDF.TabIndex = 21
        '
        'design_no_d
        '
        Me.design_no_d.DataPropertyName = "design_no_d"
        Me.design_no_d.HeaderText = "Design No."
        Me.design_no_d.Name = "design_no_d"
        Me.design_no_d.ReadOnly = True
        Me.design_no_d.Width = 85
        '
        'gwth_d
        '
        Me.gwth_d.DataPropertyName = "gwth_d"
        Me.gwth_d.HeaderText = "Gwth"
        Me.gwth_d.Name = "gwth_d"
        Me.gwth_d.ReadOnly = True
        Me.gwth_d.Width = 35
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 40
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Cust. Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        Me.custcolor.Width = 55
        '
        'dhcolref_d
        '
        Me.dhcolref_d.DataPropertyName = "dhcolref_d"
        Me.dhcolref_d.HeaderText = "Dyed House Color"
        Me.dhcolref_d.Name = "dhcolref_d"
        Me.dhcolref_d.ReadOnly = True
        Me.dhcolref_d.Width = 50
        '
        'labdipno
        '
        Me.labdipno.DataPropertyName = "labdipno"
        Me.labdipno.HeaderText = "Lab No."
        Me.labdipno.Name = "labdipno"
        Me.labdipno.ReadOnly = True
        Me.labdipno.Width = 65
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        Me.sonoid.Width = 90
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 130
        '
        'dhname
        '
        Me.dhname.DataPropertyName = "dhname"
        Me.dhname.HeaderText = "Dyed House"
        Me.dhname.Name = "dhname"
        Me.dhname.ReadOnly = True
        '
        'empname
        '
        Me.empname.DataPropertyName = "empname"
        Me.empname.HeaderText = "Owner"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        Me.empname.Width = 50
        '
        'colclosed
        '
        Me.colclosed.DataPropertyName = "closed"
        Me.colclosed.HeaderText = "Closed"
        Me.colclosed.Name = "colclosed"
        Me.colclosed.ReadOnly = True
        Me.colclosed.Width = 50
        '
        'closedt
        '
        Me.closedt.DataPropertyName = "closedt"
        Me.closedt.HeaderText = "Closed Date"
        Me.closedt.Name = "closedt"
        Me.closedt.ReadOnly = True
        Me.closedt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.closedt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colRem
        '
        Me.colRem.DataPropertyName = "rem"
        Me.colRem.HeaderText = "Remarks"
        Me.colRem.Name = "colRem"
        Me.colRem.ReadOnly = True
        Me.colRem.Width = 200
        '
        'frmDyingOrderClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 470)
        Me.Controls.Add(Me.grdDF)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyingOrderClose"
        Me.Text = "Dying Order Close"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDFNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents lblCancelled As System.Windows.Forms.ToolStripLabel
    Friend WithEvents grdDF As System.Windows.Forms.DataGridView
    Friend WithEvents design_no_d As DataGridViewTextBoxColumn
    Friend WithEvents gwth_d As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents dhcolref_d As DataGridViewTextBoxColumn
    Friend WithEvents labdipno As DataGridViewTextBoxColumn
    Friend WithEvents sonoid As DataGridViewTextBoxColumn
    Friend WithEvents custname As DataGridViewTextBoxColumn
    Friend WithEvents dhname As DataGridViewTextBoxColumn
    Friend WithEvents empname As DataGridViewTextBoxColumn
    Friend WithEvents colclosed As DataGridViewCheckBoxColumn
    Friend WithEvents closedt As Classes.CalendarColumn
    Friend WithEvents colRem As DataGridViewTextBoxColumn
End Class
