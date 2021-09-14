Public Class FormGroupAkses

    Public idgroup As String = ""
    Dim selectId As String = ""
    Dim idAkses As String = ""

    Sub hitungJumlahMenu()
        lbl_JumlahMenu.Text = "Jumlah Menu : " & clb_HakAkses.CheckedItems.Count


    End Sub

    Sub showDataGroup()
        dgv_JumGroup.DataSource = getData("select dgroup,keterangan from tblgroup order by dgroup asc")
        dgv_JumGroup.Columns(0).HeaderText = "Group"
        dgv_JumGroup.Columns(1).HeaderText = "Keterangan"

        makeFillDG(dgv_JumGroup)

        lbl_JumDataGroup.Text = "Jumlah Group : " & dgv_JumGroup.Rows.Count

    End Sub

    Sub lockItem()
        group_DataGroup.Enabled = False
        btnTambah.Enabled = True
        btnHapus.Enabled = True

    End Sub

    Sub openItem()
        group_DataGroup.Enabled = True
        btnHapus.Enabled = False
        btnTambah.Enabled = False

    End Sub

    Sub showComboBoxHakAkses()
        cmb_HakAkses.DataSource = getData("select dgroup from tblgroup order by dgroup desc")
        cmb_HakAkses.DisplayMember = "dgroup"
        cmb_HakAkses.ValueMember = "dgroup"

    End Sub
    Private Sub FormGroupAkses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showDataGroup()
        lockItem()
        showComboBoxHakAkses()
        clb_HakAkses.Visible = False

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        openItem()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lockItem()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim group As String = txt_Group.Text
        Dim keterangan As String = txt_Keterangan.Text

        If String.IsNullOrEmpty(group) Then
            dialogError("Form group Anda masih kosong !")
            Return

        ElseIf String.IsNullOrEmpty(keterangan) Then
            dialogError("Form keterangan Anda masih kosong !")
            Return

        Else
            If getCount("select dgroup from tblgroup where dgroup = '" & group & "' ") = 0 Then
                If dialog("Apakah yakin untuk menambah group hak akses?") Then

                    Dim baris As Integer = 1

                    exc("insert into tblgroup (dgroup,keterangan) values ('" & group & "' ,'" & keterangan & "' )")

                    For Each menu As String In clb_HakAkses.Items
                        exc("insert into tblmenu(dgroup,menucaption,menutag,menulevel,flag) values('" & group & "', '" & menu & "','" & baris.ToString & "',0,TRUE )")
                        baris += 1

                    Next

                End If
                showDataGroup()
                clearForm(group_DataGroup)
            Else
                dialogError("Ada duplikasi data !")
                Return

                clearForm(group_DataGroup)
                Return
            End If
        End If
        showComboBoxHakAkses()
        lockItem()
        clb_HakAkses.Visible = False


    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub dgv_JumGroup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_JumGroup.CellClick
        If (e.RowIndex >= 0) Then
            selectId = dgv_JumGroup.Rows(e.RowIndex).Cells(0).Value
            idAkses = selectId

        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(idAkses) Then
            dialogError("Harap pilih data terlebih dahulu !")
            Return
        Else
            If dialog("Apakah Anda yakin untuk menghapus group akses ?") Then
                If getCount("select dgroup from tbluser where dgroup = '" & selectId & "' ") > 0 Then
                    dialogError("Group hak akses tidak dapat dihapus !")
                    Return
                Else
                    exc("delete from tblgroup where dgroup = '" & selectId & "' ")
                    exc("delete from tblmenu where dgroup = '" & selectId & "' ")
                    showDataGroup()
                    dialogInfo("Hapus hak akses berhasil")
                End If
            Else
                dialogInfo("Hapus batal !")
            End If
        End If
        showComboBoxHakAkses()
    End Sub

    Private Sub btnTampilkanMenu_Click(sender As Object, e As EventArgs) Handles btnTampilkanMenu.Click
        clb_HakAkses.Visible = True

        Dim sql As String = "select * from tblmenu where dgroup = '" & cmb_HakAkses.SelectedValue & "'"
        Dim tblmenu As DataTable = getData(sql)


        For Each row As DataRow In tblmenu.Rows
            If row.Item("flag") Then
                clb_HakAkses.SetItemChecked(CInt(row.Item("menutag") - 1), True)
            Else
                clb_HakAkses.SetItemChecked(CInt(row.Item("menutag") - 1), False)

            End If

        Next
        hitungJumlahMenu()

    End Sub

    Private Sub btnSimpanHakAkses_Click(sender As Object, e As EventArgs) Handles btnSimpanHakAkses.Click
        If clb_HakAkses.Visible = False Then
            dialogError("Pilih hak akses yang akan diupdate terlebih dahulu")
        Else

            Dim baris = 0

            For Each menu As String In clb_HakAkses.Items
                Dim checked = False
                Dim menuTag = baris + 1

                Dim dgroup As String = cmb_HakAkses.SelectedValue

                If clb_HakAkses.GetItemChecked(baris) Then
                    checked = True

                End If
                exc("update tblmenu set flag = '" & checked.ToString & "' where dgroup = '" & dgroup & "' and menutag = '" & menuTag & "' ")

                baris += 1

            Next
            dialogInfo("Update menu berhasil !")
            dialogInfo("Silahkan restart aplikasi untuk memperbarui menu !")
            showComboBoxHakAkses()

        End If

    End Sub

    Private Sub cmb_HakAkses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_HakAkses.SelectedIndexChanged
        clb_HakAkses.Visible = False
        lbl_JumlahMenu.Text = "Jumlah Menu : 0"

    End Sub

End Class