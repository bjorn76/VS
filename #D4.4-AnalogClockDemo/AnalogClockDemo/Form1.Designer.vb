<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.LinearGradientBrush = New System.Windows.Forms.RadioButton
        Me.HatchBrush = New System.Windows.Forms.RadioButton
        Me.SolidBrush = New System.Windows.Forms.RadioButton
        Me.GradientBrush = New System.Windows.Forms.RadioButton
        Me.Clock1 = New AnalogClock.Clock
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PropertyGrid1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1089, 712)
        Me.SplitContainer1.SplitterDistance = 692
        Me.SplitContainer1.TabIndex = 41
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.LinearGradientBrush)
        Me.SplitContainer2.Panel1.Controls.Add(Me.HatchBrush)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SolidBrush)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GradientBrush)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Panel2.Controls.Add(Me.Clock1)
        Me.SplitContainer2.Size = New System.Drawing.Size(692, 712)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 12
        '
        'LinearGradientBrush
        '
        Me.LinearGradientBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LinearGradientBrush.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinearGradientBrush.Location = New System.Drawing.Point(303, 3)
        Me.LinearGradientBrush.Name = "LinearGradientBrush"
        Me.LinearGradientBrush.Size = New System.Drawing.Size(133, 24)
        Me.LinearGradientBrush.TabIndex = 15
        Me.LinearGradientBrush.Text = "Linear Gradient Brush"
        Me.LinearGradientBrush.UseVisualStyleBackColor = True
        '
        'HatchBrush
        '
        Me.HatchBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HatchBrush.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HatchBrush.Location = New System.Drawing.Point(208, 3)
        Me.HatchBrush.Name = "HatchBrush"
        Me.HatchBrush.Size = New System.Drawing.Size(89, 24)
        Me.HatchBrush.TabIndex = 14
        Me.HatchBrush.Text = "Hatch Brush"
        Me.HatchBrush.UseVisualStyleBackColor = True
        '
        'SolidBrush
        '
        Me.SolidBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SolidBrush.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SolidBrush.Location = New System.Drawing.Point(115, 3)
        Me.SolidBrush.Name = "SolidBrush"
        Me.SolidBrush.Size = New System.Drawing.Size(87, 24)
        Me.SolidBrush.TabIndex = 13
        Me.SolidBrush.Text = "Solid Brush"
        Me.SolidBrush.UseVisualStyleBackColor = True
        '
        'GradientBrush
        '
        Me.GradientBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientBrush.Checked = True
        Me.GradientBrush.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GradientBrush.Location = New System.Drawing.Point(12, 3)
        Me.GradientBrush.Name = "GradientBrush"
        Me.GradientBrush.Size = New System.Drawing.Size(97, 24)
        Me.GradientBrush.TabIndex = 12
        Me.GradientBrush.TabStop = True
        Me.GradientBrush.Text = "Gradient Brush"
        Me.GradientBrush.UseVisualStyleBackColor = True
        '
        'Clock1
        '
        Me.Clock1.BackColor = System.Drawing.Color.Transparent
        Me.Clock1.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, True, 200.0!, 14.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Triangle, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, True, 200.0!, 14.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Triangle, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, True, 200.0!, 14.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Triangle, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), AnalogClock.MarkerStyle.Regular, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.Maroon, AnalogClock.MarkerStyle.Ring, True, 200.0!, 14.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), AnalogClock.MarkerStyle.Triangle, True, 200.0!, 12.0!, 0.07!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, "")}
        Me.Clock1.BorderStyle = AnalogClock.BorderStyles.Round
        Me.Clock1.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.CenterPoint.RelativeRadius = 0.03!
        Me.Clock1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Clock1.ForeColor = System.Drawing.Color.Purple
        Me.Clock1.HourHand.Color = System.Drawing.Color.Red
        Me.Clock1.HourHand.Motion = AnalogClock.HandMotion.Sweep
        Me.Clock1.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.HourHand.RelativeRadius = 0.65!
        Me.Clock1.HourHand.Width = 12.0!
        Me.Clock1.Location = New System.Drawing.Point(144, 133)
        Me.Clock1.MinuteHand.Color = System.Drawing.Color.Teal
        Me.Clock1.MinuteHand.Motion = AnalogClock.HandMotion.Sweep
        Me.Clock1.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.MinuteHand.RelativeRadius = 0.8!
        Me.Clock1.MinuteHand.Width = 12.0!
        Me.Clock1.Name = "Clock1"
        Me.Clock1.SecondHand.Motion = AnalogClock.HandMotion.Sweep
        Me.Clock1.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        Me.Clock1.SecondHand.RelativeRadius = 0.9!
        Me.Clock1.SecondHand.Width = 3.0!
        Me.Clock1.Size = New System.Drawing.Size(400, 400)
        Me.Clock1.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.Green, AnalogClock.MarkerStyle.Triangle, True, 200.0!, 4.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.Red, AnalogClock.MarkerStyle.Ring, True, 200.0!, 6.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, ""), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 200.0!, 3.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, "")}
        Me.Clock1.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, New System.Drawing.Point(1, 1), 0, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), New System.Drawing.Point(1, 1), 1, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Point(1, 1), 2, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, New System.Drawing.Point(1, 1), 3, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), New System.Drawing.Point(1, 1), 4, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Point(1, 1), 5, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, New System.Drawing.Point(1, 1), 6, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), New System.Drawing.Point(1, 1), 7, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Point(1, 1), 8, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, New System.Drawing.Point(1, 1), 9, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), New System.Drawing.Point(1, 1), 10, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, ""), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Engravers MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), New System.Drawing.Point(1, 1), 11, True, True, AnalogClock.SymbolStyle.Numeric, 200.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, "")}
        Me.Clock1.TabIndex = 0
        Me.Clock1.UpdateFrequency = 10
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(393, 712)
        Me.PropertyGrid1.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1089, 712)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analog Clock Demo - By VBDT"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents LinearGradientBrush As System.Windows.Forms.RadioButton
    Friend WithEvents HatchBrush As System.Windows.Forms.RadioButton
    Friend WithEvents SolidBrush As System.Windows.Forms.RadioButton
    Friend WithEvents GradientBrush As System.Windows.Forms.RadioButton
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Clock1 As AnalogClock.Clock

End Class
