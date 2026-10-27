<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestSearch
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestSearch))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.btnRefresh2 = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.cboCustomer = New System.Windows.Forms.ComboBox
		Me.txtReqNo = New System.Windows.Forms.TextBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnRefresh = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.grdReq = New System.Windows.Forms.DataGridView
		Me.outreqno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.outreqdt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.doctypename = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.GroupBox1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		CType(Me.grdReq, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 64)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Req. No."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(176, 40)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 13)
		Me.Label3.TabIndex = 16
		Me.Label3.Text = "To"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 40)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Req. Date"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(208, 40)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 14
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(72, 40)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 13
		'
		'btnRefresh2
		'
		Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
		Me.btnRefresh2.Location = New System.Drawing.Point(320, 40)
		Me.btnRefresh2.Name = "btnRefresh2"
		Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
		Me.btnRefresh2.TabIndex = 23
		Me.btnRefresh2.Text = "&Refresh"
		Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnRefresh2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Customer"
		'
		'cboCustomer
		'
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(72, 16)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(224, 21)
		Me.cboCustomer.TabIndex = 11
		'
		'txtReqNo
		'
		Me.txtReqNo.Location = New System.Drawing.Point(72, 64)
		Me.txtReqNo.Name = "txtReqNo"
		Me.txtReqNo.Size = New System.Drawing.Size(88, 20)
		Me.txtReqNo.TabIndex = 10
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cboCustomer)
		Me.GroupBox1.Controls.Add(Me.txtReqNo)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(304, 88)
		Me.GroupBox1.TabIndex = 22
		Me.GroupBox1.TabStop = False
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(401, 25)
		Me.ToolStrip1.TabIndex = 21
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
		'grdReq
		'
		Me.grdReq.AllowUserToAddRows = False
		Me.grdReq.AllowUserToDeleteRows = False
		Me.grdReq.AllowUserToOrderColumns = True
		Me.grdReq.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdReq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.outreqno, Me.outreqdt, Me.doctypename, Me.custname})
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdReq.DefaultCellStyle = DataGridViewCellStyle1
		Me.grdReq.Location = New System.Drawing.Point(8, 128)
		Me.grdReq.Name = "grdReq"
		Me.grdReq.ReadOnly = True
		Me.grdReq.Size = New System.Drawing.Size(384, 312)
		Me.grdReq.TabIndex = 20
		'
		'outreqno
		'
		Me.outreqno.DataPropertyName = "outreqno"
		Me.outreqno.HeaderText = "Req. No."
		Me.outreqno.Name = "outreqno"
		Me.outreqno.ReadOnly = True
		Me.outreqno.Width = 80
		'
		'outreqdt
		'
		Me.outreqdt.DataPropertyName = "outreqdt2"
		Me.outreqdt.HeaderText = "Req. Date"
		Me.outreqdt.Name = "outreqdt"
		Me.outreqdt.ReadOnly = True
		Me.outreqdt.Width = 80
		'
		'doctypename
		'
		Me.doctypename.HeaderText = "Type"
		Me.doctypename.Name = "doctypename"
		Me.doctypename.ReadOnly = True
		Me.doctypename.Width = 50
		'
		'custname
		'
		Me.custname.DataPropertyName = "custname"
		Me.custname.HeaderText = "Customer"
		Me.custname.Name = "custname"
		Me.custname.ReadOnly = True
		'
		'frmRequestSearch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(401, 449)
		Me.Controls.Add(Me.btnRefresh2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.grdReq)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmRequestSearch"
		Me.Text = "Search Request"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.grdReq, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents grdReq As System.Windows.Forms.DataGridView
	Friend WithEvents outreqno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents outreqdt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents doctypename As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
