Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub CalculateValues(sender As System.Object, e As System.EventArgs) Handles Run.Click
        Dim a As Single, b As Single, h As Single
        Dim x As Single, y As Single
        a = CSng(inputFieldA.Text)
        b = CSng(inputFieldB.Text)
        h = CSng(inputFieldH.Text)
        DisplayX.Text = ""
        DisplayY.Text = ""
        For x = a To b Step h
            If x < 0 Then
                y = Math.Pow(x, 3) - 0.3
            ElseIf x >= 0 And x <= 1 Then
                y = 0
            Else
                y = Math.Pow(x, 2) + x
            End If
            DisplayX.Text = DisplayX.Text + CStr(x) + vbCrLf
            DisplayY.Text = DisplayY.Text + CStr(y) + vbCrLf
        Next x
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inputFieldA.TextChanged

    End Sub
End Class