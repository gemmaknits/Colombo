<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnLostByKO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnLostByKO))
        Me.chkPendingKO = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkClosedKO = New System.Windows.Forms.CheckBox()
        Me.optKIDate = New System.Windows.Forms.RadioButton()
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.optKIClosedDate = New System.Windows.Forms.RadioButton()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.textKono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkPendingKO
        '
        Me.chkPendingKO.AutoSize = True
        Me.chkPendingKO.Location = New System.Drawing.Point(48, 204)
        Me.chkPendingKO.Name = "chkPendingKO"
        Me.chkPendingKO.Size = New System.Drawing.Size(142, 17)
        Me.chkPendingKO.TabIndex = 172
        Me.chkPendingKO.Text = "Show Only Pending K/O"
        Me.chkPendingKO.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'chkClosedKO
        '
        Me.chkClosedKO.AutoSize = True
        Me.chkClosedKO.Location = New System.Drawing.Point(48, 180)
        Me.chkClosedKO.Name = "chkClosedKO"
        Me.chkClosedKO.Size = New System.Drawing.Size(135, 17)
        Me.chkClosedKO.TabIndex = 167
        Me.chkClosedKO.Text = "Show Only Closed K/O"
        Me.chkClosedKO.UseVisualStyleBackColor = True
        '
        'optKIDate
        '
        Me.optKIDate.AutoSize = True
        Me.optKIDate.Checked = True
        Me.optKIDate.Location = New System.Drawing.Point(16, 0)
        Me.optKIDate.Name = "optKIDate"
        Me.optKIDate.Size = New System.Drawing.Size(66, 17)
        Me.optKIDate.TabIndex = 165
        Me.optKIDate.TabStop = True
        Me.optKIDate.Text = "K/I Date"
        Me.optKIDate.UseVisualStyleBackColor = True
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.Location = New System.Drawing.Point(200, 44)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(22, 23)
        Me.btnSearchKI.TabIndex = 170
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'optKIClosedDate
        '
        Me.optKIClosedDate.AutoSize = True
        Me.optKIClosedDate.Location = New System.Drawing.Point(88, 0)
        Me.optKIClosedDate.Name = "optKIClosedDate"
        Me.optKIClosedDate.Size = New System.Drawing.Size(101, 17)
        Me.optKIClosedDate.TabIndex = 166
        Me.optKIClosedDate.Text = "K/I Closed Date"
        Me.optKIClosedDate.UseVisualStyleBackColor = True
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(56, 32)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpFromDate.TabIndex = 0
        '
        'textKono
        '
        Me.textKono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textKono.Location = New System.Drawing.Point(88, 44)
        Me.textKono.Name = "textKono"
        Me.textKono.Size = New System.Drawing.Size(111, 22)
        Me.textKono.TabIndex = 169
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(40, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "K/I No.:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(311, 25)
        Me.ToolStrip1.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(56, 56)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpToDate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optKIClosedDate)
        Me.GroupBox1.Controls.Add(Me.optKIDate)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 88)
        Me.GroupBox1.TabIndex = 166
        Me.GroupBox1.TabStop = False
        '
        'frmYarnLostByKO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 236)
        Me.Controls.Add(Me.chkPendingKO)
        Me.Controls.Add(Me.chkClosedKO)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.textKono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmYarnLostByKO"
        Me.Text = "Yarn Lost By KO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkPendingKO As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkClosedKO As System.Windows.Forms.CheckBox
    Friend WithEvents optKIDate As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents optKIClosedDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents textKono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
