Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles_
Button1.Click
        Dim a As Single, b As Single, h As Single
        Dim x As Single, y As Single
        a = CSng(TextBox1.Text)
        b = CSng(TextBox2.Text)
        h = CSng(TextBox3.Text)
        TextBox4.Text = ""
        TextBox5.Text = ""
        For x = a To b Step h
            If x < -1.25 Then
                y = 3 * Math.Scrt(Math.Abs(x - 1)) - 3.25
                Elself x >= 1.25, Then
y = 3.25 - Math.Sqrt(x + 1)
            Else
                y = -x
            End If
            TextBox4.Text = TextBox4.Text + CStr(x) + vbCrLf
            TextBox5.Text = TextBox5.Text + CStr(y) + vbCrLf
        Next x
    End Sub

    Private Sub Button2 _Click(sender As System.Object, e As System EventArgs) Handles_
        Button2.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class