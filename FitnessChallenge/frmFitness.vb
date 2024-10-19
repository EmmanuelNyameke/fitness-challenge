' Program Name: Fitness Challenge
' Author: K Bola
' Date: October 17, 2024
' Purpose: This application finds the average weight loss of a team of eight employees
Option Strict On
Public Class frmFitness
    Dim intMemberNumber As Integer = 1
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstWeightLoss.Items.Clear()
        lblAverageLoss.Text = ""
        btnEnterWeight.Focus()
        btnEnterWeight.Enabled = True
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuClear.PerformClick()
    End Sub
    Private Sub btnEnterWeight_Click(sender As Object, e As EventArgs) Handles btnEnterWeight.Click
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If (IsNumeric(strWeightLoss)) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, "")
            End If
        Loop
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average Weight Loss is " & decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No Weight Loss Value Entered")
        End If
        btnEnterWeight.Enabled = False
    End Sub
End Class
