Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim valor As Double
        Dim potencia As Double
        Dim resultado As Double

        valor = Convert.ToDouble(TextBox1.Text)
        potencia = Convert.ToDouble(TextBox2.Text)

        resultado = valor ^ potencia

        Label3.Text = resultado.ToString

    End Sub
End Class
