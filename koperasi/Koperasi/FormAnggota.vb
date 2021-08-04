Public Class FormAnggota
    Dim metode As String = ""
    Dim idAnggota As String = ""

    Public sql As String

    Sub showData()
        sql = "select idanggota,anggota,noktp,tempatlahir,tanggallahir,alamat,jk,notelp,status,pekerjaan,namasaudara,hpsaudara,tahunmasuk from tblanggota where anggota ilike '%" & txtSearch.Text & "%'"
        dgv_DataAnggota.DataSource = getData(sql)
        dgv_DataAnggota.Columns(0).HeaderText = "Kode Anggota"
        dgv_DataAnggota.Columns(1).HeaderText = "Nama Anggota"
        dgv_DataAnggota.Columns(2).HeaderText = "No. KTP"
        dgv_DataAnggota.Columns(3).HeaderText = "Tempat Lahir"
        dgv_DataAnggota.Columns(4).HeaderText = "Tanggal Lahir"
        dgv_DataAnggota.Columns(5).HeaderText = "Alamat"
        dgv_DataAnggota.Columns(6).HeaderText = "Jenis Kelamin"
        dgv_DataAnggota.Columns(7).HeaderText = "No Telepon"
        dgv_DataAnggota.Columns(8).HeaderText = "Status"
        dgv_DataAnggota.Columns(9).HeaderText = "Pekerjaan"
        dgv_DataAnggota.Columns(10).HeaderText = "Nama Saudara"
        dgv_DataAnggota.Columns(11).HeaderText = "No.Telp Saudara"
        dgv_DataAnggota.Columns(12).HeaderText = "Tanggal Daftar"


        lbl_JumlahData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows().Count
    End Sub

    Sub openForm()
        group_InformasiAnggota.Enabled = True
        grupBtn.Enabled = False
        group_DataAnggota.Enabled = False
    End Sub

    Sub closeForm()
        group_InformasiAnggota.Enabled = False
        grupBtn.Enabled = True
        group_DataAnggota.Enabled = True
    End Sub

    Private Sub txt_Nama_TextChanged(sender As Object, e As EventArgs) Handles txt_Nama.TextChanged
        showData()
    End Sub

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        dtp_TglDaftar.Value = DateTime.Now

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        showData()
    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        metode = "insert"
        openForm()
        clearForm(group_InformasiAnggota)

        dtp_TglDaftar.Value = DateTime.Now
    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        closeForm()
        clearForm(group_InformasiAnggota)
    End Sub

    Private Sub btn_Ubah_Click(sender As Object, e As EventArgs) Handles btn_Ubah.Click
        openForm()
        metode = "update"
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click

        If Modul.adaKosong(group_InformasiAnggota) Then
            dialogError("Lengkapi isian form anda terlebih dahulu !")
        Else
            Dim kodeAnggota As String = txt_KodeAnggota.Text
            Dim namaAnggota As String = txt_Nama.Text
            Dim noKtp As String = txt_NoKTP.Text
            Dim tempatLahir As String = txt_TmptLahir.Text
            Dim tglLahir As String = dtp_TglLahir.Value
            Dim alamat As String = txt_Alamat.Text
            Dim jenisKelamin As String = cmb_JK.Text
            Dim noTelp As String = txt_NoTelp.Text
            Dim status As String = cmb_Status.Text
            Dim pekerjaan As String = cmb_Pekerjaan.Text
            Dim namaSaudara As String = txt_NamaSaudara.Text
            Dim telpSaudara As String = txt_TelpSaudara.Text
            Dim tglDaftar As String = dtp_TglDaftar.Value


            If metode = "insert" Then
                If getCount("select idanggota from tblanggota where idanggota = '" & kodeAnggota & "' or anggota = '" & namaAnggota & "' or noktp = '" & noKtp & "' ") = 0 Then
                    exc("insert into tblanggota 
                    (
	                    idanggota,
	                    jenisanggota,
	                    anggota,
	                    jk,
	                    tempatlahir,
	                    tanggallahir,
	                    noktp,
	                    alamat,
	                    notelp,
	                    pekerjaan,
	                    status,
	                    namasaudara,
	                    hpsaudara,
	                    tahunmasuk,
	                    statusanggota 
                    ) values 
                    (
	                    '" & kodeAnggota & "',
	                    'ANGGOTA',
	                    '" & namaAnggota & "',
	                    '" & jenisKelamin & "',
	                    '" & tempatLahir & "',
	                    '" & tglLahir & "',
	                    '" & noKtp & "',
	                    '" & alamat & "',
	                    '" & noTelp & "',
	                    '" & pekerjaan & "',
	                    '" & status & "',
	                    '" & namaSaudara & "',
	                    '" & telpSaudara & "',
	                    '" & tglDaftar & "',
	                    1
                    )")
                Else
                    dialogError("Ada duplikasi data !")
                    Return
                End If


            Else
                If getCount("select idanggota from tblanggota where ( idanggota = '" & kodeAnggota & "' or anggota = '" & namaAnggota & "' or noktp = '" & noKtp & "' ) and idanggota != '" & idAnggota & "' ") = 0 Then
                    exc("update tblanggota set
                      idanggota = '" & kodeAnggota & "',
                      anggota =  '" & namaAnggota & "',
                      jk = '" & jenisKelamin & "',
                      tempatlahir =  '" & tempatLahir & "',
                      tanggallahir = '" & tglLahir & "',
                      noktp = '" & noKtp & "',
                      alamat = '" & alamat & "',
                      notelp = '" & noTelp & "',
                      pekerjaan = '" & pekerjaan & "',
                      status = '" & status & "',
                      namasaudara = '" & namaSaudara & "',
                      hpsaudara = '" & telpSaudara & "',
                      tahunmasuk = '" & tglDaftar & "'

                      where idanggota = '" & idAnggota & "'
                ")
                Else
                    dialogError("Ada duplikasi data !")
                    Return
                End If
            End If
            showData()
            closeForm()
            clearForm(group_InformasiAnggota)
        End If
    End Sub

    Private Sub dgv_DataAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota.CellClick

        If (e.RowIndex >= 0) Then
            idAnggota = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value

            txt_KodeAnggota.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value
            txt_Nama.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(1).Value
            txt_NoKTP.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(2).Value
            txt_TmptLahir.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(3).Value
            dtp_TglLahir.Value = dgv_DataAnggota.Rows(e.RowIndex).Cells(4).Value
            txt_Alamat.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(5).Value

            If dgv_DataAnggota.Rows(e.RowIndex).Cells(6).Value = "L" Then
                cmb_JK.SelectedIndex = 0
            Else
                cmb_JK.SelectedIndex = 1
            End If

            txt_NoTelp.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(7).Value


            If dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value = "Menikah" Then
                cmb_Status.SelectedIndex = 0
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value = "Belum Menikah" Then
                cmb_Status.SelectedIndex = 1
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value = "Janda" Then
                cmb_Status.SelectedIndex = 2
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(8).Value = "Duda" Then
                cmb_Status.SelectedIndex = 3
            Else
                cmb_Status.SelectedIndex = 4
            End If

            If dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "PEDAGANG" Then
                cmb_Pekerjaan.SelectedIndex = 0
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "TANI" Then
                cmb_Pekerjaan.SelectedIndex = 1
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "WIRASWASTA" Then
                cmb_Pekerjaan.SelectedIndex = 2
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "NELAYAN" Then
                cmb_Pekerjaan.SelectedIndex = 3
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "KARYAWAN" Then
                cmb_Pekerjaan.SelectedIndex = 4
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "GURU" Then
                cmb_Pekerjaan.SelectedIndex = 5
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "PNS" Then
                cmb_Pekerjaan.SelectedIndex = 6
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "TNI/POLRI" Then
                cmb_Pekerjaan.SelectedIndex = 7
            ElseIf dgv_DataAnggota.Rows(e.RowIndex).Cells(9).Value = "SWASTA" Then
                cmb_Pekerjaan.SelectedIndex = 8
            Else
                cmb_Pekerjaan.SelectedIndex = 9
            End If

            txt_NamaSaudara.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(10).Value
            txt_TelpSaudara.Text = dgv_DataAnggota.Rows(e.RowIndex).Cells(11).Value

            dtp_TglDaftar.Value = dgv_DataAnggota.Rows(e.RowIndex).Cells(12).Value


        End If



    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_Hapus.Click

        If dialog("Apakah yakin untuk menghapus data ini? ") Then
            If adaKosong(group_InformasiAnggota) Then
                dialogError("Harap pilih data anggota terlebih dahulu !")
                Return
            Else
                If getCount("select idanggota from tblpinjam where idanggota = '" & idAnggota & "' ") > 0 Or getCount("select idanggota from tblsukarela where idanggota='" & idAnggota & "'") > 0 Then
                    dialogError("Data anggota tidak dapat dihapus karena memiliki pinjaman dan simpanan !")
                    Return
                Else
                    If exc("delete from tblanggota where idanggota = '" & idAnggota & "' ") Then
                        dialogInfo("Hapus berhasil ")
                    Else
                        dialogError("Hapus gagal ")
                    End If
                    clearForm(group_InformasiAnggota)
                    showData()
                End If
            End If
        End If


    End Sub

    Private Sub txt_NoKTP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NoKTP.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_KodeAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_KodeAnggota.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_NoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NoTelp.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_TelpSaudara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TelpSaudara.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub btn_CetakKartu_Click(sender As Object, e As EventArgs) Handles btn_CetakKartu.Click
        PreviewFormAnggota.sql = Sql
        PreviewFormAnggota.ShowDialog()
    End Sub
End Class