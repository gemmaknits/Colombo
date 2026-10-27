<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockByBOI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockByBOI))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDBAL = New System.Windows.Forms.RadioButton()
        Me.optDOUT = New System.Windows.Forms.RadioButton()
        Me.optDIN = New System.Windows.Forms.RadioButton()
        Me.optGOUT = New System.Windows.Forms.RadioButton()
        Me.optGIN = New System.Windows.Forms.RadioButton()
        Me.optGBAL = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(297, 25)
        Me.ToolStrip1.TabIndex = 4
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
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(200, 40)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date From"
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(72, 40)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optGBAL)
        Me.GroupBox1.Controls.Add(Me.optDBAL)
        Me.GroupBox1.Controls.Add(Me.optDOUT)
        Me.GroupBox1.Controls.Add(Me.optDIN)
        Me.GroupBox1.Controls.Add(Me.optGOUT)
        Me.GroupBox1.Controls.Add(Me.optGIN)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 78)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Type"
        '
        'optDBAL
        '
        Me.optDBAL.AutoSize = True
        Me.optDBAL.Location = New System.Drawing.Point(181, 55)
        Me.optDBAL.Name = "optDBAL"
        Me.optDBAL.Size = New System.Drawing.Size(56, 17)
        Me.optDBAL.TabIndex = 4
        Me.optDBAL.Text = "D-BAL"
        Me.optDBAL.UseVisualStyleBackColor = True
        '
        'optDOUT
        '
        Me.optDOUT.AutoSize = True
        Me.optDOUT.Location = New System.Drawing.Point(200, 24)
        Me.optDOUT.Name = "optDOUT"
        Me.optDOUT.Size = New System.Drawing.Size(59, 17)
        Me.optDOUT.TabIndex = 3
        Me.optDOUT.Text = "D-OUT"
        Me.optDOUT.UseVisualStyleBackColor = True
        '
        'optDIN
        '
        Me.optDIN.AutoSize = True
        Me.optDIN.Location = New System.Drawing.Point(144, 24)
        Me.optDIN.Name = "optDIN"
        Me.optDIN.Size = New System.Drawing.Size(47, 17)
        Me.optDIN.TabIndex = 2
        Me.optDIN.Text = "D-IN"
        Me.optDIN.UseVisualStyleBackColor = True
        '
        'optGOUT
        '
        Me.optGOUT.AutoSize = True
        Me.optGOUT.Location = New System.Drawing.Point(72, 24)
        Me.optGOUT.Name = "optGOUT"
        Me.optGOUT.Size = New System.Drawing.Size(59, 17)
        Me.optGOUT.TabIndex = 1
        Me.optGOUT.Text = "G-OUT"
        Me.optGOUT.UseVisualStyleBackColor = True
        '
        'optGIN
        '
        Me.optGIN.AutoSize = True
        Me.optGIN.Checked = True
        Me.optGIN.Location = New System.Drawing.Point(16, 24)
        Me.optGIN.Name = "optGIN"
        Me.optGIN.Size = New System.Drawing.Size(47, 17)
        Me.optGIN.TabIndex = 0
        Me.optGIN.TabStop = True
        Me.optGIN.Text = "G-IN"
        Me.optGIN.UseVisualStyleBackColor = True
        '
        'optGBAL
        '
        Me.optGBAL.AutoSize = True
        Me.optGBAL.Location = New System.Drawing.Point(55, 55)
        Me.optGBAL.Name = "optGBAL"
        Me.optGBAL.Size = New System.Drawing.Size(56, 17)
        Me.optGBAL.TabIndex = 5
        Me.optGBAL.Text = "G-BAL"
        Me.optGBAL.UseVisualStyleBackColor = True
        '
        'frmStockByBOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 165)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockByBOI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock By BOI"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optDOUT As System.Windows.Forms.RadioButton
    Friend WithEvents optDIN As System.Windows.Forms.RadioButton
    Friend WithEvents optGOUT As System.Windows.Forms.RadioButton
    Friend WithEvents optGIN As System.Windows.Forms.RadioButton
    Friend WithEvents optDBAL As System.Windows.Forms.RadioButton
    Friend WithEvents optGBAL As System.Windows.Forms.RadioButton
End Class
