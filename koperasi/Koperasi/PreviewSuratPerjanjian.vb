Public Class PreviewSuratPerjanjian

    Public idpinjam As String = ""

    Private Sub PreviewBuktiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from qpinjam where idpinjam = '" & idpinjam & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"
        Dim t As New Terbilang()
        t.Text = getValue(sql, "besarbayar").ToString

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.SuratPerjanjian.rdlc"
        Dim dt As DataTable = getData(sql)
        Dim bilang As New Terbilang
        bilang.Text = dt.Rows(0).Item("besarpinjam")
        addLogoRDLC(ReportViewer1)
        Dim jumlahPinjaman As String = Modul.numberFor(dt.Rows(0).Item("besarpinjam")) & " - ( " & bilang.Text & " )"
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(dt, DataTable)))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dataJaminan", CType(getData("select * from tbljaminankendaraan where idpinjam = '" & idpinjam & "'"), DataTable)))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dataKoperasi", CType(getData(sqlidentitas), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("terbilang", jumlahPinjaman))

        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class