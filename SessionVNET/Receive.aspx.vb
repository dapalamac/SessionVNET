Public Class Receive
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim student As Student
        student = Session("Student")

        NameLabel.Text = student.fullname
        DOBLabel.Text = student.DOB

    End Sub

End Class