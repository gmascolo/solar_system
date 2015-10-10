Public Class Planeta
    Implements BE.ICrud(Of BE.Planeta)


    Public Function Add(objAlta As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Add

    End Function

    Public Function Delete(objdel As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Delete

    End Function

    Public Function ListAll() As List(Of BE.Planeta) Implements BE.ICrud(Of BE.Planeta).ListAll

    End Function

    Public Function Update(objUpdate As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Update

    End Function
End Class
