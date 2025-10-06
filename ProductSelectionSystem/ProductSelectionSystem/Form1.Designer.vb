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
        GroupBox1 = New GroupBox()
        rdoElectronics = New RadioButton()
        rdoClothing = New RadioButton()
        rdoBooks = New RadioButton()
        GroupBox2 = New GroupBox()
        chkWarranty = New CheckBox()
        chkGiftWrap = New CheckBox()
        chkShipping = New CheckBox()
        btnAdd = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdoBooks)
        GroupBox1.Controls.Add(rdoClothing)
        GroupBox1.Controls.Add(rdoElectronics)
        GroupBox1.Location = New Point(21, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Choose Category"
        ' 
        ' rdoElectronics
        ' 
        rdoElectronics.AutoSize = True
        rdoElectronics.Location = New Point(6, 22)
        rdoElectronics.Name = "rdoElectronics"
        rdoElectronics.Size = New Size(82, 19)
        rdoElectronics.TabIndex = 0
        rdoElectronics.TabStop = True
        rdoElectronics.Text = "Electronics"
        rdoElectronics.UseVisualStyleBackColor = True
        ' 
        ' rdoClothing
        ' 
        rdoClothing.AutoSize = True
        rdoClothing.Location = New Point(6, 47)
        rdoClothing.Name = "rdoClothing"
        rdoClothing.Size = New Size(71, 19)
        rdoClothing.TabIndex = 1
        rdoClothing.TabStop = True
        rdoClothing.Text = "Clothing"
        rdoClothing.UseVisualStyleBackColor = True
        ' 
        ' rdoBooks
        ' 
        rdoBooks.AutoSize = True
        rdoBooks.Location = New Point(6, 72)
        rdoBooks.Name = "rdoBooks"
        rdoBooks.Size = New Size(57, 19)
        rdoBooks.TabIndex = 2
        rdoBooks.TabStop = True
        rdoBooks.Text = "Books"
        rdoBooks.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(chkShipping)
        GroupBox2.Controls.Add(chkGiftWrap)
        GroupBox2.Controls.Add(chkWarranty)
        GroupBox2.Location = New Point(21, 131)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 100)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"
        ' 
        ' chkWarranty
        ' 
        chkWarranty.AutoSize = True
        chkWarranty.Location = New Point(6, 22)
        chkWarranty.Name = "chkWarranty"
        chkWarranty.Size = New Size(102, 19)
        chkWarranty.TabIndex = 0
        chkWarranty.Text = "With Warranty"
        chkWarranty.UseVisualStyleBackColor = True
        ' 
        ' chkGiftWrap
        ' 
        chkGiftWrap.AutoSize = True
        chkGiftWrap.Location = New Point(6, 47)
        chkGiftWrap.Name = "chkGiftWrap"
        chkGiftWrap.Size = New Size(76, 19)
        chkGiftWrap.TabIndex = 1
        chkGiftWrap.Text = "Gift Wrap"
        chkGiftWrap.UseVisualStyleBackColor = True
        ' 
        ' chkShipping
        ' 
        chkShipping.AutoSize = True
        chkShipping.Location = New Point(6, 72)
        chkShipping.Name = "chkShipping"
        chkShipping.Size = New Size(98, 19)
        chkShipping.TabIndex = 2
        chkShipping.Text = "Free Shipping"
        chkShipping.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(27, 237)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add to List"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 461)
        Controls.Add(btnAdd)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "ProductSelectionSystem"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoBooks As RadioButton
    Friend WithEvents rdoClothing As RadioButton
    Friend WithEvents rdoElectronics As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkShipping As CheckBox
    Friend WithEvents chkGiftWrap As CheckBox
    Friend WithEvents chkWarranty As CheckBox
    Friend WithEvents btnAdd As Button

End Class
