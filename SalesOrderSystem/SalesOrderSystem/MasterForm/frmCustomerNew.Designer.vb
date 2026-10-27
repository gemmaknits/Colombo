<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerNew
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerNew))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtTotalSite = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.btnAddParentOrSite = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdCustomers = New System.Windows.Forms.DataGridView()
        Me.ColParentCustomerFlag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Colshiptoflag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColbillToFlag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColCustcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAddr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coladdr2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coladdr3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnamet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAddr1t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coladdr2t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coladdr3t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colname2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coldistrict = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCtry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coltel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colfax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAgcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPayterms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVatregno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGroupName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMainProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColIDBanks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCustCD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnamet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 88
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
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtTotalSite
        '
        Me.txtTotalSite.Location = New System.Drawing.Point(97, 9)
        Me.txtTotalSite.Name = "txtTotalSite"
        Me.txtTotalSite.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalSite.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnDel)
        Me.TabPage1.Controls.Add(Me.btnAddParentOrSite)
        Me.TabPage1.Controls.Add(Me.BtnEdit)
        Me.TabPage1.Controls.Add(Me.txtTotalSite)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.grdCustomers)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 506)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Site"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDel.Image = Global.SalesOrderSystem.My.Resources.Resources.DeleteQuery_16x
        Me.BtnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDel.Location = New System.Drawing.Point(876, 10)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 23)
        Me.BtnDel.TabIndex = 77
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDel.UseVisualStyleBackColor = True
        Me.BtnDel.Visible = False
        '
        'btnAddParentOrSite
        '
        Me.btnAddParentOrSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddParentOrSite.Image = Global.SalesOrderSystem.My.Resources.Resources.AddQuery_16x
        Me.btnAddParentOrSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddParentOrSite.Location = New System.Drawing.Point(688, 10)
        Me.btnAddParentOrSite.Name = "btnAddParentOrSite"
        Me.btnAddParentOrSite.Size = New System.Drawing.Size(118, 23)
        Me.btnAddParentOrSite.TabIndex = 75
        Me.btnAddParentOrSite.Text = "Add Parent / Site"
        Me.btnAddParentOrSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddParentOrSite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddParentOrSite.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Image = Global.SalesOrderSystem.My.Resources.Resources.EditQuery_16x
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(812, 10)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(58, 23)
        Me.BtnEdit.TabIndex = 76
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Site"
        '
        'grdCustomers
        '
        Me.grdCustomers.AllowUserToAddRows = False
        Me.grdCustomers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColParentCustomerFlag, Me.Colshiptoflag, Me.ColbillToFlag, Me.active, Me.ColCustcd, Me.ColName, Me.ColAddr1, Me.coladdr2, Me.coladdr3, Me.colnamet, Me.ColAddr1t, Me.coladdr2t, Me.coladdr3t, Me.colname2, Me.Coldistrict, Me.ColCity, Me.ColCtry, Me.Coltel, Me.Colfax, Me.ColEmail, Me.colCredit, Me.ColContact, Me.ColAgcd, Me.ColPayterms, Me.ColVatregno, Me.ColGroupName, Me.ColMainProduct, Me.ColEdit, Me.ColIDBanks, Me.colBranchNum})
        Me.grdCustomers.Location = New System.Drawing.Point(17, 38)
        Me.grdCustomers.Name = "grdCustomers"
        Me.grdCustomers.RowHeadersVisible = False
        Me.grdCustomers.Size = New System.Drawing.Size(934, 462)
        Me.grdCustomers.TabIndex = 8
        '
        'ColParentCustomerFlag
        '
        Me.ColParentCustomerFlag.DataPropertyName = "parent_customer_flag"
        Me.ColParentCustomerFlag.HeaderText = "Parent Cust. Flag"
        Me.ColParentCustomerFlag.Name = "ColParentCustomerFlag"
        Me.ColParentCustomerFlag.ReadOnly = True
        Me.ColParentCustomerFlag.Width = 50
        '
        'Colshiptoflag
        '
        Me.Colshiptoflag.DataPropertyName = "ship_to_flag"
        Me.Colshiptoflag.FalseValue = ""
        Me.Colshiptoflag.HeaderText = "Ship To Flag"
        Me.Colshiptoflag.Name = "Colshiptoflag"
        Me.Colshiptoflag.ReadOnly = True
        Me.Colshiptoflag.TrueValue = ""
        Me.Colshiptoflag.Width = 50
        '
        'ColbillToFlag
        '
        Me.ColbillToFlag.DataPropertyName = "bill_to_flag"
        Me.ColbillToFlag.FalseValue = ""
        Me.ColbillToFlag.HeaderText = "Bill To Flag"
        Me.ColbillToFlag.Name = "ColbillToFlag"
        Me.ColbillToFlag.ReadOnly = True
        Me.ColbillToFlag.TrueValue = ""
        Me.ColbillToFlag.Width = 50
        '
        'active
        '
        Me.active.DataPropertyName = "active"
        Me.active.HeaderText = "Actived"
        Me.active.Name = "active"
        Me.active.ReadOnly = True
        Me.active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.active.Width = 50
        '
        'ColCustcd
        '
        Me.ColCustcd.DataPropertyName = "custcd"
        Me.ColCustcd.HeaderText = "Code"
        Me.ColCustcd.Name = "ColCustcd"
        Me.ColCustcd.ReadOnly = True
        Me.ColCustcd.Width = 50
        '
        'ColName
        '
        Me.ColName.DataPropertyName = "name"
        Me.ColName.HeaderText = "Name"
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        Me.ColName.Width = 160
        '
        'ColAddr1
        '
        Me.ColAddr1.DataPropertyName = "addr1"
        Me.ColAddr1.HeaderText = "Address (EN) 1"
        Me.ColAddr1.Name = "ColAddr1"
        Me.ColAddr1.ReadOnly = True
        Me.ColAddr1.Width = 150
        '
        'coladdr2
        '
        Me.coladdr2.DataPropertyName = "addr2"
        Me.coladdr2.HeaderText = "Address (EN) 2"
        Me.coladdr2.Name = "coladdr2"
        Me.coladdr2.Width = 50
        '
        'coladdr3
        '
        Me.coladdr3.DataPropertyName = "addr3"
        Me.coladdr3.HeaderText = "Address (EN) 3"
        Me.coladdr3.Name = "coladdr3"
        Me.coladdr3.Width = 50
        '
        'colnamet
        '
        Me.colnamet.DataPropertyName = "namet"
        Me.colnamet.HeaderText = "colnamet"
        Me.colnamet.Name = "colnamet"
        Me.colnamet.Visible = False
        '
        'ColAddr1t
        '
        Me.ColAddr1t.DataPropertyName = "addr1t"
        Me.ColAddr1t.HeaderText = "Address (TH) 1"
        Me.ColAddr1t.Name = "ColAddr1t"
        Me.ColAddr1t.ReadOnly = True
        Me.ColAddr1t.Width = 150
        '
        'coladdr2t
        '
        Me.coladdr2t.DataPropertyName = "addr2t"
        Me.coladdr2t.HeaderText = "Address (TH) 2"
        Me.coladdr2t.Name = "coladdr2t"
        Me.coladdr2t.Width = 50
        '
        'coladdr3t
        '
        Me.coladdr3t.DataPropertyName = "addr3t"
        Me.coladdr3t.HeaderText = "Address (TH) 3"
        Me.coladdr3t.Name = "coladdr3t"
        Me.coladdr3t.Width = 50
        '
        'colname2
        '
        Me.colname2.DataPropertyName = "name2"
        Me.colname2.HeaderText = "colname2"
        Me.colname2.Name = "colname2"
        Me.colname2.Visible = False
        '
        'Coldistrict
        '
        Me.Coldistrict.DataPropertyName = "district"
        Me.Coldistrict.HeaderText = "District"
        Me.Coldistrict.Name = "Coldistrict"
        Me.Coldistrict.Visible = False
        Me.Coldistrict.Width = 50
        '
        'ColCity
        '
        Me.ColCity.DataPropertyName = "city"
        Me.ColCity.HeaderText = "City"
        Me.ColCity.Name = "ColCity"
        Me.ColCity.ReadOnly = True
        Me.ColCity.Visible = False
        Me.ColCity.Width = 50
        '
        'ColCtry
        '
        Me.ColCtry.DataPropertyName = "ctry"
        Me.ColCtry.HeaderText = "Country"
        Me.ColCtry.Name = "ColCtry"
        Me.ColCtry.ReadOnly = True
        Me.ColCtry.Width = 50
        '
        'Coltel
        '
        Me.Coltel.DataPropertyName = "tel"
        Me.Coltel.HeaderText = "Tel"
        Me.Coltel.Name = "Coltel"
        Me.Coltel.ReadOnly = True
        Me.Coltel.Width = 80
        '
        'Colfax
        '
        Me.Colfax.DataPropertyName = "fax"
        Me.Colfax.HeaderText = "Fax"
        Me.Colfax.Name = "Colfax"
        Me.Colfax.ReadOnly = True
        Me.Colfax.Width = 80
        '
        'ColEmail
        '
        Me.ColEmail.DataPropertyName = "email"
        Me.ColEmail.HeaderText = "Email"
        Me.ColEmail.Name = "ColEmail"
        Me.ColEmail.ReadOnly = True
        '
        'colCredit
        '
        Me.colCredit.DataPropertyName = "Credit"
        Me.colCredit.HeaderText = "Credit Days"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.ReadOnly = True
        Me.colCredit.Width = 50
        '
        'ColContact
        '
        Me.ColContact.DataPropertyName = "contact"
        Me.ColContact.HeaderText = "Contact Person"
        Me.ColContact.Name = "ColContact"
        Me.ColContact.ReadOnly = True
        '
        'ColAgcd
        '
        Me.ColAgcd.DataPropertyName = "agcd"
        Me.ColAgcd.HeaderText = "Agentcy"
        Me.ColAgcd.Name = "ColAgcd"
        Me.ColAgcd.ReadOnly = True
        Me.ColAgcd.Width = 50
        '
        'ColPayterms
        '
        Me.ColPayterms.DataPropertyName = "payterms"
        Me.ColPayterms.HeaderText = "Payment Terms"
        Me.ColPayterms.Name = "ColPayterms"
        Me.ColPayterms.ReadOnly = True
        Me.ColPayterms.Width = 70
        '
        'ColVatregno
        '
        Me.ColVatregno.DataPropertyName = "vatregno"
        Me.ColVatregno.HeaderText = "Vat Reg No."
        Me.ColVatregno.Name = "ColVatregno"
        Me.ColVatregno.ReadOnly = True
        Me.ColVatregno.Width = 90
        '
        'ColGroupName
        '
        Me.ColGroupName.DataPropertyName = "group_name"
        Me.ColGroupName.HeaderText = "Group Company Name"
        Me.ColGroupName.Name = "ColGroupName"
        Me.ColGroupName.ReadOnly = True
        '
        'ColMainProduct
        '
        Me.ColMainProduct.DataPropertyName = "main_product"
        Me.ColMainProduct.HeaderText = "Main Product"
        Me.ColMainProduct.Name = "ColMainProduct"
        Me.ColMainProduct.ReadOnly = True
        Me.ColMainProduct.Width = 70
        '
        'ColEdit
        '
        Me.ColEdit.DataPropertyName = "Edit"
        Me.ColEdit.HeaderText = "Edit"
        Me.ColEdit.Name = "ColEdit"
        Me.ColEdit.ReadOnly = True
        Me.ColEdit.Visible = False
        Me.ColEdit.Width = 50
        '
        'ColIDBanks
        '
        Me.ColIDBanks.DataPropertyName = "id_banks"
        Me.ColIDBanks.HeaderText = "Banks"
        Me.ColIDBanks.Name = "ColIDBanks"
        Me.ColIDBanks.ReadOnly = True
        Me.ColIDBanks.Width = 50
        '
        'colBranchNum
        '
        Me.colBranchNum.DataPropertyName = "branch_num"
        Me.colBranchNum.HeaderText = "Branch Num"
        Me.colBranchNum.Name = "colBranchNum"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 109)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 532)
        Me.TabControl1.TabIndex = 89
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtCustCD
        '
        Me.txtCustCD.Location = New System.Drawing.Point(145, 44)
        Me.txtCustCD.Name = "txtCustCD"
        Me.txtCustCD.Size = New System.Drawing.Size(104, 22)
        Me.txtCustCD.TabIndex = 96
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Customer Code"
        '
        'txtnamet
        '
        Me.txtnamet.Location = New System.Drawing.Point(657, 71)
        Me.txtnamet.Name = "txtnamet"
        Me.txtnamet.Size = New System.Drawing.Size(335, 22)
        Me.txtnamet.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(533, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Customer Name (TH)"
        '
        'txtname2
        '
        Me.txtname2.Location = New System.Drawing.Point(657, 44)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(335, 22)
        Me.txtname2.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(565, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Alternate Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(145, 71)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(374, 22)
        Me.txtname.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Customer Name"
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.Location = New System.Drawing.Point(255, 42)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(25, 23)
        Me.BtnSearch.TabIndex = 98
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'frmCustomerNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 646)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.txtCustCD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnamet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtname2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCustomerNew"
        Me.Text = "Customer New"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDel As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnAddParentOrSite As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents txtTotalSite As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents grdCustomers As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents BtnSearch As Button
    Friend WithEvents txtCustCD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnamet As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ColParentCustomerFlag As DataGridViewCheckBoxColumn
    Friend WithEvents Colshiptoflag As DataGridViewCheckBoxColumn
    Friend WithEvents ColbillToFlag As DataGridViewCheckBoxColumn
    Friend WithEvents active As DataGridViewCheckBoxColumn
    Friend WithEvents ColCustcd As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColAddr1 As DataGridViewTextBoxColumn
    Friend WithEvents coladdr2 As DataGridViewTextBoxColumn
    Friend WithEvents coladdr3 As DataGridViewTextBoxColumn
    Friend WithEvents colnamet As DataGridViewTextBoxColumn
    Friend WithEvents ColAddr1t As DataGridViewTextBoxColumn
    Friend WithEvents coladdr2t As DataGridViewTextBoxColumn
    Friend WithEvents coladdr3t As DataGridViewTextBoxColumn
    Friend WithEvents colname2 As DataGridViewTextBoxColumn
    Friend WithEvents Coldistrict As DataGridViewTextBoxColumn
    Friend WithEvents ColCity As DataGridViewTextBoxColumn
    Friend WithEvents ColCtry As DataGridViewTextBoxColumn
    Friend WithEvents Coltel As DataGridViewTextBoxColumn
    Friend WithEvents Colfax As DataGridViewTextBoxColumn
    Friend WithEvents ColEmail As DataGridViewTextBoxColumn
    Friend WithEvents colCredit As DataGridViewTextBoxColumn
    Friend WithEvents ColContact As DataGridViewTextBoxColumn
    Friend WithEvents ColAgcd As DataGridViewTextBoxColumn
    Friend WithEvents ColPayterms As DataGridViewTextBoxColumn
    Friend WithEvents ColVatregno As DataGridViewTextBoxColumn
    Friend WithEvents ColGroupName As DataGridViewTextBoxColumn
    Friend WithEvents ColMainProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColEdit As DataGridViewButtonColumn
    Friend WithEvents ColIDBanks As DataGridViewTextBoxColumn
    Friend WithEvents colBranchNum As DataGridViewTextBoxColumn
End Class
