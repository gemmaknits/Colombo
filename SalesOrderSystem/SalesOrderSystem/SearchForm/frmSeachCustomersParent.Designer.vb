<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeachCustomersParent
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GrdData = New System.Windows.Forms.DataGridView()
        Me.ColParentCustomerFlag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GrdDataCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataCustcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataAddr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataNamet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrdDataAddrt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 54)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(259, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(34, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 22)
        Me.txtSearch.TabIndex = 0
        '
        'GrdData
        '
        Me.GrdData.AllowUserToAddRows = False
        Me.GrdData.AllowUserToDeleteRows = False
        Me.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColParentCustomerFlag, Me.GrdDataCustomerID, Me.GrdDataCustcd, Me.GrdDataName, Me.GrdDataAddr1, Me.GrdDataNamet, Me.GrdDataAddrt1})
        Me.GrdData.Location = New System.Drawing.Point(46, 84)
        Me.GrdData.Name = "GrdData"
        Me.GrdData.RowHeadersVisible = False
        Me.GrdData.Size = New System.Drawing.Size(948, 326)
        Me.GrdData.TabIndex = 5
        '
        'ColParentCustomerFlag
        '
        Me.ColParentCustomerFlag.DataPropertyName = "parent_customer_flag"
        Me.ColParentCustomerFlag.HeaderText = "Parent Cust. Flag"
        Me.ColParentCustomerFlag.Name = "ColParentCustomerFlag"
        Me.ColParentCustomerFlag.ReadOnly = True
        Me.ColParentCustomerFlag.Width = 50
        '
        'GrdDataCustomerID
        '
        Me.GrdDataCustomerID.DataPropertyName = "customer_id"
        Me.GrdDataCustomerID.HeaderText = "ID"
        Me.GrdDataCustomerID.Name = "GrdDataCustomerID"
        Me.GrdDataCustomerID.ReadOnly = True
        Me.GrdDataCustomerID.Visible = False
        Me.GrdDataCustomerID.Width = 50
        '
        'GrdDataCustcd
        '
        Me.GrdDataCustcd.DataPropertyName = "custcd"
        Me.GrdDataCustcd.HeaderText = "Code"
        Me.GrdDataCustcd.Name = "GrdDataCustcd"
        Me.GrdDataCustcd.ReadOnly = True
        Me.GrdDataCustcd.Width = 60
        '
        'GrdDataName
        '
        Me.GrdDataName.DataPropertyName = "name"
        Me.GrdDataName.HeaderText = "Name (EN)"
        Me.GrdDataName.Name = "GrdDataName"
        Me.GrdDataName.ReadOnly = True
        Me.GrdDataName.Width = 200
        '
        'GrdDataAddr1
        '
        Me.GrdDataAddr1.DataPropertyName = "addr1"
        Me.GrdDataAddr1.HeaderText = "Address (EN) Line 1"
        Me.GrdDataAddr1.Name = "GrdDataAddr1"
        Me.GrdDataAddr1.ReadOnly = True
        Me.GrdDataAddr1.Width = 200
        '
        'GrdDataNamet
        '
        Me.GrdDataNamet.DataPropertyName = "namet"
        Me.GrdDataNamet.HeaderText = "Name (TH)"
        Me.GrdDataNamet.Name = "GrdDataNamet"
        Me.GrdDataNamet.ReadOnly = True
        Me.GrdDataNamet.Width = 200
        '
        'GrdDataAddrt1
        '
        Me.GrdDataAddrt1.DataPropertyName = "addr1t"
        Me.GrdDataAddrt1.HeaderText = "Address (TH) Line 1"
        Me.GrdDataAddrt1.Name = "GrdDataAddrt1"
        Me.GrdDataAddrt1.ReadOnly = True
        Me.GrdDataAddrt1.Width = 200
        '
        'btnExit
        '
        Me.btnExit.Image = Global.SalesOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnExit.Location = New System.Drawing.Point(919, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Image = Global.SalesOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnOk.Location = New System.Drawing.Point(838, 416)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 41)
        Me.btnOk.TabIndex = 60
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmSeachCustomersParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 469)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrdData)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeachCustomersParent"
        Me.Text = "Seach Customers Parent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GrdData As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents ColParentCustomerFlag As DataGridViewCheckBoxColumn
    Friend WithEvents GrdDataCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataCustcd As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataName As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataAddr1 As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataNamet As DataGridViewTextBoxColumn
    Friend WithEvents GrdDataAddrt1 As DataGridViewTextBoxColumn
End Class
