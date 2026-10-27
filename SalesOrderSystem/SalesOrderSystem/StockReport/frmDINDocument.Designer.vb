<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDINDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDINDocument))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchDIN = New System.Windows.Forms.Button()
        Me.cboToDINNO = New System.Windows.Forms.ComboBox()
        Me.lblToGINNO = New System.Windows.Forms.Label()
        Me.cboFromDINNO = New System.Windows.Forms.ComboBox()
        Me.lblFromGINNO = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(304, 25)
        Me.ToolStrip1.TabIndex = 197
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'btnSearchDIN
        '
        Me.btnSearchDIN.Image = CType(resources.GetObject("btnSearchDIN.Image"), System.Drawing.Image)
        Me.btnSearchDIN.Location = New System.Drawing.Point(224, 40)
        Me.btnSearchDIN.Name = "btnSearchDIN"
        Me.btnSearchDIN.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDIN.TabIndex = 200
        Me.btnSearchDIN.UseVisualStyleBackColor = True
        '
        'cboToDINNO
        '
        Me.cboToDINNO.FormattingEnabled = True
        Me.cboToDINNO.Location = New System.Drawing.Point(97, 67)
        Me.cboToDINNO.Name = "cboToDINNO"
        Me.cboToDINNO.Size = New System.Drawing.Size(121, 21)
        Me.cboToDINNO.TabIndex = 207
        '
        'lblToGINNO
        '
        Me.lblToGINNO.AutoSize = True
        Me.lblToGINNO.Location = New System.Drawing.Point(19, 70)
        Me.lblToGINNO.Name = "lblToGINNO"
        Me.lblToGINNO.Size = New System.Drawing.Size(62, 13)
        Me.lblToGINNO.TabIndex = 206
        Me.lblToGINNO.Text = "To DIN No."
        '
        'cboFromDINNO
        '
        Me.cboFromDINNO.FormattingEnabled = True
        Me.cboFromDINNO.Location = New System.Drawing.Point(97, 40)
        Me.cboFromDINNO.Name = "cboFromDINNO"
        Me.cboFromDINNO.Size = New System.Drawing.Size(121, 21)
        Me.cboFromDINNO.TabIndex = 209
        '
        'lblFromGINNO
        '
        Me.lblFromGINNO.AutoSize = True
        Me.lblFromGINNO.Location = New System.Drawing.Point(19, 40)
        Me.lblFromGINNO.Name = "lblFromGINNO"
        Me.lblFromGINNO.Size = New System.Drawing.Size(76, 13)
        Me.lblFromGINNO.TabIndex = 208
        Me.lblFromGINNO.Text = "From DIN No."
        '
        'frmDINDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 114)
        Me.Controls.Add(Me.cboFromDINNO)
        Me.Controls.Add(Me.lblFromGINNO)
        Me.Controls.Add(Me.cboToDINNO)
        Me.Controls.Add(Me.lblToGINNO)
        Me.Controls.Add(Me.btnSearchDIN)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDINDocument"
        Me.Text = "DINDocument"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearchDIN As System.Windows.Forms.Button
    Friend WithEvents cboToDINNO As ComboBox
    Friend WithEvents lblToGINNO As Label
    Friend WithEvents cboFromDINNO As ComboBox
    Friend WithEvents lblFromGINNO As Label
End Class
