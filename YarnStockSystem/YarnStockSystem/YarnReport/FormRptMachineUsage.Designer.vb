<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptMachineUsage
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
		Me.crvMachine = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.dtpPrint = New System.Windows.Forms.DateTimePicker
		Me.btnPrint = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'crvMachine
		'
		Me.crvMachine.ActiveViewIndex = -1
		Me.crvMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.crvMachine.Location = New System.Drawing.Point(8, 40)
		Me.crvMachine.Name = "crvMachine"
		Me.crvMachine.SelectionFormula = ""
		Me.crvMachine.Size = New System.Drawing.Size(160, 104)
		Me.crvMachine.TabIndex = 6
		Me.crvMachine.ViewTimeSelectionFormula = ""
		'
		'dtpPrint
		'
		Me.dtpPrint.CustomFormat = "dd/MM/yyyy"
		Me.dtpPrint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpPrint.Location = New System.Drawing.Point(8, 8)
		Me.dtpPrint.Name = "dtpPrint"
		Me.dtpPrint.Size = New System.Drawing.Size(88, 20)
		Me.dtpPrint.TabIndex = 5
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(104, 8)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(64, 24)
		Me.btnPrint.TabIndex = 4
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'FormRptMachineUsage
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(349, 291)
		Me.Controls.Add(Me.crvMachine)
		Me.Controls.Add(Me.dtpPrint)
		Me.Controls.Add(Me.btnPrint)
		Me.Name = "FormRptMachineUsage"
		Me.Text = "Weekly Machine Usage"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents crvMachine As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents dtpPrint As System.Windows.Forms.DateTimePicker
	Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
