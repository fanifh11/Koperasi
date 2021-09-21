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
        tbNama.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "nama")
        tbNoKtP.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "noktp")
        tbAlamatOrang.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "alamat")
        tbPekerjaan.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "pekerjaan")
        tbUmur.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "umur")
        tbToleransiTagihan.Text = getValue("select * from tblidentitas where idkoperasi = '1' ", "toleransi")
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(txtNamaKoperasi.Text) Then
            dialogError("Nama Koperasi masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txtNamaInstansi.Text) Then
            dialogError("Nama Instansi masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txtAlamat.Text) Then
            dialogError("Alamat masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txtPimpinan.Text) Then
            dialogError("Pimpinan masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txtBendahara.Text) Then
            dialogError("Bendahara masih kosong !")
            Return
        ElseIf String.IsNullOrEmpty(txtNoTelp.Text) Then
            dialogError("Nomor telepon masih kosong !")
            Return

        ElseIf String.IsNullOrEmpty(tbToleransiTagihan.Text) Then
            dialogError("Nomor telepon masih kosong !")
            Return
        Else
            If dialog("Apakah Anda yakin ?") Then
                Dim namakoperasi As String = txtNamaKoperasi.Text
                Dim namainstansi As String = txtNamaInstansi.Text
                Dim alamatkoperasi As String = txtAlamat.Text
                Dim pimpinan As String = txtPimpinan.Text
                Dim bendahara As String = txtBendahara.Text
                Dim notelp As String = txtNoTelp.Text
                Dim nama As String = tbNama.Text
                Dim alamat As String = tbAlamatOrang.Text
                Dim pekerjaan As String = tbPekerjaan.Text
                Dim umur As String = tbUmur.Text
                Dim ktp As String = tbNoKtP.Text
                Dim toleransi As String = tbToleransiTagihan.Text

                exc("update tblidentitas set
                namakoperasi = '" & namakoperasi & "',
                namainstansi = '" & namainstansi & "',
                alamatkoperasi = '" & alamatkoperasi & "',
                pimpinan = '" & pimpinan & "',
                bendahara = '" & bendahara & "',
                notelp = '" & notelp & "',
                nama = '" & nama & "',
                alamat = '" & alamat & "',
                umur = '" & umur & "',
                pekerjaan = '" & pekerjaan & "',
                noktp = '" & ktp & "',
                toleransi = " & toleransi & "
                where idkoperasi = '1'
                ")
            End If
        End If

    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub tbNoKtP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbUmur.KeyPress, tbNoKtP.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub tbToleransiTagihan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbToleransiTagihan.KeyPress
        onlyNumber(e)
    End Sub
End Class