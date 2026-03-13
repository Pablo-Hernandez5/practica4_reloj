Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles horas.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles minutos.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Date_o = DateTime.Now.ToString("dd 'de 'MMMM 'del 'yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = DateTime.Now.ToString("HH:mm")

        Dim Time_mod = Time_o.Split(":")

        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        dias.Text = Day_o
        fecha.Text = Date_o



    End Sub

    Private Sub dias_Click(sender As Object, e As EventArgs) Handles dias.Click

    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label2.Text = ":" Then
            Label2.Text = ""
        ElseIf Label2.Text = "" Then
            Label2.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If config.Visible = False Then
            config.Visible = True
        ElseIf config.visible = True Then
            config.Visible = False

        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
