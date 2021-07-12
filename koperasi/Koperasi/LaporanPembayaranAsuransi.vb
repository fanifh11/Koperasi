Public Class LaporanPembayaranAsuransi
    Private Sub LaporanPembayaranAsuransi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, tglpinjam, asuransi from qpinjam where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("yyyy-MM-dd") & "' and '" & dtp_sampai.Value.ToString("yyyy-MM-dd") & "'"
        dgv_laporan_pembayaran_asuransi.DataSource = getData(sql)
        dgv_laporan_pembayaran_asuransi.Columns(0).HeaderText = "ID Anggota"
        dgv_laporan_pembayaran_asuransi.Columns(1).HeaderText = "Nama Anggota"
        dgv_laporan_pembayaran_asuransi.Columns(2).HeaderText = "ID Pinjam"
        dgv_laporan_pembayaran_asuransi.Columns(3).HeaderText = "Tanggal Pinjam"
        dgv_laporan_pembayaran_asuransi.Columns(4).HeaderText = "Asuransi"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_laporan_pembayaran_asuransi.Rows.Count
        lbl_total_asuransi.Text = "Total Asuransi : " & numberFor(toDouble(getValue("select sum(asuransi) as asuransi from qpinjam where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("yyyy-MM-dd") & "' and '" & dtp_sampai.Value.ToString("yyyy-MM-dd") & "'", "asuransi")).ToString)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanPembayaranAsuransi.sql = sql
        PreviewLaporanPembayaranAsuransi.mulai = dtp_mulai.Value.ToString("yyyy-MM-dd")
        PreviewLaporanPembayaranAsuransi.sampai = dtp_sampai.Value.ToString("yyyy-MM-dd")
        PreviewLaporanPembayaranAsuransi.ShowDialog()
    End Sub
End Class