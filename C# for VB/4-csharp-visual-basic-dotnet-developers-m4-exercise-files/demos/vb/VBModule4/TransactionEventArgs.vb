Public Class TransactionEventArgs
    Inherits EventArgs

    Private _message As String

    Public Property Message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property

    Public Sub New(message As String)
        Me._message = message
    End Sub

End Class