Public Class Customer
    Inherits Person

    Public intCustomerNumber As Integer
    Public blnMailingList As Boolean
    Public strComments As String

    'public properties
    Public Property CustomerNumber() As Integer
        Get
            Return intCustomerNumber
        End Get
        Set(ByVal value As Integer)
            intCustomerNumber = value
        End Set
    End Property
    Public Property MailingList() As Boolean
        Get
            Return blnMailingList
        End Get
        Set(ByVal value As Boolean)
            blnMailingList = value
        End Set
    End Property
    Public Property Comments() As String
        Get
            Return strComments
        End Get
        Set(ByVal value As String)
            strComments = value
        End Set
    End Property
End Class
