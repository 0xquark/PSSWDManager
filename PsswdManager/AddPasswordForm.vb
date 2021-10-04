Imports System.Text


Public Class AddPasswordForm
#Region "passwordGen"
    Private Const PASS_UPPERS As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Const PASS_LOWERS As String = "abcdefghijklmnopqrstuvwxyz"
    Private Const PASS_NUMBERS As String = "0123456789"
    Private Const PASS_SPECIALS As String = "~`!@#$%^&*()_+=-{[}];:'<,>.?"

    Public Function GeneratePassword(ByVal Uppers As Boolean, ByVal Lowers As Boolean, ByVal Numbers As Boolean, ByVal Specials As Boolean, ByVal passwordLength As Integer) As String

        Dim strCharacters As String = Nothing
        Dim strNewPassword As String = Nothing
        Dim p As Integer

        If Uppers = True Then
            strCharacters = strCharacters & PASS_UPPERS
        End If
        If Lowers = True Then
            strCharacters = strCharacters & PASS_LOWERS
        End If
        If Numbers = True Then
            strCharacters = strCharacters & PASS_NUMBERS
        End If
        If Specials = True Then
            strCharacters = strCharacters & PASS_SPECIALS
        End If

        Randomize()

        For p = 0 To (passwordLength - 1)
            strNewPassword = strNewPassword + Mid(strCharacters, Len(strCharacters) * Rnd() + 1, 1)
        Next

        GeneratePassword = strNewPassword

    End Function
#End Region

    Public Sub AddToList(ByVal URLUSERPASS As String)
        'split string
        Dim splitter() As String = Split(URLUSERPASS, "|", 3)
        Dim splittedDone(2) As String
        splittedDone(0) = splitter(0)
        splittedDone(1) = splitter(1)
        splittedDone(2) = splitter(2)
        For i = Form1.ListView1.Items.Count To Form1.ListView1.Items.Count
            If i = -1 Then i = 0
            Form1.ListView1.Items.Add(splittedDone(0).ToString)
            Form1.ListView1.Items(i).SubItems.Add(splittedDone(1).ToString)
            Form1.ListView1.Items(i).SubItems.Add(splittedDone(2).ToString)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'error handling to check empty textboxs. 
        Dim siteurl As String = TextBox1.Text
        Dim Username As String = TextBox2.Text
        Dim password As String = TextBox3.Text

        If siteurl = Nothing Then
            MsgBox("Site Url must be a valid Url", MsgBoxStyle.Information, Me.ProductName)
            Exit Sub
        Else
            If Not siteurl.Contains("http://") Then
                siteurl = siteurl.Insert(0, "http://")

            End If
        End If
        If password = Nothing AndAlso Username = Nothing Then
            Exit Sub
        Else

            Dim teststring As String = siteurl & "|" & Username & "|" & password
            AddToList(teststring)
        End If
        Form1.ToolStripStatusLabel2.Text = Form1.ListView1.Items.Count ' countpasswords

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Box1 As Boolean = False
        Dim Box2 As Boolean = False
        Dim Box3 As Boolean = False
        Dim Box4 As Boolean = False

        If NumCheckBox1.Checked Then
            Box1 = True
        End If

        If LettersCheckBox2.Checked Then
            Box2 = True
        End If

        If UpLowCheckBox4.Checked Then
            Box3 = True
        End If

        If SpecialCheckBox3.Checked Then
            Box4 = True
        End If

        TextBox3.Text = (GeneratePassword(Box3, Box2, Box1, Box4, NumericUpDown1.Value))
        Call CheckStren()

    End Sub

    Private Sub CheckStren()
        PasswordStats1.PasswordStrenght = PasswordStrengthChecker.EvalPwdStrength(TextBox3.Text)
    End Sub

    Private Sub TextBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyUp
        Call CheckStren()
    End Sub

    
End Class
