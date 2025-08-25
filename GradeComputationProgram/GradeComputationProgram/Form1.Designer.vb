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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPrelim = New TextBox()
        txtMidterm = New TextBox()
        txtFinal = New TextBox()
        txtRemarks = New TextBox()
        txtGPA = New TextBox()
        txtAverage = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        labelaverage = New Label()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 12F)
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 28)
        Label1.TabIndex = 0
        Label1.Text = "Input Grades:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 12F)
        Label2.Location = New Point(73, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 28)
        Label2.TabIndex = 1
        Label2.Text = "Prelim Grade:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 12F)
        Label3.Location = New Point(73, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 28)
        Label3.TabIndex = 2
        Label3.Text = "Midterm Grade:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 12F)
        Label4.Location = New Point(73, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 28)
        Label4.TabIndex = 3
        Label4.Text = "Final Grade:"
        ' 
        ' txtPrelim
        ' 
        txtPrelim.Location = New Point(291, 91)
        txtPrelim.Name = "txtPrelim"
        txtPrelim.Size = New Size(150, 31)
        txtPrelim.TabIndex = 5
        ' 
        ' txtMidterm
        ' 
        txtMidterm.Location = New Point(291, 153)
        txtMidterm.Name = "txtMidterm"
        txtMidterm.Size = New Size(150, 31)
        txtMidterm.TabIndex = 6
        ' 
        ' txtFinal
        ' 
        txtFinal.Location = New Point(291, 215)
        txtFinal.Name = "txtFinal"
        txtFinal.Size = New Size(150, 31)
        txtFinal.TabIndex = 7
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(291, 462)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(150, 31)
        txtRemarks.TabIndex = 13
        ' 
        ' txtGPA
        ' 
        txtGPA.Location = New Point(291, 400)
        txtGPA.Name = "txtGPA"
        txtGPA.Size = New Size(150, 31)
        txtGPA.TabIndex = 12
        ' 
        ' txtAverage
        ' 
        txtAverage.Location = New Point(291, 338)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(150, 31)
        txtAverage.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 12F)
        Label5.Location = New Point(73, 462)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 28)
        Label5.TabIndex = 10
        Label5.Text = "Remarks:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 12F)
        Label6.Location = New Point(73, 401)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 28)
        Label6.TabIndex = 9
        Label6.Text = "Grade Point:"
        ' 
        ' labelaverage
        ' 
        labelaverage.AutoSize = True
        labelaverage.Font = New Font("Consolas", 12F)
        labelaverage.Location = New Point(73, 338)
        labelaverage.Name = "labelaverage"
        labelaverage.Size = New Size(116, 28)
        labelaverage.TabIndex = 8
        labelaverage.Text = "Average:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Microsoft Sans Serif", 9F)
        btnSubmit.Location = New Point(206, 271)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 600)
        Controls.Add(btnSubmit)
        Controls.Add(txtRemarks)
        Controls.Add(txtGPA)
        Controls.Add(txtAverage)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(labelaverage)
        Controls.Add(txtFinal)
        Controls.Add(txtMidterm)
        Controls.Add(txtPrelim)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrelim As TextBox
    Friend WithEvents txtMidterm As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents labelaverage As Label
    Friend WithEvents btnSubmit As Button

End Class
