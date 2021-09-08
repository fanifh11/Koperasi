Public Class FormPembayaranNasabah

    Public idtagihan As String = ""
    Public idpinjam As String = "0"
    Public idnasabah As String


    Dim selectIDNasabah As String
    Dim dataTerpilih As String
    Dim tagihan As String


    Sub firstTimeLoad()
        btn_tambah.Enabled = True
        btn_keluar.Enabled = True
        group_informasi_nasabah.Enabled = False
        group_informasi_peminjaman.Enabled = False
        group_pembayaran_pinjaman.Enabled = False

    End Sub

    Sub formLoad()
        btn_tambah.Enabled = False
        btn_keluar.Enabled = False
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
        dgv_data_peminjaman.DataSource = getData("select idtagihan,idpinjam,idanggota,anggota,alamat,jenis,besarpinjam,lamapinjam,totalpokok,totalbunga,jumlahangsuran,cicilanke,totalangsur,saldopinjam,besarpokok,besarbunga,kodetagihan,besarbayar from qtagihan where CAST(cicilanke as varchar) ilike '%" & txt_search.Text & "%' 
        and (tglbayar between '" & Now().ToString("yyyy-MM-dd") & " 00:00' and '" & Now().ToString("yyyy-MM-dd") & " 23:59') and flagtagihan = 1 order by cicilanke asc ")
        dgv_data_peminjaman.Columns(0).Visible = False
        dgv_data_peminjaman.Columns(1).HeaderText = "Kode Pinjam"
        dgv_data_peminjaman.Columns(2).Visible = False
        dgv_data_peminjaman.Columns(3).HeaderText = "Nama"
        dgv_data_peminjaman.Columns(4).Visible = False
        dgv_data_peminjaman.Columns(5).HeaderText = "Jenis Pinjam"
        dgv_data_peminjaman.Columns(6).HeaderText = "Besar Pinjam"
        dgv_data_peminjaman.Columns(7).HeaderText = "Lama Pinjam"
        dgv_data_peminjaman.Columns(8).HeaderText = "Angsuran Pokok"
        dgv_data_peminjaman.Columns(9).HeaderText = "Angsuran Bunga"
        dgv_data_peminjaman.Columns(10).HeaderText = "Jumlah Angsuran"
        dgv_data_peminjaman.Columns(11).HeaderText = "Cicilan Ke -"
        dgv_data_peminjaman.Columns(12).HeaderText = "Sudah Dibayar"
        dgv_data_peminjaman.Columns(13).HeaderText = "Saldo Piutang"
        dgv_data_peminjaman.Columns(14).HeaderText = "Pokok"
        dgv_data_peminjaman.Columns(15).HeaderText = "Bunga"
        dgv_data_peminjaman.Columns(16).Visible = False

        dgv_data_peminjaman.Columns(6).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(8).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(9).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(10).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(12).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(13).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(14).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(15).DefaultCellStyle.Format = "c0"


        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_peminjaman.Rows.Count
    End Sub


    Sub kondisiBtnCetak()
        If String.IsNullOrEmpty(dataTerpilih) Then
            btn_cetak_kwitansi.Enabled = False
        Else
            btn_cetak_kwitansi.Enabled = True
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub

    Private Sub FormPembayaranNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstTimeLoad()
        kondisiBtnCetak()
        showData()

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        formLoad()

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        firstTimeLoad()
        clearForm(group_pembayaran_pinjaman)
        clearForm(group_informasi_nasabah)
        clearForm(group_informasi_peminjaman)

        btn_simpan.Enabled = True

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

    Private Sub btn_cetak_kwitansi_Click(sender As Object, e As EventArgs) Handles btn_cetak_kwitansi.Click
        If dgv_data_peminjaman.Rows.Count = 0 Then
            dialogError("Anda belum memilih data anggota !")
            Return
        Else
            PreviewBuktiPembayaran.idtagihan = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
            PreviewBuktiPembayaran.ShowDialog()
        End If
    End Sub

    Private Sub dgv_data_peminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_peminjaman.CellClick
        If String.IsNullOrEmpty(txt_kode_nasabah.Text) Then
            If (e.RowIndex >= 0) Then


                selectIDNasabah = dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value
                dataTerpilih = selectIDNasabah

                FormCariAnggota.menu = "Pembayaran Nasabah"

                Me.idtagihan = dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value

                Me.txt_kode_pinjam.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(1).Value
                Me.txt_kode_nasabah.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(2).Value
                Me.txt_nama.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(3).Value
                Me.txt_alamat.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(4).Value
                Me.txt_jenis_pinjaman.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(5).Value

                Me.txt_besar_pinjam.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(6).Value
                Me.txt_lama_pinjam.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(7).Value
                Me.txt_angsuran_pokok.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(8).Value
                Me.txt_angsuran_bunga.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(9).Value
                Me.txt_jumlah_angsuran.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(10).Value

                Me.txt_angsuran_ke.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(11).Value
                Me.txt_sudah_dibayar.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(12).Value
                Me.txt_saldo_piutang.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(13).Value
                Me.txt_biaya_pokok.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(14).Value
                Me.txt_bayar_bunga.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(15).Value
                Me.txt_kode_tagihan.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(16).Value

                Me.bayarPokok = toDouble(dgv_data_peminjaman.Rows(e.RowIndex).Cells(14).Value)
                Me.bayarBunga = toDouble(dgv_data_peminjaman.Rows(e.RowIndex).Cells(15).Value)
                Me.idpinjam = dgv_data_peminjaman.Rows(e.RowIndex).Cells(1).Value

                kondisiBtnCetak()
                btn_simpan.Enabled = False
            End If
        Else
            btn_simpan.Enabled = False
        End If




    End Sub
End Class