Public Class frm_Status

    Private Sub frm_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer_status.Enabled = True
    End Sub

    Private Sub timer_status_Tick(sender As Object, e As EventArgs) Handles timer_status.Tick
        frm_Main.Enabled = True
        Me.Close()
    End Sub
End Class