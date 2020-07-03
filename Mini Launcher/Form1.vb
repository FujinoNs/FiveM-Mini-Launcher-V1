Public Class Form_main
    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(1)
        If GunaProgressBar1.Value = GunaProgressBar1.Maximum Then
            Shell("Explorer.exe fivem://connect/127.0.0.1:30120") 'แก้ไอพีที่ตรงนี้'
            Shell("Explorer.exe ts3server://127.0.0.1") 'แก้ไอพีที่ตรงนี้'
            Me.Close()
        End If
    End Sub
End Class
