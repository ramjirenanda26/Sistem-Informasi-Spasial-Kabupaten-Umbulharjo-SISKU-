Imports DotSpatial.Controls
Imports DotSpatial.Data
Imports DotSpatial.Symbology
Imports BruTile
Imports DotSpatial.Topology
Imports DotSpatial.Plugins.WebMap

Public Class formMainWindow

    Public AppPath As String = Application.ExecutablePath
    Public ResourcesPath As String = AppPath.ToUpper.Replace("\SISKU.EXE", "\resources")
    Public lyrFasilitas As MapPointLayer
    Public lyrJalan As MapLineLayer
    Public lyrAdmin As MapPolygonLayer
    Public iselect(,) As String
    Public iselectnumd As Integer = 0
    Public totalselected As Integer
    Public selectnext As String = "salah"
    Public fullextentclick As String = "salah"
    Public sedangload As Boolean = False
    Public newpoint As MapPointLayer
    Public newfeature As New FeatureSet(FeatureType.Point)


    Private Sub formMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sedangload = True

        'ADD Layer ADMINISTRASI
        lyrAdmin = Map1.Layers.Add(ResourcesPath & "\Database\Spasial\Batas_Desa_Kec_Umbulharjo.shp")
        lyrAdmin.LegendText = "Batas Administrasi"
        lyrAdmin.FeatureSet.AddFid()
        lyrAdmin.FeatureSet.Save()
        lyrAdmin.SelectionEnabled = False

        Dim schemeAdmin As New PolygonScheme
        schemeAdmin.EditorSettings.ClassificationType = ClassificationType.UniqueValues
        schemeAdmin.EditorSettings.UseGradient = False
        schemeAdmin.EditorSettings.FieldName = "desa_1"
        schemeAdmin.CreateCategories(lyrAdmin.DataSet.DataTable)

        For Each ifc As IFeatureCategory In schemeAdmin.GetCategories
            ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
        Next

        lyrAdmin.Symbology = schemeAdmin

        'ADD LAYER JARINGAN JALAN
        lyrJalan = Map1.Layers.Add(ResourcesPath & "\Database\Spasial\Jalan_Kec_Umbulharjo.shp")
        lyrJalan.LegendText = "Jaringan Jalan"
        lyrJalan.FeatureSet.AddFid()
        lyrJalan.FeatureSet.Save()
        lyrJalan.SelectionEnabled = False

        Dim schemeJalan As New LineScheme
        schemeJalan.ClearCategories()


        Dim symbolizerJalanArteri As New LineSymbolizer(Color.FromArgb(170, 0, 0), Color.DarkRed, 3, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)
        symbolizerJalanArteri.ScaleMode = ScaleMode.Simple
        Dim categoryJalanArteri As New LineCategory(symbolizerJalanArteri)
        categoryJalanArteri.FilterExpression = "[KETERANGAN] = 'Jalan Arteri/Utama'"
        categoryJalanArteri.LegendText = "Jalan Arteri"
        schemeJalan.AddCategory(categoryJalanArteri)


        Dim symbolizerLokal As New LineSymbolizer(Color.FromArgb(255, 200, 180), Color.Transparent, 1.5, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)

        symbolizerLokal.ScaleMode = ScaleMode.Simple
        Dim categoryLokal As New LineCategory(symbolizerLokal)
        categoryLokal.FilterExpression = "[KETERANGAN] = 'Jalan Kolektor'"
        categoryLokal.LegendText = "Jalan Lokal"
        schemeJalan.AddCategory(categoryLokal)


        Dim symbolizerLain As New LineSymbolizer(Color.FromArgb(255, 230, 200), Color.Transparent, 1, Drawing2D.DashStyle.Solid, Drawing2D.LineCap.Flat)

        symbolizerLain.ScaleMode = ScaleMode.Simple
        Dim categoryLain As New LineCategory(symbolizerLokal)
        categoryLain.FilterExpression = "[KETERANGAN] = 'Jalan Lokal'"
        categoryLain.LegendText = "Jalan Lain"
        schemeJalan.AddCategory(categoryLain)

        For Each ifc As IFeatureCategory In schemeJalan.GetCategories
            ifc.SetColor(Color.FromArgb(255, ifc.GetColor))
        Next

        lyrJalan.Symbology = schemeJalan


        'ADD LAYER FASILITAS
        lyrFasilitas = Map1.Layers.Add(ResourcesPath & "\Database\Spasial\intersect.shp")
        lyrFasilitas.LegendText = "Fasilitas"
        lyrFasilitas.FeatureSet.AddFid()
        lyrFasilitas.FeatureSet.Save()

        Dim schemeFasum As New PointScheme
        schemeFasum.ClearCategories()

        'Dim sym
        Dim imageFasum As Image = Image.FromFile(ResourcesPath & "\Database\Non-spasial\Icon\masjid.png", False)
        Dim symbolizerFasum As New PointSymbolizer(imageFasum, 20)
        symbolizerFasum.ScaleMode = ScaleMode.Simple
        Dim categoryFasum As New PointCategory(symbolizerFasum)
        categoryFasum.FilterExpression = "[KETERANGAN] = 'Masjid'"
        categoryFasum.LegendText = "Masjid"
        schemeFasum.AddCategory(categoryFasum)

        Dim imageGereja As Image = Image.FromFile(ResourcesPath & "\Database\Non-spasial\Icon\gereja.png", False)
        Dim symbolizerGereja As New PointSymbolizer(imageGereja, 20)
        symbolizerGereja.ScaleMode = ScaleMode.Simple
        Dim categoryGereja As New PointCategory(symbolizerGereja)
        categoryGereja.FilterExpression = "[KETERANGAN] = 'Gereja'"
        categoryGereja.LegendText = "Gereja"
        schemeFasum.AddCategory(categoryGereja)



        Dim imageKantor As Image = Image.FromFile(ResourcesPath & "\Database\Non-spasial\Icon\kantor pemerintahan.png", False)
        Dim symbolizerKantor As New PointSymbolizer(imageKantor, 20)
        symbolizerKantor.ScaleMode = ScaleMode.Simple
        Dim categoryKantor As New PointCategory(symbolizerKantor)
        categoryKantor.FilterExpression = "[KETERANGAN] = 'Kantor Camat'"
        categoryKantor.LegendText = "Kantor Camat"
        schemeFasum.AddCategory(categoryKantor)

        Dim imageSekolah As Image = Image.FromFile(ResourcesPath & "\Database\Non-spasial\Icon\sekolah.png", False)
        Dim symbolizerSekolah As New PointSymbolizer(imageSekolah, 20)
        symbolizerSekolah.ScaleMode = ScaleMode.Simple
        Dim categorySekolah As New PointCategory(symbolizerSekolah)
        categorySekolah.FilterExpression = "[KETERANGAN] = 'Sekolah'"
        categorySekolah.LegendText = "Sekolah"
        schemeFasum.AddCategory(categorySekolah)

        lyrFasilitas.Symbology = schemeFasum


        'ADD LAYER TEMPLATE
        newpoint = Map1.Layers.Add(newfeature)
        Dim pointttsymbol As New PointSymbolizer(Color.FromArgb(175, 75, 230, 0),
                                                 DotSpatial.Symbology.PointShape.Star, 12)
        newpoint.Symbolizer = pointttsymbol
        newpoint.LegendText = "point template"
        newpoint.LegendItemVisible = False

        'LOAD ATTRIBUTE
        Dim dt As DataTable
        dt = lyrFasilitas.DataSet.DataTable
        DataGridView1.DataSource = dt

        'LOAD DATA QUERY
        lyrAdmin.SelectAll()

        Dim ls1 As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAdmin.Selection

        ls1 = il1.ToFeatureList

        KryptonRibbonGroupComboBox_QueryKecamatan.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (ls1(i).DataRow.ItemArray.GetValue(0).ToString)
            KryptonRibbonGroupComboBox_QueryKecamatan.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBox_QueryKecamatan.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBox_QueryKecamatan.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBox_QueryKecamatan.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBox_QueryKecamatan.Items(j) = KryptonRibbonGroupComboBox_QueryKecamatan.Items(j - 1) Then
                    KryptonRibbonGroupComboBox_QueryKecamatan.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next

        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBox_QueryKecamatan.Sorted = True

        lyrAdmin.UnSelectAll()

        sedangload = False


    End Sub

    '    'POP UP
    Private Sub Map1_SelectionChanged(sender As Object, e As EventArgs) Handles Map1.SelectionChanged
        Try
            If sedangload = True Then Exit Sub
            If KryptonRibbonGroupButton_Identify.Checked = True Then
                If lyrFasilitas.Selection.Count = 0 Then
                    formPopUp.Map1.ClearLayers()
                    Call RemoveSelection()
                    Exit Sub
                Else
                    formPopUp.Show()
                    Call ShowPhoto()
                    formPopUp.BringToFront()
                    formPopUp.Activate()
                End If
            End If
        Catch ex As Exception
            MsgBox("Sorry dab, sesuk tak benakke meneh" & ex.ToString & ", Error Number (" & Err.Number & ") : " & vbCrLf & Err.Description, MsgBoxStyle.Critical, "SIM jaringan utilitas Kabupaten Sleman")
        End Try
    End Sub

    Public Sub RemoveSelection()
        Try
            sedangload = True

            formPopUp.txtJenisFasilitas.Text = ""
            formPopUp.txtFoto.Text = ""
            formPopUp.txtShapeIndex.Text = ""

            lyrAdmin.UnSelectAll()
            lyrFasilitas.UnSelectAll()

            formPopUp.Map1.ClearLayers()
            Me.Refresh()
            formPopUp.Refresh()

            sedangload = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ShowPhoto()
        Try
            Dim lsl As List(Of IFeature) = New List(Of IFeature)
            Dim il1 As ISelection = lyrFasilitas.Selection

            Dim dt As DataTable
            dt = lyrFasilitas.DataSet.DataTable

            Dim fasilitas As String = ""
            Dim foto As String = ""
            Dim shapeIndex As Integer = 0

            lsl = il1.ToFeatureList

            fasilitas = (lsl(0).DataRow.ItemArray.GetValue(3).ToString)
            foto = (lsl(0).DataRow.ItemArray.GetValue(4).ToString)
            shapeIndex = (lsl(0).DataRow.ItemArray.GetValue(dt.Columns.Count - 1))
            formPopUp.txtJenisFasilitas.Text = fasilitas
            formPopUp.txtFoto.Text = foto
            formPopUp.txtShapeIndex.Text = shapeIndex

            Dim alamatfoto As String = ResourcesPath & "\Database\Non-spasial\Foto\" & foto
            formPopUp.Map1.AddLayer(alamatfoto)

            If fasilitas = "" Then
                Call RemoveSelection()
                Exit Sub
            End If

            Map1.Refresh()
            Me.Refresh()
            formPopUp.Refresh()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'BUTTON
    Private Sub KryptonRibbonGroupButton_NormalMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_NormalMode.Click
        If KryptonRibbonGroupButton_NormalMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
            'KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked() = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked() = False
            KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked() = False
            KryptonRibbonGroupButton_Area.Checked() = False
            KryptonRibbonGroupButton_AddPoint.Checked() = False
            KryptonRibbonGroupButton_Identify.Checked() = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomInMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomInMode.Click
        If KryptonRibbonGroupButton_ZoomInMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
            KryptonRibbonGroupButton_NormalMode.Checked = False
            'KryptonRibbonGroupButton_ZoomInMode.Checked() = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked() = False
            KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked() = False
            KryptonRibbonGroupButton_Area.Checked() = False
            KryptonRibbonGroupButton_AddPoint.Checked() = False
            KryptonRibbonGroupButton_Identify.Checked() = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_ZoomOutMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ZoomOutMode.Click
        If KryptonRibbonGroupButton_ZoomOutMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked() = False
            'KryptonRibbonGroupButton_ZoomOutMode.Checked() = False
            KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked() = False
            KryptonRibbonGroupButton_Area.Checked() = False
            KryptonRibbonGroupButton_AddPoint.Checked() = False
            KryptonRibbonGroupButton_Identify.Checked() = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut
        End If
    End Sub
    Private Sub KryptonRibbonGroupButton_PanMode_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_PanMode.Click
        If KryptonRibbonGroupButton_PanMode.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            'KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_Identify_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Identify.Click
        If KryptonRibbonGroupButton_Identify.Checked = True Then
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Select
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked = False
            KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked = False
            KryptonRibbonGroupButton_Area.Checked = False
            KryptonRibbonGroupButton_AddPoint.Checked = False
            'KryptonRibbonGroupButton_Identify.Checked = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton_AddPoint_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_AddPoint.Click
        If KryptonRibbonGroupButton_AddPoint.Checked = True Then
            Map1.Cursor = Cursors.Cross
            formAddPoint.Show()
            formAddPoint.BringToFront()
            formAddPoint.Activate()
            KryptonRibbonGroupButton_NormalMode.Checked = False
            KryptonRibbonGroupButton_ZoomInMode.Checked() = False
            KryptonRibbonGroupButton_ZoomOutMode.Checked() = False
            KryptonRibbonGroupButton_PanMode.Checked() = False
            KryptonRibbonGroupButton_Length.Checked() = False
            KryptonRibbonGroupButton_Area.Checked() = False
            'KryptonRibbonGroupButton_AddPoint.Checked() = False
        Else
            KryptonRibbonGroupButton_NormalMode.Checked = True
            Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None

        End If
    End Sub

    Private Sub KryptonRibbonGroupButtonZoomIn_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButtonZoomIn.Click
        Map1.ZoomIn()
    End Sub

    Private Sub KryptonRibbonGroupButtonZoomOut_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButtonZoomOut.Click
        Map1.ZoomOut()
    End Sub

    Private Sub KryptonRibbonGroupButtonFullExtent_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButtonFullExtent.Click
        Map1.ZoomToMaxExtent()
    End Sub

    Private Sub KryptonRibbonGroupButton_Prev_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Prev.Click
        Map1.ZoomToPrevious()
    End Sub

    Private Sub KryptonRibbonGroupButton_Next_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Next.Click
        Map1.ZoomToNext()
    End Sub

    'QUERYYYY

    Private Sub KryptonRibbonGroupComboBox_QueryKecamatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBox_QueryKecamatan.SelectedIndexChanged
        If KryptonRibbonGroupComboBox_QueryKecamatan.Text = "Cari Kecamatan... " Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBox_QueryKecamatan.Text
        lyrAdmin.SelectByAttribute("[kcmtn] ='" & StrKecamatan & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        Dim lsl As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrAdmin.Selection

        lsl = il1.ToFeatureList

        KryptonRibbonGroupComboBox_QueryDesa.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (lsl(i).DataRow.ItemArray.GetValue(1).ToString)
            KryptonRibbonGroupComboBox_QueryDesa.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBox_QueryDesa.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBox_QueryDesa.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBox_QueryDesa.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBox_QueryDesa.Items(j) = KryptonRibbonGroupComboBox_QueryDesa.Items(j - 1) Then
                    KryptonRibbonGroupComboBox_QueryDesa.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

        KryptonRibbonGroupComboBox_QueryDesa.Sorted = True

        'lyrAdmin.UnSelectAll()

        sedangload = False
    End Sub

    Private Sub KryptonRibbonGroupComboBox_QueryDesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBox_QueryDesa.SelectedIndexChanged
        If KryptonRibbonGroupComboBox_QueryKecamatan.Text = "Cari Kecamatan... " Then Exit Sub
        If KryptonRibbonGroupComboBox_QueryDesa.Text = "Cari Desa... " Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBox_QueryKecamatan.Text
        Dim StrDesa As String = KryptonRibbonGroupComboBox_QueryDesa.Text
        lyrAdmin.SelectByAttribute("[kcmtn] = '" & StrKecamatan & "' AND [desa_1] = '" & StrDesa & "'")
        lyrAdmin.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        lyrFasilitas.SelectByAttribute("[KECAMATAN] = '" & StrKecamatan & "' AND [DESA] = '" & StrDesa & "'")
        Dim lsl As List(Of IFeature) = New List(Of IFeature)
        Dim il1 As ISelection = lyrFasilitas.Selection

        lsl = il1.ToFeatureList

        KryptonRibbonGroupComboBox_QueryAset.Items.Clear()
        Dim i As Integer = 0
        Do While (i < il1.Count)
            Dim Name As String = (lsl(i).DataRow.ItemArray.GetValue(3).ToString)
            KryptonRibbonGroupComboBox_QueryAset.Items.Insert(i, Name)
            i = (i + 1)
        Loop

        KryptonRibbonGroupComboBox_QueryAset.Sorted = True
        Dim cboNumber As Integer = KryptonRibbonGroupComboBox_QueryAset.Items.Count - 1
        Try
            For j = 1 To cboNumber
                If j > (KryptonRibbonGroupComboBox_QueryAset.Items.Count - 1) Then Exit For
                If KryptonRibbonGroupComboBox_QueryAset.Items(j) = KryptonRibbonGroupComboBox_QueryAset.Items(j - 1) Then
                    KryptonRibbonGroupComboBox_QueryAset.Items.RemoveAt(j)
                    j = j - 1
                    cboNumber = cboNumber - 1
                End If
            Next
        Catch ex As Exception
        End Try

    End Sub

    Private Sub KryptonRibbonGroupComboBox_QueryAset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KryptonRibbonGroupComboBox_QueryAset.SelectedIndexChanged
        If KryptonRibbonGroupComboBox_QueryKecamatan.Text = "Cari Kecamatan... " Then Exit Sub
        If KryptonRibbonGroupComboBox_QueryDesa.Text = "Cari Desa... " Then Exit Sub
        If KryptonRibbonGroupComboBox_QueryAset.Text = "Cari Fasilitas... " Then Exit Sub

        sedangload = True

        Dim StrKecamatan As String = KryptonRibbonGroupComboBox_QueryKecamatan.Text
        Dim StrDesa As String = KryptonRibbonGroupComboBox_QueryDesa.Text
        Dim StrAset As String = KryptonRibbonGroupComboBox_QueryAset.Text

        lyrFasilitas.SelectByAttribute("[KECAMATAN] = '" & StrKecamatan & "' AND [DESA] = '" & StrDesa & "'AND [KETERANGAN] = '" & StrAset & "'")
        lyrFasilitas.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()

        'lyrAdmin.UnSelectAll()

        sedangload = False
    End Sub

    'ATTRIBUTE
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        lyrFasilitas.Select(CInt(DataGridView1.SelectedRows.Item(0).Cells.Item("FID").Value))
        lyrFasilitas.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = False
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        sedangload = True
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        Map1.ClearSelection()
        For i = 0 To DataGridView1.SelectedRows.Count - 1
            lyrFasilitas.Select(CInt(DataGridView1.SelectedRows.Item(i).Cells.Item("FID").Value))
        Next
        lyrFasilitas.ZoomToSelectedFeatures(0.01, 0.01)
        Map1.Refresh()
        sedangload = True
    End Sub

    Private Sub Map1_MouseUp(sender As Object, e As MouseEventArgs) Handles Map1.MouseUp
        If KryptonRibbonGroupButton_AddPoint.Checked = True And Map1.Cursor = Cursors.Cross Then
            If formAddPoint.rdoTitik_Cursor.Checked = True Then
                If e.Button = MouseButtons.Left Then
                    sedangload = True
                    newpoint.SelectAll()
                    newpoint.RemoveSelectedFeatures()
                    Dim coord As Coordinate = New Coordinate(Map1.PixelToProj(e.Location))
                    Dim point As Point = New Point(coord)
                    Dim currentfeature As IFeature = newfeature.AddFeature(point)
                    formAddPoint.txtTitik_X.Text = coord.X
                    formAddPoint.txtTitik_Y.Text = coord.Y
                    sedangload = False
                End If

                newfeature.InitializeVertices()
                newpoint.DataSet.InitializeVertices()
                newpoint.AssignFastDrawnStates()
                newfeature.UpdateExtent()
                newpoint.DataSet.UpdateExtent()
                Map1.Refresh()
                Map1.ResetBuffer()

            End If

        End If
    End Sub

    Private Sub Map1_MouseMove(sender As Object, e As MouseEventArgs) Handles Map1.MouseMove
        Try
            Dim coord As Coordinate = Map1.PixelToProj(e.Location)
            lblXY.Text = String.Format("X: {0}, Y: {1}", coord.X, coord.Y)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub KryptonRibbonGroupButton_ExportMap_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ExportMap.Click
        Dim frm As New DotSpatial.Controls.LayoutForm
        frm.MapControl = Map1
        frm.Show()
    End Sub

    Private Sub KryptonRibbonGroupButton_ExportTable_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_ExportTable.Click
        Dim dt As DataTable
        If Map1.Layers.Count > 0 Then
            Dim stateLayer As MapPolygonLayer
            stateLayer = CType(Map1.Layers(0), MapPolygonLayer)
            If stateLayer Is Nothing Then
                MessageBox.Show("The layer is not a polygon layer.")
            Else
                dt = stateLayer.DataSet.DataTable
                ExportToExcel(dt)
            End If
        Else
            MessageBox.Show("Please add a layer to the map.")
        End If
    End Sub

    Public Sub ExportToExcel(ByVal objDT As DataTable)
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim strFilename As String
        Dim intCol, intRow As Integer
        'path for storing excel datasheet
        Dim strPath As String = "D:\"
        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If
        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()
                .cells(1, 1).value = "Attribute table" 'Heading of the excel file
                .cells(1, 1).EntireRow.Font.Bold = True
                'Add the column names from the attribute table to excel worksheet
                Dim intI As Integer = 1
                For intCol = 0 To objDT.Columns.Count - 1
                    .cells(2, intI).value = objDT.Columns(intCol).ColumnName
                    .cells(2, intI).EntireRow.Font.Bold = True
                    intI += 1
                Next
                'Add the data row values from the attribute table to ecxel worksheet
                intI = 3
                Dim intK As Integer = 1
                For intCol = 0 To objDT.Columns.Count - 1
                    intI = 3
                    For intRow = 0 To objDT.Rows.Count - 1
                        .Cells(intI, intK).Value = objDT.Rows(intRow).ItemArray(intCol)
                        intI += 1
                    Next
                    intK += 1
                Next
                If Mid$(strPath, strPath.Length, 1) <> "\" Then
                    strPath = strPath & "\"
                End If
                strFilename = strPath & "AttributeTable.xls"
                .ActiveCell.Worksheet.SaveAs(strFilename)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            MsgBox("Data's are exported to Excel Succesfully in '" & strFilename & "'", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' The excel is created and opened for insert value. We most close this excel using this system
        Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each i As Process In pro
            i.Kill()
        Next
    End Sub

    Private Sub KryptonRibbonGroupButton_Projection_Click(sender As Object, e As EventArgs) Handles KryptonRibbonGroupButton_Projection.Click
        formProjection.Show()
        formProjection.BringToFront()
        formProjection.Activate()
    End Sub

    Private Sub KryptonRibbon1_SelectedTabChanged(sender As Object, e As EventArgs) Handles KryptonRibbon1.SelectedTabChanged

    End Sub
End Class
