<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnGiris = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCikis = New System.Windows.Forms.Button()
        Me.TxtAd = New System.Windows.Forms.MaskedTextBox()
        Me.TxtSifre = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblGüvenlikKod = New System.Windows.Forms.Label()
        Me.TxtGüvenlikKod = New System.Windows.Forms.TextBox()
        Me.BtnGuvenlikKod = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGiris
        '
        Me.BtnGiris.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGiris.Location = New System.Drawing.Point(79, 141)
        Me.BtnGiris.Name = "BtnGiris"
        Me.BtnGiris.Size = New System.Drawing.Size(75, 38)
        Me.BtnGiris.TabIndex = 3
        Me.BtnGiris.Text = "Giriş"
        Me.BtnGiris.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Şifre"
        '
        'BtnCikis
        '
        Me.BtnCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnCikis.Location = New System.Drawing.Point(160, 141)
        Me.BtnCikis.Name = "BtnCikis"
        Me.BtnCikis.Size = New System.Drawing.Size(75, 38)
        Me.BtnCikis.TabIndex = 4
        Me.BtnCikis.Text = "Çıkış"
        Me.BtnCikis.UseVisualStyleBackColor = True
        '
        'TxtAd
        '
        Me.TxtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtAd.Location = New System.Drawing.Point(125, 20)
        Me.TxtAd.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAd.Name = "TxtAd"
        Me.TxtAd.Size = New System.Drawing.Size(100, 21)
        Me.TxtAd.TabIndex = 0
        '
        'TxtSifre
        '
        Me.TxtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtSifre.Location = New System.Drawing.Point(125, 47)
        Me.TxtSifre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSifre.Name = "TxtSifre"
        Me.TxtSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSifre.Size = New System.Drawing.Size(100, 21)
        Me.TxtSifre.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(268, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hızlı ve Kolay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Güvenli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(349, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Yenilikçi"
        '
        'LblGüvenlikKod
        '
        Me.LblGüvenlikKod.AutoSize = True
        Me.LblGüvenlikKod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LblGüvenlikKod.Location = New System.Drawing.Point(126, 107)
        Me.LblGüvenlikKod.Name = "LblGüvenlikKod"
        Me.LblGüvenlikKod.Size = New System.Drawing.Size(33, 20)
        Me.LblGüvenlikKod.TabIndex = 9
        Me.LblGüvenlikKod.Text = "----"
        '
        'TxtGüvenlikKod
        '
        Me.TxtGüvenlikKod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtGüvenlikKod.Location = New System.Drawing.Point(125, 77)
        Me.TxtGüvenlikKod.Name = "TxtGüvenlikKod"
        Me.TxtGüvenlikKod.Size = New System.Drawing.Size(100, 21)
        Me.TxtGüvenlikKod.TabIndex = 2
        '
        'BtnGuvenlikKod
        '
        Me.BtnGuvenlikKod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnGuvenlikKod.Location = New System.Drawing.Point(237, 99)
        Me.BtnGuvenlikKod.Name = "BtnGuvenlikKod"
        Me.BtnGuvenlikKod.Size = New System.Drawing.Size(100, 32)
        Me.BtnGuvenlikKod.TabIndex = 5
        Me.BtnGuvenlikKod.Text = "Şifreyi Yenile"
        Me.BtnGuvenlikKod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Güvenlik Kodu"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(481, 186)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnGuvenlikKod)
        Me.Controls.Add(Me.TxtGüvenlikKod)
        Me.Controls.Add(Me.LblGüvenlikKod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtSifre)
        Me.Controls.Add(Me.TxtAd)
        Me.Controls.Add(Me.BtnCikis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGiris)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGiris As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCikis As Button
    Friend WithEvents TxtAd As MaskedTextBox
    Friend WithEvents TxtSifre As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblGüvenlikKod As Label
    Friend WithEvents TxtGüvenlikKod As TextBox
    Friend WithEvents BtnGuvenlikKod As Button
    Friend WithEvents Label6 As Label
End Class
