Public Class PreviewCetakBuku
    Public idsukarela As String = ""
    Public nocetak As String = ""

    Private Sub PreviewCetakBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from tbltransaksi where idsukarela = '" & idsukarela & "' and nocetak = '" & nocetak & "' order by idtransaksi desc limit 1"

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.CetakHasil.rdlc"

        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("tgltransaksi", getValue(Sql, "tgltransaksi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("ketkode", getValue(Sql, "ketkode").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("debet", getValue(Sql, "debet").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kredit", getValue(Sql, "kredit").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("saldo", getValue(Sql, "saldo").ToString))
        ReportViewer1.RefreshReport()
    End Sub
End Class