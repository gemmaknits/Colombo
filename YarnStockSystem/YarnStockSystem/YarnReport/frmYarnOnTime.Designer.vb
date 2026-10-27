<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnOnTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnOnTime))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.cbomcno = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptAllTime = New System.Windows.Forms.RadioButton()
        Me.OptWaitTime = New System.Windows.Forms.RadioButton()
        Me.OptOnTime = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(302, 25)
        Me.ToolStrip1.TabIndex = 202
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
        'cbomcno
        '
        Me.cbomcno.FormattingEnabled = True
        Me.cbomcno.Location = New System.Drawing.Point(28, 19)
        Me.cbomcno.Name = "cbomcno"
        Me.cbomcno.Size = New System.Drawing.Size(99, 21)
        Me.cbomcno.TabIndex = 203
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptAllTime)
        Me.GroupBox1.Controls.Add(Me.OptWaitTime)
        Me.GroupBox1.Controls.Add(Me.OptOnTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 56)
        Me.GroupBox1.TabIndex = 205
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step"
        '
        'OptAllTime
        '
        Me.OptAllTime.AutoSize = True
        Me.OptAllTime.Location = New System.Drawing.Point(208, 20)
        Me.OptAllTime.Name = "OptAllTime"
        Me.OptAllTime.Size = New System.Drawing.Size(65, 17)
        Me.OptAllTime.TabIndex = 40
        Me.OptAllTime.TabStop = True
        Me.OptAllTime.Text = "All-Time"
        Me.OptAllTime.UseVisualStyleBackColor = True
        '
        'OptWaitTime
        '
        Me.OptWaitTime.AutoSize = True
        Me.OptWaitTime.Location = New System.Drawing.Point(105, 20)
        Me.OptWaitTime.Name = "OptWaitTime"
        Me.OptWaitTime.Size = New System.Drawing.Size(76, 17)
        Me.OptWaitTime.TabIndex = 39
        Me.OptWaitTime.TabStop = True
        Me.OptWaitTime.Text = "Wait-Time"
        Me.OptWaitTime.UseVisualStyleBackColor = True
        '
        'OptOnTime
        '
        Me.OptOnTime.AutoSize = True
        Me.OptOnTime.Checked = True
        Me.OptOnTime.Location = New System.Drawing.Point(13, 20)
        Me.OptOnTime.Name = "OptOnTime"
        Me.OptOnTime.Size = New System.Drawing.Size(68, 17)
        Me.OptOnTime.TabIndex = 38
        Me.OptOnTime.TabStop = True
        Me.OptOnTime.Text = "On-Time"
        Me.OptOnTime.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbomcno)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 56)
        Me.GroupBox2.TabIndex = 206
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MC No."
        '
        'frmYarnOnTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 172)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYarnOnTime"
        Me.Text = "Yarn On Time"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cbomcno As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptAllTime As System.Windows.Forms.RadioButton
    Friend WithEvents OptWaitTime As System.Windows.Forms.RadioButton
    Friend WithEvents OptOnTime As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
