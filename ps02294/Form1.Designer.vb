<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btndong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên đăng nhập "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password"
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Location = New System.Drawing.Point(244, 53)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(331, 31)
        Me.txtdangnhap.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(244, 135)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(331, 31)
        Me.txtpassword.TabIndex = 3
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(54, 219)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(201, 47)
        Me.btndangnhap.TabIndex = 4
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(374, 219)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(201, 47)
        Me.btndong.TabIndex = 5
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'frmdn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 320)
        Me.Controls.Add(Me.btndong)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtdangnhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmdn"
        Me.Text = "Đăng Nhập "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btndong As System.Windows.Forms.Button

End Class
