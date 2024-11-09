Public Class index
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim yrTxt As String = yrgrp

        Dim subjectTxt As String = subjct

        Dim newForm As New Form1()
        newForm.Show()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles yrLbl.Click

    End Sub

    Private Sub yrTxt_TextChanged(sender As Object, e As EventArgs) Handles yrTxt.TextChanged

    End Sub

    Private Sub subjectTxt_TextChanged(sender As Object, e As EventArgs) Handles subjectTxt.TextChanged

    End Sub
End Class