Option Explicit On
Option Strict On
Module Module1

    Sub Main()
        'Call to these Examples by deleting the '
        'Arrays()
        ArrayMultiDimesional()
        Console.Read()
    End Sub

    Sub Arrays()
        Dim Names(5) As String

        Names(0) = "Bob"
        Names(1) = "Mary"
        Names(2) = "Jimmy"
        Names(3) = "Steven"
        Names(4) = "Jerald"
        Names(5) = "Ongo bongo"

        Console.WriteLine(Names(3))
    End Sub

    Sub ArrayMultiDimesional()

        Dim People(5, 1) As String
        Dim FirstName As Integer = 0
        Dim LastName As Integer = 1

        People(0, FirstName) = "Billy"
        People(0, LastName) = "Jean"
        People(1, FirstName) = "Tom"
        People(1, LastName) = "Jerry"
        People(2, FirstName) = "Joy"
        People(2, LastName) = "Jerimia"

        For Row = 0 To 5
            Console.WriteLine(People(Row, 0) & " " & People(Row, 1))
        Next

        'Or we can do this Shit
        'i means Incerment

        For i = LBound(People) To UBound(People)
            Console.WriteLine(People(i, 0))
        Next

    End Sub

End Module
