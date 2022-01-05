Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
        
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            WebBrowser1.Navigate(ToolStripTextBox1.Text)
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.CanGoForward Then
            Button2.Enabled = True
            Button2.BackColor = Color.Green
        Else
            Button2.Enabled = False
            Button2.BackColor = Color.RoyalBlue
        End If
        If WebBrowser1.CanGoBack Then
            Button1.Enabled = True
            Button1.BackColor = Color.Green
        Else
            Button1.Enabled = False
            Button1.BackColor = Color.RoyalBlue
        End If
        Me.Text = WebBrowser1.DocumentTitle
        ToolStripTextBox1.Text = WebBrowser1.Document.Url.AbsoluteUri



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()

        End If
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click

    End Sub

    Private Sub ToolStripTextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Dim a As String = "https://www.google.com/search?q=" & Me.ToolStripTextBox2.Text
            WebBrowser1.Navigate(a)
        End If
    End Sub

    
End Class
