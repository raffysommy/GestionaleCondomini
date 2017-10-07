Namespace Gestionale_Condomini
    Public Class Identity
        Public Class Identity
            Private user As String
            Private pass As String
            Public Property NomeUtente() As String
                Get
                    Return user
                End Get
                Set(value As String)
                    user = System.Text.RegularExpressions.Regex.Replace(value, "[^a-zA-Z0-9]", " ")
                End Set
            End Property
            Public Property Password() As String
                Get
                    Return pass
                End Get
                Set(value As String)
                    pass = System.Text.RegularExpressions.Regex.Replace(value, "[^a-zA-Z0-9]", " ")
                End Set
            End Property
        End Class

        Property Password As String

        Property NomeUtente As String

    End Class
End Namespace
