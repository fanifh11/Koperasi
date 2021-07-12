Public Class FormPembayaranNasabah

    Public idtagihan As String
    Public idpinjam As String = "0"
    Public idnasabah As String


    Sub firstTimeLoad()
        grupBtn.Enabled = True
        group_informasi_nasabah.Enabled = False
        group_informasi_peminjaman.Enabled = False
        group_pembayaran_pinjaman.Enabled = False

    End Sub

    Sub formLoad()
        grupBtn.Enabled = False
        group_informasi_nasabah.Enabled = True
        group_informasi_peminjaman.Enabled = True
        group_pembayaran_pinjaman.Enabled = True

    End Sub

    Sub jumlahBayar()
        Dim bayarPokok As Double = toDouble(txt_biaya_pokok.Text)
        Dim bayarBunga As Double = toDouble(txt_bayar_bunga.Text)

        txt_jumlah_bayar.Text = (bayarPokok + bayarBunga).ToString
    End Sub

    Sub showData()
        dgv_data_peminjaman.DataSource = getData("select idpinjam,anggota,cicilanke,besarbayar,besarpokok,besarbunga from qtagihan where idpinjam='" & idpinjam & "' and CAST(cicilanke as varchar) ilike '%" & txt_search.Text & "%' order by cicilanke asc ")
        dgv_data_peminjaman.Columns(0).HeaderText = "Kode Pinjam"
        dgv_data_peminjaman.Columns(1).HeaderText = "Nama"
        dgv_data_peminjaman.Columns(2).HeaderText = "Cicilan Ke-"
        dgv_data_peminjaman.Columns(3).HeaderText = "Total Bayar"
        dgv_data_peminjaman.Columns(4).HeaderText = "Bayar Pokok"
        dgv_data_peminjaman.Columns(5).HeaderText = "Bayar Bunga"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_peminjaman.Rows.Count


    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub

    Private Sub FormPembayaranNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstTimeLoad()
        showData()

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        formLoad()

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        firstTimeLoad()


    End Sub

    Sub kurangBayarPokok()
        Dim angsuranPokok = toDouble(txt_angsuran_pokok.Text)
        Dim biayaPokok = toDouble(txt_biaya_pokok.Text)

        txt_biaya_pokok.Text = (angsuranPokok - biayaPokok).ToString

    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        FormCariAnggota.menu = "Pembayaran Nasabah"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()
        showData()

    End Sub

    Private Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        txt_biaya_pokok.ReadOnly = False
    End Sub

    Private Sub btn_manual2_Click(sender As Object, e As EventArgs) Handles btn_manual2.Click
        txt_bayar_bunga.ReadOnly = False
    End Sub

    Private Sub txt_biaya_pokok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_biaya_pokok.KeyPress, txt_bayar_bunga.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_biaya_pokok_TextChanged(sender As Object, e As EventArgs) Handles txt_biaya_pokok.TextChanged
        jumlahBayar()

    End Sub

    Private Sub txt_bayar_bunga_TextChanged(sender As Object, e As EventArgs) Handles txt_bayar_bunga.TextChanged
        jumlahBayar()

    End Sub

    Public bayarPokok As Double
    Public bayarBunga As Double

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim tglBayar As String = dtp_tanggal_bayar.Value.ToString("G")
        Dim txtbayarPokok As Double = toDouble(txt_biaya_pokok.Text)
        Dim txtbayarBunga As Double = toDouble(txt_bayar_bunga.Text)
        Dim jumlahBayar As String = txt_jumlah_bayar.Text


        If adaKosong(group_pembayaran_pinjaman) Then
            dialogError("Harap lengkapi form isian anda!")
            Return
        ElseIf dialog("Apakah yakin untuk melakukan pembayaran !") Then
            If txtbayarPokok > bayarPokok Then
                dialogError("Uang bayar pokok kelebihan")
                Return
            ElseIf txtbayarBunga > bayarBunga Then
                dialogError("Uang bayar bunga kelebihan")
                Return
            Else
                exc("update tbltagihan set
                    tglbayar = '" & tglBayar & "',
                    besarpokok = besarpokok + " & txtbayarPokok & ",
                    besarbunga = besarbunga + " & txtbayarBunga & "

                    where idtagihan = '" & idtagihan & "'
                    ")

                exc("update tbltagihan set
                    besarbayar = besarpokok + besarbunga
                    where idtagihan = '" & idtagihan & "'

                    ")

                exc("update tblpinjam set 
                    bayarbunga = (select sum(tbltagihan.besarbunga) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam),
                    bayarpokok = (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)

                    where idpinjam = '" & idpinjam & "'
                   
                    ")

                exc("update tblpinjam set saldopinjam = besarpinjam - (select sum(tbltagihan.besarpokok) from tbltagihan where tbltagihan.idpinjam = tblpinjam.idpinjam)")
            End If
            dialogInfo("Bayar Sukses !")

        End If
        clearForm(group_data_peminjaman)
        clearForm(group_informasi_peminjaman)
        clearForm(group_pembayaran_pinjaman)
        clearForm(group_informasi_nasabah)
        showData()



    End Sub

    Private Sub txt_angsuran_pokok_TextChanged(sender As Object, e As EventArgs) Handles txt_angsuran_pokok.TextChanged
        kurangBayarPokok()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()

    End Sub
End Class