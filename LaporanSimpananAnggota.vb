Public Class LaporanSimpananAnggota
    Public idanggota As String = ""
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanSimpananAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_simpanan_pokok.SelectedIndex = 0
        showData()
    End Sub

    Private Sub cmb_simpanan_pokok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_simpanan_pokok.SelectedIndexChanged
        showData()
    End Sub

    Public sql As String

    Sub showData()
        If cmb_simpanan_pokok.SelectedIndex = 0 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek from qrekening where anggota ilike '%" & txt_search.Text & "%' and kategori = 'POKOK' and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_data_simpanan.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_data_simpanan.Columns(4).HeaderText = "Besar"
            dgv_data_simpanan.Columns(5).HeaderText = "Keterangan"
            dgv_data_simpanan.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        ElseIf cmb_simpanan_pokok.SelectedIndex = 1 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek from qrekening where anggota ilike '%" & txt_search.Text & "%' and kategori = 'WAJIB' and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_data_simpanan.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_data_simpanan.Columns(4).HeaderText = "Besar"
            dgv_data_simpanan.Columns(5).HeaderText = "Keterangan"
            dgv_data_simpanan.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        ElseIf cmb_simpanan_pokok.SelectedIndex = 2 Then
            sql = "select idanggota, anggota, jk, jenissimpanan, besar, ketsimp, to_char(tglrek, 'DD-MM-YYYY') as tglrek from qrekening where anggota ilike '%" & txt_search.Text & "%' and kategori = 'SALDO AWAL' and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "'"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "ID Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(2).HeaderText = "Jenis Kelamin"
            dgv_data_simpanan.Columns(3).HeaderText = "Jenis Simpanan"
            dgv_data_simpanan.Columns(4).HeaderText = "Besar"
            dgv_data_simpanan.Columns(5).HeaderText = "Keterangan"
            dgv_data_simpanan.Columns(6).HeaderText = "Tanggal Rekening"

            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanSimpananAnggota.sql = sql
        PreviewLaporanSimpananAnggota.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanSimpananAnggota.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanSimpananAnggota.ShowDialog()
    End Sub
End Class