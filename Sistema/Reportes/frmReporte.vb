Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.reportViewer.RefreshReport()
    End Sub
End Class