<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDesign
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
        Me.grddata = New System.Windows.Forms.DataGridView()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grddata
        '
        Me.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Design_no, Me.refdesno, Me.Compo})
        Me.grddata.Location = New System.Drawing.Point(21, 111)
        Me.grddata.Name = "grddata"
        Me.grddata.Size = New System.Drawing.Size(444, 235)
        Me.grddata.TabIndex = 0
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design_no"
        Me.Design_no.Name = "Design_no"
        '
        'refdesno
        '
        Me.refdesno.DataPropertyName = "refdesno"
        Me.refdesno.HeaderText = "Description"
        Me.refdesno.Name = "refdesno"
        Me.refdesno.Width = 200
        '
        'Compo
        '
        Me.Compo.DataPropertyName = "Compo"
        Me.Compo.HeaderText = "Compo"
        Me.Compo.Name = "Compo"
        '
        'frmSearchDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 358)
        Me.Controls.Add(Me.grddata)
        Me.Name = "frmSearchDesign"
        Me.Text = "Search Designs"
        CType(Me.grddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grddata As System.Windows.Forms.DataGridView
    Friend WithEvents Design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents refdesno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Compo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
