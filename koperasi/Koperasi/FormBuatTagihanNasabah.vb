Public Class FormBuatTagihanNasabah
    Dim data As String = ""
    Dim pilihan As ArrayList = New ArrayList

    Sub chooseAll()
        For Each idanggota As DataGridViewRow In dgv_data_peminjaman.Rows
            pilihan.Add(idanggota.Cells(0).Value)
        Next
        showData()
    End Sub

    Sub removeAll()
        pilihan.Clear()
        showData()
    End Sub

    Sub insertData(row As Integer)

        Dim idpinjam = dgv_data_peminjaman2.Rows(row).Cells(0).Value
        Dim angsuranPokok = dgv_data_peminjaman2.Rows(row).Cells(7).Value
        Dim angsuranBunga = dgv_data_peminjaman2.Rows(row).Cells(8).Value
        Dim jumAngsuran = dgv_data_peminjaman2.Rows(row).Cells(9).Value
        Dim cicianKe = getCount("select * from tbltagihan where idpinjam = '" & idpinjam & "' ") + 1
        Dim idTagihan As String = Now.ToString("yyyyMMddHHmmss") & row.ToString
        Dim kodeTagihan As String = Now.ToString("yyyyMMdd-HHmmss") & row.ToString



        exc("insert into tbltagihan
                (
                    idtagihan,
                    idpinjam,
                    tgltagihan,
                    tglbayar,
                    totalpokok,
                    totalangsur,
                    totalbunga,
                    cicilanke,
                    flagtagihan,
                    kodetagihan,
                    addtagihan,
                    flagpostingtagihan
                )values
                (
                    '" & idTagihan & "',
                    '" & idpinjam & "',
                    now(),
                    now(),
                    '" & angsuranPokok & "',
                    '" & jumAngsuran & "',
                    '" & angsuranBunga & "',
                    '" & cicianKe & "',
                    0,
                    '" & kodeTagihan & "',
                    'admin',
                    0
                )
            
            ")
    End Sub

    Sub showData()

        Dim terpilih As String = "("

        If pilihan.Count > 0 Then
            For Each kodeanggota In pilihan
                terpilih = terpilih & "'" & kodeanggota & "',"
            Next
            terpilih = Strings.Left(terpilih, terpilih.Length - 1)
        Else
            terpilih = terpilih & "'Data tidak dipilih'"
        End If
        terpilih = terpilih & ")"

        dgv_data_peminjaman.DataSource = getData("select idpinjam,idanggota,anggota,jk,jenis,besarpinjam,lamapinjam,angsuranpokok,angsuranbunga,jumlahangsuran from qpinjam where flagpinjam = 0 and anggota ilike '%" & txt_search.Text & "%' and idpinjam not in " & terpilih)
        dgv_data_peminjaman.Columns(0).HeaderText = "Kode Pinjam"
        dgv_data_peminjaman.Columns(1).HeaderText = "Kode Anggota"
        dgv_data_peminjaman.Columns(2).HeaderText = "Nama"
        dgv_data_peminjaman.Columns(3).HeaderText = "Jenis Kelamin"
        dgv_data_peminjaman.Columns(4).HeaderText = "Jenis Pinjam"
        dgv_data_peminjaman.Columns(5).HeaderText = "Besar Pinjam"
        dgv_data_peminjaman.Columns(6).HeaderText = "Lama Pinjam"

        dgv_data_peminjaman.Columns(7).Visible = False
        dgv_data_peminjaman.Columns(8).Visible = False
        dgv_data_peminjaman.Columns(9).Visible = False

        lbl_Jumlah.Text = "Jumlah Data :" & dgv_data_peminjaman.Rows.Count

        dgv_data_peminjaman2.DataSource = getData("select idpinjam,idanggota,anggota,jk,jenis,besarpinjam,lamapinjam,angsuranpokok,angsuranbunga,jumlahangsuran from qpinjam where flagpinjam = 0 and anggota ilike  '%" & txt_search2.Text & "%' and idpinjam in " & terpilih)
        dgv_data_peminjaman2.Columns(0).HeaderText = "Kode Pinjam"
        dgv_data_peminjaman2.Columns(1).HeaderText = "Kode Anggota"
        dgv_data_peminjaman2.Columns(2).HeaderText = "Nama"
        dgv_data_peminjaman2.Columns(3).HeaderText = "Jenis Kelamin"
        dgv_data_peminjaman2.Columns(4).HeaderText = "Jenis Pinjam"
        dgv_data_peminjaman2.Columns(5).HeaderText = "Besar Pinjam"
        dgv_data_peminjaman2.Columns(6).HeaderText = "Lama Pinjam"

        dgv_data_peminjaman2.Columns(7).Visible = False
        dgv_data_peminjaman2.Columns(8).Visible = False
        dgv_data_peminjaman2.Columns(9).Visible = False

        lbl_Jumlah2.Text = "Jumlah Data :" & dgv_data_peminjaman2.Rows.Count

    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click

        If pilihan.Count > 0 Then
            Dim baris
            If dialog("Apakah anda yakin untuk membuat tagihan ?") Then
                For Each row As DataGridViewRow In dgv_data_peminjaman2.Rows
                    insertData(baris)
                    baris = baris + 1
                Next
            End If
            dialogInfo("Buat tagihan sukses !")
        ElseIf pilihan.Count = 0 Then
            dialogError("Pilihan Nasabah Anda Masih Kosong !")
            Return


        End If

        removeAll()

    End Sub

    Private Sub FormBuatTagihanNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub txt_search2_TextChanged(sender As Object, e As EventArgs) Handles txt_search2.TextChanged
        showData()
    End Sub

    Private Sub dgv_data_peminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_peminjaman.CellClick
        If (e.RowIndex >= 0) Then
            pilihan.Add(dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value)
            showData()
        End If

    End Sub

    Private Sub dgv_data_peminjaman2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_peminjaman2.CellClick
        Try
            pilihan.Remove(dgv_data_peminjaman2.Rows(e.RowIndex).Cells(0).Value)
            showData()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        chooseAll()

    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        removeAll()

    End Sub

    Private Sub btn_lihat_tagihan_Click(sender As Object, e As EventArgs) Handles btn_lihat_tagihan.Click
        FormLihatTagihanNasabah.ShowDialog()
        FormLihatTagihanNasabah.Dispose()

    End Sub
End Class