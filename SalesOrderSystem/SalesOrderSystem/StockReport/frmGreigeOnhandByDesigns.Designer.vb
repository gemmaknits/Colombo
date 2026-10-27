<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeOnhandByDesigns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeOnhandByDesigns))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.btnSearchDFNo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.CboGrade = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Design No."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(94, 41)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(113, 20)
        Me.txtDesignNo.TabIndex = 1
        '
        'btnSearchDFNo
        '
        Me.btnSearchDFNo.Image = CType(resources.GetObject("btnSearchDFNo.Image"), System.Drawing.Image)
        Me.btnSearchDFNo.Location = New System.Drawing.Point(216, 39)
        Me.btnSearchDFNo.Name = "btnSearchDFNo"
        Me.btnSearchDFNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchDFNo.TabIndex = 299
        Me.btnSearchDFNo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(213, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 302
        Me.Label8.Text = "ex. A,B,C.."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 300
        Me.Label3.Text = "Grade:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(300, 25)
        Me.ToolStrip1.TabIndex = 303
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'CboGrade
        '
        Me.CboGrade.FormattingEnabled = True
        Me.CboGrade.Location = New System.Drawing.Point(94, 78)
        Me.CboGrade.Name = "CboGrade"
        Me.CboGrade.Size = New System.Drawing.Size(113, 21)
        Me.CboGrade.TabIndex = 304
        '
        'frmGreigeOnhandByDesigns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 112)
        Me.Controls.Add(Me.CboGrade)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearchDFNo)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGreigeOnhandByDesigns"
        Me.Text = "Greige Onhand By Designs"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchDFNo As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents CboGrade As System.Windows.Forms.ComboBox
End Class
