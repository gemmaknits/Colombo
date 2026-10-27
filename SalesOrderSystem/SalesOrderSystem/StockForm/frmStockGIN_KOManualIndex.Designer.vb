<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_KOManualIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_KOManualIndex))
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblkono = New System.Windows.Forms.Label()
        Me.txtkono = New System.Windows.Forms.TextBox()
        Me.lblGreigeStock = New System.Windows.Forms.Label()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.lblRollNo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(258, 86)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 304
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'lblkono
        '
        Me.lblkono.AutoSize = True
        Me.lblkono.Location = New System.Drawing.Point(43, 92)
        Me.lblkono.Name = "lblkono"
        Me.lblkono.Size = New System.Drawing.Size(47, 13)
        Me.lblkono.TabIndex = 303
        Me.lblkono.Text = "K/O No."
        '
        'txtkono
        '
        Me.txtkono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtkono.Location = New System.Drawing.Point(110, 89)
        Me.txtkono.Name = "txtkono"
        Me.txtkono.Size = New System.Drawing.Size(142, 20)
        Me.txtkono.TabIndex = 302
        '
        'lblGreigeStock
        '
        Me.lblGreigeStock.AutoSize = True
        Me.lblGreigeStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGreigeStock.Location = New System.Drawing.Point(43, 52)
        Me.lblGreigeStock.Name = "lblGreigeStock"
        Me.lblGreigeStock.Size = New System.Drawing.Size(89, 15)
        Me.lblGreigeStock.TabIndex = 301
        Me.lblGreigeStock.Text = "Greige Stock"
        '
        'txtroll_no
        '
        Me.txtroll_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtroll_no.Location = New System.Drawing.Point(110, 126)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.Size = New System.Drawing.Size(142, 20)
        Me.txtroll_no.TabIndex = 305
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.Location = New System.Drawing.Point(43, 129)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(45, 13)
        Me.lblRollNo.TabIndex = 306
        Me.lblRollNo.Text = "Roll No."
        '
        'frmStockGIN_KOManualIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 201)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.txtroll_no)
        Me.Controls.Add(Me.btnSearchOutNo)
        Me.Controls.Add(Me.lblkono)
        Me.Controls.Add(Me.txtkono)
        Me.Controls.Add(Me.lblGreigeStock)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockGIN_KOManualIndex"
        Me.Text = "Greige Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblkono As System.Windows.Forms.Label
    Friend WithEvents txtkono As System.Windows.Forms.TextBox
    Friend WithEvents lblGreigeStock As System.Windows.Forms.Label
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents lblRollNo As System.Windows.Forms.Label
End Class
