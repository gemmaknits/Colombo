<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGINManualKO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGINManualKO))
        Me.lblGreigeStock = New System.Windows.Forms.Label()
        Me.txtkono = New System.Windows.Forms.TextBox()
        Me.lblkono = New System.Windows.Forms.Label()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGreigeStock
        '
        Me.lblGreigeStock.AutoSize = True
        Me.lblGreigeStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGreigeStock.Location = New System.Drawing.Point(67, 34)
        Me.lblGreigeStock.Name = "lblGreigeStock"
        Me.lblGreigeStock.Size = New System.Drawing.Size(81, 13)
        Me.lblGreigeStock.TabIndex = 0
        Me.lblGreigeStock.Text = "Greige Stock"
        '
        'txtkono
        '
        Me.txtkono.Location = New System.Drawing.Point(134, 71)
        Me.txtkono.Name = "txtkono"
        Me.txtkono.Size = New System.Drawing.Size(142, 20)
        Me.txtkono.TabIndex = 1
        '
        'lblkono
        '
        Me.lblkono.AutoSize = True
        Me.lblkono.Location = New System.Drawing.Point(67, 74)
        Me.lblkono.Name = "lblkono"
        Me.lblkono.Size = New System.Drawing.Size(47, 13)
        Me.lblkono.TabIndex = 2
        Me.lblkono.Text = "K/O No."
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(282, 68)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 300
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'frmStockGINManualKO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 161)
        Me.Controls.Add(Me.btnSearchOutNo)
        Me.Controls.Add(Me.lblkono)
        Me.Controls.Add(Me.txtkono)
        Me.Controls.Add(Me.lblGreigeStock)
        Me.Name = "frmStockGINManualKO"
        Me.Text = "Greige Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreigeStock As System.Windows.Forms.Label
    Friend WithEvents txtkono As System.Windows.Forms.TextBox
    Friend WithEvents lblkono As System.Windows.Forms.Label
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
End Class
