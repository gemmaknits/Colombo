<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchSOCustItem
    Inherits Classes.formSearch
    'Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustItemNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtOurItemNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdCustomer_Item = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSerch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customer_design = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dm_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_article = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useable_width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grams_per_sqm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_items_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_items_xref_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bsSearchTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdCustomer_Item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(611, 425)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(510, 425)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CordiaUPC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CUSTOMER   DESIGN"
        '
        'txtCustItemNumber
        '
        Me.txtCustItemNumber.Location = New System.Drawing.Point(189, 20)
        Me.txtCustItemNumber.Name = "txtCustItemNumber"
        Me.txtCustItemNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtCustItemNumber.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CordiaUPC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 26)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CUSTOMER    NAME"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(189, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(53, 20)
        Me.txtCustomerID.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 44)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(248, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(403, 20)
        Me.txtCustomerName.TabIndex = 29
        '
        'txtOurItemNumber
        '
        Me.txtOurItemNumber.Location = New System.Drawing.Point(189, 46)
        Me.txtOurItemNumber.Name = "txtOurItemNumber"
        Me.txtOurItemNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtOurItemNumber.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdCustomer_Item)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(789, 282)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'grdCustomer_Item
        '
        Me.grdCustomer_Item.AllowUserToAddRows = False
        Me.grdCustomer_Item.AllowUserToDeleteRows = False
        Me.grdCustomer_Item.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCustomer_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomer_Item.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_design, Me.dm_design_no, Me.customer_article, Me.full_width, Me.useable_width, Me.grams_per_sqm, Me.customer_items_id, Me.customer_items_xref_id})
        Me.grdCustomer_Item.Location = New System.Drawing.Point(15, 19)
        Me.grdCustomer_Item.Name = "grdCustomer_Item"
        Me.grdCustomer_Item.ReadOnly = True
        Me.grdCustomer_Item.Size = New System.Drawing.Size(760, 252)
        Me.grdCustomer_Item.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSerch)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtOurItemNumber)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtCustItemNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 72)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conditions"
        '
        'btnSerch
        '
        Me.btnSerch.Location = New System.Drawing.Point(360, 20)
        Me.btnSerch.Name = "btnSerch"
        Me.btnSerch.Size = New System.Drawing.Size(78, 27)
        Me.btnSerch.TabIndex = 32
        Me.btnSerch.Text = "Search"
        Me.btnSerch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("CordiaUPC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 26)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "OUR   DESIGN"
        '
        'customer_design
        '
        Me.customer_design.DataPropertyName = "customer_design"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.customer_design.DefaultCellStyle = DataGridViewCellStyle1
        Me.customer_design.HeaderText = "CUSTOMER DESIGN"
        Me.customer_design.Name = "customer_design"
        Me.customer_design.ReadOnly = True
        Me.customer_design.Width = 120
        '
        'dm_design_no
        '
        Me.dm_design_no.DataPropertyName = "dm_design_no"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dm_design_no.DefaultCellStyle = DataGridViewCellStyle2
        Me.dm_design_no.HeaderText = "OUR DESIGN"
        Me.dm_design_no.Name = "dm_design_no"
        Me.dm_design_no.ReadOnly = True
        Me.dm_design_no.Width = 120
        '
        'customer_article
        '
        Me.customer_article.DataPropertyName = "refdesno"
        Me.customer_article.HeaderText = "Article"
        Me.customer_article.Name = "customer_article"
        Me.customer_article.ReadOnly = True
        Me.customer_article.Width = 150
        '
        'full_width
        '
        Me.full_width.DataPropertyName = "full_width"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.full_width.DefaultCellStyle = DataGridViewCellStyle3
        Me.full_width.HeaderText = "FULL WIDTH"
        Me.full_width.Name = "full_width"
        Me.full_width.ReadOnly = True
        '
        'useable_width
        '
        Me.useable_width.DataPropertyName = "useable_width"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.useable_width.DefaultCellStyle = DataGridViewCellStyle4
        Me.useable_width.HeaderText = "USEABLE WIDTH"
        Me.useable_width.Name = "useable_width"
        Me.useable_width.ReadOnly = True
        '
        'grams_per_sqm
        '
        Me.grams_per_sqm.DataPropertyName = "grams_per_sqm"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.grams_per_sqm.DefaultCellStyle = DataGridViewCellStyle5
        Me.grams_per_sqm.HeaderText = "GM/SQ.M"
        Me.grams_per_sqm.Name = "grams_per_sqm"
        Me.grams_per_sqm.ReadOnly = True
        '
        'customer_items_id
        '
        Me.customer_items_id.DataPropertyName = "mtl_customer_items_id"
        Me.customer_items_id.HeaderText = "CUSTOMER ITEMS ID"
        Me.customer_items_id.Name = "customer_items_id"
        Me.customer_items_id.ReadOnly = True
        '
        'customer_items_xref_id
        '
        Me.customer_items_xref_id.DataPropertyName = "mtl_customer_items_xref_id"
        Me.customer_items_xref_id.HeaderText = "CUSTOMER ITEMS XREF ID"
        Me.customer_items_xref_id.Name = "customer_items_xref_id"
        Me.customer_items_xref_id.ReadOnly = True
        '
        'frmSearchSOCustItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchSOCustItem"
        Me.Text = "Customer Item"
        Me.Controls.SetChildIndex(Me.btnOK, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        CType(Me.bsSearchTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdCustomer_Item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustItemNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtOurItemNumber As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdCustomer_Item As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSerch As Button
    Friend WithEvents customer_design As DataGridViewTextBoxColumn
    Friend WithEvents dm_design_no As DataGridViewTextBoxColumn
    Friend WithEvents customer_article As DataGridViewTextBoxColumn
    Friend WithEvents full_width As DataGridViewTextBoxColumn
    Friend WithEvents useable_width As DataGridViewTextBoxColumn
    Friend WithEvents grams_per_sqm As DataGridViewTextBoxColumn
    Friend WithEvents customer_items_id As DataGridViewTextBoxColumn
    Friend WithEvents customer_items_xref_id As DataGridViewTextBoxColumn
End Class
