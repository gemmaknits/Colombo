<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintWOClosed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintWOClosed))
        Me.optUnclosed = New System.Windows.Forms.RadioButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.optKODate = New System.Windows.Forms.RadioButton()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.optClosedDate = New System.Windows.Forms.RadioButton()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMcNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'optUnclosed
        '
        Me.optUnclosed.AutoSize = True
        Me.optUnclosed.Location = New System.Drawing.Point(247, 42)
        Me.optUnclosed.Name = "optUnclosed"
        Me.optUnclosed.Size = New System.Drawing.Size(70, 17)
        Me.optUnclosed.TabIndex = 247
        Me.optUnclosed.Text = "Unclosed"
        Me.optUnclosed.UseVisualStyleBackColor = True
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
        'optKODate
        '
        Me.optKODate.AutoSize = True
        Me.optKODate.Location = New System.Drawing.Point(167, 42)
        Me.optKODate.Name = "optKODate"
        Me.optKODate.Size = New System.Drawing.Size(75, 17)
        Me.optKODate.TabIndex = 245
        Me.optKODate.Text = "W/O Date"
        Me.optKODate.UseVisualStyleBackColor = True
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(71, 66)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(104, 20)
        Me.dtpDateFr.TabIndex = 234
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 243
        Me.Label6.Text = "From"
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
        'optClosedDate
        '
        Me.optClosedDate.AutoSize = True
        Me.optClosedDate.Checked = True
        Me.optClosedDate.Location = New System.Drawing.Point(71, 42)
        Me.optClosedDate.Name = "optClosedDate"
        Me.optClosedDate.Size = New System.Drawing.Size(83, 17)
        Me.optClosedDate.TabIndex = 246
        Me.optClosedDate.TabStop = True
        Me.optClosedDate.Text = "Closed Date"
        Me.optClosedDate.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(231, 66)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpDateTo.TabIndex = 235
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "To"
        '
        'txtMcNo
        '
        Me.txtMcNo.Location = New System.Drawing.Point(71, 146)
        Me.txtMcNo.Name = "txtMcNo"
        Me.txtMcNo.Size = New System.Drawing.Size(128, 20)
        Me.txtMcNo.TabIndex = 238
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 241
        Me.Label2.Text = "W/O No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Yarn Code."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(71, 122)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(128, 20)
        Me.txtDesignNo.TabIndex = 237
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(71, 98)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.Size = New System.Drawing.Size(128, 20)
        Me.txtKoNo.TabIndex = 236
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 242
        Me.Label4.Text = "Machine No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(335, 25)
        Me.ToolStrip1.TabIndex = 239
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(71, 172)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(59, 17)
        Me.chkActual.TabIndex = 248
        Me.chkActual.Text = "Actual "
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'frmWOClosed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 212)
        Me.Controls.Add(Me.chkActual)
        Me.Controls.Add(Me.optUnclosed)
        Me.Controls.Add(Me.optKODate)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.optClosedDate)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMcNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.txtKoNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmWOClosed"
        Me.Text = "WO Closed Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optUnclosed As System.Windows.Forms.RadioButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents optKODate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents optClosedDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMcNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents txtKoNo As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents chkActual As System.Windows.Forms.CheckBox
End Class
