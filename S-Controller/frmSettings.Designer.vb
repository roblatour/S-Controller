<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSonoffIPAddress = New System.Windows.Forms.TextBox()
        Me.tbMQTTIP = New System.Windows.Forms.TextBox()
        Me.tbSonoffMAC = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnWebInterface = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbSonoff = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMQTTMAC = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbRelay04Name = New System.Windows.Forms.TextBox()
        Me.tbRelay04Command = New System.Windows.Forms.TextBox()
        Me.tbRelay03Command = New System.Windows.Forms.TextBox()
        Me.tbRelay03Name = New System.Windows.Forms.TextBox()
        Me.tbRelay02Name = New System.Windows.Forms.TextBox()
        Me.tbRelay02Command = New System.Windows.Forms.TextBox()
        Me.tbRelay01Command = New System.Windows.Forms.TextBox()
        Me.tbRelay01Name = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cbRefreshRateEnabled = New System.Windows.Forms.CheckBox()
        Me.udRefreshRate = New System.Windows.Forms.NumericUpDown()
        Me.gbSonoff.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.udRefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MAC"
        '
        'tbSonoffIPAddress
        '
        Me.tbSonoffIPAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSonoffIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSonoffIPAddress.Location = New System.Drawing.Point(112, 31)
        Me.tbSonoffIPAddress.Name = "tbSonoffIPAddress"
        Me.tbSonoffIPAddress.Size = New System.Drawing.Size(199, 29)
        Me.tbSonoffIPAddress.TabIndex = 1
        '
        'tbMQTTIP
        '
        Me.tbMQTTIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMQTTIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMQTTIP.Location = New System.Drawing.Point(115, 32)
        Me.tbMQTTIP.Name = "tbMQTTIP"
        Me.tbMQTTIP.Size = New System.Drawing.Size(204, 29)
        Me.tbMQTTIP.TabIndex = 2
        '
        'tbSonoffMAC
        '
        Me.tbSonoffMAC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSonoffMAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSonoffMAC.Location = New System.Drawing.Point(112, 73)
        Me.tbSonoffMAC.Name = "tbSonoffMAC"
        Me.tbSonoffMAC.ReadOnly = True
        Me.tbSonoffMAC.Size = New System.Drawing.Size(201, 29)
        Me.tbSonoffMAC.TabIndex = 0
        Me.tbSonoffMAC.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(577, 441)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(120, 49)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnWebInterface
        '
        Me.btnWebInterface.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnWebInterface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnWebInterface.BackColor = System.Drawing.SystemColors.Control
        Me.btnWebInterface.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWebInterface.ForeColor = System.Drawing.Color.Black
        Me.btnWebInterface.Location = New System.Drawing.Point(136, 441)
        Me.btnWebInterface.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnWebInterface.Name = "btnWebInterface"
        Me.btnWebInterface.Size = New System.Drawing.Size(434, 49)
        Me.btnWebInterface.TabIndex = 6
        Me.btnWebInterface.Tag = ""
        Me.btnWebInterface.Text = "Open Sonoff &Web Interface"
        Me.btnWebInterface.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(9, 439)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 49)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbSonoff
        '
        Me.gbSonoff.Controls.Add(Me.tbSonoffIPAddress)
        Me.gbSonoff.Controls.Add(Me.Label1)
        Me.gbSonoff.Controls.Add(Me.Label2)
        Me.gbSonoff.Controls.Add(Me.tbSonoffMAC)
        Me.gbSonoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSonoff.Location = New System.Drawing.Point(9, 14)
        Me.gbSonoff.Name = "gbSonoff"
        Me.gbSonoff.Size = New System.Drawing.Size(327, 117)
        Me.gbSonoff.TabIndex = 0
        Me.gbSonoff.TabStop = False
        Me.gbSonoff.Text = "Sonoff"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbMQTTMAC)
        Me.GroupBox1.Controls.Add(Me.tbMQTTIP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(367, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MQTT server"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "MAC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IP address"
        '
        'tbMQTTMAC
        '
        Me.tbMQTTMAC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMQTTMAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMQTTMAC.Location = New System.Drawing.Point(115, 73)
        Me.tbMQTTMAC.Name = "tbMQTTMAC"
        Me.tbMQTTMAC.ReadOnly = True
        Me.tbMQTTMAC.Size = New System.Drawing.Size(201, 29)
        Me.tbMQTTMAC.TabIndex = 3
        Me.tbMQTTMAC.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 244)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay04Name, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay04Command, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay03Command, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay03Name, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay02Name, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay02Command, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay01Command, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRelay01Name, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(665, 190)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbRelay04Name
        '
        Me.tbRelay04Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay04Name.BackColor = System.Drawing.SystemColors.Control
        Me.tbRelay04Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRelay04Name.Location = New System.Drawing.Point(4, 152)
        Me.tbRelay04Name.Multiline = True
        Me.tbRelay04Name.Name = "tbRelay04Name"
        Me.tbRelay04Name.ReadOnly = True
        Me.tbRelay04Name.Size = New System.Drawing.Size(164, 34)
        Me.tbRelay04Name.TabIndex = 2
        Me.tbRelay04Name.TabStop = False
        Me.tbRelay04Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRelay04Command
        '
        Me.tbRelay04Command.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay04Command.BackColor = System.Drawing.SystemColors.Window
        Me.tbRelay04Command.Location = New System.Drawing.Point(175, 152)
        Me.tbRelay04Command.Multiline = True
        Me.tbRelay04Command.Name = "tbRelay04Command"
        Me.tbRelay04Command.Size = New System.Drawing.Size(486, 34)
        Me.tbRelay04Command.TabIndex = 6
        '
        'tbRelay03Command
        '
        Me.tbRelay03Command.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay03Command.BackColor = System.Drawing.SystemColors.Window
        Me.tbRelay03Command.Location = New System.Drawing.Point(175, 113)
        Me.tbRelay03Command.Multiline = True
        Me.tbRelay03Command.Name = "tbRelay03Command"
        Me.tbRelay03Command.Size = New System.Drawing.Size(486, 32)
        Me.tbRelay03Command.TabIndex = 5
        '
        'tbRelay03Name
        '
        Me.tbRelay03Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay03Name.BackColor = System.Drawing.SystemColors.Control
        Me.tbRelay03Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRelay03Name.Location = New System.Drawing.Point(4, 113)
        Me.tbRelay03Name.Multiline = True
        Me.tbRelay03Name.Name = "tbRelay03Name"
        Me.tbRelay03Name.ReadOnly = True
        Me.tbRelay03Name.Size = New System.Drawing.Size(164, 32)
        Me.tbRelay03Name.TabIndex = 1
        Me.tbRelay03Name.TabStop = False
        Me.tbRelay03Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRelay02Name
        '
        Me.tbRelay02Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay02Name.BackColor = System.Drawing.SystemColors.Control
        Me.tbRelay02Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRelay02Name.Location = New System.Drawing.Point(4, 74)
        Me.tbRelay02Name.Multiline = True
        Me.tbRelay02Name.Name = "tbRelay02Name"
        Me.tbRelay02Name.ReadOnly = True
        Me.tbRelay02Name.Size = New System.Drawing.Size(164, 32)
        Me.tbRelay02Name.TabIndex = 0
        Me.tbRelay02Name.TabStop = False
        Me.tbRelay02Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRelay02Command
        '
        Me.tbRelay02Command.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay02Command.BackColor = System.Drawing.SystemColors.Window
        Me.tbRelay02Command.Location = New System.Drawing.Point(175, 74)
        Me.tbRelay02Command.Multiline = True
        Me.tbRelay02Command.Name = "tbRelay02Command"
        Me.tbRelay02Command.Size = New System.Drawing.Size(486, 32)
        Me.tbRelay02Command.TabIndex = 4
        '
        'tbRelay01Command
        '
        Me.tbRelay01Command.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay01Command.BackColor = System.Drawing.SystemColors.Window
        Me.tbRelay01Command.Location = New System.Drawing.Point(175, 35)
        Me.tbRelay01Command.Multiline = True
        Me.tbRelay01Command.Name = "tbRelay01Command"
        Me.tbRelay01Command.Size = New System.Drawing.Size(486, 32)
        Me.tbRelay01Command.TabIndex = 3
        '
        'tbRelay01Name
        '
        Me.tbRelay01Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRelay01Name.BackColor = System.Drawing.SystemColors.Control
        Me.tbRelay01Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbRelay01Name.Location = New System.Drawing.Point(4, 35)
        Me.tbRelay01Name.Multiline = True
        Me.tbRelay01Name.Name = "tbRelay01Name"
        Me.tbRelay01Name.ReadOnly = True
        Me.tbRelay01Name.Size = New System.Drawing.Size(164, 32)
        Me.tbRelay01Name.TabIndex = 9
        Me.tbRelay01Name.TabStop = False
        Me.tbRelay01Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(164, 29)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Relay"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(175, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(486, 29)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Routine"
        '
        'cbRefreshRateEnabled
        '
        Me.cbRefreshRateEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbRefreshRateEnabled.AutoSize = True
        Me.cbRefreshRateEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRefreshRateEnabled.Location = New System.Drawing.Point(14, 389)
        Me.cbRefreshRateEnabled.Name = "cbRefreshRateEnabled"
        Me.cbRefreshRateEnabled.Size = New System.Drawing.Size(676, 28)
        Me.cbRefreshRateEnabled.TabIndex = 2
        Me.cbRefreshRateEnabled.Text = "If the MQTT server is unavailable check the Sonoff every                     seco" &
    "nds"
        Me.cbRefreshRateEnabled.UseVisualStyleBackColor = True
        '
        'udRefreshRate
        '
        Me.udRefreshRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.udRefreshRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udRefreshRate.Location = New System.Drawing.Point(509, 388)
        Me.udRefreshRate.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.udRefreshRate.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udRefreshRate.Name = "udRefreshRate"
        Me.udRefreshRate.Size = New System.Drawing.Size(91, 29)
        Me.udRefreshRate.TabIndex = 3
        Me.udRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.udRefreshRate.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'frmSettings
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(709, 502)
        Me.Controls.Add(Me.udRefreshRate)
        Me.Controls.Add(Me.cbRefreshRateEnabled)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbSonoff)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnWebInterface)
        Me.Controls.Add(Me.btnOK)
        Me.MinimumSize = New System.Drawing.Size(725, 490)
        Me.Name = "frmSettings"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Sonoff Contoller - Settings"
        Me.gbSonoff.ResumeLayout(False)
        Me.gbSonoff.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.udRefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSonoffIPAddress As TextBox
    Friend WithEvents tbMQTTIP As TextBox
    Friend WithEvents tbSonoffMAC As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnWebInterface As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents gbSonoff As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbRelay04Name As TextBox
    Friend WithEvents tbRelay03Name As TextBox
    Friend WithEvents tbRelay02Name As TextBox
    Friend WithEvents tbRelay01Name As TextBox
    Friend WithEvents tbRelay01Command As TextBox
    Friend WithEvents tbRelay04Command As TextBox
    Friend WithEvents tbRelay03Command As TextBox
    Friend WithEvents tbRelay02Command As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMQTTMAC As TextBox
    Friend WithEvents cbRefreshRateEnabled As CheckBox
    Friend WithEvents udRefreshRate As NumericUpDown
End Class
