Imports System.Data.SqlClient
Public Class Client_form
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
    Private Sub add_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles add_btn.Click
        If txtID.Text = "" Then
            MsgBox("Please enter id")
        ElseIf txtName.Text = "" Then
            MsgBox("Please enter  Name")
        ElseIf txtAadharNumber.Text = "" Then
            MsgBox("Please Enter aadhar Number")
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please Enter phone number")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please Enter Email Address")
        Else
            con.Open()
            Dim query As String = "insert into client values(" & txtID.Text & ",'" & txtName.Text & "' , '" & txtAadharNumber.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & " ')"
            Dim cmd As New SqlCommand
            cmd.CommandText = query
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Inserted Sucessfull")
            showData()
            autoid()
        End If
    End Sub
    Private Sub showData()
        Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        Dim command As New SqlCommand(" select * from client ", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        ClientView.DataSource = dt
        con.Close()

    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click

        If txtID.Text = "" Then
            MsgBox("Please enter id")
        ElseIf txtName.Text = "" Then
            MsgBox("Please enter  Name")
        ElseIf txtAadharNumber.Text = "" Then
            MsgBox("Please Enter aadhar Number")
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please Enter phone number")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please Enter Email Address")
        Else
            If MessageBox.Show("are you sure to delete this record?", "delete record", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim id As Integer = txtID.Text
                con.Open()
                Dim command As New SqlCommand("delete client where id = '" & id & "'", con)
                command.ExecuteNonQuery()
                con.Close()
                MsgBox("data delete successfull")
                showData()
            End If
        End If
    End Sub


    Private Sub autoid()
        Dim cmd As SqlCommand = New SqlCommand("select Max(id) as NUMS from client")
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        rdr.Read()
        If rdr("NUMS").ToString() <> "" Then

            txtID.Text = Integer.Parse(rdr("NUMS").ToString()) + 1
        Else
            txtID.Text = 1
        End If
        rdr.Close()

        con.Close()
    End Sub




    'Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
    '    If txtID.Text = "" Then
    '        MsgBox("Please enter id")
    '    ElseIf txtName.Text = "" Then
    '        MsgBox("Please enter  Name")
    '    ElseIf txtAadharNumber.Text = "" Then
    '        MsgBox("Please Enter aadhar Number")
    '    ElseIf txtPhone.Text = "" Then
    '        MsgBox("Please Enter phone number")
    '    ElseIf txtEmail.Text = "" Then
    '        MsgBox("Please Enter Email Address")
    '    Else
    '        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2017\Project\HotelManagment\HotelManagment\Login.mdf;Integrated Security=True")
    '        con.Open()
    '        Dim query As String = "Update client set ClientName = '" & txtName.Text & "',aadharnumber='" & txtAadharNumber.Text & "', Phone = " & txtPhone.Text & " , Email = '" & txtEmail.Text & "'  where id = " & txtID.Text & " "
    '        Dim cmd As New SqlCommand
    '        cmd.CommandText = query
    '        cmd.Connection = con
    '        cmd.ExecuteNonQuery()
    '        MsgBox("updated sucessfull")
    '        showData()
    '    End If
    'End Sub
    Private Sub clear()
        txtID.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtAadharNumber.Clear()
        txtEmail.Clear()
        txtName.Clear()
    End Sub


    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        clear()
    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        If TxT_search.Text = "" Then
            MsgBox("Please enter  Name")
        Else
            Dim name As String = TxT_search.Text
            Dim command As New SqlCommand(" select * from client where ClientName ='" & name & "'", con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            ClientView.DataSource = dt
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txtID.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid number")
            End If
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter Letters only ")
        End If
        If txtName.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid name")
            End If
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txtPhone.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid phone number")
            End If
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress

    End Sub

    Private Sub Client_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        autoid()
        showData()
    End Sub



    Private Sub txtAadharNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAadharNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter numbers only ")
        End If
        If txtAadharNumber.Text.Length >= 12 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid aadhar  number")
            End If
        End If
    End Sub

    Private Sub TxT_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxT_search.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter letters only ")
        End If
        If TxT_search.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid search value")
            End If
        End If
    End Sub

    Private Sub clientview_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles clientview.CellClick
        Dim i As Integer
        i = clientview.CurrentRow.Index
        txtID.Text = clientview.Item(0, i).Value
        txtName.Text = clientview.Item(1, i).Value
        txtAadharNumber.Text = clientview.Item(2, i).Value
        txtPhone.Text = clientview.Item(3, i).Value
        txtEmail.Text = clientview.Item(4, i).Value
    End Sub
End Class