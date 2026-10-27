<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRawBeamYarnCompareBalance
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
        Me.rbBoth = New System.Windows.Forms.RadioButton()
        Me.rbYBM = New System.Windows.Forms.RadioButton()
        Me.rbYRA = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpToYear = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFromYear = New System.Windows.Forms.DateTimePicker()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbBoth)
        Me.GroupBox1.Controls.Add(Me.rbYBM)
        Me.GroupBox1.Controls.Add(Me.rbYRA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpToYear)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFromYear)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'rbBoth
        '
        Me.rbBoth.AutoSize = True
        Me.rbBoth.Checked = True
        Me.rbBoth.Location = New System.Drawing.Point(199, 139)
        Me.rbBoth.Name = "rbBoth"
        Me.rbBoth.Size = New System.Drawing.Size(50, 19)
        Me.rbBoth.TabIndex = 10
        Me.rbBoth.TabStop = True
        Me.rbBoth.Text = "Both"
        Me.rbBoth.UseVisualStyleBackColor = True
        '
        'rbYBM
        '
        Me.rbYBM.AutoSize = True
        Me.rbYBM.Location = New System.Drawing.Point(199, 114)
        Me.rbYBM.Name = "rbYBM"
        Me.rbYBM.Size = New System.Drawing.Size(50, 19)
        Me.rbYBM.TabIndex = 9
        Me.rbYBM.Text = "YBM"
        Me.rbYBM.UseVisualStyleBackColor = True
        '
        'rbYRA
        '
        Me.rbYRA.AutoSize = True
        Me.rbYRA.Location = New System.Drawing.Point(199, 89)
        Me.rbYRA.Name = "rbYRA"
        Me.rbYRA.Size = New System.Drawing.Size(47, 19)
        Me.rbYRA.TabIndex = 8
        Me.rbYRA.Text = "YRA"
        Me.rbYRA.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Yarn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "To  Year"
        '
        'dtpToYear
        '
        Me.dtpToYear.CustomFormat = "yyyy"
        Me.dtpToYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToYear.Location = New System.Drawing.Point(198, 56)
        Me.dtpToYear.Name = "dtpToYear"
        Me.dtpToYear.Size = New System.Drawing.Size(63, 23)
        Me.dtpToYear.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From  Year"
        '
        'dtpFromYear
        '
        Me.dtpFromYear.CustomFormat = "yyyy"
        Me.dtpFromYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromYear.Location = New System.Drawing.Point(198, 27)
        Me.dtpFromYear.Name = "dtpFromYear"
        Me.dtpFromYear.Size = New System.Drawing.Size(63, 23)
        Me.dtpFromYear.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(218, 190)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(61, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(285, 190)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(61, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRawBeamYarnCompareBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 227)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRawBeamYarnCompareBalance"
        Me.Text = "Raw / Beam Yarn Compare Balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpToYear As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFromYear As DateTimePicker
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents rbBoth As RadioButton
    Friend WithEvents rbYBM As RadioButton
    Friend WithEvents rbYRA As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
