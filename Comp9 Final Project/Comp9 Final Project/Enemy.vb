﻿Public Class Enemy
    Private _health As Integer
    Private _damage As Double
    Private _speed As Integer
    Private _rank As String
    Private _position As Point
    Private _trajectory As String

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
            'work on this if keep
            _rank = value

        End Set
    End Property

    Property Position As Point
        Get
            Return _position
        End Get
        Set(value As Point)
            If value.X < 0 AndAlso value.Y < 0 Then
                value.X = 0
                value.Y = 0
            Else
                _position = value
            End If
        End Set
    End Property

    Property Trajectory As String
        Get
            Return _trajectory
        End Get
        Set(value As String)

            If value.ToLower = "left" OrElse value.ToLower = "4" Then
            ElseIf value.ToLower = "left" OrElse value.ToLower = "4" Then
                _trajectory = value
            ElseIf value.ToLower = "right" OrElse value.ToLower = "6" Then
                _trajectory = value
            ElseIf value.ToLower = "upleft" OrElse value.ToLower = "7" Then
                _trajectory = value
            ElseIf value.ToLower = "upright" OrElse value.ToLower = "9" Then
                _trajectory = value
            ElseIf value.ToLower = "downleft" OrElse value.ToLower = "1" Then
                _trajectory = value
            ElseIf value.ToLower = "downright" OrElse value.ToLower = "3" Then
                _trajectory = value
            Else
                _trajectory = "right"
            End If
        End Set
    End Property
    Public Sub Direction()
        If _trajectory = "left" OrElse _trajectory = "4" Then
            Position = New Point(Position.X - _speed, Position.Y)
        ElseIf _trajectory = "right" OrElse _trajectory = "6" Then
            Position = New Point(Position.X + _speed, Position.Y)
        ElseIf _trajectory = "upleft" OrElse _trajectory = "7" Then
            Position = New Point(Position.X - (0.8660254 * _speed), Position.Y + _speed * 0.5)
        ElseIf _trajectory = "upright" OrElse _trajectory = "9" Then
            Position = New Point(Position.X - (0.8660254 * _speed), Position.Y + _speed * 0.5)
        ElseIf _trajectory = "downleft" OrElse _trajectory = "1" Then
            Position = New Point(Position.X + (0.8660254 * _speed), Position.Y - _speed * 0.5)
        ElseIf _trajectory = "downright" OrElse _trajectory = "3" Then
            Position = New Point(Position.X + (0.8660254 * _speed), Position.Y + _speed * 0.5)
        Else
            Position = New Point(Position.X, Position.Y + _speed)
        End If

    End Sub

    Public Sub New()
        Rank = "pawn"
        Damage = 10
        Health = 100
        Speed = 20
        Trajectory = "left"
        Position = New Point(0, 0)
    End Sub
    Public Sub New(ByVal strRank, ByVal dblDamage, ByVal intHealth, ByVal intSpeed, ByVal strTrajectory, ByVal ptPosition)
        Rank = strRank
        Damage = dblDamage
        Health = intHealth
        Speed = intSpeed
        Trajectory = strTrajectory
        Position = ptPosition
    End Sub
End Class
