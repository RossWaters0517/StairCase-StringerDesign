

Imports System.Globalization
Imports System.Math
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Public Class FrmStringer
    ReadOnly SaveFileDialog1 As New SaveFileDialog
    Private WithEvents PrintDocument1 As PrintDocument = New PrintDocument
    Private ReadOnly PrintDialog1 As New PrintDialog
    Private ReadOnly PageSetupDialog1 As New PageSetupDialog
    Private PrintPreview As Boolean
    Private ReadOnly PrintPreviewDialog1 As New PrintPreviewDialog
    'Defines % Of Test Drawing Area Used Within The Form.
    'Remaining Area Of The Form Are For Labeling Purposes.
    'PictureBox Covers 70% Width Of Form
    Const PlotWidthPercent As Single = 70
    '8% Of Form Left Side Reserved For Y Axis Labeling
    Const LeftPercent As Single = 8
    '22% Of Form Right Side Reserved For Controls (TexBoxes, ListBoxes and Buttons)
    Const RightPercent As Single = 22
    'PictureBox Covers 74% Height of the Form
    Const PlotHeightPercent As Single = 74
    '11% Of Form Top Reserved For Header
    Const HeaderPercent As Single = 11
    '15% Of Form Bottom Reserved For Footer & X Axis Labeling
    Const FooterPercent As Single = 15
    Const Graph_XYRatio = 10.5 / 7.5 'Graph Aspect Ratio
    Dim Mouse_InverseTransform As Matrix
    'Variables Representing Entered TextBox Values
    Dim TreadThickness As Single
    Dim TotalHeight As Single
    Dim RunPerStep As Single
    Dim TreadDepth As Single
    Dim TopMaterialThickness
    Dim RiserAngle As Single
    Public Property ToolTip1 As Object
    Private Sub FrmStringer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Startup Form Size
        Me.Height = 730
        Me.Width = 1120
        Me.CenterToScreen()
        'Specify A PrintDocument Instance For The PrintPreviewDialog Component.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.PrinterSettings = PageSetupDialog1.PrinterSettings
        PrintDocument1.DefaultPageSettings.Landscape = True
        PageSetupDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        'Set The Page Setup Dialog To The Print Document 
        'Display Users Name On Form
        LblUserName.Text = "Name: " & SystemInformation.UserName
        ''Display Date On Form
        'This Line Requires "Import System.Globalization" Declaration
        Dim date_info As DateTimeFormatInfo = CultureInfo.CurrentCulture.DateTimeFormat()
        LblDateTime.Text = "Date: " & Now.ToString(date_info.ShortDatePattern)
        'Set The Default Values For Entered Variables
        TreadThickness = CSng(Val(TxtBxTreadThickness.Text))
        TotalHeight = CSng(Val(TxtBxHeight.Text))
        RunPerStep = CSng(Val(TxtBxRunPerStep.Text))
        TreadDepth = CSng(Val(TxtBxTreadDepth.Text))
        TopMaterialThickness = CSng(Val(TxtBxTopThickness.Text))
        RiserAngle = CSng(Val(TxtBxRiserAngle.Text))
        RdoBtnFlush.Checked = True
        LoadResize() 'Make Sure Every Control Is In It's Place
    End Sub
    Private Sub FrmStringer_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Save The Current Graphics State
        Dim GraphicState As GraphicsState = e.Graphics.Save()
        Dim FrmScale_RightX As Single
        Dim FrmScale_LeftX As Single
        Dim FrmScale_BottomY As Single
        Dim FrmScale_TopY As Single
        Dim GraphScale_BottomY As Single = 0
        Dim GraphScale_LeftX As Single = 0
        Dim GraphScale_RightX As Single = Val(TxtBxHeight.Text) * Graph_XYRatio + 16 ' +16 Gives A Little Extra Floorspace For The Bottom Step
        Dim GraphScale_TopY As Single = Val(TxtBxHeight.Text) + 12 ' +12 Gives A Little Extra Headroom For The Top Step
        'Defines The Forms Custom Scale Dimensions
        Dim GraphScale_Width As Single = Abs(GraphScale_RightX- GraphScale_LeftX) 
        Dim FrmScale_Width As Single = GraphScale_Width / (PlotWidthPercent / 100)
        If GraphScale_LeftX < GraphScale_RightX Then
            FrmScale_RightX = GraphScale_RightX + (RightPercent / 100 * FrmScale_Width)
            FrmScale_LeftX = GraphScale_LeftX - (LeftPercent / 100 * FrmScale_Width)
        End If
        If GraphScale_LeftX > GraphScale_RightX Then
            FrmScale_RightX = GraphScale_RightX - (RightPercent / 100 * FrmScale_Width)
            FrmScale_LeftX = GraphScale_LeftX + (LeftPercent / 100 * FrmScale_Width)
        End If
        'Defines The Custom Scale Dimensions Inside The Graphing Area And Set The Scale   
        Dim GraphScale_Height As Single = Abs(GraphScale_TopY - GraphScale_BottomY) 
        Dim FrmScale_Height As Single = GraphScale_Height / (PlotHeightPercent / 100)
        If GraphScale_BottomY < GraphScale_TopY Then
            FrmScale_BottomY = GraphScale_BottomY - (FooterPercent / 100 * FrmScale_Height)
            FrmScale_TopY = GraphScale_TopY + (HeaderPercent / 100 * FrmScale_Height)
        End If
        If GraphScale_BottomY > GraphScale_TopY Then
            FrmScale_BottomY = GraphScale_BottomY + (FooterPercent / 100 * FrmScale_Height)
            FrmScale_TopY = GraphScale_TopY - (HeaderPercent / 100 * FrmScale_Height)
        End If
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        'Set The New Form Scale Transformation
        SetFormScale(e.Graphics, ClientSize.Width, ClientSize.Height, FrmScale_LeftX, FrmScale_RightX, FrmScale_TopY, FrmScale_BottomY)
        'Draw The Custom Scaled Graphing Area And Fill With Color
        'Use RectangleF As Properties For DrawRectangle
        Dim Graph_Rect As New RectangleF(GraphScale_LeftX, GraphScale_BottomY, GraphScale_Width, GraphScale_Height)
        e.Graphics.Clip = new Region(Graph_Rect)
        e.Graphics.SetClip(Graph_Rect)
        e.Graphics.FillRegion(Brushes.LightCyan, e.Graphics.Clip)
        Dim GraphPen As New Pen(Color.Black, 0.2)
        e.Graphics.DrawRectangle(pen:=GraphPen, Graph_Rect.Left, Graph_Rect.Top, Graph_Rect.Width, Graph_Rect.Height)
        'Using Automatically Disposes The Brush At End Using
        GraphPen.Dispose()
        '*******Define And Draw The Grid Lines Inside The Graph Area*******
        'Only Use Even Numbers For Spacing
        'If Odd Number Appears Then Add 1
        Dim GridLine_Spacing As Integer
        GridLine_Spacing = CInt(Val(TxtBxHeight.Text) / 10)
        If GridLine_Spacing Mod 2 <> 0 Then GridLine_Spacing += 1
        'Draw The X And Y Grid Lines Inside The Graphing Area
        Dim Grid_pen As Pen = New Pen(Color.Black, 0)
        For x As Integer = 0 To GraphScale_RightX Step GridLine_Spacing
            'Draw The X Grid Lines Inside The Graphing Area
            e.Graphics.DrawLine(Grid_pen, x, 0, x, CInt(GraphScale_TopY))
        Next x
        For y As Integer = 0 To GraphScale_TopY Step GridLine_Spacing
            'Draw The Y Grid Lines Inside The Graphing Area
            e.Graphics.DrawLine(Grid_pen, 0, y, CInt(GraphScale_RightX), y)
        Next y
        Grid_pen.Dispose()
        '************************************Draw The Stringer Steps*******************************
        'Variables Used For Printing Later
        Dim NumberOfSteps, NumberOfRunners, NumberOfRisers As Integer
        Dim Peaks, PeaksX_Mid, PeaksY_Mid As Single
        Dim UpperFloorX_Levels, LowerFloorX_Levels As Single
        Dim RunCut_X, RunCut_Y, RunCut_Length As Single
        Dim OverHang_X, OverHang_Y As Single
        Dim Run_X, Run_Y As Single
        Dim TreadW_X, TreadW_Y As Single
        Dim FloorCutLength, FloorAngleSin, FloorAngleTan As Single
        Dim TopOfStringerLength, TopAngleSin, TopAngleTan, TopRiserRise, TopCutLength As Single
        Dim BottomRiserRise, BottomEndPoint, BottomOfStringerLength As Single
        Dim X1, X2, X3, Y1, Y2, Y3 As Single
        Dim TreadOverhang As Single
        Dim TreadAngleOpp, TreadAngleHyp As Single
        Dim AngleRunPerStep As Single
        Dim TotalRise, RisePerStep, RiserAngleTan As Single
        Dim Steps As Integer
        Dim Valleys As Single
        'Bring All Entered Text Values To Play
        Dim FinishedHeight As Single = TotalHeight + TopMaterialThickness
        Dim TreadWidth As Single = CSng(Val(TxtBxTreadDepth.Text))
        LblTreadWidth.Text = CStr(TreadWidth)
        Dim StringerWidth As Single = CSng(Val(LblStringerWidth.Text))
        Dim Black_Pen As Pen = New Pen(Color.Black, 0.2)
        '********************************TOP STEP IS FLUSH WITH TOP LEVEL*********************
        If RdoBtnFlush.Checked Then
            NumberOfRisers = Round(FinishedHeight / 7.5)
            RisePerStep = FinishedHeight / NumberOfRisers
            If RisePerStep >= 8 Then
                If NumberOfRisers > 2 Then NumberOfRisers = NumberOfRisers + 1
                RisePerStep = FinishedHeight / NumberOfRisers
            End If
            LblNumRisers.Text = CStr(NumberOfRisers)
            NumberOfRunners = NumberOfRisers
            LblNumRunners.Text = CStr(NumberOfRunners)
            NumberOfSteps = NumberOfRisers
            LblNumSteps.Text = CStr(NumberOfSteps)
            LblFloorSpace.Text = CStr(Round(CSng(Val(TxtBxRunPerStep.Text) * NumberOfRunners), 5))
            TopRiserRise = RisePerStep - TopMaterialThickness + TreadThickness
            LblTopRiserRise.Text = CStr(Round(TopRiserRise, 6))
            BottomRiserRise = RisePerStep - TreadThickness
            LblBottomRiserRise.Text = CStr(Round(BottomRiserRise, 6))
            Select Case NumberOfRisers
                Case Is >= 3
                    LblRisePerStep.Text = CStr(Round(RisePerStep, 6))
                Case Is = 2
                    LblRisePerStep.Text = "N/A"
                Case Is = 1
                    LblRisePerStep.Text = "N/A"
                    LblTopRiserRise.Text = "N/A"
                    LblBottomRiserRise.Text = "N/A"
            End Select
            TotalRise = (RisePerStep * (NumberOfRisers - 2)) + TopRiserRise + BottomRiserRise
            LblTotalRise.Text = CStr(Round(TotalRise, 6))
            'Riser Angle > 0
            If RiserAngle <> 0 Then
                RiserAngleTan = Tan(RiserAngle / (180 / PI))
                AngleRunPerStep = RiserAngleTan * RisePerStep 'Correction For Runs With Riser Angle
                TreadAngleOpp = RiserAngleTan * TreadThickness
                TreadAngleHyp = Sqrt(TreadThickness ^ 2 + TreadAngleOpp ^ 2)
            Else
                AngleRunPerStep = 0
            End If
            'Draw The Steps
            X1 = 0
            X2 = RunPerStep
            Y1 = TotalHeight 'Start Point For Runners
            For Steps = NumberOfRisers To 1 Step -1
                Select Case Steps
                    Case Is = NumberOfRisers
                        If NumberOfRisers > 1 Then
                            Y2 = Y1 - TopRiserRise
                        Else
                            Y2 = 0
                        End If
                    Case Is = NumberOfRisers - 1
                        If NumberOfRisers > 2 Then
                            Y1 = Y2
                            Y2 = Y1 - RisePerStep
                        Else
                            Y1 = Y2
                            Y2 = Y1 - BottomRiserRise
                        End If
                    Case Is = 1
                        Y1 = Y2
                        Y2 = Y1 - BottomRiserRise
                    Case Else
                        Y1 -= RisePerStep
                        Y2 = Y1 - RisePerStep
                End Select
                Select Case RiserAngle
                    Case Is = 0
                        TreadOverhang = TreadDepth - RunPerStep
                        '***Draw The Stringer Runners***
                        e.Graphics.DrawLine(Black_Pen, X1, Y1, X2, Y1)
                        '***Draw The Tread Placed On Top Of The Runners***
                        If Steps < NumberOfRisers Then
                            If TreadDepth > 0 Then
                                'Use RectangleF As Properties For DrawRectangle
                                'DrawRectangle Only Works With Integers Unless Feed RectangleF Properties 
                                'Draw The Tread On Top Of Runners and Fill With Color
                                Dim Tread_Rect As New RectangleF(X1, Y1, (X2 + TreadOverhang) - X1, TreadThickness)
                                Dim Tread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
                                Dim TreadPen As New Pen(Color.Brown, 0)
                                e.Graphics.DrawRectangle(TreadPen, Tread_Rect.Left, Tread_Rect.Top, Tread_Rect.Width, Tread_Rect.Height)
                                e.Graphics.FillRectangle(Tread_Brush, Tread_Rect)
                                TreadPen.Dispose()
                                Tread_Brush.Dispose()
                            End If
                        End If
                        '***Draw The Stringer Risers***
                        e.Graphics.DrawLine(Black_Pen, X2, Y1, X2, Y2)
                        BottomEndPoint = X2
                    Case Is > 0
                        '***Draw Runners***
                        TreadOverhang = TreadDepth - RunPerStep
                        If X1 = 0 Then
                            e.Graphics.DrawLine(Black_Pen, X1, Y1, X2, Y1)
                        Else
                            e.Graphics.DrawLine(Black_Pen, X1 - AngleRunPerStep, Y1, X2, Y1)
                        End If
                        '***Draw Tread And Fill With Pattern And Color***
                        If Steps < NumberOfRisers Then
                            Dim TreadPts(4) As PointF
                            TreadPts(0) = New PointF(X1 - AngleRunPerStep, Y1)
                            TreadPts(1) = New PointF(X1 - (AngleRunPerStep - 0.5), Y1 + TreadThickness)
                            TreadPts(2) = New PointF(X1 + TreadOverhang + RunPerStep, Y1 + TreadThickness)
                            TreadPts(3) = New PointF(X1 + TreadOverhang + RunPerStep, Y1)
                            TreadPts(4) = New PointF(X1 - AngleRunPerStep, Y1)
                            Dim TreadPen As New Pen(Color.Brown, 0)
                            e.Graphics.DrawPolygon(TreadPen, TreadPts)
                            Dim Tread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
                            e.Graphics.FillPolygon(Tread_Brush, TreadPts)
                            Tread_Brush.Dispose()
                            TreadPen.Dispose()
                        End If
                        '***Draw Risers***
                        e.Graphics.DrawLine(Black_Pen, X2, Y1, X2 - AngleRunPerStep, Y2)
                        BottomEndPoint = X2 - AngleRunPerStep
                End Select
                'Draw Reference Lines For Run Per Step And Tread Width
                'Draw Dot/Dash Lines For Tread Width Example On Graph
                Dim RedPen As Pen = New Pen(Color.Red, 0.2) With {
                    .DashStyle = DashStyle.DashDotDot
                }
                Select Case Steps
                    Case = NumberOfSteps - 1
                        If Y2 - X1 >= 0 Then
                            e.Graphics.DrawLine(RedPen, X1, TotalHeight, X1, Y2 - (X1 - 3))
                            e.Graphics.DrawLine(RedPen, X2, Y1, X2, Y2 - X1)
                            'Used Later For Labeling
                            Run_X = X1 : Run_Y = Y2 - (X1 - 3)

                            If RiserAngle > 0 Then
                                e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, Y2 - X1)
                                'Used Later For Labeling
                                RunCut_X = X1 - AngleRunPerStep : RunCut_Y = Y2 - X1
                            End If
                        Else
                            e.Graphics.DrawLine(RedPen, X1, Y1, X1, 0)
                            e.Graphics.DrawLine(RedPen, X2, Y2, X2, 0)
                            If RiserAngle > 0 Then
                                e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, 0)
                            End If
                        End If
                    Case = 1
                        e.Graphics.DrawLine(RedPen, X2, Y1, X2, Y1 + RisePerStep)
                        e.Graphics.DrawLine(RedPen, X2 + TreadOverhang, Y1, X2 + TreadOverhang, Y1 + RisePerStep * 2)
                        OverHang_X = X2 + TreadOverhang : OverHang_Y = Y1 + RisePerStep
                        If RiserAngle > 0 Then
                            e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, Y1 + RisePerStep * 2)
                            TreadW_X = X1 - AngleRunPerStep : TreadW_Y = (Y1 + RisePerStep * 2)

                        Else
                            TreadW_X = X1 : TreadW_Y = (Y1 + RisePerStep * 2)
                        End If
                End Select
                RedPen.Dispose()
                'Set Variables For Next Step
                X1 += RunPerStep
                If Steps > 1 Then X2 = X1 + RunPerStep
                If Steps = Abs(1 - NumberOfRisers) Then PeaksX_Mid = (X1 + X2) * 0.5 : PeaksY_Mid = (Y1 + Y2) * 0.5 'X,Y Values For Peak Label
                If Steps = NumberOfRisers Then
                    UpperFloorX_Levels = X1 + (0.5 * RunPerStep) : LowerFloorX_Levels = X1 - (0.5 * RunPerStep)  'X Value For Floor Level Labels
                End If
            Next Steps
            'Draw The Top Floor Finish Material
            'Top Tread Has Adjustable Thickness So Is Different
            Dim TopTread_Rect As New RectangleF(0, TotalHeight, (RunPerStep + TreadOverhang), TopMaterialThickness)
            Dim TopTreadPen As New Pen(Color.Brown, 0)
            Dim TopTread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
            e.Graphics.DrawRectangle(TopTreadPen, TopTread_Rect.Left, TopTread_Rect.Top, TopTread_Rect.Width, TopTread_Rect.Height)
            e.Graphics.FillRectangle(TopTread_Brush, TopTread_Rect)
            TopTreadPen.Dispose()
            TopTread_Brush.Dispose()
        Else
            '************************TOP STEP IS ONE STEP DOWN FROM TOP FLOOR*****************************
            NumberOfSteps = Round(FinishedHeight / 7.5)
            RisePerStep = FinishedHeight / NumberOfSteps
            LblNumSteps.Text = CStr(NumberOfSteps)
            NumberOfRunners = NumberOfSteps - 1
            LblNumRunners.Text = CStr(NumberOfRunners)
            NumberOfRisers = NumberOfSteps - 1
            LblNumRisers.Text = CStr(NumberOfRisers)
            LblFloorSpace.Text = CStr(Round(CSng(Val(TxtBxRunPerStep.Text) * NumberOfRunners), 5))
            TopRiserRise = RisePerStep - TopMaterialThickness + TreadThickness
            LblTopRiserRise.Text = CStr(TopRiserRise)
            BottomRiserRise = RisePerStep - TreadThickness
            LblBottomRiserRise.Text = CStr(Round(BottomRiserRise, 5))
            Select Case NumberOfSteps
                Case Is >= 3
                    LblRisePerStep.Text = CStr(Round(RisePerStep, 5))
                Case Is = 2
                    LblRisePerStep.Text = "N/A"
                Case Is = 1
                    LblRisePerStep.Text = "N/A"
                    LblTopRiserRise.Text = "N/A"
                    LblBottomRiserRise.Text = "N/A"
            End Select
            TotalRise = (RisePerStep * (NumberOfRisers - 1)) + BottomRiserRise
            LblTotalRise.Text = CStr(Round(TotalRise, 6))
            'Riser Angle > 0
            If RiserAngle <> 0 Then
                RiserAngleTan = Tan(RiserAngle / (180 / PI))
                AngleRunPerStep = RiserAngleTan * RisePerStep 'Correction For Runs With Riser Angle
                TreadAngleOpp = RiserAngleTan * TreadThickness
                TreadAngleHyp = Sqrt(TreadThickness ^ 2 + TreadAngleOpp ^ 2)
            Else
                AngleRunPerStep = 0
            End If
            TreadOverhang = TreadDepth - RunPerStep
            X1 = 0
            X2 = RunPerStep
            Y1 = FinishedHeight - RisePerStep - TreadThickness 'Start Point For Runners, Start One Step Down
            'Draw The Steps
            For Steps = NumberOfRisers To 1 Step -1
                Select Case Steps
                    Case Is = NumberOfRisers
                        If NumberOfRisers > 1 Then
                            Y2 = Y1 - RisePerStep
                        Else
                            Y2 = 0
                        End If
                    Case Is = NumberOfRisers - 1
                        If NumberOfRisers > 2 Then
                            Y1 = Y2
                            Y2 = Y1 - RisePerStep
                        Else
                            Y1 = Y2
                            Y2 = Y1 - BottomRiserRise
                        End If
                    Case Is = 1
                        Y1 = Y2
                        Y2 = Y1 - BottomRiserRise
                    Case Else
                        Y1 -= RisePerStep
                        Y2 = Y1 - RisePerStep
                End Select
                Select Case RiserAngle
                    Case Is = 0
                        '***Draw The Stringer Runners***
                        e.Graphics.DrawLine(Black_Pen, X1, Y1, X2, Y1)
                        '***Draw The Tread Placed On Top Of The Runners***
                        If TreadDepth > 0 Then
                            'Draw The Tread On Top Of Runners and Fill With Color
                            Dim Tread_Rect As New RectangleF(X1, Y1, (X2 + TreadOverhang) - X1, TreadThickness)
                            Dim Tread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
                            Dim TreadPen As New Pen(Color.Brown, 0)
                            e.Graphics.DrawRectangle(TreadPen, Tread_Rect.Left, Tread_Rect.Top, Tread_Rect.Width, Tread_Rect.Height)
                            e.Graphics.FillRectangle(Tread_Brush, Tread_Rect)
                            TreadPen.Dispose()
                            Tread_Brush.Dispose()
                        End If
                        '***Draw The Stringer Risers***
                        e.Graphics.DrawLine(Black_Pen, X2, Y1, X2, Y2)
                        BottomEndPoint = X2
                    Case Is > 0
                        '***Draw Runners***
                        If Steps = NumberOfRisers Then
                            e.Graphics.DrawLine(Black_Pen, X1, Y1, X2, Y1)
                        Else
                            e.Graphics.DrawLine(Black_Pen, X1 - AngleRunPerStep, Y1, X2, Y1)
                        End If
                        '***Draw Tread And Fill With Pattern And Color***
                        If Steps < NumberOfRisers Then
                            Dim TreadPts(4) As PointF
                            TreadPts(0) = New PointF(X1 - AngleRunPerStep, Y1)
                            TreadPts(1) = New PointF(X1 - (AngleRunPerStep - 0.5), Y1 + TreadThickness)
                            TreadPts(2) = New PointF(X1 + TreadOverhang + RunPerStep, Y1 + TreadThickness)
                            TreadPts(3) = New PointF(X1 + TreadOverhang + RunPerStep, Y1)
                            TreadPts(4) = New PointF(X1 - AngleRunPerStep, Y1)
                            Dim TreadPen As New Pen(Color.Brown, 0)
                            e.Graphics.DrawPolygon(TreadPen, TreadPts)
                            Dim Tread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
                            e.Graphics.FillPolygon(Tread_Brush, TreadPts)
                            Tread_Brush.Dispose()
                            TreadPen.Dispose()
                        Else
                            'Use RectangleF As Properties For DrawRectangle
                            'Draw The Tread On Top Of Runners And Fill With Color
                            Dim Tread_Rect As New RectangleF(0, Y1, (X2 + TreadOverhang) - X1, TreadThickness)
                            Dim TreadPen As New Pen(Color.Brown, 0)
                            Dim Tread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
                            e.Graphics.DrawRectangle(TreadPen, Tread_Rect.Left, Tread_Rect.Top, Tread_Rect.Width, Tread_Rect.Height)
                            e.Graphics.FillRectangle(Tread_Brush, Tread_Rect)
                            Tread_Brush.Dispose()
                            TreadPen.Dispose()
                        End If
                        '***Draw Risers***
                        e.Graphics.DrawLine(Black_Pen, X2, Y1, X2 - AngleRunPerStep, Y2)
                        BottomEndPoint = X2 - AngleRunPerStep
                End Select
                'Draw Reference Lines For Run Per Step And Tread Width
                'Draw Dot/Dash Lines For Tread Width Example On Graph
                Dim RedPen As Pen = New Pen(Color.Red, 0.2)
                RedPen.DashStyle = DashStyle.DashDotDot
                Select Case Steps
                    Case = NumberOfSteps - 2
                        If Y2 - X1 >= 0 Then
                            e.Graphics.DrawLine(RedPen, X1, Y1 + RisePerStep, X1, Y2 - (X1 - 3))
                            e.Graphics.DrawLine(RedPen, X2, Y1, X2, Y2 - X1)
                            'Used Later For Labeling
                            Run_X = X1 : Run_Y = Y2 - (X1 - 3)

                            If RiserAngle > 0 Then
                                e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, Y2 - X1)
                                'Used Later For Labeling
                                RunCut_X = X1 - AngleRunPerStep : RunCut_Y = Y2 - X1
                            End If
                        Else
                            e.Graphics.DrawLine(RedPen, X1, Y1, X1, 0)
                            e.Graphics.DrawLine(RedPen, X2, Y2, X2, 0)
                            If RiserAngle > 0 Then
                                e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, 0)
                            End If
                        End If
                    Case = 1
                        e.Graphics.DrawLine(RedPen, X2, Y1, X2, Y1 + RisePerStep)
                        e.Graphics.DrawLine(RedPen, X2 + TreadOverhang, Y1, X2 + TreadOverhang, Y1 + RisePerStep * 2)
                        OverHang_X = X2 + TreadOverhang : OverHang_Y = Y1 + RisePerStep
                        If RiserAngle > 0 Then
                            e.Graphics.DrawLine(RedPen, X1 - AngleRunPerStep, Y1, X1 - AngleRunPerStep, Y1 + RisePerStep * 2)
                            TreadW_X = X1 - AngleRunPerStep : TreadW_Y = (Y1 + RisePerStep * 2)

                        Else
                            TreadW_X = X1 : TreadW_Y = (Y1 + RisePerStep * 2)
                        End If
                End Select
                RedPen.Dispose()
                X1 += RunPerStep
                If Steps > 1 Then X2 = X1 + RunPerStep
                If Steps = Abs(NumberOfRisers) Then PeaksX_Mid = (X1 + X2) * 0.5 : PeaksY_Mid = (Y1 + Y2) * 0.5 'X,Y Values For Peak Label
                If Steps = NumberOfRisers Then
                    UpperFloorX_Levels = X1 + (0.5 * RunPerStep) : LowerFloorX_Levels = X1 - (0.5 * RunPerStep) 'X Value For Floor Level Labels
                End If
            Next Steps
            'Draw The Top Floor Finish Material
            'Top Tread Has Adjustable Thickness So Is Different
            Dim TopTread_Rect As New RectangleF(0, TotalHeight, TreadOverhang, TopMaterialThickness)
            Dim TopTreadPen As New Pen(Color.Brown, 0)
            Dim TopTread_Brush As New HatchBrush(HatchStyle.DiagonalBrick, Color.Black, Color.Orange)
            e.Graphics.DrawRectangle(TopTreadPen, TopTread_Rect.Left, TopTread_Rect.Top, TopTread_Rect.Width, TopTread_Rect.Height)
            e.Graphics.FillRectangle(TopTread_Brush, TopTread_Rect)
            TopTreadPen.Dispose()
            Black_Pen.Dispose()
            TopTread_Brush.Dispose()
        End If
        '**********************************CODE COMMON TO BOTH BTNFLUSH AND BTNDOWN************************
        Dim Brown_Pen As Pen = New Pen(Color.Brown, 0.2)
        TxtBxTreadDepth.Text = CStr(TreadDepth)
        '***Draw The Top Sub-Floor Level***
        e.Graphics.DrawLine(Brown_Pen, GraphScale_LeftX, TotalHeight, GraphScale_RightX, TotalHeight)
        '***Stringer Material Length***
        Brown_Pen.DashStyle = DashStyle.DashDotDot
        e.Graphics.DrawLine(Brown_Pen, 0, (TotalRise), BottomEndPoint, 0)
        LblRunCutLength.Text = CStr(RunPerStep + AngleRunPerStep)
        RunCut_Length = CSng(LblRunCutLength.Text)
        LblTreadWidth.Text = LblRunCutLength.Text + TreadOverhang
        TreadWidth = Val(LblTreadWidth.Text)
        LblStringerLength.Text = CStr(Round(Sqrt(TotalRise ^ 2 + BottomEndPoint ^ 2) / 12, 5)) 'Minimum Length Of Stringer Material Required.
        '***Staircase Angle (Bottom) Referenced To Floor***
        '1 Radian = 180/pi Degrees
        LblStairAngle.Text = CStr(Round(CSng((180 / PI) * (Atan(RisePerStep / RunPerStep))), 5)) 'Angle Of StairCase
        '***Peaks For RisePerStep ***
        Peaks = Sqrt(RisePerStep ^ 2 + RunPerStep ^ 2) 'Hyp
        LblPeaksValleys.Text = CStr(Peaks) 'Peaks And Valleys For All Steps Except Bottom Step
        '***Valley For Only Bottom Step ***
        FloorAngleTan = RisePerStep / RunPerStep
        X1 = X2 + (BottomRiserRise / FloorAngleTan)
        Valleys = Sqrt(BottomRiserRise ^ 2 + (X1 - X2) ^ 2) 'Hyp
        '***Floor Cut Length And Angle***
        FloorAngleSin = RisePerStep / Peaks
        FloorCutLength = StringerWidth / FloorAngleSin
        X3 = X1 - FloorCutLength
        LblBottomCut.Text = CStr(Round(Val(90 - (180 / PI) * (Atan(RisePerStep / RunPerStep))), 5)) 'Cut Angle At Stringer Bottom Against Floor
        e.Graphics.DrawLine(Brown_Pen, X1, 0, X3, 0)
        '***Bottom Of Stringer (Solid Line)***
        Brown_Pen.DashStyle = DashStyle.Solid
        Y1 = FloorAngleTan * X3
        e.Graphics.DrawLine(Brown_Pen, X3, 0, 0, Y1)
        BottomOfStringerLength = Sqrt(Y1 ^ 2 + X3 ^ 2)
        '***Staircase Angle (Top) Referenced To Vertical Wall***
        TopAngleTan = RunPerStep / RisePerStep
        '***Top Cut Length And Angle***
        Brown_Pen.DashStyle = DashStyle.DashDotDot
        TopAngleSin = RunPerStep / Peaks
        TopCutLength = StringerWidth / TopAngleSin
        LblTopCut.Text = LblStairAngle.Text 'Cut Angle At Top Of Stringer Against Wall
        If Y1 >= 0 Then e.Graphics.DrawLine(Brown_Pen, 0, Y1, 0, Y1 + TopCutLength)
        '***Top Of Stringer (Dotted Line)***
        Y3 = Y1 + TopCutLength
        e.Graphics.DrawLine(Brown_Pen, 0, Y3, X1, 0) 'Draw The Dotted Top Cut Line
        TopOfStringerLength = Sqrt(Y3 ^ 2 + X1 ^ 2) 'Not Used
        Brown_Pen.Dispose()
        'Display The Mouse Transform Coordinances
        'On The Mouse Label
        e.Graphics.Restore(GraphicState)
        '****************************END OF DRAWing THE STRINGERS*****************************
        '****************LABELING EVERYTHING INSIDE AND OUTSIDE THE GRAPH AREA****************
        'Draw The X Grid Lines Labels Outside The Graphing Area
        Dim Font_Format As New StringFormat
        Font_Format.LineAlignment = StringAlignment.Center
        Font_Format.Alignment = StringAlignment.Center
        Font_Format.FormatFlags = StringFormatFlags.DirectionRightToLeft
        Dim X_Pointx As Single
        Dim Y_Pointx As Single
        Dim Label_font As New Font(New FontFamily("Times New Roman"), 12, FontStyle.Regular)
        'Draw TheX Grid Line Labels Outside The Graph Area
        For x As Integer = 0 To GraphScale_RightX Step GridLine_Spacing
            'Translate The Custom Scale Point To The Original Form Scale Point
            X_Pointx = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, x)
            Y_Pointx = ClientSize.Height - (ClientSize.Height * 0.105)
            e.Graphics.DrawString(x, Label_font, Brushes.Black, X_Pointx, Y_Pointx, Font_Format)
        Next x
        'Draw The Y Grid Line Labels Outside The Graph Area
        'The Form And Graph Y axis Are An Inverted Ratio
        Dim X_Pointy As Single
        Dim Y_Pointy As Single
        Dim Y_InvertedRatio As Single = ClientSize.Height / FrmScale_Height
        For y As Integer = 0 To GraphScale_TopY Step GridLine_Spacing
            X_Pointy = ClientSize.Width - (ClientSize.Width * 0.94)
            Y_Pointy = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, y)
            e.Graphics.DrawString(y, Label_font, Brushes.Black, X_Pointy, Y_Pointy, Font_Format)
        Next y
        Label_font.Dispose()
        Dim Font_Size As Single

        Select Case GridLine_Spacing
            Case 2
                Font_Size = 8
            Case 4, 6
                Font_Size = 10
            Case 8, 10
                Font_Size = 9
            Case 12, 14
                Font_Size = 8
            Case 16
                Font_Size = 6
        End Select
        Dim Caption_font As New Font(New FontFamily("Times New Roman"), Font_Size, FontStyle.Regular)
        'Draw Caption For Upper Level Sub-Floor
        Font_Format.LineAlignment = StringAlignment.Far
        Font_Format.Alignment = StringAlignment.Far
        Y1 = TotalHeight + GridLine_Spacing / 4.5
        UpperFloorX_Levels = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, UpperFloorX_Levels)
        Y_Pointy = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, Y1)
        e.Graphics.DrawString("Upper Level Sub-Floor = " & TotalHeight & " inches", Caption_font, Brushes.Black, UpperFloorX_Levels, Y_Pointy, Font_Format)
        'Draw Caption For Lower Level Floor
        Y1 = GridLine_Spacing / 4.5
        LowerFloorX_Levels = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, LowerFloorX_Levels)
        Y_Pointy = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, Y1)
        e.Graphics.DrawString("Lower Level Floor", Caption_font, Brushes.Black, LowerFloorX_Levels, Y_Pointy, Font_Format)
        'Draw Caption For Distance Between Peaks
        'Translate The Custom Scale Point To The Original Form Scale Point
        Font_Format.LineAlignment = StringAlignment.Far
        Font_Format.Alignment = StringAlignment.Far
        PeaksX_Mid = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, PeaksX_Mid)
        PeaksY_Mid = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, PeaksY_Mid)
        e.Graphics.DrawString("Peak Spacing = " & Round(Peaks, 3) & " in", Caption_font, Brushes.Black, PeaksX_Mid, PeaksY_Mid, Font_Format)
        'Draw Caption For RunPerStep
        'Run_X = X1 : Run_Y = Y2 - (X1 - 3)
        Run_X = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, Run_X)
        Run_Y = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, Run_Y)
        e.Graphics.DrawString("Runs = " & RunPerStep & " in", Caption_font, Brushes.Black, Run_X, Run_Y + 20, Font_Format)
        If RiserAngle > 0 Then
            'Draw Caption For Runner Cut Length
            'RunCut_X = X1 - AngleRunPerStep : RunCut_Y = Y2 - X1
            RunCut_X = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, RunCut_X)
            RunCut_Y = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, RunCut_Y)
            e.Graphics.DrawString("Run Cut Length = " & Round(RunCut_Length, 3) & " in", Caption_font, Brushes.Black, RunCut_X - 10, RunCut_Y + 20, Font_Format)
            'Draw Caption For Tread Width
            'TreadW_X = X1 - AngleRunPerStep : TreadW_Y = (Y1 + RisePerStep * 2)
            TreadW_X = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, TreadW_X)
            TreadW_Y = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, TreadW_Y)
            e.Graphics.DrawString("Tread Width = " & Round(TreadWidth, 4) & " in", Caption_font, Brushes.Black, TreadW_X + 5, TreadW_Y + 5, Font_Format)
        End If
        'Draw Caption For Tread Overhang
        'OverHang_X = X2 + TreadOverhang : OverHang_Y = Y1 + RisePerStep
        OverHang_X = GetClientPt(0, ClientSize.Width, FrmScale_LeftX, FrmScale_Width, OverHang_X)
        OverHang_Y = GetClientPt(0, ClientSize.Height, FrmScale_BottomY, FrmScale_Height, OverHang_Y)
        e.Graphics.DrawString("Overhang = " & TreadOverhang & " in", Caption_font, Brushes.Black, OverHang_X, OverHang_Y + 10, Font_Format)
        'Draw Caption For Tread Overhang
        'TreadW_X = X1 - AngleRunPerStep : TreadW_Y = (Y1 + RisePerStep * 2)
        Caption_font.Dispose()
        Font_Format.Dispose()
        e.Graphics.Dispose()
    End Sub
    Private Sub FrmStringer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LoadResize()
    End Sub
    Private Sub PicVerTxt_Paint(sender As Object, e As PaintEventArgs) Handles PicVerTxt.Paint
        'Allign Text to Center of PictureBox.
        Dim string_format As New StringFormat
        string_format.Alignment = StringAlignment.Center
        string_format.LineAlignment = StringAlignment.Center
        ' Save the current graphics state.
        Dim GraphicState As GraphicsState = e.Graphics.Save()
        'Text String To Draw
        Dim TxtToDraw = "Distance To Top Landing (Inches)"
        'Rotate Font 270 Degrees Clockwise (Draw Upward)
        Dim TxtAngle As Integer = 270
        e.Graphics.RotateTransform(TxtAngle)
        'Point To Center Of Picturebox Drawing Area
        e.Graphics.TranslateTransform(PicVerTxt.ClientSize.Width / 2, PicVerTxt.ClientSize.Height / 2, MatrixOrder.Append)
        'Draw The Text
        'Match Font With Other Label (LblFooter) and Draw The Text
        e.Graphics.DrawString(TxtToDraw, LblFooter.Font, Brushes.Red, 0, 0, string_format)
        'Restore Graphic State To Original
        string_format.Dispose()
        e.Graphics.Restore(GraphicState)
    End Sub
    Private Sub LoadResize()
        'Place The Header & Footer On Form and Keep Centered With Graphing Area
        LblHeader.Left = Width * 0.19 'Around 21% From Form Left
        LblHeader.Top = 0.1 * LblHeader.Height
        LblFooter.Width = LblHeader.Width
        LblFooter.Left = LblHeader.Left
        LblFooter.Top = Height - 3 * LblFooter.Height
        LblFooter.Height = 30
        'Resize the Vertical Text PictureBox (PicVetTxt) When Resizing The Form.
        'Maintain Vertical Text PictureBox Height Referenced to Form
        'Picture Box Height = 25% Of The Form Height
        PicVerTxt.Height = Height / 2
        PicVerTxt.Top = (0.215 * Height)
        PicVerTxt.Width = LblFooter.Height

        LblMouseMove.Left = ClientSize.Width * 0.63
        LblMouseMove.Top = ClientSize.Height * 0.07
        'Vertical Text PictureBox Needs New Paint Event Because Text is Drawn By Graphics 
        PicVerTxt.Refresh()
        GBTopPosition.Left = Width * (1 - ((RightPercent / 100) - 0.015))
        GBRisers.Left = GBTopPosition.Left
        GBRunners.Left = GBTopPosition.Left
        GBAngles.Left = GBTopPosition.Left
        Me.Refresh()
    End Sub
    Private Sub SetFormScale(eR As Graphics, eR_width As Integer, eR_height As Integer,
         X_Left As Single, X_Right As Single, Y_Top As Single, Y_Bottom As Single)
        'Reset The Graphics Transform
        eR.ResetTransform()
        'Scale The Forms Dimensions To Accomidate Graph Dimensions
        'Map These New Dimensions To The Forms Width And Height
        eR.ScaleTransform(eR_width / (X_Right - X_Left), eR_height / (Y_Bottom - Y_Top))
        Dim bounds As RectangleF = eR.ClipBounds
        'Translate X,Y Origins To The Form
        eR.TranslateTransform(-X_Left, -Y_Top)
        Mouse_InverseTransform = eR.Transform
        Mouse_InverseTransform.Invert()
    End Sub
    Private Sub TxtBxHeight_MouseHover(sender As Object, e As EventArgs) Handles TxtBxHeight.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxHeight, "Sets The Height Between Lower Landing And Upper Landing." & vbCrLf &
                                         "Allowable Values Are Minimum Of 15 inches And Maximum Of" & vbCrLf &
                                         "350 inches. A Value of 350 Represents Approximately 46 Steps.")

    End Sub
    Private Sub TxtBxTopThickness_MouseHover(sender As Object, e As EventArgs) Handles TxtBxTopThickness.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxTopThickness, "Sets Top Tread Thickness, Determines The Top Riser Height.")
    End Sub
    Private Sub RdoBtnFlush_MouseHover(sender As Object, e As EventArgs) Handles RdoBtnFlush.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(RdoBtnFlush, "Sets The Stringer Top Riser Flush With The Top Unfinished Floor.")
    End Sub
    Private Sub RdoBtnDown_MouseHover(sender As Object, e As EventArgs) Handles RdoBtnDown.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(RdoBtnDown, "Sets The Stringer Top Riser Down 1 Step From Top Unfinished Floor.")
    End Sub
    Private Sub TxtBxRunPerStep_MouseHover(sender As Object, e As EventArgs) Handles TxtBxRunPerStep.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxRunPerStep, "Sets The Depth Of The Runners For All Steps." & vbCrLf &
                                             "I.R.C. Specifications Requires A Minimum Of" & vbCrLf &
                                             "10 inches And A Maximum Of 10.375 Inches.")

    End Sub
    Private Sub TxtBxTreadDepth_MouseHover(sender As Object, e As EventArgs) Handles TxtBxTreadDepth.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxTreadDepth, ("Tread Depth = Run Per Step (" & TxtBxRunPerStep.Text) & ")" & " + Overhang. Exceptable" & vbCrLf &
                                             "Values For Tread Overhang Of Runners Are A Minimum Of 0.5" & vbCrLf &
                                             "inches And Maximum Of 1.75 inches Per  I.R.C. Specifications.")
    End Sub
    Private Sub TxtBxTreadThickness_MouseHover(sender As Object, e As EventArgs) Handles TxtBxTreadThickness.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxTreadThickness, "Sets And Displays Finished Tread Thickness On Runners.")
    End Sub
    Private Sub TxtBxRiserAngle_MouseHover(sender As Object, e As EventArgs) Handles TxtBxRiserAngle.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(TxtBxRiserAngle, "Sets And Displays The Riser Toe Kick Angle For All Risers." & vbCrLf &
                                             "I.R.C. Specifications Require A Maximum Value Of " & vbCrLf &
                                             "30 Degrees And A Minumem Value Of Zero Degrees.")
    End Sub
    Private Sub TxtBxHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxHeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxHeight.Text) < 15 Or Val(TxtBxHeight.Text) > 150 Then
                MessageBox.Show("Entered Values Cannot Be Below 15 And Above 150." & vbCrLf &
                                "Any Value Less Then 15 Is Only 1 Step and The" & vbCrLf &
                                "Value of 150 Represents Approximately 20 Steps.",
                "Critical Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxHeight.Text = ""
                TxtBxHeight.Refresh()
                TxtBxHeight.Focus()
                Exit Sub
            End If
            TotalHeight = Val(TxtBxHeight.Text)
            Me.Refresh()
        End If
    End Sub
    Private Sub TxtBxTreadThickness_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxTreadThickness.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxTreadThickness.Text) = 0 Or Val(TxtBxTreadThickness.Text) > 2 Then
                MessageBox.Show("Entered Values Cannot Be 0 or Above 2." & vbCrLf &
                                "Normal Values Usually Range From 3/8 In. To 1 in.",
                "Please Try Again!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxTreadThickness.Text = ""
                TxtBxTreadThickness.Refresh()
                TxtBxTreadThickness.Focus()
                Exit Sub
            End If
            TreadThickness = Val(TxtBxTreadThickness.Text)
            Me.Refresh()
        End If
    End Sub
    Private Sub TxtBxRunPerStep_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxRunPerStep.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxRunPerStep.Text) < 10 Or Val(TxtBxRunPerStep.Text) > 10.375 Then
                MessageBox.Show("Entered Values Cannot Be Below 10 or" & vbCrLf &
                                "Above 10.375 Per I.R.C. Specifications.",
                "Please Try Again!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxRunPerStep.Text = ""
                TxtBxRunPerStep.Refresh()
                TxtBxRunPerStep.Focus()
                Exit Sub
            End If
            RunPerStep = Val(TxtBxRunPerStep.Text)
            Me.Refresh()
        End If
    End Sub
    Private Sub TxtBxTreadDepth_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxTreadDepth.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxTreadDepth.Text) < Val((TxtBxRunPerStep.Text) + 0.5) Or Val(TxtBxTreadDepth.Text) > Val((TxtBxRunPerStep.Text) + 1.75) Then
                MessageBox.Show("Entered Values For Tread Overhang Of Runners Is" & vbCrLf &
                                "A Minimum Of 0.5 inches And Maximum Of 1.75 inches." & vbCrLf &
                                "I.R.C. Specifications Require A Minimum Of 0.75 inches." & vbCrLf &
                                "A Maximum Of 1.25 inches.",
                "Please Try Again!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxTreadDepth.Text = ""
                TxtBxTreadDepth.Refresh()
                TxtBxTreadDepth.Focus()
                Exit Sub
            End If
            TreadDepth = Val(TxtBxTreadDepth.Text)
            Me.Refresh()
        End If
    End Sub
    Private Sub TxtBxRiserAngle_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxRiserAngle.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxRiserAngle.Text) > 30 Then
                MessageBox.Show("Entered Values Cannot Be Above 30 Degrees" & vbCrLf &
                                "Per I.R.C. Specifications.",
                "Please Try Again!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxRiserAngle.Text = ""
                TxtBxRiserAngle.Refresh()
                TxtBxRiserAngle.Focus()
                Exit Sub
            End If
            RiserAngle = Val(TxtBxRiserAngle.Text)
            TxtBxRiserAngle.Refresh()
            Me.Refresh()
        End If
    End Sub
    Private Sub TxtBxTopThickness_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBxTopThickness.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtBxTopThickness.Text) = 0 Or Val(TxtBxTopThickness.Text) > 2 Then
                MessageBox.Show("Entered Values Cannot Be 0 or Above 2." & vbCrLf &
                                "The Top Tread Thickness Determines The" & vbCrLf &
                                "Placement Of Top Riser Position. Normal" & vbCrLf &
                                "Values Usually Range From 3/8 In. To 1 in.",
                "Please Try Again!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                TxtBxTopThickness.Text = ""
                TxtBxTopThickness.Refresh()
                TxtBxTopThickness.Focus()
                Exit Sub
            End If
            TopMaterialThickness = Val(TxtBxTopThickness.Text)
            Me.Refresh()
        End If
    End Sub
    Private Sub FrmStringer_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'If Mouse Moves Before Paint Event Finishes Then Exit Sub
        'Because Mouse_InverseTransform.TransformPoints() Not Defined
        If Mouse_InverseTransform Is Nothing Then Exit Sub
        'Apply The Inverted Transformation To The Point.
        'Get Mouse Position Inside Custom Scaled Object
        Dim new_pos() As PointF = {New PointF(e.X, e.Y)}
        Mouse_InverseTransform.TransformPoints(new_pos)
        Dim BottomY As Single = 0
        Dim LeftX As Single = 0
        Dim RightX As Single = Val(TxtBxHeight.Text) * Graph_XYRatio + 16 ' +16 Gives A Little Extra Floorspace For The Bottom Step
        Dim TopY As Single = Val(TxtBxHeight.Text) + 12 ' +12 Gives A Little Extra Headroom For The Top Step
        'Retrieves The Individual Mouse Pointer Positions
        Dim X As Single = new_pos.GetValue(0).X
        Dim Y As Single = new_pos.GetValue(0).Y
        If X > RightX Or X < LeftX Or Y > TopY Or Y < BottomY Then Exit Sub
        LblMouseMove.Text = "L = " & new_pos(0).X.ToString("0.0") & " inches  -  H = " & new_pos(0).Y.ToString("0.0") & " inches"
    End Sub
    Private Sub LblRisePerStep_MouseHover(sender As Object, e As EventArgs) Handles LblRisePerStep.MouseHover
        'Force the ToolTip text to be displayed whether Or Not the form Is active.
        ToolTip1 = New ToolTip With {.InitialDelay = 500, .ReshowDelay = 250, .ShowAlways = True}
        'Set up the ToolTip text for the Object.
        ToolTip1.SetToolTip(LblRisePerStep, "I.R.C. Specifications Require A Maximum Riser Height" & vbCrLf &
                                            "Of 7.75 inches And A Minimum Height Of 7.375 inches.")
    End Sub
    Function GetClientPt(ClientStartPt As Single, ClientEndPt As Single, ScaleStartPt As Single, ScaleEndPt As Single, PtToFind As Single) As Single
        'This Functions Return The Posiition Of The Client Object To Any Given Scaled Position On The Object 
        Dim ThisPoint As Single
        Dim ScaleSize As Single
        If ScaleStartPt < 0 Then
            ScaleSize = ScaleEndPt
        Else
            ScaleSize = Abs(ScaleStartPt) + ScaleEndPt
        End If
        Dim SysSize As Single = Abs(ClientStartPt) + ClientEndPt ' Client Should Always Be Positive Numbers
        Dim K_Factor As Single = SysSize / ScaleSize
        If SysSize = ClientSize.Height Then
            ThisPoint = Abs(((PtToFind + Abs(ScaleStartPt)) * K_Factor) - SysSize)
        Else 'ClientSize.Width
            ThisPoint = ClientStartPt - (K_Factor * (ScaleStartPt - PtToFind))
        End If
        GetClientPt = ThisPoint
    End Function
    Private Sub RdoBtnFlush_Click(sender As Object, e As EventArgs) Handles RdoBtnFlush.Click
        Me.Refresh()
    End Sub
    Private Sub RdoBtnDown_Click(sender As Object, e As EventArgs) Handles RdoBtnDown.Click
        Me.Refresh()
    End Sub
    Private Sub SaveAsJPEGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsJPEGToolStripMenuItem.Click
        Dim frmleft As Point = Bounds.Location
        Dim MyImage As New Bitmap(Bounds.Width - 10, Bounds.Height - 5)
        Dim graph = Graphics.FromImage(MyImage)
        Dim screenx As Integer = frmleft.X + 5
        Dim screeny As Integer = frmleft.Y
        graph.CopyFromScreen(screenx, screeny, 0, 0, MyImage.Size)
        Dim aPath As String = Application.StartupPath()
        Dim saveFileDialog1 As New SaveFileDialog With {
            .InitialDirectory = aPath,
            .Title = "Save As .jpg File",
            .CheckFileExists = False,
            .CheckPathExists = True,
            .DefaultExt = "jpg",
            .Filter = "JPEG File | *.jpg",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }
        Try
            If (saveFileDialog1.ShowDialog() = DialogResult.OK) Then
                MyImage.Save(saveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Create A Bitmap Sized To The Form
        Using MyImage As Bitmap = New Bitmap(Width, Height)
            'Draw The Bitmap To The Form
            Dim rect As New Rectangle(0, 0, Width, Height)
            DrawToBitmap(MyImage, rect)
            'Fit Bitmap To Page And Center
            Dim mLeft, mTop, mWidth, mHeight As Integer
            Dim ratio As Single = MyImage.Width / MyImage.Height
            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
                mWidth = e.MarginBounds.Width
                mHeight = CInt(mWidth / ratio)
                mTop = CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - (mHeight / 2))
                mLeft = e.MarginBounds.Left
            Else
                mHeight = e.MarginBounds.Height
                mWidth = CInt(mHeight * ratio)
                mLeft = CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (mWidth / 2))
                mTop = e.MarginBounds.Top
            End If
            If PrintPreview Then 'Position PrintPreviewDialog1.Location
                Dim DialogSize = PrintPreviewDialog1.PrintPreviewControl.Size
                Dim CenterscreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width / 2
                Dim CenterscreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height / 2
                PrintPreviewDialog1.Location = New Point(CenterscreenWidth - 0.5 * DialogSize.Width, CenterscreenHeight - DialogSize.Height)
                PrintPreviewDialog1.Dock = DockStyle.Fill
            End If
            'Draw The Form Image On The Printer Graphics
            e.Graphics.DrawImage(MyImage, mLeft, mTop, mWidth, mHeight)
            MyImage.Dispose()
        End Using
        PrintPreview = False
    End Sub
    Private Sub CloseApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseApplicationToolStripMenuItem.Click
        Close()
        Application.Exit()
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created By Ross Waters" & vbCrLf & "Last Revision Date 04/17,2021" & vbCrLf & "Revision 1.0.5", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ViewIRCPDFFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIRCPDFFileToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\StairIRC.pdf")
    End Sub
    Private Sub PreviewAndPrintDefaultPrinterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAndPrintDefaultPrinterToolStripMenuItem.Click
        'Show Print Preview Dialog
        PrintPreview = True
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        Try
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SelectPrinterAndPrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectPrinterAndPrintToolStripMenuItem.Click
        PrintPreview = False
        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class
