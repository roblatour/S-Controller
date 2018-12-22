<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.gbRelays = New System.Windows.Forms.GroupBox()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MQTTOnlineTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnMystro = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tsSonoffStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsMQTTServerStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sOnoffTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MQTTRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gbMystro = New System.Windows.Forms.GroupBox()
        Me.gbRelays.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.gbMystro.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn4
        '
        Me.btn4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(14, 158)
        Me.btn4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(426, 34)
        Me.btn4.TabIndex = 4
        Me.btn4.Tag = "4"
        Me.btn4.Text = "Not found"
        Me.ToolTip1.SetToolTip(Me.btn4, "Click to run this relay's routine")
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(14, 116)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(426, 34)
        Me.btn3.TabIndex = 3
        Me.btn3.Tag = "3"
        Me.btn3.Text = "Not found"
        Me.ToolTip1.SetToolTip(Me.btn3, "Click to run this relay's routine")
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(14, 74)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(426, 34)
        Me.btn2.TabIndex = 2
        Me.btn2.Tag = "2"
        Me.btn2.Text = "Not found"
        Me.ToolTip1.SetToolTip(Me.btn2, "Click to run this relay's routine")
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(14, 32)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(426, 34)
        Me.btn1.TabIndex = 1
        Me.btn1.Tag = "1"
        Me.btn1.Text = "Not found"
        Me.ToolTip1.SetToolTip(Me.btn1, "Click to run this relay's routine")
        Me.btn1.UseVisualStyleBackColor = True
        '
        'gbRelays
        '
        Me.gbRelays.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbRelays.Controls.Add(Me.btn6)
        Me.gbRelays.Controls.Add(Me.btn7)
        Me.gbRelays.Controls.Add(Me.btn8)
        Me.gbRelays.Controls.Add(Me.btn5)
        Me.gbRelays.Controls.Add(Me.btn1)
        Me.gbRelays.Controls.Add(Me.btn2)
        Me.gbRelays.Controls.Add(Me.btn3)
        Me.gbRelays.Controls.Add(Me.btn4)
        Me.gbRelays.Location = New System.Drawing.Point(13, 42)
        Me.gbRelays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbRelays.Name = "gbRelays"
        Me.gbRelays.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbRelays.Size = New System.Drawing.Size(584, 207)
        Me.gbRelays.TabIndex = 1
        Me.gbRelays.TabStop = False
        Me.gbRelays.Text = "Relays"
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn6.Location = New System.Drawing.Point(462, 74)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(95, 33)
        Me.btn6.TabIndex = 6
        Me.btn6.Tag = "2"
        Me.btn6.Text = "Toggle"
        Me.ToolTip1.SetToolTip(Me.btn6, "Click to toggle this relay")
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn7.Location = New System.Drawing.Point(462, 116)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(95, 33)
        Me.btn7.TabIndex = 7
        Me.btn7.Tag = "3"
        Me.btn7.Text = "Toggle"
        Me.ToolTip1.SetToolTip(Me.btn7, "Click to toggle this relay")
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn8.Location = New System.Drawing.Point(462, 158)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(95, 33)
        Me.btn8.TabIndex = 7
        Me.btn8.Tag = "4"
        Me.btn8.Text = "Toggle"
        Me.ToolTip1.SetToolTip(Me.btn8, "Click to toggle this relay")
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn5.Location = New System.Drawing.Point(462, 32)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(95, 33)
        Me.btn5.TabIndex = 5
        Me.btn5.Tag = "1"
        Me.btn5.Text = "Toggle"
        Me.ToolTip1.SetToolTip(Me.btn5, "Click to toggle this relay")
        Me.btn5.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.Settings, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 25)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'Settings
        '
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(136, 26)
        Me.Settings.Text = "&Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MQTTOnlineTimer
        '
        '
        'btnMystro
        '
        Me.btnMystro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMystro.ForeColor = System.Drawing.Color.White
        Me.btnMystro.Location = New System.Drawing.Point(15, 23)
        Me.btnMystro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMystro.Name = "btnMystro"
        Me.btnMystro.Size = New System.Drawing.Size(543, 34)
        Me.btnMystro.TabIndex = 5
        Me.btnMystro.Tag = "4"
        Me.btnMystro.Text = " 1 + 2 + 3 + 4"
        Me.ToolTip1.SetToolTip(Me.btnMystro, "Click to run the Mystro routine")
        Me.btnMystro.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSonoffStatus, Me.ToolStripStatusLabel1, Me.tsMQTTServerStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 325)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(610, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'tsSonoffStatus
        '
        Me.tsSonoffStatus.ForeColor = System.Drawing.Color.Red
        Me.tsSonoffStatus.Name = "tsSonoffStatus"
        Me.tsSonoffStatus.Size = New System.Drawing.Size(98, 17)
        Me.tsSonoffStatus.Text = "Sonoff not found"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel1.Text = " | "
        '
        'tsMQTTServerStatus
        '
        Me.tsMQTTServerStatus.ForeColor = System.Drawing.Color.Red
        Me.tsMQTTServerStatus.Name = "tsMQTTServerStatus"
        Me.tsMQTTServerStatus.Size = New System.Drawing.Size(130, 17)
        Me.tsMQTTServerStatus.Text = "MQTT server not found"
        '
        'sOnoffTimer
        '
        '
        'MQTTRefreshTimer
        '
        '
        'gbMystro
        '
        Me.gbMystro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMystro.Controls.Add(Me.btnMystro)
        Me.gbMystro.Location = New System.Drawing.Point(12, 257)
        Me.gbMystro.Name = "gbMystro"
        Me.gbMystro.Size = New System.Drawing.Size(582, 65)
        Me.gbMystro.TabIndex = 3
        Me.gbMystro.TabStop = False
        Me.gbMystro.Text = "Mystro"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 347)
        Me.Controls.Add(Me.gbMystro)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.gbRelays)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(626, 320)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "sonoff Control"
        Me.gbRelays.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.gbMystro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents gbRelays As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Settings As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MQTTOnlineTimer As Timer
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents tsSonoffStatus As ToolStripStatusLabel
    Friend WithEvents tsMQTTServerStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents sOnoffTimer As Timer
    Friend WithEvents MQTTRefreshTimer As Timer
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbMystro As GroupBox
    Friend WithEvents btnMystro As Button
End Class
