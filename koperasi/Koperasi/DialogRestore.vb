Public Class DialogRestore

    Sub browseFile()
        Dim save As OpenFileDialog = New OpenFileDialog
        save.Filter = "File Database|*." & "sql"

        save.DefaultExt = "sql"

        Dim dialog As DialogResult = save.ShowDialog

        If dialog = DialogResult.OK Then
            TBAfter.Text = save.FileName
        End If
    End Sub

    Sub restore()

        Dim psi As New ProcessStartInfo(Application.StartupPath & "\Restore.exe")
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
            Dim folder As String = Modul.kodeaplikasi
            regEdit(folder, "RESFOLDER", "'" & (TBAfter.Text) & "'")
            restore()
            dialogInfo("Restore Berhasil")

        End If

    End Sub

    Sub awal()

        TBBefore.Text = getLocationDatabase()
        TBAfter.Text = ""
    End Sub
    Private Sub DialogBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBBefore.Text = getLocationDatabase()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        proses()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        browseFile()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            proses()
        ElseIf e.KeyCode = Keys.F2 Then
            browseFile()
        ElseIf e.Control AndAlso e.KeyCode = Keys.End Then
            Me.Close()
        End If
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        browseFile()
    End Sub

    Private Sub Button8_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBefore.KeyDown, TBAfter.KeyDown, Button2.KeyDown, Button1.KeyDown
        If e.KeyCode = Keys.F1 Then
            proses()
        ElseIf e.KeyCode = Keys.F2 Then
            browseFile()
        ElseIf e.Control AndAlso e.KeyCode = Keys.End Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        proses()
    End Sub
End Class