Module OperacionesSobrecargas2
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

    Sub Resultado(ByRef a As Byte, ByVal b As Integer, ByVal c As Integer)
        Select Case a
            Case 1
                Console.WriteLine(b & " + " & c & " = " & Calcular(a, b, c))
            Case 2
                Console.WriteLine(b & " - " & c & " = " & Calcular(a, b, c))
            Case 3
                Console.WriteLine(b & " * " & c & " = " & Calcular(a, b, c))
            Case 4
                Console.WriteLine(b & " / " & c & " = " & Calcular(a, b, c))
        End Select
    End Sub

    Sub Resultado(ByRef a As Byte, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer)
        Select Case a
            Case 1
                Console.WriteLine(b & " + " & c & " + " & d & " = " & Calcular(a, b, c, d))
            Case 2
                Console.WriteLine(b & " - " & c & " - " & d & " = " & Calcular(a, b, c, d))
            Case 3
                Console.WriteLine(b & " * " & c & " * " & d & " = " & Calcular(a, b, c, d))
            Case 4
                Console.WriteLine(b & " / " & c & " / " & d & " = " & Calcular(a, b, c, d))
        End Select
    End Sub

    Sub Resultado(ByRef a As Byte, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer)
        Select Case a
            Case 1
                Console.WriteLine(b & " + " & c & " + " & d & " + " & e & " = " & Calcular(a, b, c, d, e))
            Case 2
                Console.WriteLine(b & " - " & c & " - " & d & " + " & e & " = " & Calcular(a, b, c, d, e))
            Case 3
                Console.WriteLine(b & " * " & c & " * " & d & " + " & e & " = " & Calcular(a, b, c, d, e))
            Case 4
                Console.WriteLine(b & " / " & c & " / " & d & " + " & e & " = " & Calcular(a, b, c, d, e))
        End Select
    End Sub

    Sub Resultado(ByVal a As Integer, ByVal b As Integer)
        Console.WriteLine(a & " + " & b & " = " & Calcular(operaciones.suma, a, b))
    End Sub

    Function Calcular(ByRef operacion As Byte, ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer
        Select Case operacion
            Case 1
                x = a + b
            Case 2
                x = a - b
            Case 3
                x = a * b
            Case 4
                x = a / b
        End Select
        Return x
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
