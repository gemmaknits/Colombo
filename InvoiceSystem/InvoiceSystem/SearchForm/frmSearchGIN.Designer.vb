<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchGIN))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbocustomer = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.lbcustomer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.txtTranNo = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdGIN = New System.Windows.Forms.DataGridView()
        Me.tran_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CboDoc_Type = New System.Windows.Forms.ComboBox()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.lblDoNo = New System.Windows.Forms.Label()
        Me.txtSourceRefno = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.grdGIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'cbocustomer
        '
        Me.cbocustomer.FormattingEnabled = true
        Me.cbocustomer.Location = New System.Drawing.Point(131, 31)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(224, 21)
        Me.cbocustomer.TabIndex = 19
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"),System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "&Refresh"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"),System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'lbcustomer
        '
        Me.lbcustomer.AutoSize = true
        Me.lbcustomer.Location = New System.Drawing.Point(26, 31)
        Me.lbcustomer.Name = "lbcustomer"
        Me.lbcustomer.Size = New System.Drawing.Size(51, 13)
        Me.lbcustomer.TabIndex = 18
        Me.lbcustomer.Text = "Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSourceRefno)
        Me.GroupBox1.Controls.Add(Me.lblDoNo)
        Me.GroupBox1.Controls.Add(Me.LbDoctype)
        Me.GroupBox1.Controls.Add(Me.CboDoc_Type)
        Me.GroupBox1.Controls.Add(Me.cbocustomer)
        Me.GroupBox1.Controls.Add(Me.lbcustomer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.txtTranNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 160)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = false
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"),System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(422, 133)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 23
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(23, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "GIN No."
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(235, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "GIN Date"
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
        'txtTranNo
        '
        Me.txtTranNo.Location = New System.Drawing.Point(131, 90)
        Me.txtTranNo.Name = "txtTranNo"
        Me.txtTranNo.Size = New System.Drawing.Size(88, 20)
        Me.txtTranNo.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"),System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'grdGIN
        '
        Me.grdGIN.AllowUserToAddRows = false
        Me.grdGIN.AllowUserToDeleteRows = false
        Me.grdGIN.AllowUserToOrderColumns = true
        Me.grdGIN.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdGIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tran_no, Me.custname, Me.tran_dt})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdGIN.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdGIN.Location = New System.Drawing.Point(12, 245)
        Me.grdGIN.Name = "grdGIN"
        Me.grdGIN.ReadOnly = true
        Me.grdGIN.Size = New System.Drawing.Size(498, 234)
        Me.grdGIN.TabIndex = 26
        '
        'tran_no
        '
        Me.tran_no.DataPropertyName = "tran_no"
        Me.tran_no.HeaderText = "GIN No."
        Me.tran_no.Name = "tran_no"
        Me.tran_no.ReadOnly = true
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = true
        Me.custname.Width = 200
        '
        'tran_dt
        '
        Me.tran_dt.DataPropertyName = "tran_dt"
        Me.tran_dt.HeaderText = "GIN Date"
        Me.tran_dt.Name = "tran_dt"
        Me.tran_dt.ReadOnly = true
        Me.tran_dt.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(557, 25)
        Me.ToolStrip1.TabIndex = 27
        '
        'CboDoc_Type
        '
        Me.CboDoc_Type.FormattingEnabled = true
        Me.CboDoc_Type.Location = New System.Drawing.Point(131, 126)
        Me.CboDoc_Type.Name = "CboDoc_Type"
        Me.CboDoc_Type.Size = New System.Drawing.Size(224, 21)
        Me.CboDoc_Type.TabIndex = 20
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = true
        Me.LbDoctype.Location = New System.Drawing.Point(26, 126)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 21
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'lblDoNo
        '
        Me.lblDoNo.AutoSize = true
        Me.lblDoNo.Location = New System.Drawing.Point(225, 93)
        Me.lblDoNo.Name = "lblDoNo"
        Me.lblDoNo.Size = New System.Drawing.Size(40, 13)
        Me.lblDoNo.TabIndex = 22
        Me.lblDoNo.Text = "Bill No."
        '
        'txtSourceRefno
        '
        Me.txtSourceRefno.Location = New System.Drawing.Point(267, 90)
        Me.txtSourceRefno.Name = "txtSourceRefno"
        Me.txtSourceRefno.Size = New System.Drawing.Size(88, 20)
        Me.txtSourceRefno.TabIndex = 23
        '
        'frmSearchGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdGIN)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSearchGIN"
        Me.Text = "Search Greige IN"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.grdGIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cbocustomer As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbcustomer As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTranNo As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdGIN As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tran_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tran_dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents CboDoc_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txtSourceRefno As System.Windows.Forms.TextBox
    Friend WithEvents lblDoNo As System.Windows.Forms.Label
End Class
