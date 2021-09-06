Public Class DialogReset
    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            proses()

        ElseIf e.Control AndAlso e.KeyCode = Keys.End Then
            Me.Close()
        End If
    End Sub

    Sub proses()
        exc("TRUNCATE TABLE ONLY public.tblanggota RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblbunga RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblpinjam RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblrekap RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblrekapbunga RESTART IDENTITY CASCADE;
")
        ProgressBar1.Value = 50
        exc("TRUNCATE TABLE ONLY public.tblrekapsimp RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblrekapsukarela RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblrekening RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblshu RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblsisa RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tblsukarela RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tbltagihan RESTART IDENTITY CASCADE;
TRUNCATE TABLE ONLY public.tbltransaksi RESTART IDENTITY CASCADE;")

        ProgressBar1.Value = 100
        dialogInfo("Berhasil direset")
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        proses()

    End Sub

    Private Sub DialogReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        proses()
    End Sub

    Private Sub Button2_KeyDown_1(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.F1 Then
            proses()

        ElseIf e.Control AndAlso e.KeyCode = Keys.End Then
            Me.Close()
        End If
    End Sub
End Class