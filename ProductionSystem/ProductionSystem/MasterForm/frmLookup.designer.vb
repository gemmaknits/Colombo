<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLookup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLookup))
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.cboLookup_type = New System.Windows.Forms.ComboBox()
        Me.grdlookup_value = New System.Windows.Forms.DataGridView()
        Me.btnNewLookup = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.lookup_value_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lookup_value_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lookup_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboLookupValueByType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.grdlookup_value, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(18, 46)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(56, 13)
        Me.lblProperty.TabIndex = 48
        Me.lblProperty.Text = "Property :"
        '
        'cboLookup_type
        '
        Me.cboLookup_type.DisplayMember = "lookup_id"
        Me.cboLookup_type.FormattingEnabled = True
        Me.cboLookup_type.Location = New System.Drawing.Point(76, 44)
        Me.cboLookup_type.Name = "cboLookup_type"
        Me.cboLookup_type.Size = New System.Drawing.Size(261, 21)
        Me.cboLookup_type.TabIndex = 46
        Me.cboLookup_type.ValueMember = "lookup_id"
        '
        'grdlookup_value
        '
        Me.grdlookup_value.AllowUserToAddRows = False
        Me.grdlookup_value.AllowUserToDeleteRows = False
        Me.grdlookup_value.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdlookup_value.ColumnHeadersHeight = 40
        Me.grdlookup_value.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lookup_value_id, Me.active, Me.lookup_value_code, Me.lookup_value, Me.cboLookupValueByType})
        Me.grdlookup_value.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.grdlookup_value.Location = New System.Drawing.Point(12, 124)
        Me.grdlookup_value.Name = "grdlookup_value"
        Me.grdlookup_value.Size = New System.Drawing.Size(659, 406)
        Me.grdlookup_value.TabIndex = 50
        '
        'btnNewLookup
        '
        Me.btnNewLookup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewLookup.Location = New System.Drawing.Point(578, 543)
        Me.btnNewLookup.Name = "btnNewLookup"
        Me.btnNewLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnNewLookup.TabIndex = 458
        Me.btnNewLookup.Text = "New LookUp"
        Me.btnNewLookup.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 25)
        Me.ToolStrip1.TabIndex = 460
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
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
        Me.btnExit.Text = "Exit"
        '
        'BtnAdd
        '
        'Me.BtnAdd.Image = Global.ProductionSystem.My.Resources.Resources.AddQuery_16x
        Me.BtnAdd.Location = New System.Drawing.Point(21, 80)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 461
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "lookup_value_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "lookup_value_code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lookup_value"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 50
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "parent_lookup_value_id"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewComboBoxColumn1.HeaderText = "Application"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 240
        '
        'lookup_value_id
        '
        Me.lookup_value_id.DataPropertyName = "lookup_value_id"
        Me.lookup_value_id.HeaderText = "#"
        Me.lookup_value_id.Name = "lookup_value_id"
        Me.lookup_value_id.ReadOnly = True
        Me.lookup_value_id.Visible = False
        Me.lookup_value_id.Width = 40
        '
        'active
        '
        Me.active.DataPropertyName = "active"
        Me.active.HeaderText = "Active"
        Me.active.Name = "active"
        Me.active.Width = 40
        '
        'lookup_value_code
        '
        Me.lookup_value_code.DataPropertyName = "lookup_value_code"
        Me.lookup_value_code.HeaderText = "Code"
        Me.lookup_value_code.MaxInputLength = 20
        Me.lookup_value_code.Name = "lookup_value_code"
        Me.lookup_value_code.Width = 120
        '
        'lookup_value
        '
        Me.lookup_value.DataPropertyName = "lookup_value"
        Me.lookup_value.HeaderText = "Name"
        Me.lookup_value.MaxInputLength = 50
        Me.lookup_value.Name = "lookup_value"
        Me.lookup_value.Width = 180
        '
        'cboLookupValueByType
        '
        Me.cboLookupValueByType.DataPropertyName = "parent_lookup_value_id"
        Me.cboLookupValueByType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboLookupValueByType.HeaderText = "Application"
        Me.cboLookupValueByType.Name = "cboLookupValueByType"
        Me.cboLookupValueByType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboLookupValueByType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboLookupValueByType.Width = 240
        '
        'frmLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 578)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnNewLookup)
        Me.Controls.Add(Me.grdlookup_value)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.cboLookup_type)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLookup"
        Me.Text = "Lookup Master"
        CType(Me.grdlookup_value, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProperty As System.Windows.Forms.Label
    Friend WithEvents cboLookup_type As System.Windows.Forms.ComboBox
    Friend WithEvents grdlookup_value As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewLookup As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAdd As Button
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents lookup_value_id As DataGridViewTextBoxColumn
    Friend WithEvents active As DataGridViewCheckBoxColumn
    Friend WithEvents lookup_value_code As DataGridViewTextBoxColumn
    Friend WithEvents lookup_value As DataGridViewTextBoxColumn
    Friend WithEvents cboLookupValueByType As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
End Class
