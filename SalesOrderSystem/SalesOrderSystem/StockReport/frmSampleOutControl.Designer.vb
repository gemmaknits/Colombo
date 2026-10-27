<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleOutControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleOutControl))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPrintExcept = New System.Windows.Forms.RadioButton()
        Me.optPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintAll = New System.Windows.Forms.RadioButton()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtlLocation = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNoneDom = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ChkGroupByDesign = New System.Windows.Forms.RadioButton()
        Me.ChkDetail = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPrintExcept)
        Me.GroupBox1.Controls.Add(Me.optPrintOnly)
        Me.GroupBox1.Controls.Add(Me.optPrintAll)
        Me.GroupBox1.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox1.Controls.Add(Me.cbomtlLocation)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 132)
        Me.GroupBox1.TabIndex = 355
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Locations"
        '
        'optPrintExcept
        '
        Me.optPrintExcept.AutoSize = True
        Me.optPrintExcept.Location = New System.Drawing.Point(177, 19)
        Me.optPrintExcept.Name = "optPrintExcept"
        Me.optPrintExcept.Size = New System.Drawing.Size(85, 17)
        Me.optPrintExcept.TabIndex = 356
        Me.optPrintExcept.Text = "Print Except"
        Me.optPrintExcept.UseVisualStyleBackColor = True
        '
        'optPrintOnly
        '
        Me.optPrintOnly.AutoSize = True
        Me.optPrintOnly.Location = New System.Drawing.Point(87, 19)
        Me.optPrintOnly.Name = "optPrintOnly"
        Me.optPrintOnly.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnly.TabIndex = 355
        Me.optPrintOnly.Text = "Print Only"
        Me.optPrintOnly.UseVisualStyleBackColor = True
        '
        'optPrintAll
        '
        Me.optPrintAll.AutoSize = True
        Me.optPrintAll.Checked = True
        Me.optPrintAll.Location = New System.Drawing.Point(6, 19)
        Me.optPrintAll.Name = "optPrintAll"
        Me.optPrintAll.Size = New System.Drawing.Size(65, 17)
        Me.optPrintAll.TabIndex = 354
        Me.optPrintAll.TabStop = True
        Me.optPrintAll.Text = "Print All"
        Me.optPrintAll.UseVisualStyleBackColor = True
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(76, 44)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(183, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'cbomtlLocation
        '
        Me.cbomtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlLocation.FormattingEnabled = True
        Me.cbomtlLocation.Location = New System.Drawing.Point(76, 99)
        Me.cbomtlLocation.Name = "cbomtlLocation"
        Me.cbomtlLocation.Size = New System.Drawing.Size(183, 21)
        Me.cbomtlLocation.TabIndex = 348
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "W/H"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Loc."
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(76, 73)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(183, 21)
        Me.cbomtlSubinventory.TabIndex = 349
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "Sub."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 354
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpDateTo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpDateFr)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 53)
        Me.GroupBox2.TabIndex = 356
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sample Out Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(177, 19)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 203
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "From"
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(49, 19)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "To"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(76, 19)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(183, 22)
        Me.txtDesignNo.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Design No."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDesignNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 50)
        Me.GroupBox3.TabIndex = 357
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter Design"
        '
        'chkNoneDom
        '
        Me.chkNoneDom.AutoSize = True
        Me.chkNoneDom.Location = New System.Drawing.Point(21, 271)
        Me.chkNoneDom.Name = "chkNoneDom"
        Me.chkNoneDom.Size = New System.Drawing.Size(143, 17)
        Me.chkNoneDom.TabIndex = 358
        Me.chkNoneDom.Text = "Show Only None DOM"
        Me.chkNoneDom.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkDetail)
        Me.GroupBox4.Controls.Add(Me.ChkGroupByDesign)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 91)
        Me.GroupBox4.TabIndex = 359
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Type"
        '
        'ChkGroupByDesign
        '
        Me.ChkGroupByDesign.AutoSize = True
        Me.ChkGroupByDesign.Location = New System.Drawing.Point(12, 51)
        Me.ChkGroupByDesign.Name = "ChkGroupByDesign"
        Me.ChkGroupByDesign.Size = New System.Drawing.Size(112, 17)
        Me.ChkGroupByDesign.TabIndex = 0
        Me.ChkGroupByDesign.Text = "Group By Design"
        Me.ChkGroupByDesign.UseVisualStyleBackColor = True
        '
        'ChkDetail
        '
        Me.ChkDetail.AutoSize = True
        Me.ChkDetail.Checked = True
        Me.ChkDetail.Location = New System.Drawing.Point(12, 21)
        Me.ChkDetail.Name = "ChkDetail"
        Me.ChkDetail.Size = New System.Drawing.Size(55, 17)
        Me.ChkDetail.TabIndex = 1
        Me.ChkDetail.TabStop = True
        Me.ChkDetail.Text = "Detail"
        Me.ChkDetail.UseVisualStyleBackColor = True
        '
        'frmSampleOutControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 398)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkNoneDom)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampleOutControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample Out Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optPrintExcept As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintOnly As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAll As System.Windows.Forms.RadioButton
    Friend WithEvents cbomtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbomtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNoneDom As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkGroupByDesign As System.Windows.Forms.RadioButton
    Friend WithEvents ChkDetail As System.Windows.Forms.RadioButton
End Class
