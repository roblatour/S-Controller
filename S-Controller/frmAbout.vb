Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Text = gProgramName & " - About"
        Me.Icon = My.Resources.S_Controller
        lblProgramNameAndVersion.Text = gProgramName & " v" & My.Application.Info.Version.ToString
        rtbAbout.Rtf = My.Resources.About 'edit with MS Wordpad

    End Sub

    Private Sub rtbAbout_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtbAbout.LinkClicked

        Try

            System.Diagnostics.Process.Start(e.LinkText)
            System.Threading.Thread.Sleep(2500)

        Catch ex As Exception
            DebugHandler(System.Reflection.MethodInfo.GetCurrentMethod().ToString, ex.Message.ToString, ex.ToString)
        End Try

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.Hide()

    End Sub

End Class