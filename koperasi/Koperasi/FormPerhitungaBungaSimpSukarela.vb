Public Class FormPerhitungaBungaSimpSukarela

    Dim pilihan As ArrayList = New ArrayList()

    Sub chooseAll()
        For Each idsukarela As DataGridViewRow In dgv_PilihData.Rows
            pilihan.Add(idsukarela.Cells(0).Value)

        Next
        showData()
    End Sub

    Sub removeAll()
        pilihan.Clear()
        showData()
    End Sub

    Public Sub getBungaAndSaldo(row As Integer)
        Dim idsukarela = dgv_DataTerpilih.Rows(row).Cells(0).Value
        Dim bunga As Double = Double.Parse(dgv_DataTerpilih.Rows(row).Cells(0).Value)

        Dim sql As String =
            "select DATE_PART('day', now() - 
            (SELECT tbltransaksi.tgltransaksi from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1)), 
            (SELECT tbltransaksi.saldo from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1) saldo  "

        Dim saldo As String = getValue(sql, "saldo")
        Dim totalHari = 0

        If String.IsNullOrEmpty(saldo) Then
            saldo = "0"
        Else
            totalHari = Double.Parse(getValue(sql, "date_part"))
        End If

        Dim totalBunga = Math.Round((((Double.Parse(saldo) * bunga) / 30) * totalHari))
        Dim faktur As String = Now.ToString("yyyyMMddHHmmss")
        Dim saldoAkhir = Double.Parse(totalBunga) + Double.Parse(saldo)

        If totalBunga > 0 Then
            If dialog("Apakah yakin untuk menghitung bunga ?") Then
                exc("insert into tbltransaksi 
                    (
                        fakturtransaksi,
                        idsukarela,
                        debet,
                        kredit,
                        tgltransaksi,
                        kettransaksi,
                        fb,
                        nocetak,
                        saldo,
                        ketkode,
                        flagpostingtransaksi
                    )values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        0,
                        '" & totalBunga & "',
                        now(),
                        'B',
                        0,
                        '0000',
                        '" & saldoAkhir & "',
                        'B',
                        0 
                    )
                    ")
                dialogInfo("Berhasil")
            End If
        Else
            dialogError("Bunga terhitung adalah 0")
        End If

    End Sub

    Sub showData()

        Dim terpilih As String = "("

        If pilihan.Count > 0 Then
            For Each idsukarela As String In pilihan
                terpilih = terpilih & idsukarela & ","
            Next
            terpilih = Strings.Left(terpilih, terpilih.Length - 1)
        Else
            terpilih = terpilih & "0"
        End If
        terpilih = terpilih & ")"

        dgv_PilihData.DataSource = getData("select idsukarela,idanggota,anggota from qsukarela where idsukarela not in" & terpilih & " order by idsukarela asc ")
        dgv_PilihData.Columns(0).HeaderText = "No Rek"
        dgv_PilihData.Columns(1).HeaderText = "Kode Anggota"
        dgv_PilihData.Columns(2).HeaderText = "Nama"
        lbl_JumData.Text = "Jumlah Data : " & dgv_PilihData.Rows.Count

        makeFillDG(dgv_PilihData)

        dgv_DataTerpilih.DataSource = getData("select idsukarela,idanggota,anggota from qsukarela where idsukarela in" & terpilih & " order by idsukarela asc ")
        dgv_DataTerpilih.Columns(0).HeaderText = "No Rek"
        dgv_DataTerpilih.Columns(1).HeaderText = "Kode Anggota"
        dgv_DataTerpilih.Columns(2).HeaderText = "Nama"
        lbl_JumData2.Text = "Jumlah Data : " & dgv_DataTerpilih.Rows.Count

        makeFillDG(dgv_DataTerpilih)

    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormPerhitungaBungaSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()

    End Sub

    Private Sub dgv_PilihData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_PilihData.CellClick
        If (e.RowIndex >= 0) Then
            pilihan.Add(dgv_PilihData.Rows(e.RowIndex).Cells(0).Value)
            showData()
        End If
    End Sub

    Private Sub dgv_DataTerpilih_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataTerpilih.CellClick
        Try
            pilihan.Remove(dgv_DataTerpilih.Rows(e.RowIndex).Cells(0).Value)
            showData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Hitung_Click(sender As Object, e As EventArgs) Handles btn_Hitung.Click
        If pilihan.Count > 0 Then
            Dim baris

            For Each row As DataGridViewRow In dgv_DataTerpilih.Rows
                getBungaAndSaldo(baris)
                baris = baris + 1
            Next

        End If
        removeAll()


    End Sub

    Private Sub btn_PindahSemua_Click(sender As Object, e As EventArgs) Handles btn_PindahSemua.Click
        chooseAll()
    End Sub

    Private Sub btn_KembalikaSemua_Click(sender As Object, e As EventArgs) Handles btn_KembalikaSemua.Click
        removeAll()

    End Sub
End Class