<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineProductivity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachineProductivity))
        Me.cboko_group = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmtl_warehouse = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optSumMonth = New System.Windows.Forms.RadioButton()
        Me.optSummary = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.optShift = New System.Windows.Forms.RadioButton()
        Me.optDate = New System.Windows.Forms.RadioButton()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboko_group
        '
        Me.cboko_group.FormattingEnabled = True
        Me.cboko_group.Location = New System.Drawing.Point(50, 29)
        Me.cboko_group.Name = "cboko_group"
        Me.cboko_group.Size = New System.Drawing.Size(125, 21)
        Me.cboko_group.TabIndex = 203
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cboko_group)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 71)
        Me.GroupBox3.TabIndex = 208
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Production Filter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Group"
        '
        'lblmtl_warehouse
        '
        Me.lblmtl_warehouse.AutoSize = True
        Me.lblmtl_warehouse.Location = New System.Drawing.Point(6, 22)
        Me.lblmtl_warehouse.Name = "lblmtl_warehouse"
        Me.lblmtl_warehouse.Size = New System.Drawing.Size(31, 13)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblmtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 63)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "M/C Filter"
        '
        'optSumMonth
        '
        Me.optSumMonth.AutoSize = True
        Me.optSumMonth.Location = New System.Drawing.Point(96, 56)
        Me.optSumMonth.Name = "optSumMonth"
        Me.optSumMonth.Size = New System.Drawing.Size(80, 17)
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
        Me.optSummary.Size = New System.Drawing.Size(83, 17)
        Me.optSummary.TabIndex = 2
        Me.optSummary.Text = "By Summary"
        Me.optSummary.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "Month"
        '
        'optShift
        '
        Me.optShift.AutoSize = True
        Me.optShift.Location = New System.Drawing.Point(96, 24)
        Me.optShift.Name = "optShift"
        Me.optShift.Size = New System.Drawing.Size(61, 17)
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
        Me.optDate.Size = New System.Drawing.Size(63, 17)
        Me.optDate.TabIndex = 0
        Me.optDate.TabStop = True
        Me.optDate.Text = "By Date"
        Me.optDate.UseVisualStyleBackColor = True
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(70, 36)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(125, 20)
        Me.dtpStartDate.TabIndex = 205
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSumMonth)
        Me.GroupBox1.Controls.Add(Me.optSummary)
        Me.GroupBox1.Controls.Add(Me.optShift)
        Me.GroupBox1.Controls.Add(Me.optDate)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 88)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amount"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(215, 25)
        Me.ToolStrip1.TabIndex = 203
        '
        'frmMachineProductivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 320)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMachineProductivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Productivity"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboko_group As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmtl_warehouse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optSumMonth As System.Windows.Forms.RadioButton
    Friend WithEvents optSummary As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optShift As System.Windows.Forms.RadioButton
    Friend WithEvents optDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
End Class
