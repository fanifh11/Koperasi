Public Class FormDataTahun
    Dim metode As String = ""
    Dim idtahun As String = ""
    Sub startState()
        group_DataThn.Enabled = True
        grupBtn.Enabled = True
        grupInformasiTahun.Enabled = False
    End Sub
    Sub openForm()
        group_DataThn.Enabled = False
        grupInformasiTahun.Enabled = True
        grupBtn.Enabled = False
    End Sub
    Sub lockForm()
        group_DataThn.Enabled = True
        grupInformasiTahun.Enabled = False
        grupBtn.Enabled = True
        clearForm(grupInformasiTahun)
    End Sub
    Sub showData()
        dgv_DataTahun.DataSource = getData("select tahun,flagaktif from tbltahun where flagaktif ilike '%" & txt_CariDataThn.Text & "%' OR tahun like '%" & txt_CariDataThn.Text & "%'")
        dgv_DataTahun.Columns(0).HeaderText = "Tahun"
        dgv_DataTahun.Columns(1).HeaderText = "Status"

        lbl_Keterangan.Text = "Tahun Aktif : " & getValue("select tahun from tbltahun where flagaktif = 'AKTIF' ", "tahun")

        makeFillDG(dgv_DataTahun)
        lbl_JumData.Text = "Jumlah Data Tahun : " & dgv_DataTahun.Rows.Count
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        openForm()
        clearForm(grupInformasiTahun)
        metode = "insert"
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lockForm()
        clearForm(grupInformasiTahun)
    End Sub

    Private Sub FormDataTahun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startState()
        showData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Modul.adaKosong(grupInformasiTahun) Then
            dialogError("isi dulu formnya")
        Else
            Dim tahun As String = txt_Tahun.Text
            Dim status As String = cmb_StatusAktif.Text

            If cmb_StatusAktif.SelectedIndex = 0 Then
                exc("update tbltahun set flagaktif = 'NON AKTIF'")
            End If

            If metode = "insert" Then
                If getCount("select tahun from tbltahun where tahun = '" & tahun & "'") = 0 Then
                    exc("insert into tbltahun (tahun,flagaktif) values ('" & tahun & "','" & status & "')")
                Else
                    dialogError("Ada duplikasi tahun!")
                    Return
                End If

            Else
                If getCount("select tahun from tbltahun where tahun = '" & tahun & "' and tahun != '" & idtahun & "' ") = 0 Then
                    exc("update tbltahun set tahun = '" & tahun & "',flagaktif = '" & status & "' where tahun = '" & idtahun & "'")
                Else
                    dialogError("Ada duplikasi tahun!")
                    Return
                End If
            End If
            showData()
            lockForm()
        End If

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(txt_Tahun.Text) Then
            dialogError("Pilih data tahun terlebih dahulu dengan cara mengklik salah satu data tahun di tabel hingga muncul di form!")
        Else
            openForm()
            metode = "update"
        End If

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txt_CariDataThn_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataThn.TextChanged
        showData()
    End Sub

    Private Sub dgv_DataTahun_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataTahun.CellClick

        If (e.RowIndex >= 0) Then
            idtahun = dgv_DataTahun.Rows(e.RowIndex).Cells(0).Value

            txt_Tahun.Text = dgv_DataTahun.Rows(e.RowIndex).Cells(0).Value
            If dgv_DataTahun.Rows(e.RowIndex).Cells(1).Value = "AKTIF" Then
                cmb_StatusAktif.SelectedIndex = 0
            Else
                cmb_StatusAktif.SelectedIndex = 1
            End If
        End If


    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(txt_Tahun.Text) Then
            dialogError("Silahkan pilih tahun terlebih dahulu")
        Else
            If dialog("Apakah anda yakin untuk hapus data ini ?") Then
                If getCount("select tahun from tbltahun where flagaktif = AKTIF ") > 0 Or getCount("select tahun from tblrekening where tahun = '" & idtahun & "' ") > 0 Then
                    dialogError("Tahun aktif tidak dapat dihapus karena tahun aktif atau mempunyai transaksi !")
                    Return
                Else
                    If exc("delete from tbltahun where tahun = '" & idtahun & "' ") Then
                        dialogInfo("Data tahun berhasil terhapus!")
                    Else
                        dialogError("Data gagal dihapus !")
                        Return
                    End If
                    showData()
                End If
            End If
        End If





    End Sub

    Private Sub txt_Tahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Tahun.KeyPress
        onlyNumber(e)
    End Sub
End Class