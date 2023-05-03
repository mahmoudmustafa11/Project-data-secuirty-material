<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_decrypt = New System.Windows.Forms.Button()
        Me.btn_encrypt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_decrypt = New System.Windows.Forms.TextBox()
        Me.txt_encrypt = New System.Windows.Forms.TextBox()
        Me.txt_inputData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.LightGray
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(171, 516)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(79, 54)
        Me.btn_new.TabIndex = 26
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_decrypt
        '
        Me.btn_decrypt.BackColor = System.Drawing.Color.LightGray
        Me.btn_decrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_decrypt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decrypt.Location = New System.Drawing.Point(236, 444)
        Me.btn_decrypt.Name = "btn_decrypt"
        Me.btn_decrypt.Size = New System.Drawing.Size(147, 54)
        Me.btn_decrypt.TabIndex = 25
        Me.btn_decrypt.Text = "فك التشفير"
        Me.btn_decrypt.UseVisualStyleBackColor = False
        '
        'btn_encrypt
        '
        Me.btn_encrypt.BackColor = System.Drawing.Color.LightGray
        Me.btn_encrypt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_encrypt.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encrypt.Location = New System.Drawing.Point(47, 444)
        Me.btn_encrypt.Name = "btn_encrypt"
        Me.btn_encrypt.Size = New System.Drawing.Size(147, 54)
        Me.btn_encrypt.TabIndex = 24
        Me.btn_encrypt.Text = "التشفير"
        Me.btn_encrypt.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 34)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "فك التشفير"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 34)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "التشفير"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 34)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ادخال البيانات"
        '
        'txt_decrypt
        '
        Me.txt_decrypt.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic)
        Me.txt_decrypt.Location = New System.Drawing.Point(29, 363)
        Me.txt_decrypt.Multiline = True
        Me.txt_decrypt.Name = "txt_decrypt"
        Me.txt_decrypt.ReadOnly = True
        Me.txt_decrypt.Size = New System.Drawing.Size(372, 45)
        Me.txt_decrypt.TabIndex = 20
        Me.txt_decrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_encrypt
        '
        Me.txt_encrypt.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic)
        Me.txt_encrypt.Location = New System.Drawing.Point(29, 215)
        Me.txt_encrypt.Multiline = True
        Me.txt_encrypt.Name = "txt_encrypt"
        Me.txt_encrypt.ReadOnly = True
        Me.txt_encrypt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_encrypt.Size = New System.Drawing.Size(372, 45)
        Me.txt_encrypt.TabIndex = 19
        Me.txt_encrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_inputData
        '
        Me.txt_inputData.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inputData.Location = New System.Drawing.Point(29, 67)
        Me.txt_inputData.Multiline = True
        Me.txt_inputData.Name = "txt_inputData"
        Me.txt_inputData.Size = New System.Drawing.Size(372, 36)
        Me.txt_inputData.TabIndex = 18
        Me.txt_inputData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 582)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_decrypt)
        Me.Controls.Add(Me.btn_encrypt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_decrypt)
        Me.Controls.Add(Me.txt_encrypt)
        Me.Controls.Add(Me.txt_inputData)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "شفره Atbash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_decrypt As System.Windows.Forms.Button
    Friend WithEvents btn_encrypt As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_decrypt As System.Windows.Forms.TextBox
    Friend WithEvents txt_encrypt As System.Windows.Forms.TextBox
    Friend WithEvents txt_inputData As System.Windows.Forms.TextBox

End Class
