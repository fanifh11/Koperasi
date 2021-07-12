Public Class LaporanPembayaranBunga
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanPembayaranBunga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, kredit, tgltransaksi from qtransaksi where kettransaksi = 'B' and tgltransaksi between '" & dtp_mulai.Value.ToString("yyyy-MM-dd") & "' and '" & dtp_sampai.Value.ToString("yyyy-MM-dd") & "'"
        dgv_data_simpanan.DataSource = getData(sql)
        dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
        dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_simpanan.Columns(2).HeaderText = "Kredit"
        dgv_data_simpanan.Columns(3).HeaderText = "Tanggal Transaksi"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
    End Sub

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanPembayaranBunga.sql = sql
        PreviewLaporanPembayaranBunga.mulai = dtp_mulai.Value.ToString("yyyy-MM-dd")
        PreviewLaporanPembayaranBunga.sampai = dtp_sampai.Value.ToString("yyyy-MM-dd")
        PreviewLaporanPembayaranBunga.ShowDialog()
    End Sub
End Class