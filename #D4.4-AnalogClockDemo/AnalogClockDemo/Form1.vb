Imports AnalogClock

Public Class Form1

    Enum Months As Integer
        Jan = 1
        Feb = 2
        Mar = 3
        Apr = 4
        May = 5
        Jun = 6
        Jul = 7
        Aug = 8
        Sep = 9
        Oct = 10
        Nov = 11
        Dec = 12
    End Enum

    Dim _pt As Point

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now)
        Me.PropertyGrid1.SelectedObject = Me.Clock1
    End Sub

    Private Sub GradientBrush_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientBrush.CheckedChanged, SolidBrush.CheckedChanged, HatchBrush.CheckedChanged, LinearGradientBrush.CheckedChanged
        'The user selected a brush for the clock, refresh the clock to paint its elements whith the selected brush.
        Me.Clock1.Refresh()
    End Sub

    'Private Sub Clock1_HourHandPainted(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Clock1.HourHandPainted
    '    Dim h As Hand = DirectCast(sender, Hand)
    '    Dim gp As Drawing2D.GraphicsPath = CType(h.Path.Clone, Drawing2D.GraphicsPath)
    '    Dim p As New Pen(Color.Gray, 1)
    '    gp.Widen(p)
    '    e.Graphics.DrawPath(p, gp)
    '    p.Dispose()
    '    gp.Dispose()
    'End Sub

    Private Sub Clock1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseDown
        Me._pt = e.Location
    End Sub

    Private Sub Clock1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseUp
        Me._pt = Nothing
    End Sub

    Private Sub Clock1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Clock1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso Me._pt <> Nothing Then
            Me.Clock1.Left += e.X - Me._pt.X
            Me.Clock1.Top += e.Y - Me._pt.Y
        End If
    End Sub


    '*************************** Custom Painting ******************************
    '**************************************************************************

    Private Sub Clock1_BackgroundPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Clock1.BackgroundPaint

        'Painting some stuff on the clock's background.

        Dim x, y As Single
        Dim sz As SizeF

        Dim sbr As New SolidBrush(Me.Clock1.ForeColor)
        'Draw your name on the top, clock's background
        sz = e.Graphics.MeasureString("ARMAN", New Font("Palace Script MT", 12, FontStyle.Italic), New PointF(0, 0), StringFormat.GenericDefault)
        x = Me.Clock1.CenterPoint.PivotalPoint.X - sz.Width / 2
        y = CSng(Me.Clock1.Radius * 0.3)
        e.Graphics.DrawString("ARMAN", New Font("Palace Script MT", 12, FontStyle.Italic), sbr, x, y)

        'Draw digital time on the bottom, clock's background
        sz = e.Graphics.MeasureString(Me.Clock1.Value.ToShortTimeString, Me.Font, New PointF(0, 0), StringFormat.GenericDefault)
        x = Me.Clock1.CenterPoint.PivotalPoint.X - sz.Width / 2
        y = CSng(Me.Clock1.Rectangle.Height - Me.Clock1.Radius * 0.3 - sz.Height)
        e.Graphics.DrawString(Me.Clock1.Value.ToLongTimeString, Me.Font, sbr, x, y)
        sbr.Dispose()

        'Draw month-day box on the clock's background
        Dim str As String = CType(Me.Clock1.Value.Month, Months).ToString & " " & Me.Clock1.Value.Day
        sz = e.Graphics.MeasureString(str, New Font("Tahoma", 10, FontStyle.Bold), New PointF(0, 0), StringFormat.GenericDefault)
        Dim rec As New Rectangle(CInt(Me.Clock1.Rectangle.Width - Me.Clock1.Radius * 0.3 - sz.Width), CInt(Me.Clock1.CenterPoint.PivotalPoint.Y - 7.5), CInt(sz.Width), CInt(sz.Height))
        Dim br As New Drawing2D.LinearGradientBrush(rec, SystemColors.ControlDark, Color.White, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(br, rec)
        br.Dispose()
        e.Graphics.DrawString(str, New Font("Tahoma", 10, FontStyle.Bold), Brushes.Black, rec, StringFormat.GenericTypographic)
        rec.Inflate(1, 1)
        e.Graphics.DrawRectangle(Pens.White, rec)
    End Sub

    Private Sub Clock1_HandPainting(ByVal sender As System.Object, ByVal e As AnalogClock.PaintEventArgs) _
    Handles Clock1.SecondHandPainting, Clock1.MinuteHandPainting, Clock1.HourHandPainting

        'Painting the hour, minute and second hand objects with different brushs.

        Dim h As Hand = DirectCast(sender, Hand)
        Dim gp As Drawing2D.GraphicsPath = CType(h.Path.Clone, Drawing2D.GraphicsPath)
        Dim p As New Pen(Color.Gray, 2)
        gp.Widen(p)
        p.Dispose()
        e.Graphics.FillPath(Brushes.Gray, gp)
        gp.Dispose()
        'Make sure the hand's graphics path contains more than 2 points.
        If h.Path.PointCount > 2 Then
            If Me.GradientBrush.Checked Then
                'Make the hand gradient
                Dim br As New Drawing2D.PathGradientBrush(h.Path)
                br.CenterColor = Color.White
                br.SurroundColors = New Color() {h.Color}
                e.Brush = br
                br.Dispose()
            ElseIf Me.HatchBrush.Checked Then
                'Make the hand Hatch
                Dim br As New Drawing2D.HatchBrush(Drawing2D.HatchStyle.DarkUpwardDiagonal, h.Color, Color.White)
                e.Brush = br
                br.Dispose()
            ElseIf Me.LinearGradientBrush.Checked Then
                'Make the hand LinearGradient
                Dim br As New Drawing2D.LinearGradientBrush(h.Path.GetBounds, h.Color, Color.White, Drawing2D.LinearGradientMode.BackwardDiagonal)
                e.Brush = br
                br.Dispose()
            End If
        End If

    End Sub

    Private Sub Clock1_CenterPointPainting(ByVal sender As Object, ByVal e As AnalogClock.PaintEventArgs) Handles Clock1.CenterPointPainting

        'Painting the center object with different brushs.

        Dim c As Center = DirectCast(sender, AnalogClock.Center)
        If Me.GradientBrush.Checked Then
            'Make the center point gradient
            Dim br As New Drawing2D.PathGradientBrush(c.Path)
            br.WrapMode = Drawing2D.WrapMode.Tile
            br.CenterColor = Color.White
            br.SurroundColors = New Color() {c.Color}
            br.CenterPoint = c.PivotalPoint
            e.Brush = br
            br.Dispose()
        ElseIf Me.HatchBrush.Checked Then
            'Make the center point Hatch
            Dim br As New Drawing2D.HatchBrush(Drawing2D.HatchStyle.LargeCheckerBoard, c.Color, Color.White)
            e.Brush = br
            br.Dispose()
        ElseIf Me.LinearGradientBrush.Checked Then
            'Make the center point LinearGradient
            Dim br As New Drawing2D.LinearGradientBrush(c.Path.GetBounds, c.Color, Color.White, Drawing2D.LinearGradientMode.BackwardDiagonal)
            e.Brush = br
            br.Dispose()
        End If

    End Sub

    Private Sub Clock1_BigMarkerPainting(ByVal sender As Object, ByVal e As AnalogClock.PaintEventArgs) _
    Handles Clock1.BigMarkerPainting, Clock1.SmallMarkerPainting

        'Painting all big-marker objects with different brushs.
        'With the same fashion you can paint the small-markers.

        Dim m As Marker = DirectCast(sender, AnalogClock.Marker)
        Dim gp As Drawing2D.GraphicsPath = CType(m.Path.Clone, Drawing2D.GraphicsPath)
        Dim p As New Pen(Color.Gray, 2)
        gp.Widen(p)
        p.Dispose()
        e.Graphics.FillPath(Brushes.LightGray, gp)
        gp.Dispose()
        'Make sure the marker's graphics path contains more than 2 points.
        If m.Path.PointCount > 2 Then
            If Me.GradientBrush.Checked Then
                'Make the marker gradient
                Dim br As New Drawing2D.PathGradientBrush(m.Path)
                br.CenterColor = Color.White
                br.SurroundColors = New Color() {m.Color}
                e.Brush = br
                br.Dispose()
            ElseIf Me.HatchBrush.Checked Then
                'Make the marker Hatch
                Dim br As New Drawing2D.HatchBrush(Drawing2D.HatchStyle.DarkUpwardDiagonal, m.Color, Color.White)
                e.Brush = br
                br.Dispose()
            ElseIf Me.LinearGradientBrush.Checked Then
                'Make the marker LinearGradient
                Dim br As New Drawing2D.LinearGradientBrush(m.Path.GetBounds, m.Color, Color.White, Drawing2D.LinearGradientMode.BackwardDiagonal)
                e.Brush = br
                br.Dispose()
            End If
        End If

    End Sub


    '*************************** Providing Custom Elements ******************************
    '************************************************************************************
    'Note this events will fire only if an element's style is set to "Costom".

    Private Sub Clock1_CustomElementRequest(ByVal sender As Object, ByVal e As AnalogClock.CustomElementEventArgs) Handles Clock1.CustomElementRequest

        If sender.GetType Is GetType(AnalogClock.Center) Then
            'The clock's center-point requests a custom GrapicsPath object.

            'The custom center GraphicsPath object must be constructed
            'head up position and the midpoint at the clock's center.
            'Use the center's properties (pivotal-point, radius etc) for consistency.

            'This is an octagon style.
            Dim radius As Single = Me.Clock1.CenterPoint.Radius
            Dim gPath As New Drawing2D.GraphicsPath
            Dim helper As Single
            Dim points(7) As PointF
            Dim pPoint As PointF = Me.Clock1.CenterPoint.PivotalPoint

            helper = CSng(radius * Math.Sin((45.0F * Math.PI) / 180))
            'Create(points)
            points(0) = New PointF(pPoint.X, pPoint.Y - radius)
            points(1) = New PointF(pPoint.X + helper, pPoint.Y - helper)
            points(2) = New PointF(pPoint.X + radius, pPoint.Y)
            points(3) = New PointF(pPoint.X + helper, pPoint.Y + helper)
            points(4) = New PointF(pPoint.X, pPoint.Y + radius)
            points(5) = New PointF(pPoint.X - helper, pPoint.Y + helper)
            points(6) = New PointF(pPoint.X - radius, pPoint.Y)
            points(7) = New PointF(pPoint.X - helper, pPoint.Y - helper)
            'Add lines to the path.
            gPath.AddLines(points)
            gPath.CloseAllFigures()
            e.CustomPath = gPath
        ElseIf sender.GetType Is GetType(AnalogClock.Hand) Then
            'A clock' hand requests a custom GrapicsPath object.

            'The custom hour, minute and second hands GraphicsPath objects
            'must be constructed at 12 o'clock position.
            'Use the hand's properties (with, lengths, pivotal-point etc) for consistency.

            'This is a pointed style.
            Dim h As Hand = DirectCast(sender, Hand)
            Dim points(3) As PointF
            Dim gPath As New Drawing2D.GraphicsPath
            Dim pPoint As PointF = h.PivotalPoint
            'Create(points)
            points(0) = New PointF(pPoint.X, pPoint.Y - h.PrimeLength)
            points(1) = New PointF(pPoint.X + h.Width / 2, pPoint.Y)
            points(2) = New PointF(pPoint.X, pPoint.Y + h.TailLength)
            points(3) = New PointF(pPoint.X - h.Width / 2, pPoint.Y)
            'Add lines to the path.
            gPath.AddLines(points)
            gPath.CloseAllFigures()
            e.CustomPath = gPath
        ElseIf sender.GetType Is GetType(AnalogClock.Marker) Then
            'A clock' marker requests a custom GrapicsPath object.

            'The custom big and small markers GraphicsPath objects
            'must be constructed at 12 o'clock position.
            'Use the marker's properties (with, length, pivotal-point, radius etc) for consistency.

            'This is a traingle style.
            Dim m As Marker = DirectCast(sender, Marker)
            Dim pOuter, pInner As PointF
            Dim points(2) As PointF
            Dim gPath As New Drawing2D.GraphicsPath
            Dim pPoint As PointF = m.PivotalPoint

            'Create(points)
            pOuter = New PointF(pPoint.X, Me.Clock1.Radius - m.Radius)
            pInner = New PointF(pPoint.X, Me.Clock1.Radius - (m.Radius - m.Length))
            points(0) = New PointF(pOuter.X - m.Width / 2, pOuter.Y)
            points(1) = New PointF(pOuter.X + m.Width / 2, pOuter.Y)
            points(2) = pInner
            'Add lines to the path.
            gPath.AddLines(points)
            gPath.CloseAllFigures()
            e.CustomPath = gPath
        End If
    End Sub

End Class