Imports System.Net.Sockets

Public Class frm_Main

    Public Sub WakeOnLAN(ByVal MACAddress As String)
        Dim Client As New UdpClient
        Dim Count As Integer = 0
        Dim ByteArray(1024) As Byte
        Dim Pos As Integer = 0

        Client.Connect("255.255.255.255", 12287)
        Client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 0)

        For i As Integer = 0 To 5
            Count += 1
            ByteArray(Count) = &HFF
        Next

        For i As Integer = 0 To 15
            Pos = 0
            For n As Integer = 0 To 5
                Count += 1
                ByteArray(Count) = Byte.Parse(MACAddress.Substring(Pos, 2), Globalization.NumberStyles.HexNumber)
                Pos += 2
            Next
        Next

        Client.Send(ByteArray, 1024)
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_defined_1_Click(sender As Object, e As EventArgs) Handles btn_defined_1.Click
        txt_mac.Text = "8C:89:A5:60:F1:AE"
    End Sub

    Private Sub btn_defined_2_Click(sender As Object, e As EventArgs) Handles btn_defined_2.Click
        txt_mac.Text = "68:05:CA:3E:09:DC"
    End Sub

    Private Sub btn_defined_3_Click(sender As Object, e As EventArgs) Handles btn_defined_3.Click
        txt_mac.Text = "90:E6:BA:0A:BB:E5"
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        MsgBox("Gib die MAC Adresse ins Textfeld ein oder drücke einen der linken Buttons um das Feld mit vordefinierten Werten zu füllen." & Chr(13) & Chr(10) & "Mit 'Aufwecken' wird das 'Magic Packet' gesendet.", MsgBoxStyle.OkOnly, "WOL Home - Hilfe")
    End Sub

    Private Sub btn_wake_Click(sender As Object, e As EventArgs) Handles btn_wake.Click
        'On Error Resume Next
        On Error GoTo Do_Error
        'Me.Enabled = False
        'frm_Status.lbl_status.Text = "Magic Packet wird an " & Me.txt_mac.Text & " gesendet."
        'frm_Status.ShowDialog()
        WakeOnLAN(txt_mac.Text.Replace(":", ""))
        'WakeOnLAN(txt_mac.Text.ToString)
        Exit Sub
Do_Error:
        MsgBox("Ein Fehler ist aufgetreten!" & Chr(13) & Chr(10) & Err.Number & " - " & Err.Description, MsgBoxStyle.Critical)
    End Sub
End Class
