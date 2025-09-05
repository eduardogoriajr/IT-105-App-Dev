Public Class Form1
    Dim burgQuantity, spagQuantity, pizzaQuantity, friestQuantity, cokeQuantity, teaQuantity As Integer
    Dim total, payment, change As Double

    Private Sub Burger_CheckedChanged(sender As Object, e As EventArgs) Handles chkBurg.CheckedChanged
        If chkBurg.Checked Then
            burgQuan.Enabled = True
            btnAdd1.Enabled = True
            btnMin1.Enabled = True
            burgQuan.Text = 1
        Else
            burgQuan.Enabled = False
            btnAdd1.Enabled = False
            btnMin1.Enabled = False
            burgQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        burgQuan.Text += 1
    End Sub

    Private Sub btnMin1_Click(sender As Object, e As EventArgs) Handles btnMin1.Click
        burgQuan.Text -= 1
        If burgQuan.Text < 1 Then
            chkBurg.Checked = False
        End If
    End Sub

    Private Sub Spag_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpag.CheckedChanged
        If chkSpag.Checked Then
            spagQuan.Enabled = True
            btnAdd2.Enabled = True
            btnMin2.Enabled = True
            spagQuan.Text = 1
        Else
            spagQuan.Enabled = False
            btnAdd2.Enabled = False
            btnMin2.Enabled = False
            spagQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        spagQuan.Text += 1
    End Sub

    Private Sub btnMin2_Click(sender As Object, e As EventArgs) Handles btnMin2.Click
        spagQuan.Text -= 1
        If spagQuan.Text < 1 Then
            chkSpag.Checked = False
        End If
    End Sub

    Private Sub Pizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPizza.CheckedChanged
        If chkPizza.Checked Then
            pizzaQuan.Enabled = True
            btnAdd3.Enabled = True
            btnMin3.Enabled = True
            pizzaQuan.Text = 1
        Else
            pizzaQuan.Enabled = False
            btnAdd3.Enabled = False
            btnMin3.Enabled = False
            pizzaQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        pizzaQuan.Text += 1
    End Sub

    Private Sub btnMin3_Click(sender As Object, e As EventArgs) Handles btnMin3.Click
        pizzaQuan.Text -= 1
        If pizzaQuan.Text < 1 Then
            chkPizza.Checked = False
        End If
    End Sub

    Private Sub Fries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked Then
            friesQuan.Enabled = True
            btnAdd4.Enabled = True
            btnMin4.Enabled = True
            friesQuan.Text = 1
        Else
            friesQuan.Enabled = False
            btnAdd4.Enabled = False
            btnMin4.Enabled = False
            friesQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd4_Click(sender As Object, e As EventArgs) Handles btnAdd4.Click
        friesQuan.Text += 1
    End Sub

    Private Sub btnMin4_Click(sender As Object, e As EventArgs) Handles btnMin4.Click
        friesQuan.Text -= 1
        If friesQuan.Text < 1 Then
            chkFries.Checked = False
        End If
    End Sub

    Private Sub Coke_CheckedChanged(sender As Object, e As EventArgs) Handles chkCoke.CheckedChanged
        If chkCoke.Checked Then
            cokeQuan.Enabled = True
            btnAdd5.Enabled = True
            btnMin5.Enabled = True
            cokeQuan.Text = 1
        Else
            cokeQuan.Enabled = False
            btnAdd5.Enabled = False
            btnMin5.Enabled = False
            cokeQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd5_Click(sender As Object, e As EventArgs) Handles btnAdd5.Click
        cokeQuan.Text += 1
    End Sub

    Private Sub btnMin5_Click(sender As Object, e As EventArgs) Handles btnMin5.Click
        cokeQuan.Text -= 1
        If cokeQuan.Text < 1 Then
            chkCoke.Checked = False
        End If
    End Sub

    Private Sub Tea_CheckedChanged(sender As Object, e As EventArgs) Handles chkTea.CheckedChanged
        If chkTea.Checked Then
            teaQuan.Enabled = True
            btnAdd6.Enabled = True
            btnMin6.Enabled = True
            teaQuan.Text = 1
        Else
            teaQuan.Enabled = False
            btnAdd6.Enabled = False
            btnMin6.Enabled = False
            teaQuan.Clear()
        End If
    End Sub

    Private Sub btnAdd6_Click(sender As Object, e As EventArgs) Handles btnAdd6.Click
        teaQuan.Text += 1
    End Sub

    Private Sub btnMin6_Click(sender As Object, e As EventArgs) Handles btnMin6.Click
        teaQuan.Text -= 1
        If teaQuan.Text < 1 Then
            chkTea.Checked = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to proceed?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then
            If chkBurg.Checked Then
                burgQuantity = burgQuan.Text
            Else
                burgQuantity = 0
            End If

            If chkSpag.Checked Then
                spagQuantity = spagQuan.Text
            Else
                spagQuantity = 0
            End If

            If chkPizza.Checked Then
                pizzaQuantity = pizzaQuan.Text
            Else
                pizzaQuantity = 0
            End If

            If chkFries.Checked Then
                friestQuantity = friesQuan.Text
            Else
                friestQuantity = 0
            End If

            If chkCoke.Checked Then
                cokeQuantity = cokeQuan.Text
            Else
                cokeQuantity = 0
            End If

            If chkTea.Checked Then
                teaQuantity = teaQuan.Text
            Else
                teaQuantity = 0
            End If

            total = (burgQuantity * 50) + (spagQuantity * 70) + (pizzaQuantity * 525) + (friestQuantity * 45) + (cokeQuantity * 29) + (teaQuantity * 35)
            txtTotal.Text = total
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        payment = txtPayment.Text
        If payment >= total Then
            txtChange.Text = (payment - total)
        Else
            MsgBox("Insufficient Balance")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim answer As DialogResult
        answer = MessageBox.Show("Are you sure you want to clear?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            txtTotal.Clear()
            txtPayment.Clear()
            txtChange.Clear()
            chkBurg.Checked = False
            chkSpag.Checked = False
            chkPizza.Checked = False
            chkFries.Checked = False
            chkCoke.Checked = False
            chkTea.Checked = False
        End If
    End Sub
End Class
