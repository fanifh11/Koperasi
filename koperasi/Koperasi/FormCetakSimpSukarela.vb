Public Class FormCetakSimpSukarela
    Public idsukarela As String = "0"
    Public saldoAsli As Double

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_CariAnggota_Click(sender As Object, e As EventArgs) Handles btn_CariAnggota.Click
        FormCariAnggota.menu = "Form cetak buku simp sukarela"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()
    End Sub

    Private Sub FormCetakSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public Sub showData()
        dgv_DataAnggota.DataSource = getData("Select idsukarela, to_char(tgltransaksi, 'DD-MM-YYYY') as tgltransaksi, debet, kredit, saldo from tbltransaksi where idsukarela = '" & idsukarela & "'")
        dgv_DataAnggota.Columns(0).HeaderText = "No Rek"
        dgv_DataAnggota.Columns(1).HeaderText = "Tanggal Transaksi"
        dgv_DataAnggota.Columns(2).HeaderText = "Debet"
        dgv_DataAnggota.Columns(3).HeaderText = "Kredit"
        dgv_DataAnggota.Columns(4).HeaderText = "Saldo"

        dgv_DataAnggota.Columns(2).DefaultCellStyle.Format = "c0"
        dgv_DataAnggota.Columns(3).DefaultCellStyle.Format = "c0"
        dgv_DataAnggota.Columns(4).DefaultCellStyle.Format = "c0"

        lbl_JumlahData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count
    End Sub

    Sub getSaldo()
        Dim sql As String =
            "select
                (select tbltransaksi.saldo from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1) saldo
            "

        Dim saldo As String = getValue(sql, "saldo")

        lbl_NominalUang.Text = numberFor(saldo)
        saldo = saldoAsli
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        If adaKosong(group_InformasiAnggota) Then
            dialogError("Pilih data anggota terlebih dahulu !")
        Else
            PreviewSimpSukarela.idsukarela = idsukarela
            PreviewSimpSukarela.ShowDialog()
        End If

    End Sub
End Class