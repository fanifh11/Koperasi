Public Class FormBuatRekSimpSukarela
    Dim metode As String = ""
    Dim terpilih As New ArrayList

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormBuatRekSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        getSimpanan()
    End Sub

    Sub showData()
        Dim kepilih As String = "("
        If terpilih.Count > 0 Then
            For Each idanggota As String In terpilih
                kepilih = kepilih & "'" & idanggota & "',"
            Next
            kepilih = Strings.Left(kepilih, kepilih.Length - 1)
        Else
            kepilih = kepilih & "'*'"
        End If
        kepilih = kepilih & ")"

        dgv_DataAnggota.DataSource = getData("select 
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
            foto,
            tahunmasuk,
            statusanggota,
            fp 
            
            from tblanggota where anggota ilike '%" & txt_CariDataAnggota.Text & "%' and idanggota not in " & kepilih)

        dgv_DataAnggota2.DataSource = getData("select 
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
            foto,
            tahunmasuk,
            statusanggota,
            fp 
            
            from tblanggota where anggota ilike '%" & txt_CariDataAnggota2.Text & "%' and idanggota in " & kepilih)

        lbl_JumData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count
        lbl_JumData2.Text = "Jumlah Data : " & dgv_DataAnggota2.Rows.Count

        dgv_DataAnggota.Columns(0).HeaderText = "Id Anggota"
        dgv_DataAnggota.Columns(1).HeaderText = "Jenis Anggota"
        dgv_DataAnggota.Columns(2).HeaderText = "Nama Anggota"
        dgv_DataAnggota.Columns(3).HeaderText = "JK"
        dgv_DataAnggota.Columns(4).HeaderText = "Tempat Lahir"
        dgv_DataAnggota.Columns(5).HeaderText = "Tanggal Lahir"
        dgv_DataAnggota.Columns(6).HeaderText = "No KTP"
        dgv_DataAnggota.Columns(7).HeaderText = "Alamat"
        dgv_DataAnggota.Columns(8).HeaderText = "No Telp"
        dgv_DataAnggota.Columns(9).HeaderText = "Pekerjaan"
        dgv_DataAnggota.Columns(10).HeaderText = "Status"
        dgv_DataAnggota.Columns(11).HeaderText = "Nama Saudara"
        dgv_DataAnggota.Columns(12).HeaderText = "HP Saudara"
        dgv_DataAnggota.Columns(13).HeaderText = "Foto"
        dgv_DataAnggota.Columns(14).HeaderText = "Tahun Masuk"
        dgv_DataAnggota.Columns(15).HeaderText = "Status Anggota"
        dgv_DataAnggota.Columns(16).HeaderText = "FP"

        dgv_DataAnggota2.Columns(0).HeaderText = "Id Anggota"
        dgv_DataAnggota2.Columns(1).HeaderText = "Jenis Anggota"
        dgv_DataAnggota2.Columns(2).HeaderText = "Nama Anggota"
        dgv_DataAnggota2.Columns(3).HeaderText = "JK"
        dgv_DataAnggota2.Columns(4).HeaderText = "Tempat Lahir"
        dgv_DataAnggota2.Columns(5).HeaderText = "Tanggal Lahir"
        dgv_DataAnggota2.Columns(6).HeaderText = "No KTP"
        dgv_DataAnggota2.Columns(7).HeaderText = "Alamat"
        dgv_DataAnggota2.Columns(8).HeaderText = "No Telp"
        dgv_DataAnggota2.Columns(9).HeaderText = "Pekerjaan"
        dgv_DataAnggota2.Columns(10).HeaderText = "Status"
        dgv_DataAnggota2.Columns(11).HeaderText = "Nama Saudara"
        dgv_DataAnggota2.Columns(12).HeaderText = "HP Saudara"
        dgv_DataAnggota2.Columns(13).HeaderText = "Foto"
        dgv_DataAnggota2.Columns(14).HeaderText = "Tahun Masuk"
        dgv_DataAnggota2.Columns(15).HeaderText = "Status Anggota"
        dgv_DataAnggota2.Columns(16).HeaderText = "FP"
    End Sub

    Private Sub txt_CariDataAnggota_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota.TextChanged
        showData()
    End Sub

    Private Sub txt_CariDataAnggota2_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota2.TextChanged
        showData()
    End Sub

    Private Sub dgv_DataAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota.CellClick
        If (e.RowIndex >= 0) Then
            terpilih.Add(dgv_DataAnggota.Rows(e.RowIndex).Cells(0).Value)
            showData()
        End If

    End Sub

    Private Sub dgv_DataAnggota2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota2.CellClick
        If (e.RowIndex >= 0) Then
            terpilih.Remove(dgv_DataAnggota2.Rows(e.RowIndex).Cells(0).Value)
            showData()
        End If

    End Sub

    Private Sub cmb_JenisSimpanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_JenisSimpanan.SelectedIndexChanged
        txt_Bunga.Text = getValue("select bunga from tbljenis where jenissimpanan = '" & cmb_JenisSimpanan.SelectedValue.ToString & "'", "bunga")
    End Sub

    Sub getSimpanan()
        cmb_JenisSimpanan.DataSource = getData("select jenissimpanan from tbljenis where kategori = 'SUKARELA'")
        cmb_JenisSimpanan.DisplayMember = "jenissimpanan"
        cmb_JenisSimpanan.ValueMember = "jenissimpanan"
        txt_Bunga.Text = getValue("select bunga from tbljenis where jenissimpanan = '" & cmb_JenisSimpanan.SelectedValue.ToString & "'", "bunga")
        txt_Bunga.Enabled = False
    End Sub

    Private Sub btn_Last_Click(sender As Object, e As EventArgs) Handles btn_Last.Click
        chooseAll()
    End Sub

    Private Sub btn_First_Click(sender As Object, e As EventArgs) Handles btn_First.Click
        removeAll()
    End Sub

    Sub chooseAll()
        For Each idanggota As DataGridViewRow In dgv_DataAnggota.Rows
            terpilih.Add(idanggota.Cells(0).Value)
        Next
        showData()
    End Sub

    Sub removeAll()
        terpilih.Clear()
        showData()
    End Sub

    Private Sub btn_BuatRekening_Click(sender As Object, e As EventArgs) Handles btn_BuatRekening.Click
        If terpilih.Count > 0 Then
            If dialog("Apakah Anda yakin membuat untuk membuat rekening simpanan sukarela ?") Then
                For Each idanggota As String In terpilih
                    Dim ketsukarela As String = cmb_JenisSimpanan.SelectedValue
                    Dim bunga As String = txt_Bunga.Text

                    Dim replacedot = bunga.Replace(",", ".")
                    Dim sqlSelect = $"select idanggota from tblsukarela where idanggota='{idanggota}' and ketsukarela='{ketsukarela}'"
                    If getCount(sqlSelect) = 0 Then
                        exc("insert into tblsukarela
                        (
                            idanggota,
                            tglsukarela,
                            flagsukarela,
                            ketsukarela,
                            bunga,
                            kode
                        )
                        values
                        (
                            '" & idanggota & "',
                            'NOW()',
                            '0',
                            '" & ketsukarela & "',
                            '" & replacedot & "',
                            '0'
                        )")
                    End If


                Next
                dialogInfo("Pembuatan akun rekening berhasil!")
                removeAll()
            End If
        Else
            dialogError("Data harus dipilih!")
            Return

        End If
    End Sub
End Class