<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKoreksiPinjamorPiutangNasabah
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
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_DataPeminjaman = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataPeminjaman = New System.Windows.Forms.DataGridView()
        Me.txt_CariData = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.dtp_Pinjam = New System.Windows.Forms.DateTimePicker()
        Me.lbl_TglPinjam = New System.Windows.Forms.Label()
        Me.group_InfoNasabah = New System.Windows.Forms.GroupBox()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.lbl_Alamat = New System.Windows.Forms.Label()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.txt_KodeNasabah = New System.Windows.Forms.TextBox()
        Me.lbl_KodeNasabah = New System.Windows.Forms.Label()
        Me.cmb_Jenis = New System.Windows.Forms.ComboBox()
        Me.lbl_Jenis = New System.Windows.Forms.Label()
        Me.group_InfoPeminjaman = New System.Windows.Forms.GroupBox()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Simpan = New System.Windows.Forms.Button()
        Me.txt_KodePinjam = New System.Windows.Forms.TextBox()
        Me.lbl_KodePinjam = New System.Windows.Forms.Label()
        Me.txt_JumAngsuran = New System.Windows.Forms.TextBox()
        Me.lbl_JumAngsuran = New System.Windows.Forms.Label()
        Me.txt_AngsuranBunga = New System.Windows.Forms.TextBox()
        Me.lbl_AngsuranBunga = New System.Windows.Forms.Label()
        Me.txt_AngsuranPokok = New System.Windows.Forms.TextBox()
        Me.lbl_AngsuranPokok = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_UangDiterima = New System.Windows.Forms.TextBox()
        Me.txt_Administrasi = New System.Windows.Forms.TextBox()
        Me.txt_Asuransi = New System.Windows.Forms.TextBox()
        Me.txt_Bunga = New System.Windows.Forms.TextBox()
        Me.txt_LamaPinjam = New System.Windows.Forms.TextBox()
        Me.txt_BesarPinjam = New System.Windows.Forms.TextBox()
        Me.lbl_JumDiterima = New System.Windows.Forms.Label()
        Me.lbl_Administrasi = New System.Windows.Forms.Label()
        Me.lbl_Asuransi = New System.Windows.Forms.Label()
        Me.lbl_Bunga = New System.Windows.Forms.Label()
        Me.lbl_LamaPinjam = New System.Windows.Forms.Label()
        Me.lbl_BesarPinjam = New System.Windows.Forms.Label()
        Me.dtp_TglPinjam2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_TglPinjam2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_DataPeminjaman.SuspendLayout()
        CType(Me.dgv_DataPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.group_InfoNasabah.SuspendLayout()
        Me.group_InfoPeminjaman.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 73)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.Location = New System.Drawing.Point(40, 38)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(424, 15)
        Me.lbl_Subjudul.TabIndex = 19
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk memasukan proses koreksi peminjaman nasabah"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.Location = New System.Drawing.Point(22, 18)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(354, 20)
        Me.lbl_Judul.TabIndex = 18
        Me.lbl_Judul.Text = "Form Koreksi Pinjam atau piutang Nasabah" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'group_DataPeminjaman
        '
        Me.group_DataPeminjaman.Controls.Add(Me.lbl_JumData)
        Me.group_DataPeminjaman.Controls.Add(Me.dgv_DataPeminjaman)
        Me.group_DataPeminjaman.Controls.Add(Me.txt_CariData)
        Me.group_DataPeminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataPeminjaman.Location = New System.Drawing.Point(12, 79)
        Me.group_DataPeminjaman.Name = "group_DataPeminjaman"
        Me.group_DataPeminjaman.Size = New System.Drawing.Size(411, 480)
        Me.group_DataPeminjaman.TabIndex = 1
        Me.group_DataPeminjaman.TabStop = False
        Me.group_DataPeminjaman.Text = "Data Peminjaman"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(6, 453)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 3
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataPeminjaman
        '
        Me.dgv_DataPeminjaman.AllowUserToAddRows = False
        Me.dgv_DataPeminjaman.AllowUserToDeleteRows = False
        Me.dgv_DataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataPeminjaman.Location = New System.Drawing.Point(10, 52)
        Me.dgv_DataPeminjaman.Name = "dgv_DataPeminjaman"
        Me.dgv_DataPeminjaman.ReadOnly = True
        Me.dgv_DataPeminjaman.RowHeadersWidth = 51
        Me.dgv_DataPeminjaman.RowTemplate.Height = 29
        Me.dgv_DataPeminjaman.Size = New System.Drawing.Size(385, 398)
        Me.dgv_DataPeminjaman.TabIndex = 2
        '
        'txt_CariData
        '
        Me.txt_CariData.Location = New System.Drawing.Point(10, 22)
        Me.txt_CariData.Name = "txt_CariData"
        Me.txt_CariData.Size = New System.Drawing.Size(385, 20)
        Me.txt_CariData.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Refresh)
        Me.GroupBox2.Controls.Add(Me.dtp_Pinjam)
        Me.GroupBox2.Controls.Add(Me.lbl_TglPinjam)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Location = New System.Drawing.Point(335, 17)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(94, 29)
        Me.btn_Refresh.TabIndex = 3
        Me.btn_Refresh.Text = "Refresh"
        Me.btn_Refresh.UseVisualStyleBackColor = True
        '
        'dtp_Pinjam
        '
        Me.dtp_Pinjam.Location = New System.Drawing.Point(102, 20)
        Me.dtp_Pinjam.Name = "dtp_Pinjam"
        Me.dtp_Pinjam.Size = New System.Drawing.Size(227, 21)
        Me.dtp_Pinjam.TabIndex = 1
        '
        'lbl_TglPinjam
        '
        Me.lbl_TglPinjam.AutoSize = True
        Me.lbl_TglPinjam.Location = New System.Drawing.Point(2, 22)
        Me.lbl_TglPinjam.Name = "lbl_TglPinjam"
        Me.lbl_TglPinjam.Size = New System.Drawing.Size(94, 15)
        Me.lbl_TglPinjam.TabIndex = 0
        Me.lbl_TglPinjam.Text = "Tanggal Pinjam"
        '
        'group_InfoNasabah
        '
        Me.group_InfoNasabah.Controls.Add(Me.txt_Alamat)
        Me.group_InfoNasabah.Controls.Add(Me.txt_Nama)
        Me.group_InfoNasabah.Controls.Add(Me.lbl_Alamat)
        Me.group_InfoNasabah.Controls.Add(Me.lbl_Nama)
        Me.group_InfoNasabah.Controls.Add(Me.txt_KodeNasabah)
        Me.group_InfoNasabah.Controls.Add(Me.lbl_KodeNasabah)
        Me.group_InfoNasabah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InfoNasabah.Location = New System.Drawing.Point(429, 144)
        Me.group_InfoNasabah.Name = "group_InfoNasabah"
        Me.group_InfoNasabah.Size = New System.Drawing.Size(486, 113)
        Me.group_InfoNasabah.TabIndex = 3
        Me.group_InfoNasabah.TabStop = False
        Me.group_InfoNasabah.Text = "Informasi Nasabah"
        '
        'txt_Alamat
        '
        Me.txt_Alamat.Location = New System.Drawing.Point(102, 71)
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.ReadOnly = True
        Me.txt_Alamat.Size = New System.Drawing.Size(364, 20)
        Me.txt_Alamat.TabIndex = 6
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(102, 44)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(263, 20)
        Me.txt_Nama.TabIndex = 5
        '
        'lbl_Alamat
        '
        Me.lbl_Alamat.AutoSize = True
        Me.lbl_Alamat.Location = New System.Drawing.Point(8, 71)
        Me.lbl_Alamat.Name = "lbl_Alamat"
        Me.lbl_Alamat.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Alamat.TabIndex = 5
        Me.lbl_Alamat.Text = "Alamat"
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(8, 47)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Nama.TabIndex = 4
        Me.lbl_Nama.Text = "Nama"
        '
        'txt_KodeNasabah
        '
        Me.txt_KodeNasabah.Location = New System.Drawing.Point(102, 17)
        Me.txt_KodeNasabah.Name = "txt_KodeNasabah"
        Me.txt_KodeNasabah.ReadOnly = True
        Me.txt_KodeNasabah.Size = New System.Drawing.Size(134, 20)
        Me.txt_KodeNasabah.TabIndex = 4
        '
        'lbl_KodeNasabah
        '
        Me.lbl_KodeNasabah.AutoSize = True
        Me.lbl_KodeNasabah.Location = New System.Drawing.Point(7, 17)
        Me.lbl_KodeNasabah.Name = "lbl_KodeNasabah"
        Me.lbl_KodeNasabah.Size = New System.Drawing.Size(89, 15)
        Me.lbl_KodeNasabah.TabIndex = 0
        Me.lbl_KodeNasabah.Text = "Kode Nasabah"
        '
        'cmb_Jenis
        '
        Me.cmb_Jenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Jenis.FormattingEnabled = True
        Me.cmb_Jenis.Items.AddRange(New Object() {"FLAT", "EFEKTIF", "ANUITAS"})
        Me.cmb_Jenis.Location = New System.Drawing.Point(344, 89)
        Me.cmb_Jenis.Name = "cmb_Jenis"
        Me.cmb_Jenis.Size = New System.Drawing.Size(122, 21)
        Me.cmb_Jenis.TabIndex = 8
        '
        'lbl_Jenis
        '
        Me.lbl_Jenis.AutoSize = True
        Me.lbl_Jenis.Location = New System.Drawing.Point(266, 92)
        Me.lbl_Jenis.Name = "lbl_Jenis"
        Me.lbl_Jenis.Size = New System.Drawing.Size(75, 15)
        Me.lbl_Jenis.TabIndex = 7
        Me.lbl_Jenis.Text = "Jenis Bunga"
        '
        'group_InfoPeminjaman
        '
        Me.group_InfoPeminjaman.Controls.Add(Me.cmb_Jenis)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_Jenis)
        Me.group_InfoPeminjaman.Controls.Add(Me.btn_Batal)
        Me.group_InfoPeminjaman.Controls.Add(Me.btn_Simpan)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_KodePinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_KodePinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_JumAngsuran)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_JumAngsuran)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_AngsuranBunga)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_AngsuranBunga)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_AngsuranPokok)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_AngsuranPokok)
        Me.group_InfoPeminjaman.Controls.Add(Me.Label16)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_UangDiterima)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_Administrasi)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_Asuransi)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_Bunga)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_LamaPinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.txt_BesarPinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_JumDiterima)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_Administrasi)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_Asuransi)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_Bunga)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_LamaPinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_BesarPinjam)
        Me.group_InfoPeminjaman.Controls.Add(Me.dtp_TglPinjam2)
        Me.group_InfoPeminjaman.Controls.Add(Me.lbl_TglPinjam2)
        Me.group_InfoPeminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InfoPeminjaman.Location = New System.Drawing.Point(429, 263)
        Me.group_InfoPeminjaman.Name = "group_InfoPeminjaman"
        Me.group_InfoPeminjaman.Size = New System.Drawing.Size(486, 296)
        Me.group_InfoPeminjaman.TabIndex = 4
        Me.group_InfoPeminjaman.TabStop = False
        Me.group_InfoPeminjaman.Text = "Informasi Peminjaman"
        '
        'btn_Batal
        '
        Me.btn_Batal.Location = New System.Drawing.Point(185, 261)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_Batal.TabIndex = 20
        Me.btn_Batal.Text = "Batal"
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Simpan
        '
        Me.btn_Simpan.Location = New System.Drawing.Point(107, 261)
        Me.btn_Simpan.Name = "btn_Simpan"
        Me.btn_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_Simpan.TabIndex = 19
        Me.btn_Simpan.Text = "Simpan"
        Me.btn_Simpan.UseVisualStyleBackColor = True
        '
        'txt_KodePinjam
        '
        Me.txt_KodePinjam.Location = New System.Drawing.Point(344, 40)
        Me.txt_KodePinjam.Name = "txt_KodePinjam"
        Me.txt_KodePinjam.Size = New System.Drawing.Size(122, 20)
        Me.txt_KodePinjam.TabIndex = 7
        '
        'lbl_KodePinjam
        '
        Me.lbl_KodePinjam.AutoSize = True
        Me.lbl_KodePinjam.Location = New System.Drawing.Point(256, 43)
        Me.lbl_KodePinjam.Name = "lbl_KodePinjam"
        Me.lbl_KodePinjam.Size = New System.Drawing.Size(81, 15)
        Me.lbl_KodePinjam.TabIndex = 6
        Me.lbl_KodePinjam.Text = " Kode Pinjam"
        '
        'txt_JumAngsuran
        '
        Me.txt_JumAngsuran.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_JumAngsuran.Location = New System.Drawing.Point(344, 176)
        Me.txt_JumAngsuran.Name = "txt_JumAngsuran"
        Me.txt_JumAngsuran.ReadOnly = True
        Me.txt_JumAngsuran.Size = New System.Drawing.Size(122, 20)
        Me.txt_JumAngsuran.TabIndex = 18
        '
        'lbl_JumAngsuran
        '
        Me.lbl_JumAngsuran.AutoSize = True
        Me.lbl_JumAngsuran.Location = New System.Drawing.Point(242, 176)
        Me.lbl_JumAngsuran.Name = "lbl_JumAngsuran"
        Me.lbl_JumAngsuran.Size = New System.Drawing.Size(103, 15)
        Me.lbl_JumAngsuran.TabIndex = 18
        Me.lbl_JumAngsuran.Text = "Jumlah Angsuran"
        '
        'txt_AngsuranBunga
        '
        Me.txt_AngsuranBunga.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_AngsuranBunga.Location = New System.Drawing.Point(344, 149)
        Me.txt_AngsuranBunga.Name = "txt_AngsuranBunga"
        Me.txt_AngsuranBunga.ReadOnly = True
        Me.txt_AngsuranBunga.Size = New System.Drawing.Size(122, 20)
        Me.txt_AngsuranBunga.TabIndex = 17
        '
        'lbl_AngsuranBunga
        '
        Me.lbl_AngsuranBunga.AutoSize = True
        Me.lbl_AngsuranBunga.Location = New System.Drawing.Point(245, 152)
        Me.lbl_AngsuranBunga.Name = "lbl_AngsuranBunga"
        Me.lbl_AngsuranBunga.Size = New System.Drawing.Size(98, 15)
        Me.lbl_AngsuranBunga.TabIndex = 17
        Me.lbl_AngsuranBunga.Text = "Angsuran Bunga"
        '
        'txt_AngsuranPokok
        '
        Me.txt_AngsuranPokok.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_AngsuranPokok.Location = New System.Drawing.Point(344, 122)
        Me.txt_AngsuranPokok.Name = "txt_AngsuranPokok"
        Me.txt_AngsuranPokok.ReadOnly = True
        Me.txt_AngsuranPokok.Size = New System.Drawing.Size(122, 20)
        Me.txt_AngsuranPokok.TabIndex = 16
        '
        'lbl_AngsuranPokok
        '
        Me.lbl_AngsuranPokok.AutoSize = True
        Me.lbl_AngsuranPokok.Location = New System.Drawing.Point(245, 125)
        Me.lbl_AngsuranPokok.Name = "lbl_AngsuranPokok"
        Me.lbl_AngsuranPokok.Size = New System.Drawing.Size(96, 15)
        Me.lbl_AngsuranPokok.TabIndex = 15
        Me.lbl_AngsuranPokok.Text = "Angsuran Pokok"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(184, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "%"
        '
        'txt_UangDiterima
        '
        Me.txt_UangDiterima.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_UangDiterima.Location = New System.Drawing.Point(107, 230)
        Me.txt_UangDiterima.Name = "txt_UangDiterima"
        Me.txt_UangDiterima.ReadOnly = True
        Me.txt_UangDiterima.Size = New System.Drawing.Size(129, 20)
        Me.txt_UangDiterima.TabIndex = 14
        '
        'txt_Administrasi
        '
        Me.txt_Administrasi.Location = New System.Drawing.Point(107, 203)
        Me.txt_Administrasi.Name = "txt_Administrasi"
        Me.txt_Administrasi.Size = New System.Drawing.Size(129, 20)
        Me.txt_Administrasi.TabIndex = 13
        '
        'txt_Asuransi
        '
        Me.txt_Asuransi.Location = New System.Drawing.Point(107, 176)
        Me.txt_Asuransi.Name = "txt_Asuransi"
        Me.txt_Asuransi.Size = New System.Drawing.Size(129, 20)
        Me.txt_Asuransi.TabIndex = 12
        '
        'txt_Bunga
        '
        Me.txt_Bunga.Location = New System.Drawing.Point(107, 149)
        Me.txt_Bunga.Name = "txt_Bunga"
        Me.txt_Bunga.Size = New System.Drawing.Size(71, 20)
        Me.txt_Bunga.TabIndex = 11
        '
        'txt_LamaPinjam
        '
        Me.txt_LamaPinjam.Location = New System.Drawing.Point(107, 122)
        Me.txt_LamaPinjam.Name = "txt_LamaPinjam"
        Me.txt_LamaPinjam.Size = New System.Drawing.Size(101, 20)
        Me.txt_LamaPinjam.TabIndex = 10
        '
        'txt_BesarPinjam
        '
        Me.txt_BesarPinjam.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_BesarPinjam.Location = New System.Drawing.Point(107, 95)
        Me.txt_BesarPinjam.Name = "txt_BesarPinjam"
        Me.txt_BesarPinjam.Size = New System.Drawing.Size(153, 20)
        Me.txt_BesarPinjam.TabIndex = 9
        '
        'lbl_JumDiterima
        '
        Me.lbl_JumDiterima.AutoSize = True
        Me.lbl_JumDiterima.Location = New System.Drawing.Point(10, 230)
        Me.lbl_JumDiterima.Name = "lbl_JumDiterima"
        Me.lbl_JumDiterima.Size = New System.Drawing.Size(98, 15)
        Me.lbl_JumDiterima.TabIndex = 8
        Me.lbl_JumDiterima.Text = "Jumlah Diterima"
        '
        'lbl_Administrasi
        '
        Me.lbl_Administrasi.AutoSize = True
        Me.lbl_Administrasi.Location = New System.Drawing.Point(10, 203)
        Me.lbl_Administrasi.Name = "lbl_Administrasi"
        Me.lbl_Administrasi.Size = New System.Drawing.Size(74, 15)
        Me.lbl_Administrasi.TabIndex = 7
        Me.lbl_Administrasi.Text = "Administrasi"
        '
        'lbl_Asuransi
        '
        Me.lbl_Asuransi.AutoSize = True
        Me.lbl_Asuransi.Location = New System.Drawing.Point(10, 176)
        Me.lbl_Asuransi.Name = "lbl_Asuransi"
        Me.lbl_Asuransi.Size = New System.Drawing.Size(54, 15)
        Me.lbl_Asuransi.TabIndex = 6
        Me.lbl_Asuransi.Text = "Asuransi"
        '
        'lbl_Bunga
        '
        Me.lbl_Bunga.AutoSize = True
        Me.lbl_Bunga.Location = New System.Drawing.Point(10, 149)
        Me.lbl_Bunga.Name = "lbl_Bunga"
        Me.lbl_Bunga.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Bunga.TabIndex = 5
        Me.lbl_Bunga.Text = "Bunga"
        '
        'lbl_LamaPinjam
        '
        Me.lbl_LamaPinjam.AutoSize = True
        Me.lbl_LamaPinjam.Location = New System.Drawing.Point(8, 122)
        Me.lbl_LamaPinjam.Name = "lbl_LamaPinjam"
        Me.lbl_LamaPinjam.Size = New System.Drawing.Size(81, 15)
        Me.lbl_LamaPinjam.TabIndex = 4
        Me.lbl_LamaPinjam.Text = "Lama Pinjam"
        '
        'lbl_BesarPinjam
        '
        Me.lbl_BesarPinjam.AutoSize = True
        Me.lbl_BesarPinjam.Location = New System.Drawing.Point(8, 95)
        Me.lbl_BesarPinjam.Name = "lbl_BesarPinjam"
        Me.lbl_BesarPinjam.Size = New System.Drawing.Size(81, 15)
        Me.lbl_BesarPinjam.TabIndex = 3
        Me.lbl_BesarPinjam.Text = "Besar Pinjam"
        '
        'dtp_TglPinjam2
        '
        Me.dtp_TglPinjam2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_TglPinjam2.Location = New System.Drawing.Point(107, 68)
        Me.dtp_TglPinjam2.Name = "dtp_TglPinjam2"
        Me.dtp_TglPinjam2.Size = New System.Drawing.Size(101, 20)
        Me.dtp_TglPinjam2.TabIndex = 2
        '
        'lbl_TglPinjam2
        '
        Me.lbl_TglPinjam2.AutoSize = True
        Me.lbl_TglPinjam2.Location = New System.Drawing.Point(7, 68)
        Me.lbl_TglPinjam2.Name = "lbl_TglPinjam2"
        Me.lbl_TglPinjam2.Size = New System.Drawing.Size(94, 15)
        Me.lbl_TglPinjam2.TabIndex = 1
        Me.lbl_TglPinjam2.Text = "Tanggal Pinjam"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_Keluar)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 565)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(925, 47)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(821, 12)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Keluar.TabIndex = 1
        Me.btn_Keluar.Text = "Keluar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'FormKoreksiPinjamorPiutangNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 612)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.group_InfoPeminjaman)
        Me.Controls.Add(Me.group_InfoNasabah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_DataPeminjaman)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKoreksiPinjamorPiutangNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataPeminjaman.ResumeLayout(False)
        Me.group_DataPeminjaman.PerformLayout()
        CType(Me.dgv_DataPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.group_InfoNasabah.ResumeLayout(False)
        Me.group_InfoNasabah.PerformLayout()
        Me.group_InfoPeminjaman.ResumeLayout(False)
        Me.group_InfoPeminjaman.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_DataPeminjaman As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataPeminjaman As DataGridView
    Friend WithEvents txt_CariData As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents dtp_Pinjam As DateTimePicker
    Friend WithEvents lbl_TglPinjam As Label
    Friend WithEvents group_InfoNasabah As GroupBox
    Friend WithEvents lbl_Jenis As Label
    Friend WithEvents txt_Alamat As TextBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents lbl_Alamat As Label
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents txt_KodeNasabah As TextBox
    Friend WithEvents lbl_KodeNasabah As Label
    Friend WithEvents group_InfoPeminjaman As GroupBox
    Friend WithEvents txt_JumAngsuran As TextBox
    Friend WithEvents lbl_JumAngsuran As Label
    Friend WithEvents txt_AngsuranBunga As TextBox
    Friend WithEvents lbl_AngsuranBunga As Label
    Friend WithEvents txt_AngsuranPokok As TextBox
    Friend WithEvents lbl_AngsuranPokok As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_UangDiterima As TextBox
    Friend WithEvents txt_Administrasi As TextBox
    Friend WithEvents txt_Asuransi As TextBox
    Friend WithEvents txt_Bunga As TextBox
    Friend WithEvents txt_LamaPinjam As TextBox
    Friend WithEvents txt_BesarPinjam As TextBox
    Friend WithEvents lbl_JumDiterima As Label
    Friend WithEvents lbl_Administrasi As Label
    Friend WithEvents lbl_Asuransi As Label
    Friend WithEvents lbl_Bunga As Label
    Friend WithEvents lbl_LamaPinjam As Label
    Friend WithEvents lbl_BesarPinjam As Label
    Friend WithEvents dtp_TglPinjam2 As DateTimePicker
    Friend WithEvents lbl_TglPinjam2 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents lbl_KodePinjam As Label
    Friend WithEvents lbl As Label
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Simpan As Button
    Friend WithEvents cmb_Jenis As ComboBox
    Friend WithEvents txt_KodePinjam As TextBox
End Class
