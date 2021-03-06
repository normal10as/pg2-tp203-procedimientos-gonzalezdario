﻿Module OperacionesSobrecargas2
    Enum operaciones As Byte
        suma = 1
        resta
        multiplicacion
        division
    End Enum

    Sub Main()
        Resultado(9, 3)
        Resultado(operaciones.suma, 9, 3)
        Resultado(operaciones.resta, 9, 3)
        Resultado(operaciones.multiplicacion, 9, 3)
        Resultado(operaciones.division, 9, 3)

        Resultado(operaciones.suma, 27, 9, 3)
        Resultado(operaciones.resta, 27, 9, 3)
        Resultado(operaciones.multiplicacion, 27, 9, 3)
        Resultado(operaciones.division, 27, 9, 3)

        Resultado(operaciones.suma, 243, 27, 9, 3)
        Resultado(operaciones.resta, 243, 27, 9, 3)
        Resultado(operaciones.multiplicacion, 243, 27, 9, 3)
        Resultado(operaciones.division, 243, 27, 9, 3)
    End Sub

    Sub Resultado(a As operaciones, b As Integer, c As Integer)
        Select Case a
            Case operaciones.suma
                Console.WriteLine(b & " + " & c & " = " & Calcular(a, b, c))
            Case operaciones.resta
                Console.WriteLine(b & " - " & c & " = " & Calcular(a, b, c))
            Case operaciones.multiplicacion
                Console.WriteLine(b & " * " & c & " = " & Calcular(a, b, c))
            Case operaciones.division
                Console.WriteLine(b & " / " & c & " = " & Calcular(a, b, c))
        End Select
    End Sub

    Sub Resultado(a As operaciones, b As Integer, c As Integer, d As Integer)
        Select Case a
            Case operaciones.suma
                Console.WriteLine(b & " + " & c & " + " & d & " = " & Calcular(a, b, c, d))
            Case operaciones.resta
                Console.WriteLine(b & " - " & c & " - " & d & " = " & Calcular(a, b, c, d))
            Case operaciones.multiplicacion
                Console.WriteLine(b & " * " & c & " * " & d & " = " & Calcular(a, b, c, d))
            Case operaciones.division
                Console.WriteLine(b & " / " & c & " / " & d & " = " & Calcular(a, b, c, d))
        End Select
    End Sub

    Sub Resultado(a As operaciones, b As Integer, c As Integer, d As Integer, e As Integer)
        Select Case a
            Case operaciones.suma
                Console.WriteLine(b & " + " & c & " + " & d & " + " & e & " = " & Calcular(a, b, c, d, e))
            Case operaciones.resta
                Console.WriteLine(b & " - " & c & " - " & d & " - " & e & " = " & Calcular(a, b, c, d, e))
            Case operaciones.multiplicacion
                Console.WriteLine(b & " * " & c & " * " & d & " * " & e & " = " & Calcular(a, b, c, d, e))
            Case operaciones.division
                Console.WriteLine(b & " / " & c & " / " & d & " / " & e & " = " & Calcular(a, b, c, d, e))
        End Select
    End Sub

    Sub Resultado(a As Integer, b As Integer)
        Console.WriteLine(a & " + " & b & " = " & Calcular(operaciones.suma, a, b))
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
