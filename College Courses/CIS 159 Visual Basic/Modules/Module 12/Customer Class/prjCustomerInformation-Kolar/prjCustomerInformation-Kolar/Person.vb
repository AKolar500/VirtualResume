Public Class Person
    'declare vars
    Public strFirstName As String
    Public strLastName As String
    Public strAddress As String
    Public strCity As String
    Public strState As String
    Public strZipCode As String
    Public strPhoneNumber As String

    'public properties
    Public Property FirstName() As String
        Get
            Return strFirstName
        End Get
        Set(ByVal value As String)
            strFirstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return strLastName
        End Get
        Set(ByVal value As String)
            strLastName = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
    Public Property City() As String
        Get
            Return strCity
        End Get
        Set(ByVal value As String)
            strCity = value
        End Set
    End Property
    Public Property State() As String
        Get
            Return strState
        End Get
        Set(ByVal value As String)
            strState = value
        End Set
    End Property
    Public Property ZipCode() As String
        Get
            Return strZipCode
        End Get
        Set(ByVal value As String)
            strZipCode = value
        End Set
    End Property
    Public Property PhoneNumber() As String
        Get
            Return strPhoneNumber
        End Get
        Set(ByVal value As String)
            strPhoneNumber = value
        End Set
    End Property
End Class
