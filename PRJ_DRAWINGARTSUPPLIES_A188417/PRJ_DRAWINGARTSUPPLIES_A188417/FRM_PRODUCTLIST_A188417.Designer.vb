<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PRODUCTLIST_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PRODUCTLIST_A188417))
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_REFRESHDATE = New System.Windows.Forms.Button()
        Me.LBL_DATE = New System.Windows.Forms.Label()
        Me.GRD_PRODUCT = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.TXT_PRICE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_BRAND = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_QUANTITY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_WARRANTY = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GRD_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 612)
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
        Me.BTN_REFRESHDATE.Location = New System.Drawing.Point(12, 28)
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
        Me.LBL_DATE.Location = New System.Drawing.Point(12, 8)
        Me.LBL_DATE.Name = "LBL_DATE"
        Me.LBL_DATE.Size = New System.Drawing.Size(42, 16)
        Me.LBL_DATE.TabIndex = 10
        Me.LBL_DATE.Text = "DATE"
        '
        'GRD_PRODUCT
        '
        Me.GRD_PRODUCT.AllowUserToAddRows = False
        Me.GRD_PRODUCT.AllowUserToDeleteRows = False
        Me.GRD_PRODUCT.AllowUserToResizeColumns = False
        Me.GRD_PRODUCT.AllowUserToResizeRows = False
        Me.GRD_PRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GRD_PRODUCT.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.GRD_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRD_PRODUCT.Location = New System.Drawing.Point(12, 130)
        Me.GRD_PRODUCT.Name = "GRD_PRODUCT"
        Me.GRD_PRODUCT.ReadOnly = True
        Me.GRD_PRODUCT.RowHeadersWidth = 51
        Me.GRD_PRODUCT.RowTemplate.Height = 24
        Me.GRD_PRODUCT.Size = New System.Drawing.Size(977, 245)
        Me.GRD_PRODUCT.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(271, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 66)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PRODUCT LIST"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(917, 612)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 22
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID : "
        '
        'TXT_ID
        '
        Me.TXT_ID.BackColor = System.Drawing.Color.White
        Me.TXT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(9, 446)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(440, 24)
        Me.TXT_ID.TabIndex = 24
        '
        'TXT_PRICE
        '
        Me.TXT_PRICE.BackColor = System.Drawing.Color.White
        Me.TXT_PRICE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRICE.Location = New System.Drawing.Point(9, 507)
        Me.TXT_PRICE.Name = "TXT_PRICE"
        Me.TXT_PRICE.ReadOnly = True
        Me.TXT_PRICE.Size = New System.Drawing.Size(440, 24)
        Me.TXT_PRICE.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 487)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Price : "
        '
        'TXT_BRAND
        '
        Me.TXT_BRAND.BackColor = System.Drawing.Color.White
        Me.TXT_BRAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BRAND.Location = New System.Drawing.Point(9, 569)
        Me.TXT_BRAND.Name = "TXT_BRAND"
        Me.TXT_BRAND.ReadOnly = True
        Me.TXT_BRAND.Size = New System.Drawing.Size(440, 24)
        Me.TXT_BRAND.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 549)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Brand : "
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.White
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(491, 446)
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.ReadOnly = True
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(498, 24)
        Me.TXT_CATEGORY.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(491, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Category : "
        '
        'TXT_QUANTITY
        '
        Me.TXT_QUANTITY.BackColor = System.Drawing.Color.White
        Me.TXT_QUANTITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QUANTITY.Location = New System.Drawing.Point(491, 507)
        Me.TXT_QUANTITY.Name = "TXT_QUANTITY"
        Me.TXT_QUANTITY.ReadOnly = True
        Me.TXT_QUANTITY.Size = New System.Drawing.Size(501, 24)
        Me.TXT_QUANTITY.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(491, 487)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Quantity : "
        '
        'TXT_WARRANTY
        '
        Me.TXT_WARRANTY.BackColor = System.Drawing.Color.White
        Me.TXT_WARRANTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_WARRANTY.Location = New System.Drawing.Point(491, 569)
        Me.TXT_WARRANTY.Name = "TXT_WARRANTY"
        Me.TXT_WARRANTY.ReadOnly = True
        Me.TXT_WARRANTY.Size = New System.Drawing.Size(501, 24)
        Me.TXT_WARRANTY.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(491, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Warranty length : "
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(83, 392)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.ReadOnly = True
        Me.TXT_NAME.Size = New System.Drawing.Size(906, 24)
        Me.TXT_NAME.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Name : "
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TXT_SEARCH.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SEARCH.Location = New System.Drawing.Point(372, 99)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(493, 25)
        Me.TXT_SEARCH.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Type in a phrase from the product name here : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(236, 612)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(524, 48)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "ARTISTIC ART SUPPLIER"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(889, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 36)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRM_PRODUCTLIST_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_SEARCH)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_WARRANTY)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_QUANTITY)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_CATEGORY)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_BRAND)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_PRICE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GRD_PRODUCT)
        Me.Controls.Add(Me.BTN_REFRESHDATE)
        Me.Controls.Add(Me.LBL_DATE)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Name = "FRM_PRODUCTLIST_A188417"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTISTIC ART SUPPLIER - PRODUCT LIST"
        CType(Me.GRD_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_REFRESHDATE As Button
    Friend WithEvents LBL_DATE As Label
    Friend WithEvents GRD_PRODUCT As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents TXT_PRICE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_BRAND As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CATEGORY As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_QUANTITY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_WARRANTY As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
End Class
