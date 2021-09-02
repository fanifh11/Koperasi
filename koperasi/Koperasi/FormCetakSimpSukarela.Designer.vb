<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakSimpSukarela
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
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.txt_JenisSimpanan = New System.Windows.Forms.TextBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.btn_CariAnggota = New System.Windows.Forms.Button()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.lbl_JenisSimpanan = New System.Windows.Forms.Label()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.lbl_KodeAnggota = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_NominalUang = New System.Windows.Forms.Label()
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumlahData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 53)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(33, 25)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(313, 15)
        Me.lbl_Subjudul.TabIndex = 17
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk cetak data simpanan sukarela"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(21, 8)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(263, 20)
        Me.lbl_Judul.TabIndex = 12
        Me.lbl_Judul.Text = "Form Cetak Simpanan Sukarela" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.txt_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_CariAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_KodeAnggota)
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(356, 147)
        Me.group_InformasiAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(531, 202)
        Me.group_InformasiAnggota.TabIndex = 7
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'txt_JenisSimpanan
        '
        Me.txt_JenisSimpanan.Location = New System.Drawing.Point(107, 71)
        Me.txt_JenisSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_JenisSimpanan.Name = "txt_JenisSimpanan"
        Me.txt_JenisSimpanan.ReadOnly = True
        Me.txt_JenisSimpanan.Size = New System.Drawing.Size(385, 23)
        Me.txt_JenisSimpanan.TabIndex = 14
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(107, 44)
        Me.txt_Nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(283, 23)
        Me.txt_Nama.TabIndex = 10
        '
        'btn_CariAnggota
        '
        Me.btn_CariAnggota.Location = New System.Drawing.Point(246, 17)
        Me.btn_CariAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CariAnggota.Name = "btn_CariAnggota"
        Me.btn_CariAnggota.Size = New System.Drawing.Size(121, 24)
        Me.btn_CariAnggota.TabIndex = 9
        Me.btn_CariAnggota.Text = "Cari Anggota"
        Me.btn_CariAnggota.UseVisualStyleBackColor = True
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(107, 17)
        Me.txt_KodeAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.ReadOnly = True
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(121, 23)
        Me.txt_KodeAnggota.TabIndex = 8
        '
        'lbl_JenisSimpanan
        '
        Me.lbl_JenisSimpanan.AutoSize = True
        Me.lbl_JenisSimpanan.Location = New System.Drawing.Point(6, 71)
        Me.lbl_JenisSimpanan.Name = "lbl_JenisSimpanan"
        Me.lbl_JenisSimpanan.Size = New System.Drawing.Size(88, 15)
        Me.lbl_JenisSimpanan.TabIndex = 7
        Me.lbl_JenisSimpanan.Text = "Jenis Simpanan"
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(6, 44)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Nama.TabIndex = 6
        Me.lbl_Nama.Text = "Nama"
        '
        'lbl_KodeAnggota
        '
        Me.lbl_KodeAnggota.AutoSize = True
        Me.lbl_KodeAnggota.Location = New System.Drawing.Point(6, 18)
        Me.lbl_KodeAnggota.Name = "lbl_KodeAnggota"
        Me.lbl_KodeAnggota.Size = New System.Drawing.Size(83, 15)
        Me.lbl_KodeAnggota.TabIndex = 5
        Me.lbl_KodeAnggota.Text = "Kode Anggota"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_NominalUang)
        Me.Panel2.Location = New System.Drawing.Point(356, 74)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 68)
        Me.Panel2.TabIndex = 6
        '
        'lbl_NominalUang
        '
        Me.lbl_NominalUang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_NominalUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Italic)
        Me.lbl_NominalUang.ForeColor = System.Drawing.Color.Red
        Me.lbl_NominalUang.Location = New System.Drawing.Point(0, 0)
        Me.lbl_NominalUang.Name = "lbl_NominalUang"
        Me.lbl_NominalUang.Size = New System.Drawing.Size(529, 66)
        Me.lbl_NominalUang.TabIndex = 0
        Me.lbl_NominalUang.Text = "0"
        Me.lbl_NominalUang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumlahData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.group_DataAnggota.Location = New System.Drawing.Point(0, 65)
        Me.group_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Size = New System.Drawing.Size(342, 283)
        Me.group_DataAnggota.TabIndex = 5
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Data Anggota"
        '
        'lbl_JumlahData
        '
        Me.lbl_JumlahData.AutoSize = True
        Me.lbl_JumlahData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumlahData.Location = New System.Drawing.Point(13, 257)
        Me.lbl_JumlahData.Name = "lbl_JumlahData"
        Me.lbl_JumlahData.Size = New System.Drawing.Size(87, 15)
        Me.lbl_JumlahData.TabIndex = 3
        Me.lbl_JumlahData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(13, 21)
        Me.dgv_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(315, 227)
        Me.dgv_DataAnggota.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btn_Keluar)
        Me.GroupBox3.Controls.Add(Me.btn_Cetak)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 353)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(893, 57)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(800, 15)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(70, 31)
        Me.btn_Keluar.TabIndex = 1
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btn_Cetak.Location = New System.Drawing.Point(433, 17)
        Me.btn_Cetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(70, 30)
        Me.btn_Cetak.TabIndex = 0
        Me.btn_Cetak.Text = "Cetak"
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'FormCetakSimpSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 410)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCetakSimpSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents txt_JenisSimpanan As TextBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents btn_CariAnggota As Button
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents lbl_JenisSimpanan As Label
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents lbl_KodeAnggota As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_NominalUang As Label
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumlahData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Cetak As Button
End Class
