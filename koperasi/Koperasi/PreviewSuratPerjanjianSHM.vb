Public Class PreviewSuratPerjanjianSHM

    Public idpinjam As String = ""

    Private Sub PreviewBuktiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from qpinjam where idpinjam = '" & idpinjam & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"
        Dim t As New Terbilang()
        t.Text = getValue(sql, "besarbayar").ToString

        ReportViewer1.Reset()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.WindowState = FormWindowState.Maximized
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.SuratPerjanjianSHM.rdlc"
        Dim dt As DataTable = getData(sql)
        addLogoRDLC(ReportViewer1)

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(dt, DataTable)))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("jaminanSHM", CType(getData("select * from tbljaminanshm where idpinjam = '" & idpinjam & "'"), DataTable)))

        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("nama", getValue(sqlidentitas, "nama").ToString))


        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class