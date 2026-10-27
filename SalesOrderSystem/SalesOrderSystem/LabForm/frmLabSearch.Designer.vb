<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabSearch
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabSearch))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.btnRefresh2 = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.cboDyedHouse = New System.Windows.Forms.ComboBox
		Me.txtLabNo = New System.Windows.Forms.TextBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnRefresh = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.grdInv = New System.Windows.Forms.DataGridView
		Me.labno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.labdt2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.dhname = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.GroupBox1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		CType(Me.grdInv, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 64)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(45, 13)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Lab No."
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(184, 40)
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
		Me.Label2.Size = New System.Drawing.Size(51, 13)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Lab Date"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(216, 40)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 14
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(80, 40)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 13
		'
		'btnRefresh2
		'
		Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
		Me.btnRefresh2.Location = New System.Drawing.Point(328, 40)
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
		Me.Label1.Size = New System.Drawing.Size(66, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Dyed House"
		'
		'cboDyedHouse
		'
		Me.cboDyedHouse.FormattingEnabled = True
		Me.cboDyedHouse.Location = New System.Drawing.Point(80, 16)
		Me.cboDyedHouse.Name = "cboDyedHouse"
		Me.cboDyedHouse.Size = New System.Drawing.Size(224, 21)
		Me.cboDyedHouse.TabIndex = 11
		'
		'txtLabNo
		'
		Me.txtLabNo.Location = New System.Drawing.Point(80, 64)
		Me.txtLabNo.Name = "txtLabNo"
		Me.txtLabNo.Size = New System.Drawing.Size(88, 20)
		Me.txtLabNo.TabIndex = 10
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.cboDyedHouse)
		Me.GroupBox1.Controls.Add(Me.txtLabNo)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(312, 96)
		Me.GroupBox1.TabIndex = 22
		Me.GroupBox1.TabStop = False
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(449, 25)
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
		'grdInv
		'
		Me.grdInv.AllowUserToAddRows = False
		Me.grdInv.AllowUserToDeleteRows = False
		Me.grdInv.AllowUserToOrderColumns = True
		Me.grdInv.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.labno, Me.labdt2, Me.dhname, Me.design_no, Me.gwth})
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.grdInv.DefaultCellStyle = DataGridViewCellStyle1
		Me.grdInv.Location = New System.Drawing.Point(8, 136)
		Me.grdInv.Name = "grdInv"
		Me.grdInv.ReadOnly = True
		Me.grdInv.Size = New System.Drawing.Size(432, 304)
		Me.grdInv.TabIndex = 20
		'
		'labno
		'
		Me.labno.DataPropertyName = "labno"
		Me.labno.HeaderText = "Lab No."
		Me.labno.Name = "labno"
		Me.labno.ReadOnly = True
		Me.labno.Width = 75
		'
		'labdt2
		'
		Me.labdt2.DataPropertyName = "labdt2"
		Me.labdt2.HeaderText = "Lab Date"
		Me.labdt2.Name = "labdt2"
		Me.labdt2.ReadOnly = True
		Me.labdt2.Width = 75
		'
		'dhname
		'
		Me.dhname.DataPropertyName = "dhname"
		Me.dhname.HeaderText = "Dyed House"
		Me.dhname.Name = "dhname"
		Me.dhname.ReadOnly = True
		'
		'design_no
		'
		Me.design_no.DataPropertyName = "design_no"
		Me.design_no.HeaderText = "Design No."
		Me.design_no.Name = "design_no"
		Me.design_no.ReadOnly = True
		Me.design_no.Width = 85
		'
		'gwth
		'
		Me.gwth.DataPropertyName = "gwth"
		Me.gwth.HeaderText = "Gwth"
		Me.gwth.Name = "gwth"
		Me.gwth.ReadOnly = True
		Me.gwth.Width = 35
		'
		'frmLabSearch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(449, 449)
		Me.Controls.Add(Me.btnRefresh2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.grdInv)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLabSearch"
		Me.Text = "Search Lab Dip"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.grdInv, System.ComponentModel.ISupportInitialize).EndInit()
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
	Friend WithEvents cboDyedHouse As System.Windows.Forms.ComboBox
	Friend WithEvents txtLabNo As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents grdInv As System.Windows.Forms.DataGridView
	Friend WithEvents labno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents labdt2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dhname As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
