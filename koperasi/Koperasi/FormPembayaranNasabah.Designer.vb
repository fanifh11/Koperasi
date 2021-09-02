<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembayaranNasabah
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
        Me.txt_kode_pinjam = New System.Windows.Forms.TextBox()
        Me.lbl_kode_pinjam = New System.Windows.Forms.Label()
        Me.group_informasi_nasabah = New System.Windows.Forms.GroupBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_kode_nasabah = New System.Windows.Forms.TextBox()
        Me.lbl_alamat = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.lbl_kode_nasabah = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.btn_cetak_kwitansi = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.group_data_peminjaman = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_data_peminjaman = New System.Windows.Forms.DataGridView()
        Me.group_informasi_peminjaman = New System.Windows.Forms.GroupBox()
        Me.txt_saldo_piutang = New System.Windows.Forms.TextBox()
        Me.txt_sudah_dibayar = New System.Windows.Forms.TextBox()
        Me.txt_angsuran_ke = New System.Windows.Forms.TextBox()
        Me.lbl_saldo_piutang = New System.Windows.Forms.Label()
        Me.lbl_sudah_dibayar = New System.Windows.Forms.Label()
        Me.lbl_angsuran_ke = New System.Windows.Forms.Label()
        Me.lbl_jumlah_angsuran = New System.Windows.Forms.Label()
        Me.lbl_angsuran_bunga = New System.Windows.Forms.Label()
        Me.lbl_angsuran_pokok = New System.Windows.Forms.Label()
        Me.lbl_lama_pinjam = New System.Windows.Forms.Label()
        Me.lbl_besar_pinjam = New System.Windows.Forms.Label()
        Me.lbl_jenis_pinjaman = New System.Windows.Forms.Label()
        Me.txt_jumlah_angsuran = New System.Windows.Forms.TextBox()
        Me.txt_angsuran_bunga = New System.Windows.Forms.TextBox()
        Me.txt_angsuran_pokok = New System.Windows.Forms.TextBox()
        Me.txt_lama_pinjam = New System.Windows.Forms.TextBox()
        Me.txt_besar_pinjam = New System.Windows.Forms.TextBox()
        Me.txt_jenis_pinjaman = New System.Windows.Forms.TextBox()
        Me.group_pembayaran_pinjaman = New System.Windows.Forms.GroupBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_kode_tagihan = New System.Windows.Forms.TextBox()
        Me.txt_jumlah_bayar = New System.Windows.Forms.TextBox()
        Me.lbl_kode_tagihan = New System.Windows.Forms.Label()
        Me.lbl_jumlah_bayar = New System.Windows.Forms.Label()
        Me.btn_manual2 = New System.Windows.Forms.Button()
        Me.btn_manual = New System.Windows.Forms.Button()
        Me.lbl_bayar_bunga = New System.Windows.Forms.Label()
        Me.lbl_biaya_pokok = New System.Windows.Forms.Label()
        Me.lbl_tanggal_bayar = New System.Windows.Forms.Label()
        Me.txt_bayar_bunga = New System.Windows.Forms.TextBox()
        Me.txt_biaya_pokok = New System.Windows.Forms.TextBox()
        Me.dtp_tanggal_bayar = New System.Windows.Forms.DateTimePicker()
        Me.group_informasi_nasabah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.group_data_peminjaman.SuspendLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_informasi_peminjaman.SuspendLayout()
        Me.group_pembayaran_pinjaman.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_kode_pinjam
        '
        Me.txt_kode_pinjam.Location = New System.Drawing.Point(280, 19)
        Me.txt_kode_pinjam.Name = "txt_kode_pinjam"
        Me.txt_kode_pinjam.ReadOnly = True
        Me.txt_kode_pinjam.Size = New System.Drawing.Size(68, 20)
        Me.txt_kode_pinjam.TabIndex = 18
        '
        'lbl_kode_pinjam
        '
        Me.lbl_kode_pinjam.AutoSize = True
        Me.lbl_kode_pinjam.Location = New System.Drawing.Point(208, 19)
        Me.lbl_kode_pinjam.Name = "lbl_kode_pinjam"
        Me.lbl_kode_pinjam.Size = New System.Drawing.Size(66, 13)
        Me.lbl_kode_pinjam.TabIndex = 0
        Me.lbl_kode_pinjam.Text = "Kode Pinjam"
        '
        'group_informasi_nasabah
        '
        Me.group_informasi_nasabah.Controls.Add(Me.txt_nama)
        Me.group_informasi_nasabah.Controls.Add(Me.btn_cari)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_alamat)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_kode_nasabah)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_alamat)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_nama)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_kode_pinjam)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_kode_nasabah)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_kode_pinjam)
        Me.group_informasi_nasabah.Location = New System.Drawing.Point(316, 66)
        Me.group_informasi_nasabah.Name = "group_informasi_nasabah"
        Me.group_informasi_nasabah.Size = New System.Drawing.Size(407, 105)
        Me.group_informasi_nasabah.TabIndex = 57
        Me.group_informasi_nasabah.TabStop = False
        Me.group_informasi_nasabah.Text = "Informasi Nasabah"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(90, 46)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(224, 20)
        Me.txt_nama.TabIndex = 4
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(354, 19)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(45, 23)
        Me.btn_cari.TabIndex = 5
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(90, 72)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.ReadOnly = True
        Me.txt_alamat.Size = New System.Drawing.Size(279, 20)
        Me.txt_alamat.TabIndex = 51
        '
        'txt_kode_nasabah
        '
        Me.txt_kode_nasabah.Location = New System.Drawing.Point(90, 19)
        Me.txt_kode_nasabah.Name = "txt_kode_nasabah"
        Me.txt_kode_nasabah.ReadOnly = True
        Me.txt_kode_nasabah.Size = New System.Drawing.Size(100, 20)
        Me.txt_kode_nasabah.TabIndex = 3
        '
        'lbl_alamat
        '
        Me.lbl_alamat.AutoSize = True
        Me.lbl_alamat.Location = New System.Drawing.Point(6, 73)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(39, 13)
        Me.lbl_alamat.TabIndex = 2
        Me.lbl_alamat.Text = "Alamat"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Location = New System.Drawing.Point(6, 46)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(35, 13)
        Me.lbl_nama.TabIndex = 1
        Me.lbl_nama.Text = "Nama"
        '
        'lbl_kode_nasabah
        '
        Me.lbl_kode_nasabah.AutoSize = True
        Me.lbl_kode_nasabah.Location = New System.Drawing.Point(6, 19)
        Me.lbl_kode_nasabah.Name = "lbl_kode_nasabah"
        Me.lbl_kode_nasabah.Size = New System.Drawing.Size(78, 13)
        Me.lbl_kode_nasabah.TabIndex = 0
        Me.lbl_kode_nasabah.Text = "Kode Nasabah"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 60)
        Me.Panel1.TabIndex = 54
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(291, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk memasukan pembayaran nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(230, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Form Pembayaran Nasabah"
        '
        'btn_cetak_kwitansi
        '
        Me.btn_cetak_kwitansi.Location = New System.Drawing.Point(316, 12)
        Me.btn_cetak_kwitansi.Name = "btn_cetak_kwitansi"
        Me.btn_cetak_kwitansi.Size = New System.Drawing.Size(86, 23)
        Me.btn_cetak_kwitansi.TabIndex = 3
        Me.btn_cetak_kwitansi.Text = "Cetak Kwitansi"
        Me.btn_cetak_kwitansi.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(12, 12)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 1
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.grupBtn.Controls.Add(Me.btn_cetak_kwitansi)
        Me.grupBtn.Controls.Add(Me.btn_tambah)
        Me.grupBtn.Controls.Add(Me.btn_keluar)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 522)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(733, 41)
        Me.grupBtn.TabIndex = 56
        Me.grupBtn.TabStop = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(637, 12)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'group_data_peminjaman
        '
        Me.group_data_peminjaman.Controls.Add(Me.txt_search)
        Me.group_data_peminjaman.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_peminjaman.Controls.Add(Me.dgv_data_peminjaman)
        Me.group_data_peminjaman.Location = New System.Drawing.Point(6, 66)
        Me.group_data_peminjaman.Name = "group_data_peminjaman"
        Me.group_data_peminjaman.Size = New System.Drawing.Size(304, 451)
        Me.group_data_peminjaman.TabIndex = 55
        Me.group_data_peminjaman.TabStop = False
        Me.group_data_peminjaman.Text = "Data Peminjaman"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(6, 19)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(292, 20)
        Me.txt_search.TabIndex = 3
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.ForeColor = System.Drawing.Color.Red
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(8, 426)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 0"
        '
        'dgv_data_peminjaman
        '
        Me.dgv_data_peminjaman.AllowUserToAddRows = False
        Me.dgv_data_peminjaman.AllowUserToDeleteRows = False
        Me.dgv_data_peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_peminjaman.Location = New System.Drawing.Point(6, 46)
        Me.dgv_data_peminjaman.Name = "dgv_data_peminjaman"
        Me.dgv_data_peminjaman.ReadOnly = True
        Me.dgv_data_peminjaman.RowHeadersWidth = 51
        Me.dgv_data_peminjaman.Size = New System.Drawing.Size(292, 377)
        Me.dgv_data_peminjaman.TabIndex = 1
        '
        'group_informasi_peminjaman
        '
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_saldo_piutang)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_sudah_dibayar)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_angsuran_ke)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_saldo_piutang)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_sudah_dibayar)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_angsuran_ke)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_jumlah_angsuran)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_angsuran_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_angsuran_pokok)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_lama_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_besar_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_jenis_pinjaman)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_jumlah_angsuran)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_angsuran_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_angsuran_pokok)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_lama_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_besar_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_jenis_pinjaman)
        Me.group_informasi_peminjaman.Location = New System.Drawing.Point(316, 177)
        Me.group_informasi_peminjaman.Name = "group_informasi_peminjaman"
        Me.group_informasi_peminjaman.Size = New System.Drawing.Size(407, 179)
        Me.group_informasi_peminjaman.TabIndex = 59
        Me.group_informasi_peminjaman.TabStop = False
        Me.group_informasi_peminjaman.Text = "Informasi Peminjaman"
        '
        'txt_saldo_piutang
        '
        Me.txt_saldo_piutang.Location = New System.Drawing.Point(302, 146)
        Me.txt_saldo_piutang.Name = "txt_saldo_piutang"
        Me.txt_saldo_piutang.ReadOnly = True
        Me.txt_saldo_piutang.Size = New System.Drawing.Size(100, 20)
        Me.txt_saldo_piutang.TabIndex = 42
        '
        'txt_sudah_dibayar
        '
        Me.txt_sudah_dibayar.Location = New System.Drawing.Point(302, 120)
        Me.txt_sudah_dibayar.Name = "txt_sudah_dibayar"
        Me.txt_sudah_dibayar.ReadOnly = True
        Me.txt_sudah_dibayar.Size = New System.Drawing.Size(100, 20)
        Me.txt_sudah_dibayar.TabIndex = 41
        '
        'txt_angsuran_ke
        '
        Me.txt_angsuran_ke.Location = New System.Drawing.Point(302, 94)
        Me.txt_angsuran_ke.Name = "txt_angsuran_ke"
        Me.txt_angsuran_ke.ReadOnly = True
        Me.txt_angsuran_ke.Size = New System.Drawing.Size(100, 20)
        Me.txt_angsuran_ke.TabIndex = 40
        '
        'lbl_saldo_piutang
        '
        Me.lbl_saldo_piutang.AutoSize = True
        Me.lbl_saldo_piutang.Location = New System.Drawing.Point(211, 149)
        Me.lbl_saldo_piutang.Name = "lbl_saldo_piutang"
        Me.lbl_saldo_piutang.Size = New System.Drawing.Size(85, 13)
        Me.lbl_saldo_piutang.TabIndex = 39
        Me.lbl_saldo_piutang.Text = "Saldo PIUTANG"
        '
        'lbl_sudah_dibayar
        '
        Me.lbl_sudah_dibayar.AutoSize = True
        Me.lbl_sudah_dibayar.Location = New System.Drawing.Point(211, 123)
        Me.lbl_sudah_dibayar.Name = "lbl_sudah_dibayar"
        Me.lbl_sudah_dibayar.Size = New System.Drawing.Size(76, 13)
        Me.lbl_sudah_dibayar.TabIndex = 38
        Me.lbl_sudah_dibayar.Text = "Sudah diBayar"
        '
        'lbl_angsuran_ke
        '
        Me.lbl_angsuran_ke.AutoSize = True
        Me.lbl_angsuran_ke.Location = New System.Drawing.Point(212, 97)
        Me.lbl_angsuran_ke.Name = "lbl_angsuran_ke"
        Me.lbl_angsuran_ke.Size = New System.Drawing.Size(68, 13)
        Me.lbl_angsuran_ke.TabIndex = 37
        Me.lbl_angsuran_ke.Text = "Angsuran Ke"
        '
        'lbl_jumlah_angsuran
        '
        Me.lbl_jumlah_angsuran.AutoSize = True
        Me.lbl_jumlah_angsuran.Location = New System.Drawing.Point(6, 149)
        Me.lbl_jumlah_angsuran.Name = "lbl_jumlah_angsuran"
        Me.lbl_jumlah_angsuran.Size = New System.Drawing.Size(88, 13)
        Me.lbl_jumlah_angsuran.TabIndex = 36
        Me.lbl_jumlah_angsuran.Text = "Jumlah Angsuran"
        '
        'lbl_angsuran_bunga
        '
        Me.lbl_angsuran_bunga.AutoSize = True
        Me.lbl_angsuran_bunga.Location = New System.Drawing.Point(6, 123)
        Me.lbl_angsuran_bunga.Name = "lbl_angsuran_bunga"
        Me.lbl_angsuran_bunga.Size = New System.Drawing.Size(86, 13)
        Me.lbl_angsuran_bunga.TabIndex = 35
        Me.lbl_angsuran_bunga.Text = "Angsuran Bunga"
        '
        'lbl_angsuran_pokok
        '
        Me.lbl_angsuran_pokok.AutoSize = True
        Me.lbl_angsuran_pokok.Location = New System.Drawing.Point(6, 97)
        Me.lbl_angsuran_pokok.Name = "lbl_angsuran_pokok"
        Me.lbl_angsuran_pokok.Size = New System.Drawing.Size(86, 13)
        Me.lbl_angsuran_pokok.TabIndex = 34
        Me.lbl_angsuran_pokok.Text = "Angsuran Pokok"
        '
        'lbl_lama_pinjam
        '
        Me.lbl_lama_pinjam.AutoSize = True
        Me.lbl_lama_pinjam.Location = New System.Drawing.Point(6, 71)
        Me.lbl_lama_pinjam.Name = "lbl_lama_pinjam"
        Me.lbl_lama_pinjam.Size = New System.Drawing.Size(67, 13)
        Me.lbl_lama_pinjam.TabIndex = 33
        Me.lbl_lama_pinjam.Text = "Lama Pinjam"
        '
        'lbl_besar_pinjam
        '
        Me.lbl_besar_pinjam.AutoSize = True
        Me.lbl_besar_pinjam.Location = New System.Drawing.Point(6, 45)
        Me.lbl_besar_pinjam.Name = "lbl_besar_pinjam"
        Me.lbl_besar_pinjam.Size = New System.Drawing.Size(68, 13)
        Me.lbl_besar_pinjam.TabIndex = 32
        Me.lbl_besar_pinjam.Text = "Besar Pinjam"
        '
        'lbl_jenis_pinjaman
        '
        Me.lbl_jenis_pinjaman.AutoSize = True
        Me.lbl_jenis_pinjaman.Location = New System.Drawing.Point(6, 19)
        Me.lbl_jenis_pinjaman.Name = "lbl_jenis_pinjaman"
        Me.lbl_jenis_pinjaman.Size = New System.Drawing.Size(77, 13)
        Me.lbl_jenis_pinjaman.TabIndex = 31
        Me.lbl_jenis_pinjaman.Text = "Jenis Pinjaman"
        '
        'txt_jumlah_angsuran
        '
        Me.txt_jumlah_angsuran.Location = New System.Drawing.Point(100, 149)
        Me.txt_jumlah_angsuran.Name = "txt_jumlah_angsuran"
        Me.txt_jumlah_angsuran.ReadOnly = True
        Me.txt_jumlah_angsuran.Size = New System.Drawing.Size(90, 20)
        Me.txt_jumlah_angsuran.TabIndex = 30
        '
        'txt_angsuran_bunga
        '
        Me.txt_angsuran_bunga.Location = New System.Drawing.Point(100, 123)
        Me.txt_angsuran_bunga.Name = "txt_angsuran_bunga"
        Me.txt_angsuran_bunga.ReadOnly = True
        Me.txt_angsuran_bunga.Size = New System.Drawing.Size(90, 20)
        Me.txt_angsuran_bunga.TabIndex = 29
        '
        'txt_angsuran_pokok
        '
        Me.txt_angsuran_pokok.Location = New System.Drawing.Point(100, 97)
        Me.txt_angsuran_pokok.Name = "txt_angsuran_pokok"
        Me.txt_angsuran_pokok.ReadOnly = True
        Me.txt_angsuran_pokok.Size = New System.Drawing.Size(90, 20)
        Me.txt_angsuran_pokok.TabIndex = 28
        '
        'txt_lama_pinjam
        '
        Me.txt_lama_pinjam.Location = New System.Drawing.Point(100, 71)
        Me.txt_lama_pinjam.Name = "txt_lama_pinjam"
        Me.txt_lama_pinjam.ReadOnly = True
        Me.txt_lama_pinjam.Size = New System.Drawing.Size(69, 20)
        Me.txt_lama_pinjam.TabIndex = 27
        '
        'txt_besar_pinjam
        '
        Me.txt_besar_pinjam.Location = New System.Drawing.Point(100, 45)
        Me.txt_besar_pinjam.Name = "txt_besar_pinjam"
        Me.txt_besar_pinjam.ReadOnly = True
        Me.txt_besar_pinjam.Size = New System.Drawing.Size(118, 20)
        Me.txt_besar_pinjam.TabIndex = 26
        '
        'txt_jenis_pinjaman
        '
        Me.txt_jenis_pinjaman.Location = New System.Drawing.Point(100, 19)
        Me.txt_jenis_pinjaman.Name = "txt_jenis_pinjaman"
        Me.txt_jenis_pinjaman.ReadOnly = True
        Me.txt_jenis_pinjaman.Size = New System.Drawing.Size(100, 20)
        Me.txt_jenis_pinjaman.TabIndex = 25
        '
        'group_pembayaran_pinjaman
        '
        Me.group_pembayaran_pinjaman.Controls.Add(Me.btn_batal)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.btn_simpan)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.txt_kode_tagihan)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.txt_jumlah_bayar)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.lbl_kode_tagihan)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.lbl_jumlah_bayar)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.btn_manual2)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.btn_manual)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.lbl_bayar_bunga)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.lbl_biaya_pokok)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.lbl_tanggal_bayar)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.txt_bayar_bunga)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.txt_biaya_pokok)
        Me.group_pembayaran_pinjaman.Controls.Add(Me.dtp_tanggal_bayar)
        Me.group_pembayaran_pinjaman.Location = New System.Drawing.Point(316, 363)
        Me.group_pembayaran_pinjaman.Name = "group_pembayaran_pinjaman"
        Me.group_pembayaran_pinjaman.Size = New System.Drawing.Size(407, 154)
        Me.group_pembayaran_pinjaman.TabIndex = 60
        Me.group_pembayaran_pinjaman.TabStop = False
        Me.group_pembayaran_pinjaman.Text = "Pembayaran Pinjaman"
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(181, 117)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 13
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(100, 117)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 12
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_kode_tagihan
        '
        Me.txt_kode_tagihan.Location = New System.Drawing.Point(302, 83)
        Me.txt_kode_tagihan.Name = "txt_kode_tagihan"
        Me.txt_kode_tagihan.ReadOnly = True
        Me.txt_kode_tagihan.Size = New System.Drawing.Size(101, 20)
        Me.txt_kode_tagihan.TabIndex = 11
        '
        'txt_jumlah_bayar
        '
        Me.txt_jumlah_bayar.Location = New System.Drawing.Point(302, 33)
        Me.txt_jumlah_bayar.Name = "txt_jumlah_bayar"
        Me.txt_jumlah_bayar.ReadOnly = True
        Me.txt_jumlah_bayar.Size = New System.Drawing.Size(100, 20)
        Me.txt_jumlah_bayar.TabIndex = 10
        '
        'lbl_kode_tagihan
        '
        Me.lbl_kode_tagihan.AutoSize = True
        Me.lbl_kode_tagihan.Location = New System.Drawing.Point(299, 62)
        Me.lbl_kode_tagihan.Name = "lbl_kode_tagihan"
        Me.lbl_kode_tagihan.Size = New System.Drawing.Size(74, 13)
        Me.lbl_kode_tagihan.TabIndex = 9
        Me.lbl_kode_tagihan.Text = "Kode Tagihan"
        '
        'lbl_jumlah_bayar
        '
        Me.lbl_jumlah_bayar.AutoSize = True
        Me.lbl_jumlah_bayar.Location = New System.Drawing.Point(226, 33)
        Me.lbl_jumlah_bayar.Name = "lbl_jumlah_bayar"
        Me.lbl_jumlah_bayar.Size = New System.Drawing.Size(70, 13)
        Me.lbl_jumlah_bayar.TabIndex = 8
        Me.lbl_jumlah_bayar.Text = "Jumlah Bayar"
        '
        'btn_manual2
        '
        Me.btn_manual2.Location = New System.Drawing.Point(199, 84)
        Me.btn_manual2.Name = "btn_manual2"
        Me.btn_manual2.Size = New System.Drawing.Size(75, 23)
        Me.btn_manual2.TabIndex = 7
        Me.btn_manual2.Text = "Manual"
        Me.btn_manual2.UseVisualStyleBackColor = True
        '
        'btn_manual
        '
        Me.btn_manual.Location = New System.Drawing.Point(198, 57)
        Me.btn_manual.Name = "btn_manual"
        Me.btn_manual.Size = New System.Drawing.Size(75, 23)
        Me.btn_manual.TabIndex = 6
        Me.btn_manual.Text = "Manual"
        Me.btn_manual.UseVisualStyleBackColor = True
        '
        'lbl_bayar_bunga
        '
        Me.lbl_bayar_bunga.AutoSize = True
        Me.lbl_bayar_bunga.Location = New System.Drawing.Point(6, 86)
        Me.lbl_bayar_bunga.Name = "lbl_bayar_bunga"
        Me.lbl_bayar_bunga.Size = New System.Drawing.Size(68, 13)
        Me.lbl_bayar_bunga.TabIndex = 5
        Me.lbl_bayar_bunga.Text = "Bayar Bunga"
        '
        'lbl_biaya_pokok
        '
        Me.lbl_biaya_pokok.AutoSize = True
        Me.lbl_biaya_pokok.Location = New System.Drawing.Point(6, 59)
        Me.lbl_biaya_pokok.Name = "lbl_biaya_pokok"
        Me.lbl_biaya_pokok.Size = New System.Drawing.Size(68, 13)
        Me.lbl_biaya_pokok.TabIndex = 4
        Me.lbl_biaya_pokok.Text = "Bayar Pokok"
        '
        'lbl_tanggal_bayar
        '
        Me.lbl_tanggal_bayar.AutoSize = True
        Me.lbl_tanggal_bayar.Location = New System.Drawing.Point(6, 33)
        Me.lbl_tanggal_bayar.Name = "lbl_tanggal_bayar"
        Me.lbl_tanggal_bayar.Size = New System.Drawing.Size(76, 13)
        Me.lbl_tanggal_bayar.TabIndex = 3
        Me.lbl_tanggal_bayar.Text = "Tanggal Bayar"
        '
        'txt_bayar_bunga
        '
        Me.txt_bayar_bunga.Location = New System.Drawing.Point(100, 86)
        Me.txt_bayar_bunga.Name = "txt_bayar_bunga"
        Me.txt_bayar_bunga.ReadOnly = True
        Me.txt_bayar_bunga.Size = New System.Drawing.Size(90, 20)
        Me.txt_bayar_bunga.TabIndex = 2
        '
        'txt_biaya_pokok
        '
        Me.txt_biaya_pokok.Location = New System.Drawing.Point(100, 59)
        Me.txt_biaya_pokok.Name = "txt_biaya_pokok"
        Me.txt_biaya_pokok.ReadOnly = True
        Me.txt_biaya_pokok.Size = New System.Drawing.Size(90, 20)
        Me.txt_biaya_pokok.TabIndex = 1
        '
        'dtp_tanggal_bayar
        '
        Me.dtp_tanggal_bayar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tanggal_bayar.Location = New System.Drawing.Point(100, 33)
        Me.dtp_tanggal_bayar.Name = "dtp_tanggal_bayar"
        Me.dtp_tanggal_bayar.Size = New System.Drawing.Size(90, 20)
        Me.dtp_tanggal_bayar.TabIndex = 0
        '
        'FormPembayaranNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 563)
        Me.Controls.Add(Me.group_pembayaran_pinjaman)
        Me.Controls.Add(Me.group_informasi_nasabah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_data_peminjaman)
        Me.Controls.Add(Me.group_informasi_peminjaman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembayaranNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.group_informasi_nasabah.ResumeLayout(False)
        Me.group_informasi_nasabah.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.group_data_peminjaman.ResumeLayout(False)
        Me.group_data_peminjaman.PerformLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_informasi_peminjaman.ResumeLayout(False)
        Me.group_informasi_peminjaman.PerformLayout()
        Me.group_pembayaran_pinjaman.ResumeLayout(False)
        Me.group_pembayaran_pinjaman.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_kode_pinjam As TextBox
    Friend WithEvents lbl_kode_pinjam As Label
    Friend WithEvents group_informasi_nasabah As GroupBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_kode_nasabah As TextBox
    Friend WithEvents lbl_alamat As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_kode_nasabah As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents btn_cetak_kwitansi As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents group_data_peminjaman As GroupBox
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_data_peminjaman As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents group_informasi_peminjaman As GroupBox
    Friend WithEvents txt_saldo_piutang As TextBox
    Friend WithEvents txt_sudah_dibayar As TextBox
    Friend WithEvents txt_angsuran_ke As TextBox
    Friend WithEvents lbl_saldo_piutang As Label
    Friend WithEvents lbl_sudah_dibayar As Label
    Friend WithEvents lbl_angsuran_ke As Label
    Friend WithEvents lbl_jumlah_angsuran As Label
    Friend WithEvents lbl_angsuran_bunga As Label
    Friend WithEvents lbl_angsuran_pokok As Label
    Friend WithEvents lbl_lama_pinjam As Label
    Friend WithEvents lbl_besar_pinjam As Label
    Friend WithEvents lbl_jenis_pinjaman As Label
    Friend WithEvents txt_jumlah_angsuran As TextBox
    Friend WithEvents txt_angsuran_bunga As TextBox
    Friend WithEvents txt_angsuran_pokok As TextBox
    Friend WithEvents txt_lama_pinjam As TextBox
    Friend WithEvents txt_besar_pinjam As TextBox
    Friend WithEvents txt_jenis_pinjaman As TextBox
    Friend WithEvents group_pembayaran_pinjaman As GroupBox
    Friend WithEvents btn_manual2 As Button
    Friend WithEvents btn_manual As Button
    Friend WithEvents lbl_bayar_bunga As Label
    Friend WithEvents lbl_biaya_pokok As Label
    Friend WithEvents lbl_tanggal_bayar As Label
    Friend WithEvents txt_bayar_bunga As TextBox
    Friend WithEvents txt_biaya_pokok As TextBox
    Friend WithEvents dtp_tanggal_bayar As DateTimePicker
    Friend WithEvents txt_kode_tagihan As TextBox
    Friend WithEvents txt_jumlah_bayar As TextBox
    Friend WithEvents lbl_kode_tagihan As Label
    Friend WithEvents lbl_jumlah_bayar As Label
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
End Class
