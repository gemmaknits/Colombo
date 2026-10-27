<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionLotsIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionLotsIndex))
        Me.lblRollNo = New System.Windows.Forms.Label()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.btnSearchRollNo = New System.Windows.Forms.Button()
        Me.lblGreigeStock = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRollNo
        '
        Me.lblRollNo.AutoSize = True
        Me.lblRollNo.Location = New System.Drawing.Point(47, 98)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(45, 13)
        Me.lblRollNo.TabIndex = 322
        Me.lblRollNo.Text = "Roll No."
        '
        'txtroll_no
        '
        Me.txtroll_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtroll_no.Location = New System.Drawing.Point(114, 95)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.Size = New System.Drawing.Size(142, 20)
        Me.txtroll_no.TabIndex = 321
        '
        'btnSearchRollNo
        '
        Me.btnSearchRollNo.Image = CType(resources.GetObject("btnSearchRollNo.Image"), System.Drawing.Image)
        Me.btnSearchRollNo.Location = New System.Drawing.Point(262, 92)
        Me.btnSearchRollNo.Name = "btnSearchRollNo"
        Me.btnSearchRollNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchRollNo.TabIndex = 320
        Me.btnSearchRollNo.UseVisualStyleBackColor = True
        Me.btnSearchRollNo.Visible = False
        '
        'lblGreigeStock
        '
        Me.lblGreigeStock.AutoSize = True
        Me.lblGreigeStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGreigeStock.Location = New System.Drawing.Point(47, 58)
        Me.lblGreigeStock.Name = "lblGreigeStock"
        Me.lblGreigeStock.Size = New System.Drawing.Size(107, 15)
        Me.lblGreigeStock.TabIndex = 319
        Me.lblGreigeStock.Text = "Production Lots"
        '
        'frmProductionLotsIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 172)
        Me.Controls.Add(Me.lblRollNo)
        Me.Controls.Add(Me.txtroll_no)
        Me.Controls.Add(Me.btnSearchRollNo)
        Me.Controls.Add(Me.lblGreigeStock)
        Me.Name = "frmProductionLotsIndex"
        Me.Text = "Production Lots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRollNo As System.Windows.Forms.Label
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchRollNo As System.Windows.Forms.Button
    Friend WithEvents lblGreigeStock As System.Windows.Forms.Label
End Class
