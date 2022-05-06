Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub NextPageButton_Click(sender As Object, e As EventArgs) Handles NextPageButton.Click

        Dim student As New Student()

        student.fullname = NameTextBox.Text
        student.DOB = DOBTextBox.Text

        Session("student") = student

        'Response.Redirect("Receive.aspx")
        Server.Transfer("Receive.aspx")

    End Sub
End Class