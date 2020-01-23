Public Class Loading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)

        Label1.Text = ProgressBar1.Value.ToString + " %.."

        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class