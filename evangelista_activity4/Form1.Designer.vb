<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 198)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 3
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(25, 40)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 4
        txtFirstnum.Text = "label1"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(25, 93)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 5
        txtSecondnum.Text = "label2"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(25, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 7
        Label2.Text = "firstnum"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 8
        Label3.Text = "secondnum"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(88, 200)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 15)
        lblResult.TabIndex = 9
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(176, 247)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
End Class
