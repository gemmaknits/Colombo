<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestCOnhand
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
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequestCOnhand))
		Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.n_yds = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.n_mts = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
		Me.cboDesignNo = New System.Windows.Forms.ToolStripComboBox
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.btnRefresh = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.doc_type_name = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.grdReqDOnhand = New System.Windows.Forms.DataGridView
		Me.outreqno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.outreqdt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.nob = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.rptwth_s = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.rptlen_s = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ToolStrip1.SuspendLayout()
		CType(Me.grdReqDOnhand, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'n_yds
		'
		Me.n_yds.DataPropertyName = "n_yds"
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.n_yds.DefaultCellStyle = DataGridViewCellStyle11
		Me.n_yds.HeaderText = "N-Yds."
		Me.n_yds.Name = "n_yds"
		Me.n_yds.ReadOnly = True
		Me.n_yds.Width = 50
		'
		'n_mts
		'
		Me.n_mts.DataPropertyName = "n_mts"
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.n_mts.DefaultCellStyle = DataGridViewCellStyle12
		Me.n_mts.HeaderText = "N-Mts."
		Me.n_mts.Name = "n_mts"
		Me.n_mts.ReadOnly = True
		Me.n_mts.Width = 50
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDesignNo, Me.ToolStripSeparator1, Me.btnRefresh, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(991, 25)
		Me.ToolStrip1.TabIndex = 38
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 22)
		Me.ToolStripLabel1.Text = "Design No."
		'
		'cboDesignNo
		'
		Me.cboDesignNo.Name = "cboDesignNo"
		Me.cboDesignNo.Size = New System.Drawing.Size(100, 25)
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'btnRefresh
		'
		Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
		Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
		Me.btnRefresh.Text = "Refresh"
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
		'kg
		'
		Me.kg.DataPropertyName = "kg"
		DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.kg.DefaultCellStyle = DataGridViewCellStyle13
		Me.kg.HeaderText = "Kgs."
		Me.kg.Name = "kg"
		Me.kg.ReadOnly = True
		Me.kg.Width = 50
		'
		'yds
		'
		Me.yds.DataPropertyName = "yds"
		DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.yds.DefaultCellStyle = DataGridViewCellStyle14
		Me.yds.HeaderText = "Yds."
		Me.yds.Name = "yds"
		Me.yds.ReadOnly = True
		Me.yds.Width = 50
		'
		'mts
		'
		Me.mts.DataPropertyName = "mts"
		DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.mts.DefaultCellStyle = DataGridViewCellStyle15
		Me.mts.HeaderText = "Mts."
		Me.mts.Name = "mts"
		Me.mts.ReadOnly = True
		Me.mts.Width = 50
		'
		'doc_type_name
		'
		Me.doc_type_name.DataPropertyName = "doc_type_name"
		Me.doc_type_name.HeaderText = "Req. For"
		Me.doc_type_name.Name = "doc_type_name"
		Me.doc_type_name.ReadOnly = True
		Me.doc_type_name.Width = 65
		'
		'empname
		'
		Me.empname.DataPropertyName = "empname"
		Me.empname.HeaderText = "Owner"
		Me.empname.Name = "empname"
		Me.empname.ReadOnly = True
		Me.empname.Width = 50
		'
		'sono
		'
		Me.sono.DataPropertyName = "sono"
		Me.sono.HeaderText = "S/O No."
		Me.sono.Name = "sono"
		Me.sono.ReadOnly = True
		Me.sono.Width = 60
		'
		'grdReqDOnhand
		'
		Me.grdReqDOnhand.AllowUserToAddRows = False
		Me.grdReqDOnhand.AllowUserToDeleteRows = False
		Me.grdReqDOnhand.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdReqDOnhand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdReqDOnhand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.outreqno, Me.outreqdt, Me.doc_type_name, Me.empname, Me.sono, Me.custname, Me.design_no, Me.gwth, Me.nob, Me.rptwth_s, Me.rptlen_s, Me.kg, Me.yds, Me.mts, Me.n_yds, Me.n_mts})
		DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdReqDOnhand.DefaultCellStyle = DataGridViewCellStyle20
		Me.grdReqDOnhand.Location = New System.Drawing.Point(8, 32)
		Me.grdReqDOnhand.Name = "grdReqDOnhand"
		Me.grdReqDOnhand.Size = New System.Drawing.Size(976, 584)
		Me.grdReqDOnhand.TabIndex = 37
		'
		'outreqno
		'
		Me.outreqno.DataPropertyName = "outreqno"
		Me.outreqno.HeaderText = "Req. No."
		Me.outreqno.Name = "outreqno"
		Me.outreqno.ReadOnly = True
		Me.outreqno.Width = 70
		'
		'outreqdt
		'
		Me.outreqdt.DataPropertyName = "outreqdt"
		Me.outreqdt.HeaderText = "Req. Date"
		Me.outreqdt.Name = "outreqdt"
		Me.outreqdt.ReadOnly = True
		Me.outreqdt.Width = 60
		'
		'custname
		'
		Me.custname.DataPropertyName = "custname"
		Me.custname.HeaderText = "Customer"
		Me.custname.Name = "custname"
		Me.custname.ReadOnly = True
		Me.custname.Width = 90
		'
		'design_no
		'
		Me.design_no.DataPropertyName = "design_no"
		Me.design_no.HeaderText = "Design No."
		Me.design_no.Name = "design_no"
		Me.design_no.ReadOnly = True
		Me.design_no.Width = 70
		'
		'gwth
		'
		Me.gwth.DataPropertyName = "gwth"
		DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.gwth.DefaultCellStyle = DataGridViewCellStyle16
		Me.gwth.HeaderText = "Gwth"
		Me.gwth.Name = "gwth"
		Me.gwth.ReadOnly = True
		Me.gwth.Width = 45
		'
		'nob
		'
		Me.nob.DataPropertyName = "nob"
		DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.nob.DefaultCellStyle = DataGridViewCellStyle17
		Me.nob.HeaderText = "Nob"
		Me.nob.Name = "nob"
		Me.nob.ReadOnly = True
		Me.nob.Width = 35
		'
		'rptwth_s
		'
		Me.rptwth_s.DataPropertyName = "rptwth_s"
		DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.rptwth_s.DefaultCellStyle = DataGridViewCellStyle18
		Me.rptwth_s.HeaderText = "Rpt.Wth (cms)"
		Me.rptwth_s.Name = "rptwth_s"
		Me.rptwth_s.ReadOnly = True
		Me.rptwth_s.Width = 60
		'
		'rptlen_s
		'
		Me.rptlen_s.DataPropertyName = "rptlen_s"
		DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		Me.rptlen_s.DefaultCellStyle = DataGridViewCellStyle19
		Me.rptlen_s.HeaderText = "Rpt.Len (cms)"
		Me.rptlen_s.Name = "rptlen_s"
		Me.rptlen_s.ReadOnly = True
		Me.rptlen_s.Width = 60
		'
		'frmRequestCOnhand
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(991, 623)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.grdReqDOnhand)
		Me.Name = "frmRequestCOnhand"
		Me.Text = "Request Onhand (Cutted)"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.grdReqDOnhand, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents n_yds As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents n_mts As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDesignNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents yds As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents doc_type_name As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents sono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents grdReqDOnhand As System.Windows.Forms.DataGridView
	Friend WithEvents outreqno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents outreqdt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents nob As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents rptwth_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents rptlen_s As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
