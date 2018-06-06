Module Hipotenusa
    Dim ladoa As Integer
    Dim ladob As Integer
    Sub Main()
        Console.WriteLine("Calculo de la Hipotenusa ")
        Console.WriteLine("--------------------------------------")

        IngresarValor(ladoa)
        IngresarValor(ladob)

        Console.WriteLine("Su hipotenusa es: " & Hipotenusa(ladoa, ladob))
    End Sub

    Sub IngresarValor(ByRef valor As Integer)
        Do
            Console.Write("Ingrese un lado del triangulo: ")
            valor = Console.ReadLine()
        Loop Until Validar(valor)

    End Sub
    Function Validar(num As Integer) As Boolean
        Return num > 0
    End Function

    Function Hipotenusa(a As Integer, b As Integer) As Double
        Return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
    End Function
End Module