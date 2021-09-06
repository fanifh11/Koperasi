Public Class DialogBackup
    Sub browseFile()
        Dim save As SaveFileDialog = New SaveFileDialog
        save.Filter = "File Database|*." & "sql"
        save.FileName = "BackupData_" & Date.Now.ToString("yyyyMMdd_HHmmss")
        save.DefaultExt = "sql"

        Dim dialog As DialogResult = save.ShowDialog

        If dialog = DialogResult.OK Then
            TBAfter.Text = save.FileName
        End If
    End Sub

    Sub backup()

        Dim psi As New ProcessStartInfo(Application.StartupPath & "\Backup.exe")
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = False

        psi.UseShellExecute = False

        Dim process As Process = Process.Start(psi)
    End Sub

    Sub proses()
        If String.IsNullOrWhiteSpace(TBAfter.Text) Then
            dialogError("Pilih folder terlebih dahulu")
        Else
            Button2.Enabled = False
            For value As Integer = 0 To 100
                ProgressBar1.Value = value
                Threading.Thread.Sleep(300)
            Next

            Dim folder As String = Modul.kodeaplikasi
            regEdit(folder, "BAKFOLDER", """" & (TBAfter.Text) & """")
            backup()
            dialogInfo("Backup Berhasil")
            Button2.Enabled = True
            ProgressBar1.Value = 0

        End If

    End Sub

    Sub awal()
        TBBefore.Text = getLocationDatabase()
        TBAfter.Text = ""
    End Sub

    Private Sub DialogBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBBefore.Text = getLocationDatabase()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        proses()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        browseFile()
    End Sub



    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBefore.KeyDown, TBAfter.KeyDown, Button2.KeyDown, Button1.KeyDown, Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            proses()
        ElseIf e.KeyCode = Keys.F2 Then
            browseFile()
        ElseIf e.Control AndAlso e.KeyCode = Keys.End Then
            Me.Close()
        End If
    End Sub

    Private Sub TBAfter_TextChanged(sender As Object, e As EventArgs) Handles TBAfter.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class