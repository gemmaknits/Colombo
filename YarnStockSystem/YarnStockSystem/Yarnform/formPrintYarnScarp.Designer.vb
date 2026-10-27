<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintYarnScarp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrintYarnScarp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkWO = New System.Windows.Forms.RadioButton()
        Me.chkKI = New System.Windows.Forms.RadioButton()
        Me.ChkAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 54)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Yarn Scrap Date range"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(192, 24)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "From"
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(64, 24)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(325, 25)
        Me.ToolStrip1.TabIndex = 172
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
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(336, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(0, 0)
        Me.btnClear.TabIndex = 175
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(76, 45)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.Size = New System.Drawing.Size(216, 20)
        Me.txtKoNo.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Prod No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkAll)
        Me.GroupBox2.Controls.Add(Me.ChkWO)
        Me.GroupBox2.Controls.Add(Me.chkKI)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 53)
        Me.GroupBox2.TabIndex = 221
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Type"
        '
        'ChkWO
        '
        Me.ChkWO.AutoSize = True
        Me.ChkWO.Location = New System.Drawing.Point(105, 19)
        Me.ChkWO.Name = "ChkWO"
        Me.ChkWO.Size = New System.Drawing.Size(44, 17)
        Me.ChkWO.TabIndex = 1
        Me.ChkWO.Text = "WO"
        Me.ChkWO.UseVisualStyleBackColor = True
        '
        'chkKI
        '
        Me.chkKI.AutoSize = True
        Me.chkKI.Location = New System.Drawing.Point(21, 19)
        Me.chkKI.Name = "chkKI"
        Me.chkKI.Size = New System.Drawing.Size(35, 17)
        Me.chkKI.TabIndex = 0
        Me.chkKI.Text = "KI"
        Me.chkKI.UseVisualStyleBackColor = True
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Checked = True
        Me.ChkAll.Location = New System.Drawing.Point(192, 19)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(36, 17)
        Me.ChkAll.TabIndex = 2
        Me.ChkAll.TabStop = True
        Me.ChkAll.Text = "All"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'formPrintYarnScarp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 204)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKoNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "formPrintYarnScarp"
        Me.Text = "Print Yarn Scarp Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtKoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAll As System.Windows.Forms.RadioButton
    Friend WithEvents ChkWO As System.Windows.Forms.RadioButton
    Friend WithEvents chkKI As System.Windows.Forms.RadioButton
End Class
