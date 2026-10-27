<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangerStockBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangerStockBalance))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optPrintExcept = New System.Windows.Forms.RadioButton()
        Me.optPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintAll = New System.Windows.Forms.RadioButton()
        Me.cbomtlLocation = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkShowDesignOutOfStock = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(177, 19)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 214
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
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(49, 19)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 212
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "From"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(87, 16)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(178, 20)
        Me.txtDesignNo.TabIndex = 211
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Design No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(332, 25)
        Me.ToolStrip1.TabIndex = 209
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optPrintExcept)
        Me.GroupBox3.Controls.Add(Me.optPrintOnly)
        Me.GroupBox3.Controls.Add(Me.optPrintAll)
        Me.GroupBox3.Controls.Add(Me.cbomtlLocation)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 139)
        Me.GroupBox3.TabIndex = 360
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Locations"
        '
        'optPrintExcept
        '
        Me.optPrintExcept.AutoSize = True
        Me.optPrintExcept.Location = New System.Drawing.Point(177, 21)
        Me.optPrintExcept.Name = "optPrintExcept"
        Me.optPrintExcept.Size = New System.Drawing.Size(87, 17)
        Me.optPrintExcept.TabIndex = 353
        Me.optPrintExcept.Text = "Print Except"
        Me.optPrintExcept.UseVisualStyleBackColor = True
        '
        'optPrintOnly
        '
        Me.optPrintOnly.AutoSize = True
        Me.optPrintOnly.Location = New System.Drawing.Point(87, 21)
        Me.optPrintOnly.Name = "optPrintOnly"
        Me.optPrintOnly.Size = New System.Drawing.Size(77, 17)
        Me.optPrintOnly.TabIndex = 352
        Me.optPrintOnly.Text = "Print Only"
        Me.optPrintOnly.UseVisualStyleBackColor = True
        '
        'optPrintAll
        '
        Me.optPrintAll.AutoSize = True
        Me.optPrintAll.Checked = True
        Me.optPrintAll.Location = New System.Drawing.Point(6, 21)
        Me.optPrintAll.Name = "optPrintAll"
        Me.optPrintAll.Size = New System.Drawing.Size(67, 17)
        Me.optPrintAll.TabIndex = 351
        Me.optPrintAll.TabStop = True
        Me.optPrintAll.Text = "Print All"
        Me.optPrintAll.UseVisualStyleBackColor = True
        '
        'cbomtlLocation
        '
        Me.cbomtlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomtlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtlLocation.FormattingEnabled = True
        Me.cbomtlLocation.Location = New System.Drawing.Point(69, 101)
        Me.cbomtlLocation.Name = "cbomtlLocation"
        Me.cbomtlLocation.Size = New System.Drawing.Size(196, 21)
        Me.cbomtlLocation.TabIndex = 348
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 350
        Me.Label8.Text = "Sub."
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(69, 74)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(196, 21)
        Me.cbomtlSubinventory.TabIndex = 349
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Loc."
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(69, 44)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(196, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "W/H"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 54)
        Me.GroupBox1.TabIndex = 361
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Recevied Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDesignNo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 54)
        Me.GroupBox2.TabIndex = 362
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Design"
        '
        'ChkShowDesignOutOfStock
        '
        Me.ChkShowDesignOutOfStock.AutoSize = True
        Me.ChkShowDesignOutOfStock.Location = New System.Drawing.Point(16, 17)
        Me.ChkShowDesignOutOfStock.Name = "ChkShowDesignOutOfStock"
        Me.ChkShowDesignOutOfStock.Size = New System.Drawing.Size(152, 17)
        Me.ChkShowDesignOutOfStock.TabIndex = 363
        Me.ChkShowDesignOutOfStock.Text = "Show Design Out of Stock"
        Me.ChkShowDesignOutOfStock.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ChkShowDesignOutOfStock)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(300, 49)
        Me.GroupBox4.TabIndex = 364
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hanger Option"
        '
        'frmHangerStockBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 360)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHangerStockBalance"
        Me.Text = "Hanger Stock Balance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbomtlLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbomtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbomtlWarehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optPrintOnly As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAll As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintExcept As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkShowDesignOutOfStock As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
