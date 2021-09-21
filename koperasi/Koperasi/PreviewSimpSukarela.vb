Public Class PreviewSimpSukarela
    Public idsukarela As String = ""

    Private Sub PreviewSimpSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select nocetak, anggota, idsukarela, to_char(tgltransaksi, 'DD-MM-YYYY') as tgltransaksi, kettransaksi, debet, kredit, saldo from qtransaksi where idsukarela = '" & idsukarela & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.DataSimpananSukarela.rdlc"
        addLogoRDLC(ReportViewer1)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(sql), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("pimpinan", getValue(sqlidentitas, "pimpinan").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("bendahara", getValue(sqlidentitas, "bendahara").ToString))
        ReportViewer1.RefreshReport()
    End Sub
End Class