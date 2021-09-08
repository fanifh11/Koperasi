Public Class FormPengambilanSimpPokoknWajib

    Sub openForm()
        group_InformasiAnggota.Enabled = True
        groupBtn.Enabled = False
        lbl_NominalUang.Enabled = True

    End Sub

    Sub closeForm()
        group_InformasiAnggota.Enabled = False
        groupBtn.Enabled = True
        lbl_NominalUang.Enabled = False


    End Sub

    Sub showData()
        dgv_DataAnggota.DataSource = getData("select tblanggota.idanggota,tblanggota.anggota,sum(besar) from tblrekening inner join tblanggota on tblanggota.idanggota = tblrekening.idanggota 
            where (ketkategori = 'POKOK' or ketkategori = 'WAJIB') and fbayar = 1 and tglambil isnull group by tblanggota.idanggota")

        dgv_DataAnggota.Columns(0).HeaderText = "Kode Anggota"
        dgv_DataAnggota.Columns(1).HeaderText = "Nama"
        dgv_DataAnggota.Columns(2).HeaderText = "Besar"

        dgv_DataAnggota.Columns(2).DefaultCellStyle.Format = "c0"

        makeFillDG(dgv_DataAnggota)
        lbl_JumlahData.Text = "Jumlah Data : " & dgv_DataAnggota.Rows.Count

    End Sub

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormPengambilanSimpPokoknWajib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        closeForm()

    End Sub

    Private Sub btn_CariAnggota_Click(sender As Object, e As EventArgs) Handles btn_CariAnggota.Click
        FormCariAnggota.menu = "Pengambilan Simpanan Pokok dan Wajib"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()

    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        closeForm()
        lbl_NominalUang.Text = "0"
        clearForm(group_InformasiAnggota)
    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        openForm()

    End Sub

    Private Sub btn_Ambil_Click(sender As Object, e As EventArgs) Handles btn_Ambil.Click
        If String.IsNullOrEmpty(txt_KodeAnggota.Text) Then
            dialogError("Kode anggota masih kosong !")
            Return

        ElseIf String.IsNullOrEmpty(txt_Nama.Text) Then
            dialogError("Nama anggota masih kosong !")
            Return

        Else
            If dialog("Apakah anda yakin mengambil uang nasabah ?") Then
                exc("update tblrekening set tglambil = '" & dtp_TglAmbil.Value.ToString("yyyy-MM-dd HH:mm:ss") & "' where idanggota = '" & txt_KodeAnggota.Text & "' and ketkategori != 'SALDO AWAL' ")
                clearForm(group_InformasiAnggota)

                dialogInfo("Transaksi Berhasil")
                lbl_NominalUang.Text = "0"


            Else
                dialogInfo("Transaksi Batal")

            End If



        End If



    End Sub
End Class