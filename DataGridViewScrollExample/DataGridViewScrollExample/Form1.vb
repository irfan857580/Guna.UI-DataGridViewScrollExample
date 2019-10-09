Public Class Form1
    Dim hScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim vScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper

    Private Sub DataGridView1_Resize(sender As Object, e As EventArgs) Handles DataGridView1.Resize
        If hScrollHelper IsNot Nothing Then hScrollHelper.UpdateScrollBar()
        If vScrollHelper IsNot Nothing Then vScrollHelper.UpdateScrollBar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView1, GunaHScrollBar1, True)
        vScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView1, GunaVScrollBar1, True)
        Dim r As New Random
        For i As Integer = 0 To 40
            DataGridView1.Rows.Add({i, r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000)})
        Next
        hScrollHelper.UpdateScrollBar()
        vScrollHelper.UpdateScrollBar()
    End Sub


End Class
