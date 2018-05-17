Module SumaFecha
    Sub Main()
        Dim fecha As Date
        Dim dias As Integer

        Console.WriteLine("Ingrese una fecha:   Estructura DD/MM/AAAA")
        fecha = Console.ReadLine()

        Console.WriteLine("Ingrese dias a sumar :")
        dias = Console.ReadLine()

        Console.WriteLine(Suma(fecha, dias))

    End Sub

    Function Suma(a As Date, b As Integer)
        Dim resultado As Date
        resultado = a.AddDays(b)
        Return resultado
    End Function

End Module
