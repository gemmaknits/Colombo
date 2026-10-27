<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyingOrderSummary
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyingOrderSummary))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDFNo = New System.Windows.Forms.ComboBox()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.cboOwner = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDyedHouse = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optGammaRecieveDate = New System.Windows.Forms.RadioButton()
        Me.optDFDate = New System.Windows.Forms.RadioButton()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optOrderFilterAll = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTO = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTS = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterDevl = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optExportAndDomestic = New System.Windows.Forms.RadioButton()
        Me.optDomestic = New System.Windows.Forms.RadioButton()
        Me.optExport = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(240, 64)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 4
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(112, 64)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "D/F Date From"
        '
        'cboDFNo
        '
        Me.cboDFNo.FormattingEnabled = True
        Me.cboDFNo.Location = New System.Drawing.Point(112, 16)
        Me.cboDFNo.Name = "cboDFNo"
        Me.cboDFNo.Size = New System.Drawing.Size(88, 21)
        Me.cboDFNo.TabIndex = 1
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
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "D/F No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExportToExcel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(361, 25)
        Me.ToolStrip1.TabIndex = 19
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Image = Global.SalesOrderSystem.My.Resources.Resources.ExcelWorksheetView_16x1
        Me.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(53, 22)
        Me.btnExportToExcel.Text = "Excel"
        '
        'cboOwner
        '
        Me.cboOwner.FormattingEnabled = True
        Me.cboOwner.Location = New System.Drawing.Point(112, 184)
        Me.cboOwner.Name = "cboOwner"
        Me.cboOwner.Size = New System.Drawing.Size(88, 21)
        Me.cboOwner.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Owner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Design No."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(112, 160)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(216, 21)
        Me.cboDesignNo.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dyed House"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
        '
        'cboDyedHouse
        '
        Me.cboDyedHouse.FormattingEnabled = True
        Me.cboDyedHouse.Location = New System.Drawing.Point(112, 136)
        Me.cboDyedHouse.Name = "cboDyedHouse"
        Me.cboDyedHouse.Size = New System.Drawing.Size(216, 21)
        Me.cboDyedHouse.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optGammaRecieveDate)
        Me.GroupBox1.Controls.Add(Me.optDFDate)
        Me.GroupBox1.Controls.Add(Me.cboOwner)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboDyedHouse)
        Me.GroupBox1.Controls.Add(Me.cboSoNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboDFNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 216)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'optGammaRecieveDate
        '
        Me.optGammaRecieveDate.AutoSize = True
        Me.optGammaRecieveDate.Location = New System.Drawing.Point(208, 40)
        Me.optGammaRecieveDate.Name = "optGammaRecieveDate"
        Me.optGammaRecieveDate.Size = New System.Drawing.Size(130, 17)
        Me.optGammaRecieveDate.TabIndex = 17
        Me.optGammaRecieveDate.TabStop = True
        Me.optGammaRecieveDate.Text = "Gamma Recieve Date"
        Me.optGammaRecieveDate.UseVisualStyleBackColor = True
        '
        'optDFDate
        '
        Me.optDFDate.AutoSize = True
        Me.optDFDate.Checked = True
        Me.optDFDate.Location = New System.Drawing.Point(112, 40)
        Me.optDFDate.Name = "optDFDate"
        Me.optDFDate.Size = New System.Drawing.Size(70, 17)
        Me.optDFDate.TabIndex = 16
        Me.optDFDate.TabStop = True
        Me.optDFDate.Text = "D/F Date"
        Me.optDFDate.UseVisualStyleBackColor = True
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(112, 88)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(88, 21)
        Me.cboSoNo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "S/O No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Customer Name"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(112, 112)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(216, 21)
        Me.cboCustomer.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optOrderFilterAll)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTO)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTS)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterDevl)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 116)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Order filter"
        '
        'optOrderFilterAll
        '
        Me.optOrderFilterAll.AutoSize = True
        Me.optOrderFilterAll.Checked = True
        Me.optOrderFilterAll.Location = New System.Drawing.Point(30, 19)
        Me.optOrderFilterAll.Name = "optOrderFilterAll"
        Me.optOrderFilterAll.Size = New System.Drawing.Size(69, 17)
        Me.optOrderFilterAll.TabIndex = 29
        Me.optOrderFilterAll.TabStop = True
        Me.optOrderFilterAll.Text = "Show All "
        Me.optOrderFilterAll.UseVisualStyleBackColor = True
        '
        'optOrderFilterMTO
        '
        Me.optOrderFilterMTO.AutoSize = True
        Me.optOrderFilterMTO.Location = New System.Drawing.Point(30, 90)
        Me.optOrderFilterMTO.Name = "optOrderFilterMTO"
        Me.optOrderFilterMTO.Size = New System.Drawing.Size(143, 17)
        Me.optOrderFilterMTO.TabIndex = 28
        Me.optOrderFilterMTO.Text = "Show only Make-to-order"
        Me.optOrderFilterMTO.UseVisualStyleBackColor = True
        '
        'optOrderFilterMTS
        '
        Me.optOrderFilterMTS.AutoSize = True
        Me.optOrderFilterMTS.Location = New System.Drawing.Point(30, 65)
        Me.optOrderFilterMTS.Name = "optOrderFilterMTS"
        Me.optOrderFilterMTS.Size = New System.Drawing.Size(147, 17)
        Me.optOrderFilterMTS.TabIndex = 27
        Me.optOrderFilterMTS.Text = "Show Only Make-to-stock"
        Me.optOrderFilterMTS.UseVisualStyleBackColor = True
        '
        'optOrderFilterDevl
        '
        Me.optOrderFilterDevl.AutoSize = True
        Me.optOrderFilterDevl.Location = New System.Drawing.Point(30, 42)
        Me.optOrderFilterDevl.Name = "optOrderFilterDevl"
        Me.optOrderFilterDevl.Size = New System.Drawing.Size(142, 17)
        Me.optOrderFilterDevl.TabIndex = 26
        Me.optOrderFilterDevl.Text = "Show Only Devl, Sample"
        Me.optOrderFilterDevl.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optExportAndDomestic)
        Me.GroupBox2.Controls.Add(Me.optDomestic)
        Me.GroupBox2.Controls.Add(Me.optExport)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 116)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Department filter"
        '
        'optExportAndDomestic
        '
        Me.optExportAndDomestic.AutoSize = True
        Me.optExportAndDomestic.Checked = True
        Me.optExportAndDomestic.Location = New System.Drawing.Point(30, 19)
        Me.optExportAndDomestic.Name = "optExportAndDomestic"
        Me.optExportAndDomestic.Size = New System.Drawing.Size(69, 17)
        Me.optExportAndDomestic.TabIndex = 29
        Me.optExportAndDomestic.TabStop = True
        Me.optExportAndDomestic.Text = "Show All "
        Me.optExportAndDomestic.UseVisualStyleBackColor = True
        '
        'optDomestic
        '
        Me.optDomestic.AutoSize = True
        Me.optDomestic.Location = New System.Drawing.Point(30, 65)
        Me.optDomestic.Name = "optDomestic"
        Me.optDomestic.Size = New System.Drawing.Size(123, 17)
        Me.optDomestic.TabIndex = 27
        Me.optDomestic.Text = "Show Only Domestic"
        Me.optDomestic.UseVisualStyleBackColor = True
        '
        'optExport
        '
        Me.optExport.AutoSize = True
        Me.optExport.Location = New System.Drawing.Point(30, 42)
        Me.optExport.Name = "optExport"
        Me.optExport.Size = New System.Drawing.Size(109, 17)
        Me.optExport.TabIndex = 26
        Me.optExport.Text = "Show Only Export"
        Me.optExport.UseVisualStyleBackColor = True
        '
        'frmDyingOrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 409)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyingOrderSummary"
        Me.Text = "Dying Order Report Summary"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cboDFNo As System.Windows.Forms.ComboBox
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents cboOwner As System.Windows.Forms.ComboBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents cboDyedHouse As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optOrderFilterAll As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTO As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTS As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterDevl As System.Windows.Forms.RadioButton
    Friend WithEvents optGammaRecieveDate As System.Windows.Forms.RadioButton
    Friend WithEvents optDFDate As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optExportAndDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents optDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents optExport As System.Windows.Forms.RadioButton
    Friend WithEvents btnExportToExcel As ToolStripButton
End Class
