Public Class FormLihatTagihanNasabah

    Dim selectID As String
    Dim IDterpilih As String

    Sub kondisiBtnCetak()
        If String.IsNullOrEmpty(selectID) Then
            btn_cetak.Enabled = False
        Else
            btn_cetak.Enabled = True

        End If
    End Sub

    Sub showData()
        dgv_data_tagihan.DataSource = getData("select idtagihan,qtagihan.idpinjam,idanggota,anggota,alamat,jenis,besarpinjam,lamapinjam,angsuranpokok,angsuranbunga,jumlahangsuran,qtagihan.cicilanke,besarbayar,saldopinjam,totalpokok - besarpokok,totalbunga - besarbunga,kodetagihan
        from qtagihan 
        inner join (select min(cicilanke) as cicilanke,idpinjam from tbltagihan where flagtagihan=0 group by idpinjam) t 
        on t.idpinjam = qtagihan.idpinjam and t.cicilanke = qtagihan.cicilanke
        where anggota ilike '%" & txt_search.Text & "%'")
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


        dgv_data_tagihan.Columns(6).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(8).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(9).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(10).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(13).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(14).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(15).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_tagihan.Rows.Count

    End Sub
    Private Sub FormLihatTagihanNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        kondisiBtnCetak()

    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()

    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanTagihan.ShowDialog()
    End Sub

    Private Sub dgv_data_tagihan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_tagihan.CellClick
        If (e.RowIndex >= 0) Then
            selectID = dgv_data_tagihan.Rows(e.RowIndex).Cells(0).Value
            IDterpilih = selectID

            kondisiBtnCetak()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        deleteTagihan()
    End Sub

    Sub deleteTagihan()
        If Not dgv_data_tagihan.SelectedCells.Count = 1 Then
            dialogError("Harap pilih tagihan yang akan dihapus")
            Return
        End If
        If dialog("Apakah anda yakin untuk menghapus tagihan ini ?") Then
            Dim norek = dgv_data_tagihan.Rows(dgv_data_tagihan.SelectedCells(0).RowIndex).Cells(0).Value
            exc($"DELETE FROM tbltagihan WHERE idtagihan='{norek}'")
            showData()
        End If
    End Sub
End Class