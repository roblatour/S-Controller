'Copyright Rob Latour, All Rights Reserved, 2018

'on github at https://github.com/roblatour/S-Controller.git

Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Threading
Imports MQTTnet
Imports Newtonsoft.Json

'add reference to system.management 

'in support of Fody manually add these references to the project file
'   <Reference Include = "mscorlib" />
'   <Reference Include="Microsoft.VisualBasic"/>

'set form property double buffered to true

Public Class frmMain

    Private MQTTTask As Task

    Private ContinueProcessing As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Initialize()

    End Sub

    Private Sub Initialize()

        Me.Text = gProgramName
        Me.Icon = My.Resources.S_Controller

        SetSettingsVersion()

        AttemptSonoffConnect()
        UpdateDisplay_Sonoff()

        AttemptMQTTServerConnect()
        UpdateDisplay_MQTT()

        SetupTimers()

    End Sub

    Private Sub SetSettingsVersion()

        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim appVersion As Version = asm.GetName().Version
        Dim appVersionString As String = appVersion.ToString

        If My.Settings.ApplicationVersion <> appVersion.ToString Then
            My.Settings.Upgrade()
            My.Settings.ApplicationVersion = appVersionString
        End If

    End Sub

    Private Sub AttemptSonoffConnect()

        gSonoffIPAddress = GetsonoffIPAddress()
        gSonoffIsAlive = (gSonoffIPAddress.Length > 0)

        SonoffResponding(gSonoffIsAlive)

    End Sub

    Private Sub AttemptMQTTServerConnect()

        gMQTTIPAddress = GetMQTTServerIPAddress()

        If gMQTTServerIsAlive Then ShutdownMQTTClient() ' this is done when the mqtt server is being re-initialized 

        MQTTTask = New Task(AddressOf StartupMQTTClient)

        MQTTTask.Start()

        While MQTTTask.Status <> TaskStatus.RanToCompletion
            Thread.Sleep(100)
        End While

        gMQTTServerIsAlive = (mqttClient IsNot Nothing) AndAlso mqttClient.IsConnected

        gLastMQTTStatatus = gMQTTServerIsAlive

    End Sub

    Private Sub SetupTimers()

        MQTTOnlineTimer.Interval = 10000 'keep checking every 10 seconds in case the MQTT server goes on or offline
        MQTTOnlineTimer.Start()

        MQTTRefreshTimer.Interval = 1000 'keep checking every second in case the MQTT reports a button pushed
        MQTTRefreshTimer.Start()

        If My.Settings.RefreshRateEnabled Then
            sOnoffTimer.Interval = My.Settings.RefreshRateValue * 1000 'check incase the user presses a button on the Sonoff device and the display needs to be updated
            sOnoffTimer.Start()
        Else
            sOnoffTimer.Stop()
        End If

    End Sub

    Private Sub MQTTTimer_Tick(sender As Object, e As EventArgs) Handles MQTTOnlineTimer.Tick

        ' confirms the MQTT serever remains alive (online)

        If gMQTTServerIsAlive AndAlso gLastMQTTStatatus Then
        Else
            AttemptMQTTServerConnect()
            UpdateDisplay_MQTT()
            If gMQTTServerIsAlive Then
                gLastMQTTStatatus = True
            End If
        End If

        gLastMQTTStatatus = gMQTTServerIsAlive

    End Sub

    Private Sub Refresh_Tick(sender As Object, e As EventArgs) Handles MQTTRefreshTimer.Tick

        ' if the user has pressed a button on the Sonoff device and the MQTT Server is alive then
        ' the gDisplayUpdateRequired flag will be uesd to force a display update

        If gDisplayUpdateRequired Then
            gDisplayUpdateRequired = False
            UpdateDisplay()
        End If

    End Sub

    Private Sub SOnffTimer_Tick(sender As Object, e As EventArgs) Handles sOnoffTimer.Tick

        If My.Settings.RefreshRateEnabled Then

            ' confirms the Sonoff remains alive (online)

            If gSonoffIsAlive Then
                ' check the Sonoff is still online
                gSonoffIsAlive = My.Computer.Network.Ping(gSonoffIPAddress, 2500)
            Else
                ' check to see if the Sonoff has come online
                gSonoffIPAddress = GetsonoffIPAddress()
                gSonoffIsAlive = (gSonoffIPAddress.Length > 0)
            End If

            Dim ADisplayUpdateWasJustPerformed As Boolean = False

            If gSonoffIsAlive AndAlso gLastSonoffStatus Then
                ' all good, no change
            Else
                AttemptSonoffConnect()
                UpdateDisplay_Sonoff()
                ADisplayUpdateWasJustPerformed = True
            End If

            'if the MQTT Server is not active querry the swtich settings and refresh the display as needed
            If gMQTTServerIsAlive Then
            Else
                If ADisplayUpdateWasJustPerformed Then
                Else
                    GetSwitchSettings()
                    UpdateDisplay_Sonoff()
                End If

            End If

            gLastSonoffStatus = gSonoffIsAlive

        End If

    End Sub

    Friend Sub UpdateDisplay()

        UpdateDisplay_Sonoff()
        UpdateDisplay_MQTT()

    End Sub

    Friend Sub UpdateDisplay_Sonoff()

        Try

            Dim WorkingButton As Button
            Dim WorkingText As String = String.Empty

            Dim WorkingButtonNames(4) As String

            'set relay button names

            For x = 1 To 4

                'bnt1 thru btn4 are the large buttons on the main window which show the Sonoff relay names and statuses
                WorkingButton = Me.Controls.Find("btn" & x, True)(0)

                WorkingText = WorkingButton.Text.Trim
                If WorkingText.EndsWith("(ON)") Then WorkingText = WorkingText.Remove(WorkingText.LastIndexOf("(ON)"))
                If WorkingText.EndsWith("(OFF)") Then WorkingText = WorkingText.Remove(WorkingText.LastIndexOf("(OFF)"))
                WorkingText = WorkingText.Trim

                WorkingButtonNames(x) = WorkingText

                If gSonoffIsAlive Then
                    If gSwitchValue(x) Then
                        WorkingButton.Text = WorkingText & " (ON)"
                        WorkingButton.BackColor = Color.LightGreen
                    Else
                        WorkingButton.Text = WorkingText & " (OFF)"
                        WorkingButton.BackColor = Color.Red
                    End If
                Else
                    WorkingButton.Text = "Not found"
                    WorkingButton.BackColor = btn5.BackColor
                End If

            Next

            'set mastro name

            Dim MystroText As String = String.Empty

            If gSonoffIsAlive Then

                With My.Settings

                    If .Mystro01 Then MystroText &= WorkingButtonNames(1) & " + "
                    If .Mystro02 Then MystroText &= WorkingButtonNames(2) & " + "
                    If .Mystro03 Then MystroText &= WorkingButtonNames(3) & " + "
                    If .Mystro04 Then MystroText &= WorkingButtonNames(4)

                End With

                MystroText = MystroText.Trim.TrimEnd("+").Trim

                If MystroText.Length = 0 Then
                    MystroText = "Not set"
                End If

            Else

                MystroText = "Not available"

            End If

            btnMystro.Text = MystroText
            btnMystro.Enabled = Not ((MystroText = "Not set") OrElse (MystroText = "Not available"))

            btnMystro.BackColor = Color.LightBlue

            Application.DoEvents()

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

    End Sub

    Friend Sub UpdateDisplay_MQTT()

        Try

            If gMQTTServerIsAlive Then
                tsMQTTServerStatus.Text = "MQTT " & gMQTTIPAddress
                tsMQTTServerStatus.ForeColor = Color.Green
            Else
                tsMQTTServerStatus.Text = "MQTT server not found"
                tsMQTTServerStatus.ForeColor = Color.Red
            End If

            Application.DoEvents()

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

    End Sub

    Private Sub GetSwitchSettings()

        ' The gIgnorNotifications flag is set to true so that notifications generated out of this status check can be ingnored.
        ' At the end of the status check process the gIgnorNotifications flag is set to false so that if the user pressed the button on the 
        ' signoff device a notification of that action will not be ignorned.

        gIgnorNotifications = True

        For x = 1 To 4
            gSwitchValue(x) = IsASwitchOn(x)
        Next

        gIgnorNotifications = False

    End Sub

    Private Function IsASwitchOn(ByVal Switch As Integer) As Boolean

        Dim Command As String = "Power" & Switch.ToString

        Dim Response As String = SendCommandToSonOff(Command)

        Return Response.Contains("ON")

    End Function

    Private Function SendCommandToSonOff(ByVal Command As String, Optional ByVal timeout As Integer = 2500) As String

        Dim responseFromServer As String = String.Empty

        Try

            Dim request As WebRequest = WebRequest.Create(gBaseCommand & Command)
            request.Timeout = timeout
            ' request.Credentials = CredentialCache.DefaultCredentials

            Dim response As WebResponse = request.GetResponse()
            'if gDebugIsOn then Console.WriteLine(DirectCast(response, HttpWebResponse).StatusDescription)

            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            responseFromServer = reader.ReadToEnd()

            reader.Close()
            response.Close()

            'cleanup
            request = Nothing
            response.Dispose()
            dataStream.Dispose()
            reader.Dispose()

            Application.DoEvents()

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

        Return responseFromServer

    End Function

    Private Sub RelayButtons_Click(sender As Button, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click

        SuspendScreenUpdates(True)

        Dim RelayNumber As Integer = CInt(sender.Tag)

        IssueARelayCommand(RelayNumber)

        SuspendScreenUpdates(False)

    End Sub

    Private Sub IssueARelayCommand(ByVal RelayNumber As Integer)

        Dim RelayCommands As String = String.Empty

        Select Case RelayNumber

            Case Is = 1
                RelayCommands = My.Settings.Relay01Commands.ToUpper

            Case Is = 2
                RelayCommands = My.Settings.Relay02Commands.ToUpper

            Case Is = 3
                RelayCommands = My.Settings.Relay03Commands.ToUpper

            Case Is = 4
                RelayCommands = My.Settings.Relay04Commands.ToUpper

        End Select

        RelayCommands = RelayCommands.Replace(" ", "")
        Dim SubCommands() As String = RelayCommands.Split(";")

        For Each SubCommand In SubCommands

            Select Case SubCommand

                Case Is = "ON", "OFF", "TOGGLE"

                    Dim CommandToSend As String = "Power" & RelayNumber & " " & SubCommand

                    Dim Response As String = SendCommandToSonOff(CommandToSend)

                    gSwitchValue(RelayNumber) = Response.ToUpper.Contains("ON")  ' true if "ON", false if "OFF"

                Case Else

                    If IsNumeric(SubCommand) Then

                        Dim WaitTime As Integer = CInt(SubCommand)

                        Dim RemainingWaitTime As Integer = WaitTime

                        While (RemainingWaitTime > 0) AndAlso ContinueProcessing

                            ' this prevents screen lockup

                            If RemainingWaitTime > 250 Then
                                Thread.Sleep(250)
                                RemainingWaitTime -= 250
                            Else
                                Thread.Sleep(RemainingWaitTime)
                                RemainingWaitTime = 0
                            End If

                            Application.DoEvents()

                        End While

                    End If

            End Select

            If ContinueProcessing Then
                UpdateDisplay_Sonoff()
            Else
                Exit For
            End If

        Next

    End Sub

    Private Sub ToggleButtons_Click(sender As Object, e As EventArgs) Handles btn5.Click, btn6.Click, btn7.Click, btn8.Click

        SuspendScreenUpdates(True)

        Dim RelayNumber As Integer = CInt(sender.tag)

        Dim CommandToSend As String = "Power" & RelayNumber & " TOGGLE"

        Dim Response As String = SendCommandToSonOff(CommandToSend)

        If Response.Contains("ON") Then
            gSwitchValue(RelayNumber) = True

        ElseIf Response.Contains("OFF") Then
            gSwitchValue(RelayNumber) = False

        Else
            SonoffResponding(False)

        End If

        UpdateDisplay_Sonoff()

        SuspendScreenUpdates(False)

    End Sub

    Private Sub btnMystro_Click(sender As Object, e As EventArgs) Handles btnMystro.Click

        'btnMystro.Enabled = False
        SuspendScreenUpdates(True)

        With My.Settings
            If .Mystro01 Then IssueARelayCommand(1) : Application.DoEvents()
            If .Mystro02 Then IssueARelayCommand(2) : Application.DoEvents()
            If .Mystro03 Then IssueARelayCommand(3) : Application.DoEvents()
            If .Mystro04 Then IssueARelayCommand(4) : Application.DoEvents()
        End With

        SuspendScreenUpdates(False)
        'btnMystro.Enabled = True

    End Sub


    Private Sub SonoffResponding(ByVal Responding As Boolean)

        Static Dim LastResponding As Boolean = Not Responding

        If LastResponding = Responding Then
        Else

            LastResponding = Responding

            If Responding Then

                GetSwitchSettings()
                UpdateDisplay_Sonoff()
                gbRelays.Enabled = True
                gbMystro.Enabled = True
                gLastSonoffStatus = True

                tsSonoffStatus.Text = "Sonoff " & gSonoffIPAddress
                tsSonoffStatus.ForeColor = Color.Green

            Else

                tsSonoffStatus.ForeColor = Color.Red
                gbRelays.Enabled = False
                gbMystro.Enabled = False
                gLastSonoffStatus = False

                If gDebugIsOn Then Console.WriteLine("sonoff did not respond")
                tsSonoffStatus.Text = "Sonoff not found"

            End If

        End If

    End Sub

    Private Sub SuspendScreenUpdates(ByVal Suspend As Boolean)

        If Suspend Then
            Cursor.Current = Cursors.WaitCursor
            Me.SuspendLayout()
        Else
            Me.ResumeLayout()
            Cursor.Current = Cursors.Default
        End If

    End Sub

    Private Function GetsonoffIPAddress() As String

        Dim ReturnValue As String = String.Empty

        Dim CandidateIP As String = String.Empty

        Try

            'first try based on the last known IP address and mac address
            CandidateIP = My.Settings.SonoffIP

            If CandidateIP.Length > 0 Then

                If My.Computer.Network.Ping(CandidateIP, 2500) Then

                    gBaseCommand = gBaseCommand.Replace("***.***.***.***", CandidateIP)

                    If Querry_sononff(CandidateIP) Then

                        If My.Settings.SonoffMAC.Length > 0 Then
                            If My.Settings.SonoffMAC = GetMac(CandidateIP) Then
                                ReturnValue = CandidateIP
                                Exit Try
                            End If
                        End If

                        Dim CandidateMAC As String = GetMac(CandidateIP)
                        If CandidateMAC.Length > 0 Then
                            My.Settings.SonoffMAC = CandidateMAC
                            My.Settings.Save()
                        End If

                        ReturnValue = CandidateIP
                        Exit Try

                    End If

                End If

            End If

            'second try based on the last know MAC address
            If My.Settings.SonoffMAC.Length > 0 Then

                CandidateIP = GetIPBasedOnLastKnownMAC(My.Settings.SonoffMAC)
                If CandidateIP.Length > 0 Then
                    gBaseCommand = gBaseCommand.Replace("***.***.***.***", CandidateIP)

                    If Querry_sononff(CandidateIP) Then
                        My.Settings.SonoffIP = CandidateIP
                        My.Settings.Save()
                        ReturnValue = CandidateIP
                        Exit Try
                    End If

                End If

            End If

            'SetMacByEnteringIP("Sonoff")

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

        Return ReturnValue

    End Function

    Private Function GetMQTTServerIPAddress() As String

        Dim ReturnValue As String = String.Empty

        Dim CandidateIP As String = String.Empty

        Try

            'first try based on the last known IP address and mac address
            CandidateIP = My.Settings.MQTTIP

            If CandidateIP.Length > 0 Then

                If My.Computer.Network.Ping(CandidateIP, 2500) Then

                    Dim MAC As String = GetMac(CandidateIP)
                    If MAC = My.Settings.MQTTMAC Then
                        ReturnValue = CandidateIP
                        Exit Try
                    End If

                End If

            End If

            'second try based on the last know MAC address
            If My.Settings.MQTTMAC.Length > 0 Then

                CandidateIP = GetIPBasedOnLastKnownMAC(My.Settings.MQTTMAC)
                If CandidateIP.Length > 0 Then
                    ReturnValue = CandidateIP
                    Exit Try
                End If

            End If

            'SetMacByEnteringIP("MQTT Server")

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

        Return ReturnValue


    End Function

    Private Function Querry_sononff(ByVal IPAddress As String) As Boolean

        Dim ReturnValue As Boolean = False

        Try

            gBaseCommand = "http://***.***.***.***/cm?cmnd=".Replace("***.***.***.***", IPAddress)
            Dim status As String = SendCommandToSonOff("Status", 1500)

            If status > String.Empty Then

                Dim jsonResulttodict As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(status)

                If jsonResulttodict IsNot Nothing Then

                    Dim firstItem = jsonResulttodict.Item("Status")
                    Dim FriendlyNames = firstItem.item("FriendlyName")

                    btn1.Text = FriendlyNames(0)
                    btn2.Text = FriendlyNames(1)
                    btn3.Text = FriendlyNames(2)
                    btn4.Text = FriendlyNames(3)

                    btn1.BackColor = Color.LightBlue
                    btn2.BackColor = Color.LightBlue
                    btn3.BackColor = Color.LightBlue
                    btn4.BackColor = Color.LightBlue

                End If

                ReturnValue = True

            End If

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

        Return ReturnValue

    End Function

    Private Function GetIPBasedOnLastKnownMAC(ByVal MACToFind As String)

        Dim ReturnValue As String = String.Empty

        '        Polls the network And loads the database with information related to the currently network connected machines

        Try

            ' Run the ARP command

            Dim ps As New ProcessStartInfo("arp", "-a ") With {
            .RedirectStandardOutput = True,
            .UseShellExecute = False,
            .WindowStyle = ProcessWindowStyle.Hidden,
            .CreateNoWindow = True
            }

            Dim sbResults As New System.Text.StringBuilder

            Using proc As New System.Diagnostics.Process()

                proc.StartInfo = ps
                proc.Start()

                Dim sr As System.IO.StreamReader = proc.StandardOutput

                While Not proc.HasExited
                    System.Threading.Thread.Sleep(100)
                End While

                sbResults.Append(sr.ReadToEnd)

            End Using

            Dim AllOutputLines() As String = sbResults.ToString.Split(vbCrLf)

            Dim DynamicOutputLines() = Filter(AllOutputLines, "dynamic", True, CompareMethod.Text)
            Dim StaticOutputLines() = Filter(AllOutputLines, "static", True, CompareMethod.Text)

            Dim WorkingOutputLines = DynamicOutputLines.Concat(StaticOutputLines).ToArray

            Dim IP_Address, MAC_Address As String

            For Each IndividualOutputLine As String In WorkingOutputLines

                Dim Entries() As String = IndividualOutputLine.Split(New String() {}, StringSplitOptions.RemoveEmptyEntries)

                IP_Address = Entries(0)
                MAC_Address = Entries(1).ToUpper.Replace("-", ":")

                If MAC_Address = MACToFind Then
                    ReturnValue = IP_Address
                    Exit For
                End If

            Next

        Catch ex As Exception

            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)

        End Try

        Return ReturnValue

    End Function

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click

        SuspendScreenUpdates(True)
        Querry_sononff(My.Settings.SonoffIP)
        GetSwitchSettings()
        UpdateDisplay()
        SuspendScreenUpdates(False)

    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click

        Dim HoldRefreshRateEnabled As Boolean = My.Settings.RefreshRateEnabled
        Dim HoldRefreshRateValue = My.Settings.RefreshRateValue
        Dim Hold_Mystro01 As Boolean = My.Settings.Mystro01
        Dim Hold_Mystro02 As Boolean = My.Settings.Mystro02
        Dim Hold_Mystro03 As Boolean = My.Settings.Mystro03
        Dim Hold_Mystro04 As Boolean = My.Settings.Mystro04

        Dim frmSettings As Form = New frmSettings
        frmSettings.ShowDialog()


        If (gSonoffIPAddress <> My.Settings.SonoffIP) OrElse (gMQTTIPAddress <> My.Settings.MQTTIP) Then

            gSonoffIPAddress = My.Settings.SonoffIP
            gMQTTIPAddress = My.Settings.MQTTIP
            Initialize()
            Exit Sub

        End If

        If (Hold_Mystro01 <> My.Settings.Mystro01) OrElse (Hold_Mystro02 <> My.Settings.Mystro02) OrElse (Hold_Mystro03 <> My.Settings.Mystro03) OrElse (Hold_Mystro04 <> My.Settings.Mystro04) Then
            UpdateDisplay()
        End If

        If (HoldRefreshRateEnabled <> My.Settings.RefreshRateEnabled) OrElse (HoldRefreshRateValue <> My.Settings.RefreshRateValue) Then

            If My.Settings.RefreshRateEnabled Then
                sOnoffTimer.Interval = My.Settings.RefreshRateValue * 1000 'check incase the user presses a button on the Sonoff device and the display needs to be updated
                sOnoffTimer.Start()
            Else
                sOnoffTimer.Stop()
            End If
        End If

    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Static Dim frmAbout As New frmAbout

        frmAbout.Show()  'show dialog is not used so processing is not blocked when the about screen is open

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ContinueProcessing = False

    End Sub

End Class
