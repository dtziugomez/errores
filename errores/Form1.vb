Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim decKm As Decimal = Convert.ToDecimal(TextBox1.Text)
            Dim decLitros As Decimal = Convert.ToDecimal(TextBox2.Text)
            Dim decEficiencia As Decimal = decKm / decLitros
            TextBox3.Text = String.Format("(0:n)", decEficiencia)

        Catch fe As FormatException
            Dim msg As String = String.Format("error de formato:{0}/n stack trace: /n{1}", _
fe.Message, fe.StackTrace)
            MessageBox.Show(msg, fe.GetType().ToString())
        Catch divcero As DivideByZeroException
            Dim msg As String = String.Format("error division entre cero:{0}/n stack trace:/n{1}", _
divcero.Message, divcero.StackTrace)
            MessageBox.Show(msg, divcero.GetType().ToString())
        Catch ex As Exception
            Dim msg As String = String.Format("error:{0}/n stack trace:/n{1}", _
ex.Message, ex.StackTrace)
            MessageBox.Show(msg, ex.GetType().ToString())
        Catch
            Throw
        End Try
    End Sub
End Class
