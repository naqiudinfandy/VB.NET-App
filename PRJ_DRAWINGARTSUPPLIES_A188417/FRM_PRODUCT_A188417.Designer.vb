<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCT_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PRODUCT_A188417))
        Me.PIC_PRODUCT = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.LST_PRODUCT = New System.Windows.Forms.ListBox()
        Me.TXT_QUANTITY = New System.Windows.Forms.TextBox()
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox()
        Me.TXT_BRAND = New System.Windows.Forms.TextBox()
        Me.TXT_PRICE = New System.Windows.Forms.TextBox()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_WARRANTY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PIC_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIC_PRODUCT
        '
        Me.PIC_PRODUCT.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PIC_PRODUCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_PRODUCT.Location = New System.Drawing.Point(617, 193)
        Me.PIC_PRODUCT.Name = "PIC_PRODUCT"
        Me.PIC_PRODUCT.Size = New System.Drawing.Size(263, 294)
        Me.PIC_PRODUCT.TabIndex = 0
        Me.PIC_PRODUCT.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(257, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCT CATALOG"
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 29)
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
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 9)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 12
        Me.LBL_DATE.Text = "DATE"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 586)
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
        Me.BTN_EXIT.Location = New System.Drawing.Point(871, 586)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 21
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'LST_PRODUCT
        '
        Me.LST_PRODUCT.BackColor = System.Drawing.SystemColors.GrayText
        Me.LST_PRODUCT.ForeColor = System.Drawing.Color.Gold
        Me.LST_PRODUCT.FormattingEnabled = True
        Me.LST_PRODUCT.ItemHeight = 16
        Me.LST_PRODUCT.Location = New System.Drawing.Point(12, 129)
        Me.LST_PRODUCT.Name = "LST_PRODUCT"
        Me.LST_PRODUCT.Size = New System.Drawing.Size(165, 388)
        Me.LST_PRODUCT.TabIndex = 22
        '
        'TXT_QUANTITY
        '
        Me.TXT_QUANTITY.BackColor = System.Drawing.Color.White
        Me.TXT_QUANTITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QUANTITY.Location = New System.Drawing.Point(225, 465)
        Me.TXT_QUANTITY.Name = "TXT_QUANTITY"
        Me.TXT_QUANTITY.ReadOnly = True
        Me.TXT_QUANTITY.Size = New System.Drawing.Size(291, 22)
        Me.TXT_QUANTITY.TabIndex = 43
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.White
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(225, 406)
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.ReadOnly = True
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(291, 22)
        Me.TXT_CATEGORY.TabIndex = 42
        '
        'TXT_BRAND
        '
        Me.TXT_BRAND.BackColor = System.Drawing.Color.White
        Me.TXT_BRAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BRAND.Location = New System.Drawing.Point(225, 342)
        Me.TXT_BRAND.Name = "TXT_BRAND"
        Me.TXT_BRAND.ReadOnly = True
        Me.TXT_BRAND.Size = New System.Drawing.Size(291, 22)
        Me.TXT_BRAND.TabIndex = 41
        '
        'TXT_PRICE
        '
        Me.TXT_PRICE.BackColor = System.Drawing.Color.White
        Me.TXT_PRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRICE.Location = New System.Drawing.Point(266, 278)
        Me.TXT_PRICE.Name = "TXT_PRICE"
        Me.TXT_PRICE.ReadOnly = True
        Me.TXT_PRICE.Size = New System.Drawing.Size(250, 22)
        Me.TXT_PRICE.TabIndex = 40
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(225, 213)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.ReadOnly = True
        Me.TXT_NAME.Size = New System.Drawing.Size(291, 22)
        Me.TXT_NAME.TabIndex = 39
        '
        'TXT_ID
        '
        Me.TXT_ID.BackColor = System.Drawing.Color.White
        Me.TXT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(225, 154)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(291, 22)
        Me.TXT_ID.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(222, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ID : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(222, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Quantity : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(222, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Category : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(222, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Brand : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(222, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Price : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(222, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Name : "
        '
        'TXT_WARRANTY
        '
        Me.TXT_WARRANTY.BackColor = System.Drawing.Color.White
        Me.TXT_WARRANTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_WARRANTY.Location = New System.Drawing.Point(222, 526)
        Me.TXT_WARRANTY.Name = "TXT_WARRANTY"
        Me.TXT_WARRANTY.ReadOnly = True
        Me.TXT_WARRANTY.Size = New System.Drawing.Size(291, 22)
        Me.TXT_WARRANTY.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(219, 506)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Warranty Length : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Click Product ID below : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(226, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "RM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(216, 577)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(524, 48)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "ARTISTIC ART SUPPLIER"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 519)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRM_PRODUCT_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(958, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_WARRANTY)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_QUANTITY)
        Me.Controls.Add(Me.TXT_CATEGORY)
        Me.Controls.Add(Me.TXT_BRAND)
        Me.Controls.Add(Me.TXT_PRICE)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LST_PRODUCT)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PIC_PRODUCT)
        Me.Name = "FRM_PRODUCT_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - PRODUCT CATALOG"
        CType(Me.PIC_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PIC_PRODUCT As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents LST_PRODUCT As ListBox
    Friend WithEvents TXT_QUANTITY As TextBox
    Friend WithEvents TXT_CATEGORY As TextBox
    Friend WithEvents TXT_BRAND As TextBox
    Friend WithEvents TXT_PRICE As TextBox
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_WARRANTY As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
