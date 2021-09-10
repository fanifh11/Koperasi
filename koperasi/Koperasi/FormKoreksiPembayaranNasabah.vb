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

            If txtbayarPokok > bayarPokok Then
                dialogError("Uang pembayaran pokok yang anda ingputkan kelebihan!")
                Return

            ElseIf txtbayarBunga > bayarBunga Then
                dialogError("Uang pembayaran bunga yang anda inputkan kelebihan!")
                Return

            Else
                exc("update tbltagihan set
                    tglbayar = '" & tglBayar & "',
                    besarpokok = '" & txtbayarPokok & "',
                    besarbunga = '" & txtbayarBunga & "'

                    where idtagihan = '" & idtagihan & "'")

                exc("update tbltagihan set
                    besarbayar = besarpokok + besarbunga
                    where idtagihan = '" & idtagihan & "' ")

                exc("update tblpinjam set 
                    bayarbunga = (select sum(tbltagihan.besarbunga) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam),
                    bayarpokok = (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)

                    where idpinjam = '" & idpinjam & "'
                   
                   ")

                exc("update tblpinjam set saldopinjam = besarpinjam - (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)")

                dialogInfo("Edit data sukses !")
            End If
        End If


        clearForm(group_InformasiNasabah)
        clearForm(group_InformasiPinjaman)
        clearForm(group_InformasiPeminjaman)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        clearForm(group_InformasiNasabah)
        clearForm(group_InformasiPeminjaman)
        clearForm(group_InformasiPinjaman)
    End Sub
End Class