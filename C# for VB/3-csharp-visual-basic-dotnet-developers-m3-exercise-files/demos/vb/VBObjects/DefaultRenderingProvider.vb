Public Class DefaultRenderingProvider
    Implements IRenderingProvider

    Public Sub Render() Implements IRenderingProvider.Render
        Console.WriteLine("Using default rendering provider...")
    End Sub

End Class
