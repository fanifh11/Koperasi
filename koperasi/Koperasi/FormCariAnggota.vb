Public Class FormCariAnggota
    Public menu As String = ""

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormCariAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Sub showData()
        If menu = "Bayar simpanan pokok" Then
            dgv_DataAnggota.DataSource = getData("select norek, idanggota, anggota, jenissimpanan, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek, besar from qrekening where fbayar = 0 and (anggota ilike '%" & txt_CariDataAnggota.Text & "%' )")
            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
            dgv_DataAnggota.Columns(2).HeaderText = "Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_DataAnggota.Columns(4).HeaderText = "Keterangan"
            dgv_DataAnggota.Columns(5).HeaderText = "Tgl Tagihan"
            dgv_DataAnggota.Columns(6).HeaderText = "Besar"

            dgv_DataAnggota.Columns(6).DefaultCellStyle.Format = "c0"

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Isi simpanan sukarela" Then
            dgv_DataAnggota.DataSource = getData("select idsukarela, idanggota, anggota, ketsukarela, bunga from qsukarela where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' order by idsukarela asc")
            dgv_DataAnggota.Columns(0).HeaderText = "No Rek Sukarela"
            dgv_DataAnggota.Columns(1).HeaderText = "Kode Anggota"
            dgv_DataAnggota.Columns(2).HeaderText = "Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_DataAnggota.Columns(4).Visible = False

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Pengambilan simp sukarela" Then
            dgv_DataAnggota.DataSource = getData("select idsukarela, idanggota, anggota, ketsukarela, bunga from qsukarela where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' ")
            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
            dgv_DataAnggota.Columns(2).HeaderText = "Nama Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_DataAnggota.Columns(4).Visible = False

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Cetak buku simp sukarela" Then
            dgv_DataAnggota.DataSource = getData("select idsukarela, idanggota, anggota, jk, ketsukarela from qsukarela where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' ")
            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
            dgv_DataAnggota.Columns(2).HeaderText = "Nama Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Jenis Kelamin"
            dgv_DataAnggota.Columns(4).HeaderText = "Jenis Simpanan"

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Form cetak buku simp sukarela" Then
            dgv_DataAnggota.DataSource = getData("select idsukarela, idanggota, anggota, ketsukarela from qsukarela where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' ")
            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
            dgv_DataAnggota.Columns(2).HeaderText = "Nama Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpanan"

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Data Peminjam" Then
            dgv_DataAnggota.DataSource = getData("select idanggota, anggota, alamat from tblanggota where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' or anggota ilike '%" & txt_CariDataAnggota.Text & "%'  ")

            dgv_DataAnggota.Columns(0).HeaderText = "Kode Anggota"
            dgv_DataAnggota.Columns(1).HeaderText = "Nama"
            dgv_DataAnggota.Columns(2).HeaderText = "Alamat"

            makeFillDG(dgv_DataAnggota)

        ElseIf menu = "Pembayaran Nasabah" Then
            dgv_DataAnggota.DataSource = getData("select idtagihan,idpinjam,idanggota,anggota,alamat,jenis,besarpinjam,lamapinjam,totalpokok,totalbunga,totalangsur,cicilanke,besarbayar,saldopinjam,totalpokok - besarpokok,totalbunga - besarbunga,kodetagihan
            from qtagihan where flagtagihan = 0 and anggota ilike '%" & txt_CariDataAnggota.Text & "%'")
            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "Kode Pinjam"
            dgv_DataAnggota.Columns(2).HeaderText = "Kode Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Nama"
            dgv_DataAnggota.Columns(4).HeaderText = "Alamat"
            dgv_DataAnggota.Columns(5).HeaderText = "Jenis Pinjam"
            dgv_DataAnggota.Columns(6).HeaderText = "Besar Pinjam"
            dgv_DataAnggota.Columns(7).HeaderText = "Lama Pinjam"
            dgv_DataAnggota.Columns(8).HeaderText = "Angsuran Pokok"
            dgv_DataAnggota.Columns(9).HeaderText = "Angsuran Bunga"
            dgv_DataAnggota.Columns(10).HeaderText = "Jumlah Angsuran"
            dgv_DataAnggota.Columns(11).HeaderText = "Cicilan Ke -"
            dgv_DataAnggota.Columns(12).HeaderText = "Sudah Dibayar"
            dgv_DataAnggota.Columns(13).HeaderText = "Saldo Piutang"
            dgv_DataAnggota.Columns(14).HeaderText = "Pokok"
            dgv_DataAnggota.Columns(15).HeaderText = "Bunga"
            dgv_DataAnggota.Columns(16).HeaderText = "Kode Tagihan"

            dgv_DataAnggota.Columns(6).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(8).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(9).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(10).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(12).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(13).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(14).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(15).DefaultCellStyle.Format = "c0"

        ElseIf menu = "Koreksi Pembayaran Nasabah" Then
            dgv_DataAnggota.DataSource = getData("select idtagihan,idpinjam,idanggota,anggota,alamat,jenis,besarpinjam,lamapinjam,totalpokok,totalbunga,jumlahangsuran,cicilanke,totalangsur,saldopinjam,besarpokok,besarbunga,kodetagihan,besarbayar 
            from qtagihan where idtagihan in (select max(idtagihan) from tbltagihan where flagtagihan = 1 and anggota ilike '%" & txt_CariDataAnggota.Text & "%' group by idpinjam )")

            dgv_DataAnggota.Columns(0).Visible = False
            dgv_DataAnggota.Columns(1).HeaderText = "Kode Pinjam"
            dgv_DataAnggota.Columns(2).HeaderText = "Kode Anggota"
            dgv_DataAnggota.Columns(3).HeaderText = "Nama"
            dgv_DataAnggota.Columns(4).HeaderText = "Alamat"
            dgv_DataAnggota.Columns(5).HeaderText = "Jenis Pinjam"
            dgv_DataAnggota.Columns(6).HeaderText = "Besar Pinjam"
            dgv_DataAnggota.Columns(7).HeaderText = "Lama Pinjam"
            dgv_DataAnggota.Columns(8).HeaderText = "Angsuran Pokok"
            dgv_DataAnggota.Columns(9).HeaderText = "Angsuran Bunga"
            dgv_DataAnggota.Columns(10).HeaderText = "Jumlah Angsuran"
            dgv_DataAnggota.Columns(11).HeaderText = "Cicilan Ke -"
            dgv_DataAnggota.Columns(12).HeaderText = "Sudah Dibayar"
            dgv_DataAnggota.Columns(13).HeaderText = "Saldo Piutang"
            dgv_DataAnggota.Columns(14).HeaderText = "Bayar Pokok"
            dgv_DataAnggota.Columns(15).HeaderText = "Bayar Bunga"
            dgv_DataAnggota.Columns(16).HeaderText = "Kode Tagihan"
            dgv_DataAnggota.Columns(17).HeaderText = "Jumlah Bayar"



            dgv_DataAnggota.Columns(6).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(8).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(9).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(10).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(12).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(13).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(14).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(15).DefaultCellStyle.Format = "c0"
            dgv_DataAnggota.Columns(17).DefaultCellStyle.Format = "c0"

        ElseIf menu = "Pengambilan Simpanan Pokok dan Wajib" Then
            dgv_DataAnggota.DataSource = getData("select tblanggota.idanggota,tblanggota.anggota,sum(besar) from tblrekening inner join tblanggota on tblanggota.idanggota = tblrekening.idanggota 
            where (ketkategori = 'POKOK' or ketkategori = 'WAJIB') and tglambil isnull and tblanggota.anggota ilike '%" & txt_CariDataAnggota.Text & "%' group by tblanggota.idanggota")

            dgv_DataAnggota.Columns(0).HeaderText = "ID Anggota"
            dgv_DataAnggota.Columns(1).HeaderText = "Nama"
            dgv_DataAnggota.Columns(2).HeaderText = "Besar"

            dgv_DataAnggota.Columns(2).DefaultCellStyle.Format = "c0"

            makeFillDG(dgv_DataAnggota)

        End If

        lbl_JumData.Text = "Jumlah Data :" & dgv_DataAnggota.Rows.Count

    End Sub

    Private Sub txt_CariDataAnggota_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota.TextChanged
        showData()
    End Sub

    Private Sub dgv_DataAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota.CellClick

        If e.RowIndex >= 0 Then
            If menu = "Bayar simpanan pokok" Then
                FormBayar.no_rek = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormBayar.txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormBayar.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormBayar.txt_JenisSimpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                FormBayar.txt_Keterangan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value
                FormBayar.txt_TglBiling.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(5).Value
                FormBayar.txt_BesarSimpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(6).Value
            ElseIf menu = "Isi simpanan sukarela" Then
                FormIsiSimpananSukarela.idsukarela = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormIsiSimpananSukarela.txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormIsiSimpananSukarela.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormIsiSimpananSukarela.txt_JenisSimpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                FormIsiSimpananSukarela.bunga = Double.Parse(dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value)
                FormIsiSimpananSukarela.getBungaAndSaldo()
            ElseIf menu = "Pengambilan simp sukarela" Then
                PengambilanSimpananSukarela.idsukarela = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                PengambilanSimpananSukarela.txt_kode_anggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                PengambilanSimpananSukarela.txt_nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                PengambilanSimpananSukarela.txt_jenis_simpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                PengambilanSimpananSukarela.bunga = Double.Parse(dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value)

                PengambilanSimpananSukarela.getBungaAndSaldo()
                PengambilanSimpananSukarela.showData()

                PengambilanSimpananSukarela.dgv_data_anggota.Columns(0).HeaderText = "Tanggal Transaksi"
                PengambilanSimpananSukarela.dgv_data_anggota.Columns(1).HeaderText = "Nama Anggota"
                PengambilanSimpananSukarela.dgv_data_anggota.Columns(2).HeaderText = "Debet"
                PengambilanSimpananSukarela.dgv_data_anggota.Columns(3).HeaderText = "Kredit"
                PengambilanSimpananSukarela.dgv_data_anggota.Columns(4).HeaderText = "Saldo"

            ElseIf menu = "Cetak buku simp sukarela" Then
                FormCetakBukuSimpSukarela.idsukarela = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value


                FormCetakBukuSimpSukarela.txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormCetakBukuSimpSukarela.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormCetakBukuSimpSukarela.txt_JenisSimpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value
                FormCetakBukuSimpSukarela.getSaldoAndCetak()
                FormCetakBukuSimpSukarela.showData()

                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(0).HeaderText = "Tanggal Transaksi"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(1).HeaderText = "No. Faktur"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(2).HeaderText = "Keterangan Transaksi"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(3).HeaderText = "Debet"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(4).HeaderText = "Kredit"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(5).HeaderText = "Saldo"

                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(3).DefaultCellStyle.Format = "c0"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(4).DefaultCellStyle.Format = "c0"
                FormCetakBukuSimpSukarela.dgv_DataAnggota.Columns(5).DefaultCellStyle.Format = "c0"


                FormCetakBukuSimpSukarela.txt_noCetak.Enabled = True
                FormCetakBukuSimpSukarela.idanggota = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value

            ElseIf menu = "Form cetak buku simp sukarela" Then
                FormCetakSimpSukarela.idsukarela = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormCetakSimpSukarela.txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormCetakSimpSukarela.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormCetakSimpSukarela.txt_JenisSimpanan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                FormCetakSimpSukarela.getSaldo()
                FormCetakSimpSukarela.showData()
            ElseIf menu = "Data Peminjam" Then
                FormPinjam.idanggota = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormPinjam.txt_kode_nasabah.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value
                FormPinjam.txt_nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormPinjam.txt_alamat.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value

            ElseIf menu = "Pembayaran Nasabah" Then
                FormPembayaranNasabah.idtagihan = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormPembayaranNasabah.txt_kode_pinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormPembayaranNasabah.txt_kode_nasabah.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormPembayaranNasabah.txt_nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                FormPembayaranNasabah.txt_alamat.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value
                FormPembayaranNasabah.txt_jenis_pinjaman.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(5).Value

                FormPembayaranNasabah.txt_besar_pinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(6).Value
                FormPembayaranNasabah.txt_lama_pinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(7).Value
                FormPembayaranNasabah.txt_angsuran_pokok.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value
                FormPembayaranNasabah.txt_angsuran_bunga.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value
                FormPembayaranNasabah.txt_jumlah_angsuran.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(10).Value

                FormPembayaranNasabah.txt_angsuran_ke.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(11).Value
                FormPembayaranNasabah.txt_sudah_dibayar.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(12).Value
                FormPembayaranNasabah.txt_saldo_piutang.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(13).Value
                FormPembayaranNasabah.txt_biaya_pokok.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(14).Value
                FormPembayaranNasabah.txt_bayar_bunga.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(15).Value
                FormPembayaranNasabah.txt_kode_tagihan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(16).Value

                FormPembayaranNasabah.bayarPokok = toDouble(dgv_DataAnggota.Rows(e.RowIndex).Cells(14).Value)
                FormPembayaranNasabah.bayarBunga = toDouble(dgv_DataAnggota.Rows(e.RowIndex).Cells(15).Value)
                FormPembayaranNasabah.idpinjam = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value

            ElseIf menu = "Koreksi Pembayaran Nasabah" Then
                FormKoreksiPembayaranNasabah.idtagihan = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

                FormKoreksiPembayaranNasabah.txt_KodePinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormKoreksiPembayaranNasabah.txt_KodeNasabah.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
                FormKoreksiPembayaranNasabah.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
                FormKoreksiPembayaranNasabah.txt_Alamat.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value
                FormKoreksiPembayaranNasabah.txt_JenisPinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(5).Value

                FormKoreksiPembayaranNasabah.txt_BesarPinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(6).Value
                FormKoreksiPembayaranNasabah.txt_LamaPinjam.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(7).Value
                FormKoreksiPembayaranNasabah.txt_AngsuranPokok.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value
                FormKoreksiPembayaranNasabah.txt_AngsuranBunga.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value
                FormKoreksiPembayaranNasabah.txt_JumAngsuran.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(10).Value

                FormKoreksiPembayaranNasabah.txt_AngsKe.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(11).Value
                FormKoreksiPembayaranNasabah.txt_SdhDiByr.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(12).Value
                FormKoreksiPembayaranNasabah.txt_SaldoPiutang.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(13).Value
                FormKoreksiPembayaranNasabah.txt_BayarPokok.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(14).Value
                FormKoreksiPembayaranNasabah.txt_BayarBunga.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(15).Value
                FormKoreksiPembayaranNasabah.txt_KodeTagihan.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(16).Value

                FormKoreksiPembayaranNasabah.txt_JumBayar.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(17).Value

                FormKoreksiPembayaranNasabah.bayarPokok = dgv_DataAnggota.Rows(e.RowIndex).Cells(14).Value
                FormKoreksiPembayaranNasabah.bayarBunga = dgv_DataAnggota.Rows(e.RowIndex).Cells(15).Value


                FormKoreksiPembayaranNasabah.idpinjam = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value

            ElseIf menu = "Pengambilan Simpanan Pokok dan Wajib" Then
                FormPengambilanSimpPokoknWajib.txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value
                FormPengambilanSimpPokoknWajib.txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
                FormPengambilanSimpPokoknWajib.lbl_NominalUang.Text = numberFor(dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value)
            End If

            Me.Close()
        End If

    End Sub
End Class