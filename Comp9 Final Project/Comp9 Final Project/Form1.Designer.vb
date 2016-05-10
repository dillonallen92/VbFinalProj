<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.prbEnHp = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prbHealth = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnBullet = New System.Windows.Forms.Timer(Me.components)
        Me.picEn5 = New System.Windows.Forms.PictureBox()
        Me.picEn4 = New System.Windows.Forms.PictureBox()
        Me.picEn3 = New System.Windows.Forms.PictureBox()
        Me.picEn2 = New System.Windows.Forms.PictureBox()
        Me.p2b5 = New System.Windows.Forms.PictureBox()
        Me.p2b4 = New System.Windows.Forms.PictureBox()
        Me.p2b3 = New System.Windows.Forms.PictureBox()
        Me.p2b2 = New System.Windows.Forms.PictureBox()
        Me.p2b1 = New System.Windows.Forms.PictureBox()
        Me.p1b4 = New System.Windows.Forms.PictureBox()
        Me.p1b3 = New System.Windows.Forms.PictureBox()
        Me.p1b5 = New System.Windows.Forms.PictureBox()
        Me.p1b2 = New System.Windows.Forms.PictureBox()
        Me.p1b1 = New System.Windows.Forms.PictureBox()
        Me.picEn = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picEn5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2b5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2b4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2b3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2b2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2b1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1b1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Black
        Me.lblScore.ForeColor = System.Drawing.Color.Yellow
        Me.lblScore.Location = New System.Drawing.Point(126, 51)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 13)
        Me.lblScore.TabIndex = 43
        '
        'prbEnHp
        '
        Me.prbEnHp.BackColor = System.Drawing.SystemColors.Control
        Me.prbEnHp.Location = New System.Drawing.Point(1030, 42)
        Me.prbEnHp.Name = "prbEnHp"
        Me.prbEnHp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prbEnHp.Size = New System.Drawing.Size(100, 23)
        Me.prbEnHp.TabIndex = 28
        Me.prbEnHp.Value = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(1093, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Health"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Health"
        '
        'prbHealth
        '
        Me.prbHealth.BackColor = System.Drawing.SystemColors.Control
        Me.prbHealth.Location = New System.Drawing.Point(11, 42)
        Me.prbHealth.Name = "prbHealth"
        Me.prbHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prbHealth.Size = New System.Drawing.Size(100, 23)
        Me.prbHealth.TabIndex = 22
        Me.prbHealth.Value = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.StartGameToolStripMenuItem, Me.HelpToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1151, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.MultiplayerToolStripMenuItem})
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'MultiplayerToolStripMenuItem
        '
        Me.MultiplayerToolStripMenuItem.Name = "MultiplayerToolStripMenuItem"
        Me.MultiplayerToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.MultiplayerToolStripMenuItem.Text = "Multiplayer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'tmrEnBullet
        '
        Me.tmrEnBullet.Interval = 1
        '
        'picEn5
        '
        Me.picEn5.BackColor = System.Drawing.Color.Transparent
        Me.picEn5.Image = Global.WindowsApplication1.My.Resources.Resources.cloudEnemy
        Me.picEn5.Location = New System.Drawing.Point(888, 404)
        Me.picEn5.Name = "picEn5"
        Me.picEn5.Size = New System.Drawing.Size(100, 50)
        Me.picEn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn5.TabIndex = 42
        Me.picEn5.TabStop = False
        '
        'picEn4
        '
        Me.picEn4.BackColor = System.Drawing.Color.Transparent
        Me.picEn4.Image = Global.WindowsApplication1.My.Resources.Resources.cloudEnemy
        Me.picEn4.Location = New System.Drawing.Point(888, 145)
        Me.picEn4.Name = "picEn4"
        Me.picEn4.Size = New System.Drawing.Size(100, 50)
        Me.picEn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn4.TabIndex = 41
        Me.picEn4.TabStop = False
        '
        'picEn3
        '
        Me.picEn3.BackColor = System.Drawing.Color.Transparent
        Me.picEn3.Image = Global.WindowsApplication1.My.Resources.Resources.cloudEnemy
        Me.picEn3.Location = New System.Drawing.Point(888, 206)
        Me.picEn3.Name = "picEn3"
        Me.picEn3.Size = New System.Drawing.Size(100, 50)
        Me.picEn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn3.TabIndex = 40
        Me.picEn3.TabStop = False
        '
        'picEn2
        '
        Me.picEn2.BackColor = System.Drawing.Color.Transparent
        Me.picEn2.Image = Global.WindowsApplication1.My.Resources.Resources.cloudEnemy
        Me.picEn2.Location = New System.Drawing.Point(888, 273)
        Me.picEn2.Name = "picEn2"
        Me.picEn2.Size = New System.Drawing.Size(100, 50)
        Me.picEn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn2.TabIndex = 39
        Me.picEn2.TabStop = False
        '
        'p2b5
        '
        Me.p2b5.Location = New System.Drawing.Point(713, 42)
        Me.p2b5.Margin = New System.Windows.Forms.Padding(2)
        Me.p2b5.Name = "p2b5"
        Me.p2b5.Size = New System.Drawing.Size(4, 4)
        Me.p2b5.TabIndex = 38
        Me.p2b5.TabStop = False
        Me.p2b5.Visible = False
        '
        'p2b4
        '
        Me.p2b4.Location = New System.Drawing.Point(683, 42)
        Me.p2b4.Margin = New System.Windows.Forms.Padding(2)
        Me.p2b4.Name = "p2b4"
        Me.p2b4.Size = New System.Drawing.Size(4, 4)
        Me.p2b4.TabIndex = 37
        Me.p2b4.TabStop = False
        Me.p2b4.Visible = False
        '
        'p2b3
        '
        Me.p2b3.Location = New System.Drawing.Point(660, 42)
        Me.p2b3.Margin = New System.Windows.Forms.Padding(2)
        Me.p2b3.Name = "p2b3"
        Me.p2b3.Size = New System.Drawing.Size(4, 4)
        Me.p2b3.TabIndex = 36
        Me.p2b3.TabStop = False
        Me.p2b3.Visible = False
        '
        'p2b2
        '
        Me.p2b2.Location = New System.Drawing.Point(631, 42)
        Me.p2b2.Margin = New System.Windows.Forms.Padding(2)
        Me.p2b2.Name = "p2b2"
        Me.p2b2.Size = New System.Drawing.Size(4, 4)
        Me.p2b2.TabIndex = 35
        Me.p2b2.TabStop = False
        Me.p2b2.Visible = False
        '
        'p2b1
        '
        Me.p2b1.Location = New System.Drawing.Point(334, 52)
        Me.p2b1.Margin = New System.Windows.Forms.Padding(2)
        Me.p2b1.Name = "p2b1"
        Me.p2b1.Size = New System.Drawing.Size(4, 4)
        Me.p2b1.TabIndex = 34
        Me.p2b1.TabStop = False
        Me.p2b1.Visible = False
        '
        'p1b4
        '
        Me.p1b4.Location = New System.Drawing.Point(184, 51)
        Me.p1b4.Margin = New System.Windows.Forms.Padding(2)
        Me.p1b4.Name = "p1b4"
        Me.p1b4.Size = New System.Drawing.Size(5, 5)
        Me.p1b4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b4.TabIndex = 33
        Me.p1b4.TabStop = False
        Me.p1b4.Visible = False
        '
        'p1b3
        '
        Me.p1b3.Location = New System.Drawing.Point(262, 51)
        Me.p1b3.Margin = New System.Windows.Forms.Padding(2)
        Me.p1b3.Name = "p1b3"
        Me.p1b3.Size = New System.Drawing.Size(5, 5)
        Me.p1b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b3.TabIndex = 32
        Me.p1b3.TabStop = False
        Me.p1b3.Visible = False
        '
        'p1b5
        '
        Me.p1b5.Location = New System.Drawing.Point(299, 51)
        Me.p1b5.Margin = New System.Windows.Forms.Padding(2)
        Me.p1b5.Name = "p1b5"
        Me.p1b5.Size = New System.Drawing.Size(5, 5)
        Me.p1b5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b5.TabIndex = 31
        Me.p1b5.TabStop = False
        Me.p1b5.Visible = False
        '
        'p1b2
        '
        Me.p1b2.Location = New System.Drawing.Point(214, 51)
        Me.p1b2.Margin = New System.Windows.Forms.Padding(2)
        Me.p1b2.Name = "p1b2"
        Me.p1b2.Size = New System.Drawing.Size(5, 5)
        Me.p1b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b2.TabIndex = 30
        Me.p1b2.TabStop = False
        Me.p1b2.Visible = False
        '
        'p1b1
        '
        Me.p1b1.Location = New System.Drawing.Point(520, 51)
        Me.p1b1.Margin = New System.Windows.Forms.Padding(2)
        Me.p1b1.Name = "p1b1"
        Me.p1b1.Size = New System.Drawing.Size(5, 5)
        Me.p1b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.p1b1.TabIndex = 29
        Me.p1b1.TabStop = False
        Me.p1b1.Visible = False
        '
        'picEn
        '
        Me.picEn.BackColor = System.Drawing.Color.Transparent
        Me.picEn.Image = Global.WindowsApplication1.My.Resources.Resources.cloudEnemy
        Me.picEn.Location = New System.Drawing.Point(888, 338)
        Me.picEn.Name = "picEn"
        Me.picEn.Size = New System.Drawing.Size(100, 50)
        Me.picEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picEn.TabIndex = 24
        Me.picEn.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.WindowsApplication1.My.Resources.Resources.bl_ship
        Me.picPlayer.Location = New System.Drawing.Point(89, 245)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(100, 50)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPlayer.TabIndex = 23
        Me.picPlayer.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.space_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1151, 610)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picEn5)
        Me.Controls.Add(Me.picEn4)
        Me.Controls.Add(Me.picEn3)
        Me.Controls.Add(Me.picEn2)
        Me.Controls.Add(Me.p2b5)
        Me.Controls.Add(Me.p2b4)
        Me.Controls.Add(Me.p2b3)
        Me.Controls.Add(Me.p2b2)
        Me.Controls.Add(Me.p2b1)
        Me.Controls.Add(Me.p1b4)
        Me.Controls.Add(Me.p1b3)
        Me.Controls.Add(Me.p1b5)
        Me.Controls.Add(Me.p1b2)
        Me.Controls.Add(Me.p1b1)
        Me.Controls.Add(Me.prbEnHp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prbHealth)
        Me.Controls.Add(Me.picEn)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Cloud"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picEn5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2b5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2b4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2b3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2b2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2b1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1b1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picEn5 As System.Windows.Forms.PictureBox
    Friend WithEvents picEn4 As System.Windows.Forms.PictureBox
    Friend WithEvents picEn3 As System.Windows.Forms.PictureBox
    Friend WithEvents picEn2 As System.Windows.Forms.PictureBox
    Friend WithEvents p2b5 As System.Windows.Forms.PictureBox
    Friend WithEvents p2b4 As System.Windows.Forms.PictureBox
    Friend WithEvents p2b3 As System.Windows.Forms.PictureBox
    Friend WithEvents p2b2 As System.Windows.Forms.PictureBox
    Friend WithEvents p2b1 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b4 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b3 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b5 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b2 As System.Windows.Forms.PictureBox
    Friend WithEvents p1b1 As System.Windows.Forms.PictureBox
    Friend WithEvents prbEnHp As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prbHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents picEn As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiplayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrBullet As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnBullet As System.Windows.Forms.Timer
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
