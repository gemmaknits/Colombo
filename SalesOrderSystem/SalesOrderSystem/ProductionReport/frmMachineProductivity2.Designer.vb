<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachineProductivity2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMachineProductivity2))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSummary = New System.Windows.Forms.RadioButton()
        Me.optShift = New System.Windows.Forms.RadioButton()
        Me.optDate = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblmtl_warehouse = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.optSumMonth = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optBEAMING = New System.Windows.Forms.RadioButton()
        Me.optWARPKNIT = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(249, 25)
        Me.ToolStrip1.TabIndex = 196
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
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
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(80, 32)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(125, 20)
        Me.dtpStartDate.TabIndex = 198
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSumMonth)
        Me.GroupBox1.Controls.Add(Me.optSummary)
        Me.GroupBox1.Controls.Add(Me.optShift)
        Me.GroupBox1.Controls.Add(Me.optDate)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 88)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amount"
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
        'optShift
        '
        Me.optShift.AutoSize = True
        Me.optShift.Location = New System.Drawing.Point(107, 24)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Month"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblmtl_warehouse)
        Me.GroupBox4.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 150)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(204, 61)
        Me.GroupBox4.TabIndex = 202
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filter"
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
        'optSumMonth
        '
        Me.optSumMonth.AutoSize = True
        Me.optSumMonth.Location = New System.Drawing.Point(107, 56)
        Me.optSumMonth.Name = "optSumMonth"
        Me.optSumMonth.Size = New System.Drawing.Size(80, 17)
        Me.optSumMonth.TabIndex = 4
        Me.optSumMonth.TabStop = True
        Me.optSumMonth.Text = "By Monthly "
        Me.optSumMonth.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optAll)
        Me.GroupBox3.Controls.Add(Me.optBEAMING)
        Me.GroupBox3.Controls.Add(Me.optWARPKNIT)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 71)
        Me.GroupBox3.TabIndex = 203
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "M/C Type Filter"
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(16, 43)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optBEAMING
        '
        Me.optBEAMING.AutoSize = True
        Me.optBEAMING.Location = New System.Drawing.Point(107, 19)
        Me.optBEAMING.Name = "optBEAMING"
        Me.optBEAMING.Size = New System.Drawing.Size(65, 17)
        Me.optBEAMING.TabIndex = 1
        Me.optBEAMING.TabStop = True
        Me.optBEAMING.Text = "Warping"
        Me.optBEAMING.UseVisualStyleBackColor = True
        '
        'optWARPKNIT
        '
        Me.optWARPKNIT.AutoSize = True
        Me.optWARPKNIT.Checked = True
        Me.optWARPKNIT.Location = New System.Drawing.Point(16, 20)
        Me.optWARPKNIT.Name = "optWARPKNIT"
        Me.optWARPKNIT.Size = New System.Drawing.Size(60, 17)
        Me.optWARPKNIT.TabIndex = 0
        Me.optWARPKNIT.TabStop = True
        Me.optWARPKNIT.Text = "Knitting"
        Me.optWARPKNIT.UseVisualStyleBackColor = True
        '
        'frmMachineProductivity2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 318)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMachineProductivity2"
        Me.Text = "Machine Productivity 2"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSummary As System.Windows.Forms.RadioButton
    Friend WithEvents optShift As System.Windows.Forms.RadioButton
    Friend WithEvents optDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmtl_warehouse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents optSumMonth As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optBEAMING As System.Windows.Forms.RadioButton
    Friend WithEvents optWARPKNIT As System.Windows.Forms.RadioButton
End Class
