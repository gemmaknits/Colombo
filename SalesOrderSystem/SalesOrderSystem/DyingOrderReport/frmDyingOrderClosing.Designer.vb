<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderClosing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyingOrderClosing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSONo = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.optCustomer = New System.Windows.Forms.RadioButton()
        Me.optDFDate = New System.Windows.Forms.RadioButton()
        Me.optDFNo = New System.Windows.Forms.RadioButton()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLossFr = New System.Windows.Forms.TextBox()
        Me.txtLossTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSONo)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Controls.Add(Me.optCustomer)
        Me.GroupBox1.Controls.Add(Me.optDFDate)
        Me.GroupBox1.Controls.Add(Me.optDFNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 88)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order By"
        '
        'optSONo
        '
        Me.optSONo.AutoSize = True
        Me.optSONo.Location = New System.Drawing.Point(16, 56)
        Me.optSONo.Name = "optSONo"
        Me.optSONo.Size = New System.Drawing.Size(65, 17)
        Me.optSONo.TabIndex = 3
        Me.optSONo.Text = "S/O No."
        Me.optSONo.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Location = New System.Drawing.Point(200, 24)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(78, 17)
        Me.optDesignNo.TabIndex = 2
        Me.optDesignNo.Text = "Design No."
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'optCustomer
        '
        Me.optCustomer.AutoSize = True
        Me.optCustomer.Location = New System.Drawing.Point(104, 56)
        Me.optCustomer.Name = "optCustomer"
        Me.optCustomer.Size = New System.Drawing.Size(69, 17)
        Me.optCustomer.TabIndex = 4
        Me.optCustomer.Text = "Customer"
        Me.optCustomer.UseVisualStyleBackColor = True
        '
        'optDFDate
        '
        Me.optDFDate.AutoSize = True
        Me.optDFDate.Location = New System.Drawing.Point(104, 24)
        Me.optDFDate.Name = "optDFDate"
        Me.optDFDate.Size = New System.Drawing.Size(70, 17)
        Me.optDFDate.TabIndex = 1
        Me.optDFDate.Text = "D/F Date"
        Me.optDFDate.UseVisualStyleBackColor = True
        '
        'optDFNo
        '
        Me.optDFNo.AutoSize = True
        Me.optDFNo.Checked = True
        Me.optDFNo.Location = New System.Drawing.Point(16, 24)
        Me.optDFNo.Name = "optDFNo"
        Me.optDFNo.Size = New System.Drawing.Size(64, 17)
        Me.optDFNo.TabIndex = 0
        Me.optDFNo.TabStop = True
        Me.optDFNo.Text = "D/F No."
        Me.optDFNo.UseVisualStyleBackColor = True
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(104, 64)
        Me.txtDesignNo.MaxLength = 25
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(216, 20)
        Me.txtDesignNo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Design No."
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Loss % From"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(329, 25)
        Me.ToolStrip1.TabIndex = 6
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(232, 40)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 1
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(104, 40)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "D/F Date From"
        '
        'txtLossFr
        '
        Me.txtLossFr.Location = New System.Drawing.Point(104, 88)
        Me.txtLossFr.MaxLength = 25
        Me.txtLossFr.Name = "txtLossFr"
        Me.txtLossFr.Size = New System.Drawing.Size(88, 20)
        Me.txtLossFr.TabIndex = 3
        Me.txtLossFr.Text = "-100"
        Me.txtLossFr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLossTo
        '
        Me.txtLossTo.Location = New System.Drawing.Point(232, 88)
        Me.txtLossTo.MaxLength = 25
        Me.txtLossTo.Name = "txtLossTo"
        Me.txtLossTo.Size = New System.Drawing.Size(88, 20)
        Me.txtLossTo.TabIndex = 4
        Me.txtLossTo.Text = "100"
        Me.txtLossTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "To"
        '
        'frmDyingOrderClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 217)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLossTo)
        Me.Controls.Add(Me.txtLossFr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyingOrderClosing"
        Me.Text = "DF Order Closing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSONo As System.Windows.Forms.RadioButton
    Friend WithEvents optDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents optCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents optDFDate As System.Windows.Forms.RadioButton
    Friend WithEvents optDFNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLossFr As System.Windows.Forms.TextBox
    Friend WithEvents txtLossTo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
