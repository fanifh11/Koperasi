<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPinjam
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
        Me.group_informasi_nasabah = New System.Windows.Forms.GroupBox()
        Me.btn_cari = New System.Windows.Forms.Button()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_kode_nasabah = New System.Windows.Forms.TextBox()
        Me.lbl_alamat = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.lbl_kode_nasabah = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_cetak_kwitansi = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.group_data_peminjaman = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_data_peminjaman = New System.Windows.Forms.DataGridView()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.group_informasi_peminjaman = New System.Windows.Forms.GroupBox()
        Me.cmb_JenisBunga = New System.Windows.Forms.ComboBox()
        Me.lbl_JenisBunga = New System.Windows.Forms.Label()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.lbl_persen = New System.Windows.Forms.Label()
        Me.txt_jumlah_angsuran = New System.Windows.Forms.TextBox()
        Me.txt_angsuran_bunga = New System.Windows.Forms.TextBox()
        Me.txt_angsuran_pokok = New System.Windows.Forms.TextBox()
        Me.txt_kode_pinjam = New System.Windows.Forms.TextBox()
        Me.txt_jumlah_diterima = New System.Windows.Forms.TextBox()
        Me.txt_administrasi = New System.Windows.Forms.TextBox()
        Me.txt_asuransi = New System.Windows.Forms.TextBox()
        Me.txt_bunga = New System.Windows.Forms.TextBox()
        Me.txt_lama_pinjam = New System.Windows.Forms.TextBox()
        Me.txt_besar_pinjam = New System.Windows.Forms.TextBox()
        Me.dtp_tanggal_pinjam = New System.Windows.Forms.DateTimePicker()
        Me.lbl_jumlah_angsuran = New System.Windows.Forms.Label()
        Me.lbl_angsuran_bunga = New System.Windows.Forms.Label()
        Me.lbl_angsuran_pokok = New System.Windows.Forms.Label()
        Me.lbl_jumlah_diterima = New System.Windows.Forms.Label()
        Me.lbl_administrasi = New System.Windows.Forms.Label()
        Me.lbl_asuransi = New System.Windows.Forms.Label()
        Me.lbl_bunga = New System.Windows.Forms.Label()
        Me.lbl_lama_pinjam = New System.Windows.Forms.Label()
        Me.lbl_besar_pinjam = New System.Windows.Forms.Label()
        Me.lbl_tanggal_pinjam = New System.Windows.Forms.Label()
        Me.lbl_kode_pinjam = New System.Windows.Forms.Label()
        Me.group_informasi_nasabah.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.group_data_peminjaman.SuspendLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.group_informasi_peminjaman.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_informasi_nasabah
        '
        Me.group_informasi_nasabah.Controls.Add(Me.btn_cari)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_nama)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_alamat)
        Me.group_informasi_nasabah.Controls.Add(Me.txt_kode_nasabah)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_alamat)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_nama)
        Me.group_informasi_nasabah.Controls.Add(Me.lbl_kode_nasabah)
        Me.group_informasi_nasabah.Location = New System.Drawing.Point(316, 66)
        Me.group_informasi_nasabah.Name = "group_informasi_nasabah"
        Me.group_informasi_nasabah.Size = New System.Drawing.Size(424, 105)
        Me.group_informasi_nasabah.TabIndex = 50
        Me.group_informasi_nasabah.TabStop = False
        Me.group_informasi_nasabah.Text = "Informasi Nasabah"
        '
        'btn_cari
        '
        Me.btn_cari.Location = New System.Drawing.Point(196, 17)
        Me.btn_cari.Name = "btn_cari"
        Me.btn_cari.Size = New System.Drawing.Size(75, 23)
        Me.btn_cari.TabIndex = 5
        Me.btn_cari.Text = "Cari"
        Me.btn_cari.UseVisualStyleBackColor = True
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(90, 46)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(224, 20)
        Me.txt_nama.TabIndex = 4
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
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(93, 12)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 2
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
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
        Me.grupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.grupBtn.Controls.Add(Me.btn_cetak_kwitansi)
        Me.grupBtn.Controls.Add(Me.btn_hapus)
        Me.grupBtn.Controls.Add(Me.btn_tambah)
        Me.grupBtn.Controls.Add(Me.btn_keluar)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 464)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(750, 41)
        Me.grupBtn.TabIndex = 48
        Me.grupBtn.TabStop = False
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
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(653, 12)
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
        Me.group_data_peminjaman.Size = New System.Drawing.Size(304, 390)
        Me.group_data_peminjaman.TabIndex = 47
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
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(8, 334)
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
        Me.dgv_data_peminjaman.Size = New System.Drawing.Size(292, 284)
        Me.dgv_data_peminjaman.TabIndex = 1
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(323, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk memasukan proses peminjaman nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.ForeColor = System.Drawing.Color.White
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(291, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Form Pinjam atau Piutang Nasabah"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 60)
        Me.Panel1.TabIndex = 46
        '
        'group_informasi_peminjaman
        '
        Me.group_informasi_peminjaman.Controls.Add(Me.cmb_JenisBunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_JenisBunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.btn_batal)
        Me.group_informasi_peminjaman.Controls.Add(Me.btn_simpan)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_persen)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_jumlah_angsuran)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_angsuran_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_angsuran_pokok)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_kode_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_jumlah_diterima)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_administrasi)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_asuransi)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_lama_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.txt_besar_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.dtp_tanggal_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_jumlah_angsuran)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_angsuran_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_angsuran_pokok)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_jumlah_diterima)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_administrasi)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_asuransi)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_bunga)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_lama_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_besar_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_tanggal_pinjam)
        Me.group_informasi_peminjaman.Controls.Add(Me.lbl_kode_pinjam)
        Me.group_informasi_peminjaman.Location = New System.Drawing.Point(316, 177)
        Me.group_informasi_peminjaman.Name = "group_informasi_peminjaman"
        Me.group_informasi_peminjaman.Size = New System.Drawing.Size(424, 279)
        Me.group_informasi_peminjaman.TabIndex = 53
        Me.group_informasi_peminjaman.TabStop = False
        Me.group_informasi_peminjaman.Text = "Informasi Peminjaman"
        '
        'cmb_JenisBunga
        '
        Me.cmb_JenisBunga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JenisBunga.FormattingEnabled = True
        Me.cmb_JenisBunga.Items.AddRange(New Object() {"FLAT", "EFEKTIF", "ANUITAS"})
        Me.cmb_JenisBunga.Location = New System.Drawing.Point(311, 81)
        Me.cmb_JenisBunga.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_JenisBunga.Name = "cmb_JenisBunga"
        Me.cmb_JenisBunga.Size = New System.Drawing.Size(108, 21)
        Me.cmb_JenisBunga.TabIndex = 26
        '
        'lbl_JenisBunga
        '
        Me.lbl_JenisBunga.AutoSize = True
        Me.lbl_JenisBunga.Location = New System.Drawing.Point(245, 84)
        Me.lbl_JenisBunga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_JenisBunga.Name = "lbl_JenisBunga"
        Me.lbl_JenisBunga.Size = New System.Drawing.Size(65, 13)
        Me.lbl_JenisBunga.TabIndex = 25
        Me.lbl_JenisBunga.Text = "Jenis Bunga"
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(175, 244)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 24
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(94, 244)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 23
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'lbl_persen
        '
        Me.lbl_persen.AutoSize = True
        Me.lbl_persen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_persen.Location = New System.Drawing.Point(140, 137)
        Me.lbl_persen.Name = "lbl_persen"
        Me.lbl_persen.Size = New System.Drawing.Size(20, 17)
        Me.lbl_persen.TabIndex = 22
        Me.lbl_persen.Text = "%"
        '
        'txt_jumlah_angsuran
        '
        Me.txt_jumlah_angsuran.Location = New System.Drawing.Point(320, 176)
        Me.txt_jumlah_angsuran.Name = "txt_jumlah_angsuran"
        Me.txt_jumlah_angsuran.ReadOnly = True
        Me.txt_jumlah_angsuran.Size = New System.Drawing.Size(100, 20)
        Me.txt_jumlah_angsuran.TabIndex = 21
        '
        'txt_angsuran_bunga
        '
        Me.txt_angsuran_bunga.Location = New System.Drawing.Point(320, 150)
        Me.txt_angsuran_bunga.Name = "txt_angsuran_bunga"
        Me.txt_angsuran_bunga.ReadOnly = True
        Me.txt_angsuran_bunga.Size = New System.Drawing.Size(100, 20)
        Me.txt_angsuran_bunga.TabIndex = 20
        '
        'txt_angsuran_pokok
        '
        Me.txt_angsuran_pokok.Location = New System.Drawing.Point(320, 123)
        Me.txt_angsuran_pokok.Name = "txt_angsuran_pokok"
        Me.txt_angsuran_pokok.ReadOnly = True
        Me.txt_angsuran_pokok.Size = New System.Drawing.Size(100, 20)
        Me.txt_angsuran_pokok.TabIndex = 19
        '
        'txt_kode_pinjam
        '
        Me.txt_kode_pinjam.Location = New System.Drawing.Point(319, 16)
        Me.txt_kode_pinjam.Name = "txt_kode_pinjam"
        Me.txt_kode_pinjam.Size = New System.Drawing.Size(101, 20)
        Me.txt_kode_pinjam.TabIndex = 18
        '
        'txt_jumlah_diterima
        '
        Me.txt_jumlah_diterima.Location = New System.Drawing.Point(94, 214)
        Me.txt_jumlah_diterima.Name = "txt_jumlah_diterima"
        Me.txt_jumlah_diterima.ReadOnly = True
        Me.txt_jumlah_diterima.Size = New System.Drawing.Size(100, 20)
        Me.txt_jumlah_diterima.TabIndex = 17
        '
        'txt_administrasi
        '
        Me.txt_administrasi.Location = New System.Drawing.Point(94, 188)
        Me.txt_administrasi.Name = "txt_administrasi"
        Me.txt_administrasi.Size = New System.Drawing.Size(100, 20)
        Me.txt_administrasi.TabIndex = 16
        '
        'txt_asuransi
        '
        Me.txt_asuransi.Location = New System.Drawing.Point(94, 162)
        Me.txt_asuransi.Name = "txt_asuransi"
        Me.txt_asuransi.Size = New System.Drawing.Size(100, 20)
        Me.txt_asuransi.TabIndex = 15
        '
        'txt_bunga
        '
        Me.txt_bunga.Location = New System.Drawing.Point(94, 135)
        Me.txt_bunga.Name = "txt_bunga"
        Me.txt_bunga.Size = New System.Drawing.Size(40, 20)
        Me.txt_bunga.TabIndex = 14
        '
        'txt_lama_pinjam
        '
        Me.txt_lama_pinjam.Location = New System.Drawing.Point(94, 108)
        Me.txt_lama_pinjam.Name = "txt_lama_pinjam"
        Me.txt_lama_pinjam.Size = New System.Drawing.Size(59, 20)
        Me.txt_lama_pinjam.TabIndex = 13
        '
        'txt_besar_pinjam
        '
        Me.txt_besar_pinjam.Location = New System.Drawing.Point(94, 81)
        Me.txt_besar_pinjam.Name = "txt_besar_pinjam"
        Me.txt_besar_pinjam.Size = New System.Drawing.Size(124, 20)
        Me.txt_besar_pinjam.TabIndex = 12
        '
        'dtp_tanggal_pinjam
        '
        Me.dtp_tanggal_pinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tanggal_pinjam.Location = New System.Drawing.Point(94, 54)
        Me.dtp_tanggal_pinjam.Name = "dtp_tanggal_pinjam"
        Me.dtp_tanggal_pinjam.Size = New System.Drawing.Size(106, 20)
        Me.dtp_tanggal_pinjam.TabIndex = 11
        '
        'lbl_jumlah_angsuran
        '
        Me.lbl_jumlah_angsuran.AutoSize = True
        Me.lbl_jumlah_angsuran.Location = New System.Drawing.Point(229, 176)
        Me.lbl_jumlah_angsuran.Name = "lbl_jumlah_angsuran"
        Me.lbl_jumlah_angsuran.Size = New System.Drawing.Size(88, 13)
        Me.lbl_jumlah_angsuran.TabIndex = 10
        Me.lbl_jumlah_angsuran.Text = "Jumlah Angsuran"
        '
        'lbl_angsuran_bunga
        '
        Me.lbl_angsuran_bunga.AutoSize = True
        Me.lbl_angsuran_bunga.Location = New System.Drawing.Point(229, 150)
        Me.lbl_angsuran_bunga.Name = "lbl_angsuran_bunga"
        Me.lbl_angsuran_bunga.Size = New System.Drawing.Size(86, 13)
        Me.lbl_angsuran_bunga.TabIndex = 9
        Me.lbl_angsuran_bunga.Text = "Angsuran Bunga"
        '
        'lbl_angsuran_pokok
        '
        Me.lbl_angsuran_pokok.AutoSize = True
        Me.lbl_angsuran_pokok.Location = New System.Drawing.Point(229, 123)
        Me.lbl_angsuran_pokok.Name = "lbl_angsuran_pokok"
        Me.lbl_angsuran_pokok.Size = New System.Drawing.Size(86, 13)
        Me.lbl_angsuran_pokok.TabIndex = 8
        Me.lbl_angsuran_pokok.Text = "Angsuran Pokok"
        '
        'lbl_jumlah_diterima
        '
        Me.lbl_jumlah_diterima.AutoSize = True
        Me.lbl_jumlah_diterima.Location = New System.Drawing.Point(6, 214)
        Me.lbl_jumlah_diterima.Name = "lbl_jumlah_diterima"
        Me.lbl_jumlah_diterima.Size = New System.Drawing.Size(79, 13)
        Me.lbl_jumlah_diterima.TabIndex = 7
        Me.lbl_jumlah_diterima.Text = "Jumlah diterima"
        '
        'lbl_administrasi
        '
        Me.lbl_administrasi.AutoSize = True
        Me.lbl_administrasi.Location = New System.Drawing.Point(6, 188)
        Me.lbl_administrasi.Name = "lbl_administrasi"
        Me.lbl_administrasi.Size = New System.Drawing.Size(62, 13)
        Me.lbl_administrasi.TabIndex = 6
        Me.lbl_administrasi.Text = "Administrasi"
        '
        'lbl_asuransi
        '
        Me.lbl_asuransi.AutoSize = True
        Me.lbl_asuransi.Location = New System.Drawing.Point(6, 162)
        Me.lbl_asuransi.Name = "lbl_asuransi"
        Me.lbl_asuransi.Size = New System.Drawing.Size(47, 13)
        Me.lbl_asuransi.TabIndex = 5
        Me.lbl_asuransi.Text = "Asuransi"
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Location = New System.Drawing.Point(6, 135)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(38, 13)
        Me.lbl_bunga.TabIndex = 4
        Me.lbl_bunga.Text = "Bunga"
        '
        'lbl_lama_pinjam
        '
        Me.lbl_lama_pinjam.AutoSize = True
        Me.lbl_lama_pinjam.Location = New System.Drawing.Point(6, 108)
        Me.lbl_lama_pinjam.Name = "lbl_lama_pinjam"
        Me.lbl_lama_pinjam.Size = New System.Drawing.Size(67, 13)
        Me.lbl_lama_pinjam.TabIndex = 3
        Me.lbl_lama_pinjam.Text = "Lama Pinjam"
        '
        'lbl_besar_pinjam
        '
        Me.lbl_besar_pinjam.AutoSize = True
        Me.lbl_besar_pinjam.Location = New System.Drawing.Point(6, 81)
        Me.lbl_besar_pinjam.Name = "lbl_besar_pinjam"
        Me.lbl_besar_pinjam.Size = New System.Drawing.Size(68, 13)
        Me.lbl_besar_pinjam.TabIndex = 2
        Me.lbl_besar_pinjam.Text = "Besar Pinjam"
        '
        'lbl_tanggal_pinjam
        '
        Me.lbl_tanggal_pinjam.AutoSize = True
        Me.lbl_tanggal_pinjam.Location = New System.Drawing.Point(6, 54)
        Me.lbl_tanggal_pinjam.Name = "lbl_tanggal_pinjam"
        Me.lbl_tanggal_pinjam.Size = New System.Drawing.Size(80, 13)
        Me.lbl_tanggal_pinjam.TabIndex = 1
        Me.lbl_tanggal_pinjam.Text = "Tanggal Pinjam"
        '
        'lbl_kode_pinjam
        '
        Me.lbl_kode_pinjam.AutoSize = True
        Me.lbl_kode_pinjam.Location = New System.Drawing.Point(247, 16)
        Me.lbl_kode_pinjam.Name = "lbl_kode_pinjam"
        Me.lbl_kode_pinjam.Size = New System.Drawing.Size(66, 13)
        Me.lbl_kode_pinjam.TabIndex = 0
        Me.lbl_kode_pinjam.Text = "Kode Pinjam"
        '
        'FormPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 505)
        Me.Controls.Add(Me.group_informasi_peminjaman)
        Me.Controls.Add(Me.group_informasi_nasabah)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_data_peminjaman)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPinjam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.group_informasi_nasabah.ResumeLayout(False)
        Me.group_informasi_nasabah.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.group_data_peminjaman.ResumeLayout(False)
        Me.group_data_peminjaman.PerformLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_informasi_peminjaman.ResumeLayout(False)
        Me.group_informasi_peminjaman.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents group_informasi_nasabah As GroupBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents group_data_peminjaman As GroupBox
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_data_peminjaman As DataGridView
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cetak_kwitansi As Button
    Friend WithEvents btn_cari As Button
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_kode_nasabah As TextBox
    Friend WithEvents lbl_alamat As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_kode_nasabah As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents group_informasi_peminjaman As GroupBox
    Friend WithEvents lbl_lama_pinjam As Label
    Friend WithEvents lbl_besar_pinjam As Label
    Friend WithEvents lbl_tanggal_pinjam As Label
    Friend WithEvents lbl_kode_pinjam As Label
    Friend WithEvents btn_batal As Button
    Friend WithEvents lbl_persen As Label
    Friend WithEvents txt_jumlah_angsuran As TextBox
    Friend WithEvents txt_angsuran_bunga As TextBox
    Friend WithEvents txt_angsuran_pokok As TextBox
    Friend WithEvents txt_kode_pinjam As TextBox
    Friend WithEvents txt_jumlah_diterima As TextBox
    Friend WithEvents txt_administrasi As TextBox
    Friend WithEvents txt_asuransi As TextBox
    Friend WithEvents txt_bunga As TextBox
    Friend WithEvents txt_lama_pinjam As TextBox
    Friend WithEvents txt_besar_pinjam As TextBox
    Friend WithEvents dtp_tanggal_pinjam As DateTimePicker
    Friend WithEvents lbl_jumlah_angsuran As Label
    Friend WithEvents lbl_angsuran_bunga As Label
    Friend WithEvents lbl_angsuran_pokok As Label
    Friend WithEvents lbl_jumlah_diterima As Label
    Friend WithEvents lbl_administrasi As Label
    Friend WithEvents lbl_asuransi As Label
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents cmb_JenisBunga As ComboBox
    Friend WithEvents lbl_JenisBunga As Label
End Class
