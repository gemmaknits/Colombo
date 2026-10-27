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
        Me.txtDINNO = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblDINNO = New System.Windows.Forms.Label()
        Me.btnSearchDIN = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDINNO
        '
        Me.txtDINNO.Location = New System.Drawing.Point(63, 41)
        Me.txtDINNO.Name = "txtDINNO"
        Me.txtDINNO.Size = New System.Drawing.Size(96, 20)
        Me.txtDINNO.TabIndex = 195
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(204, 25)
        Me.ToolStrip1.TabIndex = 197
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'lblDINNO
        '
        Me.lblDINNO.AutoSize = True
        Me.lblDINNO.Location = New System.Drawing.Point(7, 41)
        Me.lblDINNO.Name = "lblDINNO"
        Me.lblDINNO.Size = New System.Drawing.Size(46, 13)
        Me.lblDINNO.TabIndex = 199
        Me.lblDINNO.Text = "DIN No."
        '
        'btnSearchDIN
        '
        Me.btnSearchDIN.Image = CType(resources.GetObject("btnSearchDIN.Image"), System.Drawing.Image)
        Me.btnSearchDIN.Location = New System.Drawing.Point(164, 38)
        Me.btnSearchDIN.Name = "btnSearchDIN"
        Me.btnSearchDIN.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDIN.TabIndex = 200
        Me.btnSearchDIN.UseVisualStyleBackColor = True
        '
        'frmDINDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 87)
        Me.Controls.Add(Me.btnSearchDIN)
        Me.Controls.Add(Me.txtDINNO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblDINNO)
        Me.Name = "frmDINDocument"
        Me.Text = "DINDocument"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDINNO As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDINNO As System.Windows.Forms.Label
    Friend WithEvents btnSearchDIN As System.Windows.Forms.Button
End Class
