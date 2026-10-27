<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderEnterCustPoUnique
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
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.txtCustPoUnique = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouting.Location = New System.Drawing.Point(23, 18)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(137, 21)
        Me.lblRouting.TabIndex = 139
        Me.lblRouting.Text = "Customer P/O No."
        '
        'txtCustPoUnique
        '
        Me.txtCustPoUnique.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCustPoUnique.Location = New System.Drawing.Point(166, 18)
        Me.txtCustPoUnique.Name = "txtCustPoUnique"
        Me.txtCustPoUnique.Size = New System.Drawing.Size(179, 29)
        Me.txtCustPoUnique.TabIndex = 138
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.SalesOrderSystem.My.Resources.Resources.Cancel_16x
        Me.btnCancel.Location = New System.Drawing.Point(271, 59)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 38)
        Me.btnCancel.TabIndex = 141
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Image = Global.SalesOrderSystem.My.Resources.Resources.Checkmark_16x
        Me.btnOk.Location = New System.Drawing.Point(195, 59)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 38)
        Me.btnOk.TabIndex = 140
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmSalesOrderEnterCustPoUnique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 115)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.txtCustPoUnique)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesOrderEnterCustPoUnique"
        Me.Text = "Enter Customer P/O No.(Unique)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lblRouting As Label
    Friend WithEvents txtCustPoUnique As TextBox
End Class
