<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostRollup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostRollup))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCompo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelectYarnCode = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCompo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtItemName)
        Me.GroupBox2.Controls.Add(Me.btnSelectYarnCode)
        Me.GroupBox2.Controls.Add(Me.txtItemCode)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 75)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conditon 1"
        '
        'txtCompo
        '
        Me.txtCompo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCompo.Location = New System.Drawing.Point(68, 45)
        Me.txtCompo.Name = "txtCompo"
        Me.txtCompo.ReadOnly = True
        Me.txtCompo.Size = New System.Drawing.Size(368, 22)
        Me.txtCompo.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Compo"
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtItemName.Location = New System.Drawing.Point(186, 19)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(250, 22)
        Me.txtItemName.TabIndex = 40
        '
        'txtItemCode
        '
        Me.txtItemCode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtItemCode.Location = New System.Drawing.Point(68, 19)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(90, 22)
        Me.txtItemCode.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Item"
        '
        'btnSelectYarnCode
        '
        Me.btnSelectYarnCode.BackgroundImage = CType(resources.GetObject("btnSelectYarnCode.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectYarnCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectYarnCode.Location = New System.Drawing.Point(160, 19)
        Me.btnSelectYarnCode.Name = "btnSelectYarnCode"
        Me.btnSelectYarnCode.Size = New System.Drawing.Size(21, 23)
        Me.btnSelectYarnCode.TabIndex = 39
        Me.btnSelectYarnCode.Text = "..."
        Me.btnSelectYarnCode.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(483, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(70, 25)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmCostRollup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 90)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmCostRollup"
        Me.Text = "Cost Rollup"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCompo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents btnSelectYarnCode As Button
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
End Class
