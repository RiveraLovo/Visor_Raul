Public Class Form1
    Private Sub BtnAutomatico_Click(sender As Object, e As EventArgs) Handles BtnAutomatico.Click
        Timer1.Enabled = True
    End Sub

    Private Sub BtnManual_Click(sender As Object, e As EventArgs) Handles BtnManual.Click
        BtnSiguiente.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim x As Integer
        Dim random As New Random
        x = random.Next(1, 10)
        If x = 1 Then PictureBox1.Image = PictureBox2.Image
        If x = 2 Then PictureBox1.Image = PictureBox3.Image
        If x = 3 Then PictureBox1.Image = PictureBox4.Image
        If x = 4 Then PictureBox1.Image = PictureBox5.Image
        If x = 4 Then PictureBox1.Image = PictureBox6.Image
        If x = 4 Then PictureBox1.Image = PictureBox7.Image
        If x = 4 Then PictureBox1.Image = PictureBox8.Image
        If x = 4 Then PictureBox1.Image = PictureBox9.Image
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer
        Dim random As New Random
        x = random.Next(1, 10)
        If x = 1 Then PictureBox1.Image = PictureBox2.Image
        If x = 2 Then PictureBox1.Image = PictureBox3.Image
        If x = 3 Then PictureBox1.Image = PictureBox4.Image
        If x = 4 Then PictureBox1.Image = PictureBox5.Image
        If x = 4 Then PictureBox1.Image = PictureBox6.Image
        If x = 4 Then PictureBox1.Image = PictureBox7.Image
        If x = 4 Then PictureBox1.Image = PictureBox8.Image
        If x = 4 Then PictureBox1.Image = PictureBox9.Image

        BtnSiguiente.Enabled = False
    End Sub

    Private Sub BtnSAlir_Click(sender As Object, e As EventArgs) Handles BtnSAlir.Click
        If MsgBox("Desea salir de la aplicacion?", vbQuestion + vbYesNo, "pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
