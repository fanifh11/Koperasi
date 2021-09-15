Public Class MenuUtama

    Public masuk As String = ""

    Public Sub removePanel()

        For Each tab As RibbonTab In Ribbon1.Tabs


            Dim visibleTab As Boolean = False

            For Each panel As RibbonPanel In tab.Panels
                Dim visiblePanel As Boolean = False
                For Each button As RibbonButton In panel.Items

                    If button.Visible Then
                        visiblePanel = True
                    End If
                Next

                panel.Visible = visiblePanel
                If visiblePanel Then

                    visibleTab = True
                End If
            Next
            tab.Visible = visibleTab
        Next

        'If btnAnggota.Visible = False And btnTahunAktif.Visible = False Then
        '    panelKeanggotaan.Visible = False
        'End If
        'If btnJenisSimpanan.Visible = False And btnBukuSimpSukarela.Visible = False Then
        '    panelSimpanan.Visible = False
        'End If
        'If btnBillingSimpanan.Visible = False And btnLihatBilling.Visible = False Then
        '    panelBilling.Visible = False
        'End If
        'If btnPemSimWjb.Visible = False And btnPemSimWjbKolektif.Visible = False And btnPengSimpPokok.Visible = False Then
        '    panelSimpPokokWjb.Visible = False
        'End If
        'If btnRekSimpSukarela.Visible = False And btnPemSimpSukarela.Visible = False And btnPengSimpSukarela.Visible = False Then
        '    panelSimpSukarela.Visible = False
        'End If
        'If btnHitungBunga.Visible = False Then
        '    panelBunga.Visible = False
        'End If
        'If btnCetakSampul.Visible = False And btnCetakBuku.Visible = False Then
        '    panelPembukuan.Visible = False
        'End If
        'If btnPeminjaman.Visible = False And btnLihatTagihan.Visible = False And btnBuatTagihan.Visible = False Then
        '    panelPeminjaman.Visible = False
        'End If
        'If btnPemPinjaman.Visible = False And btnPembKolektif.Visible = False Then
        '    panelPemPinjaman.Visible = False
        'End If
        'If btnKorPinjaman.Visible = False And btnKorPembayaran.Visible = False Then
        '    panelKoreksi.Visible = False
        'End If
        'If btnLapAnggota.Visible = False And btnLapPeminjaman.Visible = False Then
        '    panelLapKeanggotaan.Visible = False
        'End If
        'If btnPembAsuransi.Visible = False And btnByrAdmin.Visible = False And btnLapByrPinjaman.Visible = False And btnHistoriPembayaran.Visible = False Then
        '    panelLapPembayaran.Visible = False
        'End If
        'If btnLapSaldo.Visible = False Then
        '    panelSaldoPiutang.Visible = False
        'End If
        'If btnRekapPendatan.Visible = False And btnRekapSaldoPiutang.Visible = False And btnRekapSimpPokokWjb.Visible = False And btnSimpSukarela.Visible = False Then
        '    panelRekap.Visible = False
        'End If
        'If btnLapTraSimpSukarela.Visible = False And btnLapSimpPokokWjb.Visible = False And btnLapTunggakanSimpan.Visible = False And btnLapPemBunga.Visible = False Then
        '    panelLain2.Visible = False
        'End If
        'If btnProsesSHU.Visible = False Then
        '    panelSHU.Visible = False
        'End If
        'If btnIdentitas.Visible = False And btnGroup.Visible = False And btnUser.Visible = False Then
        '    panelSetting.Visible = False
        'End If
        'If btnBackupDB.Visible = False And btnRestoreDB.Visible = False And btnResetData.Visible = False Then
        '    panelDB.Visible = False
        'End If
        'If Keluar.Visible = False Then
        '    Me.RibbonPanel2.Visible = False
        'End If


    End Sub

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
        DialogBackup.ShowDialog()
        DialogBackup.Dispose()

    End Sub

    Private Sub btnRestoreDB_Click(sender As Object, e As EventArgs) Handles btnRestoreDB.Click
        DialogRestore.ShowDialog()
        DialogRestore.Dispose()

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

                tabUtilitas.Visible = CBool(checked)

            ElseIf menuTag = 2 Then
                btnIdentitas.Visible = checked

            ElseIf menuTag = 3 Then
                btnGroup.Visible = checked
            ElseIf menuTag = 4 Then
                btnUser.Visible = checked
            ElseIf menuTag = 5 Then
                btnBackupDB.Visible = checked
            ElseIf menuTag = 6 Then
                btnRestoreDB.Visible = checked
            ElseIf menuTag = 7 Then
                btnResetData.Visible = checked
            ElseIf menuTag = 8 Then
                tabMaster.Visible = checked
            ElseIf menuTag = 9 Then
                btnAnggota.Visible = checked
            ElseIf menuTag = 10 Then
                btnTahunAktif.Visible = checked
            ElseIf menuTag = 11 Then
                btnJenisSimpanan.Visible = checked
            ElseIf menuTag = 12 Then
                btnBukuSimpSukarela.Visible = checked
            ElseIf menuTag = 13 Then
                tabSimpanan.Visible = checked
            ElseIf menuTag = 14 Then
                btnBillingSimpanan.Visible = checked
            ElseIf menuTag = 15 Then
                btnLihatBilling.Visible = checked
            ElseIf menuTag = 16 Then
                btnPemSimWjb.Visible = checked
            ElseIf menuTag = 17 Then
                btnPemSimWjbKolektif.Visible = checked
            ElseIf menuTag = 18 Then
                btnPengSimpPokok.Visible = checked
            ElseIf menuTag = 19 Then
                btnRekSimpSukarela.Visible = checked
            ElseIf menuTag = 20 Then
                btnPemSimpSukarela.Visible = checked
            ElseIf menuTag = 21 Then
                btnPengSimpSukarela.Visible = checked
            ElseIf menuTag = 22 Then
                btnCetakSimpSukarela.Visible = checked
            ElseIf menuTag = 23 Then
                btnHitungBunga.Visible = checked
            ElseIf menuTag = 24 Then
                btnCetakSampul.Visible = checked
            ElseIf menuTag = 25 Then
                btnCetakBuku.Visible = checked
            ElseIf menuTag = 26 Then
                tabPinjaman.Visible = checked
            ElseIf menuTag = 27 Then
                btnPeminjaman.Visible = checked
            ElseIf menuTag = 28 Then
                btnBuatTagihan.Visible = checked
            ElseIf menuTag = 29 Then
                btnLihatTagihan.Visible = checked
            ElseIf menuTag = 30 Then
                btnPemPinjaman.Visible = checked
            ElseIf menuTag = 31 Then
                btnPembKolektif.Visible = checked
            ElseIf menuTag = 32 Then
                btnKorPinjaman.Visible = checked
            ElseIf menuTag = 33 Then
                btnKorPembayaran.Visible = checked
            ElseIf menuTag = 34 Then
                tabLaporan.Visible = checked
            ElseIf menuTag = 35 Then
                btnLapAnggota.Visible = checked
            ElseIf menuTag = 36 Then
                btnLapPeminjaman.Visible = checked
            ElseIf menuTag = 37 Then
                btnPembAsuransi.Visible = checked
            ElseIf menuTag = 38 Then
                btnPembAsuransi.Visible = checked
            ElseIf menuTag = 39 Then
                btnLapByrPinjaman.Visible = checked
            ElseIf menuTag = 40 Then
                btnHistoriPembayaran.Visible = checked
            ElseIf menuTag = 41 Then
                btnLapSaldo.Visible = checked
            ElseIf menuTag = 42 Then
                btnRekapPendatan.Visible = checked
            ElseIf menuTag = 43 Then
                btnRekapSaldoPiutang.Visible = checked
            ElseIf menuTag = 44 Then
                btnRekapSimpPokokWjb.Visible = checked
            ElseIf menuTag = 45 Then
                btnSimpSukarela.Visible = checked
            ElseIf menuTag = 46 Then
                btnLapTraSimpSukarela.Visible = checked
            ElseIf menuTag = 47 Then
                btnLapSimpPokokWjb.Visible = checked
            ElseIf menuTag = 48 Then
                btnLapTunggakanSimpan.Visible = checked
            ElseIf menuTag = 49 Then
                btnLapPemBunga.Visible = checked
            ElseIf menuTag = 50 Then
                btnProsesSHU.Visible = checked
            ElseIf menuTag = 51 Then
                tabKeluar.Visible = checked
            ElseIf menuTag = 52 Then
                Keluar.Visible = checked
            End If
        Next

        check = True
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs)
        Me.Close()


        Login.ShowDialog()
        Login.Dispose()
    End Sub

    Private Sub btnPembAsuransi_Click(sender As Object, e As EventArgs) Handles btnPembAsuransi.Click
        LaporanPembayaranAsuransi.ShowDialog()
        LaporanPembayaranAsuransi.Dispose()
    End Sub

    Private Sub btnByrAdmin_Click(sender As Object, e As EventArgs) Handles btnByrAdmin.Click
        LaporanPendapatanAdministrasi.ShowDialog()
        LaporanPendapatanAdministrasi.Dispose()
    End Sub

    Private Sub btnBukuSimpSukarela_Click(sender As Object, e As EventArgs) Handles btnBukuSimpSukarela.Click
        PreviewContohBukuSimpananSukarela.ShowDialog()
        PreviewContohBukuSimpananSukarela.Dispose()
    End Sub

    Private Sub MenuUtama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnResetData_Click(sender As Object, e As EventArgs) Handles btnResetData.Click
        DialogReset.ShowDialog()
        DialogReset.Dispose()
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load






    End Sub

    Dim check As Boolean = False

    Private Sub MenuUtama_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If check Then
            removePanel()
            check = False
        End If
    End Sub
End Class