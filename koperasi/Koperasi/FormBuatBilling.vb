Public Class FormBuatBilling
    Dim pilihan As ArrayList = New ArrayList()
    Dim metode As String = ""

    Sub chooseAll()
        For Each idanggota As DataGridViewRow In dgv_DataAnggota1.Rows
            pilihan.Add(idanggota.Cells(2).Value)

        Next
        showData()

    End Sub
    Sub removeAll()
        pilihan.Clear()
        showData()

    End Sub

    Sub showData()

        Dim terpilih As String = "("

        If pilihan.Count > 0 Then
            For Each kodeanggota As String In pilihan
                terpilih = terpilih & "'" & kodeanggota & "',"
            Next
            terpilih = Strings.Left(terpilih, terpilih.Length - 1)
        Else
            terpilih = terpilih & "'Data tidak ada'"
        End If
        terpilih = terpilih & ")"

        dgv_DataAnggota1.DataSource = getData("select anggota,jk,idanggota from tblanggota where anggota ilike '%" & txt_CariDataAnggota1.Text & "%' and idanggota not in " & terpilih)
        dgv_DataAnggota1.Columns(0).HeaderText = "Nama Anggota"
        dgv_DataAnggota1.Columns(1).HeaderText = "Jenis Kelamin"
        dgv_DataAnggota1.Columns(2).HeaderText = "Kode Anggota"

        lbl_JumData1.Text = "Jumlah data : " & dgv_DataAnggota1.Rows.Count

        dgv_DataAnggota2.DataSource = getData("select anggota,jk,idanggota from tblanggota where anggota ilike '%" & txt_CariDataAnggota2.Text & "%' and  idanggota in " & terpilih)
        dgv_DataAnggota2.Columns(0).HeaderText = "Nama Anggota"
        dgv_DataAnggota2.Columns(1).HeaderText = "Jenis Kelamin"
        dgv_DataAnggota2.Columns(2).HeaderText = "Kode Anggota"

        lbl_JumData2.Text = "Jumlah data : " & dgv_DataAnggota2.Rows.Count
    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub group_CariDataAnggota2_Enter(sender As Object, e As EventArgs) Handles group_CariDataAnggota2.Enter

    End Sub

    Private Sub FormBuatBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        cmb_JenisSimpanan.SelectedIndex = 0


    End Sub

    Private Sub dgv_DataAnggota1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota1.CellClick
        If (e.RowIndex >= 0) Then
            pilihan.Add(dgv_DataAnggota1.Rows(e.RowIndex).Cells(2).Value)
            showData()
        End If

    End Sub

    Private Sub txt_CariDataAnggota1_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota1.TextChanged
        showData()
    End Sub

    Private Sub txt_CariDataAnggota2_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota2.TextChanged
        showData()
    End Sub

    Private Sub dgv_DataAnggota2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataAnggota2.CellClick
        Try
            pilihan.Remove(dgv_DataAnggota2.Rows(e.RowIndex).Cells(2).Value)
            showData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_PilihSemua_Click(sender As Object, e As EventArgs) Handles btn_PilihSemua.Click
        chooseAll()
    End Sub

    Private Sub btn_hapusSemua_Click(sender As Object, e As EventArgs) Handles btn_hapusSemua.Click
        removeAll()
    End Sub

    Private Sub cmb_JenisSimpanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_JenisSimpanan.SelectedIndexChanged
        If cmb_JenisSimpanan.SelectedIndex = 0 Then
            cmb_JenisSimp.DataSource = getData("select jenissimpanan from tbljenis where kategori = 'POKOK' ")
            txt_Tahun.Text = getValue("select tahun from tbltahun where flagaktif = 'AKTIF' ", "tahun")

            cmb_JenisSimp.DisplayMember = "jenissimpanan"
            cmb_JenisSimp.ValueMember = "jenissimpanan"

            cmb_Bulan.Visible = False
            lbl_Bulan.Visible = False

            txt_BesarSimpanan.Enabled = False
        ElseIf cmb_JenisSimpanan.SelectedIndex = 1 Then
            cmb_JenisSimp.DataSource = getData("select jenissimpanan from tbljenis where kategori ='WAJIB' ")
            txt_Tahun.Text = getValue("select tahun from tbltahun where flagaktif ='AKTIF'", "tahun")
            cmb_JenisSimp.DisplayMember = "jenissimpanan"
            cmb_JenisSimp.ValueMember = "jenissimpanan"

            cmb_Bulan.Visible = True
            cmb_Bulan.SelectedIndex = 0

            lbl_Bulan.Visible = True
            txt_BesarSimpanan.Enabled = False
        ElseIf cmb_JenisSimpanan.SelectedIndex = 2 Then
            cmb_JenisSimp.DataSource = getData("select jenissimpanan from tbljenis where kategori = 'SALDO AWAL' ")
            txt_Tahun.Text = getValue("select tahun from tbltahun where flagaktif ='AKTIF'", "tahun")
            cmb_JenisSimp.DisplayMember = "jenissimpanan"
            cmb_JenisSimp.ValueMember = "jenissimpanan"

            cmb_Bulan.Visible = False
            lbl_Bulan.Visible = False
            txt_BesarSimpanan.Enabled = True

        End If
        txt_BesarSimpanan.Text = getValue("select besarsimpanan from tbljenis where jenissimpanan = '" & cmb_JenisSimp.SelectedValue.ToString & "'", "besarsimpanan")
    End Sub

    Private Sub cmb_JenisSimp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_JenisSimp.SelectedIndexChanged
        txt_BesarSimpanan.Text = getValue("select besarsimpanan from tbljenis where jenissimpanan = '" & cmb_JenisSimp.SelectedValue.ToString & "'", "besarsimpanan")
    End Sub

    Private Sub btn_BuatBiling_Click(sender As Object, e As EventArgs) Handles btn_BuatBiling.Click
        Dim ketkategori As String = cmb_JenisSimpanan.Text
        Dim jenisSimp As String = cmb_JenisSimp.SelectedValue
        Dim tahun As String = txt_Tahun.Text
        Dim bulan As String = cmb_Bulan.Text
        Dim besarSimpanan As String = txt_BesarSimpanan.Text

        Dim ketsim = ""
        If ketkategori = "WAJIB" Then
            ketsim = bulan
        Else
            ketsim = ketkategori
        End If

        If pilihan.Count = 0 Then
            dialogError("Nasabah yang anda pilih masih kosong !")
            Return

        ElseIf pilihan.Count > 0 Then
            If dialog("Apakah anda yakin untuk membuat tagihan simpanan ?") Then
                For Each kodeanggota In pilihan
                    exc("insert into tblrekening
                    (
                        idanggota,
                        jenissimpanan,
                        besar,
                        tglrek,
                        tglbayar,
                        fbayar,
                        tahun,
                        ketsimp,
                        ketkategori
                    )
                    values
                    (
                        '" & kodeanggota & "',
                        '" & jenisSimp & "',
                        '" & besarSimpanan & "',
                        now(),
                        now(),
                        0,
                        '" & tahun & "',
                        '" & ketsim & "',
                        '" & ketkategori & "'
                     ) 
                    ")
                Next
            End If

            If cmb_JenisSimpanan.SelectedIndex = 2 Then
                txt_BesarSimpanan.Text = 0
            End If

        End If

        dialogInfo("Buat tagihan simpanan sukses !")
        removeAll()
    End Sub

    Private Sub txt_BesarSimpanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BesarSimpanan.KeyPress
        onlyNumber(e)

    End Sub

    Private Sub btn_lihat_tagihan_Click(sender As Object, e As EventArgs) Handles btn_lihat_tagihan.Click
        FormLihatTagihan.ShowDialog()
        FormLihatTagihan.Dispose()
    End Sub
End Class