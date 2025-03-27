<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_DETAILSOFORDER_A188417
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DETAILSOFORDER_A188417))
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.labelprice = New System.Windows.Forms.Label()
        Me.grd_detail = New System.Windows.Forms.DataGridView()
        Me.lbl_tile = New System.Windows.Forms.Label()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grd_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("High Tower Text", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(257, 14)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(77, 32)
        Me.lbl_total.TabIndex = 134
        Me.lbl_total.Text = "Total"
        '
        'labelprice
        '
        Me.labelprice.AutoSize = True
        Me.labelprice.BackColor = System.Drawing.Color.Transparent
        Me.labelprice.Font = New System.Drawing.Font("High Tower Text", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelprice.ForeColor = System.Drawing.Color.Black
        Me.labelprice.Location = New System.Drawing.Point(3, 14)
        Me.labelprice.Name = "labelprice"
        Me.labelprice.Size = New System.Drawing.Size(248, 32)
        Me.labelprice.TabIndex = 133
        Me.labelprice.Text = "GRAND TOTAL:"
        '
        'grd_detail
        '
        Me.grd_detail.AllowUserToAddRows = False
        Me.grd_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_detail.Location = New System.Drawing.Point(213, 144)
        Me.grd_detail.Name = "grd_detail"
        Me.grd_detail.ReadOnly = True
        Me.grd_detail.RowHeadersWidth = 51
        Me.grd_detail.RowTemplate.Height = 24
        Me.grd_detail.Size = New System.Drawing.Size(706, 278)
        Me.grd_detail.TabIndex = 124
        '
        'lbl_tile
        '
        Me.lbl_tile.AutoSize = True
        Me.lbl_tile.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tile.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tile.ForeColor = System.Drawing.Color.Gold
        Me.lbl_tile.Location = New System.Drawing.Point(351, 45)
        Me.lbl_tile.Name = "lbl_tile"
        Me.lbl_tile.Size = New System.Drawing.Size(479, 66)
        Me.lbl_tile.TabIndex = 122
        Me.lbl_tile.Text = "Order Details"
        '
        'BTN_BACK
        '
        Me.BTN_BACK.BackColor = System.Drawing.Color.LightGray
        Me.BTN_BACK.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BACK.Location = New System.Drawing.Point(12, 525)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(75, 49)
        Me.BTN_BACK.TabIndex = 141
        Me.BTN_BACK.Text = "BACK"
        Me.BTN_BACK.UseVisualStyleBackColor = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackColor = System.Drawing.Color.LightGray
        Me.BTN_EXIT.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Location = New System.Drawing.Point(1052, 525)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(75, 49)
        Me.BTN_EXIT.TabIndex = 142
        Me.BTN_EXIT.Text = "EXIT"
        Me.BTN_EXIT.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.labelprice)
        Me.Panel1.Location = New System.Drawing.Point(376, 428)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 58)
        Me.Panel1.TabIndex = 143
        '
        'FRM_DETAILSOFORDER_A188417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 587)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.grd_detail)
        Me.Controls.Add(Me.lbl_tile)
        Me.Name = "FRM_DETAILSOFORDER_A188417"
        Me.Text = "FRM_DETAILSOFORDER_A188417"
        CType(Me.grd_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_total As Label
    Friend WithEvents labelprice As Label
    Friend WithEvents grd_detail As DataGridView
    Friend WithEvents lbl_tile As Label
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents Panel1 As Panel
End Class
