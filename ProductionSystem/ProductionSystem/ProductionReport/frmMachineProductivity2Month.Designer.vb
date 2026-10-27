<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineProductivity2Month
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachineProductivity2Month))
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSumMonth = New System.Windows.Forms.RadioButton()
        Me.optSummary = New System.Windows.Forms.RadioButton()
        Me.optShift = New System.Windows.Forms.RadioButton()
        Me.optDate = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboko_group = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblmtl_warehouse = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "MMMM yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(225, 41)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(121, 22)
        Me.dtpEndDate.TabIndex = 238
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSumMonth)
        Me.GroupBox1.Controls.Add(Me.optSummary)
        Me.GroupBox1.Controls.Add(Me.optShift)
        Me.GroupBox1.Controls.Add(Me.optDate)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 140)
        Me.GroupBox1.TabIndex = 234
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amount"
        '
        'optSumMonth
        '
        Me.optSumMonth.AutoSize = True
        Me.optSumMonth.Location = New System.Drawing.Point(16, 117)
        Me.optSumMonth.Name = "optSumMonth"
        Me.optSumMonth.Size = New System.Drawing.Size(86, 17)
        Me.optSumMonth.TabIndex = 3
        Me.optSumMonth.TabStop = True
        Me.optSumMonth.Text = "By Monthly "
        Me.optSumMonth.UseVisualStyleBackColor = True
        '
        'optSummary
        '
        Me.optSummary.AutoSize = True
        Me.optSummary.Location = New System.Drawing.Point(16, 56)
        Me.optSummary.Name = "optSummary"
        Me.optSummary.Size = New System.Drawing.Size(86, 17)
        Me.optSummary.TabIndex = 2
        Me.optSummary.Text = "By Summary"
        Me.optSummary.UseVisualStyleBackColor = True
        '
        'optShift
        '
        Me.optShift.AutoSize = True
        Me.optShift.Location = New System.Drawing.Point(16, 87)
        Me.optShift.Name = "optShift"
        Me.optShift.Size = New System.Drawing.Size(64, 17)
        Me.optShift.TabIndex = 1
        Me.optShift.Text = "By Shift"
        Me.optShift.UseVisualStyleBackColor = True
        '
        'optDate
        '
        Me.optDate.AutoSize = True
        Me.optDate.Checked = True
        Me.optDate.Location = New System.Drawing.Point(16, 24)
        Me.optDate.Name = "optDate"
        Me.optDate.Size = New System.Drawing.Size(64, 17)
        Me.optDate.TabIndex = 0
        Me.optDate.TabStop = True
        Me.optDate.Text = "By Date"
        Me.optDate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Group"
        '
        'cboko_group
        '
        Me.cboko_group.FormattingEnabled = True
        Me.cboko_group.Location = New System.Drawing.Point(50, 29)
        Me.cboko_group.Name = "cboko_group"
        Me.cboko_group.Size = New System.Drawing.Size(125, 21)
        Me.cboko_group.TabIndex = 203
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "And"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboko_group)
        Me.GroupBox3.Location = New System.Drawing.Point(142, 136)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 71)
        Me.GroupBox3.TabIndex = 236
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Production Filter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblmtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Location = New System.Drawing.Point(142, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 63)
        Me.GroupBox2.TabIndex = 235
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "M/C Filter"
        '
        'lblmtl_warehouse
        '
        Me.lblmtl_warehouse.AutoSize = True
        Me.lblmtl_warehouse.Location = New System.Drawing.Point(6, 22)
        Me.lblmtl_warehouse.Name = "lblmtl_warehouse"
        Me.lblmtl_warehouse.Size = New System.Drawing.Size(30, 13)
        Me.lblmtl_warehouse.TabIndex = 202
        Me.lblmtl_warehouse.Text = "W/H"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(50, 19)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(125, 21)
        Me.cbomtl_warehouse.TabIndex = 201
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(354, 25)
        Me.ToolStrip1.TabIndex = 231
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(68, 41)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(125, 22)
        Me.dtpStartDate.TabIndex = 233
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Month"
        '
        'frmMachineProductivity2Month
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 208)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMachineProductivity2Month"
        Me.Text = "Machine Productivity 2 Month"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSumMonth As RadioButton
    Friend WithEvents optSummary As RadioButton
    Friend WithEvents optShift As RadioButton
    Friend WithEvents optDate As RadioButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboko_group As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblmtl_warehouse As Label
    Friend WithEvents cbomtl_warehouse As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
