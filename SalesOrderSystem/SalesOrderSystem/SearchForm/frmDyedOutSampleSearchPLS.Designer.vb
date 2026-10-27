<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyedOutSampleSearchPLS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedOutSampleSearchPLS))
        Me.lblRouting = New System.Windows.Forms.Label()
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.colPackno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPackDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOutDt = New Classes.CalendarColumn()
        Me.colDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colcustname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colempname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlsKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlsMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPlsYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouting
        '
        Me.lblRouting.AutoSize = True
        Me.lblRouting.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouting.Location = New System.Drawing.Point(231, 31)
        Me.lblRouting.Name = "lblRouting"
        Me.lblRouting.Size = New System.Drawing.Size(162, 21)
        Me.lblRouting.TabIndex = 49
        Me.lblRouting.Text = "กรอกคีย์เวิร์ดในการค้นหา"
        '
        'grddata
        '
        Me.grddata.AllowUserToAddRows = False
        Me.grddata.ColumnHeadersHeight = 40
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPackno, Me.colPackDt, Me.colOutno, Me.colOutDt, Me.colDesignNo, Me.Colcustname, Me.colRemark, Me.colempname, Me.colPlsKg, Me.colPlsMts, Me.colPlsYds})
        Me.grddata.Location = New System.Drawing.Point(32, 117)
        Me.grddata.Name = "grddata"
        Me.grddata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grddata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grddata.Size = New System.Drawing.Size(1002, 237)
        Me.grddata.TabIndex = 51
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(412, 31)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(243, 29)
        Me.txtFilter.TabIndex = 48
        Me.txtFilter.Tag = "กรอกข้อมูลในการค้นหา"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(459, 68)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 32)
        Me.btnRefresh.TabIndex = 50
        Me.btnRefresh.Text = "&ค้นหาทันที"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'colPackno
        '
        Me.colPackno.DataPropertyName = "packno"
        Me.colPackno.HeaderText = "PLS No."
        Me.colPackno.Name = "colPackno"
        Me.colPackno.ReadOnly = True
        '
        'colPackDt
        '
        Me.colPackDt.DataPropertyName = "packdt"
        Me.colPackDt.HeaderText = "Date"
        Me.colPackDt.Name = "colPackDt"
        Me.colPackDt.ReadOnly = True
        '
        'colOutno
        '
        Me.colOutno.DataPropertyName = "outno"
        Me.colOutno.HeaderText = "DOM No."
        Me.colOutno.Name = "colOutno"
        Me.colOutno.ReadOnly = True
        '
        'colOutDt
        '
        Me.colOutDt.DataPropertyName = "outdt"
        Me.colOutDt.HeaderText = "DOM Date"
        Me.colOutDt.Name = "colOutDt"
        Me.colOutDt.ReadOnly = True
        '
        'colDesignNo
        '
        Me.colDesignNo.DataPropertyName = "design_no"
        Me.colDesignNo.HeaderText = "Design No. (FG)"
        Me.colDesignNo.Name = "colDesignNo"
        Me.colDesignNo.ReadOnly = True
        '
        'Colcustname
        '
        Me.Colcustname.DataPropertyName = "custname"
        Me.Colcustname.HeaderText = "Customers"
        Me.Colcustname.Name = "Colcustname"
        Me.Colcustname.ReadOnly = True
        '
        'colRemark
        '
        Me.colRemark.DataPropertyName = "Remark"
        Me.colRemark.HeaderText = "Remark"
        Me.colRemark.Name = "colRemark"
        '
        'colempname
        '
        Me.colempname.DataPropertyName = "empname"
        Me.colempname.HeaderText = "Request By."
        Me.colempname.Name = "colempname"
        Me.colempname.ReadOnly = True
        '
        'colPlsKg
        '
        Me.colPlsKg.DataPropertyName = "pls_kg"
        Me.colPlsKg.HeaderText = "PLS KG"
        Me.colPlsKg.Name = "colPlsKg"
        Me.colPlsKg.Width = 50
        '
        'colPlsMts
        '
        Me.colPlsMts.DataPropertyName = "pls_mts"
        Me.colPlsMts.HeaderText = "PLS MTS"
        Me.colPlsMts.Name = "colPlsMts"
        Me.colPlsMts.Width = 50
        '
        'colPlsYds
        '
        Me.colPlsYds.DataPropertyName = "pls_yds"
        Me.colPlsYds.HeaderText = "PLS YDS"
        Me.colPlsYds.Name = "colPlsYds"
        Me.colPlsYds.Width = 50
        '
        'frmDyedOutSampleSearchPLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 386)
        Me.Controls.Add(Me.lblRouting)
        Me.Controls.Add(Me.grddata)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtFilter)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDyedOutSampleSearchPLS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search PLS"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRouting As System.Windows.Forms.Label
    Friend WithEvents grddata As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents colPackno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPackDt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOutno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOutDt As Classes.CalendarColumn
    Friend WithEvents colDesignNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colcustname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colempname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlsKg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlsMts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlsYds As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
