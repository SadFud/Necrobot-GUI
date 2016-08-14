<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auth))
        Me.radiogoogle = New System.Windows.Forms.RadioButton()
        Me.radioptc = New System.Windows.Forms.RadioButton()
        Me.checkproxy = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textpass = New System.Windows.Forms.TextBox()
        Me.textuser = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textppass = New System.Windows.Forms.TextBox()
        Me.textpuser = New System.Windows.Forms.TextBox()
        Me.textpport = New System.Windows.Forms.TextBox()
        Me.textphost = New System.Windows.Forms.TextBox()
        Me.checkproxyauth = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radiogoogle
        '
        Me.radiogoogle.AutoSize = True
        Me.radiogoogle.Location = New System.Drawing.Point(6, 19)
        Me.radiogoogle.Name = "radiogoogle"
        Me.radiogoogle.Size = New System.Drawing.Size(59, 17)
        Me.radiogoogle.TabIndex = 0
        Me.radiogoogle.TabStop = True
        Me.radiogoogle.Text = "Google"
        Me.radiogoogle.UseVisualStyleBackColor = True
        '
        'radioptc
        '
        Me.radioptc.AutoSize = True
        Me.radioptc.Location = New System.Drawing.Point(73, 19)
        Me.radioptc.Name = "radioptc"
        Me.radioptc.Size = New System.Drawing.Size(125, 17)
        Me.radioptc.TabIndex = 1
        Me.radioptc.TabStop = True
        Me.radioptc.Text = "Pokemon trainer club"
        Me.radioptc.UseVisualStyleBackColor = True
        '
        'checkproxy
        '
        Me.checkproxy.AutoSize = True
        Me.checkproxy.Location = New System.Drawing.Point(6, 19)
        Me.checkproxy.Name = "checkproxy"
        Me.checkproxy.Size = New System.Drawing.Size(87, 17)
        Me.checkproxy.TabIndex = 2
        Me.checkproxy.Text = "Enable proxy"
        Me.checkproxy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textpass)
        Me.GroupBox1.Controls.Add(Me.textuser)
        Me.GroupBox1.Controls.Add(Me.radioptc)
        Me.GroupBox1.Controls.Add(Me.radiogoogle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 111)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login settings"
        '
        'textpass
        '
        Me.textpass.Location = New System.Drawing.Point(6, 81)
        Me.textpass.Name = "textpass"
        Me.textpass.Size = New System.Drawing.Size(192, 20)
        Me.textpass.TabIndex = 5
        Me.textpass.Text = "Password"
        '
        'textuser
        '
        Me.textuser.Location = New System.Drawing.Point(6, 55)
        Me.textuser.Name = "textuser"
        Me.textuser.Size = New System.Drawing.Size(192, 20)
        Me.textuser.TabIndex = 4
        Me.textuser.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.textppass)
        Me.GroupBox2.Controls.Add(Me.textpuser)
        Me.GroupBox2.Controls.Add(Me.textpport)
        Me.GroupBox2.Controls.Add(Me.textphost)
        Me.GroupBox2.Controls.Add(Me.checkproxyauth)
        Me.GroupBox2.Controls.Add(Me.checkproxy)
        Me.GroupBox2.Location = New System.Drawing.Point(235, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 170)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proxy settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Proxy port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Proxy host"
        '
        'textppass
        '
        Me.textppass.Location = New System.Drawing.Point(76, 142)
        Me.textppass.Name = "textppass"
        Me.textppass.Size = New System.Drawing.Size(203, 20)
        Me.textppass.TabIndex = 7
        '
        'textpuser
        '
        Me.textpuser.Location = New System.Drawing.Point(76, 117)
        Me.textpuser.Name = "textpuser"
        Me.textpuser.Size = New System.Drawing.Size(203, 20)
        Me.textpuser.TabIndex = 6
        '
        'textpport
        '
        Me.textpport.Location = New System.Drawing.Point(76, 68)
        Me.textpport.Name = "textpport"
        Me.textpport.Size = New System.Drawing.Size(203, 20)
        Me.textpport.TabIndex = 5
        '
        'textphost
        '
        Me.textphost.Location = New System.Drawing.Point(76, 42)
        Me.textphost.Name = "textphost"
        Me.textphost.Size = New System.Drawing.Size(203, 20)
        Me.textphost.TabIndex = 4
        '
        'checkproxyauth
        '
        Me.checkproxyauth.AutoSize = True
        Me.checkproxyauth.Location = New System.Drawing.Point(6, 94)
        Me.checkproxyauth.Name = "checkproxyauth"
        Me.checkproxyauth.Size = New System.Drawing.Size(157, 17)
        Me.checkproxyauth.TabIndex = 3
        Me.checkproxyauth.Text = "Enable proxy authentication"
        Me.checkproxyauth.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Mirisch", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save options"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 186)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Auth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auth"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radiogoogle As RadioButton
    Friend WithEvents radioptc As RadioButton
    Friend WithEvents checkproxy As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textuser As TextBox
    Friend WithEvents textpass As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textppass As TextBox
    Friend WithEvents textpuser As TextBox
    Friend WithEvents textpport As TextBox
    Friend WithEvents textphost As TextBox
    Friend WithEvents checkproxyauth As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
