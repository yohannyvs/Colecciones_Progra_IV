Public Class Form1

    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles Label1.Paint
        e.Graphics.RotateTransform(45)


    End Sub

    Private Sub PictureBox9_Paint(sender As Object, e As PaintEventArgs) Handles CajaPreferencial.Paint
        e.Graphics.RotateTransform(45)
    End Sub

   
   
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Dim fn As New funciones

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click

        Label7.Text = fn.Fichas(CBArea.SelectedItem.ToString(), CBcliente.SelectedItem.ToString())



    End Sub
    


    ' Public Shared Function ToBoolean(value As String) As Boolean
    '    If Label7 Then
    '        pbcliente1.Visible = True

    '   End If
    '  pbcliente1.Visible = False


    'End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pantalla.Items.Add(fn.cajas())
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbcliente4.Image = Image.FromFile(" C:\Users\Paola\Documents\GitHub\Colecciones_Progra_IV\Colecciones_Progra_IV\Colecciones_Progra_IV\imagenes\cliente1.jpg")
        pbcliente2.Image = Image.FromFile(" C:\Users\Paola\Documents\GitHub\Colecciones_Progra_IV\Colecciones_Progra_IV\Colecciones_Progra_IV\imagenes\cliente2.jpg")
        pbcliente3.Image = Image.FromFile(" C:\Users\Paola\Documents\GitHub\Colecciones_Progra_IV\Colecciones_Progra_IV\Colecciones_Progra_IV\imagenes\clienteesp1.jpg")
        pbcliente1.Image = Image.FromFile(" C:\Users\Paola\Documents\GitHub\Colecciones_Progra_IV\Colecciones_Progra_IV\Colecciones_Progra_IV\imagenes\clienteesp2.jpg")


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
