<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MODIPRODUCT_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MODIPRODUCT_A188417))
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRD_PRODUCT = New System.Windows.Forms.DataGridView()
        Me.PIC_PRODUCT = New System.Windows.Forms.PictureBox()
        Me.BTN_INSERT = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_PICTURE = New System.Windows.Forms.TextBox()
        Me.BTN_PICTURE = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_BRAND = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_PRICE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_WARRANTY = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox()
        Me.TXT_QUANTITY = New System.Windows.Forms.TextBox()
        Me.BTN_CLEAR = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GRD_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_REFRESHDATE
        '
        Me.BTN_REFRESHDATE.BackColor = System.Drawing.Color.LightGray
        Me.BTN_REFRESHDATE.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 29)
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
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 9)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 10
        Me.LBL_DATE.Text = "DATE"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 740)
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
        Me.BTN_EXIT.Location = New System.Drawing.Point(1102, 740)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 18
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(351, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 66)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MODIFY PRODUCT"
        '
        'GRD_PRODUCT
        '
        Me.GRD_PRODUCT.AllowUserToAddRows = False
        Me.GRD_PRODUCT.AllowUserToDeleteRows = False
        Me.GRD_PRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRD_PRODUCT.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.GRD_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRD_PRODUCT.Location = New System.Drawing.Point(12, 106)
        Me.GRD_PRODUCT.Name = "GRD_PRODUCT"
        Me.GRD_PRODUCT.RowHeadersWidth = 51
        Me.GRD_PRODUCT.RowTemplate.Height = 24
        Me.GRD_PRODUCT.Size = New System.Drawing.Size(1154, 285)
        Me.GRD_PRODUCT.TabIndex = 21
        '
        'PIC_PRODUCT
        '
        Me.PIC_PRODUCT.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PIC_PRODUCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_PRODUCT.Location = New System.Drawing.Point(958, 423)
        Me.PIC_PRODUCT.Name = "PIC_PRODUCT"
        Me.PIC_PRODUCT.Size = New System.Drawing.Size(208, 232)
        Me.PIC_PRODUCT.TabIndex = 58
        Me.PIC_PRODUCT.TabStop = False
        '
        'BTN_INSERT
        '
        Me.BTN_INSERT.BackColor = System.Drawing.Color.Turquoise
        Me.BTN_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INSERT.Location = New System.Drawing.Point(267, 734)
        Me.BTN_INSERT.Name = "BTN_INSERT"
        Me.BTN_INSERT.Size = New System.Drawing.Size(141, 60)
        Me.BTN_INSERT.TabIndex = 57
        Me.BTN_INSERT.Text = "INSERT "
        Me.BTN_INSERT.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(11, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(448, 20)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "INSTRUCTION : Please enter all the details below : "
        '
        'TXT_PICTURE
        '
        Me.TXT_PICTURE.BackColor = System.Drawing.Color.White
        Me.TXT_PICTURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PICTURE.Location = New System.Drawing.Point(581, 671)
        Me.TXT_PICTURE.Name = "TXT_PICTURE"
        Me.TXT_PICTURE.Size = New System.Drawing.Size(342, 24)
        Me.TXT_PICTURE.TabIndex = 53
        '
        'BTN_PICTURE
        '
        Me.BTN_PICTURE.BackColor = System.Drawing.Color.LightPink
        Me.BTN_PICTURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PICTURE.Location = New System.Drawing.Point(495, 647)
        Me.BTN_PICTURE.Name = "BTN_PICTURE"
        Me.BTN_PICTURE.Size = New System.Drawing.Size(80, 71)
        Me.BTN_PICTURE.TabIndex = 52
        Me.BTN_PICTURE.Text = "Select Picture"
        Me.BTN_PICTURE.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(492, 626)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Click to select new product picture : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(486, 486)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 18)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Product Quantity : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(486, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 18)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Product Category : "
        '
        'TXT_BRAND
        '
        Me.TXT_BRAND.BackColor = System.Drawing.Color.White
        Me.TXT_BRAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BRAND.Location = New System.Drawing.Point(18, 642)
        Me.TXT_BRAND.Name = "TXT_BRAND"
        Me.TXT_BRAND.Size = New System.Drawing.Size(417, 24)
        Me.TXT_BRAND.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 622)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Product Brand : "
        '
        'TXT_PRICE
        '
        Me.TXT_PRICE.BackColor = System.Drawing.Color.White
        Me.TXT_PRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRICE.Location = New System.Drawing.Point(18, 574)
        Me.TXT_PRICE.Name = "TXT_PRICE"
        Me.TXT_PRICE.Size = New System.Drawing.Size(417, 24)
        Me.TXT_PRICE.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 554)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Product Price : "
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(18, 506)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(417, 24)
        Me.TXT_NAME.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Product Name : "
        '
        'TXT_ID
        '
        Me.TXT_ID.BackColor = System.Drawing.Color.White
        Me.TXT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(18, 447)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(417, 24)
        Me.TXT_ID.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Product ID (generate automatically) :"
        '
        'TXT_WARRANTY
        '
        Me.TXT_WARRANTY.BackColor = System.Drawing.Color.White
        Me.TXT_WARRANTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_WARRANTY.Location = New System.Drawing.Point(489, 574)
        Me.TXT_WARRANTY.Name = "TXT_WARRANTY"
        Me.TXT_WARRANTY.Size = New System.Drawing.Size(427, 24)
        Me.TXT_WARRANTY.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(486, 554)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 18)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Product Waranty Length : "
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.White
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(489, 447)
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(427, 24)
        Me.TXT_CATEGORY.TabIndex = 61
        '
        'TXT_QUANTITY
        '
        Me.TXT_QUANTITY.BackColor = System.Drawing.Color.White
        Me.TXT_QUANTITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QUANTITY.Location = New System.Drawing.Point(489, 506)
        Me.TXT_QUANTITY.Name = "TXT_QUANTITY"
        Me.TXT_QUANTITY.Size = New System.Drawing.Size(427, 24)
        Me.TXT_QUANTITY.TabIndex = 62
        '
        'BTN_CLEAR
        '
        Me.BTN_CLEAR.BackColor = System.Drawing.Color.Silver
        Me.BTN_CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLEAR.Location = New System.Drawing.Point(708, 734)
        Me.BTN_CLEAR.Name = "BTN_CLEAR"
        Me.BTN_CLEAR.Size = New System.Drawing.Size(141, 60)
        Me.BTN_CLEAR.TabIndex = 63
        Me.BTN_CLEAR.Text = "CLEAR"
        Me.BTN_CLEAR.UseVisualStyleBackColor = False
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.BackColor = System.Drawing.Color.Red
        Me.BTN_DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.Location = New System.Drawing.Point(561, 734)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(141, 60)
        Me.BTN_DELETE.TabIndex = 64
        Me.BTN_DELETE.Text = "DELETE"
        Me.BTN_DELETE.UseVisualStyleBackColor = False
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.BackColor = System.Drawing.Color.Yellow
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.Location = New System.Drawing.Point(414, 734)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(141, 60)
        Me.BTN_UPDATE.TabIndex = 65
        Me.BTN_UPDATE.Text = "UPDATE"
        Me.BTN_UPDATE.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(411, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(387, 17)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Choose whether you want to INSERT, UPDATE OR DELETE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(581, 701)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 17)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "use '.jpg' file type"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1066, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRM_MODIPRODUCT_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1189, 801)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_CLEAR)
        Me.Controls.Add(Me.TXT_QUANTITY)
        Me.Controls.Add(Me.TXT_CATEGORY)
        Me.Controls.Add(Me.TXT_WARRANTY)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PIC_PRODUCT)
        Me.Controls.Add(Me.BTN_INSERT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_PICTURE)
        Me.Controls.Add(Me.BTN_PICTURE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_BRAND)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_PRICE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GRD_PRODUCT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Name = "FRM_MODIPRODUCT_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - INSERT PRODUCT DETAILS"
        CType(Me.GRD_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents GRD_PRODUCT As DataGridView
    Friend WithEvents PIC_PRODUCT As PictureBox
    Friend WithEvents BTN_INSERT As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_PICTURE As TextBox
    Friend WithEvents BTN_PICTURE As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_BRAND As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_PRICE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_WARRANTY As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_CATEGORY As TextBox
    Friend WithEvents TXT_QUANTITY As TextBox
    Friend WithEvents BTN_CLEAR As Button
    Friend WithEvents BTN_DELETE As Button
    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
End Class
