Public Class FormKoreksiPembayaranNasabah
    Public idtagihan As String
    Public idpinjam As String
    Public bayarPokok As Double
    Public bayarBunga As Double

    Dim cekSeparator As Boolean = True
    Private Sub textChanged_moneySeparator(sender As Object, e As EventArgs) Handles txt_BesarPinjam.TextChanged, txt_AngsuranPokok.TextChanged, txt_AngsuranBunga.TextChanged, txt_JumAngsuran.TextChanged, txt_SdhDiByr.TextChanged, txt_SaldoPiutang.TextChanged, txt_BayarPokok.TextChanged, txt_BayarBunga.TextChanged, txt_JumBayar.TextChanged

        Try
            If cekSeparator Then
                cekSeparator = False
                sender.Text = numberFormat(unnumberFormat(sender.Text))
                sender.SelectionStart = Len(sender.text)
                sender.SelectionLength = 0
                cekSeparator = True
            End If
        Catch ex As Exception
            cekSeparator = True
        End Try

    End Sub

    Sub hitungJumlahBayar()
        Dim bayarPokok = toDouble(unnumberFormat(txt_BayarPokok.Text))
        Dim bayarBunga = toDouble(unnumberFormat(txt_BayarBunga.Text))

        txt_JumBayar.Text = numberFormat(bayarPokok + bayarBunga).ToString

    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_Cari_Click(sender As Object, e As EventArgs) Handles btn_Cari.Click
        FormCariAnggota.menu = "Koreksi Pembayaran Nasabah"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()

    End Sub

    Private Sub FormKoreksiPembayaranNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_BayarPokok.Enabled = True

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_BayarBunga.Enabled = True

    End Sub

    Private Sub txt_BayarPokok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BayarPokok.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_BayarBunga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BayarBunga.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_BayarPokok_TextChanged(sender As Object, e As EventArgs) Handles txt_BayarPokok.TextChanged
        hitungJumlahBayar()
    End Sub

    Private Sub txt_BayarBunga_TextChanged(sender As Object, e As EventArgs) Handles txt_BayarBunga.TextChanged
        hitungJumlahBayar()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim tglBayar As String = dtp_TglBayar.Value.ToString("G")
        Dim txtbayarPokok As Double = toDouble(unnumberFormat(txt_BayarPokok.Text))
        Dim txtbayarBunga As Double = toDouble(unnumberFormat(txt_BayarBunga.Text))

        Dim jumlahBayar As String = txt_JumBayar.Text

        If (adaKosong(group_InformasiPeminjaman)) Then
            dialogError("Lengkapi form isian Anda terlebih dahulu ! karena masih ada yang kosong")
            Return
        ElseIf (dialog("Apakah yakin untuk mengubah data ?")) Then

            If exc("DELETE FROM tbltagihan WHERE idtagihan = '" & txt_KodeTagihan.Text & "'") Then
                Debug.WriteLine("DELETE FROM tbltagihan WHERE idtagihan = '" & txt_KodeTagihan.Text & "'")
                exc("update tblpinjam set 
                    flagpinjam=0,
                    bayarbunga = (select  coalesce(sum(tbltagihan.besarbunga),0) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam),
                    bayarpokok = (select coalesce(sum(tbltagihan.besarpokok),0) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)

                    where idpinjam = '" & idpinjam & "'
                   
                    ")

                exc("update tblpinjam set saldopinjam = besarpinjam - (select coalesce(sum(tbltagihan.besarpokok),0) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)")
                clearForm(group_InformasiNasabah)
                clearForm(group_InformasiPinjaman)
                clearForm(group_InformasiPeminjaman)
                dialogInfo("Berhasil dikoreksi")
            End If

        End If




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        clearForm(group_InformasiNasabah)
        clearForm(group_InformasiPeminjaman)
        clearForm(group_InformasiPinjaman)
    End Sub
End Class