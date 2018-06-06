Module Area
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim eleccion As Byte
    Enum figura As Byte
        cuadrado = 1
        rectangulo
        trapecio
    End Enum

    Sub Main()
        Console.WriteLine("Seleccione la figura...")
        Console.WriteLine("1 - Cuadrado")
        Console.WriteLine("2 - Rectangulo")
        Console.WriteLine("3 - Trapecio")
        eleccion = Console.ReadLine()

        Select Case eleccion
            Case figura.cuadrado
                Console.Write("Ingrese el lado: ")
                a = Console.ReadLine()
                Console.WriteLine("Area: " & Area(a))

            Case figura.rectangulo
                Console.Write("Ingrese la base: ")
                a = Console.ReadLine()
                Console.Write("Ingrese la altura: ")
                b = Console.ReadLine()
                Console.WriteLine("Area: " & Area(a, b))
            Case figura.trapecio
                Console.Write("Ingrese la base mayor: ")
                a = Console.ReadLine()
                Console.Write("Ingrese la base menor: ")
                b = Console.ReadLine()
                Console.Write("Ingrese la altura: ")
                c = Console.ReadLine()
                Console.WriteLine("Area: " & Area(a, b, c))
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub

    Function Area(a As Double) As Double
        Return a * a
    End Function

    Function Area(a As Double, b As Double) As Double
        Return a * b
    End Function

    Function Area(a As Double, b As Double, c As Double) As Double
        Return ((a + b) / 2) * c
    End Function

End Module
