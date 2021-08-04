<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JenisSimpanan
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
        Me.group_cari_data_jenis = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_cari_data_jenis = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.group_data_jenis = New System.Windows.Forms.GroupBox()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.cmb_kategori = New System.Windows.Forms.ComboBox()
        Me.txt_bunga = New System.Windows.Forms.TextBox()
        Me.txt_besar_simpanan = New System.Windows.Forms.TextBox()
        Me.txt_kode_simpanan = New System.Windows.Forms.TextBox()
        Me.txt_nama_simpanan = New System.Windows.Forms.TextBox()
        Me.lbl_bunga = New System.Windows.Forms.Label()
        Me.lbl_besar_simpanan = New System.Windows.Forms.Label()
        Me.lbl_kode_simpanan = New System.Windows.Forms.Label()
        Me.lbl_nama_simpanan = New System.Windows.Forms.Label()
        Me.lbl_kategori = New System.Windows.Forms.Label()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_cari_data_jenis.SuspendLayout()
        CType(Me.dgv_cari_data_jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_data_jenis.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 60)
        Me.Panel1.TabIndex = 1
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(263, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk memasukan Jenis Simpanan"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(136, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Jenis Simpanan"
        '
        'group_cari_data_jenis
        '
        Me.group_cari_data_jenis.Controls.Add(Me.lbl_jumlah_data)
        Me.group_cari_data_jenis.Controls.Add(Me.dgv_cari_data_jenis)
        Me.group_cari_data_jenis.Controls.Add(Me.txt_search)
        Me.group_cari_data_jenis.Location = New System.Drawing.Point(12, 66)
        Me.group_cari_data_jenis.Name = "group_cari_data_jenis"
        Me.group_cari_data_jenis.Size = New System.Drawing.Size(350, 250)
        Me.group_cari_data_jenis.TabIndex = 4
        Me.group_cari_data_jenis.TabStop = False
        Me.group_cari_data_jenis.Text = "Cari Data Jenis"
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.ForeColor = System.Drawing.Color.Red
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(6, 225)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 4"
        '
        'dgv_cari_data_jenis
        '
        Me.dgv_cari_data_jenis.AllowUserToAddRows = False
        Me.dgv_cari_data_jenis.AllowUserToDeleteRows = False
        Me.dgv_cari_data_jenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cari_data_jenis.Location = New System.Drawing.Point(8, 43)
        Me.dgv_cari_data_jenis.Name = "dgv_cari_data_jenis"
        Me.dgv_cari_data_jenis.ReadOnly = True
        Me.dgv_cari_data_jenis.RowHeadersWidth = 51
        Me.dgv_cari_data_jenis.Size = New System.Drawing.Size(338, 177)
        Me.dgv_cari_data_jenis.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(6, 19)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(338, 20)
        Me.txt_search.TabIndex = 0
        '
        'group_data_jenis
        '
        Me.group_data_jenis.Controls.Add(Me.btn_batal)
        Me.group_data_jenis.Controls.Add(Me.btn_simpan)
        Me.group_data_jenis.Controls.Add(Me.cmb_kategori)
        Me.group_data_jenis.Controls.Add(Me.txt_bunga)
        Me.group_data_jenis.Controls.Add(Me.txt_besar_simpanan)
        Me.group_data_jenis.Controls.Add(Me.txt_kode_simpanan)
        Me.group_data_jenis.Controls.Add(Me.txt_nama_simpanan)
        Me.group_data_jenis.Controls.Add(Me.lbl_bunga)
        Me.group_data_jenis.Controls.Add(Me.lbl_besar_simpanan)
        Me.group_data_jenis.Controls.Add(Me.lbl_kode_simpanan)
        Me.group_data_jenis.Controls.Add(Me.lbl_nama_simpanan)
        Me.group_data_jenis.Controls.Add(Me.lbl_kategori)
        Me.group_data_jenis.Location = New System.Drawing.Point(368, 66)
        Me.group_data_jenis.Name = "group_data_jenis"
        Me.group_data_jenis.Size = New System.Drawing.Size(350, 250)
        Me.group_data_jenis.TabIndex = 5
        Me.group_data_jenis.TabStop = False
        Me.group_data_jenis.Text = "Informasi Data Jenis"
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(183, 153)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 11
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(102, 153)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 10
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'cmb_kategori
        '
        Me.cmb_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_kategori.FormattingEnabled = True
        Me.cmb_kategori.Items.AddRange(New Object() {"SUKARELA", "WAJIB", "POKOK"})
        Me.cmb_kategori.Location = New System.Drawing.Point(102, 22)
        Me.cmb_kategori.Name = "cmb_kategori"
        Me.cmb_kategori.Size = New System.Drawing.Size(102, 21)
        Me.cmb_kategori.TabIndex = 9
        '
        'txt_bunga
        '
        Me.txt_bunga.Location = New System.Drawing.Point(102, 127)
        Me.txt_bunga.Name = "txt_bunga"
        Me.txt_bunga.Size = New System.Drawing.Size(60, 20)
        Me.txt_bunga.TabIndex = 8
        '
        'txt_besar_simpanan
        '
        Me.txt_besar_simpanan.Location = New System.Drawing.Point(102, 101)
        Me.txt_besar_simpanan.Name = "txt_besar_simpanan"
        Me.txt_besar_simpanan.Size = New System.Drawing.Size(140, 20)
        Me.txt_besar_simpanan.TabIndex = 7
        '
        'txt_kode_simpanan
        '
        Me.txt_kode_simpanan.Location = New System.Drawing.Point(102, 75)
        Me.txt_kode_simpanan.Name = "txt_kode_simpanan"
        Me.txt_kode_simpanan.Size = New System.Drawing.Size(43, 20)
        Me.txt_kode_simpanan.TabIndex = 6
        '
        'txt_nama_simpanan
        '
        Me.txt_nama_simpanan.Location = New System.Drawing.Point(102, 49)
        Me.txt_nama_simpanan.Name = "txt_nama_simpanan"
        Me.txt_nama_simpanan.Size = New System.Drawing.Size(242, 20)
        Me.txt_nama_simpanan.TabIndex = 5
        '
        'lbl_bunga
        '
        Me.lbl_bunga.AutoSize = True
        Me.lbl_bunga.Location = New System.Drawing.Point(6, 127)
        Me.lbl_bunga.Name = "lbl_bunga"
        Me.lbl_bunga.Size = New System.Drawing.Size(61, 13)
        Me.lbl_bunga.TabIndex = 4
        Me.lbl_bunga.Text = "Bunga <%>"
        '
        'lbl_besar_simpanan
        '
        Me.lbl_besar_simpanan.AutoSize = True
        Me.lbl_besar_simpanan.Location = New System.Drawing.Point(6, 101)
        Me.lbl_besar_simpanan.Name = "lbl_besar_simpanan"
        Me.lbl_besar_simpanan.Size = New System.Drawing.Size(84, 13)
        Me.lbl_besar_simpanan.TabIndex = 3
        Me.lbl_besar_simpanan.Text = "Besar Simpanan"
        '
        'lbl_kode_simpanan
        '
        Me.lbl_kode_simpanan.AutoSize = True
        Me.lbl_kode_simpanan.Location = New System.Drawing.Point(6, 75)
        Me.lbl_kode_simpanan.Name = "lbl_kode_simpanan"
        Me.lbl_kode_simpanan.Size = New System.Drawing.Size(82, 13)
        Me.lbl_kode_simpanan.TabIndex = 2
        Me.lbl_kode_simpanan.Text = "Kode Simpanan"
        '
        'lbl_nama_simpanan
        '
        Me.lbl_nama_simpanan.AutoSize = True
        Me.lbl_nama_simpanan.Location = New System.Drawing.Point(6, 49)
        Me.lbl_nama_simpanan.Name = "lbl_nama_simpanan"
        Me.lbl_nama_simpanan.Size = New System.Drawing.Size(85, 13)
        Me.lbl_nama_simpanan.TabIndex = 1
        Me.lbl_nama_simpanan.Text = "Nama Simpanan"
        '
        'lbl_kategori
        '
        Me.lbl_kategori.AutoSize = True
        Me.lbl_kategori.Location = New System.Drawing.Point(6, 19)
        Me.lbl_kategori.Name = "lbl_kategori"
        Me.lbl_kategori.Size = New System.Drawing.Size(46, 13)
        Me.lbl_kategori.TabIndex = 0
        Me.lbl_kategori.Text = "Kategori"
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btn_keluar)
        Me.grupBtn.Controls.Add(Me.btn_hapus)
        Me.grupBtn.Controls.Add(Me.btn_ubah)
        Me.grupBtn.Controls.Add(Me.btn_tambah)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 322)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(727, 40)
        Me.grupBtn.TabIndex = 6
        Me.grupBtn.TabStop = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(647, 11)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 3
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(183, 11)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 2
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(102, 11)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 23)
        Me.btn_ubah.TabIndex = 1
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(21, 11)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'JenisSimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 362)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_data_jenis)
        Me.Controls.Add(Me.group_cari_data_jenis)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JenisSimpanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_cari_data_jenis.ResumeLayout(False)
        Me.group_cari_data_jenis.PerformLayout()
        CType(Me.dgv_cari_data_jenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_data_jenis.ResumeLayout(False)
        Me.group_data_jenis.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents group_cari_data_jenis As GroupBox
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_cari_data_jenis As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents group_data_jenis As GroupBox
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents cmb_kategori As ComboBox
    Friend WithEvents txt_bunga As TextBox
    Friend WithEvents txt_besar_simpanan As TextBox
    Friend WithEvents txt_kode_simpanan As TextBox
    Friend WithEvents txt_nama_simpanan As TextBox
    Friend WithEvents lbl_bunga As Label
    Friend WithEvents lbl_besar_simpanan As Label
    Friend WithEvents lbl_kode_simpanan As Label
    Friend WithEvents lbl_nama_simpanan As Label
    Friend WithEvents lbl_kategori As Label
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_tambah As Button
End Class
