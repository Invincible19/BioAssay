Public Class Progressbar

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(2)
        If Guna2CircleProgressBar1.Value = 100 Then
            Timer1.Stop()

            Me.Hide()

            LOGIN.Show()

        End If
    End Sub

    Private Sub Progressbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class