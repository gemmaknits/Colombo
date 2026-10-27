<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintSampleTag
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSampleTag))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsmnPrintTag = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSrpNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbbDesignFamily = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchDyedRoll = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmnPrintTag, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(358, 25)
        Me.ToolStrip1.TabIndex = 330
        '
        'tsmnPrintTag
        '
        Me.tsmnPrintTag.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.tsmnPrintTag.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmnPrintTag.Name = "tsmnPrintTag"
        Me.tsmnPrintTag.Size = New System.Drawing.Size(75, 22)
        Me.tsmnPrintTag.Text = "Print Tag"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchDyedRoll)
        Me.GroupBox1.Controls.Add(Me.txtSrpNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRollNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbbDesignFamily)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 116)
        Me.GroupBox1.TabIndex = 331
        Me.GroupBox1.TabStop = False
        '
        'txtSrpNo
        '
        Me.txtSrpNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSrpNo.Location = New System.Drawing.Point(143, 51)
        Me.txtSrpNo.Name = "txtSrpNo"
        Me.txtSrpNo.Size = New System.Drawing.Size(87, 20)
        Me.txtSrpNo.TabIndex = 338
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 337
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 336
        Me.Label5.Text = "Design Family"
        '
        'txtRollNo
        '
        Me.txtRollNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtRollNo.Location = New System.Drawing.Point(143, 24)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(87, 20)
        Me.txtRollNo.TabIndex = 335
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 334
        Me.Label3.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 333
        Me.Label14.Text = "Roll No."
        '
        'cbbDesignFamily
        '
        Me.cbbDesignFamily.FormattingEnabled = True
        Me.cbbDesignFamily.Location = New System.Drawing.Point(143, 77)
        Me.cbbDesignFamily.Name = "cbbDesignFamily"
        Me.cbbDesignFamily.Size = New System.Drawing.Size(157, 21)
        Me.cbbDesignFamily.TabIndex = 331
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SRP No"
        '
        'btnSearchDyedRoll
        '
        Me.btnSearchDyedRoll.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x1
        Me.btnSearchDyedRoll.Location = New System.Drawing.Point(236, 24)
        Me.btnSearchDyedRoll.Name = "btnSearchDyedRoll"
        Me.btnSearchDyedRoll.Size = New System.Drawing.Size(25, 21)
        Me.btnSearchDyedRoll.TabIndex = 339
        Me.btnSearchDyedRoll.UseVisualStyleBackColor = True
        '
        'frmPrintSampleTag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 153)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmPrintSampleTag"
        Me.Text = "Print Sample Tag"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsmnPrintTag As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSrpNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRollNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbbDesignFamily As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchDyedRoll As Button
End Class
