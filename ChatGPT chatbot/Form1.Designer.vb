<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.TxtInp = New System.Windows.Forms.TextBox()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'sendBtn
        '
        Me.sendBtn.Location = New System.Drawing.Point(658, 382)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(75, 56)
        Me.sendBtn.TabIndex = 0
        Me.sendBtn.Text = "Send"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'TxtInp
        '
        Me.TxtInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtInp.Location = New System.Drawing.Point(58, 382)
        Me.TxtInp.Multiline = True
        Me.TxtInp.Name = "TxtInp"
        Me.TxtInp.Size = New System.Drawing.Size(594, 56)
        Me.TxtInp.TabIndex = 1
        '
        'TxtOutput
        '
        Me.TxtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtOutput.Location = New System.Drawing.Point(58, 34)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.Size = New System.Drawing.Size(663, 342)
        Me.TxtOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.TxtInp)
        Me.Controls.Add(Me.sendBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sendBtn As Button
    Friend WithEvents TxtInp As TextBox
    Friend WithEvents TxtOutput As TextBox
End Class
