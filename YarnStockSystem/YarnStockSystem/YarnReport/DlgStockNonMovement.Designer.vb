<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgStockNonMovement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DlgStockNonMovement))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsstlblReportBy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nmupdrYearTo = New System.Windows.Forms.NumericUpDown()
        Me.nmupdrYearFrom = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdShowDetail = New System.Windows.Forms.RadioButton()
        Me.rdShowSummary = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtShowOnlyPrefixYBM = New System.Windows.Forms.RadioButton()
        Me.rbtShowOnlyPrefixYRA = New System.Windows.Forms.RadioButton()
        Me.rbtShowPrefixAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbShowAverageWeight = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nmupdrYearTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmupdrYearFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.ToolStripSeparator2, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(449, 25)
        Me.ToolStrip1.TabIndex = 19
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 216)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(449, 22)
        Me.StatusStrip1.TabIndex = 21
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
        Me.GroupBox1.Controls.Add(Me.nmupdrYearTo)
        Me.GroupBox1.Controls.Add(Me.nmupdrYearFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 65)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Yarn In Date"
        '
        'nmupdrYearTo
        '
        Me.nmupdrYearTo.Location = New System.Drawing.Point(250, 28)
        Me.nmupdrYearTo.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nmupdrYearTo.Minimum = New Decimal(New Integer() {2015, 0, 0, 0})
        Me.nmupdrYearTo.Name = "nmupdrYearTo"
        Me.nmupdrYearTo.Size = New System.Drawing.Size(52, 20)
        Me.nmupdrYearTo.TabIndex = 22
        Me.nmupdrYearTo.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'nmupdrYearFrom
        '
        Me.nmupdrYearFrom.Location = New System.Drawing.Point(88, 28)
        Me.nmupdrYearFrom.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nmupdrYearFrom.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nmupdrYearFrom.Name = "nmupdrYearFrom"
        Me.nmupdrYearFrom.Size = New System.Drawing.Size(52, 20)
        Me.nmupdrYearFrom.TabIndex = 22
        Me.nmupdrYearFrom.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "From Year"
        '
        'rdShowDetail
        '
        Me.rdShowDetail.AutoSize = True
        Me.rdShowDetail.Location = New System.Drawing.Point(153, 19)
        Me.rdShowDetail.Name = "rdShowDetail"
        Me.rdShowDetail.Size = New System.Drawing.Size(82, 17)
        Me.rdShowDetail.TabIndex = 23
        Me.rdShowDetail.Text = "Show Detail"
        Me.rdShowDetail.UseVisualStyleBackColor = True
        '
        'rdShowSummary
        '
        Me.rdShowSummary.AutoSize = True
        Me.rdShowSummary.Checked = True
        Me.rdShowSummary.Location = New System.Drawing.Point(30, 19)
        Me.rdShowSummary.Name = "rdShowSummary"
        Me.rdShowSummary.Size = New System.Drawing.Size(98, 17)
        Me.rdShowSummary.TabIndex = 22
        Me.rdShowSummary.TabStop = True
        Me.rdShowSummary.Text = "Show Summary"
        Me.rdShowSummary.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdShowDetail)
        Me.GroupBox2.Controls.Add(Me.rdShowSummary)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 47)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รูปแบบของรายงาน"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtShowOnlyPrefixYBM)
        Me.GroupBox3.Controls.Add(Me.rbtShowOnlyPrefixYRA)
        Me.GroupBox3.Controls.Add(Me.rbtShowPrefixAll)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 47)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prefix of Item Code"
        '
        'rbtShowOnlyPrefixYBM
        '
        Me.rbtShowOnlyPrefixYBM.AutoSize = True
        Me.rbtShowOnlyPrefixYBM.Location = New System.Drawing.Point(276, 19)
        Me.rbtShowOnlyPrefixYBM.Name = "rbtShowOnlyPrefixYBM"
        Me.rbtShowOnlyPrefixYBM.Size = New System.Drawing.Size(102, 17)
        Me.rbtShowOnlyPrefixYBM.TabIndex = 24
        Me.rbtShowOnlyPrefixYBM.Text = "Show Only YBM"
        Me.rbtShowOnlyPrefixYBM.UseVisualStyleBackColor = True
        '
        'rbtShowOnlyPrefixYRA
        '
        Me.rbtShowOnlyPrefixYRA.AutoSize = True
        Me.rbtShowOnlyPrefixYRA.Location = New System.Drawing.Point(153, 19)
        Me.rbtShowOnlyPrefixYRA.Name = "rbtShowOnlyPrefixYRA"
        Me.rbtShowOnlyPrefixYRA.Size = New System.Drawing.Size(101, 17)
        Me.rbtShowOnlyPrefixYRA.TabIndex = 23
        Me.rbtShowOnlyPrefixYRA.Text = "Show Only YRA"
        Me.rbtShowOnlyPrefixYRA.UseVisualStyleBackColor = True
        '
        'rbtShowPrefixAll
        '
        Me.rbtShowPrefixAll.AutoSize = True
        Me.rbtShowPrefixAll.Checked = True
        Me.rbtShowPrefixAll.Location = New System.Drawing.Point(30, 19)
        Me.rbtShowPrefixAll.Name = "rbtShowPrefixAll"
        Me.rbtShowPrefixAll.Size = New System.Drawing.Size(66, 17)
        Me.rbtShowPrefixAll.TabIndex = 22
        Me.rbtShowPrefixAll.TabStop = True
        Me.rbtShowPrefixAll.Text = "Show All"
        Me.rbtShowPrefixAll.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbShowAverageWeight)
        Me.GroupBox4.Location = New System.Drawing.Point(272, 100)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(165, 47)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'cbShowAverageWeight
        '
        Me.cbShowAverageWeight.AutoSize = True
        Me.cbShowAverageWeight.Location = New System.Drawing.Point(11, 20)
        Me.cbShowAverageWeight.Name = "cbShowAverageWeight"
        Me.cbShowAverageWeight.Size = New System.Drawing.Size(133, 17)
        Me.cbShowAverageWeight.TabIndex = 0
        Me.cbShowAverageWeight.Text = "Show Average Weight"
        Me.cbShowAverageWeight.UseVisualStyleBackColor = True
        '
        'DlgStockNonMovement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 238)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgStockNonMovement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yarn Non Movement"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nmupdrYearTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmupdrYearFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdShowDetail As RadioButton
    Friend WithEvents rdShowSummary As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tsstlblReportBy As ToolStripStatusLabel
    Friend WithEvents nmupdrYearTo As NumericUpDown
    Friend WithEvents nmupdrYearFrom As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtShowOnlyPrefixYRA As RadioButton
    Friend WithEvents rbtShowPrefixAll As RadioButton
    Friend WithEvents rbtShowOnlyPrefixYBM As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbShowAverageWeight As CheckBox
End Class
