Public Class LaporanPendapatanAdministrasi
    Private Sub LaporanPendapatanAdministrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, to_char(tglpinjam, 'DD-MM-YYYY') as tglpinjam, administrasi from qpinjam where administrasi > 0 and (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
        dgv_laporan_pendapatan_administrasi.DataSource = getData(sql)
        dgv_laporan_pendapatan_administrasi.Columns(0).HeaderText = "ID Anggota"
        dgv_laporan_pendapatan_administrasi.Columns(1).HeaderText = "Nama Anggota"
        dgv_laporan_pendapatan_administrasi.Columns(2).HeaderText = "ID Pinjam"
        dgv_laporan_pendapatan_administrasi.Columns(3).HeaderText = "Tanggal Pinjam"
        dgv_laporan_pendapatan_administrasi.Columns(4).HeaderText = "Administrasi"

        dgv_laporan_pendapatan_administrasi.Columns(4).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_laporan_pendapatan_administrasi.Rows.Count
        lbl_total_administrasi.Text = "Total Administrasi : " & numberFor(toDouble(getValue("select sum(administrasi) as administrasi from qpinjam where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'", "administrasi")).ToString)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanPendapatanAdministrasi.sql = sql
        PreviewLaporanPendapatanAdministrasi.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPendapatanAdministrasi.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPendapatanAdministrasi.ShowDialog()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
End Class