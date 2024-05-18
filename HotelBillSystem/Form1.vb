Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Value += 1.0R
        If GunaProgressBar1.Value <= 10 Then
            Label2.Text = "loading....."
        ElseIf GunaProgressBar1.Value <= 30 Then
            Label2.Text = "loading....."
        ElseIf GunaProgressBar1.Value <= 50 Then
            Label2.Text = "     "
        ElseIf GunaProgressBar1.Value <= 70 Then
            Label2.Text = "please wait"
        ElseIf GunaProgressBar1.Value <= 100 Then
            Label2.Text = "welcome to Hotel Reception and biling system"
            If GunaProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                login.Show()


            End If
        End If
    End Sub
End Class
