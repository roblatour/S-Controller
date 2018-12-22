'Copyright Rob Latour, All Rights Reserved, 2018

Imports System.Net

Public Class frmSettings

    Private FormIsLoading As Boolean

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = gProgramName & " - Settings"
        Me.Icon = My.Resources.S_Controller

        FormIsLoading = True

        With My.Settings

            tbSonoffIPAddress.Text = .SonoffIP
            tbSonoffMAC.Text = .SonoffMAC

            tbMQTTIP.Text = .MQTTIP
            tbMQTTMAC.Text = .MQTTMAC

            cbRefreshRateEnabled.Checked = .RefreshRateEnabled
            udRefreshRate.Value = .RefreshRateValue

            tbRelay01Command.Text = .Relay01Commands
            tbRelay02Command.Text = .Relay02Commands
            tbRelay03Command.Text = .Relay03Commands
            tbRelay04Command.Text = .Relay04Commands

            cb01.Checked = .Mystro01
            cb02.Checked = .Mystro02
            cb03.Checked = .Mystro03
            cb04.Checked = .Mystro04

        End With

        udRefreshRate.Enabled = cbRefreshRateEnabled.Checked

        tbRelay01Name.Text = frmMain.btn1.Text.Replace("(ON)", "").Replace("(OFF)", "")
        tbRelay02Name.Text = frmMain.btn2.Text.Replace("(ON)", "").Replace("(OFF)", "")
        tbRelay03Name.Text = frmMain.btn3.Text.Replace("(ON)", "").Replace("(OFF)", "")
        tbRelay04Name.Text = frmMain.btn4.Text.Replace("(ON)", "").Replace("(OFF)", "")

        cb01.Text = tbRelay01Name.Text
        cb02.Text = tbRelay02Name.Text
        cb03.Text = tbRelay03Name.Text
        cb04.Text = tbRelay04Name.Text

        tbSonoffIPAddress.Select()
        tbSonoffIPAddress.SelectionStart = tbSonoffIPAddress.Text.Length
        tbSonoffIPAddress.SelectionLength = 0

        FormIsLoading = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Const PromptQuestion As String = vbCrLf & "Do you still want to save and exit Settings?"
        Const PromptStyle As MsgBoxStyle = MsgBoxStyle.YesNo Or MsgBoxStyle.Question

        Dim ip As IPAddress = Nothing
        Dim is_valid_ip_address As Boolean

        If tbSonoffIPAddress.Text.Length = 0 Then

            is_valid_ip_address = False
            If MsgBox("Sonoff IP address is missing" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                Exit Sub
            End If

        Else

            ip = Nothing
            is_valid_ip_address = IPAddress.TryParse(tbSonoffIPAddress.Text, ip)
            If is_valid_ip_address Then
            Else
                If MsgBox("Sonoff IP address is invalid" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

        End If

        If is_valid_ip_address Then

            tbSonoffMAC.Text = GetMac(tbSonoffIPAddress.Text)

            If tbSonoffMAC.Text.Length = 0 Then

                If MsgBox("Could not find the Sonoff's MAC address" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                    Exit Sub
                End If

            End If

        Else

            tbSonoffMAC.Text = String.Empty

        End If


        If tbMQTTIP.Text.Length = 0 Then

            is_valid_ip_address = False
            If MsgBox("MQTT IP address is missing" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                Exit Sub
            End If

        Else

            ip = Nothing
            is_valid_ip_address = IPAddress.TryParse(tbMQTTIP.Text, ip)
            If is_valid_ip_address Then
            Else
                If MsgBox("MQTT IP address is invalid" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

        End If

        If is_valid_ip_address Then

            tbMQTTMAC.Text = GetMac(tbMQTTIP.Text)

            If tbMQTTMAC.Text.Length = 0 Then

                If MsgBox("Could not find the MQTT servers's MAC address" & PromptQuestion, PromptStyle, gProgramName) = MsgBoxResult.No Then
                    Exit Sub
                End If

            End If

        Else

            tbMQTTMAC.Text = String.Empty

        End If

        Dim CommandsAreGood As Boolean = True

        If ValidateCommand(Me.tbRelay01Command.Text) Then
        Else
            CommandsAreGood = False
            Me.tbRelay01Command.BackColor = Color.Red
        End If

        If ValidateCommand(Me.tbRelay02Command.Text) Then
        Else
            CommandsAreGood = False
            Me.tbRelay02Command.BackColor = Color.Red
        End If

        If ValidateCommand(Me.tbRelay03Command.Text) Then
        Else
            CommandsAreGood = False
            Me.tbRelay03Command.BackColor = Color.Red
        End If

        If ValidateCommand(Me.tbRelay04Command.Text) Then
        Else
            CommandsAreGood = False
            Me.tbRelay04Command.BackColor = Color.Red
        End If

        If CommandsAreGood Then
        Else

            MsgBox("One or more of the routines are incorrect" & vbCrLf & vbCrLf &
                   "Routines may contain one or more of the following commands:" & vbCrLf &
                   "  On" & vbCrLf &
                   "  Off" & vbCrLf &
                   "  Toggle" & vbCrLf &
                   "  numbers reprenting wait times in milliseconds" & vbCrLf &
                   "  numbers may not exceed " & Integer.MaxValue & " (" & (Integer.MaxValue / 1000 / 60 / 60 / 24).ToString("##.##") & " days)" & vbCrLf & vbCrLf &
                   "When there are mulitple commands each needs to be seperated by a semi-colon ("";"")" & vbCrLf & vbCrLf &
                   "Here is an example routine:" & vbCrLf &
                   "  On; 1500; Off"
            )

            Exit Sub

        End If

        With My.Settings

            .SonoffIP = tbSonoffIPAddress.Text
            .SonoffMAC = tbSonoffMAC.Text

            .MQTTIP = tbMQTTIP.Text
            .MQTTMAC = tbMQTTMAC.Text

            .RefreshRateValue = udRefreshRate.Value
            .RefreshRateEnabled = cbRefreshRateEnabled.Checked

            .Relay01Commands = tbRelay01Command.Text
            .Relay02Commands = tbRelay02Command.Text
            .Relay03Commands = tbRelay03Command.Text
            .Relay04Commands = tbRelay04Command.Text

            .Mystro01 = cb01.Checked
            .Mystro02 = cb02.Checked
            .Mystro03 = cb03.Checked
            .Mystro04 = cb04.Checked

            .Save()

        End With

        Me.Close()

    End Sub

    Private Sub btnWebInterface_Click(sender As Object, e As EventArgs) Handles btnWebInterface.Click

        Process.Start("http://" & tbSonoffIPAddress.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub tbRelay01Command_KeyPress(sender As TextBox, e As KeyPressEventArgs) Handles tbRelay01Command.KeyPress

        If sender.BackColor = Color.Red Then sender.BackColor = Color.White

    End Sub


    Private Function ValidateCommand(ByVal Command As String) As Boolean

        Static ValidChars() As Char = "01234567890;".ToArray

        Dim ReturnCode As Boolean = False

        Try
            'Step1 Confirm only: On, Off, Toggle and numbers are found as commands

            If Command.Length = 0 Then Exit Try

            Dim WorkingCommand As String = Command

            If WorkingCommand.EndsWith(";") Then
            Else
                WorkingCommand &= ";"
            End If

            WorkingCommand = WorkingCommand.Replace(" ", "")
            WorkingCommand = WorkingCommand.ToUpper

            WorkingCommand = WorkingCommand.Replace("ON;", "")
            WorkingCommand = WorkingCommand.Replace("OFF;", "")
            WorkingCommand = WorkingCommand.Replace("TOGGLE;", "")

            For Each c In ValidChars
                WorkingCommand = WorkingCommand.Replace(c, "")
            Next

            ReturnCode = True

            'Step 2 Confirm no numbers exceed Max int value

            If WorkingCommand.Length = 0 Then

                WorkingCommand = Command
                WorkingCommand = WorkingCommand.Replace(" ", "")

                Dim SubCommands() As String = WorkingCommand.Split(";")

                For Each SubCommand In SubCommands

                    If IsNumeric(SubCommand) Then

                        Try
                            Dim WaitTime As Integer = CInt(SubCommand)
                        Catch ex As Exception
                            ReturnCode = False
                            Exit For
                        End Try

                    End If

                Next

            End If

        Catch ex As Exception

        End Try

        Return ReturnCode

    End Function

    Private Sub cbRefreshRateEnabled_CheckedChanged(sender As CheckBox, e As EventArgs) Handles cbRefreshRateEnabled.CheckedChanged

        If FormIsLoading Then
        Else
            udRefreshRate.Enabled = sender.Checked
        End If

    End Sub

End Class