Public Interface IIdentifiable
    Function Identify() As String
End Interface

Public Interface IIdentifiable2
    Inherits IIdentifiable

    Property Id As Integer
End Interface

Public Interface IIdentifiable3
    Function Identify() As String
End Interface

Public Interface IIdentifiable4
    Sub Identify()
End Interface