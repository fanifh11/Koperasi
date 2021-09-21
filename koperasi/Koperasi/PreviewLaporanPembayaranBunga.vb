Public Class PreviewLaporanPembayaranBunga

    Public sql As String
    Public mulai As String
    Public sampai As String

    Private Sub PreviewLaporanPembayaranBunga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.LaporanPembayaranBunga.rdlc"
        addLogoRDLC(ReportViewer1)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(sql), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("pimpinan", getValue(sqlidentitas, "pimpinan").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("bendahara", getValue(sqlidentitas, "bendahara").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("mulai", mulai))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("sampai", sampai))
        ReportViewer1.RefreshReport()
    End Sub
End Class