Public Class GecisForm
    Private Sub BtnSeferBiletKes_Click(sender As Object, e As EventArgs) Handles BtnSeferBiletKes.Click
        Dim x = New Sefer
        x.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnUyeKaydi.Click
        Dim x = New UyeEkle
        x.Show()
        Me.Close()
    End Sub
    Private Sub BtnOtobus_Click(sender As Object, e As EventArgs) Handles BtnOtobus.Click
        Dim x = New OtobusEkle
        x.Show()
        Me.Close()
    End Sub
    Private Sub BtnUyeGuncelle_Click(sender As Object, e As EventArgs) Handles BtnUyeGuncelle.Click
        Dim x = New UyeGuncellestir
        x.Show()
        Me.Close()
    End Sub
    Private Sub otogunBtn_Click(sender As Object, e As EventArgs) Handles otogunBtn.Click
        Dim x = New OtobusGuncellestir
        x.Show()
        Me.Close()
    End Sub
    Private Sub BtnSefer_Click(sender As Object, e As EventArgs) Handles BtnSefer.Click
        Dim x = New SeferEkle
        x.Show()
        Me.Close()
    End Sub
    Private Sub seferguncelBtn_Click(sender As Object, e As EventArgs) Handles seferguncelBtn.Click
        Dim x = New SeferGuncellestir
        x.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim x = New OtobusNerede
        x.Show()
        Me.Close()
    End Sub
End Class