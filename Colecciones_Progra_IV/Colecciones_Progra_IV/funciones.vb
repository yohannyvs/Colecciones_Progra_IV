Imports System.Threading
Imports System.Collections
Public Class funciones

    Dim Ficha As String
    Dim caja_estado As Boolean ' true = libre / false = ocupado
    Dim cp As Integer = 1
    Dim cn As Integer = 1
    Dim psp As Integer = 1
    Dim psn As Integer = 1
    Dim client As List(Of funciones)
    'Dim f As New funciones
    Dim tiempo As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos

    Public Function Fichas(area As String, cliente As String) As String 'crea el tipo de ficha

        If (area = "Cajas" And cliente = "Preferencial") Then
            Ficha = "CP - " + cp.ToString()
            cp += 1
        End If

        If (area = "Cajas" And cliente = "Normal") Then
            Ficha = "CN - " + cn.ToString()
            cn += 1
        End If

        If (area = "Pataforma de Servicios" And cliente = "Preferencial") Then
            Ficha = "PSP - " + psp.ToString()
            psp += 1
        End If

        If (area = "Pataforma de Servicios" And cliente = "Normal") Then
            Ficha = "PSN - " + psn.ToString()
            psn += 1
        End If

        Return Ficha

    End Function

    Sub cajas()
        If (caja_estado = True) Then

        End If
    End Sub

    Sub simulacion()

    End Sub

    Sub estadisticas()

    End Sub

End Class
