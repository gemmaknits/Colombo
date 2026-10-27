<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGINDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGINDocument))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblFromGINNO = New System.Windows.Forms.Label()
        Me.lblToGINNO = New System.Windows.Forms.Label()
        Me.cboGINNOfr = New System.Windows.Forms.ComboBox()
        Me.cboGINNOto = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(213, 25)
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
        'lblFromGINNO
        '
        Me.lblFromGINNO.AutoSize = True
        Me.lblFromGINNO.Location = New System.Drawing.Point(7, 41)
        Me.lblFromGINNO.Name = "lblFromGINNO"
        Me.lblFromGINNO.Size = New System.Drawing.Size(76, 13)
        Me.lblFromGINNO.TabIndex = 199
        Me.lblFromGINNO.Text = "From GIN No."
        '
        'lblToGINNO
        '
        Me.lblToGINNO.AutoSize = True
        Me.lblToGINNO.Location = New System.Drawing.Point(7, 67)
        Me.lblToGINNO.Name = "lblToGINNO"
        Me.lblToGINNO.Size = New System.Drawing.Size(62, 13)
        Me.lblToGINNO.TabIndex = 202
        Me.lblToGINNO.Text = "To GIN No."
        '
        'cboGINNOfr
        '
        Me.cboGINNOfr.FormattingEnabled = True
        Me.cboGINNOfr.Location = New System.Drawing.Point(85, 38)
        Me.cboGINNOfr.Name = "cboGINNOfr"
        Me.cboGINNOfr.Size = New System.Drawing.Size(121, 21)
        Me.cboGINNOfr.TabIndex = 204
        '
        'cboGINNOto
        '
        Me.cboGINNOto.FormattingEnabled = True
        Me.cboGINNOto.Location = New System.Drawing.Point(85, 67)
        Me.cboGINNOto.Name = "cboGINNOto"
        Me.cboGINNOto.Size = New System.Drawing.Size(121, 21)
        Me.cboGINNOto.TabIndex = 205
        '
        'frmGINDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 97)
        Me.Controls.Add(Me.cboGINNOto)
        Me.Controls.Add(Me.cboGINNOfr)
        Me.Controls.Add(Me.lblToGINNO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblFromGINNO)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGINDocument"
        Me.Text = "GINDocument"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblFromGINNO As System.Windows.Forms.Label
    Friend WithEvents lblToGINNO As System.Windows.Forms.Label
    Friend WithEvents cboGINNOfr As System.Windows.Forms.ComboBox
    Friend WithEvents cboGINNOto As ComboBox
End Class
