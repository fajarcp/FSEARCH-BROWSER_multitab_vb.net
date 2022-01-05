Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        ListBox1.Items.Add(IO.File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\FHistory.txt"))
    End Sub
End Class