<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGOnhandLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGOnhandLocation))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optCustomer = New System.Windows.Forms.RadioButton()
        Me.optLocation = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.txtSONo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(201, 25)
        Me.ToolStrip1.TabIndex = 3
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
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(80, 40)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(112, 20)
        Me.txtDesignNo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Design No."
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(80, 64)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(112, 20)
        Me.txtLocation.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Location"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optCustomer)
        Me.GroupBox1.Controls.Add(Me.optLocation)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 72)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order"
        '
        'optCustomer
        '
        Me.optCustomer.AutoSize = True
        Me.optCustomer.Location = New System.Drawing.Point(16, 48)
        Me.optCustomer.Name = "optCustomer"
        Me.optCustomer.Size = New System.Drawing.Size(69, 17)
        Me.optCustomer.TabIndex = 2
        Me.optCustomer.Text = "Customer"
        Me.optCustomer.UseVisualStyleBackColor = True
        '
        'optLocation
        '
        Me.optLocation.AutoSize = True
        Me.optLocation.Location = New System.Drawing.Point(104, 24)
        Me.optLocation.Name = "optLocation"
        Me.optLocation.Size = New System.Drawing.Size(66, 17)
        Me.optLocation.TabIndex = 1
        Me.optLocation.Text = "Location"
        Me.optLocation.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Checked = True
        Me.optDesignNo.Location = New System.Drawing.Point(16, 24)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(72, 17)
        Me.optDesignNo.TabIndex = 0
        Me.optDesignNo.TabStop = True
        Me.optDesignNo.Text = "DesignNo"
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'txtSONo
        '
        Me.txtSONo.Location = New System.Drawing.Point(80, 88)
        Me.txtSONo.Name = "txtSONo"
        Me.txtSONo.Size = New System.Drawing.Size(112, 20)
        Me.txtSONo.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "S/O No."
        '
        'frmStockGOnhandLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 201)
        Me.Controls.Add(Me.txtSONo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockGOnhandLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "G Onhand Location"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optLocation As System.Windows.Forms.RadioButton
    Friend WithEvents optDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtSONo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents optCustomer As System.Windows.Forms.RadioButton
End Class
