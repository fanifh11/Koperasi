Public Class FormCetakBukuSimpSukarela
    Public idsukarela As String = ""
    Public saldoAsli As Double
    Public idanggota As String

    Sub showData()

        dgv_DataAnggota.DataSource = getData("select to_char(tgltransaksi, 'DD-MM-YYYY') as tgltransaksi,fakturtransaksi,kettransaksi,debet,kredit,saldo 
        from qtransaksi inner join qsukarela on qtransaksi.idsukarela = qsukarela.idsukarela
        where qsukarela.idsukarela = " & idsukarela & " order by tgltransaksi desc ")

        lbl_JumData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count
    End Sub

    Public Sub getSaldoAndCetak()
        Dim sql As String =
            "select
                (select tbltransaksi.nocetak from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1),
                (select tbltransaksi.saldo from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1) saldo         
            "

        Dim saldo As String = getValue(sql, "saldo")
        Dim maxcetak As String = getValue(sql, "nocetak")

        lbl_NominalUang.Text = numberFor(saldo)

        saldo = saldoAsli
        txt_maxCetak.Text = maxcetak
    End Sub

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormCetakBukuSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub btn_CariAnggota_Click(sender As Object, e As EventArgs) Handles btn_CariAnggota.Click
        FormCariAnggota.menu = "Cetak buku simp sukarela"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_noCetak.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_noCetak_TextChanged(sender As Object, e As EventArgs) Handles txt_noCetak.TextChanged
        If txt_noCetak.Text = "0" Or txt_noCetak.Text > txt_maxCetak.Text Then
            dialogError("Tidak boleh 0 atau lebih dari max cetak!")
        End If
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click

        If String.IsNullOrEmpty(txt_KodeAnggota.Text) Then
            dialogError("Harap pilih data nasabah terlebih dahulu !")
            Return
        ElseIf String.IsNullOrEmpty(txt_noCetak.Text) Then
            dialogError("Isi nomor cetak terlebih dahulu !")
            Return
        Else
            If Double.Parse(txt_maxCetak.Text) < Double.Parse(txt_noCetak.Text) Then
                dialogError("No cetak tidak boleh lebih dari max cetak!")
                Return
            End If
            PreviewCetakBuku.idsukarela = idsukarela
            PreviewCetakBuku.nocetak = txt_noCetak.Text
            PreviewCetakBuku.ShowDialog()
        End If

    End Sub
End Class