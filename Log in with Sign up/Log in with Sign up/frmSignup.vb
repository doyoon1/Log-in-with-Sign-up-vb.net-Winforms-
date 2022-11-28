Imports System.Data.OleDb

Public Class Sign_up


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "Insert into [Users]([Username],[Password],[AccessLevel],[Lastname],[Firstname],[Status])Values('" & txtBoxUsername.Text & "','" & txtBoxPassword.Text & "','" & cboAccesslevel.Text & "','" & txtBoxLastname.Text & "','" & txtBoxFirstname.Text & "','" & cboStatus.Text & "')"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
        MsgBox("New Account Successfully Saved", MsgBoxStyle.Information, "Create account")
    End Sub

    Private Sub Sign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class