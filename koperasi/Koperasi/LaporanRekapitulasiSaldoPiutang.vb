Public Class LaporanRekapitulasiSaldoPiutang
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub LaporanRekapitulasiSaldoPiutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub

    Public sql As String

    Sub showData()
        sql = "select idanggota, anggota, idpinjam, besarpinjam, saldopinjam, (besarpinjam - saldopinjam) as bayarpokok from qpinjam where tglpinjam < '" & dtp_TglRekap.Value.ToString("yyyy-MM-dd") & "'"
        dgv_DataPembayaran.DataSource = getData(sql)
        dgv_DataPembayaran.Columns(0).HeaderText = "ID Anggota"
        dgv_DataPembayaran.Columns(1).HeaderText = "Nama Anggota"
        dgv_DataPembayaran.Columns(2).HeaderText = "ID Pinjam"
        dgv_DataPembayaran.Columns(3).HeaderText = "Besar Pinjam"
        dgv_DataPembayaran.Columns(4).HeaderText = "Saldo Pinjam"
        dgv_DataPembayaran.Columns(5).HeaderText = "Bayar"

        lbl_JumData.Text = "Jumlah Data : " & dgv_DataPembayaran.Rows.Count
        lbl_Detail.Text = "Pinjam : " & numberFor(toDouble(getValue("select sum(besarpinjam) as besarpinjam from qpinjam where tglpinjam < '" & dtp_TglRekap.Value.ToString("yyyy-MM-dd") & "'", "besarpinjam"))) & " Bayar : " & numberFor(toDouble(getValue("select sum(besarpinjam - saldopinjam) as bayar from qpinjam where tglpinjam < '" & dtp_TglRekap.Value.ToString("yyyy-MM-dd") & "'", "bayar"))) & " Sisa : " & numberFor(toDouble(getValue("select sum(saldopinjam) as saldopinjam from qpinjam where tglpinjam < '" & dtp_TglRekap.Value.ToString("yyyy-MM-dd") & "'", "saldopinjam")))
    End Sub

    Private Sub btn_Proses_Click(sender As Object, e As EventArgs) Handles btn_Proses.Click
        showData()
    End Sub

    Private Sub btn_Cetak_Click(sender As Object, e As EventArgs) Handles btn_Cetak.Click
        PreviewLaporanRekapitulasiSaldoPiutang.sql = sql
        PreviewLaporanRekapitulasiSaldoPiutang.sampai = Now().ToString("yyyy-MM-dd")
        PreviewLaporanRekapitulasiSaldoPiutang.ShowDialog()
    End Sub
End Class