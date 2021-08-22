<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStringer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStringer))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblFooter = New System.Windows.Forms.Label()
        Me.PicVerTxt = New System.Windows.Forms.PictureBox()
        Me.LblMouseMove = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblDateTime = New System.Windows.Forms.Label()
        Me.GBTopPosition = New System.Windows.Forms.GroupBox()
        Me.RdoBtnDown = New System.Windows.Forms.RadioButton()
        Me.RdoBtnFlush = New System.Windows.Forms.RadioButton()
        Me.GBRisers = New System.Windows.Forms.GroupBox()
        Me.LblBottomRiserRise = New System.Windows.Forms.Label()
        Me.LblTopRiserRise = New System.Windows.Forms.Label()
        Me.LblRisePerStep = New System.Windows.Forms.Label()
        Me.LblNumRisersCap = New System.Windows.Forms.Label()
        Me.LblTotalRiseCap = New System.Windows.Forms.Label()
        Me.LblNumRisers = New System.Windows.Forms.Label()
        Me.LblTotalRise = New System.Windows.Forms.Label()
        Me.LblBottomRiserRiseCap = New System.Windows.Forms.Label()
        Me.LblTopRiserRiseCap = New System.Windows.Forms.Label()
        Me.LblRisePerStepCap = New System.Windows.Forms.Label()
        Me.LblTopThickness = New System.Windows.Forms.Label()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.TxtBxTopThickness = New System.Windows.Forms.TextBox()
        Me.TxtBxHeight = New System.Windows.Forms.TextBox()
        Me.LblRiserAngle = New System.Windows.Forms.Label()
        Me.TxtBxRiserAngle = New System.Windows.Forms.TextBox()
        Me.GBAngles = New System.Windows.Forms.GroupBox()
        Me.LblPeaksValleys = New System.Windows.Forms.Label()
        Me.LblPeaksCap = New System.Windows.Forms.Label()
        Me.LblTreadWidth = New System.Windows.Forms.Label()
        Me.LblStringerLength = New System.Windows.Forms.Label()
        Me.LblStringerWidth = New System.Windows.Forms.Label()
        Me.LblTopCut = New System.Windows.Forms.Label()
        Me.LblBottomCut = New System.Windows.Forms.Label()
        Me.LblStairAngle = New System.Windows.Forms.Label()
        Me.LblTreadWidthCap = New System.Windows.Forms.Label()
        Me.LblStringerLengthCap = New System.Windows.Forms.Label()
        Me.LblStringerWidthCap = New System.Windows.Forms.Label()
        Me.LblTopCutCap = New System.Windows.Forms.Label()
        Me.LblBottomCutCap = New System.Windows.Forms.Label()
        Me.LblStairAngleCap = New System.Windows.Forms.Label()
        Me.GBRunners = New System.Windows.Forms.GroupBox()
        Me.LblRunCutLengthCap = New System.Windows.Forms.Label()
        Me.LblRunCutLength = New System.Windows.Forms.Label()
        Me.LblFloorSpace = New System.Windows.Forms.Label()
        Me.LblNumSteps = New System.Windows.Forms.Label()
        Me.LblNumRunners = New System.Windows.Forms.Label()
        Me.LblFloorSpaceCap = New System.Windows.Forms.Label()
        Me.LblNumStepsCap = New System.Windows.Forms.Label()
        Me.LblNumOfRunnersCap = New System.Windows.Forms.Label()
        Me.LblTreadThickness = New System.Windows.Forms.Label()
        Me.LblTreadDepth = New System.Windows.Forms.Label()
        Me.LblRunPerStep = New System.Windows.Forms.Label()
        Me.TxtBxTreadThickness = New System.Windows.Forms.TextBox()
        Me.TxtBxTreadDepth = New System.Windows.Forms.TextBox()
        Me.TxtBxRunPerStep = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsJPEGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewIRCPDFFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectPrinterAndPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewAndPrintDefaultPrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PicVerTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBTopPosition.SuspendLayout()
        Me.GBRisers.SuspendLayout()
        Me.GBAngles.SuspendLayout()
        Me.GBRunners.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblHeader.Location = New System.Drawing.Point(96, -1)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(538, 38)
        Me.LblHeader.TabIndex = 1
        Me.LblHeader.Text = "StairCase Stringer Calculator (I.R.C. Specs.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFooter
        '
        Me.LblFooter.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFooter.ForeColor = System.Drawing.Color.Red
        Me.LblFooter.Location = New System.Drawing.Point(98, 517)
        Me.LblFooter.Name = "LblFooter"
        Me.LblFooter.Size = New System.Drawing.Size(493, 25)
        Me.LblFooter.TabIndex = 2
        Me.LblFooter.Text = " Floor Distance Needed For StairCase (Inches)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicVerTxt
        '
        Me.PicVerTxt.Location = New System.Drawing.Point(2, 82)
        Me.PicVerTxt.Name = "PicVerTxt"
        Me.PicVerTxt.Size = New System.Drawing.Size(40, 240)
        Me.PicVerTxt.TabIndex = 3
        Me.PicVerTxt.TabStop = False
        '
        'LblMouseMove
        '
        Me.LblMouseMove.AutoSize = True
        Me.LblMouseMove.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMouseMove.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LblMouseMove.Location = New System.Drawing.Point(696, 48)
        Me.LblMouseMove.Name = "LblMouseMove"
        Me.LblMouseMove.Size = New System.Drawing.Size(40, 15)
        Me.LblMouseMove.TabIndex = 4
        Me.LblMouseMove.Text = "Mouse"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(1, 1)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(40, 16)
        Me.LblUserName.TabIndex = 5
        Me.LblUserName.Text = "Name"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDateTime
        '
        Me.LblDateTime.AutoSize = True
        Me.LblDateTime.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateTime.Location = New System.Drawing.Point(1, 19)
        Me.LblDateTime.Name = "LblDateTime"
        Me.LblDateTime.Size = New System.Drawing.Size(62, 16)
        Me.LblDateTime.TabIndex = 6
        Me.LblDateTime.Text = "DateTime"
        Me.LblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GBTopPosition
        '
        Me.GBTopPosition.Controls.Add(Me.RdoBtnDown)
        Me.GBTopPosition.Controls.Add(Me.RdoBtnFlush)
        Me.GBTopPosition.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBTopPosition.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GBTopPosition.Location = New System.Drawing.Point(857, 1)
        Me.GBTopPosition.Name = "GBTopPosition"
        Me.GBTopPosition.Size = New System.Drawing.Size(210, 65)
        Me.GBTopPosition.TabIndex = 0
        Me.GBTopPosition.TabStop = False
        Me.GBTopPosition.Text = "Position Of Stringer At Top"
        '
        'RdoBtnDown
        '
        Me.RdoBtnDown.AutoSize = True
        Me.RdoBtnDown.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoBtnDown.ForeColor = System.Drawing.Color.Black
        Me.RdoBtnDown.Location = New System.Drawing.Point(9, 45)
        Me.RdoBtnDown.Name = "RdoBtnDown"
        Me.RdoBtnDown.Size = New System.Drawing.Size(190, 19)
        Me.RdoBtnDown.TabIndex = 2
        Me.RdoBtnDown.TabStop = True
        Me.RdoBtnDown.Text = "Down 1 Step From Top SubFloor"
        Me.RdoBtnDown.UseVisualStyleBackColor = True
        '
        'RdoBtnFlush
        '
        Me.RdoBtnFlush.AutoSize = True
        Me.RdoBtnFlush.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoBtnFlush.ForeColor = System.Drawing.Color.Black
        Me.RdoBtnFlush.Location = New System.Drawing.Point(9, 20)
        Me.RdoBtnFlush.Name = "RdoBtnFlush"
        Me.RdoBtnFlush.Size = New System.Drawing.Size(155, 19)
        Me.RdoBtnFlush.TabIndex = 1
        Me.RdoBtnFlush.TabStop = True
        Me.RdoBtnFlush.Text = "Flush With Top SubFloor"
        Me.RdoBtnFlush.UseVisualStyleBackColor = True
        '
        'GBRisers
        '
        Me.GBRisers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GBRisers.Controls.Add(Me.LblBottomRiserRise)
        Me.GBRisers.Controls.Add(Me.LblTopRiserRise)
        Me.GBRisers.Controls.Add(Me.LblRisePerStep)
        Me.GBRisers.Controls.Add(Me.LblNumRisersCap)
        Me.GBRisers.Controls.Add(Me.LblTotalRiseCap)
        Me.GBRisers.Controls.Add(Me.LblNumRisers)
        Me.GBRisers.Controls.Add(Me.LblTotalRise)
        Me.GBRisers.Controls.Add(Me.LblBottomRiserRiseCap)
        Me.GBRisers.Controls.Add(Me.LblTopRiserRiseCap)
        Me.GBRisers.Controls.Add(Me.LblRisePerStepCap)
        Me.GBRisers.Controls.Add(Me.LblTopThickness)
        Me.GBRisers.Controls.Add(Me.LblHeight)
        Me.GBRisers.Controls.Add(Me.TxtBxTopThickness)
        Me.GBRisers.Controls.Add(Me.TxtBxHeight)
        Me.GBRisers.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRisers.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GBRisers.Location = New System.Drawing.Point(858, 70)
        Me.GBRisers.Name = "GBRisers"
        Me.GBRisers.Size = New System.Drawing.Size(210, 190)
        Me.GBRisers.TabIndex = 3
        Me.GBRisers.TabStop = False
        Me.GBRisers.Text = "Height And Risers"
        '
        'LblBottomRiserRise
        '
        Me.LblBottomRiserRise.BackColor = System.Drawing.Color.White
        Me.LblBottomRiserRise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBottomRiserRise.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomRiserRise.ForeColor = System.Drawing.Color.Black
        Me.LblBottomRiserRise.Location = New System.Drawing.Point(140, 166)
        Me.LblBottomRiserRise.Name = "LblBottomRiserRise"
        Me.LblBottomRiserRise.Size = New System.Drawing.Size(69, 20)
        Me.LblBottomRiserRise.TabIndex = 24
        Me.LblBottomRiserRise.Text = "6.5"
        '
        'LblTopRiserRise
        '
        Me.LblTopRiserRise.BackColor = System.Drawing.Color.White
        Me.LblTopRiserRise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTopRiserRise.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopRiserRise.ForeColor = System.Drawing.Color.Black
        Me.LblTopRiserRise.Location = New System.Drawing.Point(140, 143)
        Me.LblTopRiserRise.Name = "LblTopRiserRise"
        Me.LblTopRiserRise.Size = New System.Drawing.Size(69, 20)
        Me.LblTopRiserRise.TabIndex = 23
        Me.LblTopRiserRise.Text = "7.5"
        '
        'LblRisePerStep
        '
        Me.LblRisePerStep.BackColor = System.Drawing.Color.White
        Me.LblRisePerStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRisePerStep.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRisePerStep.ForeColor = System.Drawing.Color.Black
        Me.LblRisePerStep.Location = New System.Drawing.Point(140, 118)
        Me.LblRisePerStep.Name = "LblRisePerStep"
        Me.LblRisePerStep.Size = New System.Drawing.Size(69, 20)
        Me.LblRisePerStep.TabIndex = 22
        Me.LblRisePerStep.Text = "7.5"
        '
        'LblNumRisersCap
        '
        Me.LblNumRisersCap.AutoSize = True
        Me.LblNumRisersCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumRisersCap.ForeColor = System.Drawing.Color.Black
        Me.LblNumRisersCap.Location = New System.Drawing.Point(44, 94)
        Me.LblNumRisersCap.Name = "LblNumRisersCap"
        Me.LblNumRisersCap.Size = New System.Drawing.Size(95, 15)
        Me.LblNumRisersCap.TabIndex = 21
        Me.LblNumRisersCap.Text = "Number Of Risers"
        '
        'LblTotalRiseCap
        '
        Me.LblTotalRiseCap.AutoSize = True
        Me.LblTotalRiseCap.BackColor = System.Drawing.SystemColors.Control
        Me.LblTotalRiseCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRiseCap.ForeColor = System.Drawing.Color.Black
        Me.LblTotalRiseCap.Location = New System.Drawing.Point(15, 70)
        Me.LblTotalRiseCap.Name = "LblTotalRiseCap"
        Me.LblTotalRiseCap.Size = New System.Drawing.Size(124, 15)
        Me.LblTotalRiseCap.TabIndex = 20
        Me.LblTotalRiseCap.Text = "Stringer Total Rise (in.)"
        '
        'LblNumRisers
        '
        Me.LblNumRisers.BackColor = System.Drawing.Color.White
        Me.LblNumRisers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumRisers.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumRisers.ForeColor = System.Drawing.Color.Black
        Me.LblNumRisers.Location = New System.Drawing.Point(140, 94)
        Me.LblNumRisers.Name = "LblNumRisers"
        Me.LblNumRisers.Size = New System.Drawing.Size(69, 20)
        Me.LblNumRisers.TabIndex = 19
        Me.LblNumRisers.Text = "5"
        '
        'LblTotalRise
        '
        Me.LblTotalRise.BackColor = System.Drawing.Color.White
        Me.LblTotalRise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalRise.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalRise.ForeColor = System.Drawing.Color.Black
        Me.LblTotalRise.Location = New System.Drawing.Point(140, 71)
        Me.LblTotalRise.Name = "LblTotalRise"
        Me.LblTotalRise.Size = New System.Drawing.Size(69, 20)
        Me.LblTotalRise.TabIndex = 18
        Me.LblTotalRise.Text = "36.5"
        '
        'LblBottomRiserRiseCap
        '
        Me.LblBottomRiserRiseCap.AutoSize = True
        Me.LblBottomRiserRiseCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomRiserRiseCap.ForeColor = System.Drawing.Color.Black
        Me.LblBottomRiserRiseCap.Location = New System.Drawing.Point(20, 166)
        Me.LblBottomRiserRiseCap.Name = "LblBottomRiserRiseCap"
        Me.LblBottomRiserRiseCap.Size = New System.Drawing.Size(119, 15)
        Me.LblBottomRiserRiseCap.TabIndex = 17
        Me.LblBottomRiserRiseCap.Text = "Bottom Riser Rise (in.)"
        '
        'LblTopRiserRiseCap
        '
        Me.LblTopRiserRiseCap.AutoSize = True
        Me.LblTopRiserRiseCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopRiserRiseCap.ForeColor = System.Drawing.Color.Black
        Me.LblTopRiserRiseCap.Location = New System.Drawing.Point(37, 144)
        Me.LblTopRiserRiseCap.Name = "LblTopRiserRiseCap"
        Me.LblTopRiserRiseCap.Size = New System.Drawing.Size(102, 15)
        Me.LblTopRiserRiseCap.TabIndex = 16
        Me.LblTopRiserRiseCap.Text = "Top Riser Rise (in.)"
        '
        'LblRisePerStepCap
        '
        Me.LblRisePerStepCap.AutoSize = True
        Me.LblRisePerStepCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRisePerStepCap.ForeColor = System.Drawing.Color.Black
        Me.LblRisePerStepCap.Location = New System.Drawing.Point(43, 119)
        Me.LblRisePerStepCap.Name = "LblRisePerStepCap"
        Me.LblRisePerStepCap.Size = New System.Drawing.Size(96, 15)
        Me.LblRisePerStepCap.TabIndex = 15
        Me.LblRisePerStepCap.Text = "Rise Per Step (in.)"
        '
        'LblTopThickness
        '
        Me.LblTopThickness.AutoSize = True
        Me.LblTopThickness.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopThickness.ForeColor = System.Drawing.Color.Black
        Me.LblTopThickness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTopThickness.Location = New System.Drawing.Point(6, 48)
        Me.LblTopThickness.Name = "LblTopThickness"
        Me.LblTopThickness.Size = New System.Drawing.Size(133, 15)
        Me.LblTopThickness.TabIndex = 7
        Me.LblTopThickness.Text = "Top Tread Thickness (in.)"
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeight.ForeColor = System.Drawing.Color.Black
        Me.LblHeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblHeight.Location = New System.Drawing.Point(26, 23)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(113, 15)
        Me.LblHeight.TabIndex = 3
        Me.LblHeight.Text = "Staircase Height (in.)"
        '
        'TxtBxTopThickness
        '
        Me.TxtBxTopThickness.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxTopThickness.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxTopThickness.Location = New System.Drawing.Point(140, 46)
        Me.TxtBxTopThickness.Name = "TxtBxTopThickness"
        Me.TxtBxTopThickness.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxTopThickness.TabIndex = 5
        Me.TxtBxTopThickness.Text = "1"
        '
        'TxtBxHeight
        '
        Me.TxtBxHeight.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxHeight.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxHeight.Location = New System.Drawing.Point(140, 21)
        Me.TxtBxHeight.Name = "TxtBxHeight"
        Me.TxtBxHeight.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxHeight.TabIndex = 4
        Me.TxtBxHeight.Text = "36.5"
        '
        'LblRiserAngle
        '
        Me.LblRiserAngle.AutoSize = True
        Me.LblRiserAngle.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRiserAngle.ForeColor = System.Drawing.Color.Black
        Me.LblRiserAngle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblRiserAngle.Location = New System.Drawing.Point(25, 23)
        Me.LblRiserAngle.Name = "LblRiserAngle"
        Me.LblRiserAngle.Size = New System.Drawing.Size(114, 15)
        Me.LblRiserAngle.TabIndex = 5
        Me.LblRiserAngle.Text = "Riser Toe Kick Angle "
        '
        'TxtBxRiserAngle
        '
        Me.TxtBxRiserAngle.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxRiserAngle.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxRiserAngle.Location = New System.Drawing.Point(140, 20)
        Me.TxtBxRiserAngle.Name = "TxtBxRiserAngle"
        Me.TxtBxRiserAngle.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxRiserAngle.TabIndex = 12
        Me.TxtBxRiserAngle.Text = "0"
        '
        'GBAngles
        '
        Me.GBAngles.Controls.Add(Me.LblPeaksValleys)
        Me.GBAngles.Controls.Add(Me.LblPeaksCap)
        Me.GBAngles.Controls.Add(Me.LblTreadWidth)
        Me.GBAngles.Controls.Add(Me.LblStringerLength)
        Me.GBAngles.Controls.Add(Me.LblStringerWidth)
        Me.GBAngles.Controls.Add(Me.LblTopCut)
        Me.GBAngles.Controls.Add(Me.LblBottomCut)
        Me.GBAngles.Controls.Add(Me.LblStairAngle)
        Me.GBAngles.Controls.Add(Me.LblTreadWidthCap)
        Me.GBAngles.Controls.Add(Me.LblStringerLengthCap)
        Me.GBAngles.Controls.Add(Me.LblStringerWidthCap)
        Me.GBAngles.Controls.Add(Me.LblTopCutCap)
        Me.GBAngles.Controls.Add(Me.LblBottomCutCap)
        Me.GBAngles.Controls.Add(Me.LblStairAngleCap)
        Me.GBAngles.Controls.Add(Me.LblRiserAngle)
        Me.GBAngles.Controls.Add(Me.TxtBxRiserAngle)
        Me.GBAngles.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBAngles.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GBAngles.Location = New System.Drawing.Point(858, 460)
        Me.GBAngles.Name = "GBAngles"
        Me.GBAngles.Size = New System.Drawing.Size(210, 215)
        Me.GBAngles.TabIndex = 11
        Me.GBAngles.TabStop = False
        Me.GBAngles.Text = "Angles  And Material"
        '
        'LblPeaksValleys
        '
        Me.LblPeaksValleys.BackColor = System.Drawing.Color.White
        Me.LblPeaksValleys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPeaksValleys.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeaksValleys.ForeColor = System.Drawing.Color.Black
        Me.LblPeaksValleys.Location = New System.Drawing.Point(139, 192)
        Me.LblPeaksValleys.Name = "LblPeaksValleys"
        Me.LblPeaksValleys.Size = New System.Drawing.Size(69, 20)
        Me.LblPeaksValleys.TabIndex = 32
        Me.LblPeaksValleys.Text = "12.70089"
        '
        'LblPeaksCap
        '
        Me.LblPeaksCap.AutoSize = True
        Me.LblPeaksCap.BackColor = System.Drawing.SystemColors.Control
        Me.LblPeaksCap.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeaksCap.ForeColor = System.Drawing.Color.Black
        Me.LblPeaksCap.Location = New System.Drawing.Point(23, 193)
        Me.LblPeaksCap.Name = "LblPeaksCap"
        Me.LblPeaksCap.Size = New System.Drawing.Size(116, 16)
        Me.LblPeaksCap.TabIndex = 31
        Me.LblPeaksCap.Text = "Peaks / Valleys (in.)"
        '
        'LblTreadWidth
        '
        Me.LblTreadWidth.BackColor = System.Drawing.Color.White
        Me.LblTreadWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTreadWidth.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreadWidth.ForeColor = System.Drawing.Color.Black
        Me.LblTreadWidth.Location = New System.Drawing.Point(139, 168)
        Me.LblTreadWidth.Name = "LblTreadWidth"
        Me.LblTreadWidth.Size = New System.Drawing.Size(69, 20)
        Me.LblTreadWidth.TabIndex = 30
        Me.LblTreadWidth.Text = "12"
        '
        'LblStringerLength
        '
        Me.LblStringerLength.BackColor = System.Drawing.Color.White
        Me.LblStringerLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStringerLength.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStringerLength.ForeColor = System.Drawing.Color.Black
        Me.LblStringerLength.Location = New System.Drawing.Point(139, 143)
        Me.LblStringerLength.Name = "LblStringerLength"
        Me.LblStringerLength.Size = New System.Drawing.Size(69, 20)
        Me.LblStringerLength.TabIndex = 29
        Me.LblStringerLength.Text = "5.29204"
        '
        'LblStringerWidth
        '
        Me.LblStringerWidth.BackColor = System.Drawing.Color.White
        Me.LblStringerWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStringerWidth.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStringerWidth.ForeColor = System.Drawing.Color.Black
        Me.LblStringerWidth.Location = New System.Drawing.Point(140, 118)
        Me.LblStringerWidth.Name = "LblStringerWidth"
        Me.LblStringerWidth.Size = New System.Drawing.Size(69, 20)
        Me.LblStringerWidth.TabIndex = 28
        Me.LblStringerWidth.Text = "11.5"
        '
        'LblTopCut
        '
        Me.LblTopCut.BackColor = System.Drawing.Color.White
        Me.LblTopCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTopCut.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopCut.ForeColor = System.Drawing.Color.Black
        Me.LblTopCut.Location = New System.Drawing.Point(140, 93)
        Me.LblTopCut.Name = "LblTopCut"
        Me.LblTopCut.Size = New System.Drawing.Size(69, 20)
        Me.LblTopCut.TabIndex = 27
        Me.LblTopCut.Text = "36.19321"
        '
        'LblBottomCut
        '
        Me.LblBottomCut.BackColor = System.Drawing.Color.White
        Me.LblBottomCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblBottomCut.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomCut.ForeColor = System.Drawing.Color.Black
        Me.LblBottomCut.Location = New System.Drawing.Point(140, 70)
        Me.LblBottomCut.Name = "LblBottomCut"
        Me.LblBottomCut.Size = New System.Drawing.Size(69, 20)
        Me.LblBottomCut.TabIndex = 26
        Me.LblBottomCut.Text = "53.80679"
        '
        'LblStairAngle
        '
        Me.LblStairAngle.BackColor = System.Drawing.Color.White
        Me.LblStairAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStairAngle.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStairAngle.ForeColor = System.Drawing.Color.Black
        Me.LblStairAngle.Location = New System.Drawing.Point(141, 45)
        Me.LblStairAngle.Name = "LblStairAngle"
        Me.LblStairAngle.Size = New System.Drawing.Size(69, 20)
        Me.LblStairAngle.TabIndex = 25
        Me.LblStairAngle.Text = "36.193207"
        '
        'LblTreadWidthCap
        '
        Me.LblTreadWidthCap.AutoSize = True
        Me.LblTreadWidthCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreadWidthCap.ForeColor = System.Drawing.Color.Black
        Me.LblTreadWidthCap.Location = New System.Drawing.Point(43, 169)
        Me.LblTreadWidthCap.Name = "LblTreadWidthCap"
        Me.LblTreadWidthCap.Size = New System.Drawing.Size(94, 15)
        Me.LblTreadWidthCap.TabIndex = 24
        Me.LblTreadWidthCap.Text = "Tread Width (in.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblStringerLengthCap
        '
        Me.LblStringerLengthCap.AutoSize = True
        Me.LblStringerLengthCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStringerLengthCap.ForeColor = System.Drawing.Color.Black
        Me.LblStringerLengthCap.Location = New System.Drawing.Point(33, 144)
        Me.LblStringerLengthCap.Name = "LblStringerLengthCap"
        Me.LblStringerLengthCap.Size = New System.Drawing.Size(106, 15)
        Me.LblStringerLengthCap.TabIndex = 22
        Me.LblStringerLengthCap.Text = "Stringer Length (ft.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblStringerWidthCap
        '
        Me.LblStringerWidthCap.AutoSize = True
        Me.LblStringerWidthCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStringerWidthCap.ForeColor = System.Drawing.Color.Black
        Me.LblStringerWidthCap.Location = New System.Drawing.Point(33, 119)
        Me.LblStringerWidthCap.Name = "LblStringerWidthCap"
        Me.LblStringerWidthCap.Size = New System.Drawing.Size(106, 15)
        Me.LblStringerWidthCap.TabIndex = 21
        Me.LblStringerWidthCap.Text = "Stringer Width (in.)"
        '
        'LblTopCutCap
        '
        Me.LblTopCutCap.AutoSize = True
        Me.LblTopCutCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTopCutCap.ForeColor = System.Drawing.Color.Black
        Me.LblTopCutCap.Location = New System.Drawing.Point(60, 94)
        Me.LblTopCutCap.Name = "LblTopCutCap"
        Me.LblTopCutCap.Size = New System.Drawing.Size(79, 15)
        Me.LblTopCutCap.TabIndex = 20
        Me.LblTopCutCap.Text = "Top Cut Angle"
        '
        'LblBottomCutCap
        '
        Me.LblBottomCutCap.AutoSize = True
        Me.LblBottomCutCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBottomCutCap.ForeColor = System.Drawing.Color.Black
        Me.LblBottomCutCap.Location = New System.Drawing.Point(44, 71)
        Me.LblBottomCutCap.Name = "LblBottomCutCap"
        Me.LblBottomCutCap.Size = New System.Drawing.Size(96, 15)
        Me.LblBottomCutCap.TabIndex = 19
        Me.LblBottomCutCap.Text = "Bottom Cut Angle"
        '
        'LblStairAngleCap
        '
        Me.LblStairAngleCap.AutoSize = True
        Me.LblStairAngleCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStairAngleCap.ForeColor = System.Drawing.Color.Black
        Me.LblStairAngleCap.Location = New System.Drawing.Point(56, 46)
        Me.LblStairAngleCap.Name = "LblStairAngleCap"
        Me.LblStairAngleCap.Size = New System.Drawing.Size(84, 15)
        Me.LblStairAngleCap.TabIndex = 18
        Me.LblStairAngleCap.Text = "Staircase Angle"
        '
        'GBRunners
        '
        Me.GBRunners.Controls.Add(Me.LblRunCutLengthCap)
        Me.GBRunners.Controls.Add(Me.LblRunCutLength)
        Me.GBRunners.Controls.Add(Me.LblFloorSpace)
        Me.GBRunners.Controls.Add(Me.LblNumSteps)
        Me.GBRunners.Controls.Add(Me.LblNumRunners)
        Me.GBRunners.Controls.Add(Me.LblFloorSpaceCap)
        Me.GBRunners.Controls.Add(Me.LblNumStepsCap)
        Me.GBRunners.Controls.Add(Me.LblNumOfRunnersCap)
        Me.GBRunners.Controls.Add(Me.LblTreadThickness)
        Me.GBRunners.Controls.Add(Me.LblTreadDepth)
        Me.GBRunners.Controls.Add(Me.LblRunPerStep)
        Me.GBRunners.Controls.Add(Me.TxtBxTreadThickness)
        Me.GBRunners.Controls.Add(Me.TxtBxTreadDepth)
        Me.GBRunners.Controls.Add(Me.TxtBxRunPerStep)
        Me.GBRunners.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRunners.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GBRunners.Location = New System.Drawing.Point(858, 262)
        Me.GBRunners.Name = "GBRunners"
        Me.GBRunners.Size = New System.Drawing.Size(210, 198)
        Me.GBRunners.TabIndex = 6
        Me.GBRunners.TabStop = False
        Me.GBRunners.Text = "Length, Runners And Tread"
        '
        'LblRunCutLengthCap
        '
        Me.LblRunCutLengthCap.AutoSize = True
        Me.LblRunCutLengthCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRunCutLengthCap.ForeColor = System.Drawing.Color.Black
        Me.LblRunCutLengthCap.Location = New System.Drawing.Point(7, 50)
        Me.LblRunCutLengthCap.Name = "LblRunCutLengthCap"
        Me.LblRunCutLengthCap.Size = New System.Drawing.Size(133, 15)
        Me.LblRunCutLengthCap.TabIndex = 18
        Me.LblRunCutLengthCap.Text = "Runners Cut Length (in.)"
        '
        'LblRunCutLength
        '
        Me.LblRunCutLength.BackColor = System.Drawing.Color.White
        Me.LblRunCutLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRunCutLength.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRunCutLength.ForeColor = System.Drawing.Color.Black
        Me.LblRunCutLength.Location = New System.Drawing.Point(140, 49)
        Me.LblRunCutLength.Name = "LblRunCutLength"
        Me.LblRunCutLength.Size = New System.Drawing.Size(69, 20)
        Me.LblRunCutLength.TabIndex = 17
        '
        'LblFloorSpace
        '
        Me.LblFloorSpace.BackColor = System.Drawing.Color.White
        Me.LblFloorSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFloorSpace.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFloorSpace.ForeColor = System.Drawing.Color.Black
        Me.LblFloorSpace.Location = New System.Drawing.Point(141, 173)
        Me.LblFloorSpace.Name = "LblFloorSpace"
        Me.LblFloorSpace.Size = New System.Drawing.Size(69, 20)
        Me.LblFloorSpace.TabIndex = 16
        Me.LblFloorSpace.Text = "51.25"
        '
        'LblNumSteps
        '
        Me.LblNumSteps.BackColor = System.Drawing.Color.White
        Me.LblNumSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumSteps.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumSteps.ForeColor = System.Drawing.Color.Black
        Me.LblNumSteps.Location = New System.Drawing.Point(141, 149)
        Me.LblNumSteps.Name = "LblNumSteps"
        Me.LblNumSteps.Size = New System.Drawing.Size(69, 20)
        Me.LblNumSteps.TabIndex = 15
        Me.LblNumSteps.Text = "5"
        '
        'LblNumRunners
        '
        Me.LblNumRunners.BackColor = System.Drawing.Color.White
        Me.LblNumRunners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumRunners.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumRunners.ForeColor = System.Drawing.Color.Black
        Me.LblNumRunners.Location = New System.Drawing.Point(141, 125)
        Me.LblNumRunners.Name = "LblNumRunners"
        Me.LblNumRunners.Size = New System.Drawing.Size(69, 20)
        Me.LblNumRunners.TabIndex = 14
        Me.LblNumRunners.Text = "5"
        '
        'LblFloorSpaceCap
        '
        Me.LblFloorSpaceCap.AutoSize = True
        Me.LblFloorSpaceCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFloorSpaceCap.ForeColor = System.Drawing.Color.Black
        Me.LblFloorSpaceCap.Location = New System.Drawing.Point(0, 174)
        Me.LblFloorSpaceCap.Name = "LblFloorSpaceCap"
        Me.LblFloorSpaceCap.Size = New System.Drawing.Size(140, 15)
        Me.LblFloorSpaceCap.TabIndex = 13
        Me.LblFloorSpaceCap.Text = "Floor Space Required (in.)"
        '
        'LblNumStepsCap
        '
        Me.LblNumStepsCap.AutoSize = True
        Me.LblNumStepsCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumStepsCap.ForeColor = System.Drawing.Color.Black
        Me.LblNumStepsCap.Location = New System.Drawing.Point(49, 150)
        Me.LblNumStepsCap.Name = "LblNumStepsCap"
        Me.LblNumStepsCap.Size = New System.Drawing.Size(91, 15)
        Me.LblNumStepsCap.TabIndex = 12
        Me.LblNumStepsCap.Text = "Number Of Steps"
        '
        'LblNumOfRunnersCap
        '
        Me.LblNumOfRunnersCap.AutoSize = True
        Me.LblNumOfRunnersCap.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumOfRunnersCap.ForeColor = System.Drawing.Color.Black
        Me.LblNumOfRunnersCap.Location = New System.Drawing.Point(32, 126)
        Me.LblNumOfRunnersCap.Name = "LblNumOfRunnersCap"
        Me.LblNumOfRunnersCap.Size = New System.Drawing.Size(108, 15)
        Me.LblNumOfRunnersCap.TabIndex = 11
        Me.LblNumOfRunnersCap.Text = "Number Of Runners"
        '
        'LblTreadThickness
        '
        Me.LblTreadThickness.AutoSize = True
        Me.LblTreadThickness.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreadThickness.ForeColor = System.Drawing.Color.Black
        Me.LblTreadThickness.Location = New System.Drawing.Point(28, 101)
        Me.LblTreadThickness.Name = "LblTreadThickness"
        Me.LblTreadThickness.Size = New System.Drawing.Size(112, 15)
        Me.LblTreadThickness.TabIndex = 9
        Me.LblTreadThickness.Text = "Tread Thickness (in.)"
        '
        'LblTreadDepth
        '
        Me.LblTreadDepth.AutoSize = True
        Me.LblTreadDepth.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTreadDepth.ForeColor = System.Drawing.Color.Black
        Me.LblTreadDepth.Location = New System.Drawing.Point(46, 75)
        Me.LblTreadDepth.Name = "LblTreadDepth"
        Me.LblTreadDepth.Size = New System.Drawing.Size(93, 15)
        Me.LblTreadDepth.TabIndex = 8
        Me.LblTreadDepth.Text = "Tread Depth (in.)"
        '
        'LblRunPerStep
        '
        Me.LblRunPerStep.AutoSize = True
        Me.LblRunPerStep.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRunPerStep.ForeColor = System.Drawing.Color.Black
        Me.LblRunPerStep.Location = New System.Drawing.Point(43, 26)
        Me.LblRunPerStep.Name = "LblRunPerStep"
        Me.LblRunPerStep.Size = New System.Drawing.Size(97, 15)
        Me.LblRunPerStep.TabIndex = 7
        Me.LblRunPerStep.Text = "Run Per Step (in.)"
        '
        'TxtBxTreadThickness
        '
        Me.TxtBxTreadThickness.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxTreadThickness.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxTreadThickness.Location = New System.Drawing.Point(141, 98)
        Me.TxtBxTreadThickness.Name = "TxtBxTreadThickness"
        Me.TxtBxTreadThickness.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxTreadThickness.TabIndex = 9
        Me.TxtBxTreadThickness.Text = "1"
        '
        'TxtBxTreadDepth
        '
        Me.TxtBxTreadDepth.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxTreadDepth.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxTreadDepth.Location = New System.Drawing.Point(140, 72)
        Me.TxtBxTreadDepth.Name = "TxtBxTreadDepth"
        Me.TxtBxTreadDepth.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxTreadDepth.TabIndex = 8
        Me.TxtBxTreadDepth.Text = "12"
        '
        'TxtBxRunPerStep
        '
        Me.TxtBxRunPerStep.BackColor = System.Drawing.Color.LightCyan
        Me.TxtBxRunPerStep.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBxRunPerStep.Location = New System.Drawing.Point(140, 24)
        Me.TxtBxRunPerStep.Name = "TxtBxRunPerStep"
        Me.TxtBxRunPerStep.Size = New System.Drawing.Size(69, 22)
        Me.TxtBxRunPerStep.TabIndex = 7
        Me.TxtBxRunPerStep.Text = "10.25"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SaveAsJPEGToolStripMenuItem, Me.ViewIRCPDFFileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CloseApplicationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 136)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectPrinterAndPrintToolStripMenuItem, Me.PreviewAndPrintDefaultPrinterToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'SaveAsJPEGToolStripMenuItem
        '
        Me.SaveAsJPEGToolStripMenuItem.Name = "SaveAsJPEGToolStripMenuItem"
        Me.SaveAsJPEGToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsJPEGToolStripMenuItem.Text = "Save As JPEG"
        '
        'ViewIRCPDFFileToolStripMenuItem
        '
        Me.ViewIRCPDFFileToolStripMenuItem.Name = "ViewIRCPDFFileToolStripMenuItem"
        Me.ViewIRCPDFFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewIRCPDFFileToolStripMenuItem.Text = "View I.R.C. PDF File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseApplicationToolStripMenuItem
        '
        Me.CloseApplicationToolStripMenuItem.Name = "CloseApplicationToolStripMenuItem"
        Me.CloseApplicationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseApplicationToolStripMenuItem.Text = "Close Application"
        '
        'SelectPrinterAndPrintToolStripMenuItem
        '
        Me.SelectPrinterAndPrintToolStripMenuItem.Name = "SelectPrinterAndPrintToolStripMenuItem"
        Me.SelectPrinterAndPrintToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.SelectPrinterAndPrintToolStripMenuItem.Text = "Select Printer And Print"
        '
        'PreviewAndPrintDefaultPrinterToolStripMenuItem
        '
        Me.PreviewAndPrintDefaultPrinterToolStripMenuItem.Name = "PreviewAndPrintDefaultPrinterToolStripMenuItem"
        Me.PreviewAndPrintDefaultPrinterToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.PreviewAndPrintDefaultPrinterToolStripMenuItem.Text = "Preview And Print (Default Printer)"
        '
        'FrmStringer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 691)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GBRunners)
        Me.Controls.Add(Me.GBAngles)
        Me.Controls.Add(Me.GBRisers)
        Me.Controls.Add(Me.GBTopPosition)
        Me.Controls.Add(Me.LblDateTime)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.LblMouseMove)
        Me.Controls.Add(Me.PicVerTxt)
        Me.Controls.Add(Me.LblFooter)
        Me.Controls.Add(Me.LblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStringer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StairCase Stringer Design"
        CType(Me.PicVerTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBTopPosition.ResumeLayout(False)
        Me.GBTopPosition.PerformLayout()
        Me.GBRisers.ResumeLayout(False)
        Me.GBRisers.PerformLayout()
        Me.GBAngles.ResumeLayout(False)
        Me.GBAngles.PerformLayout()
        Me.GBRunners.ResumeLayout(False)
        Me.GBRunners.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblHeader As Label
    Friend WithEvents LblFooter As Label
    Friend WithEvents PicVerTxt As PictureBox
    Friend WithEvents LblMouseMove As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblDateTime As Label
    Friend WithEvents GBTopPosition As GroupBox
    Friend WithEvents GBRisers As GroupBox
    Friend WithEvents GBAngles As GroupBox
    Friend WithEvents LblTopThickness As Label
    Friend WithEvents LblRiserAngle As Label
    Friend WithEvents LblHeight As Label
    Friend WithEvents TxtBxTopThickness As TextBox
    Friend WithEvents TxtBxRiserAngle As TextBox
    Friend WithEvents TxtBxHeight As TextBox
    Friend WithEvents RdoBtnDown As RadioButton
    Friend WithEvents RdoBtnFlush As RadioButton
    Friend WithEvents GBRunners As GroupBox
    Friend WithEvents LblBottomRiserRiseCap As Label
    Friend WithEvents LblTopRiserRiseCap As Label
    Friend WithEvents LblRisePerStepCap As Label
    Friend WithEvents TxtBxTreadThickness As TextBox
    Friend WithEvents TxtBxTreadDepth As TextBox
    Friend WithEvents TxtBxRunPerStep As TextBox
    Friend WithEvents LblFloorSpaceCap As Label
    Friend WithEvents LblNumStepsCap As Label
    Friend WithEvents LblNumOfRunnersCap As Label
    Friend WithEvents LblTreadThickness As Label
    Friend WithEvents LblTreadDepth As Label
    Friend WithEvents LblRunPerStep As Label
    Friend WithEvents LblStringerLengthCap As Label
    Friend WithEvents LblStringerWidthCap As Label
    Friend WithEvents LblTopCutCap As Label
    Friend WithEvents LblBottomCutCap As Label
    Friend WithEvents LblStairAngleCap As Label
    Friend WithEvents LblTreadWidthCap As Label
    Friend WithEvents LblTotalRise As Label
    Friend WithEvents LblNumRisers As Label
    Friend WithEvents LblNumRisersCap As Label
    Friend WithEvents LblTotalRiseCap As Label
    Friend WithEvents LblRisePerStep As Label
    Friend WithEvents LblTopRiserRise As Label
    Friend WithEvents LblBottomRiserRise As Label
    Friend WithEvents LblNumRunners As Label
    Friend WithEvents LblNumSteps As Label
    Friend WithEvents LblFloorSpace As Label
    Friend WithEvents LblStairAngle As Label
    Friend WithEvents LblTopCut As Label
    Friend WithEvents LblStringerWidth As Label
    Friend WithEvents LblTreadWidth As Label
    Friend WithEvents LblStringerLength As Label
    Friend WithEvents LblBottomCut As Label
    Friend WithEvents LblPeaksValleys As Label
    Friend WithEvents LblPeaksCap As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsJPEGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewIRCPDFFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblRunCutLengthCap As Label
    Friend WithEvents LblRunCutLength As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectPrinterAndPrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviewAndPrintDefaultPrinterToolStripMenuItem As ToolStripMenuItem
End Class
