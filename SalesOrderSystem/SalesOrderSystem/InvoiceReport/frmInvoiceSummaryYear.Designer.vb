<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceSummaryYear
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceSummaryYear))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYearFr = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optExport = New System.Windows.Forms.RadioButton()
        Me.optDomestic = New System.Windows.Forms.RadioButton()
        Me.chkExclGMK = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClearArticle = New System.Windows.Forms.Button()
        Me.btnGetCustomer = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.btnGetArticle = New System.Windows.Forms.Button()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtYearTo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign = New System.Windows.Forms.RadioButton()
        Me.rbInvoiceYearSummaryGrpBySalesDesign = New System.Windows.Forms.RadioButton()
        Me.rbInvoiceYearSummaryGrpBySales = New System.Windows.Forms.RadioButton()
        Me.rbInvoiceYearSummary = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(517, 25)
        Me.ToolStrip1.TabIndex = 20
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Year"
        '
        'txtYearFr
        '
        Me.txtYearFr.Location = New System.Drawing.Point(161, 19)
        Me.txtYearFr.Name = "txtYearFr"
        Me.txtYearFr.Size = New System.Drawing.Size(64, 22)
        Me.txtYearFr.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optAll)
        Me.GroupBox1.Controls.Add(Me.optExport)
        Me.GroupBox1.Controls.Add(Me.optDomestic)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 41)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domestic / Export / All"
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(222, 17)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(38, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optExport
        '
        Me.optExport.AutoSize = True
        Me.optExport.Location = New System.Drawing.Point(132, 17)
        Me.optExport.Name = "optExport"
        Me.optExport.Size = New System.Drawing.Size(58, 17)
        Me.optExport.TabIndex = 1
        Me.optExport.Text = "Export"
        Me.optExport.UseVisualStyleBackColor = True
        '
        'optDomestic
        '
        Me.optDomestic.AutoSize = True
        Me.optDomestic.Checked = True
        Me.optDomestic.Location = New System.Drawing.Point(27, 17)
        Me.optDomestic.Name = "optDomestic"
        Me.optDomestic.Size = New System.Drawing.Size(72, 17)
        Me.optDomestic.TabIndex = 0
        Me.optDomestic.TabStop = True
        Me.optDomestic.Text = "Domestic"
        Me.optDomestic.UseVisualStyleBackColor = True
        '
        'chkExclGMK
        '
        Me.chkExclGMK.AutoSize = True
        Me.chkExclGMK.Location = New System.Drawing.Point(25, 17)
        Me.chkExclGMK.Name = "chkExclGMK"
        Me.chkExclGMK.Size = New System.Drawing.Size(92, 17)
        Me.chkExclGMK.TabIndex = 24
        Me.chkExclGMK.Text = "Exclude GMK"
        Me.chkExclGMK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnClearArticle)
        Me.GroupBox2.Controls.Add(Me.btnGetCustomer)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCustomerName)
        Me.GroupBox2.Controls.Add(Me.txtCustomerCode)
        Me.GroupBox2.Controls.Add(Me.btnGetArticle)
        Me.GroupBox2.Controls.Add(Me.txtDesignNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtYearTo)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtYearFr)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 165)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Condition"
        '
        'btnClearArticle
        '
        Me.btnClearArticle.Image = Global.SalesOrderSystem.My.Resources.Resources.DeleteQuery_16x1
        Me.btnClearArticle.Location = New System.Drawing.Point(454, 49)
        Me.btnClearArticle.Name = "btnClearArticle"
        Me.btnClearArticle.Size = New System.Drawing.Size(24, 22)
        Me.btnClearArticle.TabIndex = 35
        Me.btnClearArticle.UseVisualStyleBackColor = True
        '
        'btnGetCustomer
        '
        Me.btnGetCustomer.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnGetCustomer.Location = New System.Drawing.Point(175, 78)
        Me.btnGetCustomer.Name = "btnGetCustomer"
        Me.btnGetCustomer.Size = New System.Drawing.Size(24, 22)
        Me.btnGetCustomer.TabIndex = 24
        Me.btnGetCustomer.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Customer"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.Snow
        Me.txtCustomerName.Location = New System.Drawing.Point(205, 79)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(273, 22)
        Me.txtCustomerName.TabIndex = 23
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.BackColor = System.Drawing.Color.Snow
        Me.txtCustomerCode.Location = New System.Drawing.Point(122, 79)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        Me.txtCustomerCode.Size = New System.Drawing.Size(51, 22)
        Me.txtCustomerCode.TabIndex = 23
        '
        'btnGetArticle
        '
        Me.btnGetArticle.Image = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnGetArticle.Location = New System.Drawing.Point(427, 49)
        Me.btnGetArticle.Name = "btnGetArticle"
        Me.btnGetArticle.Size = New System.Drawing.Size(24, 22)
        Me.btnGetArticle.TabIndex = 32
        Me.btnGetArticle.UseVisualStyleBackColor = True
        '
        'txtDesignNo
        '
        Me.txtDesignNo.BackColor = System.Drawing.Color.Snow
        Me.txtDesignNo.Location = New System.Drawing.Point(122, 51)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.ReadOnly = True
        Me.txtDesignNo.Size = New System.Drawing.Size(301, 22)
        Me.txtDesignNo.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Article"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkExclGMK)
        Me.GroupBox5.Location = New System.Drawing.Point(339, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(140, 41)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GMK Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "To"
        '
        'txtYearTo
        '
        Me.txtYearTo.Location = New System.Drawing.Point(284, 19)
        Me.txtYearTo.Name = "txtYearTo"
        Me.txtYearTo.Size = New System.Drawing.Size(64, 22)
        Me.txtYearTo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "From"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbInvoiceYearSummaryGrpBySalesYMDesign)
        Me.GroupBox3.Controls.Add(Me.rbInvoiceYearSummaryGrpBySalesDesign)
        Me.GroupBox3.Controls.Add(Me.rbInvoiceYearSummaryGrpBySales)
        Me.GroupBox3.Controls.Add(Me.rbInvoiceYearSummary)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 117)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reports"
        '
        'rbInvoiceYearSummaryGrpBySalesYMDesign
        '
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.AutoSize = True
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.Location = New System.Drawing.Point(50, 88)
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.Name = "rbInvoiceYearSummaryGrpBySalesYMDesign"
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.Size = New System.Drawing.Size(323, 17)
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.TabIndex = 4
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.Text = "Invoice Year Summary (Group by Sales, Year, Moth, Design)"
        Me.rbInvoiceYearSummaryGrpBySalesYMDesign.UseVisualStyleBackColor = True
        '
        'rbInvoiceYearSummaryGrpBySalesDesign
        '
        Me.rbInvoiceYearSummaryGrpBySalesDesign.AutoSize = True
        Me.rbInvoiceYearSummaryGrpBySalesDesign.Location = New System.Drawing.Point(50, 65)
        Me.rbInvoiceYearSummaryGrpBySalesDesign.Name = "rbInvoiceYearSummaryGrpBySalesDesign"
        Me.rbInvoiceYearSummaryGrpBySalesDesign.Size = New System.Drawing.Size(330, 17)
        Me.rbInvoiceYearSummaryGrpBySalesDesign.TabIndex = 3
        Me.rbInvoiceYearSummaryGrpBySalesDesign.Text = "Invoice Year Summary (Group by Sales, Year, Design, Month)"
        Me.rbInvoiceYearSummaryGrpBySalesDesign.UseVisualStyleBackColor = True
        '
        'rbInvoiceYearSummaryGrpBySales
        '
        Me.rbInvoiceYearSummaryGrpBySales.AutoSize = True
        Me.rbInvoiceYearSummaryGrpBySales.Location = New System.Drawing.Point(50, 42)
        Me.rbInvoiceYearSummaryGrpBySales.Name = "rbInvoiceYearSummaryGrpBySales"
        Me.rbInvoiceYearSummaryGrpBySales.Size = New System.Drawing.Size(220, 17)
        Me.rbInvoiceYearSummaryGrpBySales.TabIndex = 2
        Me.rbInvoiceYearSummaryGrpBySales.Text = "Invoice Year Summary (Group by Sales)"
        Me.rbInvoiceYearSummaryGrpBySales.UseVisualStyleBackColor = True
        '
        'rbInvoiceYearSummary
        '
        Me.rbInvoiceYearSummary.AutoSize = True
        Me.rbInvoiceYearSummary.Checked = True
        Me.rbInvoiceYearSummary.Location = New System.Drawing.Point(50, 19)
        Me.rbInvoiceYearSummary.Name = "rbInvoiceYearSummary"
        Me.rbInvoiceYearSummary.Size = New System.Drawing.Size(134, 17)
        Me.rbInvoiceYearSummary.TabIndex = 1
        Me.rbInvoiceYearSummary.TabStop = True
        Me.rbInvoiceYearSummary.Text = "Invoice Year Summary"
        Me.rbInvoiceYearSummary.UseVisualStyleBackColor = True
        '
        'frmInvoiceSummaryYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 330)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceSummaryYear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Year Summary"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtYearFr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optExport As System.Windows.Forms.RadioButton
    Friend WithEvents optDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents chkExclGMK As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtYearTo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbInvoiceYearSummaryGrpBySales As RadioButton
    Friend WithEvents rbInvoiceYearSummary As RadioButton
    Friend WithEvents rbInvoiceYearSummaryGrpBySalesYMDesign As RadioButton
    Friend WithEvents rbInvoiceYearSummaryGrpBySalesDesign As RadioButton
    Friend WithEvents txtCustomerCode As TextBox
    Friend WithEvents btnGetCustomer As Button
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGetArticle As Button
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClearArticle As Button
End Class
