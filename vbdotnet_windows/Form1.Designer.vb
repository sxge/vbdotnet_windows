<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.passwortTEXT = New System.Windows.Forms.TextBox()
        Me.usernameTEXT = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.passwortTEXT)
        Me.GroupBox1.Controls.Add(Me.usernameTEXT)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fenster 1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(279, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Versteckte Ordner anzeigen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 126)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 23)
        Me.TextBox1.TabIndex = 3
        '
        'passwortTEXT
        '
        Me.passwortTEXT.Location = New System.Drawing.Point(7, 53)
        Me.passwortTEXT.Name = "passwortTEXT"
        Me.passwortTEXT.Size = New System.Drawing.Size(279, 23)
        Me.passwortTEXT.TabIndex = 2
        Me.passwortTEXT.Text = "Passwort"
        '
        'usernameTEXT
        '
        Me.usernameTEXT.Location = New System.Drawing.Point(7, 23)
        Me.usernameTEXT.Name = "usernameTEXT"
        Me.usernameTEXT.Size = New System.Drawing.Size(279, 23)
        Me.usernameTEXT.TabIndex = 1
        Me.usernameTEXT.Text = "Benutzername"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents passwortTEXT As TextBox
    Friend WithEvents usernameTEXT As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
