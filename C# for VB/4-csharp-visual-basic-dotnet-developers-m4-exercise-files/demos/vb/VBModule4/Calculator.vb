Public Class Calculator
    Delegate Function CalculateDelegate(x As Decimal, y As Decimal) As Decimal

    'Public Sub Calculate(operation As CalculateDelegate, x As Decimal, y As Decimal)
    '    Dim result = operation(x, y)
    '    Console.WriteLine("Result: {0}", result)
    'End Sub

    Public Sub Calculate(operation As Action(Of Decimal, Decimal), x As Decimal, y As Decimal)
        operation(x, y)
        Console.WriteLine("Calculation complete.")
    End Sub

    Public Sub Calculate(operation As Func(Of Decimal, Decimal, Decimal), x As Decimal, y As Decimal)
        Dim result = operation(x, y)
        Console.WriteLine("Result: {0}", result)
    End Sub

End Class