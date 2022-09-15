Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblReportProgress.Text = PBLoading1.Value & "%"
        PBLoading1.Value += 1
        'If PBLoading1.Value > 10 Then
        '    LblStatusText.Text = "Loading."
        'End If

        'If PBLoading1.Value > 20 Then
        '    LblStatusText.Text = "Loading.."
        'End If

        'If PBLoading1.Value > 30 Then
        '    LblStatusText.Text = "Loading..."
        'End If

        'If PBLoading1.Value > 40 Then
        '    LblStatusText.Text = "Loading...."
        'End If

        'If PBLoading1.Value > 50 Then
        '    LblStatusText.Text = "Loading....."
        'End If

        'If PBLoading1.Value > 60 Then
        '    LblStatusText.Text = "Loading"
        'End If

        'If PBLoading1.Value > 70 Then
        '    LblStatusText.Text = "Loading."
        'End If

        'If PBLoading1.Value > 80 Then
        '    LblStatusText.Text = "Loading.."
        'End If

        'If PBLoading1.Value > 90 Then
        '    LblStatusText.Text = "Loading..."
        'End If

        If PBLoading1.Value = 100 Then
            LblStatusText.Text = "Launching Application."
            Login.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub

End Class