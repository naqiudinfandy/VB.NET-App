<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ORDER_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ORDER_A188417))
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRD_ORDER = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LST_ORDER = New System.Windows.Forms.ListBox()
        Me.lbl_totalprice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_CUSTID = New System.Windows.Forms.TextBox()
        Me.TXT_FIRSTNAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_LASTNAME = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PHONENUM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_GENDER = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_STAFFID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_STAFFNAME = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.GRD_ORDER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 28)
        Me.BTN_REFRESHDATE.Name = "BTN_REFRESHDATE"
        Me.BTN_REFRESHDATE.Size = New System.Drawing.Size(148, 23)
        Me.BTN_REFRESHDATE.TabIndex = 13
        Me.BTN_REFRESHDATE.Text = "REFRESH TIME"
        Me.BTN_REFRESHDATE.UseVisualStyleBackColor = False
        '
        'LBL_DATE
        '
        Me.LBL_DATE.AutoSize = True
        Me.LBL_DATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 8)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 12
        Me.LBL_DATE.Text = "DATE"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 625)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(75, 49)
        Me.BTN_BACK.TabIndex = 20
        Me.BTN_BACK.Text = "BACK"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(1166, 625)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 21
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(446, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 48)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ORDER HISTORY"
        '
        'GRD_ORDER
        '
        Me.GRD_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRD_ORDER.BackgroundColor = System.Drawing.SystemColors.Info
        Me.GRD_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRD_ORDER.Location = New System.Drawing.Point(57, 321)
        Me.GRD_ORDER.Name = "GRD_ORDER"
        Me.GRD_ORDER.RowHeadersWidth = 51
        Me.GRD_ORDER.RowTemplate.Height = 24
        Me.GRD_ORDER.Size = New System.Drawing.Size(953, 218)
        Me.GRD_ORDER.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(347, 626)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(524, 48)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ARTISTIC ART SUPPLIER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(858, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 57)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LST_ORDER
        '
        Me.LST_ORDER.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LST_ORDER.FormattingEnabled = True
        Me.LST_ORDER.ItemHeight = 16
        Me.LST_ORDER.Location = New System.Drawing.Point(1039, 87)
        Me.LST_ORDER.Name = "LST_ORDER"
        Me.LST_ORDER.Size = New System.Drawing.Size(191, 452)
        Me.LST_ORDER.TabIndex = 75
        '
        'lbl_totalprice
        '
        Me.lbl_totalprice.AutoSize = True
        Me.lbl_totalprice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalprice.ForeColor = System.Drawing.Color.White
        Me.lbl_totalprice.Location = New System.Drawing.Point(245, 553)
        Me.lbl_totalprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalprice.Name = "lbl_totalprice"
        Me.lbl_totalprice.Size = New System.Drawing.Size(29, 31)
        Me.lbl_totalprice.TabIndex = 78
        Me.lbl_totalprice.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(170, 553)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 31)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "RM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(51, 553)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 31)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Customer ID: "
        '
        'TXT_CUSTID
        '
        Me.TXT_CUSTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CUSTID.Location = New System.Drawing.Point(251, 119)
        Me.TXT_CUSTID.Name = "TXT_CUSTID"
        Me.TXT_CUSTID.Size = New System.Drawing.Size(275, 24)
        Me.TXT_CUSTID.TabIndex = 80
        '
        'TXT_FIRSTNAME
        '
        Me.TXT_FIRSTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FIRSTNAME.Location = New System.Drawing.Point(251, 168)
        Me.TXT_FIRSTNAME.Name = "TXT_FIRSTNAME"
        Me.TXT_FIRSTNAME.Size = New System.Drawing.Size(275, 24)
        Me.TXT_FIRSTNAME.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Customer First Name: "
        '
        'TXT_LASTNAME
        '
        Me.TXT_LASTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LASTNAME.Location = New System.Drawing.Point(251, 222)
        Me.TXT_LASTNAME.Name = "TXT_LASTNAME"
        Me.TXT_LASTNAME.Size = New System.Drawing.Size(275, 24)
        Me.TXT_LASTNAME.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 18)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Customer Last Name: "
        '
        'TXT_PHONENUM
        '
        Me.TXT_PHONENUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PHONENUM.Location = New System.Drawing.Point(251, 272)
        Me.TXT_PHONENUM.Name = "TXT_PHONENUM"
        Me.TXT_PHONENUM.Size = New System.Drawing.Size(275, 24)
        Me.TXT_PHONENUM.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(54, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 18)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Phone Number : "
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EMAIL.Location = New System.Drawing.Point(717, 118)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(275, 24)
        Me.TXT_EMAIL.TabIndex = 88
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(625, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Email : "
        '
        'TXT_GENDER
        '
        Me.TXT_GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_GENDER.Location = New System.Drawing.Point(717, 167)
        Me.TXT_GENDER.Name = "TXT_GENDER"
        Me.TXT_GENDER.Size = New System.Drawing.Size(275, 24)
        Me.TXT_GENDER.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(617, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Gender :"
        '
        'TXT_STAFFID
        '
        Me.TXT_STAFFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_STAFFID.Location = New System.Drawing.Point(717, 219)
        Me.TXT_STAFFID.Name = "TXT_STAFFID"
        Me.TXT_STAFFID.Size = New System.Drawing.Size(275, 24)
        Me.TXT_STAFFID.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(617, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 18)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Staff ID :"
        '
        'TXT_STAFFNAME
        '
        Me.TXT_STAFFNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_STAFFNAME.Location = New System.Drawing.Point(717, 272)
        Me.TXT_STAFFNAME.Name = "TXT_STAFFNAME"
        Me.TXT_STAFFNAME.Size = New System.Drawing.Size(275, 24)
        Me.TXT_STAFFNAME.TabIndex = 94
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(589, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 18)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Staff Name :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Khaki
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1078, 545)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 57)
        Me.Button2.TabIndex = 95
        Me.Button2.Text = "INVOICE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FRM_ORDER_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1253, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TXT_STAFFNAME)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXT_STAFFID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_GENDER)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_EMAIL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_PHONENUM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_LASTNAME)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_FIRSTNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CUSTID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_totalprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LST_ORDER)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GRD_ORDER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Name = "FRM_ORDER_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - ORDER HISTORY"
        CType(Me.GRD_ORDER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GRD_ORDER As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LST_ORDER As ListBox
    Friend WithEvents lbl_totalprice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CUSTID As TextBox
    Friend WithEvents TXT_FIRSTNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_LASTNAME As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_PHONENUM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_EMAIL As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_GENDER As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_STAFFID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_STAFFNAME As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
End Class
