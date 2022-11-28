Imports System.Data.OleDb

Public Class Form1
    Dim attempt As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

    End Sub

    Private Sub txtBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtBoxUsername.TextChanged
        sql = "Select [AccessLevel] from [Users] where Username='" & txtBoxUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblAccesslvl.Text = dr("AccessLevel").ToString
        Else
            lblAccesslvl.Text = ""

        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "Select * from [Users] where Username='" & txtBoxUsername.Text & "' and Password='" & txtBoxPassword.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then
            MsgBox("Log in Success", MsgBoxStyle.Information, "User Login")
            frmMain.lblUser.Text = "Welcome, " & " " & dr("Lastname") & " " & dr("Firstname") & "!"
            frmMain.lblAccesslevel.Text = "User Type: " & " " & dr("AccessLevel").ToString
            frmMain.lblRank.Text = "Status: " & " " & dr("Status")
            frmMain.Show()
        Else
            MsgBox("Log in Failed", MsgBoxStyle.Critical, "User Login")
            txtBoxUsername.Clear()
            txtBoxPassword.Clear()
            lblAccesslvl.Text = ""
            txtBoxUsername.Focus()
            attempt += 1

            If attempt = 3 Then
                btnLogin.Enabled = False
            End If
        End If
    End Sub
End Class
