Imports System.Data.SqlClient
Public Class Restaurant_form


    Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
    Const rssingle As Integer = 1500
    Const rscouple As Integer = 2000
    Const rsfamily As Integer = 3000
    Dim no As Integer
    Dim cnt As Integer
    Dim sl As Integer
    Dim num As Integer

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If Txtroomadd.Text = "" Then
            MsgBox("Please enter  room number to add")
        Else
            no = Txtroomadd.Text
            cmbroom.Items.Add(no)
            MsgBox("room added successfull")
            Txtroomadd.Clear()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        cnt = cmbroom.Items.Count
        MsgBox("Total no. of room in hotel " & cnt)
    End Sub
    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_count_days.Click
        txt_nr.Text = DateDiff(DateInterval.Day, dt1.Value.Date, dt2.Value.Date)
    End Sub
    Private Sub btntotalroom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btntotalroom.Click
        If cmbcname.Text = "" Then
            MsgBox("Please enter client name")
        ElseIf cmbroom.Text = "" Then
            MsgBox("Please enter  room")
        ElseIf txt_nr.Text = "" Then
            MsgBox("Please number of room")

        Else
            num = txt_nr.Text
            If RadioButton1.Checked = True Then
                MsgBox(num * rssingle)
                Txt_bill.Text = Val(num * rssingle)
            End If
            If RadioButton2.Checked = True Then
                MsgBox(num * rscouple)
                Txt_bill.Text = Val(num * rscouple)
            End If
            If RadioButton3.Checked = True Then
                MsgBox(num * rsfamily)
                Txt_bill.Text = Val(num * rsfamily)
            End If
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If cmbroom.Text = "" Then
            MsgBox("Please enter room to delete from Available room")
        Else
            sl = cmbroom.SelectedIndex
            cmbroom.Items.RemoveAt(sl)
            MsgBox("This Room is deleted from Available room")
            cmbroom.Text = ""
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btn_Insert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Insert.Click
        If cmbcname.Text = "" Then
            MsgBox("Please enter client name")
        ElseIf cmbroom.Text = "" Then
            MsgBox("Please enter  room")
        ElseIf txt_nr.Text = "" Then
            MsgBox("Please number of room")
        ElseIf Txt_bill.Text = "" Then
            MsgBox("Please Enter roomm bill")

        Else

            Dim roomtyp As String = ""
            If RadioButton1.Checked = True Then
                roomtyp = "single"
            ElseIf RadioButton2.Checked = True Then
                roomtyp = "couple"
            ElseIf RadioButton2.Checked = True Then
                roomtyp = "family"
            End If

            conn.Open()
            Dim query As String = "insert into room values('" & cmbcname.Text & "','" & cmbroom.Text & "','" & dt1.Text & "','" & dt2.Text & "'," & txt_nr.Text & ",'" & roomtyp & "','" & Txt_bill.Text & "')"
            Dim cmd As New SqlCommand
            cmd.CommandText = query
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Inserted Sucessfull")
            LoadDataInGrid()
        End If
    End Sub
    Public Sub LoadDataInGrid()
        Dim command As New SqlCommand(" select * from room ", conn)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        room_view.DataSource = dt
    End Sub

    Private Sub cmbcname_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmd As New SqlCommand(" select * from client", conn)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()
        adp.Fill(tb)
        cmbcname.DataSource = tb
        cmbcname.DisplayMember = "ClientName"
        cmbcname.ValueMember = "id"
        conn.Close()
    End Sub

    Private Sub room_view_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles room_view.CellContentClick
        Dim roomtyp As String = ""
        If RadioButton1.Checked = True Then
            roomtyp = "single"
        ElseIf RadioButton2.Checked = True Then
            roomtyp = "couple"
        ElseIf RadioButton2.Checked = True Then
            roomtyp = "family"
        End If
        Dim i As Integer
        i = room_view.CurrentRow.Index
        cmbcname.Text = room_view.Item(0, i).Value
        cmbroom.Text = room_view.Item(1, i).Value
        dt1.Text = room_view.Item(2, i).Value
        dt2.Text = room_view.Item(3, i).Value
        txt_nr.Text = room_view.Item(4, i).Value
        roomtyp = room_view.Item(5, i).Value
        Txt_bill.Text = room_view.Item(6, i).Value
    End Sub



    Private Sub btn_delete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_delete.Click

        If cmbcname.Text = "" Then
            MsgBox("Please enter client name")
        ElseIf cmbroom.Text = "" Then
            MsgBox("Please enter  room")
        ElseIf txt_nr.Text = "" Then
            MsgBox("Please number of room")
        ElseIf Txt_bill.Text = "" Then
            MsgBox("Please Enter roomm bill")

        Else

            Dim roomtyp As String = ""
            If RadioButton1.Checked = True Then
                roomtyp = "single"
            ElseIf RadioButton2.Checked = True Then
                roomtyp = "couple"
            ElseIf RadioButton2.Checked = True Then
                roomtyp = "family"
            End If


            If MessageBox.Show("are you sure to delete this record?", "delete record", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim id As String = cmbcname.Text
                Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
                conn.Open()
                Dim command As New SqlCommand("delete room where Client_name = '" & id & "'", conn)
                command.ExecuteNonQuery()
                conn.Close()
                MsgBox("data delete successfull")
                LoadDataInGrid()


            End If
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

    Private Sub cmbroom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbroom.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If cmbroom.Text.Length >= 3 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid room  number")
            End If
        End If
    End Sub

    Private Sub txt_nr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nr.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If txt_nr.Text.Length >= 2 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid days")
            End If
        End If
    End Sub

    Private Sub Txtroomadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtroomadd.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If Txtroomadd.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid room add")
            End If
        End If
    End Sub



    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
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

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        cmbcname.Text = ""
        cmbroom.Text = ""
        txt_nr.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Txt_bill.Clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs)
        Dim roomtyp As String = ""
        If RadioButton1.Checked = True Then
            roomtyp = "single"
        ElseIf RadioButton2.Checked = True Then
            roomtyp = "couple"
        ElseIf RadioButton2.Checked = True Then
            roomtyp = "family"
        End If
        conn.Open()
        Dim query As String = "Update room set  Room_num = '" & cmbroom.Text & "', From =  '" & dt1.Text & "' , to = '" & dt2.Text & "' , Num_days = " & txt_nr.Text & " , Room_type = '" & roomtyp & "' , Total_bill = '" & Txt_bill.Text & "'  where ClientName = '" & cmbcname.Text & "' "
        Dim cmd As New SqlCommand
        cmd.CommandText = query
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
        MsgBox("updated sucessfull")
        LoadDataInGrid()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If cmbcname.Text = "" Then
            MsgBox("Please enter client Name")
        Else
            Dim name As String = txt_search.Text
            Dim command As New SqlCommand(" select * from room where Client_name ='" & name & "'", conn)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            room_view.DataSource = dt
        End If
    End Sub

    Private Sub Restaurant_form_Click(sender As Object, e As EventArgs) Handles Me.Click
        LoadDataInGrid()
    End Sub

    
End Class