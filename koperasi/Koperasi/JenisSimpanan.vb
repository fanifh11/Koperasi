Public Class JenisSimpanan
    Dim metode As String = ""
    Dim tempjenissimpanan As String = ""


    Sub bukaForm()
        group_data_jenis.Enabled = True
        group_cari_data_jenis.Enabled = False
        grupBtn.Enabled = False
    End Sub

    Sub kunciForm()
        group_data_jenis.Enabled = False
        group_cari_data_jenis.Enabled = True
        grupBtn.Enabled = True
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub JenisSimpanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kunciForm()
        showData()
    End Sub
    Sub showData()
        dgv_cari_data_jenis.DataSource = getData("select jenissimpanan, ketjenis, bunga, kategori, besarsimpanan from tbljenis where kategori ilike '%" & txt_search.Text & "%' OR jenissimpanan ilike '%" & txt_search.Text & "%' ")
        dgv_cari_data_jenis.Columns(0).HeaderText = "Jenis Simpanan"
        dgv_cari_data_jenis.Columns(1).HeaderText = "Kode Simpanan"
        dgv_cari_data_jenis.Columns(2).HeaderText = "Bunga"
        dgv_cari_data_jenis.Columns(3).HeaderText = "Kategori"
        dgv_cari_data_jenis.Columns(4).HeaderText = "Besar Simpanan"

        dgv_cari_data_jenis.Columns(4).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_cari_data_jenis.Rows.Count

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        bukaForm()
        clearForm(group_data_jenis)
        metode = "insert"
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If Modul.adaKosong(group_data_jenis) Then
            dialogError("Isi dulu formnya!")
        Else
            Dim jenissimpanan As String = txt_nama_simpanan.Text
            Dim ketjenis As String = txt_kode_simpanan.Text
            Dim bunga As String = txt_bunga.Text
            Dim kategori As String = cmb_kategori.Text
            Dim besarsimpanan As String = unnumberFormat(txt_besar_simpanan.Text)

            Dim replacedot = bunga.Replace(",", ".")


            If metode = "insert" Then
                If txt_bunga.Text > 100 Then
                    dialogError("Bunga anda berlebihan ! Harap cek kembali dan diganti")
                    Return
                Else
                    If getCount("select jenissimpanan from tbljenis where jenissimpanan = '" & jenissimpanan & "'") = 0 Then
                        exc("insert into tbljenis
                    (
                        jenissimpanan,
                        ketjenis,
                        bunga,
                        kategori,
                        besarsimpanan
                    )
                    values
                    (
                        '" & jenissimpanan & "',
                        '" & ketjenis & "',
                        '" & replacedot & "',
                        '" & kategori & "',
                        '" & besarsimpanan & "'
                     )")
                    Else
                        dialogError("Data sudah ada!")
                        Return
                    End If
                End If
            Else
                If getCount("select jenissimpanan from tbljenis where (jenissimpanan = '" & jenissimpanan & "') and jenissimpanan != '" & tempjenissimpanan & "'") = 0 Then
                    exc("update tbljenis set 
                        jenissimpanan = '" & jenissimpanan & "',
                        ketjenis = '" & ketjenis & "',
                        bunga = '" & replacedot & "',
                        kategori = '" & kategori & "',
                        besarsimpanan = '" & besarsimpanan & "'

                        where jenissimpanan = '" & tempjenissimpanan & "'
                        ")
                Else
                    dialogError("Data sudah ada!")
                    Return
                End If
            End If
            showData()
            kunciForm()
            clearForm(group_data_jenis)
        End If
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click

        If adaKosong(group_data_jenis) Then
            dialogError("Silahkan pilih data jenis simpanan terlebih dahulu !")
            Return
        Else
            bukaForm()
            metode = "update"
        End If

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        kunciForm()
        clearForm(group_data_jenis)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If adaKosong(group_data_jenis) Then
            dialogError("Harap pilih data yang ingin dihapus terlebih dahulu !")
            Return
        Else
            If dialog("Apakah anda yakin untuk hapus data ini ?") Then
                If getCount("select jenissimpanan from tblrekening where jenissimpanan = '" & tempjenissimpanan & "' ") > 0 Or
                       getCount("select ketsukarela from tblsukarela where ketsukarela = '" & tempjenissimpanan & "' ") > 0 Then
                    dialogError("Data jenis simpanan tidak dapat dihapus karena memiliki transaksi !")
                    Return
                Else
                    If exc("delete from tbljenis where jenissimpanan = '" & tempjenissimpanan & "'") Then
                        dialogInfo("Hapus Berhasil !")
                    Else
                        dialogError("Hapus Gagal !")
                        Return
                    End If
                End If
            End If
            showData()
        End If



    End Sub

    Private Sub txt_besar_simpanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_besar_simpanan.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_bunga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bunga.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub dgv_cari_data_jenis_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cari_data_jenis.CellClick
        If (e.RowIndex >= 0) Then
            txt_nama_simpanan.Text = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(0).Value
            txt_kode_simpanan.Text = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(1).Value
            txt_bunga.Text = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(2).Value
            cmb_kategori.Text = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(3).Value
            txt_besar_simpanan.Text = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(4).Value
            tempjenissimpanan = dgv_cari_data_jenis.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    Private Sub cmb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_kategori.SelectedIndexChanged
        PergantianKategoriSimpanan()
    End Sub

    Sub PergantianKategoriSimpanan()
        If cmb_kategori.SelectedIndex = 0 Then
            txt_bunga.Enabled = True
            txt_besar_simpanan.Text = "0"
            txt_besar_simpanan.Enabled = False
        Else
            txt_besar_simpanan.Enabled = True
            txt_bunga.Text = "0"
            txt_bunga.Enabled = False
        End If
    End Sub



    Dim checkJual2 As Boolean = True
    Private Sub TBJual2_TextChanged(sender As Object, e As EventArgs) Handles txt_besar_simpanan.TextChanged
        Try
            If checkJual2 Then
                checkJual2 = False
                sender.Text = numberFormat(unnumberFormat(sender.Text))
                sender.SelectionStart = Len(sender.text)
                sender.SelectionLength = 0
                checkJual2 = True
            End If
        Catch ex As Exception
            checkJual2 = True
        End Try

    End Sub
End Class
