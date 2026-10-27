<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDOUT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchDOUT))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.cbocustomer = New System.Windows.Forms.ComboBox()
        Me.lbcustomer = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.outno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoctype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(409, 78)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 23
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
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
        'cbocustomer
        '
        Me.cbocustomer.FormattingEnabled = True
        Me.cbocustomer.Location = New System.Drawing.Point(131, 31)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(350, 21)
        Me.cbocustomer.TabIndex = 19
        '
        'lbcustomer
        '
        Me.lbcustomer.AutoSize = True
        Me.lbcustomer.Location = New System.Drawing.Point(26, 31)
        Me.lbcustomer.Name = "lbcustomer"
        Me.lbcustomer.Size = New System.Drawing.Size(51, 13)
        Me.lbcustomer.TabIndex = 18
        Me.lbcustomer.Text = "Customer"
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToOrderColumns = True
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeight = 40
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.outno, Me.custname, Me.outdt})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Location = New System.Drawing.Point(12, 181)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(498, 290)
        Me.grdData.TabIndex = 29
        '
        'outno
        '
        Me.outno.DataPropertyName = "outno"
        Me.outno.HeaderText = "Out No."
        Me.outno.Name = "outno"
        Me.outno.ReadOnly = True
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 200
        '
        'outdt
        '
        Me.outdt.DataPropertyName = "outdt"
        Me.outdt.HeaderText = "Out Date"
        Me.outdt.Name = "outdt"
        Me.outdt.ReadOnly = True
        Me.outdt.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbDoctype)
        Me.GroupBox1.Controls.Add(Me.btnRefresh2)
        Me.GroupBox1.Controls.Add(Me.CboDoctype)
        Me.GroupBox1.Controls.Add(Me.cbocustomer)
        Me.GroupBox1.Controls.Add(Me.lbcustomer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 147)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(25, 124)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 76
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoctype
        '
        Me.CboDoctype.FormattingEnabled = True
        Me.CboDoctype.Location = New System.Drawing.Point(131, 120)
        Me.CboDoctype.Name = "CboDoctype"
        Me.CboDoctype.Size = New System.Drawing.Size(121, 21)
        Me.CboDoctype.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Out No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Out Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(267, 66)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 14
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(131, 66)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 13
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(131, 90)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(88, 20)
        Me.txtOutNo.TabIndex = 10
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip1.TabIndex = 30
        '
        'frmSearchDOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 496)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSearchDOUT"
        Me.Text = "Search Dyed OUT"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbocustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lbcustomer As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents outno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outdt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents CboDoctype As System.Windows.Forms.ComboBox
End Class
