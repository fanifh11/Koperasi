<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIsiSimpananSukarela
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
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Bayar = New System.Windows.Forms.Button()
        Me.btn_CariAnggota = New System.Windows.Forms.Button()
        Me.txt_Bunga = New System.Windows.Forms.TextBox()
        Me.dtp_TglSimpanan = New System.Windows.Forms.DateTimePicker()
        Me.txt_BesarSimpanan = New System.Windows.Forms.TextBox()
        Me.txt_JenisSimpanan = New System.Windows.Forms.TextBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.lbl_Bunga = New System.Windows.Forms.Label()
        Me.lbl_BesarSimpanan = New System.Windows.Forms.Label()
        Me.lbl_TglSimpanan = New System.Windows.Forms.Label()
        Me.lbl_JenisSimpanan = New System.Windows.Forms.Label()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.lbl_KodeAnggota = New System.Windows.Forms.Label()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(830, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(15, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Form ini digunakan untuk pengisian simpanan sukarela"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Isi Simpanan Sukarela"
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataAnggota.Location = New System.Drawing.Point(13, 58)
        Me.group_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Size = New System.Drawing.Size(326, 314)
        Me.group_DataAnggota.TabIndex = 16
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Data Anggota"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(5, 290)
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
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(5, 17)
        Me.dgv_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(311, 269)
        Me.dgv_DataAnggota.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lbl_Saldo)
        Me.Panel2.Location = New System.Drawing.Point(344, 68)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 83)
        Me.Panel2.TabIndex = 17
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Saldo.ForeColor = System.Drawing.Color.Red
        Me.lbl_Saldo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Saldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(472, 79)
        Me.lbl_Saldo.TabIndex = 0
        Me.lbl_Saldo.Text = "0"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Batal)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Bayar)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_CariAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Bunga)
        Me.group_InformasiAnggota.Controls.Add(Me.dtp_TglSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_BesarSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Bunga)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_BesarSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TglSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_JenisSimpanan)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_KodeAnggota)
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(344, 151)
        Me.group_InformasiAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(476, 220)
        Me.group_InformasiAnggota.TabIndex = 18
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'btn_Batal
        '
        Me.btn_Batal.Location = New System.Drawing.Point(212, 168)
        Me.btn_Batal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(84, 25)
        Me.btn_Batal.TabIndex = 14
        Me.btn_Batal.Text = "Batal"
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Bayar
        '
        Me.btn_Bayar.Location = New System.Drawing.Point(122, 168)
        Me.btn_Bayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Bayar.Name = "btn_Bayar"
        Me.btn_Bayar.Size = New System.Drawing.Size(84, 25)
        Me.btn_Bayar.TabIndex = 13
        Me.btn_Bayar.Text = "Bayar"
        Me.btn_Bayar.UseVisualStyleBackColor = True
        '
        'btn_CariAnggota
        '
        Me.btn_CariAnggota.Location = New System.Drawing.Point(275, 22)
        Me.btn_CariAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CariAnggota.Name = "btn_CariAnggota"
        Me.btn_CariAnggota.Size = New System.Drawing.Size(105, 22)
        Me.btn_CariAnggota.TabIndex = 12
        Me.btn_CariAnggota.Text = "Cari Anggota"
        Me.btn_CariAnggota.UseVisualStyleBackColor = True
        '
        'txt_Bunga
        '
        Me.txt_Bunga.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Bunga.Location = New System.Drawing.Point(122, 144)
        Me.txt_Bunga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Bunga.Name = "txt_Bunga"
        Me.txt_Bunga.ReadOnly = True
        Me.txt_Bunga.Size = New System.Drawing.Size(95, 20)
        Me.txt_Bunga.TabIndex = 11
        '
        'dtp_TglSimpanan
        '
        Me.dtp_TglSimpanan.Location = New System.Drawing.Point(122, 96)
        Me.dtp_TglSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtp_TglSimpanan.Name = "dtp_TglSimpanan"
        Me.dtp_TglSimpanan.Size = New System.Drawing.Size(188, 20)
        Me.dtp_TglSimpanan.TabIndex = 10
        '
        'txt_BesarSimpanan
        '
        Me.txt_BesarSimpanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_BesarSimpanan.Location = New System.Drawing.Point(122, 120)
        Me.txt_BesarSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_BesarSimpanan.Name = "txt_BesarSimpanan"
        Me.txt_BesarSimpanan.Size = New System.Drawing.Size(188, 20)
        Me.txt_BesarSimpanan.TabIndex = 9
        '
        'txt_JenisSimpanan
        '
        Me.txt_JenisSimpanan.BackColor = System.Drawing.SystemColors.Window
        Me.txt_JenisSimpanan.Location = New System.Drawing.Point(122, 72)
        Me.txt_JenisSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_JenisSimpanan.Name = "txt_JenisSimpanan"
        Me.txt_JenisSimpanan.ReadOnly = True
        Me.txt_JenisSimpanan.Size = New System.Drawing.Size(319, 20)
        Me.txt_JenisSimpanan.TabIndex = 8
        '
        'txt_Nama
        '
        Me.txt_Nama.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Nama.Location = New System.Drawing.Point(122, 48)
        Me.txt_Nama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(267, 20)
        Me.txt_Nama.TabIndex = 7
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.BackColor = System.Drawing.SystemColors.Window
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(122, 24)
        Me.txt_KodeAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.ReadOnly = True
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(131, 20)
        Me.txt_KodeAnggota.TabIndex = 6
        '
        'lbl_Bunga
        '
        Me.lbl_Bunga.AutoSize = True
        Me.lbl_Bunga.Location = New System.Drawing.Point(12, 144)
        Me.lbl_Bunga.Name = "lbl_Bunga"
        Me.lbl_Bunga.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Bunga.TabIndex = 5
        Me.lbl_Bunga.Text = "Bunga"
        '
        'lbl_BesarSimpanan
        '
        Me.lbl_BesarSimpanan.AutoSize = True
        Me.lbl_BesarSimpanan.Location = New System.Drawing.Point(12, 123)
        Me.lbl_BesarSimpanan.Name = "lbl_BesarSimpanan"
        Me.lbl_BesarSimpanan.Size = New System.Drawing.Size(99, 15)
        Me.lbl_BesarSimpanan.TabIndex = 4
        Me.lbl_BesarSimpanan.Text = "Besar Simpanan"
        '
        'lbl_TglSimpanan
        '
        Me.lbl_TglSimpanan.AutoSize = True
        Me.lbl_TglSimpanan.Location = New System.Drawing.Point(12, 96)
        Me.lbl_TglSimpanan.Name = "lbl_TglSimpanan"
        Me.lbl_TglSimpanan.Size = New System.Drawing.Size(112, 15)
        Me.lbl_TglSimpanan.TabIndex = 3
        Me.lbl_TglSimpanan.Text = "Tanggal Simpanan"
        '
        'lbl_JenisSimpanan
        '
        Me.lbl_JenisSimpanan.AutoSize = True
        Me.lbl_JenisSimpanan.Location = New System.Drawing.Point(15, 72)
        Me.lbl_JenisSimpanan.Name = "lbl_JenisSimpanan"
        Me.lbl_JenisSimpanan.Size = New System.Drawing.Size(96, 15)
        Me.lbl_JenisSimpanan.TabIndex = 2
        Me.lbl_JenisSimpanan.Text = "Jenis Simpanan"
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(15, 48)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Nama.TabIndex = 1
        Me.lbl_Nama.Text = "Nama"
        '
        'lbl_KodeAnggota
        '
        Me.lbl_KodeAnggota.AutoSize = True
        Me.lbl_KodeAnggota.Location = New System.Drawing.Point(15, 27)
        Me.lbl_KodeAnggota.Name = "lbl_KodeAnggota"
        Me.lbl_KodeAnggota.Size = New System.Drawing.Size(84, 15)
        Me.lbl_KodeAnggota.TabIndex = 0
        Me.lbl_KodeAnggota.Text = "Kode Anggota"
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btn_Keluar)
        Me.grupBtn.Controls.Add(Me.btn_Tambah)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 372)
        Me.grupBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupBtn.Size = New System.Drawing.Size(830, 50)
        Me.grupBtn.TabIndex = 20
        Me.grupBtn.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(744, 15)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(75, 24)
        Me.btn_Keluar.TabIndex = 2
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Tambah
        '
        Me.btn_Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Tambah.Location = New System.Drawing.Point(15, 15)
        Me.btn_Tambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(74, 24)
        Me.btn_Tambah.TabIndex = 0
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = True
        '
        'FormIsiSimpananSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 422)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIsiSimpananSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents txt_Bunga As TextBox
    Friend WithEvents dtp_TglSimpanan As DateTimePicker
    Friend WithEvents txt_BesarSimpanan As TextBox
    Friend WithEvents txt_JenisSimpanan As TextBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents lbl_Bunga As Label
    Friend WithEvents lbl_BesarSimpanan As Label
    Friend WithEvents lbl_TglSimpanan As Label
    Friend WithEvents lbl_JenisSimpanan As Label
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents lbl_KodeAnggota As Label
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Bayar As Button
    Friend WithEvents btn_CariAnggota As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Tambah As Button
    Friend WithEvents lbl As Label
    Friend WithEvents lbl_Saldo As Label
End Class
