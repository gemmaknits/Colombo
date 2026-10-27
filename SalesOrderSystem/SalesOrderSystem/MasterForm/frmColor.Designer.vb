<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColor))
        Me.grdColor = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colLabdipno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.base_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabsubdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabAppDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabAppShade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.grdColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdColor
        '
        Me.grdColor.AllowUserToAddRows = False
        Me.grdColor.AllowUserToDeleteRows = False
        Me.grdColor.ColumnHeadersHeight = 30
        Me.grdColor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.colname, Me.colCustcd, Me.colLabdipno, Me.base_col, Me.colCustRef, Me.colCustCol, Me.colLabsubdt, Me.colLabAppDt, Me.colLabAppShade})
        Me.grdColor.Location = New System.Drawing.Point(0, 24)
        Me.grdColor.Name = "grdColor"
        Me.grdColor.Size = New System.Drawing.Size(886, 480)
        Me.grdColor.TabIndex = 2
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        '
        'colname
        '
        Me.colname.DataPropertyName = "colname"
        Me.colname.HeaderText = "Color Name"
        Me.colname.Name = "colname"
        Me.colname.Width = 200
        '
        'colCustcd
        '
        Me.colCustcd.DataPropertyName = "custcd"
        Me.colCustcd.HeaderText = "Customer"
        Me.colCustcd.Name = "colCustcd"
        Me.colCustcd.Width = 150
        '
        'colLabdipno
        '
        Me.colLabdipno.DataPropertyName = "labdipno"
        Me.colLabdipno.HeaderText = "Lab dip no."
        Me.colLabdipno.Name = "colLabdipno"
        Me.colLabdipno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colLabdipno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'base_col
        '
        Me.base_col.DataPropertyName = "base_col"
        Me.base_col.HeaderText = "Base Color"
        Me.base_col.Name = "base_col"
        '
        'colCustRef
        '
        Me.colCustRef.DataPropertyName = "cust_ref"
        Me.colCustRef.HeaderText = "Other Ref"
        Me.colCustRef.Name = "colCustRef"
        Me.colCustRef.Width = 150
        '
        'colCustCol
        '
        Me.colCustCol.DataPropertyName = "custcol"
        Me.colCustCol.HeaderText = "Customer Color "
        Me.colCustCol.Name = "colCustCol"
        Me.colCustCol.Visible = False
        '
        'colLabsubdt
        '
        Me.colLabsubdt.DataPropertyName = "labsubdt"
        Me.colLabsubdt.HeaderText = "Lab submit date"
        Me.colLabsubdt.Name = "colLabsubdt"
        '
        'colLabAppDt
        '
        Me.colLabAppDt.DataPropertyName = "labappdt"
        Me.colLabAppDt.HeaderText = "Lab App. Date"
        Me.colLabAppDt.Name = "colLabAppDt"
        '
        'colLabAppShade
        '
        Me.colLabAppShade.DataPropertyName = "labappshade"
        Me.colLabAppShade.HeaderText = "Approved shade"
        Me.colLabAppShade.Name = "colLabAppShade"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(890, 25)
        Me.ToolStrip1.TabIndex = 19
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(260, 22)
        Me.ToolStripLabel1.Text = "Deletion of saved color records is not permitted."
        '
        'frmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 509)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdColor)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColor"
        Me.Text = "Color Master"
        CType(Me.grdColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdColor As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustcd As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colLabdipno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents base_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustRef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLabsubdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLabAppDt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLabAppShade As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
