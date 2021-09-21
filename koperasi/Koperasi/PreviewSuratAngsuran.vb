Public Class PreviewSuratAngsuran

    Public idpinjam As String = ""
    Public tagihan As New DataTable
    Private Sub PreviewBuktiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from qpinjam where idpinjam = '" & idpinjam & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"
        Dim t As New Terbilang()
        t.Text = getValue(sql, "besarbayar").ToString

        ReportViewer1.Reset()
ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
Me.WindowState = FormWindowState.Maximized
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.SuratAngsuran.rdlc"
        Dim dt As DataTable = getData(sql)
        Dim bilang As New Terbilang
        bilang.Text = dt.Rows(0).Item("besarpinjam")
        addLogoRDLC(ReportViewer1)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(dt, DataTable)))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("tagihan", CType(tagihan, DataTable)))
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("jaminan", CType(getData("select * from tbljaminankendaraan where idpinjam = '" & idpinjam & "'"), DataTable)))
        
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("denda", getValue(sql, "dendapersen").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("terbilang", bilang.Text))


        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class