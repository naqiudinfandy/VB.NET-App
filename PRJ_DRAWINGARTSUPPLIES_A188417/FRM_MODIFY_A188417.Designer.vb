<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MODIFY_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MODIFY_A188417))
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_MODIPRODUCT = New System.Windows.Forms.Button()
        Me.BTN_MODISTAFF = New System.Windows.Forms.Button()
        Me.BTN_MODICUSTOMER = New System.Windows.Forms.Button()
        Me.LBL_SUBTITLE = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 489)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(75, 49)
        Me.BTN_BACK.TabIndex = 4
        Me.BTN_BACK.Text = "BACK"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 30)
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
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 10)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 10
        Me.LBL_DATE.Text = "DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(269, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 54)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "MODIFY OPTION"
        '
        'BTN_MODIPRODUCT
        '
        Me.BTN_MODIPRODUCT.BackColor = System.Drawing.SystemColors.Info
        Me.BTN_MODIPRODUCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MODIPRODUCT.Location = New System.Drawing.Point(64, 234)
        Me.BTN_MODIPRODUCT.Name = "BTN_MODIPRODUCT"
        Me.BTN_MODIPRODUCT.Size = New System.Drawing.Size(343, 79)
        Me.BTN_MODIPRODUCT.TabIndex = 16
        Me.BTN_MODIPRODUCT.Text = "MODIFY PRODUCT"
        Me.BTN_MODIPRODUCT.UseVisualStyleBackColor = False
        '
        'BTN_MODISTAFF
        '
        Me.BTN_MODISTAFF.BackColor = System.Drawing.SystemColors.Info
        Me.BTN_MODISTAFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MODISTAFF.Location = New System.Drawing.Point(510, 234)
        Me.BTN_MODISTAFF.Name = "BTN_MODISTAFF"
        Me.BTN_MODISTAFF.Size = New System.Drawing.Size(329, 79)
        Me.BTN_MODISTAFF.TabIndex = 18
        Me.BTN_MODISTAFF.Text = "MODIFY STAFF"
        Me.BTN_MODISTAFF.UseVisualStyleBackColor = False
        '
        'BTN_MODICUSTOMER
        '
        Me.BTN_MODICUSTOMER.BackColor = System.Drawing.SystemColors.Info
        Me.BTN_MODICUSTOMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MODICUSTOMER.Location = New System.Drawing.Point(289, 357)
        Me.BTN_MODICUSTOMER.Name = "BTN_MODICUSTOMER"
        Me.BTN_MODICUSTOMER.Size = New System.Drawing.Size(329, 78)
        Me.BTN_MODICUSTOMER.TabIndex = 20
        Me.BTN_MODICUSTOMER.Text = "MODIFY CUSTOMER"
        Me.BTN_MODICUSTOMER.UseVisualStyleBackColor = False
        '
        'LBL_SUBTITLE
        '
        Me.LBL_SUBTITLE.AutoSize = True
        Me.LBL_SUBTITLE.BackColor = System.Drawing.Color.LightBlue
        Me.LBL_SUBTITLE.ForeColor = System.Drawing.Color.Black
        Me.LBL_SUBTITLE.Location = New System.Drawing.Point(385, 121)
        Me.LBL_SUBTITLE.Name = "LBL_SUBTITLE"
        Me.LBL_SUBTITLE.Size = New System.Drawing.Size(131, 17)
        Me.LBL_SUBTITLE.TabIndex = 22
        Me.LBL_SUBTITLE.Text = "Choose your option"
        Me.LBL_SUBTITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(866, 489)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 23
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'FRM_MODIFY_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 550)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.LBL_SUBTITLE)
        Me.Controls.Add(Me.BTN_MODICUSTOMER)
        Me.Controls.Add(Me.BTN_MODISTAFF)
        Me.Controls.Add(Me.BTN_MODIPRODUCT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Name = "FRM_MODIFY_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - MODIFY PAGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_MODIPRODUCT As Button
    Friend WithEvents BTN_MODISTAFF As Button
    Friend WithEvents BTN_MODICUSTOMER As Button
    Friend WithEvents LBL_SUBTITLE As Label
    Friend WithEvents BTN_EXIT As Button
End Class
