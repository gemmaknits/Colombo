<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintWOConsumption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrintWOConsumption))
        Me.chkPendingWO = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkClosedWO = New System.Windows.Forms.CheckBox()
        Me.optWODate = New System.Windows.Forms.RadioButton()
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.optWOClosedDate = New System.Windows.Forms.RadioButton()
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
        'chkPendingWO
        '
        Me.chkPendingWO.AutoSize = True
        Me.chkPendingWO.Location = New System.Drawing.Point(48, 205)
        Me.chkPendingWO.Name = "chkPendingWO"
        Me.chkPendingWO.Size = New System.Drawing.Size(155, 17)
        Me.chkPendingWO.TabIndex = 172
        Me.chkPendingWO.Text = "Show Only Pending W/O"
        Me.chkPendingWO.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton2.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'chkClosedWO
        '
        Me.chkClosedWO.AutoSize = True
        Me.chkClosedWO.Location = New System.Drawing.Point(48, 181)
        Me.chkClosedWO.Name = "chkClosedWO"
        Me.chkClosedWO.Size = New System.Drawing.Size(147, 17)
        Me.chkClosedWO.TabIndex = 167
        Me.chkClosedWO.Text = "Show Only Closed W/O"
        Me.chkClosedWO.UseVisualStyleBackColor = True
        '
        'optWODate
        '
        Me.optWODate.AutoSize = True
        Me.optWODate.Checked = True
        Me.optWODate.Location = New System.Drawing.Point(16, 0)
        Me.optWODate.Name = "optWODate"
        Me.optWODate.Size = New System.Drawing.Size(76, 17)
        Me.optWODate.TabIndex = 165
        Me.optWODate.TabStop = True
        Me.optWODate.Text = "W/O Date"
        Me.optWODate.UseVisualStyleBackColor = True
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.Location = New System.Drawing.Point(200, 45)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(22, 23)
        Me.btnSearchKI.TabIndex = 170
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'optWOClosedDate
        '
        Me.optWOClosedDate.AutoSize = True
        Me.optWOClosedDate.Location = New System.Drawing.Point(88, 0)
        Me.optWOClosedDate.Name = "optWOClosedDate"
        Me.optWOClosedDate.Size = New System.Drawing.Size(114, 17)
        Me.optWOClosedDate.TabIndex = 166
        Me.optWOClosedDate.Text = "W/O Closed Date"
        Me.optWOClosedDate.UseVisualStyleBackColor = True
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(56, 32)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpFromDate.TabIndex = 0
        '
        'textKono
        '
        Me.textKono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textKono.Location = New System.Drawing.Point(88, 45)
        Me.textKono.Name = "textKono"
        Me.textKono.Size = New System.Drawing.Size(111, 22)
        Me.textKono.TabIndex = 169
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(40, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "W/O No.:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(313, 25)
        Me.ToolStrip1.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(56, 56)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(95, 22)
        Me.dtpToDate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optWOClosedDate)
        Me.GroupBox1.Controls.Add(Me.optWODate)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 88)
        Me.GroupBox1.TabIndex = 166
        Me.GroupBox1.TabStop = False
        '
        'formPrintWOConsumption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 226)
        Me.Controls.Add(Me.chkPendingWO)
        Me.Controls.Add(Me.chkClosedWO)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.textKono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formPrintWOConsumption"
        Me.Text = "W/O Yarn consumption & loss report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkPendingWO As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkClosedWO As System.Windows.Forms.CheckBox
    Friend WithEvents optWODate As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents optWOClosedDate As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents textKono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
