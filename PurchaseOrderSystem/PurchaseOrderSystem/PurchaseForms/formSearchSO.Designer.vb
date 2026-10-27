<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchSO
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
		Me.dgSO = New System.Windows.Forms.DataGridView
		Me.Button1 = New System.Windows.Forms.Button
		Me.Button2 = New System.Windows.Forms.Button
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.btnSearch = New System.Windows.Forms.Button
		Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
		Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
        'Me.ComboSupplier1 = New myControls.comboSupplier
        Me.ComboSupplier1 = New ComboBox()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colSono = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colCust = New System.Windows.Forms.DataGridViewTextBoxColumn
		CType(Me.dgSO, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgSO
		'
		Me.dgSO.AllowUserToAddRows = False
		Me.dgSO.AllowUserToDeleteRows = False
		Me.dgSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgSO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colSono, Me.colCust})
		Me.dgSO.Location = New System.Drawing.Point(12, 96)
		Me.dgSO.Name = "dgSO"
		Me.dgSO.ReadOnly = True
		Me.dgSO.Size = New System.Drawing.Size(605, 270)
		Me.dgSO.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(427, 372)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(90, 23)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Ok"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(523, 372)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(94, 23)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Exit"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnSearch)
		Me.GroupBox1.Controls.Add(Me.dtpDateTo)
		Me.GroupBox1.Controls.Add(Me.dtpDateFr)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.ComboSupplier1)
		Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(604, 77)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Filter"
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(517, 47)
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
		Me.Label1.Size = New System.Drawing.Size(54, 13)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Customer:"
		'
		'ComboSupplier1
		'
		Me.ComboSupplier1.FormattingEnabled = True
		Me.ComboSupplier1.Location = New System.Drawing.Point(87, 19)
		Me.ComboSupplier1.Name = "ComboSupplier1"
		Me.ComboSupplier1.Size = New System.Drawing.Size(312, 21)
		Me.ComboSupplier1.TabIndex = 9
		'
		'colDate
		'
		Me.colDate.DataPropertyName = "sodt"
		Me.colDate.HeaderText = "S/o date"
		Me.colDate.Name = "colDate"
		Me.colDate.ReadOnly = True
		'
		'colSono
		'
		Me.colSono.DataPropertyName = "sono"
		Me.colSono.HeaderText = "S/o no."
		Me.colSono.Name = "colSono"
		Me.colSono.ReadOnly = True
		'
		'colCust
		'
		Me.colCust.DataPropertyName = "cust"
		Me.colCust.HeaderText = "Customer"
		Me.colCust.Name = "colCust"
		Me.colCust.ReadOnly = True
		Me.colCust.Width = 350
		'
		'formSearchSO
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(674, 403)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.dgSO)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "formSearchSO"
		Me.Text = "Search Sales Order"
		CType(Me.dgSO, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents dgSO As System.Windows.Forms.DataGridView
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents btnSearch As System.Windows.Forms.Button
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents ComboSupplier1 As myControls.comboSupplier
    Friend WithEvents ComboSupplier1 As System.Windows.Forms.ComboBox
	Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents colSono As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents colCust As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
