Imports System.Drawing
Imports System.Windows.Forms

Public Class StarRating
    Inherits UserControl

    Private _rating As Integer = 0
    Private _numberOfStars As Integer = 5
    Private _starSize As Integer = 30

    Public Property Rating As Integer
        Get
            Return _rating
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= _numberOfStars Then
                _rating = value
                Me.Invalidate() ' Redraw the control
            End If
        End Set
    End Property

    Public Property NumberOfStars As Integer
        Get
            Return _numberOfStars
        End Get
        Set(value As Integer)
            _numberOfStars = value
            Me.Width = value * _starSize
            Me.Invalidate() ' Redraw the control
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.Clear(Me.BackColor)
        Dim brush As Brush = New SolidBrush(Color.Gold)
        Dim pen As Pen = New Pen(Color.Gold)
        Dim starPoints As PointF() = GetStarPoints()

        For i As Integer = 0 To _numberOfStars - 1
            Dim offsetX As Integer = i * _starSize
            Dim transformedPoints = starPoints.Select(Function(p) New PointF(p.X + offsetX, p.Y)).ToArray()

            If i < _rating Then
                g.FillPolygon(brush, transformedPoints)
            Else
                g.DrawPolygon(pen, transformedPoints)
            End If
        Next
    End Sub

    Private Function GetStarPoints() As PointF()
        Dim points As PointF() = {
            New PointF(10, 0),
            New PointF(12, 7),
            New PointF(20, 7),
            New PointF(14, 12),
            New PointF(16, 20),
            New PointF(10, 15),
            New PointF(4, 20),
            New PointF(6, 12),
            New PointF(0, 7),
            New PointF(8, 7)
        }
        Return points
    End Function

End Class
