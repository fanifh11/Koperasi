Public Class FormUser

    Sub lockForm()
        group_InputDataGroup.Enabled = False
        grupBtn.Enabled = True


    End Sub

    Sub openForm()
        group_InputDataGroup.Enabled = True
        grupBtn.Enabled = False



    End Sub
    Sub showCmbBoxGrupUser()
        cmb_Group.DataSource = getData("select dgroup from tblgroup order by dgroup asc")
        cmb_Group.DisplayMember = "dgroup"
        cmb_Group.ValueMember = "dgroup"

    End Sub

    Sub showDataUser()
        dgv_DaftarUser.DataSource = getData("select iduser,namalengkap,duser from tbluser where namalengkap ilike '%" & txt_CariUser.Text & "%'")
        dgv_DaftarUser.Columns(0).HeaderText = "ID Pengguna"
        dgv_DaftarUser.Columns(1).HeaderText = "Nama Lengkap"
        dgv_DaftarUser.Columns(2).HeaderText = "Username"

        Modul.makeFillDG(dgv_DaftarUser)


        lbl_JumUser.Text = "Jumlah Data : " & dgv_DaftarUser.Rows.Count


    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showCmbBoxGrupUser()
        showDataUser()
        lockForm()
        txt_idUser.Text = Now.ToString("yyyyMMddHHmmss")

    End Sub

    Private Sub txt_CariUser_TextChanged(sender As Object, e As EventArgs) Handles txt_CariUser.TextChanged
        showDataUser()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        openForm()

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        lockForm()
        txt_NamaLengkap.Text = ""
        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_UlangiPass.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If String.IsNullOrEmpty(txt_NamaLengkap.Text) Then
            dialogError("Nama lengkap masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txt_Username.Text) Then
            dialogError("Nama user user masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txt_Password.Text) Then
            dialogError("Password masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txt_UlangiPass.Text) Then
            dialogError("Harap ketikan ulang password Anda !")
            Return

        ElseIf txt_Password.Text <> txt_UlangiPass.Text Then
            dialogError("Password anda tidak sama !")
            Return

        Else
            Dim group As String = cmb_Group.SelectedValue

            Dim idUser As String = txt_idUser.Text
            Dim namaLengkap As String = txt_NamaLengkap.Text
            Dim namaUser As String = txt_Username.Text
            Dim password As String = txt_Password.Text
            Dim ulangiPass As String = txt_UlangiPass.Text


            If getCount("select duser from tbluser where duser = '" & namaUser & "' ") = 0 Then
                exc("insert into tbluser 
                    (iduser,duser,dpassword,namalengkap,dgroup) 
                values
                    (
                        '" & idUser & "',
                        '" & namaUser & "',
                        '" & password & "',
                        '" & namaLengkap & "',
                        '" & group & "'
                    ) 
               
                ")
                clearForm(group_InputDataGroup)
                txt_idUser.Text = Now.ToString("yyyyMMddHHmmss")

                dialogInfo("Pembuatan user akun sukses !")
                showDataUser()

            Else
                dialogError("Username ada yang sama dengan user lain !")
                Return

            End If
        End If



    End Sub

    Private Sub cekBox_ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cekBox_ShowPass.CheckedChanged
        If cekBox_ShowPass.Checked() Then
            txt_Password.UseSystemPasswordChar = False
            txt_UlangiPass.UseSystemPasswordChar = False
        Else
            txt_Password.UseSystemPasswordChar = True
            txt_UlangiPass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txt_idUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idUser.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim selectIdUser As String = dgv_DaftarUser.CurrentCell.Value

        If dialog("Apakah Anda yakin untuk menghapus Akun Pengguna / User ?") Then
            exc("delete from tbluser where iduser = '" & selectIdUser & "'")

        End If
        dialogInfo("Hapus akun berhasil!")
        showDataUser()

    End Sub
End Class