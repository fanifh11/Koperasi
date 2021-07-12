Public Class DataIdentitasKoperasi

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub DataIdentitasKoperasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Sub showData()
        txtNamaKoperasi.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "namakoperasi")
        txtNamaInstansi.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "namainstansi")
        txtAlamat.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "alamatkoperasi")
        txtPimpinan.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "pimpinan")
        txtBendahara.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "bendahara")
        txtNoTelp.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "notelp")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dialog("Apakah Anda yakin ?") Then
            Dim namakoperasi As String = txtNamaKoperasi.Text
            Dim namainstansi As String = txtNamaInstansi.Text
            Dim alamatkoperasi As String = txtAlamat.Text
            Dim pimpinan As String = txtPimpinan.Text
            Dim bendahara As String = txtBendahara.Text
            Dim notelp As String = txtNoTelp.Text

            exc("update tblidentitas set
                namakoperasi = '" & namakoperasi & "',
                namainstansi = '" & namainstansi & "',
                alamatkoperasi = '" & alamatkoperasi & "',
                pimpinan = '" & pimpinan & "',
                bendahara = '" & bendahara & "',
                notelp = '" & notelp & "'

                where idkoperasi = '1'
                ")
        End If
    End Sub

End Class