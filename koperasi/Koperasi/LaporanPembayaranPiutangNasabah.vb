﻿Public Class LaporanPembayaranPiutangNasabah
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanPembayaranPiutangNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, to_char(tglbayar, 'DD-MM-YYYY') as tglbayar, besarbayar, besarpokok, besarbunga from qtagihan where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
        dgv_data_pembayaran.DataSource = getData(sql)
        dgv_data_pembayaran.Columns(0).HeaderText = "ID Anggota"
        dgv_data_pembayaran.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_pembayaran.Columns(2).HeaderText = "ID Pinjam"
        dgv_data_pembayaran.Columns(3).HeaderText = "Tanggal Bayar"
        dgv_data_pembayaran.Columns(4).HeaderText = "Bayar"
        dgv_data_pembayaran.Columns(5).HeaderText = "Pokok"
        dgv_data_pembayaran.Columns(6).HeaderText = "Bunga"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_pembayaran.Rows.Count
        lbl_bayar.Text = "Bayar : " & numberFor(toDouble(getValue("select sum(besarbayar) as besarbayar from qtagihan where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'", "besarbayar")).ToString) & " Pokok : " & numberFor(toDouble(getValue("select sum(besarpokok) as besarpokok from qtagihan where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'", "besarpokok")).ToString) & " Bunga : " & numberFor(toDouble(getValue("select sum(besarbunga) as besarbunga from qtagihan where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'", "besarbunga")).ToString)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanPembayaranPiutangNasabah.sql = sql
        PreviewLaporanPembayaranPiutangNasabah.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPembayaranPiutangNasabah.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPembayaranPiutangNasabah.ShowDialog()
    End Sub
End Class