Public Class Game
    Dim KeyLeft, KeyRight As Boolean

    Dim YPos As Single
    Dim YVel As Decimal

    Dim BurekCount As Single

    Dim Platforms As List(Of PictureBox)

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()


        KeyLeft = False
        KeyRight = False

        YPos = 0
        YVel = 25

        BurekCount = 0

        Platforms = New List(Of PictureBox)

        Platforms.Add(Platform1)
        Platforms.Add(Platform2)
        Platforms.Add(Platform3)

        Platform1.Top = 50
        Platform2.Top = -300
        Platform3.Top = -700

        Burek.Top = -100
        Burek.Left = Rnd() * Me.Size.Width - 60
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

    Private Sub TimerStart_Tick(sender As Object, e As EventArgs) Handles TimerStart.Tick
        TimerStart.Stop()
        UpdateTimer.Start()
        LabelZapocinje.Visible = False
    End Sub

    Private Sub Update_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        YPos += YVel

        LabelVisina.Text = "VISINA: " + Str(Math.Round(YPos / 10))
        LabelBurek.Text = "BUREK: " + Str(BurekCount)

        LabelHeightDash.Top = YPos Mod Me.Size.Height

        If KeyLeft Then
            Player.Left -= 5
        End If

        If Player.Left < 0 Then
            Player.Left = 0
        End If


        If KeyRight Then
            Player.Left += 5
        End If

        If Player.Left + Player.Bounds.Width > Me.Size.Width Then
            Player.Left = Me.Size.Width - Player.Bounds.Width
        End If


        YVel -= 0.5

        For i = 0 To 2
            Platforms(i).Top += YVel

            If Platforms(i).Bounds.IntersectsWith(Player.Bounds) And YVel < 0 Then
                YVel = 30

                Platforms(i).Top = -200 - Rnd() * 100
                Platforms(i).Left = Rnd() * (Me.Size.Width - 100)
            End If

            If Platforms(i).Top > Me.Size.Height + 150 Then
                Platforms(i).Top = -200 - Rnd(Rnd) * 100
                Platforms(i).Left = Rnd() * (Me.Size.Width - 100)
            End If
        Next

        Burek.Top += YVel
        If Burek.Bounds.IntersectsWith(Player.Bounds) Then
            BurekCount += 1
            Burek.Top = -100
            Burek.Left = Rnd() * Me.Size.Width - 60
        End If
        If Burek.Top > Me.Size.Height + 150 Then
            Burek.Top = -100
            Burek.Left = Rnd() * Me.Size.Width - 60
        End If

        If YVel < -20 Then
            Smrt()
        End If

    End Sub

    Private Sub Smrt()
        UpdateTimer.Stop()
        Dim mbr = MessageBox.Show("Umrli ste. Želite li probati još jednom? Vaša visina bila je " + Str(Math.Round(YPos / 10)) + ", a pokupili ste " + Str(BurekCount) + " bureka", "Smrt", MessageBoxButtons.YesNo)
        If mbr = DialogResult.Yes Then
            Retry()
        End If
        If mbr = DialogResult.No Then
            MainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Retry()
        KeyLeft = False
        KeyRight = False

        YPos = 0
        YVel = 25

        Platform1.Top = 50
        Platform2.Top = -300
        Platform3.Top = -700

        BurekCount = 0
        Burek.Top = -100
        Burek.Left = Rnd() * Me.Size.Width - 60

        Player.Left = Me.Size.Width / 2 - 50

        TimerStart.Start()
        LabelZapocinje.Visible = True
    End Sub
End Class