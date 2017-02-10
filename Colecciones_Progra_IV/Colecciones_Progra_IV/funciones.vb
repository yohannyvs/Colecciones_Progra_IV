Imports System.Threading
Imports System.Collections
Public Class funciones

    Dim Ficha As String
    Dim caja_estado As Boolean ' true = libre / false = ocupado
    Dim cp As Integer = 1
    Dim cn As Integer = 1
    Dim psp As Integer = 1
    Dim psn As Integer = 1
    Dim client As New List(Of String)
    Dim tiempo As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos

    Public Function Fichas(area As String, cliente As String) As String 'crea el tipo de ficha

        If (area = "Cajas" And cliente = "Preferencial") Then
            Ficha = "CP - " + cp.ToString()
            client.Add(Ficha)
            cp += 1
        End If

        If (area = "Cajas" And cliente = "Normal") Then
            Ficha = "CN - " + cn.ToString()
            client.Add(Ficha)
            cn += 1
        End If

        If (area = "Pataforma de Servicios" And cliente = "Preferencial") Then
            Ficha = "PSP - " + psp.ToString()
            client.Add(Ficha)
            psp += 1
        End If

        If (area = "Pataforma de Servicios" And cliente = "Normal") Then
            Ficha = "PSN - " + psn.ToString()
            client.Add(Ficha)
            psn += 1
        End If

        'client.Add(Ficha)
        Return Ficha


    End Function

    Public Function cajas()
        caja_estado = True
        Dim fic As String

        If (caja_estado = True) Then
            For Each c As String In client

                If c.StartsWith("CP") Then
                    fic = c
                    client.Remove(c)
                    Return fic
                End If

                If c.StartsWith("CN") Then
                    fic = c
                    client.Remove(c)
                    Return c
                End If

                If c.StartsWith("PSN") Then
                    fic = c
                    client.Remove(c)
                    Return c
                End If

                If c.StartsWith("PSP") Then
                    fic = c
                    client.Remove(c)
                    Return c
                End If
            Next
        End If
    End Function

    Sub simulacion()

    End Sub

    Sub estadisticas()

    End Sub

End Class
