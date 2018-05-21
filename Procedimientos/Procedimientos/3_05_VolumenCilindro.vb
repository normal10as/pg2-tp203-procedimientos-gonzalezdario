Module VolumenCilindro
    Dim radio As Double
    Dim altura As Double

    Sub Main()
        Console.WriteLine("Calculo de Volumen ")
        Console.WriteLine("--------------------------------------")

        radio = Ingresar("Ingrese el radio: ")
        altura = Ingresar("Ingrese la altura: ")
        Console.WriteLine("Su volumen es de: " & Volumen(radio, altura))
    End Sub

    Function Ingresar(texto As String)
        Dim num As Integer
        Console.Write(texto)
        num = Console.ReadLine()

        Do While num < 0
            Console.WriteLine("¡Error! El numero ingresado es negativo.")
            Console.Write(texto)
            num = Console.ReadLine()
        Loop
        Return num
    End Function

    Function Volumen(a As Double, b As Double)
        Dim c As Double
        c = Math.PI * Math.Pow(a, 2) * b
        Return c
    End Function
End Module
