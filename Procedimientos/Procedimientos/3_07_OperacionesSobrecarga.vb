Module OperacionesSobrecarga
    Enum operaciones As Byte
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub Main()
        Console.WriteLine(Calcular(9, 3))
        Console.WriteLine(Calcular(operaciones.suma, 9, 3))
        Console.WriteLine(Calcular(operaciones.resta, 9, 3))
        Console.WriteLine(Calcular(operaciones.multiplicacion, 9, 3))
        Console.WriteLine(Calcular(operaciones.division, 9, 3))
        Console.WriteLine("-------------------")
        Console.WriteLine(Calcular(operaciones.suma, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.resta, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.multiplicacion, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.division, 27, 9, 3))
        Console.WriteLine("-------------------")
        Console.WriteLine(Calcular(operaciones.suma, 243, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.resta, 243, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.multiplicacion, 243, 27, 9, 3))
        Console.WriteLine(Calcular(operaciones.division, 243, 27, 9, 3))
    End Sub

    Function Calcular(operacion As operaciones, a As Integer, b As Integer) As Integer
        Select Case operacion
            Case operaciones.suma
                Return a + b
            Case operaciones.resta
                Return a - b
            Case operaciones.multiplicacion
                Return a * b
            Case operaciones.division
                Return a / b
        End Select
    End Function

    Function Calcular(a As Integer, b As Integer) As Integer
        Return Calcular(operaciones.suma, a, b)
    End Function

    Function Calcular(operacion As operaciones, a As Integer, b As Integer, c As Integer) As Integer
        Return Calcular(operacion, Calcular(operacion, a, b), c)
    End Function

    Function Calcular(operacion As operaciones, a As Integer, b As Integer, c As Integer, d As Integer) As Integer
        Return Calcular(operacion, Calcular(operacion, a, b), Calcular(operacion, c, d))
    End Function

End Module
