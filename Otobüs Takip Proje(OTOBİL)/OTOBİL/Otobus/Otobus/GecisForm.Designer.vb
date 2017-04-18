<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GecisForm
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
        Me.BtnSeferBiletKes = New System.Windows.Forms.Button()
        Me.BtnUyeKaydi = New System.Windows.Forms.Button()
        Me.BtnUyeGuncelle = New System.Windows.Forms.Button()
        Me.BtnSefer = New System.Windows.Forms.Button()
        Me.BtnOtobus = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.otogunBtn = New System.Windows.Forms.Button()
        Me.seferguncelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSeferBiletKes
        '
        Me.BtnSeferBiletKes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSeferBiletKes.Location = New System.Drawing.Point(24, 12)
        Me.BtnSeferBiletKes.Name = "BtnSeferBiletKes"
        Me.BtnSeferBiletKes.Size = New System.Drawing.Size(92, 42)
        Me.BtnSeferBiletKes.TabIndex = 0
        Me.BtnSeferBiletKes.Text = "Seferler Bilet Kes"
        Me.BtnSeferBiletKes.UseVisualStyleBackColor = True
        '
        'BtnUyeKaydi
        '
        Me.BtnUyeKaydi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnUyeKaydi.Location = New System.Drawing.Point(24, 60)
        Me.BtnUyeKaydi.Name = "BtnUyeKaydi"
        Me.BtnUyeKaydi.Size = New System.Drawing.Size(92, 42)
        Me.BtnUyeKaydi.TabIndex = 0
        Me.BtnUyeKaydi.Text = "Üye Kaydı"
        Me.BtnUyeKaydi.UseVisualStyleBackColor = True
        '
        'BtnUyeGuncelle
        '
        Me.BtnUyeGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnUyeGuncelle.Location = New System.Drawing.Point(24, 108)
        Me.BtnUyeGuncelle.Name = "BtnUyeGuncelle"
        Me.BtnUyeGuncelle.Size = New System.Drawing.Size(92, 42)
        Me.BtnUyeGuncelle.TabIndex = 0
        Me.BtnUyeGuncelle.Text = "Üye Güncelleme"
        Me.BtnUyeGuncelle.UseVisualStyleBackColor = True
        '
        'BtnSefer
        '
        Me.BtnSefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnSefer.Location = New System.Drawing.Point(134, 59)
        Me.BtnSefer.Name = "BtnSefer"
        Me.BtnSefer.Size = New System.Drawing.Size(59, 42)
        Me.BtnSefer.TabIndex = 0
        Me.BtnSefer.Text = "Sefer Ekle"
        Me.BtnSefer.UseVisualStyleBackColor = True
        '
        'BtnOtobus
        '
        Me.BtnOtobus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnOtobus.Location = New System.Drawing.Point(134, 12)
        Me.BtnOtobus.Name = "BtnOtobus"
        Me.BtnOtobus.Size = New System.Drawing.Size(59, 42)
        Me.BtnOtobus.TabIndex = 0
        Me.BtnOtobus.Text = "Otobüs Ekle"
        Me.BtnOtobus.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button9.Location = New System.Drawing.Point(134, 108)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(148, 43)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Otobüs Nerede ?"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'otogunBtn
        '
        Me.otogunBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.otogunBtn.Location = New System.Drawing.Point(199, 12)
        Me.otogunBtn.Name = "otogunBtn"
        Me.otogunBtn.Size = New System.Drawing.Size(83, 42)
        Me.otogunBtn.TabIndex = 1
        Me.otogunBtn.Text = "Otobüs Güncelleştir"
        Me.otogunBtn.UseVisualStyleBackColor = True
        '
        'seferguncelBtn
        '
        Me.seferguncelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.seferguncelBtn.Location = New System.Drawing.Point(199, 60)
        Me.seferguncelBtn.Name = "seferguncelBtn"
        Me.seferguncelBtn.Size = New System.Drawing.Size(83, 41)
        Me.seferguncelBtn.TabIndex = 2
        Me.seferguncelBtn.Text = "Sefer Güncelleştir"
        Me.seferguncelBtn.UseVisualStyleBackColor = True
        '
        'GecisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(292, 161)
        Me.Controls.Add(Me.seferguncelBtn)
        Me.Controls.Add(Me.otogunBtn)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.BtnOtobus)
        Me.Controls.Add(Me.BtnSefer)
        Me.Controls.Add(Me.BtnUyeGuncelle)
        Me.Controls.Add(Me.BtnUyeKaydi)
        Me.Controls.Add(Me.BtnSeferBiletKes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GecisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GecisForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSeferBiletKes As Button
    Friend WithEvents BtnUyeKaydi As Button
    Friend WithEvents BtnUyeGuncelle As Button
    Friend WithEvents BtnSefer As Button
    Friend WithEvents BtnOtobus As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents otogunBtn As Button
    Friend WithEvents seferguncelBtn As Button
End Class
