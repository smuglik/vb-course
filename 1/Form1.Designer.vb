<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Run = New System.Windows.Forms.Button()
        Me.inputFieldA = New System.Windows.Forms.TextBox()
        Me.inputFieldB = New System.Windows.Forms.TextBox()
        Me.inputFieldH = New System.Windows.Forms.TextBox()
        Me.DisplayX = New System.Windows.Forms.TextBox()
        Me.DisplayY = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Run
        '
        Me.Run.Location = New System.Drawing.Point(141, 293)
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(75, 23)
        Me.Run.TabIndex = 0
        Me.Run.Text = "Run"
        Me.Run.UseVisualStyleBackColor = True
        '
        'inputFieldA
        '
        Me.inputFieldA.Location = New System.Drawing.Point(54, 144)
        Me.inputFieldA.Name = "inputFieldA"
        Me.inputFieldA.Size = New System.Drawing.Size(100, 20)
        Me.inputFieldA.TabIndex = 2
        '
        'inputFieldB
        '
        Me.inputFieldB.Location = New System.Drawing.Point(175, 144)
        Me.inputFieldB.Name = "inputFieldB"
        Me.inputFieldB.Size = New System.Drawing.Size(100, 20)
        Me.inputFieldB.TabIndex = 3
        '
        'inputFieldH
        '
        Me.inputFieldH.Location = New System.Drawing.Point(290, 144)
        Me.inputFieldH.Name = "inputFieldH"
        Me.inputFieldH.Size = New System.Drawing.Size(100, 20)
        Me.inputFieldH.TabIndex = 4
        '
        'DisplayX
        '
        Me.DisplayX.Location = New System.Drawing.Point(531, 30)
        Me.DisplayX.Multiline = True
        Me.DisplayX.Name = "DisplayX"
        Me.DisplayX.Size = New System.Drawing.Size(322, 134)
        Me.DisplayX.TabIndex = 5
        '
        'DisplayY
        '
        Me.DisplayY.Location = New System.Drawing.Point(531, 194)
        Me.DisplayY.Multiline = True
        Me.DisplayY.Name = "DisplayY"
        Me.DisplayY.Size = New System.Drawing.Size(322, 122)
        Me.DisplayY.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 450)
        Me.Controls.Add(Me.DisplayY)
        Me.Controls.Add(Me.DisplayX)
        Me.Controls.Add(Me.inputFieldH)
        Me.Controls.Add(Me.inputFieldB)
        Me.Controls.Add(Me.inputFieldA)
        Me.Controls.Add(Me.Run)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Run As Button
    Friend WithEvents inputFieldA As TextBox
    Friend WithEvents inputFieldB As TextBox
    Friend WithEvents inputFieldH As TextBox
    Friend WithEvents DisplayX As TextBox
    Friend WithEvents DisplayY As TextBox
End Class
