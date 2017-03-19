Public Class Game
    Dim KeyLeft, KeyRight As Boolean

    Dim YPos As Single
    Dim YVel As Decimal

    Dim Platforms As List(Of PictureBox)

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyLeft = False
        KeyRight = False

        YPos = 0
        YVel = 25

        Platforms = New List(Of PictureBox)

        Platforms.Add(Platform1)
        Platforms.Add(Platform2)
        Platforms.Add(Platform3)

        Platform1.Top = 50
        Platform2.Top = -100
        Platform3.Top = -200
    End Sub

    Private Sub KeyDownFunc(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then
            KeyLeft = True
        End If

        If e.KeyCode = Keys.Right Then
            KeyRight = True
        End If
    End Sub

    Private Sub KeyUpFunc(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            KeyLeft = False
        End If

        If e.KeyCode = Keys.Right Then
            KeyRight = False
        End If
    End Sub

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        YPos += YVel
        LabelVisina.Text = "VISINA: " + Str(Math.Round(YPos / 10))


        If KeyLeft Then
            Player.Left -= 5
        End If


        If KeyRight Then
            Player.Left += 5
        End If
        YVel -= 0.5

        For i = 0 To 2
            Platforms(i).Top += YVel

            If Platforms(i).Bounds.IntersectsWith(Player.Bounds) And YVel < 0 Then
                YVel = 30

                Platforms(i).Top = -Rnd() * 500
            End If

            If Platforms(i).Top > Me.Size.Height + 300 Then
                Platforms(i).Top = -Rnd(Rnd) * 500
            End If
        Next

    End Sub
End Class