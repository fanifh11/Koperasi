Public Class FormPembayaranSimpKolektif
    Sub showData()
        dgv_DataAnggota.DataSource = getData("select norek,idanggota,anggota,jenissimpanan,ketsimp,tglrek,besar from qrekening where fbayar = 0 and (anggota ilike '%" & txt_CariDataAnggota.Text & "%' )")
        dgv_DataAnggota.Columns(0).Visible = False
        dgv_DataAnggota.Columns(1).HeaderText = "N/A"
        dgv_DataAnggota.Columns(2).HeaderText = "Anggota"
        dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpanan"
        dgv_DataAnggota.Columns(4).HeaderText = "Keterangan"
        dgv_DataAnggota.Columns(5).HeaderText = "Tgl Tagihan"
        dgv_DataAnggota.Columns(6).HeaderText = "Besar"

        dgv_DataAnggota.Columns(6).DefaultCellStyle.Format = "c0"

        makeFillDG(dgv_DataAnggota)
        lbl_JumData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count


    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormPembayaranSimpKolektif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()

    End Sub

    Private Sub txt_CariDataAnggota_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota.TextChanged
        showData()

    End Sub

    Private Sub btn_PembayaranKolektif_Click(sender As Object, e As EventArgs) Handles btn_PembayaranKolektif.Click
        If dgv_DataAnggota.Rows.Count = 0 Then
            dialogError("Data nasabah kosong !")
            Return
        ElseIf dgv_DataAnggota.Rows.Count = 1 Then
            dialogError("Harus lebih dari satu nasabah jika ingin melakukan pembayaran secara kolektif !")
            Return
        ElseIf dgv_DataAnggota.Rows.Count > 1 Then
            If dialog("Apakah yakin melakukan proses pembayaran kolektif ?") Then
                exc("update tblrekening set
                fbayar = 1, 
                tglbayar = now()

                where fbayar = 0
                ")
                dialogInfo("Pembayaran secara kolektif berhasil !")
                showData()
            End If
        End If



    End Sub
End Class