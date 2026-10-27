<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrderInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrderInvoice))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancel = New System.Windows.Forms.GroupBox()
        Me.rbCancelShow = New System.Windows.Forms.RadioButton()
        Me.rbCancelDontShow = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbPfPfdColorShowAll = New System.Windows.Forms.RadioButton()
        Me.rbPfPfdColorShowColor = New System.Windows.Forms.RadioButton()
        Me.rbPfPfdColorShowPFD = New System.Windows.Forms.RadioButton()
        Me.rbPfPfdColorShowPFE = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbInvoiceAdjustDontShow = New System.Windows.Forms.RadioButton()
        Me.rbInvoiceAdjustShow = New System.Windows.Forms.RadioButton()
        Me.checkAllSalesPersons = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboSalesPerson1 = New Classes.comboSalesPerson()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.optOption2 = New System.Windows.Forms.RadioButton()
        Me.optOption1 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optOrderFilterAll = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTO = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTS = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterDevl = New System.Windows.Forms.RadioButton()
        Me.rbPfPfdColorShowEmpty = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.Cancel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(328, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "* This report take a long time to preview. Please relax and wait a few minutes."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.checkAllSalesPersons)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboSalesPerson1)
        Me.GroupBox1.Controls.Add(Me.txtDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.optOption2)
        Me.GroupBox1.Controls.Add(Me.optOption1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboSoNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 325)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.Controls.Add(Me.rbCancelShow)
        Me.Cancel.Controls.Add(Me.rbCancelDontShow)
        Me.Cancel.Location = New System.Drawing.Point(11, 278)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(351, 37)
        Me.Cancel.TabIndex = 23
        Me.Cancel.TabStop = False
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseWaitCursor = True
        '
        'rbCancelShow
        '
        Me.rbCancelShow.AutoSize = True
        Me.rbCancelShow.Checked = True
        Me.rbCancelShow.Location = New System.Drawing.Point(35, 13)
        Me.rbCancelShow.Name = "rbCancelShow"
        Me.rbCancelShow.Size = New System.Drawing.Size(88, 17)
        Me.rbCancelShow.TabIndex = 13
        Me.rbCancelShow.TabStop = True
        Me.rbCancelShow.Text = "Show Cancel"
        Me.rbCancelShow.UseVisualStyleBackColor = True
        Me.rbCancelShow.UseWaitCursor = True
        '
        'rbCancelDontShow
        '
        Me.rbCancelDontShow.AutoSize = True
        Me.rbCancelDontShow.Location = New System.Drawing.Point(185, 13)
        Me.rbCancelDontShow.Name = "rbCancelDontShow"
        Me.rbCancelDontShow.Size = New System.Drawing.Size(116, 17)
        Me.rbCancelDontShow.TabIndex = 10
        Me.rbCancelDontShow.Text = "Don't Show Cancel"
        Me.rbCancelDontShow.UseVisualStyleBackColor = True
        Me.rbCancelDontShow.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbPfPfdColorShowEmpty)
        Me.GroupBox4.Controls.Add(Me.rbPfPfdColorShowAll)
        Me.GroupBox4.Controls.Add(Me.rbPfPfdColorShowColor)
        Me.GroupBox4.Controls.Add(Me.rbPfPfdColorShowPFD)
        Me.GroupBox4.Controls.Add(Me.rbPfPfdColorShowPFE)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 220)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(351, 53)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PF / PFD / Color"
        Me.GroupBox4.UseWaitCursor = True
        '
        'rbPfPfdColorShowAll
        '
        Me.rbPfPfdColorShowAll.AutoSize = True
        Me.rbPfPfdColorShowAll.Checked = True
        Me.rbPfPfdColorShowAll.Location = New System.Drawing.Point(22, 13)
        Me.rbPfPfdColorShowAll.Name = "rbPfPfdColorShowAll"
        Me.rbPfPfdColorShowAll.Size = New System.Drawing.Size(66, 17)
        Me.rbPfPfdColorShowAll.TabIndex = 13
        Me.rbPfPfdColorShowAll.Text = "Show All"
        Me.rbPfPfdColorShowAll.UseVisualStyleBackColor = True
        Me.rbPfPfdColorShowAll.UseWaitCursor = True
        '
        'rbPfPfdColorShowColor
        '
        Me.rbPfPfdColorShowColor.AutoSize = True
        Me.rbPfPfdColorShowColor.Location = New System.Drawing.Point(125, 31)
        Me.rbPfPfdColorShowColor.Name = "rbPfPfdColorShowColor"
        Me.rbPfPfdColorShowColor.Size = New System.Drawing.Size(79, 17)
        Me.rbPfPfdColorShowColor.TabIndex = 12
        Me.rbPfPfdColorShowColor.Text = "Show Color"
        Me.rbPfPfdColorShowColor.UseVisualStyleBackColor = True
        Me.rbPfPfdColorShowColor.UseWaitCursor = True
        '
        'rbPfPfdColorShowPFD
        '
        Me.rbPfPfdColorShowPFD.AutoSize = True
        Me.rbPfPfdColorShowPFD.Location = New System.Drawing.Point(241, 13)
        Me.rbPfPfdColorShowPFD.Name = "rbPfPfdColorShowPFD"
        Me.rbPfPfdColorShowPFD.Size = New System.Drawing.Size(76, 17)
        Me.rbPfPfdColorShowPFD.TabIndex = 11
        Me.rbPfPfdColorShowPFD.Text = "Show PFD"
        Me.rbPfPfdColorShowPFD.UseVisualStyleBackColor = True
        Me.rbPfPfdColorShowPFD.UseWaitCursor = True
        '
        'rbPfPfdColorShowPFE
        '
        Me.rbPfPfdColorShowPFE.AutoSize = True
        Me.rbPfPfdColorShowPFE.Location = New System.Drawing.Point(125, 13)
        Me.rbPfPfdColorShowPFE.Name = "rbPfPfdColorShowPFE"
        Me.rbPfPfdColorShowPFE.Size = New System.Drawing.Size(75, 17)
        Me.rbPfPfdColorShowPFE.TabIndex = 10
        Me.rbPfPfdColorShowPFE.Text = "Show PFE"
        Me.rbPfPfdColorShowPFE.UseVisualStyleBackColor = True
        Me.rbPfPfdColorShowPFE.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbInvoiceAdjustDontShow)
        Me.GroupBox2.Controls.Add(Me.rbInvoiceAdjustShow)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 36)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adjust"
        '
        'rbInvoiceAdjustDontShow
        '
        Me.rbInvoiceAdjustDontShow.AutoSize = True
        Me.rbInvoiceAdjustDontShow.Location = New System.Drawing.Point(185, 13)
        Me.rbInvoiceAdjustDontShow.Name = "rbInvoiceAdjustDontShow"
        Me.rbInvoiceAdjustDontShow.Size = New System.Drawing.Size(150, 17)
        Me.rbInvoiceAdjustDontShow.TabIndex = 11
        Me.rbInvoiceAdjustDontShow.Text = "Don't Show Invoice Adjust"
        Me.rbInvoiceAdjustDontShow.UseVisualStyleBackColor = True
        '
        'rbInvoiceAdjustShow
        '
        Me.rbInvoiceAdjustShow.AutoSize = True
        Me.rbInvoiceAdjustShow.Checked = True
        Me.rbInvoiceAdjustShow.Location = New System.Drawing.Point(35, 13)
        Me.rbInvoiceAdjustShow.Name = "rbInvoiceAdjustShow"
        Me.rbInvoiceAdjustShow.Size = New System.Drawing.Size(122, 17)
        Me.rbInvoiceAdjustShow.TabIndex = 10
        Me.rbInvoiceAdjustShow.TabStop = True
        Me.rbInvoiceAdjustShow.Text = "Show Invoice Adjust"
        Me.rbInvoiceAdjustShow.UseVisualStyleBackColor = True
        '
        'checkAllSalesPersons
        '
        Me.checkAllSalesPersons.AutoSize = True
        Me.checkAllSalesPersons.Checked = True
        Me.checkAllSalesPersons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAllSalesPersons.Location = New System.Drawing.Point(336, 93)
        Me.checkAllSalesPersons.Name = "checkAllSalesPersons"
        Me.checkAllSalesPersons.Size = New System.Drawing.Size(37, 17)
        Me.checkAllSalesPersons.TabIndex = 20
        Me.checkAllSalesPersons.Text = "All"
        Me.checkAllSalesPersons.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sale Person"
        '
        'ComboSalesPerson1
        '
        Me.ComboSalesPerson1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSalesPerson1.FormattingEnabled = True
        Me.ComboSalesPerson1.Location = New System.Drawing.Point(111, 90)
        Me.ComboSalesPerson1.Name = "ComboSalesPerson1"
        Me.ComboSalesPerson1.Size = New System.Drawing.Size(216, 21)
        Me.ComboSalesPerson1.TabIndex = 18
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(111, 115)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(216, 20)
        Me.txtDesignNo.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Design No."
        '
        'optOption2
        '
        Me.optOption2.AutoSize = True
        Me.optOption2.Location = New System.Drawing.Point(108, 166)
        Me.optOption2.Name = "optOption2"
        Me.optOption2.Size = New System.Drawing.Size(200, 17)
        Me.optOption2.TabIndex = 9
        Me.optOption2.Text = "Show S/O no Invoice from beginning"
        Me.optOption2.UseVisualStyleBackColor = True
        '
        'optOption1
        '
        Me.optOption1.AutoSize = True
        Me.optOption1.Checked = True
        Me.optOption1.Location = New System.Drawing.Point(108, 142)
        Me.optOption1.Name = "optOption1"
        Me.optOption1.Size = New System.Drawing.Size(220, 17)
        Me.optOption1.TabIndex = 8
        Me.optOption1.TabStop = True
        Me.optOption1.Text = "Show S/O and Invoice in selected period"
        Me.optOption1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Customer Name"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(112, 64)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(216, 21)
        Me.cboCustomer.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(240, 40)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 4
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(112, 40)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "S/O Date From"
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(112, 16)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(88, 21)
        Me.cboSoNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "S/O No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(399, 25)
        Me.ToolStrip1.TabIndex = 16
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optOrderFilterAll)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTO)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTS)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterDevl)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 116)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order filter"
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
        Me.optOrderFilterMTO.Location = New System.Drawing.Point(30, 89)
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
        'rbPfPfdColorShowEmpty
        '
        Me.rbPfPfdColorShowEmpty.AutoSize = True
        Me.rbPfPfdColorShowEmpty.Location = New System.Drawing.Point(22, 31)
        Me.rbPfPfdColorShowEmpty.Name = "rbPfPfdColorShowEmpty"
        Me.rbPfPfdColorShowEmpty.Size = New System.Drawing.Size(54, 17)
        Me.rbPfPfdColorShowEmpty.TabIndex = 14
        Me.rbPfPfdColorShowEmpty.Text = "Empty"
        Me.rbPfPfdColorShowEmpty.UseVisualStyleBackColor = True
        Me.rbPfPfdColorShowEmpty.UseWaitCursor = True
        '
        'frmSalesOrderInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 505)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesOrderInvoice"
        Me.Text = "Sales Order & Invoice Control Sheet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Cancel.ResumeLayout(False)
        Me.Cancel.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents optOption2 As System.Windows.Forms.RadioButton
	Friend WithEvents optOption1 As System.Windows.Forms.RadioButton
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents cboSoNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optOrderFilterAll As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTO As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTS As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterDevl As System.Windows.Forms.RadioButton
    Friend WithEvents checkAllSalesPersons As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboSalesPerson1 As Classes.comboSalesPerson
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cancel As GroupBox
    Friend WithEvents rbCancelShow As RadioButton
    Friend WithEvents rbCancelDontShow As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbPfPfdColorShowAll As RadioButton
    Friend WithEvents rbPfPfdColorShowColor As RadioButton
    Friend WithEvents rbPfPfdColorShowPFD As RadioButton
    Friend WithEvents rbPfPfdColorShowPFE As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbInvoiceAdjustDontShow As RadioButton
    Friend WithEvents rbInvoiceAdjustShow As RadioButton
    Friend WithEvents rbPfPfdColorShowEmpty As RadioButton
End Class
