<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOrderSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOrderSummary))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.checkAllST = New System.Windows.Forms.CheckBox()
        Me.checkAllSalesPersons = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOnlyWithoutDF = New System.Windows.Forms.CheckBox()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comboSalesPerson = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSoNo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsaleRegion = New System.Windows.Forms.Label()
        Me.optOrderFilterMTO = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTS = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterAll = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterDevl = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbosalesRegion = New System.Windows.Forms.ComboBox()
        Me.btnExportToExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExportToExcel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(425, 25)
        Me.ToolStrip1.TabIndex = 33
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
        'checkAllST
        '
        Me.checkAllST.AutoSize = True
        Me.checkAllST.Checked = True
        Me.checkAllST.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAllST.Location = New System.Drawing.Point(334, 18)
        Me.checkAllST.Name = "checkAllST"
        Me.checkAllST.Size = New System.Drawing.Size(39, 17)
        Me.checkAllST.TabIndex = 14
        Me.checkAllST.Text = "All"
        Me.checkAllST.UseVisualStyleBackColor = True
        '
        'checkAllSalesPersons
        '
        Me.checkAllSalesPersons.AutoSize = True
        Me.checkAllSalesPersons.Checked = True
        Me.checkAllSalesPersons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkAllSalesPersons.Location = New System.Drawing.Point(334, 98)
        Me.checkAllSalesPersons.Name = "checkAllSalesPersons"
        Me.checkAllSalesPersons.Size = New System.Drawing.Size(39, 17)
        Me.checkAllSalesPersons.TabIndex = 10
        Me.checkAllSalesPersons.Text = "All"
        Me.checkAllSalesPersons.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkAllST)
        Me.GroupBox1.Controls.Add(Me.chkOnlyWithoutDF)
        Me.GroupBox1.Controls.Add(Me.txtDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.checkAllSalesPersons)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.comboSalesPerson)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboSoNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 160)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Order Filter"
        '
        'chkOnlyWithoutDF
        '
        Me.chkOnlyWithoutDF.AutoSize = True
        Me.chkOnlyWithoutDF.Location = New System.Drawing.Point(240, 120)
        Me.chkOnlyWithoutDF.Name = "chkOnlyWithoutDF"
        Me.chkOnlyWithoutDF.Size = New System.Drawing.Size(145, 17)
        Me.chkOnlyWithoutDF.TabIndex = 13
        Me.chkOnlyWithoutDF.Text = "Show only without D/F"
        Me.chkOnlyWithoutDF.UseVisualStyleBackColor = True
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(112, 120)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(120, 22)
        Me.txtDesignNo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Design No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sales person:"
        '
        'comboSalesPerson
        '
        Me.comboSalesPerson.FormattingEnabled = True
        Me.comboSalesPerson.Location = New System.Drawing.Point(112, 94)
        Me.comboSalesPerson.Name = "comboSalesPerson"
        Me.comboSalesPerson.Size = New System.Drawing.Size(216, 21)
        Me.comboSalesPerson.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
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
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(240, 40)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 4
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(112, 40)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 3
        Me.dtpDateFr.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "S/T Date From"
        '
        'cboSoNo
        '
        Me.cboSoNo.FormattingEnabled = True
        Me.cboSoNo.Location = New System.Drawing.Point(112, 16)
        Me.cboSoNo.Name = "cboSoNo"
        Me.cboSoNo.Size = New System.Drawing.Size(216, 21)
        Me.cboSoNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "S/T No."
        '
        'lblsaleRegion
        '
        Me.lblsaleRegion.AutoSize = True
        Me.lblsaleRegion.Location = New System.Drawing.Point(217, 247)
        Me.lblsaleRegion.Name = "lblsaleRegion"
        Me.lblsaleRegion.Size = New System.Drawing.Size(47, 13)
        Me.lblsaleRegion.TabIndex = 36
        Me.lblsaleRegion.Text = "Region:"
        '
        'optOrderFilterMTO
        '
        Me.optOrderFilterMTO.AutoSize = True
        Me.optOrderFilterMTO.Location = New System.Drawing.Point(21, 90)
        Me.optOrderFilterMTO.Name = "optOrderFilterMTO"
        Me.optOrderFilterMTO.Size = New System.Drawing.Size(157, 17)
        Me.optOrderFilterMTO.TabIndex = 28
        Me.optOrderFilterMTO.Text = "Show only Make-to-order"
        Me.optOrderFilterMTO.UseVisualStyleBackColor = True
        '
        'optOrderFilterMTS
        '
        Me.optOrderFilterMTS.AutoSize = True
        Me.optOrderFilterMTS.Location = New System.Drawing.Point(21, 65)
        Me.optOrderFilterMTS.Name = "optOrderFilterMTS"
        Me.optOrderFilterMTS.Size = New System.Drawing.Size(158, 17)
        Me.optOrderFilterMTS.TabIndex = 27
        Me.optOrderFilterMTS.Text = "Show Only Make-to-stock"
        Me.optOrderFilterMTS.UseVisualStyleBackColor = True
        '
        'optOrderFilterAll
        '
        Me.optOrderFilterAll.AutoSize = True
        Me.optOrderFilterAll.Checked = True
        Me.optOrderFilterAll.Location = New System.Drawing.Point(21, 19)
        Me.optOrderFilterAll.Name = "optOrderFilterAll"
        Me.optOrderFilterAll.Size = New System.Drawing.Size(73, 17)
        Me.optOrderFilterAll.TabIndex = 33
        Me.optOrderFilterAll.TabStop = True
        Me.optOrderFilterAll.Text = "Show All "
        Me.optOrderFilterAll.UseVisualStyleBackColor = True
        '
        'optOrderFilterDevl
        '
        Me.optOrderFilterDevl.AutoSize = True
        Me.optOrderFilterDevl.Location = New System.Drawing.Point(21, 42)
        Me.optOrderFilterDevl.Name = "optOrderFilterDevl"
        Me.optOrderFilterDevl.Size = New System.Drawing.Size(149, 17)
        Me.optOrderFilterDevl.TabIndex = 32
        Me.optOrderFilterDevl.Text = "Show Only Devl, Sample"
        Me.optOrderFilterDevl.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optOrderFilterAll)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterDevl)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTO)
        Me.GroupBox3.Controls.Add(Me.optOrderFilterMTS)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Type filter"
        '
        'cbosalesRegion
        '
        Me.cbosalesRegion.FormattingEnabled = True
        Me.cbosalesRegion.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.cbosalesRegion.Location = New System.Drawing.Point(267, 243)
        Me.cbosalesRegion.Name = "cbosalesRegion"
        Me.cbosalesRegion.Size = New System.Drawing.Size(121, 21)
        Me.cbosalesRegion.TabIndex = 35
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Image = Global.SalesOrderSystem.My.Resources.Resources.ExcelWorksheetView_16x
        Me.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(53, 22)
        Me.btnExportToExcel.Text = "Excel"
        '
        'frmStockOrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 362)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblsaleRegion)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cbosalesRegion)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockOrderSummary"
        Me.Text = "Stock Order Summary"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents checkAllST As CheckBox
    Friend WithEvents checkAllSalesPersons As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOnlyWithoutDF As CheckBox
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents comboSalesPerson As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents dtpDateFr As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cboSoNo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsaleRegion As Label
    Friend WithEvents optOrderFilterMTO As RadioButton
    Friend WithEvents optOrderFilterMTS As RadioButton
    Friend WithEvents optOrderFilterAll As RadioButton
    Friend WithEvents optOrderFilterDevl As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbosalesRegion As ComboBox
    Friend WithEvents btnExportToExcel As ToolStripButton
End Class
