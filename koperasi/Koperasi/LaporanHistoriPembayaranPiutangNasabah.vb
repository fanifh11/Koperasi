Public Class LaporanHistoriPembayaranPiutangNasabah
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanHistoriPembayaranPiutangNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_status_pembayaran.SelectedIndex = 0
        showData()
    End Sub

    Public sql As String

    Sub showData()
        If cmb_status_pembayaran.SelectedIndex = 0 Then
            sql = "select idanggota, anggota, idpinjam, besarbayar, besarpokok, besarbunga, totalangsur, totalpokok, totalbunga,TglBayar,BesarPinjam,SaldoPinjam,cicilanKe from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam > 0 and tglbayar is not null"
            dgv_data_pembayaran.DataSource = getData(sql)
            dgv_data_pembayaran.Columns(0).HeaderText = "ID Anggota"
            dgv_data_pembayaran.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_pembayaran.Columns(2).HeaderText = "ID Pinjam"
            dgv_data_pembayaran.Columns(3).HeaderText = "Besar Bayar"
            dgv_data_pembayaran.Columns(4).HeaderText = "Besar Pokok"
            dgv_data_pembayaran.Columns(5).HeaderText = "Besar Bunga"
            dgv_data_pembayaran.Columns(6).HeaderText = "Total Angsur"
            dgv_data_pembayaran.Columns(7).HeaderText = "Total Pokok"
            dgv_data_pembayaran.Columns(8).HeaderText = "Total Bunga"

            dgv_data_pembayaran.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(4).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(5).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(6).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(7).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(8).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data " & dgv_data_pembayaran.Rows.Count
            lbl_bayar.Text = "Bayar : " & numberFor(toDouble(getValue("select sum(totalangsur) as totalangsur from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam > 0", "totalangsur")).ToString) & " Pokok : " & numberFor(toDouble(getValue("select sum(totalpokok) as totalpokok from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam > 0", "totalpokok")).ToString) & " Bunga : " & numberFor(toDouble(getValue("select sum(totalbunga) as totalbunga from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam > 0", "totalbunga")).ToString)
        ElseIf cmb_status_pembayaran.SelectedIndex = 1 Then
            sql = "select idanggota, anggota, idpinjam, besarbayar, besarpokok, besarbunga, totalangsur, totalpokok, totalbunga,TglBayar,BesarPinjam,SaldoPinjam,cicilanKe from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam = 0 and tglbayar is not null"
            dgv_data_pembayaran.DataSource = getData(sql)
            dgv_data_pembayaran.Columns(0).HeaderText = "ID Anggota"
            dgv_data_pembayaran.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_pembayaran.Columns(2).HeaderText = "ID Pinjam"
            dgv_data_pembayaran.Columns(3).HeaderText = "Besar Bayar"
            dgv_data_pembayaran.Columns(4).HeaderText = "Besar Pokok"
            dgv_data_pembayaran.Columns(5).HeaderText = "Besar Bunga"
            dgv_data_pembayaran.Columns(6).HeaderText = "Total Angsur"
            dgv_data_pembayaran.Columns(7).HeaderText = "Total Pokok"
            dgv_data_pembayaran.Columns(8).HeaderText = "Total Bunga"

            dgv_data_pembayaran.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(4).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(5).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(6).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(7).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(8).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data " & dgv_data_pembayaran.Rows.Count
            lbl_bayar.Text = "Bayar : " & numberFor(toDouble(getValue("select sum(totalangsur) as totalangsur from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam <= 0", "totalangsur")).ToString) & " Pokok : " & numberFor(toDouble(getValue("select sum(totalpokok) as totalpokok from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam <= 0", "totalpokok")).ToString) & " Bunga : " & numberFor(toDouble(getValue("select sum(totalbunga) as totalbunga from qtagihan where anggota ilike '%" & txt_search.Text & "%' and saldopinjam <= 0", "totalbunga")).ToString)
        ElseIf cmb_status_pembayaran.SelectedIndex = 2 Then
            sql = "select idanggota, anggota, idpinjam, besarbayar, besarpokok, besarbunga, totalangsur, totalpokok, totalbunga,TglBayar,BesarPinjam,SaldoPinjam,cicilanKe from qtagihan where anggota ilike '%" & txt_search.Text & "%' and tglbayar is not null"
            dgv_data_pembayaran.DataSource = getData(sql)
            dgv_data_pembayaran.Columns(0).HeaderText = "ID Anggota"
            dgv_data_pembayaran.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_pembayaran.Columns(2).HeaderText = "ID Pinjam"
            dgv_data_pembayaran.Columns(3).HeaderText = "Besar Bayar"
            dgv_data_pembayaran.Columns(4).HeaderText = "Besar Pokok"
            dgv_data_pembayaran.Columns(5).HeaderText = "Besar Bunga"
            dgv_data_pembayaran.Columns(6).HeaderText = "Total Angsur"
            dgv_data_pembayaran.Columns(7).HeaderText = "Total Pokok"
            dgv_data_pembayaran.Columns(8).HeaderText = "Total Bunga"

            dgv_data_pembayaran.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(4).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(5).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(6).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(7).DefaultCellStyle.Format = "c0"
            dgv_data_pembayaran.Columns(8).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data " & dgv_data_pembayaran.Rows.Count
            lbl_bayar.Text = "Bayar : " & numberFor(toDouble(getValue("select sum(totalangsur) as totalangsur from qtagihan where anggota ilike '%" & txt_search.Text & "%'", "totalangsur")).ToString) & " Pokok : " & numberFor(toDouble(getValue("select sum(totalpokok) as totalpokok from qtagihan where anggota ilike '%" & txt_search.Text & "%'", "totalpokok")).ToString) & " Bunga : " & numberFor(toDouble(getValue("select sum(totalbunga) as totalbunga from qtagihan where anggota ilike '%" & txt_search.Text & "%'", "totalbunga")).ToString)
        End If
        dgv_data_pembayaran.Columns(9).Visible = False
        dgv_data_pembayaran.Columns(10).Visible = False
        dgv_data_pembayaran.Columns(11).Visible = False
        dgv_data_pembayaran.Columns(12).Visible = False
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanHistoryPembayaranPiutangNasabah.sql = sql
        PreviewLaporanHistoryPembayaranPiutangNasabah.ShowDialog()
    End Sub
End Class