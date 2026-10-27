<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesPerformance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesPerformance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.optMonth = New System.Windows.Forms.RadioButton()
        Me.optYear = New System.Windows.Forms.RadioButton()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optCustomer = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optSummary = New System.Windows.Forms.RadioButton()
        Me.optDetails = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optExport = New System.Windows.Forms.RadioButton()
        Me.optDomestic = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(217, 25)
        Me.ToolStrip1.TabIndex = 7
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
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM yyyy"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(96, 40)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.Size = New System.Drawing.Size(112, 20)
        Me.dtpMonth.TabIndex = 1
        '
        'optMonth
        '
        Me.optMonth.AutoSize = True
        Me.optMonth.Checked = True
        Me.optMonth.Location = New System.Drawing.Point(16, 40)
        Me.optMonth.Name = "optMonth"
        Me.optMonth.Size = New System.Drawing.Size(70, 17)
        Me.optMonth.TabIndex = 0
        Me.optMonth.TabStop = True
        Me.optMonth.Text = "By Month"
        '
        'optYear
        '
        Me.optYear.AutoSize = True
        Me.optYear.Location = New System.Drawing.Point(16, 64)
        Me.optYear.Name = "optYear"
        Me.optYear.Size = New System.Drawing.Size(62, 17)
        Me.optYear.TabIndex = 2
        Me.optYear.Text = "By Year"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Enabled = False
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(96, 64)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(56, 20)
        Me.dtpYear.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optCustomer)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'optCustomer
        '
        Me.optCustomer.AutoSize = True
        Me.optCustomer.Location = New System.Drawing.Point(112, 16)
        Me.optCustomer.Name = "optCustomer"
        Me.optCustomer.Size = New System.Drawing.Size(69, 17)
        Me.optCustomer.TabIndex = 1
        Me.optCustomer.Text = "Customer"
        Me.optCustomer.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Checked = True
        Me.optDesignNo.Location = New System.Drawing.Point(24, 16)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(58, 17)
        Me.optDesignNo.TabIndex = 0
        Me.optDesignNo.TabStop = True
        Me.optDesignNo.Text = "Design"
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optSummary)
        Me.GroupBox2.Controls.Add(Me.optDetails)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'optSummary
        '
        Me.optSummary.AutoSize = True
        Me.optSummary.Location = New System.Drawing.Point(112, 16)
        Me.optSummary.Name = "optSummary"
        Me.optSummary.Size = New System.Drawing.Size(68, 17)
        Me.optSummary.TabIndex = 1
        Me.optSummary.Text = "Summary"
        Me.optSummary.UseVisualStyleBackColor = True
        '
        'optDetails
        '
        Me.optDetails.AutoSize = True
        Me.optDetails.Checked = True
        Me.optDetails.Location = New System.Drawing.Point(24, 16)
        Me.optDetails.Name = "optDetails"
        Me.optDetails.Size = New System.Drawing.Size(57, 17)
        Me.optDetails.TabIndex = 0
        Me.optDetails.TabStop = True
        Me.optDetails.Text = "Details"
        Me.optDetails.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optExport)
        Me.GroupBox3.Controls.Add(Me.optDomestic)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'optExport
        '
        Me.optExport.AutoSize = True
        Me.optExport.Location = New System.Drawing.Point(112, 16)
        Me.optExport.Name = "optExport"
        Me.optExport.Size = New System.Drawing.Size(55, 17)
        Me.optExport.TabIndex = 1
        Me.optExport.Text = "Export"
        Me.optExport.UseVisualStyleBackColor = True
        '
        'optDomestic
        '
        Me.optDomestic.AutoSize = True
        Me.optDomestic.Checked = True
        Me.optDomestic.Location = New System.Drawing.Point(24, 16)
        Me.optDomestic.Name = "optDomestic"
        Me.optDomestic.Size = New System.Drawing.Size(69, 17)
        Me.optDomestic.TabIndex = 0
        Me.optDomestic.TabStop = True
        Me.optDomestic.Text = "Domestic"
        Me.optDomestic.UseVisualStyleBackColor = True
        '
        'frmSalesPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 257)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpYear)
        Me.Controls.Add(Me.optYear)
        Me.Controls.Add(Me.optMonth)
        Me.Controls.Add(Me.dtpMonth)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesPerformance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Performance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents optMonth As System.Windows.Forms.RadioButton
    Friend WithEvents optYear As System.Windows.Forms.RadioButton
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents optDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optSummary As System.Windows.Forms.RadioButton
    Friend WithEvents optDetails As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optExport As System.Windows.Forms.RadioButton
    Friend WithEvents optDomestic As System.Windows.Forms.RadioButton
End Class
