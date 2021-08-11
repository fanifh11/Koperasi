Public Class LaporanPeminjaman

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, to_char(tglpinjam, 'DD-MM-YYYY') as tglpinjam, besarpinjam, persenbunga, lamapinjam, asuransi, administrasi, diterima from qpinjam where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
        dgv_data_peminjaman.DataSource = getData(sql)
        dgv_data_peminjaman.Columns(0).HeaderText = "ID Anggota"
        dgv_data_peminjaman.Columns(1).HeaderText = "Nama Anggota"
        dgv_data_peminjaman.Columns(2).HeaderText = "ID Pinjam"
        dgv_data_peminjaman.Columns(3).HeaderText = "Tanggal Pinjam"
        dgv_data_peminjaman.Columns(4).HeaderText = "Besar Pinjam"
        dgv_data_peminjaman.Columns(5).HeaderText = "Bunga"
        dgv_data_peminjaman.Columns(6).HeaderText = "Lama Pinjam"
        dgv_data_peminjaman.Columns(7).HeaderText = "Asuransi"
        dgv_data_peminjaman.Columns(8).HeaderText = "Administrasi"
        dgv_data_peminjaman.Columns(9).HeaderText = "Diterima"

        dgv_data_peminjaman.Columns(4).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(7).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(8).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(9).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_peminjaman.Rows.Count
        lbl_total_pinjam.Text = "Total Pinjam : " & numberFor(toDouble(getValue("select sum(besarpinjam) as besarpinjam from qpinjam where (idanggota ilike '%" & txt_search.Text & "%' or anggota ilike '%" & txt_search.Text & "%') and tglpinjam between '" & dtp_mulai.Value.ToString("yyyy-MM-dd") & "' and '" & dtp_sampai.Value.ToString("yyyy-MM-dd") & "'", "besarpinjam")).ToString)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanPeminjaman.sql = sql
        PreviewLaporanPeminjaman.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPeminjaman.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanPeminjaman.ShowDialog()
    End Sub
End Class