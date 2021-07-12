Public Class MenuUtama

    Public masuk As String = ""

    Private Sub btnAnggota_Click(sender As Object, e As EventArgs) Handles btnAnggota.Click
        FormAnggota.ShowDialog()
        FormAnggota.Dispose()
    End Sub

    Private Sub btnIdentitas_Click(sender As Object, e As EventArgs) Handles btnIdentitas.Click
        DataIdentitasKoperasi.ShowDialog()
        DataIdentitasKoperasi.Dispose()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        FormUser.ShowDialog()
        FormUser.Dispose()
    End Sub

    Private Sub btnTahunAktif_Click(sender As Object, e As EventArgs) Handles btnTahunAktif.Click
        FormDataTahun.ShowDialog()
        FormDataTahun.Dispose()
    End Sub

    Private Sub btnJenisSimpanan_Click(sender As Object, e As EventArgs) Handles btnJenisSimpanan.Click
        JenisSimpanan.ShowDialog()
        JenisSimpanan.Dispose()
    End Sub

    Private Sub btnBillingSimpanan_Click(sender As Object, e As EventArgs) Handles btnBillingSimpanan.Click
        FormBuatBilling.ShowDialog()
        FormBuatBilling.Dispose()

    End Sub

    Private Sub btnPemSimWjb_Click(sender As Object, e As EventArgs) Handles btnPemSimWjb.Click
        FormBayar.ShowDialog()
        FormBayar.Dispose()
    End Sub

    Private Sub btnPemSimWjbKolektif_Click(sender As Object, e As EventArgs) Handles btnPemSimWjbKolektif.Click
        FormPembayaranSimpKolektif.ShowDialog()
        FormPembayaranSimpKolektif.Dispose()

    End Sub

    Private Sub btnPengSimpPokok_Click(sender As Object, e As EventArgs) Handles btnPengSimpPokok.Click
        FormPengambilanSimpPokoknWajib.ShowDialog()
        FormPengambilanSimpPokoknWajib.Dispose()
    End Sub

    Private Sub btnPemSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnPemSimpSukarela.Click
        FormIsiSimpananSukarela.ShowDialog()
        FormIsiSimpananSukarela.Dispose()
    End Sub

    Private Sub btnPengSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnPengSimpSukarela.Click
        PengambilanSimpananSukarela.ShowDialog()
        PengambilanSimpananSukarela.Dispose()
    End Sub

    Private Sub btnCetakSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnCetakSimpSukarela.Click
        FormCetakSimpSukarela.ShowDialog()
        FormCetakSimpSukarela.Dispose()
    End Sub

    Private Sub btnHitungBunga_Click(sender As Object, e As EventArgs) Handles btnHitungBunga.Click
        FormPerhitungaBungaSimpSukarela.ShowDialog()
        FormPerhitungaBungaSimpSukarela.Dispose()
    End Sub

    Private Sub btnCetakSampul_Click(sender As Object, e As EventArgs) Handles btnCetakSampul.Click
        FormCetakSampulBukuSimpSukarela.ShowDialog()
        FormCetakSampulBukuSimpSukarela.Dispose()
    End Sub

    Private Sub btnCetakBuku_Click(sender As Object, e As EventArgs) Handles btnCetakBuku.Click
        FormCetakBukuSimpSukarela.ShowDialog()
        FormCetakBukuSimpSukarela.Dispose()
    End Sub

    Private Sub btnLihatBilling_Click(sender As Object, e As EventArgs) Handles btnLihatBilling.Click
        FormLihatTagihan.ShowDialog()
        FormLihatTagihan.Dispose()
    End Sub

    Private Sub btnRekSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnRekSimpSukarela.Click
        FormBuatRekSimpSukarela.ShowDialog()
        FormBuatRekSimpSukarela.Dispose()
    End Sub

    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        FormPinjam.ShowDialog()
        FormPinjam.Dispose()
    End Sub

    Private Sub btnBuatTagihan_Click(sender As Object, e As EventArgs) Handles btnBuatTagihan.Click
        FormBuatTagihanNasabah.ShowDialog()
        FormBuatTagihanNasabah.Dispose()
    End Sub

    Private Sub btnLihatTagihan_Click(sender As Object, e As EventArgs) Handles btnLihatTagihan.Click
        FormLihatTagihanNasabah.ShowDialog()
        FormLihatTagihanNasabah.Dispose()
    End Sub

    Private Sub btnPemPinjaman_Click(sender As Object, e As EventArgs) Handles btnPemPinjaman.Click
        FormPembayaranNasabah.ShowDialog()
        FormPembayaranNasabah.Dispose()
    End Sub

    Private Sub btnPembKolektif_Click(sender As Object, e As EventArgs) Handles btnPembKolektif.Click
        FormPembayaranPinjamanKolektif.ShowDialog()
        FormPembayaranPinjamanKolektif.Dispose()
    End Sub

    Private Sub btnKorPinjaman_Click(sender As Object, e As EventArgs) Handles btnKorPinjaman.Click
        FormKoreksiPinjamorPiutangNasabah.ShowDialog()
        FormKoreksiPinjamorPiutangNasabah.Dispose()
    End Sub

    Private Sub btnKorPembayaran_Click(sender As Object, e As EventArgs) Handles btnKorPembayaran.Click
        FormKoreksiPembayaranNasabah.ShowDialog()
        FormKoreksiPembayaranNasabah.Dispose()
    End Sub

    Private Sub btnLapAnggota_Click(sender As Object, e As EventArgs) Handles btnLapAnggota.Click
        LaporanNasabah.ShowDialog()
        LaporanNasabah.Dispose()
    End Sub

    Private Sub btnLapPeminjaman_Click(sender As Object, e As EventArgs) Handles btnLapPeminjaman.Click
        LaporanPeminjaman.ShowDialog()
        LaporanPeminjaman.Dispose()
    End Sub

    Private Sub btnLapByrPinjaman_Click(sender As Object, e As EventArgs) Handles btnLapByrPinjaman.Click
        LaporanPembayaranPiutangNasabah.ShowDialog()
        LaporanPembayaranPiutangNasabah.Dispose()
    End Sub

    Private Sub btnHistoriPembayaran_Click(sender As Object, e As EventArgs) Handles btnHistoriPembayaran.Click
        LaporanHistoriPembayaranPiutangNasabah.ShowDialog()
        LaporanHistoriPembayaranPiutangNasabah.Dispose()
    End Sub

    Private Sub btnLapSaldo_Click(sender As Object, e As EventArgs) Handles btnLapSaldo.Click
        LaporanSaldoPiutangNasabah.ShowDialog()
        LaporanSaldoPiutangNasabah.Dispose()
    End Sub

    Private Sub btnRekapPendatan_Click(sender As Object, e As EventArgs) Handles btnRekapPendatan.Click
        LaporanRekapitulasiPendapatanBunga.ShowDialog()
        LaporanRekapitulasiPendapatanBunga.Dispose()
    End Sub

    Private Sub btnRekapSimpPokokWjb_Click(sender As Object, e As EventArgs) Handles btnRekapSimpPokokWjb.Click
        LaporanRekapitulasiSimpananPokok.ShowDialog()
        LaporanRekapitulasiSimpananPokok.Dispose()
    End Sub

    Private Sub btnSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnSimpSukarela.Click
        LaporanRekapitulasiSimpananSukarela.ShowDialog()
        LaporanRekapitulasiSimpananSukarela.Dispose()
    End Sub

    Private Sub btnLapTraSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnLapTraSimpSukarela.Click
        LaporanTransaksiSimpananSukarela.ShowDialog()
        LaporanTransaksiSimpananSukarela.Dispose()
    End Sub

    Private Sub btnLapSimpPokokWjb_Click(sender As Object, e As EventArgs) Handles btnLapSimpPokokWjb.Click
        LaporanSimpananAnggota.ShowDialog()
        LaporanSimpananAnggota.Dispose()
    End Sub

    Private Sub btnLapTunggakanSimpan_Click(sender As Object, e As EventArgs) Handles btnLapTunggakanSimpan.Click
        FormLihatTagihan.ShowDialog()
        FormLihatTagihan.Dispose()
    End Sub

    Private Sub btnLapPemBunga_Click(sender As Object, e As EventArgs) Handles btnLapPemBunga.Click
        LaporanPembayaranBunga.ShowDialog()
        LaporanPembayaranBunga.Dispose()
    End Sub

    Private Sub btnProsesSHU_Click(sender As Object, e As EventArgs) Handles btnProsesSHU.Click
        FormProsesSHU.ShowDialog()
        FormProsesSHU.Dispose()
    End Sub

    Private Sub btnRekapSaldoPiutang_Click(sender As Object, e As EventArgs) Handles btnRekapSaldoPiutang.Click
        LaporanRekapitulasiSaldoPiutang.ShowDialog()
        LaporanRekapitulasiSaldoPiutang.Dispose()
    End Sub

    Private Sub btnGroup_Click(sender As Object, e As EventArgs) Handles btnGroup.Click
        FormGroupAkses.ShowDialog()
        FormGroupAkses.Dispose()

    End Sub

    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs) Handles btnBackupDB.Click
        FormBackupDatabase.ShowDialog()
        FormBackupDatabase.Dispose()

    End Sub

    Private Sub btnRestoreDB_Click(sender As Object, e As EventArgs) Handles btnRestoreDB.Click
        FormRestoreDatabase.ShowDialog()
        FormRestoreDatabase.Dispose()

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Me.Close()

        Login.ShowDialog()
        Login.Dispose()

    End Sub

    Public username As String = "username"

    Sub setRule()

        Dim dgroup = getValue("select dgroup from tbluser where duser = '" & username & "'", "dgroup")
        Dim sql = "select menutag,flag from tblmenu where dgroup = '" & dgroup & "'"

        Dim dataMenu As DataTable = getData(sql)

        For Each row As DataRow In dataMenu.Rows
            Dim menuTag = row.Item("menutag")
            Dim checked = row.Item("flag")

            If menuTag = 1 Then
                tabUtilitas.Visible = checked
            ElseIf menuTag = 2 Then
                btnIdentitas.Visible = checked
            ElseIf menuTag = 3 Then
                btnGroup.Visible = checked
            ElseIf menuTag = 4 Then
                btnUser.Visible = checked
            ElseIf menuTag = 5 Then
                tabMaster.Visible = checked
            ElseIf menuTag = 6 Then
                btnAnggota.Visible = checked
            ElseIf menuTag = 7 Then
                btnTahunAktif.Visible = checked
            ElseIf menuTag = 8 Then
                btnJenisSimpanan.Visible = checked
            ElseIf menuTag = 9 Then
                btnBukuSimpSukarela.Visible = checked
            ElseIf menuTag = 10 Then
                tabSimpanan.Visible = checked
            ElseIf menuTag = 11 Then
                btnBuatTagihan.Visible = checked
            ElseIf menuTag = 12 Then
                btnLihatBilling.Visible = checked
            ElseIf menuTag = 13 Then
                btnPemSimWjb.Visible = checked
            ElseIf menuTag = 14 Then
                btnPemSimWjbKolektif.Visible = checked
            ElseIf menuTag = 15 Then
                btnPengSimpPokok.Visible = checked
            ElseIf menuTag = 16 Then
                btnRekSimpSukarela.Visible = checked
            ElseIf menuTag = 17 Then
                btnPemSimpSukarela.Visible = checked
            ElseIf menuTag = 18 Then
                btnPengSimpSukarela.Visible = checked
            ElseIf menuTag = 19 Then
                btnCetakSimpSukarela.Visible = checked
            ElseIf menuTag = 20 Then
                btnHitungBunga.Visible = checked
            ElseIf menuTag = 21 Then
                btnCetakSampul.Visible = checked
            ElseIf menuTag = 22 Then
                btnCetakBuku.Visible = checked
            ElseIf menuTag = 23 Then
                tabPinjaman.Visible = checked
            ElseIf menuTag = 24 Then
                btnPeminjaman.Visible = checked
            ElseIf menuTag = 25 Then
                btnBuatTagihan.Visible = checked
            ElseIf menuTag = 26 Then
                btnLihatBilling.Visible = checked
            ElseIf menuTag = 27 Then
                btnPemPinjaman.Visible = checked
            ElseIf menuTag = 28 Then
                btnPembKolektif.Visible = checked
            ElseIf menuTag = 29 Then
                btnKorPinjaman.Visible = checked
            ElseIf menuTag = 30 Then
                btnKorPembayaran.Visible = checked
            ElseIf menuTag = 31 Then
                tabLaporan.Visible = checked
            ElseIf menuTag = 32 Then
                btnLapAnggota.Visible = checked
            ElseIf menuTag = 33 Then
                btnLapPeminjaman.Visible = checked
            ElseIf menuTag = 34 Then
                btnPembAsuransi.Visible = checked
            ElseIf menuTag = 35 Then
                btnPembAsuransi.Visible = checked
            ElseIf menuTag = 36 Then
                btnLapByrPinjaman.Visible = checked
            ElseIf menuTag = 37 Then
                btnHistoriPembayaran.Visible = checked
            ElseIf menuTag = 38 Then
                btnLapSaldo.Visible = checked
            ElseIf menuTag = 39 Then
                btnRekapPendatan.Visible = checked
            ElseIf menuTag = 40 Then
                btnRekapSaldoPiutang.Visible = checked
            ElseIf menuTag = 41 Then
                btnRekapSimpPokokWjb.Visible = checked
            ElseIf menuTag = 42 Then
                btnSimpSukarela.Visible = checked
            ElseIf menuTag = 43 Then
                btnLapTraSimpSukarela.Visible = checked
            ElseIf menuTag = 44 Then
                btnLapSimpPokokWjb.Visible = checked
            ElseIf menuTag = 45 Then
                btnLapTunggakanSimpan.Visible = checked
            ElseIf menuTag = 46 Then
                btnLapPemBunga.Visible = checked
            ElseIf menuTag = 47 Then
                btnProsesSHU.Visible = checked
            ElseIf menuTag = 48 Then
                tabKeluar.Visible = checked
            ElseIf menuTag = 49 Then
                Keluar.Visible = checked
            End If
        Next
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs)

        Me.Close()

        Login.ShowDialog()
        Login.Dispose()
    End Sub


End Class