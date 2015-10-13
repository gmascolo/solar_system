Public Class Planeta
    Implements BE.ICrud(Of BE.Planeta)


    Public Function Create(objAlta As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Create

    End Function

    Public Function Delete(objDel As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Delete

    End Function

    Public Function ListAll() As List(Of BE.Planeta) Implements BE.ICrud(Of BE.Planeta).ListAll

    End Function

    Public Function Retrieve(objRet As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Retrieve

    End Function

    Public Function Update(objUpdate As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Update

    End Function
End Class
