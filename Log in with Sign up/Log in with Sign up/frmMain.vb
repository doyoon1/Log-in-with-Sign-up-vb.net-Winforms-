Public Class frmMain

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = "Ang kasalukuyang oras at panahon ay: " & Now
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Sign_up.ShowDialog()
    End Sub
End Class