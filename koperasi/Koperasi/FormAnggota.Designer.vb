<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnggota
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
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_ImportAnggotaExcel = New System.Windows.Forms.Button()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Ubah = New System.Windows.Forms.Button()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.btn_CetakKartu = New System.Windows.Forms.Button()
        Me.dtp_TglLahir = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_TglLahir = New System.Windows.Forms.Label()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.dtp_TglDaftar = New System.Windows.Forms.DateTimePicker()
        Me.txt_TelpSaudara = New System.Windows.Forms.TextBox()
        Me.txt_NamaSaudara = New System.Windows.Forms.TextBox()
        Me.cmb_Pekerjaan = New System.Windows.Forms.ComboBox()
        Me.cmb_Status = New System.Windows.Forms.ComboBox()
        Me.txt_NoTelp = New System.Windows.Forms.TextBox()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.txt_TmptLahir = New System.Windows.Forms.TextBox()
        Me.cmb_JK = New System.Windows.Forms.ComboBox()
        Me.txt_NoKTP = New System.Windows.Forms.TextBox()
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.lbl_TglDaftar = New System.Windows.Forms.Label()
        Me.lbl_TelpSaudara = New System.Windows.Forms.Label()
        Me.lbl_NamaSaudara = New System.Windows.Forms.Label()
        Me.lbl_Pekerjaan = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_NoTelp = New System.Windows.Forms.Label()
        Me.lbl_JK = New System.Windows.Forms.Label()
        Me.lbl_Alamat = New System.Windows.Forms.Label()
        Me.lbl_TempatLhr = New System.Windows.Forms.Label()
        Me.lbl_NoKTP = New System.Windows.Forms.Label()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.lbl_KodeAnggota = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumlahData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grupBtn.SuspendLayout()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupBtn
        '
        Me.grupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grupBtn.Controls.Add(Me.btn_Keluar)
        Me.grupBtn.Controls.Add(Me.btn_ImportAnggotaExcel)
        Me.grupBtn.Controls.Add(Me.btn_Hapus)
        Me.grupBtn.Controls.Add(Me.btn_Ubah)
        Me.grupBtn.Controls.Add(Me.btn_Tambah)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupBtn.Location = New System.Drawing.Point(0, 544)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(1219, 62)
        Me.grupBtn.TabIndex = 7
        Me.grupBtn.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(1082, 29)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(106, 26)
        Me.btn_Keluar.TabIndex = 29
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_ImportAnggotaExcel
        '
        Me.btn_ImportAnggotaExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_ImportAnggotaExcel.Location = New System.Drawing.Point(493, 25)
        Me.btn_ImportAnggotaExcel.Name = "btn_ImportAnggotaExcel"
        Me.btn_ImportAnggotaExcel.Size = New System.Drawing.Size(263, 26)
        Me.btn_ImportAnggotaExcel.TabIndex = 28
        Me.btn_ImportAnggotaExcel.Text = "Import Anggota Excel"
        Me.btn_ImportAnggotaExcel.UseVisualStyleBackColor = True
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hapus.Location = New System.Drawing.Point(291, 25)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(106, 26)
        Me.btn_Hapus.TabIndex = 27
        Me.btn_Hapus.Text = "Hapus"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Ubah
        '
        Me.btn_Ubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Ubah.Location = New System.Drawing.Point(159, 25)
        Me.btn_Ubah.Name = "btn_Ubah"
        Me.btn_Ubah.Size = New System.Drawing.Size(106, 26)
        Me.btn_Ubah.TabIndex = 26
        Me.btn_Ubah.Text = "Ubah"
        Me.btn_Ubah.UseVisualStyleBackColor = True
        '
        'btn_Tambah
        '
        Me.btn_Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Tambah.Location = New System.Drawing.Point(18, 24)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(106, 26)
        Me.btn_Tambah.TabIndex = 25
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = True
        '
        'btn_CetakKartu
        '
        Me.btn_CetakKartu.Location = New System.Drawing.Point(382, 406)
        Me.btn_CetakKartu.Name = "btn_CetakKartu"
        Me.btn_CetakKartu.Size = New System.Drawing.Size(106, 26)
        Me.btn_CetakKartu.TabIndex = 11
        Me.btn_CetakKartu.Text = "Cetak Kartu"
        Me.btn_CetakKartu.UseVisualStyleBackColor = True
        '
        'dtp_TglLahir
        '
        Me.dtp_TglLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TglLahir.Location = New System.Drawing.Point(512, 113)
        Me.dtp_TglLahir.Name = "dtp_TglLahir"
        Me.dtp_TglLahir.Size = New System.Drawing.Size(142, 20)
        Me.dtp_TglLahir.TabIndex = 27
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(27, 33)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(378, 17)
        Me.lbl_Subjudul.TabIndex = 3
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk menambahkan anggota koperasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_TglLahir
        '
        Me.lbl_TglLahir.AutoSize = True
        Me.lbl_TglLahir.Location = New System.Drawing.Point(380, 118)
        Me.lbl_TglLahir.Name = "lbl_TglLahir"
        Me.lbl_TglLahir.Size = New System.Drawing.Size(83, 15)
        Me.lbl_TglLahir.TabIndex = 26
        Me.lbl_TglLahir.Text = "Tanggal Lahir"
        '
        'btn_Batal
        '
        Me.btn_Batal.Location = New System.Drawing.Point(273, 400)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(106, 26)
        Me.btn_Batal.TabIndex = 25
        Me.btn_Batal.Text = "Batal"
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Location = New System.Drawing.Point(161, 400)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(106, 26)
        Me.btn_Simpan.TabIndex = 24
        Me.btn_Simpan.Text = "Simpan"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'dtp_TglDaftar
        '
        Me.dtp_TglDaftar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TglDaftar.Location = New System.Drawing.Point(164, 355)
        Me.dtp_TglDaftar.Name = "dtp_TglDaftar"
        Me.dtp_TglDaftar.Size = New System.Drawing.Size(144, 20)
        Me.dtp_TglDaftar.TabIndex = 23
        '
        'txt_TelpSaudara
        '
        Me.txt_TelpSaudara.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_TelpSaudara.Location = New System.Drawing.Point(164, 327)
        Me.txt_TelpSaudara.Name = "txt_TelpSaudara"
        Me.txt_TelpSaudara.Size = New System.Drawing.Size(386, 20)
        Me.txt_TelpSaudara.TabIndex = 22
        '
        'txt_NamaSaudara
        '
        Me.txt_NamaSaudara.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_NamaSaudara.Location = New System.Drawing.Point(164, 297)
        Me.txt_NamaSaudara.Name = "txt_NamaSaudara"
        Me.txt_NamaSaudara.Size = New System.Drawing.Size(325, 20)
        Me.txt_NamaSaudara.TabIndex = 21
        '
        'cmb_Pekerjaan
        '
        Me.cmb_Pekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pekerjaan.FormattingEnabled = True
        Me.cmb_Pekerjaan.Items.AddRange(New Object() {"PEDAGANG", "TANI", "WIRASWASTA", "NELAYAN", "KARYAWAN", "GURU", "PNS", "TNI/POLRI", "SWASTA", "LAIN-LAIN"})
        Me.cmb_Pekerjaan.Location = New System.Drawing.Point(164, 266)
        Me.cmb_Pekerjaan.Name = "cmb_Pekerjaan"
        Me.cmb_Pekerjaan.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Pekerjaan.TabIndex = 20
        '
        'cmb_Status
        '
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Items.AddRange(New Object() {"MENIKAH", "BELUM MENIKAH", "JANDA", "DUDA", "LAIN-LAIN"})
        Me.cmb_Status.Location = New System.Drawing.Point(164, 236)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(169, 21)
        Me.cmb_Status.TabIndex = 19
        '
        'txt_NoTelp
        '
        Me.txt_NoTelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_NoTelp.Location = New System.Drawing.Point(164, 206)
        Me.txt_NoTelp.Name = "txt_NoTelp"
        Me.txt_NoTelp.Size = New System.Drawing.Size(325, 20)
        Me.txt_NoTelp.TabIndex = 18
        '
        'txt_Alamat
        '
        Me.txt_Alamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Alamat.Location = New System.Drawing.Point(164, 145)
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.Size = New System.Drawing.Size(466, 20)
        Me.txt_Alamat.TabIndex = 16
        '
        'txt_TmptLahir
        '
        Me.txt_TmptLahir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_TmptLahir.Location = New System.Drawing.Point(164, 115)
        Me.txt_TmptLahir.Name = "txt_TmptLahir"
        Me.txt_TmptLahir.Size = New System.Drawing.Size(209, 20)
        Me.txt_TmptLahir.TabIndex = 15
        '
        'cmb_JK
        '
        Me.cmb_JK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JK.FormattingEnabled = True
        Me.cmb_JK.Items.AddRange(New Object() {"L", "P"})
        Me.cmb_JK.Location = New System.Drawing.Point(164, 176)
        Me.cmb_JK.Name = "cmb_JK"
        Me.cmb_JK.Size = New System.Drawing.Size(102, 21)
        Me.cmb_JK.TabIndex = 17
        '
        'txt_NoKTP
        '
        Me.txt_NoKTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_NoKTP.Location = New System.Drawing.Point(164, 84)
        Me.txt_NoKTP.Name = "txt_NoKTP"
        Me.txt_NoKTP.Size = New System.Drawing.Size(447, 20)
        Me.txt_NoKTP.TabIndex = 14
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.dtp_TglLahir)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TglLahir)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Batal)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Simpan)
        Me.group_InformasiAnggota.Controls.Add(Me.dtp_TglDaftar)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_TelpSaudara)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_NamaSaudara)
        Me.group_InformasiAnggota.Controls.Add(Me.cmb_Pekerjaan)
        Me.group_InformasiAnggota.Controls.Add(Me.cmb_Status)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_NoTelp)
        Me.group_InformasiAnggota.Controls.Add(Me.cmb_JK)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Alamat)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_TmptLahir)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_NoKTP)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TglDaftar)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TelpSaudara)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_NamaSaudara)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Pekerjaan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Status)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_NoTelp)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_JK)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Alamat)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TempatLhr)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_NoKTP)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_KodeAnggota)
        Me.group_InformasiAnggota.Enabled = False
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(534, 78)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(664, 452)
        Me.group_InformasiAnggota.TabIndex = 6
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'txt_Nama
        '
        Me.txt_Nama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Nama.Location = New System.Drawing.Point(164, 54)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.Size = New System.Drawing.Size(281, 20)
        Me.txt_Nama.TabIndex = 13
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(164, 23)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(214, 20)
        Me.txt_KodeAnggota.TabIndex = 12
        '
        'lbl_TglDaftar
        '
        Me.lbl_TglDaftar.AutoSize = True
        Me.lbl_TglDaftar.Location = New System.Drawing.Point(7, 359)
        Me.lbl_TglDaftar.Name = "lbl_TglDaftar"
        Me.lbl_TglDaftar.Size = New System.Drawing.Size(88, 15)
        Me.lbl_TglDaftar.TabIndex = 11
        Me.lbl_TglDaftar.Text = "Tanggal Daftar"
        '
        'lbl_TelpSaudara
        '
        Me.lbl_TelpSaudara.AutoSize = True
        Me.lbl_TelpSaudara.Location = New System.Drawing.Point(8, 330)
        Me.lbl_TelpSaudara.Name = "lbl_TelpSaudara"
        Me.lbl_TelpSaudara.Size = New System.Drawing.Size(81, 15)
        Me.lbl_TelpSaudara.TabIndex = 10
        Me.lbl_TelpSaudara.Text = "Telp Saudara"
        '
        'lbl_NamaSaudara
        '
        Me.lbl_NamaSaudara.AutoSize = True
        Me.lbl_NamaSaudara.Location = New System.Drawing.Point(8, 297)
        Me.lbl_NamaSaudara.Name = "lbl_NamaSaudara"
        Me.lbl_NamaSaudara.Size = New System.Drawing.Size(91, 15)
        Me.lbl_NamaSaudara.TabIndex = 9
        Me.lbl_NamaSaudara.Text = "Nama Saudara"
        '
        'lbl_Pekerjaan
        '
        Me.lbl_Pekerjaan.AutoSize = True
        Me.lbl_Pekerjaan.Location = New System.Drawing.Point(8, 264)
        Me.lbl_Pekerjaan.Name = "lbl_Pekerjaan"
        Me.lbl_Pekerjaan.Size = New System.Drawing.Size(63, 15)
        Me.lbl_Pekerjaan.TabIndex = 8
        Me.lbl_Pekerjaan.Text = "Pekerjaan"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(8, 234)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Status.TabIndex = 7
        Me.lbl_Status.Text = "Status"
        '
        'lbl_NoTelp
        '
        Me.lbl_NoTelp.AutoSize = True
        Me.lbl_NoTelp.Location = New System.Drawing.Point(8, 205)
        Me.lbl_NoTelp.Name = "lbl_NoTelp"
        Me.lbl_NoTelp.Size = New System.Drawing.Size(79, 15)
        Me.lbl_NoTelp.TabIndex = 6
        Me.lbl_NoTelp.Text = "No. Telp / HP"
        '
        'lbl_JK
        '
        Me.lbl_JK.AutoSize = True
        Me.lbl_JK.Location = New System.Drawing.Point(8, 174)
        Me.lbl_JK.Name = "lbl_JK"
        Me.lbl_JK.Size = New System.Drawing.Size(85, 15)
        Me.lbl_JK.TabIndex = 5
        Me.lbl_JK.Text = "Jenis Kelamin"
        '
        'lbl_Alamat
        '
        Me.lbl_Alamat.AutoSize = True
        Me.lbl_Alamat.Location = New System.Drawing.Point(8, 145)
        Me.lbl_Alamat.Name = "lbl_Alamat"
        Me.lbl_Alamat.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Alamat.TabIndex = 4
        Me.lbl_Alamat.Text = "Alamat"
        '
        'lbl_TempatLhr
        '
        Me.lbl_TempatLhr.AutoSize = True
        Me.lbl_TempatLhr.Location = New System.Drawing.Point(8, 113)
        Me.lbl_TempatLhr.Name = "lbl_TempatLhr"
        Me.lbl_TempatLhr.Size = New System.Drawing.Size(80, 15)
        Me.lbl_TempatLhr.TabIndex = 3
        Me.lbl_TempatLhr.Text = "Tempat Lahir"
        '
        'lbl_NoKTP
        '
        Me.lbl_NoKTP.AutoSize = True
        Me.lbl_NoKTP.Location = New System.Drawing.Point(8, 84)
        Me.lbl_NoKTP.Name = "lbl_NoKTP"
        Me.lbl_NoKTP.Size = New System.Drawing.Size(52, 15)
        Me.lbl_NoKTP.TabIndex = 2
        Me.lbl_NoKTP.Text = "No. KTP"
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(8, 54)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Nama.TabIndex = 1
        Me.lbl_Nama.Text = "Nama"
        '
        'lbl_KodeAnggota
        '
        Me.lbl_KodeAnggota.AutoSize = True
        Me.lbl_KodeAnggota.Location = New System.Drawing.Point(8, 23)
        Me.lbl_KodeAnggota.Name = "lbl_KodeAnggota"
        Me.lbl_KodeAnggota.Size = New System.Drawing.Size(84, 15)
        Me.lbl_KodeAnggota.TabIndex = 0
        Me.lbl_KodeAnggota.Text = "Kode Anggota"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(14, 8)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(121, 20)
        Me.lbl_Judul.TabIndex = 2
        Me.lbl_Judul.Text = "Data Anggota"
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.btn_CetakKartu)
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumlahData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Controls.Add(Me.txtSearch)
        Me.group_DataAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataAnggota.Location = New System.Drawing.Point(19, 78)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Size = New System.Drawing.Size(508, 452)
        Me.group_DataAnggota.TabIndex = 5
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Data Anggota"
        '
        'lbl_JumlahData
        '
        Me.lbl_JumlahData.AutoSize = True
        Me.lbl_JumlahData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumlahData.Location = New System.Drawing.Point(8, 408)
        Me.lbl_JumlahData.Name = "lbl_JumlahData"
        Me.lbl_JumlahData.Size = New System.Drawing.Size(91, 15)
        Me.lbl_JumlahData.TabIndex = 10
        Me.lbl_JumlahData.Text = "Jumlah data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(8, 54)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(494, 346)
        Me.dgv_DataAnggota.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(494, 20)
        Me.txtSearch.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1219, 61)
        Me.Panel1.TabIndex = 4
        '
        'FormAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 606)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grupBtn.ResumeLayout(False)
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_ImportAnggotaExcel As Button
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_Ubah As Button
    Friend WithEvents btn_Tambah As Button
    Friend WithEvents btn_CetakKartu As Button
    Friend WithEvents dtp_TglLahir As DateTimePicker
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_TglLahir As Label
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents dtp_TglDaftar As DateTimePicker
    Friend WithEvents txt_TelpSaudara As TextBox
    Friend WithEvents txt_NamaSaudara As TextBox
    Friend WithEvents cmb_Pekerjaan As ComboBox
    Friend WithEvents cmb_Status As ComboBox
    Friend WithEvents txt_NoTelp As TextBox
    Friend WithEvents txt_Alamat As TextBox
    Friend WithEvents txt_TmptLahir As TextBox
    Friend WithEvents cmb_JK As ComboBox
    Friend WithEvents txt_NoKTP As TextBox
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents lbl_TglDaftar As Label
    Friend WithEvents lbl_TelpSaudara As Label
    Friend WithEvents lbl_NamaSaudara As Label
    Friend WithEvents lbl_Pekerjaan As Label
    Friend WithEvents lbl_Status As Label
    Friend WithEvents lbl_NoTelp As Label
    Friend WithEvents lbl_JK As Label
    Friend WithEvents lbl_Alamat As Label
    Friend WithEvents lbl_TempatLhr As Label
    Friend WithEvents lbl_NoKTP As Label
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents lbl_KodeAnggota As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumlahData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
End Class
