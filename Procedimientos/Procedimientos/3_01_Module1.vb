Module Module1
    Dim Hoy As Date = Now
    Sub Main()
        Fecha()
        Console.WriteLine(Hora())
    End Sub

    Sub Fecha()
        Console.WriteLine(Hoy.Date)
    End Sub

    Function Hora()
        Dim a As TimeSpan
        a = Hoy.TimeOfDay
        Return a
    End Function

End Module
