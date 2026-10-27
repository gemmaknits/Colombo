<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKOOntime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKOOntime))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.OptOnTime = New System.Windows.Forms.RadioButton()
        Me.OptWaitTime = New System.Windows.Forms.RadioButton()
        Me.OptAllTime = New System.Windows.Forms.RadioButton()
        Me.cbomc = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblSup = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(310, 25)
        Me.ToolStrip1.TabIndex = 34
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'OptOnTime
        '
        Me.OptOnTime.AutoSize = True
        Me.OptOnTime.Checked = True
        Me.OptOnTime.Location = New System.Drawing.Point(6, 19)
        Me.OptOnTime.Name = "OptOnTime"
        Me.OptOnTime.Size = New System.Drawing.Size(68, 17)
        Me.OptOnTime.TabIndex = 35
        Me.OptOnTime.TabStop = True
        Me.OptOnTime.Text = "Pending"
        Me.OptOnTime.UseVisualStyleBackColor = True
        '
        'OptWaitTime
        '
        Me.OptWaitTime.AutoSize = True
        Me.OptWaitTime.Location = New System.Drawing.Point(89, 19)
        Me.OptWaitTime.Name = "OptWaitTime"
        Me.OptWaitTime.Size = New System.Drawing.Size(110, 17)
        Me.OptWaitTime.TabIndex = 36
        Me.OptWaitTime.TabStop = True
        Me.OptWaitTime.Text = "Wait For Process"
        Me.OptWaitTime.UseVisualStyleBackColor = True
        '
        'OptAllTime
        '
        Me.OptAllTime.AutoSize = True
        Me.OptAllTime.Location = New System.Drawing.Point(212, 19)
        Me.OptAllTime.Name = "OptAllTime"
        Me.OptAllTime.Size = New System.Drawing.Size(38, 17)
        Me.OptAllTime.TabIndex = 37
        Me.OptAllTime.TabStop = True
        Me.OptAllTime.Text = "All"
        Me.OptAllTime.UseVisualStyleBackColor = True
        '
        'cbomc
        '
        Me.cbomc.FormattingEnabled = True
        Me.cbomc.Location = New System.Drawing.Point(106, 19)
        Me.cbomc.Name = "cbomc"
        Me.cbomc.Size = New System.Drawing.Size(166, 21)
        Me.cbomc.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptOnTime)
        Me.GroupBox1.Controls.Add(Me.OptWaitTime)
        Me.GroupBox1.Controls.Add(Me.OptAllTime)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 51)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.lblSup)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbomc)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 98)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fliter By"
        '
        'cboCustomer
        '
        Me.cboCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(106, 57)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(166, 21)
        Me.cboCustomer.TabIndex = 52
        '
        'lblSup
        '
        Me.lblSup.AutoSize = True
        Me.lblSup.Location = New System.Drawing.Point(38, 60)
        Me.lblSup.Name = "lblSup"
        Me.lblSup.Size = New System.Drawing.Size(56, 13)
        Me.lblSup.TabIndex = 51
        Me.lblSup.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "M/C No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "***ถ้าต้องการแสดงทั้งหมดให้เครื่อง ใส่ค่าว่าง"
        '
        'frmKOOntime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKOOntime"
        Me.Text = "KO Ontime By Machine"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptOnTime As System.Windows.Forms.RadioButton
    Friend WithEvents OptWaitTime As System.Windows.Forms.RadioButton
    Friend WithEvents OptAllTime As System.Windows.Forms.RadioButton
    Friend WithEvents cbomc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblSup As System.Windows.Forms.Label
End Class
