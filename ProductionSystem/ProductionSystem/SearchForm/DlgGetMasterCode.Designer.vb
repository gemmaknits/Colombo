<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgGetMasterCode
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.MasterCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterEDescp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterTDescp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchWording = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBeginFirstRecFind = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbFillterWhenKey = New System.Windows.Forms.RadioButton()
        Me.rbFillterWhenEnter = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdData)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 295)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MasterCode, Me.MasterEDescp, Me.MasterTDescp})
        Me.grdData.Location = New System.Drawing.Point(9, 16)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(657, 270)
        Me.grdData.TabIndex = 0
        '
        'MasterCode
        '
        Me.MasterCode.DataPropertyName = "MasterCode"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MasterCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.MasterCode.HeaderText = "Code"
        Me.MasterCode.Name = "MasterCode"
        Me.MasterCode.ReadOnly = True
        '
        'MasterEDescp
        '
        Me.MasterEDescp.DataPropertyName = "MasterEDescp"
        Me.MasterEDescp.HeaderText = "Description (E)"
        Me.MasterEDescp.Name = "MasterEDescp"
        Me.MasterEDescp.ReadOnly = True
        Me.MasterEDescp.Width = 250
        '
        'MasterTDescp
        '
        Me.MasterTDescp.DataPropertyName = "MasterTDescp"
        Me.MasterTDescp.HeaderText = "Description (T)"
        Me.MasterTDescp.Name = "MasterTDescp"
        Me.MasterTDescp.ReadOnly = True
        Me.MasterTDescp.Width = 250
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(525, 384)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(602, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 22)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(92, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(94, 20)
        Me.txtSearch.TabIndex = 0
        '
        'lblSearchWording
        '
        Me.lblSearchWording.AutoSize = True
        Me.lblSearchWording.Location = New System.Drawing.Point(21, 22)
        Me.lblSearchWording.Name = "lblSearchWording"
        Me.lblSearchWording.Size = New System.Drawing.Size(47, 13)
        Me.lblSearchWording.TabIndex = 1
        Me.lblSearchWording.Text = "Wording"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBeginFirstRecFind)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblSearchWording)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 62)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search (ค้าหาคำ ในกลุ่มของข้อมูลที่กรองแล้ว)"
        '
        'btnBeginFirstRecFind
        '
        Me.btnBeginFirstRecFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBeginFirstRecFind.Location = New System.Drawing.Point(203, 16)
        Me.btnBeginFirstRecFind.Name = "btnBeginFirstRecFind"
        Me.btnBeginFirstRecFind.Size = New System.Drawing.Size(94, 36)
        Me.btnBeginFirstRecFind.TabIndex = 4
        Me.btnBeginFirstRecFind.Text = "เริ่มค้นหา จากรายการแรก"
        Me.btnBeginFirstRecFind.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDescription)
        Me.GroupBox3.Controls.Add(Me.rbFillterWhenKey)
        Me.GroupBox3.Controls.Add(Me.rbFillterWhenEnter)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtWordFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 67)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter (กรองข้อมูล)"
        '
        'rbFillterWhenKey
        '
        Me.rbFillterWhenKey.AutoSize = True
        Me.rbFillterWhenKey.Checked = True
        Me.rbFillterWhenKey.Location = New System.Drawing.Point(239, 35)
        Me.rbFillterWhenKey.Name = "rbFillterWhenKey"
        Me.rbFillterWhenKey.Size = New System.Drawing.Size(115, 17)
        Me.rbFillterWhenKey.TabIndex = 4
        Me.rbFillterWhenKey.TabStop = True
        Me.rbFillterWhenKey.Text = "มีผลตอน ป้อนข้อมูล"
        Me.rbFillterWhenKey.UseVisualStyleBackColor = True
        '
        'rbFillterWhenEnter
        '
        Me.rbFillterWhenEnter.AutoSize = True
        Me.rbFillterWhenEnter.Location = New System.Drawing.Point(239, 16)
        Me.rbFillterWhenEnter.Name = "rbFillterWhenEnter"
        Me.rbFillterWhenEnter.Size = New System.Drawing.Size(94, 17)
        Me.rbFillterWhenEnter.TabIndex = 3
        Me.rbFillterWhenEnter.Text = "มีผลตอน Enter"
        Me.rbFillterWhenEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Code"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(100, 18)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(115, 20)
        Me.txtWordFilter.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(100, 42)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(115, 20)
        Me.txtDescription.TabIndex = 5
        '
        'DlgGetMasterCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 416)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgGetMasterCode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Get Master Code"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdData As DataGridView
    Friend WithEvents MasterCode As DataGridViewTextBoxColumn
    Friend WithEvents MasterEDescp As DataGridViewTextBoxColumn
    Friend WithEvents MasterTDescp As DataGridViewTextBoxColumn
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchWording As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBeginFirstRecFind As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbFillterWhenKey As RadioButton
    Friend WithEvents rbFillterWhenEnter As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
End Class
