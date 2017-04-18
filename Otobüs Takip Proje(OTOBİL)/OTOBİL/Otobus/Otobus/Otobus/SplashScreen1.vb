Public NotInheritable Class SplashScreen1
    Dim x As Int16 = 0
    'TODO: Bu form uygulama için kolayca karşılama ekranı olarak ayarlanabilir; "Uygulama" sekmesine gittiğiniz
    '  Proje Tasarımcısı'nda yapılır ("Proje" menüsü altındaki "Özellikler").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Uygulamanın derleme bilgisine göre çalışma zamanındaki iletişim metnini ayarlayın.  

        'TODO: Uygulamanın derleme bilgisini özelleştirin; "Uygulama" bölmesine gittiğiniz proje 
        '  özellikleri iletişim kutusunda yapılır ("Proje" menüsü altında).

        'Uygulama başlığı
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Uygulama başlığı yoksa, uygulama adını uzantısı olmadan kullanın
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Sürüm bilgilerini, çalışma zamanında Sürüm denetimindeki metin kümesini biçimlendirme
        '  dizesi olarak kullanarak biçimlendirin.  İsternirse, etkili yerelleştirmeye olanak sağlar.
        '  Yapı ve düzeltme bilgilerini dahil etmekte aşağıdaki kod kullanılabilir ve 
        '  Sürüm denetiminin tasarım zamanı metni "Sürüm {0}.{1:00}.{2}.{3}" veya benzeri olarak değiştirilebilir.  Daha fazla
        '  bilgi için bkz. Yardım altındaki String.Format().
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Telif Hakkı bilgileri
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        x = x + 1
        If x > 4 Then
            Timer1.Enabled = False
            MessageBox.Show("Hi")
            Form1.Show()
            Me.Close()

        End If
    End Sub
End Class
