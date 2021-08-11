Public Class LaporanRekapitulasiSimpananSukarela
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanRekapitulasiSimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String
    Sub showData()

        sql = "select tblanggota.idanggota, tblanggota.anggota, sum(qtransaksi.debet) as debet, sum(qtransaksi.kredit) as kredit, sum(qtransaksi.kredit - qtransaksi.debet) as saldo from qtransaksi inner join tblanggota on tblanggota.idanggota = qtransaksi.idanggota where qtransaksi.anggota ilike '%" & txt_search.Text & "%' and qtransaksi.tgltransaksi between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "' group by tblanggota.idanggota"
        dgv_data_simpanan.DataSource = getData(sql)
        dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
        dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_simpanan.Columns(2).HeaderText = "Jumlah Debet"
        dgv_data_simpanan.Columns(3).HeaderText = "Jumlah Kredit"
        dgv_data_simpanan.Columns(4).HeaderText = "Saldo"

        dgv_data_simpanan.Columns(2).DefaultCellStyle.Format = "c0"
        dgv_data_simpanan.Columns(3).DefaultCellStyle.Format = "c0"
        dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
    End Sub

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanRekapitulasiSimpananSukarela.sql = sql
        PreviewLaporanRekapitulasiSimpananSukarela.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanRekapitulasiSimpananSukarela.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanRekapitulasiSimpananSukarela.ShowDialog()
    End Sub
End Class