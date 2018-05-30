﻿Module OperacionesSobrecarga
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

    Function Calcular(ByRef operacion As Byte, ByVal a As Integer, ByVal b As Integer) As Integer
        Dim resultado As Integer
        Select Case operacion
            Case 1
                resultado = a + b
            Case 2
                resultado = a - b
            Case 3
                resultado = a * b
            Case 4
                resultado = a / b
        End Select
        Return resultado
    End Function

    Function Calcular(ByVal a As Integer, ByVal b As Integer) As Integer
        Return Calcular(operaciones.suma, a, b)
    End Function

    Function Calcular(ByRef operacion As Byte, ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return Calcular(operacion, Calcular(operacion, a, b), c)
    End Function

    Function Calcular(ByRef operacion As Byte, ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Return Calcular(operacion, Calcular(operacion, a, b), Calcular(operacion, c, d))
    End Function

End Module