<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyingOrderSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.grdDF = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlookup = New System.Windows.Forms.TextBox()
        Me.dfno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dfdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no_fg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dhname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(894, 25)
        Me.ToolStrip1.TabIndex = 16
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(62, 22)
        Me.btnRefresh.Text = "&Search"
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
        Me.btnExit.Text = "E&xit"
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(411, 33)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 22
        Me.btnRefresh2.Text = "&Search"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'grdDF
        '
        Me.grdDF.AllowUserToAddRows = False
        Me.grdDF.AllowUserToDeleteRows = False
        Me.grdDF.AllowUserToOrderColumns = True
        Me.grdDF.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dfno, Me.dfdt, Me.design_no, Me.design_no_fg, Me.sono, Me.custname, Me.dhname, Me.empname, Me.outno})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDF.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdDF.Location = New System.Drawing.Point(10, 75)
        Me.grdDF.Name = "grdDF"
        Me.grdDF.ReadOnly = True
        Me.grdDF.Size = New System.Drawing.Size(872, 402)
        Me.grdDF.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Lookup:"
        '
        'txtlookup
        '
        Me.txtlookup.Location = New System.Drawing.Point(64, 40)
        Me.txtlookup.Name = "txtlookup"
        Me.txtlookup.Size = New System.Drawing.Size(326, 20)
        Me.txtlookup.TabIndex = 168
        '
        'dfno
        '
        Me.dfno.DataPropertyName = "dfno"
        Me.dfno.HeaderText = "D/F No."
        Me.dfno.Name = "dfno"
        Me.dfno.ReadOnly = True
        Me.dfno.Width = 85
        '
        'dfdt
        '
        Me.dfdt.DataPropertyName = "dfdt2"
        Me.dfdt.HeaderText = "D/F Date"
        Me.dfdt.Name = "dfdt"
        Me.dfdt.ReadOnly = True
        Me.dfdt.Width = 85
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 85
        '
        'design_no_fg
        '
        Me.design_no_fg.DataPropertyName = "design_no_fg"
        Me.design_no_fg.HeaderText = "Design No (FG)"
        Me.design_no_fg.Name = "design_no_fg"
        Me.design_no_fg.ReadOnly = True
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "S/O No."
        Me.sono.Name = "sono"
        Me.sono.ReadOnly = True
        Me.sono.Width = 85
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
        'outno
        '
        Me.outno.DataPropertyName = "outno"
        Me.outno.HeaderText = "Out No."
        Me.outno.Name = "outno"
        Me.outno.ReadOnly = True
        '
        'frmDyingOrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 489)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtlookup)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.grdDF)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyingOrderSearch"
        Me.Text = "D/F Order Search"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents grdDF As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtlookup As TextBox
    Friend WithEvents dfno As DataGridViewTextBoxColumn
    Friend WithEvents dfdt As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents design_no_fg As DataGridViewTextBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents custname As DataGridViewTextBoxColumn
    Friend WithEvents dhname As DataGridViewTextBoxColumn
    Friend WithEvents empname As DataGridViewTextBoxColumn
    Friend WithEvents outno As DataGridViewTextBoxColumn
End Class
