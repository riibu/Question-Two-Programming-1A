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
        Dim ListViewItem1 As ListViewItem = New ListViewItem(New String() {"Name"}, -1, Color.Empty, SystemColors.InactiveCaption, New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point))
        Dim ListViewItem2 As ListViewItem = New ListViewItem(New String() {"Surname"}, -1, Color.Empty, SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem3 As ListViewItem = New ListViewItem(New String() {"Contact number"}, -1, Color.Empty, SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem4 As ListViewItem = New ListViewItem(New String() {"Year of Registration "}, -1, Color.Empty, SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem5 As ListViewItem = New ListViewItem(New String() {"Gender"}, -1, Color.Empty, SystemColors.InactiveCaption, Nothing)
        Dim ListViewItem6 As ListViewItem = New ListViewItem(New String() {"Student Number "}, -1, Color.Empty, SystemColors.Info, Nothing)
        btnCreate = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ListView1 = New ListView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        clmName = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(122, 208)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(75, 23)
        btnCreate.TabIndex = 1
        btnCreate.Text = "Create"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 2
        Label1.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 5
        Label3.Text = "Contact Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 7
        Label4.Text = "Year of registration:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 9
        Label5.Text = "Surname:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 11
        Label6.Text = "Gender:"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {clmName, ColumnHeader1})
        ListView1.Items.AddRange(New ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6})
        ListView1.Location = New Point(255, 3)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(283, 228)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(135, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(135, 30)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(135, 56)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 17
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(135, 85)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 19
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(135, 114)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(550, 261)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnCreate)
        Name = "Form1"
        Text = "Student Number Generator "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents clmName As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
