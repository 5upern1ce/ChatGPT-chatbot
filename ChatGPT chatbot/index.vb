Public Class index
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Dim newForm As New Form1()
        newForm.Show()
        Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles yrLbl.Click

    End Sub
End Class