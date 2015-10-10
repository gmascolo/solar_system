Public Class Planeta
    Inherits BE.Cuerpo_Celeste

    Private Temperatura As ULong
    Public Property pTemperatura() As ULong
        Get
            Return Temperatura
        End Get
        Set(ByVal value As ULong)
            Temperatura = value
        End Set
    End Property

    Private Orden As Integer
    Public Property pOrden() As Integer
        Get
            Return Orden
        End Get
        Set(ByVal value As Integer)
            Orden = value
        End Set
    End Property

    Private Clasificacion As String
    Public Property pClasificacion() As String
        Get
            Return Clasificacion
        End Get
        Set(ByVal value As String)
            Clasificacion = value
        End Set
    End Property


End Class
