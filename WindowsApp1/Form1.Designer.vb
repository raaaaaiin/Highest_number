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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tnum1 = New System.Windows.Forms.TextBox()
        Me.tnum2 = New System.Windows.Forms.TextBox()
        Me.tnum3 = New System.Windows.Forms.TextBox()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.highestt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1st value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2nd value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3rd value"
        '
        'tnum1
        '
        Me.tnum1.Location = New System.Drawing.Point(12, 63)
        Me.tnum1.Name = "tnum1"
        Me.tnum1.Size = New System.Drawing.Size(100, 20)
        Me.tnum1.TabIndex = 3
        '
        'tnum2
        '
        Me.tnum2.Location = New System.Drawing.Point(118, 63)
        Me.tnum2.Name = "tnum2"
        Me.tnum2.Size = New System.Drawing.Size(100, 20)
        Me.tnum2.TabIndex = 4
        '
        'tnum3
        '
        Me.tnum3.Location = New System.Drawing.Point(224, 63)
        Me.tnum3.Name = "tnum3"
        Me.tnum3.Size = New System.Drawing.Size(100, 20)
        Me.tnum3.TabIndex = 5
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(12, 115)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(165, 51)
        Me.btncompute.TabIndex = 6
        Me.btncompute.Text = "Compute the Highest Value"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Highest:"
        '
        'highestt
        '
        Me.highestt.AutoSize = True
        Me.highestt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highestt.Location = New System.Drawing.Point(285, 125)
        Me.highestt.Name = "highestt"
        Me.highestt.Size = New System.Drawing.Size(0, 25)
        Me.highestt.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 213)
        Me.Controls.Add(Me.highestt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.tnum3)
        Me.Controls.Add(Me.tnum2)
        Me.Controls.Add(Me.tnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tnum1 As TextBox
    Friend WithEvents tnum2 As TextBox
    Friend WithEvents tnum3 As TextBox
    Friend WithEvents btncompute As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents highestt As Label
End Class
