<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanySticker
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
		Me.crvReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnPrint = New System.Windows.Forms.Button
		Me.txtCopies = New System.Windows.Forms.TextBox
		Me.SuspendLayout()
		'
		'crvReport
		'
		Me.crvReport.ActiveViewIndex = -1
		Me.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.crvReport.Location = New System.Drawing.Point(0, 40)
		Me.crvReport.Name = "crvReport"
		Me.crvReport.SelectionFormula = ""
		Me.crvReport.Size = New System.Drawing.Size(526, 390)
		Me.crvReport.TabIndex = 1
		Me.crvReport.ViewTimeSelectionFormula = ""
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(77, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "No. of Copies :"
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(184, 8)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(64, 24)
		Me.btnPrint.TabIndex = 3
		Me.btnPrint.Text = "&Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'txtCopies
		'
		Me.txtCopies.Location = New System.Drawing.Point(88, 8)
		Me.txtCopies.Name = "txtCopies"
		Me.txtCopies.Size = New System.Drawing.Size(88, 20)
		Me.txtCopies.TabIndex = 4
		Me.txtCopies.Text = "1"
		Me.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'frmCompanySticker
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(526, 430)
		Me.Controls.Add(Me.txtCopies)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.crvReport)
		Me.Name = "frmCompanySticker"
		Me.Text = "frmCompanySticker"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents crvReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	Friend WithEvents txtCopies As System.Windows.Forms.TextBox
End Class
