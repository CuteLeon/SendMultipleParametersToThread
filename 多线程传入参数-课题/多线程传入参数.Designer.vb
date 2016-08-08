<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestStudio
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Test_1 = New System.Windows.Forms.Button()
        Me.Test_2 = New System.Windows.Forms.Button()
        Me.Test_3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Test_1
        '
        Me.Test_1.Location = New System.Drawing.Point(12, 12)
        Me.Test_1.Name = "Test_1"
        Me.Test_1.Size = New System.Drawing.Size(113, 31)
        Me.Test_1.TabIndex = 0
        Me.Test_1.Text = "Test_1"
        Me.Test_1.UseVisualStyleBackColor = True
        '
        'Test_2
        '
        Me.Test_2.Location = New System.Drawing.Point(12, 49)
        Me.Test_2.Name = "Test_2"
        Me.Test_2.Size = New System.Drawing.Size(113, 31)
        Me.Test_2.TabIndex = 1
        Me.Test_2.Text = "Test_2"
        Me.Test_2.UseVisualStyleBackColor = True
        '
        'Test_3
        '
        Me.Test_3.Location = New System.Drawing.Point(12, 86)
        Me.Test_3.Name = "Test_3"
        Me.Test_3.Size = New System.Drawing.Size(113, 31)
        Me.Test_3.TabIndex = 2
        Me.Test_3.Text = "Test_3"
        Me.Test_3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(131, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "System.Threading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "引用命名空间实现。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(131, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Thread.Start(Parameter)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "使用Start方法只能传入一个参数。"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(131, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Thread.Start(ParameterStructure)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test_2的衍生方法，传入一个包含多" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "个参数的结构体参数。"
        '
        'TestStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 144)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Test_3)
        Me.Controls.Add(Me.Test_2)
        Me.Controls.Add(Me.Test_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TestStudio"
        Me.Text = "多线程传入参数-课题"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test_1 As System.Windows.Forms.Button
    Friend WithEvents Test_2 As System.Windows.Forms.Button
    Friend WithEvents Test_3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
