Imports System
Imports System.Windows.Forms

Public Class DataGridViewCalendarColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New CalendarCell())
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If (value IsNot Nothing) AndAlso
                Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) _
                Then
                Throw New InvalidCastException("Must be a CalendarCell")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property
    Public Class CalendarCell
        Inherits DataGridViewTextBoxCell

        Public Sub New()
            ' Use the short date format.
            Me.Style.Format = "d"
        End Sub

        Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer,
            ByVal initialFormattedValue As Object,
            ByVal dataGridViewCellStyle As DataGridViewCellStyle)

            ' Set the value of the editing control to the current cell value.
            MyBase.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle)

            Dim ctl As ComponentCalendarEditingControl =
                CType(DataGridView.EditingControl, ComponentCalendarEditingControl)

            Dim config As New clsConfig
            ' Use the default row value when Value property is null.
            If (Me.Value Is Nothing) Then
                ctl.Value = CType(Me.DefaultNewRowValue, DateTime)
            Else
                'ctl.Value = CType(Me.Value, DateTime)
                ctl.Value = CType(config.IsNull(Me.Value, Now()), DateTime)
                'ctl.Value = CType(config.IsNull(Me.Value, "1900-01-01"), DateTime)
                'ctl.Value = Nothing
            End If


        End Sub

        Public Overrides ReadOnly Property EditType() As Type
            Get
                ' Return the type of the editing control that CalendarCell uses.
                Return GetType(ComponentCalendarEditingControl)
            End Get
        End Property

        Public Overrides ReadOnly Property ValueType() As Type
            Get
                ' Return the type of the value that CalendarCell contains.
                Return GetType(DateTime)
            End Get
        End Property

        Public Overrides ReadOnly Property DefaultNewRowValue() As Object
            Get
                ' Use the current date and time as the default value.
                Return DateTime.Now
            End Get
        End Property
    End Class
End Class
