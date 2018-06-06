Module Module1
    Dim Hoy As Date = Now
    Dim Fech As DateTime = DateTime.Today
    Sub Main()
        Fecha()
        Console.WriteLine(Hora())


        Fecha2()
        Console.WriteLine(Hora2())
    End Sub

    Sub Fecha()
        Console.WriteLine(Hoy.Date)
    End Sub

    Function Hora() As TimeSpan
        Dim a As TimeSpan
        a = Hoy.TimeOfDay
        Return a
    End Function


    Sub Fecha2()
        Console.WriteLine("La fecha actual es: " & Fech.ToString("D"))
    End Sub

    Function Hora2() As String
        Return Now.ToString("HH:mm:ss")
    End Function

End Module
