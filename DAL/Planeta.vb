Imports System.Data.SqlClient

Public Class Planeta
    Implements BE.ICrud(Of BE.Planeta)

    Public Function Create(objAlta As BE.Planeta) As Boolean Implements BE.ICrud(Of BE.Planeta).Create

        Dim connection As New SqlConnection
        Dim connectionStringName = "Data Source=192.168.1.60;Initial Catalog=Sistema_Solar;User ID=lug;Password=2015Sabbath"

        Dim procedure = "dbo.sp_CreatePlaneta"
        Dim command = New SqlCommand(procedure, connection)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.Add(
            New SqlParameter("@nombre", objAlta.pNombre))
        command.Parameters.Add(
            New SqlParameter("@diametro", objAlta.pDiametro))
        command.Parameters.Add(
            New SqlParameter("@temperatura", objAlta.pTemperatura))
        command.Parameters.Add(
            New SqlParameter("@clasificacion", objAlta.pClasificacion))
        command.Parameters.Add(
            New SqlParameter("@orden", objAlta.pOrden))

        connection.Open()
        command.ExecuteNonQuery()

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
