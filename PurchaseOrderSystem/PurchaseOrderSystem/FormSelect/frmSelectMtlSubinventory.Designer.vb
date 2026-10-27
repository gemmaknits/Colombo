<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectMtlSubinventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectMtlSubinventory))
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.colmtlsubinventoryid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubinventorycode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsubinventoryname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouting.Location = New System.Drawing.Point(40, 19)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(159, 21)
        Me.lblRouting.TabIndex = 73
        Me.lblRouting.Text = "กรอกคีย์เวิร์ดในการค้นหา"
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddata.ColumnHeadersHeight = 40
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colmtlsubinventoryid, Me.colsubinventorycode, Me.colsubinventoryname})
        Me.grddata.Location = New System.Drawing.Point(21, 101)
        Me.grddata.Name = "grddata"
        Me.grddata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grddata.Size = New System.Drawing.Size(708, 175)
        Me.grddata.TabIndex = 75
        '
        'colmtlsubinventoryid
        '
        Me.colmtlsubinventoryid.DataPropertyName = "mtl_subinventory_id"
        Me.colmtlsubinventoryid.HeaderText = "SUB ID"
        Me.colmtlsubinventoryid.Name = "colmtlsubinventoryid"
        '
        'colsubinventorycode
        '
        Me.colsubinventorycode.DataPropertyName = "subinventory_code"
        Me.colsubinventorycode.HeaderText = "SUB Code"
        Me.colsubinventorycode.Name = "colsubinventorycode"
        '
        'colsubinventoryname
        '
        Me.colsubinventoryname.DataPropertyName = "subinventory_name"
        Me.colsubinventoryname.HeaderText = "Desceptions"
        Me.colsubinventoryname.Name = "colsubinventoryname"
        Me.colsubinventoryname.Width = 300
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(654, 282)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 41)
        Me.btnCancel.TabIndex = 77
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(573, 282)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 41)
        Me.btnOk.TabIndex = 76
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(225, 19)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(243, 29)
        Me.txtFilter.TabIndex = 72
        Me.txtFilter.Tag = "กรอกข้อมูลในการค้นหา"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(285, 54)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 32)
        Me.btnRefresh.TabIndex = 74
        Me.btnRefresh.Text = "&ค้นหาทันที"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmSelectMtlSubinventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 342)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtFilter)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectMtlSubinventory"
        Me.Text = "Select Sub Inventory"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRouting As Label
    Friend WithEvents grddata As DataGridView
    Friend WithEvents colmtlsubinventoryid As DataGridViewTextBoxColumn
    Friend WithEvents colsubinventorycode As DataGridViewTextBoxColumn
    Friend WithEvents colsubinventoryname As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtFilter As TextBox
End Class
