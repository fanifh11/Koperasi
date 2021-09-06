Public Class FormLihatTagihan

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Public sql As String

    Sub showData()
        If cmb_Pilihan.SelectedIndex = 0 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek,norek from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'POKOK'"
            dgv_Data.DataSource = getData(sql)
            dgv_Data.Columns(0).HeaderText = "ID Anggota"
            dgv_Data.Columns(1).HeaderText = "Nama Anggota"
            dgv_Data.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            dgv_Data.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_Data.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_JumData.Text = "Jumlah Data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 1 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek,norek from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'WAJIB'"
            dgv_Data.DataSource = getData(sql)
            dgv_Data.Columns(0).HeaderText = "ID Anggota"
            dgv_Data.Columns(1).HeaderText = "Nama Anggota"
            dgv_Data.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            dgv_Data.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_Data.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_JumData.Text = "Jumlah Data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 2 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek,norek from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'SALDO AWAL'"
            dgv_Data.DataSource = getData(sql)
            dgv_Data.Columns(0).HeaderText = "ID Anggota"
            dgv_Data.Columns(1).HeaderText = "Nama Anggota"
            dgv_Data.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            dgv_Data.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_Data.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_JumData.Text = "Jumlah Data : " & dgv_Data.Rows.Count
        End If
        dgv_Data.Columns(7).Visible = False
    End Sub
    Private Sub FormLihatTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Pilihan.SelectedIndex = 0
        showData()
    End Sub

    Private Sub cmb_Pilihan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pilihan.SelectedIndexChanged
        showData()
    End Sub

    Private Sub txt_Cari_TextChanged(sender As Object, e As EventArgs) Handles txt_Cari.TextChanged
        showData()
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        PreviewFormLihatTagihan.sql = sql
        PreviewFormLihatTagihan.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        deleteTagihan()
    End Sub


    Sub deleteTagihan()
        If Not dgv_Data.SelectedCells.Count = 1 Then
            dialogError("Harap pilih tagihan yang akan dihapus")
            Return
        End If
        If dialog("Apakah anda yakin untuk menghapus tagihan ini ?") Then
            Dim norek = dgv_Data.Rows(dgv_Data.SelectedCells(0).RowIndex).Cells(7).Value
            exc($"DELETE FROM tblrekening WHERE norek='{norek}'")
            showData()
        End If
    End Sub
End Class