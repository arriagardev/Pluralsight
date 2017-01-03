Imports System.Collections

Module Module1


    Sub Main()

        '----------------------------------------------
        ' Generics
        '----------------------------------------------
        'Dim people As New List(Of Person)()

        'people.Add(New Person("Craig Shoemaker", "@craigshoemaker"))
        'people.Add(New Person("John Sonmez", "@jsonmez"))

        'For Each person As Person In people
        '    Console.WriteLine(person.Name)
        'Next

        'Dim workflow As New Workflow()

        'Dim _stop As New StopWorkflow()
        'Dim setup As New SetupWorkflow()

        'workflow.Process(Of SetupWorkflow)(setup)
        '----------------------------------------------

        '----------------------------------------------
        ' Using Delegates
        '----------------------------------------------
        'Dim operations As New BasicMathOperations()
        'Dim calculator As New Calculator()

        'calculator.Calculate(AddressOf operations.Add, 5, 2)
        'calculator.Calculate(AddressOf operations.Subtract, 5, 2)
        'calculator.Calculate(AddressOf operations.Multiply, 5, 2)
        'calculator.Calculate(AddressOf operations.Divide, 5, 2)
        '----------------------------------------------

        '----------------------------------------------
        ' Events
        '----------------------------------------------
        'Dim account As New BankAccount(3000)

        'AddHandler account.LargeWithdrawl, AddressOf account_LargeWithdrawl
        ' ''AddHandler account.LargeWithdrawl, Sub(sender As Object, e As TransactionEventArgs)
        ''                                       Console.WriteLine(e.Message)
        ''                                   End Sub
        ''AddHandler account.LargeWithdrawl, Sub(sender As Object, e As TransactionEventArgs) Console.WriteLine(e.Message)

        'AddHandler account.WithdrawlExceedsBalance, Sub(sender As Object, e As TransactionEventArgs) Console.WriteLine(e.Message)

        'account.Withdraw(100)
        'account.Withdraw(1000)
        'account.Withdraw(10000)
        '----------------------------------------------

        '----------------------------------------------
        ' Lambdas
        '----------------------------------------------
        'Dim calculator As New Calculator()
        'calculator.Calculate(Function(x, y) Decimal.Add(x, y), 5, 2)
        'calculator.Calculate(Function(x, y) Decimal.Subtract(x, y), 5, 2)
        'calculator.Calculate(Function(x, y) Decimal.Multiply(x, y), 5, 2)
        'calculator.Calculate(Function(x, y) Decimal.Divide(x, y), 5, 2)


        Dim calculator As New Calculator()
        calculator.Calculate(Sub(x, y) Console.WriteLine(Decimal.Add(x, y)), 5, 2)
        calculator.Calculate(Sub(x, y) Console.WriteLine(Decimal.Subtract(x, y)), 5, 2)
        calculator.Calculate(Sub(x, y) Console.WriteLine(Decimal.Multiply(x, y)), 5, 2)
        calculator.Calculate(Sub(x, y) Console.WriteLine(Decimal.Divide(x, y)), 5, 2)


        'Dim account As New BankAccount(3000)
        'AddHandler account.LargeWithdrawl, Sub(s, e) Console.WriteLine(e.Message)
        'account.Withdraw(1000)

        ' linq
        Dim people As New List(Of Person)()

        people.Add(New Person("John Sonmez", "@jsonmez"))
        people.Add(New Person("Dan Wahlin", "@danwhalin"))
        people.Add(New Person("John Papa", "@john_papa"))
        people.Add(New Person("Craig Shoemaker", "@craigshoemaker"))
        people.Add(New Person("Julie Lerman", "@julielerman"))

        Dim query = From p In people
                    Where p.Name.StartsWith("John")
                    Select p

        Dim results As List(Of Person) = query.ToList()

        For Each person As Person In results
            Console.WriteLine(person.Name)
        Next
        ''----------------------------------------------



        Console.ReadLine()
    End Sub

    Public Sub account_LargeWithdrawl(sender As Object, e As TransactionEventArgs)
        Console.WriteLine(e.Message)
    End Sub

End Module
