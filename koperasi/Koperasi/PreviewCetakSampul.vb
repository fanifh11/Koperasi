Public Class PreviewCetakSampul
    Public idsukarela As String = ""

    Private Sub PreviewCetakSampul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from qsukarela where idsukarela = '" & idsukarela & "'"

        ReportViewer1.Reset()
ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
Me.WindowState = FormWindowState.Maximized
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.CetakNasabah.rdlc"

        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("no_nasabah", getValue(sql, "idanggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("no_rek", getValue(sql, "kode").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("nama", getValue(sql, "anggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("jk", getValue(sql, "jk").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("jenissimpanan", getValue(sql, "ketsukarela").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamat", getValue(sql, "alamat").ToString))
        ReportViewer1.RefreshReport()
    End Sub
End Class