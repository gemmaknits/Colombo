Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Controls

    ''' <summary>
    ''' Drop-in replacement for Syncfusion DateTimePickerAdv.
    ''' Supports BindableValue (accepts/returns DBNull), IsNullDate mode,
    ''' and ShowCheckBox behaviour identical to Syncfusion's control.
    ''' </summary>
    Public Class NullableDateTimePicker
        Inherits DateTimePicker
        Implements System.ComponentModel.ISupportInitialize

        Private _isNull As Boolean = False
        Private Shared ReadOnly _nullFormat As String = " "

        ' Syncfusion styling stubs — accepted but ignored at runtime
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MetroColor As Color
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ShowDropDownOnNull As Boolean
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property BorderColor As Color
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property CalendarSize As Size
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Culture As System.Globalization.CultureInfo
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property DropDownImage As System.Drawing.Image
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property DropDownNormalColor As Color
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MinValue As Date
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property [ReadOnly] As Boolean

        Public Sub New()
            Me.ShowCheckBox = True
            Me.Format = DateTimePickerFormat.Custom
            Me.CustomFormat = "dd/MM/yyyy"
        End Sub

        ' ---------------------------------------------------------------
        ' IsNullDate — enable null display mode (Syncfusion compat)
        ' ---------------------------------------------------------------
        Private _isNullDate As Boolean = False
        <Browsable(True), DefaultValue(False)>
        Public Property IsNullDate As Boolean
            Get
                Return _isNullDate
            End Get
            Set(value As Boolean)
                _isNullDate = value
            End Set
        End Property

        ' ---------------------------------------------------------------
        ' BindableValue — bind to DBNull-capable database fields
        ' ---------------------------------------------------------------
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property BindableValue As Object
            Get
                If _isNull Then Return DBNull.Value
                Return Me.Value
            End Get
            Set(value As Object)
                If IsDBNull(value) OrElse value Is Nothing Then
                    SetNull()
                Else
                    Try
                        Dim d As Date = Convert.ToDateTime(value)
                        _isNull = False
                        Me.CustomFormat = "dd/MM/yyyy"
                        Me.Checked = True
                        Me.Value = d
                    Catch
                        SetNull()
                    End Try
                End If
            End Set
        End Property

        Private Sub SetNull()
            _isNull = True
            Me.Checked = False
            Me.CustomFormat = _nullFormat
        End Sub

        ' Keep _isNull in sync when user unchecks the checkbox
        Protected Overrides Sub OnValueChanged(e As EventArgs)
            If Not Me.Checked Then
                _isNull = True
                Me.CustomFormat = _nullFormat
            Else
                _isNull = False
                Me.CustomFormat = "dd/MM/yyyy"
            End If
            MyBase.OnValueChanged(e)
        End Sub

        ' ISupportInitialize — required by Designer CType cast
        Public Sub BeginInit() Implements System.ComponentModel.ISupportInitialize.BeginInit
        End Sub

        Public Sub EndInit() Implements System.ComponentModel.ISupportInitialize.EndInit
        End Sub

    End Class

End Namespace
