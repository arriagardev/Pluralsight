Public Class BasicMathOperations
    Public Function Add(x As Integer, y As Integer) As Decimal
        Return Decimal.Add(x, y)
    End Function

    Public Function Subtract(x As Integer, y As Integer) As Decimal
        Return Decimal.Subtract(x, y)
    End Function

    Public Function Multiply(x As Integer, y As Integer) As Decimal
        Return Decimal.Multiply(x, y)
    End Function

    Public Function Divide(x As Integer, y As Integer) As Decimal

        If x = 0 Then
            Throw New ArgumentException("You can not divide by zero!")
        End If

        Return Decimal.Divide(x, y)
    End Function
End Class