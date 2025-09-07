Public Class Form1
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim taskName As String = txtTaskName.Text
        Dim taskDurationText As String = txtTaskDuration.Text
        Dim duration As Double
        If taskName = "" Then
            MessageBox.Show("Please enter a task name.")
            Exit Sub
        End If
        If Not Double.TryParse(taskDurationText, duration) Then
            MessageBox.Show("Please enter a valid number of hours.")
            Exit Sub
        End If
        Dim newCheckBox As New CheckBox()
        newCheckBox.Text = taskName & " (" & duration & " hrs)"
        newCheckBox.Tag = duration
        newCheckBox.AutoSize = True
        pnlCustomTask.Controls.Add(newCheckBox)
        txtTaskName.Clear()
        txtTaskDuration.Clear()
    End Sub
    Private Sub btnTotalTime_Click(sender As Object, e As EventArgs) Handles btnTotalTime.Click
        Dim totalTime As Double = 0
        Dim selectedTasks As New List(Of String)

        If chkDefaultOne.Checked Then
            totalTime += 2
            selectedTasks.Add("Study for Exam")
        End If
        If chkDefaultTwo.Checked Then
            totalTime += 1
            selectedTasks.Add("Do Homework")
        End If
        If chkDefaultThree.Checked Then
            totalTime += 1
            selectedTasks.Add("Clean Room")
        End If
        If chkDefaultFour.Checked Then
            totalTime += 1.5
            selectedTasks.Add("Exercise")
        End If
        If chkDefaultFive.Checked Then
            totalTime += 0.5
            selectedTasks.Add("Watch Tutorial Video")
        End If
        For Each ctrl As Control In pnlCustomTask.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    totalTime += Convert.ToDouble(cb.Tag)
                    Dim taskName As String = cb.Text.Split("("c)(0).Trim()
                    selectedTasks.Add(taskName)
                End If
            End If
        Next
        txtSelected.Text = String.Join(", ", selectedTasks)
        txtTotalTime.Text = totalTime.ToString() & " hours"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTaskName.Clear()
        txtTaskDuration.Clear()
        chkDefaultOne.Checked = False
        chkDefaultTwo.Checked = False
        chkDefaultThree.Checked = False
        chkDefaultFour.Checked = False
        chkDefaultFive.Checked = False
        For Each ctrl As Control In pnlCustomTask.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next
        txtSelected.Clear()
        txtTotalTime.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClearCustomTask_Click(sender As Object, e As EventArgs) Handles btnClearCustomTask.Click
        For Each ctrl As Control In pnlCustomTask.Controls.OfType(Of CheckBox)().ToList()
            pnlCustomTask.Controls.Remove(ctrl)
        Next
    End Sub
End Class