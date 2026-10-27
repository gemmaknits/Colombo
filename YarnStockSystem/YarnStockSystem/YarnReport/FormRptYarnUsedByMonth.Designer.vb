<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRptYarnUsedByMonth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtpPrint = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSortByItemDesc = New System.Windows.Forms.RadioButton()
        Me.optSortByItemCode = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.crvYarnUsed = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpPrint
        '
        Me.dtpPrint.CustomFormat = "MM/yyyy"
        Me.dtpPrint.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPrint.Location = New System.Drawing.Point(8, 8)
        Me.dtpPrint.Name = "dtpPrint"
        Me.dtpPrint.Size = New System.Drawing.Size(72, 20)
        Me.dtpPrint.TabIndex = 9
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(86, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Show Data"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSortByItemDesc)
        Me.GroupBox1.Controls.Add(Me.optSortByItemCode)
        Me.GroupBox1.Location = New System.Drawing.Point(174, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 40)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort by:"
        '
        'optSortByItemDesc
        '
        Me.optSortByItemDesc.AutoSize = True
        Me.optSortByItemDesc.Location = New System.Drawing.Point(108, 14)
        Me.optSortByItemDesc.Name = "optSortByItemDesc"
        Me.optSortByItemDesc.Size = New System.Drawing.Size(99, 17)
        Me.optSortByItemDesc.TabIndex = 1
        Me.optSortByItemDesc.Text = "Item description"
        Me.optSortByItemDesc.UseVisualStyleBackColor = True
        '
        'optSortByItemCode
        '
        Me.optSortByItemCode.AutoSize = True
        Me.optSortByItemCode.Checked = True
        Me.optSortByItemCode.Location = New System.Drawing.Point(22, 14)
        Me.optSortByItemCode.Name = "optSortByItemCode"
        Me.optSortByItemCode.Size = New System.Drawing.Size(72, 17)
        Me.optSortByItemCode.TabIndex = 0
        Me.optSortByItemCode.TabStop = True
        Me.optSortByItemCode.Text = "Item code"
        Me.optSortByItemCode.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox2.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox2.Location = New System.Drawing.Point(397, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 40)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other Filter"
        Me.GroupBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SubInven"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "W/H"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(49, 14)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(71, 21)
        Me.cbomtl_warehouse.TabIndex = 1
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(185, 14)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(82, 21)
        Me.cbomtl_subinventory.TabIndex = 0
        '
        'crvYarnUsed
        '
        Me.crvYarnUsed.ActiveViewIndex = -1
        Me.crvYarnUsed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvYarnUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvYarnUsed.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvYarnUsed.Location = New System.Drawing.Point(8, 45)
        Me.crvYarnUsed.Name = "crvYarnUsed"
        Me.crvYarnUsed.SelectionFormula = ""
        Me.crvYarnUsed.ShowCloseButton = False
        Me.crvYarnUsed.ShowGroupTreeButton = False
        Me.crvYarnUsed.ShowRefreshButton = False
        Me.crvYarnUsed.Size = New System.Drawing.Size(663, 422)
        Me.crvYarnUsed.TabIndex = 7
        Me.crvYarnUsed.ViewTimeSelectionFormula = ""
        '
        'FormRptYarnUsedByMonth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpPrint)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.crvYarnUsed)
        Me.Name = "FormRptYarnUsedByMonth"
        Me.Text = "Yarn Used Report By Month"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpPrint As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optSortByItemDesc As System.Windows.Forms.RadioButton
    Friend WithEvents optSortByItemCode As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents crvYarnUsed As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
