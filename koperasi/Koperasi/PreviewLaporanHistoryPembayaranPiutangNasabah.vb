Public Class PreviewLaporanHistoryPembayaranPiutangNasabah

    Public sql As String

    Private Sub PreviewLaporanHistoryPembayaranPiutangNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.LaporanHistoryPembayaranPiutangNasabah.rdlc"
        addLogoRDLC(ReportViewer1)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(Sql), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("pimpinan", getValue(sqlidentitas, "pimpinan").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("bendahara", getValue(sqlidentitas, "bendahara").ToString))
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class