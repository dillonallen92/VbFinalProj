Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Dim count As Integer = 0
    Dim count2 As Integer = 0
    Dim intCount As Integer = 0
    Dim intCount2 As Integer = 0
    Dim intCount3 As Integer = 0
    Dim score As Integer = 0
    Public game As String = ""
    Dim trajec As Integer = 0
    Dim boss As Boolean = False
    Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}
    Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}

    Dim rnd As New Random

    Dim player1 As Ship = New Ship()
    Dim player2 As Ship = New Ship()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        game = "login"
        'testing
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim Loc As Point
        Dim bLoc As Point
        Dim b2loc As Point
        Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}
        Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}


        If game = "Over" Then
            intCount = 0
            intCount2 = 0
            For i As Integer = 0 To 4
                Bullets(i).SetBounds(0, 0, 5, 5)
                EnBullets(i).SetBounds(0, 0, 5, 5)
            Next
            GameOver()
        Else
            Select Case e.KeyCode 'the arrows are for the player on the right, szxc is for the player on the left
                Case Keys.Up
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.Y - 5 < 70 Then
                            Loc = New Point(picEn.Location.X, picEn.Location.Y - player2.Speed)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.S
                    If Not picPlayer.Location.Y - 5 < 70 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - player1.Speed)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Down
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.Y - 5 > Me.Height - picEn.Height * 1.6 Then
                            Loc = New Point(picEn.Location.X, picEn.Location.Y + player2.Speed)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.X
                    If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + player1.Speed)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Left
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.X - 5 < 0 Then
                            Loc = New Point(picEn.Location.X - player2.Speed, picEn.Location.Y)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.Z
                    If Not picPlayer.Location.X - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X - player1.Speed, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Right
                    If game.Equals("Multiplayer") Then
                        If Not picEn.Location.X - 5 > Me.Width - picEn.Width - 5 Then
                            Loc = New Point(picEn.Location.X + player2.Speed, picEn.Location.Y)
                            picEn.Location = Loc
                        End If
                    End If

                Case Keys.C
                    If Not picPlayer.Location.X - 5 > Me.Width - picPlayer.Width - 5 Then
                        Loc = New Point(picPlayer.Location.X + player1.Speed, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                Case Keys.Space 'bullet for player one
                    If game.Equals("Over") = False Then
                        bLoc = New Point(picPlayer.Location.X + 100, picPlayer.Location.Y + 25)
                        Bullets(intCount).Location = bLoc

                        tmrBullet.Enabled = True

                        Bullets(intCount).Visible = True
                        intCount += 1
                        If intCount = 5 Then
                            intCount = 0
                        End If
                    End If
                Case Keys.D0 Or Keys.NumPad0
                    If game.Equals("Multiplayer") Then
                        If game.Equals("Over") = False Then

                            b2loc = New Point(picEn.Location.X, picEn.Location.Y + 25)
                            EnBullets(intCount2).Location = b2loc
                            tmrEnBullet.Enabled = True
                            EnBullets(intCount2).Visible = True
                            intCount2 += 1
                            If intCount2 = 5 Then
                                intCount2 = 0
                            End If
                        End If
                    End If

                Case Keys.Oemcomma
                    If trajec = 1 Then

                    Else
                        trajec += 1
                    End If
                Case Keys.OemPeriod
                    If trajec = -1 Then

                    Else
                        trajec -= 1
                    End If
            End Select
        End If
        'If picPlayer.Bounds.IntersectsWith(picEn.Bounds) Then 'May need to be moved later
        '   'picEn.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy
        '    
        '   prbHealth.Value -= 10
        '   
        '    If prbHealth.Value = 0 Then
        '        MessageBox.Show("Game Over")
        '    End If
        'End If
    End Sub

    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        'player 1 bullet timer
        Dim Bullets() As PictureBox = {p1b1, p1b2, p1b3, p1b4, p1b5}
        Static picBullets(4) As Bullet
        Dim d As String = "6"
        If count2 = 0 Then

            For i As Integer = 0 To 4
                picBullets(i) = New Bullet

            Next
            count2 += 1
        End If

        Select Case trajec
            Case 1
                d = "9"
            Case 0
                d = "6"
            Case -1
                d = "3"

        End Select

        picBullets(intCount).Trajectory = d

        For x As Integer = 0 To Bullets.Length - 1


            picBullets(x).Position = Bullets(x).Location
            picBullets(x).Direction()
            Bullets(x).Location = picBullets(x).Position
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim enArray() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}

        Static enemies(4) As Enemy
        If count = 0 Then

            For i As Integer = 0 To 4
                enemies(i) = New Enemy
            Next
            count += 1
        End If
        Dim en As PictureBox
        'Dim Loc As Point
        'This timer is for enemy movement

        For x As Integer = 0 To enArray.Length - 1
            en = enArray(x)
            'en.Left -= 10
            Dim int As Integer = rnd.Next(-20, 20)
            Dim tra As Integer = rnd.Next(0, 5)
            'Loc = New Point(en.Location.X, en.Location.Y - int)
            'enArray(x).Location = Loc


            If en.Location.X - 5 < 0 Then
                en.SetBounds(888 - int * 2, 237 - int * 2, 0, 0)
                If prbHealth.Value <> 0 Then
                    prbHealth.Value -= 10 'player loses health if enemy makes it to the edge
                End If
                If prbHealth.Value = 0 Then
                    tmrBullet.Enabled = False
                    Timer1.Enabled = False
                    GameOver()
                End If
            End If 'moved
            Select Case tra
                Case 1
                    enemies(x).Trajectory = "1"
                Case 2
                    enemies(x).Trajectory = "2"
                Case 3
                    enemies(x).Trajectory = "4"
                Case 4
                    enemies(x).Trajectory = "7"
                Case 5
                    enemies(x).Trajectory = "8"
            End Select

            If en.Location.Y - 20 < 70 Then
                enemies(x).Trajectory = "7"
            End If
            If en.Location.Y > Me.Height - 100 Then
                enemies(x).Trajectory = "1"
            End If
            '*****************************************************
            enemies(x).Position = enArray(x).Location
            enemies(x).Direction()
            enArray(x).Location = enemies(x).Position
            '******************************************************

            If bulletCol(en) Then
                If game = "Normal" Then
                    intCount3 += 1
                    If intCount3 Mod 20 = 0 Then
                        boss = True
                        Boss_start()
                    End If
                End If
                If boss Then
                        en.SetBounds(Me.Height + 200, Me.Width + 200, 0, 0)

                    Else
                        en.SetBounds(888 - int * 2, 237 - int * 2, 0, 0) 'changes location
                    End If

                End If
                'moved from hear
                If picPlayer.Bounds.IntersectsWith(en.Bounds) Then 'May need to be moved later
                en.SetBounds(100, Me.Width - 100, 0, 0) ' location of the enemy
                If prbHealth.Value <> 0 Then
                    prbHealth.Value -= 10
                End If
                If prbHealth.Value = 0 Then
                    tmrBullet.Enabled = False
                    Timer1.Enabled = False
                    'game = "Over"
                    'MessageBox.Show("Game Over")
                    GameOver()
                    Exit For
                End If
            End If
        Next


    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        If game = "login" Then
            MessageBox.Show("Please Login First")
        Else
            StartGame()
        End If

    End Sub

    Private Sub MultiplayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplayerToolStripMenuItem.Click
        StartMultiplayer()
    End Sub

    Public Sub StartGame() 'start the normal game here.... going to spawn an array of enemies that will keep respawning until character dies
        game = "Normal"
        prbHealth.Value = 100
        picPlayer.SetBounds(90, 247, 0, 0)
        Respawn()
        Timer1.Enabled = True 'starts the timer that makes the enemy move
        picEn2.Visible = True
        picEn3.Visible = True
        picEn4.Visible = True
        picEn5.Visible = True
        prbEnHp.Visible = False
        Label2.Visible = False
        lblScore.Text = "0"
        score = 0
        count = 0
        count2 = 0
        intCount = 0
        intCount3 = 0

    End Sub

    Public Sub StartMultiplayer()
        game = "Multiplayer"
        prbEnHp.Value = 100
        prbHealth.Value = 100
        prbEnHp.Visible = True
        Label2.Visible = True
        picEn2.Visible = False
        picEn3.Visible = False
        picEn4.Visible = False
        picEn5.Visible = False
        picPlayer.SetBounds(90, 247, 0, 0)
        picEn.SetBounds(888, 247, 0, 0)
        lblScore.Visible = False
        intCount = 0
        intCount2 = 0
    End Sub

    Public Sub GameOver()

        Timer1.Enabled = False
        tmrBullet.Enabled = False
        tmrEnBullet.Enabled = False
        picEn2.Visible = False
        picEn3.Visible = False
        picEn4.Visible = False
        picEn5.Visible = False
        If game.Equals("Multiplayer") Then
            MessageBox.Show("Game is over!")
        ElseIf game.Equals("Over") Then
            MessageBox.Show("Game is over!")
        Else
            'Trying to call the player name when game is over.
            MessageBox.Show("Game is over!" & ControlChars.NewLine & DatabaseForm.getData("player_name", Login.txtName.Text).ToString & ControlChars.NewLine & "Score: " & score)
        End If
        game = "Over"
    End Sub

    Private Sub Respawn()
        picEn.SetBounds(888, 197, 0, 0)
        picEn2.SetBounds(888, 247, 0, 0)
        picEn3.SetBounds(888, 297, 0, 0)
        picEn4.SetBounds(888, 347, 0, 0)
        picEn5.SetBounds(888, 397, 0, 0)
        picEn.Visible = True
        picEn2.Visible = True
        picEn3.Visible = True
        picEn4.Visible = True
        picEn5.Visible = True
    End Sub

    Private Function bulletCol(pic As PictureBox) As Boolean

        If p1b1.Bounds.IntersectsWith(pic.Bounds) Then
            p1b1.SetBounds(-100, Me.Width - 100, 5, 5)
            score += 1
            lblScore.Text = score.ToString
            Return True
        ElseIf p1b2.Bounds.IntersectsWith(pic.Bounds) Then
            p1b2.SetBounds(-100, Me.Width - 100, 5, 5)
            score += 1
            lblScore.Text = score.ToString
            Return True
        ElseIf p1b3.Bounds.IntersectsWith(pic.Bounds) Then
            p1b3.SetBounds(-100, Me.Width - 100, 5, 5)
            score += 1
            lblScore.Text = score.ToString
            Return True
        ElseIf p1b4.Bounds.IntersectsWith(pic.Bounds) Then
            p1b4.SetBounds(-100, Me.Width - 100, 5, 5)
            score += 1
            lblScore.Text = score.ToString
            Return True
        ElseIf p1b5.Bounds.IntersectsWith(pic.Bounds) Then
            p1b5.SetBounds(-100, Me.Width - 100, 5, 5)
            score += 1
            lblScore.Text = score.ToString
            Return True
        Else
            Return False
        End If


    End Function

    Private Function EnBulletCol(pic As PictureBox) As Boolean
        If p2b1.Bounds.IntersectsWith(pic.Bounds) Then
            p2b1.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b2.Bounds.IntersectsWith(pic.Bounds) Then
            p2b2.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b3.Bounds.IntersectsWith(pic.Bounds) Then
            p2b3.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b4.Bounds.IntersectsWith(pic.Bounds) Then
            p2b4.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        ElseIf p2b5.Bounds.IntersectsWith(pic.Bounds) Then
            p2b5.SetBounds(100, Me.Width - 100, 5, 5)
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Bullet_Collision(bullets() As PictureBox, target As PictureBox) As Boolean
        For i As Integer = 0 To bullets.Length - 1
            If bullets(i).Bounds.IntersectsWith(target.Bounds) Then
                bullets(i).SetBounds(-100, -100, 5, 5)
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub tmrEnBullet_Tick(sender As Object, e As EventArgs) Handles tmrEnBullet.Tick
        'If Not boss Then
        '    Dim EnBullets() As PictureBox = {p2b1, p2b2, p2b3, p2b4, p2b5}
        'Else
        '    Dim EnBullets() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}
        'End If
        'Static picBullets(4) As Bullet
        'For i As Integer = 0 To 4
        '    picBullets(i) = New Bullet
        '    picBullets(i).Trajectory = "4"
        'Next

        'For x As Integer = 0 To intCount2
        '    'Bullets(x).Left += 10

        '    picBullets(x).Position = EnBullets(x).Location
        '    picBullets(x).Direction()
        '    EnBullets(x).Location = picBullets(x).Position
        'Next
        'If boss Then
        '    If Bullet_Collision(EnBullets, picPlayer) Then
        '        prbHealth.Value -= 10
        '        If prbHealth.Value = 0 Then
        '            tmrEnBullet.Enabled = False
        '            tmrBullet.Enabled = False
        '            GameOver()
        '        End If
        '    End If
        'Else
        '    If EnBulletCol(picPlayer) Then
        '        prbHealth.Value -= 10
        '        If prbHealth.Value = 0 Then
        '            tmrEnBullet.Enabled = False
        '            tmrBullet.Enabled = False
        '            GameOver()
        '        End If
        '    End If
        'End If

        Dim Bullets() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}
        Static picBullets(4) As Bullet
        Static count As Integer = 0
        Dim d As String = "4"
        If count = 0 Then

            For i As Integer = 0 To 4
                picBullets(i) = New Bullet

            Next
            count2 += 1
        End If

        For x As Integer = 0 To Bullets.Length - 1
            picBullets(x).Trajectory = d

            picBullets(x).Position = Bullets(x).Location
            picBullets(x).Direction()
            Bullets(x).Location = picBullets(x).Position
        Next
        If Bullet_Collision(Bullets, picPlayer) Then
            prbHealth.Value -= 10
            If prbHealth.Value = 0 Then
                tmrEnBullet.Enabled = False
                tmrBullet.Enabled = False
                GameOver()
            End If
        End If
    End Sub


    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        DatabaseForm.Visible = True
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Visible = True
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        MessageBox.Show("Use SZXC for up,left,down,right controls. Kill enemies before they hit you or hit the end", "Instructions")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Computer 009 advanced visual basic project 2 and 4.", "About")
    End Sub

    Private Sub tmrBoss_Tick(sender As Object, e As EventArgs) Handles tmrBoss.Tick
        Static k As Integer = 0
        Static king As New Enemy("king", (intCount3 \ 20) * 10, (intCount3 \ 20) * 100, 20 + score Mod 20, "none", picBoss.Location)
        Label2.Text = "Health: " & king.Health
        If bulletCol(picBoss) Then
            king.Health -= player1.Damage
        End If
        king.Position = picBoss.Location
        tmrBossAttack.Enabled = True
        If king.Health = 0 Then
            Boss_end()
        End If
    End Sub

    Private Sub Boss_start()
        Timer1.Enabled = False
        tmrEnBullet.Enabled = True
        tmrBoss.Enabled = True
        picBoss.Visible = True
        Label2.Visible = True
        picEn.Visible = False
        picEn2.Visible = False
        picEn3.Visible = False
        picEn4.Visible = False
        picEn5.Visible = False
    End Sub

    Private Sub Boss_end()
        Timer1.Enabled = True
        tmrBoss.Enabled = False
        tmrEnBullet.Enabled = False
        picBoss.Visible = False
        Label2.Visible = False
        prbEnHp.Visible = False
        Label2.Text = "Health"
        tmrBossAttack.Enabled = False
        intCount2 = 0
        Respawn()
    End Sub

    Private Sub tmrBossAttack_Tick(sender As Object, e As EventArgs) Handles tmrBossAttack.Tick
        Dim num As Integer = rnd.Next(0, 50)
        Dim EnBullets() As PictureBox = {picEn, picEn2, picEn3, picEn4, picEn5}
        Dim bLoc As Point
        Select Case num
            Case 0 To 50
                If game.Equals("Over") = False Then

                    bLoc = New Point(picBoss.Location.X, picBoss.Location.Y + 150)
                    EnBullets(intCount2).Location = bLoc


                    tmrEnBullet.Enabled = True
                    EnBullets(intCount2).Visible = True
                    intCount2 += 1
                    If intCount2 = 5 Then
                        intCount2 = 0
                    End If
                End If
        End Select
    End Sub
End Class
