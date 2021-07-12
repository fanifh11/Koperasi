Public Class FormLihatTagihan

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Sub showData()
        If cmb_Pilihan.SelectedIndex = 0 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'POKOK'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 1 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'WAJIB'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 2 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where anggota ilike '%" & txt_Cari.Text & "%' and kategori = 'SALDO AWAL'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count
        End If
    End Sub
    Private Sub FormLihatTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Pilihan.SelectedIndex = 0
    End Sub

    Private Sub cmb_Pilihan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pilihan.SelectedIndexChanged
        If cmb_Pilihan.SelectedIndex = 0 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where kategori = 'POKOK'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 1 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where kategori = 'WAJIB'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count
        ElseIf cmb_Pilihan.SelectedIndex = 2 Then
            dgv_Data.DataSource = getData("select anggota,jk,idanggota,jenissimpanan,besar,ketsimp from qrekening where kategori = 'SALDO AWAL'")
            dgv_Data.Columns(0).HeaderText = "Nama Anggota"
            dgv_Data.Columns(1).HeaderText = "Jenis Kelamin"
            dgv_Data.Columns(2).HeaderText = "N/A"
            dgv_Data.Columns(3).HeaderText = "Jenis"
            dgv_Data.Columns(4).HeaderText = "Besar"
            dgv_Data.Columns(5).HeaderText = "Keterangan"
            lbl_JumData.Text = "Jumlah data : " & dgv_Data.Rows.Count

        End If
    End Sub

    Private Sub txt_Cari_TextChanged(sender As Object, e As EventArgs) Handles txt_Cari.TextChanged
        showData()

    End Sub
End Class