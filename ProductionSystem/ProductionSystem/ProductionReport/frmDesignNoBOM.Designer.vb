<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesignNoBOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesignNoBOM))
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtItcd = New System.Windows.Forms.TextBox()
        Me.txtYarnDescpNo1 = New System.Windows.Forms.TextBox()
        Me.btnGetYarnCodeNo1 = New System.Windows.Forms.Button()
        Me.rbDesignNo = New System.Windows.Forms.RadioButton()
        Me.rbItemsNo = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(121, 40)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(128, 22)
        Me.txtDesignNo.TabIndex = 201
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(600, 25)
        Me.ToolStrip1.TabIndex = 200
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
        'txtItcd
        '
        Me.txtItcd.Location = New System.Drawing.Point(121, 66)
        Me.txtItcd.Name = "txtItcd"
        Me.txtItcd.Size = New System.Drawing.Size(128, 22)
        Me.txtItcd.TabIndex = 203
        '
        'txtYarnDescpNo1
        '
        Me.txtYarnDescpNo1.Location = New System.Drawing.Point(282, 66)
        Me.txtYarnDescpNo1.Name = "txtYarnDescpNo1"
        Me.txtYarnDescpNo1.ReadOnly = True
        Me.txtYarnDescpNo1.Size = New System.Drawing.Size(295, 22)
        Me.txtYarnDescpNo1.TabIndex = 206
        '
        'btnGetYarnCodeNo1
        '
        Me.btnGetYarnCodeNo1.BackgroundImage = Global.ProductionSystem.My.Resources.Resources.Search_16x
        Me.btnGetYarnCodeNo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetYarnCodeNo1.Location = New System.Drawing.Point(252, 66)
        Me.btnGetYarnCodeNo1.Name = "btnGetYarnCodeNo1"
        Me.btnGetYarnCodeNo1.Size = New System.Drawing.Size(24, 20)
        Me.btnGetYarnCodeNo1.TabIndex = 205
        Me.btnGetYarnCodeNo1.UseVisualStyleBackColor = True
        '
        'rbDesignNo
        '
        Me.rbDesignNo.AutoSize = True
        Me.rbDesignNo.Location = New System.Drawing.Point(19, 41)
        Me.rbDesignNo.Name = "rbDesignNo"
        Me.rbDesignNo.Size = New System.Drawing.Size(84, 17)
        Me.rbDesignNo.TabIndex = 207
        Me.rbDesignNo.Text = "Designs No"
        Me.rbDesignNo.UseVisualStyleBackColor = True
        '
        'rbItemsNo
        '
        Me.rbItemsNo.AutoSize = True
        Me.rbItemsNo.Checked = True
        Me.rbItemsNo.Location = New System.Drawing.Point(19, 67)
        Me.rbItemsNo.Name = "rbItemsNo"
        Me.rbItemsNo.Size = New System.Drawing.Size(73, 17)
        Me.rbItemsNo.TabIndex = 208
        Me.rbItemsNo.TabStop = True
        Me.rbItemsNo.Text = "Items No."
        Me.rbItemsNo.UseVisualStyleBackColor = True
        '
        'frmDesignNoBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 113)
        Me.Controls.Add(Me.rbItemsNo)
        Me.Controls.Add(Me.rbDesignNo)
        Me.Controls.Add(Me.txtYarnDescpNo1)
        Me.Controls.Add(Me.btnGetYarnCodeNo1)
        Me.Controls.Add(Me.txtItcd)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDesignNoBOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Design No. BOM"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtItcd As System.Windows.Forms.TextBox
    Friend WithEvents txtYarnDescpNo1 As TextBox
    Friend WithEvents btnGetYarnCodeNo1 As Button
    Friend WithEvents rbDesignNo As RadioButton
    Friend WithEvents rbItemsNo As RadioButton
End Class
