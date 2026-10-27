<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockMovement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockMovement))
        Me.optStockC = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optStockD = New System.Windows.Forms.RadioButton()
        Me.optStockG = New System.Windows.Forms.RadioButton()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optBalance = New System.Windows.Forms.RadioButton()
        Me.optMovement = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optThai = New System.Windows.Forms.RadioButton()
        Me.optEng = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'optStockC
        '
        Me.optStockC.AutoSize = True
        Me.optStockC.Location = New System.Drawing.Point(216, 16)
        Me.optStockC.Name = "optStockC"
        Me.optStockC.Size = New System.Drawing.Size(63, 17)
        Me.optStockC.TabIndex = 24
        Me.optStockC.Text = "Stock C"
        Me.optStockC.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optStockC)
        Me.GroupBox3.Controls.Add(Me.optStockD)
        Me.GroupBox3.Controls.Add(Me.optStockG)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 48)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Type"
        '
        'optStockD
        '
        Me.optStockD.AutoSize = True
        Me.optStockD.Location = New System.Drawing.Point(120, 16)
        Me.optStockD.Name = "optStockD"
        Me.optStockD.Size = New System.Drawing.Size(64, 17)
        Me.optStockD.TabIndex = 9
        Me.optStockD.Text = "Stock D"
        Me.optStockD.UseVisualStyleBackColor = True
        '
        'optStockG
        '
        Me.optStockG.AutoSize = True
        Me.optStockG.Checked = True
        Me.optStockG.Location = New System.Drawing.Point(16, 16)
        Me.optStockG.Name = "optStockG"
        Me.optStockG.Size = New System.Drawing.Size(64, 17)
        Me.optStockG.TabIndex = 8
        Me.optStockG.TabStop = True
        Me.optStockG.Text = "Stock G"
        Me.optStockG.UseVisualStyleBackColor = True
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(80, 32)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "To"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(232, 32)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 39
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(329, 25)
        Me.ToolStrip1.TabIndex = 41
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "From Date"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 32)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(80, 56)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(240, 21)
        Me.cboDesignNo.TabIndex = 45
        '
        'cboDocType
        '
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(80, 80)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(240, 21)
        Me.cboDocType.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Design No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Out Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optBalance)
        Me.GroupBox2.Controls.Add(Me.optMovement)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 48)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        '
        'optBalance
        '
        Me.optBalance.AutoSize = True
        Me.optBalance.Checked = True
        Me.optBalance.Location = New System.Drawing.Point(96, 16)
        Me.optBalance.Name = "optBalance"
        Me.optBalance.Size = New System.Drawing.Size(65, 17)
        Me.optBalance.TabIndex = 9
        Me.optBalance.TabStop = True
        Me.optBalance.Text = "Balance"
        Me.optBalance.UseVisualStyleBackColor = True
        '
        'optMovement
        '
        Me.optMovement.AutoSize = True
        Me.optMovement.Location = New System.Drawing.Point(16, 16)
        Me.optMovement.Name = "optMovement"
        Me.optMovement.Size = New System.Drawing.Size(79, 17)
        Me.optMovement.TabIndex = 8
        Me.optMovement.Text = "Movement"
        Me.optMovement.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optThai)
        Me.GroupBox1.Controls.Add(Me.optEng)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 48)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language"
        '
        'optThai
        '
        Me.optThai.AutoSize = True
        Me.optThai.Checked = True
        Me.optThai.Location = New System.Drawing.Point(80, 16)
        Me.optThai.Name = "optThai"
        Me.optThai.Size = New System.Drawing.Size(46, 17)
        Me.optThai.TabIndex = 9
        Me.optThai.TabStop = True
        Me.optThai.Text = "Thai"
        Me.optThai.UseVisualStyleBackColor = True
        '
        'optEng
        '
        Me.optEng.AutoSize = True
        Me.optEng.Location = New System.Drawing.Point(16, 16)
        Me.optEng.Name = "optEng"
        Me.optEng.Size = New System.Drawing.Size(63, 17)
        Me.optEng.TabIndex = 8
        Me.optEng.Text = "English"
        Me.optEng.UseVisualStyleBackColor = True
        '
        'frmStockMovement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 257)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDocType)
        Me.Controls.Add(Me.cboDesignNo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockMovement"
        Me.Text = "Stock Movement"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optStockC As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents optStockD As System.Windows.Forms.RadioButton
	Friend WithEvents optStockG As System.Windows.Forms.RadioButton
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents optBalance As System.Windows.Forms.RadioButton
	Friend WithEvents optMovement As System.Windows.Forms.RadioButton
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents optThai As System.Windows.Forms.RadioButton
	Friend WithEvents optEng As System.Windows.Forms.RadioButton
End Class
