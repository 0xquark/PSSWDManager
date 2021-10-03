<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPasswordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPasswordForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UpLowCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SpecialCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.LettersCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.NumCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PasswordStats1 = New Password_Manager.PasswordStats()
        Me.CueBanner1 = New Password_Manager.CueBanner()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.CueBanner1.SetCueBanner(Me.TextBox1, "Please enter a Site/Url")
        Me.TextBox1.Location = New System.Drawing.Point(67, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.CueBanner1.SetCueBanner(Me.TextBox2, "Please enter a Username")
        Me.TextBox2.Location = New System.Drawing.Point(67, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.CueBanner1.SetCueBanner(Me.TextBox3, "Please generate Password")
        Me.TextBox3.Location = New System.Drawing.Point(67, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(252, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Site/Url"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(132, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(19, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UpLowCheckBox4
        '
        Me.UpLowCheckBox4.AutoSize = True
        Me.UpLowCheckBox4.Checked = True
        Me.UpLowCheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UpLowCheckBox4.Location = New System.Drawing.Point(6, 43)
        Me.UpLowCheckBox4.Name = "UpLowCheckBox4"
        Me.UpLowCheckBox4.Size = New System.Drawing.Size(137, 17)
        Me.UpLowCheckBox4.TabIndex = 14
        Me.UpLowCheckBox4.Text = "UpperCase/LowerCase"
        Me.UpLowCheckBox4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Length"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(55, 89)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'SpecialCheckBox3
        '
        Me.SpecialCheckBox3.AutoSize = True
        Me.SpecialCheckBox3.Checked = True
        Me.SpecialCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SpecialCheckBox3.Location = New System.Drawing.Point(6, 66)
        Me.SpecialCheckBox3.Name = "SpecialCheckBox3"
        Me.SpecialCheckBox3.Size = New System.Drawing.Size(109, 17)
        Me.SpecialCheckBox3.TabIndex = 11
        Me.SpecialCheckBox3.Text = "Special Charaters"
        Me.SpecialCheckBox3.UseVisualStyleBackColor = True
        '
        'LettersCheckBox2
        '
        Me.LettersCheckBox2.AutoSize = True
        Me.LettersCheckBox2.Checked = True
        Me.LettersCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LettersCheckBox2.Location = New System.Drawing.Point(80, 19)
        Me.LettersCheckBox2.Name = "LettersCheckBox2"
        Me.LettersCheckBox2.Size = New System.Drawing.Size(58, 17)
        Me.LettersCheckBox2.TabIndex = 10
        Me.LettersCheckBox2.Text = "Letters"
        Me.LettersCheckBox2.UseVisualStyleBackColor = True
        '
        'NumCheckBox1
        '
        Me.NumCheckBox1.AutoSize = True
        Me.NumCheckBox1.Checked = True
        Me.NumCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NumCheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.NumCheckBox1.Name = "NumCheckBox1"
        Me.NumCheckBox1.Size = New System.Drawing.Size(68, 17)
        Me.NumCheckBox1.TabIndex = 9
        Me.NumCheckBox1.Text = "Numbers"
        Me.NumCheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PasswordStats1)
        Me.GroupBox1.Controls.Add(Me.NumCheckBox1)
        Me.GroupBox1.Controls.Add(Me.UpLowCheckBox4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LettersCheckBox2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.SpecialCheckBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 150)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Password Generator"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(198, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(88, 64)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate"
        '
        'PasswordStats1
        '
        Me.PasswordStats1.Location = New System.Drawing.Point(12, 115)
        Me.PasswordStats1.Name = "PasswordStats1"
        Me.PasswordStats1.PasswordStrenght = 0
        Me.PasswordStats1.Size = New System.Drawing.Size(274, 20)
        Me.PasswordStats1.TabIndex = 15
        '
        'AddPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 281)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Manager"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents UpLowCheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents SpecialCheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents LettersCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents NumCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PasswordStats1 As Password_Manager.PasswordStats
    Friend WithEvents CueBanner1 As Password_Manager.CueBanner
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
