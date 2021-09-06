Imports System.ComponentModel

Public Class ImportAnggota
    Private Sub ImportSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub browseFile()
        Dim save As OpenFileDialog = New OpenFileDialog
        Dim excel As String = "xlsx"

        If True Then
            excel = "xls"
        End If
        save.Filter = "File Excel|*." & excel



        Dim dialog As DialogResult = save.ShowDialog

        If dialog = DialogResult.OK Then
            TBAfter.Text = save.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        browseFile()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        check()
    End Sub

    Sub check()
        If Not System.IO.File.Exists(TBAfter.Text) Or String.IsNullOrWhiteSpace(TBAfter.Text) Then
            dialogError("Pilih file lokasi terlebih dahulu")
        Else
            Dim dt As DataTable = importExcelFromURL(TBAfter.Text, "Sheet1")
            import_excel(dt)
        End If
    End Sub

    Private Function cekRow(row As DataRow, Optional tipe As Integer = 0) As Boolean
        Dim filled = True
        For i As Integer = 0 To 10
            If String.IsNullOrWhiteSpace(row.Item(i).ToString) Then
                filled = False
                Exit For
            End If


        Next

        Return filled
    End Function

    Private Sub import_excel(data As DataTable)
        If IsNothing(data) Then
            dialogError("File tidak sesuai format")
            Return
        End If

        Dim CTL As Control
        For Each CTL In Me.Controls
            CTL.Enabled = False
        Next

        Dim status As Boolean = True
        Dim per As Integer = Math.Floor(100 / data.Rows.Count)
        Dim jumlahDataMasuk As Integer = 0
        For Each row As DataRow In data.Rows
            If data.Rows.IndexOf(row) = 0 Then
                Continue For
            End If
            If String.IsNullOrEmpty(row.Item(0)) Then
                Continue For
            ElseIf cekRow(row) Then
                Dim kodeanggota As String = row.Item(0)
                Dim nama As String = row.Item(1)
                Dim nik As String = row.Item(2)
                Dim telp As String = row.Item(3)
                Dim tempatlahir As String = row.Item(4)
                Dim tgllahir As String = DateTime.FromOADate(toDouble(row.Item(5))).ToString("yyyy-MM-dd")
                Dim alamat As String = row.Item(6)
                Dim jk As String = row.Item(7)
                Dim saudara As String = row.Item(8)
                Dim telpsaudara As String = row.Item(9)
                Dim tgldaftar As String = DateTime.FromOADate(toDouble(row.Item(10))).ToString("yyyy-MM-dd")


                Dim sqlDuplikasiKode = $"SELECT anggota where  idanggota={kodeanggota} or noktp={nik}"
                If getCount(sqlDuplikasiKode) > 0 Then
                    dialogError("Terjadi duplikasi data pada NIK atau Kode Anggota")
                    Continue For
                End If

                Dim sqlInsert = $"INSERT INTO public.tblanggota
(idanggota, jenisanggota, anggota, jk, tempatlahir, tanggallahir, noktp, alamat, notelp, pekerjaan, status, namasaudara, hpsaudara, foto, tahunmasuk, statusanggota, fp)
VALUES('{kodeanggota}', 'ANGGOTA', '{nama}','{jk}', '{tempatlahir}', '{tgllahir}', '{nik}', '{alamat}', '{telp}', 'LAIN-LAIN', 'LAIN-LAIN', '{saudara}', '{telpsaudara}', '','{tgldaftar}', 1, 0);"
                Debug.WriteLine(sqlInsert)
                If exc(sqlInsert) Then
                    jumlahDataMasuk += 1
                End If



            Else
                Dim baris = data.Rows.IndexOf(row) + 1
                dialogError("Terdapat kolom yang kosong di baris " & baris)
            End If

            ProgressBar1.Value += per
        Next
        ProgressBar1.Value = 100
        dialogInfo($"{jumlahDataMasuk.ToString} data dari {(data.Rows.Count - 1).ToString} berhasil diimport")
        ProgressBar1.Value = 0
        TBAfter.Text = ""
        FormAnggota.showData()

        For Each CTL In Me.Controls
            CTL.Enabled = True
        Next

    End Sub



    Private Sub ImportPelanggan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savefile As New SaveFileDialog
        Dim excel As String = "xlsx"

        If True Then
            excel = "xls"
        End If
        savefile.Filter = "File Excel|*." & excel
        savefile.DefaultExt = excel
        savefile.FileName = "Template Anggota." & excel
        Dim ds As DialogResult = savefile.ShowDialog

        If ds = DialogResult.OK Then
            copyFile(Application.StartupPath & "/template/TemplateAnggota." & excel, savefile.FileName)
            Try
                Process.Start("explorer.exe", "/select," & savefile.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class