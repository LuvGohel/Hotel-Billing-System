Public Class controlpanel

    Sub switchPanel3(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        panel.Show()
    End Sub

    Private Sub controlpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel3(Client_form)
    End Sub

    Private Sub client_btn_Click(sender As Object, e As EventArgs) Handles client_btn.Click
        switchPanel3(Client_form)

    End Sub

    Private Sub room_btn_Click(sender As Object, e As EventArgs) Handles room_btn.Click
        switchPanel3(Restaurant_form)

    End Sub

    Private Sub Btn_restaurant_Click(sender As Object, e As EventArgs) Handles Btn_restaurant.Click
        switchPanel3(Room_form)
    End Sub

    Private Sub reservation_btn_Click(sender As Object, e As EventArgs) Handles reservation_btn.Click
        switchPanel3(Bill_form)

    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        login.Show()
        Me.Hide()
    End Sub
End Class