<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CRViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewer
        '
        Me.CRViewer.ActiveViewIndex = -1
        Me.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer.Name = "CRViewer"
        Me.CRViewer.Size = New System.Drawing.Size(792, 566)
        Me.CRViewer.TabIndex = 0
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CRViewer)
        Me.Name = "frmReport"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents CrystalReport11 As CrystalReport1

End Class