'Copyright Rob Latour, All Rights Reserved, 2018

Module modCommon

#If DEBUG Then
    Friend Const gDebugIsOn As Boolean = True
#Else
    Friend const gDebugIsOn As Boolean = False
#End If

    Friend Const gProgramName As String = "S-Controller"

    Friend gSonoffIsAlive As Boolean = False
    Friend gMQTTServerIsAlive As Boolean = False

    Friend gLastSonoffStatus As Boolean
    Friend gLastMQTTStatatus As Boolean

    Friend gSonoffIPAddress As String = String.Empty
    Friend gMQTTIPAddress As String = String.Empty

    Friend gDisplayUpdateRequired As Boolean = False
    Friend gIgnorNotifications As Boolean = False

    Friend gSwitchValue(4) As Boolean

    Friend gBaseCommand As String = "http://***.***.***.***/cm?cmnd="

    Private ReadOnly Lock As Object = New Object

    Friend Sub DebugHandler(ByVal CurrentMethod As String, ByVal Message As String, ByVal FullException As String)

        SyncLock Lock

            If gDebugIsOn Then

                Console.WriteLine(StrDup(80, "*"))
                Console.WriteLine(CurrentMethod.Replace("System.String ", ""))
                Console.WriteLine(Message)
                Console.WriteLine(FullException)

            End If

        End SyncLock

    End Sub

    Friend Function GetMac(ByVal iIPAddress As String) As String

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

                If iIPAddress = IP_Address Then
                    ReturnValue = MAC_Address
                    Exit For
                End If

            Next

        Catch ex As Exception

            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)

        End Try

        Return ReturnValue

    End Function

End Module
