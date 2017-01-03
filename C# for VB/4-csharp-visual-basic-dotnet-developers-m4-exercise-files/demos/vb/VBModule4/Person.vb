Public Class Person
    Private _name As String
    Private _twitter As String

    Public Property Twitter() As String
        Get
            Return _twitter
        End Get
        Set(ByVal value As String)
            _twitter = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Public Sub New(name As String, twitter As String)
        Me._name = name
        Me._twitter = twitter
    End Sub
End Class
