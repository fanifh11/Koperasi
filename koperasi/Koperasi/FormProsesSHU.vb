Public Class FormProsesSHU

    Public sql As String

    Sub showData()

        Dim SHU As String = txt_SHU.Text

        If toDouble(SHU) > 0 Then
            sql = "select (select anggota as jenissimpanan from tblanggota t3 where idanggota = tblrekening.idanggota), sum(besar) / (select sum(besar) from tblrekening t2  where fbayar = 1 and ketkategori != 'SALDO AWAL' ) * '" & SHU & "'  as besar from tblrekening where fbayar = 1 and ketkategori != 'SALDO AWAL' group by idanggota  "
            dgv_DataSimpanan.DataSource = getData(sql)
            dgv_DataSimpanan.Columns(0).HeaderText = "Nama Anggota"
            dgv_DataSimpanan.Columns(1).HeaderText = "Jumah SHU"

            makeFillDG(dgv_DataSimpanan)

            dgv_DataSimpanan.Columns(1).DefaultCellStyle.Format = "c0"

            lbl_JumData.Text = "Jumlah Data: " & dgv_DataSimpanan.Rows.Count

            For Each row As DataGridViewRow In dgv_DataSimpanan.Rows
                row.Cells(1).Value = Math.Round(toDouble(row.Cells(1).Value))
            Next
        End If

    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormProsesSHU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Tahun.Text = getValue("select tahun from tbltahun where flagaktif = 'AKTIF'", "tahun")
    End Sub

    Private Sub btn_Proses_Click(sender As Object, e As EventArgs) Handles btn_Proses.Click
        If String.IsNullOrEmpty(txt_SHU.Text) Then
            dialogError("Isi jumlah SHU anda terlebih dahulu")
        ElseIf txt_SHU.Text = 0 Then
            dialogError("SHU tidak boleh diisi 0")
        Else
            showData()
        End If
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        PreviewFormProsesSHU.sql = sql
        PreviewFormProsesSHU.tahun = txt_Tahun.Text
        PreviewFormProsesSHU.ShowDialog()
    End Sub

    Private Sub txt_SHU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SHU.KeyPress
        onlyNumber(e)
    End Sub
End Class