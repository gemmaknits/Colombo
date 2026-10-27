<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenWarpSet
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
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.BtnGenLots = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(99, 32)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 20)
        Me.txtQty.TabIndex = 0
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(44, 35)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(23, 13)
        Me.lblQty.TabIndex = 1
        Me.lblQty.Text = "Qty"
        '
        'BtnGenLots
        '
        Me.BtnGenLots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGenLots.Location = New System.Drawing.Point(205, 32)
        Me.BtnGenLots.Name = "BtnGenLots"
        Me.BtnGenLots.Size = New System.Drawing.Size(67, 20)
        Me.BtnGenLots.TabIndex = 471
        Me.BtnGenLots.Text = "OK"
        Me.BtnGenLots.UseVisualStyleBackColor = True
        '
        'frmGenWarpSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 87)
        Me.Controls.Add(Me.BtnGenLots)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.txtQty)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenWarpSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input No of Set"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents BtnGenLots As System.Windows.Forms.Button
End Class
