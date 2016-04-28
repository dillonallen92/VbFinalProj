Public Class Enemy
    Private _health As Integer
    Private _damage As Double
    Private _speed As Integer
    Private _rank As String

    Property Health As Integer
        Get
            Return _health
        End Get
        Set(value As Integer)
            If value > 0 Then
                _health = value
            Else
                _health = 0
            End If
        End Set
    End Property
    Property Damage As Double
        Get
            Return _damage
        End Get
        Set(value As Double)
            If value > 0 Then
                _damage = value
            Else
                _damage = 0
            End If
        End Set
    End Property
    Property Speed As Integer
        Get
            Return _speed
        End Get
        Set(value As Integer)
            If value > 0 Then
                _speed = value
            Else
                _speed = 0
            End If
        End Set
    End Property
    Property Rank As String
        Get
            Return _rank
        End Get
        Set(value As String)
            If value > 0 Then
                _rank = value
            Else
                _rank = 0
            End If
        End Set
    End Property
    Public Sub New()
        _rank = "pawn"
        _damage = 10
        _health = 100
        _speed = 20
    End Sub
    Public Sub New(ByVal strRank, ByVal dblDamage, ByVal intHealth, ByVal intSpeed)
        Rank = strRank
        Damage = dblDamage
        Health = intHealth
        Speed = intSpeed
    End Sub
End Class
