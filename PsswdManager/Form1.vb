Imports System.IO
Imports System.Security.Cryptography

Public Class Form1
    ' TO DO : 
    'Clean up code
    'Add help options.

    
    Dim fileholder As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\pashashfile.rtfm33"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddPasswordForm.Show()
    End Sub

    Public Sub loadpasslist(ByVal FileToRead As String)
        Dim sr As New StreamReader(FileToRead)
        ListView1.Items.Clear()
        ListView1.BeginUpdate()

        Dim countlines As Integer = Split(sr.ReadToEnd, vbNewLine).Count
        sr.Close()
        Dim srr As New StreamReader(FileToRead)

        For i = 0 To countlines - 1

            Dim spiltted As String() = Split(srr.ReadLine, "|", 3)
            If spiltted(0) = "" Then
                Exit For
            End If
            Dim firstcolitem As ListViewItem
            firstcolitem = ListView1.Items.Add(spiltted(0))
            firstcolitem.SubItems.Add(spiltted(1))
            firstcolitem.SubItems.Add(PasswordManagerCl.RijndaelDecrypt(spiltted(2), "hashbro123jh382$$%248918798713134"))
        Next
        srr.Close()
        ListView1.EndUpdate()
        ListView1.Refresh()
        ToolStripStatusLabel2.Text = ListView1.Items.Count ' load passwords count
    End Sub

    Public Sub SavetoFile(ByVal FileToSave As String)
        Dim linecount As Integer = ListView1.Items.Count

       
        Dim sw As New StreamWriter(FileToSave)
        For i = 0 To linecount - 1
            Dim item As String
            item = ListView1.Items(i).Text
            item = item & "|" & ListView1.Items(i).SubItems(1).Text & "|" & PasswordManagerCl.Rijndaelcrypt(ListView1.Items(i).SubItems(2).Text, "hashbro123jh382$$%248918798713134")

            sw.WriteLine(item, True)

        Next
        sw.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SavetoFile(fileholder)
        NotifyIcon1.Visible = False
        NotifyIcon1.Dispose()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(fileholder) Then
            loadpasslist(fileholder)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Nothing to remove!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
        SavetoFile(fileholder)
        loadpasslist(fileholder)
        ToolStripStatusLabel2.Text = ListView1.Items.Count ' countpasswords

    End Sub

    Private Sub CopyPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyPasswordToolStripMenuItem.Click

        If ListView1.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Clipboard.SetText(ListView1.SelectedItems(0).SubItems(2).Text.ToString)
            CopiedToClipB()
        End If


    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        AddPasswordForm.Show()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Nothing to Remove!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        ListView1.Items.Remove(ListView1.SelectedItems.Item(0))
        SavetoFile(fileholder)
        loadpasslist(fileholder)
    End Sub

    Private Sub CopyUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyUsernameToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Clipboard.SetText(ListView1.SelectedItems(0).SubItems(1).Text.ToString)
            CopiedToClipB()
        End If
    End Sub

    Private Sub OpenURLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenURLToolStripMenuItem.Click

        If ListView1.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Process.Start(ListView1.SelectedItems(0).Text)
        End If

    End Sub

    Private Sub CopyBothToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyBothToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Clipboard.SetText(String.Format("Username : {0}" & vbNewLine & "Password : {1}", ListView1.SelectedItems(0).SubItems(1).Text.ToString, (ListView1.SelectedItems(0).SubItems(2).Text.ToString)))
            CopiedToClipB()
        End If
    End Sub
    Sub CopiedToClipB()
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(50, "Text", "Copied To ClipBoard", ToolTipIcon.Info)
    End Sub

End Class
