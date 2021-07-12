Public Class LaporanNasabah
    Public idanggota As String = ""

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Sub showData()
        dgv_data_nasabah.DataSource = getData("select idanggota, anggota, alamat, notelp, jk, tahunmasuk from tblanggota where idanggota ilike '%" & txt_search.Text & "%' OR anggota ilike '%" & txt_search.Text & "%' ")
        dgv_data_nasabah.Columns(0).HeaderText = "ID Anggota"
        dgv_data_nasabah.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_nasabah.Columns(2).HeaderText = "Alamat"
        dgv_data_nasabah.Columns(3).HeaderText = "Telp"
        dgv_data_nasabah.Columns(4).HeaderText = "Jenis Kelamin"
        dgv_data_nasabah.Columns(5).HeaderText = "Tahun Masuk"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_nasabah.Rows.Count
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanNasabah.ShowDialog()
    End Sub
End Class