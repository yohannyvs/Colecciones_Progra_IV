Imports System.Threading

Public Class Form1

    Dim list_pb As New List(Of PictureBox)
    Dim estado As New Boolean
    Dim c As Integer

    Dim fn As New funciones

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click
        Try
            Label7.Text = fn.Fichas(CBArea.SelectedItem.ToString(), CBcliente.SelectedItem.ToString())
        Catch ex As Exception
            MessageBox.Show("Escoja un tipo de Ficha")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        est_caja()
        't1.Start()
        'mover_cliente()
    End Sub

    Sub est_caja()
        Dim v1 As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos
        Dim v2 As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos
        Dim v3 As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos
        Dim v4 As Integer = CInt(Int((20 * Rnd()) + 1)) 'Crea ramdom para los tiempos

        If lb_c1.BackColor = Color.Green Then
            mover_cliente(True, 1)

        ElseIf lb_c2.BackColor = Color.Green Then
            mover_cliente(True, 2)

        ElseIf lb_c3.BackColor = Color.Green Then
            mover_cliente(True, 3)

        ElseIf lb_c4.BackColor = Color.Green Then
            mover_cliente(True, 4)
        End If


    End Sub

    Sub mover_cliente(est_caja As Boolean, num_caja As Integer)
        Try
            pantalla.Items.Add(fn.cajas(est_caja))
            list_pb(0).Location = New Point(545, 196)
            fn.mover(list_pb(0), num_caja)
            bloquear_caja()
            list_pb.Add(list_pb(0))
            Thread.Sleep(4000)
            list_pb(0).Location = New Point(list_pb(1).Location.X, list_pb(1).Location.Y) 'Extrae la posicion del picturbox
            list_pb(1).Location = New Point(545, 196) 'ingresa posicion para el picturebox
            list_pb.Remove(list_pb(0))
            
        Catch ex As Exception
            MessageBox.Show("No hay clientes en espera")
        End Try
    End Sub

    Sub bloquear_caja()
        Dim p1 As Point = New Point(list_pb(0).Location.X, list_pb(0).Location.Y)
        Dim p2 As Point = New Point(895, 91)
        Dim p3 As Point = New Point(895, 196)
        Dim p4 As Point = New Point(895, 301)
        Dim p5 As Point = New Point(664, 383)


        If Point.Equals(p1, p2) = True Then
            lb_c1.BackColor = Color.Red
        End If

        If Point.Equals(p1, p3) = True Then
            lb_c2.BackColor = Color.Red
        End If

        If Point.Equals(p1, p4) = True Then
            lb_c3.BackColor = Color.Red
        End If

        If Point.Equals(p1, p5) = True Then
            lb_c4.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbcliente4.Image = Image.FromFile("..\..\imagenes\cliente1.jpg")
        pbcliente2.Image = Image.FromFile("..\..\imagenes\cliente2.jpg")
        pbcliente3.Image = Image.FromFile("..\..\imagenes\clienteesp1.jpg")
        pbcliente1.Image = Image.FromFile("..\..\imagenes\clienteesp2.jpg")

        list_pb.Add(pbcliente1)
        list_pb.Add(pbcliente2)
        list_pb.Add(pbcliente3)
        list_pb.Add(pbcliente4)
        list_pb.Add(pbcliente5)
        list_pb.Add(pbcliente6)
        list_pb.Add(pbcliente7)

        ' pbcliente1.Image = Image.FromFile("../../imagenes/cliente1jpg")
        '  pbcliente1.Image = Image.FromFile(" C:\Users\Paola\Documents\GitHub\Colecciones_Progra_IV\Colecciones_Progra_IV\Colecciones_Progra_IV\imagenes\cliente1.jpg")
        ' End If


    End Sub


    Private Sub btnestadistica_Click(sender As Object, e As EventArgs) Handles btnestadistica.Click
        Dim Form1 As New Estadisticas
        Estadisticas.Show()
        Me.Hide()
    End Sub
End Class
