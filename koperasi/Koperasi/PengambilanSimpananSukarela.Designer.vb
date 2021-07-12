<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengambilanSimpananSukarela
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_data_anggota = New System.Windows.Forms.DataGridView()
        Me.group_data_anggota = New System.Windows.Forms.GroupBox()
        Me.button_keluar = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_harpus = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.group_informasi_anggota = New System.Windows.Forms.GroupBox()
        Me.btn_cari_anggota = New System.Windows.Forms.Button()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_ambil = New System.Windows.Forms.Button()
        Me.dtp_tanggal_ambil = New System.Windows.Forms.DateTimePicker()
        Me.txt_bunga = New System.Windows.Forms.TextBox()
        Me.txt_besar_ambil = New System.Windows.Forms.TextBox()
        Me.txt_jenis_simpanan = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_kode_anggota = New System.Windows.Forms.TextBox()
        Me.lbl_bunga = New System.Windows.Forms.Label()
        Me.lbl_besar_ambil = New System.Windows.Forms.Label()
        Me.lbl_tanggal_ambil = New System.Windows.Forms.Label()
        Me.lbl_jenis_simpanan = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.lbl_kode_anggota = New System.Windows.Forms.Label()
        Me.group_Nominal = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_data_anggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_data_anggota.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.group_informasi_anggota.SuspendLayout()
        Me.group_Nominal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 60)
        Me.Panel1.TabIndex = 41
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(280, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk pengambilan simpanan sukarela"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(273, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Pengambilan Simpanan Sukarela"
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(6, 287)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 0"
        '
        'dgv_data_anggota
        '
        Me.dgv_data_anggota.AllowUserToAddRows = False
        Me.dgv_data_anggota.AllowUserToDeleteRows = False
        Me.dgv_data_anggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_anggota.Location = New System.Drawing.Point(6, 19)
        Me.dgv_data_anggota.Name = "dgv_data_anggota"
        Me.dgv_data_anggota.ReadOnly = True
        Me.dgv_data_anggota.RowHeadersWidth = 51
        Me.dgv_data_anggota.Size = New System.Drawing.Size(250, 265)
        Me.dgv_data_anggota.TabIndex = 1
        '
        'group_data_anggota
        '
        Me.group_data_anggota.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_anggota.Controls.Add(Me.dgv_data_anggota)
        Me.group_data_anggota.Location = New System.Drawing.Point(6, 66)
        Me.group_data_anggota.Name = "group_data_anggota"
        Me.group_data_anggota.Size = New System.Drawing.Size(262, 309)
        Me.group_data_anggota.TabIndex = 42
        Me.group_data_anggota.TabStop = False
        Me.group_data_anggota.Text = "Data Anggota"
        '
        'button_keluar
        '
        Me.button_keluar.Location = New System.Drawing.Point(551, 12)
        Me.button_keluar.Name = "button_keluar"
        Me.button_keluar.Size = New System.Drawing.Size(75, 23)
        Me.button_keluar.TabIndex = 0
        Me.button_keluar.Text = "Keluar"
        Me.button_keluar.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btn_harpus)
        Me.grupBtn.Controls.Add(Me.btn_tambah)
        Me.grupBtn.Controls.Add(Me.button_keluar)
        Me.grupBtn.Location = New System.Drawing.Point(0, 381)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(632, 41)
        Me.grupBtn.TabIndex = 43
        Me.grupBtn.TabStop = False
        '
        'btn_harpus
        '
        Me.btn_harpus.Location = New System.Drawing.Point(93, 12)
        Me.btn_harpus.Name = "btn_harpus"
        Me.btn_harpus.Size = New System.Drawing.Size(75, 23)
        Me.btn_harpus.TabIndex = 2
        Me.btn_harpus.Text = "Hapus"
        Me.btn_harpus.UseVisualStyleBackColor = True
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
        'group_informasi_anggota
        '
        Me.group_informasi_anggota.Controls.Add(Me.btn_cari_anggota)
        Me.group_informasi_anggota.Controls.Add(Me.btn_batal)
        Me.group_informasi_anggota.Controls.Add(Me.btn_ambil)
        Me.group_informasi_anggota.Controls.Add(Me.dtp_tanggal_ambil)
        Me.group_informasi_anggota.Controls.Add(Me.txt_bunga)
        Me.group_informasi_anggota.Controls.Add(Me.txt_besar_ambil)
        Me.group_informasi_anggota.Controls.Add(Me.txt_jenis_simpanan)
        Me.group_informasi_anggota.Controls.Add(Me.txt_nama)
        Me.group_informasi_anggota.Controls.Add(Me.txt_kode_anggota)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_bunga)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_besar_ambil)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_tanggal_ambil)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_jenis_simpanan)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_nama)
        Me.group_informasi_anggota.Controls.Add(Me.lbl_kode_anggota)
        Me.group_informasi_anggota.Location = New System.Drawing.Point(274, 150)
        Me.group_informasi_anggota.Name = "group_informasi_anggota"
        Me.group_informasi_anggota.Size = New System.Drawing.Size(351, 225)
        Me.group_informasi_anggota.TabIndex = 44
        Me.group_informasi_anggota.TabStop = False
        Me.group_informasi_anggota.Text = "Informasi Anggota"
        '
        'btn_cari_anggota
        '
        Me.btn_cari_anggota.Location = New System.Drawing.Point(182, 17)
        Me.btn_cari_anggota.Name = "btn_cari_anggota"
        Me.btn_cari_anggota.Size = New System.Drawing.Size(81, 23)
        Me.btn_cari_anggota.TabIndex = 14
        Me.btn_cari_anggota.Text = "Cari Anggota"
        Me.btn_cari_anggota.UseVisualStyleBackColor = True
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(182, 175)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 13
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_ambil
        '
        Me.btn_ambil.Location = New System.Drawing.Point(101, 175)
        Me.btn_ambil.Name = "btn_ambil"
        Me.btn_ambil.Size = New System.Drawing.Size(75, 23)
        Me.btn_ambil.TabIndex = 12
        Me.btn_ambil.Text = "Ambil"
        Me.btn_ambil.UseVisualStyleBackColor = True
        '
        'dtp_tanggal_ambil
        '
        Me.dtp_tanggal_ambil.Location = New System.Drawing.Point(101, 97)
        Me.dtp_tanggal_ambil.Name = "dtp_tanggal_ambil"
        Me.dtp_tanggal_ambil.Size = New System.Drawing.Size(175, 20)
        Me.dtp_tanggal_ambil.TabIndex = 11
        '
        'txt_bunga
        '
        Me.txt_bunga.Location = New System.Drawing.Point(101, 149)
        Me.txt_bunga.Name = "txt_bunga"
        Me.txt_bunga.ReadOnly = True
        Me.txt_bunga.Size = New System.Drawing.Size(83, 20)
        Me.txt_bunga.TabIndex = 10
        '
        'txt_besar_ambil
        '
        Me.txt_besar_ambil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_besar_ambil.Location = New System.Drawing.Point(101, 123)
        Me.txt_besar_ambil.Name = "txt_besar_ambil"
        Me.txt_besar_ambil.Size = New System.Drawing.Size(135, 20)
        Me.txt_besar_ambil.TabIndex = 9
        '
        'txt_jenis_simpanan
        '
        Me.txt_jenis_simpanan.Location = New System.Drawing.Point(101, 71)
        Me.txt_jenis_simpanan.Name = "txt_jenis_simpanan"
        Me.txt_jenis_simpanan.ReadOnly = True
        Me.txt_jenis_simpanan.Size = New System.Drawing.Size(224, 20)
        Me.txt_jenis_simpanan.TabIndex = 8
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(101, 45)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.ReadOnly = True
        Me.txt_nama.Size = New System.Drawing.Size(175, 20)
        Me.txt_nama.TabIndex = 7
        '
        'txt_kode_anggota
        '
        Me.txt_kode_anggota.Location = New System.Drawing.Point(101, 19)
        Me.txt_kode_anggota.Name = "txt_kode_anggota"
        Me.txt_kode_anggota.ReadOnly = True
        Me.txt_kode_anggota.Size = New System.Drawing.Size(75, 20)
        Me.txt_kode_anggota.TabIndex = 6
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Location = New System.Drawing.Point(6, 149)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(38, 13)
        Me.lbl_bunga.TabIndex = 5
        Me.lbl_bunga.Text = "Bunga"
        '
        'lbl_besar_ambil
        '
        Me.lbl_besar_ambil.AutoSize = True
        Me.lbl_besar_ambil.Location = New System.Drawing.Point(6, 123)
        Me.lbl_besar_ambil.Name = "lbl_besar_ambil"
        Me.lbl_besar_ambil.Size = New System.Drawing.Size(62, 13)
        Me.lbl_besar_ambil.TabIndex = 4
        Me.lbl_besar_ambil.Text = "Besar Ambil"
        '
        'lbl_tanggal_ambil
        '
        Me.lbl_tanggal_ambil.AutoSize = True
        Me.lbl_tanggal_ambil.Location = New System.Drawing.Point(6, 97)
        Me.lbl_tanggal_ambil.Name = "lbl_tanggal_ambil"
        Me.lbl_tanggal_ambil.Size = New System.Drawing.Size(74, 13)
        Me.lbl_tanggal_ambil.TabIndex = 3
        Me.lbl_tanggal_ambil.Text = "Tanggal Ambil"
        '
        'lbl_jenis_simpanan
        '
        Me.lbl_jenis_simpanan.AutoSize = True
        Me.lbl_jenis_simpanan.Location = New System.Drawing.Point(6, 71)
        Me.lbl_jenis_simpanan.Name = "lbl_jenis_simpanan"
        Me.lbl_jenis_simpanan.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jenis_simpanan.TabIndex = 2
        Me.lbl_jenis_simpanan.Text = "Jenis Simpanan"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Location = New System.Drawing.Point(6, 45)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(35, 13)
        Me.lbl_nama.TabIndex = 1
        Me.lbl_nama.Text = "Nama"
        '
        'lbl_kode_anggota
        '
        Me.lbl_kode_anggota.AutoSize = True
        Me.lbl_kode_anggota.Location = New System.Drawing.Point(6, 19)
        Me.lbl_kode_anggota.Name = "lbl_kode_anggota"
        Me.lbl_kode_anggota.Size = New System.Drawing.Size(75, 13)
        Me.lbl_kode_anggota.TabIndex = 0
        Me.lbl_kode_anggota.Text = "Kode Anggota"
        '
        'group_Nominal
        '
        Me.group_Nominal.Controls.Add(Me.lbl_jumlah)
        Me.group_Nominal.Location = New System.Drawing.Point(275, 66)
        Me.group_Nominal.Name = "group_Nominal"
        Me.group_Nominal.Size = New System.Drawing.Size(351, 78)
        Me.group_Nominal.TabIndex = 45
        Me.group_Nominal.TabStop = False
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(163, 25)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(29, 31)
        Me.lbl_jumlah.TabIndex = 0
        Me.lbl_jumlah.Text = "0"
        '
        'PengambilanSimpananSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 423)
        Me.Controls.Add(Me.group_Nominal)
        Me.Controls.Add(Me.group_informasi_anggota)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.group_data_anggota)
        Me.Controls.Add(Me.grupBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PengambilanSimpananSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_data_anggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_data_anggota.ResumeLayout(False)
        Me.group_data_anggota.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.group_informasi_anggota.ResumeLayout(False)
        Me.group_informasi_anggota.PerformLayout()
        Me.group_Nominal.ResumeLayout(False)
        Me.group_Nominal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_data_anggota As DataGridView
    Friend WithEvents button_keluar As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_harpus As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents group_informasi_anggota As GroupBox
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_ambil As Button
    Friend WithEvents dtp_tanggal_ambil As DateTimePicker
    Friend WithEvents txt_bunga As TextBox
    Friend WithEvents txt_besar_ambil As TextBox
    Friend WithEvents txt_jenis_simpanan As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_kode_anggota As TextBox
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents lbl_besar_ambil As Label
    Friend WithEvents lbl_tanggal_ambil As Label
    Friend WithEvents lbl_jenis_simpanan As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_kode_anggota As Label
    Friend WithEvents group_Nominal As GroupBox
    Friend WithEvents lbl_jumlah As Label
    Friend WithEvents btn_cari_anggota As Button
    Friend WithEvents group_data_anggota As GroupBox
End Class
