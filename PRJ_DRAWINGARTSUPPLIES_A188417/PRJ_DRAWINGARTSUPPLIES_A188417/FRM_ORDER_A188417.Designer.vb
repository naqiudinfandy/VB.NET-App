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
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 496)
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
        Me.BTN_EXIT.Location = New System.Drawing.Point(865, 496)
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
        Me.Label1.Location = New System.Drawing.Point(301, 41)
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
        Me.GRD_ORDER.Location = New System.Drawing.Point(68, 103)
        Me.GRD_ORDER.Name = "GRD_ORDER"
        Me.GRD_ORDER.RowHeadersWidth = 51
        Me.GRD_ORDER.RowTemplate.Height = 24
        Me.GRD_ORDER.Size = New System.Drawing.Size(791, 307)
        Me.GRD_ORDER.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(227, 487)
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
        Me.Button1.Location = New System.Drawing.Point(377, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 57)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRM_ORDER_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(952, 557)
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
        Me.Text = "ARTISTIC ART SUPPLIER - ORDER"
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
End Class
