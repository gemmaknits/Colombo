<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeamControlReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBeamControlReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKONoTo = New System.Windows.Forms.TextBox()
        Me.txtKONoFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpKODtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpKODtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbomc = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbGrpByMCNo = New System.Windows.Forms.RadioButton()
        Me.rbGrpByWoNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbomc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKONoTo)
        Me.GroupBox1.Controls.Add(Me.txtKONoFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpKODtFrom)
        Me.GroupBox1.Controls.Add(Me.dtpKODtTo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'txtKONoTo
        '
        Me.txtKONoTo.Location = New System.Drawing.Point(317, 46)
        Me.txtKONoTo.Name = "txtKONoTo"
        Me.txtKONoTo.Size = New System.Drawing.Size(86, 20)
        Me.txtKONoTo.TabIndex = 37
        '
        'txtKONoFrom
        '
        Me.txtKONoFrom.Location = New System.Drawing.Point(143, 46)
        Me.txtKONoFrom.Name = "txtKONoFrom"
        Me.txtKONoFrom.Size = New System.Drawing.Size(86, 20)
        Me.txtKONoFrom.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "WO No."
        '
        'dtpKODtFrom
        '
        Me.dtpKODtFrom.Checked = False
        Me.dtpKODtFrom.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKODtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKODtFrom.Location = New System.Drawing.Point(143, 20)
        Me.dtpKODtFrom.Name = "dtpKODtFrom"
        Me.dtpKODtFrom.ShowCheckBox = True
        Me.dtpKODtFrom.Size = New System.Drawing.Size(99, 20)
        Me.dtpKODtFrom.TabIndex = 32
        '
        'dtpKODtTo
        '
        Me.dtpKODtTo.Checked = False
        Me.dtpKODtTo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKODtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKODtTo.Location = New System.Drawing.Point(317, 20)
        Me.dtpKODtTo.Name = "dtpKODtTo"
        Me.dtpKODtTo.ShowCheckBox = True
        Me.dtpKODtTo.Size = New System.Drawing.Size(102, 20)
        Me.dtpKODtTo.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(291, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(107, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "From"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "WO Date"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(477, 25)
        Me.ToolStrip1.TabIndex = 36
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "M/C No."
        '
        'cbomc
        '
        Me.cbomc.FormattingEnabled = True
        Me.cbomc.Location = New System.Drawing.Point(143, 73)
        Me.cbomc.Name = "cbomc"
        Me.cbomc.Size = New System.Drawing.Size(86, 21)
        Me.cbomc.TabIndex = 46
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbGrpByMCNo)
        Me.GroupBox3.Controls.Add(Me.rbGrpByWoNo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 47)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Group By"
        '
        'rbGrpByMCNo
        '
        Me.rbGrpByMCNo.AutoSize = True
        Me.rbGrpByMCNo.Location = New System.Drawing.Point(294, 19)
        Me.rbGrpByMCNo.Name = "rbGrpByMCNo"
        Me.rbGrpByMCNo.Size = New System.Drawing.Size(66, 17)
        Me.rbGrpByMCNo.TabIndex = 30
        Me.rbGrpByMCNo.Text = "M/C No."
        Me.rbGrpByMCNo.UseVisualStyleBackColor = True
        '
        'rbGrpByWoNo
        '
        Me.rbGrpByWoNo.AutoSize = True
        Me.rbGrpByWoNo.Checked = True
        Me.rbGrpByWoNo.Location = New System.Drawing.Point(97, 19)
        Me.rbGrpByWoNo.Name = "rbGrpByWoNo"
        Me.rbGrpByWoNo.Size = New System.Drawing.Size(70, 17)
        Me.rbGrpByWoNo.TabIndex = 29
        Me.rbGrpByWoNo.TabStop = True
        Me.rbGrpByWoNo.Text = "WO Date"
        Me.rbGrpByWoNo.UseVisualStyleBackColor = True
        '
        'FrmBeamControlReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 206)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBeamControlReport"
        Me.Text = "Beam Control Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpKODtFrom As DateTimePicker
    Friend WithEvents dtpKODtTo As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtKONoTo As TextBox
    Friend WithEvents txtKONoFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cbomc As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbGrpByMCNo As RadioButton
    Friend WithEvents rbGrpByWoNo As RadioButton
End Class
