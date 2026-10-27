<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchColNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchColNo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblColNo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtColNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdCol = New System.Windows.Forms.DataGridView()
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
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColNo
        '
        Me.lblColNo.AutoSize = True
        Me.lblColNo.Location = New System.Drawing.Point(17, 55)
        Me.lblColNo.Name = "lblColNo"
        Me.lblColNo.Size = New System.Drawing.Size(42, 13)
        Me.lblColNo.TabIndex = 26
        Me.lblColNo.Text = "Col No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(906, 25)
        Me.ToolStrip1.TabIndex = 27
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "&Refresh"
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
        Me.btnExit.Text = "E&xit"
        '
        'txtColNo
        '
        Me.txtColNo.Location = New System.Drawing.Point(81, 55)
        Me.txtColNo.Name = "txtColNo"
        Me.txtColNo.Size = New System.Drawing.Size(88, 20)
        Me.txtColNo.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Customer"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(81, 19)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(224, 21)
        Me.cboCustomer.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtColNo)
        Me.GroupBox1.Controls.Add(Me.lblColNo)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 81)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'grdCol
        '
        Me.grdCol.AllowUserToAddRows = False
        Me.grdCol.AllowUserToDeleteRows = False
        Me.grdCol.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdCol.ColumnHeadersHeight = 30
        Me.grdCol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.colname, Me.colCustcd, Me.colLabdipno, Me.base_col, Me.colCustRef, Me.colCustCol, Me.colLabsubdt, Me.colLabAppDt, Me.colLabAppShade})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCol.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdCol.Location = New System.Drawing.Point(12, 115)
        Me.grdCol.Name = "grdCol"
        Me.grdCol.Size = New System.Drawing.Size(886, 332)
        Me.grdCol.TabIndex = 32
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
        'frmSearchColNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 454)
        Me.Controls.Add(Me.grdCol)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSearchColNo"
        Me.Text = "Search Color"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColNo As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtColNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdCol As System.Windows.Forms.DataGridView
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
