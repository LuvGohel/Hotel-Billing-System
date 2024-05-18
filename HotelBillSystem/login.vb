Imports System.Data.SqlClient
Public Class login
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If username1.Text = "" Then
            MsgBox("Please enter username")
        ElseIf password1.Text = "" Then
            MsgBox("Please Enter password")
        Else
            Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("Select * FROM login where Username='" & username1.Text & "' AND Password='" & password1.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Dim username, password As String
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()
                        If sdr.HasRows Then
                            username = sdr("Username").ToString()
                            password = sdr("Password").ToString()
                            If username = username1.Text And password = password1.Text Then
                                Me.Hide()
                                controlpanel.Show()

                            End If
                        Else
                            MsgBox("maybe Username or Password are Wrong", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "login failed")
                        End If
                    End Using
                    con.Close()
                End Using
            End Using
        End If

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class