<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.img_Person = New System.Windows.Forms.PictureBox()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.CBox_showPass = New System.Windows.Forms.CheckBox()
        CType(Me.img_Person, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Keluar
        '
        Me.btn_Keluar.BackColor = System.Drawing.Color.Red
        Me.btn_Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Keluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Keluar.Location = New System.Drawing.Point(204, 431)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(247, 33)
        Me.btn_Keluar.TabIndex = 21
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = False
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(204, 336)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(248, 23)
        Me.txt_Password.TabIndex = 19
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Password.Location = New System.Drawing.Point(204, 318)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(69, 17)
        Me.lbl_Password.TabIndex = 18
        Me.lbl_Password.Text = "Password"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(204, 280)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(248, 23)
        Me.txt_Username.TabIndex = 16
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Username.Location = New System.Drawing.Point(204, 262)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(73, 17)
        Me.lbl_Username.TabIndex = 15
        Me.lbl_Username.Text = "Username"
        '
        'txt_Address
        '
        Me.txt_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.Location = New System.Drawing.Point(204, 229)
        Me.txt_Address.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(248, 23)
        Me.txt_Address.TabIndex = 14
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_Address.Location = New System.Drawing.Point(204, 210)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(60, 17)
        Me.lbl_Address.TabIndex = 13
        Me.lbl_Address.Text = "Address"
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Login.Location = New System.Drawing.Point(215, 174)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(240, 26)
        Me.lbl_Login.TabIndex = 12
        Me.lbl_Login.Text = "Masuk Ke Akun Anda"
        '
        'img_Person
        '
        Me.img_Person.Image = CType(resources.GetObject("img_Person.Image"), System.Drawing.Image)
        Me.img_Person.Location = New System.Drawing.Point(252, 18)
        Me.img_Person.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_Person.Name = "img_Person"
        Me.img_Person.Size = New System.Drawing.Size(145, 137)
        Me.img_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_Person.TabIndex = 11
        Me.img_Person.TabStop = False
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.Blue
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMasuk.Location = New System.Drawing.Point(204, 395)
        Me.btnMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(247, 33)
        Me.btnMasuk.TabIndex = 22
        Me.btnMasuk.Text = "Masuk"
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'CBox_showPass
        '
        Me.CBox_showPass.AutoSize = True
        Me.CBox_showPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_showPass.Location = New System.Drawing.Point(204, 360)
        Me.CBox_showPass.Margin = New System.Windows.Forms.Padding(2)
        Me.CBox_showPass.Name = "CBox_showPass"
        Me.CBox_showPass.Size = New System.Drawing.Size(157, 21)
        Me.CBox_showPass.TabIndex = 23
        Me.CBox_showPass.Text = "Tampilkan Password"
        Me.CBox_showPass.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 486)
        Me.Controls.Add(Me.CBox_showPass)
        Me.Controls.Add(Me.btnMasuk)
        Me.Controls.Add(Me.btn_Keluar)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.lbl_Address)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.img_Person)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.img_Person, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Keluar As Button
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents lbl_Password As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents lbl_Username As Label
    Friend WithEvents txt_Address As TextBox
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_Login As Label
    Friend WithEvents img_Person As PictureBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents CBox_showPass As CheckBox
End Class
