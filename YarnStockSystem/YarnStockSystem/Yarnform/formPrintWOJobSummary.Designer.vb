<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintWOJobSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrintWOJobSummary))
        Me.btnSearchKI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optSortByJob = New System.Windows.Forms.RadioButton()
        Me.optSortByKI = New System.Windows.Forms.RadioButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.textWono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.checkClosedProduction = New System.Windows.Forms.CheckBox()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkAllDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearchKI
        '
        Me.btnSearchKI.Image = CType(resources.GetObject("btnSearchKI.Image"), System.Drawing.Image)
        Me.btnSearchKI.Location = New System.Drawing.Point(236, 55)
        Me.btnSearchKI.Name = "btnSearchKI"
        Me.btnSearchKI.Size = New System.Drawing.Size(22, 23)
        Me.btnSearchKI.TabIndex = 171
        Me.btnSearchKI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optSortByJob)
        Me.GroupBox3.Controls.Add(Me.optSortByKI)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 63)
        Me.GroupBox3.TabIndex = 173
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sort by"
        '
        'optSortByJob
        '
        Me.optSortByJob.AutoSize = True
        Me.optSortByJob.Location = New System.Drawing.Point(49, 40)
        Me.optSortByJob.Name = "optSortByJob"
        Me.optSortByJob.Size = New System.Drawing.Size(60, 17)
        Me.optSortByJob.TabIndex = 1
        Me.optSortByJob.Text = "Job no."
        Me.optSortByJob.UseVisualStyleBackColor = True
        '
        'optSortByKI
        '
        Me.optSortByKI.AutoSize = True
        Me.optSortByKI.Checked = True
        Me.optSortByKI.Location = New System.Drawing.Point(49, 17)
        Me.optSortByKI.Name = "optSortByKI"
        Me.optSortByKI.Size = New System.Drawing.Size(67, 17)
        Me.optSortByKI.TabIndex = 0
        Me.optSortByKI.TabStop = True
        Me.optSortByKI.Text = "W/O no."
        Me.optSortByKI.UseVisualStyleBackColor = True
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
        'textWono
        '
        Me.textWono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textWono.Location = New System.Drawing.Point(119, 56)
        Me.textWono.Name = "textWono"
        Me.textWono.Size = New System.Drawing.Size(111, 22)
        Me.textWono.TabIndex = 170
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Warp order No.:"
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
        'checkClosedProduction
        '
        Me.checkClosedProduction.AutoSize = True
        Me.checkClosedProduction.Location = New System.Drawing.Point(28, 259)
        Me.checkClosedProduction.Name = "checkClosedProduction"
        Me.checkClosedProduction.Size = New System.Drawing.Size(171, 17)
        Me.checkClosedProduction.TabIndex = 168
        Me.checkClosedProduction.Text = "W/O is closed after production"
        Me.checkClosedProduction.UseVisualStyleBackColor = True
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(59, 62)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpToDate.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnPrint, Me.btnMinimized, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(374, 25)
        Me.ToolStrip1.TabIndex = 169
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(59, 36)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpFromDate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkAllDate)
        Me.GroupBox1.Controls.Add(Me.dtpFromDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 88)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "W/O date"
        '
        'checkAllDate
        '
        Me.checkAllDate.AutoSize = True
        Me.checkAllDate.Location = New System.Drawing.Point(59, 13)
        Me.checkAllDate.Name = "checkAllDate"
        Me.checkAllDate.Size = New System.Drawing.Size(37, 17)
        Me.checkAllDate.TabIndex = 6
        Me.checkAllDate.Text = "All"
        Me.checkAllDate.UseVisualStyleBackColor = True
        '
        'formPrintWOJobSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 289)
        Me.Controls.Add(Me.btnSearchKI)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.textWono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.checkClosedProduction)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formPrintWOJobSummary"
        Me.Text = "Print W/O Job Summary"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchKI As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optSortByJob As System.Windows.Forms.RadioButton
    Friend WithEvents optSortByKI As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents textWono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents checkClosedProduction As System.Windows.Forms.CheckBox
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkAllDate As System.Windows.Forms.CheckBox
End Class
