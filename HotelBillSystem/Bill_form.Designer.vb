<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill_form))
        Me.print = New System.Windows.Forms.Button()
        Me.TOTAL = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.cmbfrom = New System.Windows.Forms.ComboBox()
        Me.Cmbrmn = New System.Windows.Forms.ComboBox()
        Me.cmbname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.billview = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Printbill = New System.Windows.Forms.PrintPreviewDialog()
        Me.Cmbto = New System.Windows.Forms.ComboBox()
        Me.cmbrmtyp = New System.Windows.Forms.ComboBox()
        Me.cmbrb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbrestaurant = New System.Windows.Forms.ComboBox()
        Me.cmbgst = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbtotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.billview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.Location = New System.Drawing.Point(162, 515)
        Me.print.Margin = New System.Windows.Forms.Padding(2)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(122, 41)
        Me.print.TabIndex = 52
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'TOTAL
        '
        Me.TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.Location = New System.Drawing.Point(162, 447)
        Me.TOTAL.Margin = New System.Windows.Forms.Padding(2)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(104, 41)
        Me.TOTAL.TabIndex = 51
        Me.TOTAL.Text = "Total"
        Me.TOTAL.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(282, 447)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(116, 41)
        Me.btnclear.TabIndex = 50
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(26, 447)
        Me.insert.Margin = New System.Windows.Forms.Padding(2)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(104, 41)
        Me.insert.TabIndex = 49
        Me.insert.Text = "INSERT"
        Me.insert.UseVisualStyleBackColor = True
        '
        'cmbfrom
        '
        Me.cmbfrom.FormattingEnabled = True
        Me.cmbfrom.Items.AddRange(New Object() {"None"})
        Me.cmbfrom.Location = New System.Drawing.Point(176, 135)
        Me.cmbfrom.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbfrom.Name = "cmbfrom"
        Me.cmbfrom.Size = New System.Drawing.Size(186, 21)
        Me.cmbfrom.TabIndex = 48
        '
        'Cmbrmn
        '
        Me.Cmbrmn.FormattingEnabled = True
        Me.Cmbrmn.Items.AddRange(New Object() {"none"})
        Me.Cmbrmn.Location = New System.Drawing.Point(176, 95)
        Me.Cmbrmn.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbrmn.Name = "Cmbrmn"
        Me.Cmbrmn.Size = New System.Drawing.Size(186, 21)
        Me.Cmbrmn.TabIndex = 47
        '
        'cmbname
        '
        Me.cmbname.FormattingEnabled = True
        Me.cmbname.Items.AddRange(New Object() {"None"})
        Me.cmbname.Location = New System.Drawing.Point(176, 49)
        Me.cmbname.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(186, 21)
        Me.cmbname.TabIndex = 46
        Me.cmbname.Text = "enter Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "room type:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "to:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Room number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "from:-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Name :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(395, 49)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(711, 394)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.billview)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(703, 368)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'billview
        '
        Me.billview.AllowDrop = True
        Me.billview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billview.Location = New System.Drawing.Point(-3, 0)
        Me.billview.Margin = New System.Windows.Forms.Padding(2)
        Me.billview.Name = "billview"
        Me.billview.ReadOnly = True
        Me.billview.RowTemplate.Height = 24
        Me.billview.Size = New System.Drawing.Size(702, 372)
        Me.billview.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(703, 368)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "print preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(4, 5)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(695, 359)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'PrintDocument1
        '
        '
        'Printbill
        '
        Me.Printbill.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Printbill.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Printbill.ClientSize = New System.Drawing.Size(400, 300)
        Me.Printbill.Document = Me.PrintDocument1
        Me.Printbill.Enabled = True
        Me.Printbill.Icon = CType(resources.GetObject("Printbill.Icon"), System.Drawing.Icon)
        Me.Printbill.Name = "PrintPreviewDialog1"
        Me.Printbill.Visible = False
        '
        'Cmbto
        '
        Me.Cmbto.FormattingEnabled = True
        Me.Cmbto.Items.AddRange(New Object() {"none"})
        Me.Cmbto.Location = New System.Drawing.Point(176, 168)
        Me.Cmbto.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmbto.Name = "Cmbto"
        Me.Cmbto.Size = New System.Drawing.Size(186, 21)
        Me.Cmbto.TabIndex = 54
        '
        'cmbrmtyp
        '
        Me.cmbrmtyp.FormattingEnabled = True
        Me.cmbrmtyp.Items.AddRange(New Object() {"none"})
        Me.cmbrmtyp.Location = New System.Drawing.Point(176, 206)
        Me.cmbrmtyp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbrmtyp.Name = "cmbrmtyp"
        Me.cmbrmtyp.Size = New System.Drawing.Size(186, 21)
        Me.cmbrmtyp.TabIndex = 55
        '
        'cmbrb
        '
        Me.cmbrb.FormattingEnabled = True
        Me.cmbrb.Items.AddRange(New Object() {"0"})
        Me.cmbrb.Location = New System.Drawing.Point(176, 250)
        Me.cmbrb.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbrb.Name = "cmbrb"
        Me.cmbrb.Size = New System.Drawing.Size(186, 21)
        Me.cmbrb.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 248)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "room bill:-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 287)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "restaurant:-"
        '
        'cmbrestaurant
        '
        Me.cmbrestaurant.FormattingEnabled = True
        Me.cmbrestaurant.Location = New System.Drawing.Point(176, 289)
        Me.cmbrestaurant.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbrestaurant.Name = "cmbrestaurant"
        Me.cmbrestaurant.Size = New System.Drawing.Size(186, 21)
        Me.cmbrestaurant.TabIndex = 59
        '
        'cmbgst
        '
        Me.cmbgst.FormattingEnabled = True
        Me.cmbgst.Items.AddRange(New Object() {"18"})
        Me.cmbgst.Location = New System.Drawing.Point(176, 340)
        Me.cmbgst.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbgst.Name = "cmbgst"
        Me.cmbgst.Size = New System.Drawing.Size(60, 21)
        Me.cmbgst.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 338)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "g.s.t"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 385)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "total:-"
        '
        'cmbtotal
        '
        Me.cmbtotal.Location = New System.Drawing.Point(176, 387)
        Me.cmbtotal.Name = "cmbtotal"
        Me.cmbtotal.Size = New System.Drawing.Size(186, 20)
        Me.cmbtotal.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 340)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 24)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "%"
        '
        'Bill_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 665)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbgst)
        Me.Controls.Add(Me.cmbrestaurant)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbrb)
        Me.Controls.Add(Me.cmbrmtyp)
        Me.Controls.Add(Me.Cmbto)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.cmbfrom)
        Me.Controls.Add(Me.Cmbrmn)
        Me.Controls.Add(Me.cmbname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bill_form"
        Me.Text = "Bill_form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.billview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents print As Button
    Friend WithEvents TOTAL As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents insert As Button
    Friend WithEvents cmbfrom As ComboBox
    Friend WithEvents Cmbrmn As ComboBox
    Friend WithEvents cmbname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents billview As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Printbill As PrintPreviewDialog
    Friend WithEvents Cmbto As ComboBox
    Friend WithEvents cmbrmtyp As ComboBox
    Friend WithEvents cmbrb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbrestaurant As ComboBox
    Friend WithEvents cmbgst As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbtotal As TextBox
    Friend WithEvents Label10 As Label
End Class
