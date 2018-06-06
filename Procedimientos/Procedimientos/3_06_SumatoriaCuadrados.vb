Module SumatoriaCuadrados
    Dim numero As Integer

    Sub Main()
        IngresarValor(numero)
        Console.WriteLine("Sumatoria: " & Sumatoria(numero))
    End Sub

    Sub IngresarValor(ByRef valor As Integer)
        Do
            Console.Write("Ingrese un numero: ")
            valor = Console.ReadLine()
        Loop Until Validar(valor)

    End Sub
    Function Validar(num As Integer) As Boolean
        Return num > 0
    End Function

    Function Sumatoria(ByRef n As Integer) As Integer
        Dim a As Integer

        For x = 1 To n
            a = a + Math.Pow(x, 2)
        Next

        Return a

    End Function

End Module
