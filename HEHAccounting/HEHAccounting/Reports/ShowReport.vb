Imports Telerik.Reporting

Public Class ShowReport

    Public RptName As String
    Public AllParamter As Parameter()

    Private ReadOnly MInstanceReport As InstanceReportSource = New InstanceReportSource()
    Private ReadOnly MReportBook As ReportBook = New ReportBook()
    Private ReadOnly MUriReportSource As UriReportSource = New UriReportSource()


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
    Sub AddSources()
        MUriReportSource.Uri = Application.StartupPath.ToString & "\Reports\" & RptName & ".trdp"
        MReportBook.ReportSources.Add(MUriReportSource)
        MInstanceReport.ReportDocument = MReportBook
        Me.RptViewer.ReportSource = MInstanceReport
        Me.RptViewer.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        Me.RptViewer.ShowPrintPreviewButton = False
    End Sub
    Public Sub AddParameters()
        For Each Par In AllParamter
            MInstanceReport.Parameters.Add(Par)
        Next
    End Sub
    Public Sub RefrechReport()
        RptViewer.RefreshReport()
    End Sub
    Private Sub ShowReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddSources()
        AddParameters()
        RefrechReport()
        'Dim typeReportSource = New Telerik.Reporting.TypeReportSource()
        'typeReportSource.TypeName = "HEHAccounting.SalesOrders, HEHAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        'Me.RptViewer.ReportSource = typeReportSource
        'RptViewer.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.RptViewer.PrintReport()
    End Sub
End Class
