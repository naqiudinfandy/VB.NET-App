<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MODISTAFF_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MODISTAFF_A188417))
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRD_STAFF = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.TXT_FIRSTNAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_LASTNAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_AGE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_PICTURE = New System.Windows.Forms.Button()
        Me.TXT_PICTURE = New System.Windows.Forms.TextBox()
        Me.CMB_GENDER = New System.Windows.Forms.ComboBox()
        Me.CMB_JOBTYPE = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PIC_STAFF = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.BTN_CLEAR = New System.Windows.Forms.Button()
        Me.BTN_INSERT = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GRD_STAFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_STAFF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 31)
        Me.BTN_REFRESHDATE.Name = "BTN_REFRESHDATE"
        Me.BTN_REFRESHDATE.Size = New System.Drawing.Size(148, 23)
        Me.BTN_REFRESHDATE.TabIndex = 11
        Me.BTN_REFRESHDATE.Text = "REFRESH TIME"
        Me.BTN_REFRESHDATE.UseVisualStyleBackColor = False
        '
        'LBL_DATE
        '
        Me.LBL_DATE.AutoSize = True
        Me.LBL_DATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 11)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 10
        Me.LBL_DATE.Text = "DATE"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 670)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(75, 49)
        Me.BTN_BACK.TabIndex = 12
        Me.BTN_BACK.Text = "BACK"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(1088, 670)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 18
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(391, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 66)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "MODIFY STAFF"
        '
        'GRD_STAFF
        '
        Me.GRD_STAFF.AllowUserToAddRows = False
        Me.GRD_STAFF.AllowUserToDeleteRows = False
        Me.GRD_STAFF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRD_STAFF.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.GRD_STAFF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRD_STAFF.Location = New System.Drawing.Point(15, 95)
        Me.GRD_STAFF.Name = "GRD_STAFF"
        Me.GRD_STAFF.ReadOnly = True
        Me.GRD_STAFF.RowHeadersWidth = 51
        Me.GRD_STAFF.RowTemplate.Height = 24
        Me.GRD_STAFF.Size = New System.Drawing.Size(1148, 262)
        Me.GRD_STAFF.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Staff ID (generate automatically) :"
        '
        'TXT_ID
        '
        Me.TXT_ID.BackColor = System.Drawing.Color.White
        Me.TXT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(15, 410)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(417, 24)
        Me.TXT_ID.TabIndex = 22
        '
        'TXT_FIRSTNAME
        '
        Me.TXT_FIRSTNAME.BackColor = System.Drawing.Color.White
        Me.TXT_FIRSTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FIRSTNAME.Location = New System.Drawing.Point(15, 469)
        Me.TXT_FIRSTNAME.Name = "TXT_FIRSTNAME"
        Me.TXT_FIRSTNAME.Size = New System.Drawing.Size(417, 24)
        Me.TXT_FIRSTNAME.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Staff First Name : "
        '
        'TXT_LASTNAME
        '
        Me.TXT_LASTNAME.BackColor = System.Drawing.Color.White
        Me.TXT_LASTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LASTNAME.Location = New System.Drawing.Point(15, 537)
        Me.TXT_LASTNAME.Name = "TXT_LASTNAME"
        Me.TXT_LASTNAME.Size = New System.Drawing.Size(417, 24)
        Me.TXT_LASTNAME.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Staff Last Name : "
        '
        'TXT_AGE
        '
        Me.TXT_AGE.BackColor = System.Drawing.Color.White
        Me.TXT_AGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AGE.Location = New System.Drawing.Point(15, 605)
        Me.TXT_AGE.Name = "TXT_AGE"
        Me.TXT_AGE.Size = New System.Drawing.Size(417, 24)
        Me.TXT_AGE.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 585)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Staff Age (enter numbers only) : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(490, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Staff Gender : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(490, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Staff Job Type : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(489, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(260, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Click to select new staff picture : "
        '
        'BTN_PICTURE
        '
        Me.BTN_PICTURE.BackColor = System.Drawing.Color.LightPink
        Me.BTN_PICTURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PICTURE.Location = New System.Drawing.Point(492, 558)
        Me.BTN_PICTURE.Name = "BTN_PICTURE"
        Me.BTN_PICTURE.Size = New System.Drawing.Size(80, 71)
        Me.BTN_PICTURE.TabIndex = 34
        Me.BTN_PICTURE.Text = "Select Picture"
        Me.BTN_PICTURE.UseVisualStyleBackColor = False
        '
        'TXT_PICTURE
        '
        Me.TXT_PICTURE.BackColor = System.Drawing.Color.White
        Me.TXT_PICTURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PICTURE.Location = New System.Drawing.Point(578, 582)
        Me.TXT_PICTURE.Name = "TXT_PICTURE"
        Me.TXT_PICTURE.Size = New System.Drawing.Size(342, 24)
        Me.TXT_PICTURE.TabIndex = 35
        '
        'CMB_GENDER
        '
        Me.CMB_GENDER.BackColor = System.Drawing.Color.White
        Me.CMB_GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_GENDER.FormattingEnabled = True
        Me.CMB_GENDER.Location = New System.Drawing.Point(492, 410)
        Me.CMB_GENDER.Name = "CMB_GENDER"
        Me.CMB_GENDER.Size = New System.Drawing.Size(428, 26)
        Me.CMB_GENDER.TabIndex = 36
        '
        'CMB_JOBTYPE
        '
        Me.CMB_JOBTYPE.BackColor = System.Drawing.Color.White
        Me.CMB_JOBTYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_JOBTYPE.FormattingEnabled = True
        Me.CMB_JOBTYPE.Location = New System.Drawing.Point(492, 469)
        Me.CMB_JOBTYPE.Name = "CMB_JOBTYPE"
        Me.CMB_JOBTYPE.Size = New System.Drawing.Size(428, 26)
        Me.CMB_JOBTYPE.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(8, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(448, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "INSTRUCTION : Please enter all the details below : "
        '
        'PIC_STAFF
        '
        Me.PIC_STAFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_STAFF.Location = New System.Drawing.Point(955, 386)
        Me.PIC_STAFF.Name = "PIC_STAFF"
        Me.PIC_STAFF.Size = New System.Drawing.Size(208, 232)
        Me.PIC_STAFF.TabIndex = 40
        Me.PIC_STAFF.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackColor = System.Drawing.Color.Yellow
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.Location = New System.Drawing.Point(419, 659)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(141, 60)
        Me.BTN_UPDATE.TabIndex = 69
        Me.BTN_UPDATE.Text = "UPDATE"
        Me.BTN_UPDATE.UseVisualStyleBackColor = False
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackColor = System.Drawing.Color.Red
        Me.BTN_DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.Location = New System.Drawing.Point(566, 659)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(141, 60)
        Me.BTN_DELETE.TabIndex = 68
        Me.BTN_DELETE.Text = "DELETE"
        Me.BTN_DELETE.UseVisualStyleBackColor = False
        '
        'BTN_CLEAR
        '
        Me.BTN_CLEAR.BackColor = System.Drawing.Color.Silver
        Me.BTN_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLEAR.Location = New System.Drawing.Point(713, 659)
        Me.BTN_CLEAR.Name = "BTN_CLEAR"
        Me.BTN_CLEAR.Size = New System.Drawing.Size(141, 60)
        Me.BTN_CLEAR.TabIndex = 67
        Me.BTN_CLEAR.Text = "CLEAR"
        Me.BTN_CLEAR.UseVisualStyleBackColor = False
        '
        'BTN_INSERT
        '
        Me.BTN_INSERT.BackColor = System.Drawing.Color.Turquoise
        Me.BTN_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INSERT.Location = New System.Drawing.Point(272, 659)
        Me.BTN_INSERT.Name = "BTN_INSERT"
        Me.BTN_INSERT.Size = New System.Drawing.Size(141, 60)
        Me.BTN_INSERT.TabIndex = 66
        Me.BTN_INSERT.Text = "INSERT "
        Me.BTN_INSERT.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(416, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(387, 17)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Choose whether you want to INSERT, UPDATE OR DELETE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(578, 609)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "use '.jpg' file type"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1063, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRM_MODISTAFF_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 731)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_CLEAR)
        Me.Controls.Add(Me.BTN_INSERT)
        Me.Controls.Add(Me.PIC_STAFF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CMB_JOBTYPE)
        Me.Controls.Add(Me.CMB_GENDER)
        Me.Controls.Add(Me.TXT_PICTURE)
        Me.Controls.Add(Me.BTN_PICTURE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_AGE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_LASTNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_FIRSTNAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GRD_STAFF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Name = "FRM_MODISTAFF_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - INSERT STAFF DETAILS"
        CType(Me.GRD_STAFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_STAFF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GRD_STAFF As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents TXT_FIRSTNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_LASTNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_AGE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BTN_PICTURE As Button
    Friend WithEvents TXT_PICTURE As TextBox
    Friend WithEvents CMB_GENDER As ComboBox
    Friend WithEvents CMB_JOBTYPE As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PIC_STAFF As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents BTN_CLEAR As Button
    Friend WithEvents BTN_INSERT As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
End Class
