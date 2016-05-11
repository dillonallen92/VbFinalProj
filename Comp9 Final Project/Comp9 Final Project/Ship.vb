Public Class Ship
    Private _health As Integer
    Private _damage As Integer
    Private _speed As Integer
    Private _currency As Integer

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
    Property Damage As Integer
        Get
            Return _damage
        End Get
        Set(value As Integer)
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
    Property Currency As Integer
        Get
            Return _currency
        End Get
        Set(value As Integer)
            If value > 0 Then
                _currency = value
            Else
                _currency = 0
            End If
        End Set
    End Property
    Public Sub New()
        _currency = 0
        _damage = 10
        _health = 100
        _speed = 20
    End Sub
    Public Sub New(ByVal intCurrency, ByVal intDamage, ByVal intHealth, ByVal intSpeed)
        Currency = intCurrency
        Damage = intDamage
        Health = intHealth
        Speed = intSpeed
    End Sub
End Class