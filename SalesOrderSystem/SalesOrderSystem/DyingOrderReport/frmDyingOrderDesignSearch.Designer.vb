<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderSearchDesign
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
		Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
		Me.cboDesignNo = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.btnPrint = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'CRViewer
		'
		Me.CRViewer.ActiveViewIndex = -1
		Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CRViewer.Location = New System.Drawing.Point(8, 40)
		Me.CRViewer.Name = "CRViewer"
		Me.CRViewer.SelectionFormula = ""
		Me.CRViewer.ShowRefreshButton = False
		Me.CRViewer.Size = New System.Drawing.Size(160, 112)
		Me.CRViewer.TabIndex = 2
		Me.CRViewer.ViewTimeSelectionFormula = ""
		'
		'cboDesignNo
		'
		Me.cboDesignNo.FormattingEnabled = True
		Me.cboDesignNo.Location = New System.Drawing.Point(80, 8)
		Me.cboDesignNo.Name = "cboDesignNo"
		Me.cboDesignNo.Size = New System.Drawing.Size(160, 21)
		Me.cboDesignNo.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Design No."
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(248, 8)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(56, 24)
		Me.btnPrint.TabIndex = 5
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'frmDyingOrderSearchDesign
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(670, 485)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.cboDesignNo)
		Me.Controls.Add(Me.CRViewer)
		Me.Name = "frmDyingOrderSearchDesign"
		Me.Text = "Search DF by Design No."
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
