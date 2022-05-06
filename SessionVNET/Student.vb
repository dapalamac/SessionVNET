Public Class Student

    Private name As String
    Private dateOfBirth As DateTime

    Public Property fullname As String

        Get
            Return Me.name

        End Get
        Set(value As String)

            Me.name = value

        End Set
    End Property

    Public Property DOB() As String

        Get

            Return Me.dateOfBirth

        End Get
        Set(value As String)

            Me.dateOfBirth = value

        End Set

    End Property




End Class
