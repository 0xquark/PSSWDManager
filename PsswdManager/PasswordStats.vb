
'Written by 0xQuark
'Credits to me and Microsoft
'Please leave these credits in and don't be a leech! :)

'Example Usage : PasswordStats1.PasswordStrenght = PasswordStrengthChecker.EvalPwdStrength(TextBox1.Text)

Imports System.Drawing.Drawing2D

Public Class PasswordStats
    Inherits Panel


    Dim G As Graphics


    Private _Strenght As Integer
    Public Property PasswordStrenght() As Integer
        Get
            Return _Strenght
        End Get
        Set(ByVal value As Integer)
            _Strenght = value
            Invalidate()
        End Set
    End Property


    Sub New()
        Size = New Size(255, 20)
        PasswordStrenght = 0

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
    End Sub

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(pe)
        G = pe.Graphics
        G.Clear(BackColor)
        Dim clr As Integer = CInt(Me.Width / 4)

        
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, clr - 1, Height), Color.Red, Color.Transparent, 0.0F)

        Select Case _Strenght
            Case 0
                G.FillRectangle(Brushes.Transparent, New Rectangle(1, 1, Width, Height - 2))

            Case 1
                lgb = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.White, Color.Black, 0.0F)
                Dim color_blend As New ColorBlend
                color_blend.Colors = New Color() {Color.Red, _
                    Color.Transparent, Color.Transparent, Color.Transparent}
                color_blend.Positions = New Single() {0.0, 0.3, 0.7, 1.0}
                lgb.InterpolationColors = color_blend

                G.FillRectangle(lgb, New Rectangle(1, 1, Width - 2, Height - 2))
                G.DrawString("Weak", Font, Brushes.White, 1, 3)
            Case 2
                lgb = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.White, Color.Black, 0.0F)
                Dim color_blend As New ColorBlend
                color_blend.Colors = New Color() {Color.Red, _
                    Color.Orange, Color.Transparent, Color.Transparent}
                color_blend.Positions = New Single() {0.0, 0.3, 0.7, 1.0}
                lgb.InterpolationColors = color_blend

                G.FillRectangle(lgb, New Rectangle(1, 1, Width - 2, Height - 2))
                G.DrawString("Medium", Font, Brushes.White, 1, 3)
            Case 3
                lgb = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.White, Color.Black, 0.0F)
                Dim color_blend As New ColorBlend
                color_blend.Colors = New Color() {Color.Red, _
                    Color.Orange, Color.Green, Color.Transparent}
                color_blend.Positions = New Single() {0.0, 0.3, 0.7, 1.0}
                lgb.InterpolationColors = color_blend

                G.FillRectangle(lgb, New Rectangle(1, 1, Width - 2, Height - 2))
                G.DrawString("Strong", Font, Brushes.White, 1, 3)

            Case 4
                lgb = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.White, Color.Black, 0.0F)
                Dim color_blend As New ColorBlend
                color_blend.Colors = New Color() {Color.Red, _
                    Color.Orange, Color.Green, Color.LawnGreen}
                color_blend.Positions = New Single() {0.0, 0.3, 0.7, 1.0}
                lgb.InterpolationColors = color_blend

                G.FillRectangle(lgb, New Rectangle(1, 1, Width, Height - 2))
                G.DrawString("Best", Font, Brushes.White, 1, 3)
        End Select



        'Boarder of PasswordStatChecker
        G.DrawRectangle(Pens.Black, New Rectangle(0, 0, Width - 1, Height - 1))
        G.DrawLine(Pens.Black, New Point(clr, 0), New Point(clr, Height))
        G.DrawLine(Pens.Black, New Point(clr + clr, 0), New Point(clr + clr, Height))
        G.DrawLine(Pens.Black, New Point(clr + clr + clr, 0), New Point(clr + clr + clr, Height))
        Dim grad As LinearGradientBrush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(80, Color.White), Color.FromArgb(20, Color.White), 90.0F)
        G.FillRectangle(grad, 0, 0, Width, CInt(Height / 2 - 2))


    End Sub
End Class

Module PasswordStrengthChecker

    Dim alpha As String = "abcdefghijklmnopqrstuvwxyz"
    Dim upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim upper_punct As String = "~`!@#$%^&*()-_+="
    Dim digits As String = "1234567890"

    Dim totalChars As Integer = 127 - 32
    Dim alphaChars As Integer = alpha.Length
    Dim upperChars As Integer = upper.Length
    Dim upper_punctChars As Integer = upper_punct.Length
    Dim digitChars As Integer = digits.Length
    Dim otherChars As Integer = totalChars - (alphaChars + upperChars + upper_punctChars + digitChars)

    Public Function calculateBits(ByVal password As String) As Integer

        If (password.Length < 1) Then

            ' No Password
            calculateBits = 0

        Else

            Dim fAlpha As Boolean = False
            Dim fUpper As Boolean = False
            Dim fUpperPunct As Boolean = False
            Dim fDigit As Boolean = False
            Dim fOther As Boolean = False
            Dim charset As Integer = 0

            Dim chr As Char

            For i As Integer = 0 To (password.Length - 1)

                chr = password.Chars(i)

                If (alpha.IndexOf(chr) <> -1) Then
                    fAlpha = True
                ElseIf (upper.IndexOf(chr) <> -1) Then
                    fUpper = True
                ElseIf (digits.IndexOf(chr) <> -1) Then
                    fDigit = True
                ElseIf (upper_punct.IndexOf(chr) <> -1) Then
                    fUpperPunct = True
                Else
                    fOther = True
                End If

            Next

            If (fAlpha) Then charset = charset + alphaChars
            If (fUpper) Then charset = charset + upperChars
            If (fDigit) Then charset = charset + digitChars
            If (fUpperPunct) Then charset = charset + upper_punctChars
            If (fOther) Then charset = charset + otherChars

            Dim bits As Integer
            bits = Math.Log(charset) * (password.Length / Math.Log(2))

            calculateBits = Math.Floor(bits)

        End If

    End Function

    Public Function EvalPwdStrength(ByVal password) As Integer

        Dim bits As Integer = calculateBits(password)
        Dim strength As Integer

        If (bits >= 128) Then
            strength = 4
        ElseIf (bits < 128 And bits >= 64) Then
            strength = 3
        ElseIf (bits < 64 And bits >= 56) Then
            strength = 2
        ElseIf (bits < 56 And bits > 0) Then
            strength = 1
        Else
            strength = 0
        End If

        EvalPwdStrength = strength

    End Function

End Module
