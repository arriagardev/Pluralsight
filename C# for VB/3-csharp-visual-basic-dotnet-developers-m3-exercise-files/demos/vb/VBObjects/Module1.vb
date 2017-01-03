Module Module1

    Sub Main()

        Dim square As New Square()
        Dim shape As ShapeBase
        Dim ident As IIdentifiable

        shape = DirectCast(square, ShapeBase)

        ident = DirectCast(square, IIdentifiable)

        Console.WriteLine(square.Identify())
        Console.WriteLine(shape.Identify())
        Console.WriteLine(ident.Identify())

        Console.ReadLine()
    End Sub

End Module
