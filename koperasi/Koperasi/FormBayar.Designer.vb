<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBayar
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
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_Hapus = New System.Windows.Forms.Button()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Bayar = New System.Windows.Forms.Button()
        Me.dtp_TglBayar = New System.Windows.Forms.DateTimePicker()
        Me.txt_BesarSimpanan = New System.Windows.Forms.TextBox()
        Me.txt_TglBiling = New System.Windows.Forms.TextBox()
        Me.txt_Keterangan = New System.Windows.Forms.TextBox()
        Me.txt_JenisSimpanan = New System.Windows.Forms.TextBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.btn_CariAnggota = New System.Windows.Forms.Button()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataAnggota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grupBtn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(985, 20)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(106, 26)
        Me.btn_Keluar.TabIndex = 33
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Tambah
        '
        Me.btn_Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Tambah.Location = New System.Drawing.Point(20, 18)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(106, 26)
        Me.btn_Tambah.TabIndex = 31
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btn_Keluar)
        Me.grupBtn.Controls.Add(Me.btn_Hapus)
        Me.grupBtn.Controls.Add(Me.btn_Tambah)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 401)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(1105, 50)
        Me.grupBtn.TabIndex = 20
        Me.grupBtn.TabStop = False
        '
        'btn_Hapus
        '
        Me.btn_Hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Hapus.Location = New System.Drawing.Point(133, 18)
        Me.btn_Hapus.Name = "btn_Hapus"
        Me.btn_Hapus.Size = New System.Drawing.Size(106, 26)
        Me.btn_Hapus.TabIndex = 32
        Me.btn_Hapus.Text = "Hapus"
        Me.btn_Hapus.UseVisualStyleBackColor = True
        '
        'btn_Batal
        '
        Me.btn_Batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Batal.Location = New System.Drawing.Point(274, 242)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(106, 26)
        Me.btn_Batal.TabIndex = 30
        Me.btn_Batal.Text = "Batal"
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Bayar
        '
        Me.btn_Bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Bayar.Location = New System.Drawing.Point(162, 242)
        Me.btn_Bayar.Name = "btn_Bayar"
        Me.btn_Bayar.Size = New System.Drawing.Size(106, 26)
        Me.btn_Bayar.TabIndex = 29
        Me.btn_Bayar.Text = "Bayar"
        Me.btn_Bayar.UseVisualStyleBackColor = True
        '
        'dtp_TglBayar
        '
        Me.dtp_TglBayar.Location = New System.Drawing.Point(162, 205)
        Me.dtp_TglBayar.Name = "dtp_TglBayar"
        Me.dtp_TglBayar.Size = New System.Drawing.Size(281, 21)
        Me.dtp_TglBayar.TabIndex = 28
        '
        'txt_BesarSimpanan
        '
        Me.txt_BesarSimpanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_BesarSimpanan.Location = New System.Drawing.Point(162, 173)
        Me.txt_BesarSimpanan.Name = "txt_BesarSimpanan"
        Me.txt_BesarSimpanan.ReadOnly = True
        Me.txt_BesarSimpanan.Size = New System.Drawing.Size(229, 21)
        Me.txt_BesarSimpanan.TabIndex = 27
        '
        'txt_TglBiling
        '
        Me.txt_TglBiling.Location = New System.Drawing.Point(162, 144)
        Me.txt_TglBiling.Name = "txt_TglBiling"
        Me.txt_TglBiling.ReadOnly = True
        Me.txt_TglBiling.Size = New System.Drawing.Size(229, 21)
        Me.txt_TglBiling.TabIndex = 26
        '
        'txt_Keterangan
        '
        Me.txt_Keterangan.Location = New System.Drawing.Point(162, 112)
        Me.txt_Keterangan.Name = "txt_Keterangan"
        Me.txt_Keterangan.ReadOnly = True
        Me.txt_Keterangan.Size = New System.Drawing.Size(310, 21)
        Me.txt_Keterangan.TabIndex = 25
        '
        'txt_JenisSimpanan
        '
        Me.txt_JenisSimpanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_JenisSimpanan.Location = New System.Drawing.Point(162, 83)
        Me.txt_JenisSimpanan.Name = "txt_JenisSimpanan"
        Me.txt_JenisSimpanan.ReadOnly = True
        Me.txt_JenisSimpanan.Size = New System.Drawing.Size(434, 21)
        Me.txt_JenisSimpanan.TabIndex = 24
        '
        'txt_Nama
        '
        Me.txt_Nama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Nama.Location = New System.Drawing.Point(162, 53)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(281, 21)
        Me.txt_Nama.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 66)
        Me.Panel1.TabIndex = 17
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.Location = New System.Drawing.Point(39, 34)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(433, 15)
        Me.lbl_Subjudul.TabIndex = 9
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk pembayaran simpanan pokok, wajib dan saldo awal"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.Location = New System.Drawing.Point(14, 9)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(347, 20)
        Me.lbl_Judul.TabIndex = 8
        Me.lbl_Judul.Text = "Bayar Simpanan Pokok, Wajib, Saldo Awal"
        '
        'btn_CariAnggota
        '
        Me.btn_CariAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_CariAnggota.Location = New System.Drawing.Point(425, 19)
        Me.btn_CariAnggota.Name = "btn_CariAnggota"
        Me.btn_CariAnggota.Size = New System.Drawing.Size(158, 26)
        Me.btn_CariAnggota.TabIndex = 22
        Me.btn_CariAnggota.Text = "Cari Anggota"
        Me.btn_CariAnggota.UseVisualStyleBackColor = True
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(162, 21)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.ReadOnly = True
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(229, 21)
        Me.txt_KodeAnggota.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label12.Location = New System.Drawing.Point(7, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Tanggal Bayar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label11.Location = New System.Drawing.Point(7, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Besar Simpanan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label10.Location = New System.Drawing.Point(7, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tanggal Billing"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label9.Location = New System.Drawing.Point(7, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Keterangan"
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Controls.Add(Me.txt_CariDataAnggota)
        Me.group_DataAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataAnggota.Location = New System.Drawing.Point(14, 72)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Size = New System.Drawing.Size(443, 324)
        Me.group_DataAnggota.TabIndex = 18
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Data Anggota"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(7, 290)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 12
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(7, 53)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(430, 224)
        Me.dgv_DataAnggota.TabIndex = 11
        '
        'txt_CariDataAnggota
        '
        Me.txt_CariDataAnggota.Location = New System.Drawing.Point(7, 23)
        Me.txt_CariDataAnggota.Name = "txt_CariDataAnggota"
        Me.txt_CariDataAnggota.Size = New System.Drawing.Size(429, 20)
        Me.txt_CariDataAnggota.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label6.Location = New System.Drawing.Point(7, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Jenis Simpanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label5.Location = New System.Drawing.Point(7, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nama"
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Batal)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Bayar)
        Me.group_InformasiAnggota.Controls.Add(Me.dtp_TglBayar)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_BesarSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_TglBiling)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Keterangan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_CariAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.Label12)
        Me.group_InformasiAnggota.Controls.Add(Me.Label11)
        Me.group_InformasiAnggota.Controls.Add(Me.Label10)
        Me.group_InformasiAnggota.Controls.Add(Me.Label9)
        Me.group_InformasiAnggota.Controls.Add(Me.Label6)
        Me.group_InformasiAnggota.Controls.Add(Me.Label5)
        Me.group_InformasiAnggota.Controls.Add(Me.Label4)
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(464, 72)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(627, 324)
        Me.group_InformasiAnggota.TabIndex = 19
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Kode Anggota"
        '
        'FormBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 451)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grupBtn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Tambah As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_Hapus As Button
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Bayar As Button
    Friend WithEvents dtp_TglBayar As DateTimePicker
    Friend WithEvents txt_BesarSimpanan As TextBox
    Friend WithEvents txt_TglBiling As TextBox
    Friend WithEvents txt_Keterangan As TextBox
    Friend WithEvents txt_JenisSimpanan As TextBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents btn_CariAnggota As Button
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents txt_CariDataAnggota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents Label4 As Label
End Class
