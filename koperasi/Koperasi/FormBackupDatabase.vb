Public Class FormBackupDatabase
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub



    Private Sub btn_Backup_Click(sender As Object, e As EventArgs) Handles btn_Backup.Click
        Dim p As Process = New Process()
        Dim command As ProcessStartInfo = New ProcessStartInfo()


        Dim args As String = "pg_dump -U postgres -p 5433 -w -F t koperasidb > " & txt_LokaliasasiDB.Text.ToString & "koperasi.sql"

        command.FileName = "cmd.exe"
        command.Arguments = args

        p.StartInfo = command

        p.Start("cmd.exe", "/c " & args & " ")

        MsgBox("pg_dump -U postgres -p 5433 -W -F t koperasidb > " & txt_LokaliasasiDB.Text.ToString & "koperasi.sql")

    End Sub

    Private Sub btn_LokalisasiHasilBckup_Click(sender As Object, e As EventArgs) Handles btn_LokalisasiHasilBckup.Click
        Dim folderDialog As New FolderBrowserDialog
        folderDialog.ShowNewFolderButton = True

        If folderDialog.ShowDialog() = DialogResult.OK Then
            txt_LokaliasasiDB.Text = folderDialog.SelectedPath & "\"

            Dim root As Environment.SpecialFolder = folderDialog.RootFolder
        End If
    End Sub
End Class