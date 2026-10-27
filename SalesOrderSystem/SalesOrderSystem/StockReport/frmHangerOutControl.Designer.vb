<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangerOutControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangerOutControl))
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.comboSalesPerson = New System.Windows.Forms.ComboBox()
        Me.optPrintAllDesign = New System.Windows.Forms.RadioButton()
        Me.optPrintOnlyDesign = New System.Windows.Forms.RadioButton()
        Me.optPrintOnlyEmpcd = New System.Windows.Forms.RadioButton()
        Me.optPrintAllEmpcd = New System.Windows.Forms.RadioButton()
        Me.optPrintExceptDesign = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optPrintExceptEmpcd = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.optPrintExceptCustomers = New System.Windows.Forms.RadioButton()
        Me.optPrintOnlyCustomers = New System.Windows.Forms.RadioButton()
        Me.optPrintAllCustomers = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.optCustomer = New System.Windows.Forms.RadioButton()
        Me.optRequested = New System.Windows.Forms.RadioButton()
        Me.optDesign = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 142)
        Me.GroupBox1.TabIndex = 359
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "From"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Enabled = False
        Me.txtDesignNo.Location = New System.Drawing.Point(11, 33)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(252, 22)
        Me.txtDesignNo.TabIndex = 32
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.TabIndex = 358
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 53)
        Me.GroupBox2.TabIndex = 360
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hanger Out Date"
        '
        'comboSalesPerson
        '
        Me.comboSalesPerson.Enabled = False
        Me.comboSalesPerson.FormattingEnabled = True
        Me.comboSalesPerson.Location = New System.Drawing.Point(13, 37)
        Me.comboSalesPerson.Name = "comboSalesPerson"
        Me.comboSalesPerson.Size = New System.Drawing.Size(251, 21)
        Me.comboSalesPerson.TabIndex = 362
        '
        'optPrintAllDesign
        '
        Me.optPrintAllDesign.AutoSize = True
        Me.optPrintAllDesign.Checked = True
        Me.optPrintAllDesign.Location = New System.Drawing.Point(11, 16)
        Me.optPrintAllDesign.Name = "optPrintAllDesign"
        Me.optPrintAllDesign.Size = New System.Drawing.Size(65, 17)
        Me.optPrintAllDesign.TabIndex = 357
        Me.optPrintAllDesign.TabStop = True
        Me.optPrintAllDesign.Text = "Print All"
        Me.optPrintAllDesign.UseVisualStyleBackColor = True
        '
        'optPrintOnlyDesign
        '
        Me.optPrintOnlyDesign.AutoSize = True
        Me.optPrintOnlyDesign.Location = New System.Drawing.Point(87, 16)
        Me.optPrintOnlyDesign.Name = "optPrintOnlyDesign"
        Me.optPrintOnlyDesign.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnlyDesign.TabIndex = 364
        Me.optPrintOnlyDesign.Text = "Print Only"
        Me.optPrintOnlyDesign.UseVisualStyleBackColor = True
        '
        'optPrintOnlyEmpcd
        '
        Me.optPrintOnlyEmpcd.AutoSize = True
        Me.optPrintOnlyEmpcd.Location = New System.Drawing.Point(88, 18)
        Me.optPrintOnlyEmpcd.Name = "optPrintOnlyEmpcd"
        Me.optPrintOnlyEmpcd.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnlyEmpcd.TabIndex = 366
        Me.optPrintOnlyEmpcd.Text = "Print Only"
        Me.optPrintOnlyEmpcd.UseVisualStyleBackColor = True
        '
        'optPrintAllEmpcd
        '
        Me.optPrintAllEmpcd.AutoSize = True
        Me.optPrintAllEmpcd.Checked = True
        Me.optPrintAllEmpcd.Location = New System.Drawing.Point(13, 18)
        Me.optPrintAllEmpcd.Name = "optPrintAllEmpcd"
        Me.optPrintAllEmpcd.Size = New System.Drawing.Size(65, 17)
        Me.optPrintAllEmpcd.TabIndex = 365
        Me.optPrintAllEmpcd.TabStop = True
        Me.optPrintAllEmpcd.Text = "Print All"
        Me.optPrintAllEmpcd.UseVisualStyleBackColor = True
        '
        'optPrintExceptDesign
        '
        Me.optPrintExceptDesign.AutoSize = True
        Me.optPrintExceptDesign.Location = New System.Drawing.Point(178, 16)
        Me.optPrintExceptDesign.Name = "optPrintExceptDesign"
        Me.optPrintExceptDesign.Size = New System.Drawing.Size(85, 17)
        Me.optPrintExceptDesign.TabIndex = 370
        Me.optPrintExceptDesign.Text = "Print Except"
        Me.optPrintExceptDesign.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optPrintExceptDesign)
        Me.GroupBox4.Controls.Add(Me.txtDesignNo)
        Me.GroupBox4.Controls.Add(Me.optPrintAllDesign)
        Me.GroupBox4.Controls.Add(Me.optPrintOnlyDesign)
        Me.GroupBox4.Location = New System.Drawing.Point(289, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(281, 61)
        Me.GroupBox4.TabIndex = 362
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Design No."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optPrintExceptEmpcd)
        Me.GroupBox5.Controls.Add(Me.optPrintOnlyEmpcd)
        Me.GroupBox5.Controls.Add(Me.optPrintAllEmpcd)
        Me.GroupBox5.Controls.Add(Me.comboSalesPerson)
        Me.GroupBox5.Location = New System.Drawing.Point(288, 85)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(282, 66)
        Me.GroupBox5.TabIndex = 363
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sale Person"
        '
        'optPrintExceptEmpcd
        '
        Me.optPrintExceptEmpcd.AutoSize = True
        Me.optPrintExceptEmpcd.Location = New System.Drawing.Point(179, 18)
        Me.optPrintExceptEmpcd.Name = "optPrintExceptEmpcd"
        Me.optPrintExceptEmpcd.Size = New System.Drawing.Size(85, 17)
        Me.optPrintExceptEmpcd.TabIndex = 371
        Me.optPrintExceptEmpcd.Text = "Print Except"
        Me.optPrintExceptEmpcd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCustomer)
        Me.GroupBox3.Controls.Add(Me.optPrintExceptCustomers)
        Me.GroupBox3.Controls.Add(Me.optPrintOnlyCustomers)
        Me.GroupBox3.Controls.Add(Me.optPrintAllCustomers)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(281, 76)
        Me.GroupBox3.TabIndex = 370
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customers"
        '
        'cboCustomer
        '
        Me.cboCustomer.Enabled = False
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(12, 38)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(251, 21)
        Me.cboCustomer.TabIndex = 375
        '
        'optPrintExceptCustomers
        '
        Me.optPrintExceptCustomers.AutoSize = True
        Me.optPrintExceptCustomers.Location = New System.Drawing.Point(179, 16)
        Me.optPrintExceptCustomers.Name = "optPrintExceptCustomers"
        Me.optPrintExceptCustomers.Size = New System.Drawing.Size(85, 17)
        Me.optPrintExceptCustomers.TabIndex = 374
        Me.optPrintExceptCustomers.Text = "Print Except"
        Me.optPrintExceptCustomers.UseVisualStyleBackColor = True
        '
        'optPrintOnlyCustomers
        '
        Me.optPrintOnlyCustomers.AutoSize = True
        Me.optPrintOnlyCustomers.Location = New System.Drawing.Point(88, 16)
        Me.optPrintOnlyCustomers.Name = "optPrintOnlyCustomers"
        Me.optPrintOnlyCustomers.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnlyCustomers.TabIndex = 373
        Me.optPrintOnlyCustomers.Text = "Print Only"
        Me.optPrintOnlyCustomers.UseVisualStyleBackColor = True
        '
        'optPrintAllCustomers
        '
        Me.optPrintAllCustomers.AutoSize = True
        Me.optPrintAllCustomers.Checked = True
        Me.optPrintAllCustomers.Location = New System.Drawing.Point(12, 16)
        Me.optPrintAllCustomers.Name = "optPrintAllCustomers"
        Me.optPrintAllCustomers.Size = New System.Drawing.Size(65, 17)
        Me.optPrintAllCustomers.TabIndex = 372
        Me.optPrintAllCustomers.TabStop = True
        Me.optPrintAllCustomers.Text = "Print All"
        Me.optPrintAllCustomers.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optCustomer)
        Me.GroupBox6.Controls.Add(Me.optRequested)
        Me.GroupBox6.Controls.Add(Me.optDesign)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 232)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(270, 50)
        Me.GroupBox6.TabIndex = 371
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Report Type"
        '
        'optCustomer
        '
        Me.optCustomer.AutoSize = True
        Me.optCustomer.Location = New System.Drawing.Point(174, 16)
        Me.optCustomer.Name = "optCustomer"
        Me.optCustomer.Size = New System.Drawing.Size(79, 17)
        Me.optCustomer.TabIndex = 24
        Me.optCustomer.Text = "Customers"
        Me.optCustomer.UseVisualStyleBackColor = True
        '
        'optRequested
        '
        Me.optRequested.AutoSize = True
        Me.optRequested.Location = New System.Drawing.Point(88, 16)
        Me.optRequested.Name = "optRequested"
        Me.optRequested.Size = New System.Drawing.Size(84, 17)
        Me.optRequested.TabIndex = 9
        Me.optRequested.Text = "Sale Person"
        Me.optRequested.UseVisualStyleBackColor = True
        '
        'optDesign
        '
        Me.optDesign.AutoSize = True
        Me.optDesign.Checked = True
        Me.optDesign.Location = New System.Drawing.Point(16, 16)
        Me.optDesign.Name = "optDesign"
        Me.optDesign.Size = New System.Drawing.Size(61, 17)
        Me.optDesign.TabIndex = 8
        Me.optDesign.TabStop = True
        Me.optDesign.Text = "Design"
        Me.optDesign.UseVisualStyleBackColor = True
        '
        'frmHangerOutControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 294)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHangerOutControl"
        Me.Text = "Hanger Out Control"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents comboSalesPerson As System.Windows.Forms.ComboBox
    Friend WithEvents optPrintOnlyEmpcd As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAllEmpcd As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAllDesign As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintOnlyDesign As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintExceptDesign As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents optPrintExceptEmpcd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optPrintExceptCustomers As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintOnlyCustomers As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAllCustomers As System.Windows.Forms.RadioButton
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents optCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents optRequested As System.Windows.Forms.RadioButton
    Friend WithEvents optDesign As System.Windows.Forms.RadioButton
End Class
