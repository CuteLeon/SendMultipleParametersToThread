Imports System.Threading 'Test_1方案需要引入的命名空间

Public Class TestStudio
    Dim Index As Int16 '这个变量可以一如既往地被忽略。
    '要传入四个线程的四个参数：
    Dim Parameter() As String = {"我是一支线程。", "我也是一支线程。",
                                 "我也是！我也是！", "好吧，我是最后一个线程。"}

    '———————————————————我是一条分割线——————————————————————
    'Test_1方案：使用命名空间，不需要定义Thread类型变量。
    Private Sub Test_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test_1.Click
        For Me.Index = 0 To 3
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf Sub_Test_1), Parameter(Index))
        Next
    End Sub
    'Test_1绑定的过程。
    Private Sub Sub_Test_1(ByVal Parameter As String)
        MsgBox(Parameter, MsgBoxStyle.Information, "Sub_Test_1")
    End Sub

    '———————————————————我是一条分割线——————————————————————
    'Test_2方案：使用Thread的Start方法传入一个参数，也只能传入一个参数。
    Private Sub Test_2_Click(sender As Object, e As EventArgs) Handles Test_2.Click
        Dim MyThread(3) As Threading.Thread
        For Me.Index = 0 To 3
            '初始化线程，并传入数据和启动
            MyThread(Index) = New Threading.Thread(AddressOf Sub_Test_2)
            MyThread(Index).Start(Parameter(Index))
        Next
    End Sub
    'Test_2绑定的过程
    Private Sub Sub_Test_2(ByVal Parameter As String)
        MsgBox(Parameter, MsgBoxStyle.Information, "Sub_Test_2")
    End Sub

    '———————————————————我是一条分割线——————————————————————
    '包含多个数据的结构体变量
    Structure ParameterStru
        Dim Body1 As String
        Dim Body2 As Integer
        Dim Body3 As String
    End Structure

    'Test_3方案：把多个数据集中到一个结构体变量中，只需传入结构体即可传入多个数据。
    Private Sub Test_3_Click(sender As Object, e As EventArgs) Handles Test_3.Click
        Dim ParameterStructure(3) As ParameterStru
        Dim MyThread(3) As Threading.Thread

        For Me.Index = 0 To 3
            '给结构体赋值
            With ParameterStructure(Index)
                .Body1 = Parameter(Index)
                .Body2 = 16 * (1 + Index)
                .Body3 = "Sub_Test_3"
            End With
            '初始化线程，并传入数据和启动
            MyThread(Index) = New Threading.Thread(AddressOf Sub_Test_3)
            MyThread(Index).Start(ParameterStructure(Index))
        Next
    End Sub
    'Test_3绑定的过程
    Private Sub Sub_Test_3(ByVal Parameter As ParameterStru)
        MsgBox(Parameter.Body1, Parameter.Body2, Parameter.Body3)
    End Sub
End Class