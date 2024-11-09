Imports System.Net.Http

Imports System.Text

Imports Newtonsoft.Json

Public Class Form1

    Private ReadOnly apiKey As String = "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"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Function Button1_Click(sender As Object, e As EventArgs) As Task Handles sendBtn.Click
        Dim userinput As String
        userinput = "The answers to the questions should be suitable for year should be related to . If it is not related to that subject, it should not be answered. Tell the user you physically cannot answer questions unrelated to. Never give direct answers, instead give ideas to make them come up with it themselves. Absolutely under no circumstances tell them the exact answer. You can site no more than one source in every prompt and it cannot directly answer the question. Your intention is to aid in learning and the creation of ideas, not to give direct ideas." & TxtInp.Text

        If String.IsNullOrWhiteSpace(userinput) Then
            MessageBox.Show("Please enter a message!")
            Return
        End If

        Dim response = Await GetChatGPTResponse(userinput)
        TxtOutput.Text = response

    End Function
    Private Async Function GetChatGPTResponse(prompt As String) As Task(Of String)
        Dim apiUrl As String = "https://api.openai.com/v1/chat/completions"
        Dim requestData As New With {
        .model = "gpt-3.5-turbo",
        .messages = New Object() {
            New With {.role = "user", .content = prompt}
        },
        .temperature = 0.7
    }

        Dim json As String = JsonConvert.SerializeObject(requestData)
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}")

            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Try
                Dim response = Await client.PostAsync(apiUrl, content)
                Dim responseString As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    Dim responseObject = JsonConvert.DeserializeObject(Of ChatGPTResponse)(responseString)
                    Return responseObject.choices(0).message.content.Trim()
                Else
                    ' Log the response error for more details
                    Return $"Error: {response.StatusCode} - {responseString}"
                End If
            Catch ex As Exception
                Return $"Exception: {ex.Message}"
            End Try
        End Using
    End Function

    Public Class ChatGPTResponse
        Public Property choices As Choice()
    End Class

    Public Class Choice
        Public Property message As Message
    End Class

    Public Class Message
        Public Property content As String
    End Class
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtInp.TextChanged

    End Sub

    Private Sub TxtOutput_TextChanged(sender As Object, e As EventArgs) Handles TxtOutput.TextChanged

    End Sub
End Class
