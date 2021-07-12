Public Class LaporanSaldoPiutangNasabah

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanSaldoPiutangNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, tglpinjam, besarpinjam, saldopinjam from qpinjam where idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%'"
        dgv_data_saldo_piutang.DataSource = getData(sql)
        dgv_data_saldo_piutang.Columns(0).HeaderText = "ID Anggota"
        dgv_data_saldo_piutang.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_saldo_piutang.Columns(2).HeaderText = "ID Pinjam"
        dgv_data_saldo_piutang.Columns(3).HeaderText = "Tanggal Pinjam"
        dgv_data_saldo_piutang.Columns(4).HeaderText = "Besar Pinjam"
        dgv_data_saldo_piutang.Columns(5).HeaderText = "Saldo"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_saldo_piutang.Rows.Count
        lbl_saldo_pinjam.Text = "Saldo Pinjam : " & numberFor(toDouble(getValue("select sum(saldopinjam) as saldopinjam from qpinjam where idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%'", "saldopinjam")).ToString)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanSaldoPiutangNasabah.sql = sql
        PreviewLaporanSaldoPiutangNasabah.sampai = Now().ToString("yyyy-MM-dd")
        PreviewLaporanSaldoPiutangNasabah.ShowDialog()
    End Sub
End Class