Public Class Square
    Inherits ShapeBase

    Public Sub New()
        Console.WriteLine("Constructor")
    End Sub

    Public Sub New(provider As IRenderingProvider)
        MyBase.New(provider)
    End Sub

    Public Overrides Function Identify() As String
        Return "Identify [Square]"
    End Function

    Public Overrides Sub Draw()
        Console.WriteLine("[]")
    End Sub

    Public Overrides Sub Fill(colorName As String)
        Console.WriteLine("Filling square: " & colorName)
    End Sub

End Class

