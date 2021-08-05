Public Class FormBayar
    Public no_rek As String

    Sub startState()
        group_InformasiAnggota.Enabled = False
        grupBtn.Enabled = True
        group_DataAnggota.Enabled = True
    End Sub

    Sub openForm()
        group_InformasiAnggota.Enabled = True
        group_DataAnggota.Enabled = False
        grupBtn.Enabled = False
    End Sub

    Sub lockForm()
        group_DataAnggota.Enabled = True
        group_InformasiAnggota.Enabled = False
        grupBtn.Enabled = True
    End Sub

    Sub showData()
        dgv_DataAnggota.DataSource = getData("select tglrek,tglbayar,anggota,ketsimp,besar from qrekening where fbayar = 1 and (tglbayar between '" & Now().ToString("yyyy-MM-dd") & " 00:00' and '" & Now().ToString("yyyy-MM-dd") & " 23:59') and anggota ilike '%" & txt_CariDataAnggota.Text & "%' 
         order by tglbayar desc")
        dgv_DataAnggota.Columns(0).HeaderText = "Tanggal Tagihan"
        dgv_DataAnggota.Columns(1).HeaderText = "Tanggal Bayar"
        dgv_DataAnggota.Columns(2).HeaderText = "Anggota"
        dgv_DataAnggota.Columns(3).HeaderText = "Jenis Simpan"
        dgv_DataAnggota.Columns(4).HeaderText = "Besar"

        dgv_DataAnggota.Columns(4).DefaultCellStyle.Format = "c0"

        lbl_JumData.Text = "Jumlah Data :" & dgv_DataAnggota.Rows.Count
    End Sub

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click

        Me.Close()
    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        openForm()
        clearForm(group_InformasiAnggota)

    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        lockForm()
        clearForm(group_InformasiAnggota)

    End Sub

    Private Sub FormBayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startState()
        showData()

    End Sub

    Private Sub btn_Bayar_Click(sender As Object, e As EventArgs) Handles btn_Bayar.Click

        If Modul.adaKosong(group_InformasiAnggota) Then
            dialogError("Isi terlebih dahulu formnya !")
        Else
            If dialog("Apakah ingin menambah data ?") Then
                exc("update tblrekening set fbayar = 1,tglbayar = '" & dtp_TglBayar.Value.ToString("yyyy-MM-dd HH:mm:ss") & "' where norek = '" & no_rek & "'")
            End If
            clearForm(group_InformasiAnggota)
        End If
        dialogInfo("Pembayaran Berhasil!")

        showData()
        lockForm()

    End Sub

    Private Sub btn_CariAnggota_Click(sender As Object, e As EventArgs) Handles btn_CariAnggota.Click
        FormCariAnggota.menu = "Bayar simpanan pokok"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()
    End Sub

    Private Sub txt_CariDataAnggota_TextChanged(sender As Object, e As EventArgs) Handles txt_CariDataAnggota.TextChanged
        showData()

    End Sub
End Class