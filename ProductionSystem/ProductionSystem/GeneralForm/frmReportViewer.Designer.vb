<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewer
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
        Me.rv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rv
        '
        Me.rv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rv.Location = New System.Drawing.Point(12, 12)
        Me.rv.Name = "rv"
        Me.rv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rv.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.rv.Size = New System.Drawing.Size(1215, 380)
        Me.rv.TabIndex = 0
        '
        'frmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 404)
        Me.Controls.Add(Me.rv)
        Me.Name = "frmReportViewer"
        Me.Text = "frmReportViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv As Microsoft.Reporting.WinForms.ReportViewer
End Class
