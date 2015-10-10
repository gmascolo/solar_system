Public Class Cuerpo_Celeste

    Private ID As Integer
    Public Property pID() As Integer
        Get
            Return ID
        End Get
        Set(ByVal value As Integer)
            ID = value
        End Set
    End Property

    Private Nombre As String
    Public Property pNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Private Diametro As ULong
    Public Property pDiametro() As ULong
        Get
            Return Diametro
        End Get
        Set(ByVal value As ULong)
            Diametro = value
        End Set
    End Property

End Class
