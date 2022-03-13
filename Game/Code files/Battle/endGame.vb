Public Class endGame

    Private Sub endGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(Form1.gameStatus)
        If Form1.gameStatus = "win" Then
            lstats.Text = "You WIN!!!"
        ElseIf Form1.gameStatus = "lost" Then
            lstats.Text = "You Lost! Try again?"
        End If
    End Sub


    Private Sub bagain_Click(sender As Object, e As EventArgs) Handles bagain.Click
        Form1.Close()
        Form1.Show()
    End Sub


    Private Sub bexit_Click(sender As Object, e As EventArgs) Handles bexit.Click
        Application.Exit()
    End Sub

End Class