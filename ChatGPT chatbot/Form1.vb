Imports System.Net.Http

Imports System.Text

Imports Newtonsoft.Json

Public Class Form1
    Public yrGrp As String

    Public subject As String

    ' Constructor to accept values from the index form
    Public Sub New(yr As String, subject As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Set the values to the public variables
        Me.yrGrp = yr
        Me.subject = subject
    End Sub
    Private ReadOnly apiKey As String = "PLACE_API_KEY"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust controls' size and position initially
        AdjustControlsSizeAndPosition()
    End Sub

    ' Handle Form Resize event
    Private Sub Form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustControlsSizeAndPosition()
    End Sub

    ' Adjust all controls' size and position dynamically based on form size
    Private Sub AdjustControlsSizeAndPosition()
        ' Ensure the form's client size is reasonable
        If Me.ClientSize.Width < 100 Or Me.ClientSize.Height < 100 Then
            Return ' Skip resizing if the form is too small
        End If

        ' Define proportions for controls
        Dim buttonProportion As Double = 0.15  ' Button will take up 15% of the form width
        Dim textBoxProportion As Double = 0.6  ' Textboxes will take up 60% of the form width

        ' Calculate sizes for controls based on form size
        Dim buttonWidth As Integer = CInt(Me.ClientSize.Width * buttonProportion)
        Dim buttonHeight As Integer = CInt(Me.ClientSize.Height * 0.1)  ' Button height 10% of form height
        Dim textBoxWidth As Integer = CInt(Me.ClientSize.Width * textBoxProportion)

        ' Resize and position the output textbox (TxtOutput) - Same width as input + button
        TxtOutput.Size = New Size(textBoxWidth + buttonWidth + 10, CInt(Me.ClientSize.Height * 0.3))  ' Height 30% of form height
        ' Adjust the X coordinate of TxtOutput to move it slightly to the left
        TxtOutput.Location = New Point((Me.ClientSize.Width - TxtOutput.Width) / 2 - 20, (Me.ClientSize.Height - TxtOutput.Height) / 2 - 150)

        ' Resize and position the input textbox (TxtInp)
        TxtInp.Size = New Size(textBoxWidth, CInt(Me.ClientSize.Height * 0.1))  ' Height 10% of form height
        TxtInp.Location = New Point((Me.ClientSize.Width - TxtInp.Width) / 2 - buttonWidth - 10, TxtOutput.Bottom + 10)

        ' Resize and position the button (sendBtn) next to the input textbox
        sendBtn.Size = New Size(buttonWidth, buttonHeight)
        sendBtn.Location = New Point(TxtInp.Right + 10, TxtInp.Top)

        ' Ensure everything stays within bounds
        Me.Refresh()
    End Sub


    Private Async Function Button1_Click(sender As Object, e As EventArgs) As Task Handles sendBtn.Click
        Dim userinput As String
        userinput = "The answers to the questions should be suitable for someone " & yrGrp & "Years old and should be related to " & subject & ". If it is not related to that subject, it should not be answered. Tell the user you physically cannot answer questions unrelated to" & subject & ". Never give direct answers, instead give ideas to make them come up with it themselves. Absolutely under no circumstances tell them the exact answer.It cannot directly give the word for word answer the question. Your intention is to aid in learning and the creation of ideas, not to give direct ideas.To reiterate, never answer questions unrelated to " & subject & "if you're asked to complete a question that is of a sexual nature, a violent nature or linked to any kind of mass tradgedy or terrorism, please decline it unless the subject (" & subject & ")  is history" & TxtInp.Text

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
