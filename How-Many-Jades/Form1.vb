Public Class Form1

    Private Sub FrmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbJade.SelectedIndex = 0
        cmbOwn.SelectedIndex = 0
    End Sub

    Private Sub lblResetText(sender As Object, e As EventArgs) Handles cmbJade.SelectedIndexChanged, cmbStart.SelectedIndexChanged, cmbOwn.SelectedIndexChanged, cmbFin.SelectedIndexChanged
        lblReq.Text = "Waiting..."
        lblCost.Text = "Waiting..."
    End Sub

    Private Sub cmbStartSIC(sender As Object, e As EventArgs) Handles cmbStart.SelectedIndexChanged
        Integer.TryParse(cmbStart.SelectedItem.ToString, Vars.intSta)
        cmbFin.Items.Clear()
        If Vars.intSta > 0 Then
            For i As Integer = (Vars.intSta + 1) To 10
                cmbFin.Items.Add(i)
            Next
        Else
            For i As Integer = 3 To 10
                cmbFin.Items.Add(i)
            Next
        End If
        cmbFin.SelectedIndex = 0
    End Sub

    Private Sub btnCalcCli(sender As Object, e As EventArgs) Handles btnCalc.Click
        If cmbStart.SelectedIndex <> -1 Then
            Integer.TryParse(cmbStart.SelectedItem.ToString, Vars.intSta)
            Integer.TryParse(cmbOwn.SelectedItem.ToString, Vars.intOwn)
            Integer.TryParse(cmbFin.SelectedItem.ToString, Vars.intFin)

            Vars.intNum = Math.Pow(3, Vars.intFin - 3) '* (3 - Vars.intOwn)
            lblReq.Text = Vars.intNum.ToString()
            lblCost.Text = (Vars.intNum * Vars.intJade(cmbJade.SelectedIndex)).ToString()
        Else
            MessageBox.Show("Please fill all boxes before trying to calculate.", "More Info Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
