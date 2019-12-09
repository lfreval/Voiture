Module Module1

    Dim voiTure As New Hashtable

    Sub parasite()
        voiTure("kilometrage") = -30
    End Sub

    Sub Main()
        voiTure.Add("kilometrage", 0)
        voiTure("kilometrage") += 12
        parasite()
        Console.WriteLine(voiTure("kilometrage"))
        Console.ReadKey()
    End Sub

End Module
