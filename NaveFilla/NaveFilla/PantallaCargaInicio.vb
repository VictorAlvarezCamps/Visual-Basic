Public Class PantallaCargaInicio

    'Forms
    Dim F1 As Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Invalidate()
    End Sub

    Private Sub PantallaCargaInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F1 = New Form1

        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If BarraCarga.Value >= BarraCarga.Maximum Then
            F1.Visible = True
            Me.Visible = False
            Timer2.Stop()
        Else
            BarraCarga.Value += 5
            BarraCarga.Refresh()
        End If
    End Sub


End Class