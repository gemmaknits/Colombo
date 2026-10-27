<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchYarnCode
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
        Me.colItemcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItDesc3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.colItDesc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colItdesc_spec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgYarn = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colItemcd
        '
        Me.colItemcd.DataPropertyName = "itcd"
        Me.colItemcd.HeaderText = "Item code"
        Me.colItemcd.Name = "colItemcd"
        Me.colItemcd.ReadOnly = True
        '
        'colItDesc3
        '
        Me.colItDesc3.DataPropertyName = "itdesc3"
        Me.colItDesc3.HeaderText = "Description 3"
        Me.colItDesc3.Name = "colItDesc3"
        Me.colItDesc3.ReadOnly = True
        Me.colItDesc3.Width = 200
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "itdesc"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Sub group:"
        '
        'colItDesc2
        '
        Me.colItDesc2.DataPropertyName = "itdesc2"
        Me.colItDesc2.HeaderText = "Description 2"
        Me.colItDesc2.Name = "colItDesc2"
        Me.colItDesc2.ReadOnly = True
        Me.colItDesc2.Width = 200
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Group:"
        '
        'colItdesc_spec
        '
        Me.colItdesc_spec.DataPropertyName = "itdesc_spec"
        Me.colItdesc_spec.HeaderText = "Description for spec."
        Me.colItdesc_spec.Name = "colItdesc_spec"
        Me.colItdesc_spec.ReadOnly = True
        Me.colItdesc_spec.Width = 200
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(284, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Show"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(520, 345)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgYarn
        '
        Me.dgYarn.AllowUserToAddRows = False
        Me.dgYarn.AllowUserToDeleteRows = False
        Me.dgYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemcd, Me.colDesc, Me.colItDesc2, Me.colItDesc3, Me.colItdesc_spec})
        Me.dgYarn.Location = New System.Drawing.Point(8, 90)
        Me.dgYarn.Name = "dgYarn"
        Me.dgYarn.ReadOnly = True
        Me.dgYarn.Size = New System.Drawing.Size(616, 245)
        Me.dgYarn.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nature:"
        '
        'formSearchYarnCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 377)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgYarn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formSearchYarnCode"
        Me.Text = "Search Yarn Master"
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colItemcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItDesc3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colItDesc2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colItdesc_spec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgYarn As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
