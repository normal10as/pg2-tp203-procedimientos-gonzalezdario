Module Hipotenusa
    Dim ladoa As Integer
    Dim ladob As Integer
    Sub Main()
        Console.WriteLine("Calculo de la Hipotenusa ")
        Console.WriteLine("--------------------------------------")
        ladoa = Ingreso()
        ladob = Ingreso()
        Console.WriteLine("Su hipotenusa es: " & Hipotenusa(ladoa, ladob))
    End Sub

    Function Ingreso()
        Dim num As Integer
        Console.Write("Ingrese un lado del triangulo: ")
        num = Console.ReadLine()

        Do While num < 0
            Console.WriteLine("¡Error! El numero ingresado es negativo.")
            Console.Write("Ingrese un lado del triangulo: ")
            num = Console.ReadLine()
        Loop
        Return num
    End Function

    Function Hipotenusa(a As Integer, b As Integer)
        Dim c As Integer
        c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
        Return c
    End Function
End Module