Public Interface ICrud(Of T)

    Function Add(objAlta As T) As Boolean
    Function Delete(objdel As T) As Boolean
    Function ListAll() As List(Of T)
    Function Update(objUpdate As T) As Boolean


End Interface
