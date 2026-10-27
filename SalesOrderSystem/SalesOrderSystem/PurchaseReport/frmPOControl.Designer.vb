<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOControl
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOControl))
		Me.Label2 = New System.Windows.Forms.Label
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.cboSupplier = New System.Windows.Forms.ComboBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.cboEmpCD = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.GroupBox1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(30, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "From"
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(64, 16)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 8
		'
		'cboSupplier
		'
		Me.cboSupplier.FormattingEnabled = True
		Me.cboSupplier.Location = New System.Drawing.Point(64, 40)
		Me.cboSupplier.Name = "cboSupplier"
		Me.cboSupplier.Size = New System.Drawing.Size(216, 21)
		Me.cboSupplier.TabIndex = 9
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.cboEmpCD)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.cboSupplier)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(288, 96)
		Me.GroupBox1.TabIndex = 10
		Me.GroupBox1.TabStop = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 64)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(38, 13)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Owner"
		'
		'cboEmpCD
		'
		Me.cboEmpCD.FormattingEnabled = True
		Me.cboEmpCD.Location = New System.Drawing.Point(64, 64)
		Me.cboEmpCD.Name = "cboEmpCD"
		Me.cboEmpCD.Size = New System.Drawing.Size(128, 21)
		Me.cboEmpCD.TabIndex = 13
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 40)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(45, 13)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Supplier"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(160, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(20, 13)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "To"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(192, 16)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 11
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(305, 25)
		Me.ToolStrip1.TabIndex = 20
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
		'frmPOControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(305, 137)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPOControl"
		Me.Text = "Purchase Order Control"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboEmpCD As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
End Class
