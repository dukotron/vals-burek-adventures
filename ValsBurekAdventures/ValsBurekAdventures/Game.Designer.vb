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
        Me.Platform1 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Platform2 = New System.Windows.Forms.PictureBox()
        Me.Platform3 = New System.Windows.Forms.PictureBox()
        Me.LabelVisina = New System.Windows.Forms.Label()
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 17
        '
        'Platform1
        '
        Me.Platform1.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform1.Location = New System.Drawing.Point(22, 232)
        Me.Platform1.Name = "Platform1"
        Me.Platform1.Size = New System.Drawing.Size(135, 17)
        Me.Platform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform1.TabIndex = 1
        Me.Platform1.TabStop = False
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
        'Platform2
        '
        Me.Platform2.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform2.Location = New System.Drawing.Point(113, 291)
        Me.Platform2.Name = "Platform2"
        Me.Platform2.Size = New System.Drawing.Size(135, 17)
        Me.Platform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform2.TabIndex = 2
        Me.Platform2.TabStop = False
        '
        'Platform3
        '
        Me.Platform3.Image = Global.ValsBurekAdventures.My.Resources.Resources.Platforma
        Me.Platform3.Location = New System.Drawing.Point(214, 352)
        Me.Platform3.Name = "Platform3"
        Me.Platform3.Size = New System.Drawing.Size(135, 17)
        Me.Platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Platform3.TabIndex = 3
        Me.Platform3.TabStop = False
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
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(381, 563)
        Me.Controls.Add(Me.LabelVisina)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Platform3)
        Me.Controls.Add(Me.Platform2)
        Me.Controls.Add(Me.Platform1)
        Me.DoubleBuffered = True
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Val's Burek Adventures"
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents Platform2 As PictureBox
    Friend WithEvents Platform3 As PictureBox
    Friend WithEvents LabelVisina As Label
End Class
