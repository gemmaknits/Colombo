<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockSummary
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.lblDateFr = New System.Windows.Forms.Label()
        Me.lblArticleNo = New System.Windows.Forms.Label()
        Me.cboArticleNo = New System.Windows.Forms.ComboBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblStNo = New System.Windows.Forms.Label()
        Me.cboStNo = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()

        ' ToolStrip1
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(480, 25)
        Me.ToolStrip1.TabIndex = 0

        ' btnPrint
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(51, 22)
        Me.btnPrint.Text = "&Print"

        ' btnMinimized
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(69, 22)
        Me.btnMinimized.Text = "Minimized"

        ' btnExit
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 22)
        Me.btnExit.Text = "E&xit"

        ' GroupBox1
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.lblDateTo)
        Me.GroupBox1.Controls.Add(Me.lblDateFr)
        Me.GroupBox1.Controls.Add(Me.lblArticleNo)
        Me.GroupBox1.Controls.Add(Me.cboArticleNo)
        Me.GroupBox1.Controls.Add(Me.lblCustomer)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.lblStNo)
        Me.GroupBox1.Controls.Add(Me.cboStNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Filter"

        ' lblDateFr
        Me.lblDateFr.AutoSize = False
        Me.lblDateFr.Location = New System.Drawing.Point(8, 22)
        Me.lblDateFr.Name = "lblDateFr"
        Me.lblDateFr.Size = New System.Drawing.Size(68, 20)
        Me.lblDateFr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDateFr.Text = "Date From :"

        ' dtpDateFr
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Location = New System.Drawing.Point(80, 19)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(105, 20)
        Me.dtpDateFr.TabIndex = 0

        ' lblDateTo
        Me.lblDateTo.AutoSize = False
        Me.lblDateTo.Location = New System.Drawing.Point(198, 22)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(58, 20)
        Me.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDateTo.Text = "Date To :"

        ' dtpDateTo
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Location = New System.Drawing.Point(260, 19)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(105, 20)
        Me.dtpDateTo.TabIndex = 1

        ' lblArticleNo
        Me.lblArticleNo.AutoSize = False
        Me.lblArticleNo.Location = New System.Drawing.Point(8, 50)
        Me.lblArticleNo.Name = "lblArticleNo"
        Me.lblArticleNo.Size = New System.Drawing.Size(68, 21)
        Me.lblArticleNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblArticleNo.Text = "Article No. :"

        ' cboArticleNo
        Me.cboArticleNo.Location = New System.Drawing.Point(80, 47)
        Me.cboArticleNo.Name = "cboArticleNo"
        Me.cboArticleNo.Size = New System.Drawing.Size(110, 21)
        Me.cboArticleNo.TabIndex = 2
        Me.cboArticleNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown

        ' lblCustomer
        Me.lblCustomer.AutoSize = False
        Me.lblCustomer.Location = New System.Drawing.Point(198, 50)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(58, 21)
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCustomer.Text = "Customer :"

        ' cboCustomer
        Me.cboCustomer.Location = New System.Drawing.Point(260, 47)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(182, 21)
        Me.cboCustomer.TabIndex = 3
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown

        ' lblStNo
        Me.lblStNo.AutoSize = False
        Me.lblStNo.Location = New System.Drawing.Point(8, 78)
        Me.lblStNo.Name = "lblStNo"
        Me.lblStNo.Size = New System.Drawing.Size(68, 21)
        Me.lblStNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStNo.Text = "S/T No. :"

        ' cboStNo
        Me.cboStNo.Location = New System.Drawing.Point(80, 75)
        Me.cboStNo.Name = "cboStNo"
        Me.cboStNo.Size = New System.Drawing.Size(110, 21)
        Me.cboStNo.TabIndex = 4
        Me.cboStNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown

        ' frmStockSummary
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 156)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStockSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Greige Summary"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend lblDateFr As System.Windows.Forms.Label
    Friend lblDateTo As System.Windows.Forms.Label
    Friend lblArticleNo As System.Windows.Forms.Label
    Friend WithEvents cboArticleNo As System.Windows.Forms.ComboBox
    Friend lblCustomer As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend lblStNo As System.Windows.Forms.Label
    Friend WithEvents cboStNo As System.Windows.Forms.ComboBox
End Class
