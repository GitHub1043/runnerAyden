Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim sngRun1 As Single
        Dim sngRun2 As Single
        Dim sngRun3 As Single
        Dim sngTotal As Single
        Const STRETCH As Integer = 5


        sngRun1 = Val(txtRun1.Text)
        sngRun2 = Val(txtRun2.Text)
        sngRun3 = Val(txtRun3.Text)


        sngTotal = STRETCH + sngRun1 + STRETCH + sngRun2 + STRETCH + sngRun3


        lblTime.Text = "Total Race Time: " & sngTotal


        lblMin.Text = "Time is shown in Minutes"

    End Sub

    Private Sub txtRun1_TextChanged(sender As Object, e As EventArgs) Handles txtRun1.TextChanged
        lblMin.Text = ""

    End Sub

    Private Sub txtRun2_TextChanged(sender As Object, e As EventArgs) Handles txtRun2.TextChanged
        lblMin.Text = ""

    End Sub

    Private Sub txtRun3_TextChanged(sender As Object, e As EventArgs) Handles txtRun3.TextChanged
        lblMin.Text = ""

    End Sub
End Class
