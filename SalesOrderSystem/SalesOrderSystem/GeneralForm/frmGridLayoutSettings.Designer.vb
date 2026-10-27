<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridLayoutSettings
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
        Me.dgvGridLayoutSettings = New System.Windows.Forms.DataGridView()
        Me.lblGridName = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVisible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvGridLayoutSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGridLayoutSettings
        '
        Me.dgvGridLayoutSettings.AllowUserToAddRows = False
        Me.dgvGridLayoutSettings.AllowUserToDeleteRows = False
        Me.dgvGridLayoutSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGridLayoutSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridLayoutSettings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.colColumnName, Me.Column2, Me.colVisible})
        Me.dgvGridLayoutSettings.Location = New System.Drawing.Point(12, 34)
        Me.dgvGridLayoutSettings.Name = "dgvGridLayoutSettings"
        Me.dgvGridLayoutSettings.RowHeadersVisible = False
        Me.dgvGridLayoutSettings.Size = New System.Drawing.Size(321, 437)
        Me.dgvGridLayoutSettings.TabIndex = 0
        '
        'lblGridName
        '
        Me.lblGridName.AutoSize = True
        Me.lblGridName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGridName.Location = New System.Drawing.Point(12, 13)
        Me.lblGridName.Name = "lblGridName"
        Me.lblGridName.Size = New System.Drawing.Size(66, 13)
        Me.lblGridName.TabIndex = 1
        Me.lblGridName.Text = "Grid Name"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(258, 477)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "user_grid_settings_id"
        Me.Column1.HeaderText = "User Grid Settings ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "col_data_property"
        Me.Column3.HeaderText = "Column Data Property"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'colColumnName
        '
        Me.colColumnName.DataPropertyName = "column_name"
        Me.colColumnName.HeaderText = "Column"
        Me.colColumnName.Name = "colColumnName"
        Me.colColumnName.Width = 200
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "col_width"
        Me.Column2.HeaderText = "Width"
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'colVisible
        '
        Me.colVisible.DataPropertyName = "col_visible"
        Me.colVisible.HeaderText = "Visible"
        Me.colVisible.Name = "colVisible"
        Me.colVisible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colVisible.Width = 50
        '
        'frmGridLayoutSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 506)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblGridName)
        Me.Controls.Add(Me.dgvGridLayoutSettings)
        Me.Name = "frmGridLayoutSettings"
        Me.Text = "Grid Layout Settings"
        CType(Me.dgvGridLayoutSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGridLayoutSettings As DataGridView
    Friend WithEvents lblGridName As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents colColumnName As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colVisible As DataGridViewCheckBoxColumn
End Class
