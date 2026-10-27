<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSearchItemcode
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgYarn = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboItemNature = New System.Windows.Forms.ComboBox()
        Me.colItemcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItDesc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItDesc3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesct2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesct3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesc_spec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(284, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Show"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Exit_16x
        Me.Button2.Location = New System.Drawing.Point(1097, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.PurchaseOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.Button1.Location = New System.Drawing.Point(992, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ok"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgYarn
        '
        Me.dgYarn.AllowUserToAddRows = False
        Me.dgYarn.AllowUserToDeleteRows = False
        Me.dgYarn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgYarn.ColumnHeadersHeight = 30
        Me.dgYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemcd, Me.colDesc, Me.colItDesc2, Me.colItDesc3, Me.colItdesct, Me.colItdesct2, Me.colItdesct3, Me.colItdesc_spec})
        Me.dgYarn.Location = New System.Drawing.Point(8, 89)
        Me.dgYarn.Name = "dgYarn"
        Me.dgYarn.ReadOnly = True
        Me.dgYarn.Size = New System.Drawing.Size(1193, 373)
        Me.dgYarn.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nature:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Group:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Sub group:"
        '
        'comboItemNature
        '
        Me.comboItemNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemNature.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboItemNature.FormattingEnabled = True
        Me.comboItemNature.Location = New System.Drawing.Point(90, 5)
        Me.comboItemNature.Name = "comboItemNature"
        Me.comboItemNature.Size = New System.Drawing.Size(195, 21)
        Me.comboItemNature.TabIndex = 163
        '
        'colItemcd
        '
        Me.colItemcd.DataPropertyName = "itcd"
        Me.colItemcd.Frozen = True
        Me.colItemcd.HeaderText = "Item code"
        Me.colItemcd.Name = "colItemcd"
        Me.colItemcd.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "itdesc"
        Me.colDesc.HeaderText = "Description"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 150
        '
        'colItDesc2
        '
        Me.colItDesc2.DataPropertyName = "itdesc2"
        Me.colItDesc2.HeaderText = "Description 2"
        Me.colItDesc2.Name = "colItDesc2"
        Me.colItDesc2.ReadOnly = True
        Me.colItDesc2.Width = 150
        '
        'colItDesc3
        '
        Me.colItDesc3.DataPropertyName = "itdesc3"
        Me.colItDesc3.HeaderText = "Description 3"
        Me.colItDesc3.Name = "colItDesc3"
        Me.colItDesc3.ReadOnly = True
        Me.colItDesc3.Width = 150
        '
        'colItdesct
        '
        Me.colItdesct.DataPropertyName = "itdesct"
        Me.colItdesct.HeaderText = "Description Thai"
        Me.colItdesct.Name = "colItdesct"
        Me.colItdesct.ReadOnly = True
        Me.colItdesct.Width = 150
        '
        'colItdesct2
        '
        Me.colItdesct2.DataPropertyName = "itdesct2"
        Me.colItdesct2.HeaderText = "Description Thai 2"
        Me.colItdesct2.Name = "colItdesct2"
        Me.colItdesct2.ReadOnly = True
        Me.colItdesct2.Width = 150
        '
        'colItdesct3
        '
        Me.colItdesct3.DataPropertyName = "itdesct3"
        Me.colItdesct3.HeaderText = "Description Thai 3"
        Me.colItdesct3.Name = "colItdesct3"
        Me.colItdesct3.ReadOnly = True
        Me.colItdesct3.Width = 150
        '
        'colItdesc_spec
        '
        Me.colItdesc_spec.DataPropertyName = "itdesc_spec"
        Me.colItdesc_spec.HeaderText = "Description for spec."
        Me.colItdesc_spec.Name = "colItdesc_spec"
        Me.colItdesc_spec.ReadOnly = True
        Me.colItdesc_spec.Width = 150
        '
        'formSearchItemcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 501)
        Me.Controls.Add(Me.comboItemNature)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgYarn)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formSearchItemcode"
        Me.Text = "Search item master"
        CType(Me.dgYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgYarn As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboItemNature As System.Windows.Forms.ComboBox
    Friend WithEvents colItemcd As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colItDesc2 As DataGridViewTextBoxColumn
    Friend WithEvents colItDesc3 As DataGridViewTextBoxColumn
    Friend WithEvents colItdesct As DataGridViewTextBoxColumn
    Friend WithEvents colItdesct2 As DataGridViewTextBoxColumn
    Friend WithEvents colItdesct3 As DataGridViewTextBoxColumn
    Friend WithEvents colItdesc_spec As DataGridViewTextBoxColumn
End Class
