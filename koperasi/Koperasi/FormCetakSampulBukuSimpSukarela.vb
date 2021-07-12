Public Class FormCetakSampulBukuSimpSukarela
    Dim idsukarela As String = ""

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormCetakSampulBukuSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub dgv_DataAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota.CellClick
        If (e.RowIndex >= 0) Then
            idsukarela = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value
        End If

    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        PreviewCetakSampul.idsukarela = dgv_DataAnggota.Rows(dgv_DataAnggota.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewCetakSampul.ShowDialog()
    End Sub

    Sub showData()
        dgv_DataAnggota.DataSource = getData("select idsukarela, ketsukarela,idanggota, anggota, jk  from qsukarela where idanggota ilike '%" & txt_CariDataAnggota.Text & "%' OR anggota ilike '%" & txt_CariDataAnggota.Text & "%'")
        dgv_DataAnggota.Columns(0).Visible = False
        dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
        dgv_DataAnggota.Columns(2).HeaderText = "Keterangan"
        dgv_DataAnggota.Columns(3).HeaderText = "Nama Anggota"
        dgv_DataAnggota.Columns(4).HeaderText = "Jenis Kelamin"

        makeFillDG(dgv_DataAnggota)
        lbl_JumData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count
    End Sub

    Private Sub txt_CariDataAnggota_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota.TextChanged
        showData()
    End Sub
End Class