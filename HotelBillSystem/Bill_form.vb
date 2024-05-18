Imports System.Data.SqlClient
Public Class Bill_form
    Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
    Private Sub Bill_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()

    End Sub


    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        If cmbname.Text = "" Then
            MsgBox("Please enter name")
        ElseIf Cmbrmn.Text = "" Then
            MsgBox("Please enter  roomnumer")
        ElseIf cmbfrom.Text = "" Then
            MsgBox("Please Enter from destination")
        ElseIf Cmbto.Text = "" Then
            MsgBox("Please Enter to destination")
        ElseIf cmbrb.Text = "" Then
            MsgBox("please enter room bill ")
        ElseIf cmbrestaurant.Text = "" Then
            MsgBox("please enter restaurant bill ")
        ElseIf cmbgst.Text = "" Then
            MsgBox("please enter gst ")
        ElseIf cmbtotal.Text = "" Then
            MsgBox("please enter last total ")

        Else
            conn.Open()
            Dim query As String = "insert into Bill values('" & cmbname.Text & "'," & Cmbrmn.Text & "," & cmbfrom.Text & "," & Cmbto.Text & "," & cmbrb.Text & "," & cmbrestaurant.Text & "," & cmbgst.Text & "," & cmbtotal.Text & ")"
            Dim cmd As New SqlCommand
            cmd.CommandText = query
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Inserted Sucessfull")
            LoadDataInGrid()
        End If
    End Sub
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand(" select * from Bill ", conn)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        billview.DataSource = dt
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        cmbname.SelectedIndex = -1
        Cmbrmn.Text = ""
        cmbfrom.Text = ""
        Cmbto.Text = ""
        cmbrmtyp.Text = ""
        cmbrb.Text = ""
        cmbrestaurant.Text = ""
        cmbgst.Text = ""
        cmbtotal.Text = ""
    End Sub

    Private Sub TOTAL_Click(sender As Object, e As EventArgs) Handles TOTAL.Click
        cmbtotal.Text = Val(cmbrb.Text) + Val(cmbrestaurant.Text) * 18 / 100

    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click


        RichTextBox1.AppendText("++++============================================++++" + vbNewLine)
        RichTextBox1.AppendText("" + vbNewLine)


        RichTextBox1.AppendText(vbTab + "" + vbNewLine + vbTab)

        RichTextBox1.AppendText(vbTab + "" + vbNewLine + vbTab)
        RichTextBox1.AppendText("Pay bill " + vbNewLine + vbTab)

        RichTextBox1.AppendText(vbTab + "" + vbNewLine + vbTab)
        RichTextBox1.AppendText("Client name " + vbTab & cmbname.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("room num " + vbTab & Cmbrmn.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("from bill " + vbTab & cmbfrom.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("to bill " + vbTab & Cmbto.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("room type:- " + vbTab & cmbrmtyp.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("room bill:- " + vbTab & cmbrb.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("restaurant bill:- " + vbTab & cmbrestaurant.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("G .s.t:- " + vbTab & cmbgst.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText("Grand tota:- " + vbTab & cmbtotal.Text + vbNewLine + vbTab)
        RichTextBox1.AppendText(vbTab + "" + vbNewLine + vbTab)

        RichTextBox1.AppendText("+++ =======================================+++" + vbNewLine + vbTab)


        RichTextBox1.AppendText("Contact us 999264914 " + vbNewLine + vbTab)

            RichTextBox1.AppendText(vbTab + "" + vbNewLine + vbTab)
        Printbill.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, Font, Brushes.Black, 140, 140)

    End Sub

    'Private Sub billview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles billview.CellContentClick



    'End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs)
        If cmbname.Text = "" Then
            MsgBox("Please enter name")
        ElseIf Cmbrmn.Text = "" Then
            MsgBox("Please enter  roomnumer")
        ElseIf cmbfrom.Text = "" Then
            MsgBox("Please Enter from destination")
        ElseIf Cmbto.Text = "" Then
            MsgBox("Please Enter to destination")
        ElseIf cmbrb.Text = "" Then
            MsgBox("please enter room bill ")
        ElseIf cmbrestaurant.Text = "" Then
            MsgBox("please enter restaurant bill ")
        ElseIf cmbgst.Text = "" Then
            MsgBox("please enter gst ")
        ElseIf cmbtotal.Text = "" Then
            MsgBox("please enter last total ")

        Else

            If MessageBox.Show("are you sure to delete this record?", "delete record", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim id As String = cmbname.Text
                conn.Open()
                Dim command As New SqlCommand("delete Bill  where Name = '" & id & "'", conn)
                command.ExecuteNonQuery()
                conn.Close()
                MsgBox("data delete successfull")
                LoadDataInGrid()
            End If
        End If
    End Sub

    Private Sub cmbname_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        Dim cmd As New SqlCommand(" select * from client", conn)
        Dim adp As New SqlDataAdapter(cmd)
        Dim tb As New DataTable()
        adp.Fill(tb)
        cmbname.DataSource = tb
        cmbname.DisplayMember = "ClientName"
        cmbname.ValueMember = "id"
    End Sub

    Private Sub cmbrmn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        Dim cmmd As New SqlCommand(" select * from room", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        Cmbrmn.DataSource = ta
        Cmbrmn.DisplayMember = "Room_num"
        Cmbrmn.ValueMember = "Client_name"
    End Sub

    Private Sub cmbfrom_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmmd As New SqlCommand(" select * from room", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        cmbfrom.DataSource = ta
        cmbfrom.DisplayMember = "From"
        cmbfrom.ValueMember = "Client_name"
        conn.Close()
    End Sub

    Private Sub Cmbto_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmmd As New SqlCommand(" select * from room", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        Cmbto.DataSource = ta
        Cmbto.DisplayMember = "to"
        Cmbto.ValueMember = "Client_name"
        conn.Close()
    End Sub

    Private Sub cmbrmtyp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmmd As New SqlCommand(" select * from room", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        cmbrmtyp.DataSource = ta
        cmbrmtyp.DisplayMember = "Room_type"
        cmbrmtyp.ValueMember = "Client_name"
        conn.Close()
    End Sub

    Private Sub cmbrb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmmd As New SqlCommand(" select * from room", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        cmbrb.DataSource = ta
        cmbrb.DisplayMember = "Total_bill"
        cmbrb.ValueMember = "Client_name"
        conn.Close()
    End Sub

    Private Sub cmbrestaurant_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\Visual Studio 2010\Projects\HotelBillSystem\HotelBillSystem\Hotel.mdf;Integrated Security=True;User Instance=True")
        conn.Open()
        Dim cmmd As New SqlCommand(" select * from restaurant", conn)
        Dim adpd As New SqlDataAdapter(cmmd)
        Dim ta As New DataTable()
        adpd.Fill(ta)
        cmbrestaurant.DataSource = ta
        cmbrestaurant.DisplayMember = "total"
        cmbrestaurant.ValueMember = "C_name"
        conn.Close()
    End Sub


    Private Sub cmbname_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cmbname.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter Letters only ")
        End If
        If cmbname.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  client name")
            End If
        End If
    End Sub

    Private Sub Cmbrmn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbrmn.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If Cmbrmn.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  client name")
            End If
        End If
    End Sub

    Private Sub cmbrmtyp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbrmtyp.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter Letters only ")
        End If
        If cmbrmtyp.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  room type name")
            End If
        End If
    End Sub

    Private Sub cmbrb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbrb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If cmbrb.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  bill ")
            End If
        End If
    End Sub

    Private Sub cmbrestaurant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbrestaurant.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If cmbrestaurant.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  restaurant bill")
            End If
        End If
    End Sub

    Private Sub cmbgst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbgst.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If cmbgst.Text.Length >= 20 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  gst number")
            End If
        End If
    End Sub

    Private Sub cmbtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtotal.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Enter number only ")
        End If
        If cmbtotal.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("invalid  total")
            End If
        End If
    End Sub


    'Private Sub billview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles billview.CellClick
    '    Dim i As Integer
    '    i = billview.CurrentRow.Index
    '    cmbname.Text = billview.Item(0, i).Value
    '    Cmbrmn.Text = billview.Item(1, i).Value
    '    cmbfrom.Text = billview.Item(2, i).Value
    '    Cmbto.Text = billview.Item(3, i).Value
    '    cmbrmtyp.Text = billview.Item(4, i).Value
    '    cmbrb.Text = billview.Item(5, i).Value
    '    cmbrestaurant.Text = billview.Item(6, i).Value
    '    cmbgst.Text = billview.Item(7, i).Value
    '    cmbtotal.Text = billview.Item(8, i).Value
    'End Sub
End Class