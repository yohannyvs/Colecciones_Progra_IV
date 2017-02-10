'Imports System.Windows.Forms.DataVisualization.Charting

Public Class Estadisticas

   
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Dim Estadisticas As New Form1
        Form1.Show()
        Me.Hide()
    End Sub
End Class