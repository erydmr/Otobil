Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Login
    Dim oku As MySqlDataReader
    Dim MySqlConn As New MySqlConnection
    Dim komut As New MySqlCommand
    Private Sub BtnCikis_click(sender As Object, e As EventArgs) Handles BtnCikis.Click
        Application.Exit()
    End Sub
    Sub Giris()
        Try
            MySqlConn.Open()
            komut.Connection = MySqlConn
            komut.CommandText = "Select * from yonetim where kullanici_adi='" & TxtAd.Text & "' and sifre='" & TxtSifre.Text & "'"
            komut.Connection = MySqlConn
            oku = komut.ExecuteReader()
            If (oku.Read()) Then
                MsgBox("Sorunsuz Bir Şekide Giriş Yapıldı.")
                Dim x = New GecisForm
                x.Show()
                Me.Close()
            Else
                MsgBox("Şifre Veya Kullanıcı Adı Yanlış. Lütfen Tekrar Deneyiniz .")
            End If
            oku.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Sub GuvenlikSifre()
        Randomize()
        Dim RastgeleSayi As New Random
        Dim OlusturulanSayi As Integer = RastgeleSayi.Next(1000, 9999)
        LblGüvenlikKod.Text = OlusturulanSayi.ToString
    End Sub
    Private Sub BtnGiris_Click(sender As Object, e As EventArgs) Handles BtnGiris.Click
        If TxtAd.Text = "" Or TxtSifre.Text = "" Or TxtGüvenlikKod.Text = "" Then
            MessageBox.Show("Boş Alanları Doldurunuz.Lütfen tekrar Deneyiniz.")
        ElseIf TxtGüvenlikKod.Text = LblGüvenlikKod.Text Then
            Giris()
        End If
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuvenlikSifre()
        MySqlConn.ConnectionString = "Server=sql11.freemysqlhosting.net;Database=sql11168214;Uid=sql11168214;Password=4Ci7FaFEF8;"
    End Sub
    Private Sub BtnGuvenlikKod_Click(sender As Object, e As EventArgs) Handles BtnGuvenlikKod.Click
        GuvenlikSifre()
    End Sub
End Class