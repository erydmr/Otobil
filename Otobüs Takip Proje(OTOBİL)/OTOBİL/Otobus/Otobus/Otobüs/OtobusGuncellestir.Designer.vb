<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtobusGuncellestir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.otobusLb = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.guncellestirBtn = New System.Windows.Forms.Button()
        Me.silBtn = New System.Windows.Forms.Button()
        Me.TxtAd = New System.Windows.Forms.MaskedTextBox()
        Me.CbTur = New System.Windows.Forms.MaskedTextBox()
        Me.plakaTxt = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCepTel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'otobusLb
        '
        Me.otobusLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.otobusLb.FormattingEnabled = True
        Me.otobusLb.ItemHeight = 15
        Me.otobusLb.Location = New System.Drawing.Point(12, 3)
        Me.otobusLb.Name = "otobusLb"
        Me.otobusLb.Size = New System.Drawing.Size(206, 349)
        Me.otobusLb.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(371, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Türü"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Plaka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Cep Telefon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Şöför Ad"
        '
        'guncellestirBtn
        '
        Me.guncellestirBtn.BackColor = System.Drawing.Color.Red
        Me.guncellestirBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.guncellestirBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.guncellestirBtn.Location = New System.Drawing.Point(233, 176)
        Me.guncellestirBtn.Name = "guncellestirBtn"
        Me.guncellestirBtn.Size = New System.Drawing.Size(113, 42)
        Me.guncellestirBtn.TabIndex = 4
        Me.guncellestirBtn.Text = "Güncelleştir"
        Me.guncellestirBtn.UseVisualStyleBackColor = False
        '
        'silBtn
        '
        Me.silBtn.BackColor = System.Drawing.Color.Red
        Me.silBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.silBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.silBtn.Location = New System.Drawing.Point(365, 176)
        Me.silBtn.Name = "silBtn"
        Me.silBtn.Size = New System.Drawing.Size(84, 42)
        Me.silBtn.TabIndex = 5
        Me.silBtn.Text = "Sil"
        Me.silBtn.UseVisualStyleBackColor = False
        '
        'TxtAd
        '
        Me.TxtAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtAd.Location = New System.Drawing.Point(323, 42)
        Me.TxtAd.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAd.Name = "TxtAd"
        Me.TxtAd.Size = New System.Drawing.Size(126, 21)
        Me.TxtAd.TabIndex = 0
        '
        'CbTur
        '
        Me.CbTur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CbTur.Location = New System.Drawing.Point(323, 133)
        Me.CbTur.Margin = New System.Windows.Forms.Padding(2)
        Me.CbTur.Name = "CbTur"
        Me.CbTur.Size = New System.Drawing.Size(126, 21)
        Me.CbTur.TabIndex = 3
        '
        'plakaTxt
        '
        Me.plakaTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.plakaTxt.Location = New System.Drawing.Point(323, 102)
        Me.plakaTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.plakaTxt.Name = "plakaTxt"
        Me.plakaTxt.Size = New System.Drawing.Size(126, 21)
        Me.plakaTxt.TabIndex = 2
        '
        'TxtCepTel
        '
        Me.TxtCepTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TxtCepTel.Location = New System.Drawing.Point(323, 74)
        Me.TxtCepTel.Name = "TxtCepTel"
        Me.TxtCepTel.Size = New System.Drawing.Size(126, 21)
        Me.TxtCepTel.TabIndex = 1
        '
        'OtobusGuncellestir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(461, 361)
        Me.Controls.Add(Me.TxtCepTel)
        Me.Controls.Add(Me.plakaTxt)
        Me.Controls.Add(Me.CbTur)
        Me.Controls.Add(Me.TxtAd)
        Me.Controls.Add(Me.silBtn)
        Me.Controls.Add(Me.guncellestirBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.otobusLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OtobusGuncellestir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otobüs Guncellestir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents otobusLb As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents guncellestirBtn As Button
    Friend WithEvents silBtn As Button
    Friend WithEvents TxtAd As MaskedTextBox
    Friend WithEvents CbTur As MaskedTextBox
    Friend WithEvents plakaTxt As MaskedTextBox
    Friend WithEvents TxtCepTel As TextBox
End Class
