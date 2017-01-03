Public Class CustomRenderingProvider
    Implements IRenderingProvider

    Public Sub Render() Implements IRenderingProvider.Render
        Console.WriteLine("Using custom rendering provider...")
    End Sub
End Class
