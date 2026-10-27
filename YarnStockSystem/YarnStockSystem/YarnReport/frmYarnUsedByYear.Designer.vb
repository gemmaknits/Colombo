<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnUsedByYear
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
        Me.dtpPrint = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.crvYarnUsed = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYarnCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpPrint
        '
        Me.dtpPrint.CustomFormat = "yyyy"
        Me.dtpPrint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPrint.Location = New System.Drawing.Point(224, 8)
        Me.dtpPrint.Name = "dtpPrint"
        Me.dtpPrint.Size = New System.Drawing.Size(64, 20)
        Me.dtpPrint.TabIndex = 12
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(296, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Show Data"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'crvYarnUsed
        '
        Me.crvYarnUsed.ActiveViewIndex = -1
        Me.crvYarnUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvYarnUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvYarnUsed.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crvYarnUsed.Location = New System.Drawing.Point(0, 40)
        Me.crvYarnUsed.Name = "crvYarnUsed"
        Me.crvYarnUsed.SelectionFormula = ""
        Me.crvYarnUsed.ShowCloseButton = False
        Me.crvYarnUsed.ShowGroupTreeButton = False
        Me.crvYarnUsed.ShowRefreshButton = False
        Me.crvYarnUsed.Size = New System.Drawing.Size(883, 393)
        Me.crvYarnUsed.TabIndex = 10
        Me.crvYarnUsed.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Yarn Code"
        '
        'txtYarnCode
        '
        Me.txtYarnCode.Location = New System.Drawing.Point(72, 8)
        Me.txtYarnCode.Name = "txtYarnCode"
        Me.txtYarnCode.Size = New System.Drawing.Size(100, 20)
        Me.txtYarnCode.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Year"
        '
        'frmYarnUsedByYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 433)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtYarnCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpPrint)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.crvYarnUsed)
        Me.Name = "frmYarnUsedByYear"
        Me.Text = "Yarn Used By Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpPrint As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents crvYarnUsed As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtYarnCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
