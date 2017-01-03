Imports System.Text

Public Class Message

    Private _text As String
    Public Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
        End Set
    End Property

    Public Function Save(ByRef status As String)
        status = "Success"
        Return True
    End Function

    Public Sub Concatenate(delmiter As String, ParamArray items() As String)
        Dim result As New StringBuilder()
        For Each item As String In items
            result.Append(item & delmiter)
        Next

        Me._text = result.ToString().TrimEnd(delmiter)
    End Sub
End Class
