<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchYarnOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSearchYarnOut))
        Me.btnSearch = New System.Windows.Forms.Button
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgYarn = New System.Windows.Forms.DataGridView
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDocno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTranType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKono = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(294, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Refresh"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(200, 13)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 2
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(72, 13)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "From Date"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(436, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(436, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgYarn
        '
        Me.dgYarn.AllowUserToAddRows = False
        Me.dgYarn.AllowUserToDeleteRows = False
        Me.dgYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colDocno, Me.colTranType, Me.colKono})
        Me.dgYarn.Location = New System.Drawing.Point(8, 41)
        Me.dgYarn.Name = "dgYarn"
        Me.dgYarn.ReadOnly = True
        Me.dgYarn.Size = New System.Drawing.Size(408, 437)
        Me.dgYarn.TabIndex = 4
        '
        'colDate
        '
        Me.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDate.DataPropertyName = "outdt"
        Me.colDate.HeaderText = "Y-OUT Doc. Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 87
        '
        'colDocno
        '
        Me.colDocno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDocno.DataPropertyName = "outno"
        Me.colDocno.HeaderText = "Y-OUT Doc No."
        Me.colDocno.Name = "colDocno"
        Me.colDocno.ReadOnly = True
        Me.colDocno.Width = 84
        '
        'colTranType
        '
        Me.colTranType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTranType.DataPropertyName = "tran_type"
        Me.colTranType.HeaderText = "Y-Out type"
        Me.colTranType.Name = "colTranType"
        Me.colTranType.ReadOnly = True
        Me.colTranType.Width = 76
        '
        'colKono
        '
        Me.colKono.DataPropertyName = "kono"
        Me.colKono.HeaderText = "K/I no."
        Me.colKono.Name = "colKono"
        Me.colKono.ReadOnly = True
        '
        'formSearchYarnOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 501)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgYarn)
        Me.Name = "formSearchYarnOut"
        Me.Text = "Yarn Search"
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents btnSearch As System.Windows.Forms.Button
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgYarn As System.Windows.Forms.DataGridView
    Friend WithEvents colDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTranType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
