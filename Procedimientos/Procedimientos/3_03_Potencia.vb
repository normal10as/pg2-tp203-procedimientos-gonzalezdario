Module Potencia
    Dim exponente As Integer = 2
    Sub Main()
        Dim num As Integer
        Console.Write("Ingrese un numero: ")
        num = Console.ReadLine()
        For exponente = 2 To 6
            Console.WriteLine(num & "^" & exponente & " = " & Potencia(num, exponente))
        Next
    End Sub

    Function Potencia(ByVal numero As Integer, ByVal exponente As Integer) As Integer
        Return Math.Pow(numero, exponente)
    End Function

End Module
