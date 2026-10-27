<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOIFromGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBOIFromGIN))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optReturn = New System.Windows.Forms.RadioButton()
        Me.optPurchase = New System.Windows.Forms.RadioButton()
        Me.optPreset = New System.Windows.Forms.RadioButton()
        Me.optKnitting = New System.Windows.Forms.RadioButton()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 32)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optReturn)
        Me.GroupBox1.Controls.Add(Me.optPurchase)
        Me.GroupBox1.Controls.Add(Me.optPreset)
        Me.GroupBox1.Controls.Add(Me.optKnitting)
        Me.GroupBox1.Controls.Add(Me.dtpMonth)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 84)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'optReturn
        '
        Me.optReturn.AutoSize = True
        Me.optReturn.Location = New System.Drawing.Point(271, 48)
        Me.optReturn.Name = "optReturn"
        Me.optReturn.Size = New System.Drawing.Size(57, 17)
        Me.optReturn.TabIndex = 13
        Me.optReturn.Text = "Return"
        Me.optReturn.UseVisualStyleBackColor = True
        '
        'optPurchase
        '
        Me.optPurchase.AutoSize = True
        Me.optPurchase.Location = New System.Drawing.Point(185, 48)
        Me.optPurchase.Name = "optPurchase"
        Me.optPurchase.Size = New System.Drawing.Size(70, 17)
        Me.optPurchase.TabIndex = 12
        Me.optPurchase.Text = "Purchase"
        Me.optPurchase.UseVisualStyleBackColor = True
        '
        'optPreset
        '
        Me.optPreset.AutoSize = True
        Me.optPreset.Location = New System.Drawing.Point(112, 48)
        Me.optPreset.Name = "optPreset"
        Me.optPreset.Size = New System.Drawing.Size(55, 17)
        Me.optPreset.TabIndex = 11
        Me.optPreset.Text = "Preset"
        Me.optPreset.UseVisualStyleBackColor = True
        '
        'optKnitting
        '
        Me.optKnitting.AutoSize = True
        Me.optKnitting.Checked = True
        Me.optKnitting.Location = New System.Drawing.Point(33, 48)
        Me.optKnitting.Name = "optKnitting"
        Me.optKnitting.Size = New System.Drawing.Size(60, 17)
        Me.optKnitting.TabIndex = 10
        Me.optKnitting.TabStop = True
        Me.optKnitting.Text = "Knitting"
        Me.optKnitting.UseVisualStyleBackColor = True
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(112, 18)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(143, 20)
        Me.dtpMonth.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(40, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Month"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(372, 25)
        Me.ToolStrip1.TabIndex = 25
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
        'frmBOIFromGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 171)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmBOIFromGIN"
        Me.Text = "BOI From Greige IN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optPreset As System.Windows.Forms.RadioButton
    Friend WithEvents optKnitting As System.Windows.Forms.RadioButton
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents optReturn As System.Windows.Forms.RadioButton
    Friend WithEvents optPurchase As System.Windows.Forms.RadioButton
End Class
