<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakBukuSimpSukarela
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
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.lbl_NominalUang = New System.Windows.Forms.Label()
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.txt_maxCetak = New System.Windows.Forms.TextBox()
        Me.txt_noCetak = New System.Windows.Forms.TextBox()
        Me.txt_JenisSimpanan = New System.Windows.Forms.TextBox()
        Me.lbl_NoCetak = New System.Windows.Forms.Label()
        Me.lbl_JenisSimpanan = New System.Windows.Forms.Label()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.btn_CariAnggota = New System.Windows.Forms.Button()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.lbl_KodeAnggota = New System.Windows.Forms.Label()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 74)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(26, 35)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(316, 15)
        Me.lbl_Subjudul.TabIndex = 15
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk cetak buku simpanan sukarela"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(9, 15)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(269, 20)
        Me.lbl_Judul.TabIndex = 14
        Me.lbl_Judul.Text = "Form Cetak Buku Simp Sukarela" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataAnggota.Location = New System.Drawing.Point(12, 90)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Size = New System.Drawing.Size(472, 389)
        Me.group_DataAnggota.TabIndex = 1
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Data Anggota"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(17, 349)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 1
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(17, 23)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(435, 323)
        Me.dgv_DataAnggota.TabIndex = 0
        '
        'lbl_NominalUang
        '
        Me.lbl_NominalUang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_NominalUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_NominalUang.ForeColor = System.Drawing.Color.Red
        Me.lbl_NominalUang.Location = New System.Drawing.Point(3, 17)
        Me.lbl_NominalUang.Name = "lbl_NominalUang"
        Me.lbl_NominalUang.Size = New System.Drawing.Size(628, 80)
        Me.lbl_NominalUang.TabIndex = 0
        Me.lbl_NominalUang.Text = "0"
        Me.lbl_NominalUang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.txt_maxCetak)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_noCetak)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_NoCetak)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_CariAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_KodeAnggota)
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(490, 196)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(635, 283)
        Me.group_InformasiAnggota.TabIndex = 3
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'txt_maxCetak
        '
        Me.txt_maxCetak.Location = New System.Drawing.Point(282, 130)
        Me.txt_maxCetak.Name = "txt_maxCetak"
        Me.txt_maxCetak.ReadOnly = True
        Me.txt_maxCetak.Size = New System.Drawing.Size(125, 20)
        Me.txt_maxCetak.TabIndex = 9
        '
        'txt_noCetak
        '
        Me.txt_noCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_noCetak.Enabled = False
        Me.txt_noCetak.Location = New System.Drawing.Point(151, 130)
        Me.txt_noCetak.Name = "txt_noCetak"
        Me.txt_noCetak.Size = New System.Drawing.Size(125, 20)
        Me.txt_noCetak.TabIndex = 8
        '
        'txt_JenisSimpanan
        '
        Me.txt_JenisSimpanan.Location = New System.Drawing.Point(151, 93)
        Me.txt_JenisSimpanan.Name = "txt_JenisSimpanan"
        Me.txt_JenisSimpanan.ReadOnly = True
        Me.txt_JenisSimpanan.Size = New System.Drawing.Size(419, 20)
        Me.txt_JenisSimpanan.TabIndex = 7
        '
        'lbl_NoCetak
        '
        Me.lbl_NoCetak.AutoSize = True
        Me.lbl_NoCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_NoCetak.Location = New System.Drawing.Point(21, 133)
        Me.lbl_NoCetak.Name = "lbl_NoCetak"
        Me.lbl_NoCetak.Size = New System.Drawing.Size(65, 15)
        Me.lbl_NoCetak.TabIndex = 6
        Me.lbl_NoCetak.Text = "No Cetak"
        '
        'lbl_JenisSimpanan
        '
        Me.lbl_JenisSimpanan.AutoSize = True
        Me.lbl_JenisSimpanan.Location = New System.Drawing.Point(21, 96)
        Me.lbl_JenisSimpanan.Name = "lbl_JenisSimpanan"
        Me.lbl_JenisSimpanan.Size = New System.Drawing.Size(96, 15)
        Me.lbl_JenisSimpanan.TabIndex = 5
        Me.lbl_JenisSimpanan.Text = "Jenis Simpanan"
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(151, 62)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(300, 20)
        Me.txt_Nama.TabIndex = 4
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(21, 62)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Nama.TabIndex = 3
        Me.lbl_Nama.Text = "Nama"
        '
        'btn_CariAnggota
        '
        Me.btn_CariAnggota.Location = New System.Drawing.Point(282, 24)
        Me.btn_CariAnggota.Name = "btn_CariAnggota"
        Me.btn_CariAnggota.Size = New System.Drawing.Size(133, 29)
        Me.btn_CariAnggota.TabIndex = 2
        Me.btn_CariAnggota.Text = "Cari Anggota"
        Me.btn_CariAnggota.UseVisualStyleBackColor = True
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(151, 29)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.ReadOnly = True
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(125, 20)
        Me.txt_KodeAnggota.TabIndex = 1
        '
        'lbl_KodeAnggota
        '
        Me.lbl_KodeAnggota.AutoSize = True
        Me.lbl_KodeAnggota.Location = New System.Drawing.Point(21, 29)
        Me.lbl_KodeAnggota.Name = "lbl_KodeAnggota"
        Me.lbl_KodeAnggota.Size = New System.Drawing.Size(84, 15)
        Me.lbl_KodeAnggota.TabIndex = 0
        Me.lbl_KodeAnggota.Text = "Kode Anggota"
        '
        'grupBtn
        '
        Me.grupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.grupBtn.Controls.Add(Me.btn_Keluar)
        Me.grupBtn.Controls.Add(Me.btn_Cetak)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 483)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(1135, 60)
        Me.grupBtn.TabIndex = 10
        Me.grupBtn.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(1008, 23)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Keluar.TabIndex = 1
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Cetak.Location = New System.Drawing.Point(490, 23)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(94, 29)
        Me.btn_Cetak.TabIndex = 0
        Me.btn_Cetak.Text = "Cetak"
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_NominalUang)
        Me.GroupBox1.Location = New System.Drawing.Point(490, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'FormCetakBukuSimpSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCetakBukuSimpSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents lbl_NominalUang As Label
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents txt_maxCetak As TextBox
    Friend WithEvents txt_noCetak As TextBox
    Friend WithEvents txt_JenisSimpanan As TextBox
    Friend WithEvents lbl_NoCetak As Label
    Friend WithEvents lbl_JenisSimpanan As Label
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents btn_CariAnggota As Button
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents lbl_KodeAnggota As Label
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Cetak As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
