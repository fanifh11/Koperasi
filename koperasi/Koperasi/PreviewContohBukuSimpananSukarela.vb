Public Class PreviewContohBukuSimpananSukarela
    Private Sub PreviewContohBukuSimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String = "select * from tblidentitas"

        ReportViewer1.Reset()
ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
Me.WindowState = FormWindowState.Maximized
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.ContohBukuSimpananSukarela.rdlc"

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(Sql), DataTable)))

        ReportViewer1.RefreshReport()
    End Sub
End Class