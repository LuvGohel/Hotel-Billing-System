Imports System.Data.SqlClient
Public Class Room_form
    Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
    Dim bf As Integer
    Dim lh As Integer
    Dim dn As Integer
    Dim fd As Integer
    Dim total As Integer
    Public Sub Room_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_breakfast.Text += 1
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt_lunch.Text += 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt_dinner.Text += 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt_buffet.Text += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_breakfast.Text -= 1
        If txt_breakfast.Text < 0 Then
            txt_breakfast.Text = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt_lunch.Text -= 1
        If txt_lunch.Text < 0 Then
            txt_lunch.Text = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt_dinner.Text -= 1
        If txt_dinner.Text < 0 Then
            txt_dinner.Text = 0
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt_buffet.Text -= 1
        If txt_buffet.Text < 0 Then
            txt_buffet.Text = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_total.Click
        bf = txt_breakfast.Text * 200
        lh = txt_lunch.Text * 300
        dn = txt_dinner.Text * 200
        fd = txt_buffet.Text * 1000
        Txt_total.Text = bf + lh + dn + fd
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_breakfast.Text = 0
        txt_lunch.Text = 0
        txt_dinner.Text = 0
        txt_buffet.Text = 0
        Txt_total.Text = 0
    End Sub

    Private Sub cmbcname_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand(" select * from client", conn)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()
        adp.Fill(tb)
        cmbcname.DataSource = tb
        cmbcname.DisplayMember = "ClientName"
        cmbcname.ValueMember = "id"

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If Txt_total.Text = "" Then
            MsgBox("please enter total amount to insert")
        Else
            conn.Open()
            Dim query As String = "insert into restaurant values('" & cmbcname.Text & "','" & Txt_total.Text & "')"
            Dim cmd As New SqlCommand
            cmd.CommandText = query
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Inserted Sucessfull")
        End If
    End Sub

    Private Sub cmbcname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbcname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter Letters only ")
        End If
        If cmbcname.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  client name")
            End If
        End If
    End Sub

    Private Sub txt_breakfast_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txt_breakfast.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txt_breakfast.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid number")
            End If
        End If
    End Sub

    Private Sub Txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_total.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
    End Sub

    Private Sub txt_buffet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buffet.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txt_buffet.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid number")
            End If
        End If
    End Sub

    Private Sub txt_dinner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dinner.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txt_dinner.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid number")
            End If
        End If
    End Sub

    Private Sub txt_lunch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lunch.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If Txt_total.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid number")
            End If
        End If

    End Sub

    Private Sub cmbcname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcname.SelectedIndexChanged

    End Sub
End Class

