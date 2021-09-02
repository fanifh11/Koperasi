Public Class Login



    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub


    Sub masuk()
        setLocationDatabase(txt_Address.Text)
        Dim usernameTxt = txt_Username.Text
        Dim passwordTxt = txt_Password.Text
        Debug.WriteLine("select duser,dpassword from tbluser where duser = '" & usernameTxt & "' and dpassword = '" & passwordTxt & "' ")
        If getCount("select duser,dpassword from tbluser where duser = '" & usernameTxt & "' and dpassword = '" & passwordTxt & "' ") > 0 Then

            If clearKoneksi() Then
                Me.Hide()

                MenuUtama.username = usernameTxt
                MenuUtama.setRule()

                MenuUtama.Show()

                txt_Address.Clear()
                txt_Username.Clear()
                txt_Password.Clear()

            Else
                dialogError("address tidak ditemukan")
            End If
        Else
            dialogError("username atau passwrod tidak ditemukan")
        End If
    End Sub

    Private Sub CBox_showPass_CheckedChanged(sender As Object, e As EventArgs) Handles CBox_showPass.CheckedChanged
        If CBox_showPass.Checked() Then
            txt_Password.UseSystemPasswordChar = False
        Else
            txt_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        masuk()

    End Sub

    Private Sub txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Password.KeyDown
        If e.KeyValue = 13 Then
            masuk()
        End If
    End Sub
End Class