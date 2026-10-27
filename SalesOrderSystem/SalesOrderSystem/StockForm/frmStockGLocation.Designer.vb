<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGLocation))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDFNo = New System.Windows.Forms.RadioButton()
        Me.optCol = New System.Windows.Forms.RadioButton()
        Me.optLotNo = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(862, 25)
        Me.ToolStrip1.TabIndex = 293
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
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
        Me.GroupBox1.Controls.Add(Me.optDFNo)
        Me.GroupBox1.Controls.Add(Me.optCol)
        Me.GroupBox1.Controls.Add(Me.optLotNo)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 50)
        Me.GroupBox1.TabIndex = 294
        Me.GroupBox1.TabStop = False
        '
        'optDFNo
        '
        Me.optDFNo.AutoSize = True
        Me.optDFNo.Location = New System.Drawing.Point(367, 18)
        Me.optDFNo.Name = "optDFNo"
        Me.optDFNo.Size = New System.Drawing.Size(64, 17)
        Me.optDFNo.TabIndex = 8
        Me.optDFNo.TabStop = True
        Me.optDFNo.Text = "D/F No."
        Me.optDFNo.UseVisualStyleBackColor = True
        '
        'optCol
        '
        Me.optCol.AutoSize = True
        Me.optCol.Location = New System.Drawing.Point(244, 18)
        Me.optCol.Name = "optCol"
        Me.optCol.Size = New System.Drawing.Size(83, 17)
        Me.optCol.TabIndex = 7
        Me.optCol.TabStop = True
        Me.optCol.Text = "Colour Code"
        Me.optCol.UseVisualStyleBackColor = True
        '
        'optLotNo
        '
        Me.optLotNo.AutoSize = True
        Me.optLotNo.Location = New System.Drawing.Point(141, 18)
        Me.optLotNo.Name = "optLotNo"
        Me.optLotNo.Size = New System.Drawing.Size(60, 17)
        Me.optLotNo.TabIndex = 6
        Me.optLotNo.Text = "Lot No."
        Me.optLotNo.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Checked = True
        Me.optDesignNo.Location = New System.Drawing.Point(33, 18)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(78, 17)
        Me.optDesignNo.TabIndex = 5
        Me.optDesignNo.TabStop = True
        Me.optDesignNo.Text = "Design No."
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'txtSeach
        '
        Me.txtSeach.Location = New System.Drawing.Point(615, 30)
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(182, 20)
        Me.txtSeach.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtSeach)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(838, 72)
        Me.GroupBox2.TabIndex = 295
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condition"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(838, 312)
        Me.GroupBox3.TabIndex = 296
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(824, 287)
        Me.DataGridView1.TabIndex = 0
        '
        'frmStockGLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 431)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmStockGLocation"
        Me.Text = "Stock G Location"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optDFNo As RadioButton
    Friend WithEvents optCol As RadioButton
    Friend WithEvents optLotNo As RadioButton
    Friend WithEvents optDesignNo As RadioButton
    Friend WithEvents txtSeach As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
