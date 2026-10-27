<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrdDataNamet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GrdDataAddrt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataAddr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GrdData = New System.Windows.Forms.DataGridView()
        Me.GrdDataCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataCustcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdDataNamet
        '
        Me.GrdDataNamet.DataPropertyName = "namet"
        Me.GrdDataNamet.HeaderText = "Name (Thai)"
        Me.GrdDataNamet.Name = "GrdDataNamet"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(29, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 22)
        Me.txtSearch.TabIndex = 0
        '
        'GrdDataAddrt1
        '
        Me.GrdDataAddrt1.DataPropertyName = "addrt1"
        Me.GrdDataAddrt1.HeaderText = "Address (TH) Line 1"
        Me.GrdDataAddrt1.Name = "GrdDataAddrt1"
        '
        'GrdDataAddr1
        '
        Me.GrdDataAddr1.DataPropertyName = "addr1"
        Me.GrdDataAddr1.HeaderText = "Address (EN) Line 1"
        Me.GrdDataAddr1.Name = "GrdDataAddr1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 50)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(276, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GrdData
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GrdDataCustomerID, Me.GrdDataCustcd, Me.GrdDataName, Me.GrdDataAddr1, Me.GrdDataNamet, Me.GrdDataAddrt1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdData.DefaultCellStyle = DataGridViewCellStyle2
        Me.GrdData.Location = New System.Drawing.Point(12, 74)
        Me.GrdData.Name = "GrdData"
        Me.GrdData.Size = New System.Drawing.Size(594, 329)
        Me.GrdData.TabIndex = 3
        '
        'GrdDataCustomerID
        '
        Me.GrdDataCustomerID.DataPropertyName = "customer_id"
        Me.GrdDataCustomerID.HeaderText = "ID"
        Me.GrdDataCustomerID.Name = "GrdDataCustomerID"
        Me.GrdDataCustomerID.Width = 50
        '
        'GrdDataCustcd
        '
        Me.GrdDataCustcd.DataPropertyName = "custcd"
        Me.GrdDataCustcd.HeaderText = "Code"
        Me.GrdDataCustcd.Name = "GrdDataCustcd"
        '
        'GrdDataName
        '
        Me.GrdDataName.DataPropertyName = "name"
        Me.GrdDataName.HeaderText = "Name"
        Me.GrdDataName.Name = "GrdDataName"
        '
        'frmSearchCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 417)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrdData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Customers Parent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrdDataNamet As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GrdDataAddrt1 As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataAddr1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GrdData As DataGridView
    Friend WithEvents GrdDataCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataCustcd As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataName As DataGridViewTextBoxColumn
End Class
