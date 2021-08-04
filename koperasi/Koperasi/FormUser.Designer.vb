<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.group_DaftarUserProgram = New System.Windows.Forms.GroupBox()
        Me.lbl_JumUser = New System.Windows.Forms.Label()
        Me.dgv_DaftarUser = New System.Windows.Forms.DataGridView()
        Me.txt_CariUser = New System.Windows.Forms.TextBox()
        Me.lbl_CariUser = New System.Windows.Forms.Label()
        Me.group_InputDataGroup = New System.Windows.Forms.GroupBox()
        Me.txt_idUser = New System.Windows.Forms.TextBox()
        Me.lbl_idUser = New System.Windows.Forms.Label()
        Me.cekBox_ShowPass = New System.Windows.Forms.CheckBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txt_UlangiPass = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_NamaLengkap = New System.Windows.Forms.TextBox()
        Me.cmb_Group = New System.Windows.Forms.ComboBox()
        Me.lbl_UlangiPass = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_NamaUser = New System.Windows.Forms.Label()
        Me.lbl_NamaLengkap = New System.Windows.Forms.Label()
        Me.lbl_Group = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_DaftarUserProgram.SuspendLayout()
        CType(Me.dgv_DaftarUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_InputDataGroup.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(423, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Form ini digunakan untuk membuat User yang akan menggunakan program"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(17, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form User"
        '
        'group_DaftarUserProgram
        '
        Me.group_DaftarUserProgram.Controls.Add(Me.lbl_JumUser)
        Me.group_DaftarUserProgram.Controls.Add(Me.dgv_DaftarUser)
        Me.group_DaftarUserProgram.Controls.Add(Me.txt_CariUser)
        Me.group_DaftarUserProgram.Controls.Add(Me.lbl_CariUser)
        Me.group_DaftarUserProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DaftarUserProgram.Location = New System.Drawing.Point(10, 67)
        Me.group_DaftarUserProgram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DaftarUserProgram.Name = "group_DaftarUserProgram"
        Me.group_DaftarUserProgram.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DaftarUserProgram.Size = New System.Drawing.Size(415, 221)
        Me.group_DaftarUserProgram.TabIndex = 1
        Me.group_DaftarUserProgram.TabStop = False
        Me.group_DaftarUserProgram.Text = "Daftar User Program"
        '
        'lbl_JumUser
        '
        Me.lbl_JumUser.AutoSize = True
        Me.lbl_JumUser.Location = New System.Drawing.Point(8, 180)
        Me.lbl_JumUser.Name = "lbl_JumUser"
        Me.lbl_JumUser.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumUser.TabIndex = 3
        Me.lbl_JumUser.Text = "Jumlah User : 1"
        '
        'dgv_DaftarUser
        '
        Me.dgv_DaftarUser.AllowUserToAddRows = False
        Me.dgv_DaftarUser.AllowUserToDeleteRows = False
        Me.dgv_DaftarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DaftarUser.Location = New System.Drawing.Point(8, 49)
        Me.dgv_DaftarUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DaftarUser.Name = "dgv_DaftarUser"
        Me.dgv_DaftarUser.ReadOnly = True
        Me.dgv_DaftarUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgv_DaftarUser.RowHeadersWidth = 51
        Me.dgv_DaftarUser.RowTemplate.Height = 29
        Me.dgv_DaftarUser.Size = New System.Drawing.Size(397, 122)
        Me.dgv_DaftarUser.TabIndex = 2
        '
        'txt_CariUser
        '
        Me.txt_CariUser.Location = New System.Drawing.Point(63, 20)
        Me.txt_CariUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_CariUser.Name = "txt_CariUser"
        Me.txt_CariUser.Size = New System.Drawing.Size(343, 20)
        Me.txt_CariUser.TabIndex = 1
        '
        'lbl_CariUser
        '
        Me.lbl_CariUser.AutoSize = True
        Me.lbl_CariUser.Location = New System.Drawing.Point(8, 23)
        Me.lbl_CariUser.Name = "lbl_CariUser"
        Me.lbl_CariUser.Size = New System.Drawing.Size(58, 15)
        Me.lbl_CariUser.TabIndex = 0
        Me.lbl_CariUser.Text = "Cari User"
        '
        'group_InputDataGroup
        '
        Me.group_InputDataGroup.Controls.Add(Me.txt_idUser)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_idUser)
        Me.group_InputDataGroup.Controls.Add(Me.cekBox_ShowPass)
        Me.group_InputDataGroup.Controls.Add(Me.btnSimpan)
        Me.group_InputDataGroup.Controls.Add(Me.btnBatal)
        Me.group_InputDataGroup.Controls.Add(Me.txt_UlangiPass)
        Me.group_InputDataGroup.Controls.Add(Me.txt_Password)
        Me.group_InputDataGroup.Controls.Add(Me.txt_Username)
        Me.group_InputDataGroup.Controls.Add(Me.txt_NamaLengkap)
        Me.group_InputDataGroup.Controls.Add(Me.cmb_Group)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_UlangiPass)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_Password)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_NamaUser)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_NamaLengkap)
        Me.group_InputDataGroup.Controls.Add(Me.lbl_Group)
        Me.group_InputDataGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InputDataGroup.Location = New System.Drawing.Point(429, 67)
        Me.group_InputDataGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InputDataGroup.Name = "group_InputDataGroup"
        Me.group_InputDataGroup.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InputDataGroup.Size = New System.Drawing.Size(431, 221)
        Me.group_InputDataGroup.TabIndex = 2
        Me.group_InputDataGroup.TabStop = False
        Me.group_InputDataGroup.Text = "Input Data Group"
        '
        'txt_idUser
        '
        Me.txt_idUser.Location = New System.Drawing.Point(111, 61)
        Me.txt_idUser.Name = "txt_idUser"
        Me.txt_idUser.Size = New System.Drawing.Size(133, 20)
        Me.txt_idUser.TabIndex = 15
        '
        'lbl_idUser
        '
        Me.lbl_idUser.AutoSize = True
        Me.lbl_idUser.Location = New System.Drawing.Point(11, 64)
        Me.lbl_idUser.Name = "lbl_idUser"
        Me.lbl_idUser.Size = New System.Drawing.Size(48, 15)
        Me.lbl_idUser.TabIndex = 14
        Me.lbl_idUser.Text = "ID User"
        '
        'cekBox_ShowPass
        '
        Me.cekBox_ShowPass.AutoSize = True
        Me.cekBox_ShowPass.Location = New System.Drawing.Point(291, 136)
        Me.cekBox_ShowPass.Margin = New System.Windows.Forms.Padding(2)
        Me.cekBox_ShowPass.Name = "cekBox_ShowPass"
        Me.cekBox_ShowPass.Size = New System.Drawing.Size(140, 19)
        Me.cekBox_ShowPass.TabIndex = 13
        Me.cekBox_ShowPass.Text = "Tampilkan password"
        Me.cekBox_ShowPass.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(111, 193)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(79, 24)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(194, 193)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(79, 24)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txt_UlangiPass
        '
        Me.txt_UlangiPass.Location = New System.Drawing.Point(111, 160)
        Me.txt_UlangiPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_UlangiPass.Name = "txt_UlangiPass"
        Me.txt_UlangiPass.Size = New System.Drawing.Size(174, 20)
        Me.txt_UlangiPass.TabIndex = 9
        Me.txt_UlangiPass.UseSystemPasswordChar = True
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(111, 136)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(174, 20)
        Me.txt_Password.TabIndex = 8
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(111, 112)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(308, 20)
        Me.txt_Username.TabIndex = 7
        '
        'txt_NamaLengkap
        '
        Me.txt_NamaLengkap.Location = New System.Drawing.Point(111, 88)
        Me.txt_NamaLengkap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_NamaLengkap.Name = "txt_NamaLengkap"
        Me.txt_NamaLengkap.Size = New System.Drawing.Size(308, 20)
        Me.txt_NamaLengkap.TabIndex = 6
        '
        'cmb_Group
        '
        Me.cmb_Group.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Group.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_Group.FormattingEnabled = True
        Me.cmb_Group.Location = New System.Drawing.Point(111, 18)
        Me.cmb_Group.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Group.Name = "cmb_Group"
        Me.cmb_Group.Size = New System.Drawing.Size(249, 21)
        Me.cmb_Group.TabIndex = 5
        '
        'lbl_UlangiPass
        '
        Me.lbl_UlangiPass.AutoSize = True
        Me.lbl_UlangiPass.Location = New System.Drawing.Point(11, 151)
        Me.lbl_UlangiPass.Name = "lbl_UlangiPass"
        Me.lbl_UlangiPass.Size = New System.Drawing.Size(100, 15)
        Me.lbl_UlangiPass.TabIndex = 4
        Me.lbl_UlangiPass.Text = "Ulangi Password"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Location = New System.Drawing.Point(11, 129)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(61, 15)
        Me.lbl_Password.TabIndex = 3
        Me.lbl_Password.Text = "Password"
        '
        'lbl_NamaUser
        '
        Me.lbl_NamaUser.AutoSize = True
        Me.lbl_NamaUser.Location = New System.Drawing.Point(11, 107)
        Me.lbl_NamaUser.Name = "lbl_NamaUser"
        Me.lbl_NamaUser.Size = New System.Drawing.Size(48, 15)
        Me.lbl_NamaUser.TabIndex = 2
        Me.lbl_NamaUser.Text = "ID User"
        '
        'lbl_NamaLengkap
        '
        Me.lbl_NamaLengkap.AutoSize = True
        Me.lbl_NamaLengkap.Location = New System.Drawing.Point(11, 85)
        Me.lbl_NamaLengkap.Name = "lbl_NamaLengkap"
        Me.lbl_NamaLengkap.Size = New System.Drawing.Size(92, 15)
        Me.lbl_NamaLengkap.TabIndex = 1
        Me.lbl_NamaLengkap.Text = "Nama Lengkap"
        '
        'lbl_Group
        '
        Me.lbl_Group.AutoSize = True
        Me.lbl_Group.Location = New System.Drawing.Point(11, 20)
        Me.lbl_Group.Name = "lbl_Group"
        Me.lbl_Group.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Group.TabIndex = 0
        Me.lbl_Group.Text = "Group"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(101, 15)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(79, 24)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(18, 15)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(79, 24)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btnHapus)
        Me.grupBtn.Controls.Add(Me.btnTambah)
        Me.grupBtn.Controls.Add(Me.btnKeluar)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 292)
        Me.grupBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupBtn.Size = New System.Drawing.Size(866, 44)
        Me.grupBtn.TabIndex = 2
        Me.grupBtn.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(710, 15)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(79, 24)
        Me.btnKeluar.TabIndex = 13
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 336)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_InputDataGroup)
        Me.Controls.Add(Me.group_DaftarUserProgram)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DaftarUserProgram.ResumeLayout(False)
        Me.group_DaftarUserProgram.PerformLayout()
        CType(Me.dgv_DaftarUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_InputDataGroup.ResumeLayout(False)
        Me.group_InputDataGroup.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents group_DaftarUserProgram As GroupBox
    Friend WithEvents lbl_JumUser As Label
    Friend WithEvents dgv_DaftarUser As DataGridView
    Friend WithEvents txt_CariUser As TextBox
    Friend WithEvents lbl_CariUser As Label
    Friend WithEvents group_InputDataGroup As GroupBox
    Friend WithEvents txt_UlangiPass As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_NamaLengkap As TextBox
    Friend WithEvents cmb_Group As ComboBox
    Friend WithEvents lbl_UlangiPass As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_NamaUser As Label
    Friend WithEvents lbl_NamaLengkap As Label
    Friend WithEvents lbl_Group As Label
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cekBox_ShowPass As CheckBox
    Friend WithEvents txt_idUser As TextBox
    Friend WithEvents lbl_idUser As Label
End Class
