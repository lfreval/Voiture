Public Class VoitureSale
    Private _kilometrage As Integer = 0
    Public Property km As Integer
        Get
            Return _kilometrage
        End Get
        Set(value As Integer)
            _kilometrage = value
        End Set
    End Property

    Public Function Rouler(km As Integer) As Integer
        _kilometrage += km
        Return _kilometrage
    End Function

End Class
