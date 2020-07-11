Public Class FrmProcess
    Public strWho As String
    Public strWhat As String
    Public strWhere As String
    Public strWhen As String
    Public strWhy As String
    Public strHow As String
    Public IntQty1 As Int16
    Public stProcess1 As String
    Public strAction1 As String
    Public strSubProcesses1 As String
    Public strPredecessors1 As String
    Public strSuccessors1 As String
    Public strEnergy1 As String
    Public strSideEffects1 As String

    Private Sub FrmProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBWho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBWho.SelectedIndexChanged
        strWho = CBWho.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Who is " & strWho.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBWhat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBWhat.SelectedIndexChanged
        strWhat = CBWhat.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "What is " & strWhat.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBWhere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBWhere.SelectedIndexChanged
        strWhere = CBWhere.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Where is " & strWhere.ToLower() & "." & vbCrLf
    End Sub

    Private Sub TBWhen_TextChanged(sender As Object, e As EventArgs) Handles TBWhen.LostFocus
        If TBWhen.Text <> "" Then
            strWhen = TBWhen.Text
            RTBExplanations.Text = RTBExplanations.Text & "When is " & strWhen.ToLower() & "." & vbCrLf
        End If

    End Sub

    Private Sub CBWhy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBWhy.SelectedIndexChanged
        strWhy = CBWhy.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Why is " & strWhy.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBHow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBHow.SelectedIndexChanged
        strHow = CBHow.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "How is " & strHow.ToLower() & "." & vbCrLf
    End Sub

    Private Sub TBHowMuch_TextChanged(sender As Object, e As EventArgs) Handles TBHowMuch.LostFocus
        If TBHowMuch.Text <> "" Then
            IntQty1 = Int(TBHowMuch.Text)
            RTBExplanations.Text = RTBExplanations.Text & "The quantity is  " & IntQty1 & "." & vbCrLf
        End If
    End Sub

    Private Sub CBProcess1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProcess1.SelectedIndexChanged
        stProcess1 = CBProcess1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 is " & stProcess1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBAction1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAction1.SelectedIndexChanged
        strAction1 = CBAction1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 action is " & strAction1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBPredecessors1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPredecessors1.SelectedIndexChanged
        strPredecessors1 = CBPredecessors1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 predecessors is " & strPredecessors1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBSuccessors1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSuccessors1.SelectedIndexChanged
        strSuccessors1 = CBSuccessors1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 successor is " & strSuccessors1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBSubProcesses1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSubProcesses1.SelectedIndexChanged
        strSubProcesses1 = CBSubProcesses1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 subprocesses are " & strSubProcesses1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBEnergy1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEnergy1.SelectedIndexChanged
        strEnergy1 = CBEnergy1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 energy is " & strEnergy1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBSideEffects1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSideEffects1.SelectedIndexChanged
        strSideEffects1 = CBSideEffects1.SelectedItem
        RTBExplanations.Text = RTBExplanations.Text & "Process 1 side effects are " & strSideEffects1.ToLower() & "." & vbCrLf
    End Sub

    Private Sub CBWho_LostFocus(sender As Object, e As EventArgs) Handles CBWho.LostFocus
        If CBWho.Text <> "" Then
            strWho = CBWho.Text
            RTBExplanations.Text = RTBExplanations.Text & "Who is " & strWho & "." & vbCrLf
        End If
    End Sub

End Class
