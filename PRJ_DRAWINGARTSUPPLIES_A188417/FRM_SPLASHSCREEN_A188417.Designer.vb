<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SPLASHSCREEN_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_SPLASHSCREEN_A188417))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_MATRIC = New System.Windows.Forms.TextBox()
        Me.BTN_START = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 144)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ARTISTIC ART " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SUPPLIER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matric Number : "
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.SystemColors.Info
        Me.TXT_NAME.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(522, 220)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(248, 34)
        Me.TXT_NAME.TabIndex = 3
        Me.TXT_NAME.Text = "ANONYMOUS"
        '
        'TXT_MATRIC
        '
        Me.TXT_MATRIC.BackColor = System.Drawing.SystemColors.Info
        Me.TXT_MATRIC.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MATRIC.Location = New System.Drawing.Point(522, 263)
        Me.TXT_MATRIC.Name = "TXT_MATRIC"
        Me.TXT_MATRIC.Size = New System.Drawing.Size(248, 34)
        Me.TXT_MATRIC.TabIndex = 4
        Me.TXT_MATRIC.Text = "A123456"
        '
        'BTN_START
        '
        Me.BTN_START.BackColor = System.Drawing.Color.LightBlue
        Me.BTN_START.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_START.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTN_START.Location = New System.Drawing.Point(561, 315)
        Me.BTN_START.Name = "BTN_START"
        Me.BTN_START.Size = New System.Drawing.Size(157, 67)
        Me.BTN_START.TabIndex = 5
        Me.BTN_START.Text = "START"
        Me.BTN_START.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(12, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(45, 17)
        Me.lbl_date.TabIndex = 6
        Me.lbl_date.Text = "DATE"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(717, 404)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 35)
        Me.BTN_EXIT.TabIndex = 7
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 38)
        Me.BTN_REFRESHDATE.Name = "BTN_REFRESHDATE"
        Me.BTN_REFRESHDATE.Size = New System.Drawing.Size(148, 23)
        Me.BTN_REFRESHDATE.TabIndex = 8
        Me.BTN_REFRESHDATE.Text = "REFRESH TIME"
        Me.BTN_REFRESHDATE.UseVisualStyleBackColor = False
        '
        'FRM_SPLASHSCREEN_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.BTN_START)
        Me.Controls.Add(Me.TXT_MATRIC)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_SPLASHSCREEN_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_MATRIC As TextBox
    Friend WithEvents BTN_START As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents BTN_REFRESHDATE As Button
End Class
