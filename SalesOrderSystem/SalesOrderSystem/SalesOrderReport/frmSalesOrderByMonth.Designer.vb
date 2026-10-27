<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderByMonth
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderByMonth))
		Me.Label4 = New System.Windows.Forms.Label
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.cboCustomer = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.GroupBox1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(8, 40)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(82, 13)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Customer Name"
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
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.cboCustomer)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(336, 72)
		Me.GroupBox1.TabIndex = 25
		Me.GroupBox1.TabStop = False
		'
		'cboCustomer
		'
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(112, 40)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(216, 21)
		Me.cboCustomer.TabIndex = 6
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(208, 16)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "To"
		'
		'dtpDateTo
		'
		Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateTo.Location = New System.Drawing.Point(240, 16)
		Me.dtpDateTo.Name = "dtpDateTo"
		Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateTo.TabIndex = 4
		'
		'dtpDateFr
		'
		Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
		Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpDateFr.Location = New System.Drawing.Point(112, 16)
		Me.dtpDateFr.Name = "dtpDateFr"
		Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
		Me.dtpDateFr.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(79, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "S/O Date From"
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.Label6.Location = New System.Drawing.Point(8, 112)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(336, 32)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(353, 25)
		Me.ToolStrip1.TabIndex = 27
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
		'frmSalesOrderByMonth
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(353, 145)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmSalesOrderByMonth"
		Me.Text = "Monthly Sales Order"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
End Class
