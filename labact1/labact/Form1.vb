Public Class Form1

    Private A As Integer
    Private B As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If A = 0 Then
            Button1.BackColor = Color.Blue   '0
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.White
            A = 1



        ElseIf A = 1 Then
            Button1.BackColor = Color.White   '1
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
            A = 2

        ElseIf A = 2 Then
            Button1.BackColor = Color.Blue   '2
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.White
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Blue
            A = 3

        ElseIf A = 3 Then
            Button1.BackColor = Color.Blue   '3
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.Blue
            A = 4

        ElseIf A = 4 Then
            Button1.BackColor = Color.White   '4
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue
            A = 5

        ElseIf A = 5 Then
            Button1.BackColor = Color.Blue   '5
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue
            A = 6

        ElseIf A = 6 Then
            Button1.BackColor = Color.Blue   '6
            Button2.BackColor = Color.White
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue
            A = 7

        ElseIf A = 7 Then
            Button1.BackColor = Color.Blue   '7
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
            A = 8

        ElseIf A = 8 Then
            Button1.BackColor = Color.Blue   '8
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue
            A = 9

        ElseIf A = 9 Then
            Button1.BackColor = Color.Blue   '9
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.Blue
            Button7.BackColor = Color.Blue
            A = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = 0
        B = -1


        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 750


    End Sub
End Class
