Public Class FormLihatTagihanNasabah

    Sub showData()
        dgv_data_tagihan.DataSource = getData("select idtagihan,idpinjam,idanggota,anggota,alamat,jenis,besarpinjam,lamapinjam,angsuranpokok,angsuranbunga,jumlahangsuran,cicilanke,besarbayar,saldopinjam,totalpokok - besarpokok,totalbunga - besarbunga,kodetagihan
        from qtagihan where flagtagihan = 0 and anggota ilike '%" & txt_search.Text & "%'")
        dgv_data_tagihan.Columns(0).Visible = False
        dgv_data_tagihan.Columns(1).HeaderText = "Kode Pinjam"
        dgv_data_tagihan.Columns(2).HeaderText = "Kode Anggota"
        dgv_data_tagihan.Columns(3).HeaderText = "Nama"
        dgv_data_tagihan.Columns(4).HeaderText = "Alamat"
        dgv_data_tagihan.Columns(5).HeaderText = "Jenis Pinjam"
        dgv_data_tagihan.Columns(6).HeaderText = "Besar Pinjam"
        dgv_data_tagihan.Columns(7).HeaderText = "Lama Pinjam"
        dgv_data_tagihan.Columns(8).HeaderText = "Angsuran Pokok"
        dgv_data_tagihan.Columns(9).HeaderText = "Angsuran Bunga"
        dgv_data_tagihan.Columns(10).HeaderText = "Jumlah Angsuran"
        dgv_data_tagihan.Columns(11).HeaderText = "Cicilan Ke -"
        dgv_data_tagihan.Columns(12).HeaderText = "Sudah Dibayar"
        dgv_data_tagihan.Columns(13).HeaderText = "Saldo Piutang"
        dgv_data_tagihan.Columns(14).HeaderText = "Pokok"
        dgv_data_tagihan.Columns(15).HeaderText = "Bunga"
        dgv_data_tagihan.Columns(16).HeaderText = "Kode Tagihan"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_tagihan.Rows.Count

    End Sub
    Private Sub FormLihatTagihanNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles group_data_tagihan.Enter

    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()

    End Sub

End Class