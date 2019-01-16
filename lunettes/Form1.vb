Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim query = From wClient In ListeClient
                    Group Join wLunettes In ListLunettes
                        On wClient.Id Equals wLunettes.clientID
                        Into lunettesClients = Group
                    Select wClient, lunettesClients

        For Each wItem In query
            NomClient.Text = wItem.wClient.Nom & " " & wItem.wClient.PreNom
            For Each wLunettes In wItem.lunettesClients
                lstLun.Items.Add(wLunettes.Monture)
                For Each wverre In wLunettes.VerreList
                    lstLun.Items.Add(wverre.Nom)
                Next
            Next
        Next
    End Sub
End Class
