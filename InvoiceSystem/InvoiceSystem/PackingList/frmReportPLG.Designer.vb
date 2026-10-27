<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportPLG
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
        Me.RvPLG = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvPLG
        '
        Me.RvPLG.Location = New System.Drawing.Point(1, 0)
        Me.RvPLG.Name = "RvPLG"
        Me.RvPLG.Size = New System.Drawing.Size(904, 511)
        Me.RvPLG.TabIndex = 0
        '
        'frmReportPLG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 513)
        Me.Controls.Add(Me.RvPLG)
        Me.Name = "frmReportPLG"
        Me.Text = "frmReportPLG"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RvPLG As Microsoft.Reporting.WinForms.ReportViewer
End Class
