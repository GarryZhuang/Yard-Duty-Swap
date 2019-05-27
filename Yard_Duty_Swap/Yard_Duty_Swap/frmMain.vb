Public Class frmMain

#Region "Main Function"
    Public Sub Swap_Item(ByVal itemA As TextBox, ByVal itemB As TextBox)
        Dim temp As String              '[STEP 1] First, we will declare a tempoarty string to hold information from itemA

        temp = itemA.Text               '[STEP 2] We will now get text information from itemA
        itemA.Text = itemB.Text         '[STEP 3] We will now replace the item from itemA as itemB's text
        itemB.Text = temp               '[STEP 4] We will finally replace itemB with itemA's text which is held in temporary storage
    End Sub
#End Region 'This is the base procedure to do the tasks in this program, itemA as a Textbox and itemB as a Textbox

#Region "Checkboxes Actions"
    Private Sub cbxSwapDay_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSwapDay.CheckedChanged
        'We will call for the procedure "Swap_Duty" with the appropriate TextBox's names.
        Swap_Item(txtDay1, txtDay2)
    End Sub

    Private Sub cbxSwapDuty_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSwapDuty.CheckedChanged
        'We will call for the procedure "Swap_Duty" with the appropriate TextBox's names.
        Swap_Item(txtDuty1, txtDuty2)
    End Sub

    Private Sub cbxSwapDuty2_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSwapDuty2.CheckedChanged
        'We will call for the procedure "Swap_Duty" with the appropriate TextBox's names.
        Swap_Item(txtLocation1, txtLocation2)
    End Sub
#End Region 'Action's after checkboxes have changed

#Region "Buttons"
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This button will clear all the data saved in the checkboxes
        txtDay1.Clear()
        txtDay2.Clear()
        txtDuty1.Clear()
        txtDuty2.Clear()
        txtLocation1.Clear()
        txtLocation2.Clear()

        'We will reset the checked status of the checkboxes aswell
        cbxSwapDay.Checked = False
        cbxSwapDuty.Checked = False
        cbxSwapDuty2.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This button will close the form
        End
    End Sub
#End Region 'Buttons in the frmMain

End Class

' Copyright Garry Zhuang 2019 | Software Development 3 & 4 | Unit 3 Outcome 1 | SAC
