Public Class Form1

    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles Label1.Paint
        e.Graphics.RotateTransform(45)

    End Sub

    Private Sub PictureBox9_Paint(sender As Object, e As PaintEventArgs) Handles CajaPreferencial.Paint
        e.Graphics.RotateTransform(45)
    End Sub

    Dim fn As New funciones

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click
        Try
            Label7.Text = fn.Fichas(CBArea.SelectedItem.ToString(), CBcliente.SelectedItem.ToString())
        Catch ex As Exception
            MessageBox.Show("Escoja un tipo de Ficha")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            pantalla.Items.Add(fn.cajas(True))
            fn.mover(pbcliente1, 4)
        Catch ex As Exception
            MessageBox.Show("No hay clientes en espera")
        End Try
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbcliente4.Image = Image.FromFile("..\..\imagenes\cliente1.jpg")
        pbcliente2.Image = Image.FromFile("..\..\imagenes\cliente2.jpg")
        pbcliente3.Image = Image.FromFile("..\..\imagenes\clienteesp1.jpg")
        pbcliente1.Image = Image.FromFile("..\..\imagenes\clienteesp2.jpg")


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
