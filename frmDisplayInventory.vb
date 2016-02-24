' The frmDisplayInventory class is opened by frmDepreciation
' and displays the inventory file in sorted order

Option Strict On
Public Class frmDisplayInventory

    Private Sub frmDisplayInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' The frmDisplayInventory load is a second form that
        ' displays the sorted inventory items

        Dim strItem As String

        ' Sorts the _strInventoryItem array
        Array.Sort(frmDepreciation._strInventoryItem)

        ' Displays the _strInventorItem array
        For Each strItem In frmDepreciation._strInventoryItem
            lstDisplay.Items.Add(strItem)
        Next

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        ' This sub procedure opens the first form
        Dim frmFirst As New frmDepreciation

        Hide()
        frmFirst.ShowDialog()

    End Sub
End Class