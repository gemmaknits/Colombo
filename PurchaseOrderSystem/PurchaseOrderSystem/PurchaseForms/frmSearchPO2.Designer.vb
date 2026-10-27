<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPO2
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBOSupplier1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgPO = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPONo = New System.Windows.Forms.TextBox()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(416, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 23)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Show"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(215, 43)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 12
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(87, 43)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "From Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Supplier:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtPONo)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CBOSupplier1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 77)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'CBOSupplier1
        '
        Me.CBOSupplier1.FormattingEnabled = True
        Me.CBOSupplier1.Location = New System.Drawing.Point(87, 19)
        Me.CBOSupplier1.Name = "CBOSupplier1"
        Me.CBOSupplier1.Size = New System.Drawing.Size(312, 21)
        Me.CBOSupplier1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgPO
        '
        Me.dgPO.AllowUserToAddRows = False
        Me.dgPO.AllowUserToDeleteRows = False
        Me.dgPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colPono, Me.colSupp})
        Me.dgPO.Location = New System.Drawing.Point(30, 88)
        Me.dgPO.Name = "dgPO"
        Me.dgPO.ReadOnly = True
        Me.dgPO.Size = New System.Drawing.Size(605, 270)
        Me.dgPO.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "D/F No."
        '
        'txtPONo
        '
        Me.txtPONo.Location = New System.Drawing.Point(498, 16)
        Me.txtPONo.Name = "txtPONo"
        Me.txtPONo.Size = New System.Drawing.Size(88, 20)
        Me.txtPONo.TabIndex = 18
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "jobdt"
        Me.colDate.HeaderText = "P/o date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colPono
        '
        Me.colPono.DataPropertyName = "jobno"
        Me.colPono.HeaderText = "P/o no."
        Me.colPono.Name = "colPono"
        Me.colPono.ReadOnly = True
        '
        'colSupp
        '
        Me.colSupp.DataPropertyName = "supname"
        Me.colSupp.HeaderText = "Supplier"
        Me.colSupp.Name = "colSupp"
        Me.colSupp.ReadOnly = True
        Me.colSupp.Width = 350
        '
        'frmSearchPO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 393)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgPO)
        Me.Name = "frmSearchPO2"
        Me.Text = "Search purchase order"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgPO,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBOSupplier1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgPO As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPONo As System.Windows.Forms.TextBox
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSupp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
