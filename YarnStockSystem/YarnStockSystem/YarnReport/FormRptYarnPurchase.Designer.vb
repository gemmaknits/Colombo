<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRptYarnPurchase
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
        Me.crvYarnUsed = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtpPrint = New System.Windows.Forms.DateTimePicker
        Me.btnPrint = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'crvYarnUsed
        '
        Me.crvYarnUsed.ActiveViewIndex = -1
        Me.crvYarnUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.crvYarnUsed.DisplayGroupTree = False
        Me.crvYarnUsed.Location = New System.Drawing.Point(8, 40)
        Me.crvYarnUsed.Name = "crvYarnUsed"
        Me.crvYarnUsed.SelectionFormula = ""
        Me.crvYarnUsed.ShowCloseButton = False
        Me.crvYarnUsed.ShowGroupTreeButton = False
        Me.crvYarnUsed.ShowRefreshButton = False
        Me.crvYarnUsed.Size = New System.Drawing.Size(716, 470)
        Me.crvYarnUsed.TabIndex = 7
        Me.crvYarnUsed.ViewTimeSelectionFormula = ""
        '
        'dtpPrint
        '
        Me.dtpPrint.CustomFormat = "MM/yyyy"
        Me.dtpPrint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPrint.Location = New System.Drawing.Point(8, 8)
        Me.dtpPrint.Name = "dtpPrint"
        Me.dtpPrint.Size = New System.Drawing.Size(72, 20)
        Me.dtpPrint.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(88, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Show Data"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FormRptYarnPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 517)
        Me.Controls.Add(Me.dtpPrint)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.crvYarnUsed)
        Me.Name = "FormRptYarnPurchase"
        Me.Text = "Yarn Purchase Report"
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents crvYarnUsed As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents dtpPrint As System.Windows.Forms.DateTimePicker
	Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
