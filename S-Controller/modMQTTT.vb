'Copyright Rob Latour, All Rights Reserved, 2018

Imports MQTTnet
Imports MQTTnet.Client
Imports SonoffController.frmMain

'https://github.com/chkr1011/MQTTnet/wiki/Client
'https://github.com/arendst/Sonoff-Tasmota/wiki/MQTT-Overview

Module modMQTTT

    Friend factory As MqttFactory = New MqttFactory
    Friend WithEvents mqttClient As Client.IMqttClient

    Friend Async Sub StartupMQTTClient()

        mqttClient = factory.CreateMqttClient

        Dim options As New MqttClientOptionsBuilder
        With options
            .WithCleanSession()
            '.WientId("DVES_461C78x")
            '.WithCredentials("DVES_USER", "DVES_PASS")
            .WithTcpServer(My.Settings.MQTTIP, 1883)
        End With

        Try

            AddHandler mqttClient.ApplicationMessageReceived, AddressOf mqttClient_ApplicationMessageReceived

            Await mqttClient.ConnectAsync(options.Build)

            Await mqttClient.SubscribeAsync("stat/sonoff4chpro/POWER1")
            Await mqttClient.SubscribeAsync("stat/sonoff4chpro/POWER2")
            Await mqttClient.SubscribeAsync("stat/sonoff4chpro/POWER3")
            Await mqttClient.SubscribeAsync("stat/sonoff4chpro/POWER4")

        Catch ex As Exception
            ' DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

    End Sub

    Friend Async Sub ShutdownMQTTClient()

        Try

            RemoveHandler mqttClient.ApplicationMessageReceived, AddressOf mqttClient_ApplicationMessageReceived

            Await mqttClient.UnsubscribeAsync("stat/sonoff4chpro/POWER1")
            Await mqttClient.UnsubscribeAsync("stat/sonoff4chpro/POWER2")
            Await mqttClient.UnsubscribeAsync("stat/sonoff4chpro/POWER3")
            Await mqttClient.UnsubscribeAsync("stat/sonoff4chpro/POWER4")

            Await mqttClient.DisconnectAsync()

            mqttClient.Dispose()

        Catch ex As Exception
            'DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

    End Sub

    Private Sub mqttClient_Connected(sender As Object, e As MqttClientConnectedEventArgs) Handles mqttClient.Connected

        If gDebugIsOn Then Console.WriteLine("** Connected *** ")
        gMQTTServerIsAlive = True
        gDisplayUpdateRequired = True

    End Sub

    Private Sub mqttClient_Disconnected(sender As Object, e As MqttClientDisconnectedEventArgs) Handles mqttClient.Disconnected

        If gDebugIsOn Then Console.WriteLine("** Disconnected *** ")
        gMQTTServerIsAlive = False
        gDisplayUpdateRequired = True

    End Sub

    Private Sub mqttClient_ApplicationMessageReceived(sender As Object, e As MqttApplicationMessageReceivedEventArgs) Handles mqttClient.ApplicationMessageReceived

        ' as notification happen when a switch changes values and when it is querried to confirm its new value
        ' the gIgnorEnvents flag is used to avoid a loop when after being notified of a changed switch the program might otherwise continue to 
        ' cause notifications based on checking for the new values of the switches

        If gIgnorNotifications Then

            If gDebugIsOn Then Console.WriteLine("** Incomming Message " & e.ApplicationMessage.Topic & " " & System.Text.Encoding.ASCII.GetString(e.ApplicationMessage.Payload) & " *** event was expected and ignored ***")

        Else

            If gDebugIsOn Then Console.WriteLine("** Incomming Message " & e.ApplicationMessage.Topic & " " & System.Text.Encoding.ASCII.GetString(e.ApplicationMessage.Payload))

            If e.ApplicationMessage.Topic.Contains("POWER") Then

                ' the code commented out below is an alternative to have the system querry for the changed switch values 
                ' it might may be open to inaccuracies
                ' but for now I'm going with it
                ' the alternative is to check for the status in the timer routine of frmMain

                Dim SwitchIndex As Integer = Strings.Right(e.ApplicationMessage.Topic.ToString, 1)
                Dim NewSwitchValue As Boolean = (System.Text.Encoding.ASCII.GetString(e.ApplicationMessage.Payload).ToString.ToUpper = "ON")

                If (gSwitchValue(SwitchIndex) <> NewSwitchValue) OrElse (Not gSonoffIsAlive) OrElse (Not gMQTTServerIsAlive) Then
                    gSwitchValue(SwitchIndex) = NewSwitchValue

                    ' Ideally I would like to have raised an event here or figured out how to use a delegate in order to trigger the updatedisplay code
                    ' but while I tried many things this is the only way I found to do it without running into threading issues

                    'Dim UpdatedNow As MyUpdateDisplay_Sonoff_Delegate = AddressOf frmMain.UpdateDisplay_Sonoff
                    'UpdateNow.Invoke()

                    gDisplayUpdateRequired = True

                End If

            End If

        End If

    End Sub

End Module
