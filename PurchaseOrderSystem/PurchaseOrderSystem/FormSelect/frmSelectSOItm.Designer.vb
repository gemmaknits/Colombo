<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectSOItm
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
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.colSoHeaderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoLineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUomId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(75, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(217, 22)
        Me.txtFilter.TabIndex = 81
        Me.txtFilter.Tag = "กรอกข้อมูลในการค้นหา"
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.AllowUserToDeleteRows = False
        Me.grddata.AllowUserToResizeColumns = False
        Me.grddata.AllowUserToResizeRows = False
        Me.grddata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSoHeaderId, Me.colsono, Me.colSoLineID, Me.colsonoid, Me.colDesignNo, Me.colCol, Me.colqty, Me.colUomId, Me.coluom})
        Me.grddata.Location = New System.Drawing.Point(12, 40)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(678, 373)
        Me.grddata.TabIndex = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "uom"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sono"
        Me.DataGridViewTextBoxColumn1.HeaderText = "S/O No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sonoid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "S/O No ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "so_line_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "S/O Line ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "design_no"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Design No."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "QTY"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "uom_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UOM ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Exit_16x
        Me.btnCancel.Location = New System.Drawing.Point(615, 419)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 80
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Enter Text"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.PurchaseOrderSystem.My.Resources.Resources.None_16x
        Me.Button1.Location = New System.Drawing.Point(534, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "None"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Image = Global.PurchaseOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnOk.Location = New System.Drawing.Point(453, 419)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 79
        Me.btnOk.Text = "OK"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'colSoHeaderId
        '
        Me.colSoHeaderId.DataPropertyName = "so_header_id"
        Me.colSoHeaderId.HeaderText = "S/O Header ID"
        Me.colSoHeaderId.Name = "colSoHeaderId"
        '
        'colsono
        '
        Me.colsono.DataPropertyName = "sono"
        Me.colsono.HeaderText = "S/O No."
        Me.colsono.Name = "colsono"
        '
        'colSoLineID
        '
        Me.colSoLineID.DataPropertyName = "so_line_id"
        Me.colSoLineID.HeaderText = "S/O Line ID"
        Me.colSoLineID.Name = "colSoLineID"
        '
        'colsonoid
        '
        Me.colsonoid.DataPropertyName = "sonoid"
        Me.colsonoid.HeaderText = "S/O No ID"
        Me.colsonoid.Name = "colsonoid"
        '
        'colDesignNo
        '
        Me.colDesignNo.DataPropertyName = "design_no"
        Me.colDesignNo.HeaderText = "Design No."
        Me.colDesignNo.Name = "colDesignNo"
        '
        'colCol
        '
        Me.colCol.DataPropertyName = "col"
        Me.colCol.HeaderText = "Colors Code"
        Me.colCol.Name = "colCol"
        Me.colCol.ReadOnly = True
        '
        'colqty
        '
        Me.colqty.DataPropertyName = "qty"
        Me.colqty.HeaderText = "QTY"
        Me.colqty.Name = "colqty"
        '
        'colUomId
        '
        Me.colUomId.DataPropertyName = "uom_id"
        Me.colUomId.HeaderText = "UOM ID"
        Me.colUomId.Name = "colUomId"
        Me.colUomId.Visible = False
        '
        'coluom
        '
        Me.coluom.DataPropertyName = "uom"
        Me.coluom.HeaderText = "UOM"
        Me.coluom.Name = "coluom"
        '
        'frmSelectSOItm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectSOItm"
        Me.Text = "Select S/O Item"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents grddata As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents colSoHeaderId As DataGridViewTextBoxColumn
    Friend WithEvents colsono As DataGridViewTextBoxColumn
    Friend WithEvents colSoLineID As DataGridViewTextBoxColumn
    Friend WithEvents colsonoid As DataGridViewTextBoxColumn
    Friend WithEvents colDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents colCol As DataGridViewTextBoxColumn
    Friend WithEvents colqty As DataGridViewTextBoxColumn
    Friend WithEvents colUomId As DataGridViewTextBoxColumn
    Friend WithEvents coluom As DataGridViewTextBoxColumn
End Class
