<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabPending
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabPending))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.cboOwner = New System.Windows.Forms.ComboBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.cboDesignNo = New System.Windows.Forms.ComboBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.cboDyedHouse = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.cboLabNo = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.Label6 = New System.Windows.Forms.Label
		Me.GroupBox1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboOwner)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label8)
		Me.GroupBox1.Controls.Add(Me.cboDesignNo)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.cboDyedHouse)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.cboLabNo)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(336, 144)
		Me.GroupBox1.TabIndex = 23
		Me.GroupBox1.TabStop = False
		'
		'cboOwner
		'
		Me.cboOwner.FormattingEnabled = True
		Me.cboOwner.Location = New System.Drawing.Point(112, 112)
		Me.cboOwner.Name = "cboOwner"
		Me.cboOwner.Size = New System.Drawing.Size(88, 21)
		Me.cboOwner.TabIndex = 15
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(8, 112)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(38, 13)
		Me.Label9.TabIndex = 14
		Me.Label9.Text = "Owner"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(8, 88)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(60, 13)
		Me.Label8.TabIndex = 13
		Me.Label8.Text = "Design No."
		'
		'cboDesignNo
		'
		Me.cboDesignNo.FormattingEnabled = True
		Me.cboDesignNo.Location = New System.Drawing.Point(112, 88)
		Me.cboDesignNo.Name = "cboDesignNo"
		Me.cboDesignNo.Size = New System.Drawing.Size(216, 21)
		Me.cboDesignNo.TabIndex = 12
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(8, 64)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(66, 13)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Dyed House"
		'
		'cboDyedHouse
		'
		Me.cboDyedHouse.FormattingEnabled = True
		Me.cboDyedHouse.Location = New System.Drawing.Point(112, 64)
		Me.cboDyedHouse.Name = "cboDyedHouse"
		Me.cboDyedHouse.Size = New System.Drawing.Size(216, 21)
		Me.cboDyedHouse.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(208, 40)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "To"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(240, 40)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 4
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(112, 40)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 40)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Lab Date From"
		'
		'cboLabNo
		'
		Me.cboLabNo.FormattingEnabled = True
		Me.cboLabNo.Location = New System.Drawing.Point(112, 16)
		Me.cboLabNo.Name = "cboLabNo"
		Me.cboLabNo.Size = New System.Drawing.Size(88, 21)
		Me.cboLabNo.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(45, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Lab No."
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(353, 25)
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
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label6.Location = New System.Drawing.Point(16, 184)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(328, 32)
		Me.Label6.TabIndex = 24
		Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
		'
		'frmLabPending
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(353, 217)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.Label6)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLabPending"
		Me.Text = "Lab Pending"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents cboOwner As System.Windows.Forms.ComboBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents cboDyedHouse As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cboLabNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
