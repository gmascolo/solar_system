Public Interface ICrud(Of T)

    Function Create(objAlta As T) As Boolean
    Function Retrieve(objRet As T) As Boolean
    Function Update(objUpdate As T) As Boolean
    Function Delete(objDel As T) As Boolean
    Function ListAll() As List(Of T)


End Interface
