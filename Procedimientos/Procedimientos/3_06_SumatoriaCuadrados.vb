Module SumatoriaCuadrados
    Dim numero As Integer

    Sub Main()
        numero = Ingresar()
        Console.WriteLine("Sumatoria: " & Sumatoria(numero))
    End Sub

    Function Ingresar()
        Dim num As Integer
        Console.Write("Ingrese un numero: ")
        num = Console.ReadLine()

        Do While num < 0
            Console.WriteLine("¡Error! El numero ingresado es negativo.")
            Console.Write("Ingrese un numero: ")
            num = Console.ReadLine()
        Loop
        Return num
    End Function

    Function Sumatoria(ByRef n As Integer) As Integer
        Dim a As Integer

        For x = 1 To n
            a = a + Math.Pow(x, 2)
        Next
        Return a
    End Function
End Module
