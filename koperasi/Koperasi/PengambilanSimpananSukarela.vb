Public Class PengambilanSimpananSukarela
    Public idsukarela As String = ""
    Public bunga As Double
    Dim tempidtransaksi As String = ""

    Sub openMainForm()
        group_data_anggota.Enabled = False
        group_informasi_anggota.Enabled = True
        grupBtn.Enabled = False
        group_Nominal.Enabled = True
    End Sub

    Sub lockMainForm()
        group_data_anggota.Enabled = True
        group_informasi_anggota.Enabled = False
        grupBtn.Enabled = True
        group_Nominal.Enabled = False
    End Sub

    Public Sub getBungaAndSaldo()
        Dim sql As String =
            "select date_part('day', now() - 
                (select tbltransaksi.tgltransaksi from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1)),
                (select tbltransaksi.saldo from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1) saldo
            "
        Dim saldo As String = getValue(sql, "saldo")
        Dim meng As Double = 0

        If String.IsNullOrEmpty(saldo) Then
            saldo = "0"
        Else
            meng = Double.Parse(getValue(sql, "date_part"))
        End If

        lbl_jumlah.Text = saldo
        txt_bunga.Text = Math.Round(((Double.Parse(saldo) * bunga) / 30) * meng)
    End Sub

    Sub showData()
        dgv_data_anggota.DataSource = getData("select anggota, jk, idanggota, ketsimp, besar from qrekening")
        dgv_data_anggota.Columns(0).HeaderText = "Nama Anggota"
        dgv_data_anggota.Columns(1).HeaderText = "Jenis Kelamin"
        dgv_data_anggota.Columns(2).HeaderText = "Kode Anggota"
        dgv_data_anggota.Columns(3).HeaderText = "Keterangan Simpanan"
        dgv_data_anggota.Columns(4).HeaderText = "Besar"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_anggota.Rows.Count
    End Sub

    Private Sub button_keluar_Click(sender As Object, e As EventArgs) Handles button_keluar.Click
        Me.Close()
    End Sub

    Private Sub PengambilanSimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lockMainForm()
        showData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        openMainForm()
        clearForm(group_informasi_anggota)
    End Sub

    Private Sub btn_ambil_Click(sender As Object, e As EventArgs) Handles btn_ambil.Click
        If String.IsNullOrEmpty(txt_besar_ambil.Text) Then
            dialogError("Form besar ambil harus diisi!")
            lbl_jumlah.Text = 0
        Else
            Dim jenissimpanan As String = txt_jenis_simpanan.Text
            Dim tanggalambil As String = dtp_tanggal_ambil.Value.ToString("yyyy-MM-dd")
            Dim besarsambil As String = txt_besar_ambil.Text
            Dim bunga As String = txt_bunga.Text
            Dim nocetak As Integer = getCount("select * from tbltransaksi where idsukarela = '" & idsukarela & "'") + 1
            Dim saldo As String = lbl_jumlah.Text
            Dim ketkode As String = getValue("select ketjenis from tbljenis where jenissimpanan = '" & jenissimpanan & "'", "ketjenis")

            If dialog("Apakah anda yakin ?") Then
                Dim faktur As String = Now.ToString("yyyyMMddHHmmss")
                Dim saldobaru As String = (Double.Parse(saldo) - Double.Parse(besarsambil)).ToString
                Debug.WriteLine("insert into tbltransaksi
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
                    )
                    values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        '" & besarsambil & "',
                        0,
                        '" & tanggalambil & "',
                        '" & jenissimpanan & "',
                        0,
                        '" & nocetak & "',
                        '" & saldobaru & "',
                        '" & ketkode & "',
                        0
                    )")
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
                    )
                    values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        '" & besarsambil & "',
                        0,
                        '" & tanggalambil & "',
                        '" & jenissimpanan & "',
                        0,
                        '" & nocetak & "',
                        '" & saldobaru & "',
                        '" & ketkode & "',
                        0
                    )")
                If bunga > 0 Then
                    Dim saldoakhir As String = (Double.Parse(saldobaru) + bunga).ToString
                    Dim nocetakakhir As String = nocetak + 1
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
                    )
                    values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        0,
                        '" & bunga & "',
                        '" & tanggalambil & "',
                        'B',
                        0,
                        '" & nocetakakhir & "',
                        '" & saldoakhir & "',
                        '" & ketkode & "',
                        0
                    )")
                End If
            End If
        End If

        lockMainForm()
        clearForm(group_informasi_anggota)
    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        lockMainForm()
        clearForm(group_informasi_anggota)

    End Sub

    Private Sub btn_cari_anggota_Click(sender As Object, e As EventArgs) Handles btn_cari_anggota.Click
        FormCariAnggota.menu = "Pengambilan simp sukarela"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()

    End Sub

    Private Sub btn_harpus_Click(sender As Object, e As EventArgs) Handles btn_harpus.Click
        If dialog("Apakah anda yakin hapus data ini ?") Then
            exc("delete from tbltransaksi where idtransaksi = '" & tempidtransaksi & "'")
            showData()
        End If
    End Sub

    Private Sub txt_besar_ambil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_besar_ambil.KeyPress
        onlyNumber(e)
    End Sub
End Class