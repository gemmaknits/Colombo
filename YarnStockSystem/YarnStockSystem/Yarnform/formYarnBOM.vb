Public Class formYarnBOM
    Dim bsYarnBOM As BindingSource
    Dim bsyarnBOMItems As BindingSource

    Private Sub formYarnBOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData("NEW")
    End Sub
    Public Overrides Sub LoadData(ByVal MainDocno As Integer)
        MyBase.LoadData(MainDocno)

    End Sub
End Class
