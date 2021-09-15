<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.tabMaster = New System.Windows.Forms.RibbonTab()
        Me.panelKeanggotaan = New System.Windows.Forms.RibbonPanel()
        Me.btnAnggota = New System.Windows.Forms.RibbonButton()
        Me.btnTahunAktif = New System.Windows.Forms.RibbonButton()
        Me.panelSimpanan = New System.Windows.Forms.RibbonPanel()
        Me.btnJenisSimpanan = New System.Windows.Forms.RibbonButton()
        Me.btnBukuSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.tabSimpanan = New System.Windows.Forms.RibbonTab()
        Me.panelSimpPokokWjb = New System.Windows.Forms.RibbonPanel()
        Me.btnPemSimWjb = New System.Windows.Forms.RibbonButton()
        Me.btnPemSimWjbKolektif = New System.Windows.Forms.RibbonButton()
        Me.btnPengSimpPokok = New System.Windows.Forms.RibbonButton()
        Me.btnBillingSimpanan = New System.Windows.Forms.RibbonButton()
        Me.btnLihatBilling = New System.Windows.Forms.RibbonButton()
        Me.panelSimpSukarela = New System.Windows.Forms.RibbonPanel()
        Me.btnRekSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.btnPemSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.btnPengSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.btnCetakSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.btnCetakBuku = New System.Windows.Forms.RibbonButton()
        Me.btnCetakSampul = New System.Windows.Forms.RibbonButton()
        Me.btnHitungBunga = New System.Windows.Forms.RibbonButton()
        Me.tabPinjaman = New System.Windows.Forms.RibbonTab()
        Me.panelPeminjaman = New System.Windows.Forms.RibbonPanel()
        Me.btnPeminjaman = New System.Windows.Forms.RibbonButton()
        Me.btnBuatTagihan = New System.Windows.Forms.RibbonButton()
        Me.btnLihatTagihan = New System.Windows.Forms.RibbonButton()
        Me.btnKorPinjaman = New System.Windows.Forms.RibbonButton()
        Me.panelPemPinjaman = New System.Windows.Forms.RibbonPanel()
        Me.btnPemPinjaman = New System.Windows.Forms.RibbonButton()
        Me.btnPembKolektif = New System.Windows.Forms.RibbonButton()
        Me.btnKorPembayaran = New System.Windows.Forms.RibbonButton()
        Me.tabLaporan = New System.Windows.Forms.RibbonTab()
        Me.panelLapKeanggotaan = New System.Windows.Forms.RibbonPanel()
        Me.btnLapAnggota = New System.Windows.Forms.RibbonButton()
        Me.panelLapPembayaran = New System.Windows.Forms.RibbonPanel()
        Me.btnHistoriPembayaran = New System.Windows.Forms.RibbonButton()
        Me.btnLapPeminjaman = New System.Windows.Forms.RibbonButton()
        Me.btnLapByrPinjaman = New System.Windows.Forms.RibbonButton()
        Me.btnLapSaldo = New System.Windows.Forms.RibbonButton()
        Me.btnRekapSaldoPiutang = New System.Windows.Forms.RibbonButton()
        Me.btnRekapPendatan = New System.Windows.Forms.RibbonButton()
        Me.btnByrAdmin = New System.Windows.Forms.RibbonButton()
        Me.btnPembAsuransi = New System.Windows.Forms.RibbonButton()
        Me.panelLain2 = New System.Windows.Forms.RibbonPanel()
        Me.btnLapSimpPokokWjb = New System.Windows.Forms.RibbonButton()
        Me.btnLapTraSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.btnLapTunggakanSimpan = New System.Windows.Forms.RibbonButton()
        Me.btnLapPemBunga = New System.Windows.Forms.RibbonButton()
        Me.btnRekapSimpPokokWjb = New System.Windows.Forms.RibbonButton()
        Me.btnSimpSukarela = New System.Windows.Forms.RibbonButton()
        Me.panelSHU = New System.Windows.Forms.RibbonPanel()
        Me.btnProsesSHU = New System.Windows.Forms.RibbonButton()
        Me.tabUtilitas = New System.Windows.Forms.RibbonTab()
        Me.panelSetting = New System.Windows.Forms.RibbonPanel()
        Me.btnIdentitas = New System.Windows.Forms.RibbonButton()
        Me.btnGroup = New System.Windows.Forms.RibbonButton()
        Me.btnUser = New System.Windows.Forms.RibbonButton()
        Me.panelDB = New System.Windows.Forms.RibbonPanel()
        Me.btnBackupDB = New System.Windows.Forms.RibbonButton()
        Me.btnRestoreDB = New System.Windows.Forms.RibbonButton()
        Me.btnResetData = New System.Windows.Forms.RibbonButton()
        Me.tabKeluar = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.Keluar = New System.Windows.Forms.RibbonButton()
        Me.TabControl1 = New JacksiroKe.MdiTabCtrl.TabControl()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Margin = New System.Windows.Forms.Padding(2)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbVisible = False
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(648, 158)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.tabMaster)
        Me.Ribbon1.Tabs.Add(Me.tabSimpanan)
        Me.Ribbon1.Tabs.Add(Me.tabPinjaman)
        Me.Ribbon1.Tabs.Add(Me.tabLaporan)
        Me.Ribbon1.Tabs.Add(Me.tabUtilitas)
        Me.Ribbon1.Tabs.Add(Me.tabKeluar)
        Me.Ribbon1.TabSpacing = 4
        Me.Ribbon1.TabStop = False
        Me.Ribbon1.Text = "Ribbon1"
        '
        'tabMaster
        '
        Me.tabMaster.Name = "tabMaster"
        Me.tabMaster.Panels.Add(Me.panelKeanggotaan)
        Me.tabMaster.Panels.Add(Me.panelSimpanan)
        Me.tabMaster.Text = "Master"
        '
        'panelKeanggotaan
        '
        Me.panelKeanggotaan.Items.Add(Me.btnAnggota)
        Me.panelKeanggotaan.Items.Add(Me.btnTahunAktif)
        Me.panelKeanggotaan.Name = "panelKeanggotaan"
        Me.panelKeanggotaan.Text = "Keanggotaan"
        '
        'btnAnggota
        '
        Me.btnAnggota.Image = CType(resources.GetObject("btnAnggota.Image"), System.Drawing.Image)
        Me.btnAnggota.LargeImage = CType(resources.GetObject("btnAnggota.LargeImage"), System.Drawing.Image)
        Me.btnAnggota.Name = "btnAnggota"
        Me.btnAnggota.SmallImage = CType(resources.GetObject("btnAnggota.SmallImage"), System.Drawing.Image)
        Me.btnAnggota.Text = "Anggota"
        '
        'btnTahunAktif
        '
        Me.btnTahunAktif.Image = CType(resources.GetObject("btnTahunAktif.Image"), System.Drawing.Image)
        Me.btnTahunAktif.LargeImage = CType(resources.GetObject("btnTahunAktif.LargeImage"), System.Drawing.Image)
        Me.btnTahunAktif.Name = "btnTahunAktif"
        Me.btnTahunAktif.SmallImage = CType(resources.GetObject("btnTahunAktif.SmallImage"), System.Drawing.Image)
        Me.btnTahunAktif.Text = "Tahun Aktif"
        '
        'panelSimpanan
        '
        Me.panelSimpanan.Items.Add(Me.btnJenisSimpanan)
        Me.panelSimpanan.Items.Add(Me.btnBukuSimpSukarela)
        Me.panelSimpanan.Name = "panelSimpanan"
        Me.panelSimpanan.Text = "Simpanan"
        '
        'btnJenisSimpanan
        '
        Me.btnJenisSimpanan.Image = CType(resources.GetObject("btnJenisSimpanan.Image"), System.Drawing.Image)
        Me.btnJenisSimpanan.LargeImage = CType(resources.GetObject("btnJenisSimpanan.LargeImage"), System.Drawing.Image)
        Me.btnJenisSimpanan.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnJenisSimpanan.Name = "btnJenisSimpanan"
        Me.btnJenisSimpanan.SmallImage = CType(resources.GetObject("btnJenisSimpanan.SmallImage"), System.Drawing.Image)
        Me.btnJenisSimpanan.Text = "Jenis Simpanan"
        '
        'btnBukuSimpSukarela
        '
        Me.btnBukuSimpSukarela.Image = CType(resources.GetObject("btnBukuSimpSukarela.Image"), System.Drawing.Image)
        Me.btnBukuSimpSukarela.LargeImage = CType(resources.GetObject("btnBukuSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnBukuSimpSukarela.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnBukuSimpSukarela.MinimumSize = New System.Drawing.Size(70, 0)
        Me.btnBukuSimpSukarela.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnBukuSimpSukarela.Name = "btnBukuSimpSukarela"
        Me.btnBukuSimpSukarela.SmallImage = CType(resources.GetObject("btnBukuSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnBukuSimpSukarela.Text = "Buku Simp Sukarela"
        '
        'tabSimpanan
        '
        Me.tabSimpanan.Name = "tabSimpanan"
        Me.tabSimpanan.Panels.Add(Me.panelSimpPokokWjb)
        Me.tabSimpanan.Panels.Add(Me.panelSimpSukarela)
        Me.tabSimpanan.Text = "Simpanan"
        '
        'panelSimpPokokWjb
        '
        Me.panelSimpPokokWjb.Items.Add(Me.btnBillingSimpanan)
        Me.panelSimpPokokWjb.Items.Add(Me.btnLihatBilling)
        Me.panelSimpPokokWjb.Items.Add(Me.btnPemSimWjb)
        Me.panelSimpPokokWjb.Items.Add(Me.btnPemSimWjbKolektif)
        Me.panelSimpPokokWjb.Items.Add(Me.btnPengSimpPokok)
        Me.panelSimpPokokWjb.Name = "panelSimpPokokWjb"
        Me.panelSimpPokokWjb.Text = "Simpanan Pokok dan Wajib"
        '
        'btnPemSimWjb
        '
        Me.btnPemSimWjb.Image = CType(resources.GetObject("btnPemSimWjb.Image"), System.Drawing.Image)
        Me.btnPemSimWjb.LargeImage = CType(resources.GetObject("btnPemSimWjb.LargeImage"), System.Drawing.Image)
        Me.btnPemSimWjb.Name = "btnPemSimWjb"
        Me.btnPemSimWjb.SmallImage = CType(resources.GetObject("btnPemSimWjb.SmallImage"), System.Drawing.Image)
        Me.btnPemSimWjb.Text = "Pembayaran"
        '
        'btnPemSimWjbKolektif
        '
        Me.btnPemSimWjbKolektif.Image = CType(resources.GetObject("btnPemSimWjbKolektif.Image"), System.Drawing.Image)
        Me.btnPemSimWjbKolektif.LargeImage = CType(resources.GetObject("btnPemSimWjbKolektif.LargeImage"), System.Drawing.Image)
        Me.btnPemSimWjbKolektif.Name = "btnPemSimWjbKolektif"
        Me.btnPemSimWjbKolektif.SmallImage = CType(resources.GetObject("btnPemSimWjbKolektif.SmallImage"), System.Drawing.Image)
        Me.btnPemSimWjbKolektif.Text = "Pembayaran Kolektif"
        '
        'btnPengSimpPokok
        '
        Me.btnPengSimpPokok.Image = CType(resources.GetObject("btnPengSimpPokok.Image"), System.Drawing.Image)
        Me.btnPengSimpPokok.LargeImage = CType(resources.GetObject("btnPengSimpPokok.LargeImage"), System.Drawing.Image)
        Me.btnPengSimpPokok.Name = "btnPengSimpPokok"
        Me.btnPengSimpPokok.SmallImage = CType(resources.GetObject("btnPengSimpPokok.SmallImage"), System.Drawing.Image)
        Me.btnPengSimpPokok.Text = "Pengambilan"
        '
        'btnBillingSimpanan
        '
        Me.btnBillingSimpanan.Image = CType(resources.GetObject("btnBillingSimpanan.Image"), System.Drawing.Image)
        Me.btnBillingSimpanan.LargeImage = CType(resources.GetObject("btnBillingSimpanan.LargeImage"), System.Drawing.Image)
        Me.btnBillingSimpanan.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnBillingSimpanan.Name = "btnBillingSimpanan"
        Me.btnBillingSimpanan.SmallImage = CType(resources.GetObject("btnBillingSimpanan.SmallImage"), System.Drawing.Image)
        Me.btnBillingSimpanan.Text = "Buat Tagihan Simpanan"
        '
        'btnLihatBilling
        '
        Me.btnLihatBilling.Image = CType(resources.GetObject("btnLihatBilling.Image"), System.Drawing.Image)
        Me.btnLihatBilling.LargeImage = CType(resources.GetObject("btnLihatBilling.LargeImage"), System.Drawing.Image)
        Me.btnLihatBilling.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnLihatBilling.Name = "btnLihatBilling"
        Me.btnLihatBilling.SmallImage = CType(resources.GetObject("btnLihatBilling.SmallImage"), System.Drawing.Image)
        Me.btnLihatBilling.Text = "Cek Tagihan Simpanan"
        '
        'panelSimpSukarela
        '
        Me.panelSimpSukarela.Items.Add(Me.btnRekSimpSukarela)
        Me.panelSimpSukarela.Items.Add(Me.btnPemSimpSukarela)
        Me.panelSimpSukarela.Items.Add(Me.btnPengSimpSukarela)
        Me.panelSimpSukarela.Items.Add(Me.btnCetakSimpSukarela)
        Me.panelSimpSukarela.Items.Add(Me.btnCetakBuku)
        Me.panelSimpSukarela.Items.Add(Me.btnCetakSampul)
        Me.panelSimpSukarela.Items.Add(Me.btnHitungBunga)
        Me.panelSimpSukarela.Name = "panelSimpSukarela"
        Me.panelSimpSukarela.Text = "Simpanan Sukarela"
        '
        'btnRekSimpSukarela
        '
        Me.btnRekSimpSukarela.Image = CType(resources.GetObject("btnRekSimpSukarela.Image"), System.Drawing.Image)
        Me.btnRekSimpSukarela.LargeImage = CType(resources.GetObject("btnRekSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnRekSimpSukarela.Name = "btnRekSimpSukarela"
        Me.btnRekSimpSukarela.SmallImage = CType(resources.GetObject("btnRekSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnRekSimpSukarela.Text = "Buat Rekening"
        '
        'btnPemSimpSukarela
        '
        Me.btnPemSimpSukarela.Image = CType(resources.GetObject("btnPemSimpSukarela.Image"), System.Drawing.Image)
        Me.btnPemSimpSukarela.LargeImage = CType(resources.GetObject("btnPemSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnPemSimpSukarela.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnPemSimpSukarela.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnPemSimpSukarela.Name = "btnPemSimpSukarela"
        Me.btnPemSimpSukarela.SmallImage = CType(resources.GetObject("btnPemSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnPemSimpSukarela.Text = "Pembayaran Simpanan"
        '
        'btnPengSimpSukarela
        '
        Me.btnPengSimpSukarela.Image = CType(resources.GetObject("btnPengSimpSukarela.Image"), System.Drawing.Image)
        Me.btnPengSimpSukarela.LargeImage = CType(resources.GetObject("btnPengSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnPengSimpSukarela.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnPengSimpSukarela.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnPengSimpSukarela.Name = "btnPengSimpSukarela"
        Me.btnPengSimpSukarela.SmallImage = CType(resources.GetObject("btnPengSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnPengSimpSukarela.Text = "Pengambilan Simpanan"
        '
        'btnCetakSimpSukarela
        '
        Me.btnCetakSimpSukarela.Image = CType(resources.GetObject("btnCetakSimpSukarela.Image"), System.Drawing.Image)
        Me.btnCetakSimpSukarela.LargeImage = CType(resources.GetObject("btnCetakSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnCetakSimpSukarela.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakSimpSukarela.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakSimpSukarela.Name = "btnCetakSimpSukarela"
        Me.btnCetakSimpSukarela.SmallImage = CType(resources.GetObject("btnCetakSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnCetakSimpSukarela.Text = "Cetak Lap. Simpanan"
        '
        'btnCetakBuku
        '
        Me.btnCetakBuku.Image = CType(resources.GetObject("btnCetakBuku.Image"), System.Drawing.Image)
        Me.btnCetakBuku.LargeImage = CType(resources.GetObject("btnCetakBuku.LargeImage"), System.Drawing.Image)
        Me.btnCetakBuku.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakBuku.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakBuku.Name = "btnCetakBuku"
        Me.btnCetakBuku.SmallImage = CType(resources.GetObject("btnCetakBuku.SmallImage"), System.Drawing.Image)
        Me.btnCetakBuku.Text = "Cetak Buku Simpanan"
        '
        'btnCetakSampul
        '
        Me.btnCetakSampul.Image = CType(resources.GetObject("btnCetakSampul.Image"), System.Drawing.Image)
        Me.btnCetakSampul.LargeImage = CType(resources.GetObject("btnCetakSampul.LargeImage"), System.Drawing.Image)
        Me.btnCetakSampul.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakSampul.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnCetakSampul.Name = "btnCetakSampul"
        Me.btnCetakSampul.SmallImage = CType(resources.GetObject("btnCetakSampul.SmallImage"), System.Drawing.Image)
        Me.btnCetakSampul.Text = "Cetak Sampul"
        '
        'btnHitungBunga
        '
        Me.btnHitungBunga.Image = CType(resources.GetObject("btnHitungBunga.Image"), System.Drawing.Image)
        Me.btnHitungBunga.LargeImage = CType(resources.GetObject("btnHitungBunga.LargeImage"), System.Drawing.Image)
        Me.btnHitungBunga.MinimumSize = New System.Drawing.Size(100, 0)
        Me.btnHitungBunga.Name = "btnHitungBunga"
        Me.btnHitungBunga.SmallImage = CType(resources.GetObject("btnHitungBunga.SmallImage"), System.Drawing.Image)
        Me.btnHitungBunga.Text = "Hitung Bunga Simpanan"
        '
        'tabPinjaman
        '
        Me.tabPinjaman.Name = "tabPinjaman"
        Me.tabPinjaman.Panels.Add(Me.panelPeminjaman)
        Me.tabPinjaman.Panels.Add(Me.panelPemPinjaman)
        Me.tabPinjaman.Text = "Pinjaman"
        '
        'panelPeminjaman
        '
        Me.panelPeminjaman.Items.Add(Me.btnPeminjaman)
        Me.panelPeminjaman.Items.Add(Me.btnBuatTagihan)
        Me.panelPeminjaman.Items.Add(Me.btnLihatTagihan)
        Me.panelPeminjaman.Items.Add(Me.btnKorPinjaman)
        Me.panelPeminjaman.Name = "panelPeminjaman"
        Me.panelPeminjaman.Text = "Pinjaman"
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.Image = CType(resources.GetObject("btnPeminjaman.Image"), System.Drawing.Image)
        Me.btnPeminjaman.LargeImage = CType(resources.GetObject("btnPeminjaman.LargeImage"), System.Drawing.Image)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.SmallImage = CType(resources.GetObject("btnPeminjaman.SmallImage"), System.Drawing.Image)
        Me.btnPeminjaman.Text = "Peminjaman Baru"
        '
        'btnBuatTagihan
        '
        Me.btnBuatTagihan.Image = CType(resources.GetObject("btnBuatTagihan.Image"), System.Drawing.Image)
        Me.btnBuatTagihan.LargeImage = CType(resources.GetObject("btnBuatTagihan.LargeImage"), System.Drawing.Image)
        Me.btnBuatTagihan.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnBuatTagihan.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnBuatTagihan.Name = "btnBuatTagihan"
        Me.btnBuatTagihan.SmallImage = CType(resources.GetObject("btnBuatTagihan.SmallImage"), System.Drawing.Image)
        Me.btnBuatTagihan.Text = "Buat Tagihan Pinjaman"
        '
        'btnLihatTagihan
        '
        Me.btnLihatTagihan.Image = CType(resources.GetObject("btnLihatTagihan.Image"), System.Drawing.Image)
        Me.btnLihatTagihan.LargeImage = CType(resources.GetObject("btnLihatTagihan.LargeImage"), System.Drawing.Image)
        Me.btnLihatTagihan.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnLihatTagihan.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnLihatTagihan.Name = "btnLihatTagihan"
        Me.btnLihatTagihan.SmallImage = CType(resources.GetObject("btnLihatTagihan.SmallImage"), System.Drawing.Image)
        Me.btnLihatTagihan.Text = "Cek Tagihan Pinjaman"
        '
        'btnKorPinjaman
        '
        Me.btnKorPinjaman.Image = CType(resources.GetObject("btnKorPinjaman.Image"), System.Drawing.Image)
        Me.btnKorPinjaman.LargeImage = CType(resources.GetObject("btnKorPinjaman.LargeImage"), System.Drawing.Image)
        Me.btnKorPinjaman.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnKorPinjaman.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnKorPinjaman.Name = "btnKorPinjaman"
        Me.btnKorPinjaman.SmallImage = CType(resources.GetObject("btnKorPinjaman.SmallImage"), System.Drawing.Image)
        Me.btnKorPinjaman.Text = "Koreksi Pinjaman"
        '
        'panelPemPinjaman
        '
        Me.panelPemPinjaman.Items.Add(Me.btnPemPinjaman)
        Me.panelPemPinjaman.Items.Add(Me.btnPembKolektif)
        Me.panelPemPinjaman.Items.Add(Me.btnKorPembayaran)
        Me.panelPemPinjaman.Name = "panelPemPinjaman"
        Me.panelPemPinjaman.Text = "Pembayaran Pinjaman"
        '
        'btnPemPinjaman
        '
        Me.btnPemPinjaman.Image = CType(resources.GetObject("btnPemPinjaman.Image"), System.Drawing.Image)
        Me.btnPemPinjaman.LargeImage = CType(resources.GetObject("btnPemPinjaman.LargeImage"), System.Drawing.Image)
        Me.btnPemPinjaman.Name = "btnPemPinjaman"
        Me.btnPemPinjaman.SmallImage = CType(resources.GetObject("btnPemPinjaman.SmallImage"), System.Drawing.Image)
        Me.btnPemPinjaman.Text = "Pembayaran Per Orang"
        '
        'btnPembKolektif
        '
        Me.btnPembKolektif.Image = CType(resources.GetObject("btnPembKolektif.Image"), System.Drawing.Image)
        Me.btnPembKolektif.LargeImage = CType(resources.GetObject("btnPembKolektif.LargeImage"), System.Drawing.Image)
        Me.btnPembKolektif.Name = "btnPembKolektif"
        Me.btnPembKolektif.SmallImage = CType(resources.GetObject("btnPembKolektif.SmallImage"), System.Drawing.Image)
        Me.btnPembKolektif.Text = "Pembayaran Kolektif"
        '
        'btnKorPembayaran
        '
        Me.btnKorPembayaran.Image = CType(resources.GetObject("btnKorPembayaran.Image"), System.Drawing.Image)
        Me.btnKorPembayaran.LargeImage = CType(resources.GetObject("btnKorPembayaran.LargeImage"), System.Drawing.Image)
        Me.btnKorPembayaran.Name = "btnKorPembayaran"
        Me.btnKorPembayaran.SmallImage = CType(resources.GetObject("btnKorPembayaran.SmallImage"), System.Drawing.Image)
        Me.btnKorPembayaran.Text = "Koreksi Pembayaran"
        '
        'tabLaporan
        '
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Panels.Add(Me.panelLapKeanggotaan)
        Me.tabLaporan.Panels.Add(Me.panelLapPembayaran)
        Me.tabLaporan.Panels.Add(Me.panelLain2)
        Me.tabLaporan.Panels.Add(Me.panelSHU)
        Me.tabLaporan.Text = "Laporan"
        '
        'panelLapKeanggotaan
        '
        Me.panelLapKeanggotaan.Items.Add(Me.btnLapAnggota)
        Me.panelLapKeanggotaan.Name = "panelLapKeanggotaan"
        Me.panelLapKeanggotaan.Text = "Lap. Anggota"
        '
        'btnLapAnggota
        '
        Me.btnLapAnggota.Image = CType(resources.GetObject("btnLapAnggota.Image"), System.Drawing.Image)
        Me.btnLapAnggota.LargeImage = CType(resources.GetObject("btnLapAnggota.LargeImage"), System.Drawing.Image)
        Me.btnLapAnggota.Name = "btnLapAnggota"
        Me.btnLapAnggota.SmallImage = CType(resources.GetObject("btnLapAnggota.SmallImage"), System.Drawing.Image)
        Me.btnLapAnggota.Text = "Anggota"
        '
        'panelLapPembayaran
        '
        Me.panelLapPembayaran.Items.Add(Me.btnLapPeminjaman)
        Me.panelLapPembayaran.Items.Add(Me.btnLapByrPinjaman)
        Me.panelLapPembayaran.Items.Add(Me.btnHistoriPembayaran)
        Me.panelLapPembayaran.Items.Add(Me.btnLapSaldo)
        Me.panelLapPembayaran.Items.Add(Me.btnRekapSaldoPiutang)
        Me.panelLapPembayaran.Items.Add(Me.btnRekapPendatan)
        Me.panelLapPembayaran.Items.Add(Me.btnByrAdmin)
        Me.panelLapPembayaran.Items.Add(Me.btnPembAsuransi)
        Me.panelLapPembayaran.Name = "panelLapPembayaran"
        Me.panelLapPembayaran.Text = "Lap. Pinjaman"
        '
        'btnHistoriPembayaran
        '
        Me.btnHistoriPembayaran.Image = CType(resources.GetObject("btnHistoriPembayaran.Image"), System.Drawing.Image)
        Me.btnHistoriPembayaran.LargeImage = CType(resources.GetObject("btnHistoriPembayaran.LargeImage"), System.Drawing.Image)
        Me.btnHistoriPembayaran.Name = "btnHistoriPembayaran"
        Me.btnHistoriPembayaran.SmallImage = CType(resources.GetObject("btnHistoriPembayaran.SmallImage"), System.Drawing.Image)
        Me.btnHistoriPembayaran.Text = "Histori Pembayaran Pinjaman"
        '
        'btnLapPeminjaman
        '
        Me.btnLapPeminjaman.Image = CType(resources.GetObject("btnLapPeminjaman.Image"), System.Drawing.Image)
        Me.btnLapPeminjaman.LargeImage = CType(resources.GetObject("btnLapPeminjaman.LargeImage"), System.Drawing.Image)
        Me.btnLapPeminjaman.Name = "btnLapPeminjaman"
        Me.btnLapPeminjaman.SmallImage = CType(resources.GetObject("btnLapPeminjaman.SmallImage"), System.Drawing.Image)
        Me.btnLapPeminjaman.Text = "Peminjaman"
        '
        'btnLapByrPinjaman
        '
        Me.btnLapByrPinjaman.Image = Global.Koperasi.My.Resources.Resources.analytics
        Me.btnLapByrPinjaman.LargeImage = Global.Koperasi.My.Resources.Resources.analytics
        Me.btnLapByrPinjaman.Name = "btnLapByrPinjaman"
        Me.btnLapByrPinjaman.SmallImage = CType(resources.GetObject("btnLapByrPinjaman.SmallImage"), System.Drawing.Image)
        Me.btnLapByrPinjaman.Text = "Pembayaran Pinjaman"
        '
        'btnLapSaldo
        '
        Me.btnLapSaldo.Image = Global.Koperasi.My.Resources.Resources.analytics
        Me.btnLapSaldo.LargeImage = Global.Koperasi.My.Resources.Resources.analytics
        Me.btnLapSaldo.Name = "btnLapSaldo"
        Me.btnLapSaldo.SmallImage = CType(resources.GetObject("btnLapSaldo.SmallImage"), System.Drawing.Image)
        Me.btnLapSaldo.Text = "Saldo Piutang"
        '
        'btnRekapSaldoPiutang
        '
        Me.btnRekapSaldoPiutang.Image = CType(resources.GetObject("btnRekapSaldoPiutang.Image"), System.Drawing.Image)
        Me.btnRekapSaldoPiutang.LargeImage = CType(resources.GetObject("btnRekapSaldoPiutang.LargeImage"), System.Drawing.Image)
        Me.btnRekapSaldoPiutang.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnRekapSaldoPiutang.Name = "btnRekapSaldoPiutang"
        Me.btnRekapSaldoPiutang.SmallImage = CType(resources.GetObject("btnRekapSaldoPiutang.SmallImage"), System.Drawing.Image)
        Me.btnRekapSaldoPiutang.Text = "Rekap Saldo Piutang"
        '
        'btnRekapPendatan
        '
        Me.btnRekapPendatan.Image = CType(resources.GetObject("btnRekapPendatan.Image"), System.Drawing.Image)
        Me.btnRekapPendatan.LargeImage = CType(resources.GetObject("btnRekapPendatan.LargeImage"), System.Drawing.Image)
        Me.btnRekapPendatan.Name = "btnRekapPendatan"
        Me.btnRekapPendatan.SmallImage = CType(resources.GetObject("btnRekapPendatan.SmallImage"), System.Drawing.Image)
        Me.btnRekapPendatan.Text = "Rekap Pendapatan Bunga"
        '
        'btnByrAdmin
        '
        Me.btnByrAdmin.Image = CType(resources.GetObject("btnByrAdmin.Image"), System.Drawing.Image)
        Me.btnByrAdmin.LargeImage = CType(resources.GetObject("btnByrAdmin.LargeImage"), System.Drawing.Image)
        Me.btnByrAdmin.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnByrAdmin.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnByrAdmin.Name = "btnByrAdmin"
        Me.btnByrAdmin.SmallImage = CType(resources.GetObject("btnByrAdmin.SmallImage"), System.Drawing.Image)
        Me.btnByrAdmin.Text = "Administrasi"
        '
        'btnPembAsuransi
        '
        Me.btnPembAsuransi.Image = CType(resources.GetObject("btnPembAsuransi.Image"), System.Drawing.Image)
        Me.btnPembAsuransi.LargeImage = CType(resources.GetObject("btnPembAsuransi.LargeImage"), System.Drawing.Image)
        Me.btnPembAsuransi.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnPembAsuransi.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium
        Me.btnPembAsuransi.Name = "btnPembAsuransi"
        Me.btnPembAsuransi.SmallImage = CType(resources.GetObject("btnPembAsuransi.SmallImage"), System.Drawing.Image)
        Me.btnPembAsuransi.Text = "Asuransi"
        '
        'panelLain2
        '
        Me.panelLain2.Items.Add(Me.btnLapSimpPokokWjb)
        Me.panelLain2.Items.Add(Me.btnLapTraSimpSukarela)
        Me.panelLain2.Items.Add(Me.btnLapTunggakanSimpan)
        Me.panelLain2.Items.Add(Me.btnLapPemBunga)
        Me.panelLain2.Items.Add(Me.btnRekapSimpPokokWjb)
        Me.panelLain2.Items.Add(Me.btnSimpSukarela)
        Me.panelLain2.Name = "panelLain2"
        Me.panelLain2.Text = "Lap. Simpanan"
        '
        'btnLapSimpPokokWjb
        '
        Me.btnLapSimpPokokWjb.Image = CType(resources.GetObject("btnLapSimpPokokWjb.Image"), System.Drawing.Image)
        Me.btnLapSimpPokokWjb.LargeImage = CType(resources.GetObject("btnLapSimpPokokWjb.LargeImage"), System.Drawing.Image)
        Me.btnLapSimpPokokWjb.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnLapSimpPokokWjb.Name = "btnLapSimpPokokWjb"
        Me.btnLapSimpPokokWjb.SmallImage = CType(resources.GetObject("btnLapSimpPokokWjb.SmallImage"), System.Drawing.Image)
        Me.btnLapSimpPokokWjb.Text = "Simpanan Pokok Wajib"
        '
        'btnLapTraSimpSukarela
        '
        Me.btnLapTraSimpSukarela.Image = CType(resources.GetObject("btnLapTraSimpSukarela.Image"), System.Drawing.Image)
        Me.btnLapTraSimpSukarela.LargeImage = CType(resources.GetObject("btnLapTraSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnLapTraSimpSukarela.MinimumSize = New System.Drawing.Size(90, 0)
        Me.btnLapTraSimpSukarela.Name = "btnLapTraSimpSukarela"
        Me.btnLapTraSimpSukarela.SmallImage = CType(resources.GetObject("btnLapTraSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnLapTraSimpSukarela.Text = "Transaksi Simp Sukarela"
        '
        'btnLapTunggakanSimpan
        '
        Me.btnLapTunggakanSimpan.Image = CType(resources.GetObject("btnLapTunggakanSimpan.Image"), System.Drawing.Image)
        Me.btnLapTunggakanSimpan.LargeImage = CType(resources.GetObject("btnLapTunggakanSimpan.LargeImage"), System.Drawing.Image)
        Me.btnLapTunggakanSimpan.Name = "btnLapTunggakanSimpan"
        Me.btnLapTunggakanSimpan.SmallImage = CType(resources.GetObject("btnLapTunggakanSimpan.SmallImage"), System.Drawing.Image)
        Me.btnLapTunggakanSimpan.Text = "Tunggakan Simpanan"
        '
        'btnLapPemBunga
        '
        Me.btnLapPemBunga.Image = CType(resources.GetObject("btnLapPemBunga.Image"), System.Drawing.Image)
        Me.btnLapPemBunga.LargeImage = CType(resources.GetObject("btnLapPemBunga.LargeImage"), System.Drawing.Image)
        Me.btnLapPemBunga.Name = "btnLapPemBunga"
        Me.btnLapPemBunga.SmallImage = CType(resources.GetObject("btnLapPemBunga.SmallImage"), System.Drawing.Image)
        Me.btnLapPemBunga.Text = "Pembayaran Bunga"
        '
        'btnRekapSimpPokokWjb
        '
        Me.btnRekapSimpPokokWjb.Image = CType(resources.GetObject("btnRekapSimpPokokWjb.Image"), System.Drawing.Image)
        Me.btnRekapSimpPokokWjb.LargeImage = CType(resources.GetObject("btnRekapSimpPokokWjb.LargeImage"), System.Drawing.Image)
        Me.btnRekapSimpPokokWjb.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnRekapSimpPokokWjb.Name = "btnRekapSimpPokokWjb"
        Me.btnRekapSimpPokokWjb.SmallImage = CType(resources.GetObject("btnRekapSimpPokokWjb.SmallImage"), System.Drawing.Image)
        Me.btnRekapSimpPokokWjb.Text = "Rekap Pokok dan Wajib"
        '
        'btnSimpSukarela
        '
        Me.btnSimpSukarela.Image = CType(resources.GetObject("btnSimpSukarela.Image"), System.Drawing.Image)
        Me.btnSimpSukarela.LargeImage = CType(resources.GetObject("btnSimpSukarela.LargeImage"), System.Drawing.Image)
        Me.btnSimpSukarela.Name = "btnSimpSukarela"
        Me.btnSimpSukarela.SmallImage = CType(resources.GetObject("btnSimpSukarela.SmallImage"), System.Drawing.Image)
        Me.btnSimpSukarela.Text = "Rekap Sukarela"
        '
        'panelSHU
        '
        Me.panelSHU.Items.Add(Me.btnProsesSHU)
        Me.panelSHU.Name = "panelSHU"
        Me.panelSHU.Text = "Lap. SHU"
        '
        'btnProsesSHU
        '
        Me.btnProsesSHU.Image = CType(resources.GetObject("btnProsesSHU.Image"), System.Drawing.Image)
        Me.btnProsesSHU.LargeImage = CType(resources.GetObject("btnProsesSHU.LargeImage"), System.Drawing.Image)
        Me.btnProsesSHU.Name = "btnProsesSHU"
        Me.btnProsesSHU.SmallImage = CType(resources.GetObject("btnProsesSHU.SmallImage"), System.Drawing.Image)
        Me.btnProsesSHU.Text = "Proses SHU"
        '
        'tabUtilitas
        '
        Me.tabUtilitas.Name = "tabUtilitas"
        Me.tabUtilitas.Panels.Add(Me.panelSetting)
        Me.tabUtilitas.Panels.Add(Me.panelDB)
        Me.tabUtilitas.Text = "Utilitas"
        '
        'panelSetting
        '
        Me.panelSetting.Items.Add(Me.btnIdentitas)
        Me.panelSetting.Items.Add(Me.btnGroup)
        Me.panelSetting.Items.Add(Me.btnUser)
        Me.panelSetting.Name = "panelSetting"
        Me.panelSetting.Text = "Setting"
        '
        'btnIdentitas
        '
        Me.btnIdentitas.Image = CType(resources.GetObject("btnIdentitas.Image"), System.Drawing.Image)
        Me.btnIdentitas.LargeImage = CType(resources.GetObject("btnIdentitas.LargeImage"), System.Drawing.Image)
        Me.btnIdentitas.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnIdentitas.Name = "btnIdentitas"
        Me.btnIdentitas.SmallImage = CType(resources.GetObject("btnIdentitas.SmallImage"), System.Drawing.Image)
        Me.btnIdentitas.Text = "Identitas"
        Me.btnIdentitas.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'btnGroup
        '
        Me.btnGroup.Image = CType(resources.GetObject("btnGroup.Image"), System.Drawing.Image)
        Me.btnGroup.LargeImage = CType(resources.GetObject("btnGroup.LargeImage"), System.Drawing.Image)
        Me.btnGroup.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnGroup.Name = "btnGroup"
        Me.btnGroup.SmallImage = CType(resources.GetObject("btnGroup.SmallImage"), System.Drawing.Image)
        Me.btnGroup.Text = "Group"
        Me.btnGroup.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'btnUser
        '
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.LargeImage = CType(resources.GetObject("btnUser.LargeImage"), System.Drawing.Image)
        Me.btnUser.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.btnUser.Name = "btnUser"
        Me.btnUser.SmallImage = CType(resources.GetObject("btnUser.SmallImage"), System.Drawing.Image)
        Me.btnUser.Text = "User"
        Me.btnUser.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'panelDB
        '
        Me.panelDB.Items.Add(Me.btnBackupDB)
        Me.panelDB.Items.Add(Me.btnRestoreDB)
        Me.panelDB.Items.Add(Me.btnResetData)
        Me.panelDB.Name = "panelDB"
        Me.panelDB.Text = "Database"
        '
        'btnBackupDB
        '
        Me.btnBackupDB.Image = CType(resources.GetObject("btnBackupDB.Image"), System.Drawing.Image)
        Me.btnBackupDB.LargeImage = CType(resources.GetObject("btnBackupDB.LargeImage"), System.Drawing.Image)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.SmallImage = CType(resources.GetObject("btnBackupDB.SmallImage"), System.Drawing.Image)
        Me.btnBackupDB.Text = "Backup"
        Me.btnBackupDB.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'btnRestoreDB
        '
        Me.btnRestoreDB.Image = CType(resources.GetObject("btnRestoreDB.Image"), System.Drawing.Image)
        Me.btnRestoreDB.LargeImage = CType(resources.GetObject("btnRestoreDB.LargeImage"), System.Drawing.Image)
        Me.btnRestoreDB.Name = "btnRestoreDB"
        Me.btnRestoreDB.SmallImage = CType(resources.GetObject("btnRestoreDB.SmallImage"), System.Drawing.Image)
        Me.btnRestoreDB.Text = "Restore"
        Me.btnRestoreDB.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center
        '
        'btnResetData
        '
        Me.btnResetData.Image = CType(resources.GetObject("btnResetData.Image"), System.Drawing.Image)
        Me.btnResetData.LargeImage = CType(resources.GetObject("btnResetData.LargeImage"), System.Drawing.Image)
        Me.btnResetData.Name = "btnResetData"
        Me.btnResetData.SmallImage = CType(resources.GetObject("btnResetData.SmallImage"), System.Drawing.Image)
        Me.btnResetData.Text = "Reset Data"
        '
        'tabKeluar
        '
        Me.tabKeluar.Name = "tabKeluar"
        Me.tabKeluar.Panels.Add(Me.RibbonPanel2)
        Me.tabKeluar.Text = "Keluar Aplikasi"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.Keluar)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = ""
        '
        'Keluar
        '
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.LargeImage = CType(resources.GetObject("Keluar.LargeImage"), System.Drawing.Image)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.SmallImage = CType(resources.GetObject("Keluar.SmallImage"), System.Drawing.Image)
        Me.Keluar.Text = "Kembali Ke Menu Login"
        '
        'TabControl1
        '
        Me.TabControl1.BackHighColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.BackLowColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.DropButtonVisible = False
        Me.TabControl1.Location = New System.Drawing.Point(0, 158)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(648, 331)
        Me.TabControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        Me.TabControl1.TabBackHighColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TabControl1.TabBackHighColorDisabled = System.Drawing.SystemColors.Window
        Me.TabControl1.TabBackLowColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TabControl1.TabBackLowColorDisabled = System.Drawing.SystemColors.Window
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 1
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Ribbon1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuUtama"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents tabUtilitas As RibbonTab
    Friend WithEvents panelSetting As RibbonPanel
    Friend WithEvents btnIdentitas As RibbonButton
    Friend WithEvents btnGroup As RibbonButton
    Friend WithEvents btnUser As RibbonButton
    Friend WithEvents tabMaster As RibbonTab
    Friend WithEvents panelKeanggotaan As RibbonPanel
    Friend WithEvents btnAnggota As RibbonButton
    Friend WithEvents btnTahunAktif As RibbonButton
    Friend WithEvents panelSimpanan As RibbonPanel
    Friend WithEvents btnJenisSimpanan As RibbonButton
    Friend WithEvents btnBukuSimpSukarela As RibbonButton
    Friend WithEvents tabSimpanan As RibbonTab
    Friend WithEvents panelSimpPokokWjb As RibbonPanel
    Friend WithEvents btnPemSimWjb As RibbonButton
    Friend WithEvents btnPemSimWjbKolektif As RibbonButton
    Friend WithEvents btnPengSimpPokok As RibbonButton
    Friend WithEvents panelSimpSukarela As RibbonPanel
    Friend WithEvents btnRekSimpSukarela As RibbonButton
    Friend WithEvents btnPemSimpSukarela As RibbonButton
    Friend WithEvents btnPengSimpSukarela As RibbonButton
    Friend WithEvents btnCetakSimpSukarela As RibbonButton
    Friend WithEvents tabPinjaman As RibbonTab
    Friend WithEvents panelPeminjaman As RibbonPanel
    Friend WithEvents btnPeminjaman As RibbonButton
    Friend WithEvents btnBuatTagihan As RibbonButton
    Friend WithEvents btnLihatTagihan As RibbonButton
    Friend WithEvents panelPemPinjaman As RibbonPanel
    Friend WithEvents btnPemPinjaman As RibbonButton
    Friend WithEvents btnPembKolektif As RibbonButton
    Friend WithEvents panelKoreksi As RibbonPanel
    Friend WithEvents tabLaporan As RibbonTab
    Friend WithEvents panelLapKeanggotaan As RibbonPanel
    Friend WithEvents btnLapAnggota As RibbonButton
    Friend WithEvents panelLapPembayaran As RibbonPanel
    Friend WithEvents btnHistoriPembayaran As RibbonButton
    Friend WithEvents panelSaldoPiutang As RibbonPanel
    Friend WithEvents panelRekap As RibbonPanel
    Friend WithEvents panelLain2 As RibbonPanel
    Friend WithEvents btnLapTraSimpSukarela As RibbonButton
    Friend WithEvents btnLapSimpPokokWjb As RibbonButton
    Friend WithEvents btnLapTunggakanSimpan As RibbonButton
    Friend WithEvents btnLapPemBunga As RibbonButton
    Friend WithEvents panelSHU As RibbonPanel
    Friend WithEvents btnProsesSHU As RibbonButton
    Friend WithEvents btnPembAsuransi As RibbonButton
    Friend WithEvents btnByrAdmin As RibbonButton
    Friend WithEvents tabKeluar As RibbonTab
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents Keluar As RibbonButton
    Friend WithEvents panelDB As RibbonPanel
    Friend WithEvents btnBackupDB As RibbonButton
    Friend WithEvents btnRestoreDB As RibbonButton
    Friend WithEvents btnResetData As RibbonButton
    Friend WithEvents btnLapPeminjaman As RibbonButton
    Friend WithEvents btnLapByrPinjaman As RibbonButton
    Friend WithEvents btnLapSaldo As RibbonButton
    Friend WithEvents btnRekapSaldoPiutang As RibbonButton
    Friend WithEvents btnRekapPendatan As RibbonButton
    Friend WithEvents btnRekapSimpPokokWjb As RibbonButton
    Friend WithEvents btnSimpSukarela As RibbonButton
    Friend WithEvents TabControl1 As JacksiroKe.MdiTabCtrl.TabControl
    Friend WithEvents btnKorPinjaman As RibbonButton
    Friend WithEvents btnKorPembayaran As RibbonButton
    Friend WithEvents btnBillingSimpanan As RibbonButton
    Friend WithEvents btnLihatBilling As RibbonButton
    Friend WithEvents btnCetakBuku As RibbonButton
    Friend WithEvents btnCetakSampul As RibbonButton
    Friend WithEvents btnHitungBunga As RibbonButton
End Class
