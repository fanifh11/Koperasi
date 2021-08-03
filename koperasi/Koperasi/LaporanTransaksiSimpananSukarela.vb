Public Class LaporanTransaksiSimpananSukarela
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanTransaksiSimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_setoran.SelectedIndex = 0
        showData()
    End Sub

    Public sql As String

    Sub showData()
        If cmb_setoran.SelectedIndex = 0 Then
            sql = "select idanggota, anggota, jk, kettransaksi, debet, kredit from qtransaksi where anggota ilike '%" & txt_search.Text & "%' and tgltransaksi between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "' and kredit > 0"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_data_simpanan.Columns(3).HeaderText = "Keterangan Transaksi"
            dgv_data_simpanan.Columns(4).HeaderText = "Debet"
            dgv_data_simpanan.Columns(5).HeaderText = "Kredit"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        ElseIf cmb_setoran.SelectedIndex = 1 Then

            sql = "select idanggota, anggota, jk, kettransaksi, debet, kredit from qtransaksi where anggota ilike '%" & txt_search.Text & "%' and tgltransaksi between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "' and debet > 0"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_data_simpanan.Columns(3).HeaderText = "Keterangan Transaksi"
            dgv_data_simpanan.Columns(4).HeaderText = "Debet"
            dgv_data_simpanan.Columns(5).HeaderText = "Kredit"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanTransaksiSimpananSukarela.sql = sql
        PreviewLaporanTransaksiSimpananSukarela.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanTransaksiSimpananSukarela.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanTransaksiSimpananSukarela.ShowDialog()
    End Sub
End Class