<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProjection
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlMap1 = New System.Windows.Forms.Panel()
        Me.pnlMap2 = New System.Windows.Forms.Panel()
        Me.pnlMap3 = New System.Windows.Forms.Panel()
        Me.pnlMap4 = New System.Windows.Forms.Panel()
        Me.pnlMap5 = New System.Windows.Forms.Panel()
        Me.pnlMap6 = New System.Windows.Forms.Panel()
        Me.Map1 = New DotSpatial.Controls.Map()
        Me.Map2 = New DotSpatial.Controls.Map()
        Me.Map3 = New DotSpatial.Controls.Map()
        Me.Map4 = New DotSpatial.Controls.Map()
        Me.Map5 = New DotSpatial.Controls.Map()
        Me.Map6 = New DotSpatial.Controls.Map()
        Me.lblmap1Projection = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap1 = New System.Windows.Forms.Label()
        Me.lblmap1selectedinfo = New System.Windows.Forms.Label()
        Me.lblMap1SelectedArea = New System.Windows.Forms.Label()
        Me.lblmap1info = New System.Windows.Forms.Label()
        Me.lblmap1difference = New System.Windows.Forms.Label()
        Me.lblmap2Projection = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap2 = New System.Windows.Forms.Label()
        Me.lblmap2selectedinfo = New System.Windows.Forms.Label()
        Me.lblmap2assumption = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMap2SelectedArea = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap3 = New System.Windows.Forms.Label()
        Me.lblmap3selectedinfo = New System.Windows.Forms.Label()
        Me.lblmap3Projection = New System.Windows.Forms.Label()
        Me.lblmap2info = New System.Windows.Forms.Label()
        Me.lblmap2difference = New System.Windows.Forms.Label()
        Me.lblMap3SelectedArea = New System.Windows.Forms.Label()
        Me.lblmap6Projection = New System.Windows.Forms.Label()
        Me.lblmap6selectedinfo = New System.Windows.Forms.Label()
        Me.lblmap5info = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap6 = New System.Windows.Forms.Label()
        Me.lblMap6SelectedArea = New System.Windows.Forms.Label()
        Me.lblmap4info = New System.Windows.Forms.Label()
        Me.lblmap5selectedinfo = New System.Windows.Forms.Label()
        Me.lblmap5Projection = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap5 = New System.Windows.Forms.Label()
        Me.lblMap5SelectedArea = New System.Windows.Forms.Label()
        Me.lblmap4Projection = New System.Windows.Forms.Label()
        Me.lblmap4selectedinfo = New System.Windows.Forms.Label()
        Me.lblmap3info = New System.Windows.Forms.Label()
        Me.lbltotalAreaMap4 = New System.Windows.Forms.Label()
        Me.lblMap4SelectedArea = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmap3difference = New System.Windows.Forms.Label()
        Me.lblmap4difference = New System.Windows.Forms.Label()
        Me.lblmap5difference = New System.Windows.Forms.Label()
        Me.gbBasicOperations = New System.Windows.Forms.GroupBox()
        Me.gbAdvanceOperations = New System.Windows.Forms.GroupBox()
        Me.btnLoadShapefile = New System.Windows.Forms.Button()
        Me.btnGetTotalArea = New System.Windows.Forms.Button()
        Me.labelFieldName = New System.Windows.Forms.Label()
        Me.lblSelectedRegion = New System.Windows.Forms.Label()
        Me.cmbFieldName = New System.Windows.Forms.ComboBox()
        Me.cmbSelectedRegion = New System.Windows.Forms.ComboBox()
        Me.btnRegionArea = New System.Windows.Forms.Button()
        Me.btnCompareProjections = New System.Windows.Forms.Button()
        Me.pnlMap1.SuspendLayout()
        Me.pnlMap2.SuspendLayout()
        Me.pnlMap3.SuspendLayout()
        Me.pnlMap4.SuspendLayout()
        Me.pnlMap5.SuspendLayout()
        Me.pnlMap6.SuspendLayout()
        Me.gbBasicOperations.SuspendLayout()
        Me.gbAdvanceOperations.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMap1
        '
        Me.pnlMap1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap1.Controls.Add(Me.lblMap1SelectedArea)
        Me.pnlMap1.Controls.Add(Me.lblmap1difference)
        Me.pnlMap1.Controls.Add(Me.lblmap1info)
        Me.pnlMap1.Controls.Add(Me.lblmap1selectedinfo)
        Me.pnlMap1.Controls.Add(Me.lbltotalAreaMap1)
        Me.pnlMap1.Controls.Add(Me.lblmap1Projection)
        Me.pnlMap1.Controls.Add(Me.Map1)
        Me.pnlMap1.Location = New System.Drawing.Point(22, 130)
        Me.pnlMap1.Name = "pnlMap1"
        Me.pnlMap1.Size = New System.Drawing.Size(378, 272)
        Me.pnlMap1.TabIndex = 0
        '
        'pnlMap2
        '
        Me.pnlMap2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap2.Controls.Add(Me.lblMap2SelectedArea)
        Me.pnlMap2.Controls.Add(Me.Label11)
        Me.pnlMap2.Controls.Add(Me.Map2)
        Me.pnlMap2.Controls.Add(Me.lblmap2assumption)
        Me.pnlMap2.Controls.Add(Me.lblmap2Projection)
        Me.pnlMap2.Controls.Add(Me.lblmap2selectedinfo)
        Me.pnlMap2.Controls.Add(Me.lbltotalAreaMap2)
        Me.pnlMap2.Location = New System.Drawing.Point(412, 131)
        Me.pnlMap2.Name = "pnlMap2"
        Me.pnlMap2.Size = New System.Drawing.Size(406, 271)
        Me.pnlMap2.TabIndex = 1
        '
        'pnlMap3
        '
        Me.pnlMap3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap3.Controls.Add(Me.lblMap3SelectedArea)
        Me.pnlMap3.Controls.Add(Me.lblmap2difference)
        Me.pnlMap3.Controls.Add(Me.Map3)
        Me.pnlMap3.Controls.Add(Me.lbltotalAreaMap3)
        Me.pnlMap3.Controls.Add(Me.lblmap2info)
        Me.pnlMap3.Controls.Add(Me.lblmap3selectedinfo)
        Me.pnlMap3.Controls.Add(Me.lblmap3Projection)
        Me.pnlMap3.Location = New System.Drawing.Point(838, 132)
        Me.pnlMap3.Name = "pnlMap3"
        Me.pnlMap3.Size = New System.Drawing.Size(378, 270)
        Me.pnlMap3.TabIndex = 2
        '
        'pnlMap4
        '
        Me.pnlMap4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap4.Controls.Add(Me.lblMap4SelectedArea)
        Me.pnlMap4.Controls.Add(Me.lblmap3difference)
        Me.pnlMap4.Controls.Add(Me.Map4)
        Me.pnlMap4.Controls.Add(Me.lbltotalAreaMap4)
        Me.pnlMap4.Controls.Add(Me.lblmap4Projection)
        Me.pnlMap4.Controls.Add(Me.lblmap4selectedinfo)
        Me.pnlMap4.Controls.Add(Me.lblmap3info)
        Me.pnlMap4.Location = New System.Drawing.Point(20, 408)
        Me.pnlMap4.Name = "pnlMap4"
        Me.pnlMap4.Size = New System.Drawing.Size(375, 286)
        Me.pnlMap4.TabIndex = 3
        '
        'pnlMap5
        '
        Me.pnlMap5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap5.Controls.Add(Me.lblMap5SelectedArea)
        Me.pnlMap5.Controls.Add(Me.lblmap4difference)
        Me.pnlMap5.Controls.Add(Me.Map5)
        Me.pnlMap5.Controls.Add(Me.lbltotalAreaMap5)
        Me.pnlMap5.Controls.Add(Me.lblmap4info)
        Me.pnlMap5.Controls.Add(Me.lblmap5selectedinfo)
        Me.pnlMap5.Controls.Add(Me.lblmap5Projection)
        Me.pnlMap5.Location = New System.Drawing.Point(414, 410)
        Me.pnlMap5.Name = "pnlMap5"
        Me.pnlMap5.Size = New System.Drawing.Size(404, 284)
        Me.pnlMap5.TabIndex = 4
        '
        'pnlMap6
        '
        Me.pnlMap6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlMap6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMap6.Controls.Add(Me.lblMap6SelectedArea)
        Me.pnlMap6.Controls.Add(Me.lblmap5difference)
        Me.pnlMap6.Controls.Add(Me.Map6)
        Me.pnlMap6.Controls.Add(Me.lbltotalAreaMap6)
        Me.pnlMap6.Controls.Add(Me.lblmap6Projection)
        Me.pnlMap6.Controls.Add(Me.lblmap6selectedinfo)
        Me.pnlMap6.Controls.Add(Me.lblmap5info)
        Me.pnlMap6.Location = New System.Drawing.Point(838, 408)
        Me.pnlMap6.Name = "pnlMap6"
        Me.pnlMap6.Size = New System.Drawing.Size(378, 286)
        Me.pnlMap6.TabIndex = 5
        '
        'Map1
        '
        Me.Map1.AllowDrop = True
        Me.Map1.BackColor = System.Drawing.Color.White
        Me.Map1.CollectAfterDraw = False
        Me.Map1.CollisionDetection = False
        Me.Map1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map1.ExtendBuffer = False
        Me.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map1.IsBusy = False
        Me.Map1.IsZoomedToMaxExtent = False
        Me.Map1.Legend = Nothing
        Me.Map1.Location = New System.Drawing.Point(0, 0)
        Me.Map1.Name = "Map1"
        Me.Map1.ProgressHandler = Nothing
        Me.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map1.RedrawLayersWhileResizing = False
        Me.Map1.SelectionEnabled = True
        Me.Map1.Size = New System.Drawing.Size(374, 183)
        Me.Map1.TabIndex = 0
        Me.Map1.ZoomOutFartherThanMaxExtent = False
        '
        'Map2
        '
        Me.Map2.AllowDrop = True
        Me.Map2.BackColor = System.Drawing.Color.White
        Me.Map2.CollectAfterDraw = False
        Me.Map2.CollisionDetection = False
        Me.Map2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map2.ExtendBuffer = False
        Me.Map2.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map2.IsBusy = False
        Me.Map2.IsZoomedToMaxExtent = False
        Me.Map2.Legend = Nothing
        Me.Map2.Location = New System.Drawing.Point(0, 0)
        Me.Map2.Name = "Map2"
        Me.Map2.ProgressHandler = Nothing
        Me.Map2.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map2.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map2.RedrawLayersWhileResizing = False
        Me.Map2.SelectionEnabled = True
        Me.Map2.Size = New System.Drawing.Size(402, 182)
        Me.Map2.TabIndex = 0
        Me.Map2.ZoomOutFartherThanMaxExtent = False
        '
        'Map3
        '
        Me.Map3.AllowDrop = True
        Me.Map3.BackColor = System.Drawing.Color.White
        Me.Map3.CollectAfterDraw = False
        Me.Map3.CollisionDetection = False
        Me.Map3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map3.ExtendBuffer = False
        Me.Map3.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map3.IsBusy = False
        Me.Map3.IsZoomedToMaxExtent = False
        Me.Map3.Legend = Nothing
        Me.Map3.Location = New System.Drawing.Point(0, 0)
        Me.Map3.Name = "Map3"
        Me.Map3.ProgressHandler = Nothing
        Me.Map3.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map3.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map3.RedrawLayersWhileResizing = False
        Me.Map3.SelectionEnabled = True
        Me.Map3.Size = New System.Drawing.Size(374, 183)
        Me.Map3.TabIndex = 0
        Me.Map3.ZoomOutFartherThanMaxExtent = False
        '
        'Map4
        '
        Me.Map4.AllowDrop = True
        Me.Map4.BackColor = System.Drawing.Color.White
        Me.Map4.CollectAfterDraw = False
        Me.Map4.CollisionDetection = False
        Me.Map4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map4.ExtendBuffer = False
        Me.Map4.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map4.IsBusy = False
        Me.Map4.IsZoomedToMaxExtent = False
        Me.Map4.Legend = Nothing
        Me.Map4.Location = New System.Drawing.Point(0, 0)
        Me.Map4.Name = "Map4"
        Me.Map4.ProgressHandler = Nothing
        Me.Map4.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map4.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map4.RedrawLayersWhileResizing = False
        Me.Map4.SelectionEnabled = True
        Me.Map4.Size = New System.Drawing.Size(371, 176)
        Me.Map4.TabIndex = 0
        Me.Map4.ZoomOutFartherThanMaxExtent = False
        '
        'Map5
        '
        Me.Map5.AllowDrop = True
        Me.Map5.BackColor = System.Drawing.Color.White
        Me.Map5.CollectAfterDraw = False
        Me.Map5.CollisionDetection = False
        Me.Map5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map5.ExtendBuffer = False
        Me.Map5.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map5.IsBusy = False
        Me.Map5.IsZoomedToMaxExtent = False
        Me.Map5.Legend = Nothing
        Me.Map5.Location = New System.Drawing.Point(0, 0)
        Me.Map5.Name = "Map5"
        Me.Map5.ProgressHandler = Nothing
        Me.Map5.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map5.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map5.RedrawLayersWhileResizing = False
        Me.Map5.SelectionEnabled = True
        Me.Map5.Size = New System.Drawing.Size(400, 176)
        Me.Map5.TabIndex = 0
        Me.Map5.ZoomOutFartherThanMaxExtent = False
        '
        'Map6
        '
        Me.Map6.AllowDrop = True
        Me.Map6.BackColor = System.Drawing.Color.White
        Me.Map6.CollectAfterDraw = False
        Me.Map6.CollisionDetection = False
        Me.Map6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Map6.ExtendBuffer = False
        Me.Map6.FunctionMode = DotSpatial.Controls.FunctionMode.None
        Me.Map6.IsBusy = False
        Me.Map6.IsZoomedToMaxExtent = False
        Me.Map6.Legend = Nothing
        Me.Map6.Location = New System.Drawing.Point(0, 0)
        Me.Map6.Name = "Map6"
        Me.Map6.ProgressHandler = Nothing
        Me.Map6.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt
        Me.Map6.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt
        Me.Map6.RedrawLayersWhileResizing = False
        Me.Map6.SelectionEnabled = True
        Me.Map6.Size = New System.Drawing.Size(374, 176)
        Me.Map6.TabIndex = 0
        Me.Map6.ZoomOutFartherThanMaxExtent = False
        '
        'lblmap1Projection
        '
        Me.lblmap1Projection.AutoSize = True
        Me.lblmap1Projection.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblmap1Projection.Location = New System.Drawing.Point(3, 184)
        Me.lblmap1Projection.Name = "lblmap1Projection"
        Me.lblmap1Projection.Size = New System.Drawing.Size(245, 17)
        Me.lblmap1Projection.TabIndex = 1
        Me.lblmap1Projection.Text = "UtmNad1983.NAD1983UTMZone12N"
        '
        'lbltotalAreaMap1
        '
        Me.lbltotalAreaMap1.AutoSize = True
        Me.lbltotalAreaMap1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap1.Location = New System.Drawing.Point(2, 204)
        Me.lbltotalAreaMap1.Name = "lbltotalAreaMap1"
        Me.lbltotalAreaMap1.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap1.TabIndex = 1
        Me.lbltotalAreaMap1.Text = "Total Area"
        '
        'lblmap1selectedinfo
        '
        Me.lblmap1selectedinfo.AutoSize = True
        Me.lblmap1selectedinfo.Location = New System.Drawing.Point(3, 222)
        Me.lblmap1selectedinfo.Name = "lblmap1selectedinfo"
        Me.lblmap1selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap1selectedinfo.TabIndex = 1
        Me.lblmap1selectedinfo.Text = "Area of the selected region"
        Me.lblmap1selectedinfo.Visible = False
        '
        'lblMap1SelectedArea
        '
        Me.lblMap1SelectedArea.AutoSize = True
        Me.lblMap1SelectedArea.Location = New System.Drawing.Point(188, 222)
        Me.lblMap1SelectedArea.Name = "lblMap1SelectedArea"
        Me.lblMap1SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap1SelectedArea.TabIndex = 1
        Me.lblMap1SelectedArea.Text = "lblMap1SelectedArea"
        '
        'lblmap1info
        '
        Me.lblmap1info.AutoSize = True
        Me.lblmap1info.Location = New System.Drawing.Point(3, 243)
        Me.lblmap1info.Name = "lblmap1info"
        Me.lblmap1info.Size = New System.Drawing.Size(320, 17)
        Me.lblmap1info.TabIndex = 1
        Me.lblmap1info.Text = "Difference between current and default projection"
        Me.lblmap1info.Visible = False
        '
        'lblmap1difference
        '
        Me.lblmap1difference.AutoSize = True
        Me.lblmap1difference.Location = New System.Drawing.Point(320, 244)
        Me.lblmap1difference.Name = "lblmap1difference"
        Me.lblmap1difference.Size = New System.Drawing.Size(51, 17)
        Me.lblmap1difference.TabIndex = 1
        Me.lblmap1difference.Text = "Label1"
        '
        'lblmap2Projection
        '
        Me.lblmap2Projection.AutoSize = True
        Me.lblmap2Projection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblmap2Projection.Location = New System.Drawing.Point(5, 184)
        Me.lblmap2Projection.Name = "lblmap2Projection"
        Me.lblmap2Projection.Size = New System.Drawing.Size(325, 17)
        Me.lblmap2Projection.TabIndex = 1
        Me.lblmap2Projection.Text = "NorthAmerica.NorthAmericaAlbersEqualAreaConic"
        '
        'lbltotalAreaMap2
        '
        Me.lbltotalAreaMap2.AutoSize = True
        Me.lbltotalAreaMap2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap2.Location = New System.Drawing.Point(4, 225)
        Me.lbltotalAreaMap2.Name = "lbltotalAreaMap2"
        Me.lbltotalAreaMap2.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap2.TabIndex = 1
        Me.lbltotalAreaMap2.Text = "Total Area"
        '
        'lblmap2selectedinfo
        '
        Me.lblmap2selectedinfo.AutoSize = True
        Me.lblmap2selectedinfo.Location = New System.Drawing.Point(5, 243)
        Me.lblmap2selectedinfo.Name = "lblmap2selectedinfo"
        Me.lblmap2selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap2selectedinfo.TabIndex = 1
        Me.lblmap2selectedinfo.Text = "Area of the selected region"
        Me.lblmap2selectedinfo.Visible = False
        '
        'lblmap2assumption
        '
        Me.lblmap2assumption.AutoSize = True
        Me.lblmap2assumption.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmap2assumption.Location = New System.Drawing.Point(6, 204)
        Me.lblmap2assumption.Name = "lblmap2assumption"
        Me.lblmap2assumption.Size = New System.Drawing.Size(230, 17)
        Me.lblmap2assumption.TabIndex = 1
        Me.lblmap2assumption.Text = "Assumption: Default projection"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Label1"
        '
        'lblMap2SelectedArea
        '
        Me.lblMap2SelectedArea.AutoSize = True
        Me.lblMap2SelectedArea.Location = New System.Drawing.Point(190, 243)
        Me.lblMap2SelectedArea.Name = "lblMap2SelectedArea"
        Me.lblMap2SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap2SelectedArea.TabIndex = 1
        Me.lblMap2SelectedArea.Text = "lblMap2SelectedArea"
        '
        'lbltotalAreaMap3
        '
        Me.lbltotalAreaMap3.AutoSize = True
        Me.lbltotalAreaMap3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap3.Location = New System.Drawing.Point(5, 203)
        Me.lbltotalAreaMap3.Name = "lbltotalAreaMap3"
        Me.lbltotalAreaMap3.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap3.TabIndex = 1
        Me.lbltotalAreaMap3.Text = "Total Area"
        '
        'lblmap3selectedinfo
        '
        Me.lblmap3selectedinfo.AutoSize = True
        Me.lblmap3selectedinfo.Location = New System.Drawing.Point(6, 221)
        Me.lblmap3selectedinfo.Name = "lblmap3selectedinfo"
        Me.lblmap3selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap3selectedinfo.TabIndex = 1
        Me.lblmap3selectedinfo.Text = "Area of the selected region"
        Me.lblmap3selectedinfo.Visible = False
        '
        'lblmap3Projection
        '
        Me.lblmap3Projection.AutoSize = True
        Me.lblmap3Projection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblmap3Projection.Location = New System.Drawing.Point(6, 183)
        Me.lblmap3Projection.Name = "lblmap3Projection"
        Me.lblmap3Projection.Size = New System.Drawing.Size(348, 17)
        Me.lblmap3Projection.TabIndex = 1
        Me.lblmap3Projection.Text = "NorthAmerica.USAContiguousLambertConformalConic"
        '
        'lblmap2info
        '
        Me.lblmap2info.AutoSize = True
        Me.lblmap2info.Location = New System.Drawing.Point(6, 242)
        Me.lblmap2info.Name = "lblmap2info"
        Me.lblmap2info.Size = New System.Drawing.Size(320, 17)
        Me.lblmap2info.TabIndex = 1
        Me.lblmap2info.Text = "Difference between current and default projection"
        Me.lblmap2info.Visible = False
        '
        'lblmap2difference
        '
        Me.lblmap2difference.AutoSize = True
        Me.lblmap2difference.Location = New System.Drawing.Point(323, 242)
        Me.lblmap2difference.Name = "lblmap2difference"
        Me.lblmap2difference.Size = New System.Drawing.Size(51, 17)
        Me.lblmap2difference.TabIndex = 1
        Me.lblmap2difference.Text = "Label1"
        '
        'lblMap3SelectedArea
        '
        Me.lblMap3SelectedArea.AutoSize = True
        Me.lblMap3SelectedArea.Location = New System.Drawing.Point(191, 221)
        Me.lblMap3SelectedArea.Name = "lblMap3SelectedArea"
        Me.lblMap3SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap3SelectedArea.TabIndex = 1
        Me.lblMap3SelectedArea.Text = "lblMap3SelectedArea"
        '
        'lblmap6Projection
        '
        Me.lblmap6Projection.AutoSize = True
        Me.lblmap6Projection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblmap6Projection.Location = New System.Drawing.Point(6, 177)
        Me.lblmap6Projection.Name = "lblmap6Projection"
        Me.lblmap6Projection.Size = New System.Drawing.Size(377, 17)
        Me.lblmap6Projection.TabIndex = 1
        Me.lblmap6Projection.Text = "NorthAmerica.USAContiguousAlbersEqualAreaConicUSGS"
        '
        'lblmap6selectedinfo
        '
        Me.lblmap6selectedinfo.AutoSize = True
        Me.lblmap6selectedinfo.Location = New System.Drawing.Point(6, 215)
        Me.lblmap6selectedinfo.Name = "lblmap6selectedinfo"
        Me.lblmap6selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap6selectedinfo.TabIndex = 1
        Me.lblmap6selectedinfo.Text = "Area of the selected region"
        Me.lblmap6selectedinfo.Visible = False
        '
        'lblmap5info
        '
        Me.lblmap5info.AutoSize = True
        Me.lblmap5info.Location = New System.Drawing.Point(6, 236)
        Me.lblmap5info.Name = "lblmap5info"
        Me.lblmap5info.Size = New System.Drawing.Size(320, 17)
        Me.lblmap5info.TabIndex = 1
        Me.lblmap5info.Text = "Difference between current and default projection"
        Me.lblmap5info.Visible = False
        '
        'lbltotalAreaMap6
        '
        Me.lbltotalAreaMap6.AutoSize = True
        Me.lbltotalAreaMap6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap6.Location = New System.Drawing.Point(5, 197)
        Me.lbltotalAreaMap6.Name = "lbltotalAreaMap6"
        Me.lbltotalAreaMap6.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap6.TabIndex = 1
        Me.lbltotalAreaMap6.Text = "Total Area"
        '
        'lblMap6SelectedArea
        '
        Me.lblMap6SelectedArea.AutoSize = True
        Me.lblMap6SelectedArea.Location = New System.Drawing.Point(205, 215)
        Me.lblMap6SelectedArea.Name = "lblMap6SelectedArea"
        Me.lblMap6SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap6SelectedArea.TabIndex = 1
        Me.lblMap6SelectedArea.Text = "lblMap6SelectedArea"
        '
        'lblmap4info
        '
        Me.lblmap4info.AutoSize = True
        Me.lblmap4info.Location = New System.Drawing.Point(6, 236)
        Me.lblmap4info.Name = "lblmap4info"
        Me.lblmap4info.Size = New System.Drawing.Size(320, 17)
        Me.lblmap4info.TabIndex = 1
        Me.lblmap4info.Text = "Difference between current and default projection"
        Me.lblmap4info.Visible = False
        '
        'lblmap5selectedinfo
        '
        Me.lblmap5selectedinfo.AutoSize = True
        Me.lblmap5selectedinfo.Location = New System.Drawing.Point(6, 215)
        Me.lblmap5selectedinfo.Name = "lblmap5selectedinfo"
        Me.lblmap5selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap5selectedinfo.TabIndex = 1
        Me.lblmap5selectedinfo.Text = "Area of the selected region"
        Me.lblmap5selectedinfo.Visible = False
        '
        'lblmap5Projection
        '
        Me.lblmap5Projection.AutoSize = True
        Me.lblmap5Projection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblmap5Projection.Location = New System.Drawing.Point(6, 177)
        Me.lblmap5Projection.Name = "lblmap5Projection"
        Me.lblmap5Projection.Size = New System.Drawing.Size(239, 17)
        Me.lblmap5Projection.TabIndex = 1
        Me.lblmap5Projection.Text = "Polar.NorthPoleAzimuthalEquidistant"
        '
        'lbltotalAreaMap5
        '
        Me.lbltotalAreaMap5.AutoSize = True
        Me.lbltotalAreaMap5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap5.Location = New System.Drawing.Point(5, 197)
        Me.lbltotalAreaMap5.Name = "lbltotalAreaMap5"
        Me.lbltotalAreaMap5.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap5.TabIndex = 1
        Me.lbltotalAreaMap5.Text = "Total Area"
        '
        'lblMap5SelectedArea
        '
        Me.lblMap5SelectedArea.AutoSize = True
        Me.lblMap5SelectedArea.Location = New System.Drawing.Point(188, 215)
        Me.lblMap5SelectedArea.Name = "lblMap5SelectedArea"
        Me.lblMap5SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap5SelectedArea.TabIndex = 1
        Me.lblMap5SelectedArea.Text = "lblMap5SelectedArea"
        '
        'lblmap4Projection
        '
        Me.lblmap4Projection.AutoSize = True
        Me.lblmap4Projection.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblmap4Projection.Location = New System.Drawing.Point(4, 177)
        Me.lblmap4Projection.Name = "lblmap4Projection"
        Me.lblmap4Projection.Size = New System.Drawing.Size(212, 17)
        Me.lblmap4Projection.TabIndex = 1
        Me.lblmap4Projection.Text = "World.CylindricalEqualAreaworld"
        '
        'lblmap4selectedinfo
        '
        Me.lblmap4selectedinfo.AutoSize = True
        Me.lblmap4selectedinfo.Location = New System.Drawing.Point(4, 215)
        Me.lblmap4selectedinfo.Name = "lblmap4selectedinfo"
        Me.lblmap4selectedinfo.Size = New System.Drawing.Size(179, 17)
        Me.lblmap4selectedinfo.TabIndex = 1
        Me.lblmap4selectedinfo.Text = "Area of the selected region"
        Me.lblmap4selectedinfo.Visible = False
        '
        'lblmap3info
        '
        Me.lblmap3info.AutoSize = True
        Me.lblmap3info.Location = New System.Drawing.Point(4, 236)
        Me.lblmap3info.Name = "lblmap3info"
        Me.lblmap3info.Size = New System.Drawing.Size(320, 17)
        Me.lblmap3info.TabIndex = 1
        Me.lblmap3info.Text = "Difference between current and default projection"
        Me.lblmap3info.Visible = False
        '
        'lbltotalAreaMap4
        '
        Me.lbltotalAreaMap4.AutoSize = True
        Me.lbltotalAreaMap4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalAreaMap4.Location = New System.Drawing.Point(3, 197)
        Me.lbltotalAreaMap4.Name = "lbltotalAreaMap4"
        Me.lbltotalAreaMap4.Size = New System.Drawing.Size(84, 17)
        Me.lbltotalAreaMap4.TabIndex = 1
        Me.lbltotalAreaMap4.Text = "Total Area"
        '
        'lblMap4SelectedArea
        '
        Me.lblMap4SelectedArea.AutoSize = True
        Me.lblMap4SelectedArea.Location = New System.Drawing.Point(185, 215)
        Me.lblMap4SelectedArea.Name = "lblMap4SelectedArea"
        Me.lblMap4SelectedArea.Size = New System.Drawing.Size(142, 17)
        Me.lblMap4SelectedArea.TabIndex = 1
        Me.lblMap4SelectedArea.Text = "lblMap4SelectedArea"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Projection Explorer"
        '
        'lblmap3difference
        '
        Me.lblmap3difference.AutoSize = True
        Me.lblmap3difference.Location = New System.Drawing.Point(322, 236)
        Me.lblmap3difference.Name = "lblmap3difference"
        Me.lblmap3difference.Size = New System.Drawing.Size(51, 17)
        Me.lblmap3difference.TabIndex = 1
        Me.lblmap3difference.Text = "Label1"
        '
        'lblmap4difference
        '
        Me.lblmap4difference.AutoSize = True
        Me.lblmap4difference.Location = New System.Drawing.Point(332, 236)
        Me.lblmap4difference.Name = "lblmap4difference"
        Me.lblmap4difference.Size = New System.Drawing.Size(51, 17)
        Me.lblmap4difference.TabIndex = 1
        Me.lblmap4difference.Text = "Label1"
        '
        'lblmap5difference
        '
        Me.lblmap5difference.AutoSize = True
        Me.lblmap5difference.Location = New System.Drawing.Point(327, 238)
        Me.lblmap5difference.Name = "lblmap5difference"
        Me.lblmap5difference.Size = New System.Drawing.Size(51, 17)
        Me.lblmap5difference.TabIndex = 1
        Me.lblmap5difference.Text = "Label1"
        '
        'gbBasicOperations
        '
        Me.gbBasicOperations.Controls.Add(Me.btnGetTotalArea)
        Me.gbBasicOperations.Controls.Add(Me.btnLoadShapefile)
        Me.gbBasicOperations.Location = New System.Drawing.Point(16, 4)
        Me.gbBasicOperations.Name = "gbBasicOperations"
        Me.gbBasicOperations.Size = New System.Drawing.Size(200, 100)
        Me.gbBasicOperations.TabIndex = 7
        Me.gbBasicOperations.TabStop = False
        Me.gbBasicOperations.Text = "Basic Operations"
        '
        'gbAdvanceOperations
        '
        Me.gbAdvanceOperations.Controls.Add(Me.btnCompareProjections)
        Me.gbAdvanceOperations.Controls.Add(Me.btnRegionArea)
        Me.gbAdvanceOperations.Controls.Add(Me.cmbSelectedRegion)
        Me.gbAdvanceOperations.Controls.Add(Me.cmbFieldName)
        Me.gbAdvanceOperations.Controls.Add(Me.lblSelectedRegion)
        Me.gbAdvanceOperations.Controls.Add(Me.labelFieldName)
        Me.gbAdvanceOperations.Location = New System.Drawing.Point(931, 8)
        Me.gbAdvanceOperations.Name = "gbAdvanceOperations"
        Me.gbAdvanceOperations.Size = New System.Drawing.Size(281, 124)
        Me.gbAdvanceOperations.TabIndex = 7
        Me.gbAdvanceOperations.TabStop = False
        Me.gbAdvanceOperations.Text = "Advance Operations"
        '
        'btnLoadShapefile
        '
        Me.btnLoadShapefile.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadShapefile.Location = New System.Drawing.Point(38, 21)
        Me.btnLoadShapefile.Name = "btnLoadShapefile"
        Me.btnLoadShapefile.Size = New System.Drawing.Size(125, 40)
        Me.btnLoadShapefile.TabIndex = 0
        Me.btnLoadShapefile.Text = "Load Shapeflie"
        Me.btnLoadShapefile.UseVisualStyleBackColor = True
        '
        'btnGetTotalArea
        '
        Me.btnGetTotalArea.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetTotalArea.Location = New System.Drawing.Point(38, 62)
        Me.btnGetTotalArea.Name = "btnGetTotalArea"
        Me.btnGetTotalArea.Size = New System.Drawing.Size(125, 38)
        Me.btnGetTotalArea.TabIndex = 0
        Me.btnGetTotalArea.Text = "Get Total Area"
        Me.btnGetTotalArea.UseVisualStyleBackColor = True
        '
        'labelFieldName
        '
        Me.labelFieldName.AutoSize = True
        Me.labelFieldName.Location = New System.Drawing.Point(6, 26)
        Me.labelFieldName.Name = "labelFieldName"
        Me.labelFieldName.Size = New System.Drawing.Size(79, 17)
        Me.labelFieldName.TabIndex = 0
        Me.labelFieldName.Text = "Field Name"
        '
        'lblSelectedRegion
        '
        Me.lblSelectedRegion.AutoSize = True
        Me.lblSelectedRegion.Location = New System.Drawing.Point(6, 51)
        Me.lblSelectedRegion.Name = "lblSelectedRegion"
        Me.lblSelectedRegion.Size = New System.Drawing.Size(112, 17)
        Me.lblSelectedRegion.TabIndex = 0
        Me.lblSelectedRegion.Text = "Selected Region"
        '
        'cmbFieldName
        '
        Me.cmbFieldName.FormattingEnabled = True
        Me.cmbFieldName.Location = New System.Drawing.Point(142, 21)
        Me.cmbFieldName.Name = "cmbFieldName"
        Me.cmbFieldName.Size = New System.Drawing.Size(121, 24)
        Me.cmbFieldName.TabIndex = 1
        '
        'cmbSelectedRegion
        '
        Me.cmbSelectedRegion.FormattingEnabled = True
        Me.cmbSelectedRegion.Location = New System.Drawing.Point(142, 51)
        Me.cmbSelectedRegion.Name = "cmbSelectedRegion"
        Me.cmbSelectedRegion.Size = New System.Drawing.Size(121, 24)
        Me.cmbSelectedRegion.TabIndex = 1
        '
        'btnRegionArea
        '
        Me.btnRegionArea.Location = New System.Drawing.Point(9, 71)
        Me.btnRegionArea.Name = "btnRegionArea"
        Me.btnRegionArea.Size = New System.Drawing.Size(180, 25)
        Me.btnRegionArea.TabIndex = 2
        Me.btnRegionArea.Text = "Area of Selected Region"
        Me.btnRegionArea.UseVisualStyleBackColor = True
        '
        'btnCompareProjections
        '
        Me.btnCompareProjections.Location = New System.Drawing.Point(9, 100)
        Me.btnCompareProjections.Name = "btnCompareProjections"
        Me.btnCompareProjections.Size = New System.Drawing.Size(180, 25)
        Me.btnCompareProjections.TabIndex = 2
        Me.btnCompareProjections.Text = "Compare Projection"
        Me.btnCompareProjections.UseVisualStyleBackColor = True
        '
        'formProjection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 717)
        Me.Controls.Add(Me.gbAdvanceOperations)
        Me.Controls.Add(Me.gbBasicOperations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlMap6)
        Me.Controls.Add(Me.pnlMap5)
        Me.Controls.Add(Me.pnlMap4)
        Me.Controls.Add(Me.pnlMap3)
        Me.Controls.Add(Me.pnlMap2)
        Me.Controls.Add(Me.pnlMap1)
        Me.Name = "formProjection"
        Me.Text = "Projection"
        Me.pnlMap1.ResumeLayout(False)
        Me.pnlMap1.PerformLayout()
        Me.pnlMap2.ResumeLayout(False)
        Me.pnlMap2.PerformLayout()
        Me.pnlMap3.ResumeLayout(False)
        Me.pnlMap3.PerformLayout()
        Me.pnlMap4.ResumeLayout(False)
        Me.pnlMap4.PerformLayout()
        Me.pnlMap5.ResumeLayout(False)
        Me.pnlMap5.PerformLayout()
        Me.pnlMap6.ResumeLayout(False)
        Me.pnlMap6.PerformLayout()
        Me.gbBasicOperations.ResumeLayout(False)
        Me.gbAdvanceOperations.ResumeLayout(False)
        Me.gbAdvanceOperations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMap1 As Panel
    Friend WithEvents pnlMap2 As Panel
    Friend WithEvents pnlMap3 As Panel
    Friend WithEvents pnlMap4 As Panel
    Friend WithEvents pnlMap5 As Panel
    Friend WithEvents pnlMap6 As Panel
    Friend WithEvents Map1 As DotSpatial.Controls.Map
    Friend WithEvents Map2 As DotSpatial.Controls.Map
    Friend WithEvents Map3 As DotSpatial.Controls.Map
    Friend WithEvents Map4 As DotSpatial.Controls.Map
    Friend WithEvents Map5 As DotSpatial.Controls.Map
    Friend WithEvents Map6 As DotSpatial.Controls.Map
    Friend WithEvents lblMap1SelectedArea As Label
    Friend WithEvents lblmap1difference As Label
    Friend WithEvents lblmap1info As Label
    Friend WithEvents lblmap1selectedinfo As Label
    Friend WithEvents lbltotalAreaMap1 As Label
    Friend WithEvents lblmap1Projection As Label
    Friend WithEvents lblMap2SelectedArea As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblmap2assumption As Label
    Friend WithEvents lblmap2Projection As Label
    Friend WithEvents lblmap2selectedinfo As Label
    Friend WithEvents lbltotalAreaMap2 As Label
    Friend WithEvents lblMap3SelectedArea As Label
    Friend WithEvents lblmap2difference As Label
    Friend WithEvents lbltotalAreaMap3 As Label
    Friend WithEvents lblmap2info As Label
    Friend WithEvents lblmap3selectedinfo As Label
    Friend WithEvents lblmap3Projection As Label
    Friend WithEvents lblMap4SelectedArea As Label
    Friend WithEvents lbltotalAreaMap4 As Label
    Friend WithEvents lblmap4Projection As Label
    Friend WithEvents lblmap4selectedinfo As Label
    Friend WithEvents lblmap3info As Label
    Friend WithEvents lblMap5SelectedArea As Label
    Friend WithEvents lbltotalAreaMap5 As Label
    Friend WithEvents lblmap4info As Label
    Friend WithEvents lblmap5selectedinfo As Label
    Friend WithEvents lblmap5Projection As Label
    Friend WithEvents lblMap6SelectedArea As Label
    Friend WithEvents lbltotalAreaMap6 As Label
    Friend WithEvents lblmap6Projection As Label
    Friend WithEvents lblmap6selectedinfo As Label
    Friend WithEvents lblmap5info As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmap3difference As Label
    Friend WithEvents lblmap4difference As Label
    Friend WithEvents lblmap5difference As Label
    Friend WithEvents gbBasicOperations As GroupBox
    Friend WithEvents gbAdvanceOperations As GroupBox
    Friend WithEvents btnGetTotalArea As Button
    Friend WithEvents btnLoadShapefile As Button
    Friend WithEvents btnCompareProjections As Button
    Friend WithEvents btnRegionArea As Button
    Friend WithEvents cmbSelectedRegion As ComboBox
    Friend WithEvents cmbFieldName As ComboBox
    Friend WithEvents lblSelectedRegion As Label
    Friend WithEvents labelFieldName As Label
End Class
