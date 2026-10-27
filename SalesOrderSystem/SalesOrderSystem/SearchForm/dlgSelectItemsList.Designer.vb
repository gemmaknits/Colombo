<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSearchItemsList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.statusUser = New System.Windows.Forms.StatusStrip()
        Me.ClmnSelected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClmnDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmnRefdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmnCompo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmnFwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmnGwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(788, 507)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtWordFilter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.grdData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(919, 492)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Of Items"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(190, 23)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(189, 20)
        Me.txtWordFilter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filter Wording"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmnSelected, Me.ClmnDesignNo, Me.ClmnRefdesno, Me.ClmnCompo, Me.ClmnFwth, Me.ClmnGwth})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.Location = New System.Drawing.Point(17, 56)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdData.Size = New System.Drawing.Size(885, 430)
        Me.grdData.TabIndex = 0
        '
        'statusUser
        '
        Me.statusUser.Location = New System.Drawing.Point(0, 546)
        Me.statusUser.Name = "statusUser"
        Me.statusUser.Size = New System.Drawing.Size(946, 22)
        Me.statusUser.TabIndex = 2
        Me.statusUser.Text = "StatusStrip1"
        '
        'ClmnSelected
        '
        Me.ClmnSelected.DataPropertyName = "selected"
        Me.ClmnSelected.HeaderText = "Select"
        Me.ClmnSelected.Name = "ClmnSelected"
        Me.ClmnSelected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClmnSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ClmnSelected.Width = 50
        '
        'ClmnDesignNo
        '
        Me.ClmnDesignNo.DataPropertyName = "Design_no"
        Me.ClmnDesignNo.HeaderText = "Design No"
        Me.ClmnDesignNo.Name = "ClmnDesignNo"
        Me.ClmnDesignNo.Width = 110
        '
        'ClmnRefdesno
        '
        Me.ClmnRefdesno.DataPropertyName = "refdesno"
        Me.ClmnRefdesno.HeaderText = "Description"
        Me.ClmnRefdesno.Name = "ClmnRefdesno"
        Me.ClmnRefdesno.Width = 300
        '
        'ClmnCompo
        '
        Me.ClmnCompo.FillWeight = 150.0!
        Me.ClmnCompo.HeaderText = "Compo"
        Me.ClmnCompo.Name = "ClmnCompo"
        Me.ClmnCompo.Width = 200
        '
        'ClmnFwth
        '
        Me.ClmnFwth.DataPropertyName = "Fwth"
        Me.ClmnFwth.HeaderText = "Fwth"
        Me.ClmnFwth.Name = "ClmnFwth"
        Me.ClmnFwth.Width = 80
        '
        'ClmnGwth
        '
        Me.ClmnGwth.DataPropertyName = "Gwth"
        Me.ClmnGwth.HeaderText = "Gwth"
        Me.ClmnGwth.Name = "ClmnGwth"
        Me.ClmnGwth.Width = 80
        '
        'dlgSearchItemsList
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(946, 568)
        Me.Controls.Add(Me.statusUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSearchItemsList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Items List"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdData As DataGridView
    Friend WithEvents statusUser As StatusStrip
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ClmnSelected As DataGridViewCheckBoxColumn
    Friend WithEvents ClmnDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents ClmnRefdesno As DataGridViewTextBoxColumn
    Friend WithEvents ClmnCompo As DataGridViewTextBoxColumn
    Friend WithEvents ClmnFwth As DataGridViewTextBoxColumn
    Friend WithEvents ClmnGwth As DataGridViewTextBoxColumn
End Class
