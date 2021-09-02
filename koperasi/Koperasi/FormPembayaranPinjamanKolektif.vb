Public Class FormPembayaranPinjamanKolektif

    Sub showData()

        dgv_data_tagihan.DataSource = getData("select idtagihan,idpinjam,idanggota,anggota,jk,besarpinjam,totalpokok,totalbunga,totalangsur from qtagihan where anggota ilike '%" & txt_search.Text & "%' and flagtagihan = 0")
        dgv_data_tagihan.Columns(0).HeaderText = "Kode Tagihan"
        dgv_data_tagihan.Columns(1).Visible = False
        dgv_data_tagihan.Columns(2).HeaderText = "Kode Anggota"
        dgv_data_tagihan.Columns(3).HeaderText = "Nama"
        dgv_data_tagihan.Columns(4).HeaderText = "Jenis Kelamin"
        dgv_data_tagihan.Columns(5).HeaderText = "Besar Pinjam"
        dgv_data_tagihan.Columns(6).HeaderText = "Total Pokok"
        dgv_data_tagihan.Columns(7).HeaderText = "Total Bunga"
        dgv_data_tagihan.Columns(8).HeaderText = "Total Angsur"

        dgv_data_tagihan.Columns(5).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(6).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(7).DefaultCellStyle.Format = "c0"
        dgv_data_tagihan.Columns(8).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_tagihan.Rows.Count

    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub FormPembayaranPinjamanKolektif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()

    End Sub

    Private Sub btn_biaya_tagihan_kolektif_Click(sender As Object, e As EventArgs) Handles btn_biaya_tagihan_kolektif.Click
        If dgv_data_tagihan.RowCount = 0 Then
            dialogError("Data nasabah masih kosong !")
            Return

        Else
            If dialog("Apakah anda yakin melakukan pembayaran anggota secara kolektif ?") Then
                Dim idtagihan As String = "("

                For Each Row As DataGridViewRow In dgv_data_tagihan.Rows
                    idtagihan = idtagihan & " '" & Row.Cells(1).Value & "',"
                Next

                idtagihan = Strings.Left(idtagihan, idtagihan.Length - 1)

                idtagihan = idtagihan & ")"


                exc("update tbltagihan set
                    besarbayar = totalangsur,
                    besarpokok = totalpokok,
                    besarbunga = totalbunga,
                    tglbayar = now(),
                    flagtagihan = 1  
                    
                    where flagtagihan = 0 
         ")


                exc("update tblpinjam set 
                    bayarbunga = (select sum(tbltagihan.besarbunga) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam),
                    bayarpokok = (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)

                where idpinjam in " & idtagihan & "           
        ")

                exc("update tblpinjam set saldopinjam = besarpinjam - (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam) where idpinjam in " & idtagihan & " ")
            End If
        End If
        dialogInfo("Pembayaran kolektif sukses !")
        showData()


    End Sub
End Class