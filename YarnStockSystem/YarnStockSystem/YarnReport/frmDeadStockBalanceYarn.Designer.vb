<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeadStockBalanceYarn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeadStockBalanceYarn))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsstlblReportBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nmudToYear = New System.Windows.Forms.NumericUpDown()
        Me.nmudFromYear = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbYRA = New System.Windows.Forms.RadioButton()
        Me.rbYBM = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nmudToYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmudFromYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.ToolStripSeparator2, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(247, 25)
        Me.ToolStrip1.TabIndex = 20
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsstlblReportBy})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 203)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(247, 22)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsstlblReportBy
        '
        Me.tsstlblReportBy.Name = "tsstlblReportBy"
        Me.tsstlblReportBy.Size = New System.Drawing.Size(64, 17)
        Me.tsstlblReportBy.Text = "Report By :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nmudToYear)
        Me.GroupBox1.Controls.Add(Me.nmudFromYear)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 85)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'nmudToYear
        '
        Me.nmudToYear.Location = New System.Drawing.Point(118, 48)
        Me.nmudToYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nmudToYear.Minimum = New Decimal(New Integer() {2015, 0, 0, 0})
        Me.nmudToYear.Name = "nmudToYear"
        Me.nmudToYear.Size = New System.Drawing.Size(52, 20)
        Me.nmudToYear.TabIndex = 22
        Me.nmudToYear.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'nmudFromYear
        '
        Me.nmudFromYear.Location = New System.Drawing.Point(118, 22)
        Me.nmudFromYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nmudFromYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nmudFromYear.Name = "nmudFromYear"
        Me.nmudFromYear.Size = New System.Drawing.Size(52, 20)
        Me.nmudFromYear.TabIndex = 22
        Me.nmudFromYear.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "From Year"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbYBM)
        Me.GroupBox2.Controls.Add(Me.rbYRA)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 60)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'rbYRA
        '
        Me.rbYRA.AutoSize = True
        Me.rbYRA.Checked = True
        Me.rbYRA.Location = New System.Drawing.Point(31, 23)
        Me.rbYRA.Name = "rbYRA"
        Me.rbYRA.Size = New System.Drawing.Size(47, 17)
        Me.rbYRA.TabIndex = 0
        Me.rbYRA.TabStop = True
        Me.rbYRA.Text = "YRA"
        Me.rbYRA.UseVisualStyleBackColor = True
        '
        'rbYBM
        '
        Me.rbYBM.AutoSize = True
        Me.rbYBM.Location = New System.Drawing.Point(119, 23)
        Me.rbYBM.Name = "rbYBM"
        Me.rbYBM.Size = New System.Drawing.Size(48, 17)
        Me.rbYBM.TabIndex = 0
        Me.rbYBM.Text = "YBM"
        Me.rbYBM.UseVisualStyleBackColor = True
        '
        'frmDeadStockBalanceYarn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 225)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDeadStockBalanceYarn"
        Me.Text = "Dead Stock Balance - Yarn"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nmudToYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmudFromYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsstlblReportBy As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nmudToYear As NumericUpDown
    Friend WithEvents nmudFromYear As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbYBM As RadioButton
    Friend WithEvents rbYRA As RadioButton
End Class
