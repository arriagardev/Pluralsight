Public Class BankAccount

    Public Event LargeWithdrawl As EventHandler(Of TransactionEventArgs)
    Public Event WithdrawlExceedsBalance As EventHandler(Of TransactionEventArgs)

    Private _balance As Decimal

    Public Sub New(balance As Decimal)
        Me._balance = balance
    End Sub

    Public Function Withdraw(amount As Decimal) As Boolean

        If Me._balance < amount Then
            Me.OnWithdrawlExceedsBalance()
            Return False
        End If

        Me._balance -= amount

        Console.WriteLine("{0:c} is withdrawn from the account", amount)

        If amount >= 1000 Then
            Me.OnLargeWithdrawl()
        End If

        Return True

    End Function

    Private Sub OnWithdrawlExceedsBalance()
        RaiseEvent WithdrawlExceedsBalance(Me,
            New TransactionEventArgs("Withdrawl denied. Exceeds balance."))
    End Sub

    Private Sub OnLargeWithdrawl()
        RaiseEvent LargeWithdrawl(Me,
            New TransactionEventArgs("ATTENTION: Large withdrawl - call your teenager and see what's up!"))
    End Sub

End Class