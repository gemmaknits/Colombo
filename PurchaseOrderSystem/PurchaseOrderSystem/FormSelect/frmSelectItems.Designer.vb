<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectItems
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
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.colItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdescSupp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouting.Location = New System.Drawing.Point(17, 15)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(55, 13)
        Me.lblRouting.TabIndex = 65
        Me.lblRouting.Text = "Exter Text"
        Me.lblRouting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemId, Me.colItcd, Me.colitdesc, Me.colItdescSupp, Me.colUomid, Me.colUom})
        Me.grddata.Location = New System.Drawing.Point(20, 40)
        Me.grddata.Name = "grddata"
        Me.grddata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grddata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grddata.Size = New System.Drawing.Size(661, 368)
        Me.grddata.TabIndex = 67
        '
        'colItemId
        '
        Me.colItemId.DataPropertyName = "item_id"
        Me.colItemId.HeaderText = "Items ID"
        Me.colItemId.Name = "colItemId"
        '
        'colItcd
        '
        Me.colItcd.DataPropertyName = "itcd"
        Me.colItcd.HeaderText = "Item Code"
        Me.colItcd.Name = "colItcd"
        '
        'colitdesc
        '
        Me.colitdesc.DataPropertyName = "itdesc"
        Me.colitdesc.HeaderText = "Description"
        Me.colitdesc.Name = "colitdesc"
        Me.colitdesc.Width = 200
        '
        'colItdescSupp
        '
        Me.colItdescSupp.DataPropertyName = "itdesc_supp"
        Me.colItdescSupp.HeaderText = "Description for Supplier"
        Me.colItdescSupp.Name = "colItdescSupp"
        Me.colItdescSupp.Width = 200
        '
        'colUomid
        '
        Me.colUomid.DataPropertyName = "uom_id"
        Me.colUomid.HeaderText = "UOM ID"
        Me.colUomid.Name = "colUomid"
        Me.colUomid.Visible = False
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "uom"
        Me.colUom.HeaderText = "UOM"
        Me.colUom.Name = "colUom"
        Me.colUom.Width = 60
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnCancel.Location = New System.Drawing.Point(606, 414)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Image = Global.PurchaseOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnOk.Location = New System.Drawing.Point(444, 415)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 24)
        Me.btnOk.TabIndex = 68
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(78, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(243, 22)
        Me.txtFilter.TabIndex = 64
        Me.txtFilter.Tag = "กรอกข้อมูลในการค้นหา"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.PurchaseOrderSystem.My.Resources.Resources.None_16x
        Me.Button1.Location = New System.Drawing.Point(525, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "None"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSelectItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtFilter)
        Me.Name = "frmSelectItems"
        Me.Text = "Select Items"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRouting As Label
    Friend WithEvents grddata As DataGridView
    Friend WithEvents colItemId As DataGridViewTextBoxColumn
    Friend WithEvents colItcd As DataGridViewTextBoxColumn
    Friend WithEvents colitdesc As DataGridViewTextBoxColumn
    Friend WithEvents colItdescSupp As DataGridViewTextBoxColumn
    Friend WithEvents colUomid As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Button1 As Button
End Class
