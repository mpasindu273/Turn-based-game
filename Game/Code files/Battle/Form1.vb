Public Class Form1
    Dim h_health As Integer = 50
    Dim h_shield As Integer = 0
    Dim h_baseatk As Integer = 3
    Dim h_totalatk As Integer

    Dim e_health As Integer = 30
    Dim e_shield As Integer = 2
    Dim e_baseatk As Integer = 5
    Dim e_totalatk As Integer

    Dim atk_cost As Integer = 2
    Dim shield_cost As Integer = 3
    Dim sharpen_cost As Integer = 4

    Dim hsharpen_duration As Integer
    Dim esharpen_duration As Integer
    Dim sharpen As Integer

    Dim hatk_incr_amount As Integer
    Dim hshield_incr_amount As Integer = 3
    Dim eatk_incr_amount As Integer = 3
    Dim eshield_incr_amount As Integer = 3

    Dim energy As Integer = 4
    Dim max_energy As Integer = 10
    Dim damage As Integer

    Dim turn As Integer = 1
    Dim action As String
    Dim n As Integer = 0

    Dim randomGenerator As New System.Random
    Dim enemyAction As String

    Public gameStatus As String


    Sub winner()
        If e_health <= 0 Then
            gameStatus = "win"
            endGame.Show()
            Me.Hide()
        ElseIf h_health <= 0 Then
            gameStatus = "lost"
            endGame.Show()
            Me.Hide()
        End If
    End Sub

    Sub choose_enemyAction()
        Dim randomNumber = randomGenerator.Next(0, 11)

        If randomNumber = 1 Or randomNumber = 2 Or randomNumber = 3 Or randomNumber = 4 Or randomNumber = 5 Or randomNumber = 6 Then
            enemyAction = "attack"

        ElseIf randomNumber = 7 Or randomNumber = 8 Or randomNumber = 9 Then
            enemyAction = "shield"

        Else
            enemyAction = "sharpen"
            sharpen = 1
        End If
    End Sub

    Sub energy_fill()
        If energy = 9 Then
            energy = 10
        ElseIf energy < 10 Then
            energy = energy + 2
        End If
    End Sub

    Sub endofturn()
        winner()
        energy_fill()
        h_shield = 0
        e_shield = 0
        hsharpen_duration = hsharpen_duration - 1
        esharpen_duration = esharpen_duration - 1
        turn = turn + 1
        loadStats()
    End Sub

    Sub enemyAI()
        If sharpen Then
            enemyAction = "attack"
            sharpen = 0
        Else
            choose_enemyAction()
        End If


        If enemyAction = "attack" Then
            If e_totalatk > h_shield Then
                damage = (e_totalatk - h_shield)
                h_health = h_health - damage
                h_shield = 0
                laction.ForeColor = Color.Red
                laction.Text = "Your life -" & damage

            ElseIf e_totalatk <= h_shield Then
                e_shield = e_shield - h_totalatk
                laction.ForeColor = Color.Red
                laction.Text = "Your shield -" & e_totalatk
            End If
            loadStats()
            t1.Start()

        ElseIf enemyAction = "shield" Then
            e_shield = e_shield + eshield_incr_amount
            laction.ForeColor = Color.Blue
            laction.Text = "Enemy shield +" & eshield_incr_amount
            loadStats()
            t1.Start()

        ElseIf enemyAction = "sharpen" Then
            esharpen_duration = 3
            hatk_incr_amount = 3
            e_totalatk = e_baseatk + eatk_incr_amount
            laction.ForeColor = Color.Orange
            laction.Text = "Enemy attack +" & eatk_incr_amount
            loadStats()
            t1.Start()
        End If

        endofturn()
    End Sub


    Sub loadStats()
        If hsharpen_duration > 0 Then
            h_totalatk = h_baseatk + hatk_incr_amount
            lhattack.Text = "Attack: " & (h_baseatk) & "(+" & hatk_incr_amount & ") " & hsharpen_duration & " turns"
        Else
            h_totalatk = h_baseatk
            lhattack.Text = "Attack: " & h_baseatk
        End If

        If esharpen_duration > 0 Then
            e_totalatk = e_baseatk + eatk_incr_amount
            leattack.Text = "Attack: " & (e_baseatk) & "(+" & eatk_incr_amount & ") " & esharpen_duration & " turns"
        Else
            e_totalatk = e_baseatk
            leattack.Text = "Attack: " & e_baseatk
        End If

        lhhealth.Text = "Health: " & h_health
        lhshield.Text = "Shield: " & h_shield

        lehealth.Text = "Health: " & e_health
        leshield.Text = "Shield:" & e_shield

        lenergy.Text = "Energy:  " & energy & "/" & max_energy
        lturn.Text = "Turn " & turn
    End Sub

    Sub buttonDisable()
        batk.Enabled = False
        bshield.Enabled = False
        bsharp.Enabled = False
        bendturn.Enabled = False
    End Sub

    Sub buttonEnable()
        batk.Enabled = True
        bshield.Enabled = True
        bsharp.Enabled = True
        bendturn.Enabled = True
    End Sub

   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStats()
    End Sub

    Private Sub t1_Tick(sender As Object, e As EventArgs) Handles t1.Tick
        n = n + 1
        If n > 1 Then
            t1.Stop()
            buttonEnable()
            batk.BackColor = Color.Black
            bshield.BackColor = Color.Black
            bsharp.BackColor = Color.Black          
            laction.Text = ""
            n = 0
            winner()
        End If
    End Sub

    Private Sub batk_Click(sender As Object, e As EventArgs) Handles batk.Click
        If atk_cost <= energy Then
            batk.BackColor = Color.Red
            buttonDisable()


            If h_totalatk > e_shield Then
                damage = (h_totalatk - e_shield)
                e_health = e_health - damage
                e_shield = 0

                laction.ForeColor = Color.Green
                laction.Text = "Enemy life -" & damage

            ElseIf h_totalatk <= e_shield Then
                e_shield = e_shield - h_totalatk
                laction.ForeColor = Color.Green
                laction.Text = "Enemy shield -" & h_totalatk
            End If

            energy = energy - atk_cost
            loadStats()
            t1.Start()

        Else
            MsgBox("Not enough energy! Press end turn to finish the turn", MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub bshield_Click(sender As Object, e As EventArgs) Handles bshield.Click
        If shield_cost <= energy Then
            buttonDisable()
            bshield.BackColor = Color.Blue

            h_shield = h_shield + hshield_incr_amount
            laction.Text = "Your shield +" & hshield_incr_amount
            energy = energy - shield_cost
            loadStats()
            t1.Start()

        Else
            MsgBox("Not enough energy! Press end turn to finish the turn", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bsharp_Click(sender As Object, e As EventArgs) Handles bsharp.Click
        If sharpen_cost <= energy Then
            buttonDisable()
            bsharp.BackColor = Color.Orange

            hsharpen_duration = 2
            hatk_incr_amount = 3
            h_totalatk = h_baseatk + hatk_incr_amount
            laction.Text = "Your attack +" & hatk_incr_amount
            energy = energy - sharpen_cost
            loadStats()
            t1.Start()

        Else
            MsgBox("Not enough energy! Press end turn to finish the turn", MessageBoxIcon.Warning)
        End If

    End Sub

  
    Private Sub bendturn_Click(sender As Object, e As EventArgs) Handles bendturn.Click
        buttonDisable()
        enemyAI()
    End Sub
End Class
