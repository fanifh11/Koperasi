<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGroupAkses
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.group_HakAkses = New System.Windows.Forms.GroupBox()
        Me.lbl_JumlahMenu = New System.Windows.Forms.Label()
        Me.clb_HakAkses = New System.Windows.Forms.CheckedListBox()
        Me.cmb_HakAkses = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupBtnHakAkses = New System.Windows.Forms.GroupBox()
        Me.btnSimpanHakAkses = New System.Windows.Forms.Button()
        Me.btnTampilkanMenu = New System.Windows.Forms.Button()
        Me.group_DataGroup = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txt_Keterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Group = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_JumDataGroup = New System.Windows.Forms.Label()
        Me.dgv_JumGroup = New System.Windows.Forms.DataGridView()
        Me.groupBtnInputData = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.groupBtnBottom = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_HakAkses.SuspendLayout()
        Me.groupBtnHakAkses.SuspendLayout()
        Me.group_DataGroup.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_JumGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBtnInputData.SuspendLayout()
        Me.groupBtnBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 80)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(600, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Form ini digunakan untuk membuat GROUP dan hak akses pada masing-masing GROUP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Group Akses"
        '
        'group_HakAkses
        '
        Me.group_HakAkses.Controls.Add(Me.lbl_JumlahMenu)
        Me.group_HakAkses.Controls.Add(Me.clb_HakAkses)
        Me.group_HakAkses.Controls.Add(Me.cmb_HakAkses)
        Me.group_HakAkses.Controls.Add(Me.Label3)
        Me.group_HakAkses.Location = New System.Drawing.Point(13, 87)
        Me.group_HakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_HakAkses.Name = "group_HakAkses"
        Me.group_HakAkses.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_HakAkses.Size = New System.Drawing.Size(429, 394)
        Me.group_HakAkses.TabIndex = 1
        Me.group_HakAkses.TabStop = False
        Me.group_HakAkses.Text = "Hak Akses"
        '
        'lbl_JumlahMenu
        '
        Me.lbl_JumlahMenu.AutoSize = True
        Me.lbl_JumlahMenu.Location = New System.Drawing.Point(69, 369)
        Me.lbl_JumlahMenu.Name = "lbl_JumlahMenu"
        Me.lbl_JumlahMenu.Size = New System.Drawing.Size(100, 17)
        Me.lbl_JumlahMenu.TabIndex = 3
        Me.lbl_JumlahMenu.Text = "Jumlah Menu :"
        '
        'clb_HakAkses
        '
        Me.clb_HakAkses.FormattingEnabled = True
        Me.clb_HakAkses.Items.AddRange(New Object() {"Utilitas", "        Identitas", "        Group", "        User", "        Backup Database", "        Restore Database", "        Reset Data", "Master", "        Anggota", "        Tahun Aktif", "        Jenis Simpanan", "        Buku Simpanan Sukarela", "Simpanan", "        Buat Tagihan Simpanan", "        Lihat Tagihan Simpanan", "        Pembayaran Simpanan Pokok Wajib", "        Pembayaran Kolektif Simpanan Pokok", "        Pengambilan Simpanan Pokok Wajib", "        Buat Rekening Simpanan Sukarela", "        Pembayaran Simpanan Sukarela", "        Pengambilan Simpanan Sukarela", "        Cetak Simpanan Sukarela", "        Hitung Bunga Simpanan", "        Cetak Sampul Buku Simpanan", "        Cetak Buku Simpanan", "Pinjaman" & Global.Microsoft.VisualBasic.ChrW(9), "        Buat Pinjaman", "        Buat Tagihan", "        Lihat Tagihan Pinjaman", "        Pembayaran Pinjaman Perorangan", "        Pembayaran Kolektif Pinjaman", "        Koreksi Pinjaman Nasabah", "        Koreksi Pembayaran Nasabah", "Laporan", "        Anggota", "        Peminjaman", "        Pembayaran Asuransi", "        Pembayaran Administrasi", "        Pembayaran Pinjaman", "        Histori Pembayaran Pinjaman", "        Saldo Piutang", "        Rekapitulasi Pendapatan", "        Rekapitulasi Saldo Piutang", "        Rekapitulasi Simpanan Pokok Wajib", "        Rekapitulasi Simpanan Sukarela", "        Lap. Transaksi Simpanan Sukarela", "        Lap. Simpanan Pokok Wajib", "        Lap. Tunggakan Simpanan", "        Lap. Pembayaran Bunga", "        Proses SHU", "Keluar Aplikasi", "        Keluar"})
        Me.clb_HakAkses.Location = New System.Drawing.Point(69, 69)
        Me.clb_HakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clb_HakAkses.Name = "clb_HakAkses"
        Me.clb_HakAkses.Size = New System.Drawing.Size(355, 242)
        Me.clb_HakAkses.TabIndex = 2
        '
        'cmb_HakAkses
        '
        Me.cmb_HakAkses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HakAkses.FormattingEnabled = True
        Me.cmb_HakAkses.Location = New System.Drawing.Point(69, 30)
        Me.cmb_HakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_HakAkses.Name = "cmb_HakAkses"
        Me.cmb_HakAkses.Size = New System.Drawing.Size(355, 24)
        Me.cmb_HakAkses.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Group"
        '
        'groupBtnHakAkses
        '
        Me.groupBtnHakAkses.Controls.Add(Me.btnSimpanHakAkses)
        Me.groupBtnHakAkses.Controls.Add(Me.btnTampilkanMenu)
        Me.groupBtnHakAkses.Location = New System.Drawing.Point(12, 480)
        Me.groupBtnHakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnHakAkses.Name = "groupBtnHakAkses"
        Me.groupBtnHakAkses.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnHakAkses.Size = New System.Drawing.Size(431, 59)
        Me.groupBtnHakAkses.TabIndex = 2
        Me.groupBtnHakAkses.TabStop = False
        '
        'btnSimpanHakAkses
        '
        Me.btnSimpanHakAkses.Location = New System.Drawing.Point(212, 15)
        Me.btnSimpanHakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpanHakAkses.Name = "btnSimpanHakAkses"
        Me.btnSimpanHakAkses.Size = New System.Drawing.Size(188, 31)
        Me.btnSimpanHakAkses.TabIndex = 3
        Me.btnSimpanHakAkses.Text = "Simpan Hak Akses"
        Me.btnSimpanHakAkses.UseVisualStyleBackColor = True
        '
        'btnTampilkanMenu
        '
        Me.btnTampilkanMenu.Location = New System.Drawing.Point(33, 15)
        Me.btnTampilkanMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTampilkanMenu.Name = "btnTampilkanMenu"
        Me.btnTampilkanMenu.Size = New System.Drawing.Size(173, 31)
        Me.btnTampilkanMenu.TabIndex = 0
        Me.btnTampilkanMenu.Text = "Tampilkan Menu"
        Me.btnTampilkanMenu.UseVisualStyleBackColor = True
        '
        'group_DataGroup
        '
        Me.group_DataGroup.Controls.Add(Me.btnBatal)
        Me.group_DataGroup.Controls.Add(Me.txt_Keterangan)
        Me.group_DataGroup.Controls.Add(Me.Label6)
        Me.group_DataGroup.Controls.Add(Me.btnSimpan)
        Me.group_DataGroup.Controls.Add(Me.Label5)
        Me.group_DataGroup.Controls.Add(Me.txt_Group)
        Me.group_DataGroup.Location = New System.Drawing.Point(449, 87)
        Me.group_DataGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataGroup.Name = "group_DataGroup"
        Me.group_DataGroup.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataGroup.Size = New System.Drawing.Size(397, 135)
        Me.group_DataGroup.TabIndex = 3
        Me.group_DataGroup.TabStop = False
        Me.group_DataGroup.Text = "Input Data Group"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(203, 85)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(91, 31)
        Me.btnBatal.TabIndex = 5
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txt_Keterangan
        '
        Me.txt_Keterangan.Location = New System.Drawing.Point(105, 57)
        Me.txt_Keterangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Keterangan.Name = "txt_Keterangan"
        Me.txt_Keterangan.Size = New System.Drawing.Size(247, 22)
        Me.txt_Keterangan.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Keterangan"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(105, 85)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(91, 31)
        Me.btnSimpan.TabIndex = 4
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Group"
        '
        'txt_Group
        '
        Me.txt_Group.Location = New System.Drawing.Point(105, 30)
        Me.txt_Group.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Group.Name = "txt_Group"
        Me.txt_Group.Size = New System.Drawing.Size(247, 22)
        Me.txt_Group.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_JumDataGroup)
        Me.GroupBox4.Controls.Add(Me.dgv_JumGroup)
        Me.GroupBox4.Location = New System.Drawing.Point(449, 222)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(397, 260)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'lbl_JumDataGroup
        '
        Me.lbl_JumDataGroup.AutoSize = True
        Me.lbl_JumDataGroup.Location = New System.Drawing.Point(5, 235)
        Me.lbl_JumDataGroup.Name = "lbl_JumDataGroup"
        Me.lbl_JumDataGroup.Size = New System.Drawing.Size(105, 17)
        Me.lbl_JumDataGroup.TabIndex = 6
        Me.lbl_JumDataGroup.Text = "Jumlah Group :"
        '
        'dgv_JumGroup
        '
        Me.dgv_JumGroup.AllowUserToAddRows = False
        Me.dgv_JumGroup.AllowUserToDeleteRows = False
        Me.dgv_JumGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_JumGroup.Location = New System.Drawing.Point(5, 14)
        Me.dgv_JumGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_JumGroup.Name = "dgv_JumGroup"
        Me.dgv_JumGroup.ReadOnly = True
        Me.dgv_JumGroup.RowHeadersWidth = 51
        Me.dgv_JumGroup.RowTemplate.Height = 24
        Me.dgv_JumGroup.Size = New System.Drawing.Size(387, 214)
        Me.dgv_JumGroup.TabIndex = 0
        '
        'groupBtnInputData
        '
        Me.groupBtnInputData.Controls.Add(Me.btnHapus)
        Me.groupBtnInputData.Controls.Add(Me.btnTambah)
        Me.groupBtnInputData.Location = New System.Drawing.Point(449, 480)
        Me.groupBtnInputData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnInputData.Name = "groupBtnInputData"
        Me.groupBtnInputData.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnInputData.Size = New System.Drawing.Size(397, 59)
        Me.groupBtnInputData.TabIndex = 6
        Me.groupBtnInputData.TabStop = False
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(125, 15)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 31)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(19, 15)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 31)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'groupBtnBottom
        '
        Me.groupBtnBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.groupBtnBottom.Controls.Add(Me.btnKeluar)
        Me.groupBtnBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBtnBottom.Location = New System.Drawing.Point(0, 553)
        Me.groupBtnBottom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnBottom.Name = "groupBtnBottom"
        Me.groupBtnBottom.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBtnBottom.Size = New System.Drawing.Size(859, 57)
        Me.groupBtnBottom.TabIndex = 7
        Me.groupBtnBottom.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(696, 16)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(100, 31)
        Me.btnKeluar.TabIndex = 8
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'FormGroupAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 610)
        Me.Controls.Add(Me.groupBtnBottom)
        Me.Controls.Add(Me.groupBtnInputData)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.group_DataGroup)
        Me.Controls.Add(Me.groupBtnHakAkses)
        Me.Controls.Add(Me.group_HakAkses)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGroupAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_HakAkses.ResumeLayout(False)
        Me.group_HakAkses.PerformLayout()
        Me.groupBtnHakAkses.ResumeLayout(False)
        Me.group_DataGroup.ResumeLayout(False)
        Me.group_DataGroup.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_JumGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBtnInputData.ResumeLayout(False)
        Me.groupBtnBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents group_HakAkses As GroupBox
    Friend WithEvents clb_HakAkses As CheckedListBox
    Friend WithEvents cmb_HakAkses As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_JumlahMenu As Label
    Friend WithEvents groupBtnHakAkses As GroupBox
    Friend WithEvents btnSimpanHakAkses As Button
    Friend WithEvents btnTampilkanMenu As Button
    Friend WithEvents group_DataGroup As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents txt_Keterangan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Group As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_JumDataGroup As Label
    Friend WithEvents dgv_JumGroup As DataGridView
    Friend WithEvents groupBtnInputData As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents groupBtnBottom As GroupBox
    Friend WithEvents btnKeluar As Button
End Class
