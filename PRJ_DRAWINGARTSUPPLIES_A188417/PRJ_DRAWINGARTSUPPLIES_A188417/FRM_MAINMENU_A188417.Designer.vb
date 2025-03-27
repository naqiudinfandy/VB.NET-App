<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MAINMENU_A188417
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MAINMENU_A188417))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_SUBTITLE = New System.Windows.Forms.Label()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.BTN_STAFF = New System.Windows.Forms.Button()
        Me.BTN_CUSTOMER = New System.Windows.Forms.Button()
        Me.BTN_ORDER = New System.Windows.Forms.Button()
        Me.BTN_PRODUCT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.BTN_PRODUCTLIST = New System.Windows.Forms.Button()
        Me.BTN_MODIFY = New System.Windows.Forms.Button()
        Me.BTN_MAKEORDER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(206, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ARTISTIC ART SUPPLIER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_SUBTITLE
        '
        Me.LBL_SUBTITLE.AutoSize = True
        Me.LBL_SUBTITLE.BackColor = System.Drawing.Color.LightPink
        Me.LBL_SUBTITLE.Location = New System.Drawing.Point(427, 461)
        Me.LBL_SUBTITLE.Name = "LBL_SUBTITLE"
        Me.LBL_SUBTITLE.Size = New System.Drawing.Size(109, 17)
        Me.LBL_SUBTITLE.TabIndex = 1
        Me.LBL_SUBTITLE.Text = "Click the button "
        Me.LBL_SUBTITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_DATE
        '
        Me.LBL_DATE.AutoSize = True
        Me.LBL_DATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 9)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 2
        Me.LBL_DATE.Text = "DATE"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(15, 531)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(75, 49)
        Me.BTN_BACK.TabIndex = 3
        Me.BTN_BACK.Text = "BACK"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 29)
        Me.BTN_REFRESHDATE.Name = "BTN_REFRESHDATE"
        Me.BTN_REFRESHDATE.Size = New System.Drawing.Size(148, 23)
        Me.BTN_REFRESHDATE.TabIndex = 9
        Me.BTN_REFRESHDATE.Text = "REFRESH TIME"
        Me.BTN_REFRESHDATE.UseVisualStyleBackColor = False
        '
        'BTN_STAFF
        '
        Me.BTN_STAFF.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_STAFF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STAFF.Location = New System.Drawing.Point(312, 125)
        Me.BTN_STAFF.Name = "BTN_STAFF"
        Me.BTN_STAFF.Size = New System.Drawing.Size(157, 91)
        Me.BTN_STAFF.TabIndex = 10
        Me.BTN_STAFF.Text = "Staff " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.BTN_STAFF.UseVisualStyleBackColor = False
        '
        'BTN_CUSTOMER
        '
        Me.BTN_CUSTOMER.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_CUSTOMER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CUSTOMER.Location = New System.Drawing.Point(475, 125)
        Me.BTN_CUSTOMER.Name = "BTN_CUSTOMER"
        Me.BTN_CUSTOMER.Size = New System.Drawing.Size(157, 91)
        Me.BTN_CUSTOMER.TabIndex = 11
        Me.BTN_CUSTOMER.Text = "Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.BTN_CUSTOMER.UseVisualStyleBackColor = False
        '
        'BTN_ORDER
        '
        Me.BTN_ORDER.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_ORDER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ORDER.Location = New System.Drawing.Point(312, 242)
        Me.BTN_ORDER.Name = "BTN_ORDER"
        Me.BTN_ORDER.Size = New System.Drawing.Size(157, 91)
        Me.BTN_ORDER.TabIndex = 12
        Me.BTN_ORDER.Text = "Order " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.BTN_ORDER.UseVisualStyleBackColor = False
        '
        'BTN_PRODUCT
        '
        Me.BTN_PRODUCT.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_PRODUCT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PRODUCT.Location = New System.Drawing.Point(312, 356)
        Me.BTN_PRODUCT.Name = "BTN_PRODUCT"
        Me.BTN_PRODUCT.Size = New System.Drawing.Size(157, 91)
        Me.BTN_PRODUCT.TabIndex = 13
        Me.BTN_PRODUCT.Text = "Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Catalog"
        Me.BTN_PRODUCT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(300, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 66)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "MAIN MENU"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(863, 531)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 17
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'BTN_PRODUCTLIST
        '
        Me.BTN_PRODUCTLIST.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_PRODUCTLIST.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PRODUCTLIST.Location = New System.Drawing.Point(475, 356)
        Me.BTN_PRODUCTLIST.Name = "BTN_PRODUCTLIST"
        Me.BTN_PRODUCTLIST.Size = New System.Drawing.Size(157, 91)
        Me.BTN_PRODUCTLIST.TabIndex = 18
        Me.BTN_PRODUCTLIST.Text = "Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "List"
        Me.BTN_PRODUCTLIST.UseVisualStyleBackColor = False
        '
        'BTN_MODIFY
        '
        Me.BTN_MODIFY.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_MODIFY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MODIFY.Location = New System.Drawing.Point(638, 192)
        Me.BTN_MODIFY.Name = "BTN_MODIFY"
        Me.BTN_MODIFY.Size = New System.Drawing.Size(157, 190)
        Me.BTN_MODIFY.TabIndex = 19
        Me.BTN_MODIFY.Text = "Modify"
        Me.BTN_MODIFY.UseVisualStyleBackColor = False
        '
        'BTN_MAKEORDER
        '
        Me.BTN_MAKEORDER.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTN_MAKEORDER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MAKEORDER.Location = New System.Drawing.Point(475, 242)
        Me.BTN_MAKEORDER.Name = "BTN_MAKEORDER"
        Me.BTN_MAKEORDER.Size = New System.Drawing.Size(157, 91)
        Me.BTN_MAKEORDER.TabIndex = 20
        Me.BTN_MAKEORDER.Text = "Order Option"
        Me.BTN_MAKEORDER.UseVisualStyleBackColor = False
        '
        'FRM_MAINMENU_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 592)
        Me.Controls.Add(Me.BTN_MAKEORDER)
        Me.Controls.Add(Me.BTN_MODIFY)
        Me.Controls.Add(Me.BTN_PRODUCTLIST)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_PRODUCT)
        Me.Controls.Add(Me.BTN_ORDER)
        Me.Controls.Add(Me.BTN_CUSTOMER)
        Me.Controls.Add(Me.BTN_STAFF)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Controls.Add(Me.LBL_SUBTITLE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_MAINMENU_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - MAIN MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_SUBTITLE As Label
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents BTN_STAFF As Button
    Friend WithEvents BTN_CUSTOMER As Button
    Friend WithEvents BTN_ORDER As Button
    Friend WithEvents BTN_PRODUCT As Button
    Friend WithEvents BTN_ORDERHISTORY As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents BTN_PRODUCTLIST As Button
    Friend WithEvents BTN_MODIFY As Button
    Friend WithEvents BTN_MAKEORDER As Button
End Class
