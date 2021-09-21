<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataIdentitasKoperasi
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
        Me.group_InformasiKoperasi = New System.Windows.Forms.GroupBox()
        Me.tbAlamatOrang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNoKtP = New System.Windows.Forms.TextBox()
        Me.tbPekerjaan = New System.Windows.Forms.TextBox()
        Me.tbUmur = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtBendahara = New System.Windows.Forms.TextBox()
        Me.txtPimpinan = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNamaInstansi = New System.Windows.Forms.TextBox()
        Me.txtNamaKoperasi = New System.Windows.Forms.TextBox()
        Me.lbl_NoTelp = New System.Windows.Forms.Label()
        Me.lbl_BendaharaKoperasi = New System.Windows.Forms.Label()
        Me.lbl_PimpinanKoperasi = New System.Windows.Forms.Label()
        Me.lbl_Alamat = New System.Windows.Forms.Label()
        Me.lbl_NamaInstansi = New System.Windows.Forms.Label()
        Me.lbl_NamaKoperasi = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.imgKoperasi = New System.Windows.Forms.PictureBox()
        Me.btnCariLogi = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.tbToleransiTagihan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.group_InformasiKoperasi.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgKoperasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 55)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(32, 28)
        Me.lbl_Subjudul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(301, 15)
        Me.lbl_Subjudul.TabIndex = 1
        Me.lbl_Subjudul.Text = "Menu Ini digunakan untuk memasukan data koperasi "
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(16, 7)
        Me.lbl_Judul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(199, 20)
        Me.lbl_Judul.TabIndex = 0
        Me.lbl_Judul.Text = "Data Identitas Koperasi"
        '
        'group_InformasiKoperasi
        '
        Me.group_InformasiKoperasi.Controls.Add(Me.Label7)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbToleransiTagihan)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label6)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbAlamatOrang)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label5)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbNoKtP)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbPekerjaan)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbUmur)
        Me.group_InformasiKoperasi.Controls.Add(Me.tbNama)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label1)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label2)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label3)
        Me.group_InformasiKoperasi.Controls.Add(Me.Label4)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtNoTelp)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtBendahara)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtPimpinan)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtAlamat)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtNamaInstansi)
        Me.group_InformasiKoperasi.Controls.Add(Me.txtNamaKoperasi)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_NoTelp)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_BendaharaKoperasi)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_PimpinanKoperasi)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_Alamat)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_NamaInstansi)
        Me.group_InformasiKoperasi.Controls.Add(Me.lbl_NamaKoperasi)
        Me.group_InformasiKoperasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_InformasiKoperasi.Location = New System.Drawing.Point(10, 61)
        Me.group_InformasiKoperasi.Margin = New System.Windows.Forms.Padding(2)
        Me.group_InformasiKoperasi.Name = "group_InformasiKoperasi"
        Me.group_InformasiKoperasi.Padding = New System.Windows.Forms.Padding(2)
        Me.group_InformasiKoperasi.Size = New System.Drawing.Size(488, 325)
        Me.group_InformasiKoperasi.TabIndex = 1
        Me.group_InformasiKoperasi.TabStop = False
        Me.group_InformasiKoperasi.Text = "Informasi Koperasi"
        '
        'tbAlamatOrang
        '
        Me.tbAlamatOrang.Location = New System.Drawing.Point(126, 273)
        Me.tbAlamatOrang.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAlamatOrang.Name = "tbAlamatOrang"
        Me.tbAlamatOrang.Size = New System.Drawing.Size(354, 20)
        Me.tbAlamatOrang.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 273)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Alamat"
        '
        'tbNoKtP
        '
        Me.tbNoKtP.Location = New System.Drawing.Point(126, 248)
        Me.tbNoKtP.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNoKtP.Name = "tbNoKtP"
        Me.tbNoKtP.Size = New System.Drawing.Size(354, 20)
        Me.tbNoKtP.TabIndex = 19
        '
        'tbPekerjaan
        '
        Me.tbPekerjaan.Location = New System.Drawing.Point(126, 224)
        Me.tbPekerjaan.Margin = New System.Windows.Forms.Padding(2)
        Me.tbPekerjaan.Name = "tbPekerjaan"
        Me.tbPekerjaan.Size = New System.Drawing.Size(354, 20)
        Me.tbPekerjaan.TabIndex = 18
        '
        'tbUmur
        '
        Me.tbUmur.Location = New System.Drawing.Point(126, 199)
        Me.tbUmur.Margin = New System.Windows.Forms.Padding(2)
        Me.tbUmur.Name = "tbUmur"
        Me.tbUmur.Size = New System.Drawing.Size(354, 20)
        Me.tbUmur.TabIndex = 17
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(126, 175)
        Me.tbNama.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(354, 20)
        Me.tbNama.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 248)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "No. KTP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Pekerjaan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Umur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nama"
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(125, 147)
        Me.txtNoTelp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(354, 20)
        Me.txtNoTelp.TabIndex = 11
        '
        'txtBendahara
        '
        Me.txtBendahara.Location = New System.Drawing.Point(125, 123)
        Me.txtBendahara.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBendahara.Name = "txtBendahara"
        Me.txtBendahara.Size = New System.Drawing.Size(354, 20)
        Me.txtBendahara.TabIndex = 10
        '
        'txtPimpinan
        '
        Me.txtPimpinan.Location = New System.Drawing.Point(125, 98)
        Me.txtPimpinan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPimpinan.Name = "txtPimpinan"
        Me.txtPimpinan.Size = New System.Drawing.Size(354, 20)
        Me.txtPimpinan.TabIndex = 9
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(125, 74)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(354, 20)
        Me.txtAlamat.TabIndex = 8
        '
        'txtNamaInstansi
        '
        Me.txtNamaInstansi.Location = New System.Drawing.Point(125, 50)
        Me.txtNamaInstansi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNamaInstansi.Name = "txtNamaInstansi"
        Me.txtNamaInstansi.Size = New System.Drawing.Size(354, 20)
        Me.txtNamaInstansi.TabIndex = 7
        '
        'txtNamaKoperasi
        '
        Me.txtNamaKoperasi.Location = New System.Drawing.Point(125, 25)
        Me.txtNamaKoperasi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNamaKoperasi.Name = "txtNamaKoperasi"
        Me.txtNamaKoperasi.Size = New System.Drawing.Size(354, 20)
        Me.txtNamaKoperasi.TabIndex = 6
        '
        'lbl_NoTelp
        '
        Me.lbl_NoTelp.AutoSize = True
        Me.lbl_NoTelp.Location = New System.Drawing.Point(8, 147)
        Me.lbl_NoTelp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NoTelp.Name = "lbl_NoTelp"
        Me.lbl_NoTelp.Size = New System.Drawing.Size(53, 15)
        Me.lbl_NoTelp.TabIndex = 5
        Me.lbl_NoTelp.Text = "No. Telp"
        '
        'lbl_BendaharaKoperasi
        '
        Me.lbl_BendaharaKoperasi.AutoSize = True
        Me.lbl_BendaharaKoperasi.Location = New System.Drawing.Point(8, 123)
        Me.lbl_BendaharaKoperasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_BendaharaKoperasi.Name = "lbl_BendaharaKoperasi"
        Me.lbl_BendaharaKoperasi.Size = New System.Drawing.Size(120, 15)
        Me.lbl_BendaharaKoperasi.TabIndex = 4
        Me.lbl_BendaharaKoperasi.Text = "Bendahara Koperasi"
        '
        'lbl_PimpinanKoperasi
        '
        Me.lbl_PimpinanKoperasi.AutoSize = True
        Me.lbl_PimpinanKoperasi.Location = New System.Drawing.Point(8, 98)
        Me.lbl_PimpinanKoperasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_PimpinanKoperasi.Name = "lbl_PimpinanKoperasi"
        Me.lbl_PimpinanKoperasi.Size = New System.Drawing.Size(112, 15)
        Me.lbl_PimpinanKoperasi.TabIndex = 3
        Me.lbl_PimpinanKoperasi.Text = "Pimpinan Koperasi"
        '
        'lbl_Alamat
        '
        Me.lbl_Alamat.AutoSize = True
        Me.lbl_Alamat.Location = New System.Drawing.Point(8, 74)
        Me.lbl_Alamat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Alamat.Name = "lbl_Alamat"
        Me.lbl_Alamat.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Alamat.TabIndex = 2
        Me.lbl_Alamat.Text = "Alamat"
        '
        'lbl_NamaInstansi
        '
        Me.lbl_NamaInstansi.AutoSize = True
        Me.lbl_NamaInstansi.Location = New System.Drawing.Point(8, 50)
        Me.lbl_NamaInstansi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NamaInstansi.Name = "lbl_NamaInstansi"
        Me.lbl_NamaInstansi.Size = New System.Drawing.Size(86, 15)
        Me.lbl_NamaInstansi.TabIndex = 1
        Me.lbl_NamaInstansi.Text = "Nama Instansi"
        '
        'lbl_NamaKoperasi
        '
        Me.lbl_NamaKoperasi.AutoSize = True
        Me.lbl_NamaKoperasi.Location = New System.Drawing.Point(8, 25)
        Me.lbl_NamaKoperasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_NamaKoperasi.Name = "lbl_NamaKoperasi"
        Me.lbl_NamaKoperasi.Size = New System.Drawing.Size(93, 15)
        Me.lbl_NamaKoperasi.TabIndex = 0
        Me.lbl_NamaKoperasi.Text = "Nama Koperasi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.imgKoperasi)
        Me.GroupBox2.Location = New System.Drawing.Point(502, 114)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(122, 126)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'imgKoperasi
        '
        Me.imgKoperasi.Location = New System.Drawing.Point(4, 14)
        Me.imgKoperasi.Margin = New System.Windows.Forms.Padding(2)
        Me.imgKoperasi.Name = "imgKoperasi"
        Me.imgKoperasi.Size = New System.Drawing.Size(113, 107)
        Me.imgKoperasi.TabIndex = 0
        Me.imgKoperasi.TabStop = False
        '
        'btnCariLogi
        '
        Me.btnCariLogi.Location = New System.Drawing.Point(502, 245)
        Me.btnCariLogi.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCariLogi.Name = "btnCariLogi"
        Me.btnCariLogi.Size = New System.Drawing.Size(88, 30)
        Me.btnCariLogi.TabIndex = 3
        Me.btnCariLogi.Text = "Cari Logo"
        Me.btnCariLogi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnKeluar)
        Me.GroupBox3.Controls.Add(Me.btnUbah)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 390)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(638, 50)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(568, 17)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(56, 25)
        Me.btnKeluar.TabIndex = 1
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(10, 15)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(56, 25)
        Me.btnUbah.TabIndex = 0
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'tbToleransiTagihan
        '
        Me.tbToleransiTagihan.Location = New System.Drawing.Point(125, 297)
        Me.tbToleransiTagihan.Margin = New System.Windows.Forms.Padding(2)
        Me.tbToleransiTagihan.Name = "tbToleransiTagihan"
        Me.tbToleransiTagihan.Size = New System.Drawing.Size(157, 20)
        Me.tbToleransiTagihan.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 297)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Toleransi Tagihan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 300)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Hari"
        '
        'DataIdentitasKoperasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 440)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCariLogi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_InformasiKoperasi)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataIdentitasKoperasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_InformasiKoperasi.ResumeLayout(False)
        Me.group_InformasiKoperasi.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.imgKoperasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_InformasiKoperasi As GroupBox
    Friend WithEvents txtPimpinan As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNamaInstansi As TextBox
    Friend WithEvents txtNamaKoperasi As TextBox
    Friend WithEvents lbl_NoTelp As Label
    Friend WithEvents lbl_BendaharaKoperasi As Label
    Friend WithEvents lbl_PimpinanKoperasi As Label
    Friend WithEvents lbl_Alamat As Label
    Friend WithEvents lbl_NamaInstansi As Label
    Friend WithEvents lbl_NamaKoperasi As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtBendahara As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents imgKoperasi As PictureBox
    Friend WithEvents btnCariLogi As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents tbAlamatOrang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNoKtP As TextBox
    Friend WithEvents tbPekerjaan As TextBox
    Friend WithEvents tbUmur As TextBox
    Friend WithEvents tbNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbToleransiTagihan As TextBox
    Friend WithEvents Label6 As Label
End Class
