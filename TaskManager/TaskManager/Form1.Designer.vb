<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        chkDefaultOne = New CheckBox()
        chkDefaultTwo = New CheckBox()
        chkDefaultThree = New CheckBox()
        chkDefaultFour = New CheckBox()
        chkDefaultFive = New CheckBox()
        txtTaskName = New TextBox()
        txtTaskDuration = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnAddTask = New Button()
        Label5 = New Label()
        pnlCustomTask = New FlowLayoutPanel()
        btnTotalTime = New Button()
        btnClear = New Button()
        btnExit = New Button()
        Label7 = New Label()
        Label8 = New Label()
        txtSelected = New TextBox()
        txtTotalTime = New TextBox()
        btnClearCustomTask = New Button()
        SuspendLayout()
        ' 
        ' chkDefaultOne
        ' 
        chkDefaultOne.AutoSize = True
        chkDefaultOne.Location = New Point(33, 60)
        chkDefaultOne.Name = "chkDefaultOne"
        chkDefaultOne.Size = New Size(139, 19)
        chkDefaultOne.TabIndex = 2
        chkDefaultOne.Text = "Study for Exam (2hrs)"
        chkDefaultOne.UseVisualStyleBackColor = True
        ' 
        ' chkDefaultTwo
        ' 
        chkDefaultTwo.AutoSize = True
        chkDefaultTwo.Location = New Point(33, 85)
        chkDefaultTwo.Name = "chkDefaultTwo"
        chkDefaultTwo.Size = New Size(131, 19)
        chkDefaultTwo.TabIndex = 3
        chkDefaultTwo.Text = "Do Homework (1hr)"
        chkDefaultTwo.UseVisualStyleBackColor = True
        ' 
        ' chkDefaultThree
        ' 
        chkDefaultThree.AutoSize = True
        chkDefaultThree.Location = New Point(33, 110)
        chkDefaultThree.Name = "chkDefaultThree"
        chkDefaultThree.Size = New Size(119, 19)
        chkDefaultThree.TabIndex = 4
        chkDefaultThree.Text = "Clean Room (1hr)"
        chkDefaultThree.UseVisualStyleBackColor = True
        ' 
        ' chkDefaultFour
        ' 
        chkDefaultFour.AutoSize = True
        chkDefaultFour.Location = New Point(33, 135)
        chkDefaultFour.Name = "chkDefaultFour"
        chkDefaultFour.Size = New Size(110, 19)
        chkDefaultFour.TabIndex = 5
        chkDefaultFour.Text = "Exercise (1.5hrs)"
        chkDefaultFour.UseVisualStyleBackColor = True
        ' 
        ' chkDefaultFive
        ' 
        chkDefaultFive.AutoSize = True
        chkDefaultFive.Location = New Point(33, 160)
        chkDefaultFive.Name = "chkDefaultFive"
        chkDefaultFive.Size = New Size(173, 19)
        chkDefaultFive.TabIndex = 6
        chkDefaultFive.Text = "Watch Tutorial Video (0.5hr)"
        chkDefaultFive.UseVisualStyleBackColor = True
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Location = New Point(117, 246)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(115, 23)
        txtTaskName.TabIndex = 7
        ' 
        ' txtTaskDuration
        ' 
        txtTaskDuration.Location = New Point(117, 275)
        txtTaskDuration.Name = "txtTaskDuration"
        txtTaskDuration.Size = New Size(115, 23)
        txtTaskDuration.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 21)
        Label1.TabIndex = 9
        Label1.Text = "Add Custom Task"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(32, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 21)
        Label2.TabIndex = 10
        Label2.Text = "Pre Defined Task"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 11
        Label3.Text = "Task Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 12
        Label4.Text = "Task Duration"
        ' 
        ' btnAddTask
        ' 
        btnAddTask.Location = New Point(55, 316)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(140, 23)
        btnAddTask.TabIndex = 13
        btnAddTask.Text = "Add Custom Task"
        btnAddTask.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(274, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 14
        Label5.Text = "Custom Task"
        ' 
        ' pnlCustomTask
        ' 
        pnlCustomTask.BackColor = SystemColors.Control
        pnlCustomTask.BorderStyle = BorderStyle.FixedSingle
        pnlCustomTask.FlowDirection = FlowDirection.TopDown
        pnlCustomTask.Location = New Point(274, 60)
        pnlCustomTask.Name = "pnlCustomTask"
        pnlCustomTask.Size = New Size(285, 238)
        pnlCustomTask.TabIndex = 15
        ' 
        ' btnTotalTime
        ' 
        btnTotalTime.Location = New Point(136, 376)
        btnTotalTime.Name = "btnTotalTime"
        btnTotalTime.Size = New Size(123, 23)
        btnTotalTime.TabIndex = 16
        btnTotalTime.Text = "Calculate Total Time"
        btnTotalTime.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(265, 376)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 17
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(346, 376)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 18
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 429)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 21)
        Label7.TabIndex = 20
        Label7.Text = "Task Selected:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(33, 529)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 21)
        Label8.TabIndex = 21
        Label8.Text = "Total Time:"
        ' 
        ' txtSelected
        ' 
        txtSelected.Enabled = False
        txtSelected.Location = New Point(155, 431)
        txtSelected.Multiline = True
        txtSelected.Name = "txtSelected"
        txtSelected.Size = New Size(404, 79)
        txtSelected.TabIndex = 22
        ' 
        ' txtTotalTime
        ' 
        txtTotalTime.Enabled = False
        txtTotalTime.Location = New Point(155, 529)
        txtTotalTime.Name = "txtTotalTime"
        txtTotalTime.Size = New Size(404, 23)
        txtTotalTime.TabIndex = 23
        ' 
        ' btnClearCustomTask
        ' 
        btnClearCustomTask.Location = New Point(274, 316)
        btnClearCustomTask.Name = "btnClearCustomTask"
        btnClearCustomTask.Size = New Size(125, 23)
        btnClearCustomTask.TabIndex = 24
        btnClearCustomTask.Text = "Clear Custom Task"
        btnClearCustomTask.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 616)
        Controls.Add(btnClearCustomTask)
        Controls.Add(txtTotalTime)
        Controls.Add(txtSelected)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnTotalTime)
        Controls.Add(pnlCustomTask)
        Controls.Add(Label5)
        Controls.Add(btnAddTask)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTaskDuration)
        Controls.Add(txtTaskName)
        Controls.Add(chkDefaultFive)
        Controls.Add(chkDefaultFour)
        Controls.Add(chkDefaultThree)
        Controls.Add(chkDefaultTwo)
        Controls.Add(chkDefaultOne)
        Name = "Form1"
        Text = "TaskManager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkDefaultOne As CheckBox
    Friend WithEvents chkDefaultTwo As CheckBox
    Friend WithEvents chkDefaultThree As CheckBox
    Friend WithEvents chkDefaultFour As CheckBox
    Friend WithEvents chkDefaultFive As CheckBox
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents txtTaskDuration As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddTask As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlCustomTask As FlowLayoutPanel
    Friend WithEvents btnTotalTime As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSelected As TextBox
    Friend WithEvents txtTotalTime As TextBox
    Friend WithEvents btnClearCustomTask As Button

End Class
