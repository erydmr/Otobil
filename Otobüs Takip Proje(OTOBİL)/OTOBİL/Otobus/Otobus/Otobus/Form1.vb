Public Class Form1

    Public Sub Sec(ByVal x As String)
        LbSecili.Text = LbSecili.Text + x + ","
    End Sub

    Private Sub CbCinsiyet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCinsiyet1.SelectedIndexChanged
        If CbCinsiyet1.Text = "Bay" Then

            MessageBox.Show("Erkek")
        Else
            MessageBox.Show("Bayan")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub iki1_CheckedChanged(sender As Object, e As EventArgs) Handles iki1.CheckedChanged
        If iki1.Checked Then
            Sec(iki1.Text)
        Else

        End If


    End Sub

    Private Sub iki5_CheckedChanged(sender As Object, e As EventArgs) Handles iki5.CheckedChanged
        Sec(iki5.Text)
    End Sub

    Private Sub iki9_CheckedChanged(sender As Object, e As EventArgs) Handles iki9.CheckedChanged
        Sec(iki9.Text)
    End Sub



    Private Sub iki43_CheckedChanged(sender As Object, e As EventArgs) Handles iki43.CheckedChanged, iki3.CheckedChanged
        Dim check As CheckBox = sender
        MessageBox.Show(check.Text)




    End Sub
    'Checklerde TextBeforeImage=TextBeforeImage
    'imageAlign MiddleRight
    'image özelliğine konacak resim...
    Private Sub iki2_CheckedChanged(sender As Object, e As EventArgs) Handles iki2.CheckedChanged

    End Sub
End Class
