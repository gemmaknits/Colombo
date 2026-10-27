<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRDSsProductionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDSsProductionReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMcNo = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbGrpByMachineNo = New System.Windows.Forms.RadioButton()
        Me.rbGrpByDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMcNo)
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 107)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'cmbMcNo
        '
        Me.cmbMcNo.FormattingEnabled = True
        Me.cmbMcNo.Location = New System.Drawing.Point(126, 24)
        Me.cmbMcNo.Name = "cmbMcNo"
        Me.cmbMcNo.Size = New System.Drawing.Size(115, 21)
        Me.cmbMcNo.TabIndex = 63
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoCompleteCustomSource.AddRange(New String() {"", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(126, 49)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(52, 21)
        Me.cmbMonth.TabIndex = 62
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(126, 75)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(52, 22)
        Me.txtYear.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Machine No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(290, 25)
        Me.ToolStrip1.TabIndex = 195
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbGrpByDate)
        Me.GroupBox2.Controls.Add(Me.rbGrpByMachineNo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 88)
        Me.GroupBox2.TabIndex = 196
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Group By"
        '
        'rbGrpByMachineNo
        '
        Me.rbGrpByMachineNo.AutoSize = True
        Me.rbGrpByMachineNo.Checked = True
        Me.rbGrpByMachineNo.Location = New System.Drawing.Point(35, 28)
        Me.rbGrpByMachineNo.Name = "rbGrpByMachineNo"
        Me.rbGrpByMachineNo.Size = New System.Drawing.Size(83, 17)
        Me.rbGrpByMachineNo.TabIndex = 0
        Me.rbGrpByMachineNo.TabStop = True
        Me.rbGrpByMachineNo.Text = "Machine No"
        Me.rbGrpByMachineNo.UseVisualStyleBackColor = True
        '
        'rbGrpByDate
        '
        Me.rbGrpByDate.AutoSize = True
        Me.rbGrpByDate.Location = New System.Drawing.Point(35, 51)
        Me.rbGrpByDate.Name = "rbGrpByDate"
        Me.rbGrpByDate.Size = New System.Drawing.Size(48, 17)
        Me.rbGrpByDate.TabIndex = 1
        Me.rbGrpByDate.Text = "Date"
        Me.rbGrpByDate.UseVisualStyleBackColor = True
        '
        'frmRDSsProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 243)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRDSsProductionReport"
        Me.Text = "RDS's  Production  Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents cmbMcNo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbGrpByDate As RadioButton
    Friend WithEvents rbGrpByMachineNo As RadioButton
End Class
