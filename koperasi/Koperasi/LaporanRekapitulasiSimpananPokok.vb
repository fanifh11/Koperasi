Public Class LaporanRekapitulasiSimpananPokok
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanRekapitulasiSimpananPokok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_anggota.SelectedIndex = 0
        showData()
    End Sub

    Public sql As String

    Sub showData()
        If cmb_anggota.SelectedIndex = 0 Then
            sql = "select anggota, to_char(now(), 'DD-MM-YYYY') as tglrekap, (select coalesce (sum(besar), 0) from qrekening where kategori = 'WAJIB' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as wajib, (select coalesce (sum(besar), 0) from qrekening where kategori = 'POKOK' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as pokok, (select coalesce(sum(besar), 0) from qrekening where kategori = 'SALDO AWAL' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as saldoawal from tblanggota where anggota ilike '%" & txt_search.Text & "%' and idanggota in (select idanggota from tblrekening group by idanggota)"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Tanggal Rekap"
            dgv_data_simpanan.Columns(2).HeaderText = "Wajib"
            dgv_data_simpanan.Columns(3).HeaderText = "Pokok"
            dgv_data_simpanan.Columns(4).HeaderText = "Saldo Awal"

            dgv_data_simpanan.Columns(2).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        ElseIf cmb_anggota.SelectedIndex = 1 Then
            sql = "select anggota, to_char(now(), 'DD-MM-YYYY') as tglrekap, (select coalesce (sum(besar), 0) from qrekening where kategori = 'WAJIB' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as wajib, (select coalesce (sum(besar), 0) from qrekening where kategori = 'POKOK' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as pokok, (select coalesce(sum(besar), 0) from qrekening where kategori = 'SALDO AWAL' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as saldoawal from tblanggota where anggota ilike '%" & txt_search.Text & "%' and idanggota not in (select idanggota from tblrekening group by idanggota)"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Tanggal Rekap"
            dgv_data_simpanan.Columns(2).HeaderText = "Wajib"
            dgv_data_simpanan.Columns(3).HeaderText = "Pokok"
            dgv_data_simpanan.Columns(4).HeaderText = "Saldo Awal"

            dgv_data_simpanan.Columns(2).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        ElseIf cmb_anggota.SelectedIndex = 2 Then
            sql = "select anggota, to_char(now(), 'DD-MM-YYYY') as tglrekap, (select coalesce (sum(besar), 0) from qrekening where kategori = 'WAJIB' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as wajib, (select coalesce (sum(besar), 0) from qrekening where kategori = 'POKOK' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as pokok, (select coalesce(sum(besar), 0) from qrekening where kategori = 'SALDO AWAL' and idanggota = tblanggota.idanggota and tglrek between '" & dtp_mulai.Value.ToString("dd-MM-yyyy") & "' and '" & dtp_sampai.Value.ToString("dd-MM-yyyy") & "') as saldoawal from tblanggota where anggota ilike '%" & txt_search.Text & "%'"
            dgv_data_simpanan.DataSource = getData(sql)
            dgv_data_simpanan.Columns(0).HeaderText = "Nama Anggota"
            dgv_data_simpanan.Columns(1).HeaderText = "Tanggal Rekap"
            dgv_data_simpanan.Columns(2).HeaderText = "Wajib"
            dgv_data_simpanan.Columns(3).HeaderText = "Pokok"
            dgv_data_simpanan.Columns(4).HeaderText = "Saldo Awal"

            dgv_data_simpanan.Columns(2).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(3).DefaultCellStyle.Format = "c0"
            dgv_data_simpanan.Columns(4).DefaultCellStyle.Format = "c0"

            lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_simpanan.Rows.Count
        End If
    End Sub

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        showData()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PreviewLaporanRekapitulasiSimpananPokok.sql = sql
        PreviewLaporanRekapitulasiSimpananPokok.mulai = dtp_mulai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanRekapitulasiSimpananPokok.sampai = dtp_sampai.Value.ToString("dd-MM-yyyy")
        PreviewLaporanRekapitulasiSimpananPokok.ShowDialog()
    End Sub
End Class