Module VolumenCilindro
    Dim radio As Double
    Dim altura As Double

    Sub Main()
        Console.WriteLine("Calculo de Volumen ")
        Console.WriteLine("--------------------------------------")

        IngresarValor(radio, "radio")
        IngresarValor(altura, "altura")

        Console.WriteLine("Su volumen es de: " & Volumen(radio, altura))
    End Sub

    Sub IngresarValor(ByRef valor As Integer, palabra As String)
        Do
            Console.Write("Ingrese " & palabra & ": ")
            valor = Console.ReadLine()
        Loop Until Validar(valor)

    End Sub
    Function Validar(num As Integer) As Boolean
        Return num > 0
    End Function



    Function Volumen(a As Double, b As Double) As Double
        Return Math.PI * Math.Pow(a, 2) * b
    End Function
End Module
