<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtobusNerede
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
        Me.otobusLb = New System.Windows.Forms.ListBox()
        Me.gitBtn = New System.Windows.Forms.Button()
        Me.hepsiBtn = New System.Windows.Forms.Button()
        Me.BtnGeri = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'otobusLb
        '
        Me.otobusLb.FormattingEnabled = True
        Me.otobusLb.ItemHeight = 15
        Me.otobusLb.Location = New System.Drawing.Point(13, 12)
        Me.otobusLb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.otobusLb.Name = "otobusLb"
        Me.otobusLb.Size = New System.Drawing.Size(173, 349)
        Me.otobusLb.TabIndex = 0
        '
        'gitBtn
        '
        Me.gitBtn.Location = New System.Drawing.Point(225, 57)
        Me.gitBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gitBtn.Name = "gitBtn"
        Me.gitBtn.Size = New System.Drawing.Size(100, 60)
        Me.gitBtn.TabIndex = 1
        Me.gitBtn.Text = "Otobus Nerede ?"
        Me.gitBtn.UseVisualStyleBackColor = True
        '
        'hepsiBtn
        '
        Me.hepsiBtn.Location = New System.Drawing.Point(225, 141)
        Me.hepsiBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.hepsiBtn.Name = "hepsiBtn"
        Me.hepsiBtn.Size = New System.Drawing.Size(100, 58)
        Me.hepsiBtn.TabIndex = 2
        Me.hepsiBtn.Text = "Tüm Otobüsler"
        Me.hepsiBtn.UseVisualStyleBackColor = True
        '
        'BtnGeri
        '
        Me.BtnGeri.Location = New System.Drawing.Point(265, 12)
        Me.BtnGeri.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGeri.Name = "BtnGeri"
        Me.BtnGeri.Size = New System.Drawing.Size(53, 33)
        Me.BtnGeri.TabIndex = 3
        Me.BtnGeri.Text = "Geri"
        Me.BtnGeri.UseVisualStyleBackColor = True
        '
        'OtobusNerede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(331, 374)
        Me.Controls.Add(Me.BtnGeri)
        Me.Controls.Add(Me.hepsiBtn)
        Me.Controls.Add(Me.gitBtn)
        Me.Controls.Add(Me.otobusLb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "OtobusNerede"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otobüsüm Nerede"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents otobusLb As ListBox
    Friend WithEvents gitBtn As Button
    Friend WithEvents hepsiBtn As Button
    Friend WithEvents BtnGeri As Button
End Class
