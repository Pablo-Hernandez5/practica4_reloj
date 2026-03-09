Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles horas.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles minutos.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de 'mmmm 'del 'yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        dias.Text = Day_o
        fecha.Text = Date_o



    End Sub
End Class
