Public Class Game
    Dim KeyLeft, KeyRight As Boolean

    Dim YPos As Single
    Dim YVel As Decimal

    Dim BurekCount As Single

    Dim Platforms As List(Of PictureBox)

    Dim PlayerImg1 As Image = My.Resources.Meme7
    Dim PlayerImg2 As Image = My.Resources.Meme8

    Dim TimeInvinc As Single


    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()


        KeyLeft = False
        KeyRight = False

        YPos = 0
        YVel = 25

        BurekCount = 0

        Platforms = New List(Of PictureBox)

        TimeInvinc = 0

        Platforms.Add(Platform1)
        Platforms.Add(Platform2)
        Platforms.Add(Platform3)

        Platform1.Top = 50
        Platform2.Top = -300
        Platform3.Top = -700

        Burek.Top = -100
        Burek.Left = Rnd() * Me.Size.Width - 60

        Jogurt.Top = -500
        Jogurt.Left = Rnd() * Me.Size.Width - 60

        Cindric.Top = -200
        Cindric.Left = Rnd() * Me.Size.Width - 100
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

        TimeInvinc -= 1

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

            If Platforms(i).Bounds.IntersectsWith(Player.Bounds) And YVel < 10 Then
                My.Computer.Audio.Play(My.Resources.Boing, AudioPlayMode.Background)
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

            If TimeInvinc < 0 Then
                My.Computer.Audio.Play(My.Resources.Eat, AudioPlayMode.Background)
            End If

            If Player.Image Is PlayerImg1 Then
                Player.Image = PlayerImg2
            Else
                Player.Image = PlayerImg1
            End If
        End If
        If Burek.Top > Me.Size.Height + 150 Then
            Burek.Top = -100
            Burek.Left = Rnd() * Me.Size.Width - 60
        End If

        Cindric.Top += YVel
        If Cindric.Bounds.IntersectsWith(Player.Bounds) And TimeInvinc <= 0 Then
            Smrt(True)
        End If
        If Cindric.Top > Me.Size.Height + 150 Then
            Cindric.Top = -100
            Cindric.Left = Rnd() * Me.Size.Width - 100
        End If

        Jogurt.Top += YVel
        If Jogurt.Bounds.IntersectsWith(Player.Bounds) Then
            TimeInvinc = 60 * 3
            YVel = 60

            Jogurt.Top = -1500
            Jogurt.Left = Rnd() * Me.Size.Width - 60

            My.Computer.Audio.Play(My.Resources.gg, AudioPlayMode.Background)
        End If
        If Jogurt.Top > Me.Size.Height + 400 Then
            Jogurt.Top = -1000
            Jogurt.Left = Rnd() * Me.Size.Width - 60
        End If

        If YVel < -30 Then
            Smrt(False)
        End If

    End Sub

    Private Sub Smrt(ByVal JeLiCindric)
        UpdateTimer.Stop()

        Dim mbr As DialogResult

        If JeLiCindric Then
            My.Computer.Audio.Play(My.Resources.Upper_Cut_SoundBible_com_1272257235, AudioPlayMode.Background)
            mbr = MessageBox.Show("Ubio vas je Bibinjac! Želite li probati još jednom? Vaša visina bila je " + Str(Math.Round(YPos / 10)) + ", a pokupili ste " + Str(BurekCount) + " bureka", "Smrt", MessageBoxButtons.YesNo)
        Else
            My.Computer.Audio.Play(My.Resources._0477, AudioPlayMode.Background)
            mbr = MessageBox.Show("Pali ste u smrt! Želite li probati još jednom? Vaša visina bila je " + Str(Math.Round(YPos / 10)) + ", a pokupili ste " + Str(BurekCount) + " bureka", "Smrt", MessageBoxButtons.YesNo)
        End If

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

        Jogurt.Top = -500
        Jogurt.Left = Rnd() * Me.Size.Width - 60

        Cindric.Top = -100
        Cindric.Left = Rnd() * Me.Size.Width - 100

        Player.Left = Me.Size.Width / 2 - 50

        TimerStart.Start()
        LabelZapocinje.Visible = True
    End Sub
End Class