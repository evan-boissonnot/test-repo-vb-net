Module Donnees

    Public ListVerre As New List(Of Verre) From
        {
            New Verre() With {.Id = 0, .Nom = "Orma"},
            New Verre() With {.Id = 1, .Nom = "Ormix"},
            New Verre() With {.Id = 2, .Nom = "Varilux"}
         }

    Public ListeClient As New List(Of Client) From
    {
       New Client() With {.Nom = "Dupond", .PreNom = "Archibal", .CA = 15000, .Id = 3}
    }

    'New Client() With {.Nom = "Martin", .PreNom = "Jean-Yves", .CA = 10000, .Id = 1},
    'New Client() With {.Nom = "Durand", .PreNom = "Jean-Piere", .CA = 20000, .Id = 2},

    Public ListLunettes As New List(Of Lunette) From
    {
        New Lunette() With {.Monture = "Rayban", .clientID = 1, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(0), ListVerre(0)}},
        New Lunette() With {.Monture = "Rayban", .clientID = 1, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(1), ListVerre(1)}},
        New Lunette() With {.Monture = "Channel", .clientID = 2, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(2), ListVerre(2)}},
        New Lunette() With {.Monture = "RipCurl", .clientID = 3, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(1), ListVerre(1)}},
        New Lunette() With {.Monture = "Channel", .clientID = 3, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(0), ListVerre(0)}},
        New Lunette() With {.Monture = "Rayban", .clientID = 3, .prix = 100, .VerreList = New List(Of Verre)() From {ListVerre(2), ListVerre(2)}}
    }

End Module
