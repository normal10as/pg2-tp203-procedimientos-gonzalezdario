Module Potencia
    Dim exponente As Integer = 2
    Sub Main()
        Dim num As Integer
        Console.Write("Ingrese un numero: ")
        num = Console.ReadLine()
        For x = 2 To 6
            Potencia(num, x)
        Next
    End Sub

    Function Potencia(ByVal numero As Integer, ByVal exponente As Integer) As Integer
        Console.WriteLine(numero & "^" & exponente & " = " & Math.Pow(numero, exponente))
        Return 0
    End Function

End Module
