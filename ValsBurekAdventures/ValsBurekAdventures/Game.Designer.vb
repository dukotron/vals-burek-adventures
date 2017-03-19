<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LabelVisina = New System.Windows.Forms.Label()
        Me.LabelHeightDash = New System.Windows.Forms.Label()
        Me.TimerStart = New System.Windows.Forms.Timer(Me.components)
        Me.LabelZapocinje = New System.Windows.Forms.Label()
        Me.LabelBurek = New System.Windows.Forms.Label()
        Me.Cindric = New System.Windows.Forms.PictureBox()
        Me.Burek = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Platform3 = New System.Windows.Forms.PictureBox()
        Me.Platform2 = New System.Windows.Forms.PictureBox()
        Me.Platform1 = New System.Windows.Forms.PictureBox()
        CType(Me.Cindric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Burek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 17
        '
        'LabelVisina
        '
        Me.LabelVisina.AutoSize = True
        Me.LabelVisina.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelVisina.Location = New System.Drawing.Point(12, 528)
        Me.LabelVisina.Name = "LabelVisina"
        Me.LabelVisina.Size = New System.Drawing.Size(91, 26)
        Me.LabelVisina.TabIndex = 4
        Me.LabelVisina.Text = "VISINA:"
        '
        'LabelHeightDash
        '
        Me.LabelHeightDash.AutoSize = True
        Me.LabelHeightDash.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelHeightDash.Location = New System.Drawing.Point(13, 13)
        Me.LabelHeightDash.Name = "LabelHeightDash"
        Me.LabelHeightDash.Size = New System.Drawing.Size(354, 26)
        Me.LabelHeightDash.TabIndex = 5
        Me.LabelHeightDash.Text = "__                                                 __"
        '
        'TimerStart
        '
        Me.TimerStart.Enabled = True
        Me.TimerStart.Interval = 3000
        '
        'LabelZapocinje
        '
        Me.LabelZapocinje.AutoSize = True
        Me.LabelZapocinje.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelZapocinje.Location = New System.Drawing.Point(35, 153)
        Me.LabelZapocinje.Name = "LabelZapocinje"
        Me.LabelZapocinje.Size = New System.Drawing.Size(305, 29)
        Me.LabelZapocinje.TabIndex = 6
        Me.LabelZapocinje.Text = "Igra započinje u 3 sekunde."
        '
        'LabelBurek
        '
        Me.LabelBurek.AutoSize = True
        Me.LabelBurek.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelBurek.Location = New System.Drawing.Point(12, 502)
        Me.LabelBurek.Name = "LabelBurek"
        Me.LabelBurek.Size = New System.Drawing.Size(95, 26)
        Me.LabelBurek.TabIndex = 8
        Me.LabelBurek.Text = "BUREK:"
        '
        'Cindric
        '
        Me.Cindric.Image = Global.ValsBurekAdventures.My.Resources.Resources._580b57fbd9996e24bc43be68
        Me.Cindric.Location = New System.Drawing.Point(227, 209)
        Me.Cindric.Name = "Cindric"
        Me.Cindric.Size = New System.Drawing.Size(100, 93)
        Me.Cindric.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cindric.TabIndex = 9
        Me.Cindric.TabStop = False
        '
        'Burek
        '
        Me.Burek.Image = Global.ValsBurekAdventures.My.Resources.Resources.Burek
        Me.Burek.Location = New System.Drawing.Point(214, 91)
        Me.Burek.Name = "Burek"
        Me.Burek.Size = New System.Drawing.Size(47, 50)
        Me.Burek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Burek.TabIndex = 7
        Me.Burek.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = Global.ValsBurekAdventures.My.Resources.Resources.Obama_head
        Me.Player.InitialImage = Global.ValsBurekAdventures.My.Resources.Resources.Obama_head
        Me.Player.Location = New System.Drawing.Point(152, 423)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(59, 74)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Platform3
        '
        Me.Platform3.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform3.Location = New System.Drawing.Point(214, 352)
        Me.Platform3.Name = "Platform3"
        Me.Platform3.Size = New System.Drawing.Size(98, 17)
        Me.Platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform3.TabIndex = 3
        Me.Platform3.TabStop = False
        '
        'Platform2
        '
        Me.Platform2.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform2.Location = New System.Drawing.Point(113, 285)
        Me.Platform2.Name = "Platform2"
        Me.Platform2.Size = New System.Drawing.Size(98, 17)
        Me.Platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform2.TabIndex = 2
        Me.Platform2.TabStop = False
        '
        'Platform1
        '
        Me.Platform1.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform1.Location = New System.Drawing.Point(22, 232)
        Me.Platform1.Name = "Platform1"
        Me.Platform1.Size = New System.Drawing.Size(98, 17)
        Me.Platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform1.TabIndex = 1
        Me.Platform1.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(381, 563)
        Me.Controls.Add(Me.LabelBurek)
        Me.Controls.Add(Me.LabelVisina)
        Me.Controls.Add(Me.Cindric)
        Me.Controls.Add(Me.Burek)
        Me.Controls.Add(Me.LabelZapocinje)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Platform3)
        Me.Controls.Add(Me.Platform2)
        Me.Controls.Add(Me.Platform1)
        Me.Controls.Add(Me.LabelHeightDash)
        Me.DoubleBuffered = True
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Val's Burek Adventures"
        CType(Me.Cindric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Burek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents Platform2 As PictureBox
    Friend WithEvents Platform3 As PictureBox
    Friend WithEvents LabelVisina As Label
    Friend WithEvents LabelHeightDash As Label
    Friend WithEvents TimerStart As Timer
    Friend WithEvents LabelZapocinje As Label
    Friend WithEvents Burek As PictureBox
    Friend WithEvents LabelBurek As Label
    Friend WithEvents Cindric As PictureBox
End Class
