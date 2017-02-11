Imports System.Threading
Imports System.Collections
Public Class funciones

    Dim Ficha As String
    'Dim caja_estado As Boolean ' true = libre / false = ocupado
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

        Return Ficha


    End Function

    Public Function cajas(caja_estado As Boolean)

        Dim fic As String

        If (caja_estado = True) Then
            For Each c As String In client

                If c.StartsWith("CP") Then
                    fic = c
                    client.Remove(c)
                    Return fic
                End If
            Next

            For Each c As String In client

                If c.StartsWith("PSP") Then
                    fic = c
                    client.Remove(c)
                    Return fic
                End If
            Next

            For Each c As String In client

                If c.StartsWith("PSN") Or c.StartsWith("CN") Then
                    fic = c
                    client.Remove(c)
                    Return fic
                End If
            Next
        End If
    End Function

    Sub mover(client As PictureBox, caja As Integer)
        Dim count As Integer = 0
        If caja = 1 Then
            While (count <= 68)
                client.Location = New Point(client.Location.X + 10, client.Location.Y)
                client.Location = New Point(client.Location.X, client.Location.Y - 3)
                count += 2
                Threading.Thread.Sleep(50)
            End While
        End If

        If caja = 2 Then
            While (count <= 68)
                client.Location = New Point(client.Location.X + 10, client.Location.Y)
                count += 2
                Threading.Thread.Sleep(50)
            End While
        End If

        If caja = 3 Then
            While (count <= 68)
                client.Location = New Point(client.Location.X + 10, client.Location.Y)
                client.Location = New Point(client.Location.X, client.Location.Y + 3.4)
                count += 2
                Threading.Thread.Sleep(50)
            End While
        End If

        If caja = 4 Then
            While (count <= 50)
                client.Location = New Point(client.Location.X + 7, client.Location.Y)
                client.Location = New Point(client.Location.X, client.Location.Y + 11)
                count += 3
                Threading.Thread.Sleep(50)
            End While
        End If

    End Sub

    Sub simulacion()

    End Sub

    Sub estadisticas()

    End Sub

End Class
