<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.yrTxt = New System.Windows.Forms.TextBox()
        Me.subjectTxt = New System.Windows.Forms.TextBox()
        Me.yrLbl = New System.Windows.Forms.Label()
        Me.subjectLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(308, 326)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(159, 77)
        Me.submitBtn.TabIndex = 0
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'yrTxt
        '
        Me.yrTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.yrTxt.Location = New System.Drawing.Point(182, 89)
        Me.yrTxt.Name = "yrTxt"
        Me.yrTxt.Size = New System.Drawing.Size(463, 41)
        Me.yrTxt.TabIndex = 1
        '
        'subjectTxt
        '
        Me.subjectTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.subjectTxt.Location = New System.Drawing.Point(202, 192)
        Me.subjectTxt.Name = "subjectTxt"
        Me.subjectTxt.Size = New System.Drawing.Size(443, 41)
        Me.subjectTxt.TabIndex = 2
        '
        'yrLbl
        '
        Me.yrLbl.AutoSize = True
        Me.yrLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.yrLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.yrLbl.Location = New System.Drawing.Point(91, 92)
        Me.yrLbl.Name = "yrLbl"
        Me.yrLbl.Size = New System.Drawing.Size(77, 36)
        Me.yrLbl.TabIndex = 3
        Me.yrLbl.Text = "Age:"
        '
        'subjectLbl
        '
        Me.subjectLbl.AutoSize = True
        Me.subjectLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.subjectLbl.Location = New System.Drawing.Point(64, 192)
        Me.subjectLbl.Name = "subjectLbl"
        Me.subjectLbl.Size = New System.Drawing.Size(123, 36)
        Me.subjectLbl.TabIndex = 4
        Me.subjectLbl.Text = "Subject:"
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.subjectLbl)
        Me.Controls.Add(Me.yrLbl)
        Me.Controls.Add(Me.subjectTxt)
        Me.Controls.Add(Me.yrTxt)
        Me.Controls.Add(Me.submitBtn)
        Me.Name = "index"
        Me.Text = "index"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitBtn As Button
    Friend WithEvents yrTxt As TextBox
    Friend WithEvents subjectTxt As TextBox
    Friend WithEvents yrLbl As Label
    Friend WithEvents subjectLbl As Label
End Class
