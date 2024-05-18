<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlpanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(controlpanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.client_btn = New System.Windows.Forms.Button()
        Me.reservation_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.Btn_restaurant = New System.Windows.Forms.Button()
        Me.room_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.client_btn)
        Me.Panel1.Controls.Add(Me.reservation_btn)
        Me.Panel1.Controls.Add(Me.logout_btn)
        Me.Panel1.Controls.Add(Me.Btn_restaurant)
        Me.Panel1.Controls.Add(Me.room_btn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 749)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Aqua
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(58, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'client_btn
        '
        Me.client_btn.BackColor = System.Drawing.Color.Aqua
        Me.client_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client_btn.Location = New System.Drawing.Point(0, 173)
        Me.client_btn.Name = "client_btn"
        Me.client_btn.Size = New System.Drawing.Size(200, 39)
        Me.client_btn.TabIndex = 0
        Me.client_btn.Text = "clients"
        Me.client_btn.UseVisualStyleBackColor = False
        '
        'reservation_btn
        '
        Me.reservation_btn.BackColor = System.Drawing.Color.Cyan
        Me.reservation_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservation_btn.Location = New System.Drawing.Point(0, 304)
        Me.reservation_btn.Name = "reservation_btn"
        Me.reservation_btn.Size = New System.Drawing.Size(200, 38)
        Me.reservation_btn.TabIndex = 0
        Me.reservation_btn.Text = "Bill"
        Me.reservation_btn.UseVisualStyleBackColor = False
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Red
        Me.logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.Location = New System.Drawing.Point(0, 431)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(200, 37)
        Me.logout_btn.TabIndex = 4
        Me.logout_btn.Text = "Log Out"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'Btn_restaurant
        '
        Me.Btn_restaurant.BackColor = System.Drawing.Color.Cyan
        Me.Btn_restaurant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_restaurant.Location = New System.Drawing.Point(0, 261)
        Me.Btn_restaurant.Name = "Btn_restaurant"
        Me.Btn_restaurant.Size = New System.Drawing.Size(200, 37)
        Me.Btn_restaurant.TabIndex = 1
        Me.Btn_restaurant.Text = "Restaurant"
        Me.Btn_restaurant.UseVisualStyleBackColor = False
        '
        'room_btn
        '
        Me.room_btn.BackColor = System.Drawing.Color.Cyan
        Me.room_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.room_btn.Location = New System.Drawing.Point(0, 218)
        Me.room_btn.Name = "room_btn"
        Me.room_btn.Size = New System.Drawing.Size(200, 37)
        Me.room_btn.TabIndex = 0
        Me.room_btn.Text = "Rooms"
        Me.room_btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.pnlmain)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 126)
        Me.Panel2.TabIndex = 0
        '
        'pnlmain
        '
        Me.pnlmain.Location = New System.Drawing.Point(197, 0)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(1170, 749)
        Me.pnlmain.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(201, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1166, 743)
        Me.Panel3.TabIndex = 2
        '
        'controlpanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "controlpanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "controlpanel"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents client_btn As Button
    Friend WithEvents reservation_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents Btn_restaurant As Button
    Friend WithEvents room_btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlmain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
